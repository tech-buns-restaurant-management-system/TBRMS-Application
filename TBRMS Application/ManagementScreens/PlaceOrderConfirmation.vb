Public Class PlaceOrderConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        MessageBox.Show("Order Placed.")
        Me.Hide()
    End Sub
End Class