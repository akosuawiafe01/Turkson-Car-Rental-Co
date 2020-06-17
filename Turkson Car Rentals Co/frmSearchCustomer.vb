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


        End If

        fieldsStats(False)

    End Sub

    Public Sub fieldsStats(value As Boolean)
        txtUserPassss.Enabled = value
        txtUsername.Enabled = value
        txtResAddr.Enabled = value
        txtEmail.Enabled = value
        txtContact.Enabled = value
        txtLicNo.Enabled = value
        txtLN.Enabled = value
        txtON.Enabled = value
        txtFN.Enabled = value
        txtUserID.Enabled = value
        dtpDOB.Enabled = value
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        fieldsStats(True)

        clientAdapter.UpdateClientTable(txtFN.Text, txtLN.Text, txtON.Text, dtpDOB.Value.Date, txtLicNo.Text, txtContact.Text, txtEmail.Text, txtResAddr.Text, txtUsername.Text, txtUserPassss.Text, txtUserID.Text)
        MessageBox.Show("Updates saved!", "Turkson Car Rentals Company")
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        clearAllFields()
        fieldsStats(True)



    End Sub


    Public Sub clearAllFields()
        txtUserPassss.Clear()
        txtUsername.Clear()
        txtResAddr.Clear()
        txtEmail.Clear()
        txtContact.Clear()
        txtLicNo.Clear()
        txtLN.Clear()
        txtON.Clear()
        txtFN.Clear()
        txtUserID.Clear()
        'dtpDOB.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            clientRow = clientDataset.Client.NewRow

            clientRow.password = txtUserPassss.Text
            clientRow.username = txtUsername.Text
            clientRow.residenceLocation = txtResAddr.Text
            clientRow.email = txtEmail.Text
            clientRow.contact = txtContact.Text
            clientRow.LicenseNo = txtLicNo.Text
            clientRow.lastname = txtLN.Text
            clientRow.otherName = txtON.Text
            clientRow.firstName = txtFN.Text
            clientRow.clientID = txtUserID.Text
            clientRow.DOB = dtpDOB.Value.Date




            If txtUserID.Text = "" Then
                MessageBox.Show("User ID column cannot be left null")
            Else
                'saving the Courses into the database
                clientDataset.Client.AddClientRow(clientRow)
                clientAdapter.Update(clientDataset.Client)

                'transDataSet.Transcript.AddTranscriptRow(transRow)
                'transAdapter.Update(transDataSet.Transcript)



                'Saving data into database
                MessageBox.Show("New Client Added sucessfully", "Turkson Car Rentals Company")
                clearAllFields()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim cancelOption = MessageBox.Show("Do you want to stop this process?", "Turkson Car Rental Co.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)


        If cancelOption = DialogResult.Yes Then
            frmUserMenu.Show()

            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
End Class