Public Class Ticket
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        MenuTicket.Show()
        Dim Borrar As New TicketC

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSector.SelectedIndexChanged

    End Sub

    Private Sub Ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Codigo As Integer = Val(TBxCodigo.Text)
        Dim Code As New TicketC
        Code.CodigoTbx(Codigo)

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Dim Alta As New TicketC
        Dim Codigo As Integer = TBxCodigo.Text
        Dim Nombre As String = TBxNombre.Text
        Dim Apellido As String = TBxApellido.Text
        Dim Sector As String = CBSector.Text
        Dim Prioridad As String = CBPrioridad.Text
        Dim Email As String = TBxEmail.Text
        Dim Mensaje As String = TBxMensaje.Text

        Alta.AltaTicket(Codigo, Nombre, Apellido, Sector, Prioridad, Email, Mensaje)
       
    End Sub

    Private Sub TBxNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBxNombre.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub TBxApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBxApellido.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False

        End If
    End Sub
End Class