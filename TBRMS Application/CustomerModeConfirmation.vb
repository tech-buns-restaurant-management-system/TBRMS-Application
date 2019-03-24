Public Class CustomerModeConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        CustomerSplashScreen.Show()
        WelcomeScreen.Hide()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class