<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoHSDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FoHSDashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRunOrder = New System.Windows.Forms.Button()
        Me.btnOrderDetails = New System.Windows.Forms.Button()
        Me.lstCurrentOrders = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnEditItem = New System.Windows.Forms.Button()
        Me.lstOrderDetails = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(567, 110)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Top Buns Front-of-House" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRunOrder
        '
        Me.btnRunOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnRunOrder.Location = New System.Drawing.Point(75, 654)
        Me.btnRunOrder.Name = "btnRunOrder"
        Me.btnRunOrder.Size = New System.Drawing.Size(379, 34)
        Me.btnRunOrder.TabIndex = 12
        Me.btnRunOrder.Text = "Run Order"
        Me.btnRunOrder.UseVisualStyleBackColor = True
        '
        'btnOrderDetails
        '
        Me.btnOrderDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnOrderDetails.Location = New System.Drawing.Point(75, 574)
        Me.btnOrderDetails.Name = "btnOrderDetails"
        Me.btnOrderDetails.Size = New System.Drawing.Size(379, 34)
        Me.btnOrderDetails.TabIndex = 11
        Me.btnOrderDetails.Text = "Order Details"
        Me.btnOrderDetails.UseVisualStyleBackColor = True
        '
        'lstCurrentOrders
        '
        Me.lstCurrentOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCurrentOrders.FormattingEnabled = True
        Me.lstCurrentOrders.ItemHeight = 20
        Me.lstCurrentOrders.Location = New System.Drawing.Point(75, 164)
        Me.lstCurrentOrders.Name = "lstCurrentOrders"
        Me.lstCurrentOrders.Size = New System.Drawing.Size(379, 404)
        Me.lstCurrentOrders.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(32, 32)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 80)
        Me.btnBack.TabIndex = 15
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCash
        '
        Me.btnCash.Enabled = False
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCash.Location = New System.Drawing.Point(75, 614)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(379, 34)
        Me.btnCash.TabIndex = 17
        Me.btnCash.Text = "Cash Payment"
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnDeleteItem.Location = New System.Drawing.Point(826, 614)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(379, 34)
        Me.btnDeleteItem.TabIndex = 20
        Me.btnDeleteItem.Text = "Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnEditItem
        '
        Me.btnEditItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnEditItem.Location = New System.Drawing.Point(826, 574)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(379, 34)
        Me.btnEditItem.TabIndex = 19
        Me.btnEditItem.Text = "Edit Item"
        Me.btnEditItem.UseVisualStyleBackColor = True
        '
        'lstOrderDetails
        '
        Me.lstOrderDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrderDetails.FormattingEnabled = True
        Me.lstOrderDetails.ItemHeight = 20
        Me.lstOrderDetails.Location = New System.Drawing.Point(826, 164)
        Me.lstOrderDetails.Name = "lstOrderDetails"
        Me.lstOrderDetails.Size = New System.Drawing.Size(379, 404)
        Me.lstOrderDetails.TabIndex = 18
        '
        'FoHSDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnEditItem)
        Me.Controls.Add(Me.lstOrderDetails)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRunOrder)
        Me.Controls.Add(Me.btnOrderDetails)
        Me.Controls.Add(Me.lstCurrentOrders)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FoHSDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRunOrder As Button
    Friend WithEvents btnOrderDetails As Button
    Friend WithEvents lstCurrentOrders As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnEditItem As Button
    Friend WithEvents lstOrderDetails As ListBox
End Class
