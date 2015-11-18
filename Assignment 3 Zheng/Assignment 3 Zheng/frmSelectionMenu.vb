Public Class frmSelectionMenu

    Private Sub btnAddHairdresser_Click(sender As Object, e As EventArgs) Handles btnAddHairdresser.Click
        Dim intSelectedIndex As Integer
        intSelectedIndex = lstHairdressers.SelectedIndex
        LoadTypeValues(intSelectedIndex, "Hairdresser")
        Me.Close()
        
    End Sub

    Private Sub btnCloseHairdresser_Click(sender As Object, e As EventArgs) Handles btnCloseHairdresser.Click
        Me.Close()
    End Sub

End Class