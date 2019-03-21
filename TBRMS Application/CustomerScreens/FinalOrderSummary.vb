Public Class FinalOrderSummary
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.Hide()
        CustomerOrderDashboard.Show()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Hide()
        PaymentScreen.Show()
    End Sub

    Private Sub FinalOrderSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In CustomerOrderDashboard.strOrderLine
            lstOrderSummary.Items.Add(item)
        Next
    End Sub
End Class