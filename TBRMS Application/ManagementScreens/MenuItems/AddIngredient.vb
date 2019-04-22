Public Class AddIngredient
    Dim strCustom As String = "True"
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If AddIng() = False Then
            MessageBox.Show("Maximum number of customizable ingredients selected.")
        Else
            MenuItemDetails.dgvIngs.Rows.Add(cboItems.SelectedItem, strCustom)
            Shrink()
        End If
    End Sub

    Function AddIng()
        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()

        selectQuery.CommandText = "SELECT Inv.InvName, Inv.InvModCode
                                   FROM Inventory as Inv
                                   WHERE Inv.InvName = '" & cboItems.SelectedItem & "';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        While SQLReader.Read()
            Dim strTemp() As String = {SQLReader.Item("InvModCode")}
            If strTemp(0) = "--" Then
                strCustom = "False"
            Else
                strCustom = "True"
            End If
        End While

        connection.Close()

        Dim CustomIngNum As Integer

        For i As Integer = 0 To MenuItemDetails.dgvIngs.Rows.Count - 1
            If MenuItemDetails.dgvIngs.Rows(i).Cells(1).Value.ToString = True Then
                CustomIngNum += 1
            End If
        Next

        If strCustom = "True" And CustomIngNum = 4 Then
            Return False
        Else
            Return True
        End If
    End Function

    Function PopulateControls()
        cboItems.Items.Clear()

        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()

        If MenuItemDetails.dgvIngs.Rows.Count - 1 <> -1 Then
            Dim strCriteria As String = "WHERE "
            For i As Integer = 0 To MenuItemDetails.dgvIngs.Rows.Count - 1
                If i <> MenuItemDetails.dgvIngs.Rows.Count - 1 Then
                    strCriteria += "InvName != '" & MenuItemDetails.dgvIngs.Rows(i).Cells(0).Value.ToString & "' AND "
                Else
                    strCriteria += "InvName != '" & MenuItemDetails.dgvIngs.Rows(i).Cells(0).Value.ToString & "'"
                End If
            Next

            selectQuery.CommandText = "SELECT TRIM(Inv.InvName) as InvName
                                   FROM Inventory as Inv " & strCriteria & ";"
        Else

            selectQuery.CommandText = "SELECT TRIM(Inv.InvName) as InvName
                                   FROM Inventory as Inv;"

        End If

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        While SQLReader.Read()
            Dim strTemp() As String = {SQLReader.Item("InvName")}
            cboItems.Items.Add(strTemp(0))
        End While

        connection.Close()
    End Function

    Function Grow()
        For i As Integer = 1 To 20

            Me.Height = i * 10
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

        For i As Integer = 20 To 1 Step -1

            Me.Height = i * 10
            Me.Width = i * 22

            Me.CenterToParent()
            Threading.Thread.Sleep(5)
        Next

        Me.Hide()
    End Function
End Class