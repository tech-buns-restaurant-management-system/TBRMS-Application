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
        Me.lstBurgers = New System.Windows.Forms.ListBox()
        Me.lstSides = New System.Windows.Forms.ListBox()
        Me.lstBeverages = New System.Windows.Forms.ListBox()
        Me.lstOrderSummary = New System.Windows.Forms.ListBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
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
        'lstBurgers
        '
        Me.lstBurgers.FormattingEnabled = True
        Me.lstBurgers.Location = New System.Drawing.Point(478, 76)
        Me.lstBurgers.Name = "lstBurgers"
        Me.lstBurgers.Size = New System.Drawing.Size(277, 160)
        Me.lstBurgers.TabIndex = 4
        '
        'lstSides
        '
        Me.lstSides.FormattingEnabled = True
        Me.lstSides.Location = New System.Drawing.Point(478, 268)
        Me.lstSides.Name = "lstSides"
        Me.lstSides.Size = New System.Drawing.Size(277, 160)
        Me.lstSides.TabIndex = 5
        '
        'lstBeverages
        '
        Me.lstBeverages.FormattingEnabled = True
        Me.lstBeverages.Location = New System.Drawing.Point(478, 478)
        Me.lstBeverages.Name = "lstBeverages"
        Me.lstBeverages.Size = New System.Drawing.Size(277, 160)
        Me.lstBeverages.TabIndex = 6
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
        'CustomerOrderDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lstOrderSummary)
        Me.Controls.Add(Me.lstBeverages)
        Me.Controls.Add(Me.lstSides)
        Me.Controls.Add(Me.lstBurgers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBeverages)
        Me.Controls.Add(Me.btnSides)
        Me.Controls.Add(Me.btnBurgers)
        Me.Name = "CustomerOrderDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerOrderDashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBurgers As Button
    Friend WithEvents btnSides As Button
    Friend WithEvents btnBeverages As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstBurgers As ListBox
    Friend WithEvents lstSides As ListBox
    Friend WithEvents lstBeverages As ListBox
    Friend WithEvents lstOrderSummary As ListBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCheckout As Button
End Class
