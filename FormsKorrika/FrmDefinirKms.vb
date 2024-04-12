Imports Entidades

Public Class FrmDefinirKms
    Private Sub FrmDefinirKms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDatosKorrika.Text = korrika.ToString
    End Sub

    Private Sub btnDefinirKm_Click(sender As Object, e As EventArgs) Handles btnDefinirKm.Click
        Dim msg As String = korrika.DefinirKm(txtNumKm.Text, txtDireccion.Text, txtLocalidad.Text, txtProvincia.Text)
        If msg <> "" Then
            MessageBox.Show(msg)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Close()
    End Sub
End Class