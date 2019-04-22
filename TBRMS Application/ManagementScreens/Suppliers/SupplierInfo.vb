Public Class SupplierInfo
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If txtName.Text = "" Then
            MessageBox.Show("Error: All fields must have a value.")
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            MessageBox.Show("Error: All fields must have a value.")
            Exit Sub
        ElseIf txtCity.Text = "" Then
            MessageBox.Show("Error: All fields must have a value.")
            Exit Sub
        ElseIf txtState.Text = "" Then
            MessageBox.Show("Error: All fields must have a value.")
            Exit Sub
        ElseIf txtZip.Text = "" Then
            MessageBox.Show("Error: All fields must have a value.")
            Exit Sub
        ElseIf txtPhone.Text = "" Then
            MessageBox.Show("Error: All fields must have a value.")
            Exit Sub
        End If

        'Inserts the Supplier into the Supplier table
        If btnAddItem.Text = "Add Supplier" Then
            Dim insertQuery As String = "INSERT INTO Supplier VALUES ('" & txtName.Text + "', '" & txtAddress.Text &
                                        "', '" & txtCity.Text & "', '" & txtState.Text & "', '" & txtZip.Text & "', '" & txtPhone.Text & "');"
            ExecuteQuery(insertQuery)


        Else
            'Updates the existing Supplier wit the new information in the Supplier table
            Dim updateQuery As String = "UPDATE Supplier SET SupName = '" & txtName.Text + "', SupAddress = '" & txtAddress.Text & "', SupCity = '" & txtCity.Text &
                                        "', SupState = '" & txtState.Text & "', SupZip = '" & txtZip.Text & "', SupPhoneNumber = '" & txtPhone.Text & "'
                                        WHERE Sup_ID = (SELECT Sup_ID FROM Supplier WHERE SupName = '" & ManagementDashboard.selectedRow.Cells(0).Value.ToString & "');"
            ExecuteQuery(updateQuery)
        End If

        ManagementDashboard.FetchSuppliers()
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

            Me.Height = i * 15
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

            Me.Height = i * 15
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