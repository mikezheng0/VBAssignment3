Public Class frmSalonDiscount
    Private Sub btnCloseDiscounts_Click(sender As Object, e As EventArgs) Handles btnCloseDiscounts.Click
        Me.Close()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub txtNumberOfVisits_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfVisits.TextChanged
        Try
            Integer.Parse(txtNumberOfVisits.Text)
        Catch ex As FormatException

        End Try
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        Dim intTextInput As Integer = -1
        Dim strErrorMessage As String = "Please input a valid integer greater than 0"

        Try
            intTextInput = Integer.Parse(txtNumberOfVisits.Text)
        Catch ex As FormatException
        End Try

        If intTextInput >= 0 Then
            Dim decCalculatedVisitDiscount As Decimal = PriceCalcModule.DetermineVisitDiscount(intTextInput)
            lblVisitDiscount.Text = decCalculatedVisitDiscount.ToString("c")
            frmMain.decVisitDiscount = decCalculatedVisitDiscount
            frmMain.lblVisitDiscount.Text = decCalculatedVisitDiscount.ToString("c")

        Else
            MessageBox.Show(strErrorMessage)
        End If
    End Sub

    Private Sub btnCalculateTypeDiscount_Click(sender As Object, e As EventArgs) Handles btnCalculateTypeDiscount.Click
        Dim intSelectedIndex As Integer
        Dim decCalculatedTypeDiscount As Decimal

        If intSelectedIndex >= 0 Then
            intSelectedIndex = lstClientType.SelectedIndex
            decCalculatedTypeDiscount = PriceCalcModule.DetermineTypeDiscount(intSelectedIndex) * 0.01 * PriceCalcModule.CalculatePrice()
            lblClientTypeDiscount.Text = decCalculatedTypeDiscount.ToString("c")
            frmMain.decTypeDiscount = decCalculatedTypeDiscount
            frmMain.lblClientTypeDiscount.Text = decCalculatedTypeDiscount.ToString("c")
        End If
    End Sub
End Class