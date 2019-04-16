Public Class PaymentSelection
    Public blnPaid As Boolean
    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        blnPaid = True
        CardPayment.Timer1.Enabled = True
        CardPayment.Timer1.Start()
        CardPayment.Show()
        Me.Hide()
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        blnPaid = False
        CashPayment.Timer1.Enabled = True
        CashPayment.Timer1.Start()
        CashPayment.Show()
        Me.Hide()
    End Sub
End Class