Public Class ModificarStock
    Private Sub BtnModificar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        InventarioStock.Show()
    End Sub

    Private Sub CBCodigoS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCodigoS.SelectedIndexChanged
        Dim Full As New StockC
        Dim Codigo As String = CBCodigoS.Text

        Full.LlenarModi(Codigo)
    End Sub

    Private Sub ModificarStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Full As New StockC

        Full.LlenarCombobx()
    End Sub

    Private Sub BtnModificar_Click_1(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim Full As New StockC
        Dim Codigo As String = CBCodigoS.Text
        Dim Nombre As String = CBNombre.Text
        Dim Estado As String = CBEstado.Text
        Dim Sector As String = CbSector.Text
        Full.UpdateS(Codigo, Nombre, Estado, Sector)
        Full.InsertModif(Codigo, Nombre, Estado, Sector)
    End Sub
End Class