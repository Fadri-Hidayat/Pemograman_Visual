Public Class Perhitungan

    Private Function HitungVolume(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim volume As Integer
        volume = panjang * lebar * tinggi
        Return volume
    End Function
    Private Function HitungLuasP(panjang As Integer, lebar As Integer, tinggi As Integer) As Integer
        Dim luasp As Integer
        luasp = 2 * (panjang * lebar + panjang * tinggi + lebar * tinggi)
        Return luasp
    End Function

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim panjang, lebar, tinggi, volum, luasp As Integer
        panjang = Val(txtP.Text)
        lebar = Val(txtLe.Text)
        tinggi = Val(txtTinggi.Text)

        volum = HitungVolume(panjang, lebar, tinggi)
        luasp = HitungLuasP(panjang, lebar, tinggi)

        txtVolum.Text = Str(volum)
        txtLuasP.Text = Str(luasp)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class

