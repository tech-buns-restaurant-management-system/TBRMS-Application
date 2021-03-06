﻿Public Class CustomerModeConfirmation
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

        CustomerOrderDashboard.picBack.Enabled = False
        CustomerOrderDashboard.picOrderSummary.Enabled = False
        CustomerOrderDashboard.dgvCategories.Enabled = False
        CustomerOrderDashboard.dgvMenuItems.Enabled = False
        CustomerOrderDashboard.btnEdit.Enabled = False
        CustomerOrderDashboard.btnDelete.Enabled = False
        CustomerOrderDashboard.btnCheckout.Enabled = False

        For i As Integer = 1 To 20

            Me.Height = i * 8
            Me.Width = i * 17
            Me.CenterToParent()

            Threading.Thread.Sleep(5)

            If i = 20 Then
                Threading.Thread.Sleep(50)
            End If
        Next

        For Each ctrl In Me.Controls
            ctrl.visible = True
        Next

        lblMessage.Focus()
    End Function

    Function Shrink()

        For Each ctrl In Me.Controls
            ctrl.visible = False
        Next

        For i As Integer = 20 To 1 Step -1
            Me.Height = i * 8
            Me.Width = i * 17

            Me.CenterToParent()
            Threading.Thread.Sleep(10)

        Next

        CustomerOrderDashboard.picBack.Enabled = True
        CustomerOrderDashboard.picOrderSummary.Enabled = True
        CustomerOrderDashboard.dgvCategories.Enabled = True
        CustomerOrderDashboard.dgvMenuItems.Enabled = True
        CustomerOrderDashboard.btnEdit.Enabled = True
        CustomerOrderDashboard.btnDelete.Enabled = True
        CustomerOrderDashboard.btnCheckout.Enabled = True

        Me.Hide()
    End Function
End Class