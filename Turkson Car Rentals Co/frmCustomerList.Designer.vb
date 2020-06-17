<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnViewList = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TurksonCo_DataSet = New Turkson_Car_Rentals_Co.TurksonCo_DataSet()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New Turkson_Car_Rentals_Co.TurksonCo_DataSetTableAdapters.ClientTableAdapter()
        Me.ClientIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicenseNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResidenceLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurksonCo_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(-141, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1149, 328)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClientIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.OtherNameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.LicenseNoDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ResidenceLocationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(179, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(945, 276)
        Me.DataGridView1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(361, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Client List"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1020, 92)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Turkson Car Rentals Co"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(637, 482)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 22)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnViewList
        '
        Me.btnViewList.Location = New System.Drawing.Point(519, 482)
        Me.btnViewList.Name = "btnViewList"
        Me.btnViewList.Size = New System.Drawing.Size(75, 23)
        Me.btnViewList.TabIndex = 22
        Me.btnViewList.Text = "View List"
        Me.btnViewList.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(852, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 22)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(734, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "View List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TurksonCo_DataSet
        '
        Me.TurksonCo_DataSet.DataSetName = "TurksonCo_DataSet"
        Me.TurksonCo_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.TurksonCo_DataSet
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
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
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LicenseNoDataGridViewTextBoxColumn
        '
        Me.LicenseNoDataGridViewTextBoxColumn.DataPropertyName = "LicenseNo"
        Me.LicenseNoDataGridViewTextBoxColumn.HeaderText = "LicenseNo"
        Me.LicenseNoDataGridViewTextBoxColumn.Name = "LicenseNoDataGridViewTextBoxColumn"
        Me.LicenseNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResidenceLocationDataGridViewTextBoxColumn
        '
        Me.ResidenceLocationDataGridViewTextBoxColumn.DataPropertyName = "residenceLocation"
        Me.ResidenceLocationDataGridViewTextBoxColumn.HeaderText = "residenceLocation"
        Me.ResidenceLocationDataGridViewTextBoxColumn.Name = "ResidenceLocationDataGridViewTextBoxColumn"
        Me.ResidenceLocationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmCustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnViewList)
        Me.Name = "frmCustomerList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCustomerList"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurksonCo_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnViewList As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TurksonCo_DataSet As TurksonCo_DataSet
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents ClientTableAdapter As TurksonCo_DataSetTableAdapters.ClientTableAdapter
    Friend WithEvents ClientIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LicenseNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResidenceLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
