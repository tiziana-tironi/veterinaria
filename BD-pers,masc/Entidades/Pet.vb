Public Class Pet
    Private _nombre As String
    Private _añoNac As Integer
    Private _dueño As Person
    Private _id As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property AñoNac As Integer
        Get
            Return _añoNac
        End Get
        Set(value As Integer)
            _añoNac = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Dueño As Person
        Get
            Return _dueño
        End Get
        Set(value As Person)
            _dueño = value
        End Set
    End Property

    Public Sub Pet()

    End Sub
    Public Sub Pet(nombre_ As String, dueño_ As Person, añoNac_ As Integer, id_ As Integer)
        Nombre = nombre_
        Dueño = dueño_
        AñoNac = añoNac_
        Id = id_
    End Sub

End Class
