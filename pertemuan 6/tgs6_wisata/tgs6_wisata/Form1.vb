Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim harga As Integer

        'Cek kategori tiket yang dipilih
        If rbnAnak.Checked Then
            harga = 30000 'Harga tiket anak-anak
        ElseIf rbnDewasa.Checked Then
            harga = 60000 'Harga tiket dewasa
        Else
            MessageBox.Show("Pilih kategori tiket terlebih dahulu")
            Exit Sub
        End If

        'Tampilkan harga tiket
        txtHargaT.Text = harga.ToString
    End Sub
End Class
