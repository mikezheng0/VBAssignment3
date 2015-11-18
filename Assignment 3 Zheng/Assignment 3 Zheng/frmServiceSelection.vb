Public Class frmServiceSelection

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        Dim intSelectedIndex As Integer
        Dim decPriceToAddToList As Decimal = PriceCalcModule.decServicesPrices(intSelectedIndex)
        intSelectedIndex = lstServices.SelectedIndex
        If intSelectedIndex >= 0 Then
            frmMain.lstHairAndServices.Items.Add(lstServices.Items.Item(intSelectedIndex))
            frmMain.lstPrice.Items.Add(decPriceToAddToList.ToString("c"))

            frmMain.ApplyDiscountsToolStripMenuItem.Enabled = True
            frmMain.btnCalculateTotal.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub btnCloseService_Click(sender As Object, e As EventArgs) Handles btnCloseService.Click
        Me.Close()
    End Sub
End Class