<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomePhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobilePhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateProvinceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIPPostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryRegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebPageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttachmentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialCircumstancesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicianNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicianPhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AllergiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicationsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuranceCarrierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuranceNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTestDataSet = New Test1.StudentsTestDataSet()
        Me.StudentsTableAdapter = New Test1.StudentsTestDataSetTableAdapters.StudentsTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.LevelDataGridViewTextBoxColumn, Me.RoomDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.IDNumberDataGridViewTextBoxColumn, Me.HomePhoneDataGridViewTextBoxColumn, Me.MobilePhoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateProvinceDataGridViewTextBoxColumn, Me.ZIPPostalCodeDataGridViewTextBoxColumn, Me.CountryRegionDataGridViewTextBoxColumn, Me.WebPageDataGridViewTextBoxColumn, Me.NotesDataGridViewTextBoxColumn, Me.AttachmentsDataGridViewTextBoxColumn, Me.SpecialCircumstancesDataGridViewTextBoxColumn, Me.PhysicianNameDataGridViewTextBoxColumn, Me.PhysicianPhoneNumberDataGridViewTextBoxColumn, Me.AllergiesDataGridViewTextBoxColumn, Me.MedicationsDataGridViewTextBoxColumn, Me.InsuranceCarrierDataGridViewTextBoxColumn, Me.InsuranceNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1142, 210)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'EmailAddressDataGridViewTextBoxColumn
        '
        Me.EmailAddressDataGridViewTextBoxColumn.DataPropertyName = "E-mail Address"
        Me.EmailAddressDataGridViewTextBoxColumn.HeaderText = "E-mail Address"
        Me.EmailAddressDataGridViewTextBoxColumn.Name = "EmailAddressDataGridViewTextBoxColumn"
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'LevelDataGridViewTextBoxColumn
        '
        Me.LevelDataGridViewTextBoxColumn.DataPropertyName = "Level"
        Me.LevelDataGridViewTextBoxColumn.HeaderText = "Level"
        Me.LevelDataGridViewTextBoxColumn.Name = "LevelDataGridViewTextBoxColumn"
        '
        'RoomDataGridViewTextBoxColumn
        '
        Me.RoomDataGridViewTextBoxColumn.DataPropertyName = "Room"
        Me.RoomDataGridViewTextBoxColumn.HeaderText = "Room"
        Me.RoomDataGridViewTextBoxColumn.Name = "RoomDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'IDNumberDataGridViewTextBoxColumn
        '
        Me.IDNumberDataGridViewTextBoxColumn.DataPropertyName = "ID Number"
        Me.IDNumberDataGridViewTextBoxColumn.HeaderText = "ID Number"
        Me.IDNumberDataGridViewTextBoxColumn.Name = "IDNumberDataGridViewTextBoxColumn"
        '
        'HomePhoneDataGridViewTextBoxColumn
        '
        Me.HomePhoneDataGridViewTextBoxColumn.DataPropertyName = "Home Phone"
        Me.HomePhoneDataGridViewTextBoxColumn.HeaderText = "Home Phone"
        Me.HomePhoneDataGridViewTextBoxColumn.Name = "HomePhoneDataGridViewTextBoxColumn"
        '
        'MobilePhoneDataGridViewTextBoxColumn
        '
        Me.MobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "Mobile Phone"
        Me.MobilePhoneDataGridViewTextBoxColumn.HeaderText = "Mobile Phone"
        Me.MobilePhoneDataGridViewTextBoxColumn.Name = "MobilePhoneDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'StateProvinceDataGridViewTextBoxColumn
        '
        Me.StateProvinceDataGridViewTextBoxColumn.DataPropertyName = "State/Province"
        Me.StateProvinceDataGridViewTextBoxColumn.HeaderText = "State/Province"
        Me.StateProvinceDataGridViewTextBoxColumn.Name = "StateProvinceDataGridViewTextBoxColumn"
        '
        'ZIPPostalCodeDataGridViewTextBoxColumn
        '
        Me.ZIPPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ZIP/Postal Code"
        Me.ZIPPostalCodeDataGridViewTextBoxColumn.HeaderText = "ZIP/Postal Code"
        Me.ZIPPostalCodeDataGridViewTextBoxColumn.Name = "ZIPPostalCodeDataGridViewTextBoxColumn"
        '
        'CountryRegionDataGridViewTextBoxColumn
        '
        Me.CountryRegionDataGridViewTextBoxColumn.DataPropertyName = "Country/Region"
        Me.CountryRegionDataGridViewTextBoxColumn.HeaderText = "Country/Region"
        Me.CountryRegionDataGridViewTextBoxColumn.Name = "CountryRegionDataGridViewTextBoxColumn"
        '
        'WebPageDataGridViewTextBoxColumn
        '
        Me.WebPageDataGridViewTextBoxColumn.DataPropertyName = "Web Page"
        Me.WebPageDataGridViewTextBoxColumn.HeaderText = "Web Page"
        Me.WebPageDataGridViewTextBoxColumn.Name = "WebPageDataGridViewTextBoxColumn"
        '
        'NotesDataGridViewTextBoxColumn
        '
        Me.NotesDataGridViewTextBoxColumn.DataPropertyName = "Notes"
        Me.NotesDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NotesDataGridViewTextBoxColumn.Name = "NotesDataGridViewTextBoxColumn"
        '
        'AttachmentsDataGridViewTextBoxColumn
        '
        Me.AttachmentsDataGridViewTextBoxColumn.DataPropertyName = "Attachments"
        Me.AttachmentsDataGridViewTextBoxColumn.HeaderText = "Attachments"
        Me.AttachmentsDataGridViewTextBoxColumn.Name = "AttachmentsDataGridViewTextBoxColumn"
        '
        'SpecialCircumstancesDataGridViewTextBoxColumn
        '
        Me.SpecialCircumstancesDataGridViewTextBoxColumn.DataPropertyName = "Special Circumstances"
        Me.SpecialCircumstancesDataGridViewTextBoxColumn.HeaderText = "Special Circumstances"
        Me.SpecialCircumstancesDataGridViewTextBoxColumn.Name = "SpecialCircumstancesDataGridViewTextBoxColumn"
        '
        'PhysicianNameDataGridViewTextBoxColumn
        '
        Me.PhysicianNameDataGridViewTextBoxColumn.DataPropertyName = "Physician Name"
        Me.PhysicianNameDataGridViewTextBoxColumn.HeaderText = "Physician Name"
        Me.PhysicianNameDataGridViewTextBoxColumn.Name = "PhysicianNameDataGridViewTextBoxColumn"
        '
        'PhysicianPhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhysicianPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Physician Phone Number"
        Me.PhysicianPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Physician Phone Number"
        Me.PhysicianPhoneNumberDataGridViewTextBoxColumn.Name = "PhysicianPhoneNumberDataGridViewTextBoxColumn"
        '
        'AllergiesDataGridViewTextBoxColumn
        '
        Me.AllergiesDataGridViewTextBoxColumn.DataPropertyName = "Allergies"
        Me.AllergiesDataGridViewTextBoxColumn.HeaderText = "Allergies"
        Me.AllergiesDataGridViewTextBoxColumn.Name = "AllergiesDataGridViewTextBoxColumn"
        '
        'MedicationsDataGridViewTextBoxColumn
        '
        Me.MedicationsDataGridViewTextBoxColumn.DataPropertyName = "Medications"
        Me.MedicationsDataGridViewTextBoxColumn.HeaderText = "Medications"
        Me.MedicationsDataGridViewTextBoxColumn.Name = "MedicationsDataGridViewTextBoxColumn"
        '
        'InsuranceCarrierDataGridViewTextBoxColumn
        '
        Me.InsuranceCarrierDataGridViewTextBoxColumn.DataPropertyName = "Insurance Carrier"
        Me.InsuranceCarrierDataGridViewTextBoxColumn.HeaderText = "Insurance Carrier"
        Me.InsuranceCarrierDataGridViewTextBoxColumn.Name = "InsuranceCarrierDataGridViewTextBoxColumn"
        '
        'InsuranceNumberDataGridViewTextBoxColumn
        '
        Me.InsuranceNumberDataGridViewTextBoxColumn.DataPropertyName = "Insurance Number"
        Me.InsuranceNumberDataGridViewTextBoxColumn.HeaderText = "Insurance Number"
        Me.InsuranceNumberDataGridViewTextBoxColumn.Name = "InsuranceNumberDataGridViewTextBoxColumn"
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.StudentsTestDataSet
        '
        'StudentsTestDataSet
        '
        Me.StudentsTestDataSet.DataSetName = "StudentsTestDataSet"
        Me.StudentsTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentsTestDataSet As StudentsTestDataSet
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As StudentsTestDataSetTableAdapters.StudentsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HomePhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobilePhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateProvinceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZIPPostalCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryRegionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WebPageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttachmentsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpecialCircumstancesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhysicianNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhysicianPhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllergiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedicationsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InsuranceCarrierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InsuranceNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
