Public Class Form1
    Private Function HitungVol(jari As Integer) As Integer
        Dim volume As Integer
        volume = (4 * 3.14 * (jari ^ 3)) / 3
        Return volume
    End Function
    Private Function HitungluasP(jari As Integer) As Integer
        Dim luas As Integer
        luas = 4 * 3.14 * (jari ^ 2)
        Return luas
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jari, volume, luasp As Integer
        jari = Val(txtJari.Text)
        volume = (4 * 3.14 * (jari ^ 3)) / 3
        luasp = 4 * 3.14 * jari ^ 2

        txtVol.Text = Str(volume)
        txtLuasp.Text = Str(luasp)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
