Public Class if2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtTotalNilaiUN.Text) >= 350) Then
            txtKeterangan.Text = "Anda mendapat handphone baru"

        ElseIf (txtTotalNilaiUN.Text >= 300) Then
            txtKeterangan.Text = "Anda mendapat sepatu baru"

        ElseIf (txtTotalNilaiUN.Text >= 250) Then
            txtKeterangan.Text = "Anda mendapat buku"
        Else
            txtKeterangan.Text = "Maaf Nilai Anda Tidak Bagus Dan Tidak dapat hadiah "
        End If
    End Sub
End Class