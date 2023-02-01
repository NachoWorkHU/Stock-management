Public Class ModificarTC
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim objeto As New TicketC
        Dim nrot As String = CBticket.Text
        Dim ci As String = TextBoxCI.Text
        Dim solucion As String = TBxSolucion.Text

        objeto.UpdateT(Ci, nroT, solucion)
    End Sub

    Private Sub ModificarTC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objeto As New TicketC
        objeto.LlenarCBTC()
    End Sub

    Private Sub CBCi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBticket.SelectedIndexChanged
        Dim objeto As New TicketC
        Dim nrot As String = CBticket.Text
        objeto.LlenarCBx(nrot)
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Visible = False
        CTicket.Show()
    End Sub
End Class