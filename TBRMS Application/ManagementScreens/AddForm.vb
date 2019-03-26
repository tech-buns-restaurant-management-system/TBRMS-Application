Public Class AddForm
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Select Case (ManagemantDashboard.Identifier)
            Case "s1"
                If txtAddName.Text <> "" Then
                    ManagemantDashboard.lsbPortalDisplay.Items.Add(txtAddName.Text)
                    If txtAddName.Text <> "" Then
                        MessageBox.Show("Supplier added successfully.")
                        Me.Hide()
                    End If
                End If

            Case "i1"
                If txtAddName.Text <> "" Then
                    ManagemantDashboard.lsbInventoryItems.Items.Add(txtAddName.Text)
                    If txtAddName.Text <> "" Then
                        MessageBox.Show("Item added successfully.")
                        Me.Hide()
                    End If

                End If

            Case "m1"
                    If txtAddName.Text <> "" Then
                        ManagemantDashboard.lsbPortalDisplay.Items.Add(txtAddName.Text)
                        If txtAddName.Text <> "" Then
                            MessageBox.Show("Item added successfully")
                        End If
                    End If

            Case "s2"
                If txtAddName.Text <> ManagemantDashboard.lsbPortalDisplay.SelectedItem Then
                    ManagemantDashboard.lsbPortalDisplay.Items(ManagemantDashboard.lsbPortalDisplay.SelectedIndex) = txtAddName.Text
                    Me.Hide()
                Else
                    Me.Hide()
                End If

            Case "i2"
                If txtAddName.Text <> ManagemantDashboard.lsbInventoryItems.SelectedItem Then
                    ManagemantDashboard.lsbInventoryItems.Items(ManagemantDashboard.lsbInventoryItems.SelectedIndex) = txtAddName.Text
                    Me.Hide()
                Else
                    Me.Hide()
                End If
            Case "m2"
                If txtAddName.Text <> ManagemantDashboard.lsbPortalDisplay.SelectedItem Then
                    ManagemantDashboard.lsbPortalDisplay.Items(ManagemantDashboard.lsbPortalDisplay.SelectedIndex) = txtAddName.Text
                    Me.Hide()
                Else
                    Me.Hide()
                End If
        End Select


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
End Class