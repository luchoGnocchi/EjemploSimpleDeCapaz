Imports DAL
Imports Domino

Public Class UserService
    Dim _userDataAccess As New UserDataAccess()
    Public Function login(usuario As Usuario) As Usuario
        Return _userDataAccess.login(usuario)

    End Function
End Class
