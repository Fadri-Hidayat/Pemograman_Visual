Public Class Form2
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtMasaKerja.Text) >= 20) Then
            txtKeterangan.Text = "Selamat Anda Mendapatkan THR 1 Rumah"

        ElseIf (txtMasaKerja.Text >= 15) Then
            txtKeterangan.Text = "Selamat Anda Mendapatkan THR mobil"

        ElseIf (txtMasaKerja.Text >= 10) Then
            txtKeterangan.Text = "Selamat Anda Mendapatkan THR motor"

        ElseIf (txtMasaKerja.Text >= 5) Then
            txtKeterangan.Text = "Anda mendapat THR handphone"

        Else
            txtKeterangan.Text = "Anda mendapat THR uang Rp. 200.000"
        End If
    End Sub

    Private Sub txtKeterangan_TextChanged(sender As Object, e As EventArgs) Handles txtKeterangan.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class