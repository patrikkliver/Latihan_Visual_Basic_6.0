Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim Ds As DataSet
    Dim MyDB As String

    Sub Koneksi()
        MyDB = "data source=RRUTAMA;initial catalog=DB_CRUD1;integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        Da = New SqlDataAdapter("select * from tbl_mahasiswa", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tbl_mahasiswa")
        DataGridView1.DataSource = (Ds.Tables("tbl_mahasiswa"))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
End Class
