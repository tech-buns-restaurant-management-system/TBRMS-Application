Public Class CashThankYouScreen
    Dim intSecond As Integer
    Private Sub CashPaymentScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intSecond += 1
        If intSecond >= 5 Then
            Timer1.Stop()
            CustomerSplashScreen.Show()
            Me.Hide()
        End If
    End Sub
End Class