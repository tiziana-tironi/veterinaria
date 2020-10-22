Public Class Mascota
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



    End Sub
End Class