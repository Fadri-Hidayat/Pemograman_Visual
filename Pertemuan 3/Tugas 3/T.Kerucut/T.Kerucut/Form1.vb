Public Class Form1
    Private Function HitungVol(jari As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = (3.14 * (jari ^ 2) * tinggi) / 3
        Return volume
    End Function
    Private Function HitungLuasP(jari As Integer, garisp As Integer) As Integer
        Dim volume As Integer
        volume = 3.14 * jari * (jari + garisp)
        Return volume
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, garisp, tinggi, volume, luasp As Integer
        jari = Val(txtJari.Text)
        garisp = Val(txtGP.Text)
        tinggi = Val(txtTinggi.Text)
        volume = HitungVol(jari, tinggi)
        luasp = HitungLuasP(jari, garisp)

        txtVol.Text = Str(volume)
        txtLuasp.Text = Str(luasp)

    End Sub
End Class
