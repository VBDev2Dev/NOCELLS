Namespace GridColumns.ColorPicker
	 Class ColorEditingControl
		  Inherits Button
		  Implements IDataGridViewEditingControl
		  Dim _currentColor As Color = Color.Transparent

		  Dim dataGridViewControl As DataGridView
		  Dim rowIndexNum As Integer
		  Dim valueIsChanged As Boolean = False

		  Sub New()
				MyBase.New
				Text = "Change Color..."

		  End Sub

		  Protected Overrides Sub OnClick(e As EventArgs)
				MyBase.OnClick(e)
				Dim dlg As New ColorDialog
				dlg.FullOpen = True
				dlg.Color = CurrentColor

				If dlg.ShowDialog = DialogResult.OK Then
					 EditingControlDataGridView.BeginEdit(True)
					 CurrentColor = dlg.Color
					 valueIsChanged = True

					 EditingControlDataGridView.NotifyCurrentCellDirty(True)

					 EditingControlDataGridView.EndEdit()
					 EditingControlDataGridView.Invalidate()
					 EditingControlDataGridView.Refresh()



				End If
		  End Sub

		  Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As _
				DataGridViewCellStyle) _
				Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl



		  End Sub

		  Function EditingControlWantsInputKey(ByVal key As Keys,
				ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
				Implements IDataGridViewEditingControl.EditingControlWantsInputKey

				Return Not dataGridViewWantsInputKey
		  End Function

		  Function GetEditingControlFormattedValue(ByVal context _
				As DataGridViewDataErrorContexts) As Object _
				Implements IDataGridViewEditingControl.GetEditingControlFormattedValue

				Return CurrentColor

		  End Function
		  Function getForeColor() As Color

				'https://stackoverflow.com/questions/1855884/determine-font-color-based-on-background-color
				Dim d As Integer = 0

				' Counting the perceptive luminance - human eye favors green color... 
				Dim luminance = (0.299 * CurrentColor.R + 0.587 * CurrentColor.G + 0.114 * CurrentColor.B) / 255

				d = If(luminance > 0.5, 0, 255)
				Return Color.FromArgb(d, d, d)

		  End Function

		  Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
				Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
				Dim cell As ColorPickerCell = EditingControlDataGridView.CurrentCell
				CurrentColor = cell.Value

		  End Sub

		  Property CurrentColor As Color
				Get
					 Return _currentColor
				End Get
				Set
					 _currentColor = Value
					 MyBase.BackColor = Value
					 MyBase.ForeColor = getForeColor()
				End Set
		  End Property
		  ReadOnly Property EditingControlCursor() As Cursor _
				Implements IDataGridViewEditingControl.EditingPanelCursor

				Get
					 Return Cursors.Default
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
					 Return CurrentColor
				End Get

				Set(ByVal value As Object)

					 CurrentColor = value

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
