Namespace GridColumns.Calendar
	 Class CalendarEditingControl
		  Inherits DateTimePicker
		  Implements IDataGridViewEditingControl

		  Dim dataGridViewControl As DataGridView
		  Dim rowIndexNum As Integer
		  Dim valueIsChanged As Boolean = False

		  Sub New()
				Format = DateTimePickerFormat.Custom
				CustomFormat = "yyyy/MM/dd h:mm:ss tt"
				Show()
		  End Sub

		  Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)

				' Notify the DataGridView that the contents of the cell have changed.
				valueIsChanged = True
				EditingControlDataGridView.NotifyCurrentCellDirty(True)
				MyBase.OnValueChanged(eventargs)

		  End Sub

		  Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As _
				DataGridViewCellStyle) _
				Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl

				Font = dataGridViewCellStyle.Font
				CalendarForeColor = dataGridViewCellStyle.ForeColor
				CalendarMonthBackground = dataGridViewCellStyle.BackColor

		  End Sub

		  Function EditingControlWantsInputKey(ByVal key As Keys,
				ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
				Implements IDataGridViewEditingControl.EditingControlWantsInputKey

				' Let the DateTimePicker handle the keys listed.
				Select Case key And Keys.KeyCode
					 Case Keys.Left, Keys.Up, Keys.Down, Keys.Right,
						  Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp

						  Return True

					 Case Else
						  Return Not dataGridViewWantsInputKey
				End Select

		  End Function

		  Function GetEditingControlFormattedValue(ByVal context _
				As DataGridViewDataErrorContexts) As Object _
				Implements IDataGridViewEditingControl.GetEditingControlFormattedValue

				Return Value.ToString("yyyy/MM/dd h:mm:ss tt")

		  End Function

		  Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
				Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

				' No preparation needs to be done.

		  End Sub

		  ReadOnly Property EditingControlCursor() As Cursor _
				Implements IDataGridViewEditingControl.EditingPanelCursor

				Get
					 Return MyBase.Cursor
				End Get

		  End Property

		  Property EditingControlDataGridView() As DataGridView _
				Implements IDataGridViewEditingControl.EditingControlDataGridView

				Get
					 Return dataGridViewControl
				End Get
				Set(ByVal value As DataGridView)
					 dataGridViewControl = value
				End Set

		  End Property

		  Property EditingControlFormattedValue() As Object _
				Implements IDataGridViewEditingControl.EditingControlFormattedValue

				Get
					 Return Value.ToString("yyyy/MM/dd h:mm:ss tt")
				End Get

				Set(ByVal value As Object)
					 Try
						  ' This will throw an exception of the string is 
						  ' null, empty, or not in the format of a date.
						  Me.Value = Date.Parse(CStr(value))
					 Catch
						  ' In the case of an exception, just use the default
						  ' value so we're not left with a null value.
						  Me.Value = Date.Now
					 End Try
				End Set

		  End Property

		  Property EditingControlRowIndex() As Integer _
				Implements IDataGridViewEditingControl.EditingControlRowIndex

				Get
					 Return rowIndexNum
				End Get
				Set(ByVal value As Integer)
					 rowIndexNum = value
				End Set

		  End Property

		  Property EditingControlValueChanged() As Boolean _
				Implements IDataGridViewEditingControl.EditingControlValueChanged

				Get
					 Return valueIsChanged
				End Get
				Set(ByVal value As Boolean)
					 valueIsChanged = value
				End Set

		  End Property

		  ReadOnly Property RepositionEditingControlOnValueChange() _
				As Boolean Implements _
				IDataGridViewEditingControl.RepositionEditingControlOnValueChange

				Get
					 Return False
				End Get

		  End Property

	 End Class
End Namespace
