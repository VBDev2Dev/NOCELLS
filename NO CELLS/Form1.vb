Imports System.ComponentModel

Public Class Form1
	 Dim people As New List(Of Person)
	 'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
	 '  If DataGridView1.Columns(e.ColumnIndex).Name = "HairColor" Then
	 '		Dim dlg As ColorDialog = New ColorDialog()
	 '		Dim currentCell As ColorPickerCell = TryCast(DataGridView1(e.ColumnIndex, e.RowIndex), ColorPickerCell)
	 '		If currentCell.ReadOnly Then Return
	 '		If dlg.ShowDialog() = DialogResult.OK Then

	 '			 If currentCell IsNot Nothing Then
	 '				  DataGridView1.BeginEdit(True)
	 '				  currentCell.Color = dlg.Color
	 '				  DataGridView1.NotifyCurrentCellDirty(True)
	 '				  DataGridView1.EndEdit()
	 '				  PersonBindingSource.EndEdit()

	 '				  Me.Invalidate()
	 '			 End If
	 '		End If
	 '  End If
	 'End Sub

	 Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
		  DataGridView1.EndEdit()
		  PersonBindingSource.EndEdit()
		  Dim data As Person = DataGridView1.Rows(e.RowIndex).DataBoundItem
		  Dim p As Person = people(e.RowIndex)
		  MessageBox.Show(data.ToString)
	 End Sub

	 Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		  PersonBindingSource.DataSource = New BindingList(Of Person)(people)
	 End Sub
End Class
