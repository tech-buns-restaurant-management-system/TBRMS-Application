Public Class ManagemantDashboard
    Private Sub picOrderSummary_Click(sender As Object, e As EventArgs) Handles picOrderSummary.Click
        ExitManagementConfirmation.Height = 0
        ExitManagementConfirmation.Width = 0
        ExitManagementConfirmation.Show()
        ExitManagementConfirmation.Grow()
    End Sub
End Class
