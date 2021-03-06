﻿Public Class OrderDetails
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

        For Each ctrl In Me.Controls
            ctrl.visible = True
        Next

        lblHeading.Focus()
    End Function

    Function Shrink()

        For Each ctrl In Me.Controls
            ctrl.visible = False
        Next

        For i As Integer = 20 To 1 Step -1

            Me.Height = i * 25
            Me.Width = i * 20

            Me.CenterToParent()
            Threading.Thread.Sleep(5)
        Next

        Me.Hide()
    End Function

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Shrink()
    End Sub

    Function FetchOrderDetails(strSelectedOrder As String)
        'Fetches the MenuItems and Customizations for the selected order and populates dgvOrderDetails
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")


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

        dgvOrderDetails.Columns("colItem").Width = 159
        dgvOrderDetails.Columns("colMods").Width = 199

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
End Class