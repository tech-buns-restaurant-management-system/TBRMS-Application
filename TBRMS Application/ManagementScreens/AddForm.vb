Public Class AddForm
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If ManagemantDashboard.btnOpt1.Text = "Add New Supplier" Then
            ManagemantDashboard.lsbPortalDisplay.Items.Add(txtAddName.Text)
            MessageBox.Show("Supplier added successfully.")
            Me.Hide()
        ElseIf ManagemantDashboard.btnOpt1.Text = "Add New Menu Item" Then
        ElseIf ManagemantDashboard.btnOpt1.Text = "Add New Inventory Item" Then
            ManagemantDashboard.lsbInventoryItems.Items.Add(txtAddName.Text)
            MessageBox.Show("Item added successfully.")
            Me.Hide()
        End If


    End Sub
End Class