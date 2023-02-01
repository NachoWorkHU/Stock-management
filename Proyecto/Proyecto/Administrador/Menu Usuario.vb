Public Class Menu_Usuario
    Private Sub Menu_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Visible = False
        MenuUniversal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Me.Visible = False
        UsuariosT.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCrearU.Click
        Me.Visible = False
        Usuarios.Show()
    End Sub
End Class