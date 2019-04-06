Public Class FoHMenuItemDeletionConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim deleteQuery As String = "DELETE FROM CustomerOrderLine 
                                     WHERE CusOrder_ID = '" + FoHSDashboard.strSelectedOrder + "'
                                     AND MenuItem_ID = (SELECT MenuItem_ID FROM MenuItem WHERE MenuItemName = '" + FoHSDashboard.strSelectedItem + "');"

        FoHSDashboard.ExecuteQuery(deleteQuery)

        MessageBox.Show("Item has been deleted.")

        FoHSDashboard.FetchOrderDetails()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class