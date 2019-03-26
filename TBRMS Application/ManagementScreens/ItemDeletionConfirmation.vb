Public Class ItemDeletionConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Me.Hide()
        ManagemantDashboard.lsbPortalDisplay.Items.RemoveAt(ManagemantDashboard.lsbPortalDisplay.SelectedIndex)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class