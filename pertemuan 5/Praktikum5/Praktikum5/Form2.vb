Public Class Form2

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtPisang.Text
            Case "PA" : txtKeterangan.Text = "Pisang Ambon"

            Case "PR" : txtKeterangan.Text = "Pisang Raja"

            Case "PK" : txtKeterangan.Text = "Pisang Klutuk"

            Case Else : txtKeterangan.Text = "Tidak Ada kode nama pisang"
        End Select
    End Sub
End Class