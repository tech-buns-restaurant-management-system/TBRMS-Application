Public Class CashPayment
    Dim intSecond As Integer
    Private Sub CardPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intSecond += 1
        If intSecond >= 5 Then
            Timer1.Stop()
            ThankYouScreen.Timer1.Enabled = True
            ThankYouScreen.Timer1.Start()
            ThankYouScreen.Show()
            Me.Hide()
            intSecond = 0
        End If
    End Sub
End Class