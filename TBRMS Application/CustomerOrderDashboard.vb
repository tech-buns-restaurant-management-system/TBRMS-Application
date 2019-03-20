Public Class CustomerOrderDashboard
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        FinalOrderSummary.Show()
    End Sub

    Private Sub btnBurger1_Click(sender As Object, e As EventArgs) Handles btnBurger1.Click
        MenuItemCustomization.Show()
    End Sub

    Private Sub btnBurger2_Click(sender As Object, e As EventArgs) Handles btnBurger2.Click
        MenuItemCustomization.Show()
    End Sub

    Private Sub btnBurger3_Click(sender As Object, e As EventArgs) Handles btnBurger3.Click
        MenuItemCustomization.Show()
    End Sub

    Private Sub btnBurger4_Click(sender As Object, e As EventArgs) Handles btnBurger4.Click
        MenuItemCustomization.Show()
    End Sub

    Private Sub btnSides_Click(sender As Object, e As EventArgs) Handles btnSides.Click
        btnBurger1.Hide()
    End Sub
End Class