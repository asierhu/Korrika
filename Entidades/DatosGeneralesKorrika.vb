Public Class DatosGeneralesKorrika
    Public Property NKorrika As Byte
    Public Property Anyo As Integer
    Public Property Eslogan As String
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property CantKms As Integer

    Public Sub New(nKorrika As Byte, anyo As Integer, eslogan As String, fechaInicio As Date, fechaFin As Date, cantKms As Integer)
        Me.NKorrika = nKorrika
        Me.Anyo = anyo
        Me.Eslogan = eslogan
        Me.FechaInicio = fechaInicio
        Me.FechaFin = fechaFin
        Me.CantKms = cantKms
    End Sub
    Public Overrides Function ToString() As String
        Return $"Korrika {NKorrika} '{Eslogan}', desde {FechaInicio} hasta {FechaFin} corriendo {CantKms} kilómetros."
    End Function
End Class
