Public Class ManagemantDashboard
    Private Sub ManagemantDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSuppliersPortal_Click(sender As Object, e As EventArgs) Handles btnSuppliersPortal.Click
        btnOpt1.Visible = True
        btnOpt2.Visible = True
        btnOpt3.Visible = True
        btnOpt1.Text = "Add New Supplier"
        btnOpt2.Text = "Edit Supplier Information"
        btnOpt3.Text = "Delete Supplier"
        lsbInventoryItems.Visible = False
        lsbInventoryOrder.Visible = False
        btnAddtoOrder.Visible = False
        lsbPortalDisplay.Visible = True
    End Sub

    Private Sub btnInventoryItemsPortal_Click(sender As Object, e As EventArgs) Handles btnInventoryItemsPortal.Click
        btnOpt1.Visible = True
        btnOpt2.Visible = True
        btnOpt3.Visible = True
        btnOpt1.Text = "Add New Inventory Item"
        btnOpt2.Text = "Edit Existing Inventory Item"
        btnOpt3.Text = "Place Inventory Orders"
        btnAddtoOrder.Visible = True
        lsbPortalDisplay.Visible = False
        lsbInventoryItems.Visible = True
        lsbInventoryOrder.Visible = True
    End Sub

    Private Sub btnMenuItemsPortal_Click(sender As Object, e As EventArgs) Handles btnMenuItemsPortal.Click
        btnOpt1.Visible = True
        btnOpt2.Visible = True
        btnOpt3.Visible = True
        btnOpt1.Text = "Add New Menu Item"
        btnOpt2.Text = "Edit Menu Item"
        btnOpt3.Text = "Delete Menu Item"
        lsbInventoryItems.Visible = False
        lsbInventoryOrder.Visible = False
        btnAddtoOrder.Visible = False
        btnAddtoOrder.Visible = True
        lsbPortalDisplay.Visible = True
    End Sub

    'Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
    '    WelcomeScreen.Show()
    '    Me.Hide()
    '    btnOpt1.Visible = False
    '    btnOpt2.Visible = False
    '    btnOpt3.Visible = False
    '    lsbInventoryItems.Visible = False
    '    lsbInventoryOrder.Visible = False
    '    btnAddtoOrder.Visible = False
    '    lsbPortalDisplay.Visible = False
    '    lsbInventoryItems.Items.Clear()
    '    lsbInventoryOrder.Items.Clear()
    '    lsbPortalDisplay.Items.Clear()


    'End Sub
End Class