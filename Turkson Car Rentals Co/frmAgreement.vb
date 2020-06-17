Public Class frmAgreement
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim cancelOption = MessageBox.Show("Do you want to go back to the Main Menu?", "Back to Main Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmEmployeeMenu.Show()

            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmAgreement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class