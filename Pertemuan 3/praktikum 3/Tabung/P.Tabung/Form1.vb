Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, tinggi, volume, luasp As Integer
        jari = Val(txtJari.Text)
        tinggi = Val(txtTi.Text)
        volume = 3.14 * jari ^ 2 * tinggi
        luasp = 2 * 3.14 * jari * (jari + tinggi)
        txtVol.Text = Str(volume)
        txtLuasP.Text = Str(luasp)

    End Sub
End Class
