Imports System.Data.Odbc
Public Class Consultas



    Public conexion As Odbc.OdbcConnection
    Public cmd As New Odbc.OdbcCommand
    Public da As Odbc.OdbcDataAdapter
    Public ds As New DataSet


    Sub CConexion()

        conexion = New Odbc.OdbcConnection("Dsn=proyecto")

        If conexion.State = ConnectionState.Closed Then
            conexion.Open()

        Else
            MsgBox("Conexion no establecida")


        End If

    End Sub

    Sub Consulta1()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult1 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasT.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasT.DataGridViewB.Columns("Codigo").Width = 60
        ConsultasT.DataGridViewB.Columns("Nombre_invitado").Width = 80
        ConsultasT.DataGridViewB.Columns("Apellido_invitado").Width = 80
        ConsultasT.DataGridViewB.Columns("Mensaje").Width = 80
        ConsultasT.DataGridViewB.Columns("Sector").Width = 80
        ConsultasT.DataGridViewB.Columns("Prioridad").Width = 60
        ConsultasT.DataGridViewB.Columns("Email").Width = 80
        ConsultasT.DataGridViewB.Columns("Fecha_t").Width = 60


    End Sub

    Sub Consulta2()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult2 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasT.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasT.DataGridViewB.Columns("Ticket").Width = 60
        ConsultasT.DataGridViewB.Columns("Sector").Width = 80



    End Sub
    Sub Consulta3()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult3 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasT.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasT.DataGridViewB.Columns("Nombre").Width = 60
        ConsultasT.DataGridViewB.Columns("Apellido").Width = 80



    End Sub
    Sub Consulta4()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult4 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasT.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasT.DataGridViewB.Columns("Diferencia de dias").Width = 60
    End Sub
    Sub Consulta5()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult5 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasIns.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasIns.DataGridViewB.Columns("Insumos").Width = 60
        ConsultasIns.DataGridViewB.Columns("Stock").Width = 60
    End Sub

    Sub Consulta6()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult6 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasIns.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasIns.DataGridViewB.Columns("Insumos").Width = 60
        ConsultasIns.DataGridViewB.Columns("Sector").Width = 60
    End Sub

    Sub Consulta7()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult7 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasIns.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasIns.DataGridViewB.Columns("Cod_i").Width = 60
        ConsultasIns.DataGridViewB.Columns("Nombre_p").Width = 60
        ConsultasIns.DataGridViewB.Columns("Fecha_mov").Width = 60
        ConsultasIns.DataGridViewB.Columns("Estado").Width = 60
        ConsultasIns.DataGridViewB.Columns("Sector").Width = 60
        ConsultasIns.DataGridViewB.Columns("Donador").Width = 60
    End Sub
    Sub Consulta8()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult8 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasIns.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasIns.DataGridViewB.Columns("Codigo").Width = 60
        ConsultasIns.DataGridViewB.Columns("Insumo").Width = 60
        ConsultasIns.DataGridViewB.Columns("Fecha en la que ingreso").Width = 60
        ConsultasIns.DataGridViewB.Columns("Donador").Width = 60

    End Sub
    Sub Consulta9()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult9 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasT.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasT.DataGridViewB.Columns("Nombre del tecnico").Width = 60
        ConsultasT.DataGridViewB.Columns("Apellido del tecnico").Width = 60
        ConsultasT.DataGridViewB.Columns("Fecha de ingreso").Width = 60
        ConsultasT.DataGridViewB.Columns("Fecha de cierre").Width = 60
        ConsultasT.DataGridViewB.Columns("Sector Asignado").Width = 60

    End Sub
    Sub Consulta10()
        Call CConexion()
        da = New OdbcDataAdapter("SELECT * FROM consult10 ", conexion)
        ds = New DataSet()
        da.Fill(ds)
        ConsultasIS.DataGridViewB.DataSource = ds.Tables(0)
        ConsultasIS.DataGridViewB.Columns("Nombre").Width = 60
        ConsultasIS.DataGridViewB.Columns("Inicio de sesion").Width = 60
        ConsultasIS.DataGridViewB.Columns("Cierre de sesion").Width = 60


    End Sub

End Class
