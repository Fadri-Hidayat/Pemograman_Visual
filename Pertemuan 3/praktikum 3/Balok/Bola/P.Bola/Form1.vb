Public Class Form1
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
