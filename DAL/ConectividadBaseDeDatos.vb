Imports System.Data.Odbc

Public Class ConectividadBaseDeDatos
    Public cn As New OdbcConnection
    Public comando As New OdbcCommand
    Public reader As OdbcDataReader




    Protected Shared Function CrearConexion() As OdbcConnection

        Dim usuarioBD As String = My.Settings.Usuario
        Dim passwordBD As String = My.Settings.Password
        Dim puerto As String = My.Settings.Puerto
        Dim servidor As String = My.Settings.Instancia
        Dim ip As String = My.Settings.Ip
        Dim nombreBD As String = My.Settings.NombreBD
        Return New OdbcConnection("DRIVER=IBM INFORMIX ODBC DRIVER (64-bit);UID =" & usuarioBD & ";PWD=" & passwordBD & ";DLOC=en_US.819;CLOC =en_US.CP1252;PRO = olsoctcp;SERV = " & puerto & ";SRVR = " & servidor & ";HOST= " & ip & ";DATABASE = " & nombreBD)
    End Function
End Class