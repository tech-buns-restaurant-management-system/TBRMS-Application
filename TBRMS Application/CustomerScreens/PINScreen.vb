﻿Public Class PINScreen

    Dim strPIN As String = ""

    Function AddNumber(Num As String)
        If (strPIN.Length < 4) Then
            strPIN += Num
        End If

        'Allows user to exit Customer Order Mode if the passcode is correct
        If (strPIN.Length = 4 And strPIN = "1234") Then
            Me.Hide()
            WelcomeScreen.Show()
            CusSplashScreen.Hide()
            strPIN = ""
        ElseIf (strPIN.Length = 4 And strPIN <> "1234") Then
            Me.Hide()
            strPIN = ""
        End If

    End Function

    'Keypad Button Functions
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        AddNumber("1")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        AddNumber("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        AddNumber("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        AddNumber("4")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        AddNumber("5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        AddNumber("6")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        AddNumber("7")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        AddNumber("8")
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        AddNumber("9")
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        AddNumber("0")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        strPIN = ""
        Me.Hide()
    End Sub
End Class