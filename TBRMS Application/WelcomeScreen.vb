Public Class WelcomeScreen
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        LogOutConfirmation.Show()
    End Sub

    Private Sub btnCustomerOrder_Click(sender As Object, e As EventArgs) Handles btnCustomerOrder.Click
        CustomerModeConfirmation.Height = 0
        CustomerModeConfirmation.Width = 0
        CustomerModeConfirmation.Show()
        CustomerModeConfirmation.Grow()
    End Sub

    Private Sub btnFOH_Click(sender As Object, e As EventArgs) Handles btnFOH.Click
        FoHSDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnManagement_Click(sender As Object, e As EventArgs) Handles btnManagement.Click
        ManagemantDashboard.Show()
        Me.Hide()
    End Sub
End Class