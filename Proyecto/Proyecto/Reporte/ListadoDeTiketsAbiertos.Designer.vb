<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoDeTiketsAbiertos
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
        Me.BtnVolverR = New System.Windows.Forms.Button()
        Me.DataGridViewB = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewC = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnVolverA = New System.Windows.Forms.Button()
        Me.TBxConsulta = New System.Windows.Forms.TextBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.TbxConsultarA = New System.Windows.Forms.TextBox()
        Me.BtnConsultarA = New System.Windows.Forms.Button()
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnVolverR
        '
        Me.BtnVolverR.BackColor = System.Drawing.Color.White
        Me.BtnVolverR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnVolverR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnVolverR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnVolverR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolverR.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolverR.Location = New System.Drawing.Point(782, 656)
        Me.BtnVolverR.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVolverR.Name = "BtnVolverR"
        Me.BtnVolverR.Size = New System.Drawing.Size(265, 36)
        Me.BtnVolverR.TabIndex = 26
        Me.BtnVolverR.Text = "Volver"
        Me.BtnVolverR.UseVisualStyleBackColor = False
        '
        'DataGridViewB
        '
        Me.DataGridViewB.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewB.Location = New System.Drawing.Point(31, 66)
        Me.DataGridViewB.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewB.Name = "DataGridViewB"
        Me.DataGridViewB.ReadOnly = True
        Me.DataGridViewB.RowHeadersWidth = 51
        Me.DataGridViewB.Size = New System.Drawing.Size(743, 268)
        Me.DataGridViewB.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(31, 656)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(743, 36)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DataGridViewC
        '
        Me.DataGridViewC.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewC.Location = New System.Drawing.Point(31, 365)
        Me.DataGridViewC.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewC.Name = "DataGridViewC"
        Me.DataGridViewC.ReadOnly = True
        Me.DataGridViewC.RowHeadersWidth = 51
        Me.DataGridViewC.Size = New System.Drawing.Size(743, 268)
        Me.DataGridViewC.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tickets abiertos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(27, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Tickets cerrados"
        '
        'BtnVolverA
        '
        Me.BtnVolverA.BackColor = System.Drawing.Color.White
        Me.BtnVolverA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnVolverA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnVolverA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnVolverA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolverA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolverA.Location = New System.Drawing.Point(781, 656)
        Me.BtnVolverA.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnVolverA.Name = "BtnVolverA"
        Me.BtnVolverA.Size = New System.Drawing.Size(265, 36)
        Me.BtnVolverA.TabIndex = 31
        Me.BtnVolverA.Text = "Volver"
        Me.BtnVolverA.UseVisualStyleBackColor = False
        '
        'TBxConsulta
        '
        Me.TBxConsulta.Location = New System.Drawing.Point(782, 366)
        Me.TBxConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxConsulta.Name = "TBxConsulta"
        Me.TBxConsulta.Size = New System.Drawing.Size(264, 22)
        Me.TBxConsulta.TabIndex = 78
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.White
        Me.BtnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(782, 434)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(264, 41)
        Me.BtnConsultar.TabIndex = 77
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'TbxConsultarA
        '
        Me.TbxConsultarA.Location = New System.Drawing.Point(782, 66)
        Me.TbxConsultarA.Margin = New System.Windows.Forms.Padding(4)
        Me.TbxConsultarA.Name = "TbxConsultarA"
        Me.TbxConsultarA.Size = New System.Drawing.Size(264, 22)
        Me.TbxConsultarA.TabIndex = 80
        '
        'BtnConsultarA
        '
        Me.BtnConsultarA.BackColor = System.Drawing.Color.White
        Me.BtnConsultarA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnConsultarA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnConsultarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnConsultarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultarA.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarA.Location = New System.Drawing.Point(782, 134)
        Me.BtnConsultarA.Name = "BtnConsultarA"
        Me.BtnConsultarA.Size = New System.Drawing.Size(264, 41)
        Me.BtnConsultarA.TabIndex = 79
        Me.BtnConsultarA.Text = "Consultar"
        Me.BtnConsultarA.UseVisualStyleBackColor = False
        '
        'ListadoDeTiketsAbiertos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1059, 705)
        Me.Controls.Add(Me.TbxConsultarA)
        Me.Controls.Add(Me.BtnConsultarA)
        Me.Controls.Add(Me.TBxConsulta)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnVolverA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewC)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnVolverR)
        Me.Controls.Add(Me.DataGridViewB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ListadoDeTiketsAbiertos"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListadoDeTiketsAbiertos"
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnVolverR As Button
    Friend WithEvents DataGridViewB As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewC As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnVolverA As Button
    Friend WithEvents TBxConsulta As TextBox
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents TbxConsultarA As TextBox
    Friend WithEvents BtnConsultarA As Button
End Class
