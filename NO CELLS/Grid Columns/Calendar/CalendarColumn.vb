
Namespace GridColumns.Calendar
	 Public Class CalendarColumn
		  Inherits DataGridViewColumn

		  Sub New()
				MyBase.New(New CalendarCell)
				MyBase.CellTemplate.Style = DefaultCellStyle
		  End Sub

		  Overrides Property CellTemplate() As DataGridViewCell
				Get
					 MyBase.CellTemplate.Style = DefaultCellStyle
					 Return MyBase.CellTemplate
				End Get
				Set(ByVal value As DataGridViewCell)

					 ' Ensure that the cell used for the template is a CalendarCell.
					 If (value IsNot Nothing) AndAlso
						  Not value.GetType().IsAssignableFrom(GetType(CalendarCell)) _
						  Then
						  Throw New InvalidCastException("Must be a CalendarCell")
					 End If
					 MyBase.CellTemplate = value

				End Set
		  End Property
		  Property MaxDate As Date = Date.MaxValue
	 End Class
End Namespace
