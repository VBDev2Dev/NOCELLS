Imports System.ComponentModel

Namespace GridColumns.ColorPicker
	 Public Class ColorPickerCell
		  Inherits DataGridViewCell

		  Const phi As Single = 1.618F

		  Dim colorValue As Color

		  Sub New()
				MyBase.New

		  End Sub

		  Protected Overrides Function GetFormattedValue(value As Object, rowIndex As Integer, ByRef cellStyle As DataGridViewCellStyle, valueTypeConverter As TypeConverter, formattedValueTypeConverter As TypeConverter, context As DataGridViewDataErrorContexts) As Object
				Return value
		  End Function


		  Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)



				MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, Nothing, Nothing, errorText, cellStyle, advancedBorderStyle, paintParts)



				Using darkPen As Pen = New Pen(SystemColors.ControlDark)
					 Dim rc As New Rectangle(cellBounds.X + 8, cellBounds.Y + 3, cellBounds.Width - CInt((cellBounds.Width * phi / 8)), cellBounds.Height - CInt((cellBounds.Height * phi / 4)))

					 Using brsh As SolidBrush = New SolidBrush(value)
						  graphics.FillRectangle(brsh, rc)
						  graphics.DrawRectangle(darkPen, rc)
					 End Using
				End Using
		  End Sub

		  Property Color As Color
				Get
					 Return colorValue
				End Get
				Set(ByVal value As Color)
					 colorValue = value
					 Me.Value = value
				End Set
		  End Property
		  Overrides ReadOnly Property DefaultNewRowValue() As Object
				Get
					 Return Color.Transparent
				End Get
		  End Property
		  Overrides ReadOnly Property EditType As Type
				Get
					 Return GetType(ColorEditingControl)
				End Get
		  End Property

		  Overrides ReadOnly Property FormattedValueType As Type
				Get
					 Return GetType(Color)
				End Get
		  End Property
		  Overrides Property ValueType As Type
				Get
					 Return GetType(Color)
				End Get
				Set(value As Type)
					 MyBase.ValueType = GetType(Color)
				End Set
		  End Property

	 End Class
End Namespace
