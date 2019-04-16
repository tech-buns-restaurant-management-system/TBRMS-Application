<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomizeItem
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.flpCustom = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlIng1 = New System.Windows.Forms.Panel()
        Me.lblIng1Amount = New System.Windows.Forms.Label()
        Me.btnLessIng1 = New System.Windows.Forms.Button()
        Me.btnMoreIng1 = New System.Windows.Forms.Button()
        Me.lblIng1 = New System.Windows.Forms.Label()
        Me.pnlIng2 = New System.Windows.Forms.Panel()
        Me.lblIng2Amount = New System.Windows.Forms.Label()
        Me.btnLessIng2 = New System.Windows.Forms.Button()
        Me.btnMoreIng2 = New System.Windows.Forms.Button()
        Me.lblIng2 = New System.Windows.Forms.Label()
        Me.pnlIng3 = New System.Windows.Forms.Panel()
        Me.lblIng3Amount = New System.Windows.Forms.Label()
        Me.btnLessIng3 = New System.Windows.Forms.Button()
        Me.btnMoreIng3 = New System.Windows.Forms.Button()
        Me.lblIng3 = New System.Windows.Forms.Label()
        Me.pnlIng4 = New System.Windows.Forms.Panel()
        Me.lblIng4Amount = New System.Windows.Forms.Label()
        Me.btnLessIng4 = New System.Windows.Forms.Button()
        Me.btnMoreIng4 = New System.Windows.Forms.Button()
        Me.lblIng4 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.flpCustom.SuspendLayout()
        Me.pnlIng1.SuspendLayout()
        Me.pnlIng2.SuspendLayout()
        Me.pnlIng3.SuspendLayout()
        Me.pnlIng4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(30, 530)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(440, 50)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Add Item"
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(74, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 39)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Customize Your Item!"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblItemName)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Location = New System.Drawing.Point(-1, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(500, 120)
        Me.pnlHeader.TabIndex = 25
        Me.pnlHeader.Visible = False
        '
        'lblItemName
        '
        Me.lblItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblItemName.Location = New System.Drawing.Point(80, 53)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(341, 61)
        Me.lblItemName.TabIndex = 25
        Me.lblItemName.Text = "Item Name"
        Me.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(30, 470)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(440, 50)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'flpCustom
        '
        Me.flpCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flpCustom.Controls.Add(Me.pnlIng1)
        Me.flpCustom.Controls.Add(Me.pnlIng2)
        Me.flpCustom.Controls.Add(Me.pnlIng3)
        Me.flpCustom.Controls.Add(Me.pnlIng4)
        Me.flpCustom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpCustom.Location = New System.Drawing.Point(30, 140)
        Me.flpCustom.Name = "flpCustom"
        Me.flpCustom.Size = New System.Drawing.Size(440, 310)
        Me.flpCustom.TabIndex = 28
        Me.flpCustom.Visible = False
        '
        'pnlIng1
        '
        Me.pnlIng1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlIng1.Controls.Add(Me.lblIng1Amount)
        Me.pnlIng1.Controls.Add(Me.btnLessIng1)
        Me.pnlIng1.Controls.Add(Me.btnMoreIng1)
        Me.pnlIng1.Controls.Add(Me.lblIng1)
        Me.pnlIng1.Location = New System.Drawing.Point(3, 3)
        Me.pnlIng1.Name = "pnlIng1"
        Me.pnlIng1.Size = New System.Drawing.Size(434, 71)
        Me.pnlIng1.TabIndex = 0
        '
        'lblIng1Amount
        '
        Me.lblIng1Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIng1Amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIng1Amount.Location = New System.Drawing.Point(121, 23)
        Me.lblIng1Amount.Name = "lblIng1Amount"
        Me.lblIng1Amount.Size = New System.Drawing.Size(106, 25)
        Me.lblIng1Amount.TabIndex = 3
        Me.lblIng1Amount.Text = "Regular"
        Me.lblIng1Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLessIng1
        '
        Me.btnLessIng1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLessIng1.FlatAppearance.BorderSize = 0
        Me.btnLessIng1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnLessIng1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLessIng1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLessIng1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLessIng1.Location = New System.Drawing.Point(10, 10)
        Me.btnLessIng1.Name = "btnLessIng1"
        Me.btnLessIng1.Size = New System.Drawing.Size(50, 50)
        Me.btnLessIng1.TabIndex = 2
        Me.btnLessIng1.Text = "-"
        Me.btnLessIng1.UseVisualStyleBackColor = False
        '
        'btnMoreIng1
        '
        Me.btnMoreIng1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMoreIng1.FlatAppearance.BorderSize = 0
        Me.btnMoreIng1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnMoreIng1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMoreIng1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoreIng1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoreIng1.Location = New System.Drawing.Point(65, 10)
        Me.btnMoreIng1.Name = "btnMoreIng1"
        Me.btnMoreIng1.Size = New System.Drawing.Size(50, 50)
        Me.btnMoreIng1.TabIndex = 1
        Me.btnMoreIng1.Text = "+"
        Me.btnMoreIng1.UseVisualStyleBackColor = False
        '
        'lblIng1
        '
        Me.lblIng1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIng1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIng1.Location = New System.Drawing.Point(233, 0)
        Me.lblIng1.Name = "lblIng1"
        Me.lblIng1.Size = New System.Drawing.Size(199, 71)
        Me.lblIng1.TabIndex = 0
        Me.lblIng1.Text = "Stout-Caramelized Onions"
        Me.lblIng1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlIng2
        '
        Me.pnlIng2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlIng2.Controls.Add(Me.lblIng2Amount)
        Me.pnlIng2.Controls.Add(Me.btnLessIng2)
        Me.pnlIng2.Controls.Add(Me.btnMoreIng2)
        Me.pnlIng2.Controls.Add(Me.lblIng2)
        Me.pnlIng2.Location = New System.Drawing.Point(3, 80)
        Me.pnlIng2.Name = "pnlIng2"
        Me.pnlIng2.Size = New System.Drawing.Size(434, 71)
        Me.pnlIng2.TabIndex = 1
        '
        'lblIng2Amount
        '
        Me.lblIng2Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIng2Amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIng2Amount.Location = New System.Drawing.Point(121, 23)
        Me.lblIng2Amount.Name = "lblIng2Amount"
        Me.lblIng2Amount.Size = New System.Drawing.Size(106, 25)
        Me.lblIng2Amount.TabIndex = 4
        Me.lblIng2Amount.Text = "Regular"
        Me.lblIng2Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLessIng2
        '
        Me.btnLessIng2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLessIng2.FlatAppearance.BorderSize = 0
        Me.btnLessIng2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnLessIng2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLessIng2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLessIng2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLessIng2.Location = New System.Drawing.Point(10, 10)
        Me.btnLessIng2.Name = "btnLessIng2"
        Me.btnLessIng2.Size = New System.Drawing.Size(50, 50)
        Me.btnLessIng2.TabIndex = 2
        Me.btnLessIng2.Text = "-"
        Me.btnLessIng2.UseVisualStyleBackColor = False
        '
        'btnMoreIng2
        '
        Me.btnMoreIng2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMoreIng2.FlatAppearance.BorderSize = 0
        Me.btnMoreIng2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnMoreIng2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMoreIng2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoreIng2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoreIng2.Location = New System.Drawing.Point(65, 10)
        Me.btnMoreIng2.Name = "btnMoreIng2"
        Me.btnMoreIng2.Size = New System.Drawing.Size(50, 50)
        Me.btnMoreIng2.TabIndex = 1
        Me.btnMoreIng2.Text = "+"
        Me.btnMoreIng2.UseVisualStyleBackColor = False
        '
        'lblIng2
        '
        Me.lblIng2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIng2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIng2.Location = New System.Drawing.Point(233, 0)
        Me.lblIng2.Name = "lblIng2"
        Me.lblIng2.Size = New System.Drawing.Size(199, 71)
        Me.lblIng2.TabIndex = 3
        Me.lblIng2.Text = "Stout-Caramelized Onions"
        Me.lblIng2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlIng3
        '
        Me.pnlIng3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlIng3.Controls.Add(Me.lblIng3Amount)
        Me.pnlIng3.Controls.Add(Me.btnLessIng3)
        Me.pnlIng3.Controls.Add(Me.btnMoreIng3)
        Me.pnlIng3.Controls.Add(Me.lblIng3)
        Me.pnlIng3.Location = New System.Drawing.Point(3, 157)
        Me.pnlIng3.Name = "pnlIng3"
        Me.pnlIng3.Size = New System.Drawing.Size(434, 71)
        Me.pnlIng3.TabIndex = 3
        '
        'lblIng3Amount
        '
        Me.lblIng3Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIng3Amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIng3Amount.Location = New System.Drawing.Point(121, 23)
        Me.lblIng3Amount.Name = "lblIng3Amount"
        Me.lblIng3Amount.Size = New System.Drawing.Size(106, 25)
        Me.lblIng3Amount.TabIndex = 4
        Me.lblIng3Amount.Text = "Regular"
        Me.lblIng3Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLessIng3
        '
        Me.btnLessIng3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLessIng3.FlatAppearance.BorderSize = 0
        Me.btnLessIng3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnLessIng3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLessIng3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLessIng3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLessIng3.Location = New System.Drawing.Point(10, 10)
        Me.btnLessIng3.Name = "btnLessIng3"
        Me.btnLessIng3.Size = New System.Drawing.Size(50, 50)
        Me.btnLessIng3.TabIndex = 2
        Me.btnLessIng3.Text = "-"
        Me.btnLessIng3.UseVisualStyleBackColor = False
        '
        'btnMoreIng3
        '
        Me.btnMoreIng3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMoreIng3.FlatAppearance.BorderSize = 0
        Me.btnMoreIng3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnMoreIng3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMoreIng3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoreIng3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoreIng3.Location = New System.Drawing.Point(65, 10)
        Me.btnMoreIng3.Name = "btnMoreIng3"
        Me.btnMoreIng3.Size = New System.Drawing.Size(50, 50)
        Me.btnMoreIng3.TabIndex = 1
        Me.btnMoreIng3.Text = "+"
        Me.btnMoreIng3.UseVisualStyleBackColor = False
        '
        'lblIng3
        '
        Me.lblIng3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIng3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIng3.Location = New System.Drawing.Point(233, 0)
        Me.lblIng3.Name = "lblIng3"
        Me.lblIng3.Size = New System.Drawing.Size(199, 71)
        Me.lblIng3.TabIndex = 3
        Me.lblIng3.Text = "Stout-Caramelized Onions"
        Me.lblIng3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlIng4
        '
        Me.pnlIng4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlIng4.Controls.Add(Me.lblIng4Amount)
        Me.pnlIng4.Controls.Add(Me.btnLessIng4)
        Me.pnlIng4.Controls.Add(Me.btnMoreIng4)
        Me.pnlIng4.Controls.Add(Me.lblIng4)
        Me.pnlIng4.Location = New System.Drawing.Point(3, 234)
        Me.pnlIng4.Name = "pnlIng4"
        Me.pnlIng4.Size = New System.Drawing.Size(434, 71)
        Me.pnlIng4.TabIndex = 3
        '
        'lblIng4Amount
        '
        Me.lblIng4Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIng4Amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIng4Amount.Location = New System.Drawing.Point(121, 23)
        Me.lblIng4Amount.Name = "lblIng4Amount"
        Me.lblIng4Amount.Size = New System.Drawing.Size(106, 25)
        Me.lblIng4Amount.TabIndex = 4
        Me.lblIng4Amount.Text = "Regular"
        Me.lblIng4Amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLessIng4
        '
        Me.btnLessIng4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLessIng4.FlatAppearance.BorderSize = 0
        Me.btnLessIng4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnLessIng4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLessIng4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLessIng4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLessIng4.Location = New System.Drawing.Point(10, 10)
        Me.btnLessIng4.Name = "btnLessIng4"
        Me.btnLessIng4.Size = New System.Drawing.Size(50, 50)
        Me.btnLessIng4.TabIndex = 2
        Me.btnLessIng4.Text = "-"
        Me.btnLessIng4.UseVisualStyleBackColor = False
        '
        'btnMoreIng4
        '
        Me.btnMoreIng4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMoreIng4.FlatAppearance.BorderSize = 0
        Me.btnMoreIng4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnMoreIng4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnMoreIng4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoreIng4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoreIng4.Location = New System.Drawing.Point(65, 10)
        Me.btnMoreIng4.Name = "btnMoreIng4"
        Me.btnMoreIng4.Size = New System.Drawing.Size(50, 50)
        Me.btnMoreIng4.TabIndex = 1
        Me.btnMoreIng4.Text = "+"
        Me.btnMoreIng4.UseVisualStyleBackColor = False
        '
        'lblIng4
        '
        Me.lblIng4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIng4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblIng4.Location = New System.Drawing.Point(233, 0)
        Me.lblIng4.Name = "lblIng4"
        Me.lblIng4.Size = New System.Drawing.Size(199, 71)
        Me.lblIng4.TabIndex = 3
        Me.lblIng4.Text = "Stout-Caramelized Onions"
        Me.lblIng4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomizeItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(498, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.flpCustom)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.btnSave)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CustomizeItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.flpCustom.ResumeLayout(False)
        Me.pnlIng1.ResumeLayout(False)
        Me.pnlIng2.ResumeLayout(False)
        Me.pnlIng3.ResumeLayout(False)
        Me.pnlIng4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblItemName As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents flpCustom As FlowLayoutPanel
    Friend WithEvents pnlIng1 As Panel
    Friend WithEvents lblIng1Amount As Label
    Friend WithEvents btnLessIng1 As Button
    Friend WithEvents btnMoreIng1 As Button
    Friend WithEvents lblIng1 As Label
    Friend WithEvents pnlIng2 As Panel
    Friend WithEvents lblIng2Amount As Label
    Friend WithEvents btnLessIng2 As Button
    Friend WithEvents btnMoreIng2 As Button
    Friend WithEvents lblIng2 As Label
    Friend WithEvents pnlIng3 As Panel
    Friend WithEvents lblIng3Amount As Label
    Friend WithEvents btnLessIng3 As Button
    Friend WithEvents btnMoreIng3 As Button
    Friend WithEvents lblIng3 As Label
    Friend WithEvents pnlIng4 As Panel
    Friend WithEvents lblIng4Amount As Label
    Friend WithEvents btnLessIng4 As Button
    Friend WithEvents btnMoreIng4 As Button
    Friend WithEvents lblIng4 As Label
End Class
