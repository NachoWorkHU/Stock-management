Public Class InventarioStock
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim Lista As New StockC
        Lista.ListarInventario()
        Lista.VaciarCampos()
    End Sub

    Private Sub InventarioStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Lista As New StockC
        Lista.ListarInventario()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonVM.Click
        Dim Con As New StockC
        Me.Visible = False
        MenuControlStock.Show()
        Con.VaciarCampos()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim Con As New StockC
        Dim Consulta As String = TBxConsulta.Text

        Con.ConsultarS(Consulta)
        Con.VaciarCampos()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim Con As New StockC
        Me.Visible = False
        ModificarStock.Show()

        Con.VaciarCampos()
    End Sub
End Class