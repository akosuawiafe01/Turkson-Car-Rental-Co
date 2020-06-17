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

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        frmInvoice.Show()
    End Sub

    Private Sub RentACarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RentACarToolStripMenuItem.Click
        frmRentCar.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmUserLogin.txtUserName.Clear()
        frmUserLogin.txtUserpasss.Clear()

        Me.Hide()
        frmUserLogin.Show()
    End Sub
End Class