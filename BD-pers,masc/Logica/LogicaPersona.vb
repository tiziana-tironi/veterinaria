Public Class LogicaPersona
    Public Sub AltaPersona(personota As Person)
        Dim persistencia As New PPersona
        persistencia.AltaPersona(personota)
    End Sub

    Public Sub modificarPersona(personota As Person)
        Dim persistencia As New PPersona
        persistencia.modificarPersona(personota)
    End Sub

    Public Function personsearch(cedula As Integer) As Person
        Dim persistencia As New PPersona
        persistencia.personSearch(cedula)
        Dim newPerson As Person
        newPerson = persistencia.personSearch(cedula)
        Return newPerson
    End Function
End Class
