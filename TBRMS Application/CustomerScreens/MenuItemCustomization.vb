Public Class MenuItemCustomization
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerOrderDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CustomerOrderDashboard.blnEditItem = False Then
            CustomerOrderDashboard.lstOrderSummary.Items.Add(lblItem.Text)
        Else
            AddCustomizations()
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

    Function AddCustomizations()

        If rdIng1None.Checked = True Then
            Select Case lblIng1.Text
                Case "Red Ale-Caramelized Onions"
            End Select
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " N-" + lblIng1.Text.Remove(3, lblIng1.Text.Length - 3)
        ElseIf rdIng1Light.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " L-" + lblIng1.Text.Remove(3, lblIng1.Text.Length - 3)
        ElseIf rdIng1Extra.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " E-" + lblIng1.Text.Remove(3, lblIng1.Text.Length - 3)
        End If

        If rdIng2None.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " N-" + lblIng2.Text.Remove(3, lblIng2.Text.Length - 3)
        ElseIf rdIng2Light.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " L-" + lblIng2.Text.Remove(3, lblIng2.Text.Length - 3)
        ElseIf rdIng2Extra.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " E-" + lblIng2.Text.Remove(3, lblIng2.Text.Length - 3)
        End If

        If rdIng3None.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " N-" + lblIng3.Text.Remove(3, lblIng3.Text.Length - 3)
        ElseIf rdIng3Light.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " L-" + lblIng3.Text.Remove(3, lblIng3.Text.Length - 3)
        ElseIf rdIng3Extra.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " E-" + lblIng3.Text.Remove(3, lblIng3.Text.Length - 3)
        End If

        If rdIng4None.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " N-" + lblIng4.Text.Remove(3, lblIng4.Text.Length - 3)
        ElseIf rdIng4Light.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " L-" + lblIng4.Text.Remove(3, lblIng4.Text.Length - 3)
        ElseIf rdIng4Extra.Checked = True Then
            CustomerOrderDashboard.lstOrderSummary.Items(CustomerOrderDashboard.lstOrderSummary.SelectedIndex) += " E-" + lblIng4.Text.Remove(3, lblIng4.Text.Length - 3)
        End If
    End Function
End Class