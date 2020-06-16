Public Class frmEmployeeLogin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim empPass, empname As String

        empPass = txtEmpPasss.Text
        empname = txtEmpName.Text


        Dim strCon As String = "Data Source=.;Initial Catalog=TimtimTourApp-Db;Integrated Security=True"
        Dim strSQL As String = "Select * from Employee where empUsername='" & empname & "' and empPassword ='" & empPass & "' "
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, strCon)
        'Dim sqlCmd As SqlClient.SqlCommand
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        If dataTable.Rows.Count > 0 Then
            frmEmployeeMenu.Show()
            Me.Hide()

        Else
            MessageBox.Show("Enter a correct username or password", "Incorrect Details")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmUserLogin.Show()
    End Sub
End Class