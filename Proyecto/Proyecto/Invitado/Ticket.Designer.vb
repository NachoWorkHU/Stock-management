<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ticket
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBSector = New System.Windows.Forms.ComboBox()
        Me.TBxEmail = New System.Windows.Forms.TextBox()
        Me.TBxCodigo = New System.Windows.Forms.TextBox()
        Me.CBPrioridad = New System.Windows.Forms.ComboBox()
        Me.TBxMensaje = New System.Windows.Forms.TextBox()
        Me.TBxApellido = New System.Windows.Forms.TextBox()
        Me.TBxNombre = New System.Windows.Forms.TextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(550, 417)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 36)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Volver al menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.logo_impulso
        Me.PictureBox1.Location = New System.Drawing.Point(22, 387)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(515, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Apellido:"
        '
        'CBSector
        '
        Me.CBSector.FormattingEnabled = True
        Me.CBSector.Items.AddRange(New Object() {"Biblioteca", "Profesores", "Salas", "Salones", "6T", "Taller", "Tutoria"})
        Me.CBSector.Location = New System.Drawing.Point(55, 154)
        Me.CBSector.Margin = New System.Windows.Forms.Padding(4)
        Me.CBSector.Name = "CBSector"
        Me.CBSector.Size = New System.Drawing.Size(204, 24)
        Me.CBSector.TabIndex = 48
        '
        'TBxEmail
        '
        Me.TBxEmail.Location = New System.Drawing.Point(518, 154)
        Me.TBxEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxEmail.Multiline = True
        Me.TBxEmail.Name = "TBxEmail"
        Me.TBxEmail.Size = New System.Drawing.Size(204, 23)
        Me.TBxEmail.TabIndex = 50
        '
        'TBxCodigo
        '
        Me.TBxCodigo.Enabled = False
        Me.TBxCodigo.Location = New System.Drawing.Point(55, 74)
        Me.TBxCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxCodigo.Multiline = True
        Me.TBxCodigo.Name = "TBxCodigo"
        Me.TBxCodigo.Size = New System.Drawing.Size(204, 24)
        Me.TBxCodigo.TabIndex = 51
        '
        'CBPrioridad
        '
        Me.CBPrioridad.FormattingEnabled = True
        Me.CBPrioridad.Items.AddRange(New Object() {"Alta", "Media", "Baja"})
        Me.CBPrioridad.Location = New System.Drawing.Point(284, 154)
        Me.CBPrioridad.Margin = New System.Windows.Forms.Padding(4)
        Me.CBPrioridad.Name = "CBPrioridad"
        Me.CBPrioridad.Size = New System.Drawing.Size(204, 24)
        Me.CBPrioridad.TabIndex = 56
        '
        'TBxMensaje
        '
        Me.TBxMensaje.Location = New System.Drawing.Point(55, 209)
        Me.TBxMensaje.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxMensaje.Multiline = True
        Me.TBxMensaje.Name = "TBxMensaje"
        Me.TBxMensaje.Size = New System.Drawing.Size(667, 105)
        Me.TBxMensaje.TabIndex = 57
        '
        'TBxApellido
        '
        Me.TBxApellido.Location = New System.Drawing.Point(518, 74)
        Me.TBxApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxApellido.Multiline = True
        Me.TBxApellido.Name = "TBxApellido"
        Me.TBxApellido.Size = New System.Drawing.Size(204, 24)
        Me.TBxApellido.TabIndex = 60
        '
        'TBxNombre
        '
        Me.TBxNombre.Location = New System.Drawing.Point(284, 74)
        Me.TBxNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxNombre.Multiline = True
        Me.TBxNombre.Name = "TBxNombre"
        Me.TBxNombre.Size = New System.Drawing.Size(204, 24)
        Me.TBxNombre.TabIndex = 61
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.White
        Me.BtnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Location = New System.Drawing.Point(55, 334)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(667, 33)
        Me.BtnEnviar.TabIndex = 63
        Me.BtnEnviar.Text = "Enviar Ticket"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(280, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(51, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Codigo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGray
        Me.Label6.Location = New System.Drawing.Point(280, 115)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Prioridad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(515, 115)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 23)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(51, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Sector:"
        '
        'Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(750, 466)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.TBxNombre)
        Me.Controls.Add(Me.TBxApellido)
        Me.Controls.Add(Me.TBxMensaje)
        Me.Controls.Add(Me.CBPrioridad)
        Me.Controls.Add(Me.TBxCodigo)
        Me.Controls.Add(Me.TBxEmail)
        Me.Controls.Add(Me.CBSector)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ticket"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tickets "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBSector As ComboBox
    Friend WithEvents TBxEmail As TextBox
    Friend WithEvents TBxCodigo As TextBox
    Friend WithEvents CBPrioridad As ComboBox
    Friend WithEvents TBxMensaje As TextBox
    Friend WithEvents TBxApellido As TextBox
    Friend WithEvents TBxNombre As TextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
End Class
