<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManagementDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagementDashboard))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AzureTBDB = New TBRMS_Application.AzureTBDB()
        Me.AzureTBDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picOrderSummary = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.pnlViews = New System.Windows.Forms.Panel()
        Me.picCloseArrow = New System.Windows.Forms.PictureBox()
        Me.btnMenuView = New System.Windows.Forms.Button()
        Me.btnSupplierView = New System.Windows.Forms.Button()
        Me.btnInventoryView = New System.Windows.Forms.Button()
        Me.btnOrderView = New System.Windows.Forms.Button()
        Me.pnlOptions = New System.Windows.Forms.Panel()
        Me.btnOpt1 = New System.Windows.Forms.Button()
        Me.btnOpt2 = New System.Windows.Forms.Button()
        Me.btnOpt3 = New System.Windows.Forms.Button()
        Me.tmrViews = New System.Windows.Forms.Timer(Me.components)
        Me.tmrOptions = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.AzureTBDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AzureTBDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picOrderSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlViews.SuspendLayout()
        CType(Me.picCloseArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOptions.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AzureTBDB
        '
        Me.AzureTBDB.DataSetName = "AzureTBDB"
        Me.AzureTBDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AzureTBDBBindingSource
        '
        Me.AzureTBDBBindingSource.DataSource = Me.AzureTBDB
        Me.AzureTBDBBindingSource.Position = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picOrderSummary)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.picBack)
        Me.Panel2.Location = New System.Drawing.Point(-1, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 100)
        Me.Panel2.TabIndex = 31
        '
        'picOrderSummary
        '
        Me.picOrderSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.picOrderSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picOrderSummary.Image = CType(resources.GetObject("picOrderSummary.Image"), System.Drawing.Image)
        Me.picOrderSummary.Location = New System.Drawing.Point(1150, 0)
        Me.picOrderSummary.Name = "picOrderSummary"
        Me.picOrderSummary.Size = New System.Drawing.Size(100, 100)
        Me.picOrderSummary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrderSummary.TabIndex = 23
        Me.picOrderSummary.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(253, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(775, 55)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Top Buns Management Dashboard"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(30, 0)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(100, 100)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBack.TabIndex = 22
        Me.picBack.TabStop = False
        '
        'pnlViews
        '
        Me.pnlViews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlViews.Controls.Add(Me.picCloseArrow)
        Me.pnlViews.Controls.Add(Me.btnMenuView)
        Me.pnlViews.Controls.Add(Me.btnSupplierView)
        Me.pnlViews.Controls.Add(Me.btnInventoryView)
        Me.pnlViews.Controls.Add(Me.btnOrderView)
        Me.pnlViews.Location = New System.Drawing.Point(859, -1)
        Me.pnlViews.Name = "pnlViews"
        Me.pnlViews.Size = New System.Drawing.Size(420, 720)
        Me.pnlViews.TabIndex = 32
        '
        'picCloseArrow
        '
        Me.picCloseArrow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.picCloseArrow.Image = CType(resources.GetObject("picCloseArrow.Image"), System.Drawing.Image)
        Me.picCloseArrow.Location = New System.Drawing.Point(330, 10)
        Me.picCloseArrow.Name = "picCloseArrow"
        Me.picCloseArrow.Size = New System.Drawing.Size(80, 80)
        Me.picCloseArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCloseArrow.TabIndex = 33
        Me.picCloseArrow.TabStop = False
        '
        'btnMenuView
        '
        Me.btnMenuView.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMenuView.FlatAppearance.BorderSize = 0
        Me.btnMenuView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnMenuView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMenuView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuView.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMenuView.Location = New System.Drawing.Point(30, 565)
        Me.btnMenuView.Name = "btnMenuView"
        Me.btnMenuView.Size = New System.Drawing.Size(360, 140)
        Me.btnMenuView.TabIndex = 32
        Me.btnMenuView.Text = "Menu View"
        Me.btnMenuView.UseVisualStyleBackColor = False
        '
        'btnSupplierView
        '
        Me.btnSupplierView.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupplierView.FlatAppearance.BorderSize = 0
        Me.btnSupplierView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSupplierView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupplierView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplierView.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplierView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSupplierView.Location = New System.Drawing.Point(30, 410)
        Me.btnSupplierView.Name = "btnSupplierView"
        Me.btnSupplierView.Size = New System.Drawing.Size(360, 140)
        Me.btnSupplierView.TabIndex = 31
        Me.btnSupplierView.Text = "Supplier View"
        Me.btnSupplierView.UseVisualStyleBackColor = False
        '
        'btnInventoryView
        '
        Me.btnInventoryView.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnInventoryView.FlatAppearance.BorderSize = 0
        Me.btnInventoryView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnInventoryView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnInventoryView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryView.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnInventoryView.Location = New System.Drawing.Point(30, 255)
        Me.btnInventoryView.Name = "btnInventoryView"
        Me.btnInventoryView.Size = New System.Drawing.Size(360, 140)
        Me.btnInventoryView.TabIndex = 30
        Me.btnInventoryView.Text = "Inventory View"
        Me.btnInventoryView.UseVisualStyleBackColor = False
        '
        'btnOrderView
        '
        Me.btnOrderView.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOrderView.FlatAppearance.BorderSize = 0
        Me.btnOrderView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnOrderView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOrderView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderView.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnOrderView.Location = New System.Drawing.Point(30, 100)
        Me.btnOrderView.Name = "btnOrderView"
        Me.btnOrderView.Size = New System.Drawing.Size(360, 140)
        Me.btnOrderView.TabIndex = 29
        Me.btnOrderView.Text = "Order View"
        Me.btnOrderView.UseVisualStyleBackColor = False
        '
        'pnlOptions
        '
        Me.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOptions.Controls.Add(Me.btnOpt1)
        Me.pnlOptions.Controls.Add(Me.btnOpt2)
        Me.pnlOptions.Controls.Add(Me.btnOpt3)
        Me.pnlOptions.Location = New System.Drawing.Point(319, 639)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(640, 80)
        Me.pnlOptions.TabIndex = 33
        Me.pnlOptions.Visible = False
        '
        'btnOpt1
        '
        Me.btnOpt1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOpt1.FlatAppearance.BorderSize = 0
        Me.btnOpt1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnOpt1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOpt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnOpt1.Location = New System.Drawing.Point(14, 7)
        Me.btnOpt1.Name = "btnOpt1"
        Me.btnOpt1.Size = New System.Drawing.Size(190, 65)
        Me.btnOpt1.TabIndex = 33
        Me.btnOpt1.TabStop = False
        Me.btnOpt1.Text = "Option 1"
        Me.btnOpt1.UseVisualStyleBackColor = True
        '
        'btnOpt2
        '
        Me.btnOpt2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOpt2.FlatAppearance.BorderSize = 0
        Me.btnOpt2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnOpt2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOpt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpt2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnOpt2.Location = New System.Drawing.Point(224, 7)
        Me.btnOpt2.Name = "btnOpt2"
        Me.btnOpt2.Size = New System.Drawing.Size(190, 65)
        Me.btnOpt2.TabIndex = 32
        Me.btnOpt2.TabStop = False
        Me.btnOpt2.Text = "Option 2"
        Me.btnOpt2.UseVisualStyleBackColor = False
        '
        'btnOpt3
        '
        Me.btnOpt3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOpt3.FlatAppearance.BorderSize = 0
        Me.btnOpt3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnOpt3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnOpt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpt3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnOpt3.Location = New System.Drawing.Point(434, 7)
        Me.btnOpt3.Name = "btnOpt3"
        Me.btnOpt3.Size = New System.Drawing.Size(190, 65)
        Me.btnOpt3.TabIndex = 31
        Me.btnOpt3.TabStop = False
        Me.btnOpt3.Text = "Option 3"
        Me.btnOpt3.UseVisualStyleBackColor = False
        '
        'tmrViews
        '
        Me.tmrViews.Interval = 1
        '
        'tmrOptions
        '
        Me.tmrOptions.Interval = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(319, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(640, 480)
        Me.DataGridView1.TabIndex = 35
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(605, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(713, 722)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 36
        Me.PictureBox2.TabStop = False
        '
        'ManagementDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlViews)
        Me.Controls.Add(Me.pnlOptions)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManagementDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.AzureTBDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AzureTBDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picOrderSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlViews.ResumeLayout(False)
        CType(Me.picCloseArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOptions.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AzureTBDB As AzureTBDB
    Friend WithEvents AzureTBDBBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents picBack As PictureBox
    Friend WithEvents pnlOptions As Panel
    Friend WithEvents btnMenuView As Button
    Friend WithEvents btnSupplierView As Button
    Friend WithEvents btnInventoryView As Button
    Friend WithEvents btnOrderView As Button
    Friend WithEvents picCloseArrow As PictureBox
    Friend WithEvents pnlViews As Panel
    Friend WithEvents btnOpt1 As Button
    Friend WithEvents btnOpt2 As Button
    Friend WithEvents btnOpt3 As Button
    Friend WithEvents picOrderSummary As PictureBox
    Friend WithEvents tmrViews As Timer
    Friend WithEvents tmrOptions As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
End Class
