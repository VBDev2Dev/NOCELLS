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
		  BirthdateDataGridViewCalendarColumn.MaxDate = Now
	 End Sub

	 Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
		  Static rand As New Random
		  Dim randString = Function(chars As Integer)
									  Return New String(Enumerable.Range(0, chars).Select(Function(n) ChrW(rand.Next(65, 101))).ToArray)
								 End Function
		  PersonBindingSource.DataSource = Nothing
		  people.AddRange(Enumerable.Range(0, 50).Select(Function(n) New Person With
																	 {
																		 .FirstName = randString(20),
																		 .LastName = randString(30),
																		 .CanDrive = rand.Next(-1, 1),
																		 .HairColor = Color.FromArgb(255, rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256)),
																		 .Birthdate = Now.AddYears(-18).AddMonths(-4).AddDays(rand.Next(0, 365) * -1)
																	  })
							)

		  PersonBindingSource.DataSource = New BindingList(Of Person)(people)
	 End Sub
End Class
