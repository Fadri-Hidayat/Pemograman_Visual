Public Class Form1
    Private Function HitungVolume(sisi As Integer) As Integer
        Dim volume As Integer
        volume = sisi ^ 3
        Return volume
    End Function
    Private Function HitungLuasP(sisi As Integer) As Integer
        Dim luas As Integer
        luas = 6 * (sisi ^ 2)
        Return luas
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, volume, luasp As Integer
        sisi = Val(txtSisi.Text)
        volume = HitungVolume(sisi)
        luasp = HitungLuasP(sisi)
        txtVolum.Text = Str(volume)
        txtLuasP.Text = Str(luasp)
    End Sub
End Class
