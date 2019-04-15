Public Class ThankYouScreen
    Dim intSecond As Integer
    Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        intSecond += 1
        If intSecond >= 5 Then
            Timer1.Stop()
            intSecond = 0
            Checkout()

            CusSplashScreen.Show()
            Me.Hide()
        End If
    End Sub

    Function Checkout()
        Dim strDate As String = DateString
        Dim strTime As String = TimeString

        Dim insertOrderQuery As String = "INSERT INTO CustomerOrder VALUES ('" + DateString + "', '" + TimeString + "', '" + TableTagEntry.strTableTag + "', '" +
                                         CStr(PaymentSelection.blnPaid) + "', 'False', " + CStr(NewCustomerOrderDashboard.dblOrderTotal) + ");"

        ExecuteQuery(insertOrderQuery)

        For i As Integer = 0 To NewCustomerOrderDashboard.strItems.Length - 1
            Dim OrderLineQuery As String = "INSERT INTO CustomerOrderLine VALUES ((SELECT CusOrder_ID FROM CustomerOrder WHERE OrderDate = '" +
                                            strDate + "' AND OrderTime = '" + strTime + "' AND OrderTableNum = '" + TableTagEntry.strTableTag + "'), (SELECT MenuItem_ID FROM MenuItem WHERE MenuItemName = '" +
                                            NewCustomerOrderDashboard.strItems(i) + "'), '"

            If (NewCustomerOrderDashboard.strMods(i) = "") Then
                OrderLineQuery += "NULL');"
            Else
                OrderLineQuery += NewCustomerOrderDashboard.strMods(i) + "');"
            End If

            ExecuteQuery(OrderLineQuery)
        Next
    End Function

    Function ExecuteQuery(query As String)
        Dim command As New SqlClient.SqlCommand(query, connection)
        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()
    End Function
End Class