Public Class WelcomeScreen
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LogOutConfirmation.Show()
    End Sub

    Private Sub btnCustomerOrder_Click(sender As Object, e As EventArgs) Handles btnCustomerOrder.Click
        CustomerSplashScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnFOH_Click(sender As Object, e As EventArgs) Handles btnFOH.Click
        FoHSDashboard.Show()
        Me.Hide()
    End Sub
End Class