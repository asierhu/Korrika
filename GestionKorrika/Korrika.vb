Imports System.IO
Imports Entidades

Public Class Korrika
' TODO: LA PRIMERA PARTE DE KORRIKA COMPARTIDA POR VARIOS GRUPOS EN CLASE, CON ERRORES 
    Public Property DatosGenerales As DatosGeneralesKorrika
    Private Property _Provincias As New List(Of String) From {"araba", "gipuzkoa", "nafarroa", "bizkaia", "zuberoa", "nafarra behera", "lapurdi"}
    Public ReadOnly Property Provincias ' todo Las propiedades tienen que ser de un tipo concreto (Así es Object) Esto con todas
        Get
            Return _Provincias.AsReadOnly
        End Get
    End Property
    Private Property _Kilometros As New List(Of Kilometro) ' todo Esto no puede ser una propiedad
    Public ReadOnly Property Kilometros
        Get
            Return _Kilometros.AsReadOnly
        End Get
    End Property
    Private Property _TotalRecaudado As Decimal
    Public ReadOnly Property TotalRecaudado ' todo Ahora no valía esta solución sino la que CORREGIMOS en clase
        Get
            Return _TotalRecaudado
        End Get
    End Property

    Private Sub TotalRecaudadoCalculo(euros As Decimal) ' todo Esto no vale
        _TotalRecaudado += euros
    End Sub
    Public Sub New(nKorrika As Byte, anyo As Integer, eslogan As String, fechaInicio As Date, fechaFin As Date, cantKms As Integer, ByRef mensajeError As String)
        Me.New(New DatosGeneralesKorrika(nKorrika, anyo, eslogan, fechaInicio, fechaFin, cantKms), mensajeError)

    End Sub
    Public Sub New(datosGeneralesKorrika As DatosGeneralesKorrika, ByRef mensajeError As String)
        DatosGenerales = datosGeneralesKorrika ' todo Lo lógico es que esto lo haga después
        CrearKilometros(DatosGenerales.CantKms)
        If File.Exists($"./Ficheros/Korrika{datosGeneralesKorrika.NKorrika}.txt") Then
            mensajeError = $"Ya existe la korrrika Korrika{datosGeneralesKorrika.NKorrika}"
            Exit Sub
        End If
        mensajeError = GuardarCambios()
        _Cambios = False
    End Sub
    Public Sub New(nKorrika As Integer, ByRef mensajeError As String)
        mensajeError = LeerKorrika(nKorrika)
    End Sub
    Private Sub CrearKilometros(cantKm)
        For i = 1 To cantKm
            _Kilometros.Add(New Kilometro(i))
        Next
    End Sub
    Public Overrides Function ToString() As String
        Return DatosGenerales.ToString
    End Function

    Public Function DefinirKm(numKm As Integer, direccion As String, localidad As String, provincia As String) As String
        Dim msg As String = DefinirKm(New Kilometro(numKm, direccion, localidad, provincia))
        Return msg
    End Function
    Public Function DefinirKm(kilometro As Kilometro) As String
        If kilometro Is Nothing Then
            Return "El kilometro no existe"
        End If
        If String.IsNullOrWhiteSpace(kilometro.Direccion) Then
            Return "La dirección no puede quedar vacia"
        End If
        If String.IsNullOrWhiteSpace(kilometro.Localidad) Then
            Return "La localidad no puede quedar vacia"
        End If
        If String.IsNullOrWhiteSpace(kilometro.Provincia) Then
            Return "La provincia no puede quedar vacia"
        End If
        If Not _Provincias.Contains(kilometro.Provincia.ToLower) Then
            Return $"No existe la provincia {kilometro.Provincia}"
        End If
        Dim posKm As Integer = _Kilometros.IndexOf(kilometro)
        If posKm = -1 Then
            Return $"No existe el kilometro {kilometro.NumKm}"
        End If
        For Each km In _Kilometros
            If kilometro.Direccion = km.Direccion AndAlso kilometro.Localidad = km.Localidad Then
                Return $"El kilómetro número {km.NumKm} ya c comienza en la dirección {km.Direccion} de {km.Provincia}"
            End If
        Next
        _Kilometros(posKm) = kilometro
        _Cambios = True
        Return ""
    End Function

    Public Function PatrocinarKilometro(numKm As Integer, organizacion As String, euros As Decimal) As String
        If euros <= 0 Then
            Return "Para patrocinar el kilometro tienes que aportar dinero"
        End If
        Dim posKm As Integer = _Kilometros.IndexOf(New Kilometro(numKm))
        If posKm = -1 Then
            Return $"No existe el kilometro {numKm}"
        End If
        Dim kmAux As KilometroFinanciado = TryCast(_Kilometros(posKm), KilometroFinanciado)
        If kmAux IsNot Nothing Then
            Return $"El kilómetro número {numKm} ya está financiado por { kmAux.Organizacion}"
        End If
        If String.IsNullOrWhiteSpace(organizacion) Then
            Return $"Tiene que haber una organizacion patrocinadora"
        End If
        Dim organizacionYaEstaba As Boolean = False
        Dim kmFinanciadosOrg As Integer
        For Each km In _Kilometros
            Dim kmKmFinanciado As KilometroFinanciado = TryCast(km, KilometroFinanciado)
            If kmKmFinanciado IsNot Nothing Then
                If kmKmFinanciado.Organizacion.ToLower = organizacion.ToLower Then
                    organizacionYaEstaba = True
                    kmFinanciadosOrg += 1
                End If
            End If
        Next
        _Kilometros(posKm) = New KilometroFinanciado(_Kilometros(posKm), organizacion, euros)
        TotalRecaudadoCalculo(euros)
        If organizacionYaEstaba Then
            Return $"La organización {organizacion} financia el kilómetro {numKm}, aunque ya había financiado otros {kmFinanciadosOrg} kilómetros"
        End If
        _Cambios = True
        Return $"La organización {organizacion} financia el kilómetro {numKm}"
    End Function
    Public Function KilometrosLibreProvincia(provincia As String) As List(Of Kilometro)
        If Not _Provincias.Contains(provincia) Then
            Return Nothing
        End If
        Dim kmLibres As New List(Of Kilometro)
        For Each km In _Kilometros
            If km.Provincia.ToLower = provincia.ToLower Then
                If TypeOf km IsNot KilometroFinanciado Then
                    kmLibres.Add(km)
                End If
            End If
        Next
        Return kmLibres
    End Function
    Private Function LeerKorrika(num As Integer) As String ' todo Nombre de parámetro (num) que no aclara el motivo del número
        Dim nombreFichero As String = $"./Ficheros/Korrika{num}.txt"
        If Not File.Exists(nombreFichero) Then
            Return $"La Korrika{num} no existe"
        End If
        Dim lineas() As String = File.ReadAllLines(nombreFichero)
        Dim datos() As String = lineas(0).Split("*")
        If Not datos.Length <= 6 Then
            Return "Los datos generales son incorrectos"
        End If
        Dim byteComprobar As Byte
        Dim anyoComp, numKmComp As Integer
        Byte.TryParse(datos(0), byteComprobar)
        Dim fechaIni As Date = $"#{datos(3)}#" ' todo No es lógica esta forma, ya que si no hay un dato válido provoca error de ejecución. Para esto tenemos el Date.TryParse
        Dim fechaFin As Date = $"#{datos(4)}#"
        Integer.TryParse(datos(1), anyoComp) ' todo ¿Y qué ocurre si no en un entero?
        Integer.TryParse(datos(5), numKmComp)
        Me.DatosGenerales = New DatosGeneralesKorrika(byteComprobar, anyoComp, datos(2), fechaIni, fechaFin, numKmComp)
        Dim kilometros As New List(Of Kilometro)
        For i = 1 To lineas.Length - 1
            datos = lineas(i).Split("*")
            Select Case datos.Length
                Case 1
                    kilometros.Add(New Kilometro(datos(0)))
                Case 4
                    kilometros.Add(New Kilometro(datos(0), datos(1), datos(2), datos(3)))
                Case 6
                    kilometros.Add(New KilometroFinanciado(New Kilometro(datos(0), datos(1), datos(2), datos(3)), datos(4), datos(5)))
            End Select
        Next
        Me._Kilometros = kilometros
        Return ""
    End Function
    Public Function GuardarCambios() As String
        Dim nombreFichero As String = $"./Ficheros/Korrika{DatosGenerales.NKorrika}.txt"
        Dim lineas As New List(Of String)
        lineas.Add($"{DatosGenerales.NKorrika}*{DatosGenerales.Anyo}*{DatosGenerales.Eslogan}*{DatosGenerales.FechaInicio}*{DatosGenerales.FechaFin}*{DatosGenerales.CantKms}")
        For Each km In _Kilometros
            If TypeOf km Is KilometroFinanciado Then
                Dim kmFin As KilometroFinanciado = TryCast(km, KilometroFinanciado)
                lineas.Add($"{kmFin.NumKm}*{kmFin.Direccion}*{kmFin.Localidad}*{kmFin.Provincia}*{kmFin.Organizacion}*{kmFin.Euros}")
            Else
                If km.Direccion = "" Then
                    lineas.Add(km.NumKm)
                Else
                    lineas.Add($"{km.NumKm}*{km.Direccion}*{km.Localidad}*{km.Provincia}")
                End If
            End If
        Next
        _Cambios = False
        Try
            File.WriteAllLines(nombreFichero, lineas.ToArray)
        Catch ex As Exception
            Return $"Tienes que ejecutar el formulario y crear la carpeta Ficheros" ' todo La clase no tiene porqué saber que es un formulario, ... Mensaje en todo caso: No existe la carpeta Ficheros
        End Try
        Return $"La korrika {DatosGenerales.NKorrika} se ha guardado"
    End Function
    Private Property _Cambios As Boolean ' todo ¡¡¡No puede ser una propiedad!!!
    Public ReadOnly Property Cambios ' todo Las propiedades tienen que ser de un tipo concreto (Así es Object)
        Get
            Return _Cambios
        End Get
    End Property

End Class
