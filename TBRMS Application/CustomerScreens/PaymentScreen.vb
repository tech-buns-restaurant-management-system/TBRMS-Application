Public Class PaymentScreen
    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        CashThankYouScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        CardPaymentScreen.Show()
        Me.Hide()
    End Sub
End Class