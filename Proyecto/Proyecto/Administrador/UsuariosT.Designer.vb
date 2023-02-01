<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsuariosT
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
        Me.DataGridViewB = New System.Windows.Forms.DataGridView()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TBxConsulta = New System.Windows.Forms.TextBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button1.Location = New System.Drawing.Point(863, 286)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 39)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewB
        '
        Me.DataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewB.Location = New System.Drawing.Point(13, 24)
        Me.DataGridViewB.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewB.Name = "DataGridViewB"
        Me.DataGridViewB.ReadOnly = True
        Me.DataGridViewB.RowHeadersWidth = 51
        Me.DataGridViewB.Size = New System.Drawing.Size(831, 301)
        Me.DataGridViewB.TabIndex = 24
        '
        'Actualizar
        '
        Me.Actualizar.BackColor = System.Drawing.Color.White
        Me.Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Actualizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Actualizar.Location = New System.Drawing.Point(863, 156)
        Me.Actualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(230, 40)
        Me.Actualizar.TabIndex = 26
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(863, 217)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 39)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TBxConsulta
        '
        Me.TBxConsulta.Location = New System.Drawing.Point(863, 24)
        Me.TBxConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxConsulta.Name = "TBxConsulta"
        Me.TBxConsulta.Size = New System.Drawing.Size(230, 22)
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
        Me.BtnConsultar.Location = New System.Drawing.Point(863, 92)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(230, 41)
        Me.BtnConsultar.TabIndex = 77
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'UsuariosT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1106, 348)
        Me.Controls.Add(Me.TBxConsulta)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridViewB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UsuariosT"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UsuariosT"
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewB As DataGridView
    Friend WithEvents Actualizar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TBxConsulta As TextBox
    Friend WithEvents BtnConsultar As Button
End Class
