<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinanciacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombreOrganización = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblPueblo = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEuros = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFinanciarKm = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboKmsProvincia = New System.Windows.Forms.ComboBox()
        Me.cboProvincias = New System.Windows.Forms.ComboBox()
        Me.lblNumKm = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnTotalRecaudado = New System.Windows.Forms.Button()
        Me.lblDatosKorrika = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNombreOrganización
        '
        Me.txtNombreOrganización.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombreOrganización.Location = New System.Drawing.Point(389, 327)
        Me.txtNombreOrganización.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtNombreOrganización.Name = "txtNombreOrganización"
        Me.txtNombreOrganización.Size = New System.Drawing.Size(423, 27)
        Me.txtNombreOrganización.TabIndex = 2
        Me.txtNombreOrganización.Text = "4v"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(791, 483)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(138, 35)
        Me.btnVolver.TabIndex = 34
        Me.btnVolver.Text = "&Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblPueblo
        '
        Me.lblPueblo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPueblo.Location = New System.Drawing.Point(1040, 273)
        Me.lblPueblo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPueblo.Name = "lblPueblo"
        Me.lblPueblo.Size = New System.Drawing.Size(279, 30)
        Me.lblPueblo.TabIndex = 39
        Me.lblPueblo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDireccion
        '
        Me.lblDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDireccion.Location = New System.Drawing.Point(1040, 224)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(347, 30)
        Me.lblDireccion.TabIndex = 38
        Me.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(858, 285)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Pueblo/Ciudad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(858, 224)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Dirección"
        '
        'txtEuros
        '
        Me.txtEuros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEuros.Location = New System.Drawing.Point(389, 387)
        Me.txtEuros.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtEuros.Name = "txtEuros"
        Me.txtEuros.Size = New System.Drawing.Size(86, 27)
        Me.txtEuros.TabIndex = 5
        Me.txtEuros.Text = "250"
        Me.txtEuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(132, 390)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Euros de patrocinio"
        '
        'btnFinanciarKm
        '
        Me.btnFinanciarKm.Location = New System.Drawing.Point(262, 483)
        Me.btnFinanciarKm.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnFinanciarKm.Name = "btnFinanciarKm"
        Me.btnFinanciarKm.Size = New System.Drawing.Size(138, 35)
        Me.btnFinanciarKm.TabIndex = 6
        Me.btnFinanciarKm.Text = "&Financiar km"
        Me.btnFinanciarKm.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(132, 327)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Nombre Organización"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 182)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Kms libres de la provincia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 112)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Provincias"
        '
        'cboKmsProvincia
        '
        Me.cboKmsProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKmsProvincia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKmsProvincia.FormattingEnabled = True
        Me.cboKmsProvincia.Location = New System.Drawing.Point(389, 179)
        Me.cboKmsProvincia.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.cboKmsProvincia.Name = "cboKmsProvincia"
        Me.cboKmsProvincia.Size = New System.Drawing.Size(447, 28)
        Me.cboKmsProvincia.TabIndex = 1
        '
        'cboProvincias
        '
        Me.cboProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvincias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboProvincias.FormattingEnabled = True
        Me.cboProvincias.Location = New System.Drawing.Point(389, 114)
        Me.cboProvincias.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.cboProvincias.Name = "cboProvincias"
        Me.cboProvincias.Size = New System.Drawing.Size(377, 28)
        Me.cboProvincias.TabIndex = 0
        '
        'lblNumKm
        '
        Me.lblNumKm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNumKm.Location = New System.Drawing.Point(1040, 172)
        Me.lblNumKm.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblNumKm.Name = "lblNumKm"
        Me.lblNumKm.Size = New System.Drawing.Size(58, 30)
        Me.lblNumKm.TabIndex = 41
        Me.lblNumKm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(858, 177)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 20)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Número de km"
        '
        'btnTotalRecaudado
        '
        Me.btnTotalRecaudado.Location = New System.Drawing.Point(504, 483)
        Me.btnTotalRecaudado.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnTotalRecaudado.Name = "btnTotalRecaudado"
        Me.btnTotalRecaudado.Size = New System.Drawing.Size(184, 35)
        Me.btnTotalRecaudado.TabIndex = 42
        Me.btnTotalRecaudado.Text = "&Total recaudado"
        Me.btnTotalRecaudado.UseVisualStyleBackColor = True
        '
        'lblDatosKorrika
        '
        Me.lblDatosKorrika.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDatosKorrika.Location = New System.Drawing.Point(370, 36)
        Me.lblDatosKorrika.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDatosKorrika.Name = "lblDatosKorrika"
        Me.lblDatosKorrika.Size = New System.Drawing.Size(613, 28)
        Me.lblDatosKorrika.TabIndex = 43
        Me.lblDatosKorrika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmFinanciacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1435, 578)
        Me.Controls.Add(Me.lblDatosKorrika)
        Me.Controls.Add(Me.btnTotalRecaudado)
        Me.Controls.Add(Me.lblNumKm)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNombreOrganización)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblPueblo)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEuros)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnFinanciarKm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboKmsProvincia)
        Me.Controls.Add(Me.cboProvincias)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmFinanciacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Korrika"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreOrganización As TextBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblPueblo As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEuros As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnFinanciarKm As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboKmsProvincia As ComboBox
    Friend WithEvents cboProvincias As ComboBox
    Friend WithEvents lblNumKm As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnTotalRecaudado As Button
    Friend WithEvents lblDatosKorrika As Label
End Class
