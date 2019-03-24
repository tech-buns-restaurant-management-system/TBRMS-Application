Public Class CashPaymentScreen
    Public dblDue As Double
    Dim dblPaid, dblChange As Double
    Dim blnPaid As Boolean = False

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        txtPaid.ReadOnly = True
        txtPaid.BackColor = Color.White
        dblPaid = CDbl(txtPaid.Text)

        If dblPaid - dblDue < 0 Then
            MessageBox.Show("Error: Too low of payment")
            txtPaid.Clear()
        Else
            dblChange = dblPaid - dblDue
            txtPaid.Text = String.Format("{0:C}", dblPaid)

            txtChange.Text = String.Format("{0:C}", dblChange)
            blnPaid = True
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FoHSDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If blnPaid = True Then
            FoHSDashboard.lstCurrentOrders.Items(1) = "Order 2 [PAID]"
            FoHSDashboard.btnCash.Enabled = False
            FoHSDashboard.Show()
            MessageBox.Show("Payment Accepted")
            Me.Hide()
        Else
            MessageBox.Show("Error: You did not enter a paid amount.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPaid.Clear()
        txtChange.Clear()
        blnPaid = False
    End Sub
End Class