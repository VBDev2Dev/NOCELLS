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

	 Private Sub btnMissingCols_Click(sender As Object, e As EventArgs) Handles btnMissingCols.Click
		  Debug.WriteLine("Datagrid columns")

		  Dim props = GetType(Person).GetProperties
		  Dim columns As IEnumerable(Of DataGridViewColumn) = DataGridView1.Columns.Cast(Of DataGridViewColumn)
		  Dim matched = From p In props
							 Join c In columns On p.Name Equals c.DataPropertyName
							 Select New With {.Column = c, .Property = p}

		  Dim missing = props.Except(matched.Select(Function(m) m.Property))
		  For Each col In columns
				Debug.WriteLine($"{vbTab}{col.Name}: Bound to {col.DataPropertyName}")
				For Each row In DataGridView1.SelectedRows.Cast(Of DataGridViewRow).Where(Function(r) Not r.IsNewRow)
					 Debug.WriteLine($"{vbTab}{vbTab}{row.Cells(col.Index).Value}")
				Next
		  Next
		  Debug.WriteLine($"{NameOf(Person)} properties:")
		  For Each p In props
				Debug.WriteLine($"{vbTab}{p.Name}: {p.PropertyType.FullName}")
		  Next
		  Debug.WriteLine($"{NameOf(Person)} properties not in grid: CANNOT ACCESS USING CELLS!!!!")
		  For Each m In missing
				Debug.WriteLine($"{vbTab}{m.Name}: {m.PropertyType.FullName}")
		  Next
		  MessageBox.Show("Look at Immediate window.")
	 End Sub

	 Private Sub btnSelected_Click(sender As Object, e As EventArgs) Handles btnSelected.Click
		  For Each p In DataGridView1.SelectedRows.Cast(Of DataGridViewRow).Where(Function(r) Not r.IsNewRow).Select(Function(r) r.DataBoundItem).Cast(Of Person)
				Debug.WriteLine(p)
				Debug.WriteLine($"{vbTab} ID:{p.ID:B}")
				Debug.WriteLine($"{vbTab} Age:{p.Age.TotalDays:N0} (days)")
		  Next

		  Debug.WriteLine("Notice I was able to get the properties from the data object even though the columns did not exist in the grid.")

		  MessageBox.Show("Look at Immediate window.")
	 End Sub

	 Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
		  For Each p In people
				p.HairColor = Color.Cyan
		  Next
		  DataGridView1.Invalidate()
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
