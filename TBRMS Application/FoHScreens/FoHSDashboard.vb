Public Class FoHSDashboard
    Public strOrder1(2), strOrder2(4), strOrder3(3), strOrder4(2) As String
    Public intSelectedOrder As String = 0

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        If lstOrderDetails.SelectedIndex = -1 Then
            MessageBox.Show("Error: No order item is selected")
        Else
            ItemCustomization(lstOrderDetails.Items(lstOrderDetails.SelectedIndex))
            FoHMenuItemCustomization.lblItem.Text = lstOrderDetails.Items(lstOrderDetails.SelectedIndex)
            FoHMenuItemCustomization.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If lstOrderDetails.SelectedIndex = -1 Then
            MessageBox.Show("Error: No order item is selected")
        Else
            FoHMenuItemDeletionConfirmation.Show()
        End If
    End Sub

    Private Sub lstCurrentOrders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCurrentOrders.SelectedIndexChanged
        Dim strTrimStart() As Char = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "O", "r", "d", "e", "r", " "}
        Dim strTrimEnd() As Char = {"[", "P", "A", "I", "D", "]"}
        If lstCurrentOrders.SelectedIndex > -1 Then
            If lstCurrentOrders.Items(lstCurrentOrders.SelectedIndex).TrimStart(strTrimStart) = "[PAID]" Then
                btnCash.Enabled = False
            Else
                btnCash.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        FoHCashPaymentScreen.dblDue = 16.95
        FoHCashPaymentScreen.txtDue.Text = "$" + CStr(FoHCashPaymentScreen.dblDue)
        FoHCashPaymentScreen.Show()
    End Sub

    Private Sub FoHSDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCurrentOrders.Items.Add("Order 1 [PAID]")
        strOrder1(0) = "Banzai Burger"
        strOrder1(1) = "Sea Salt French Fries"
        strOrder1(2) = "Spring Water"

        lstCurrentOrders.Items.Add("Order 2")
        strOrder2(0) = "Bare Essentials Burger"
        strOrder2(1) = "Sea Salt Sweet Potato Fries"
        strOrder2(2) = "Top Beverages Vanilla Cream Soda"
        strOrder2(3) = "Mini Gherkins"
        strOrder2(4) = "Spring Water"

        lstCurrentOrders.Items.Add("Order 3 [PAID]")
        strOrder3(0) = "Banzai Burger"
        strOrder3(1) = "Drunk Monk Burger"
        strOrder3(2) = "Spring Water"
        strOrder3(3) = "Roasted Vegetables"

        lstCurrentOrders.Items.Add("Order 4 [PAID]")
        strOrder4(0) = "Drunk Monk Burger"
        strOrder4(1) = "Sea Salt French Fries"
        strOrder4(2) = "Top Beverages Fresh Lemonade"
    End Sub

    Private Sub btnRunOrder_Click(sender As Object, e As EventArgs) Handles btnRunOrder.Click
        Dim strTrimStart() As Char = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "O", "r", "d", "e", "r", " "}
        Dim strTrimEnd() As Char = {"[", "P", "A", "I", "D", "]"}

        If lstCurrentOrders.Items(lstCurrentOrders.SelectedIndex).TrimStart(strTrimStart) = "[PAID]" Then
            MessageBox.Show(lstCurrentOrders.Items(lstCurrentOrders.SelectedIndex).TrimEnd(strTrimEnd) + "Complete")

            lstCurrentOrders.Items.RemoveAt(lstCurrentOrders.SelectedIndex)
            lstOrderDetails.Items.Clear()
        Else
            MessageBox.Show("Error: The order has not been paid for")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WelcomeScreen.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrderDetails_Click(sender As Object, e As EventArgs) Handles btnOrderDetails.Click
        If lstCurrentOrders.SelectedIndex = -1 Then
            MessageBox.Show("Error: No order selected")
        Else
            lstOrderDetails.Items.Clear()
            Select Case lstCurrentOrders.SelectedIndex
                Case 0
                    intSelectedOrder = 1
                    For i As Integer = 0 To strOrder1.Length - 1
                        lstOrderDetails.Items.Add(strOrder1(i))
                    Next
                Case 1
                    intSelectedOrder = 2
                    For i As Integer = 0 To strOrder2.Length - 1
                        lstOrderDetails.Items.Add(strOrder2(i))
                    Next
                Case 2
                    intSelectedOrder = 3
                    For i As Integer = 0 To strOrder3.Length - 1
                        lstOrderDetails.Items.Add(strOrder3(i))
                    Next
                Case 3
                    intSelectedOrder = 4
                    For i As Integer = 0 To strOrder4.Length - 1
                        lstOrderDetails.Items.Add(strOrder4(i))
                    Next
            End Select
        End If
    End Sub

    Function ItemCustomization(strItem As String)
        'TODO: Customization Options
        Select Case strItem
            Case "Drunk Monk Burger"

            Case "Banzai Burger"

            Case "Bare Essentials Burger"

            Case "Sea Salted Sweet Potato Fries"

            Case "Sea Salted French Fries"

            Case "Roasted Vegetables"

            Case "Top Beverages Vanilla Cream Soda"

            Case "Top Beverages Fresh Lemonade"

            Case "Spring Water"

        End Select
    End Function
End Class