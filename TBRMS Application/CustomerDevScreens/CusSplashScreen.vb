Public Class CusSplashScreen
    Private Sub btnStartOrder_Click(sender As Object, e As EventArgs) Handles btnStartOrder.Click
        NewCustomerOrderDashboard.FetchCategories()

        NewCustomerOrderDashboard.dgvOrderSummary.Columns.Add("colItem", "Item Name")
        NewCustomerOrderDashboard.dgvOrderSummary.Columns.Add("colMods", "Mods")

        NewCustomerOrderDashboard.dgvOrderSummary.Columns("colItem").Width = 190
        NewCustomerOrderDashboard.dgvOrderSummary.Columns("colItem").SortMode = DataGridViewColumnSortMode.NotSortable
        NewCustomerOrderDashboard.dgvOrderSummary.Columns("colMods").Width = 150
        NewCustomerOrderDashboard.dgvOrderSummary.Columns("colMods").SortMode = DataGridViewColumnSortMode.NotSortable

        NewCustomerOrderDashboard.Show()
        Me.Hide()
    End Sub
End Class