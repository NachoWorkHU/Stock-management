Public Class ConsultasIS
    Private Sub ButtonVolver_Click(sender As Object, e As EventArgs) Handles ButtonVolver.Click
        Me.Visible = False
        Informes.Show()
    End Sub

    Private Sub ButtonConsultar4_Click(sender As Object, e As EventArgs) Handles ButtonConsultar4.Click
        Dim Objeto As New Consultas
        Objeto.Consulta10()

    End Sub
End Class