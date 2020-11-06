Public Class PersonSearch
    Private Sub buttonSearch_Click(sender As Object, e As EventArgs) Handles buttonSearch.Click
        Try
            Dim ciPersona As Integer
            ciPersona = txtBoxCi.Text

            Dim newPerson = New Person()

            Dim logica As New LogicaPersona()
            newPerson = logica.personSearch(ciPersona)

            Show.Text = newPerson.Ci.ToString + " - " + newPerson.Name + " - " + newPerson.Address

        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub
End Class