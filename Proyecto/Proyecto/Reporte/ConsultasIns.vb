Public Class ConsultasIns
    Private Sub ConsultasIns_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim Objeto As New Consultas
        Objeto.Consulta5()
    End Sub

    Private Sub ButtonConsultar2_Click(sender As Object, e As EventArgs) Handles ButtonConsultar2.Click
        Dim Objeto As New Consultas
        Objeto.Consulta6()
    End Sub

    Private Sub ButtonConsultar3_Click(sender As Object, e As EventArgs) Handles ButtonConsultar3.Click
        Dim Objeto As New Consultas
        Objeto.Consulta7()
    End Sub

    Private Sub ButtonConsultar4_Click(sender As Object, e As EventArgs) Handles ButtonConsultar4.Click
        Dim Objeto As New Consultas
        Objeto.Consulta8()
    End Sub

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Me.Visible = False
        Informes.Show()
    End Sub
End Class