Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeMakanan.Text
            Case "SB" : txtKeterangan.Text = "Sosis Bakar"

            Case "NGR" : txtKeterangan.Text = "Nasi Goreng"

            Case "ABKR" : txtKeterangan.Text = "Ayam Bakar"

            Case Else : txtKeterangan.Text = "Tidak Ada kode menu makanan"
        End Select
    End Sub

End Class
