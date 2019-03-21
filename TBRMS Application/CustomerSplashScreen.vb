Public Class CustomerSplashScreen
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        PINScreen.Show()
    End Sub

    Private Sub btnStartOrder_Click(sender As Object, e As EventArgs) Handles btnStartOrder.Click
        CustomerOrderDashboard.Show()
        Me.Hide()
    End Sub
End Class