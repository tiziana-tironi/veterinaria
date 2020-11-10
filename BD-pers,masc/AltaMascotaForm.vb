Public Class PetClass
    Private Sub BtnGuarM_Click(sender As Object, e As EventArgs) Handles BtnGuarM.Click
        Dim Id As Integer
        Dim name As String
        Dim año As Integer
        Dim ceduP As Integer

        Id = TxtbId.Text
        name = TxtbNam.Text
        año = TxtbAño.Text
        ceduP = TxtbCedum.Text

        Dim resu As String
        resu = Id & " " & name & " " & año & " " & ceduP

        LblMostrar.Text = resu

        Dim newMascota As New ClassPet()
        newMascota.IdPet = Id
        newMascota.NamePet = name
        newMascota.CiPet = ceduP

        Dim logica As New LMascota
        logica.AltaMascota(newMascota)

    End Sub

    Private Sub LblMascot_Click(sender As Object, e As EventArgs) Handles LblMascot.Click

    End Sub

    Private Sub TxtbId_TextChanged(sender As Object, e As EventArgs) Handles TxtbId.TextChanged

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try
            Dim nombreMascota As String
            nombreMascota = TxtbNam.Text

            Dim ciPersona As Integer
            ciPersona = Convert.ToInt32(TxtbCedum.Text.Trim)

            Dim anioNacimiento As Integer
            anioNacimiento = TxtbAño.Text

            Dim idPet As Integer
            idPet = TxtbId.Text


            Dim newMascota As New ClassPet()
            newMascota.CiPet = ciPersona
            newMascota.NamePet = nombreMascota
            newMascota.DateOfBirthdayPet = anioNacimiento
            newMascota.IdPet = idPet


            Dim logica As New LMascota()
            logica.modificarMascota(newMascota)
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

End Class