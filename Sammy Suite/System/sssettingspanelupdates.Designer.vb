<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sssettingspanelupdates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sssettingspanelupdates))
        Me.ManualUpdateButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DisableUpdatesSwitch = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EnableUpdatesSwitch = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AdhocUpdatesSwitch = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ManualUpdateButton
        '
        Me.ManualUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ManualUpdateButton.Location = New System.Drawing.Point(562, 238)
        Me.ManualUpdateButton.Name = "ManualUpdateButton"
        Me.ManualUpdateButton.Size = New System.Drawing.Size(168, 23)
        Me.ManualUpdateButton.TabIndex = 20
        Me.ManualUpdateButton.Text = "Manually Check for Updates..."
        Me.ManualUpdateButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(50, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(373, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Adhoc updates will only check for updates when the application starts."
        '
        'DisableUpdatesSwitch
        '
        Me.DisableUpdatesSwitch.AutoSize = True
        Me.DisableUpdatesSwitch.ForeColor = System.Drawing.Color.White
        Me.DisableUpdatesSwitch.Location = New System.Drawing.Point(50, 182)
        Me.DisableUpdatesSwitch.Name = "DisableUpdatesSwitch"
        Me.DisableUpdatesSwitch.Size = New System.Drawing.Size(289, 17)
        Me.DisableUpdatesSwitch.TabIndex = 18
        Me.DisableUpdatesSwitch.Text = "Disable updates (not suggested nor recommended)"
        Me.DisableUpdatesSwitch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(50, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(344, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Disabling updates will stop the application checking for updates."
        '
        'EnableUpdatesSwitch
        '
        Me.EnableUpdatesSwitch.AutoSize = True
        Me.EnableUpdatesSwitch.ForeColor = System.Drawing.Color.White
        Me.EnableUpdatesSwitch.Location = New System.Drawing.Point(50, 90)
        Me.EnableUpdatesSwitch.Name = "EnableUpdatesSwitch"
        Me.EnableUpdatesSwitch.Size = New System.Drawing.Size(241, 17)
        Me.EnableUpdatesSwitch.TabIndex = 16
        Me.EnableUpdatesSwitch.Text = "Enable persistant updates (recommended)"
        Me.EnableUpdatesSwitch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(50, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(609, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Persistant updates will check for updates throughout your usage of the applicatio" & _
            "n and will notify you if it finds any."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(706, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "The Hub ESR front-end can check for updates automatically when set. This will ens" & _
            "ure that your version of the application is up to date."
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.ss.My.Resources.Resources.ssSecWarn
        Me.PictureBox8.Location = New System.Drawing.Point(12, 136)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 21
        Me.PictureBox8.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.ss.My.Resources.Resources.ssSecBad
        Me.PictureBox2.Location = New System.Drawing.Point(12, 182)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.ss.My.Resources.Resources.ssSecGood
        Me.PictureBox3.Location = New System.Drawing.Point(12, 90)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ss.My.Resources.Resources.GoodGradient
        Me.PictureBox1.Location = New System.Drawing.Point(0, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(734, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 53)
        Me.Panel1.TabIndex = 24
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.ss.My.Resources.Resources.ssNavigateBack
        Me.BackButton.Location = New System.Drawing.Point(12, 9)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(444, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change how your computer handles updates..."
        '
        'AdhocUpdatesSwitch
        '
        Me.AdhocUpdatesSwitch.AutoSize = True
        Me.AdhocUpdatesSwitch.ForeColor = System.Drawing.Color.White
        Me.AdhocUpdatesSwitch.Location = New System.Drawing.Point(50, 136)
        Me.AdhocUpdatesSwitch.Name = "AdhocUpdatesSwitch"
        Me.AdhocUpdatesSwitch.Size = New System.Drawing.Size(203, 17)
        Me.AdhocUpdatesSwitch.TabIndex = 25
        Me.AdhocUpdatesSwitch.Text = "Enable adhoc updates (suggested)"
        Me.AdhocUpdatesSwitch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(293, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Alternatively, you can check for updates manually."
        '
        'sssettingspanelupdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(734, 265)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AdhocUpdatesSwitch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.ManualUpdateButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DisableUpdatesSwitch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EnableUpdatesSwitch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sssettingspanelupdates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Updates"
        Me.TopMost = True
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents ManualUpdateButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DisableUpdatesSwitch As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents EnableUpdatesSwitch As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents AdhocUpdatesSwitch As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
