Public Class Form1
    Private Function Hitungluas(jari As Integer) As Integer
        Dim luas As Integer
        luas = 3.14 * (jari ^ 2)
        Return luas
    End Function
    Private Function Hitungkeliling(jari As Integer) As Integer
        Dim keliling As Integer
        keliling = 2 * 3.14 * jari
        Return keliling
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, luas, keliling As Integer
        jari = Val(txtJari.Text)
        luas = Hitungluas(jari)
        keliling = Hitungkeliling(jari)
        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
