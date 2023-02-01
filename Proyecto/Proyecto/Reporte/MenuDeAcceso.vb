Public Class MenuDeAcceso
    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem.Click
        Me.Visible = False
        Informes.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Me.Visible = False
        Reportes.Show()
    End Sub

    Private Sub HistorialDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeComprasToolStripMenuItem.Click
        Me.Visible = False
        HistorialDeCompra.Show()
    End Sub

    Private Sub ListadoDeTiketsAbiertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTiketsAbiertosToolStripMenuItem.Click
        Me.Visible = False
        ListadoDeTiketsAbiertos.Show()
    End Sub

    Private Sub MenuDeAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnVLogin.Click
        Dim inicio As New Usuario
        Me.Visible = False
        Login.Show()
        inicio.Iniciar_Cerrar()
        inicio.VaciarCampos()



    End Sub

    Private Sub BtnVolverMA_Click(sender As Object, e As EventArgs) Handles BtnVolverMA.Click
        Me.Visible = False
        MenuUniversal.Show()
    End Sub
End Class