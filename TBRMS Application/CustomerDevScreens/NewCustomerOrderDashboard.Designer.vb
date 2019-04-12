<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewCustomerOrderDashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCustomerOrderDashboard))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AzureTBDB = New TBRMS_Application.AzureTBDB()
        Me.AzureTBDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvMenuItems = New System.Windows.Forms.DataGridView()
        Me.dgvCategories = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.picSearch = New System.Windows.Forms.PictureBox()
        Me.picOrderSummary = New System.Windows.Forms.PictureBox()
        Me.pnlOrderSummary = New System.Windows.Forms.Panel()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picCloseArrow = New System.Windows.Forms.PictureBox()
        Me.dgvOrderSummary = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.tmrOrderSummarySlider = New System.Windows.Forms.Timer(Me.components)
        Me.pnlOrderSumCaller = New System.Windows.Forms.Panel()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNumItems = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.pnlKeyboard = New System.Windows.Forms.Panel()
        Me.btnDeleteSearch = New System.Windows.Forms.Button()
        Me.btnSpace = New System.Windows.Forms.Button()
        Me.picHide = New System.Windows.Forms.PictureBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnQ = New System.Windows.Forms.Button()
        Me.tmrKeyboard = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picMeme = New System.Windows.Forms.PictureBox()
        CType(Me.AzureTBDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AzureTBDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenuItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOrderSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrderSummary.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picCloseArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOrderSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrderSumCaller.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKeyboard.SuspendLayout()
        CType(Me.picHide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMeme, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(443, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(395, 55)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Place Your Order"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvMenuItems
        '
        Me.dgvMenuItems.AllowUserToAddRows = False
        Me.dgvMenuItems.AllowUserToDeleteRows = False
        Me.dgvMenuItems.AllowUserToResizeColumns = False
        Me.dgvMenuItems.AllowUserToResizeRows = False
        Me.dgvMenuItems.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvMenuItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenuItems.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMenuItems.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMenuItems.GridColor = System.Drawing.SystemColors.MenuText
        Me.dgvMenuItems.Location = New System.Drawing.Point(441, 220)
        Me.dgvMenuItems.MultiSelect = False
        Me.dgvMenuItems.Name = "dgvMenuItems"
        Me.dgvMenuItems.ReadOnly = True
        Me.dgvMenuItems.RowHeadersVisible = False
        Me.dgvMenuItems.RowTemplate.Height = 100
        Me.dgvMenuItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMenuItems.ShowCellToolTips = False
        Me.dgvMenuItems.Size = New System.Drawing.Size(398, 402)
        Me.dgvMenuItems.TabIndex = 10
        Me.dgvMenuItems.TabStop = False
        '
        'dgvCategories
        '
        Me.dgvCategories.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace
        Me.dgvCategories.AllowUserToAddRows = False
        Me.dgvCategories.AllowUserToDeleteRows = False
        Me.dgvCategories.AllowUserToResizeColumns = False
        Me.dgvCategories.AllowUserToResizeRows = False
        Me.dgvCategories.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategories.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCategories.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCategories.GridColor = System.Drawing.SystemColors.MenuText
        Me.dgvCategories.Location = New System.Drawing.Point(70, 220)
        Me.dgvCategories.MultiSelect = False
        Me.dgvCategories.Name = "dgvCategories"
        Me.dgvCategories.ReadOnly = True
        Me.dgvCategories.RowHeadersVisible = False
        Me.dgvCategories.RowTemplate.Height = 133
        Me.dgvCategories.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategories.ShowCellToolTips = False
        Me.dgvCategories.Size = New System.Drawing.Size(300, 401)
        Me.dgvCategories.TabIndex = 14
        Me.dgvCategories.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(70, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 50)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Categories"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.picSearch)
        Me.pnlSearch.Location = New System.Drawing.Point(441, 160)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(398, 50)
        Me.pnlSearch.TabIndex = 17
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(58, 4)
        Me.txtSearch.MaxLength = 30
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.ReadOnly = True
        Me.txtSearch.Size = New System.Drawing.Size(340, 43)
        Me.txtSearch.TabIndex = 20
        Me.txtSearch.TabStop = False
        Me.txtSearch.Text = "Search..."
        '
        'picSearch
        '
        Me.picSearch.Image = CType(resources.GetObject("picSearch.Image"), System.Drawing.Image)
        Me.picSearch.Location = New System.Drawing.Point(-2, -10)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(70, 70)
        Me.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSearch.TabIndex = 19
        Me.picSearch.TabStop = False
        '
        'picOrderSummary
        '
        Me.picOrderSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.picOrderSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picOrderSummary.Image = CType(resources.GetObject("picOrderSummary.Image"), System.Drawing.Image)
        Me.picOrderSummary.Location = New System.Drawing.Point(1145, 0)
        Me.picOrderSummary.Name = "picOrderSummary"
        Me.picOrderSummary.Size = New System.Drawing.Size(100, 100)
        Me.picOrderSummary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrderSummary.TabIndex = 22
        Me.picOrderSummary.TabStop = False
        '
        'pnlOrderSummary
        '
        Me.pnlOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOrderSummary.Controls.Add(Me.btnCheckout)
        Me.pnlOrderSummary.Controls.Add(Me.Panel1)
        Me.pnlOrderSummary.Controls.Add(Me.dgvOrderSummary)
        Me.pnlOrderSummary.Controls.Add(Me.btnDelete)
        Me.pnlOrderSummary.Controls.Add(Me.btnEdit)
        Me.pnlOrderSummary.Location = New System.Drawing.Point(859, -1)
        Me.pnlOrderSummary.Name = "pnlOrderSummary"
        Me.pnlOrderSummary.Size = New System.Drawing.Size(420, 722)
        Me.pnlOrderSummary.TabIndex = 23
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCheckout.FlatAppearance.BorderSize = 0
        Me.btnCheckout.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCheckout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCheckout.Location = New System.Drawing.Point(40, 650)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(340, 50)
        Me.btnCheckout.TabIndex = 28
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.picCloseArrow)
        Me.Panel1.Location = New System.Drawing.Point(40, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 50)
        Me.Panel1.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 50)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Order Summary"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picCloseArrow
        '
        Me.picCloseArrow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.picCloseArrow.Image = CType(resources.GetObject("picCloseArrow.Image"), System.Drawing.Image)
        Me.picCloseArrow.Location = New System.Drawing.Point(255, -7)
        Me.picCloseArrow.Name = "picCloseArrow"
        Me.picCloseArrow.Size = New System.Drawing.Size(70, 70)
        Me.picCloseArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCloseArrow.TabIndex = 26
        Me.picCloseArrow.TabStop = False
        '
        'dgvOrderSummary
        '
        Me.dgvOrderSummary.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace
        Me.dgvOrderSummary.AllowUserToAddRows = False
        Me.dgvOrderSummary.AllowUserToDeleteRows = False
        Me.dgvOrderSummary.AllowUserToResizeColumns = False
        Me.dgvOrderSummary.AllowUserToResizeRows = False
        Me.dgvOrderSummary.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOrderSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderSummary.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvOrderSummary.GridColor = System.Drawing.SystemColors.MenuText
        Me.dgvOrderSummary.Location = New System.Drawing.Point(40, 90)
        Me.dgvOrderSummary.MultiSelect = False
        Me.dgvOrderSummary.Name = "dgvOrderSummary"
        Me.dgvOrderSummary.ReadOnly = True
        Me.dgvOrderSummary.RowHeadersVisible = False
        Me.dgvOrderSummary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvOrderSummary.RowTemplate.Height = 70
        Me.dgvOrderSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOrderSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderSummary.ShowCellToolTips = False
        Me.dgvOrderSummary.Size = New System.Drawing.Size(340, 430)
        Me.dgvOrderSummary.TabIndex = 24
        Me.dgvOrderSummary.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(40, 590)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(340, 50)
        Me.btnDelete.TabIndex = 23
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEdit.Location = New System.Drawing.Point(40, 530)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(340, 50)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit Item"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'tmrOrderSummarySlider
        '
        Me.tmrOrderSummarySlider.Interval = 5
        '
        'pnlOrderSumCaller
        '
        Me.pnlOrderSumCaller.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlOrderSumCaller.Controls.Add(Me.lblTax)
        Me.pnlOrderSumCaller.Controls.Add(Me.Label7)
        Me.pnlOrderSumCaller.Controls.Add(Me.lblSubtotal)
        Me.pnlOrderSumCaller.Controls.Add(Me.Label6)
        Me.pnlOrderSumCaller.Controls.Add(Me.lblNumItems)
        Me.pnlOrderSumCaller.Controls.Add(Me.Label4)
        Me.pnlOrderSumCaller.Location = New System.Drawing.Point(-1, 650)
        Me.pnlOrderSumCaller.Name = "pnlOrderSumCaller"
        Me.pnlOrderSumCaller.Size = New System.Drawing.Size(1280, 70)
        Me.pnlOrderSumCaller.TabIndex = 24
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTax.Location = New System.Drawing.Point(678, 17)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(130, 37)
        Me.lblTax.TabIndex = 5
        Me.lblTax.Text = "$0.00"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(610, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 37)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tax:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSubtotal.Location = New System.Drawing.Point(465, 17)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(140, 37)
        Me.lblSubtotal.TabIndex = 3
        Me.lblSubtotal.Text = "$0.00"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(331, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 37)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Subtotal:"
        '
        'lblNumItems
        '
        Me.lblNumItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblNumItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNumItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumItems.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNumItems.Location = New System.Drawing.Point(251, 17)
        Me.lblNumItems.Name = "lblNumItems"
        Me.lblNumItems.Size = New System.Drawing.Size(98, 37)
        Me.lblNumItems.TabIndex = 1
        Me.lblNumItems.Text = "0"
        Me.lblNumItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(96, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 37)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "# of Items:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picBack)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.picOrderSummary)
        Me.Panel2.Location = New System.Drawing.Point(-1, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 100)
        Me.Panel2.TabIndex = 26
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
        Me.picBack.TabIndex = 23
        Me.picBack.TabStop = False
        '
        'pnlKeyboard
        '
        Me.pnlKeyboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlKeyboard.Controls.Add(Me.btnDeleteSearch)
        Me.pnlKeyboard.Controls.Add(Me.btnSpace)
        Me.pnlKeyboard.Controls.Add(Me.picHide)
        Me.pnlKeyboard.Controls.Add(Me.btnHide)
        Me.pnlKeyboard.Controls.Add(Me.btnSearch)
        Me.pnlKeyboard.Controls.Add(Me.btnO)
        Me.pnlKeyboard.Controls.Add(Me.btnP)
        Me.pnlKeyboard.Controls.Add(Me.btnU)
        Me.pnlKeyboard.Controls.Add(Me.btnI)
        Me.pnlKeyboard.Controls.Add(Me.btnE)
        Me.pnlKeyboard.Controls.Add(Me.btnT)
        Me.pnlKeyboard.Controls.Add(Me.btnY)
        Me.pnlKeyboard.Controls.Add(Me.btnR)
        Me.pnlKeyboard.Controls.Add(Me.btnK)
        Me.pnlKeyboard.Controls.Add(Me.btnL)
        Me.pnlKeyboard.Controls.Add(Me.btnD)
        Me.pnlKeyboard.Controls.Add(Me.btnF)
        Me.pnlKeyboard.Controls.Add(Me.btnG)
        Me.pnlKeyboard.Controls.Add(Me.btnH)
        Me.pnlKeyboard.Controls.Add(Me.btnJ)
        Me.pnlKeyboard.Controls.Add(Me.btnC)
        Me.pnlKeyboard.Controls.Add(Me.btnV)
        Me.pnlKeyboard.Controls.Add(Me.btnB)
        Me.pnlKeyboard.Controls.Add(Me.btnN)
        Me.pnlKeyboard.Controls.Add(Me.btnM)
        Me.pnlKeyboard.Controls.Add(Me.btnW)
        Me.pnlKeyboard.Controls.Add(Me.btnS)
        Me.pnlKeyboard.Controls.Add(Me.btnX)
        Me.pnlKeyboard.Controls.Add(Me.btnZ)
        Me.pnlKeyboard.Controls.Add(Me.btnA)
        Me.pnlKeyboard.Controls.Add(Me.btnQ)
        Me.pnlKeyboard.Location = New System.Drawing.Point(-2, 710)
        Me.pnlKeyboard.Name = "pnlKeyboard"
        Me.pnlKeyboard.Size = New System.Drawing.Size(1282, 300)
        Me.pnlKeyboard.TabIndex = 27
        '
        'btnDeleteSearch
        '
        Me.btnDeleteSearch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeleteSearch.FlatAppearance.BorderSize = 0
        Me.btnDeleteSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnDeleteSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeleteSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteSearch.Location = New System.Drawing.Point(818, 149)
        Me.btnDeleteSearch.Name = "btnDeleteSearch"
        Me.btnDeleteSearch.Size = New System.Drawing.Size(140, 65)
        Me.btnDeleteSearch.TabIndex = 30
        Me.btnDeleteSearch.Text = "Delete"
        Me.btnDeleteSearch.UseVisualStyleBackColor = False
        '
        'btnSpace
        '
        Me.btnSpace.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSpace.FlatAppearance.BorderSize = 0
        Me.btnSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSpace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSpace.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSpace.Location = New System.Drawing.Point(412, 219)
        Me.btnSpace.Name = "btnSpace"
        Me.btnSpace.Size = New System.Drawing.Size(345, 65)
        Me.btnSpace.TabIndex = 29
        Me.btnSpace.UseVisualStyleBackColor = False
        '
        'picHide
        '
        Me.picHide.BackColor = System.Drawing.SystemColors.ControlLight
        Me.picHide.Enabled = False
        Me.picHide.Image = CType(resources.GetObject("picHide.Image"), System.Drawing.Image)
        Me.picHide.Location = New System.Drawing.Point(345, 223)
        Me.picHide.Name = "picHide"
        Me.picHide.Size = New System.Drawing.Size(57, 57)
        Me.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHide.TabIndex = 28
        Me.picHide.TabStop = False
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnHide.FlatAppearance.BorderSize = 0
        Me.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnHide.Location = New System.Drawing.Point(341, 219)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(65, 65)
        Me.btnHide.TabIndex = 27
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(763, 219)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(149, 65)
        Me.btnSearch.TabIndex = 26
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnO
        '
        Me.btnO.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnO.FlatAppearance.BorderSize = 0
        Me.btnO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnO.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnO.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnO.Location = New System.Drawing.Point(854, 6)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(65, 65)
        Me.btnO.TabIndex = 25
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = False
        '
        'btnP
        '
        Me.btnP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnP.FlatAppearance.BorderSize = 0
        Me.btnP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnP.Location = New System.Drawing.Point(925, 6)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(65, 65)
        Me.btnP.TabIndex = 24
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = False
        '
        'btnU
        '
        Me.btnU.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnU.FlatAppearance.BorderSize = 0
        Me.btnU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnU.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnU.Location = New System.Drawing.Point(712, 6)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(65, 65)
        Me.btnU.TabIndex = 23
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = False
        '
        'btnI
        '
        Me.btnI.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnI.FlatAppearance.BorderSize = 0
        Me.btnI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnI.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnI.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnI.Location = New System.Drawing.Point(783, 6)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(65, 65)
        Me.btnI.TabIndex = 22
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = False
        '
        'btnE
        '
        Me.btnE.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnE.FlatAppearance.BorderSize = 0
        Me.btnE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnE.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnE.Location = New System.Drawing.Point(428, 6)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(65, 65)
        Me.btnE.TabIndex = 21
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = False
        '
        'btnT
        '
        Me.btnT.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnT.FlatAppearance.BorderSize = 0
        Me.btnT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnT.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnT.Location = New System.Drawing.Point(570, 6)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(65, 65)
        Me.btnT.TabIndex = 20
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = False
        '
        'btnY
        '
        Me.btnY.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnY.FlatAppearance.BorderSize = 0
        Me.btnY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnY.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnY.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnY.Location = New System.Drawing.Point(641, 6)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(65, 65)
        Me.btnY.TabIndex = 19
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = False
        '
        'btnR
        '
        Me.btnR.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnR.FlatAppearance.BorderSize = 0
        Me.btnR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnR.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnR.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnR.Location = New System.Drawing.Point(499, 6)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(65, 65)
        Me.btnR.TabIndex = 18
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = False
        '
        'btnK
        '
        Me.btnK.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnK.FlatAppearance.BorderSize = 0
        Me.btnK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnK.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnK.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnK.Location = New System.Drawing.Point(800, 77)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(65, 65)
        Me.btnK.TabIndex = 17
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = False
        '
        'btnL
        '
        Me.btnL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnL.FlatAppearance.BorderSize = 0
        Me.btnL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnL.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnL.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnL.Location = New System.Drawing.Point(871, 77)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(65, 65)
        Me.btnL.TabIndex = 16
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnD.FlatAppearance.BorderSize = 0
        Me.btnD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnD.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnD.Location = New System.Drawing.Point(445, 77)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(65, 65)
        Me.btnD.TabIndex = 15
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = False
        '
        'btnF
        '
        Me.btnF.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnF.FlatAppearance.BorderSize = 0
        Me.btnF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnF.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnF.Location = New System.Drawing.Point(516, 77)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(65, 65)
        Me.btnF.TabIndex = 14
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = False
        '
        'btnG
        '
        Me.btnG.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnG.FlatAppearance.BorderSize = 0
        Me.btnG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnG.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnG.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnG.Location = New System.Drawing.Point(587, 77)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(65, 65)
        Me.btnG.TabIndex = 13
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = False
        '
        'btnH
        '
        Me.btnH.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnH.FlatAppearance.BorderSize = 0
        Me.btnH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnH.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnH.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnH.Location = New System.Drawing.Point(658, 77)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(65, 65)
        Me.btnH.TabIndex = 12
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = False
        '
        'btnJ
        '
        Me.btnJ.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnJ.FlatAppearance.BorderSize = 0
        Me.btnJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnJ.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnJ.Location = New System.Drawing.Point(729, 77)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(65, 65)
        Me.btnJ.TabIndex = 11
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnC.FlatAppearance.BorderSize = 0
        Me.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnC.Location = New System.Drawing.Point(463, 148)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(65, 65)
        Me.btnC.TabIndex = 10
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnV
        '
        Me.btnV.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnV.FlatAppearance.BorderSize = 0
        Me.btnV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnV.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnV.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnV.Location = New System.Drawing.Point(534, 148)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(65, 65)
        Me.btnV.TabIndex = 9
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnB.FlatAppearance.BorderSize = 0
        Me.btnB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnB.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnB.Location = New System.Drawing.Point(605, 148)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(65, 65)
        Me.btnB.TabIndex = 8
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btnN
        '
        Me.btnN.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnN.FlatAppearance.BorderSize = 0
        Me.btnN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnN.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnN.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnN.Location = New System.Drawing.Point(676, 148)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(65, 65)
        Me.btnN.TabIndex = 7
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = False
        '
        'btnM
        '
        Me.btnM.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnM.FlatAppearance.BorderSize = 0
        Me.btnM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnM.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnM.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnM.Location = New System.Drawing.Point(747, 148)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(65, 65)
        Me.btnM.TabIndex = 6
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = False
        '
        'btnW
        '
        Me.btnW.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnW.FlatAppearance.BorderSize = 0
        Me.btnW.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnW.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnW.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnW.Location = New System.Drawing.Point(357, 6)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(65, 65)
        Me.btnW.TabIndex = 5
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = False
        '
        'btnS
        '
        Me.btnS.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnS.FlatAppearance.BorderSize = 0
        Me.btnS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnS.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnS.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnS.Location = New System.Drawing.Point(374, 77)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(65, 65)
        Me.btnS.TabIndex = 4
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = False
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnX.FlatAppearance.BorderSize = 0
        Me.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnX.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnX.Location = New System.Drawing.Point(392, 148)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(65, 65)
        Me.btnX.TabIndex = 3
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'btnZ
        '
        Me.btnZ.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnZ.FlatAppearance.BorderSize = 0
        Me.btnZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnZ.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnZ.Location = New System.Drawing.Point(321, 148)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(65, 65)
        Me.btnZ.TabIndex = 2
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = False
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnA.FlatAppearance.BorderSize = 0
        Me.btnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnA.Location = New System.Drawing.Point(303, 77)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(65, 65)
        Me.btnA.TabIndex = 1
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'btnQ
        '
        Me.btnQ.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnQ.FlatAppearance.BorderSize = 0
        Me.btnQ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnQ.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnQ.Location = New System.Drawing.Point(286, 6)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(65, 65)
        Me.btnQ.TabIndex = 0
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = False
        '
        'tmrKeyboard
        '
        Me.tmrKeyboard.Interval = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(605, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(713, 722)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'picMeme
        '
        Me.picMeme.Image = CType(resources.GetObject("picMeme.Image"), System.Drawing.Image)
        Me.picMeme.Location = New System.Drawing.Point(1280, 169)
        Me.picMeme.Name = "picMeme"
        Me.picMeme.Size = New System.Drawing.Size(448, 381)
        Me.picMeme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMeme.TabIndex = 30
        Me.picMeme.TabStop = False
        Me.picMeme.Visible = False
        '
        'NewCustomerOrderDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.picMeme)
        Me.Controls.Add(Me.pnlKeyboard)
        Me.Controls.Add(Me.pnlOrderSummary)
        Me.Controls.Add(Me.pnlOrderSumCaller)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCategories)
        Me.Controls.Add(Me.dgvMenuItems)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NewCustomerOrderDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.AzureTBDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AzureTBDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenuItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOrderSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOrderSummary.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.picCloseArrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOrderSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOrderSumCaller.ResumeLayout(False)
        Me.pnlOrderSumCaller.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKeyboard.ResumeLayout(False)
        CType(Me.picHide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMeme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AzureTBDB As AzureTBDB
    Friend WithEvents AzureTBDBBindingSource As BindingSource
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvMenuItems As DataGridView
    Friend WithEvents dgvCategories As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents picOrderSummary As PictureBox
    Friend WithEvents pnlOrderSummary As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvOrderSummary As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents tmrOrderSummarySlider As Timer
    Friend WithEvents picSearch As PictureBox
    Friend WithEvents picCloseArrow As PictureBox
    Friend WithEvents pnlOrderSumCaller As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNumItems As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pnlKeyboard As Panel
    Friend WithEvents btnDeleteSearch As Button
    Friend WithEvents btnSpace As Button
    Friend WithEvents picHide As PictureBox
    Friend WithEvents btnHide As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnY As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnM As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnZ As Button
    Friend WithEvents btnA As Button
    Friend WithEvents btnQ As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents tmrKeyboard As Timer
    Friend WithEvents picBack As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picMeme As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCheckout As Button
End Class
