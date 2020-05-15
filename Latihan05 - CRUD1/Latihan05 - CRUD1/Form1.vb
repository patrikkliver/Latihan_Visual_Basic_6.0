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
        CB_JenisKelamin.Text = ""
        CB_JenisKelamin.Items.Add("Pria")
        CB_JenisKelamin.Items.Add("Wanita")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub BTN_Keluar_Click(sender As Object, e As EventArgs) Handles BTN_Keluar.Click
        Me.Close()
    End Sub

    Private Sub BTN_Input_Click(sender As Object, e As EventArgs) Handles BTN_Input.Click
        Call Koneksi()
        Dim InputData As String = "insert into tbl_mahasiswa values('" & TB_Nim.Text & "', '" & TB_Nama.Text & "', '" & CB_JenisKelamin.Text & "', '" & TB_Alamat.Text & "', '" & TB_Telepon.Text & "')"
        Cmd = New SqlCommand(InputData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Input")
        Call KondisiAwal()
    End Sub

    Private Sub BTN_Update_Click(sender As Object, e As EventArgs) Handles BTN_Update.Click
        Call Koneksi()
        Dim EditData As String = "update tbl_mahasiswa set Nama = '" & TB_Nama.Text & "', JenisKelamin = '" & CB_JenisKelamin.Text & "', Alamat = '" & TB_Alamat.Text & "', Tlpn = '" & TB_Telepon.Text & "' where Nim = '" & TB_Nim.Text & "'"
        Cmd = New SqlCommand(EditData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Edit")
        Call KondisiAwal()
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        Call Koneksi()
        Dim DelData As String = "delete tbl_mahasiswa where Nim = '" & TB_Nim.Text & "'"
        Cmd = New SqlCommand(DelData, Conn)
        Cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus")
        Call KondisiAwal()
    End Sub
End Class
