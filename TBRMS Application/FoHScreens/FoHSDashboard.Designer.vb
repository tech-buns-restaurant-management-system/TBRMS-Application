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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRunOrder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(475, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(703, 138)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Top Buns Front-of-House" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dashboard"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRunOrder
        '
        Me.btnRunOrder.FlatAppearance.BorderSize = 0
        Me.btnRunOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnRunOrder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRunOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRunOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnRunOrder.Location = New System.Drawing.Point(168, 690)
        Me.btnRunOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRunOrder.Name = "btnRunOrder"
        Me.btnRunOrder.Size = New System.Drawing.Size(505, 86)
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
        Me.PictureBox1.Location = New System.Drawing.Point(48, 44)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(43, 39)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 98)
        Me.btnBack.TabIndex = 15
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.Enabled = False
        Me.btnCash.FlatAppearance.BorderSize = 0
        Me.btnCash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnCash.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.btnCash.Location = New System.Drawing.Point(1032, 690)
        Me.btnCash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(505, 86)
        Me.btnCash.TabIndex = 17
        Me.btnCash.Text = "Cash Payment"
        Me.btnCash.UseVisualStyleBackColor = True
        '
        'dgvOrderList
        '
        Me.dgvOrderList.AllowUserToAddRows = False
        Me.dgvOrderList.AllowUserToDeleteRows = False
        Me.dgvOrderList.AllowUserToResizeColumns = False
        Me.dgvOrderList.AllowUserToResizeRows = False
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!)
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderList.DefaultCellStyle = DataGridViewCellStyle22
        Me.dgvOrderList.Location = New System.Drawing.Point(168, 202)
        Me.dgvOrderList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvOrderList.MultiSelect = False
        Me.dgvOrderList.Name = "dgvOrderList"
        Me.dgvOrderList.ReadOnly = True
        Me.dgvOrderList.RowHeadersVisible = False
        Me.dgvOrderList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderList.Size = New System.Drawing.Size(505, 480)
        Me.dgvOrderList.TabIndex = 21
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.AllowUserToAddRows = False
        Me.dgvOrderDetails.AllowUserToDeleteRows = False
        Me.dgvOrderDetails.AllowUserToResizeColumns = False
        Me.dgvOrderDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderDetails.DefaultCellStyle = DataGridViewCellStyle24
        Me.dgvOrderDetails.Location = New System.Drawing.Point(1032, 202)
        Me.dgvOrderDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvOrderDetails.MultiSelect = False
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.ReadOnly = True
        Me.dgvOrderDetails.RowHeadersVisible = False
        Me.dgvOrderDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderDetails.Size = New System.Drawing.Size(505, 480)
        Me.dgvOrderDetails.TabIndex = 23
        '
        'FoHSDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1704, 884)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvOrderDetails)
        Me.Controls.Add(Me.dgvOrderList)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRunOrder)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents dgvOrderList As DataGridView
    Friend WithEvents dgvOrderDetails As DataGridView
End Class
