<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialDeCompra
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTiketsAbiertosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewB = New System.Windows.Forms.DataGridView()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TbxConsultarH = New System.Windows.Forms.TextBox()
        Me.BtnConsultarH = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeToolStripMenuItem, Me.FiltrosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1040, 31)
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
        Me.FiltrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeTiketsAbiertosToolStripMenuItem})
        Me.FiltrosToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrosToolStripMenuItem.Name = "FiltrosToolStripMenuItem"
        Me.FiltrosToolStripMenuItem.Size = New System.Drawing.Size(99, 27)
        Me.FiltrosToolStripMenuItem.Text = "Tecnico"
        '
        'ListadoDeTiketsAbiertosToolStripMenuItem
        '
        Me.ListadoDeTiketsAbiertosToolStripMenuItem.Name = "ListadoDeTiketsAbiertosToolStripMenuItem"
        Me.ListadoDeTiketsAbiertosToolStripMenuItem.Size = New System.Drawing.Size(156, 28)
        Me.ListadoDeTiketsAbiertosToolStripMenuItem.Text = "Tickets"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(110, 27)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(803, 398)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 39)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewB
        '
        Me.DataGridViewB.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewB.Location = New System.Drawing.Point(27, 52)
        Me.DataGridViewB.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewB.Name = "DataGridViewB"
        Me.DataGridViewB.ReadOnly = True
        Me.DataGridViewB.RowHeadersWidth = 51
        Me.DataGridViewB.Size = New System.Drawing.Size(758, 309)
        Me.DataGridViewB.TabIndex = 25
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.White
        Me.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(803, 183)
        Me.BtnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(224, 35)
        Me.BtnActualizar.TabIndex = 27
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TbxConsultarH
        '
        Me.TbxConsultarH.Location = New System.Drawing.Point(803, 53)
        Me.TbxConsultarH.Margin = New System.Windows.Forms.Padding(4)
        Me.TbxConsultarH.Name = "TbxConsultarH"
        Me.TbxConsultarH.Size = New System.Drawing.Size(224, 22)
        Me.TbxConsultarH.TabIndex = 82
        '
        'BtnConsultarH
        '
        Me.BtnConsultarH.BackColor = System.Drawing.Color.White
        Me.BtnConsultarH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnConsultarH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnConsultarH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnConsultarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarH.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarH.Location = New System.Drawing.Point(803, 111)
        Me.BtnConsultarH.Name = "BtnConsultarH"
        Me.BtnConsultarH.Size = New System.Drawing.Size(224, 41)
        Me.BtnConsultarH.TabIndex = 81
        Me.BtnConsultarH.Text = "Consultar"
        Me.BtnConsultarH.UseVisualStyleBackColor = False
        '
        'HistorialDeCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 450)
        Me.Controls.Add(Me.TbxConsultarH)
        Me.Controls.Add(Me.BtnConsultarH)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridViewB)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HistorialDeCompra"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HistorialDeCompra"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiltrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTiketsAbiertosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewB As DataGridView
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TbxConsultarH As TextBox
    Friend WithEvents BtnConsultarH As Button
End Class
