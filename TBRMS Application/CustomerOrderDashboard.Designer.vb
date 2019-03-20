<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerOrderDashboard
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
        Me.btnBurgers = New System.Windows.Forms.Button()
        Me.btnSides = New System.Windows.Forms.Button()
        Me.btnBeverages = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstOrderSummary = New System.Windows.Forms.ListBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBurger1 = New System.Windows.Forms.Button()
        Me.btnBurger2 = New System.Windows.Forms.Button()
        Me.btnBurger3 = New System.Windows.Forms.Button()
        Me.btnBurger4 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBurgers
        '
        Me.btnBurgers.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnBurgers.Location = New System.Drawing.Point(28, 76)
        Me.btnBurgers.Name = "btnBurgers"
        Me.btnBurgers.Size = New System.Drawing.Size(277, 164)
        Me.btnBurgers.TabIndex = 0
        Me.btnBurgers.Text = "Burgers"
        Me.btnBurgers.UseVisualStyleBackColor = True
        '
        'btnSides
        '
        Me.btnSides.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnSides.Location = New System.Drawing.Point(28, 268)
        Me.btnSides.Name = "btnSides"
        Me.btnSides.Size = New System.Drawing.Size(277, 164)
        Me.btnSides.TabIndex = 1
        Me.btnSides.Text = "Sides"
        Me.btnSides.UseVisualStyleBackColor = True
        '
        'btnBeverages
        '
        Me.btnBeverages.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnBeverages.Location = New System.Drawing.Point(28, 478)
        Me.btnBeverages.Name = "btnBeverages"
        Me.btnBeverages.Size = New System.Drawing.Size(277, 164)
        Me.btnBeverages.TabIndex = 2
        Me.btnBeverages.Text = "Beverages"
        Me.btnBeverages.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(495, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Place your order."
        '
        'lstOrderSummary
        '
        Me.lstOrderSummary.FormattingEnabled = True
        Me.lstOrderSummary.Location = New System.Drawing.Point(904, 76)
        Me.lstOrderSummary.Name = "lstOrderSummary"
        Me.lstOrderSummary.Size = New System.Drawing.Size(277, 355)
        Me.lstOrderSummary.TabIndex = 7
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnEdit.Location = New System.Drawing.Point(904, 464)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(122, 91)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCheckout.Location = New System.Drawing.Point(1059, 464)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(122, 91)
        Me.btnCheckout.TabIndex = 9
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBurger1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBurger2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBurger3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBurger4)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(478, 76)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(294, 566)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'btnBurger1
        '
        Me.btnBurger1.Location = New System.Drawing.Point(3, 3)
        Me.btnBurger1.Name = "btnBurger1"
        Me.btnBurger1.Size = New System.Drawing.Size(272, 200)
        Me.btnBurger1.TabIndex = 0
        Me.btnBurger1.Text = "Burger 1"
        Me.btnBurger1.UseVisualStyleBackColor = True
        '
        'btnBurger2
        '
        Me.btnBurger2.Location = New System.Drawing.Point(3, 209)
        Me.btnBurger2.Name = "btnBurger2"
        Me.btnBurger2.Size = New System.Drawing.Size(272, 200)
        Me.btnBurger2.TabIndex = 1
        Me.btnBurger2.Text = "Burger 2"
        Me.btnBurger2.UseVisualStyleBackColor = True
        '
        'btnBurger3
        '
        Me.btnBurger3.Location = New System.Drawing.Point(3, 415)
        Me.btnBurger3.Name = "btnBurger3"
        Me.btnBurger3.Size = New System.Drawing.Size(272, 200)
        Me.btnBurger3.TabIndex = 2
        Me.btnBurger3.Text = "Burger 3"
        Me.btnBurger3.UseVisualStyleBackColor = True
        '
        'btnBurger4
        '
        Me.btnBurger4.Location = New System.Drawing.Point(3, 621)
        Me.btnBurger4.Name = "btnBurger4"
        Me.btnBurger4.Size = New System.Drawing.Size(272, 200)
        Me.btnBurger4.TabIndex = 3
        Me.btnBurger4.Text = "Burger 4"
        Me.btnBurger4.UseVisualStyleBackColor = True
        '
        'CustomerOrderDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lstOrderSummary)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBeverages)
        Me.Controls.Add(Me.btnSides)
        Me.Controls.Add(Me.btnBurgers)
        Me.Name = "CustomerOrderDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerOrderDashboard"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBurgers As Button
    Friend WithEvents btnSides As Button
    Friend WithEvents btnBeverages As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstOrderSummary As ListBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnBurger1 As Button
    Friend WithEvents btnBurger2 As Button
    Friend WithEvents btnBurger3 As Button
    Friend WithEvents btnBurger4 As Button
End Class
