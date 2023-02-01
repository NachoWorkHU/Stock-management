<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuDeAcceso
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
        Me.InformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTiketsAbiertosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnVLogin = New System.Windows.Forms.Button()
        Me.BtnVolverMA = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InformeToolStripMenuItem
        '
        Me.InformeToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformeToolStripMenuItem.Name = "InformeToolStripMenuItem"
        Me.InformeToolStripMenuItem.Size = New System.Drawing.Size(76, 27)
        Me.InformeToolStripMenuItem.Text = "Filtros"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(110, 27)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
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
        Me.HistorialDeComprasToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.HistorialDeComprasToolStripMenuItem.Text = "Historico"
        '
        'ListadoDeTiketsAbiertosToolStripMenuItem
        '
        Me.ListadoDeTiketsAbiertosToolStripMenuItem.Name = "ListadoDeTiketsAbiertosToolStripMenuItem"
        Me.ListadoDeTiketsAbiertosToolStripMenuItem.Size = New System.Drawing.Size(174, 28)
        Me.ListadoDeTiketsAbiertosToolStripMenuItem.Text = "Tickets"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.FiltrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.logo_impulso
        Me.PictureBox1.Location = New System.Drawing.Point(13, 301)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BtnVLogin
        '
        Me.BtnVLogin.BackColor = System.Drawing.Color.White
        Me.BtnVLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnVLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnVLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnVLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVLogin.Location = New System.Drawing.Point(441, 358)
        Me.BtnVLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVLogin.Name = "BtnVLogin"
        Me.BtnVLogin.Size = New System.Drawing.Size(201, 35)
        Me.BtnVLogin.TabIndex = 16
        Me.BtnVLogin.Text = "Cerrar sesion"
        Me.BtnVLogin.UseVisualStyleBackColor = False
        Me.BtnVLogin.Visible = False
        '
        'BtnVolverMA
        '
        Me.BtnVolverMA.BackColor = System.Drawing.Color.White
        Me.BtnVolverMA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnVolverMA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnVolverMA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnVolverMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolverMA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolverMA.Location = New System.Drawing.Point(88, 358)
        Me.BtnVolverMA.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVolverMA.Name = "BtnVolverMA"
        Me.BtnVolverMA.Size = New System.Drawing.Size(135, 35)
        Me.BtnVolverMA.TabIndex = 17
        Me.BtnVolverMA.Text = "Volver"
        Me.BtnVolverMA.UseVisualStyleBackColor = False
        Me.BtnVolverMA.Visible = False
        '
        'MenuDeAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(655, 406)
        Me.Controls.Add(Me.BtnVolverMA)
        Me.Controls.Add(Me.BtnVLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuDeAcceso"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu de acceso - Reporte"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiltrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialDeComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTiketsAbiertosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnVLogin As Button
    Friend WithEvents BtnVolverMA As Button
End Class
