<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCrearKorrika = New System.Windows.Forms.Button()
        Me.txtCantKms = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnyo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEslogan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaInicio = New System.Windows.Forms.TextBox()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.txtNumKorrika = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefinirKmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinanciarKmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FinalizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCrearKorrika
        '
        Me.btnCrearKorrika.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearKorrika.Location = New System.Drawing.Point(300, 437)
        Me.btnCrearKorrika.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrearKorrika.Name = "btnCrearKorrika"
        Me.btnCrearKorrika.Size = New System.Drawing.Size(184, 49)
        Me.btnCrearKorrika.TabIndex = 0
        Me.btnCrearKorrika.Text = "&Crear korrika"
        Me.btnCrearKorrika.UseVisualStyleBackColor = True
        '
        'txtCantKms
        '
        Me.txtCantKms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantKms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantKms.Location = New System.Drawing.Point(378, 350)
        Me.txtCantKms.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantKms.Name = "txtCantKms"
        Me.txtCantKms.Size = New System.Drawing.Size(56, 26)
        Me.txtCantKms.TabIndex = 1
        Me.txtCantKms.Text = "20"
        Me.txtCantKms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Año"
        '
        'txtAnyo
        '
        Me.txtAnyo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnyo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnyo.Location = New System.Drawing.Point(363, 114)
        Me.txtAnyo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAnyo.Name = "txtAnyo"
        Me.txtAnyo.Size = New System.Drawing.Size(56, 26)
        Me.txtAnyo.TabIndex = 3
        Me.txtAnyo.Text = "2024"
        Me.txtAnyo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Eslogan"
        '
        'txtEslogan
        '
        Me.txtEslogan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEslogan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEslogan.Location = New System.Drawing.Point(363, 172)
        Me.txtEslogan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEslogan.Name = "txtEslogan"
        Me.txtEslogan.Size = New System.Drawing.Size(211, 26)
        Me.txtEslogan.TabIndex = 5
        Me.txtEslogan.Text = "HARRO HERRI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha inicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(158, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(158, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad de kms"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaInicio.Location = New System.Drawing.Point(363, 234)
        Me.txtFechaInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(100, 26)
        Me.txtFechaInicio.TabIndex = 9
        Me.txtFechaInicio.Text = "14/03/2024"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaFin.Location = New System.Drawing.Point(363, 289)
        Me.txtFechaFin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(100, 26)
        Me.txtFechaFin.TabIndex = 10
        Me.txtFechaFin.Text = "25/03/2024"
        '
        'txtNumKorrika
        '
        Me.txtNumKorrika.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumKorrika.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNumKorrika.Location = New System.Drawing.Point(363, 64)
        Me.txtNumKorrika.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumKorrika.Name = "txtNumKorrika"
        Me.txtNumKorrika.Size = New System.Drawing.Size(56, 26)
        Me.txtNumKorrika.TabIndex = 12
        Me.txtNumKorrika.Text = "23"
        Me.txtNumKorrika.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(158, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nº de korrika"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(753, 28)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefinirKmToolStripMenuItem, Me.FinanciarKmToolStripMenuItem, Me.ToolStripMenuItem1, Me.FinalizarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'DefinirKmToolStripMenuItem
        '
        Me.DefinirKmToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DefinirKmToolStripMenuItem.Name = "DefinirKmToolStripMenuItem"
        Me.DefinirKmToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DefinirKmToolStripMenuItem.Text = "Definir km"
        '
        'FinanciarKmToolStripMenuItem
        '
        Me.FinanciarKmToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FinanciarKmToolStripMenuItem.Name = "FinanciarKmToolStripMenuItem"
        Me.FinanciarKmToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FinanciarKmToolStripMenuItem.Text = "Financiar Km"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(200, 6)
        '
        'FinalizarToolStripMenuItem
        '
        Me.FinalizarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FinalizarToolStripMenuItem.Name = "FinalizarToolStripMenuItem"
        Me.FinalizarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FinalizarToolStripMenuItem.Text = "Finalizar"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 554)
        Me.Controls.Add(Me.txtNumKorrika)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.txtFechaInicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEslogan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAnyo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantKms)
        Me.Controls.Add(Me.btnCrearKorrika)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Korrika"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCrearKorrika As Button
    Friend WithEvents txtCantKms As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAnyo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEslogan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFechaInicio As TextBox
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents txtNumKorrika As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefinirKmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinanciarKmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents FinalizarToolStripMenuItem As ToolStripMenuItem
End Class
