<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stock
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.TBxCodigo = New System.Windows.Forms.TextBox()
        Me.TBxDonador = New System.Windows.Forms.TextBox()
        Me.CBSector = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ComboBoxNombre = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(295, 128)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Sector:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightGray
        Me.Label8.Location = New System.Drawing.Point(530, 129)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 23)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Donador:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(66, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Codigo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(295, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Nombre:"
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.White
        Me.BtnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Location = New System.Drawing.Point(70, 240)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(667, 33)
        Me.BtnEnviar.TabIndex = 79
        Me.BtnEnviar.Text = "Ingresar Insumo"
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'CBEstado
        '
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"Reparando", "Ausente", "Funcionando", "Dañado"})
        Me.CBEstado.Location = New System.Drawing.Point(70, 168)
        Me.CBEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(204, 24)
        Me.CBEstado.TabIndex = 75
        '
        'TBxCodigo
        '
        Me.TBxCodigo.Location = New System.Drawing.Point(70, 88)
        Me.TBxCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxCodigo.Multiline = True
        Me.TBxCodigo.Name = "TBxCodigo"
        Me.TBxCodigo.Size = New System.Drawing.Size(204, 24)
        Me.TBxCodigo.TabIndex = 74
        '
        'TBxDonador
        '
        Me.TBxDonador.Location = New System.Drawing.Point(533, 168)
        Me.TBxDonador.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxDonador.Multiline = True
        Me.TBxDonador.Name = "TBxDonador"
        Me.TBxDonador.Size = New System.Drawing.Size(204, 23)
        Me.TBxDonador.TabIndex = 73
        '
        'CBSector
        '
        Me.CBSector.FormattingEnabled = True
        Me.CBSector.Items.AddRange(New Object() {"", "Biblioteca", "Taller", "Sala", "6To", "Salones", "Oficinas", "Profesores", "Tutoria"})
        Me.CBSector.Location = New System.Drawing.Point(299, 167)
        Me.CBSector.Margin = New System.Windows.Forms.Padding(4)
        Me.CBSector.Name = "CBSector"
        Me.CBSector.Size = New System.Drawing.Size(204, 24)
        Me.CBSector.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(66, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 23)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Estado:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.logo_impulso
        Me.PictureBox1.Location = New System.Drawing.Point(61, 314)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 70
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
        Me.ButtonMenu.Location = New System.Drawing.Point(550, 344)
        Me.ButtonMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(187, 36)
        Me.ButtonMenu.TabIndex = 69
        Me.ButtonMenu.Text = "Volver al menu"
        Me.ButtonMenu.UseVisualStyleBackColor = False
        '
        'ComboBoxNombre
        '
        Me.ComboBoxNombre.FormattingEnabled = True
        Me.ComboBoxNombre.Items.AddRange(New Object() {"Laptop", "Router", "Cargadores", "Monitores", "Impresoras", "Rack", "Switch", "Cpu", "Teclado", "Mouse", "Audifonos", "Server"})
        Me.ComboBoxNombre.Location = New System.Drawing.Point(299, 88)
        Me.ComboBoxNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxNombre.Name = "ComboBoxNombre"
        Me.ComboBoxNombre.Size = New System.Drawing.Size(204, 24)
        Me.ComboBoxNombre.TabIndex = 85
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 422)
        Me.Controls.Add(Me.ComboBoxNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.CBEstado)
        Me.Controls.Add(Me.TBxCodigo)
        Me.Controls.Add(Me.TBxDonador)
        Me.Controls.Add(Me.CBSector)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Stock"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents TBxCodigo As TextBox
    Friend WithEvents TBxDonador As TextBox
    Friend WithEvents CBSector As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents ComboBoxNombre As ComboBox
End Class
