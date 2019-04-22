Public Class FoHDashboard
    Public strSelectedOrder As String
    Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT CO.OrderTotal
                                   FROM CustomerOrder as CO
                                   WHERE CO.CusOrder_ID = '" + strSelectedOrder + "';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        Dim strPrice() As String

        While SQLReader.Read()
            strPrice = ({SQLReader.Item("OrderTotal").ToString})
        End While

        connection.Close()

        FoHCashPaymentScreen.dblDue = strPrice(0)
        FoHCashPaymentScreen.txtDue.Text = FormatCurrency(FoHCashPaymentScreen.dblDue)
        FoHCashPaymentScreen.Show()
    End Sub

    Private Sub btnRunOrder_Click(sender As Object, e As EventArgs) Handles btnRunOrder.Click
        'Updates CustomerOrder table to show that order has been completed
        Dim updateQuery As String = "UPDATE CustomerOrder SET OrderComplete = 'TRUE' WHERE CusOrder_ID = '" + strSelectedOrder + "';"

        ExecuteQuery(updateQuery)

        FetchOrderList()
    End Sub

    Private Sub dgvOrderDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderDetails.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        If e.RowIndex <> -1 Then
            selectedRow = dgvOrderDetails.Rows(index)
        End If
    End Sub

    Private Sub dgvOrderList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderList.CellClick
        'Sets the selectedRow and Fetches the details for that order
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        If e.RowIndex >= 0 Then
            selectedRow = dgvOrderList.Rows(index)
            strSelectedOrder = selectedRow.Cells(0).Value.ToString
            FetchOrderDetails()

            If (selectedRow.Cells(2).Value.ToString = "False") Then
                btnCash.Enabled = True
                btnRunOrder.Enabled = False
            Else
                btnCash.Enabled = False
                btnRunOrder.Enabled = True
            End If
        End If
    End Sub

    Private Sub dgvOrderList_GotFocus(sender As Object, e As EventArgs) Handles dgvOrderList.GotFocus
        dgvOrderDetails.ClearSelection()
    End Sub

    'SQL Query Functions
    Function FetchOrderList()
        'Queries CustomerOrder table and refreshes dgvOrderList with updated list of open orders
        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT CO.CusOrder_ID as OrderID, CO.OrderTableNum as TableNum, CO.OrderPaid as Paid, CO.OrderTotal as Price
                                   FROM CustomerOrder as CO
                                   WHERE CO.OrderComplete = 'FALSE';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        dgvOrderList.Columns.Clear()
        dgvOrderList.Rows.Clear()

        dgvOrderDetails.Columns.Clear()
        dgvOrderDetails.Rows.Clear()

        dgvOrderList.Columns.Add("colID", "Order")
        dgvOrderList.Columns.Add("colTableNum", "Table")
        dgvOrderList.Columns.Add("colPaid", "Paid?")
        dgvOrderList.Columns.Add("colPrice", "Price")

        dgvOrderList.Columns("colID").Width = 95
        dgvOrderList.Columns("colTableNum").Width = 95
        dgvOrderList.Columns("colPaid").Width = 100
        dgvOrderList.Columns("colPrice").Width = 110

        While SQLReader.Read()
            dgvOrderList.Rows.Add({SQLReader.Item("OrderID"), SQLReader.Item("TableNum"), SQLReader.Item("Paid"), "$" + SQLReader.Item("Price").ToString})
        End While

        connection.Close()

        For i = 0 To dgvOrderList.Rows.Count - 1
            dgvOrderList.Rows(i).Height = 50
        Next

        For Each col As DataGridViewColumn In dgvOrderList.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        dgvOrderList.ClearSelection()
    End Function

    Function FetchOrderDetails()
        'Queries CustomerOrderLine table and populates dgvOrderDetails with the MenuItems and their Modifications
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

        dgvOrderDetails.Columns("colItem").Width = 170
        dgvOrderDetails.Columns("colMods").Width = 229

        While SQLReader.Read()
            dgvOrderDetails.Rows.Add({SQLReader.Item("MenuItemName"), SQLReader.Item("Customizations")})
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

    Function ExecuteQuery(query As String)
        Dim command As New SqlClient.SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Function

    Private Sub FoHSDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchOrderList()
        dgvOrderList.ClearSelection()
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        FoHExitConfirmation.Width = 0
        FoHExitConfirmation.Height = 0
        FoHExitConfirmation.Show()
        FoHExitConfirmation.Grow()
    End Sub
End Class