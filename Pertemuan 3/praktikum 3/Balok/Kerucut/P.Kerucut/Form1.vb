Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, garisp, tinggi, volume, luasp As Integer
        jari = Val(txtJari.Text)
        garisp = Val(txtGP.Text)
        tinggi = Val(txtTinggi.Text)
        volume = (3.14 * (jari ^ 2) * tinggi) / 3
        luasp = 3.14 * jari * (jari + garisp)

        txtVol.Text = Str(volume)
        txtLuasp.Text = Str(luasp)

    End Sub
End Class
