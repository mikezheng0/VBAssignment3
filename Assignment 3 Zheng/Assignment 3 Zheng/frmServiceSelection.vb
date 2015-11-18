Public Class frmServiceSelection

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        Dim intSelectedIndex As Integer
        Dim decPriceToAddToList As Decimal
        intSelectedIndex = lstServices.SelectedIndex
        If intSelectedIndex >= 0 And frmMain.lstHairAndServices.Items.Contains(PriceCalcModule.strServices(intSelectedIndex)) = False Then
            decPriceToAddToList = PriceCalcModule.decServicesPrices(intSelectedIndex)
            frmMain.lstHairAndServices.Items.Add(PriceCalcModule.strServices(intSelectedIndex))
            frmMain.lstPrice.Items.Add(decPriceToAddToList.ToString("c"))

            frmMain.ApplyDiscountsToolStripMenuItem.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub btnCloseService_Click(sender As Object, e As EventArgs) Handles btnCloseService.Click
        Me.Close()
    End Sub
End Class