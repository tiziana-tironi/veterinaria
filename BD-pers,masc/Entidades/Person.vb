Public Class Person
    Private _name As String
    Private _ci As Integer
    Private _phoneList As List(Of Integer)
    Private _address As String

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set
    End Property

    Public Property PhoneList As List(Of Integer)
        Get
            Return _phoneList
        End Get
        Set(value As List(Of Integer))
            _phoneList = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public Sub PersonaClase()

    End Sub

    Public Sub PersonaClase(ci_ As Integer, address_ As String, phoneList_ As List(Of Integer), name_ As String)
        Ci = ci_
        Name = name_
        Address = address_
        PhoneList = phoneList_
    End Sub


End Class