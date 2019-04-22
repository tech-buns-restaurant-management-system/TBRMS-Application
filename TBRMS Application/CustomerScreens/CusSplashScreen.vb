Public Class CusSplashScreen
    Public dtbOrderMods As New DataTable
    Private Sub btnStartOrder_Click(sender As Object, e As EventArgs) Handles btnStartOrder.Click
        CustomerOrderDashboard.FetchCategories()

        'Initializes the necessary columns in the dgvOrderSummary DataGridView
        CustomerOrderDashboard.dgvOrderSummary.Columns.Add("colItem", "Item Name")
        CustomerOrderDashboard.dgvOrderSummary.Columns.Add("colMods", "Mods")

        CustomerOrderDashboard.dgvOrderSummary.Columns("colItem").Width = 190
        CustomerOrderDashboard.dgvOrderSummary.Columns("colItem").SortMode = DataGridViewColumnSortMode.NotSortable
        CustomerOrderDashboard.dgvOrderSummary.Columns("colMods").Width = 150
        CustomerOrderDashboard.dgvOrderSummary.Columns("colMods").SortMode = DataGridViewColumnSortMode.NotSortable

        'Initializes the necessary columns in the dtbOrderMods datatable
        dtbOrderMods.Rows.Clear()
        dtbOrderMods.Columns.Clear()

        dtbOrderMods.Columns.Add("colIng1", GetType(String))
        dtbOrderMods.Columns.Add("colIng2", GetType(String))
        dtbOrderMods.Columns.Add("colIng3", GetType(String))
        dtbOrderMods.Columns.Add("colIng4", GetType(String))

        CustomerOrderDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        PINScreen.Show()
    End Sub
End Class