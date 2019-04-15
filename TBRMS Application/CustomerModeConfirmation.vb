Public Class CustomerModeConfirmation
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
        Me.Hide()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Shrink()
        CusSplashScreen.Show()
        Me.Hide()
        WelcomeScreen.Hide()
    End Sub

    Function Grow()

        NewCustomerOrderDashboard.picBack.Enabled = False
        NewCustomerOrderDashboard.picOrderSummary.Enabled = False
        NewCustomerOrderDashboard.dgvCategories.Enabled = False
        NewCustomerOrderDashboard.dgvMenuItems.Enabled = False
        NewCustomerOrderDashboard.btnEdit.Enabled = False
        NewCustomerOrderDashboard.btnDelete.Enabled = False
        NewCustomerOrderDashboard.btnCheckout.Enabled = False

        For i As Integer = 1 To 20

            Me.Height = i * 8
            Me.Width = i * 17
            Me.CenterToParent()

            Threading.Thread.Sleep(5)

            If i = 20 Then
                Threading.Thread.Sleep(50)
            End If
        Next

        lblMessage.Visible = True
        btnContinue.Visible = True
        btnCancel.Visible = True
        lblMessage.Focus()
    End Function

    Function Shrink()

        lblMessage.Visible = False
        btnContinue.Visible = False
        btnCancel.Visible = False

        For i As Integer = 20 To 1 Step -1
            Me.Height = i * 8
            Me.Width = i * 17

            Me.CenterToParent()
            Threading.Thread.Sleep(10)

        Next

        NewCustomerOrderDashboard.picBack.Enabled = True
        NewCustomerOrderDashboard.picOrderSummary.Enabled = True
        NewCustomerOrderDashboard.dgvCategories.Enabled = True
        NewCustomerOrderDashboard.dgvMenuItems.Enabled = True
        NewCustomerOrderDashboard.btnEdit.Enabled = True
        NewCustomerOrderDashboard.btnDelete.Enabled = True
        NewCustomerOrderDashboard.btnCheckout.Enabled = True

        Me.Hide()
    End Function
End Class