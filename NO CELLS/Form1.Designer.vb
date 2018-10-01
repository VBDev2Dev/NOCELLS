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
		  Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		  Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		  Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		  Me.BirthdateDataGridViewCalendarColumn = New NO_CELLS.GridColumns.Calendar.CalendarColumn()
		  Me.CanDriveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		  Me.HairColor = New NO_CELLS.GridColumns.ColorPicker.ColorPickerColumn()
		  Me.PersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		  Me.pnlTests = New System.Windows.Forms.Panel()
		  Me.btnGenerate = New System.Windows.Forms.Button()
		  Me.btnColor = New System.Windows.Forms.Button()
		  Me.btnSelected = New System.Windows.Forms.Button()
		  Me.btnMissingCols = New System.Windows.Forms.Button()
		  Me.ColorPickerColumn1 = New NO_CELLS.GridColumns.ColorPicker.ColorPickerColumn()
		  Me.btnChangeNotify = New System.Windows.Forms.Button()
		  CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		  CType(Me.PersonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		  Me.pnlTests.SuspendLayout()
		  Me.SuspendLayout()
		  '
		  'DataGridView1
		  '
		  Me.DataGridView1.AllowUserToAddRows = False
		  Me.DataGridView1.AutoGenerateColumns = False
		  Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		  Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.BirthdateDataGridViewCalendarColumn, Me.CanDriveDataGridViewCheckBoxColumn, Me.HairColor})
		  Me.DataGridView1.DataSource = Me.PersonBindingSource
		  Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		  Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
		  Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
		  Me.DataGridView1.Name = "DataGridView1"
		  Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		  Me.DataGridView1.Size = New System.Drawing.Size(1031, 350)
		  Me.DataGridView1.TabIndex = 0
		  '
		  'FirstNameDataGridViewTextBoxColumn
		  '
		  Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
		  Me.FirstNameDataGridViewTextBoxColumn.Frozen = True
		  Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
		  Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
		  '
		  'LastNameDataGridViewTextBoxColumn
		  '
		  Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
		  Me.LastNameDataGridViewTextBoxColumn.Frozen = True
		  Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
		  Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
		  '
		  'BirthdateDataGridViewCalendarColumn
		  '
		  Me.BirthdateDataGridViewCalendarColumn.DataPropertyName = "Birthdate"
		  DataGridViewCellStyle2.Format = "d"
		  DataGridViewCellStyle2.NullValue = Nothing
		  Me.BirthdateDataGridViewCalendarColumn.DefaultCellStyle = DataGridViewCellStyle2
		  Me.BirthdateDataGridViewCalendarColumn.HeaderText = "Birthdate"
		  Me.BirthdateDataGridViewCalendarColumn.MaxDate = New Date(9999, 12, 31, 23, 59, 59, 999)
		  Me.BirthdateDataGridViewCalendarColumn.Name = "BirthdateDataGridViewCalendarColumn"
		  Me.BirthdateDataGridViewCalendarColumn.Width = 160
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
		  'PersonBindingSource
		  '
		  Me.PersonBindingSource.DataSource = GetType(NO_CELLS.Person)
		  '
		  'pnlTests
		  '
		  Me.pnlTests.Controls.Add(Me.btnChangeNotify)
		  Me.pnlTests.Controls.Add(Me.btnGenerate)
		  Me.pnlTests.Controls.Add(Me.btnColor)
		  Me.pnlTests.Controls.Add(Me.btnSelected)
		  Me.pnlTests.Controls.Add(Me.btnMissingCols)
		  Me.pnlTests.Dock = System.Windows.Forms.DockStyle.Bottom
		  Me.pnlTests.Location = New System.Drawing.Point(0, 350)
		  Me.pnlTests.Name = "pnlTests"
		  Me.pnlTests.Size = New System.Drawing.Size(1031, 100)
		  Me.pnlTests.TabIndex = 1
		  '
		  'btnGenerate
		  '
		  Me.btnGenerate.Location = New System.Drawing.Point(564, 18)
		  Me.btnGenerate.Name = "btnGenerate"
		  Me.btnGenerate.Size = New System.Drawing.Size(75, 57)
		  Me.btnGenerate.TabIndex = 2
		  Me.btnGenerate.Text = "Generate People"
		  Me.btnGenerate.UseVisualStyleBackColor = True
		  '
		  'btnColor
		  '
		  Me.btnColor.Location = New System.Drawing.Point(345, 18)
		  Me.btnColor.Name = "btnColor"
		  Me.btnColor.Size = New System.Drawing.Size(75, 57)
		  Me.btnColor.TabIndex = 1
		  Me.btnColor.Text = "Change Color"
		  Me.btnColor.UseVisualStyleBackColor = True
		  '
		  'btnSelected
		  '
		  Me.btnSelected.Location = New System.Drawing.Point(186, 18)
		  Me.btnSelected.Name = "btnSelected"
		  Me.btnSelected.Size = New System.Drawing.Size(75, 57)
		  Me.btnSelected.TabIndex = 0
		  Me.btnSelected.Text = "Get Selected Info"
		  Me.btnSelected.UseVisualStyleBackColor = True
		  '
		  'btnMissingCols
		  '
		  Me.btnMissingCols.Location = New System.Drawing.Point(45, 18)
		  Me.btnMissingCols.Name = "btnMissingCols"
		  Me.btnMissingCols.Size = New System.Drawing.Size(75, 57)
		  Me.btnMissingCols.TabIndex = 0
		  Me.btnMissingCols.Text = "Missing Columns"
		  Me.btnMissingCols.UseVisualStyleBackColor = True
		  '
		  'ColorPickerColumn1
		  '
		  Me.ColorPickerColumn1.HeaderText = "HairColor"
		  Me.ColorPickerColumn1.Name = "ColorPickerColumn1"
		  '
		  'btnChangeNotify
		  '
		  Me.btnChangeNotify.Location = New System.Drawing.Point(917, 32)
		  Me.btnChangeNotify.Name = "btnChangeNotify"
		  Me.btnChangeNotify.Size = New System.Drawing.Size(75, 43)
		  Me.btnChangeNotify.TabIndex = 3
		  Me.btnChangeNotify.Text = "Change Notify"
		  Me.btnChangeNotify.UseVisualStyleBackColor = True
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
		  Me.pnlTests.ResumeLayout(False)
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
	 Friend WithEvents btnMissingCols As Button
	 Friend WithEvents btnSelected As Button
	 Friend WithEvents btnColor As Button
	 Friend WithEvents btnGenerate As Button
	 Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	 Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	 Friend WithEvents BirthdateDataGridViewCalendarColumn As CalendarColumn
	 Friend WithEvents CanDriveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
	 Friend WithEvents HairColor As ColorPickerColumn
	 Friend WithEvents btnChangeNotify As Button
End Class
