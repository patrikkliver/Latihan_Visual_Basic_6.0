Public Class F_Balok
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BTN_Kembali.Click
        F_Home.Show()
        Me.Close()
    End Sub

    Private Sub BTN_Volume_Click(sender As Object, e As EventArgs) Handles BTN_Volume.Click
        TB_Hasil.Text = TB_Panjang.Text * TB_Lebar.Text * TB_Tinggi.Text
    End Sub

    Private Sub BTN_Bersihkan_Click(sender As Object, e As EventArgs) Handles BTN_Bersihkan.Click
        TB_Panjang.Clear()
        TB_Lebar.Clear()
        TB_Tinggi.Clear()
        TB_Hasil.Clear()
        TB_Panjang.Focus()
    End Sub
End Class