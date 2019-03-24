Public Class CustomerOrderDashboard
    Public strOrderLine() As String

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If (lstOrderSummary.Items.Count > 0) Then
            For i As Integer = 0 To (lstOrderSummary.Items.Count - 1)
                ReDim Preserve strOrderLine(i)
                strOrderLine(i) = lstOrderSummary.Items(i)
            Next

            FinalOrderSummary.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error: No items on order")
        End If

    End Sub

    Private Sub btnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        lstOrderSummary.Items.Add(btnOption1.Text)
    End Sub

    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        lstOrderSummary.Items.Add(btnOption2.Text)
    End Sub

    Private Sub btnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        lstOrderSummary.Items.Add(btnOption3.Text)
    End Sub

    Private Sub btnOption4_Click(sender As Object, e As EventArgs) Handles btnOption4.Click
        lstOrderSummary.Items.Add(btnOption4.Text)
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

