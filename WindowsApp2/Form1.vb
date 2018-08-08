Imports Domino
Imports LogicaNegocio

Public Class Form1
    Private _userService As New UserService
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'eventos del boton
        Dim txtUserName As String = TextBox1.Text
        Dim txtUserPassword As String = TextBox2.Text
        Dim usuarioAEnviar As New Usuario
        usuarioAEnviar.nombre = txtUserName
        usuarioAEnviar.password = txtUserPassword
        Dim usuarioALogear As Usuario = _userService.login(usuarioAEnviar)

    End Sub
End Class
