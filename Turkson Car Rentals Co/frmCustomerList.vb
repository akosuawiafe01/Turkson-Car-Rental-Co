Public Class frmCustomerList
    Private Sub frmCustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'TODO: This line of code loads data into the 'TurksonCo_DataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.TurksonCo_DataSet.Client)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cancelOption = MessageBox.Show("Do you want to go back to the Main Menu?", "Back to Main Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmEmployeeMenu.Show()

            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class