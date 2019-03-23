Public Class LoginSplash
    Private Sub LoginSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrSlider.Enabled = True
        tmrSlider.Start()
    End Sub

    Private Sub tmrSlider_Tick(sender As Object, e As EventArgs) Handles tmrSlider.Tick
        MenuSearchScreen.Slider()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUser.Text = "Admin" And txtPass.Text = "Test1234") Then
            Me.Hide()
            txtUser.Clear()
            txtPass.Clear()
            WelcomeScreen.Show()
        Else
            MessageBox.Show("That username and password combination does not exist. Please try again.", "Login Error")
        End If
    End Sub

    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        Me.Hide()
        WelcomeScreen.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        End
    End Sub
End Class