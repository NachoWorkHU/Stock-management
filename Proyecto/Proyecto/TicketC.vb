Imports System.Data.Odbc

Public Class TicketC
    Public conexion As Odbc.OdbcConnection
    Public cmd As New Odbc.OdbcCommand
    Public da As Odbc.OdbcDataAdapter
    Public ds As New DataSet
    Private respuesta As Odbc.OdbcDataReader
    Private TipoArea As String



    Sub CConexion()

        conexion = New Odbc.OdbcConnection("Dsn=proyecto")

        If conexion.State = ConnectionState.Closed Then
            conexion.Open()

        End If

    End Sub
    Sub ListTicketA()


        Call CConexion()
        da = New OdbcDataAdapter("SELECT codigo As Codigo, nombre_invitado As Nombre, apellido_invitado As Apellido,email As Email,mensaje As Descripcion ,sector As Area, prioridad AS Prioridad FROM Ticket", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ListadoDeTiketsAbiertos.DataGridViewB.DataSource = ds.Tables(0)
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("Codigo").Width = 60
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("Nombre").Width = 80
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("Apellido").Width = 80
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("Email").Width = 80
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("Descripcion").Width = 60
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("Area").Width = 80
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("Prioridad").Width = 60




    End Sub



    Sub ListTicketC()


        Call CConexion()

        da = New OdbcDataAdapter("SELECT ci_usuario As Cedula, codigo_ticket As Codigo, fecha_y_hora As Fecha_Horario,solucion As Solucion From Cierra", conexion)
        da.Fill(ds)
        ListadoDeTiketsAbiertos.DataGridViewC.DataSource = ds.Tables(0)
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("Cedula").Width = 60
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("Codigo").Width = 80
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("Fecha_Horario").Width = 80
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("Solucion").Width = 80




    End Sub
    Sub ListTicketCn()


        Call CConexion()

        da = New OdbcDataAdapter("SELECT codigo_ticket As Codigo,nombre_invitado AS Nombre,apellido_invitado AS Apellido, mensaje As Mensaje,sector As Sector,prioridad AS prioridad, email AS Email, fecha_t As Fecha From ticket", conexion)
        da.Fill(ds)
        ListadoDeTiketsAbiertos.DataGridViewC.DataSource = ds.Tables(0)
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("Cedula").Width = 60
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("Codigo").Width = 80
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("Fecha_Horario").Width = 80
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("Solucion").Width = 80




    End Sub

    Sub ConsultarT(Code As Integer)

        Call CConexion()
        Dim resultado As Integer
        cmd = New OdbcCommand("SELECT COUNT(*) As Cant from cierra where codigo_ticket = '" & Code & "'", conexion)
        respuesta = cmd.ExecuteReader
        If respuesta.Read Then
            resultado = respuesta.Item("Cant")
        End If

        If resultado >= 1 Then

            da = New OdbcDataAdapter("SELECT pnombre As Nombre,codigo_ticket As Codigo,fecha_y_hora As Fecha_Horario,solucion As Solucion from usuario,cierra where codigo_ticket = '" & Code & "' and usuario.ci = ci_usuario", conexion)
            da.Fill(ds)
            ConsultasTvb.DataGridViewB.DataSource = ds.Tables(0)
            ConsultasTvb.DataGridViewB.Columns("Nombre").Width = 100
            ConsultasTvb.DataGridViewB.Columns("Codigo").Width = 100
            ConsultasTvb.DataGridViewB.Columns("Fecha_Horario").Width = 100
            ConsultasTvb.DataGridViewB.Columns("Solucion").Width = 100
        Else

            da = New OdbcDataAdapter("SELECT codigo As Codigo,nombre_invitado AS Nombre,apellido_invitado AS Apellido, mensaje As Mensaje,sector As Sector,prioridad AS Prioridad, email AS Email, fecha_t As Fecha From ticket where codigo= '" & Code & "'", conexion)
            da.Fill(ds)
            ConsultasTvb.DataGridViewB.DataSource = ds.Tables(0)
            ConsultasTvb.DataGridViewB.Columns("Codigo").Width = 60
            ConsultasTvb.DataGridViewB.Columns("Nombre").Width = 80
            ConsultasTvb.DataGridViewB.Columns("Apellido").Width = 80
            ConsultasTvb.DataGridViewB.Columns("Mensaje").Width = 80
            ConsultasTvb.DataGridViewB.Columns("Sector").Width = 60
            ConsultasTvb.DataGridViewB.Columns("Prioridad").Width = 80
            ConsultasTvb.DataGridViewB.Columns("Email").Width = 80
            ConsultasTvb.DataGridViewB.Columns("Fecha").Width = 80

        End If

    End Sub
    Sub CodigoTbx(Codigo)
        Dim resultado As Integer
        Call CConexion()
        cmd = New OdbcCommand("SELECT COUNT(codigo) As Cant from ticket", conexion)
        respuesta = cmd.ExecuteReader
        If respuesta.Read Then
            resultado = respuesta.Item("Cant")
            Codigo = resultado + 1
            Ticket.TBxCodigo.Text = Codigo

        End If
    End Sub
    Sub VaciarCampos()
        Ticket.TBxCodigo.Text = ""
        Ticket.TBxNombre.Text = ""
        Ticket.TBxApellido.Text = ""
        Ticket.CBSector.Text = ""
        Ticket.CBPrioridad.Text = ""
        Ticket.TBxEmail.Text = ""
        Ticket.TBxMensaje.Text = ""
        CTicket.TextBoxCI.Text = ""
        CTicket.TBxSolucion.Text = ""
        CTicket.CBNt.Text = ""
        ConsultasTvb.Tbxconsulta.Text = ""
        ListadoDeTiketsAbiertos.TbxConsultarA.Text = ""
        ListadoDeTiketsAbiertos.TBxConsulta.Text = ""
        HistorialDeCompra.TbxConsultarH.Text = ""
        ConsultasTvb.DataGridViewB.Columns.Clear()
    End Sub
    Sub consultasC(code)
        Call CConexion()





        da = New OdbcDataAdapter("SELECT * From cierra where ci_usuario = '" & code & "'  Or codigo_ticket= '" & code & "'", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ListadoDeTiketsAbiertos.DataGridViewC.DataSource = ds.Tables(0)
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("ci_usuario").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("codigo_ticket").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("fecha_y_hora").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewC.Columns("solucion").Width = 250



    End Sub
    Sub consultasA(Code)
        Call CConexion()




        da = New OdbcDataAdapter("SELECT * From ticket where codigo = '" & Code & "'  Or sector= '" & Code & "' Or prioridad = '" & Code & "'", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ListadoDeTiketsAbiertos.DataGridViewB.DataSource = ds.Tables(0)
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("codigo").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("nombre_invitado").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("apellido_invitado").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("mensaje").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("sector").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("prioridad").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("email").Width = 100
        ListadoDeTiketsAbiertos.DataGridViewB.Columns("fecha_t").Width = 100



    End Sub

    Sub AltaTicket(Codigo, Nombre, Apellido, Sector, Prioridad, Email, Mensaje)
        Call CConexion()
        If Ticket.TBxNombre.Text = "" Or
            Ticket.TBxApellido.Text = "" Or
            Ticket.CBSector.Text = "" Or
            Ticket.CBPrioridad.Text = "" Or
            Ticket.TBxEmail.Text = "" Or
            Ticket.TBxMensaje.Text = "" Then


            MessageBox.Show("No pueden quedar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else


            Try

                cmd = New OdbcCommand("INSERT INTO ticket(codigo, nombre_invitado, apellido_invitado, sector, prioridad, email,mensaje, fecha_t) VALUES ('" & Codigo & "','" & Nombre & "','" & Apellido & "','" & Sector & "','" & Prioridad & "','" & Email & "','" & Mensaje & "', NOW()) ", conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro guardado!", "ALTA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                VaciarCampos()
                CodigoTbx(Codigo)
            Catch ex As Exception
                MessageBox.Show("ERROR: " & ex.Message)
            End Try

        End If



    End Sub

    Sub LlenarCB()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT codigo FROM consult1", conexion)
        da.Fill(ds)
        CTicket.CBNt.DataSource = ds.Tables(0)
        CTicket.CBNt.ValueMember = "codigo"
    End Sub

    Sub LlenarCBTC()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT codigo_ticket FROM cierra", conexion)
        da.Fill(ds)
        ModificarTC.CBticket.DataSource = ds.Tables(0)
        ModificarTC.CBticket.ValueMember = "codigo_ticket"
    End Sub
    Sub LlenarCBx(nrot)
        Call CConexion()
        cmd = New OdbcCommand("SELECT * FROM cierra where codigo_ticket= '" & nrot & "'", conexion)

        respuesta = cmd.ExecuteReader

        If respuesta.Read() Then



            ModificarTC.TextBoxCI.Text = respuesta.Item("ci_usuario")
            ModificarTC.TBxSolucion.Text = respuesta.Item("Solucion")

        End If

        respuesta.Close()



    End Sub

    Sub UpdateT(Ci, NroT, Solucion)
        Call CConexion()
        Try
            cmd = New OdbcCommand("UPDATE cierra set solucion = '" & Solucion & "' where codigo_ticket = '" & NroT & "'", conexion)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro actualizado", "EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            VaciarCampos()
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)

        End Try
    End Sub
    Sub CerrarTicket(Cedula, Numero, Solucion)
        Call CConexion()
        If CTicket.TextBoxCI.Text = "" Or
           CTicket.CBNt.Text = "" Or
           CTicket.TBxSolucion.Text = "" Then


            MessageBox.Show("No pueden quedar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else


            Try

                cmd = New OdbcCommand("INSERT INTO cierra(ci_usuario, codigo_ticket, fecha_y_hora,solucion) VALUES ('" & Cedula & "','" & Numero & "',NOW(),'" & Solucion & "') ", conexion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro guardado!", "ALTA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                VaciarCampos()

            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error con el cierre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End If
    End Sub


    Sub ListTicket()


        Call CConexion()

        da = New OdbcDataAdapter("SELECT * FROM ticket WHERE codigo NOT IN (SELECT codigo_ticket FROM cierra)", conexion)
        da.Fill(ds)
        CTicket.DataGridViewB.DataSource = ds.Tables(0)
        CTicket.DataGridViewB.Columns("Codigo").Width = 60
        CTicket.DataGridViewB.Columns("Nombre_invitado").Width = 80
        CTicket.DataGridViewB.Columns("Apellido_invitado").Width = 80
        CTicket.DataGridViewB.Columns("Mensaje").Width = 80
        CTicket.DataGridViewB.Columns("Sector").Width = 80
        CTicket.DataGridViewB.Columns("Prioridad").Width = 80
        CTicket.DataGridViewB.Columns("Email").Width = 80
        CTicket.DataGridViewB.Columns("Fecha_t").Width = 80




    End Sub
End Class
