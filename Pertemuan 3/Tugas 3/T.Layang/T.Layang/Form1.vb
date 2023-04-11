Public Class Form1
    Private Function HtgLuas(diagonal1 As Integer, diagonal2 As Integer) As Integer
        Dim luas As Integer
        luas = (diagonal1 * diagonal2) / 2
        Return luas
    End Function
    Private Function HtgKel(sisia As Integer, sisib As Integer, sisic As Integer, sisid As Integer) As Integer
        Dim keliling As Integer
        keliling = sisia + sisib + sisic + sisid
        Return keliling
    End Function
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim diagonal1, diagonal2, sisia, sisib, sisic, sisid, luas, keliling As Integer
        diagonal1 = Val(txtD1.Text)
        diagonal2 = Val(txtD2.Text)
        sisia = Val(txtSisiA.Text)
        sisib = Val(txtSisiB.Text)
        sisic = Val(txtSIsiC.Text)
        sisid = Val(txtSisiD.Text)
        luas = HtgLuas(diagonal1, diagonal2)
        keliling = HtgKel(sisia, sisib, sisic, sisid)
        txtLuas.Text = Str(luas)
        txtKeliling.Text = Str(keliling)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtD1_TextChanged(sender As Object, e As EventArgs) Handles txtD1.TextChanged

    End Sub
End Class
