Public Class frmSearchCustomer

    Dim clientAdapter As TurksonCo_DataSetTableAdapters.ClientTableAdapter = New TurksonCo_DataSetTableAdapters.ClientTableAdapter
    Dim clientDataset As TurksonCo_DataSet = New TurksonCo_DataSet()

    'Variable for storing rental data collected
    Dim clientRow As TurksonCo_DataSet.ClientRow

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        clientRow = clientDataset.Client.NewRow

        clientAdapter.FillBy(clientDataset.Client, txtUserID.Text)

        If clientDataset.Client.Rows.Count > 0 Then
            clientRow = clientDataset.Client.Rows(0)

            txtFN.Text = clientRow.firstName
            txtON.Text = clientRow.otherName
            txtLN.Text = clientRow.lastname
            dtpDOB.Value = clientRow.DOB
            txtLicNo.Text = clientRow.LicenseNo
            txtContact.Text = clientRow.contact
            txtEmail.Text = clientRow.email
            txtResAddr.Text = clientRow.residenceLocation
            txtUsername.Text = clientRow.username
            txtUserPassss.Text = clientRow.password

            fieldsStats(False)
        End If

    End Sub

    Public Sub fieldsStats(value As Boolean)
        txtUserPassss.Text = value
        txtUsername.Text = value
        txtResAddr.Text = value
        txtEmail.Text = value
        txtContact.Text = value
        txtLicNo.Text = value
        txtLN.Text = value
        txtON.Text = value
        txtFN.Text = value
        txtUserID.Text = value

        dtpDOB.Enabled = value
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        fieldsStats(True)
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        fieldsStats(True)
    End Sub
End Class