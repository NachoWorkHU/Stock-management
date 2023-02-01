Public Class Stock
    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Dim Alta As New StockC
        Dim AltI As New StockC
        Dim Codigo As Integer = Val(TBxCodigo.Text)
        Dim Nombre As String = ComboBoxNombre.Text
        Dim Estado As String = CBEstado.Text
        Dim Sector As String = CBSector.Text
        Dim Donador As String = TBxDonador.Text
        Alta.AltaStock(Codigo, Nombre, Estado, Sector, Donador)
        AltI.AltaInv(Codigo, Nombre, Estado, Sector)
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Me.Visible = False
        MenuControlStock.Show()
    End Sub

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TBxCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBxCodigo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
End Class