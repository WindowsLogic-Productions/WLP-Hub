<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sssecurity
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sssecurity))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogOffButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SystemPowerButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TaskMgrButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChangePasswrdButton = New System.Windows.Forms.Button()
        Me.LockPCButton = New System.Windows.Forms.Button()
        Me.DateTime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 53)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ss.My.Resources.Resources.WLPFull
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WLP Hub"
        '
        'LogOffButton
        '
        Me.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LogOffButton.Location = New System.Drawing.Point(141, 178)
        Me.LogOffButton.Name = "LogOffButton"
        Me.LogOffButton.Size = New System.Drawing.Size(123, 23)
        Me.LogOffButton.TabIndex = 3
        Me.LogOffButton.Text = "Log Off..."
        Me.LogOffButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(361, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Use the Task Manager to close an application that is not responding."
        '
        'SystemPowerButton
        '
        Me.SystemPowerButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SystemPowerButton.Location = New System.Drawing.Point(270, 178)
        Me.SystemPowerButton.Name = "SystemPowerButton"
        Me.SystemPowerButton.Size = New System.Drawing.Size(114, 23)
        Me.SystemPowerButton.TabIndex = 5
        Me.SystemPowerButton.Text = "System Power..."
        Me.SystemPowerButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelButton.Location = New System.Drawing.Point(270, 207)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(114, 23)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'TaskMgrButton
        '
        Me.TaskMgrButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TaskMgrButton.Location = New System.Drawing.Point(141, 207)
        Me.TaskMgrButton.Name = "TaskMgrButton"
        Me.TaskMgrButton.Size = New System.Drawing.Size(123, 23)
        Me.TaskMgrButton.TabIndex = 6
        Me.TaskMgrButton.Text = "Task Manager"
        Me.TaskMgrButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Session Information"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "00:00:00 AM - 00/00/0000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "The current date and time is: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "You are logged on as %user%."
        '
        'ChangePasswrdButton
        '
        Me.ChangePasswrdButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ChangePasswrdButton.Location = New System.Drawing.Point(12, 207)
        Me.ChangePasswrdButton.Name = "ChangePasswrdButton"
        Me.ChangePasswrdButton.Size = New System.Drawing.Size(123, 23)
        Me.ChangePasswrdButton.TabIndex = 10
        Me.ChangePasswrdButton.Text = "Change Password..."
        Me.ChangePasswrdButton.UseVisualStyleBackColor = True
        '
        'LockPCButton
        '
        Me.LockPCButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LockPCButton.Location = New System.Drawing.Point(12, 178)
        Me.LockPCButton.Name = "LockPCButton"
        Me.LockPCButton.Size = New System.Drawing.Size(123, 23)
        Me.LockPCButton.TabIndex = 9
        Me.LockPCButton.Text = "Lock Computer"
        Me.LockPCButton.UseVisualStyleBackColor = True
        '
        'DateTime
        '
        Me.DateTime.Enabled = True
        Me.DateTime.Interval = 1
        '
        'sssecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(394, 238)
        Me.Controls.Add(Me.ChangePasswrdButton)
        Me.Controls.Add(Me.LockPCButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.TaskMgrButton)
        Me.Controls.Add(Me.SystemPowerButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LogOffButton)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sssecurity"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WLP Hub Security"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogOffButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SystemPowerButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents TaskMgrButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChangePasswrdButton As System.Windows.Forms.Button
    Friend WithEvents LockPCButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTime As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
