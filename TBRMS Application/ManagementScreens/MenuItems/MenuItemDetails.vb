Public Class MenuItemDetails
    Dim index As Integer
    Private Sub lnkAddIng_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAddIng.LinkClicked
        Dim IngNum As Integer = 0

        'If there are 6 ingredients on the Menu Item, the user cannot add any more
        For i As Integer = 0 To dgvIngs.Rows.Count - 1
            IngNum += 1
        Next

        If IngNum = 6 Then
            MessageBox.Show("Maximum number of ingredients reached.")
        Else
            AddIngredient.PopulateControls()
            AddIngredient.Height = 0
            AddIngredient.Width = 0
            AddIngredient.Show()
            AddIngredient.Grow()
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If txtName.Text = "" Then
            MessageBox.Show("Error: All fields must have a value.")
            Exit Sub
        ElseIf txtPrice.Text = "" Then
            MessageBox.Show("Error: All fields must have a value.")
            Exit Sub
        ElseIf cboCategory.SelectedItem = "" Then
            MessageBox.Show("Error: All fields must have a value.")
            Exit Sub
        End If

        Select Case btnAddItem.Text
            Case "Add Item"
                AddMenuItem()
            Case "Update Item"
                EditMenuItem()
        End Select

        ManagementDashboard.FetchMenuItemList()
        Shrink()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
    End Sub

    Function NewMenuItem()
        dgvIngs.Columns.Add("colIng", "Ingredient Name")
        dgvIngs.Columns.Add("colCustom", "Customizable?")
    End Function

    Function AddMenuItem()
        'Inserts Menu Item info into MenuItem table
        Dim insertMenuItemQuery As String = "INSERT INTO MenuItem VALUES ('" & txtPrice.Text & "', '" & txtName.Text & "', '" & cboCategory.SelectedItem & "'"

        If CheckBox1.Checked = True Then
            insertMenuItemQuery += ", 'True');"
        Else
            insertMenuItemQuery += ", 'False');"
        End If

        ExecuteQuery(insertMenuItemQuery)

        'Inserts each ingredient for the Menu Item into the Ingredients table
        For i As Integer = 0 To dgvIngs.Rows.Count - 1

            Dim insertIngredientQuery As String = "INSERT INTO Ingredient VALUES ((SELECT MI.MenuItem_ID FROM MenuItem as MI WHERE MI.MenuItemName = '" & txtName.Text &
                                                 "'), (SELECT Inv.Inv_ID FROM Inventory as Inv WHERE Inv.InvName = '" & dgvIngs.Rows(i).Cells(0).Value.ToString & "'));"

            ExecuteQuery(insertIngredientQuery)
        Next

        txtName.Clear()
        txtPrice.Clear()
        CheckBox1.Checked = False
        cboCategory.SelectedIndex = -1
    End Function

    Function EditMenuItem()
        'Updates the Menu Item info in the MenuItem table
        Dim updateMenuItemQuery As String = "UPDATE MenuItem SET MenuItemPrice = '" & txtPrice.Text & "', MenuItemName = '" & txtName.Text & "', MenuItemCategory = '" & cboCategory.SelectedItem & "'"

        If CheckBox1.Checked = True Then
            updateMenuItemQuery += ", MenuItemActive = 'True' "
        Else
            updateMenuItemQuery += ", MenuItemActive = 'False' "
        End If

        updateMenuItemQuery += "WHERE MenuItem_ID = (SELECT MenuItem_ID FROM MenuItem WHERE MenuItemName = '" & ManagementDashboard.selectedRow.Cells(0).Value.ToString & "');"

        ExecuteQuery(updateMenuItemQuery)

        'Deletes old Ingredients for the MenuItem in the Ingredients table
        Dim deleteIngredientQuery As String = "DELETE FROM Ingredient WHERE MenuItem_ID = (SELECT MenuItem_ID FROM MenuItem WHERE MenuItemName = '" & ManagementDashboard.selectedRow.Cells(0).Value.ToString & "');"

        ExecuteQuery(deleteIngredientQuery)

        'Adds new Ingredients for the Menu Item in the Ingredients table
        For i As Integer = 0 To dgvIngs.Rows.Count - 1

            Dim insertIngredientQuery As String = "INSERT INTO Ingredient VALUES ((SELECT MI.MenuItem_ID FROM MenuItem as MI WHERE MI.MenuItemName = '" & txtName.Text &
                                                 "'), (SELECT Inv.Inv_ID FROM Inventory as Inv WHERE Inv.InvName = '" & dgvIngs.Rows(i).Cells(0).Value.ToString & "'));"

            ExecuteQuery(insertIngredientQuery)
        Next

        txtName.Clear()
        txtPrice.Clear()
        CheckBox1.Checked = False
        cboCategory.SelectedIndex = -1
        dgvIngs.ClearSelection()
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

            Me.Height = i * 34
            Me.Width = i * 28
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

            Me.Height = i * 34
            Me.Width = i * 28

            Me.CenterToParent()
            Threading.Thread.Sleep(5)
        Next

        dgvIngs.Rows.Clear()
        dgvIngs.Columns.Clear()
        txtName.Clear()
        cboCategory.SelectedIndex = -1
        txtPrice.Clear()

        Me.Hide()
    End Function

    Private Sub dgvIngs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIngs.CellClick
        index = e.RowIndex
    End Sub

    Private Sub lnkDeleteIngredient_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkDeleteIngredient.LinkClicked
        If index = -1 Then
            MessageBox.Show("Error: No item selected.")
        Else
            dgvIngs.Rows.RemoveAt(index)
            dgvIngs.ClearSelection()
            index = -1
        End If
    End Sub
End Class