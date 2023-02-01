Public Class Informes
    Private Sub Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Visible = False
        MenuDeAcceso.Show()

    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Me.Visible = False
        Reportes.Show()
    End Sub

    Private Sub HistorialDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeComprasToolStripMenuItem.Click
        Me.Visible = False
        HistorialDeCompra.Show()
    End Sub

    Private Sub ListadoDeTicketsAbiertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTicketsAbiertosToolStripMenuItem.Click
        Me.Visible = False
        ListadoDeTiketsAbiertos.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        ConsultasT.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        ConsultasIns.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = False
        ConsultasIS.Show()
    End Sub
End Class