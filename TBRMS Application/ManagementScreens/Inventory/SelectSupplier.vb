Public Class SelectSupplier
    Public strSupplier As String
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        strSupplier = cboSupplier.SelectedItem
        Shrink()
        PlaceOrderConfirmation.Height = 0
        PlaceOrderConfirmation.Width = 0
        PlaceOrderConfirmation.Show()
        PlaceOrderConfirmation.Grow()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
    End Sub

    Function FetchSuppliers()
        'Queries the Supplier table for SupName and populates cboSupplier with each name
        cboSupplier.Items.Clear()

        Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

        connection.Open()

        Dim selectQuery As SqlClient.SqlCommand = connection.CreateCommand()
        selectQuery.CommandText = "SELECT TRIM(Sup.SupName) as Name
                                   FROM Supplier as Sup;"

        Dim SQLReader As SqlClient.SqlDataReader = selectQuery.ExecuteReader()

        While SQLReader.Read()
            Dim strTemp() As String = {SQLReader.Item("Name")}
            cboSupplier.Items.Add(strTemp(0))
        End While

        connection.Close()
    End Function

    Function Grow()
        For i As Integer = 1 To 20

            Me.Height = i * 10
            Me.Width = i * 17
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

            Me.Height = i * 10
            Me.Width = i * 17

            Me.CenterToParent()
            Threading.Thread.Sleep(5)
        Next

        cboSupplier.Text = ""

        Me.Hide()
    End Function
End Class