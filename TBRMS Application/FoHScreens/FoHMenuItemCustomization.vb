Public Class FoHMenuItemCustomization
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FoHSDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AddNewCustomizations()
        FoHSDashboard.Show()
        Me.Hide()
    End Sub

    Function AddNewCustomizations()
        Dim strCustomization(3) As String
        Dim strOrderLineItem, strItem As String
        Dim intIndex As Integer

        strItem = lblItem.Text

        'Handles the customization labels for each option on each item
        Select Case strItem
            Case "Drunk Monk Burger"
                strOrderLineItem = "Drunk Monk Burger"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-On"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-On"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-On"
                End If

                If rdIng2None.Checked = True Then
                    strCustomization(1) = " N-Ar"
                ElseIf rdIng2Light.Checked = True Then
                    strCustomization(1) = " L-Ar"
                ElseIf rdIng2Reg.Checked = True Then
                    strCustomization(1) = ""
                ElseIf rdIng2Extra.Checked = True Then
                    strCustomization(1) = " E-Ar"
                End If

                If rdIng3None.Checked = True Then
                    strCustomization(2) = " N-Ai"
                ElseIf rdIng3Light.Checked = True Then
                    strCustomization(2) = " L-Ai"
                ElseIf rdIng3Reg.Checked = True Then
                    strCustomization(2) = ""
                ElseIf rdIng3Extra.Checked = True Then
                    strCustomization(2) = " E-Ai"
                End If

                If rdIng4None.Checked = True Then
                    strCustomization(3) = " N-Ch"
                ElseIf rdIng4Light.Checked = True Then
                    strCustomization(3) = " L-Ch"
                ElseIf rdIng4Reg.Checked = True Then
                    strCustomization(3) = ""
                ElseIf rdIng4Extra.Checked = True Then
                    strCustomization(3) = " E-Ch"
                End If

            Case "Banzai Burger"
                strOrderLineItem = "Banzai Burger"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-Le"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-Le"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-Le"
                End If

                If rdIng2None.Checked = True Then
                    strCustomization(1) = " N-Pi"
                ElseIf rdIng2Light.Checked = True Then
                    strCustomization(1) = " L-Pi"
                ElseIf rdIng2Reg.Checked = True Then
                    strCustomization(1) = ""
                ElseIf rdIng2Extra.Checked = True Then
                    strCustomization(1) = " E-Pi"
                End If

                If rdIng3None.Checked = True Then
                    strCustomization(2) = " N-Te"
                ElseIf rdIng3Light.Checked = True Then
                    strCustomization(2) = " L-Te"
                ElseIf rdIng3Reg.Checked = True Then
                    strCustomization(2) = ""
                ElseIf rdIng3Extra.Checked = True Then
                    strCustomization(2) = " E-Te"
                End If

                If rdIng4None.Checked = True Then
                    strCustomization(3) = " N-Ch"
                ElseIf rdIng4Light.Checked = True Then
                    strCustomization(3) = " L-Ch"
                ElseIf rdIng4Reg.Checked = True Then
                    strCustomization(3) = ""
                ElseIf rdIng4Extra.Checked = True Then
                    strCustomization(3) = " E-Ch"
                End If

            Case "Bare Essentials Burger"
                strOrderLineItem = "Bare Essentials Burger"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-Le"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-Le"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-Le"
                End If

                If rdIng2None.Checked = True Then
                    strCustomization(1) = " N-To"
                ElseIf rdIng2Light.Checked = True Then
                    strCustomization(1) = " L-To"
                ElseIf rdIng2Reg.Checked = True Then
                    strCustomization(1) = ""
                ElseIf rdIng2Extra.Checked = True Then
                    strCustomization(1) = " E-To"
                End If

                If rdIng3None.Checked = True Then
                    strCustomization(2) = " N-Ke"
                ElseIf rdIng3Light.Checked = True Then
                    strCustomization(2) = " L-Ke"
                ElseIf rdIng3Reg.Checked = True Then
                    strCustomization(2) = ""
                ElseIf rdIng3Extra.Checked = True Then
                    strCustomization(2) = " E-Ke"
                End If

                If rdIng4None.Checked = True Then
                    strCustomization(3) = " N-Ch"
                ElseIf rdIng4Light.Checked = True Then
                    strCustomization(3) = " L-Ch"
                ElseIf rdIng4Reg.Checked = True Then
                    strCustomization(3) = ""
                ElseIf rdIng4Extra.Checked = True Then
                    strCustomization(3) = " E-Ch"
                End If

            Case "Sea Salt French Fries"
                strOrderLineItem = "Sea Salt French Fries"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-Sa"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-Sa"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-Sa"
                End If

            Case "Sea Salt Sweet Potato Fries"
                strOrderLineItem = "Sea Salt Sweet Potato Fries"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-Sa"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-Sa"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-Sa"
                End If

            Case "Roasted Vegetables"
                strOrderLineItem = "Roasted Vegetables"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-SP"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-SP"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-SP"
                End If

                If rdIng2None.Checked = True Then
                    strCustomization(1) = " N-Or"
                ElseIf rdIng2Light.Checked = True Then
                    strCustomization(1) = " L-Or"
                ElseIf rdIng2Reg.Checked = True Then
                    strCustomization(1) = ""
                ElseIf rdIng2Extra.Checked = True Then
                    strCustomization(1) = " E-Or"
                End If

                If rdIng3None.Checked = True Then
                    strCustomization(2) = " N-RP"
                ElseIf rdIng3Light.Checked = True Then
                    strCustomization(2) = " L-RP"
                ElseIf rdIng3Reg.Checked = True Then
                    strCustomization(2) = ""
                ElseIf rdIng3Extra.Checked = True Then
                    strCustomization(2) = " E-RP"
                End If

                If rdIng4None.Checked = True Then
                    strCustomization(3) = " N-BV"
                ElseIf rdIng4Light.Checked = True Then
                    strCustomization(3) = " L-BV"
                ElseIf rdIng4Reg.Checked = True Then
                    strCustomization(3) = ""
                ElseIf rdIng4Extra.Checked = True Then
                    strCustomization(3) = " E-BV"
                End If

            Case "Mini Gherkins"
                strOrderLineItem = "Mini Gherkins"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-SM"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-SM"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-SM"
                End If

            Case "Top Beverages Vanilla Cream Soda"
                strOrderLineItem = "Top Beverages Vanilla Cream Soda"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-Ice"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-Ice"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-Ice"
                End If

            Case "Top Beverages Fresh Lemonade"
                strOrderLineItem = "Top Beverages Fresh Lemonade"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-Ice"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-Ice"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-Ice"
                End If

            Case "Spring Water"
                strOrderLineItem = "Spring Water"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-Ice"
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-Ice"
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-Ice"
                End If
        End Select
    End Function

    Function SetIngredients()
        pnlIng1.Visible = False
        pnlIng2.Visible = False
        pnlIng3.Visible = False
        pnlIng4.Visible = False

        rdIng1Reg.Checked = True
        rdIng2Reg.Checked = True
        rdIng3Reg.Checked = True
        rdIng4Reg.Checked = True

        Select Case lblItem.Text
            Case "Drunk Monk Burger"
                pnlIng1.Visible = True
                lblIng1.Text = "Red Ale-Carmelized Onions"

                pnlIng2.Visible = True
                lblIng2.Text = "Arugula"

                pnlIng3.Visible = True
                lblIng3.Text = "Rosemary Aioli"

                pnlIng4.Visible = True
                lblIng4.Text = "Brie Cheese"

            Case "Banzai Burger"
                pnlIng1.Visible = True
                lblIng1.Text = "Lettuce"

                pnlIng2.Visible = True
                lblIng2.Text = "Pineapple Rings"

                pnlIng3.Visible = True
                lblIng3.Text = "Teriyaki Demi-Glace"

                pnlIng4.Visible = True
                lblIng4.Text = "Cheddar Cheese"

            Case "Bare Essentials Burger"
                pnlIng1.Visible = True
                lblIng1.Text = "Lettuce"

                pnlIng2.Visible = True
                lblIng2.Text = "Tomato"

                pnlIng3.Visible = True
                lblIng3.Text = "Ketchup"

                pnlIng4.Visible = True
                lblIng4.Text = "American Cheese"

            Case "Sea Salt French Fries"
                pnlIng1.Visible = True
                lblIng1.Text = "Sea Salt"

            Case "Sea Salt Sweet Potato Fries"
                pnlIng1.Visible = True
                lblIng1.Text = "Sea Salt"

            Case "Roasted Vegetables"
                pnlIng1.Visible = True
                lblIng1.Text = "Salt & Pepper"

                pnlIng2.Visible = True
                lblIng2.Text = "Oregano"

                pnlIng3.Visible = True
                lblIng3.Text = "Crushed Red Pepper"

                pnlIng4.Visible = True
                lblIng4.Text = "Balsamic Vinagrette"

            Case "Top Beverages Vanilla Cream Soda"
                pnlIng1.Visible = True
                lblIng1.Text = "Ice"

            Case "Top Beverages Fresh Lemonade"
                pnlIng1.Visible = True
                lblIng1.Text = "Ice"

            Case "Spring Water"
                pnlIng1.Visible = True
                lblIng1.Text = "Ice"

            Case "Mini Gherkins"
                pnlIng1.Visible = True
                lblIng1.Text = "Spicy Mustard"
        End Select
    End Function
End Class