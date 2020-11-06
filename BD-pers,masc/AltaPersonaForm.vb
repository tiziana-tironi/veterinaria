Public Class AltaPersonaForm
    Dim listatelefonos As New List(Of Integer)

    Private Sub BtnGuar_Click(sender As Object, e As EventArgs) Handles BtnGuar.Click
        Try
            Dim ceduP As Integer
            Dim nameP As String
            Dim dir As String

            ceduP = TxtbCedu.Text
            nameP = TxtbName.Text
            dir = TxtbDir.Text

            Dim newPersona As New Person()
            newPersona.Ci = ceduP
            newPersona.Name = nameP
            newPersona.Address = dir
            newPersona.PhoneList = listatelefonos

            Dim logica As New LogicaPersona
            logica.AltaPersona(newPersona)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btntelefono_Click(sender As Object, e As EventArgs) Handles btntelefono.Click
        Try
            Dim telefono As Integer
            telefono = TxtbTel.Text

            lv_telefono.Items.Add(telefono)
            listatelefonos.Add(telefono)

            TxtbTel.Text = ""
        Catch ex As Exception
            MessageBox.Show("Hubo un error:" + ex.Message)
        End Try

    End Sub

    Private Sub lv_telefono_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_telefono.SelectedIndexChanged
        Dim teleliminado As Integer
        Dim iterador As Integer = 0
        Dim stringteleliminado = lv_telefono.SelectedItems(0).SubItems(0).Text
        teleliminado = Convert.ToInt32(stringteleliminado)

        While iterador < listatelefonos.Count
            If teleliminado = listatelefonos.Item(iterador) Then
                listatelefonos.Remove(teleliminado)
                iterador = listatelefonos.Count
            End If
            iterador = iterador + 1
        End While

        lv_telefono.Clear()
        iterador = 0
        While iterador < listatelefonos.Count
            lv_telefono.Items.Add(listatelefonos.Item(iterador))
            iterador = iterador + 1
        End While

    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            Dim nombrePersona As String
            nombrePersona = TxtbName.Text

            Dim ciPersona As Integer
            ciPersona = TxtbCedu.Text

            Dim direccionPersona As String
            direccionPersona = TxtbDir.Text

            Dim personaNueva = New Person()
            personaNueva.Ci = ciPersona
            personaNueva.Name = nombrePersona
            personaNueva.Address = direccionPersona
            personaNueva.PhoneList = listatelefonos

            Dim newPersonaClase As New Person()
            newPersonaClase.Ci = ciPersona
            newPersonaClase.Name = nombrePersona
            newPersonaClase.Address = direccionPersona
            newPersonaClase.PhoneList = listatelefonos

            Dim logica As New LogicaPersona()
            logica.modificarPersona(personaNueva)
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

    Private Sub LblPerson_Click(sender As Object, e As EventArgs) Handles LblPerson.Click

    End Sub
End Class
