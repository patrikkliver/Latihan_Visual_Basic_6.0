Imports MySql.Data.MySqlClient

Module Module_Conn
    Dim MyDB As String
    Public conn As MySqlConnection

    Sub Db()
        MyDB = "server=localhost;userid=root;password=1234;database=db_minimarket"
        conn = New MySqlConnection(MyDB)

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
