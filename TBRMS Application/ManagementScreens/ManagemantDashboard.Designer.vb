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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.picCloseArrow = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.AzureTBDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AzureTBDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picOrderSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOrderSummary.SuspendLayout()
        CType(Me.picCloseArrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.DataGridView1.Location = New System.Drawing.Point(388, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(639, 548)
        Me.DataGridView1.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.picOrderSummary)
        Me.Panel2.Location = New System.Drawing.Point(-1, 12)
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
        Me.Label8.Location = New System.Drawing.Point(253, 19)
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
        Me.picOrderSummary.Location = New System.Drawing.Point(67, 0)
        Me.picOrderSummary.Name = "picOrderSummary"
        Me.picOrderSummary.Size = New System.Drawing.Size(100, 100)
        Me.picOrderSummary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOrderSummary.TabIndex = 22
        Me.picOrderSummary.TabStop = False
        '
        'pnlOrderSummary
        '
        Me.pnlOrderSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlOrderSummary.Controls.Add(Me.picCloseArrow)
        Me.pnlOrderSummary.Controls.Add(Me.Button4)
        Me.pnlOrderSummary.Controls.Add(Me.Button3)
        Me.pnlOrderSummary.Controls.Add(Me.Button2)
        Me.pnlOrderSummary.Controls.Add(Me.Button1)
        Me.pnlOrderSummary.Location = New System.Drawing.Point(-1, -2)
        Me.pnlOrderSummary.Name = "pnlOrderSummary"
        Me.pnlOrderSummary.Size = New System.Drawing.Size(383, 719)
        Me.pnlOrderSummary.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(378, 152)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Order View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(378, 152)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Inventory View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 402)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(378, 152)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Supplier View"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(3, 560)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(378, 152)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Menu View"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'picCloseArrow
        '
        Me.picCloseArrow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.picCloseArrow.Image = CType(resources.GetObject("picCloseArrow.Image"), System.Drawing.Image)
        Me.picCloseArrow.Location = New System.Drawing.Point(3, 3)
        Me.picCloseArrow.Name = "picCloseArrow"
        Me.picCloseArrow.Size = New System.Drawing.Size(76, 77)
        Me.picCloseArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCloseArrow.TabIndex = 33
        Me.picCloseArrow.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Location = New System.Drawing.Point(388, 664)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 55)
        Me.Panel1.TabIndex = 33
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(429, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(203, 38)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Option 3"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(220, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(203, 38)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Option 2"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(3, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(211, 38)
        Me.Button7.TabIndex = 33
        Me.Button7.Text = "Option 1"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ManagemantDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlOrderSummary)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AzureTBDB As AzureTBDB
    Friend WithEvents AzureTBDBBindingSource As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents picOrderSummary As PictureBox
    Friend WithEvents pnlOrderSummary As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents picCloseArrow As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
