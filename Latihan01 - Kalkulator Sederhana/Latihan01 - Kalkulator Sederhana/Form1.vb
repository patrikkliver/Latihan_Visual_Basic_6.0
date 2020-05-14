Public Class Form1
    Private Sub BTN_Tambah_Click(sender As Object, e As EventArgs) Handles BTN_Tambah.Click
        TB_Hasil.Text = Val(TB_Angka1.Text) + Val(TB_Angka2.Text)
    End Sub

    Private Sub BTN_Kurang_Click(sender As Object, e As EventArgs) Handles BTN_Kurang.Click
        TB_Hasil.Text = Val(TB_Angka1.Text) - Val(TB_Angka2.Text)
    End Sub

    Private Sub BTN_Kali_Click(sender As Object, e As EventArgs) Handles BTN_Kali.Click
        TB_Hasil.Text = Val(TB_Angka1.Text) * Val(TB_Angka2.Text)
    End Sub

    Private Sub BTN_Bagi_Click(sender As Object, e As EventArgs) Handles BTN_Bagi.Click
        TB_Hasil.Text = Val(TB_Angka1.Text) / Val(TB_Angka2.Text)
    End Sub

    Private Sub BTN_Kosongkan_Click(sender As Object, e As EventArgs) Handles BTN_Kosongkan.Click
        TB_Angka1.Clear()
        TB_Angka2.Clear()
        TB_Hasil.Clear()
        TB_Angka1.Focus()
    End Sub

    Private Sub BTN_Keluar_Click(sender As Object, e As EventArgs) Handles BTN_Keluar.Click
        Me.Close()
    End Sub
End Class
