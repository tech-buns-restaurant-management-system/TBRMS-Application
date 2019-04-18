Public Class CustomizeItem
    Dim strModCodes(3) As String
    Public strItemNames(3) As String
    Public intIngAmount(3), intIngCount As Integer

    Private Sub btnMoreIng1_Click(sender As Object, e As EventArgs) Handles btnMoreIng1.Click
        Select Case intIngAmount(0)
            Case 0
                lblIng1Amount.Text = "Light"
                intIngAmount(0) += 1
            Case 1
                lblIng1Amount.Text = "Regular"
                intIngAmount(0) += 1
            Case 2
                lblIng1Amount.Text = "Extra"
                intIngAmount(0) += 1
        End Select
    End Sub

    Private Sub btnMoreIng2_Click(sender As Object, e As EventArgs) Handles btnMoreIng2.Click
        Select Case intIngAmount(1)
            Case 0
                lblIng2Amount.Text = "Light"
                intIngAmount(1) += 1
            Case 1
                lblIng2Amount.Text = "Regular"
                intIngAmount(1) += 1
            Case 2
                lblIng2Amount.Text = "Extra"
                intIngAmount(1) += 1
        End Select
    End Sub

    Private Sub btnMoreIng3_Click(sender As Object, e As EventArgs) Handles btnMoreIng3.Click
        Select Case intIngAmount(2)
            Case 0
                lblIng3Amount.Text = "Light"
                intIngAmount(2) += 1
            Case 1
                lblIng3Amount.Text = "Regular"
                intIngAmount(2) += 1
            Case 2
                lblIng3Amount.Text = "Extra"
                intIngAmount(2) += 1
        End Select
    End Sub

    Private Sub btnMoreIng4_Click(sender As Object, e As EventArgs) Handles btnMoreIng4.Click
        Select Case intIngAmount(3)
            Case 0
                lblIng4Amount.Text = "Light"
                intIngAmount(3) += 1
            Case 1
                lblIng4Amount.Text = "Regular"
                intIngAmount(3) += 1
            Case 2
                lblIng4Amount.Text = "Extra"
                intIngAmount(3) += 1
        End Select
    End Sub

    Private Sub btnLessIng1_Click(sender As Object, e As EventArgs) Handles btnLessIng1.Click
        Select Case intIngAmount(0)
            Case 1
                lblIng1Amount.Text = "None"
                intIngAmount(0) -= 1
            Case 2
                lblIng1Amount.Text = "Light"
                intIngAmount(0) -= 1
            Case 3
                lblIng1Amount.Text = "Regular"
                intIngAmount(0) -= 1
        End Select
    End Sub

    Private Sub btnLessIng2_Click(sender As Object, e As EventArgs) Handles btnLessIng2.Click
        Select Case intIngAmount(1)
            Case 1
                lblIng2Amount.Text = "None"
                intIngAmount(1) -= 1
            Case 2
                lblIng2Amount.Text = "Light"
                intIngAmount(1) -= 1
            Case 3
                lblIng2Amount.Text = "Regular"
                intIngAmount(1) -= 1
        End Select
    End Sub

    Private Sub btnLessIng3_Click(sender As Object, e As EventArgs) Handles btnLessIng3.Click
        Select Case intIngAmount(2)
            Case 1
                lblIng3Amount.Text = "None"
                intIngAmount(2) -= 1
            Case 2
                lblIng3Amount.Text = "Light"
                intIngAmount(2) -= 1
            Case 3
                lblIng3Amount.Text = "Regular"
                intIngAmount(2) -= 1
        End Select
    End Sub

    Private Sub btnLessIng4_Click(sender As Object, e As EventArgs) Handles btnLessIng4.Click
        Select Case intIngAmount(3)
            Case 1
                lblIng4Amount.Text = "None"
                intIngAmount(3) -= 1
            Case 2
                lblIng4Amount.Text = "Light"
                intIngAmount(3) -= 1
            Case 3
                lblIng4Amount.Text = "Regular"
                intIngAmount(3) -= 1
        End Select
    End Sub

    Function GetItemNames(dtbInvIDs As DataTable, ByRef strItemNames() As String)
        Dim dtbItemNames As New DataTable
        Dim strTemp(3) As String

        For i As Integer = 0 To dtbInvIDs.Rows.Count - 1
            Dim strSelect As String = "SELECT TRIM(Inv.InvName) FROM Inventory as Inv WHERE Inv.Inv_ID = '" + CStr(dtbInvIDs.Rows(i).Item(0)) + "';"
            Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

            Using connection
                connection.Open()
                Using dad As New SqlClient.SqlDataAdapter(strSelect, connection)
                    dad.Fill(dtbItemNames)
                End Using
                connection.Close()
            End Using
            ReDim Preserve strTemp(i)
            strTemp(i) = dtbItemNames.Rows(i).Item(0)
        Next

        Dim counter As Integer = 0

        For i As Integer = 0 To dtbInvIDs.Rows.Count - 1
            If (dtbInvIDs.Rows(i).Item(1)) <> "--" Then
                ReDim Preserve strModCodes(i)
                strModCodes(i) = dtbInvIDs.Rows(i).Item(1)

                Select Case counter
                    Case 0
                        lblIng1.Text = strTemp(i)
                        strItemNames(counter) = lblIng1.Text
                    Case 1
                        lblIng2.Text = strTemp(i)
                        strItemNames(counter) = lblIng2.Text
                    Case 2
                        lblIng3.Text = strTemp(i)
                        strItemNames(counter) = lblIng3.Text
                    Case 3
                        lblIng4.Text = strTemp(i)
                        strItemNames(counter) = lblIng4.Text
                End Select

                counter += 1
            End If
        Next

        intIngCount = counter
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        For i As Integer = 0 To intIngCount - 1
            Dim strSelect As String = "SELECT Inv.InvModCode FROM Inventory as Inv WHERE Inv.InvName = '" + strItemNames(i) + "';"
            Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
            Dim dtb As New DataTable

            Using connection
                connection.Open()
                Using dad As New SqlClient.SqlDataAdapter(strSelect, connection)
                    dad.Fill(dtb)
                End Using
                connection.Close()
            End Using

            Select Case intIngAmount(i)
                Case 0
                    strModCodes(i) = "N-" + dtb.Rows(0).Item(0)

                Case 1
                    strModCodes(i) = "L-" + dtb.Rows(0).Item(0)
                Case 2
                    strModCodes(i) = ""
                Case 3
                    strModCodes(i) = "E-" + dtb.Rows(0).Item(0)
            End Select
        Next

        Dim strMods As String

        For j As Integer = 0 To intIngCount - 1

            If (CustomerOrderDashboard.intSelectedIndex = -1) Then
                If strModCodes(j + 1) <> "" Then
                    strMods += strModCodes(j) + " "
                Else
                    strMods += strModCodes(j)
                End If

            Else
                If strModCodes(j + 1) <> "" Then
                    strMods += strModCodes(j) + " "
                Else
                    strMods += strModCodes(j)
                End If
            End If
        Next

        If CustomerOrderDashboard.intSelectedIndex = -1 Then
            Select Case intIngCount
                Case 1
                    CusSplashScreen.dtbOrderMods.Rows.Add(lblIng1Amount.Text, "", "", "")
                Case 2
                    CusSplashScreen.dtbOrderMods.Rows.Add(lblIng1Amount.Text, lblIng2Amount.Text, "", "")
                Case 3
                    CusSplashScreen.dtbOrderMods.Rows.Add(lblIng1Amount.Text, lblIng2Amount.Text, lblIng3Amount.Text, "")
                Case 4
                    CusSplashScreen.dtbOrderMods.Rows.Add(lblIng1Amount.Text, lblIng2Amount.Text, lblIng3Amount.Text, lblIng4Amount.Text)
            End Select

        Else
            Select Case intIngCount
                Case 1
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng1") = lblIng1Amount.Text
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng2") = ""
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng3") = ""
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng4") = ""
                Case 2
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng1") = lblIng1Amount.Text
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng2") = lblIng2Amount.Text
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng3") = ""
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng4") = ""
                Case 3
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng1") = lblIng1Amount.Text
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng2") = lblIng2Amount.Text
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng3") = lblIng3Amount.Text
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng4") = ""
                Case 4
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng1") = lblIng1Amount.Text
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng2") = lblIng2Amount.Text
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng3") = lblIng3Amount.Text
                    CusSplashScreen.dtbOrderMods.Rows(CustomerOrderDashboard.intSelectedIndex)("colIng4") = lblIng4Amount.Text
            End Select
        End If

        If (CustomerOrderDashboard.intSelectedIndex = -1) Then
            CustomerOrderDashboard.dgvOrderSummary.Rows.Add(lblItemName.Text, strMods)
            CustomerOrderDashboard.dgvOrderSummary.ClearSelection()
            CustomerOrderDashboard.AddItem()
        Else
            CustomerOrderDashboard.dgvOrderSummary.Rows(CustomerOrderDashboard.intSelectedIndex).Cells(0).Value = lblItemName.Text
            CustomerOrderDashboard.dgvOrderSummary.Rows(CustomerOrderDashboard.intSelectedIndex).Cells(1).Value = strMods
        End If

        Shrink()
    End Sub

    Function Grow()
        CustomerOrderDashboard.picBack.Enabled = False
        CustomerOrderDashboard.picOrderSummary.Enabled = False
        CustomerOrderDashboard.dgvCategories.Enabled = False
        CustomerOrderDashboard.dgvMenuItems.Enabled = False

        Me.CenterToParent()
        For i As Integer = 1 To 20

            Me.Height = i * 30
            Me.Width = i * 25
            Me.CenterToParent()

            Threading.Thread.Sleep(5)

            If i = 20 Then
                Threading.Thread.Sleep(50)
            End If
        Next

        pnlHeader.Visible = True
        flpCustom.Visible = True
        btnSave.Visible = True
        btnCancel.Visible = True
        lblItemName.Focus()
    End Function

    Function Shrink()
        pnlHeader.Visible = False
        flpCustom.Visible = False
        btnCancel.Visible = False
        btnSave.Visible = False

        For i As Integer = 20 To 1 Step -1
            Me.Height = i * 30
            Me.Width = i * 25

            Me.CenterToParent()
            Threading.Thread.Sleep(5)

        Next

        CustomerOrderDashboard.picBack.Enabled = True
        CustomerOrderDashboard.picOrderSummary.Enabled = True
        CustomerOrderDashboard.dgvCategories.Enabled = True
        CustomerOrderDashboard.dgvMenuItems.Enabled = True

        Me.Hide()
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
    End Sub

    'This function sets the focus to lblItemName when the user clicks off of the form. This keeps the border from appearing around a button.
    Private Sub CustomizeItem_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        lblItemName.Focus()
    End Sub
End Class