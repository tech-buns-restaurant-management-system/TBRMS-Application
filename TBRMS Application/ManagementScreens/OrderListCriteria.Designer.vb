<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderListCriteria
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
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpStart
        '
        Me.dtpStart.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.dtpStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dtpStart.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dtpStart.CustomFormat = "yyyy-MM-dd"
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(170, 90)
        Me.dtpStart.MaxDate = New Date(2019, 4, 17, 15, 56, 29, 0)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(119, 26)
        Me.dtpStart.TabIndex = 1
        Me.dtpStart.TabStop = False
        Me.dtpStart.Value = New Date(2019, 4, 17, 0, 0, 0, 0)
        Me.dtpStart.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMessage.Location = New System.Drawing.Point(-1, 10)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(340, 70)
        Me.lblMessage.TabIndex = 36
        Me.lblMessage.Text = "Select a Date Range"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMessage.Visible = False
        '
        'dtpEnd
        '
        Me.dtpEnd.CalendarMonthBackground = System.Drawing.SystemColors.ControlLightLight
        Me.dtpEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dtpEnd.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dtpEnd.CustomFormat = "yyyy-MM-dd"
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(170, 122)
        Me.dtpEnd.MaxDate = New Date(2019, 4, 17, 15, 56, 29, 0)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(119, 26)
        Me.dtpEnd.TabIndex = 37
        Me.dtpEnd.TabStop = False
        Me.dtpEnd.Value = New Date(2019, 4, 17, 0, 0, 0, 0)
        Me.dtpEnd.Visible = False
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblStart.Location = New System.Drawing.Point(49, 90)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(115, 26)
        Me.lblStart.TabIndex = 38
        Me.lblStart.Text = "Start Date:"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblStart.Visible = False
        '
        'lblEnd
        '
        Me.lblEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblEnd.Location = New System.Drawing.Point(49, 122)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(115, 26)
        Me.lblEnd.TabIndex = 39
        Me.lblEnd.Text = "End Date:"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblEnd.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(179, 158)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(140, 50)
        Me.btnCancel.TabIndex = 42
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        Me.btnCancel.Visible = False
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnContinue.FlatAppearance.BorderSize = 0
        Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(19, 158)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(140, 50)
        Me.btnContinue.TabIndex = 41
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        Me.btnContinue.Visible = False
        '
        'OrderListCriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(338, 218)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.dtpStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "OrderListCriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents lblMessage As Label
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents lblStart As Label
    Friend WithEvents lblEnd As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnContinue As Button
End Class
