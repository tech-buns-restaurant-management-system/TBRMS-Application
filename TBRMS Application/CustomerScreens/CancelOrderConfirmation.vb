Public Class CancelOrderConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Shrink()
        NewCustomerOrderDashboard.dgvCategories.Rows.Clear()
        NewCustomerOrderDashboard.dgvMenuItems.Rows.Clear()
        NewCustomerOrderDashboard.dgvOrderSummary.Rows.Clear()



        CusSplashScreen.Show()
        NewCustomerOrderDashboard.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
    End Sub

    Function Grow()

        NewCustomerOrderDashboard.picBack.Enabled = False
        NewCustomerOrderDashboard.picOrderSummary.Enabled = False
        NewCustomerOrderDashboard.dgvCategories.Enabled = False
        NewCustomerOrderDashboard.dgvMenuItems.Enabled = False
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
            Threading.Thread.Sleep(5)

        Next

        lblMessage.Visible = False
        btnContinue.Visible = False
        btnCancel.Visible = False

        NewCustomerOrderDashboard.picBack.Enabled = True
        NewCustomerOrderDashboard.picOrderSummary.Enabled = True
        NewCustomerOrderDashboard.dgvCategories.Enabled = True
        NewCustomerOrderDashboard.dgvMenuItems.Enabled = True

        Me.Hide()
    End Function
End Class