Public Class ClassPet
    Private _idPet As Integer
    Private _namePet As String
    Private _dateOfBirthdayPet As Integer
    Private _ciPet As Integer


    Public Property NamePet As String
        Get
            Return _namePet
        End Get
        Set(value As String)
            _namePet = value
        End Set
    End Property

    Public Property DateOfBirthdayPet As Integer
        Get
            Return _dateOfBirthdayPet
        End Get
        Set(value As Integer)
            _dateOfBirthdayPet = value
        End Set
    End Property

    Public Property IdPet As Integer
        Get
            Return _idPet
        End Get
        Set(value As Integer)
            _idPet = value
        End Set
    End Property

    Public Property CiPet As Integer
        Get
            Return _ciPet
        End Get
        Set(value As Integer)
            _ciPet = value
        End Set
    End Property

    Public Sub PetClass()

        End Sub

    Public Sub PetClass(namePet_ As String, idPet_ As Integer, dateOfBirthdayPet_ As Integer, ciPet_ As Integer)
        NamePet = namePet_
        DateOfBirthdayPet = dateOfBirthdayPet_
        CiPet = ciPet_
        IdPet = idPet_
    End Sub

End Class
