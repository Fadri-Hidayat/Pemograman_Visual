Public Class Form3
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeJabatan.Text
            Case "MNGR" : txtKeterangan.Text = "Manager"

            Case "SKTR" : txtKeterangan.Text = "Sekretaris"

            Case "BDH" : txtKeterangan.Text = "Bendahara"

            Case Else : txtKeterangan.Text = "Staff"
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub
End Class