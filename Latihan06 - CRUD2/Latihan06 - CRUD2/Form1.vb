Imports MySql.Data.MySqlClient

Public Class Form_MenuUtama
    Dim query As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Db()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'query = "select * from tbl_users"
        'da = New MySqlDataAdapter(query, conn)
        'ds = New DataSet()
        'ds.Clear()
        'da.Fill(ds, "tbl_users")
        'DG1.DataSource = (ds.Tables("tbl_users"))
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Form_Login.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        Form_Admin.ShowDialog()
    End Sub
End Class
