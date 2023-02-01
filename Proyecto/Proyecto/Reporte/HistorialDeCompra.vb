Public Class HistorialDeCompra
    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem.Click
        Me.Visible = False
        Informes.Show()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Me.Visible = False
        Reportes.Show()
    End Sub

    Private Sub ListadoDeTiketsAbiertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTiketsAbiertosToolStripMenuItem.Click
        Me.Visible = False
        ListadoDeTiketsAbiertos.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HistorialDeCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ListaR As New StockC
        ListaR.ListarStockR()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VV As New TicketC
        Me.Visible = False
        MenuDeAcceso.Show()
        VV.VaciarCampos()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim ListaR As New StockC
        Dim VV As New TicketC
        ListaR.ListarStockR()
        VV.VaciarCampos()
    End Sub

    Private Sub DataGridViewB_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewB.CellContentClick

    End Sub

    Private Sub BtnConsultarH_Click(sender As Object, e As EventArgs) Handles BtnConsultarH.Click
        Dim Consulta As String = TbxConsultarH.Text
        Dim Con As New StockC
        Dim vv As New TicketC
        Con.ConsultarHR(Consulta)
        vv.VaciarCampos()

    End Sub
End Class