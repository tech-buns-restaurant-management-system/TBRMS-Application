Public Class CustomerOrderDashboard
    Public strOrderLine() As String

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If (lstOrderSummary.Items.Count > 0) Then
            FinalOrderSummary.lstOrderSummary.Items.Clear()
            For i As Integer = 0 To (lstOrderSummary.Items.Count - 1)
                ReDim Preserve strOrderLine(i)
                strOrderLine(i) = lstOrderSummary.Items(i)
                FinalOrderSummary.lstOrderSummary.Items.Add(lstOrderSummary.Items(i))
            Next

            ResetButtons()
            FinalOrderSummary.Show()
            lstOrderSummary.Items.Clear()
            Me.Hide()
        Else
            MessageBox.Show("Error: No items on order")
        End If

    End Sub

    Private Sub btnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        MenuItemCustomization.lblItem.Text = btnOption1.Text
        MenuItemCustomization.ResetIngredients()

        Select Case btnOption1.Text
            Case "Drunk Monk Burger"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Red Ale-Carmelized Onions"

                MenuItemCustomization.pnlIng2.Visible = True
                MenuItemCustomization.lblIng2.Text = "Arugula"

                MenuItemCustomization.pnlIng3.Visible = True
                MenuItemCustomization.lblIng3.Text = "Rosemary Aioli"

                MenuItemCustomization.pnlIng4.Visible = True
                MenuItemCustomization.lblIng4.Text = "Brie Cheese"

            Case "Sea Salt French Fries"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Sea Salt"

            Case "Top Beverages Vanilla Cream Soda"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Ice"
        End Select

        MenuItemCustomization.Show()
        ResetButtons()
        'lstOrderSummary.Items.Add(btnOption1.Text)
    End Sub

    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        MenuItemCustomization.lblItem.Text = btnOption2.Text
        MenuItemCustomization.ResetIngredients()

        Select Case btnOption2.Text
            Case "Banzai Burger"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Lettuce"

                MenuItemCustomization.pnlIng2.Visible = True
                MenuItemCustomization.lblIng2.Text = "Pineapple Rings"

                MenuItemCustomization.pnlIng3.Visible = True
                MenuItemCustomization.lblIng3.Text = "Teriyaki Demi-Glace"

                MenuItemCustomization.pnlIng4.Visible = True
                MenuItemCustomization.lblIng4.Text = "Cheddar Cheese"

            Case "Sea Salt Sweet Potato Fries"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Sea Salt"

            Case "Top Beverages Fresh Lemonade"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Ice"
        End Select

        MenuItemCustomization.Show()
        ResetButtons()
        'lstOrderSummary.Items.Add(btnOption2.Text)
    End Sub

    Private Sub btnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        MenuItemCustomization.lblItem.Text = btnOption3.Text
        MenuItemCustomization.ResetIngredients()

        Select Case btnOption3.Text
            Case "Banzai Burger"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Lettuce"

                MenuItemCustomization.pnlIng2.Visible = True
                MenuItemCustomization.lblIng2.Text = "Pineapple Rings"

                MenuItemCustomization.pnlIng3.Visible = True
                MenuItemCustomization.lblIng3.Text = "Teriyaki Demi-Glace"

                MenuItemCustomization.pnlIng4.Visible = True
                MenuItemCustomization.lblIng4.Text = "Cheddar Cheese"

            Case "Roasted Vegetables"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Salt & Pepper"

                MenuItemCustomization.pnlIng2.Visible = True
                MenuItemCustomization.lblIng2.Text = "Oregano"

                MenuItemCustomization.pnlIng3.Visible = True
                MenuItemCustomization.lblIng3.Text = "Crushed Red Pepper"

                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Balsamic Vinagrette"

            Case "Spring Water"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Ice"
        End Select
        MenuItemCustomization.Show()
        ResetButtons()
        'lstOrderSummary.Items.Add(btnOption3.Text)
    End Sub

    Private Sub btnOption4_Click(sender As Object, e As EventArgs) Handles btnOption4.Click
        MenuItemCustomization.lblItem.Text = btnOption4.Text
        MenuItemCustomization.ResetIngredients()

        Select Case btnOption4.Text
            Case "Mini Gherkins"
                MenuItemCustomization.pnlIng1.Visible = True
                MenuItemCustomization.lblIng1.Text = "Spicy Mustard"

        End Select
        MenuItemCustomization.Show()
        ResetButtons()
        'lstOrderSummary.Items.Add(btnOption4.Text)
    End Sub

    Private Sub btnBurgers_Click(sender As Object, e As EventArgs) Handles btnBurgers.Click
        ResetButtons()

        btnOption1.Show()
        btnOption1.Text = "Drunk Monk Burger"

        btnOption2.Show()
        btnOption2.Text = "Banzai Burger"

        btnOption3.Show()
        btnOption3.Text = "Bare Essentials Burger"
    End Sub

    Private Sub btnSides_Click(sender As Object, e As EventArgs) Handles btnSides.Click
        ResetButtons()

        btnOption1.Show()
        btnOption1.Text = "Sea Salt French Fries"

        btnOption2.Show()
        btnOption2.Text = "Sea Salt Sweet Potato Fries"

        btnOption3.Show()
        btnOption3.Text = "Roasted Vegetables"

        btnOption4.Show()
        btnOption4.Text = "Mini Gherkins"

    End Sub

    Private Sub btnBeverages_Click(sender As Object, e As EventArgs) Handles btnBeverages.Click
        ResetButtons()

        btnOption1.Show()
        btnOption1.Text = "Top Beverages Vanilla Cream Soda"

        btnOption2.Show()
        btnOption2.Text = "Top Beverages Fresh Lemonade"

        btnOption3.Show()
        btnOption3.Text = "Spring Water"
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lstOrderSummary.SelectedIndex = -1 Then
            MessageBox.Show("Error: No order item is selected")
        Else
            MenuItemCustomization.lblItem.Text = lstOrderSummary.Items(lstOrderSummary.SelectedIndex)
            ItemCustomization(lstOrderSummary.Items(lstOrderSummary.SelectedIndex))
            MenuItemCustomization.Show()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (lstOrderSummary.SelectedIndex = -1) Then
            MessageBox.Show("Error: No order item is selected")
        Else
            MenuItemDeletionConfirmation.Show()
        End If
    End Sub

    Private Sub btnOrderCancel_Click(sender As Object, e As EventArgs) Handles btnOrderCancel.Click
        OrderCancelConfirmation.Show()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        MenuSearchScreen.pnlSlider.Location = New Point(-2, 720)
        MenuSearchScreen.txtSearch.Text = ""
        MenuSearchScreen.Show()
        MenuSearchScreen.tmrSlider.Enabled = True
        MenuSearchScreen.tmrSlider.Start()
    End Sub

    Function ResetButtons()
        btnOption1.Hide()
        btnOption2.Hide()
        btnOption3.Hide()
        btnOption4.Hide()
    End Function

    Function ItemCustomization(strItem As String)
        'TODO: Customization Options
        Select Case strItem
            Case "Drunk Monk Burger"

            Case "Banzai Burger"

            Case "Bare Essentials Burger"

            Case "Sea Salted Sweet Potato Fries"

            Case "Sea Salted French Fries"

            Case "Roasted Vegetables"

            Case "Top Beverages Vanilla Cream Soda"

            Case "Top Beverages Fresh Lemonade"

            Case "Spring Water"

        End Select
    End Function
End Class

