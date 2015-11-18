' I Mike Zheng, 000348657 certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.
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
        Dim decSelectedIndex As Decimal = -1
        If lstHairAndServices.SelectedIndex >= 0 Then
            decSelectedIndex = lstHairAndServices.SelectedIndex
        ElseIf lstPrice.SelectedIndex >= 0 Then
            decSelectedIndex = lstPrice.SelectedIndex
        End If

        If decSelectedIndex = 0 Then
            resetAll()
        ElseIf decSelectedIndex > 0 Then
            lstHairAndServices.Items.RemoveAt(decSelectedIndex)
            lstPrice.Items.RemoveAt(decSelectedIndex)
            resetLabels()
        End If

        If lstHairAndServices.Items.Count = 1 Then
            btnCalculateTotal.Enabled = False
            ApplyDiscountsToolStripMenuItem.Enabled = False
            ServiceSelectionToolStripMenuItem.Enabled = True
        End If
        lblPrice.Text = CalculatePrice().ToString("c")


    End Sub

    Private Sub resetAll()
        lstHairAndServices.Items.Clear()
        lstPrice.Items.Clear()

        btnCalculateTotal.Enabled = False
        btnRemoveItem.Enabled = False
        HairDresserSelectionToolStripMenuItem.Enabled = True
        ServiceSelectionToolStripMenuItem.Enabled = False
        ApplyDiscountsToolStripMenuItem.Enabled = False

        resetLabels()

    End Sub

    Private Sub resetLabels()
        Dim decDefaultLabelValue = 0D
        lblPrice.Text = decDefaultLabelValue.ToString("c")
        lblClientTypeDiscount.Text = decDefaultLabelValue.ToString("c")
        lblVisitDiscount.Text = decDefaultLabelValue.ToString("c")
        lblTotalPrice.Text = decDefaultLabelValue.ToString("c")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetAll()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        resetAll()
    End Sub


    Private Sub lstPrice_GotFocus(sender As Object, e As EventArgs) Handles lstPrice.GotFocus
        If lstHairAndServices.SelectedIndex >= 0 Then
            lstHairAndServices.SelectedIndex = -1
        End If
    End Sub

    Private Sub lstHairAndServices_GotFocus(sender As Object, e As EventArgs) Handles lstHairAndServices.GotFocus
        If lstPrice.SelectedIndex >= 0 Then
            lstPrice.SelectedIndex = -1
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        resetLabels()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("I Mike Zheng, 000348657 certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.")
    End Sub
End Class
