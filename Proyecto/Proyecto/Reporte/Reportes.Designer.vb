<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTiketsAbiertosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.TextBoxNa = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxCI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Asunto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxT = New System.Windows.Forms.TextBox()
        Me.TextBoxNCompleto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxMensaje = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeToolStripMenuItem, Me.FiltrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1248, 31)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InformeToolStripMenuItem
        '
        Me.InformeToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformeToolStripMenuItem.Name = "InformeToolStripMenuItem"
        Me.InformeToolStripMenuItem.Size = New System.Drawing.Size(76, 27)
        Me.InformeToolStripMenuItem.Text = "Filtros"
        '
        'FiltrosToolStripMenuItem
        '
        Me.FiltrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistorialDeComprasToolStripMenuItem, Me.ListadoDeTiketsAbiertosToolStripMenuItem})
        Me.FiltrosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrosToolStripMenuItem.Name = "FiltrosToolStripMenuItem"
        Me.FiltrosToolStripMenuItem.Size = New System.Drawing.Size(99, 27)
        Me.FiltrosToolStripMenuItem.Text = "Tecnico"
        '
        'HistorialDeComprasToolStripMenuItem
        '
        Me.HistorialDeComprasToolStripMenuItem.Name = "HistorialDeComprasToolStripMenuItem"
        Me.HistorialDeComprasToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.HistorialDeComprasToolStripMenuItem.Text = "Historico"
        '
        'ListadoDeTiketsAbiertosToolStripMenuItem
        '
        Me.ListadoDeTiketsAbiertosToolStripMenuItem.Name = "ListadoDeTiketsAbiertosToolStripMenuItem"
        Me.ListadoDeTiketsAbiertosToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.ListadoDeTiketsAbiertosToolStripMenuItem.Text = "Tickets"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1085, 325)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 40)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnReporte
        '
        Me.BtnReporte.BackColor = System.Drawing.Color.White
        Me.BtnReporte.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporte.Location = New System.Drawing.Point(30, 250)
        Me.BtnReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(262, 41)
        Me.BtnReporte.TabIndex = 22
        Me.BtnReporte.Text = "Enviar reporte"
        Me.BtnReporte.UseVisualStyleBackColor = False
        '
        'TextBoxNa
        '
        Me.TextBoxNa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNa.Location = New System.Drawing.Point(30, 97)
        Me.TextBoxNa.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNa.Name = "TextBoxNa"
        Me.TextBoxNa.Size = New System.Drawing.Size(262, 15)
        Me.TextBoxNa.TabIndex = 104
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCorreo.Location = New System.Drawing.Point(329, 97)
        Me.TextBoxCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(262, 15)
        Me.TextBoxCorreo.TabIndex = 106
        '
        'TextBoxCI
        '
        Me.TextBoxCI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCI.Location = New System.Drawing.Point(642, 97)
        Me.TextBoxCI.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCI.Name = "TextBoxCI"
        Me.TextBoxCI.Size = New System.Drawing.Size(262, 15)
        Me.TextBoxCI.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(26, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 23)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Nombre del archivo:"
        '
        'Asunto
        '
        Me.Asunto.AutoSize = True
        Me.Asunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Asunto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Asunto.ForeColor = System.Drawing.Color.LightGray
        Me.Asunto.Location = New System.Drawing.Point(26, 131)
        Me.Asunto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Asunto.Name = "Asunto"
        Me.Asunto.Size = New System.Drawing.Size(63, 23)
        Me.Asunto.TabIndex = 110
        Me.Asunto.Text = "Titulo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(325, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 23)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Correo electronico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(325, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Descripcion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGray
        Me.Label5.Location = New System.Drawing.Point(638, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 23)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Cedula:"
        '
        'TextBoxT
        '
        Me.TextBoxT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxT.Location = New System.Drawing.Point(30, 171)
        Me.TextBoxT.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxT.Name = "TextBoxT"
        Me.TextBoxT.Size = New System.Drawing.Size(262, 15)
        Me.TextBoxT.TabIndex = 105
        '
        'TextBoxNCompleto
        '
        Me.TextBoxNCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNCompleto.Location = New System.Drawing.Point(955, 97)
        Me.TextBoxNCompleto.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNCompleto.Name = "TextBoxNCompleto"
        Me.TextBoxNCompleto.Size = New System.Drawing.Size(262, 15)
        Me.TextBoxNCompleto.TabIndex = 114
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(947, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 23)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Nombre completo"
        '
        'TextBoxMensaje
        '
        Me.TextBoxMensaje.AcceptsTab = True
        Me.TextBoxMensaje.Location = New System.Drawing.Point(329, 171)
        Me.TextBoxMensaje.Name = "TextBoxMensaje"
        Me.TextBoxMensaje.Size = New System.Drawing.Size(888, 120)
        Me.TextBoxMensaje.TabIndex = 116
        Me.TextBoxMensaje.Text = ""
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1248, 378)
        Me.Controls.Add(Me.TextBoxMensaje)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNCompleto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Asunto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCI)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.TextBoxT)
        Me.Controls.Add(Me.TextBoxNa)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Reportes"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiltrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDeComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTiketsAbiertosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnReporte As Button
    Friend WithEvents TextBoxNa As TextBox
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents TextBoxCI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Asunto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxT As TextBox
    Friend WithEvents TextBoxNCompleto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxMensaje As RichTextBox
End Class
