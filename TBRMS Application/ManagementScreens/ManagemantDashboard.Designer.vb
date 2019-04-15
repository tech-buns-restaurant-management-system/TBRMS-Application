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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagemantDashboard))
        Me.AzureTBDB = New TBRMS_Application.AzureTBDB()
        Me.AzureTBDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.picOrderSummary = New System.Windows.Forms.PictureBox()
        Me.pnlOrderSummary = New System.Windows.Forms.Panel()
        Me.picCloseArrow = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOpt1 = New System.Windows.Forms.Button()
        Me.btnOpt2 = New System.Windows.Forms.Button()
        Me.btnOpt3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AzureTBDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AzureTBDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picOrderSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrderSummary.SuspendLayout()
        CType(Me.picCloseArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.AzureTBDBBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(319, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 480)
        Me.DataGridView1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.picOrderSummary)
        Me.Panel2.Location = New System.Drawing.Point(-1, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 100)
        Me.Panel2.TabIndex = 31
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
        'picOrderSummary
        '
        Me.picOrderSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.picOrderSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picOrderSummary.Image = CType(resources.GetObject("picOrderSummary.Image"), System.Drawing.Image)
        Me.picOrderSummary.Location = New System.Drawing.Point(30, 0)
        Me.picOrderSummary.Name = "picOrderSummary"
        Me.picOrderSummary.Size = New System.Drawing.Size(100, 100)
        Me.picOrderSummary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrderSummary.TabIndex = 22
        Me.picOrderSummary.TabStop = False
        '
        'pnlOrderSummary
        '
        Me.pnlOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOrderSummary.Controls.Add(Me.picCloseArrow)
        Me.pnlOrderSummary.Controls.Add(Me.btnMenu)
        Me.pnlOrderSummary.Controls.Add(Me.Button3)
        Me.pnlOrderSummary.Controls.Add(Me.Button2)
        Me.pnlOrderSummary.Controls.Add(Me.Button1)
        Me.pnlOrderSummary.Location = New System.Drawing.Point(1270, -1)
        Me.pnlOrderSummary.Name = "pnlOrderSummary"
        Me.pnlOrderSummary.Size = New System.Drawing.Size(420, 720)
        Me.pnlOrderSummary.TabIndex = 32
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
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMenu.Location = New System.Drawing.Point(30, 565)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(360, 140)
        Me.btnMenu.TabIndex = 32
        Me.btnMenu.Text = "Menu View"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(30, 410)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(360, 140)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Supplier View"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(30, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(360, 140)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Inventory View"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(30, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(360, 140)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Order View"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnOpt1)
        Me.Panel1.Controls.Add(Me.btnOpt2)
        Me.Panel1.Controls.Add(Me.btnOpt3)
        Me.Panel1.Location = New System.Drawing.Point(319, 639)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 80)
        Me.Panel1.TabIndex = 33
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
        Me.btnOpt1.Text = "Option 1"
        Me.btnOpt1.UseVisualStyleBackColor = False
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
        Me.btnOpt3.Text = "Option 3"
        Me.btnOpt3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1150, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'ManagemantDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlOrderSummary)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManagemantDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.AzureTBDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AzureTBDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picOrderSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOrderSummary.ResumeLayout(False)
        CType(Me.picCloseArrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AzureTBDB As AzureTBDB
    Friend WithEvents AzureTBDBBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents picOrderSummary As PictureBox
    Friend WithEvents pnlOrderSummary As Panel
    Friend WithEvents btnMenu As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents picCloseArrow As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOpt1 As Button
    Friend WithEvents btnOpt2 As Button
    Friend WithEvents btnOpt3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
