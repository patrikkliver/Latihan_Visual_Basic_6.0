Imports MySql.Data.MySqlClient

Public Class Form_Admin
    Dim query As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim dr As MySqlDataReader
    Dim myCommand As MySqlCommand

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Db()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub KondisiAwal()
        query = "select * from tbl_users"
        da = New MySqlDataAdapter(query, conn)
        ds = New DataSet()
        ds.Clear()
        da.Fill(ds, "tbl_users")
        DG_AllUser.DataSource = (ds.Tables("tbl_users"))

        TB_IdUser.Clear()
        TB_Nama.Clear()
        TB_Password.Clear()
        CB_RoleId.Text = ""
        CB_RoleId.Items.Clear()
        CB_RoleId.Items.Add("30")
        CB_RoleId.Items.Add("10")
    End Sub

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub BTN_Simpan_Click(sender As Object, e As EventArgs) Handles BTN_Simpan.Click
        query = "insert into tbl_users values('" & TB_IdUser.Text & "', '" & TB_Nama.Text & "', '" & TB_Password.Text & "', '" & CB_RoleId.Text & "')"
        myCommand = New MySqlCommand(query, conn)
        myCommand.ExecuteNonQuery()

        TB_IdUser.Clear()
        TB_Nama.Clear()
        TB_Password.Clear()
        CB_RoleId.Text = ""
        Call KondisiAwal()
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        Db()
        query = "delete from tbl_users where Id_Users = '" & TB_IdUser.Text & "'"
        myCommand = New MySqlCommand(query, conn)
        myCommand.ExecuteNonQuery()

        MsgBox("Data Berhasil di Hapus")
        Call KondisiAwal()
    End Sub

    Private Sub BTN_Update_Click(sender As Object, e As EventArgs) Handles BTN_Update.Click
        Db()
        query = "update tbl_users set Id_Users = '" & TB_IdUser.Text & "', Nama = '" & TB_Nama.Text & "', Password = '" & TB_Password.Text & "', Role_Id = '" & CB_RoleId.Text & "' where Id_Users = '" & TB_IdUser.Text & "'"
        myCommand = New MySqlCommand(query, conn)
        myCommand.ExecuteNonQuery()

        MsgBox("Data Berhasil di Edit")
        Call KondisiAwal()
    End Sub

    Private Sub TB_IdUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_IdUser.KeyPress
        If e.KeyChar = Chr(13) Then
            query = "select * from tbl_users where Id_Users = '" & TB_IdUser.Text & "'"
            myCommand = New MySqlCommand(query, conn)
            dr = myCommand.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                TB_IdUser.Text = dr.Item("Id_Users")
                TB_Nama.Text = dr.Item("Nama")
                TB_Password.Text = dr.Item("Password")
                CB_RoleId.Text = dr.Item("Role_Id")
            Else
                MsgBox("Data Tidak di Temukan")
            End If
        End If
        Me.Refresh()
    End Sub
End Class