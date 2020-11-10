Public Class LMascota
    Public Sub AltaMascota(mascotita As ClassPet)
        Dim persistencia As New PMascota
        persistencia.AltaMascota(mascotita)
    End Sub

    Public Sub modificarMascota(mascotita As ClassPet)
        Dim persistencia As New PMascota
        persistencia.modificarMascota(mascotita)
    End Sub
End Class
