
Namespace GridColumns.ColorPicker
	 Class ColorPickerColumn
		  Inherits DataGridViewColumn
		  Sub New()
				MyBase.New()
				MyBase.CellTemplate = New ColorPickerCell
		  End Sub

		  Overrides Property CellTemplate() As DataGridViewCell
				Get
					 Return MyBase.CellTemplate
				End Get
				Set(ByVal value As DataGridViewCell)

					 ' Ensure that the cell used for the template is a ColorPickerCell.
					 If (value IsNot Nothing) AndAlso
						  Not value.GetType().IsAssignableFrom(GetType(ColorPickerCell)) _
						  Then
						  Throw New InvalidCastException("Must be a ColorPickerCell")
					 End If
					 MyBase.CellTemplate = value

				End Set
		  End Property

	 End Class
End Namespace
