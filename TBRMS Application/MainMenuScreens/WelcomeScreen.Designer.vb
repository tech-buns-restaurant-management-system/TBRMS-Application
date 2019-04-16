<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeScreen))
        Me.btnCustomerOrder = New System.Windows.Forms.Button()
        Me.btnFOH = New System.Windows.Forms.Button()
        Me.btnManagement = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCustomerOrder
        '
        Me.btnCustomerOrder.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCustomerOrder.FlatAppearance.BorderSize = 0
        Me.btnCustomerOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnCustomerOrder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomerOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCustomerOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCustomerOrder.Location = New System.Drawing.Point(79, 390)
        Me.btnCustomerOrder.Name = "btnCustomerOrder"
        Me.btnCustomerOrder.Size = New System.Drawing.Size(320, 180)
        Me.btnCustomerOrder.TabIndex = 0
        Me.btnCustomerOrder.Text = "Customer Mode"
        Me.btnCustomerOrder.UseVisualStyleBackColor = False
        '
        'btnFOH
        '
        Me.btnFOH.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFOH.FlatAppearance.BorderSize = 0
        Me.btnFOH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnFOH.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnFOH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFOH.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnFOH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnFOH.Location = New System.Drawing.Point(479, 391)
        Me.btnFOH.Name = "btnFOH"
        Me.btnFOH.Size = New System.Drawing.Size(320, 180)
        Me.btnFOH.TabIndex = 1
        Me.btnFOH.Text = "Front of House Mode"
        Me.btnFOH.UseVisualStyleBackColor = False
        '
        'btnManagement
        '
        Me.btnManagement.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnManagement.FlatAppearance.BorderSize = 0
        Me.btnManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnManagement.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnManagement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnManagement.Location = New System.Drawing.Point(879, 390)
        Me.btnManagement.Name = "btnManagement"
        Me.btnManagement.Size = New System.Drawing.Size(320, 180)
        Me.btnManagement.TabIndex = 2
        Me.btnManagement.Text = "Manangement Mode"
        Me.btnManagement.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(256, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(769, 110)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome to Tech Buns Restaurant" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management System!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(388, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(504, 42)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Please Select a Menu Below."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel2.Controls.Add(Me.picBack)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-1, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 210)
        Me.Panel2.TabIndex = 27
        '
        'picBack
        '
        Me.picBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(78, 55)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(100, 100)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBack.TabIndex = 24
        Me.picBack.TabStop = False
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnManagement)
        Me.Controls.Add(Me.btnFOH)
        Me.Controls.Add(Me.btnCustomerOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "WelcomeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomerOrder As Button
    Friend WithEvents btnFOH As Button
    Friend WithEvents btnManagement As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picBack As PictureBox
End Class
