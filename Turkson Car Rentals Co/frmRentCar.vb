Imports System.Data.SqlClient

Public Class frmRentCar

    Dim randInt As Integer = 5

    Dim rentalAdatpter As TurksonCo_DataSetTableAdapters.RentalTableAdapter = New TurksonCo_DataSetTableAdapters.RentalTableAdapter
    Dim rentalDataset = New TurksonCo_DataSet()

    'Variable for storing rental data collected
    Dim rentalRow As TurksonCo_DataSet.RentalRow


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRentCar.Click

        Try

            rentalRow = rentalDataset.Rental.NewRow


            rentalRow.vehicleID = cmbCarVehiNo.SelectedValue.ToString
            rentalRow.carModel = cmbCarModel.SelectedValue.ToString
            rentalRow.carYear = cmbCarYear.SelectedValue.ToString
            rentalRow.clientID = labUserID.Text
            rentalRow.rentalID = txtRentalID.Text



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        'saving the Courses into the database
        rentalDataset.Rental.AddRentalRow(rentalRow)
        rentalAdatpter.Update(rentalDataset.Rental)

        'transDataSet.Transcript.AddTranscriptRow(transRow)
        'transAdapter.Update(transDataSet.Transcript)



        'Saving data into database
        MessageBox.Show("Rental details saved sucessfully", "Car Rental")
    End Sub

    Private Sub frmRentCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TurksonCo_DataSet.Vehicle' table. You can move, or remove it, as needed.
        Me.VehicleTableAdapter.Fill(Me.TurksonCo_DataSet.Vehicle)


        labUsername.Text = frmUserLogin.Text




        txtRentalID.Text = randomInteger(randInt)


        Try

            Dim constr As String = "Data Source=.;Initial Catalog=TurksonCo-Db;Integrated Security=True"
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("Select * from Client where username='" & frmUserLogin.txtUserName.Text & "'  ")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = con
                    con.Open()
                    Using sdr As SqlDataReader = cmd.ExecuteReader()
                        sdr.Read()

                        labUserID.Text = sdr("clientID").ToString()
                    End Using
                    con.Close()
                End Using
            End Using




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