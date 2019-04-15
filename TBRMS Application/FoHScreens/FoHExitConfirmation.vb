Public Class FoHExitConfirmation
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Shrink()
        WelcomeScreen.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Shrink()
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

        Me.Hide()
    End Function
End Class