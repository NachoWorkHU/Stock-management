Imports System.Data.Odbc
Public Class StockC
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

    Sub ListarStockB()
        TipoArea = "Biblioteca"
        Call CConexion()
        da = New OdbcDataAdapter("SELECT cod_i As Codigo, nombre_p As Nombre, fecha_mov As Fecha_Movimiento,estado As Estado ,sector As Area, donador As Donador FROM historico WHERE sector = '" & TipoArea & "' ORDER BY fecha_mov", conexion)
        ds = New DataSet()
        da.Fill(ds)
        Historico.DataGridViewB.DataSource = ds.Tables(0)
        Historico.DataGridViewB.Columns("Codigo").Width = 60
        Historico.DataGridViewB.Columns("Nombre").Width = 80
        Historico.DataGridViewB.Columns("Fecha_Movimiento").Width = 80
        Historico.DataGridViewB.Columns("Estado").Width = 80
        Historico.DataGridViewB.Columns("Area").Width = 80
        Historico.DataGridViewB.Columns("Donador").Width = 60


    End Sub
    Sub ListarStockP()
        TipoArea = "Profesores"
        Call CConexion()
        da = New OdbcDataAdapter("SELECT cod_i As Codigo, nombre_p As Nombre, fecha_mov As Fecha_Movimiento,estado As Estado ,sector As Area, donador As Donador FROM historico WHERE sector = '" & TipoArea & "' ORDER BY fecha_mov", conexion)
        ds = New DataSet()
        da.Fill(ds)
        Historico.DataGridViewB.DataSource = ds.Tables(0)
        Historico.DataGridViewB.Columns("Codigo").Width = 60
        Historico.DataGridViewB.Columns("Nombre").Width = 80
        Historico.DataGridViewB.Columns("Fecha_Movimiento").Width = 80
        Historico.DataGridViewB.Columns("Estado").Width = 80
        Historico.DataGridViewB.Columns("Area").Width = 80
        Historico.DataGridViewB.Columns("Donador").Width = 60


    End Sub

    Sub ListarStockTM()
        TipoArea = "Taller"
        Call CConexion()
        da = New OdbcDataAdapter("SELECT cod_i As Codigo, nombre_p As Nombre, fecha_mov As Fecha_Movimiento,estado As Estado ,sector As Area, donador As Donador FROM historico WHERE sector = '" & TipoArea & "' ORDER BY fecha_mov", conexion)
        ds = New DataSet()
        da.Fill(ds)
        Historico.DataGridViewB.DataSource = ds.Tables(0)
        Historico.DataGridViewB.Columns("Codigo").Width = 60
        Historico.DataGridViewB.Columns("Nombre").Width = 80
        Historico.DataGridViewB.Columns("Fecha_Movimiento").Width = 80
        Historico.DataGridViewB.Columns("Estado").Width = 80
        Historico.DataGridViewB.Columns("Area").Width = 80
        Historico.DataGridViewB.Columns("Donador").Width = 60


    End Sub

    Sub ListarStockSl()
        TipoArea = "Sala"
        Call CConexion()
        da = New OdbcDataAdapter("SELECT cod_i As Codigo, nombre_p As Nombre, fecha_mov As Fecha_Movimiento,estado As Estado ,sector As Area, donador As Donador FROM historico WHERE sector = '" & TipoArea & "' ORDER BY fecha_mov", conexion)
        ds = New DataSet()
        da.Fill(ds)
        Historico.DataGridViewB.DataSource = ds.Tables(0)
        Historico.DataGridViewB.Columns("Codigo").Width = 60
        Historico.DataGridViewB.Columns("Nombre").Width = 80
        Historico.DataGridViewB.Columns("Fecha_Movimiento").Width = 80
        Historico.DataGridViewB.Columns("Estado").Width = 80
        Historico.DataGridViewB.Columns("Area").Width = 80
        Historico.DataGridViewB.Columns("Donador").Width = 60


    End Sub
    Sub ListarStockSlns()
        TipoArea = "Salones"

        Call CConexion()
        da = New OdbcDataAdapter("SELECT cod_i As Codigo, nombre_p As Nombre, fecha_mov As Fecha_Movimiento,estado As Estado ,sector As Area, donador As Donador FROM historico WHERE sector = '" & TipoArea & "' ORDER BY fecha_mov", conexion)
        ds = New DataSet()
        da.Fill(ds)
        Historico.DataGridViewB.DataSource = ds.Tables(0)
        Historico.DataGridViewB.Columns("Codigo").Width = 60
        Historico.DataGridViewB.Columns("Nombre").Width = 80
        Historico.DataGridViewB.Columns("Fecha_Movimiento").Width = 80
        Historico.DataGridViewB.Columns("Estado").Width = 80
        Historico.DataGridViewB.Columns("Area").Width = 80
        Historico.DataGridViewB.Columns("Donador").Width = 60


    End Sub
    Sub ListarStock6T()
        TipoArea = "6To"

        Call CConexion()
        da = New OdbcDataAdapter("SELECT cod_i As Codigo, nombre_p As Nombre, fecha_mov As Fecha_Movimiento,estado As Estado ,sector As Area, donador As Donador FROM historico WHERE sector = '" & TipoArea & "' ORDER BY fecha_mov", conexion)
        ds = New DataSet()
        da.Fill(ds)
        Historico.DataGridViewB.DataSource = ds.Tables(0)
        Historico.DataGridViewB.Columns("Codigo").Width = 80
        Historico.DataGridViewB.Columns("Nombre").Width = 100
        Historico.DataGridViewB.Columns("Fecha_Movimiento").Width = 100
        Historico.DataGridViewB.Columns("Estado").Width = 100
        Historico.DataGridViewB.Columns("Area").Width = 100
        Historico.DataGridViewB.Columns("Donador").Width = 100





    End Sub
    Sub ListarStockTT()
        TipoArea = "Tutoria"

        Call CConexion()
        da = New OdbcDataAdapter("SELECT codigo_p As Codigo, nombre_p As Nombre, fecha_compra As Fechacompra,estado As Estado ,area As Area, stock As Cantidad FROM Inventario WHERE area = '" & TipoArea & "' ORDER BY fecha_compra", conexion)
        ds = New DataSet()
        da.Fill(ds)
        Historico.DataGridViewB.DataSource = ds.Tables(0)
        Historico.DataGridViewB.Columns("Codigo").Width = 60
        Historico.DataGridViewB.Columns("Nombre").Width = 80
        Historico.DataGridViewB.Columns("FechaCompra").Width = 80
        Historico.DataGridViewB.Columns("Estado").Width = 80
        Historico.DataGridViewB.Columns("Area").Width = 80
        Historico.DataGridViewB.Columns("Cantidad").Width = 60




    End Sub
    Sub ConsultarS(code)
        Call CConexion()





        da = New OdbcDataAdapter("SELECT * From insumos where codigo_i = '" & code & "' Or nombre_stock = '" & code & "' Or estado_stock = '" & code & "'Or sector_stock = '" & code & "'", conexion)
        ds = New DataSet()
        da.Fill(ds)
        InventarioStock.DataGridViewB.DataSource = ds.Tables(0)
        InventarioStock.DataGridViewB.Columns("codigo_i").Width = 100
        InventarioStock.DataGridViewB.Columns("nombre_stock").Width = 100
        InventarioStock.DataGridViewB.Columns("estado_stock").Width = 100
        InventarioStock.DataGridViewB.Columns("sector_stock").Width = 100

    End Sub

    Sub ConsultarH(code)
        Call CConexion()





        da = New OdbcDataAdapter("SELECT * From historico where cod_i = '" & code & "' Or nombre_p = '" & code & "' Or estado= '" & code & "'Or sector = '" & code & "'", conexion)
        ds = New DataSet()
        da.Fill(ds)
        Historico.DataGridViewB.DataSource = ds.Tables(0)
        Historico.DataGridViewB.Columns("cod_i").Width = 100
        Historico.DataGridViewB.Columns("nombre_p").Width = 100
        Historico.DataGridViewB.Columns("fecha_mov").Width = 100
        Historico.DataGridViewB.Columns("estado").Width = 100
        Historico.DataGridViewB.Columns("sector").Width = 100
        Historico.DataGridViewB.Columns("donador").Width = 100


    End Sub
    Sub ConsultarHR(code)
        Call CConexion()





        da = New OdbcDataAdapter("SELECT * From historico where cod_i = '" & code & "' Or nombre_p = '" & code & "' Or estado= '" & code & "'Or sector = '" & code & "'", conexion)
        ds = New DataSet()
        da.Fill(ds)
        HistorialDeCompra.DataGridViewB.DataSource = ds.Tables(0)
        HistorialDeCompra.DataGridViewB.Columns("cod_i").Width = 100
        HistorialDeCompra.DataGridViewB.Columns("nombre_p").Width = 100
        HistorialDeCompra.DataGridViewB.Columns("fecha_mov").Width = 100
        HistorialDeCompra.DataGridViewB.Columns("estado").Width = 100
        HistorialDeCompra.DataGridViewB.Columns("sector").Width = 100
        HistorialDeCompra.DataGridViewB.Columns("donador").Width = 100


    End Sub
    Sub ListarStockR()

        Call CConexion()
        da = New OdbcDataAdapter("SELECT cod_i As Codigo, nombre_p As Nombre, fecha_mov As Fecha_Movimiento,estado As Estado ,sector As Area, donador As Donador FROM historico ORDER BY fecha_mov", conexion)
        ds = New DataSet()
        da.Fill(ds)
        HistorialDeCompra.DataGridViewB.DataSource = ds.Tables(0)
        HistorialDeCompra.DataGridViewB.Columns("Codigo").Width = 60
        HistorialDeCompra.DataGridViewB.Columns("Nombre").Width = 80
        HistorialDeCompra.DataGridViewB.Columns("Fecha_Movimiento").Width = 80
        HistorialDeCompra.DataGridViewB.Columns("Estado").Width = 80
        HistorialDeCompra.DataGridViewB.Columns("Area").Width = 80
        HistorialDeCompra.DataGridViewB.Columns("Donador").Width = 60


    End Sub


    Sub ListarStockH()


        Call CConexion()
        da = New OdbcDataAdapter("SELECT cod_i As Codigo, nombre_p As Nombre, fecha_mov As Fecha_Movimiento,estado As Estado ,sector As Area, donador As Donador FROM historico ORDER BY fecha_mov", conexion)
        ds = New DataSet()
        da.Fill(ds)
        Historico.DataGridViewB.DataSource = ds.Tables(0)
        Historico.DataGridViewB.Columns("Codigo").Width = 80
        Historico.DataGridViewB.Columns("Nombre").Width = 100
        Historico.DataGridViewB.Columns("Fecha_Movimiento").Width = 100
        Historico.DataGridViewB.Columns("Estado").Width = 100
        Historico.DataGridViewB.Columns("Area").Width = 100
        Historico.DataGridViewB.Columns("Donador").Width = 100





    End Sub

    Sub ListarInventario()


        Call CConexion()
        da = New OdbcDataAdapter("SELECT codigo_i As Codigo, nombre_stock As Nombre,estado_stock As Estado ,sector_stock As Area FROM insumos", conexion)
        ds = New DataSet()
        da.Fill(ds)
        InventarioStock.DataGridViewB.DataSource = ds.Tables(0)
        InventarioStock.DataGridViewB.Columns("Codigo").Width = 80
        InventarioStock.DataGridViewB.Columns("Nombre").Width = 100
        InventarioStock.DataGridViewB.Columns("Estado").Width = 100
        InventarioStock.DataGridViewB.Columns("Area").Width = 100






    End Sub

    Sub VaciarCampos()
        Stock.TBxCodigo.Text = ""
        Stock.ComboBoxNombre.Text = ""
        Stock.CBSector.Text = ""
        Stock.CBEstado.Text = ""
        Stock.TBxDonador.Text = ""
        Historico.TBxConsulta.Text = ""
        InventarioStock.TBxConsulta.Text = ""



    End Sub
    Sub AltaStock(Codigo, Nombre, Estado, Sector, Donador)
        Call CConexion()
        If Stock.TBxCodigo.Text = "" Or
            Stock.ComboBoxNombre.Text = "" Or
               Stock.CBEstado.Text = "" Or
            Stock.CBSector.Text = "" Then




            MessageBox.Show("No pueden quedar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else


            Try

                cmd = New OdbcCommand("INSERT INTO historico(cod_i, nombre_p, fecha_mov, estado, sector, donador) VALUES ('" & Codigo & "','" & Nombre & "',NOW(),'" & Estado & "','" & Sector & "','" & Donador & "')", conexion)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Registro guardado!", "ALTA", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Codigo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub
    Sub AltaInv(Codigo, Nombre, Estado, Sector)
        Call CConexion()
        If Stock.TBxCodigo.Text = "" Or
            Stock.ComboBoxNombre.Text = "" Or
               Stock.CBEstado.Text = "" Or
            Stock.CBSector.Text = "" Then




            MessageBox.Show("No pueden quedar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            Try


                cmd = New OdbcCommand("INSERT INTO insumos(codigo_i, nombre_stock, estado_stock, sector_stock) VALUES ('" & Codigo & "','" & Nombre & "','" & Estado & "','" & Sector & "')", conexion)
                cmd.ExecuteNonQuery()
                '' MessageBox.Show("Registro guardado!", "ALTA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                VaciarCampos()
            Catch ex As Exception
                MessageBox.Show("Codigo incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub
    Sub LlenarCombobx()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT codigo_i FROM insumos", conexion)
        da.Fill(ds)
        ModificarStock.CBCodigoS.DataSource = ds.Tables(0)
        ModificarStock.CBCodigoS.ValueMember = "codigo_i"
    End Sub
    Sub LlenarModi(Codigo)
        Call CConexion()
        cmd = New OdbcCommand("SELECT * FROM insumos where codigo_i = '" & Codigo & "'", conexion)

        respuesta = cmd.ExecuteReader

        If respuesta.Read() Then

            ModificarStock.CBNombre.Text = respuesta.Item("nombre_stock")

            ModificarStock.CBEstado.Text = respuesta.Item("estado_stock")
            ModificarStock.CbSector.Text = respuesta.Item("sector_stock")


        End If

        respuesta.Close()


    End Sub

    Sub UpdateS(Code, Nombre, Estado, Sector)
        Call CConexion()

        Try
            cmd = New OdbcCommand("UPDATE insumos set nombre_stock = '" & Nombre & "',estado_stock = '" & Estado & "',sector_stock = '" & Sector & "' where codigo_i = '" & Code & "'", conexion)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro actualizado", "EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            VaciarCampos()
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)

        End Try
    End Sub
    Sub InsertModif(Code, Nombre, Estado, Sector)
        Try

            cmd = New OdbcCommand("INSERT INTO historico(cod_i, nombre_p, fecha_mov, estado, sector) VALUES ('" & Code & "','" & Nombre & "',NOW(),'" & Estado & "','" & Sector & "')", conexion)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Registro guardado!", "ALTA", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        End Try
    End Sub



End Class
