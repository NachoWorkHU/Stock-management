<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Usuario
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
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnCrearU = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.BackColor = System.Drawing.Color.White
        Me.BtnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.Location = New System.Drawing.Point(352, 79)
        Me.BtnUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(180, 47)
        Me.BtnUsuarios.TabIndex = 0
        Me.BtnUsuarios.Text = "Usuarios"
        Me.BtnUsuarios.UseVisualStyleBackColor = False
        '
        'BtnCrearU
        '
        Me.BtnCrearU.BackColor = System.Drawing.Color.White
        Me.BtnCrearU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnCrearU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnCrearU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnCrearU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearU.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearU.Location = New System.Drawing.Point(77, 79)
        Me.BtnCrearU.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCrearU.Name = "BtnCrearU"
        Me.BtnCrearU.Size = New System.Drawing.Size(180, 47)
        Me.BtnCrearU.TabIndex = 1
        Me.BtnCrearU.Text = "Crear Usuarios"
        Me.BtnCrearU.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.White
        Me.BtnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Location = New System.Drawing.Point(482, 205)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(132, 33)
        Me.BtnVolver.TabIndex = 2
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'Menu_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(627, 251)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnCrearU)
        Me.Controls.Add(Me.BtnUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Menu_Usuario"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Usuario"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnCrearU As Button
    Friend WithEvents BtnVolver As Button
End Class
