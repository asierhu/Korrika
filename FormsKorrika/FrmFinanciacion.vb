

Imports Entidades

Public Class FrmFinanciacion
    Private Sub FrmFinanciacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDatosKorrika.Text = korrika.ToString
        For Each provincia In korrika.Provincias
            cboProvincias.Items.Add(provincia)
        Next
        cboKmsProvincia.DisplayMember = ToString()
    End Sub

    Private Sub cboKmsProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKmsProvincia.SelectedIndexChanged
        Dim kmSelect As Kilometro = TryCast(cboKmsProvincia.SelectedItem, Kilometro)
        lblNumKm.Text = kmSelect.NumKm
        lblDireccion.Text = kmSelect.Direccion
        lblPueblo.Text = kmSelect.Localidad
    End Sub

    Private Sub cboProvincias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincias.SelectedIndexChanged
        cboKmsProvincia.Items.Clear()
        If korrika.KilometrosLibreProvincia(cboProvincias.SelectedItem).Count = 0 Then
            MessageBox.Show("Esta provincia no tiene kilometros")
            Exit Sub
        End If
        cboKmsProvincia.Items.AddRange(korrika.KilometrosLibreProvincia(cboProvincias.SelectedItem).ToArray)
    End Sub

    Private Sub btnFinanciarKm_Click(sender As Object, e As EventArgs) Handles btnFinanciarKm.Click
        Dim kmSelect As Kilometro = TryCast(cboKmsProvincia.SelectedItem, Kilometro)
        Dim msg As String = korrika.PatrocinarKilometro(kmSelect.NumKm, txtNombreOrganización.Text, txtEuros.Text)
        MessageBox.Show(msg)
        If msg.Contains("financia el kilómetro") Then
            cboProvincias_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Close()
    End Sub

    Private Sub btnTotalRecaudado_Click(sender As Object, e As EventArgs) Handles btnTotalRecaudado.Click
        MessageBox.Show($"El total recaudado ha sido {korrika.TotalRecaudado}")
    End Sub
End Class
