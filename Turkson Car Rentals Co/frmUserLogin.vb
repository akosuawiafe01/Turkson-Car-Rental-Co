Public Class frmUserLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userPass, username As String

        userPass = txtUserpasss.Text
        username = txtUserName.Text


        Dim strCon As String = "Data Source=.;Initial Catalog=TurksonCo-Db;Integrated Security=True"
        Dim strSQL As String = "Select * from Client where username='" & username & "' and password ='" & userPass & "' "
        Dim dataAdapter As New SqlClient.SqlDataAdapter(strSQL, strCon)
        'Dim sqlCmd As SqlClient.SqlCommand
        Dim dataTable As New DataTable
        dataAdapter.Fill(dataTable)

        If dataTable.Rows.Count > 0 Then
            frmUserMenu.Show()
            Me.Hide()

        Else
            MessageBox.Show("Enter a correct username or password", "Incorrect Details")
        End If

    End Sub

    Private Sub empLogin_Click(sender As Object, e As EventArgs) Handles empLogin.Click
        frmEmployeeLogin.Show()
        Me.Hide()
    End Sub
End Class