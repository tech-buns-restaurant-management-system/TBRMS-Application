Public Class ThankYouScreen
    Dim intSecond As Integer
    Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intSecond += 1
        If intSecond = 5 Then
            Timer1.Stop()
            intSecond = 0
            Checkout()
            DeductInventory()

            CusSplashScreen.Show()
            Me.Hide()
        End If
    End Sub

    Function Checkout()
        Dim strDate As String = DateString
        Dim strTime As String = TimeString

        'Inserts record for the order into CustomerOrder table
        Dim insertOrderQuery As String = "INSERT INTO CustomerOrder VALUES ('" + DateString + "', '" + TimeString + "', '" + TableTagEntry.strTableTag + "', '" +
                                         CStr(PaymentSelection.blnPaid) + "', 'False', " + CStr(CustomerOrderDashboard.dblOrderTotal) + ");"

        ExecuteQuery(insertOrderQuery)

        'Inserts each Order Line Item into CustomerOrderLine table
        For i As Integer = 0 To CustomerOrderDashboard.strItems.Length - 1
            Dim OrderLineQuery As String = "INSERT INTO CustomerOrderLine VALUES ((SELECT CusOrder_ID FROM CustomerOrder WHERE OrderDate = '" &
                                            strDate & "' AND OrderTime = '" & strTime & "' AND OrderTableNum = '" & TableTagEntry.strTableTag & "'), (SELECT MenuItem_ID FROM MenuItem WHERE MenuItemName = '" +
                                            CustomerOrderDashboard.strItems(i) + "'), '" & (i + 1) & "', ' "

            'If there are no mods for the current item, NULL is inserted
            If (CustomerOrderDashboard.strMods(i) = "") Then
                OrderLineQuery += "NULL');"
            Else
                OrderLineQuery += CustomerOrderDashboard.strMods(i) + "');"
            End If

            ExecuteQuery(OrderLineQuery)
        Next


    End Function

    Function DeductInventory()
        'Hidden DataGridViews were used because the programming was a lot easier to do versus using Datatables at the time. 
        'If it's stupid but it works, it ain't supid, right?

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        DataGridView3.Columns.Clear()
        DataGridView3.Columns.Add("colIng1", "Ing1")
        DataGridView3.Columns.Add("colIng2", "Ing2")
        DataGridView3.Columns.Add("colIng3", "Ing3")
        DataGridView3.Columns.Add("colIng4", "Ing4")

        'Add each mod for each item to DataGridView3
        For Each Row In CusSplashScreen.dtbOrderMods.Rows
            DataGridView3.Rows.Add(Row("colIng1"), Row("colIng2"), Row("colIng3"), Row("colIng4"))
        Next

        DataGridView4.Columns.Clear()
        DataGridView4.Rows.Clear()

        DataGridView4.Columns.Add("colItem", "Item")

        'Add each item to DataGridView4
        For i As Integer = 0 To CustomerOrderDashboard.strItems.Length - 1
            DataGridView4.Rows.Add(CustomerOrderDashboard.strItems(i))
        Next

        DataGridView1.Columns.Add("colMenuItem", "MenuItem_ID")
        DataGridView1.Columns.Add("colIng", "Inv_ID")

        'Fetch the MenuItem_ID and the Inv_ID for each Ingredient for each item
        For i As Integer = 0 To CustomerOrderDashboard.strItems.Length - 1
            Dim Connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

            'Gets Inv_IDs of the ingredients used in the Item selected

            Connection.Open()

            Dim selectQuery As SqlClient.SqlCommand = Connection.CreateCommand()
            selectQuery.CommandText = "SELECT Ing.MenuItem_ID, Ing.Inv_ID FROM Ingredient as Ing, Inventory as Inv WHERE Ing.Inv_ID = Inv.Inv_ID AND Ing.MenuItem_ID = (SELECT MenuItem_ID FROM MenuItem WHERE MenuItemName = '" +
                                      CustomerOrderDashboard.strItems(i) + "');"

            Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

            While SQLReader.Read()
                DataGridView1.Rows.Add({SQLReader.Item("MenuItem_ID"), SQLReader.Item("Inv_ID")})
            End While

            Connection.Close()
        Next

        DataGridView2.Columns.Clear()
        DataGridView2.Rows.Clear()

        DataGridView2.Columns.Add("colInv_ID", "Inv_ID")
        DataGridView2.Columns.Add("colModCode", "ModCode")

        Dim counter As Integer = 0

        For Each row As DataGridViewRow In DataGridView1.Rows

            Dim Connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

            'Gets the ModCode for each ingredient and inserts into DataGridView2

            Connection.Open()

            Dim selectQuery As SqlClient.SqlCommand = Connection.CreateCommand()
            selectQuery.CommandText = "SELECT Inv.InvModCode FROM Inventory as Inv WHERE Inv.Inv_ID = '" + row.Cells(1).Value.ToString + "';"

            Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

            While SQLReader.Read()
                Dim strMod() As String

                strMod = {SQLReader.Item("InvModCode")}

                DataGridView2.Rows.Add(row.Cells(1).Value.ToString, strMod(0))
            End While

            Connection.Close()

            'If item does not have a mod code, the regular amount is deducted from the quantity
            If DataGridView2.Rows(counter).Cells(1).Value.ToString = "--" And DataGridView2.Rows(counter).Cells(0).Value.ToString <> "28" Then
                Dim updateString As String = "UPDATE Inventory SET InvQty = InvQty - 1 WHERE Inv_ID = '" + DataGridView2.Rows(counter).Cells(0).Value.ToString + "';"
                ExecuteQuery(updateString)

                DataGridView2.Rows.RemoveAt(counter)
            Else
                counter += 1
            End If
        Next

        Dim dgvCounter As Integer = DataGridView2.Rows.Count
        counter = 0

        'Each ingredient for each item is updated based on the amount selected by the customer
        For Each row As DataRow In CusSplashScreen.dtbOrderMods.Rows

            Dim updateString As String

            For i As Integer = 0 To 3
                Dim col As String

                Select Case i
                    Case 0
                        col = "colIng1"
                    Case 1
                        col = "colIng2"
                    Case 2
                        col = "colIng3"
                    Case 3
                        col = "colIng4"
                End Select

                'If the item is not Ice or Spring Water, the quantity is updated based on what has been chosen
                If dgvCounter > 0 Then
                    If (DataGridView2.Rows(counter).Cells(0).Value.ToString <> "27" And DataGridView2.Rows(counter).Cells(0).Value.ToString <> "28") Then
                        Select Case row(col)
                            Case ""
                                updateString = ""
                            Case "None"
                                updateString = ""
                            Case "Light"
                                updateString = "UPDATE Inventory SET InvQty = InvQty - .5 WHERE Inv_ID = '" + DataGridView2.Rows(counter).Cells(0).Value.ToString + "';"
                                ExecuteQuery(updateString)
                            Case "Regular"
                                updateString = "UPDATE Inventory SET InvQty = InvQty - 1 WHERE Inv_ID = '" + DataGridView2.Rows(counter).Cells(0).Value.ToString + "';"
                                ExecuteQuery(updateString)
                            Case "Extra"
                                updateString = "UPDATE Inventory SET InvQty = InvQty - 1.5 WHERE Inv_ID = '" + DataGridView2.Rows(counter).Cells(0).Value.ToString + "';"
                                ExecuteQuery(updateString)
                        End Select
                        counter += 1
                        dgvCounter -= 1
                    End If
                End If
            Next
        Next
    End Function

    Function ExecuteQuery(query As String)
        Dim command As New SqlClient.SqlCommand(query, connection)
        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()
    End Function
End Class