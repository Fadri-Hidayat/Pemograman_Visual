Public Class Form1
    Private Sub cmbFakultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFakultas.Items.Clear()
        cmbFakultas.Items.Add("TEKNIK")
        cmbFakultas.Items.Add("FKIP")
        cmbFakultas.Items.Add("FIKES")
        cmbFakultas.Items.Add("FISIP")
        cmbFakultas.Items.Add("FE")
        cmbFakultas.Items.Add("FH")
    End Sub

    Private Sub cmbProdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProdi.Items.Clear()
        cmbProdi.Items.Add("Teknik Informatika")
        cmbProdi.Items.Add("Teknik Industri")
        cmbProdi.Items.Add("Peternakan")
        cmbProdi.Items.Add("D3 Teknik Informatika")
        cmbProdi.Items.Add("D3 Teknik Industri")
        cmbProdi.Items.Add("Pendidikan Matematika")
        cmbProdi.Items.Add("Pendidikan Kimia")
        cmbProdi.Items.Add("PG SD")
        cmbProdi.Items.Add("PG PAUD")
        cmbProdi.Items.Add("Keperawatan")
        cmbProdi.Items.Add("Ilmu Keolahragaan")
        cmbProdi.Items.Add("Ilmu Gizi")
        cmbProdi.Items.Add("Ilmu Komunikasi")
        cmbProdi.Items.Add("Ilmu Pemerintahan")
        cmbProdi.Items.Add("Manajemen")
        cmbProdi.Items.Add("Akuntansi")
        cmbProdi.Items.Add("Ilmu Hukum")

    End Sub

    Private Sub cmbSemester_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSMTR.Items.Clear()
        cmbSMTR.Items.Add("1")
        cmbSMTR.Items.Add("2")
        cmbSMTR.Items.Add("3")
        cmbSMTR.Items.Add("4")
        cmbSMTR.Items.Add("5")
        cmbSMTR.Items.Add("6")
        cmbSMTR.Items.Add("7")
        cmbSMTR.Items.Add("8")
    End Sub

    Private Sub cmbProdi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProdi.SelectedIndexChanged
        If cmbProdi.Text = "Teknik Informatika" Then
            txtBiaya.Text = "4500000"
        ElseIf cmbProdi.Text = "Teknik Industri" Then
            txtBiaya.Text = "4250000"
        ElseIf cmbProdi.Text = "Peternakan" Then
            txtBiaya.Text = "3500000"
        ElseIf cmbProdi.Text = " D3 Teknik Industri" Then
            txtBiaya.Text = "3000000"
        ElseIf cmbProdi.Text = "D3 Teknik Informatika" Then
            txtBiaya.Text = "3300000"
        ElseIf cmbProdi.Text = "Pendidikan Matematika" Then
            txtBiaya.Text = "3000000"
        ElseIf cmbProdi.Text = "Pendidikan Kimia" Then
            txtBiaya.Text = "2900000"
        ElseIf cmbProdi.Text = "PG SD" Then
            txtBiaya.Text = "2800000"
        ElseIf cmbProdi.Text = "PG PAUD" Then
            txtBiaya.Text = "2600000"
        ElseIf cmbProdi.Text = "Keperawatan" Then
            txtBiaya.Text = "7000000"
        ElseIf cmbProdi.Text = "Ilmu keolahragaan" Then
            txtBiaya.Text = "2500000"
        ElseIf cmbProdi.Text = "Ilmu Gizi" Then
            txtBiaya.Text = "5000000"
        ElseIf cmbProdi.Text = "Ilmu Komunikasi" Then
            txtBiaya.Text = "3800000"
        ElseIf cmbProdi.Text = "Ilmu Pemerintahan" Then
            txtBiaya.Text = "3700000"
        ElseIf cmbProdi.Text = "Manajemen" Then
            txtBiaya.Text = "3400000"
        ElseIf cmbProdi.Text = "Akuntansi" Then
            txtBiaya.Text = "3600000"
        ElseIf cmbProdi.Text = "Ilmu Hukum" Then
            txtBiaya.Text = "3850000"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        txtSisa.Text = Val(txtBiaya.Text) - Val(txtPmbryan.Text)
    End Sub

End Class
