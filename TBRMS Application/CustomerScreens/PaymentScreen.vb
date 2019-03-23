Public Class PaymentScreen
    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        ThankYouScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        ThankYouScreen.Show()
        Me.Hide()
    End Sub
End Class