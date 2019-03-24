Public Class MenuItemCustomization
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerOrderDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        CustomerOrderDashboard.Show()
        CustomerOrderDashboard.lstOrderSummary.Items.Add(lblItem.Text)
        Me.Hide()
    End Sub
End Class