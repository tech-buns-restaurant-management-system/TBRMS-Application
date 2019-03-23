Public Class FinalOrderSummary
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        CustomerOrderDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        PaymentScreen.Show()
        Me.Hide()
    End Sub

    Private Sub FinalOrderSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In CustomerOrderDashboard.strOrderLine
            lstOrderSummary.Items.Add(item)
        Next
    End Sub
End Class