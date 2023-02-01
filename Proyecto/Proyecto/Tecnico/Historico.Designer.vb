<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Historico
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
        Me.DataGridViewB = New System.Windows.Forms.DataGridView()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnVM = New System.Windows.Forms.Button()
        Me.TBxConsulta = New System.Windows.Forms.TextBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewB
        '
        Me.DataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewB.Location = New System.Drawing.Point(34, 30)
        Me.DataGridViewB.Name = "DataGridViewB"
        Me.DataGridViewB.ReadOnly = True
        Me.DataGridViewB.RowHeadersWidth = 51
        Me.DataGridViewB.RowTemplate.Height = 24
        Me.DataGridViewB.Size = New System.Drawing.Size(738, 342)
        Me.DataGridViewB.TabIndex = 0
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.White
        Me.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(805, 251)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(220, 44)
        Me.BtnActualizar.TabIndex = 1
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnVM
        '
        Me.BtnVM.BackColor = System.Drawing.Color.White
        Me.BtnVM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnVM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnVM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnVM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVM.Location = New System.Drawing.Point(805, 330)
        Me.BtnVM.Name = "BtnVM"
        Me.BtnVM.Size = New System.Drawing.Size(220, 42)
        Me.BtnVM.TabIndex = 2
        Me.BtnVM.Text = "Volver al menu"
        Me.BtnVM.UseVisualStyleBackColor = False
        '
        'TBxConsulta
        '
        Me.TBxConsulta.Location = New System.Drawing.Point(805, 30)
        Me.TBxConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxConsulta.Name = "TBxConsulta"
        Me.TBxConsulta.Size = New System.Drawing.Size(220, 22)
        Me.TBxConsulta.TabIndex = 76
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.White
        Me.BtnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(805, 98)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(220, 41)
        Me.BtnConsultar.TabIndex = 75
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'Historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1061, 400)
        Me.Controls.Add(Me.TBxConsulta)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.BtnVM)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.DataGridViewB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Historico"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historico"
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewB As DataGridView
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnVM As Button
    Friend WithEvents TBxConsulta As TextBox
    Friend WithEvents BtnConsultar As Button
End Class
