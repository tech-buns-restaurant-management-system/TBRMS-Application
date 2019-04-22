Public Class ExitManagementConfirmation
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Shrink()
        WelcomeScreen.Show()
        ManagementDashboard.Hide()
    End Sub

    Function Grow()
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
            Threading.Thread.Sleep(5)
        Next

        Me.Hide()
    End Function
End Class