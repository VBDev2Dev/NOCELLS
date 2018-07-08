Public Class Person

	 Overrides Function ToString() As String
		  Return $"{FirstName} {LastName} ({ID:B}) is {Age.TotalDays:N0} days old and has {ColorTranslator.ToHtml(HairColor)} hair color."

	 End Function

	 ReadOnly Property Age As TimeSpan
		  Get
				Return Now - Birthdate

		  End Get
	 End Property
	 Property Birthdate As Date = Now
	 Property CanDrive As Boolean
	 Property FirstName As String
	 Property HairColor As Color = Color.Black

	 Property ID As Guid = Guid.NewGuid
	 Property LastName As String

End Class
