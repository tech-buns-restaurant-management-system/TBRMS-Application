﻿Public Class LoginSplash
    Dim intTicks As Integer = 0
    Dim intYCoor As Integer = 720
    Dim blnSliderOpen As Boolean = False
    Dim blnLoggedIn As Boolean = False
    Dim blnShift As Boolean = False
    Dim strTextInUse As String = ""
    Private Sub LoginSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlSlider.Location = New Point(-2, intYCoor)
    End Sub

    Private Sub LoginSplash_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If blnSliderOpen = True Then
            tmrSlider.Start()
        End If
    End Sub

    Private Sub tmrSlider_Tick(sender As Object, e As EventArgs) Handles tmrSlider.Tick
        Slider()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUser.Text = "ADMIN" And txtPass.Text = "PASSWORD") Then
            blnLoggedIn = True
            tmrSlider.Start()
        Else
            MessageBox.Show("That username and password combination does not exist. Please try again.", "Login Error")
        End If
    End Sub

    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        If blnSliderOpen = False Then
            WelcomeScreen.Show()
            txtUser.Clear()
            txtPass.Clear()
            Me.Hide()
        Else
            blnLoggedIn = True
            tmrSlider.Start()
        End If

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        End
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        KeyboardButtons("1")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        KeyboardButtons("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        KeyboardButtons("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        KeyboardButtons("4")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        KeyboardButtons("5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        KeyboardButtons("6")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        KeyboardButtons("7")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        KeyboardButtons("8")
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        KeyboardButtons("9")
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        KeyboardButtons("0")
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        KeyboardButtons(btnA.Text)
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        KeyboardButtons(btnB.Text)
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        KeyboardButtons(btnC.Text)
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        KeyboardButtons(btnD.Text)
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        KeyboardButtons(btnE.Text)
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        KeyboardButtons(btnF.Text)
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        KeyboardButtons(btnG.Text)
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        KeyboardButtons(btnH.Text)
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        KeyboardButtons(btnI.Text)
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        KeyboardButtons(btnJ.Text)
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        KeyboardButtons(btnK.Text)
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        KeyboardButtons(btnL.Text)
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        KeyboardButtons(btnM.Text)
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        KeyboardButtons(btnN.Text)
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        KeyboardButtons(btnO.Text)
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        KeyboardButtons(btnP.Text)
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        KeyboardButtons(btnQ.Text)
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        KeyboardButtons(btnR.Text)
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        KeyboardButtons(btnS.Text)
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        KeyboardButtons(btnT.Text)
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        KeyboardButtons(btnU.Text)
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        KeyboardButtons(btnV.Text)
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        KeyboardButtons(btnW.Text)
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        KeyboardButtons(btnX.Text)
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        KeyboardButtons(btnY.Text)
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        KeyboardButtons(btnZ.Text)
    End Sub

    Private Sub btnSpace_Click(sender As Object, e As EventArgs)
        KeyboardButtons(" ")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If strTextInUse = "U" Then
            If txtUser.Text.Length > 0 Then
                txtUser.Text = txtUser.Text.Remove(txtUser.Text.Length - 1)
            End If
        ElseIf strTextInUse = "P" Then
            If txtPass.Text.Length > 0 Then
                txtPass.Text = txtPass.Text.Remove(txtPass.Text.Length - 1)
            End If
        End If
    End Sub

    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click
        If blnShift = False Then
            btnA.Text = "A"
            btnB.Text = "B"
            btnC.Text = "C"
            btnD.Text = "D"
            btnE.Text = "E"
            btnF.Text = "F"
            btnG.Text = "G"
            btnH.Text = "H"
            btnI.Text = "I"
            btnJ.Text = "J"
            btnK.Text = "K"
            btnL.Text = "L"
            btnM.Text = "M"
            btnN.Text = "N"
            btnO.Text = "O"
            btnP.Text = "P"
            btnQ.Text = "Q"
            btnR.Text = "R"
            btnS.Text = "S"
            btnT.Text = "T"
            btnU.Text = "U"
            btnV.Text = "V"
            btnW.Text = "W"
            btnX.Text = "X"
            btnY.Text = "Y"
            btnZ.Text = "Z"
            blnShift = True
        ElseIf blnShift = True Then
            btnA.Text = "a"
            btnB.Text = "b"
            btnC.Text = "c"
            btnD.Text = "d"
            btnE.Text = "e"
            btnF.Text = "f"
            btnG.Text = "g"
            btnH.Text = "h"
            btnI.Text = "i"
            btnJ.Text = "j"
            btnK.Text = "k"
            btnL.Text = "l"
            btnM.Text = "m"
            btnN.Text = "n"
            btnO.Text = "o"
            btnP.Text = "p"
            btnQ.Text = "q"
            btnR.Text = "r"
            btnS.Text = "s"
            btnT.Text = "t"
            btnU.Text = "u"
            btnV.Text = "v"
            btnW.Text = "w"
            btnX.Text = "x"
            btnY.Text = "y"
            btnZ.Text = "z"
            blnShift = False
        End If
    End Sub

    Private Sub txtUser_Click(sender As Object, e As EventArgs) Handles txtUser.Click
        strTextInUse = "U"

        If blnSliderOpen = False Then
            tmrSlider.Start()
        End If
    End Sub

    Private Sub txtPass_Click(sender As Object, e As EventArgs) Handles txtPass.Click
        strTextInUse = "P"

        If blnSliderOpen = False Then
            tmrSlider.Start()
        End If
    End Sub

    Function Slider()
        If blnSliderOpen = False Then
            If (intTicks < 15) Then
                intTicks += 1
                intYCoor -= 20
                pnlSlider.Location = New Point(-2, intYCoor)
            ElseIf (intTicks = 15) Then
                tmrSlider.Stop()
                intTicks = 0
                pnlSlider.Location = New Point(-2, 420)
                blnSliderOpen = True
            End If
        ElseIf blnSliderOpen = True Then
            If (intTicks < 15) Then
                intTicks += 1
                intYCoor += 20
                pnlSlider.Location = New Point(-2, intYCoor)
            ElseIf (intTicks = 15) Then
                tmrSlider.Stop()
                intTicks = 0
                pnlSlider.Location = New Point(-2, 720)
                blnSliderOpen = False
                If blnLoggedIn = True Then
                    WelcomeScreen.Show()
                    txtUser.Clear()
                    txtPass.Clear()
                    blnLoggedIn = False
                    Me.Hide()
                End If
            End If
        End If
    End Function

    Function KeyboardButtons(strLetter As String)
        If strTextInUse = "U" Then
            txtUser.Text += strLetter
        ElseIf strTextInUse = "P" Then
            txtPass.Text += strLetter
        End If
    End Function
End Class