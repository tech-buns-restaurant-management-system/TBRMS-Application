Public Class MenuItemCustomization

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerOrderDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'If CustomerOrderDashboard.blnEditItem = False Then

        AddNewCustomizations()
        'Else
        '    AddEditCustomizations()
        '    CustomerOrderDashboard.blnEditItem = False
        'End If

        CustomerOrderDashboard.Show()
        Me.Hide()
    End Sub

    Function ResetIngredients()
        pnlIng1.Visible = False
        pnlIng2.Visible = False
        pnlIng3.Visible = False
        pnlIng4.Visible = False
    End Function

    Function AddNewCustomizations()
        Dim strCustomization(3) As String
        Dim strOrderLineItem, strItem As String
        Dim intIndex As Integer

        If CustomerOrderDashboard.blnEditItem = True Then
            strItem = CustomerOrderDashboard.strOrderLine(CustomerOrderDashboard.lstOrderSummary.SelectedIndex + (1 * CustomerOrderDashboard.lstOrderSummary.SelectedIndex))
        Else
            strItem = lblItem.Text
        End If

        Select Case strItem
            Case "Drunk Monk Burger"
                strOrderLineItem = "Drunk Monk Burger"
                If rdIng1None.Checked = True Then
                    strCustomization(0) = " N-" + lblIng1.Text.Remove(0, lblIng1.Text.Length - 6).Remove(2, 4)
                ElseIf rdIng1Light.Checked = True Then
                    strCustomization(0) = " L-" + lblIng1.Text.Remove(0, lblIng1.Text.Length - 6).Remove(2, 4)
                ElseIf rdIng1Reg.Checked = True Then
                    strCustomization(0) = ""
                ElseIf rdIng1Extra.Checked = True Then
                    strCustomization(0) = " E-" + lblIng1.Text.Remove(0, lblIng1.Text.Length - 6).Remove(2, 4)
                End If

                If rdIng2None.Checked = True Then
                    strCustomization(1) = " N-" + lblIng2.Text.Remove(2, lblIng2.Text.Length - 2)
                ElseIf rdIng2Light.Checked = True Then
                    strCustomization(1) = " L-" + lblIng2.Text.Remove(2, lblIng2.Text.Length - 2)
                ElseIf rdIng2Reg.Checked = True Then
                    strCustomization(1) = ""
                ElseIf rdIng2Extra.Checked = True Then
                    strCustomization(1) = " E-" + lblIng2.Text.Remove(2, lblIng2.Text.Length - 2)
                End If

                If rdIng3None.Checked = True Then
                    strCustomization(2) = " N-" + lblIng3.Text.Remove(0, lblIng3.Text.Length - 5).Remove(2, 3)
                ElseIf rdIng3Light.Checked = True Then
                    strCustomization(2) = " L-" + lblIng3.Text.Remove(0, lblIng3.Text.Length - 5).Remove(2, 3)
                ElseIf rdIng3Reg.Checked = True Then
                    strCustomization(2) = ""
                ElseIf rdIng3Extra.Checked = True Then
                    strCustomization(2) = " E-" + lblIng3.Text.Remove(0, lblIng3.Text.Length - 5).Remove(2, 3)
                End If

                If rdIng4None.Checked = True Then
                    strCustomization(3) = " N-" + lblIng4.Text.Remove(0, lblIng4.Text.Length - 6).Remove(2, 4)
                ElseIf rdIng4Light.Checked = True Then
                    strCustomization(3) = " L-" + lblIng4.Text.Remove(0, lblIng4.Text.Length - 6).Remove(2, 4)
                ElseIf rdIng4Reg.Checked = True Then
                    strCustomization(3) = ""
                ElseIf rdIng4Extra.Checked = True Then
                    strCustomization(3) = " E-" + lblIng4.Text.Remove(0, lblIng4.Text.Length - 6).Remove(2, 4)
                End If
        End Select

        If CustomerOrderDashboard.lstOrderSummary.SelectedIndex > -1 Then
            intIndex = CustomerOrderDashboard.lstOrderSummary.SelectedIndex
        End If

        If CustomerOrderDashboard.blnEditItem = False Then
            If CustomerOrderDashboard.strOrderLine.Length < 2 Then
                Dim intNewLength As Integer = CustomerOrderDashboard.strOrderLine.Length
                ReDim CustomerOrderDashboard.strOrderLine(intNewLength)
            Else
                Dim intNewLength As Integer = CustomerOrderDashboard.strOrderLine.Length + 1
                ReDim Preserve CustomerOrderDashboard.strOrderLine(intNewLength)
            End If


            CustomerOrderDashboard.strOrderLine(CustomerOrderDashboard.strOrderLine.Length - 2) = strOrderLineItem

            CustomerOrderDashboard.strOrderLine(CustomerOrderDashboard.strOrderLine.Length - 1) = ""
            For i As Integer = 0 To 3
                CustomerOrderDashboard.strOrderLine(CustomerOrderDashboard.strOrderLine.Length - 1) += strCustomization(i)
            Next

        ElseIf CustomerOrderDashboard.blnEditItem = True Then
            CustomerOrderDashboard.strOrderLine(intIndex + (1 * intIndex)) = strOrderLineItem
            CustomerOrderDashboard.strOrderLine(intIndex + (1 * intIndex) + 1) = ""
            For i As Integer = 0 To 3
                CustomerOrderDashboard.strOrderLine(intIndex + (1 * intIndex) + 1) += strCustomization(i)
            Next
            CustomerOrderDashboard.blnEditItem = False
        End If

        CustomerOrderDashboard.lstOrderSummary.Items.Clear()

        For i As Integer = 0 To CustomerOrderDashboard.strOrderLine.Length - 2 Step 2
            CustomerOrderDashboard.lstOrderSummary.Items.Add(CustomerOrderDashboard.strOrderLine(i) + CustomerOrderDashboard.strOrderLine(i + 1))
        Next
    End Function

    Function ResetRadioButtons()
        rdIng1Reg.Checked = True
        rdIng2Reg.Checked = True
        rdIng3Reg.Checked = True
        rdIng4Reg.Checked = True
    End Function
End Class