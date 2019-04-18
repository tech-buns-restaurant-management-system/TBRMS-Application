<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvOrderDetails = New System.Windows.Forms.DataGridView()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeading = New System.Windows.Forms.Label()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.AllowUserToAddRows = False
        Me.dgvOrderDetails.AllowUserToDeleteRows = False
        Me.dgvOrderDetails.AllowUserToResizeColumns = False
        Me.dgvOrderDetails.AllowUserToResizeRows = False
        Me.dgvOrderDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderDetails.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrderDetails.Location = New System.Drawing.Point(19, 110)
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.ReadOnly = True
        Me.dgvOrderDetails.RowHeadersVisible = False
        Me.dgvOrderDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOrderDetails.Size = New System.Drawing.Size(360, 310)
        Me.dgvOrderDetails.TabIndex = 0
        Me.dgvOrderDetails.Visible = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnContinue.FlatAppearance.BorderSize = 0
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(19, 435)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(360, 50)
        Me.btnContinue.TabIndex = 33
        Me.btnContinue.Text = "Dismiss"
        Me.btnContinue.UseVisualStyleBackColor = False
        Me.btnContinue.Visible = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblHeading)
        Me.pnlHeader.Location = New System.Drawing.Point(-1, 15)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(400, 80)
        Me.pnlHeader.TabIndex = 34
        Me.pnlHeader.Visible = False
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHeading.Location = New System.Drawing.Point(0, 15)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(400, 50)
        Me.lblHeading.TabIndex = 24
        Me.lblHeading.Text = "Order Details"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(398, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.dgvOrderDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "OrderDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvOrderDetails As DataGridView
    Friend WithEvents btnContinue As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeading As Label
End Class
