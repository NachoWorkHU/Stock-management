<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.TextBoxCI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBCargo = New System.Windows.Forms.ComboBox()
        Me.TBxContraseña = New System.Windows.Forms.TextBox()
        Me.TBx2Nombre = New System.Windows.Forms.TextBox()
        Me.CBSector = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2Apellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackColor = System.Drawing.Color.White
        Me.ButtonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ButtonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ButtonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.Location = New System.Drawing.Point(38, 256)
        Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(908, 34)
        Me.ButtonGuardar.TabIndex = 0
        Me.ButtonGuardar.Text = "Ingresar usuarios"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'TextBoxCI
        '
        Me.TextBoxCI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCI.Location = New System.Drawing.Point(38, 107)
        Me.TextBoxCI.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCI.Multiline = True
        Me.TextBoxCI.Name = "TextBoxCI"
        Me.TextBoxCI.Size = New System.Drawing.Size(204, 24)
        Me.TextBoxCI.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(738, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 97
        Me.Label5.Text = "Sector:"
        Me.Label5.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(272, 152)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 23)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Segundo nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(34, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 23)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Cedula:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(43, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 23)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Primer nombre:"
        '
        'CBCargo
        '
        Me.CBCargo.FormattingEnabled = True
        Me.CBCargo.Items.AddRange(New Object() {"", "Administrador", "Reporte", "Tecnico"})
        Me.CBCargo.Location = New System.Drawing.Point(510, 107)
        Me.CBCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCargo.Name = "CBCargo"
        Me.CBCargo.Size = New System.Drawing.Size(204, 24)
        Me.CBCargo.TabIndex = 92
        '
        'TBxContraseña
        '
        Me.TBxContraseña.Location = New System.Drawing.Point(276, 107)
        Me.TBxContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxContraseña.Multiline = True
        Me.TBxContraseña.Name = "TBxContraseña"
        Me.TBxContraseña.Size = New System.Drawing.Size(204, 24)
        Me.TBxContraseña.TabIndex = 91
        '
        'TBx2Nombre
        '
        Me.TBx2Nombre.Location = New System.Drawing.Point(276, 187)
        Me.TBx2Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TBx2Nombre.Multiline = True
        Me.TBx2Nombre.Name = "TBx2Nombre"
        Me.TBx2Nombre.Size = New System.Drawing.Size(204, 23)
        Me.TBx2Nombre.TabIndex = 90
        '
        'CBSector
        '
        Me.CBSector.FormattingEnabled = True
        Me.CBSector.Items.AddRange(New Object() {"", "Taller", "Sala", "6T", "Salones", "Oficinas", "Profesores", "Tutoria", "Biblioteca"})
        Me.CBSector.Location = New System.Drawing.Point(742, 107)
        Me.CBSector.Margin = New System.Windows.Forms.Padding(4)
        Me.CBSector.Name = "CBSector"
        Me.CBSector.Size = New System.Drawing.Size(204, 24)
        Me.CBSector.TabIndex = 89
        Me.CBSector.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(506, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 23)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Cargo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.logo_impulso
        Me.PictureBox1.Location = New System.Drawing.Point(38, 333)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'ButtonMenu
        '
        Me.ButtonMenu.BackColor = System.Drawing.Color.White
        Me.ButtonMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ButtonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ButtonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenu.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMenu.Location = New System.Drawing.Point(781, 372)
        Me.ButtonMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(187, 36)
        Me.ButtonMenu.TabIndex = 86
        Me.ButtonMenu.Text = "Volver al menu"
        Me.ButtonMenu.UseVisualStyleBackColor = False
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(38, 187)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNombre.Multiline = True
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(204, 24)
        Me.TextBoxNombre.TabIndex = 98
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(510, 188)
        Me.TextBoxApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxApellido.Multiline = True
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(204, 23)
        Me.TextBoxApellido.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(272, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Contraseña"
        '
        'TextBox2Apellido
        '
        Me.TextBox2Apellido.Location = New System.Drawing.Point(742, 188)
        Me.TextBox2Apellido.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2Apellido.Multiline = True
        Me.TextBox2Apellido.Name = "TextBox2Apellido"
        Me.TextBox2Apellido.Size = New System.Drawing.Size(204, 23)
        Me.TextBox2Apellido.TabIndex = 101
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(735, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 23)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Segundo apellido:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGray
        Me.Label7.Location = New System.Drawing.Point(506, 152)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 23)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Primer apellido:"
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(981, 421)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2Apellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBCargo)
        Me.Controls.Add(Me.TBxContraseña)
        Me.Controls.Add(Me.TBx2Nombre)
        Me.Controls.Add(Me.CBSector)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.TextBoxCI)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Usuarios"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents TextBoxCI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBCargo As ComboBox
    Friend WithEvents TBxContraseña As TextBox
    Friend WithEvents TBx2Nombre As TextBox
    Friend WithEvents CBSector As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2Apellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
