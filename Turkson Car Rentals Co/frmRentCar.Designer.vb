<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCarstatus = New System.Windows.Forms.ComboBox()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Turkson_Co_DataSet = New Turkson_Car_Rentals_Co.Turkson_Co_DataSet()
        Me.cmbCarCategory = New System.Windows.Forms.ComboBox()
        Me.cmbCarYear = New System.Windows.Forms.ComboBox()
        Me.cmbCarMaker = New System.Windows.Forms.ComboBox()
        Me.cmbCarModel = New System.Windows.Forms.ComboBox()
        Me.cmbCarVehiNo = New System.Windows.Forms.ComboBox()
        Me.cmbCarName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRentCar = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labUsername = New System.Windows.Forms.Label()
        Me.labUserID = New System.Windows.Forms.Label()
        Me.VehicleTableAdapter = New Turkson_Car_Rentals_Co.Turkson_Co_DataSetTableAdapters.VehicleTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRentalID = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turkson_Co_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(363, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Car Rental"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 109)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Turkson Car Rentals Co"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 109)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(415, 362)
        Me.Splitter1.TabIndex = 17
        Me.Splitter1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Model"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCarstatus)
        Me.GroupBox2.Controls.Add(Me.cmbCarCategory)
        Me.GroupBox2.Controls.Add(Me.cmbCarYear)
        Me.GroupBox2.Controls.Add(Me.cmbCarMaker)
        Me.GroupBox2.Controls.Add(Me.cmbCarModel)
        Me.GroupBox2.Controls.Add(Me.cmbCarVehiNo)
        Me.GroupBox2.Controls.Add(Me.cmbCarName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(421, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 274)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Car Information"
        '
        'cmbCarstatus
        '
        Me.cmbCarstatus.DataSource = Me.VehicleBindingSource
        Me.cmbCarstatus.DisplayMember = "carStatus"
        Me.cmbCarstatus.FormattingEnabled = True
        Me.cmbCarstatus.Location = New System.Drawing.Point(104, 234)
        Me.cmbCarstatus.Name = "cmbCarstatus"
        Me.cmbCarstatus.Size = New System.Drawing.Size(146, 21)
        Me.cmbCarstatus.TabIndex = 35
        Me.cmbCarstatus.ValueMember = "carStatus"
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me.Turkson_Co_DataSet
        '
        'Turkson_Co_DataSet
        '
        Me.Turkson_Co_DataSet.DataSetName = "Turkson_Co_DataSet"
        Me.Turkson_Co_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbCarCategory
        '
        Me.cmbCarCategory.DataSource = Me.VehicleBindingSource
        Me.cmbCarCategory.DisplayMember = "carCategory"
        Me.cmbCarCategory.FormattingEnabled = True
        Me.cmbCarCategory.Location = New System.Drawing.Point(104, 195)
        Me.cmbCarCategory.Name = "cmbCarCategory"
        Me.cmbCarCategory.Size = New System.Drawing.Size(149, 21)
        Me.cmbCarCategory.TabIndex = 34
        Me.cmbCarCategory.ValueMember = "carCategory"
        '
        'cmbCarYear
        '
        Me.cmbCarYear.DataSource = Me.VehicleBindingSource
        Me.cmbCarYear.DisplayMember = "carYear"
        Me.cmbCarYear.FormattingEnabled = True
        Me.cmbCarYear.Location = New System.Drawing.Point(104, 161)
        Me.cmbCarYear.Name = "cmbCarYear"
        Me.cmbCarYear.Size = New System.Drawing.Size(146, 21)
        Me.cmbCarYear.TabIndex = 33
        Me.cmbCarYear.ValueMember = "carYear"
        '
        'cmbCarMaker
        '
        Me.cmbCarMaker.DataSource = Me.VehicleBindingSource
        Me.cmbCarMaker.DisplayMember = "carManufacturer"
        Me.cmbCarMaker.FormattingEnabled = True
        Me.cmbCarMaker.Location = New System.Drawing.Point(104, 127)
        Me.cmbCarMaker.Name = "cmbCarMaker"
        Me.cmbCarMaker.Size = New System.Drawing.Size(149, 21)
        Me.cmbCarMaker.TabIndex = 32
        Me.cmbCarMaker.ValueMember = "carManufacturer"
        '
        'cmbCarModel
        '
        Me.cmbCarModel.DataSource = Me.VehicleBindingSource
        Me.cmbCarModel.DisplayMember = "carModel"
        Me.cmbCarModel.FormattingEnabled = True
        Me.cmbCarModel.Location = New System.Drawing.Point(104, 87)
        Me.cmbCarModel.Name = "cmbCarModel"
        Me.cmbCarModel.Size = New System.Drawing.Size(149, 21)
        Me.cmbCarModel.TabIndex = 31
        Me.cmbCarModel.ValueMember = "carModel"
        '
        'cmbCarVehiNo
        '
        Me.cmbCarVehiNo.DataSource = Me.VehicleBindingSource
        Me.cmbCarVehiNo.DisplayMember = "carNo"
        Me.cmbCarVehiNo.FormattingEnabled = True
        Me.cmbCarVehiNo.Location = New System.Drawing.Point(104, 60)
        Me.cmbCarVehiNo.Name = "cmbCarVehiNo"
        Me.cmbCarVehiNo.Size = New System.Drawing.Size(149, 21)
        Me.cmbCarVehiNo.TabIndex = 30
        Me.cmbCarVehiNo.ValueMember = "carNo"
        '
        'cmbCarName
        '
        Me.cmbCarName.DataSource = Me.VehicleBindingSource
        Me.cmbCarName.DisplayMember = "carName"
        Me.cmbCarName.FormattingEnabled = True
        Me.cmbCarName.Location = New System.Drawing.Point(104, 25)
        Me.cmbCarName.Name = "cmbCarName"
        Me.cmbCarName.Size = New System.Drawing.Size(149, 21)
        Me.cmbCarName.TabIndex = 29
        Me.cmbCarName.ValueMember = "carName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Category"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Vehicle No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Availability"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Manufacturer"
        '
        'btnRentCar
        '
        Me.btnRentCar.Location = New System.Drawing.Point(475, 400)
        Me.btnRentCar.Name = "btnRentCar"
        Me.btnRentCar.Size = New System.Drawing.Size(97, 33)
        Me.btnRentCar.TabIndex = 20
        Me.btnRentCar.Text = "Rent Car"
        Me.btnRentCar.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(612, 400)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 33)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Turkson_Car_Rentals_Co.My.Resources.Resources._2013_Bugatti_Veyron_Grand_Sport_Vitesse_placement_626x382
        Me.PictureBox1.Location = New System.Drawing.Point(3, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(406, 311)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'labUsername
        '
        Me.labUsername.AutoSize = True
        Me.labUsername.Location = New System.Drawing.Point(747, 0)
        Me.labUsername.Name = "labUsername"
        Me.labUsername.Size = New System.Drawing.Size(53, 13)
        Me.labUsername.TabIndex = 23
        Me.labUsername.Text = "username"
        '
        'labUserID
        '
        Me.labUserID.AutoSize = True
        Me.labUserID.Location = New System.Drawing.Point(758, 34)
        Me.labUserID.Name = "labUserID"
        Me.labUserID.Size = New System.Drawing.Size(41, 13)
        Me.labUserID.TabIndex = 24
        Me.labUserID.Text = "user ID"
        Me.labUserID.Visible = False
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(663, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Rental ID"
        '
        'txtRentalID
        '
        Me.txtRentalID.Location = New System.Drawing.Point(736, 50)
        Me.txtRentalID.Name = "txtRentalID"
        Me.txtRentalID.Size = New System.Drawing.Size(63, 20)
        Me.txtRentalID.TabIndex = 26
        '
        'frmRentCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.txtRentalID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labUserID)
        Me.Controls.Add(Me.labUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRentCar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRentCar"
        Me.Text = "frmRentCar"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turkson_Co_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnRentCar As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCarstatus As ComboBox
    Friend WithEvents cmbCarCategory As ComboBox
    Friend WithEvents cmbCarYear As ComboBox
    Friend WithEvents cmbCarMaker As ComboBox
    Friend WithEvents cmbCarModel As ComboBox
    Friend WithEvents cmbCarVehiNo As ComboBox
    Friend WithEvents cmbCarName As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labUsername As Label
    Friend WithEvents labUserID As Label
    Friend WithEvents Turkson_Co_DataSet As Turkson_Co_DataSet
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter As Turkson_Co_DataSetTableAdapters.VehicleTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRentalID As TextBox
End Class
