Public Class frmEmployeeMenu
    Private Sub frmEmployeeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = frmUserLogin.txtUserName.Text
    End Sub

    Private Sub RentACarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentACarToolStripMenuItem.Click
        frmCustomersList.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        frmInvoice.Show()
    End Sub
End Class