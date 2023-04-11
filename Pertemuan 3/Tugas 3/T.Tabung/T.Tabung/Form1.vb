Public Class Form1
    Private Function HitungVol(jari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = 3.14 * (jari ^ 2) * tinggi
        Return volume
    End Function
    Private Function HitungLuas(jari As Integer, tinggi As Integer) As Integer
        Dim luas As Integer
        luas = 2 * 3.14 * jari * (jari + tinggi)
        Return luas
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, tinggi, volume, luasp As Integer
        jari = Val(txtJari.Text)
        tinggi = Val(txtTi.Text)
        volume = HitungVol(jari, tinggi)
        luasp = HitungLuas(jari, tinggi)
        txtVol.Text = Str(volume)
        txtLuasP.Text = Str(luasp)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
