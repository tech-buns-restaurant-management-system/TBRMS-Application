Public Class FoHSDashboard
    Public strSelectedOrder As String = ""
    Public strSelectedItem As String = ""
    Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        'If lstOrderDetails.SelectedIndex = -1 Then
        '    MessageBox.Show("Error: No order item is selected")
        'Else
        '    FoHMenuItemCustomization.lblItem.Text = lstOrderDetails.SelectedItem
        '    FoHMenuItemCustomization.SetIngredients()
        '    FoHMenuItemCustomization.Show()
        '    Me.Hide()
        'End If
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If (strSelectedItem = "") Then
            MessageBox.Show("Error: No item selected.")
        Else
            FoHMenuItemDeletionConfirmation.Show()
        End If
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        FoHCashPaymentScreen.dblDue = 16.95
        FoHCashPaymentScreen.txtDue.Text = "$" + CStr(FoHCashPaymentScreen.dblDue)
        FoHCashPaymentScreen.Show()
    End Sub

    Private Sub btnRunOrder_Click(sender As Object, e As EventArgs) Handles btnRunOrder.Click
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WelcomeScreen.Show()
        Me.Hide()
    End Sub

    Private Sub FoHSDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchOrderList()
    End Sub

    Private Sub dgvOrderDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderDetails.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        If e.RowIndex <> -1 Then
            selectedRow = dgvOrderDetails.Rows(index)
            strSelectedItem = selectedRow.Cells(0).Value.ToString
        End If
    End Sub

    Private Sub dgvOrderList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderList.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        If e.RowIndex <> -1 Then
            selectedRow = dgvOrderList.Rows(index)
            strSelectedOrder = selectedRow.Cells(0).Value.ToString
            FetchOrderDetails()
        End If
    End Sub

    Private Sub dgvOrderList_GotFocus(sender As Object, e As EventArgs) Handles dgvOrderList.GotFocus
        dgvOrderDetails.ClearSelection()
        strSelectedItem = ""
    End Sub

    'SQL Query Functions

    Function FetchOrderList()
        'Queries CustomerOrder table and refreshes dgvOrderList with updated list of open orders
        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT CO.CusOrder_ID as OrderID, CO.OrderTableNum as TableNum, CO.OrderPaid as Paid, SUM(MI.MenuItemPrice) as Price
                                   FROM CustomerOrder as CO, CustomerOrderLine as COL, MenuItem as MI
                                   WHERE CO.CusOrder_ID = COL.CusOrder_ID
                                   AND COL.MenuItem_ID = MI.MenuItem_ID
                                   GROUP BY CO.CusOrder_ID, CO.OrderTableNum, CO.OrderPaid;"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        dgvOrderList.Columns.Clear()
        dgvOrderList.Rows.Clear()

        dgvOrderList.Columns.Add("colID", "Order")
        dgvOrderList.Columns.Add("colTableNum", "Table")
        dgvOrderList.Columns.Add("colPaid", "Paid?")
        dgvOrderList.Columns.Add("colPrice", "Price")

        dgvOrderList.Columns("colID").Width = 90
        dgvOrderList.Columns("colTableNum").Width = 90
        dgvOrderList.Columns("colPaid").Width = 90
        dgvOrderList.Columns("colPrice").Width = 110

        While SQLReader.Read()
            dgvOrderList.Rows.Add({SQLReader.Item("OrderID"), SQLReader.Item("TableNum"), SQLReader.Item("Paid"), "$" + SQLReader.Item("Price").ToString})
        End While

        connection.Close()

        For i = 0 To dgvOrderList.Rows.Count - 1
            dgvOrderList.Rows(i).Height = 50
        Next

        dgvOrderList.ClearSelection()
    End Function

    Function FetchOrderDetails()
        'Queries CustomerOrder table and refreshes dgvOrderList with updated list of open orders
        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT MenuItem.MenuItemName, CustomerOrderLine.Customizations 
                                   FROM CustomerOrder, CustomerOrderLine, MenuItem 
                                   WHERE CustomerOrder.CusOrder_ID = CustomerOrderLine.CusOrder_ID 
                                   AND CustomerOrderLine.MenuItem_ID = MenuItem.MenuItem_ID
                                   AND CustomerOrderLine.CusOrder_ID = '" + strSelectedOrder + "';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        dgvOrderDetails.Columns.Clear()
        dgvOrderDetails.Rows.Clear()

        dgvOrderDetails.Columns.Add("colItem", "Item Name")
        dgvOrderDetails.Columns.Add("colMods", "Mods")

        dgvOrderDetails.Columns("colItem").Width = 150
        dgvOrderDetails.Columns("colMods").Width = 229

        While SQLReader.Read()
            dgvOrderDetails.Rows.Add({SQLReader.Item("MenuItemName"), SQLReader.Item("Customizations")})
        End While

        connection.Close()

        For i = 0 To dgvOrderDetails.Rows.Count - 1
            dgvOrderDetails.Rows(i).Height = 50
        Next

        dgvOrderDetails.ClearSelection()
    End Function

    Function ExecuteQuery(query As String)
        Dim command As New SqlClient.SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Function
End Class