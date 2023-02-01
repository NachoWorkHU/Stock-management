Public Class Historico
    Private Sub Historico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Lista As New StockC
        Lista.ListarStockH()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim Lista As New StockC
        Lista.ListarStockH()
        Lista.VaciarCampos()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnVM.Click
        Dim Con As New StockC

        Me.Visible = False
        MenuControlStock.Show()
        Con.VaciarCampos()
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim Con As New StockC
        Dim Consulta As String = TBxConsulta.Text
        Con.VaciarCampos()
        Con.ConsultarH(Consulta)
    End Sub

    Private Sub TBxConsulta_TextChanged(sender As Object, e As EventArgs) Handles TBxConsulta.TextChanged

    End Sub
End Class