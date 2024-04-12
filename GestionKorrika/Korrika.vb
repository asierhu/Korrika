Imports Entidades

Public Class Korrika
    Public Property DatosGenerales As DatosGeneralesKorrika
    Private Property _Provincias As New List(Of String) From {"araba", "gipuzkoa", "nafarroa", "bizkaia", "zuberoa", "nafarra behera", "lapurdi"}
    Public ReadOnly Property Provincias
        Get
            Return _Provincias.AsReadOnly
        End Get
    End Property
    Private Property _Kilometros As New List(Of Kilometro)
    Public ReadOnly Property Kilometros
        Get
            Return _Kilometros.AsReadOnly
        End Get
    End Property
    Private Property _TotalRecaudado As Decimal
    Public ReadOnly Property TotalRecaudado
        Get
            Return _TotalRecaudado
        End Get
    End Property

    Private Sub TotalRecaudadoCalculo(euros As Decimal)
        _TotalRecaudado += euros
    End Sub
    Public Sub New(nKorrika As Byte, anyo As Integer, eslogan As String, fechaInicio As Date, fechaFin As Date, cantKms As Integer)
        Me.New(New DatosGeneralesKorrika(nKorrika, anyo, eslogan, fechaInicio, fechaFin, cantKms))
    End Sub
    Public Sub New(datosGeneralesKorrika As DatosGeneralesKorrika)
        DatosGenerales = datosGeneralesKorrika
        CrearKilometros(DatosGenerales.CantKms)
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
End Class
