﻿Imports System.Data.Odbc
Imports Domino

Public Class UserDataAccess
    Inherits ConectividadBaseDeDatos

    Public Function login(usuario As Usuario) As Usuario

        Dim retorno As New Usuario


        cn = CrearConexion()
        comando = New OdbcCommand("select * from usuario where nombre=? and pin=?;", cn)
        comando.CommandType = CommandType.Text

        comando.Parameters.Add(New OdbcParameter("nxx", usuario.nombre))
        comando.Parameters.Add(New OdbcParameter("u", usuario.password))
        cn.Open()
        reader = comando.ExecuteReader()

        If reader.Read() Then


            If Not reader("nombre").Equals(DBNull.Value) Then
                retorno.nombre = reader("nombre").ToString()
            End If

            If Not reader("apellido").Equals(DBNull.Value) Then
                retorno.apellido = reader("apellido").ToString()
            End If


        End If

        Return retorno


    End Function
End Class
