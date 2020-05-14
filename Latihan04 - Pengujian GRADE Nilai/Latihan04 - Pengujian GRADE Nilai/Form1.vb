Public Class Form1
    Private Sub BTN_Bersihkan_Click(sender As Object, e As EventArgs) Handles BTN_Bersihkan.Click
        TB_Tugas.Clear()
        TB_Quiz.Clear()
        TB_Uts.Clear()
        TB_Uas.Clear()
        TB_Tugas.Focus()
    End Sub

    Private Sub BTN_Keluar_Click(sender As Object, e As EventArgs) Handles BTN_Keluar.Click
        Me.Close()
    End Sub

    Private Sub TB_Tugas_TextChanged(sender As Object, e As EventArgs) Handles TB_Tugas.TextChanged
        L_Tugas.Text = TB_Tugas.Text * 0.25
    End Sub

    Private Sub TB_Quiz_TextChanged(sender As Object, e As EventArgs) Handles TB_Quiz.TextChanged
        L_Quiz.Text = TB_Quiz.Text * 0.15
    End Sub

    Private Sub TB_Uts_TextChanged(sender As Object, e As EventArgs) Handles TB_Uts.TextChanged
        L_Uts.Text = TB_Uts.Text * 0.3
    End Sub

    Private Sub TB_Uas_TextChanged(sender As Object, e As EventArgs) Handles TB_Uas.TextChanged
        L_Uas.Text = TB_Uas.Text * 0.3
    End Sub

    Private Sub BTN_Proses_Click(sender As Object, e As EventArgs) Handles BTN_Proses.Click
        Dim Total As String

        TB_TotalNilai.Text = Val(L_Tugas.Text) + Val(L_Quiz.Text) + Val(L_Uts.Text) + Val(L_Uas.Text)

        Total = TB_TotalNilai.Text
        If Total >= 85 Then
            TB_GradeNilai.Text = "A"
        ElseIf Total >= 75 And Total < 85 Then
            TB_GradeNilai.Text = "AB"
        ElseIf Total >= 65 And Total < 75 Then
            TB_GradeNilai.Text = "B"
        ElseIf Total >= 50 And Total < 65 Then
            TB_GradeNilai.Text = "BC"
        ElseIf Total >= 40 And Total < 50 Then
            TB_GradeNilai.Text = "C"
        Else
            TB_GradeNilai.Text = "D"
        End If
    End Sub

End Class
