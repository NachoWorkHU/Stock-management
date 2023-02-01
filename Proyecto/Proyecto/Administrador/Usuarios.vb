Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim ValidacionCi As New Usuario
        Dim CI As String = TextBoxCI.Text
        Dim Contraseña As String = TBxContraseña.Text
        Dim Cargo As String = CBCargo.Text
        Dim Area As String = CBSector.Text
        Dim Pnombre As String = TextBoxNombre.Text
        Dim Snombre As String = TBx2Nombre.Text
        Dim Papellido As String = TextBoxApellido.Text
        Dim Sapellido As String = TextBox2Apellido.Text

        Dim Alta As New Usuario
        ValidacionCi.validarCI(CI)
        If ValidacionCi.validarCI(CI) Then
            Alta.AltaUsuario(CI, Contraseña, Cargo, Area, Pnombre, Snombre, Papellido, Sapellido)

        Else
            MsgBox("Cedula incorrecta")
        End If

    End Sub



    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Dim VV As New Usuario
        Me.Visible = False
        Menu_Usuario.Show()
        VV.VaciarCampos()
    End Sub

    Private Sub CBCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCargo.SelectedIndexChanged
        If CBCargo.Text = "Tecnico" Then
            CBSector.Visible = True
            Label5.Visible = True

        Else
            CBSector.Visible = False
            Label5.Visible = False



        End If
    End Sub

    Private Sub TextBoxCI_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCI.TextChanged

    End Sub

    Private Sub TextBoxCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub

    Private Sub TextBoxNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNombre.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub TBx2Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBx2Nombre.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub TextBoxApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxApellido.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub TextBox2Apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2Apellido.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub TBx2Nombre_TextChanged(sender As Object, e As EventArgs) Handles TBx2Nombre.TextChanged

    End Sub
End Class