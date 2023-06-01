Public Class mdiMenu
    Private Sub StokToolStripMenuItemn_Click(sender As Object, e As EventArgs) Handles StokToolStripMenuItem.Click
        frmStok.MdiParent = Me
        frmStok.Show()
    End Sub
    Private Sub CustomerToolStripMenuItemn_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        frmCustomer.MdiParent = Me
        frmCustomer.Show()
    End Sub
    Private Sub SupplierToolStripMenuItemn_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        frmSupplier.MdiParent = Me
        frmSupplier.Show()
    End Sub
End Class