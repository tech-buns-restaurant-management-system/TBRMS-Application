Public Class ManagementDashboard
    Dim intViewTicks As Integer = 0
    Dim intXCoor As Integer = 1281
    Dim blnViews As Boolean = False

    Dim intOptionsTicks As Integer = 0
    Dim intYCoor As Integer = 721
    Dim blnOptions As Boolean = False

    Dim index As Integer = -1
    Public selectedRow As DataGridViewRow

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        ExitManagementConfirmation.Height = 0
        ExitManagementConfirmation.Width = 0
        ExitManagementConfirmation.Show()
        ExitManagementConfirmation.Grow()
    End Sub

    Private Sub ManagemantDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlViews.Location = New Point(1280, -1)
        pnlOptions.Location = New Point(319, 720)
    End Sub

    Private Sub tmrViews_Tick(sender As Object, e As EventArgs) Handles tmrViews.Tick
        ViewsSlider()
    End Sub

    Function ViewsSlider()
        If blnViews = False Then
            If (intViewTicks < 10) Then
                intViewTicks += 1
                intXCoor -= 30
                pnlViews.Location = New Point(intXCoor, -1)
            ElseIf (intViewTicks = 10) Then
                tmrViews.Stop()
                intViewTicks = 0
                pnlViews.Location = New Point(859, -1)
                blnViews = True
                intXCoor = 859
            End If
        ElseIf blnViews = True Then
            If (intViewTicks < 10) Then
                intViewTicks += 1
                intXCoor += 30
                pnlViews.Location = New Point(intXCoor, -1)
            ElseIf (intViewTicks = 10) Then
                tmrViews.Stop()
                intViewTicks = 0
                intXCoor = 1281
                pnlViews.Location = New Point(1281, -1)
                blnViews = False
            End If
        End If
    End Function

    Private Sub picOrderSummary_Click(sender As Object, e As EventArgs) Handles picOrderSummary.Click
        tmrViews.Enabled = True
        tmrViews.Start()

        If blnOptions = True Then
            tmrOptions.Enabled = True
            tmrOptions.Start()
        End If
    End Sub

    Private Sub picCloseArrow_Click(sender As Object, e As EventArgs) Handles picCloseArrow.Click
        tmrViews.Enabled = True
        tmrViews.Start()

        tmrOptions.Enabled = True
        tmrOptions.Start()
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs)
        tmrOptions.Enabled = True
        tmrOptions.Start()
    End Sub

    Private Sub tmrOptions_Tick(sender As Object, e As EventArgs) Handles tmrOptions.Tick
        OptionsSlider()
    End Sub

    Function OptionsSlider()
        If blnOptions = False Then
            If (intOptionsTicks < 20) Then
                intOptionsTicks += 1
                intYCoor -= 4
                pnlOptions.Location = New Point(319, intYCoor)
            ElseIf (intOptionsTicks = 20) Then
                tmrOptions.Stop()
                intOptionsTicks = 0
                pnlOptions.Location = New Point(319, 639)
                blnOptions = True
                intYCoor = 639
            End If
        ElseIf blnOptions = True Then
            If (intOptionsTicks < 20) Then
                intOptionsTicks += 1
                intYCoor += 4
                pnlOptions.Location = New Point(319, intYCoor)
            ElseIf (intOptionsTicks = 20) Then
                tmrOptions.Stop()
                intOptionsTicks = 0
                intYCoor = 721
                pnlOptions.Location = New Point(319, 721)
                blnOptions = False
            End If
        End If
    End Function

    Private Sub btnOrderView_Click(sender As Object, e As EventArgs) Handles btnOrderView.Click
        OrderListCriteria.dtpStart.Value = DateTime.Now()
        OrderListCriteria.dtpEnd.Value = DateTime.Now()

        OrderListCriteria.Width = 0
        OrderListCriteria.Height = 0
        OrderListCriteria.Show()
        OrderListCriteria.Grow()
    End Sub

    Function FetchOrders(StartDate As String, EndDate As String)
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT CO.CusOrder_ID, CO.OrderDate, CONVERT(varchar(10), CO.OrderDate, 101) as Date, CO.OrderTime, CONCAT('$', CO.OrderTotal) as OrderTotal
                                   FROM CustomerOrder as CO
                                   WHERE CO.OrderDate >= '" + StartDate + "' AND CO.OrderDate <= '" + EndDate + "';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("colOrderID", "Order ID")
        DataGridView1.Columns.Add("colDate", "Date")
        DataGridView1.Columns.Add("colTime", "Time")
        DataGridView1.Columns.Add("colTotal", "Total Price")

        While SQLReader.Read()
            DataGridView1.Rows.Add({SQLReader.Item("CusOrder_ID"), SQLReader.Item("Date"), SQLReader.Item("OrderTime"), SQLReader.Item("OrderTotal")})
        End While

        connection.Close()

        DataGridView1.ClearSelection()
    End Function

    Private Sub btnOpt1_Click(sender As Object, e As EventArgs) Handles btnOpt1.Click
        Select Case btnOpt1.Text
            Case "Add Item"
                DataGridView1.ClearSelection()
                InventoryItem.txtItemName.Clear()
                InventoryItem.txtModCode.Clear()
                InventoryItem.txtOrderQty.Clear()
                InventoryItem.txtSS.Clear()

                InventoryItem.Height = 0
                InventoryItem.Width = 0
                InventoryItem.Show()
                InventoryItem.Grow()

            Case "Add Supplier"
                DataGridView1.ClearSelection()
                SupplierInfo.txtName.Clear()
                SupplierInfo.txtAddress.Clear()
                SupplierInfo.txtCity.Clear()
                SupplierInfo.txtState.Clear()
                SupplierInfo.txtZip.Clear()
                SupplierInfo.txtPhone.Clear()

                SupplierInfo.Height = 0
                SupplierInfo.Width = 0
                SupplierInfo.Show()
                SupplierInfo.Grow()
        End Select
    End Sub

    Private Sub btnOpt2_Click(sender As Object, e As EventArgs) Handles btnOpt2.Click
        Select Case btnOpt2.Text
            Case "Order Details"
                If index = -1 Then
                    MessageBox.Show("Error: No order selected.")
                Else
                    Dim strSelectedOrder As String = selectedRow.Cells(0).Value.ToString
                    OrderDetails.FetchOrderDetails(strSelectedOrder)
                    OrderDetails.Width = 0
                    OrderDetails.Height = 0
                    OrderDetails.Show()
                    OrderDetails.Grow()
                End If

            Case "Order Inventory"

        End Select
    End Sub

    Private Sub btnOpt3_Click(sender As Object, e As EventArgs) Handles btnOpt3.Click
        Select Case btnOpt3.Text
            Case "Edit Item"
                If index = -1 Then
                    MessageBox.Show("Error: No order selected.")
                Else
                    FetchInventoryDetails()

                    InventoryItem.btnAddItem.Text = "Save Changes"
                    InventoryItem.Height = 0
                    InventoryItem.Width = 0
                    InventoryItem.Show()
                    InventoryItem.Grow()
                End If

            Case "Edit Supplier"
                If index = -1 Then
                    MessageBox.Show("Error: No order selected.")
                Else
                    EditSupplier()

                    SupplierInfo.btnAddItem.Text = "Save Changes"
                    SupplierInfo.Height = 0
                    SupplierInfo.Width = 0
                    SupplierInfo.Show()
                    SupplierInfo.Grow()
                End If
        End Select
    End Sub

    Function FetchInventoryDetails()
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT Inv.InvName, Inv.InvQty, Inv.InvSS, Inv.InvDefaultOrder, Inv.InvModCode
                                   FROM Inventory as Inv
                                   WHERE Inv.Inv_ID = '" + selectedRow.Cells(0).Value.ToString + "';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        While SQLReader.Read()
            Dim strName() As String = {SQLReader.Item("InvName")}

            If Not IsNothing({SQLReader.Item("InvQty")}.ToString) Then
                Dim strQty() As String = {SQLReader.Item("InvQty").ToString}
            End If

            Dim strSS() As String = {SQLReader.Item("InvSS")}
            Dim strDO() As String = {SQLReader.Item("InvDefaultOrder")}
            Dim strMC() As String = {SQLReader.Item("InvModCode")}

            InventoryItem.txtItemName.Text = strName(0)
            InventoryItem.txtSS.Text = strSS(0)
            InventoryItem.txtOrderQty.Text = strDO(0)
            InventoryItem.txtModCode.Text = strMC(0)
        End While

        connection.Close()
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        index = e.RowIndex
        If e.RowIndex >= 0 Then
            selectedRow = DataGridView1.Rows(index)
        End If
    End Sub

    Private Sub btnInventoryView_Click(sender As Object, e As EventArgs) Handles btnInventoryView.Click
        FetchInventoryList()

        tmrViews.Enabled = True
        tmrViews.Start()

        pnlOptions.Visible = True

        btnOpt1.Text = "Add Item"
        btnOpt1.Visible = True
        btnOpt2.Text = "Order Inventory"
        btnOpt2.Visible = True
        btnOpt3.Text = "Edit Item"
        btnOpt3.Visible = True

        tmrOptions.Enabled = True
        tmrOptions.Start()
    End Sub

    Function FetchInventoryList()
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT Inv.Inv_ID, Inv.InvName, Inv.InvQty, Inv.InvSS
                                   FROM Inventory as Inv;"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("colOrderID", "Inventory ID")
        DataGridView1.Columns.Add("colDate", "Item Name")
        DataGridView1.Columns.Add("colTime", "Quantity")
        DataGridView1.Columns.Add("colTotal", "Safety Stock")

        While SQLReader.Read()
            DataGridView1.Rows.Add({SQLReader.Item("Inv_ID"), SQLReader.Item("InvName"), SQLReader.Item("InvQty"), SQLReader.Item("InvSS")})

        End While

        connection.Close()
        connection.Open()

        Dim selectQueryV2 As SqlClient.SqlCommand = connection.CreateCommand()

        selectQueryV2.CommandText = "SELECT Inv.InvName, Inv.InvQty, Inv.InvSS
                                   FROM Inventory as Inv
                                   WHERE Inv.InvQty < Inv.InvSS;"

        Dim SQLReaderV2 As SqlClient.SqlDataReader = selectQueryV2.ExecuteReader()

        Dim strItemsToOrder As String = ""

        While SQLReaderV2.Read()
            Dim strTemp() As String = {SQLReaderV2.Item("InvName").ToString}
            strItemsToOrder += strTemp(0) + vbCrLf
        End While

        If (Not IsNothing(strItemsToOrder)) Then
            MessageBox.Show("Items That Need To Be Reordered:" + vbCrLf + vbCrLf + strItemsToOrder)
        Else
            MessageBox.Show("Shit's good yo")
        End If

        connection.Close()

        DataGridView1.ClearSelection()
    End Function

    Private Sub btnSupplierView_Click(sender As Object, e As EventArgs) Handles btnSupplierView.Click
        FetchSuppliers()

        tmrViews.Enabled = True
        tmrViews.Start()

        pnlOptions.Visible = True

        btnOpt1.Text = "Add Supplier"
        btnOpt1.Visible = True
        btnOpt2.Visible = False
        btnOpt3.Text = "Edit Supplier"
        btnOpt3.Visible = True

        tmrOptions.Enabled = True
        tmrOptions.Start()
    End Sub

    Function FetchSuppliers()
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT TRIM(Sup.SupName) as Name, TRIM(Sup.SupAddress) as Address, TRIM(Sup.SupCity) as City, Sup.SupState as State, Sup.SupZip as Zip, Sup.SupPhoneNumber as Phone
                                   FROM Supplier as Sup;"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView1.Columns.Add("colName", "Name")
        DataGridView1.Columns.Add("colAddress", "Address")
        DataGridView1.Columns.Add("colCity", "City")
        DataGridView1.Columns.Add("colState", "State")
        DataGridView1.Columns.Add("colZip", "Zip")
        DataGridView1.Columns.Add("colPhone", "Phone")

        While SQLReader.Read()
            DataGridView1.Rows.Add({SQLReader.Item("Name"), SQLReader.Item("Address"), SQLReader.Item("City"), SQLReader.Item("State"), SQLReader.Item("Zip"), SQLReader.Item("Phone")})
        End While

        connection.Close()

        DataGridView1.ClearSelection()
    End Function

    Function EditSupplier()
        SupplierInfo.txtName.Text = selectedRow.Cells(0).Value.ToString
        SupplierInfo.txtAddress.Text = selectedRow.Cells(1).Value.ToString
        SupplierInfo.txtCity.Text = selectedRow.Cells(2).Value.ToString
        SupplierInfo.txtState.Text = selectedRow.Cells(3).Value.ToString
        SupplierInfo.txtZip.Text = selectedRow.Cells(4).Value.ToString
        SupplierInfo.txtPhone.Text = selectedRow.Cells(5).Value.ToString
    End Function
End Class