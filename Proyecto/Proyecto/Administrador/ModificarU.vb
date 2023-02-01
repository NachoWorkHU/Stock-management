Public Class ModificarU
    Private Sub ModificarU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LCb As New Usuario
        LCb.LlenarCB()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        UsuariosT.Show()
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click

        Dim Update As New Usuario
        Dim Ci As String = ComboBoxCI.Text
        Dim Contraseña As String = TBxContraseña.Text
        Dim Cargo As String = CBCargo.Text
        Dim Area As String = CBSector.Text
        Dim PN As String = TextBoxNombre.Text
        Dim SN As String = TBx2Nombre.Text
        Dim PA As String = TextBoxApellido.Text
        Dim SA As String = TextBox2Apellido.Text
        Update.UpdateU(Ci, Contraseña, Cargo, Area, PN, SN, PA, SA)
    End Sub

    Private Sub ComboBoxCI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCI.SelectedIndexChanged

        Dim Llenar As New Usuario
        Dim Update As New Usuario
        Dim Ci As String = ComboBoxCI.Text
            Dim Contraseña As String = TBxContraseña.Text
            Dim Cargo As String = CBCargo.Text
        Dim Area As String = CBSector.Text
        Dim PN As String = TextBoxNombre.Text
        Dim SN As String = TBx2Nombre.Text
        Dim PA As String = TextBoxApellido.Text
        Dim SA As String = TextBox2Apellido.Text
        Llenar.LlenarCBx(Ci, Contraseña, Cargo, Area, PN, SN, PA, SA)



    End Sub

    Private Sub CBSector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSector.SelectedIndexChanged

    End Sub

    Private Sub CBCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCargo.SelectedIndexChanged
        If CBCargo.Text = "Tecnico" Then
            CBSector.Visible = True
            Label5.Text = True
        Else
            CBSector.Visible = False
            Label5.Text = False
        End If
    End Sub
End Class