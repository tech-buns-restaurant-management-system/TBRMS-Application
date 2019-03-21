Public Class PaymentScreen
    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        Me.Hide()
        ThankYouScreen.Show()
    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        Me.Hide()
        ThankYouScreen.Show()
    End Sub
End Class