<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventarioStock
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
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.DataGridViewB = New System.Windows.Forms.DataGridView()
        Me.ButtonVM = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.TBxConsulta = New System.Windows.Forms.TextBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.White
        Me.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(724, 332)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(215, 41)
        Me.BtnActualizar.TabIndex = 3
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'DataGridViewB
        '
        Me.DataGridViewB.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewB.Location = New System.Drawing.Point(29, 23)
        Me.DataGridViewB.Name = "DataGridViewB"
        Me.DataGridViewB.ReadOnly = True
        Me.DataGridViewB.RowHeadersWidth = 51
        Me.DataGridViewB.RowTemplate.Height = 24
        Me.DataGridViewB.Size = New System.Drawing.Size(672, 419)
        Me.DataGridViewB.TabIndex = 2
        '
        'ButtonVM
        '
        Me.ButtonVM.BackColor = System.Drawing.Color.White
        Me.ButtonVM.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ButtonVM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ButtonVM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ButtonVM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVM.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVM.Location = New System.Drawing.Point(724, 401)
        Me.ButtonVM.Name = "ButtonVM"
        Me.ButtonVM.Size = New System.Drawing.Size(215, 41)
        Me.ButtonVM.TabIndex = 4
        Me.ButtonVM.Text = "Volver al menu"
        Me.ButtonVM.UseVisualStyleBackColor = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.BackColor = System.Drawing.Color.White
        Me.BtnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(724, 91)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(215, 41)
        Me.BtnConsultar.TabIndex = 5
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = False
        '
        'TBxConsulta
        '
        Me.TBxConsulta.Location = New System.Drawing.Point(723, 23)
        Me.TBxConsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxConsulta.Name = "TBxConsulta"
        Me.TBxConsulta.Size = New System.Drawing.Size(215, 22)
        Me.TBxConsulta.TabIndex = 74
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.White
        Me.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(724, 208)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(215, 41)
        Me.BtnModificar.TabIndex = 75
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'InventarioStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 466)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.TBxConsulta)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.ButtonVM)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.DataGridViewB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventarioStock"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InventarioStock"
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnActualizar As Button
    Friend WithEvents DataGridViewB As DataGridView
    Friend WithEvents ButtonVM As Button
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents TBxConsulta As TextBox
    Friend WithEvents BtnModificar As Button
End Class
