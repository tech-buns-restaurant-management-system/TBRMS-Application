Public Class Form1
    Dim strItems() As String = {"Bare Essentials Burger", "Roasted Vegetables", "Top Beverages Spring Water"}
    Dim dtbMods As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()



        DataGridView1.Columns.Add("colMenuItem", "MenuItem_ID")
        DataGridView1.Columns.Add("colIng", "Inv_ID")

        For i As Integer = 0 To strItems.Count - 1
            Dim Connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

            'Gets Inv_IDs of the ingredients used in the Item selected

            Connection.Open()

            Dim selectQuery As SqlClient.SqlCommand = Connection.CreateCommand()
            selectQuery.CommandText = "SELECT Ing.MenuItem_ID, Ing.Inv_ID FROM Ingredient as Ing, Inventory as Inv WHERE Ing.Inv_ID = Inv.Inv_ID AND Ing.MenuItem_ID = (SELECT MenuItem_ID FROM MenuItem WHERE MenuItemName = '" +
                                      strItems(i) + "');"

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

            'Gets Inv_IDs of the ingredients used in the Item selected

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

            If DataGridView2.Rows(counter).Cells(0).Value.ToString = "27" Or DataGridView2.Rows(counter).Cells(0).Value.ToString = "28" Then
                DataGridView2.Rows.RemoveAt(counter)
            ElseIf DataGridView2.Rows(counter).Cells(1).Value.ToString = "--" Then
                Dim updateString As String = "UPDATE Inventory SET InvQty = InvQty - 1 WHERE Inv_ID = '" + DataGridView2.Rows(counter).Cells(0).Value.ToString + "';"
                ExecuteQuery(updateString)
                'MessageBox.Show(updateString)

                DataGridView2.Rows.RemoveAt(counter)
            Else
                counter += 1
            End If
        Next

        counter = 0

        For Each row As DataRow In dtbMods.Rows

            Dim updateString As String

            For i As Integer = 0 To 3
                Dim col As String

                Select Case i
                    Case 0
                        col = "Ing1"
                    Case 1
                        col = "Ing2"
                    Case 2
                        col = "Ing3"
                    Case 3
                        col = "Ing4"
                End Select

                Select Case row(col)
                    Case ""
                        updateString = ""
                    Case "None"
                        updateString = ""
                    Case "Light"
                        updateString = "UPDATE Inventory SET InvQty = InvQty - .5 WHERE Inv_ID = '" + DataGridView2.Rows(counter).Cells(0).Value.ToString + "';"
                        'MessageBox.Show(updateString)
                        ExecuteQuery(updateString)
                    Case "Regular"
                        updateString = "UPDATE Inventory SET InvQty = InvQty - 1 WHERE Inv_ID = '" + DataGridView2.Rows(counter).Cells(0).Value.ToString + "';"
                        'MessageBox.Show(updateString)
                        ExecuteQuery(updateString)
                    Case "Extra"
                        updateString = "UPDATE Inventory SET InvQty = InvQty - 1.5 WHERE Inv_ID = '" + DataGridView2.Rows(counter).Cells(0).Value.ToString + "';"
                        'MessageBox.Show(updateString)
                        ExecuteQuery(updateString)
                End Select
                counter += 1
            Next
        Next

        MessageBox.Show("*Gordon Ramsay Voice* Done")
    End Sub

    Function ExecuteQuery(query As String)
        Dim Connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        Dim command As New SqlClient.SqlCommand(query, connection)
        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dtbMods.Rows.Clear()
        dtbMods.Columns.Clear()

        dtbMods.Columns.Add("Ing1", GetType(String))
        dtbMods.Columns.Add("Ing2", GetType(String))
        dtbMods.Columns.Add("Ing3", GetType(String))
        dtbMods.Columns.Add("Ing4", GetType(String))

        dtbMods.Rows.Add("Extra", "Regular", "None", "Light")
        dtbMods.Rows.Add("Regular", "Light", "Extra", "Light")
        dtbMods.Rows.Add("None", "", "", "")

        DataGridView3.Columns.Clear()
        DataGridView3.Columns.Add("colIng1", "Ing1")
        DataGridView3.Columns.Add("colIng2", "Ing2")
        DataGridView3.Columns.Add("colIng3", "Ing3")
        DataGridView3.Columns.Add("colIng4", "Ing4")

        For Each Row In dtbMods.Rows
            DataGridView3.Rows.Add(Row("Ing1"), Row("Ing2"), Row("Ing3"), Row("Ing4"))
        Next

        DataGridView4.Columns.Clear()
        DataGridView4.Rows.Clear()
    End Sub
End Class