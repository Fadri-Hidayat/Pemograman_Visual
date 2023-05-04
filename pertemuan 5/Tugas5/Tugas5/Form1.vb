Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' Mengambil input dari pengguna
        Dim nim, nama, prodi, mutu As String
        Dim nkhdrn, ntgs, nuts, nuas As Decimal

        nim = txtNim.Text
        nama = txtNama.Text
        prodi = txtProdi.Text
        nkhdrn = CDec(txtNKehdr.Text)
        ntgs = CDec(txtNTugas.Text)
        nuts = CDec(txtUts.Text)
        nuas = CDec(txtUas.Text)


        ' Menghitung nilai akhir
        Dim nilaiAkhir As Decimal = (0.25 * nkhdrn) + (0.35 * ntgs) + (0.2 * nuts) + (0.2 * nuas)

        ' Menentukan nilai mutu
        If nilaiAkhir >= 85 And nilaiAkhir <= 100 Then
            mutu = "A"
        ElseIf nilaiAkhir >= 75 And nilaiAkhir < 85 Then
            mutu = "B"
        ElseIf nilaiAkhir >= 55 And nilaiAkhir < 75 Then
            mutu = "C"
        ElseIf nilaiAkhir >= 30 And nilaiAkhir < 55 Then
            mutu = "D"
        Else
            mutu = "E"
        End If

        ' Menampilkan hasil penilaian
        txtKtrNim.Text = nim
        txtKtrNama.Text = nama
        txtKtrProdi.Text = prodi
        txtKtrAkhir.Text = nilaiAkhir.ToString()
        txtKtrMutu.Text = mutu
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Mereset semua input dan output
        txtNim.Clear()
        txtNama.Clear()
        txtProdi.Clear()
        txtNKehdr.Clear()
        txtNTugas.Clear()
        txtUts.Clear()
        txtUas.Clear()
        txtKtrNim.Clear()
        txtKtrNama.Clear()
        txtKtrProdi.Clear()
        txtKtrAkhir.Clear()
        txtKtrMutu.Clear()
    End Sub

End Class
