<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerOrderDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerOrderDashboard))
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnOrderCancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBurgers
        '
        Me.btnBurgers.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnBurgers.Location = New System.Drawing.Point(32, 122)
        Me.btnBurgers.Name = "btnBurgers"
        Me.btnBurgers.Size = New System.Drawing.Size(275, 181)
        Me.btnBurgers.TabIndex = 0
        Me.btnBurgers.Text = "Burgers"
        Me.btnBurgers.UseVisualStyleBackColor = True
        '
        'btnSides
        '
        Me.btnSides.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnSides.Location = New System.Drawing.Point(32, 315)
        Me.btnSides.Name = "btnSides"
        Me.btnSides.Size = New System.Drawing.Size(275, 181)
        Me.btnSides.TabIndex = 1
        Me.btnSides.Text = "Sides"
        Me.btnSides.UseVisualStyleBackColor = True
        '
        'btnBeverages
        '
        Me.btnBeverages.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnBeverages.Location = New System.Drawing.Point(32, 508)
        Me.btnBeverages.Name = "btnBeverages"
        Me.btnBeverages.Size = New System.Drawing.Size(275, 181)
        Me.btnBeverages.TabIndex = 2
        Me.btnBeverages.Text = "Beverages"
        Me.btnBeverages.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(442, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Place Your Order"
        '
        'lstOrderSummary
        '
        Me.lstOrderSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrderSummary.FormattingEnabled = True
        Me.lstOrderSummary.ItemHeight = 20
        Me.lstOrderSummary.Location = New System.Drawing.Point(964, 122)
        Me.lstOrderSummary.Name = "lstOrderSummary"
        Me.lstOrderSummary.Size = New System.Drawing.Size(277, 444)
        Me.lstOrderSummary.TabIndex = 7
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnEdit.Location = New System.Drawing.Point(964, 575)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(277, 34)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit Item"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCheckout
        '
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCheckout.Location = New System.Drawing.Point(964, 655)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(277, 34)
        Me.btnCheckout.TabIndex = 9
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOption1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOption2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOption3)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOption4)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(489, 122)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(300, 567)
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
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnDelete.Location = New System.Drawing.Point(964, 615)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(277, 34)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnOrderCancel
        '
        Me.btnOrderCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderCancel.Location = New System.Drawing.Point(32, 32)
        Me.btnOrderCancel.Name = "btnOrderCancel"
        Me.btnOrderCancel.Size = New System.Drawing.Size(80, 80)
        Me.btnOrderCancel.TabIndex = 12
        Me.btnOrderCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(888, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 55)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtSearch.Location = New System.Drawing.Point(6, 18)
        Me.txtSearch.MaxLength = 9
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.ReadOnly = True
        Me.txtSearch.Size = New System.Drawing.Size(341, 31)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TabStop = False
        Me.txtSearch.Text = "Search..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'CustomerOrderDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOrderCancel)
        Me.Controls.Add(Me.btnDelete)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnOrderCancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
