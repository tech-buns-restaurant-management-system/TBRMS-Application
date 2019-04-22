Public Class FoHCashPaymentScreen
    Public dblDue As Double
    Dim dblPaid, dblChange As Double
    Dim blnPaid As Boolean = False
    Dim connection As New SqlClient.SqlConnection("Server=tcp:techbuns.database.windows.net,1433;Initial Catalog=TechBunsTestDB1;Persist Security Info=False;User ID=TopBuns;Password=TechBuns123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        txtPaid.ReadOnly = True
        dblPaid = FormatCurrency(CDbl(txtPaid.Text))

        If dblPaid - dblDue < 0 Then
            MessageBox.Show("Error: Too low of payment")
            txtPaid.Clear()
        Else
            dblChange = dblPaid - dblDue

            txtPaid.Text = FormatCurrency(dblPaid)
            txtChange.Text = FormatCurrency(dblChange)

            picSave.Enabled = True
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        AddNumber("1")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        AddNumber("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        AddNumber("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        AddNumber("4")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        AddNumber("5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        AddNumber("6")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        AddNumber("7")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        AddNumber("8")
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        AddNumber("9")
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        AddNumber("0")
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        AddNumber(".")
    End Sub

    Function AddNumber(Num As String)
        If blnPaid = False Then
            txtPaid.Text += Num
        End If
    End Function

    Private Sub picSave_Click(sender As Object, e As EventArgs) Handles picSave.Click
        'Updates the CustomerOrder table to show that the order has been paid for
        Dim updateQuery As String = "UPDATE CustomerOrder SET OrderPaid = 'TRUE' WHERE CusOrder_ID = '" + FoHDashboard.strSelectedOrder + "';"

        ExecuteQuery(updateQuery)

        txtDue.Clear()
        txtPaid.Clear()
        txtChange.Clear()

        dblChange = 0
        dblPaid = 0
        dblDue = 0

        FoHDashboard.FetchOrderList()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPaid.Clear()
        txtChange.Clear()
        blnPaid = False
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        FoHDashboard.Show()
        txtDue.Clear()
        txtPaid.Clear()
        txtChange.Clear()
        dblDue = 0
        dblPaid = 0
        dblChange = 0
        blnPaid = False
        Me.Hide()
    End Sub

    Function ExecuteQuery(query As String)
        Dim command As New SqlClient.SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Function
End Class