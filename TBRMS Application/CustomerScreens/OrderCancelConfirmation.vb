Public Class OrderCancelConfirmation
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Hide()
        CustomerSplashScreen.Show()
        ReDim CustomerOrderDashboard.strOrderLine(0)
        CustomerOrderDashboard.lstOrderSummary.Items.Clear()
        CustomerOrderDashboard.ResetButtons()
        CustomerOrderDashboard.Hide()
    End Sub
End Class