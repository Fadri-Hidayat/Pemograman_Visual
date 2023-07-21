Public Class Dashboard
    Private Sub SparepartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuSparepart.Click
        Sparepart.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuCustomer.Click
        Customer.ShowDialog()
    End Sub

    Private Sub TransToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuTransaksi.Click
        Transaksi.ShowDialog()
    End Sub

    Private Sub MatikanSemuaMenu()
        MenuAdminBar.Visible = False
        LoginBar.Visible = True
        LogoutBar.Visible = False
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        MatikanSemuaMenu()
    End Sub

    Private Sub LoginBar_Click(sender As Object, e As EventArgs) Handles LoginBar.Click
        login.ShowDialog()
    End Sub

    Private Sub LogoutBar_Click(sender As Object, e As EventArgs) Handles LogoutBar.Click
        MatikanSemuaMenu()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatikanSemuaMenu()
    End Sub

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Jika user login adalah Admin
        If (admin_role = True) Then
            MenuAdminBar.Visible = True
            LoginBar.Visible = False
            LogoutBar.Visible = True
        End If
    End Sub

    Private Sub ExitBar_Click(sender As Object, e As EventArgs) Handles ExitBar.Click
        End
    End Sub

    Private Sub MenuAdminBar_Click(sender As Object, e As EventArgs) Handles MenuAdminBar.Click

    End Sub
End Class