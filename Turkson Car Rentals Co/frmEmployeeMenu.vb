Public Class frmEmployeeMenu
    Private Sub frmEmployeeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = frmUserLogin.txtUserName.Text
    End Sub

    Private Sub RentACarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentACarToolStripMenuItem.Click
        frmRentalList.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        frmInvoice.Show()
    End Sub


    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        frmEmployeeLogin.txtEmpName.Clear()
        frmEmployeeLogin.txtEmpPasss.Clear()

        frmEmployeeLogin.Show()
        Me.Hide()

    End Sub

    Private Sub SearchForACustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchForACustomerToolStripMenuItem.Click
        frmSearchCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub AgreementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgreementToolStripMenuItem.Click
        frmCarList.Show()
        Me.Hide()
    End Sub
End Class