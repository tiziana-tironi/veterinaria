Public Class ClassPet
    Private _name As String
    Private _dateOfBirthday As Integer
    Private _owner As Person
    Private _id As Integer


    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property dateOfBirthday As Integer
        Get
            Return _dateOfBirthday
        End Get
        Set(value As Integer)
            _dateOfBirthday = value
        End Set
    End Property

    Public Property Id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property

    Public Property Owner As Person
        Get
            Return _owner
        End Get
        Set(value As Person)
            _owner = value
        End Set
    End Property

    Public Sub PetClass()

        End Sub

    Public Sub PetClass(owner_ As Person, id_ As Integer, dateOfBirthday_ As Integer, name_ As String)
        Owner = owner_
        dateOfBirthday = dateOfBirthday_
        Name = name_
        Id = id_
    End Sub

End Class
