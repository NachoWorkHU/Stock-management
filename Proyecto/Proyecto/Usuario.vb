Imports System.Data.Odbc
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Usuario

    Public conexion As Odbc.OdbcConnection
    Public cmd As New Odbc.OdbcCommand
    Public da As Odbc.OdbcDataAdapter
    Public ds As New DataSet
    Private respuesta As Odbc.OdbcDataReader



    Sub CConexion()

        conexion = New Odbc.OdbcConnection("Dsn=proyecto")

        If conexion.State = ConnectionState.Closed Then
            conexion.Open()

        End If

    End Sub

    Private CI As String
    Private Clave As String
    Private cargo As String
    Private area As String
    Private PNombre As String
    Private SNombre As String
    Private PApellido As String
    Private SApellido As String





    Public Property C1 As String
        Get
            Return CI

        End Get
        Set(CIIng As String)
            CI = CIIng


        End Set
    End Property

    Public Property CV1 As String
        Get
            Return Clave
        End Get
        Set(ConIng As String)
            Clave = ConIng

        End Set
    End Property

    Public Property Car As String
        Get
            Return cargo

        End Get
        Set(CarIng As String)
            cargo = CarIng


        End Set
    End Property

    Public Property ar As String
        Get
            Return area

        End Get
        Set(areaIng As String)
            area = areaIng


        End Set
    End Property

    Public Property PN As String
        Get
            Return PNombre

        End Get
        Set(PNIng As String)
            PNombre = PNIng


        End Set
    End Property

    Public Property PA As String
        Get
            Return PApellido
        End Get
        Set(PAIng As String)
            PApellido = PAIng

        End Set
    End Property
    Public Property SN As String
        Get
            Return SNombre

        End Get
        Set(SNIng As String)
            SNombre = SNIng


        End Set
    End Property

    Public Property SA As String
        Get
            Return SApellido
        End Get
        Set(SAIng As String)
            SApellido = SAIng

        End Set
    End Property

    Sub Inicios()
        Try

            ''cmd = New OdbcCommand("INSERT INTO sesion(ci_sesion,nombre_apellido,fh_inicia) VALUES ('" & CI & "','" & Contraseña & "','" & cargo & "','" & area & "','" & PNombre & "','" & SNombre & "','" & PApellido & "','" & SApellido & "')", conexion)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro guardado!", "ALTA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            VaciarCampos()
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        End Try


    End Sub




    Function LLogin(CI, clave, cargo, area)

        Call CConexion()

        If cargo = "Tecnico" Then
            cmd = New OdbcCommand("SELECT COUNT(*) FROM usuario WHERE Ci = '" & CI & "' AND contraseña = '" & clave & "'AND cargo = '" & cargo & "' and area = '" & area & "'", conexion)





        Else
            cmd = New OdbcCommand("SELECT COUNT(*) FROM usuario WHERE Ci = '" & CI & "' AND contraseña = '" & clave & "'AND cargo = '" & cargo & "'", conexion)

        End If





        Return cmd.ExecuteScalar()







    End Function

    Sub ListarUsuarios()

        Call CConexion()
        da = New OdbcDataAdapter("SELECT ci As Cedula, cargo As Cargo, contraseña As Contraseña,pnombre As Primer_Nombre ,snombre As Segundo_Nombre,papellido As Primer_Apellido,sapellido As Segundo_Apellido,area As Area FROM Usuario", conexion)
        ds = New DataSet()
        da.Fill(ds)
        UsuariosT.DataGridViewB.DataSource = ds.Tables(0)
        UsuariosT.DataGridViewB.Columns("Cedula").Width = 60
        UsuariosT.DataGridViewB.Columns("Cargo").Width = 80
        UsuariosT.DataGridViewB.Columns("Contraseña").Width = 80
        UsuariosT.DataGridViewB.Columns("Primer_Nombre").Width = 80
        UsuariosT.DataGridViewB.Columns("Segundo_Nombre").Width = 80
        UsuariosT.DataGridViewB.Columns("Primer_Apellido").Width = 80
        UsuariosT.DataGridViewB.Columns("Segundo_Apellido").Width = 80


    End Sub

    Sub VaciarCampos()
        Login.TextBoxCI.Text = ""
        Login.TextBoxContraseña.Text = ""
        Login.cbTipoDeUsuario.Text = ""
        Login.cbAreaAsignada.Text = ""
        Login.cbAreaAsignada.Visible = False
        Reportes.TextBoxCI.Text = ""
        Reportes.TextBoxCorreo.Text = ""
        Reportes.TextBoxMensaje.Text = ""
        Reportes.TextBoxNa.Text = ""
        Reportes.TextBoxNCompleto.Text = ""
        Reportes.TextBoxT.Text = ""
        ModificarU.TBxContraseña.Text = ""
        ModificarU.CBCargo.Text = ""
        ModificarU.CBSector.Text = ""
        ModificarU.TextBoxNombre.Text = ""
        ModificarU.TBx2Nombre.Text = ""
        ModificarU.TextBoxApellido.Text = ""
        ModificarU.TextBox2Apellido.Text = ""
        Usuarios.TextBoxCI.Text = ""
        Usuarios.TBxContraseña.Text = ""
        Usuarios.CBCargo.Text = ""
        Usuarios.CBSector.Text = ""
        Usuarios.TextBoxNombre.Text = ""
        Usuarios.TBx2Nombre.Text = ""
        Usuarios.TextBoxApellido.Text = ""
        Usuarios.TextBox2Apellido.Text = ""
        UsuariosT.TBxConsulta.Text = ""



    End Sub

    Function VVacio(CI, clave, cargo)
        Call CConexion()

        If CI = "" Or clave = "" Or cargo = "" Then
            Return False

        Else


            Return True

        End If



    End Function

    Function validarCI(CI)

        Call CConexion()

        Dim Cedula As String
        Dim Verificador As Integer
        Dim NroC As String
        Dim NVeri As Integer = 0
        Dim Suma As Integer = 0
        Dim multiplicacion As Integer = 0
        Dim Sumador As String
        Dim UltD As String
        Dim Separador As String
        Dim PNum As Integer = 0
        Dim SNum As Integer = 0
        Dim TNum As Integer = 0
        Dim CNum As Integer = 0
        Dim QNum As Integer = 0
        Dim SexNum As Integer = 0
        Dim SepNum As Integer = 0
        Dim octNum As Integer = 0
        Try


            If CI < 10000000 Then
                Return False
            Else

                Cedula = CI

                Separador = CI(0)
                PNum = Separador

                Separador = CI(1)
                SNum = Separador

                Separador = CI(2)
                TNum = Separador

                Separador = CI(3)
                CNum = Separador

                Separador = CI(4)
                QNum = Separador

                Separador = CI(5)
                SexNum = Separador

                Separador = CI(6)
                SepNum = Separador

                Separador = CI(7)
                octNum = Separador


                multiplicacion = PNum * 2
                Suma = Suma + multiplicacion
                multiplicacion = SNum * 9
                Suma = Suma + multiplicacion
                multiplicacion = TNum * 8
                Suma = Suma + multiplicacion
                multiplicacion = CNum * 7
                Suma = Suma + multiplicacion
                multiplicacion = QNum * 6
                Suma = Suma + multiplicacion
                multiplicacion = SexNum * 3
                Suma = Suma + multiplicacion
                multiplicacion = SepNum * 4
                Suma = Suma + multiplicacion


                Sumador = Suma
                NVeri = Len(Sumador) - 1
                NroC = Sumador(NVeri)
                UltD = NroC

                If UltD = 0 Then

                    Verificador = 0
                Else

                    Verificador = 10 - UltD
                End If


                If Verificador <> octNum Then

                    Return False

                Else

                    Return True

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        End Try
    End Function

    Sub AltaUsuario(CI, Contraseña, Cargo, Area, Pnombre, Snombre, Papellido, Sapellido)
        Call CConexion()

        If Usuarios.TextBoxCI.Text = "" Or
           Usuarios.TBxContraseña.Text = "" Or
           Usuarios.CBCargo.Text = "" Or
           Usuarios.TextBoxNombre.Text = "" Or
           Usuarios.TextBoxApellido.Text = "" Then
            MessageBox.Show("No pueden quedar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Cargo = "Tecnico" Then
            If Usuarios.CBSector.Text = "" Then
                MessageBox.Show("No pueden quedar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If


        Else
            Try

                cmd = New OdbcCommand("INSERT INTO usuario(ci, contraseña,cargo, area, pnombre, snombre,papellido,sapellido) VALUES ('" & CI & "','" & Contraseña & "','" & Cargo & "','" & Area & "','" & Pnombre & "','" & Snombre & "','" & Papellido & "','" & Sapellido & "')", conexion)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro guardado!", "ALTA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                VaciarCampos()
            Catch ex As Exception
                MessageBox.Show("Ya esta registrada esa cedula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        End If
    End Sub



    Sub Main(Npdf, Nc, Titulo, Email, CI, Mensaje)

        ' CREAR PDF Y ESCRIBIR 

        Dim documentoPDF As New Document(PageSize.A4, 100, 100, 220, 150) ' SE LE PONE LAS CARACTERISTICAS DEL DOCUMENTO PDF (TAMAÑO ETC.)
        iTextSharp.text.pdf.PdfWriter.GetInstance(documentoPDF, New System.IO.FileStream("Npdf.pdf", System.IO.FileMode.Create))
        documentoPDF.Open()


        'AÑADIR TABLA 

        Dim tabla
        Dim celda
        Dim celda1
        Dim celda2
        Dim celda3
        Dim celda4
        Dim celda5



        tabla = New pdf.PdfPTable(1) 'EL 4 ES EL NUMERO DE COLUMNAS


        celda = New pdf.PdfPCell(New Phrase("Titulo")) 'TITULO DE LA TABLA
        celda1 = New pdf.PdfPCell(New Phrase("Nombre completo"))

        celda2 = New pdf.PdfPCell(New Phrase("Cedula"))
        celda3 = New pdf.PdfPCell(New Phrase("Correo electronico"))
        celda4 = New pdf.PdfPCell(New Phrase("Descripcion"))



        'celda.colspan = 1 ' CELDAS QUE OCUPA EL TITULO DE TABLA  |||  SI LLEGA A SER 3, COMO LA TABLA TIENE 4 COLUMNAS, 1 DE LAS CELDAS SUBIRIA Y SE COLOCARIA JUNTA A LA DEL TITULO
        ' celda.horizontalAlignment = 1 ' UBICACIÓN DEL TITULO DE LA TABLA: 0=IZQUIERDA 1=CENTRADO 2=DERECHA


        'celda.padding = 0.5 ' ALTURA DE LA CELDA DE TITULO


        celda.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
        celda.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP

        celda1.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
        celda1.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP
        celda2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
        celda2.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP
        celda3.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
        celda3.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP
        celda4.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
        celda4.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP


        celda.backgroundcolor = pdf.ExtendedColor.LIGHT_GRAY ' COLOR DE RELLENO DE LA CELDA DE TITULO
        celda1.backgroundcolor = pdf.ExtendedColor.LIGHT_GRAY
        celda2.backgroundcolor = pdf.ExtendedColor.LIGHT_GRAY
        celda3.backgroundcolor = pdf.ExtendedColor.LIGHT_GRAY
        celda4.backgroundcolor = pdf.ExtendedColor.LIGHT_GRAY

        tabla.TotalWidth = 500.0F

        tabla.LockedWidth = True

        tabla.addcell(celda)
        tabla.addcell(Titulo)
        tabla.addcell(celda1)
        tabla.addcell(Nc)
        tabla.addcell(celda2)
        tabla.addcell(CI)
        tabla.addcell(celda3)
        tabla.addcell(Email)
        tabla.addcell(celda4)
        tabla.addcell(Mensaje)



        'SE AÑADE LA CELDA 1






        ' TOTAL DE CELDAS: 12


        documentoPDF.Add(tabla)

        documentoPDF.Close()
        Process.Start("Npdf.PDF")



    End Sub


    Sub LlenarCB()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT ci FROM usuario", conexion)
        da.Fill(ds)
        ModificarU.ComboBoxCI.DataSource = ds.Tables(0)
        ModificarU.ComboBoxCI.ValueMember = "ci"


    End Sub
    Sub LlenarCBx(Ci, Contraseña, Cargo, Area, PN, SN, PA, SA)
        Call CConexion()
        cmd = New OdbcCommand("SELECT * FROM Usuario where ci = '" & Ci & "'", conexion)

        respuesta = cmd.ExecuteReader

        If respuesta.Read() Then

            ModificarU.TBxContraseña.Text = respuesta.Item("Contraseña")

            ModificarU.CBCargo.Text = respuesta.Item("Cargo")
            ModificarU.CBSector.Text = respuesta.Item("Area")
            ModificarU.TextBoxNombre.Text = respuesta.Item("pnombre")
            ModificarU.TBx2Nombre.Text = respuesta.Item("snombre")
            ModificarU.TextBoxApellido.Text = respuesta.Item("papellido")
            ModificarU.TextBox2Apellido.Text = respuesta.Item("sapellido")
        End If

        respuesta.Close()



    End Sub

    Sub UpdateU(Ci, Contraseña, Cargo, Area, PN, SN, PA, SA)
        Call CConexion()
        Try
            cmd = New OdbcCommand("UPDATE usuario set contraseña = '" & Contraseña & "',cargo = '" & Cargo & "',area = '" & Area & "',pnombre = '" & PN & "',snombre = '" & SN & "',papellido = '" & PA & "',sapellido = '" & SA & "'  where ci = '" & Ci & "'", conexion)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro actualizado", "EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            VaciarCampos()
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)

        End Try
    End Sub

    Sub ConsultarU(Code)
        Call CConexion()





        da = New OdbcDataAdapter("SELECT * From usuario where ci = '" & Code & "' Or cargo = '" & Code & "' Or area = '" & Code & "'", conexion)
        ds = New DataSet()
        da.Fill(ds)
        UsuariosT.DataGridViewB.DataSource = ds.Tables(0)
        UsuariosT.DataGridViewB.Columns("ci").Width = 100
        UsuariosT.DataGridViewB.Columns("cargo").Width = 100
        UsuariosT.DataGridViewB.Columns("contraseña").Width = 100
        UsuariosT.DataGridViewB.Columns("pnombre").Width = 100
        UsuariosT.DataGridViewB.Columns("snombre").Width = 100
        UsuariosT.DataGridViewB.Columns("papellido").Width = 100
        UsuariosT.DataGridViewB.Columns("sapellido").Width = 100


    End Sub
    Sub HoraInicial()
        Call CConexion()
        Dim horalogin As String = ""
        cmd = New OdbcCommand("SELECT now()", conexion)
        respuesta = cmd.ExecuteReader

        If respuesta.Read Then
            Login.txtfecha.Text = respuesta.Item("now()")
            Dim hora As String

            hora = Login.txtfecha.Value.Year & "-" & Login.txtfecha.Value.Month & "-" & Login.txtfecha.Value.Day & " " & Login.txtfecha.Value.Hour & ":" & Login.txtfecha.Value.Minute & ":" & Login.txtfecha.Value.Second




        End If

    End Sub

    Sub obtenerN()
        Call CConexion()

        Dim cedula As String = Login.TextBoxCI.Text

        cmd = New OdbcCommand("Select DISTINCT pnombre from usuario where ci = '" & cedula & "'", conexion)
        respuesta = cmd.ExecuteReader
        If respuesta.Read Then
            Login.TextBoxCIingresar.Text = respuesta.Item("pnombre")
            Dim nombre As String = Login.TextBoxCIingresar.Text

        End If


    End Sub
    Sub Iniciar_Cerrar()
        Call CConexion()
        Try
            Dim cedula As String = Val(Login.TextBoxCI.Text)

            Dim nombre As String = Login.TextBoxCIingresar.Text


            Dim horainicio As String = Login.TxtFecha.Value.Year & "-" & Login.TxtFecha.Value.Month & "-" & Login.TxtFecha.Value.Day & " " & Login.TxtFecha.Value.Hour & ":" & Login.TxtFecha.Value.Minute & ":" & Login.TxtFecha.Value.Second

            cmd = New OdbcCommand("INSERT INTO sesion(ci_sesion, nombre,fh_inicia,fh_cierra) VALUES ('" & cedula & "','" & Nombre & "' ,'" & horainicio & "', Now())", conexion)
                respuesta = cmd.ExecuteReader





        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        End Try

    End Sub


End Class
