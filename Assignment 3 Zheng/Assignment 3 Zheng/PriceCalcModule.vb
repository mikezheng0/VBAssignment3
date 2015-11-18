' I Mike Zheng, 000348657 certify that this material is my original work. No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.

Module PriceCalcModule
    Dim strHairDressers = New String() {"Jane Samley",
                                        "Pat Johnson",
                                        "Ron Chambers",
                                        "Sue Pallon",
                                        "Laurie Renkins"}
    Dim decHairDressersPrices = New Decimal() {30D, 45D, 40D, 50D, 55D}

    Dim strServices = New String() {"Cut, Wash, Blowdry and Style",
                                    "Colour",
                                    "Highlights",
                                    "Extensions",
                                    "Up Do",
                                    "Wash, Blowdry and Style"}
    Dim decServicesPrices = New Decimal() {50D, 40D, 50D, 200D, 60D, 30D}

    Dim strClientTypes = New String() {"Standard Adult",
                                          "Child (12 and under)",
                                          "Student", "Senior (over 65)"}
    Dim decClientTypePrices = New Decimal() {0D, 10D, 5D, 15D}
    Dim decVisitRates = New Decimal() {0D, 5D, 10D, 15D}

    Public decPrice As Decimal = 0D
    Public decVisitDiscount As Decimal = 0D
    Public decTypeDiscount As Decimal = 0D
    Public decTotalPrice As Decimal = 0D

    Sub DetermineVisitDiscount(ByVal intNumOfVisits As Integer)
        CalculatePrice()
        Dim decDiscountRate As Decimal

        If (intNumOfVisits <= 3) Then
            decDiscountRate = decVisitRates(0)
        ElseIf (intNumOfVisits <= 8) Then
            decDiscountRate = decVisitRates(1)
        ElseIf (intNumOfVisits <= 13) Then
            decDiscountRate = decVisitRates(2)
        Else
            decDiscountRate = decVisitRates(3)
        End If

        decVisitDiscount = decDiscountRate * 0.01 * decPrice
    End Sub

    Sub DetermineTypeDiscount(ByVal intSelectedType As Integer)
        If intSelectedType >= 0 Then
            CalculatePrice()
            decTypeDiscount = decClientTypePrices(intSelectedType) * 0.01 * decPrice
        End If
        
    End Sub

    Sub CalculatePrice()
        decPrice = 0
        For Each intTempNumber As Integer In frmMain.lstPrice.Items
            decPrice += intTempNumber
        Next
    End Sub

    Sub LoadTypeValues(ByVal intSelectedIndex As Integer, ByVal strAddType As String)
        Dim decPriceToAddToList As Decimal
        Dim strServiceHairdresserToAdd As String
        If intSelectedIndex >= 0 And strAddType = "Hairdresser" Then
            decPriceToAddToList = decHairDressersPrices(intSelectedIndex)
            strServiceHairdresserToAdd = strHairDressers(intSelectedIndex)

            frmMain.HairDresserSelectionToolStripMenuItem.Enabled = False
            frmMain.ServiceSelectionToolStripMenuItem.Enabled = True
            frmMain.btnRemoveItem.Enabled = True

            frmMain.lstHairAndServices.Items.Add(strServiceHairdresserToAdd)
            frmMain.lstPrice.Items.Add(decPriceToAddToList.ToString("c"))
            frmMain.lblPrice.Text = PriceCalcModule.decPrice.ToString("c")
        ElseIf intSelectedIndex >= 0 And frmMain.lstHairAndServices.Items.Contains(PriceCalcModule.strServices(intSelectedIndex)) = False Then
            decPriceToAddToList = decServicesPrices(intSelectedIndex)
            strServiceHairdresserToAdd = strServices(intSelectedIndex)

            frmMain.ApplyDiscountsToolStripMenuItem.Enabled = True

            frmMain.lstHairAndServices.Items.Add(strServiceHairdresserToAdd)
            frmMain.lstPrice.Items.Add(decPriceToAddToList.ToString("c"))
            frmMain.lblPrice.Text = PriceCalcModule.decPrice.ToString("c")
        End If
        CalculatePrice()
    End Sub
End Module
