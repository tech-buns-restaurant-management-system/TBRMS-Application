Public Class CusSplashScreen
    Public dtbOrderMods As New DataTable
    Private Sub btnStartOrder_Click(sender As Object, e As EventArgs) Handles btnStartOrder.Click
        NewCustomerOrderDashboard.FetchCategories()

        NewCustomerOrderDashboard.dgvOrderSummary.Columns.Add("colItem", "Item Name")
        NewCustomerOrderDashboard.dgvOrderSummary.Columns.Add("colMods", "Mods")

        NewCustomerOrderDashboard.dgvOrderSummary.Columns("colItem").Width = 190
        NewCustomerOrderDashboard.dgvOrderSummary.Columns("colItem").SortMode = DataGridViewColumnSortMode.NotSortable
        NewCustomerOrderDashboard.dgvOrderSummary.Columns("colMods").Width = 150
        NewCustomerOrderDashboard.dgvOrderSummary.Columns("colMods").SortMode = DataGridViewColumnSortMode.NotSortable

        dtbOrderMods.Rows.Clear()
        dtbOrderMods.Columns.Clear()

        dtbOrderMods.Columns.Add("colIng1", GetType(String))
        dtbOrderMods.Columns.Add("colIng2", GetType(String))
        dtbOrderMods.Columns.Add("colIng3", GetType(String))
        dtbOrderMods.Columns.Add("colIng4", GetType(String))

        NewCustomerOrderDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        PINScreen.Show()
    End Sub
End Class