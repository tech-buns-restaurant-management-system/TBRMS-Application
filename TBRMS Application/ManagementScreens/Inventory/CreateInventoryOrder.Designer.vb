﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateInventoryOrder
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.dgvOrderDetails = New System.Windows.Forms.DataGridView()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMessage.Location = New System.Drawing.Point(-1, 20)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(440, 70)
        Me.lblMessage.TabIndex = 41
        Me.lblMessage.Text = "Create a New Inventory Order"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage.Visible = False
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSaveChanges.FlatAppearance.BorderSize = 0
        Me.btnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveChanges.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveChanges.Location = New System.Drawing.Point(19, 495)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(400, 50)
        Me.btnSaveChanges.TabIndex = 44
        Me.btnSaveChanges.TabStop = False
        Me.btnSaveChanges.Text = "Submit Order"
        Me.btnSaveChanges.UseVisualStyleBackColor = False
        Me.btnSaveChanges.Visible = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAddItem.FlatAppearance.BorderSize = 0
        Me.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(19, 435)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(400, 50)
        Me.btnAddItem.TabIndex = 45
        Me.btnAddItem.TabStop = False
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        Me.btnAddItem.Visible = False
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.AllowUserToAddRows = False
        Me.dgvOrderDetails.AllowUserToDeleteRows = False
        Me.dgvOrderDetails.AllowUserToResizeColumns = False
        Me.dgvOrderDetails.AllowUserToResizeRows = False
        Me.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOrderDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrderDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrderDetails.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvOrderDetails.Location = New System.Drawing.Point(19, 110)
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.RowHeadersVisible = False
        Me.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrderDetails.Size = New System.Drawing.Size(400, 310)
        Me.dgvOrderDetails.TabIndex = 46
        Me.dgvOrderDetails.Visible = False
        '
        'CreateInventoryOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(438, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvOrderDetails)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CreateInventoryOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents dgvOrderDetails As DataGridView
End Class
