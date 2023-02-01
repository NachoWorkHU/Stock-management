Public Class CTicket
    Private Sub CTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CBllenar As New TicketC
        Dim Actua As New TicketC
        Actua.ListTicket()
        CBllenar.LlenarCB()
    End Sub

    Private Sub BtnGerrar_Click(sender As Object, e As EventArgs) Handles BtnGerrar.Click
        Dim CBllenar As New TicketC
        Dim Cierra As New TicketC
        Dim ValidacionCi As New Usuario
        Dim Cedula As String = Val(TextBoxCI.Text)
        Dim Nro As Integer = CBNt.Text
        Dim Solucion As String = TBxSolucion.Text
        ValidacionCi.validarCI(Cedula)
        If ValidacionCi.validarCI(Cedula) Then
            Cierra.CerrarTicket(Cedula, Nro, Solucion)
            Dim Actua As New TicketC
            Actua.ListTicket()
            CBllenar.LlenarCB()

        Else
            MsgBox("Cedula incorrecta")
        End If


    End Sub

    Private Sub CBNt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNt.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        MenuControlStock.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        ModificarTC.Show()
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
End Class