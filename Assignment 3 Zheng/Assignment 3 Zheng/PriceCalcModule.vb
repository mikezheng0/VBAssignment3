Module PriceCalcModule
    Dim strHairDressers = New String() {"Jane Samley",
                                        "Pat Johnson",
                                        "Ron Chambers",
                                        "Sue Pallon",
                                        "Laurie Renkins"}
    Public decHairDressersPrices = New Decimal() {30D, 45D, 40D, 50D, 55D}

    Dim strServices = New String() {"Cut, Wash, Blowdry and Style",
                                    "Colour",
                                    "Highlights",
                                    "Extensions",
                                    "Up Do",
                                    "Wash, Blowdry and Style"}
    Public decServicesPrices = New Decimal() {50D, 40D, 50D, 200D, 60D, 30D}

    Dim strClientTypes = New String() {"Standard Adult", "Child (12 and under)", "Student", "Senior (over 65)"}
    Dim decClientTypePrices = New Decimal() {0D, 10D, 5D, 15D}
    Dim decVisitRates = New Decimal() {0D, 5D, 10D, 15D}

    Public Function DetermineVisitDiscount(ByVal intNumOfVisits As Integer) As Decimal
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

        Return decDiscountRate * 0.01 * CalculatePrice()
    End Function

    Public Function DetermineTypeDiscount(ByVal intSelectedType As Integer) As Decimal
        Return decClientTypePrices(intSelectedType) * 0.01 * CalculatePrice()
    End Function

    Public Function CalculatePrice() As Decimal
        Dim decTotal As Decimal = 0
        For Each intTempNumber As Integer In frmMain.lstPrice.Items
            decTotal += intTempNumber
        Next

        Return decTotal
    End Function

    'LoadTypeValues()
End Module
