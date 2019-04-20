Public Class PlaceOrderConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        PlaceOrder()
        Shrink()
        CreateInventoryOrder.Shrink()
        ManagementDashboard.FetchInventoryOrderList()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
    End Sub

    Function PlaceOrder()
        Dim strDate As String = DateString
        Dim strTime As String = TimeString

        Dim insertQuery As String = "INSERT INTO InventoryOrder VALUES ('" & DateString & "', '" & TimeString &
                                    "', (SELECT Sup.Sup_ID FROM Supplier as Sup WHERE Sup.SupName = '" & SelectSupplier.strSupplier & "'), 'False');"

        ExecuteQuery(insertQuery)

        For i As Integer = 0 To CreateInventoryOrder.dgvOrderDetails.Rows.Count - 1
            Dim strItem, strQuantity As String

            strItem = CreateInventoryOrder.dgvOrderDetails.Rows(i).Cells(0).Value.ToString
            strQuantity = CreateInventoryOrder.dgvOrderDetails.Rows(i).Cells(1).Value.ToString

            Dim insertOrderLineQuery As String = "INSERT INTO InventoryOrderLine VALUES ((SELECT IO.InvOrder_ID FROM InventoryOrder as IO WHERE IO.InvOrderDate = '" & strDate &
                                                 "' AND IO.InvOrderTime = '" & strTime & "'), (SELECT Inv.Inv_ID FROM Inventory as Inv WHERE Inv.InvName = '" & strItem & "')," &
                                                 strQuantity & ");"

            ExecuteQuery(insertOrderLineQuery)
        Next
    End Function

    Function ExecuteQuery(query As String)
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        Dim command As New SqlClient.SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Function

    Function Grow()
        For i As Integer = 1 To 20

            Me.Height = i * 8
            Me.Width = i * 17
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

            Me.Height = i * 8
            Me.Width = i * 17

            Me.CenterToParent()
            Threading.Thread.Sleep(5)
        Next

        Me.Hide()
    End Function
End Class