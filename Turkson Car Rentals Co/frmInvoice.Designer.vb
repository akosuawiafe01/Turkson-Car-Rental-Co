<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtVehicNo = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtCarYeaar = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.dtpPickUp = New System.Windows.Forms.DateTimePicker()
        Me.dtpDropOff = New System.Windows.Forms.DateTimePicker()
        Me.label8 = New System.Windows.Forms.Label()
        Me.cmbPayType = New System.Windows.Forms.ComboBox()
        Me.btnPayforCar = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Invoice"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(800, 92)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Turkson Car Rentals Co"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 117)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "User ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Last name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCarYeaar)
        Me.GroupBox2.Controls.Add(Me.txtModel)
        Me.GroupBox2.Controls.Add(Me.txtVehicNo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(439, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 115)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Car Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Year"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Vehicle No."
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbPayType)
        Me.GroupBox3.Controls.Add(Me.label8)
        Me.GroupBox3.Controls.Add(Me.dtpDropOff)
        Me.GroupBox3.Controls.Add(Me.dtpPickUp)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(38, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(750, 136)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Invoice"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(358, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Pick Up Date"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(358, 58)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Drop Off Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(358, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Total Cost"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Rent/Hour"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Duration"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Reciept No."
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(124, 25)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(139, 20)
        Me.txtUserID.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(126, 55)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(136, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(124, 87)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(138, 20)
        Me.txtFirstname.TabIndex = 5
        '
        'txtVehicNo
        '
        Me.txtVehicNo.Location = New System.Drawing.Point(124, 21)
        Me.txtVehicNo.Name = "txtVehicNo"
        Me.txtVehicNo.Size = New System.Drawing.Size(142, 20)
        Me.txtVehicNo.TabIndex = 3
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(124, 60)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(141, 20)
        Me.txtModel.TabIndex = 4
        '
        'txtCarYeaar
        '
        Me.txtCarYeaar.Location = New System.Drawing.Point(126, 87)
        Me.txtCarYeaar.Name = "txtCarYeaar"
        Me.txtCarYeaar.Size = New System.Drawing.Size(138, 20)
        Me.txtCarYeaar.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(102, 25)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(171, 20)
        Me.TextBox7.TabIndex = 26
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(102, 51)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(136, 20)
        Me.TextBox8.TabIndex = 27
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(102, 80)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(145, 20)
        Me.TextBox9.TabIndex = 28
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(491, 109)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(164, 20)
        Me.TextBox10.TabIndex = 29
        '
        'dtpPickUp
        '
        Me.dtpPickUp.Location = New System.Drawing.Point(492, 31)
        Me.dtpPickUp.Name = "dtpPickUp"
        Me.dtpPickUp.Size = New System.Drawing.Size(187, 20)
        Me.dtpPickUp.TabIndex = 30
        '
        'dtpDropOff
        '
        Me.dtpDropOff.Location = New System.Drawing.Point(491, 61)
        Me.dtpDropOff.Name = "dtpDropOff"
        Me.dtpDropOff.Size = New System.Drawing.Size(188, 20)
        Me.dtpDropOff.TabIndex = 31
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 107)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(87, 13)
        Me.label8.TabIndex = 32
        Me.label8.Text = "Payment Method"
        '
        'cmbPayType
        '
        Me.cmbPayType.FormattingEnabled = True
        Me.cmbPayType.Location = New System.Drawing.Point(102, 107)
        Me.cmbPayType.Name = "cmbPayType"
        Me.cmbPayType.Size = New System.Drawing.Size(145, 21)
        Me.cmbPayType.TabIndex = 33
        '
        'btnPayforCar
        '
        Me.btnPayforCar.Location = New System.Drawing.Point(419, 433)
        Me.btnPayforCar.Name = "btnPayforCar"
        Me.btnPayforCar.Size = New System.Drawing.Size(110, 36)
        Me.btnPayforCar.TabIndex = 16
        Me.btnPayforCar.Text = "Check out"
        Me.btnPayforCar.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(554, 438)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(126, 30)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "Cancel"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 530)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnPayforCar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInvoice"
        Me.Text = "frmInvoice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtCarYeaar As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtVehicNo As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents dtpDropOff As DateTimePicker
    Friend WithEvents dtpPickUp As DateTimePicker
    Friend WithEvents cmbPayType As ComboBox
    Friend WithEvents label8 As Label
    Friend WithEvents btnPayforCar As Button
    Friend WithEvents btnBack As Button
End Class
