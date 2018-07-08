Imports Microsoft.VisualBasic.CompilerServices
Imports NO_CELLS.GridColumns.Calendar
Imports NO_CELLS.GridColumns.ColorPicker
Imports System.ComponentModel

<DesignerGenerated()> _
Partial Class Form1
	 Inherits Form

	 'Required by the Windows Form Designer
	 Dim components As IContainer

	 Friend WithEvents DataGridView1 As DataGridView
	 Friend WithEvents PersonBindingSource As BindingSource
	 Friend WithEvents pnlTests As Panel

	 'NOTE: The following procedure is required by the Windows Form Designer
	 'It can be modified using the Windows Form Designer.  
	 'Do not modify it using the code editor.
	 <DebuggerStepThrough()>
	 Private Sub InitializeComponent()
		  Me.components = New System.ComponentModel.Container()
		  Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		  Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		  Me.pnlTests = New System.Windows.Forms.Panel()
		  Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		  Me.ColorPickerColumn1 = New ColorPickerColumn()
		  Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.BirthdateDataGridViewTextBoxColumn = New CalendarColumn()
		  Me.CanDriveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		  Me.HairColor = New ColorPickerColumn()
		  CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		  CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		  Me.SuspendLayout()
		  '
		  'DataGridView1
		  '
		  Me.DataGridView1.AutoGenerateColumns = False
		  Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		  Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.CanDriveDataGridViewCheckBoxColumn, Me.HairColor})
		  Me.DataGridView1.DataSource = Me.PersonBindingSource
		  Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		  Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
		  Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
		  Me.DataGridView1.Name = "DataGridView1"
		  Me.DataGridView1.Size = New System.Drawing.Size(1031, 350)
		  Me.DataGridView1.TabIndex = 0
		  '
		  'pnlTests
		  '
		  Me.pnlTests.Dock = System.Windows.Forms.DockStyle.Bottom
		  Me.pnlTests.Location = New System.Drawing.Point(0, 350)
		  Me.pnlTests.Name = "pnlTests"
		  Me.pnlTests.Size = New System.Drawing.Size(1031, 100)
		  Me.pnlTests.TabIndex = 1
		  '
		  'PersonBindingSource
		  '
		  Me.PersonBindingSource.DataSource = GetType(NO_CELLS.Person)
		  '
		  'ColorPickerColumn1
		  '
		  Me.ColorPickerColumn1.HeaderText = "HairColor"
		  Me.ColorPickerColumn1.Name = "ColorPickerColumn1"
		  '
		  'FirstNameDataGridViewTextBoxColumn
		  '
		  Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
		  Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
		  Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
		  '
		  'LastNameDataGridViewTextBoxColumn
		  '
		  Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
		  Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
		  Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
		  '
		  'BirthdateDataGridViewTextBoxColumn
		  '
		  Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate"
		  DataGridViewCellStyle1.Format = "d"
		  DataGridViewCellStyle1.NullValue = Nothing
		  Me.BirthdateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
		  Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate"
		  Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
		  Me.BirthdateDataGridViewTextBoxColumn.Width = 160
		  '
		  'CanDriveDataGridViewCheckBoxColumn
		  '
		  Me.CanDriveDataGridViewCheckBoxColumn.DataPropertyName = "CanDrive"
		  Me.CanDriveDataGridViewCheckBoxColumn.HeaderText = "Can Drive"
		  Me.CanDriveDataGridViewCheckBoxColumn.Name = "CanDriveDataGridViewCheckBoxColumn"
		  '
		  'HairColor
		  '
		  Me.HairColor.DataPropertyName = "HairColor"
		  Me.HairColor.HeaderText = "Hair Color"
		  Me.HairColor.Name = "HairColor"
		  '
		  'Form1
		  '
		  Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		  Me.ClientSize = New System.Drawing.Size(1031, 450)
		  Me.Controls.Add(Me.DataGridView1)
		  Me.Controls.Add(Me.pnlTests)
		  Me.Name = "Form1"
		  Me.Text = "Form1"
		  CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		  CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		  Me.ResumeLayout(False)

	 End Sub

	 'Form overrides dispose to clean up the component list.
	 <DebuggerNonUserCode()>
	 Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		  Try
				If disposing AndAlso components IsNot Nothing Then
					 components.Dispose()
				End If
		  Finally
				MyBase.Dispose(disposing)
		  End Try
	 End Sub
	 Friend WithEvents ColorPickerColumn1 As ColorPickerColumn
	 Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	 Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	 Friend WithEvents BirthdateDataGridViewTextBoxColumn As CalendarColumn
	 Friend WithEvents CanDriveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
	 Friend WithEvents HairColor As ColorPickerColumn
End Class
