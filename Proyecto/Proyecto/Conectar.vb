Imports System.Data.Odbc
Public Class Conectar

    Public conexion As Odbc.OdbcConnection
    Public cmd As New Odbc.OdbcCommand
    Public da As Odbc.OdbcDataAdapter
    Public ds As New DataSet


    Sub CConexion()

        conexion = New Odbc.OdbcConnection("Dsn=proyecto")

        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
            MsgBox("Conexion  establecida")
        Else
            MsgBox("Conexion no establecida")


        End If

    End Sub





End Class
