<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentalList
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurksonCo_DataSet = New Turkson_Car_Rentals_Co.TurksonCo_DataSet()
        Me.btnViewList = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Rental_ListTableAdapter = New Turkson_Car_Rentals_Co.TurksonCo_DataSetTableAdapters.Rental_ListTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurksonCo_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1119, 92)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Turkson Car Rentals Co"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(526, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Rental List"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1095, 362)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rental List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.OtherNameDataGridViewTextBoxColumn, Me.RentalIDDataGridViewTextBoxColumn, Me.VehicleIDDataGridViewTextBoxColumn, Me.CarNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RentalListBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(179, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(745, 276)
        Me.DataGridView1.TabIndex = 0
        '
        'ClientIDDataGridViewTextBoxColumn
        '
        Me.ClientIDDataGridViewTextBoxColumn.DataPropertyName = "clientID"
        Me.ClientIDDataGridViewTextBoxColumn.HeaderText = "clientID"
        Me.ClientIDDataGridViewTextBoxColumn.Name = "ClientIDDataGridViewTextBoxColumn"
        Me.ClientIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "firstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OtherNameDataGridViewTextBoxColumn
        '
        Me.OtherNameDataGridViewTextBoxColumn.DataPropertyName = "otherName"
        Me.OtherNameDataGridViewTextBoxColumn.HeaderText = "otherName"
        Me.OtherNameDataGridViewTextBoxColumn.Name = "OtherNameDataGridViewTextBoxColumn"
        Me.OtherNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RentalIDDataGridViewTextBoxColumn
        '
        Me.RentalIDDataGridViewTextBoxColumn.DataPropertyName = "rentalID"
        Me.RentalIDDataGridViewTextBoxColumn.HeaderText = "rentalID"
        Me.RentalIDDataGridViewTextBoxColumn.Name = "RentalIDDataGridViewTextBoxColumn"
        Me.RentalIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VehicleIDDataGridViewTextBoxColumn
        '
        Me.VehicleIDDataGridViewTextBoxColumn.DataPropertyName = "vehicleID"
        Me.VehicleIDDataGridViewTextBoxColumn.HeaderText = "vehicleID"
        Me.VehicleIDDataGridViewTextBoxColumn.Name = "VehicleIDDataGridViewTextBoxColumn"
        Me.VehicleIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarNameDataGridViewTextBoxColumn
        '
        Me.CarNameDataGridViewTextBoxColumn.DataPropertyName = "carName"
        Me.CarNameDataGridViewTextBoxColumn.HeaderText = "carName"
        Me.CarNameDataGridViewTextBoxColumn.Name = "CarNameDataGridViewTextBoxColumn"
        Me.CarNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RentalListBindingSource
        '
        Me.RentalListBindingSource.DataMember = "Rental_List"
        Me.RentalListBindingSource.DataSource = Me.TurksonCo_DataSet
        '
        'TurksonCo_DataSet
        '
        Me.TurksonCo_DataSet.DataSetName = "TurksonCo_DataSet"
        Me.TurksonCo_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnViewList
        '
        Me.btnViewList.Location = New System.Drawing.Point(672, 537)
        Me.btnViewList.Name = "btnViewList"
        Me.btnViewList.Size = New System.Drawing.Size(75, 23)
        Me.btnViewList.TabIndex = 17
        Me.btnViewList.Text = "View List"
        Me.btnViewList.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(790, 537)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 22)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Rental_ListTableAdapter
        '
        Me.Rental_ListTableAdapter.ClearBeforeFill = True
        '
        'frmRentalList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 568)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnViewList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRentalList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRentalList"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurksonCo_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnViewList As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents TurksonCo_DataSet As TurksonCo_DataSet
    Friend WithEvents RentalListBindingSource As BindingSource
    Friend WithEvents Rental_ListTableAdapter As TurksonCo_DataSetTableAdapters.Rental_ListTableAdapter
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentalIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
