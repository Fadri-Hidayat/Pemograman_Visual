Public Class Form1
    Private Function HtgHasil(bilangan1 As Integer, bilangan2 As Integer) As Integer
        Dim penjumlahan As Integer
        penjumlahan = bilangan1 + bilangan2
        Return penjumlahan
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim bilangan1, bilangan2, hasil As Integer
        bilangan1 = Val(txtB1.Text)
        bilangan2 = Val(txtB2.Text)
        hasil = HtgHasil(bilangan1, bilangan2)
        txtHsl.Text = Str(hasil)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
