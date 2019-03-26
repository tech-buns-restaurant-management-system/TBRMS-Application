Public Class PlaceOrderConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        MessageBox.Show("Order Placed.")
        ManagemantDashboard.lsbInventoryOrder.Items.Clear()
        Me.Hide()
    End Sub
End Class