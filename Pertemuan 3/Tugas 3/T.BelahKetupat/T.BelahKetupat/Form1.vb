Public Class Form1
    Private Function HtgLuas(diagonal1 As Integer, diagonal2 As Integer) As Integer
        Dim luas As Integer
        luas = (diagonal1 * diagonal2) / 2
        Return luas
    End Function
    Private Function HtgKellng(sisi As Integer) As Integer
        Dim keliling As Integer
        keliling = 4 * sisi
        Return keliling
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim diagonal1, diagonal2, sisi, luas, keliling As Integer
        diagonal1 = Val(txtD1.Text)
        diagonal2 = Val(txtD2.Text)
        sisi = Val(txtSisi.Text)

        luas = HtgLuas(diagonal1, diagonal2)
        keliling = HtgKellng(sisi)

        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub
End Class
