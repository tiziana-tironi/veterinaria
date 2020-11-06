Public Class inicio
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click

    End Sub

    Private Sub MascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotaToolStripMenuItem.Click
        PetClass.ShowDialog()
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        PersonSearch.ShowDialog()
    End Sub
End Class
