<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagemantDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagemantDashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInventoryItemsPortal = New System.Windows.Forms.Button()
        Me.btnMenuItemsPortal = New System.Windows.Forms.Button()
        Me.btnSuppliersPortal = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnOpt1 = New System.Windows.Forms.Button()
        Me.btnOpt2 = New System.Windows.Forms.Button()
        Me.btnOpt3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lsbPortalDisplay = New System.Windows.Forms.ListBox()
        Me.lsbInventoryOrder = New System.Windows.Forms.ListBox()
        Me.lsbInventoryItems = New System.Windows.Forms.ListBox()
        Me.btnAddtoOrder = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(775, 55)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Top Buns Management Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInventoryItemsPortal
        '
        Me.btnInventoryItemsPortal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnInventoryItemsPortal.Location = New System.Drawing.Point(44, 316)
        Me.btnInventoryItemsPortal.Name = "btnInventoryItemsPortal"
        Me.btnInventoryItemsPortal.Size = New System.Drawing.Size(379, 161)
        Me.btnInventoryItemsPortal.TabIndex = 21
        Me.btnInventoryItemsPortal.Text = "Inventory Items Portal"
        Me.btnInventoryItemsPortal.UseVisualStyleBackColor = True
        '
        'btnMenuItemsPortal
        '
        Me.btnMenuItemsPortal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnMenuItemsPortal.Location = New System.Drawing.Point(44, 483)
        Me.btnMenuItemsPortal.Name = "btnMenuItemsPortal"
        Me.btnMenuItemsPortal.Size = New System.Drawing.Size(379, 161)
        Me.btnMenuItemsPortal.TabIndex = 20
        Me.btnMenuItemsPortal.Text = "Menu Items Portal"
        Me.btnMenuItemsPortal.UseVisualStyleBackColor = True
        '
        'btnSuppliersPortal
        '
        Me.btnSuppliersPortal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnSuppliersPortal.Location = New System.Drawing.Point(44, 149)
        Me.btnSuppliersPortal.Name = "btnSuppliersPortal"
        Me.btnSuppliersPortal.Size = New System.Drawing.Size(379, 161)
        Me.btnSuppliersPortal.TabIndex = 19
        Me.btnSuppliersPortal.Text = "Suppliers Portal"
        Me.btnSuppliersPortal.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpt1)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpt2)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpt3)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(906, 149)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(318, 495)
        Me.FlowLayoutPanel1.TabIndex = 22
        '
        'btnOpt1
        '
        Me.btnOpt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpt1.Location = New System.Drawing.Point(3, 3)
        Me.btnOpt1.Name = "btnOpt1"
        Me.btnOpt1.Size = New System.Drawing.Size(315, 158)
        Me.btnOpt1.TabIndex = 1
        Me.btnOpt1.Text = "Option 1"
        Me.btnOpt1.UseVisualStyleBackColor = True
        Me.btnOpt1.Visible = False
        '
        'btnOpt2
        '
        Me.btnOpt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpt2.Location = New System.Drawing.Point(3, 167)
        Me.btnOpt2.Name = "btnOpt2"
        Me.btnOpt2.Size = New System.Drawing.Size(315, 158)
        Me.btnOpt2.TabIndex = 2
        Me.btnOpt2.Text = "Option 2"
        Me.btnOpt2.UseVisualStyleBackColor = True
        Me.btnOpt2.Visible = False
        '
        'btnOpt3
        '
        Me.btnOpt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpt3.Location = New System.Drawing.Point(3, 331)
        Me.btnOpt3.Name = "btnOpt3"
        Me.btnOpt3.Size = New System.Drawing.Size(315, 158)
        Me.btnOpt3.TabIndex = 3
        Me.btnOpt3.Text = "Option 3"
        Me.btnOpt3.UseVisualStyleBackColor = True
        Me.btnOpt3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'lsbPortalDisplay
        '
        Me.lsbPortalDisplay.FormattingEnabled = True
        Me.lsbPortalDisplay.Location = New System.Drawing.Point(433, 149)
        Me.lsbPortalDisplay.Name = "lsbPortalDisplay"
        Me.lsbPortalDisplay.Size = New System.Drawing.Size(470, 498)
        Me.lsbPortalDisplay.TabIndex = 24
        Me.lsbPortalDisplay.Visible = False
        '
        'lsbInventoryOrder
        '
        Me.lsbInventoryOrder.FormattingEnabled = True
        Me.lsbInventoryOrder.Location = New System.Drawing.Point(433, 149)
        Me.lsbInventoryOrder.Name = "lsbInventoryOrder"
        Me.lsbInventoryOrder.Size = New System.Drawing.Size(202, 498)
        Me.lsbInventoryOrder.TabIndex = 25
        Me.lsbInventoryOrder.Visible = False
        '
        'lsbInventoryItems
        '
        Me.lsbInventoryItems.FormattingEnabled = True
        Me.lsbInventoryItems.Location = New System.Drawing.Point(701, 149)
        Me.lsbInventoryItems.Name = "lsbInventoryItems"
        Me.lsbInventoryItems.Size = New System.Drawing.Size(202, 498)
        Me.lsbInventoryItems.TabIndex = 26
        Me.lsbInventoryItems.Visible = False
        '
        'btnAddtoOrder
        '
        Me.btnAddtoOrder.Location = New System.Drawing.Point(641, 379)
        Me.btnAddtoOrder.Name = "btnAddtoOrder"
        Me.btnAddtoOrder.Size = New System.Drawing.Size(54, 40)
        Me.btnAddtoOrder.TabIndex = 28
        Me.btnAddtoOrder.Text = "Add to Order"
        Me.btnAddtoOrder.UseVisualStyleBackColor = True
        Me.btnAddtoOrder.Visible = False
        '
        'ManagemantDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 704)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAddtoOrder)
        Me.Controls.Add(Me.lsbInventoryItems)
        Me.Controls.Add(Me.lsbInventoryOrder)
        Me.Controls.Add(Me.lsbPortalDisplay)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.btnInventoryItemsPortal)
        Me.Controls.Add(Me.btnMenuItemsPortal)
        Me.Controls.Add(Me.btnSuppliersPortal)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManagemantDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnInventoryItemsPortal As Button
    Friend WithEvents btnMenuItemsPortal As Button
    Friend WithEvents btnSuppliersPortal As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnOpt1 As Button
    Friend WithEvents btnOpt2 As Button
    Friend WithEvents btnOpt3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lsbPortalDisplay As ListBox
    Friend WithEvents lsbInventoryOrder As ListBox
    Friend WithEvents lsbInventoryItems As ListBox
    Friend WithEvents btnAddtoOrder As Button
End Class
