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
        Me.btnOption1 = New System.Windows.Forms.Button()
        Me.btnOption2 = New System.Windows.Forms.Button()
        Me.btnOption3 = New System.Windows.Forms.Button()
        Me.btnOption4 = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBurgers
        '
        Me.btnBurgers.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnBurgers.Location = New System.Drawing.Point(32, 62)
        Me.btnBurgers.Name = "btnBurgers"
        Me.btnBurgers.Size = New System.Drawing.Size(275, 210)
        Me.btnBurgers.TabIndex = 0
        Me.btnBurgers.Text = "Burgers"
        Me.btnBurgers.UseVisualStyleBackColor = True
        '
        'btnSides
        '
        Me.btnSides.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnSides.Location = New System.Drawing.Point(32, 279)
        Me.btnSides.Name = "btnSides"
        Me.btnSides.Size = New System.Drawing.Size(275, 210)
        Me.btnSides.TabIndex = 1
        Me.btnSides.Text = "Sides"
        Me.btnSides.UseVisualStyleBackColor = True
        '
        'btnBeverages
        '
        Me.btnBeverages.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnBeverages.Location = New System.Drawing.Point(32, 496)
        Me.btnBeverages.Name = "btnBeverages"
        Me.btnBeverages.Size = New System.Drawing.Size(275, 210)
        Me.btnBeverages.TabIndex = 2
        Me.btnBeverages.Text = "Beverages"
        Me.btnBeverages.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(507, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Place Your Order"
        '
        'lstOrderSummary
        '
        Me.lstOrderSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrderSummary.FormattingEnabled = True
        Me.lstOrderSummary.ItemHeight = 20
        Me.lstOrderSummary.Location = New System.Drawing.Point(964, 62)
        Me.lstOrderSummary.Name = "lstOrderSummary"
        Me.lstOrderSummary.Size = New System.Drawing.Size(277, 524)
        Me.lstOrderSummary.TabIndex = 7
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnEdit.Location = New System.Drawing.Point(964, 592)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(277, 34)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCheckout.Location = New System.Drawing.Point(964, 672)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(277, 34)
        Me.btnCheckout.TabIndex = 9
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOption1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOption2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOption3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOption4)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(492, 62)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(295, 644)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'btnOption1
        '
        Me.btnOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption1.Location = New System.Drawing.Point(3, 3)
        Me.btnOption1.Name = "btnOption1"
        Me.btnOption1.Size = New System.Drawing.Size(272, 200)
        Me.btnOption1.TabIndex = 0
        Me.btnOption1.Text = "Option 1"
        Me.btnOption1.UseVisualStyleBackColor = True
        Me.btnOption1.Visible = False
        '
        'btnOption2
        '
        Me.btnOption2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption2.Location = New System.Drawing.Point(3, 209)
        Me.btnOption2.Name = "btnOption2"
        Me.btnOption2.Size = New System.Drawing.Size(272, 200)
        Me.btnOption2.TabIndex = 1
        Me.btnOption2.Text = "Option 2"
        Me.btnOption2.UseVisualStyleBackColor = True
        Me.btnOption2.Visible = False
        '
        'btnOption3
        '
        Me.btnOption3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption3.Location = New System.Drawing.Point(3, 415)
        Me.btnOption3.Name = "btnOption3"
        Me.btnOption3.Size = New System.Drawing.Size(272, 200)
        Me.btnOption3.TabIndex = 2
        Me.btnOption3.Text = "Option 3"
        Me.btnOption3.UseVisualStyleBackColor = True
        Me.btnOption3.Visible = False
        '
        'btnOption4
        '
        Me.btnOption4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption4.Location = New System.Drawing.Point(3, 621)
        Me.btnOption4.Name = "btnOption4"
        Me.btnOption4.Size = New System.Drawing.Size(272, 200)
        Me.btnOption4.TabIndex = 3
        Me.btnOption4.Text = "Option 4"
        Me.btnOption4.UseVisualStyleBackColor = True
        Me.btnOption4.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnRemove.Location = New System.Drawing.Point(964, 632)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(277, 34)
        Me.btnRemove.TabIndex = 11
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(32, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CustomerOrderDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lstOrderSummary)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBeverages)
        Me.Controls.Add(Me.btnSides)
        Me.Controls.Add(Me.btnBurgers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CustomerOrderDashboard"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents btnOption1 As Button
    Friend WithEvents btnOption2 As Button
    Friend WithEvents btnOption3 As Button
    Friend WithEvents btnOption4 As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Button1 As Button
End Class
