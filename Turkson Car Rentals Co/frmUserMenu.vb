Public Class frmUserMenu
    Private Sub frmUserMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = frmUserLogin.txtUserName.Text
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub AgreementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgreementToolStripMenuItem.Click
        frmAgreement.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        frmInvoice.Show()
    End Sub
End Class