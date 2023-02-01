Public Class ConsultasTvb
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        MenuTicket.Show()
        Dim Lista As New TicketC
        Lista.VaciarCampos()
    End Sub
    Private Sub Tbxconsulta_TextChanged(sender As Object, e As EventArgs) Handles Tbxconsulta.TextChanged

    End Sub
    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Dim Lista As New TicketC
        Dim Code As Integer
        Code = Val(Tbxconsulta.Text)
        Lista.ConsultarT(Code)

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewB.CellContentClick

    End Sub

    Private Sub ConsultasTvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tbxconsulta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tbxconsulta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
End Class