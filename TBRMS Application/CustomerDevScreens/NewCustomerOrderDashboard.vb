Public Class NewCustomerOrderDashboard
    Dim dblOrderPrice(0), dblSubtotal, dblOrderTax As Double
    Public intItemNum As Integer
    Dim intTicks As Integer = 0
    Dim intXCoor As Integer = 1281
    Dim intYCoor As Integer = 720
    Dim blnSliderOpen As Boolean = False
    Dim blnOrderSummarySlider As Boolean = False
    Dim strMeme As String = ""
    Public intSelectedIndex As Integer = -1
    Public strItems(), strMods(), strIngredients As String
    Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
    'Form Load Function
    Private Sub DBTestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlOrderSummary.Location = New Point(intXCoor, -1)
        pnlKeyboard.Location = New Point(-2, intYCoor)

        dgvCategories.ClearSelection()
    End Sub

    'MainOrderForm Functions
    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        CancelOrderConfirmation.Width = 0
        CancelOrderConfirmation.Height = 0
        CancelOrderConfirmation.Show()
        CancelOrderConfirmation.Grow()
    End Sub

    Private Sub picOrderSummary_Click(sender As Object, e As EventArgs) Handles picOrderSummary.Click
        If (blnSliderOpen = True) Then
            tmrKeyboard.Start()
        End If

        tmrOrderSummarySlider.Enabled = True
        tmrOrderSummarySlider.Start()
    End Sub

    'Category & Menu Item DataGridView Functions
    Private Sub dgvCategories_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategories.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow = dgvCategories.Rows(index)
        Dim strCategory As String = selectedRow.Cells(0).Value

        FetchItemList(strCategory)
        intSelectedIndex = -1
        dgvOrderSummary.ClearSelection()
    End Sub

    Private Sub dgvMenuItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenuItems.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow = dgvMenuItems.Rows(index)
        CustomizeItem.lblItemName.Text = selectedRow.Cells(0).Value

        dgvOrderSummary.ClearSelection()
        intSelectedIndex = -1

        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        'Gets Inv_IDs of the ignredients used in the Item selected
        Dim strSelect As String = "SELECT Ing.Inv_ID, Inv.InvModCode FROM Ingredient as Ing, Inventory as Inv, MenuItem as MI " +
                                  "WHERE MI.MenuItem_ID = Ing.MenuItem_ID And Ing.Inv_ID = Inv.Inv_ID And MI.MenuItemName = '" + CustomizeItem.lblItemName.Text + "';"

        Dim dtbInvIDs As New DataTable

        Using connection
            connection.Open()
            Using dad As New SqlClient.SqlDataAdapter(strSelect, connection)
                dad.Fill(dtbInvIDs)
            End Using
            connection.Close()
        End Using

        CustomizeItem.GetItemNames(dtbInvIDs, CustomizeItem.strItemNames)

        CustomizeItem.pnlIng1.Visible = False
        CustomizeItem.pnlIng2.Visible = False
        CustomizeItem.pnlIng3.Visible = False
        CustomizeItem.pnlIng4.Visible = False

        MessageBox.Show(CustomizeItem.intIngCount)

        Select Case CustomizeItem.intIngCount
            Case 1
                CustomizeItem.intIngAmount(0) = 2

                CustomizeItem.lblIng1Amount.Text = "Regular"

                CustomizeItem.pnlIng1.Visible = True
            Case 2
                CustomizeItem.intIngAmount(0) = 2
                CustomizeItem.intIngAmount(1) = 2

                CustomizeItem.lblIng1Amount.Text = "Regular"
                CustomizeItem.lblIng2Amount.Text = "Regular"

                CustomizeItem.pnlIng1.Visible = True
                CustomizeItem.pnlIng2.Visible = True
            Case 3
                CustomizeItem.intIngAmount(0) = 2
                CustomizeItem.intIngAmount(1) = 2
                CustomizeItem.intIngAmount(2) = 2

                CustomizeItem.lblIng1Amount.Text = "Regular"
                CustomizeItem.lblIng2Amount.Text = "Regular"
                CustomizeItem.lblIng3Amount.Text = "Regular"

                CustomizeItem.pnlIng1.Visible = True
                CustomizeItem.pnlIng2.Visible = True
                CustomizeItem.pnlIng3.Visible = True
            Case 4
                CustomizeItem.intIngAmount(0) = 2
                CustomizeItem.intIngAmount(1) = 2
                CustomizeItem.intIngAmount(2) = 2
                CustomizeItem.intIngAmount(3) = 2

                CustomizeItem.lblIng1Amount.Text = "Regular"
                CustomizeItem.lblIng2Amount.Text = "Regular"
                CustomizeItem.lblIng3Amount.Text = "Regular"
                CustomizeItem.lblIng4Amount.Text = "Regular"

                CustomizeItem.pnlIng1.Visible = True
                CustomizeItem.pnlIng2.Visible = True
                CustomizeItem.pnlIng3.Visible = True
                CustomizeItem.pnlIng4.Visible = True
        End Select

        CustomizeItem.Height = 0
        CustomizeItem.Width = 0
        CustomizeItem.Show()
        CustomizeItem.Grow()
    End Sub

    Function AddItem()
        Dim strItem As String = CustomizeItem.lblItemName.Text

        intItemNum += 1
        lblNumItems.Text = intItemNum

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT MI.MenuItemPrice
                                   FROM MenuItem as MI
                                   WHERE MI.MenuItemName = '" + strItem + "';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        Dim dblItemPrice() As Double

        While SQLReader.Read()
            dblItemPrice = {SQLReader.Item("MenuItemPrice")}
        End While

        connection.Close()

        If (dblOrderPrice.Length > 0) And (dblOrderPrice(0) <> Nothing) Then
            ReDim Preserve dblOrderPrice(dblOrderPrice.Length)
        End If

        dblOrderPrice(dblOrderPrice.Length - 1) = dblItemPrice(0)
        dblSubtotal = 0

        For i As Integer = 0 To dblOrderPrice.Length - 1
            dblSubtotal += dblOrderPrice(i)
        Next

        lblSubtotal.Text = FormatCurrency(dblSubtotal)
        dblOrderTax = dblSubtotal * 0.06
        lblTax.Text = FormatCurrency(dblOrderTax)

        If (blnOrderSummarySlider = False) Then
            tmrOrderSummarySlider.Start()
        End If

        dgvMenuItems.ClearSelection()
        dgvOrderSummary.ClearSelection()
        intSelectedIndex = -1
    End Function

    Function FetchCategories()
        'Fetches Menu Categories and displays them in dgvCategories
        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT MI.MenuItemCategory
                                   FROM MenuItem as MI
                                   GROUP BY MI.MenuItemCategory;"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        dgvCategories.Columns.Clear()
        dgvCategories.Rows.Clear()

        dgvCategories.Columns.Add("colCategory", "Category")

        dgvCategories.Columns("colCategory").Width = 395

        While SQLReader.Read()
            dgvCategories.Rows.Add({SQLReader.Item("MenuItemCategory")})
        End While

        connection.Close()

        dgvCategories.ClearSelection()
    End Function

    Function FetchItemList(Category As String)
        'Queries CustomerOrder table and refreshes dgvOrderList with updated list of open orders
        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT TRIM(MI.MenuItemName) as MenuItemName
                                   From MenuItem as MI
                                   WHERE MI.MenuItemCategory = '" + Category + "';"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        dgvMenuItems.Columns.Clear()
        dgvMenuItems.Rows.Clear()

        dgvMenuItems.Columns.Add("colItem", "Menu Item")

        dgvMenuItems.Columns("colItem").Width = 396

        While SQLReader.Read()
            dgvMenuItems.Rows.Add({SQLReader.Item("MenuItemName")})
        End While

        connection.Close()

        dgvMenuItems.ClearSelection()
    End Function

    'OrderSummary Slider functions
    Private Sub dgvOrderSummary_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrderSummary.CellClick
        intSelectedIndex = e.RowIndex
    End Sub

    Function DeleteItem()
        If (intSelectedIndex < 0) Then
            MessageBox.Show("Error: No item is selected.")
        Else

            dgvOrderSummary.Rows.RemoveAt(intSelectedIndex)
            ReDim dblOrderPrice(0)

            For i As Integer = 0 To dgvOrderSummary.Rows.Count - 1
                connection.Open()

                Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
                selectQuery.CommandText = "SELECT MI.MenuItemPrice
                               FROM MenuItem as MI
                               WHERE MI.MenuItemName = '" + dgvOrderSummary.Rows(i).Cells(0).Value + "';"

                Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

                Dim dblItemPrice() As Double

                While SQLReader.Read()
                    dblItemPrice = {SQLReader.Item("MenuItemPrice")}
                End While

                connection.Close()

                If (dblOrderPrice.Length > 0) And (dblOrderPrice(0) <> Nothing) Then
                    ReDim Preserve dblOrderPrice(dblOrderPrice.Length)
                End If

                dblOrderPrice(i) = dblItemPrice(0)

            Next

            dblSubtotal = 0

            For i As Integer = 0 To dblOrderPrice.Length - 1
                dblSubtotal += dblOrderPrice(i)
            Next

            lblSubtotal.Text = FormatCurrency(dblSubtotal)
            dblOrderTax = dblSubtotal * 0.06
            lblTax.Text = FormatCurrency(dblOrderTax)

            intItemNum -= 1

            lblNumItems.Text = CStr(intItemNum)
            lblSubtotal.Text = FormatCurrency(dblSubtotal)
            dblOrderTax = dblSubtotal * 0.06
            lblTax.Text = FormatCurrency(dblOrderTax)

            dgvOrderSummary.ClearSelection()
            intSelectedIndex = -1
        End If
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (intSelectedIndex = -1) Then
            MessageBox.Show("Error: No item selected.")
        Else
            DeleteItemConfirmation.Height = 0
            DeleteItemConfirmation.Width = 0
            DeleteItemConfirmation.Show()
            DeleteItemConfirmation.Grow()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (intSelectedIndex = -1) Then
            MessageBox.Show("Error: No item selected.")
            Exit Sub
        End If

        Dim selectedRow As DataGridViewRow = dgvOrderSummary.Rows(intSelectedIndex)
        CustomizeItem.lblItemName.Text = selectedRow.Cells(0).Value

            Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

            'Gets Inv_IDs of the ignredients used in the Item selected
            Dim strSelect As String = "SELECT Ing.Inv_ID, Inv.InvModCode FROM Ingredient as Ing, Inventory as Inv, MenuItem as MI " +
                               "WHERE MI.MenuItem_ID = Ing.MenuItem_ID And Ing.Inv_ID = Inv.Inv_ID And MI.MenuItemName = '" + selectedRow.Cells(0).Value + "';"

            Dim dtbInvIDs As New DataTable

            Using connection
                connection.Open()
                Using dad As New SqlClient.SqlDataAdapter(strSelect, connection)
                    dad.Fill(dtbInvIDs)
                End Using
                connection.Close()
            End Using

            CustomizeItem.GetItemNames(dtbInvIDs, CustomizeItem.strItemNames)

            For i As Integer = 0 To 3
                CustomizeItem.intIngAmount(i) = 2
                CustomizeItem.lblIng1Amount.Text = "Regular"
                CustomizeItem.lblIng2Amount.Text = "Regular"
                CustomizeItem.lblIng3Amount.Text = "Regular"
                CustomizeItem.lblIng4Amount.Text = "Regular"
            Next

            CustomizeItem.Height = 0
            CustomizeItem.Width = 0
            CustomizeItem.Show()
            CustomizeItem.Grow()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If (dgvOrderSummary.Rows.Count = 0) Then
            MessageBox.Show("Error: There are no items on the order.")
            Exit Sub
        End If

        For i As Integer = 0 To dgvOrderSummary.Rows.Count - 1
            ReDim Preserve strItems(i)
            ReDim Preserve strMods(i)

            strItems(i) = dgvOrderSummary.Rows(i).Cells(0).Value
            strMods(i) = dgvOrderSummary.Rows(i).Cells(1).Value
        Next

        dgvOrderSummary.Rows.Clear()
        dgvCategories.Rows.Clear()
        dgvMenuItems.Rows.Clear()

        dblSubtotal = 0
        dblOrderTax = 0
        intItemNum = 0

        lblNumItems.Text = CStr(intItemNum)
        lblSubtotal.Text = FormatCurrency(dblSubtotal)
        lblTax.Text = FormatCurrency(dblOrderTax)

        tmrOrderSummarySlider.Enabled = True
        tmrOrderSummarySlider.Start()

        TableTagEntry.Show()
        Me.Hide()
    End Sub

    Private Sub picCloseArrow_Click(sender As Object, e As EventArgs) Handles picCloseArrow.Click
        tmrOrderSummarySlider.Enabled = True
        tmrOrderSummarySlider.Start()
    End Sub

    Private Sub tmrOrderSummarySlider_Tick(sender As Object, e As EventArgs) Handles tmrOrderSummarySlider.Tick
        OrderSummarySlider()
    End Sub

    Function OrderSummarySlider()
        If blnOrderSummarySlider = False Then
            If (intTicks < 10) Then
                intTicks += 1
                intXCoor -= 30
                pnlOrderSummary.Location = New Point(intXCoor, -1)
            ElseIf (intTicks = 10) Then
                tmrOrderSummarySlider.Stop()
                intTicks = 0
                pnlOrderSummary.Location = New Point(859, -1)
                blnOrderSummarySlider = True
                intXCoor = 859
            End If
        ElseIf blnOrderSummarySlider = True Then
            If (intTicks < 10) Then
                intTicks += 1
                intXCoor += 30
                pnlOrderSummary.Location = New Point(intXCoor, -1)
            ElseIf (intTicks = 10) Then
                tmrOrderSummarySlider.Stop()
                intTicks = 0
                intXCoor = 1281
                pnlOrderSummary.Location = New Point(1281, -1)
                blnOrderSummarySlider = False
                dgvOrderSummary.ClearSelection()
                intSelectedIndex = -1
            End If
        End If
    End Function

    'Keyboard Functionality
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        txtSearch.Text += "A"
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        txtSearch.Text += "B"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtSearch.Text += "C"
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        txtSearch.Text += "D"
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        txtSearch.Text += "E"
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        txtSearch.Text += "F"
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        txtSearch.Text += "G"
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        txtSearch.Text += "H"
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        txtSearch.Text += "I"
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        txtSearch.Text += "J"
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        txtSearch.Text += "K"
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        txtSearch.Text += "L"
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        txtSearch.Text += "M"
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        txtSearch.Text += "N"
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        txtSearch.Text += "O"
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        txtSearch.Text += "P"
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        txtSearch.Text += "Q"
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        txtSearch.Text += "R"
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        txtSearch.Text += "S"
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        txtSearch.Text += "T"
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        txtSearch.Text += "U"
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        txtSearch.Text += "V"
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        txtSearch.Text += "W"
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        txtSearch.Text += "X"
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        txtSearch.Text += "Y"
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        txtSearch.Text += "Z"
    End Sub

    Private Sub btnSpace_Click(sender As Object, e As EventArgs) Handles btnSpace.Click
        txtSearch.Text += " "
    End Sub

    Private Sub btnDeleteSearch_Click(sender As Object, e As EventArgs) Handles btnDeleteSearch.Click
        If txtSearch.Text.Length <> 0 Then
            txtSearch.Text = txtSearch.Text.Remove(txtSearch.Text.Length - 1)
        End If

    End Sub

    Private Sub btnHide_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHide.MouseDown
        picHide.BackColor = Color.FromArgb(207, 211, 216)
    End Sub

    Private Sub btnHide_MouseUp(sender As Object, e As MouseEventArgs) Handles btnHide.MouseUp
        picHide.BackColor = Color.FromArgb(227, 227, 227)

        tmrKeyboard.Enabled = True
        tmrKeyboard.Start()

        txtSearch.Text = "Search..."
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        tmrKeyboard.Enabled = True
        tmrKeyboard.Start()

        If strMeme = "Mascot" Then
            Meme()
        ElseIf strMeme = "Shrek" Then
            Meme()
        Else
            connection.Open()

            Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
            selectQuery.CommandText = "SELECT MI.MenuItemName
                                   FROM MenuItem as MI
                                   WHERE MI.MenuItemName LIKE '%" + txtSearch.Text + "%';"

            Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

            dgvMenuItems.Columns.Clear()
            dgvMenuItems.Rows.Clear()

            dgvMenuItems.Columns.Add("colItem", "Menu Item")

            dgvMenuItems.Columns("colItem").Width = 396

            While SQLReader.Read()
                dgvMenuItems.Rows.Add({SQLReader.Item("MenuItemName")})
            End While

            connection.Close()
        End If

        txtSearch.Text = "Search..."

        dgvCategories.ClearSelection()
        dgvMenuItems.ClearSelection()
        dgvOrderSummary.ClearSelection()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "HAPPY BUNS" Then
            picMeme.ImageLocation = "Mascot1.png"
            strMeme = "Mascot"
        ElseIf txtSearch.Text = "MAX OGRE DRIVE" Then
            picMeme.ImageLocation = "shrek.png"
            strMeme = "Shrek"
        End If
    End Sub

    Private Sub txtSearch_MouseDown(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseDown
        If blnSliderOpen = False Then
            Me.txtSearch.BackColor = Color.FromArgb(207, 211, 216)
            Me.picSearch.BackColor = Color.FromArgb(207, 211, 216)
            Me.pnlSearch.BackColor = Color.FromArgb(207, 211, 216)
        End If
    End Sub

    Private Sub txtSearch_MouseUp(sender As Object, e As MouseEventArgs) Handles txtSearch.MouseUp
        If blnSliderOpen = False Then
            Me.txtSearch.BackColor = Color.FromArgb(227, 227, 227)
            Me.picSearch.BackColor = Color.FromArgb(227, 227, 227)
            Me.pnlSearch.BackColor = Color.FromArgb(227, 227, 227)

            tmrKeyboard.Enabled = True
            tmrKeyboard.Start()

            txtSearch.Clear()
        End If
    End Sub

    Private Sub tmrKeyboard_Tick(sender As Object, e As EventArgs) Handles tmrKeyboard.Tick
        KeyboardSlider()
    End Sub

    Function KeyboardSlider()
        If blnSliderOpen = False Then
            If (intTicks < 15) Then
                intTicks += 1
                intYCoor -= 20
                pnlKeyboard.Location = New Point(-2, intYCoor)
            ElseIf (intTicks = 15) Then
                tmrKeyboard.Stop()
                intTicks = 0
                pnlKeyboard.Location = New Point(-2, 420)
                blnSliderOpen = True
            End If
        ElseIf blnSliderOpen = True Then
            If (intTicks < 15) Then
                intTicks += 1
                intYCoor += 20
                pnlKeyboard.Location = New Point(-2, intYCoor)
            ElseIf (intTicks = 15) Then
                tmrKeyboard.Stop()
                intTicks = 0
                pnlKeyboard.Location = New Point(-2, 720)
                blnSliderOpen = False
                txtSearch.Text = "Search..."
            End If
        End If
    End Function

    'These functions are essential. DO NOT REMOVE
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Meme()
    End Sub

    Function Meme()
        picMeme.Location = New Point(415, 169)
        Timer1.Enabled = True
        Timer1.Start()
        picMeme.Visible = True
        If (intTicks = 1) Then

            If strMeme = "Mascot" Then
                My.Computer.Audio.Play("wow.wav", AudioPlayMode.WaitToComplete)
            ElseIf strMeme = "Shrek" Then
                My.Computer.Audio.Play("allstar.wav", AudioPlayMode.WaitToComplete)
            End If
            intTicks += 1
        ElseIf (intTicks < 3) Then
            intTicks += 1
        ElseIf (intTicks = 3) Then
            Timer1.Stop()
            picMeme.Visible = False
            intTicks = 0
        End If
    End Function
End Class