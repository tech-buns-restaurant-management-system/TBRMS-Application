Public Class CustomerOrderDashboard
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        FinalOrderSummary.Show()
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

    Function ResetButtons()
        btnOption1.Hide()
        btnOption2.Hide()
        btnOption3.Hide()
        btnOption4.Hide()
    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        MenuItemCustomization.Show()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        MenuItemDeletionConfirmation.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class

