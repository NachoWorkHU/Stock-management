Public Class ListadoDeTiketsAbiertos
    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        Informes.Show()
    End Sub



    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        Reportes.Show()
    End Sub

    Private Sub HistorialDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Visible = False
        HistorialDeCompra.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnVolverR.Click
        Me.Visible = False
        MenuDeAcceso.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Lista As New TicketC
        Dim ListaC As New TicketC
        Lista.ListTicketA()
        ListaC.ListTicketC()
        Lista.VaciarCampos()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewB.CellContentClick

    End Sub

    Private Sub ListadoDeTiketsAbiertos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Lista As New TicketC
        Dim ListaC As New TicketC
        Lista.ListTicketA()
        ListaC.ListTicketC()
    End Sub

    Private Sub BtnVolverA_Click(sender As Object, e As EventArgs) Handles BtnVolverA.Click
        Dim VV As New TicketC
        Me.Visible = False
        MenuControlStock.Show()
        VV.VaciarCampos()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnConsultarA_Click(sender As Object, e As EventArgs) Handles BtnConsultarA.Click
        Dim Con As New TicketC
        Dim Consulta As String = TbxConsultarA.Text
        Con.consultasA(Consulta)
        Con.VaciarCampos()
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim Con As New TicketC
        Dim Consulta As String = TBxConsulta.Text
        Con.consultasC(Consulta)
        Con.VaciarCampos()
    End Sub
End Class