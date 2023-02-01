Public Class ConsultasT
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Me.Visible = False
        Informes.Show()
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim Objetto As New Consultas
        Objetto.Consulta1()
    End Sub

    Private Sub ButtonConsultar2_Click(sender As Object, e As EventArgs) Handles ButtonConsultar2.Click
        Dim Objetto As New Consultas
        Objetto.Consulta2()
    End Sub

    Private Sub ButtonConsultar3_Click(sender As Object, e As EventArgs) Handles ButtonConsultar3.Click
        Dim Objetto As New Consultas
        Objetto.Consulta3()
    End Sub

    Private Sub ButtonConsultar4_Click(sender As Object, e As EventArgs) Handles ButtonConsultar4.Click
        Dim Objetto As New Consultas
        Objetto.Consulta4()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Objetto As New Consultas
        Objetto.Consulta9()
    End Sub
End Class