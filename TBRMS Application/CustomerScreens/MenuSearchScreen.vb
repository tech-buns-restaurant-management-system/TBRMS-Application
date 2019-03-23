Public Class MenuSearchScreen
    Dim intTicks As Integer = 0
    Dim intYCoor As Integer = 720
    Dim blnSliderOpen As Boolean = False
    Dim blnBack As Boolean = False

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click
        If blnSliderOpen = False Then
            txtSearch.Text = ""
            ResetButtons()
            tmrSlider.Start()
        End If
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        If blnSliderOpen = True Then
            tmrSlider.Start()
        End If
    End Sub

    Private Sub tmrSlider_Tick(sender As Object, e As EventArgs) Handles tmrSlider.Tick
        Slider()
    End Sub

    Function Slider()
        If blnSliderOpen = False Then
            If (intTicks < 15) Then
                btnSearch.Focus()
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
            txtSearch.Text = "Search..."
            If (intTicks < 15) Then
                intTicks += 1
                intYCoor += 20
                pnlSlider.Location = New Point(-2, intYCoor)
            ElseIf (intTicks = 15) Then
                tmrSlider.Stop()
                intTicks = 0
                pnlSlider.Location = New Point(-2, 720)
                blnSliderOpen = False
                If blnBack = True Then
                    CustomerOrderDashboard.Label1.Focus()
                    ResetButtons()
                    Me.Hide()
                    blnBack = False
                End If
            End If
        End If
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If blnSliderOpen = False Then
            CustomerOrderDashboard.Label1.Focus()
            ResetButtons()
            Me.Hide()
        Else
            blnBack = True
            tmrSlider.Start()
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If blnSliderOpen = True Then
            tmrSlider.Start()
        End If

        btnOption1.Visible = True
        btnOption1.Text = "Drunk Monk Burger"

        btnOption2.Visible = True
        btnOption2.Text = "Banzai Burger"

        btnOption3.Visible = True
        btnOption3.Text = "Bare Essentials Burger"
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        txtSearch.Text += "A"
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        txtSearch.Text += "B"
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtSearch.Text += "C"
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        txtSearch.Text += "D"
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        txtSearch.Text += "E"
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        txtSearch.Text += "F"
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        txtSearch.Text += "G"
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        txtSearch.Text += "H"
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        txtSearch.Text += "I"
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        txtSearch.Text += "J"
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        txtSearch.Text += "K"
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        txtSearch.Text += "L"
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        txtSearch.Text += "M"
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        txtSearch.Text += "N"
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        txtSearch.Text += "O"
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        txtSearch.Text += "P"
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        txtSearch.Text += "Q"
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        txtSearch.Text += "R"
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        txtSearch.Text += "S"
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        txtSearch.Text += "T"
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        txtSearch.Text += "U"
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        txtSearch.Text += "V"
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        txtSearch.Text += "W"
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        txtSearch.Text += "X"
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        txtSearch.Text += "Y"
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        txtSearch.Text += "Z"
    End Sub

    Private Sub btnSpace_Click(sender As Object, e As EventArgs) Handles btnSpace.Click
        txtSearch.Text += " "
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        txtSearch.Text = txtSearch.Text.Remove(txtSearch.Text.Length - 1)
    End Sub

    Private Sub btnOption1_Click(sender As Object, e As EventArgs) Handles btnOption1.Click
        CustomerOrderDashboard.lstOrderSummary.Items.Add(btnOption1.Text)
        CustomerOrderDashboard.Label1.Focus()
        ResetButtons()
        Me.Hide()
    End Sub

    Private Sub btnOption2_Click(sender As Object, e As EventArgs) Handles btnOption2.Click
        CustomerOrderDashboard.lstOrderSummary.Items.Add(btnOption2.Text)
        CustomerOrderDashboard.Label1.Focus()
        ResetButtons()
        Me.Hide()
    End Sub

    Private Sub btnOption3_Click(sender As Object, e As EventArgs) Handles btnOption3.Click
        CustomerOrderDashboard.lstOrderSummary.Items.Add(btnOption3.Text)
        CustomerOrderDashboard.Label1.Focus()
        ResetButtons()
        Me.Hide()
    End Sub

    Private Sub btnOption4_Click(sender As Object, e As EventArgs) Handles btnOption4.Click
        CustomerOrderDashboard.lstOrderSummary.Items.Add(btnOption4.Text)
        CustomerOrderDashboard.Label1.Focus()
        ResetButtons()
        Me.Hide()
    End Sub

    Private Sub btnOption5_Click(sender As Object, e As EventArgs) Handles btnOption5.Click
        CustomerOrderDashboard.lstOrderSummary.Items.Add(btnOption5.Text)
        CustomerOrderDashboard.Label1.Focus()
        ResetButtons()
        Me.Hide()
    End Sub

    Private Sub btnOption6_Click(sender As Object, e As EventArgs) Handles btnOption6.Click
        CustomerOrderDashboard.lstOrderSummary.Items.Add(btnOption6.Text)
        CustomerOrderDashboard.Label1.Focus()
        ResetButtons()
        Me.Hide()
    End Sub

    Private Sub btnOption7_Click(sender As Object, e As EventArgs) Handles btnOption7.Click
        CustomerOrderDashboard.lstOrderSummary.Items.Add(btnOption7.Text)
        CustomerOrderDashboard.Label1.Focus()
        ResetButtons()
        Me.Hide()
    End Sub

    Private Sub btnOption8_Click(sender As Object, e As EventArgs) Handles btnOption8.Click
        CustomerOrderDashboard.lstOrderSummary.Items.Add(btnOption8.Text)
        CustomerOrderDashboard.Label1.Focus()
        ResetButtons()
        Me.Hide()
    End Sub

    Function ResetButtons()
        btnOption1.Visible = False
        btnOption2.Visible = False
        btnOption3.Visible = False
        btnOption4.Visible = False
        btnOption5.Visible = False
        btnOption6.Visible = False
        btnOption7.Visible = False
        btnOption8.Visible = False
    End Function
End Class