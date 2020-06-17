Public Class frmRentalList
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim cancelOption = MessageBox.Show("Do you want to go back to the Main Menu?", "Back to Main Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmEmployeeMenu.Show()

            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub frmRentalList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewList_Click(sender As Object, e As EventArgs) Handles btnViewList.Click
        'TODO: This line of code loads data into the 'TurksonCo_DataSet.Rental_List' table. You can move, or remove it, as needed.
        Me.Rental_ListTableAdapter.Fill(Me.TurksonCo_DataSet.Rental_List)

    End Sub
End Class