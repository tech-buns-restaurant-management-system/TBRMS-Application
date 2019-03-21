Public Class FinalOrderSummary
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.Hide()
        CustomerOrderDashboard.Show()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        PaymentScreen.Show()
    End Sub
End Class