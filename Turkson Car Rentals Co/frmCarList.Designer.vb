<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarList
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
        Me.CarNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FuelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurksonCo_DataSet = New Turkson_Car_Rentals_Co.TurksonCo_DataSet()
        Me.VehicleTableAdapter = New Turkson_Car_Rentals_Co.TurksonCo_DataSetTableAdapters.VehicleTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurksonCo_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1206, 92)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Turkson Car Rentals Co"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(598, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Car List"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1047, 285)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "All Cars"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarNoDataGridViewTextBoxColumn, Me.CarModelDataGridViewTextBoxColumn, Me.CarColourDataGridViewTextBoxColumn, Me.CarYearDataGridViewTextBoxColumn, Me.RentalCostDataGridViewTextBoxColumn, Me.FuelDataGridViewTextBoxColumn, Me.CarManufacturerDataGridViewTextBoxColumn, Me.CarStatusDataGridViewTextBoxColumn, Me.CarCategoryDataGridViewTextBoxColumn, Me.CarNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VehicleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1041, 229)
        Me.DataGridView1.TabIndex = 0
        '
        'CarNoDataGridViewTextBoxColumn
        '
        Me.CarNoDataGridViewTextBoxColumn.DataPropertyName = "carNo"
        Me.CarNoDataGridViewTextBoxColumn.HeaderText = "carNo"
        Me.CarNoDataGridViewTextBoxColumn.Name = "CarNoDataGridViewTextBoxColumn"
        '
        'CarModelDataGridViewTextBoxColumn
        '
        Me.CarModelDataGridViewTextBoxColumn.DataPropertyName = "carModel"
        Me.CarModelDataGridViewTextBoxColumn.HeaderText = "carModel"
        Me.CarModelDataGridViewTextBoxColumn.Name = "CarModelDataGridViewTextBoxColumn"
        '
        'CarColourDataGridViewTextBoxColumn
        '
        Me.CarColourDataGridViewTextBoxColumn.DataPropertyName = "carColour"
        Me.CarColourDataGridViewTextBoxColumn.HeaderText = "carColour"
        Me.CarColourDataGridViewTextBoxColumn.Name = "CarColourDataGridViewTextBoxColumn"
        '
        'CarYearDataGridViewTextBoxColumn
        '
        Me.CarYearDataGridViewTextBoxColumn.DataPropertyName = "carYear"
        Me.CarYearDataGridViewTextBoxColumn.HeaderText = "carYear"
        Me.CarYearDataGridViewTextBoxColumn.Name = "CarYearDataGridViewTextBoxColumn"
        '
        'RentalCostDataGridViewTextBoxColumn
        '
        Me.RentalCostDataGridViewTextBoxColumn.DataPropertyName = "rentalCost"
        Me.RentalCostDataGridViewTextBoxColumn.HeaderText = "rentalCost"
        Me.RentalCostDataGridViewTextBoxColumn.Name = "RentalCostDataGridViewTextBoxColumn"
        '
        'FuelDataGridViewTextBoxColumn
        '
        Me.FuelDataGridViewTextBoxColumn.DataPropertyName = "fuel"
        Me.FuelDataGridViewTextBoxColumn.HeaderText = "fuel"
        Me.FuelDataGridViewTextBoxColumn.Name = "FuelDataGridViewTextBoxColumn"
        '
        'CarManufacturerDataGridViewTextBoxColumn
        '
        Me.CarManufacturerDataGridViewTextBoxColumn.DataPropertyName = "carManufacturer"
        Me.CarManufacturerDataGridViewTextBoxColumn.HeaderText = "carManufacturer"
        Me.CarManufacturerDataGridViewTextBoxColumn.Name = "CarManufacturerDataGridViewTextBoxColumn"
        '
        'CarStatusDataGridViewTextBoxColumn
        '
        Me.CarStatusDataGridViewTextBoxColumn.DataPropertyName = "carStatus"
        Me.CarStatusDataGridViewTextBoxColumn.HeaderText = "carStatus"
        Me.CarStatusDataGridViewTextBoxColumn.Name = "CarStatusDataGridViewTextBoxColumn"
        '
        'CarCategoryDataGridViewTextBoxColumn
        '
        Me.CarCategoryDataGridViewTextBoxColumn.DataPropertyName = "carCategory"
        Me.CarCategoryDataGridViewTextBoxColumn.HeaderText = "carCategory"
        Me.CarCategoryDataGridViewTextBoxColumn.Name = "CarCategoryDataGridViewTextBoxColumn"
        '
        'CarNameDataGridViewTextBoxColumn
        '
        Me.CarNameDataGridViewTextBoxColumn.DataPropertyName = "carName"
        Me.CarNameDataGridViewTextBoxColumn.HeaderText = "carName"
        Me.CarNameDataGridViewTextBoxColumn.Name = "CarNameDataGridViewTextBoxColumn"
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me.TurksonCo_DataSet
        '
        'TurksonCo_DataSet
        '
        Me.TurksonCo_DataSet.DataSetName = "TurksonCo_DataSet"
        Me.TurksonCo_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'frmCarList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCarList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCarList"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurksonCo_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TurksonCo_DataSet As TurksonCo_DataSet
    Friend WithEvents VehicleBindingSource As BindingSource
    Friend WithEvents VehicleTableAdapter As TurksonCo_DataSetTableAdapters.VehicleTableAdapter
    Friend WithEvents CarNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentalCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FuelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarManufacturerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
