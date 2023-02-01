Public Class MenuControlStock


    Private Sub MenuControlStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim inicio As New Usuario
        Me.Visible = False
        Login.Show()
        inicio.Iniciar_Cerrar()
        inicio.VaciarCampos()


    End Sub

    Private Sub BtnHistorico_Click(sender As Object, e As EventArgs) Handles BtnHistorico.Click
        Me.Visible = False
        Historico.Show()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Me.Visible = False
        Stock.Show()
    End Sub

    Private Sub BtnStock_Click(sender As Object, e As EventArgs) Handles BtnStock.Click

        Me.Visible = False
        InventarioStock.Show()
    End Sub

    Private Sub BtnV_Click(sender As Object, e As EventArgs) Handles BtnV.Click
        Me.Visible = False
        MenuUniversal.Show()

    End Sub

    Private Sub BtnTicket_Click(sender As Object, e As EventArgs) Handles BtnTicket.Click
        Me.Visible = False
        ListadoDeTiketsAbiertos.Show()
    End Sub

    Private Sub BtnCTicket_Click(sender As Object, e As EventArgs) Handles BtnCTicket.Click
        Me.Visible = False
        CTicket.Show()
    End Sub
End Class