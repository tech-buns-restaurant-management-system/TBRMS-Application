Public Class AddOrderItem
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        CreateInventoryOrder.dgvOrderDetails.Rows.Add(cboItems.SelectedItem, txtQuantity.Text)
        CreateInventoryOrder.dgvOrderDetails.ClearSelection()
        Shrink()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
    End Sub

    Private Sub cboItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItems.SelectedIndexChanged
        'Queries the default order quantity for the Inventory table
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT Inv.InvDefaultOrder
                                   FROM Inventory as Inv
                                   WHERE Inv.InvName = '" & cboItems.SelectedItem & "';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        While SQLReader.Read()
            Dim strTemp() As String = {SQLReader.Item("InvDefaultOrder")}
            txtQuantity.Text = strTemp(0)
        End While

        connection.Close()
    End Sub

    Function PopulateControls()
        'Queries InvName and InvQty from Inventory table and populates controls
        cboItems.Items.Clear()

        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT TRIM(Inv.InvName) as InvName, Inv.InvQty
                                   FROM Inventory as Inv
                                   WHERE Inv.InvQty IS NOT NULL;"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        While SQLReader.Read()
            Dim strTemp() As String = {SQLReader.Item("InvName")}
            cboItems.Items.Add(strTemp(0))
        End While

        connection.Close()
    End Function

    Function Grow()
        For i As Integer = 1 To 20

            Me.Height = i * 12
            Me.Width = i * 22
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

        cboItems.Text = ""
        txtQuantity.Text = ""

        For i As Integer = 20 To 1 Step -1

            Me.Height = i * 12
            Me.Width = i * 22

            Me.CenterToParent()
            Threading.Thread.Sleep(5)
        Next

        Me.Hide()
    End Function
End Class