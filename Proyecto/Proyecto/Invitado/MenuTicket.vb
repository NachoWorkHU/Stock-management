Public Class MenuTicket
    Private Sub MenuTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Ticket.Show()
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Visible = False
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        ConsultasTvb.Show()
    End Sub

    Private Sub BtnVolverA_Click(sender As Object, e As EventArgs) Handles BtnVolverA.Click
        Me.Visible = False
        MenuUniversal.Show()
    End Sub
End Class