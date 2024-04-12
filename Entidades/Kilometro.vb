Public Class Kilometro
    Implements IEquatable(Of Kilometro)

    Public Property NumKm As Integer
    Public Property Direccion As String
    Public Property Localidad As String
    Public Property Provincia As String

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Kilometro))
    End Function
    Public Overloads Function Equals(other As Kilometro) As Boolean Implements IEquatable(Of Kilometro).Equals
        Return other IsNot Nothing AndAlso Me.NumKm = other.NumKm
    End Function
    Public Sub New(numKm As Integer)
        Me.NumKm = numKm
        Direccion = ""
        Localidad = ""
        Provincia = ""
    End Sub

    Public Sub New(numKm As Integer, direccion As String, localidad As String, provincia As String)
        Me.New(numKm)
        Me.Direccion = direccion
        Me.Localidad = localidad
        Me.Provincia = provincia
    End Sub

    Public Overrides Function ToString() As String
        Return $"{NumKm} '{Localidad}', inicia en {Direccion}, provnincia: {Provincia}"
    End Function
End Class
