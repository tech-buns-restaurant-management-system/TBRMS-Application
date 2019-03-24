Public Class FoHMenuItemDeletionConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        FoHSDashboard.lstOrderDetails.Items.RemoveAt(FoHSDashboard.lstOrderDetails.SelectedIndex)
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class