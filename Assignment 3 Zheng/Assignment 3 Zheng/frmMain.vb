Public Class frmMain

    Private Sub HairDresserSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HairDresserSelectionToolStripMenuItem.Click
        Dim aboutBox As New frmSelectionMenu()
        aboutBox.ShowDialog()
    End Sub
End Class
