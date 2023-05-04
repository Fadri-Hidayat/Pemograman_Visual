Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtNilaiAkhir.Text) >= 70) Then
            txtKeterangan.Text = "Selamat, Anda Lulus"
        Else
            txtKeterangan.Text = "Anda tidak Lulus, Silahkan mengulang tahun depan"
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
