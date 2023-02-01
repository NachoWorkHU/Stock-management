Public Class UsuariosT
    Private Sub UsuariosT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ListaU As New Usuario
        ListaU.ListarUsuarios()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim ListaU As New Usuario
        ListaU.ListarUsuarios()
        ListaU.VaciarCampos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Con As New Usuario
        Me.Visible = False
        Menu_Usuario.Show()


        Con.VaciarCampos()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        ModificarU.Show()
        Dim Con As New Usuario

        Con.VaciarCampos()
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim Con As New Usuario
        Dim Code As String = TBxConsulta.Text
        Con.ConsultarU(Code)
        Con.VaciarCampos()
    End Sub
End Class