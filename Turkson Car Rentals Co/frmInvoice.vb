Imports System.Data.SqlClient


Public Class frmInvoice

    Dim randInt As Integer = 10

    Dim invoiceAdapter As TurksonCo_DataSetTableAdapters.Transaction_InvoiceTableAdapter = New TurksonCo_DataSetTableAdapters.Transaction_InvoiceTableAdapter
    Dim invoiceDataset = New TurksonCo_DataSet()

    'Variable for storing rental data collected
    Dim invoiceRow As TurksonCo_DataSet.Transaction_InvoiceRow
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCost.TextChanged

    End Sub

    Private Sub TextBox9_Leave(sender As Object, e As EventArgs) Handles txtHourRental.Leave

    End Sub

    Private Sub cmbPayType_Leave(sender As Object, e As EventArgs) Handles cmbPayType.Leave
        Dim totalCost, duration, hourRent As Integer

        duration = Val(txtDuration.Text)
        hourRent = Val(txtHourRental.Text)

        totalCost = (duration * hourRent)

        totalCost = Format(totalCost, "0.00")

        txtTotalCost.Text = totalCost.ToString

    End Sub

    Private Sub btnPayforCar_Click(sender As Object, e As EventArgs) Handles btnPayforCar.Click
        Try

            invoiceRow = invoiceDataset.Transaction_Invoice.Row

            'recieving data from text boxes

            invoiceRow.recieptNo = txtrecieptNo.Text.ToString()
            invoiceRow.dateIssued = dtpPickUp.ToString()
            invoiceRow.workerID = cmbPaidTo.SelectedValue.ToString()
            invoiceRow.clientID = txtUserID.Text
            invoiceRow.totalAmountPayable = txtTotalCost.Text
            invoiceRow.paymentMethod = cmbPayType.SelectedItem.ToString
            invoiceRow.duration = txtDuration.Text
            invoiceRow.duedate = dtpDropOff.ToString()
            invoiceRow.dateHired = dtpPickUp.ToString()



        Catch ex As Exception
            MessageBox.Show("Data fields cannot be left null", ex.Message)
        End Try


        'saving the Courses into the database
        invoiceDataset.Transaction_Invoice.AddTransaction_InvoiceRow(invoiceRow)
        invoiceAdapter.Update(invoiceDataset.Transaction_Invoice)


        'Saving data into database

        MessageBox.Show("Rental details saved sucessfully", "Car Rental")
    End Sub

    Private Sub frmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Turkson_Co_DataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.Turkson_Co_DataSet.Employee)



    End Sub

    Private Sub txtUserID_Leave(sender As Object, e As EventArgs) Handles txtUserID.Leave
        Try

            Dim constr As String = "Data Source=.;Initial Catalog=TurksonCo-Db;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("select * from User_Rental_Details where clientID ='" & txtUserID.Text & "'  ")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()

                        'labUserID.Text = sdr("clientID").ToString()
                        'txtUserID.Text = sdr("clientID").ToString()
                        txtFirstname.Text = sdr("firstName").ToString()
                        txtUserLicen.Text = sdr("LicenseNo").ToString()
                        txtVehicNo.Text = sdr("vehicleID").ToString()
                        txtModel.Text = sdr("carModel").ToString()
                        txtCarYeaar.Text = sdr("carYear").ToString()
                        txtRentalID.Text = sdr("rentalID").ToString()

                    End Using
                    con.Close()
                End Using
            End Using

            txtrecieptNo.Text = randomInteger(randInt)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim cancelOption = MessageBox.Show("Do you want to go back to the Main Menu?", "Back to Main Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If cancelOption = DialogResult.Yes Then
            frmEmployeeMenu.Show()

            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
End Class