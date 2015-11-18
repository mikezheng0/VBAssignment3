Public Class frmSelectionMenu

    Private Sub btnAddHairdresser_Click(sender As Object, e As EventArgs) Handles btnAddHairdresser.Click
        Dim intSelectedIndex As Integer
        Dim decPriceToAddToList As Decimal = PriceCalcModule.decHairDressersPrices(intSelectedIndex)
        intSelectedIndex = lstHairdressers.SelectedIndex

        If intSelectedIndex >= 0 Then
            frmMain.lstHairAndServices.Items.Add(lstHairdressers.Items.Item(intSelectedIndex))
            frmMain.lstPrice.Items.Add(decPriceToAddToList.ToString("c"))

            frmMain.btnRemoveItem.Enabled = True
            frmMain.HairDresserSelectionToolStripMenuItem.Enabled = False
            frmMain.ServiceSelectionToolStripMenuItem.Enabled = True

            Me.Close()
        End If
    End Sub

    Private Sub btnCloseHairdresser_Click(sender As Object, e As EventArgs) Handles btnCloseHairdresser.Click
        Me.Close()
    End Sub

End Class