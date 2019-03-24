Public Class MenuItemCustomization
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerOrderDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CustomerOrderDashboard.blnEditItem = False Then
            CustomerOrderDashboard.lstOrderSummary.Items.Add(lblItem.Text)
        Else
            'Concatenate customizations onto existing Order Line item
        End If
        CustomerOrderDashboard.Show()

        Me.Hide()
    End Sub

    Function ResetIngredients()
        pnlIng1.Visible = False
        pnlIng2.Visible = False
        pnlIng3.Visible = False
        pnlIng4.Visible = False
    End Function
End Class