Public Class Person
    Private _ci As Integer
    Private _nombre As String
    Private _listatelefono As List(Of Integer)
    Private _direccion As String

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
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

    Public Property Listatelefono As List(Of Integer)
        Get
            Return _listatelefono
        End Get
        Set(value As List(Of Integer))
            _listatelefono = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Sub Person()

    End Sub
    Public Sub Person(ci_ As Integer, nombre_ As String, direccion_ As String, listatelefono_ As List(Of Integer))
        Ci = ci_
        Nombre = nombre_
        Direccion = direccion_
        Listatelefono = listatelefono_
    End Sub
End Class
