Public Class frmMain

    Private Sub HairDresserSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HairDresserSelectionToolStripMenuItem.Click
        Dim frmHairDresserBox As New frmSelectionMenu()
        frmHairDresserBox.ShowDialog()
    End Sub

    Private Sub ServiceSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceSelectionToolStripMenuItem.Click
        Dim frmServiceBox As New frmServiceSelection()
        frmServiceBox.ShowDialog()
    End Sub
End Class
