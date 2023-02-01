Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoDeUsuario.SelectedIndexChanged
        If cbTipoDeUsuario.Text = "Tecnico" Then
            lbArea.Visible = True
            cbAreaAsignada.Visible = True
            cbAreaAsignada.Items.Clear()
            cbAreaAsignada.Items.Add("6ºT")
            cbAreaAsignada.Items.Add("Taller M")
            cbAreaAsignada.Items.Add("Sala")
            cbAreaAsignada.Items.Add("Oficinas Tutoria")
            cbAreaAsignada.Items.Add("Oficinas Profesores")
            cbAreaAsignada.Items.Add("Oficinas Bibloteca")
            cbAreaAsignada.Items.Add("Salones")
        Else
            cbAreaAsignada.Visible = False
            lbArea.Visible = False

        End If

    End Sub



    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click




        Dim inicio As New Usuario

        Dim CI As String = TextBoxCI.Text
        Dim Clave As String = TextBoxContraseña.Text
        Dim Cargo As String = cbTipoDeUsuario.Text
        Dim Area As String = cbAreaAsignada.Text
        inicio.LLogin(CI, Clave, Cargo, Area)
        inicio.VVacio(CI, Clave, Cargo)


        ''If inicio.VVacio(CI, Clave, Cargo) Then

        If inicio.LLogin(CI, Clave, Cargo, Area) = 1 Then
            inicio.HoraInicial()
            inicio.obtenerN()

            If Cargo = "Reporte" Then

                Me.Visible = False
                MenuDeAcceso.Show()
                cbAreaAsignada.Visible = False
                lbArea.Visible = False
                ListadoDeTiketsAbiertos.BtnVolverA.Visible = False


                MenuDeAcceso.BtnVLogin.Visible = True
            ElseIf Cargo = "Administrador" Then

                Me.Visible = False
                MenuUniversal.Show()
                cbAreaAsignada.Visible = False
                lbArea.Visible = False

                MenuControlStock.BtnV.Visible = True
                MenuTicket.BtnVolverA.Visible = True
                MenuTicket.BtnVolver.Visible = False
                MenuDeAcceso.BtnVolverMA.Visible = True
                ListadoDeTiketsAbiertos.BtnVolverR.Visible = False



            ElseIf Cargo = "Tecnico" Then
                Me.Visible = False
                MenuControlStock.Show()
                cbAreaAsignada.Visible = False
                lbArea.Visible = False
                MenuControlStock.BtnVolver.Visible = True
                ListadoDeTiketsAbiertos.BtnVolverR.Visible = False

                lbArea.Visible = False




            Else
                MsgBox("Debe completar las casillas")
            End If
        Else MsgBox("Login incorrecto")


            cbAreaAsignada.Visible = False
            lbArea.Visible = False



        End If
        ''End If
        Dim VC As New Usuario




    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Visible = False
        MenuTicket.Show()
        Dim VC As New Usuario
        VC.VaciarCampos()

    End Sub

    Private Sub cbAreaAsignada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAreaAsignada.SelectedIndexChanged
    End Sub

    Private Sub lblAreaAsignada_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnConexion_Click(sender As Object, e As EventArgs)
        Dim objConexion As New Conectar


        objConexion.CConexion()
    End Sub

    Private Sub TextBoxCI_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCI.TextChanged

    End Sub




    Private Sub TextBoxContraseña_TextChanged(sender As Object, e As EventArgs) Handles TextBoxContraseña.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBoxContraseña.PasswordChar = ""
        Else
            TextBoxContraseña.PasswordChar = "*"

        End If
    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBoxCI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCI.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub
End Class
