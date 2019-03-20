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
        Me.btnCustomerOrder = New System.Windows.Forms.Button()
        Me.btnFOH = New System.Windows.Forms.Button()
        Me.btnManagement = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCustomerOrder
        '
        Me.btnCustomerOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnCustomerOrder.Location = New System.Drawing.Point(32, 184)
        Me.btnCustomerOrder.Name = "btnCustomerOrder"
        Me.btnCustomerOrder.Size = New System.Drawing.Size(168, 83)
        Me.btnCustomerOrder.TabIndex = 0
        Me.btnCustomerOrder.Text = "Customer Order"
        Me.btnCustomerOrder.UseVisualStyleBackColor = True
        '
        'btnFOH
        '
        Me.btnFOH.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnFOH.Location = New System.Drawing.Point(257, 184)
        Me.btnFOH.Name = "btnFOH"
        Me.btnFOH.Size = New System.Drawing.Size(168, 83)
        Me.btnFOH.TabIndex = 1
        Me.btnFOH.Text = "Front of House Staff"
        Me.btnFOH.UseVisualStyleBackColor = True
        '
        'btnManagement
        '
        Me.btnManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnManagement.Location = New System.Drawing.Point(469, 184)
        Me.btnManagement.Name = "btnManagement"
        Me.btnManagement.Size = New System.Drawing.Size(168, 83)
        Me.btnManagement.TabIndex = 2
        Me.btnManagement.Text = "Manangement"
        Me.btnManagement.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(203, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome to Top Buns!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(156, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Please select an option below."
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 369)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnManagement)
        Me.Controls.Add(Me.btnFOH)
        Me.Controls.Add(Me.btnCustomerOrder)
        Me.Name = "WelcomeScreen"
        Me.Text = "WelcomeScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCustomerOrder As Button
    Friend WithEvents btnFOH As Button
    Friend WithEvents btnManagement As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
