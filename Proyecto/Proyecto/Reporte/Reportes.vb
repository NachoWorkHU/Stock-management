Public Class Reportes
    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem.Click
        Me.Visible = False
        Informes.Show()
    End Sub



    Private Sub HistorialDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialDeComprasToolStripMenuItem.Click
        Me.Visible = False
        HistorialDeCompra.Show()
    End Sub

    Private Sub ListadoDeTiketsAbiertosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTiketsAbiertosToolStripMenuItem.Click
        Me.Visible = False
        ListadoDeTiketsAbiertos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        MenuDeAcceso.Show()
        Dim VV As New Usuario
        VV.VaciarCampos()
    End Sub

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim VV As New Usuario
        VV.VaciarCampos()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Dim Pdf As New Usuario
        Dim VV As New Usuario
        Dim NombrePdf As String = TextBoxNa.Text
        Dim Email As String = TextBoxCorreo.Text
        Dim Ci As String = TextBoxCI.Text
        Dim Nc As String = TextBoxNCompleto.Text
        Dim titulo As String = TextBoxT.Text
        Dim Mensaje As String = TextBoxMensaje.Text
        '' Pdf.CrearPdf(NombrePdf, Nc, titulo, Email, Ci, Mensaje)
        Pdf.Main(NombrePdf, Nc, titulo, Email, Ci, Mensaje)

        VV.VaciarCampos()
    End Sub
End Class