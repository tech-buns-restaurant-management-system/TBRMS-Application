Public Class ThankYouScreen

    Private Sub ThankYouScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 10000 Then
            Me.Hide()
            CustomerOrderDashboard.Show()
        End If
    End Sub
End Class