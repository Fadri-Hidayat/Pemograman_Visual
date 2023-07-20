Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub Reload()
        oMatakuliah.getAllData(DataGridView1)
    End Sub

    Private Sub txtKodeMK_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeMK.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oMatakuliah.Carimatakuliah(txtKodeMK.Text)
            If (matakuliah_baru = False) Then
                TampilMatakuliah()
            Else
                MessageBox.Show("Data tidak ditemukan")
                matakuliah_baru = True
            End If
        End If
    End Sub

    Private Sub TampilMatakuliah()
        txtKodeMK.Text = oMatakuliah.kodemk
        txtNamaMK.Text = oMatakuliah.namamk
        txtSKS.Text = oMatakuliah.sks
        txtProdi.Text = oMatakuliah.prodi
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearEntry()
    End Sub

    Private Sub ClearEntry()
        txtKodeMK.Clear()
        txtNamaMK.Clear()
        txtSKS.Clear()
        txtProdi.Clear()
        txtKodeMK.Focus()
    End Sub

    Private Sub SimpanDatamatakuliah()
        oMatakuliah.kodemk = txtKodeMK.Text
        oMatakuliah.namamk = txtNamaMK.Text
        oMatakuliah.sks = txtSKS.Text
        oMatakuliah.prodi = txtProdi.Text
        oMatakuliah.Simpan()
        Reload()
        If (oMatakuliah.InsertState = True) Then
            MessageBox.Show("Data berhasil disimpan.")
        ElseIf (oMatakuliah.UpdateState = True) Then
            MessageBox.Show("Data berhasil diperbarui.")
        Else
            MessageBox.Show("Data gagal disimpan.")
        End If
        ClearEntry()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If (txtKodeMK.Text <> "" And txtNamaMK.Text <> "") Then
            SimpanDatamatakuliah()
            ClearEntry()
            Reload()
        Else
            MessageBox.Show("kode mk dan nama mk tidak boleh kosong!")
        End If
    End Sub

    Private Sub Hapus()
        If (matakuliah_baru = False And txtKodeMK.Text <> "") Then
            oMatakuliah.hapus(txtKodeMK.Text)
            ClearEntry()
            Reload()
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah data akan dihapus", "Confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
        Else
            MessageBox.Show("Data batal dihapus")
        End If

    End Sub
End Class
