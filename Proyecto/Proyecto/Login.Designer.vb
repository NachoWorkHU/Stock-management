<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.TextBoxCI = New System.Windows.Forms.TextBox()
        Me.cbTipoDeUsuario = New System.Windows.Forms.ComboBox()
        Me.cbAreaAsignada = New System.Windows.Forms.ComboBox()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbArea = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxCIingresar = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCI
        '
        Me.TextBoxCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TextBoxCI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCI.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCI.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxCI.Location = New System.Drawing.Point(224, 239)
        Me.TextBoxCI.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCI.Name = "TextBoxCI"
        Me.TextBoxCI.Size = New System.Drawing.Size(408, 25)
        Me.TextBoxCI.TabIndex = 0
        '
        'cbTipoDeUsuario
        '
        Me.cbTipoDeUsuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbTipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDeUsuario.FormattingEnabled = True
        Me.cbTipoDeUsuario.Items.AddRange(New Object() {"Administrador", "Tecnico", "Reporte"})
        Me.cbTipoDeUsuario.Location = New System.Drawing.Point(224, 366)
        Me.cbTipoDeUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTipoDeUsuario.Name = "cbTipoDeUsuario"
        Me.cbTipoDeUsuario.Size = New System.Drawing.Size(408, 24)
        Me.cbTipoDeUsuario.TabIndex = 2
        '
        'cbAreaAsignada
        '
        Me.cbAreaAsignada.BackColor = System.Drawing.Color.White
        Me.cbAreaAsignada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAreaAsignada.FormattingEnabled = True
        Me.cbAreaAsignada.Items.AddRange(New Object() {"", "Taller", "Sala", "6T", "Salones", "Oficinas", "Profesores", "Tutoria"})
        Me.cbAreaAsignada.Location = New System.Drawing.Point(224, 426)
        Me.cbAreaAsignada.Margin = New System.Windows.Forms.Padding(4)
        Me.cbAreaAsignada.Name = "cbAreaAsignada"
        Me.cbAreaAsignada.Size = New System.Drawing.Size(408, 24)
        Me.cbAreaAsignada.TabIndex = 3
        Me.cbAreaAsignada.Visible = False
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BtnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIniciar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciar.ForeColor = System.Drawing.Color.LightGray
        Me.BtnIniciar.Location = New System.Drawing.Point(224, 484)
        Me.BtnIniciar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(408, 40)
        Me.BtnIniciar.TabIndex = 9
        Me.BtnIniciar.Text = "Iniciar sesion"
        Me.BtnIniciar.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(323, 545)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(215, 23)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Entrar como invitado"
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TextBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxContraseña.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContraseña.ForeColor = System.Drawing.Color.Silver
        Me.TextBoxContraseña.Location = New System.Drawing.Point(224, 302)
        Me.TextBoxContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxContraseña.Size = New System.Drawing.Size(408, 25)
        Me.TextBoxContraseña.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cedula:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 340)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tipo de usuario:"
        '
        'lbArea
        '
        Me.lbArea.AutoSize = True
        Me.lbArea.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbArea.Location = New System.Drawing.Point(220, 399)
        Me.lbArea.Name = "lbArea"
        Me.lbArea.Size = New System.Drawing.Size(162, 23)
        Me.lbArea.TabIndex = 17
        Me.lbArea.Text = "Area Asignada:"
        Me.lbArea.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(639, 306)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(164, 23)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Mostrar contraseña"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Proyecto.My.Resources.Resources.imageonline_co_whitebackgroundremoved
        Me.PictureBox4.Location = New System.Drawing.Point(758, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(70, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Proyecto.My.Resources.Resources.minimize_window
        Me.PictureBox3.Location = New System.Drawing.Point(682, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(70, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.Proyecto.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(-4, -3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(193, 595)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.logo_impulso
        Me.PictureBox1.Location = New System.Drawing.Point(360, 53)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 141)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(147, 12)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(31, 22)
        Me.TxtFecha.TabIndex = 21
        Me.TxtFecha.Visible = False
        '
        'TextBoxCIingresar
        '
        Me.TextBoxCIingresar.Location = New System.Drawing.Point(57, 73)
        Me.TextBoxCIingresar.Name = "TextBoxCIingresar"
        Me.TextBoxCIingresar.Size = New System.Drawing.Size(10, 22)
        Me.TextBoxCIingresar.TabIndex = 22
        Me.TextBoxCIingresar.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(829, 584)
        Me.Controls.Add(Me.TextBoxCIingresar)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lbArea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.cbAreaAsignada)
        Me.Controls.Add(Me.cbTipoDeUsuario)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.TextBoxCI)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCI As TextBox
    Friend WithEvents cbTipoDeUsuario As ComboBox
    Friend WithEvents cbAreaAsignada As ComboBox
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbArea As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TxtFecha As DateTimePicker
    Friend WithEvents TextBoxCIingresar As TextBox
End Class
