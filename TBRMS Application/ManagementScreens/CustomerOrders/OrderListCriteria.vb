Public Class OrderListCriteria
    Dim StartDate As String
    Dim EndDate As String

    Private Sub dtpStart_ValueChanged(sender As Object, e As EventArgs) Handles dtpStart.ValueChanged
        StartDate = dtpStart.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub dtpEnd_ValueChanged(sender As Object, e As EventArgs) Handles dtpEnd.ValueChanged
        EndDate = dtpEnd.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ManagementDashboard.btnOpt2.Visible = True
        ManagementDashboard.btnOpt2.Text = "Order Details"
        ManagementDashboard.btnOpt1.Visible = False
        ManagementDashboard.btnOpt3.Visible = False
        Shrink()

        ManagementDashboard.FetchOrders(StartDate, EndDate)

        ManagementDashboard.tmrViews.Start()
        ManagementDashboard.pnlOptions.Visible = True
        ManagementDashboard.tmrOptions.Start()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
    End Sub

    Function Grow()
        WelcomeScreen.btnCustomerOrder.Enabled = False
        WelcomeScreen.btnFOH.Enabled = False
        WelcomeScreen.btnManagement.Enabled = False

        For i As Integer = 1 To 20

            Me.Height = i * 11
            Me.Width = i * 17
            Me.CenterToParent()

            Threading.Thread.Sleep(5)

            If i = 20 Then
                Threading.Thread.Sleep(50)
            End If
        Next

        lblMessage.Visible = True
        lblStart.Visible = True
        lblEnd.Visible = True
        dtpStart.Visible = True
        dtpEnd.Visible = True
        btnContinue.Visible = True
        btnCancel.Visible = True

        lblMessage.Focus()
    End Function

    Function Shrink()
        lblMessage.Visible = False
        lblStart.Visible = False
        lblEnd.Visible = False
        dtpStart.Visible = False
        dtpEnd.Visible = False
        btnContinue.Visible = False
        btnCancel.Visible = False

        For i As Integer = 20 To 1 Step -1

            Me.Height = i * 11
            Me.Width = i * 17

            Me.CenterToParent()
            Threading.Thread.Sleep(5)

        Next
        Me.Hide()
    End Function
End Class