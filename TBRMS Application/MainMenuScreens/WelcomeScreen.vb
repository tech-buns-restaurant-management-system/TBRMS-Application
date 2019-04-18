Public Class WelcomeScreen
    Private Sub btnCustomerOrder_Click(sender As Object, e As EventArgs) Handles btnCustomerOrder.Click
        If LoginSplash.blnManagement = "False" Then
            MessageBox.Show("Error: You are not logged into a management account. Access Denied.")
        Else
            CustomerModeConfirmation.Height = 0
            CustomerModeConfirmation.Width = 0
            CustomerModeConfirmation.Show()
            CustomerModeConfirmation.Grow()
        End If
    End Sub

    Private Sub btnFOH_Click(sender As Object, e As EventArgs) Handles btnFOH.Click
        FoHDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnManagement_Click(sender As Object, e As EventArgs) Handles btnManagement.Click
        If LoginSplash.blnManagement = "False" Then
            MessageBox.Show("Error: You are not logged into a management account. Access Denied.")
        Else
            ManagementDashboard.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        LogOutConfirmation.Height = 0
        LogOutConfirmation.Width = 0
        LogOutConfirmation.Show()
        LogOutConfirmation.Grow()
    End Sub
End Class