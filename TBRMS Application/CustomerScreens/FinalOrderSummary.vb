Public Class FinalOrderSummary
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        For Each item In CustomerOrderDashboard.strOrderLine
            CustomerOrderDashboard.lstOrderSummary.Items.Add(item)
        Next

        CustomerOrderDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        OrderTagScreen.Show()
        lstOrderSummary.Items.Clear()
        Me.Hide()
    End Sub
End Class