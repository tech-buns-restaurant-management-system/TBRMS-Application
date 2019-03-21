<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCash
        '
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCash.Location = New System.Drawing.Point(123, 212)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(435, 297)
        Me.btnCash.TabIndex = 0
        Me.btnCash.Text = "Cash"
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'btnCard
        '
        Me.btnCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCard.Location = New System.Drawing.Point(729, 212)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(435, 297)
        Me.btnCard.TabIndex = 1
        Me.btnCard.Text = "Credit/Debit Card"
        Me.btnCard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(420, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please select a payment option below."
        '
        'PaymentScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.btnCash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PaymentScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCash As Button
    Friend WithEvents btnCard As Button
    Friend WithEvents Label1 As Label
End Class
