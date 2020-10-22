Public Class Persona
    Dim listatelefonos As New List(Of Integer)

    Private Sub BtnGuar_Click(sender As Object, e As EventArgs) Handles BtnGuar.Click
        Try
            Dim ceduP As Integer
            Dim nameP As String
            Dim tel As Integer
            Dim dir As String

            ceduP = TxtbCedu.Text
            nameP = TxtbName.Text
            dir = TxtbDir.Text

            Dim newPersona As New Person()
            newPersona.Ci = ceduP
            newPersona.Nombre = nameP
            newPersona.Direccion = dir
            newPersona.Listatelefono = listatelefonos

            Dim logica As New LPersona
            logica.altaPersona(newPersona)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btntelefono_Click(sender As Object, e As EventArgs) Handles btntelefono.Click
        Dim telefono As Integer
        telefono = TxtbTel.Text

        lv_telefono.Items.Add(telefono)
        listatelefonos.Add(telefono)

        TxtbTel.Text = ""
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
End Class
