' I Mike Zheng, 000348657 certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.

Public Class frmServiceSelection

    Private Sub btnAddService_Click(sender As Object, e As EventArgs) Handles btnAddService.Click
        Dim intSelectedIndex As Integer
        Dim decPriceToAddToList As Decimal
        intSelectedIndex = lstServices.SelectedIndex

        LoadTypeValues(intSelectedIndex, "Service")
        Me.Close()
    End Sub

    Private Sub btnCloseService_Click(sender As Object, e As EventArgs) Handles btnCloseService.Click
        Me.Close()
    End Sub
End Class