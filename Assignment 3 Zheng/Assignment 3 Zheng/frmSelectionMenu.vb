Public Class frmSelectionMenu

    Private Sub btnAddHairdresser_Click(sender As Object, e As EventArgs) Handles btnAddHairdresser.Click
        Dim intSelectedIndex As Integer
        Dim decPriceToAddToList As Decimal
        intSelectedIndex = lstHairdressers.SelectedIndex

        If intSelectedIndex >= 0 Then
            decPriceToAddToList = PriceCalcModule.decHairDressersPrices(intSelectedIndex)
            frmMain.lstHairAndServices.Items.Add(PriceCalcModule.strHairDressers(intSelectedIndex))
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