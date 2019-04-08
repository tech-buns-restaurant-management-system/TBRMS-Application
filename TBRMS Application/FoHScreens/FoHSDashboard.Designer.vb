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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRunOrder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnEditItem = New System.Windows.Forms.Button()
        Me.dgvOrderList = New System.Windows.Forms.DataGridView()
        Me.dgvOrderDetails = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnRunOrder.Location = New System.Drawing.Point(126, 636)
        Me.btnRunOrder.Name = "btnRunOrder"
        Me.btnRunOrder.Size = New System.Drawing.Size(379, 70)
        Me.btnRunOrder.TabIndex = 12
        Me.btnRunOrder.Text = "Run Order"
        Me.btnRunOrder.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
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
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(32, 32)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 80)
        Me.btnBack.TabIndex = 15
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.Enabled = False
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCash.Location = New System.Drawing.Point(126, 560)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(379, 70)
        Me.btnCash.TabIndex = 17
        Me.btnCash.Text = "Cash Payment"
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnDeleteItem.Location = New System.Drawing.Point(774, 636)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(379, 70)
        Me.btnDeleteItem.TabIndex = 20
        Me.btnDeleteItem.Text = "Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnEditItem
        '
        Me.btnEditItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnEditItem.Location = New System.Drawing.Point(774, 560)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(379, 70)
        Me.btnEditItem.TabIndex = 19
        Me.btnEditItem.Text = "Edit Item"
        Me.btnEditItem.UseVisualStyleBackColor = True
        '
        'dgvOrderList
        '
        Me.dgvOrderList.AllowUserToAddRows = False
        Me.dgvOrderList.AllowUserToDeleteRows = False
        Me.dgvOrderList.AllowUserToResizeColumns = False
        Me.dgvOrderList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrderList.Location = New System.Drawing.Point(126, 164)
        Me.dgvOrderList.MultiSelect = False
        Me.dgvOrderList.Name = "dgvOrderList"
        Me.dgvOrderList.ReadOnly = True
        Me.dgvOrderList.RowHeadersVisible = False
        Me.dgvOrderList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderList.Size = New System.Drawing.Size(379, 390)
        Me.dgvOrderList.TabIndex = 21
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.AllowUserToAddRows = False
        Me.dgvOrderDetails.AllowUserToDeleteRows = False
        Me.dgvOrderDetails.AllowUserToResizeColumns = False
        Me.dgvOrderDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderDetails.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvOrderDetails.Location = New System.Drawing.Point(774, 164)
        Me.dgvOrderDetails.MultiSelect = False
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.ReadOnly = True
        Me.dgvOrderDetails.RowHeadersVisible = False
        Me.dgvOrderDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderDetails.Size = New System.Drawing.Size(379, 390)
        Me.dgvOrderDetails.TabIndex = 23
        '
        'FoHSDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvOrderDetails)
        Me.Controls.Add(Me.dgvOrderList)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnEditItem)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRunOrder)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FoHSDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRunOrder As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnEditItem As Button
    Friend WithEvents dgvOrderList As DataGridView
    Friend WithEvents dgvOrderDetails As DataGridView
End Class
