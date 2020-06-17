Public Class frmCarList
    Private Sub frmCarList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnListCars_Click(sender As Object, e As EventArgs) Handles btnListCars.Click
        'TODO: This line of code loads data into the 'TurksonCo_DataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.TurksonCo_DataSet.Vehicle)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim cancelOption = MessageBox.Show("Do you want to go back to the Main Menu?", "Back to Main Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmEmployeeMenu.Show()

            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
End Class