<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTicket
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBNt = New System.Windows.Forms.ComboBox()
        Me.TBxSolucion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCI = New System.Windows.Forms.TextBox()
        Me.BtnGerrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewB = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(20, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Solucion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(20, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 23)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Cedula:"
        '
        'CBNt
        '
        Me.CBNt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNt.FormattingEnabled = True
        Me.CBNt.Items.AddRange(New Object() {"", "Administrador", "Reporte", "Tecnico"})
        Me.CBNt.Location = New System.Drawing.Point(278, 60)
        Me.CBNt.Margin = New System.Windows.Forms.Padding(4)
        Me.CBNt.Name = "CBNt"
        Me.CBNt.Size = New System.Drawing.Size(204, 24)
        Me.CBNt.TabIndex = 106
        '
        'TBxSolucion
        '
        Me.TBxSolucion.Location = New System.Drawing.Point(24, 145)
        Me.TBxSolucion.Margin = New System.Windows.Forms.Padding(4)
        Me.TBxSolucion.Multiline = True
        Me.TBxSolucion.Name = "TBxSolucion"
        Me.TBxSolucion.Size = New System.Drawing.Size(458, 147)
        Me.TBxSolucion.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightGray
        Me.Label4.Location = New System.Drawing.Point(274, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 23)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Nro Ticket:"
        '
        'TextBoxCI
        '
        Me.TextBoxCI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCI.Location = New System.Drawing.Point(24, 60)
        Me.TextBoxCI.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCI.Multiline = True
        Me.TextBoxCI.Name = "TextBoxCI"
        Me.TextBoxCI.Size = New System.Drawing.Size(204, 24)
        Me.TextBoxCI.TabIndex = 103
        '
        'BtnGerrar
        '
        Me.BtnGerrar.BackColor = System.Drawing.Color.White
        Me.BtnGerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnGerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnGerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.BtnGerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGerrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGerrar.Location = New System.Drawing.Point(24, 308)
        Me.BtnGerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGerrar.Name = "BtnGerrar"
        Me.BtnGerrar.Size = New System.Drawing.Size(458, 34)
        Me.BtnGerrar.TabIndex = 111
        Me.BtnGerrar.Text = "Cerrar ticket"
        Me.BtnGerrar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(897, 308)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 35)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridViewB
        '
        Me.DataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewB.Location = New System.Drawing.Point(505, 59)
        Me.DataGridViewB.Name = "DataGridViewB"
        Me.DataGridViewB.ReadOnly = True
        Me.DataGridViewB.RowHeadersWidth = 51
        Me.DataGridViewB.RowTemplate.Height = 24
        Me.DataGridViewB.Size = New System.Drawing.Size(622, 233)
        Me.DataGridViewB.TabIndex = 113
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(505, 309)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(371, 34)
        Me.Button2.TabIndex = 114
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(501, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "Tickets"
        '
        'CTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1147, 362)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridViewB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnGerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBNt)
        Me.Controls.Add(Me.TBxSolucion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxCI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CTicket"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CTicket"
        CType(Me.DataGridViewB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBNt As ComboBox
    Friend WithEvents TBxSolucion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCI As TextBox
    Friend WithEvents BtnGerrar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewB As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
