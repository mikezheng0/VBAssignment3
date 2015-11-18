Public Class frmMain

    Public decTypeDiscount As Decimal = 0D
    Public decVisitDiscount As Decimal = 0D

    Private Sub HairDresserSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HairDresserSelectionToolStripMenuItem.Click
        Dim frmHairDresserBox As New frmSelectionMenu()
        frmHairDresserBox.ShowDialog()
    End Sub

    Private Sub ServiceSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceSelectionToolStripMenuItem.Click
        Dim frmServiceBox As New frmServiceSelection()
        frmServiceBox.ShowDialog()
    End Sub

    Private Sub ApplyDiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplyDiscountsToolStripMenuItem.Click
        Dim frmDiscountBox As New frmSalonDiscount()
        frmDiscountBox.ShowDialog()
    End Sub

    Private Sub btnCalculateTotal_Click(sender As Object, e As EventArgs) Handles btnCalculateTotal.Click
        Dim decPrice As Decimal
        decPrice = PriceCalcModule.CalculatePrice().ToString("c")
        lblPrice.Text = decPrice.ToString("c")

        lblTotalPrice.Text = (decPrice - decTypeDiscount - decVisitDiscount).ToString("c")
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        Dim decSelectedIndex As Decimal
        decSelectedIndex = lstHairAndServices.SelectedIndex
        If decSelectedIndex >= 0 Then
            lstHairAndServices.Items.RemoveAt(decSelectedIndex)
            lstPrice.Items.RemoveAt(decSelectedIndex)
        End If
    End Sub
End Class
