Imports MySql.Data.MySqlClient

Public Class Form_Login

    Dim query As String
    Dim dr As MySqlDataReader
    Dim myCommand As MySqlCommand

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Db()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        Me.Close()
    End Sub

    Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
        If TB_Username.Text = "" Or TB_Password.Text = "" Then
            MsgBox("Username atau Password tidak boleh kosong")
        Else
            query = "select * from tbl_users where Id_Users = '" & TB_Username.Text & "' and Password = '" & TB_Password.Text & "'"
            myCommand = New MySqlCommand(query, conn)
            dr = myCommand.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                MsgBox(dr.GetString(0))
                Me.Close()

                Form_MenuUtama.LoginToolStripMenuItem.Enabled = False
                Form_MenuUtama.LogoutToolStripMenuItem.Enabled = True
                Form_MenuUtama.MasterToolStripMenuItem.Enabled = True
                Form_MenuUtama.TransaksiToolStripMenuItem.Enabled = True
                Form_MenuUtama.LaporanToolStripMenuItem.Enabled = True

                TB_Username.Clear()
                TB_Password.Clear()
            Else
                MsgBox("Username dan Password tidak terdaftar")
            End If
            dr.Close()

        End If
    End Sub
End Class