Public Class F_Persegi
    Private Sub BTN_Kembali_Click(sender As Object, e As EventArgs) Handles BTN_Kembali.Click
        F_Home.Show()
        Me.Close()
    End Sub

    Private Sub BTN_Keliling_Click(sender As Object, e As EventArgs) Handles BTN_Keliling.Click
        TB_Hasil.Text = TB_Sisi1.Text * 2 + TB_Sisi2.Text * 2
    End Sub

    Private Sub BTN_Luas_Click(sender As Object, e As EventArgs) Handles BTN_Luas.Click
        TB_Hasil.Text = TB_Sisi1.Text * TB_Sisi2.Text
    End Sub

    Private Sub BTN_Kosongkan_Click(sender As Object, e As EventArgs) Handles BTN_Kosongkan.Click
        TB_Sisi1.Clear()
        TB_Sisi2.Clear()
        TB_Hasil.Clear()
        TB_Sisi1.Focus()
    End Sub
End Class