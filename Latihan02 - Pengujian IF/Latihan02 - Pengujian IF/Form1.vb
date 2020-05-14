Public Class Form1
    Private Sub BTN_Keluar_Click(sender As Object, e As EventArgs) Handles BTN_Keluar.Click
        Me.Close()
    End Sub

    Private Sub BTN_Kosongkan_Click(sender As Object, e As EventArgs) Handles BTN_Kosongkan.Click
        TB_Nim.Clear()
        TB_Nama.Clear()
        TB_Alamat.Clear()
        TB_Nohp.Clear()
        TB_Nim.Focus()
    End Sub

    Private Sub BTN_Cari_Click(sender As Object, e As EventArgs) Handles BTN_Cari.Click
        Dim nim As String
        nim = TB_Nim.Text

        If (nim = "15024043") Then
            TB_Nama.Text = "Patrik Kliver Oroh"
            TB_Alamat.Text = "Jl.Mapelong Link 4 Walian 1 Tomohon Selatan"
            TB_Nohp.Text = "0821xxxxxxxx"
        ElseIf nim = "15024099" Then
            TB_Nama.Text = "Kasih Nunuhitu"
            TB_Alamat.Text = "Sagerat Weru satu, Bitung"
            TB_Nohp.Text = "0821xxxxxxxx"
        Else
            MsgBox("Maaf, Data Tidak di Temukan")
            TB_Nim.Clear()
            TB_Nama.Clear()
            TB_Alamat.Clear()
            TB_Nohp.Clear()
            TB_Nim.Focus()
        End If
    End Sub
End Class
