Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim sisi, volume, luasp As Integer
        sisi = Val(txtSisi.Text)
        volume = sisi ^ 3
        luasp = 6 * (sisi ^ 2)
        txtVolum.Text = Str(volume)
        txtLuasP.Text = Str(luasp)
    End Sub
End Class
