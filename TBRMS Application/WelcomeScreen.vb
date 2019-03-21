Public Class WelcomeScreen
    Private Sub btnCustomerOrder_Click(sender As Object, e As EventArgs) Handles btnCustomerOrder.Click
        CustomerSplashScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LogOutConfirmation.Show()
    End Sub
End Class