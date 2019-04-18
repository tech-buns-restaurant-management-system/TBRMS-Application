Public Class AddInventoryItem
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If txtItemName.Text = "" Or IsNumeric(txtModCode.Text) Then
            MessageBox.Show("Stop")
            Exit Sub
        ElseIf txtOrderQty.Text = "" Or Not IsNumeric(txtOrderQty.Text) Then
            MessageBox.Show("Stop")
            Exit Sub
        ElseIf txtSS.Text = "" Or Not IsNumeric(txtSS.Text) Then
            MessageBox.Show("Stop")
            Exit Sub
        ElseIf txtModCode.Text = "" Or IsNumeric(txtModCode.Text) Then
            MessageBox.Show("Stop")
            Exit Sub
        End If

        If btnAddItem.Text = "Add Item" Then
            Dim insertQuery As String = "INSERT INTO Inventory VALUES ('" & txtItemName.Text + "', NULL, CONVERT(DECIMAL(6,2), " & txtSS.Text & "), CONVERT(DECIMAL(6,2), " &
                                    txtOrderQty.Text & "), '" & txtModCode.Text & "');"

            ExecuteQuery(insertQuery)

            MessageBox.Show("Item inserted successfully")
        Else
            Dim updateQuery As String = "UPDATE Inventory SET InvName = '" & txtItemName.Text + "'AND InvSS = CONVERT(DECIMAL(6,2), " & txtSS.Text &
                                        ") AND InvDefaultOrder = CONVERT(DECIMAL(6,2), " & txtOrderQty.Text & ") AND InvModCode = '" & txtModCode.Text & "' WHERE Inv_ID = '" & ManagementDashboard.selectedRow.Cells(0).Value.ToString & "';"
        End If
        Shrink()
    End Sub

    Function ExecuteQuery(query As String)
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        Dim command As New SqlClient.SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Function

    Function Grow()
        For i As Integer = 1 To 20

            Me.Height = i * 12
            Me.Width = i * 26
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

            Me.Height = i * 12
            Me.Width = i * 26

            Me.CenterToParent()
            Threading.Thread.Sleep(5)
        Next

        Me.Hide()
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
    End Sub
End Class