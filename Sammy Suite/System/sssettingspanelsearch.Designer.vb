<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sssettingspanelsearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sssettingspanelsearch))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DuckDuckGoSwitch = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GoogleSwitch = New System.Windows.Forms.RadioButton()
        Me.YahooSwitch = New System.Windows.Forms.RadioButton()
        Me.BingSwitch = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BuiltInSwitch = New System.Windows.Forms.RadioButton()
        Me.WindowSwitch = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 53)
        Me.Panel1.TabIndex = 3
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
        Me.BackButton.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BackButton, "Back to Settings Panel.")
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(250, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Change how you search..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DuckDuckGoSwitch)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.GoogleSwitch)
        Me.GroupBox1.Controls.Add(Me.YahooSwitch)
        Me.GroupBox1.Controls.Add(Me.BingSwitch)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 85)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Engine"
        '
        'DuckDuckGoSwitch
        '
        Me.DuckDuckGoSwitch.AutoSize = True
        Me.DuckDuckGoSwitch.Location = New System.Drawing.Point(231, 29)
        Me.DuckDuckGoSwitch.Name = "DuckDuckGoSwitch"
        Me.DuckDuckGoSwitch.Size = New System.Drawing.Size(95, 17)
        Me.DuckDuckGoSwitch.TabIndex = 9
        Me.DuckDuckGoSwitch.TabStop = True
        Me.DuckDuckGoSwitch.Text = "DuckDuckGo!"
        Me.DuckDuckGoSwitch.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ss.My.Resources.Resources.ssSearch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GoogleSwitch
        '
        Me.GoogleSwitch.AutoSize = True
        Me.GoogleSwitch.Location = New System.Drawing.Point(44, 29)
        Me.GoogleSwitch.Name = "GoogleSwitch"
        Me.GoogleSwitch.Size = New System.Drawing.Size(63, 17)
        Me.GoogleSwitch.TabIndex = 5
        Me.GoogleSwitch.TabStop = True
        Me.GoogleSwitch.Text = "Google"
        Me.GoogleSwitch.UseVisualStyleBackColor = True
        '
        'YahooSwitch
        '
        Me.YahooSwitch.AutoSize = True
        Me.YahooSwitch.Location = New System.Drawing.Point(168, 29)
        Me.YahooSwitch.Name = "YahooSwitch"
        Me.YahooSwitch.Size = New System.Drawing.Size(57, 17)
        Me.YahooSwitch.TabIndex = 7
        Me.YahooSwitch.TabStop = True
        Me.YahooSwitch.Text = "Yahoo"
        Me.YahooSwitch.UseVisualStyleBackColor = True
        '
        'BingSwitch
        '
        Me.BingSwitch.AutoSize = True
        Me.BingSwitch.Location = New System.Drawing.Point(113, 29)
        Me.BingSwitch.Name = "BingSwitch"
        Me.BingSwitch.Size = New System.Drawing.Size(49, 17)
        Me.BingSwitch.TabIndex = 6
        Me.BingSwitch.TabStop = True
        Me.BingSwitch.Text = "Bing"
        Me.BingSwitch.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BuiltInSwitch)
        Me.GroupBox2.Controls.Add(Me.WindowSwitch)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 83)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Style"
        '
        'BuiltInSwitch
        '
        Me.BuiltInSwitch.AutoSize = True
        Me.BuiltInSwitch.Location = New System.Drawing.Point(44, 29)
        Me.BuiltInSwitch.Name = "BuiltInSwitch"
        Me.BuiltInSwitch.Size = New System.Drawing.Size(47, 17)
        Me.BuiltInSwitch.TabIndex = 2
        Me.BuiltInSwitch.TabStop = True
        Me.BuiltInSwitch.Text = "Hub"
        Me.BuiltInSwitch.UseVisualStyleBackColor = True
        '
        'WindowSwitch
        '
        Me.WindowSwitch.AutoSize = True
        Me.WindowSwitch.Location = New System.Drawing.Point(97, 29)
        Me.WindowSwitch.Name = "WindowSwitch"
        Me.WindowSwitch.Size = New System.Drawing.Size(82, 17)
        Me.WindowSwitch.TabIndex = 1
        Me.WindowSwitch.TabStop = True
        Me.WindowSwitch.Text = "Windowed"
        Me.WindowSwitch.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ss.My.Resources.Resources.ssProcessList
        Me.PictureBox2.Location = New System.Drawing.Point(7, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'sssettingspanelsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(441, 245)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sssettingspanelsearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Search"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GoogleSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents YahooSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents BingSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BuiltInSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents WindowSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DuckDuckGoSwitch As System.Windows.Forms.RadioButton
End Class
