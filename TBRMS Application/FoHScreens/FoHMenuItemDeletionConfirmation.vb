Public Class FoHMenuItemDeletionConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        For i As Integer = FoHSDashboard.lstOrderDetails.SelectedIndex To FoHSDashboard.lstOrderDetails.Items.Count - 2
            Select Case FoHSDashboard.intSelectedOrder
                Case 1
                    FoHSDashboard.strOrder1(i) = FoHSDashboard.strOrder1(i + 1)
                Case 2
                    FoHSDashboard.strOrder2(i) = FoHSDashboard.strOrder2(i + 1)
                Case 3
                    FoHSDashboard.strOrder3(i) = FoHSDashboard.strOrder3(i + 1)
                Case 4
                    FoHSDashboard.strOrder4(i) = FoHSDashboard.strOrder4(i + 1)
            End Select
        Next

        Select Case FoHSDashboard.intSelectedOrder
            Case 1
                ReDim Preserve FoHSDashboard.strOrder1(FoHSDashboard.lstOrderDetails.Items.Count - 2)
            Case 2
                ReDim Preserve FoHSDashboard.strOrder2(FoHSDashboard.lstOrderDetails.Items.Count - 2)
            Case 3
                ReDim Preserve FoHSDashboard.strOrder3(FoHSDashboard.lstOrderDetails.Items.Count - 2)
            Case 4
                ReDim Preserve FoHSDashboard.strOrder4(FoHSDashboard.lstOrderDetails.Items.Count - 2)
        End Select

        FoHSDashboard.lstOrderDetails.Items.RemoveAt(FoHSDashboard.lstOrderDetails.SelectedIndex)

        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class