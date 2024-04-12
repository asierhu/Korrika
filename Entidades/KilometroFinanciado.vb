Public Class KilometroFinanciado
    Inherits Kilometro
    Public Property Organizacion As String
    Public Property Euros As Decimal
    Public Sub New(kilometro As Kilometro, organizacion As String, euros As Decimal)
        MyBase.New(kilometro.NumKm, kilometro.Direccion, kilometro.Localidad, kilometro.Provincia)
        Me.Organizacion = organizacion
        Me.Euros = euros
    End Sub
End Class
