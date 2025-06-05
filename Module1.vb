Imports MySql.Data.MySqlClient
Module Module1
    Public Con As MySqlConnection

    Public Sub Konek_DB()
        Con = New MySqlConnection("server=localhost;user=root;password=;peralatandapur=")
        Con.Open()
    End Sub
End Module
