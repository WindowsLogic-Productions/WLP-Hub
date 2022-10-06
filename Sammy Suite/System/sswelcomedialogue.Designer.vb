<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sswelcomedialogue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sswelcomedialogue))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StartWLSButton = New System.Windows.Forms.Button()
        Me.RMLButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WelcomeTabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NewsFeed = New Gecko.GeckoWebBrowser()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Website = New Gecko.GeckoWebBrowser()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BS = New Gecko.GeckoWebBrowser()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BetaLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.WelcomeTabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CloseButton.Location = New System.Drawing.Point(692, 526)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(80, 23)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "OK"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.StartWLSButton)
        Me.Panel1.Controls.Add(Me.RMLButton)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PasswordBox)
        Me.Panel1.Controls.Add(Me.UsernameBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 561)
        Me.Panel1.TabIndex = 5
        '
        'StartWLSButton
        '
        Me.StartWLSButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.StartWLSButton.Location = New System.Drawing.Point(547, 526)
        Me.StartWLSButton.Name = "StartWLSButton"
        Me.StartWLSButton.Size = New System.Drawing.Size(225, 23)
        Me.StartWLSButton.TabIndex = 1
        Me.StartWLSButton.Text = "Save and Enable Hub Locking System"
        Me.StartWLSButton.UseVisualStyleBackColor = True
        '
        'RMLButton
        '
        Me.RMLButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RMLButton.Location = New System.Drawing.Point(435, 526)
        Me.RMLButton.Name = "RMLButton"
        Me.RMLButton.Size = New System.Drawing.Size(106, 23)
        Me.RMLButton.TabIndex = 0
        Me.RMLButton.Text = "Remind Me Later"
        Me.RMLButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(95, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(595, 63)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Usernames and passwords are kept local to your system and are not sent to a serve" &
    "r." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you don't want to continue this process right now, click 'Remind Me Lat" &
    "er'."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PasswordBox
        '
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordBox.Location = New System.Drawing.Point(310, 278)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(232, 22)
        Me.PasswordBox.TabIndex = 3
        '
        'UsernameBox
        '
        Me.UsernameBox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameBox.Location = New System.Drawing.Point(310, 243)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(232, 22)
        Me.UsernameBox.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(245, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(243, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(84, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(617, 42)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "The Hub Locking System enables security features built into Hub." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Before these se" &
    "curity features are enabled, you need to enter a username and password."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(312, 32)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Set up Hub Locking System..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(310, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "WLP Hub 10 makes its open source debut, with some much needed changes."
        '
        'WelcomeTabs
        '
        Me.WelcomeTabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WelcomeTabs.Controls.Add(Me.TabPage1)
        Me.WelcomeTabs.Controls.Add(Me.TabPage2)
        Me.WelcomeTabs.Controls.Add(Me.TabPage3)
        Me.WelcomeTabs.Controls.Add(Me.TabPage4)
        Me.WelcomeTabs.Location = New System.Drawing.Point(12, 12)
        Me.WelcomeTabs.Name = "WelcomeTabs"
        Me.WelcomeTabs.SelectedIndex = 0
        Me.WelcomeTabs.Size = New System.Drawing.Size(760, 508)
        Me.WelcomeTabs.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BetaLabel)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.LinkLabel2)
        Me.TabPage1.Controls.Add(Me.LinkLabel1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(752, 482)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Welcome"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(368, 282)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(170, 32)
        Me.LinkLabel2.TabIndex = 9
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Send Feedback"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(214, 282)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(148, 32)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "What's New?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(689, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "With the new design and the ability to change even more settings, WLP Hub is more" &
    " customisable and easier to use that ever before!"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NewsFeed)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(752, 482)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "News Feed"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NewsFeed
        '
        Me.NewsFeed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewsFeed.ConsoleMessageEventReceivesConsoleLogCalls = True
        Me.NewsFeed.FrameEventsPropagateToMainWindow = False
        Me.NewsFeed.Location = New System.Drawing.Point(0, 0)
        Me.NewsFeed.Name = "NewsFeed"
        Me.NewsFeed.Size = New System.Drawing.Size(752, 482)
        Me.NewsFeed.TabIndex = 62
        Me.NewsFeed.UseHttpActivityObserver = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Website)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(752, 482)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Website"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Website
        '
        Me.Website.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Website.ConsoleMessageEventReceivesConsoleLogCalls = True
        Me.Website.FrameEventsPropagateToMainWindow = False
        Me.Website.Location = New System.Drawing.Point(0, 0)
        Me.Website.Name = "Website"
        Me.Website.Size = New System.Drawing.Size(752, 482)
        Me.Website.TabIndex = 63
        Me.Website.UseHttpActivityObserver = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.BS)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(752, 482)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Get your birthday suit?"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BS
        '
        Me.BS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BS.ConsoleMessageEventReceivesConsoleLogCalls = True
        Me.BS.FrameEventsPropagateToMainWindow = False
        Me.BS.Location = New System.Drawing.Point(0, 0)
        Me.BS.Name = "BS"
        Me.BS.Size = New System.Drawing.Size(752, 482)
        Me.BS.TabIndex = 64
        Me.BS.UseHttpActivityObserver = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ss.My.Resources.Resources.ssConstruction
        Me.PictureBox1.Location = New System.Drawing.Point(152, 400)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'BetaLabel
        '
        Me.BetaLabel.AutoSize = True
        Me.BetaLabel.Location = New System.Drawing.Point(190, 400)
        Me.BetaLabel.Name = "BetaLabel"
        Me.BetaLabel.Size = New System.Drawing.Size(411, 26)
        Me.BetaLabel.TabIndex = 11
        Me.BetaLabel.Text = "This software is currently in development and may have unfinished areas, bugs" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or" &
    " non-working functions. Use at your own risk."
        '
        'sswelcomedialogue
        '
        Me.AcceptButton = Me.StartWLSButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.WelcomeTabs)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "sswelcomedialogue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.WelcomeTabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CloseButton As Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StartWLSButton As System.Windows.Forms.Button
    Friend WithEvents RMLButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PasswordBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WelcomeTabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents NewsFeed As Gecko.GeckoWebBrowser
    Friend WithEvents Website As Gecko.GeckoWebBrowser
    Friend WithEvents BS As Gecko.GeckoWebBrowser
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BetaLabel As Label
End Class
