<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultasIS
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
        Me.DataGridViewB = New System.Windows.Forms.DataGridView()
        Me.ButtonVolver = New System.Windows.Forms.Button()
        Me.ButtonConsultar4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewB
        '
        Me.DataGridViewB.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewB.Location = New System.Drawing.Point(33, 26)
        Me.DataGridViewB.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewB.Name = "DataGridViewB"
        Me.DataGridViewB.ReadOnly = True
        Me.DataGridViewB.RowHeadersWidth = 51
        Me.DataGridViewB.Size = New System.Drawing.Size(656, 374)
        Me.DataGridViewB.TabIndex = 55
        '
        'ButtonVolver
        '
        Me.ButtonVolver.BackColor = System.Drawing.Color.White
        Me.ButtonVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ButtonVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ButtonVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ButtonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVolver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVolver.Location = New System.Drawing.Point(33, 480)
        Me.ButtonVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonVolver.Name = "ButtonVolver"
        Me.ButtonVolver.Size = New System.Drawing.Size(656, 36)
        Me.ButtonVolver.TabIndex = 54
        Me.ButtonVolver.Text = "Volver"
        Me.ButtonVolver.UseVisualStyleBackColor = False
        '
        'ButtonConsultar4
        '
        Me.ButtonConsultar4.BackColor = System.Drawing.Color.White
        Me.ButtonConsultar4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ButtonConsultar4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ButtonConsultar4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ButtonConsultar4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConsultar4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultar4.Location = New System.Drawing.Point(33, 418)
        Me.ButtonConsultar4.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonConsultar4.Name = "ButtonConsultar4"
        Me.ButtonConsultar4.Size = New System.Drawing.Size(152, 36)
        Me.ButtonConsultar4.TabIndex = 53
        Me.ButtonConsultar4.Text = "Consultar"
        Me.ButtonConsultar4.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(207, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 23)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Inicio de sesion de usuarios"
        '
        'ConsultasIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(738, 552)
        Me.Controls.Add(Me.DataGridViewB)
        Me.Controls.Add(Me.ButtonVolver)
        Me.Controls.Add(Me.ButtonConsultar4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultasIS"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultasIS"
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewB As DataGridView
    Friend WithEvents ButtonVolver As Button
    Friend WithEvents ButtonConsultar4 As Button
    Friend WithEvents Label3 As Label
End Class
