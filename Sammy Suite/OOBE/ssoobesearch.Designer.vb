<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssoobesearch
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
        Me.RMLButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.WLSOOBEBackground = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BuiltInSwitch = New System.Windows.Forms.RadioButton()
        Me.WindowSwitch = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DuckDuckGoSwitch = New System.Windows.Forms.RadioButton()
        Me.GoogleSwitch = New System.Windows.Forms.RadioButton()
        Me.YahooSwitch = New System.Windows.Forms.RadioButton()
        Me.BingSwitch = New System.Windows.Forms.RadioButton()
        CType(Me.WLSOOBEBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RMLButton
        '
        Me.RMLButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RMLButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMLButton.Location = New System.Drawing.Point(856, 595)
        Me.RMLButton.Name = "RMLButton"
        Me.RMLButton.Size = New System.Drawing.Size(112, 36)
        Me.RMLButton.TabIndex = 22
        Me.RMLButton.Text = "Do It Later"
        Me.RMLButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 37)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = " 1. > 2. > 3. > 4. > 5. Search"
        '
        'ForwardButton
        '
        Me.ForwardButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ForwardButton.Image = Global.ss.My.Resources.Resources.ssNavigateFoward
        Me.ForwardButton.Location = New System.Drawing.Point(974, 595)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 36)
        Me.ForwardButton.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Save changes and continue.")
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'WLSOOBEBackground
        '
        Me.WLSOOBEBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WLSOOBEBackground.Image = Global.ss.My.Resources.Resources.WLPBackground
        Me.WLSOOBEBackground.Location = New System.Drawing.Point(0, 0)
        Me.WLSOOBEBackground.Name = "WLSOOBEBackground"
        Me.WLSOOBEBackground.Size = New System.Drawing.Size(1022, 643)
        Me.WLSOOBEBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WLSOOBEBackground.TabIndex = 18
        Me.WLSOOBEBackground.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(123, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(771, 60)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "These settings change how you search." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can set these up to your liking right " &
    "now or do it later from the Settings Panel."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BuiltInSwitch)
        Me.GroupBox2.Controls.Add(Me.WindowSwitch)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(425, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 57)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Style"
        '
        'BuiltInSwitch
        '
        Me.BuiltInSwitch.AutoSize = True
        Me.BuiltInSwitch.Location = New System.Drawing.Point(6, 28)
        Me.BuiltInSwitch.Name = "BuiltInSwitch"
        Me.BuiltInSwitch.Size = New System.Drawing.Size(57, 25)
        Me.BuiltInSwitch.TabIndex = 2
        Me.BuiltInSwitch.TabStop = True
        Me.BuiltInSwitch.Text = "Hub"
        Me.BuiltInSwitch.UseVisualStyleBackColor = True
        '
        'WindowSwitch
        '
        Me.WindowSwitch.AutoSize = True
        Me.WindowSwitch.Location = New System.Drawing.Point(69, 28)
        Me.WindowSwitch.Name = "WindowSwitch"
        Me.WindowSwitch.Size = New System.Drawing.Size(102, 25)
        Me.WindowSwitch.TabIndex = 1
        Me.WindowSwitch.TabStop = True
        Me.WindowSwitch.Text = "Windowed"
        Me.WindowSwitch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DuckDuckGoSwitch)
        Me.GroupBox1.Controls.Add(Me.GoogleSwitch)
        Me.GroupBox1.Controls.Add(Me.YahooSwitch)
        Me.GroupBox1.Controls.Add(Me.BingSwitch)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(333, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 59)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Engine"
        '
        'DuckDuckGoSwitch
        '
        Me.DuckDuckGoSwitch.AutoSize = True
        Me.DuckDuckGoSwitch.Location = New System.Drawing.Point(232, 28)
        Me.DuckDuckGoSwitch.Name = "DuckDuckGoSwitch"
        Me.DuckDuckGoSwitch.Size = New System.Drawing.Size(123, 25)
        Me.DuckDuckGoSwitch.TabIndex = 9
        Me.DuckDuckGoSwitch.TabStop = True
        Me.DuckDuckGoSwitch.Text = "DuckDuckGo!"
        Me.DuckDuckGoSwitch.UseVisualStyleBackColor = True
        '
        'GoogleSwitch
        '
        Me.GoogleSwitch.AutoSize = True
        Me.GoogleSwitch.Location = New System.Drawing.Point(6, 28)
        Me.GoogleSwitch.Name = "GoogleSwitch"
        Me.GoogleSwitch.Size = New System.Drawing.Size(78, 25)
        Me.GoogleSwitch.TabIndex = 5
        Me.GoogleSwitch.TabStop = True
        Me.GoogleSwitch.Text = "Google"
        Me.GoogleSwitch.UseVisualStyleBackColor = True
        '
        'YahooSwitch
        '
        Me.YahooSwitch.AutoSize = True
        Me.YahooSwitch.Location = New System.Drawing.Point(155, 28)
        Me.YahooSwitch.Name = "YahooSwitch"
        Me.YahooSwitch.Size = New System.Drawing.Size(70, 25)
        Me.YahooSwitch.TabIndex = 7
        Me.YahooSwitch.TabStop = True
        Me.YahooSwitch.Text = "Yahoo"
        Me.YahooSwitch.UseVisualStyleBackColor = True
        '
        'BingSwitch
        '
        Me.BingSwitch.AutoSize = True
        Me.BingSwitch.Location = New System.Drawing.Point(90, 28)
        Me.BingSwitch.Name = "BingSwitch"
        Me.BingSwitch.Size = New System.Drawing.Size(59, 25)
        Me.BingSwitch.TabIndex = 6
        Me.BingSwitch.TabStop = True
        Me.BingSwitch.Text = "Bing"
        Me.BingSwitch.UseVisualStyleBackColor = True
        '
        'ssoobesearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1022, 643)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RMLButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WLSOOBEBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ssoobesearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hub Settings - OOBE"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WLSOOBEBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RMLButton As System.Windows.Forms.Button
    Friend WithEvents ForwardButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WLSOOBEBackground As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BuiltInSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents WindowSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DuckDuckGoSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents GoogleSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents YahooSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents BingSwitch As System.Windows.Forms.RadioButton
End Class
