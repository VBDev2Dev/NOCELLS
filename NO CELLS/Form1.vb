Imports System.ComponentModel

Public Class Form1
	 Dim people As New List(Of Person)
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
