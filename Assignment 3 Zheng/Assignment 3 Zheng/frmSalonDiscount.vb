' I Mike Zheng, 000348657 certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.

Public Class frmSalonDiscount

    Dim decCalculatedTypeDiscount As Decimal
    Dim decCalculatedVisitDiscount As Decimal
    Private Sub btnCloseDiscounts_Click(sender As Object, e As EventArgs) Handles btnCloseDiscounts.Click
        Me.Close()
    End Sub

    Private Sub txtNumberOfVisits_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfVisits.TextChanged
        Try
            Integer.Parse(txtNumberOfVisits.Text)
        Catch ex As FormatException

        End Try
    End Sub

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        Dim intTextInput As Integer = -1
        Const strErrorMessage As String = "Please input a valid integer that is 0 or greater"
        decCalculatedVisitDiscount = 0D

        Try
            intTextInput = Integer.Parse(txtNumberOfVisits.Text)
        Catch ex As FormatException
        End Try

        If intTextInput >= 0 Then
            decCalculatedVisitDiscount = PriceCalcModule.DetermineVisitDiscount(intTextInput)
            lblVisitDiscount.Text = decCalculatedVisitDiscount.ToString("c")
            frmMain.decVisitDiscount = decCalculatedVisitDiscount

        Else
            MessageBox.Show(strErrorMessage)
        End If
    End Sub

    Private Sub btnCalculateTypeDiscount_Click(sender As Object, e As EventArgs) Handles btnCalculateTypeDiscount.Click
        decCalculatedTypeDiscount = 0D
        Dim intSelectedIndex As Integer

        If intSelectedIndex >= 0 Then
            intSelectedIndex = lstClientType.SelectedIndex
            decCalculatedTypeDiscount = PriceCalcModule.DetermineTypeDiscount(intSelectedIndex) * 0.01 * PriceCalcModule.CalculatePrice()
            lblClientTypeDiscount.Text = decCalculatedTypeDiscount.ToString("c")
            frmMain.decTypeDiscount = decCalculatedTypeDiscount
        End If
    End Sub

    Private Sub frmSalonDiscount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.btnCalculateTotal.Enabled = True
        frmMain.lblClientTypeDiscount.Text = decCalculatedTypeDiscount.ToString("c")
        frmMain.lblVisitDiscount.Text = decCalculatedVisitDiscount.ToString("c")
        frmMain.ServiceSelectionToolStripMenuItem.Enabled = False
    End Sub
End Class