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
End Class