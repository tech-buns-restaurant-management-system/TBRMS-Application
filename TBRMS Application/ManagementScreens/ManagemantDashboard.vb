Public Class ManagemantDashboard
    Public Identifier As String
    Private Sub btnSuppliersPortal_Click(sender As Object, e As EventArgs) Handles btnSuppliersPortal.Click
        lsbPortalDisplay.Items.Clear()
        btnOpt1.Visible = True
        btnOpt2.Visible = True
        btnOpt3.Visible = True
        btnOpt1.Text = "Add New Supplier"
        btnOpt2.Text = "View/Edit Supplier Information"
        btnOpt3.Text = "Delete Supplier"
        lsbInventoryItems.Visible = False
        lsbInventoryOrder.Visible = False
        btnAddtoOrder.Visible = False
        lsbPortalDisplay.Visible = True
        lsbPortalDisplay.Items.Add("Food Inc.")
        lsbPortalDisplay.Items.Add("Sides Inc.")
        lsbPortalDisplay.Items.Add("Drinks Inc.")
    End Sub

    Private Sub btnInventoryItemsPortal_Click(sender As Object, e As EventArgs) Handles btnInventoryItemsPortal.Click
        lsbInventoryItems.Items.Clear()
        lsbInventoryOrder.Items.Clear()
        btnOpt1.Visible = True
        btnOpt2.Visible = True
        btnOpt3.Visible = True
        btnOpt1.Text = "Add New Inventory Item"
        btnOpt2.Text = "View/Edit Existing Inventory Item"
        btnOpt3.Text = "Place Inventory Order"
        btnAddtoOrder.Visible = True
        lsbPortalDisplay.Visible = False
        lsbInventoryItems.Visible = True
        lsbInventoryOrder.Visible = True
        lsbInventoryItems.Items.Add("Beef")
        lsbInventoryItems.Items.Add("Buns")
        lsbInventoryItems.Items.Add("Lettuce")
        lsbInventoryOrder.Items.Add("Buns")
        lsbInventoryOrder.Items.Add("Lettuce")
        lsbInventoryOrder.Items.Add("Beef")
    End Sub

    Private Sub btnMenuItemsPortal_Click(sender As Object, e As EventArgs) Handles btnMenuItemsPortal.Click
        lsbPortalDisplay.Items.Clear()
        btnOpt1.Visible = True
        btnOpt2.Visible = True
        btnOpt3.Visible = True
        btnOpt1.Text = "Add New Menu Item"
        btnOpt2.Text = "View/Edit Menu Item"
        btnOpt3.Text = "Delete Menu Item"
        lsbInventoryItems.Visible = False
        lsbInventoryOrder.Visible = False
        btnAddtoOrder.Visible = False
        lsbPortalDisplay.Visible = True
        lsbPortalDisplay.Items.Add("Bonzai Burger")
        lsbPortalDisplay.Items.Add("Water")
        lsbPortalDisplay.Items.Add("Drunk Monkey Burger")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WelcomeScreen.Show()
        btnOpt1.Visible = False
        btnOpt2.Visible = False
        btnOpt3.Visible = False
        lsbInventoryItems.Visible = False
        lsbInventoryOrder.Visible = False
        btnAddtoOrder.Visible = False
        lsbPortalDisplay.Visible = False
        lsbInventoryItems.Items.Clear()
        lsbInventoryOrder.Items.Clear()
        lsbPortalDisplay.Items.Clear()
        Me.Hide()
    End Sub



    Private Sub btnOpt1_Click(sender As Object, e As EventArgs) Handles btnOpt1.Click
        If btnOpt1.Text = "Add New Supplier" Then
            AddForm.txtAddName.Clear()
            AddForm.BtnSave.Text = "Add Supplier"
            AddForm.Label2.Visible = True
            AddForm.txtAddAddress.Visible = True
            AddForm.Show()
            Identifier = "s1"
        ElseIf btnOpt1.Text = "Add New Inventory Item" Then
            AddForm.txtAddName.Clear()
            AddForm.Label1.Text = "Item Name"
            AddForm.BtnSave.Text = "Add Item"
            AddForm.txtAddAddress.Visible = False
            AddForm.Label2.Visible = False
            AddForm.Show()
            Identifier = "i1"
        ElseIf btnOpt1.Text = "Add New Menu Item" Then
            AddForm.txtAddName.Clear()
            AddForm.BtnSave.Text = "Add Item"
            AddForm.Label1.Text = "Item Name"
            AddForm.txtAddAddress.Visible = False
            AddForm.Label2.Visible = False
            AddForm.Show()
            Identifier = "m1"
        End If
    End Sub

    Private Sub btnOpt2_Click(sender As Object, e As EventArgs) Handles btnOpt2.Click
        If btnOpt2.Text = "View/Edit Supplier Information" Then
            AddForm.txtAddName.Clear()
            AddForm.txtAddName.Text = lsbPortalDisplay.SelectedItem
            AddForm.txtAddAddress.Text = "Company info from database"
            AddForm.BtnSave.Text = "Update Supplier"
            AddForm.Label2.Visible = True
            AddForm.txtAddAddress.Visible = True
            AddForm.Show()
            Identifier = "s2"
        ElseIf btnOpt2.Text = "View/Edit Existing Inventory Item" Then
            AddForm.txtAddName.Clear()
            AddForm.Label1.Text = "Item Name"
            AddForm.txtAddName.Text = lsbInventoryItems.SelectedItem
            AddForm.BtnSave.Text = "Update Item"
            AddForm.txtAddAddress.Visible = False
            AddForm.Label2.Visible = False
            AddForm.Show()
            Identifier = "i2"
        ElseIf btnOpt2.Text = "View/Edit Menu Item" Then
            AddForm.txtAddName.Clear()
            AddForm.Label1.Text = "Item Name"
            AddForm.txtAddName.Text = lsbPortalDisplay.SelectedItem
            AddForm.BtnSave.Text = "Update Item"
            AddForm.txtAddAddress.Visible = False
            AddForm.Label2.Visible = False
            AddForm.Show()
            Identifier = "m2"
        End If
    End Sub
    Private Sub btnOpt3_Click(sender As Object, e As EventArgs) Handles btnOpt3.Click

        If btnOpt3.Text = "Delete Menu Item" Or btnOpt3.Text = "Delete Supplier" Then
            If lsbPortalDisplay.SelectedIndex <> -1 Then
                ItemDeletionConfirmation.Show()
            End If

        ElseIf btnOpt3.Text = "Place Inventory Order" Then
            PlaceOrderConfirmation.Show()
        Else
        End If

    End Sub

    Private Sub btnAddtoOrder_Click(sender As Object, e As EventArgs) Handles btnAddtoOrder.Click
        lsbInventoryOrder.Items.Add(lsbInventoryItems.SelectedItem)
    End Sub
End Class
