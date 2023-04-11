Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, tinggi, volum, luasp As Integer
        panjang = Val(txtP.Text)
        lebar = Val(txtL.Text)
        tinggi = Val(txtT.Text)

        volum = panjang * lebar * tinggi
        luasp = 2 * (panjang * lebar + panjang * tinggi + lebar * tinggi)

        txtVolum.Text = Str(volum)
        txtLuasP.Text = Str(luasp)
    End Sub
End Class
