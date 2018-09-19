
Namespace GridColumns.Calendar
	 Public Class CalendarCell
		  Inherits DataGridViewTextBoxCell

		  Sub New()
				' Use the short date format.
				Style.Format = If(String.IsNullOrEmpty(Style.Format), "yyyy/MM/dd h:mm:ss tt", Style.Format)
		  End Sub

		  Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer,
															  ByVal initialFormattedValue As Object,
															  ByVal dataGridViewCellStyle As DataGridViewCellStyle)

				' Set the value of the editing control to the current cell value.
				MyBase.InitializeEditingControl(rowIndex, initialFormattedValue,
					 dataGridViewCellStyle)

				Dim ctl As CalendarEditingControl =
					 CType(DataGridView.EditingControl, CalendarEditingControl)

				' Use the default row value when Value property is null.
				Try
					 Dim v = MyBase.GetValue(rowIndex)
					 If v Is Nothing OrElse IsDBNull(v) Then
						  ctl.Value = CType(DefaultNewRowValue, Date)
					 Else
						  ctl.Value = CType(v, Date)
					 End If
				Catch ex As Exception
				End Try
		  End Sub

		  Overrides ReadOnly Property DefaultNewRowValue() As Object
				Get
					 ' Use the current date and time as the default value.
					 Return Date.Now
				End Get
		  End Property

		  Overrides ReadOnly Property EditType() As Type
				Get
					 ' Return the type of the editing control that CalendarCell uses.
					 Return GetType(CalendarEditingControl)
				End Get
		  End Property

		  Overrides ReadOnly Property ValueType() As Type
				Get
					 ' Return the type of the value that CalendarCell contains.
					 Return GetType(Date)
				End Get
		  End Property
		  Public Overrides ReadOnly Property FormattedValueType As Type
				Get
					 Return GetType(String)
				End Get
		  End Property

	 End Class
End Namespace
