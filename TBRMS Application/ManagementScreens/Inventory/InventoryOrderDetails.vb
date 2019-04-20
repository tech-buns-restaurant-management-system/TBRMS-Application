Public Class InventoryOrderDetails
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Shrink()
    End Sub

    Function FetchOrderDetails(strSelectedOrder As String)
        'Queries CustomerOrder table and refreshes dgvOrderList with updated list of open orders
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")


        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT IO.InvOrder_ID, IOL.InvOrderQty, TRIM(Inv.InvName) as InvName
                                  FROM Inventory as Inv, InventoryOrderLine as IOL, InventoryOrder as IO
                                  WHERE Inv.Inv_ID = IOL.Inv_ID
                                  AND IO.InvOrder_ID = IOL.InvOrder_ID
                                  AND IO.InvOrder_ID = '" & strSelectedOrder & "';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        dgvOrderDetails.Columns.Clear()
        dgvOrderDetails.Rows.Clear()

        dgvOrderDetails.Columns.Add("colItem", "Item Name")
        dgvOrderDetails.Columns.Add("colQty", "Quantity")

        While SQLReader.Read()
            dgvOrderDetails.Rows.Add({SQLReader.Item("InvName"), SQLReader.Item("InvOrderQty")})
        End While

        connection.Close()

        For i = 0 To dgvOrderDetails.Rows.Count - 1
            dgvOrderDetails.Rows(i).Height = 50
        Next

        For Each col As DataGridViewColumn In dgvOrderDetails.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        dgvOrderDetails.ClearSelection()
    End Function

    Function Grow()
        For i As Integer = 1 To 20

            Me.Height = i * 25
            Me.Width = i * 20
            Me.CenterToParent()

            Threading.Thread.Sleep(5)

            If i = 20 Then
                Threading.Thread.Sleep(50)
            End If
        Next

        pnlHeader.Visible = True
        btnContinue.Visible = True
        dgvOrderDetails.Visible = True

        lblHeading.Focus()
    End Function

    Function Shrink()

        pnlHeader.Visible = False
        btnContinue.Visible = False
        dgvOrderDetails.Visible = False

        For i As Integer = 20 To 1 Step -1

            Me.Height = i * 25
            Me.Width = i * 20

            Me.CenterToParent()
            Threading.Thread.Sleep(5)
        Next

        Me.Hide()
    End Function
End Class