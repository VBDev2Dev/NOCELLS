Imports System.ComponentModel

Public Class Person
	 Implements ComponentModel.INotifyPropertyChanged

	 Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

	 Protected Overridable Sub OnPropertyChanged(e As PropertyChangedEventArgs)
		  RaiseEvent PropertyChanged(Me, e)
	 End Sub
	 Overrides Function ToString() As String
		  Return $"{FirstName} {LastName} ({ID:B}) is {Age.TotalDays:N0} days old and has {ColorTranslator.ToHtml(HairColor)} hair color. They are a {If(CanDrive, "Driver", "Passenger")}."

	 End Function

	 ReadOnly Property Age As TimeSpan
		  Get
				Return Now - Birthdate

		  End Get
	 End Property

	 Dim _birthdate As Date = Now
	 Property Birthdate As Date
		  Get
				Return _birthdate
		  End Get
		  Set
				If _birthdate = Value Then
					 Return
				End If
				_birthdate = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(Birthdate)))
		  End Set
	 End Property

	 Dim _canDrive As Boolean
	 Property CanDrive As Boolean
		  Get
				Return _canDrive
		  End Get
		  Set
				If _canDrive = Value Then
					 Return
				End If
				_canDrive = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(CanDrive)))
		  End Set
	 End Property

	 Dim _firstName As String
	 Property FirstName As String
		  Get
				Return _firstName
		  End Get
		  Set
				If _firstName Is Value Then
					 Return
				End If
				_firstName = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(FirstName)))
		  End Set
	 End Property

	 Dim _hairColor As Color = Color.Black
	 Property HairColor As Color
		  Get
				Return _hairColor
		  End Get
		  Set
				If _hairColor = Value Then
					 Return
				End If
				_hairColor = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(HairColor)))
		  End Set
	 End Property

	 Dim _iD As Guid = Guid.NewGuid
	 Property ID As Guid
		  Get
				Return _iD
		  End Get
		  Set
				If _iD = Value Then
					 Return
				End If
				_iD = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(ID)))
		  End Set
	 End Property

	 Dim _lastName As String
	 Property LastName As String
		  Get
				Return _lastName
		  End Get
		  Set
				If _lastName Is Value Then
					 Return
				End If
				_lastName = Value
				OnPropertyChanged(New PropertyChangedEventArgs(NameOf(LastName)))
		  End Set
	 End Property
End Class
