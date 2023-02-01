Public Class MenuUniversal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Me.Visible = False
        MenuDeAcceso.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnInv.Click
        Me.Visible = False
        MenuControlStock.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnUsuario.Click
        Me.Visible = False
        Menu_Usuario.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnTicket.Click
        Me.Visible = False
        MenuTicket.Show()
    End Sub

    Private Sub MenuUniversal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim inicio As New Usuario
        Me.Visible = False
        Login.Show()


        inicio.Iniciar_Cerrar()
        inicio.VaciarCampos()
    End Sub
End Class