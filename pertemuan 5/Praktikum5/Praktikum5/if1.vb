Public Class if1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtPoint.Text) >= 2500) Then
            txtKeterangan.Text = "Anda mendapat mobil remot"

        ElseIf (txtPoint.Text >= 2000) Then
            txtKeterangan.Text = "Anda mendapat boneka kecil"

        ElseIf (txtPoint.Text >= 1500) Then
            txtKeterangan.Text = "Anda mendapat Pengerut Pensil"

        ElseIf (txtPoint.Text >= 1000) Then
            txtKeterangan.Text = "Anda mendapat Pulpen 3 Warna"

        Else
            txtKeterangan.Text = "Maaf tidak dapat apa apa "
        End If
    End Sub
End Class