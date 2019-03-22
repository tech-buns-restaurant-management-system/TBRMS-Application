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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCustomerOrder
        '
        Me.btnCustomerOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCustomerOrder.Location = New System.Drawing.Point(173, 381)
        Me.btnCustomerOrder.Name = "btnCustomerOrder"
        Me.btnCustomerOrder.Size = New System.Drawing.Size(307, 179)
        Me.btnCustomerOrder.TabIndex = 0
        Me.btnCustomerOrder.Text = "Customer Order"
        Me.btnCustomerOrder.UseVisualStyleBackColor = True
        '
        'btnFOH
        '
        Me.btnFOH.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnFOH.Location = New System.Drawing.Point(486, 381)
        Me.btnFOH.Name = "btnFOH"
        Me.btnFOH.Size = New System.Drawing.Size(307, 179)
        Me.btnFOH.TabIndex = 1
        Me.btnFOH.Text = "Front of House Staff"
        Me.btnFOH.UseVisualStyleBackColor = True
        '
        'btnManagement
        '
        Me.btnManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnManagement.Location = New System.Drawing.Point(799, 381)
        Me.btnManagement.Name = "btnManagement"
        Me.btnManagement.Size = New System.Drawing.Size(307, 179)
        Me.btnManagement.TabIndex = 2
        Me.btnManagement.Text = "Manangement"
        Me.btnManagement.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(680, 73)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome to Top Buns!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(899, 73)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Please select an option below."
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(36, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(32, 32)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(80, 80)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.TabStop = False
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnManagement)
        Me.Controls.Add(Me.btnFOH)
        Me.Controls.Add(Me.btnCustomerOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "WelcomeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCustomerOrder As Button
    Friend WithEvents btnFOH As Button
    Friend WithEvents btnManagement As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogOut As Button
End Class
