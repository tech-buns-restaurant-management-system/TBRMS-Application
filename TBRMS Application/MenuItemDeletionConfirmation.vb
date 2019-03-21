Public Class MenuItemDeletionConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        CustomerOrderDashboard.lstOrderSummary.Items.RemoveAt(CustomerOrderDashboard.lstOrderSummary.SelectedIndex)
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class