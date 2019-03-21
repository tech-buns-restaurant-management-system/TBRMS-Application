<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalOrderSummary
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
        Me.lstOrderSummary = New System.Windows.Forms.ListBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstOrderSummary
        '
        Me.lstOrderSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lstOrderSummary.FormattingEnabled = True
        Me.lstOrderSummary.ItemHeight = 25
        Me.lstOrderSummary.Location = New System.Drawing.Point(456, 57)
        Me.lstOrderSummary.Name = "lstOrderSummary"
        Me.lstOrderSummary.Size = New System.Drawing.Size(303, 479)
        Me.lstOrderSummary.TabIndex = 0
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnEdit.Location = New System.Drawing.Point(456, 555)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(303, 38)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCheckout.Location = New System.Drawing.Point(456, 612)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(303, 38)
        Me.btnCheckout.TabIndex = 2
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(451, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Check your order below."
        '
        'FinalOrderSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lstOrderSummary)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FinalOrderSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOrderSummary As ListBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents Label1 As Label
End Class
