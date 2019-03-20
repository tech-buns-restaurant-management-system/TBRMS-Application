Public Class WelcomeScreen
    Private Sub btnCustomerOrder_Click(sender As Object, e As EventArgs) Handles btnCustomerOrder.Click
        Me.Hide()
        CustomerOrderDashboard.Show()
    End Sub
End Class