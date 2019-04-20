Public Class CreateInventoryOrder
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        AddOrderItem.Height = 0
        AddOrderItem.Width = 0
        AddOrderItem.Show()
        AddOrderItem.PopulateControls()
        AddOrderItem.Grow()
    End Sub

    Function NewOrder()
        dgvOrderDetails.Columns.Clear()
        dgvOrderDetails.Rows.Clear()

        dgvOrderDetails.Columns.Add("colName", "Item Name")
        dgvOrderDetails.Columns.Add("colQuantity", "Quantity")
    End Function

    Function Grow()
        For i As Integer = 1 To 20

            Me.Height = i * 28
            Me.Width = i * 22
            Me.CenterToParent()

            Threading.Thread.Sleep(5)

            If i = 20 Then
                Threading.Thread.Sleep(50)
            End If
        Next

        For Each ctrl In Me.Controls
            ctrl.Visible = True
        Next

        lblMessage.Focus()
    End Function

    Function Shrink()

        For Each ctrl In Me.Controls
            ctrl.Visible = False
        Next

        For i As Integer = 20 To 1 Step -1

            Me.Height = i * 28
            Me.Width = i * 22

            Me.CenterToParent()
            Threading.Thread.Sleep(5)
        Next

        Me.Hide()
    End Function

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        SelectSupplier.Height = 0
        SelectSupplier.Width = 0
        SelectSupplier.FetchSuppliers()
        SelectSupplier.Show()
        SelectSupplier.Grow()
    End Sub
End Class