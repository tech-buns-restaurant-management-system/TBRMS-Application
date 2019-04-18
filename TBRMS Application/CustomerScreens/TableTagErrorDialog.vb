Public Class TableTagErrorDialog
    Private Sub ErrorDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 0
        Me.Width = 0
    End Sub

    Function Grow()
        TableTagEntry.btn0.Enabled = False
        TableTagEntry.btnClear.Enabled = False
        TableTagEntry.btn1.Enabled = False
        TableTagEntry.btn2.Enabled = False
        TableTagEntry.btn3.Enabled = False
        TableTagEntry.btn4.Enabled = False
        TableTagEntry.btn5.Enabled = False
        TableTagEntry.btn6.Enabled = False
        TableTagEntry.btn7.Enabled = False
        TableTagEntry.btn8.Enabled = False
        TableTagEntry.btn9.Enabled = False
        TableTagEntry.btnEnter.Enabled = False
        TableTagEntry.txtTableTag.Enabled = False

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
        lblMessage.Focus()
    End Function

    Function Shrink()

        lblMessage.Visible = False
        btnContinue.Visible = False

        For i As Integer = 20 To 1 Step -1
            Me.Height = i * 8
            Me.Width = i * 17

            Me.CenterToParent()
            Threading.Thread.Sleep(10)

        Next

        TableTagEntry.btn0.Enabled = True
        TableTagEntry.btnClear.Enabled = True
        TableTagEntry.btn1.Enabled = True
        TableTagEntry.btn2.Enabled = True
        TableTagEntry.btn3.Enabled = True
        TableTagEntry.btn4.Enabled = True
        TableTagEntry.btn5.Enabled = True
        TableTagEntry.btn6.Enabled = True
        TableTagEntry.btn7.Enabled = True
        TableTagEntry.btn8.Enabled = True
        TableTagEntry.btn9.Enabled = True
        TableTagEntry.btnEnter.Enabled = True
        TableTagEntry.txtTableTag.Enabled = True

        Me.Hide()
    End Function

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Shrink()
    End Sub
End Class