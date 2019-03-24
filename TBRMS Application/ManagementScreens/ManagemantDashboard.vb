Public Class ManagemantDashboard
    Private Sub ManagemantDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSuppliersPortal_Click(sender As Object, e As EventArgs) Handles btnSuppliersPortal.Click
        btnOpt1.Text = "Add New Supplier"
        btnOpt2.Text = "Edit Supplier Information"
        btnOpt3.Text = "Delete Supplier"
    End Sub

    Private Sub btnInventoryItemsPortal_Click(sender As Object, e As EventArgs) Handles btnInventoryItemsPortal.Click
        btnOpt1.Text = "Add New Inventory Item"
        btnOpt2.Text = "Edit Existing Inventory Item"
        btnOpt3.Text = "Place Inventory Orders"
    End Sub

    Private Sub btnMenuItemsPortal_Click(sender As Object, e As EventArgs) Handles btnMenuItemsPortal.Click
        btnOpt1.Text = "Add New Menu Item"
        btnOpt2.Text = "Edit Menu Item"
        btnOpt3.Text = "Delete Menu Item"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WelcomeScreen.Show()
        Me.Hide()

    End Sub
End Class