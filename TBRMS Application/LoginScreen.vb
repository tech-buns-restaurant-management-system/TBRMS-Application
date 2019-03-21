Public Class LoginScreen

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUser.Text = "Admin" And txtPass.Text = "Test1234") Then
            Me.Hide()
            WelcomeScreen.Show()
        Else
            MessageBox.Show("That username and password combination does not exist. Please try again.", "Login Error")
        End If
    End Sub

    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        Me.Hide()
        WelcomeScreen.Show()
    End Sub
End Class
