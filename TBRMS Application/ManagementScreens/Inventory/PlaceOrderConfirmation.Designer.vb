﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlaceOrderConfirmation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMessage.Location = New System.Drawing.Point(-1, 11)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(340, 70)
        Me.lblMessage.TabIndex = 41
        Me.lblMessage.Text = "Are you sure that you'd like to place this order?"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(180, 98)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 50)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnContinue.FlatAppearance.BorderSize = 0
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(20, 98)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(140, 50)
        Me.btnContinue.TabIndex = 39
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        Me.btnContinue.Visible = False
        '
        'PlaceOrderConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContinue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PlaceOrderConfirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnContinue As Button
End Class
