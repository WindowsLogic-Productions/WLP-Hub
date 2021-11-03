<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssoobepersonalisationbackground
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.CB2Button = New System.Windows.Forms.Button()
        Me.CB1Button = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.WLSOOBEBackground = New System.Windows.Forms.PictureBox()
        Me.WelcomeBackgroundPicture = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WDBSwitch = New System.Windows.Forms.RadioButton()
        Me.WUCSwitch = New System.Windows.Forms.RadioButton()
        Me.RB2Box = New System.Windows.Forms.RadioButton()
        Me.HubBackgroundPicture = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HDBSwitch = New System.Windows.Forms.RadioButton()
        Me.HUCSwitch = New System.Windows.Forms.RadioButton()
        Me.RB1Box = New System.Windows.Forms.RadioButton()
        Me.WelcomeBackgroundLabel = New System.Windows.Forms.Label()
        Me.HubBackgroundBox = New System.Windows.Forms.GroupBox()
        Me.WelcomeBackgroundBox = New System.Windows.Forms.GroupBox()
        CType(Me.WLSOOBEBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeBackgroundPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HubBackgroundPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HubBackgroundBox.SuspendLayout()
        Me.WelcomeBackgroundBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'RMLButton
        '
        Me.RMLButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RMLButton.BackColor = System.Drawing.Color.Transparent
        Me.RMLButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMLButton.Location = New System.Drawing.Point(856, 595)
        Me.RMLButton.Name = "RMLButton"
        Me.RMLButton.Size = New System.Drawing.Size(112, 36)
        Me.RMLButton.TabIndex = 22
        Me.RMLButton.Text = "Do It Later"
        Me.RMLButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(494, 37)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "1. > 2. > 3. Personalisation (Background)"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(123, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(773, 60)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "These settings personalise your experience." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can set these up to your liking " &
    "right now or do it later from the Settings Panel."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ForwardButton
        '
        Me.ForwardButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ForwardButton.BackColor = System.Drawing.Color.Transparent
        Me.ForwardButton.Image = Global.ss.My.Resources.Resources.ssNavigateFoward
        Me.ForwardButton.Location = New System.Drawing.Point(974, 595)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 36)
        Me.ForwardButton.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Save changes and continue.")
        Me.ForwardButton.UseVisualStyleBackColor = False
        '
        'CB2Button
        '
        Me.CB2Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB2Button.Location = New System.Drawing.Point(504, 177)
        Me.CB2Button.Name = "CB2Button"
        Me.CB2Button.Size = New System.Drawing.Size(79, 25)
        Me.CB2Button.TabIndex = 19
        Me.CB2Button.Text = "Browse..."
        Me.ToolTip1.SetToolTip(Me.CB2Button, "Browse for a welcome background...")
        Me.CB2Button.UseVisualStyleBackColor = True
        '
        'CB1Button
        '
        Me.CB1Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB1Button.Location = New System.Drawing.Point(504, 177)
        Me.CB1Button.Name = "CB1Button"
        Me.CB1Button.Size = New System.Drawing.Size(79, 25)
        Me.CB1Button.TabIndex = 20
        Me.CB1Button.Text = "Browse..."
        Me.ToolTip1.SetToolTip(Me.CB1Button, "Browse for a hub background...")
        Me.CB1Button.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Title = "Choose Hub Background..."
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.InitialDirectory = "C:\"
        Me.OpenFileDialog2.Title = "Choose Welcome/Exit Background..."
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
        'WelcomeBackgroundPicture
        '
        Me.WelcomeBackgroundPicture.Location = New System.Drawing.Point(6, 28)
        Me.WelcomeBackgroundPicture.Name = "WelcomeBackgroundPicture"
        Me.WelcomeBackgroundPicture.Size = New System.Drawing.Size(208, 125)
        Me.WelcomeBackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WelcomeBackgroundPicture.TabIndex = 0
        Me.WelcomeBackgroundPicture.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(220, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 84)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Enabling the background will disable the default" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "background or colour. When pick" &
    "ing a background" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "make sure you have set up a dedicated folder that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hub can rea" &
    "d the file from."
        '
        'WDBSwitch
        '
        Me.WDBSwitch.AutoSize = True
        Me.WDBSwitch.ForeColor = System.Drawing.Color.White
        Me.WDBSwitch.Location = New System.Drawing.Point(224, 115)
        Me.WDBSwitch.Name = "WDBSwitch"
        Me.WDBSwitch.Size = New System.Drawing.Size(165, 25)
        Me.WDBSwitch.TabIndex = 24
        Me.WDBSwitch.TabStop = True
        Me.WDBSwitch.Text = "Default background"
        Me.WDBSwitch.UseVisualStyleBackColor = True
        '
        'WUCSwitch
        '
        Me.WUCSwitch.AutoSize = True
        Me.WUCSwitch.ForeColor = System.Drawing.Color.White
        Me.WUCSwitch.Location = New System.Drawing.Point(224, 138)
        Me.WUCSwitch.Name = "WUCSwitch"
        Me.WUCSwitch.Size = New System.Drawing.Size(108, 25)
        Me.WUCSwitch.TabIndex = 24
        Me.WUCSwitch.TabStop = True
        Me.WUCSwitch.Text = "User colour"
        Me.WUCSwitch.UseVisualStyleBackColor = True
        '
        'RB2Box
        '
        Me.RB2Box.AutoSize = True
        Me.RB2Box.ForeColor = System.Drawing.Color.White
        Me.RB2Box.Location = New System.Drawing.Point(224, 161)
        Me.RB2Box.Name = "RB2Box"
        Me.RB2Box.Size = New System.Drawing.Size(169, 25)
        Me.RB2Box.TabIndex = 25
        Me.RB2Box.TabStop = True
        Me.RB2Box.Text = "Custom background"
        Me.RB2Box.UseVisualStyleBackColor = True
        '
        'HubBackgroundPicture
        '
        Me.HubBackgroundPicture.Location = New System.Drawing.Point(6, 28)
        Me.HubBackgroundPicture.Name = "HubBackgroundPicture"
        Me.HubBackgroundPicture.Size = New System.Drawing.Size(208, 125)
        Me.HubBackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HubBackgroundPicture.TabIndex = 2
        Me.HubBackgroundPicture.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(220, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 84)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Enabling the background will disable the default" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "background or colour. When pick" &
    "ing a background" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "make sure you have set up a dedicated folder that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hub can rea" &
    "d the file from."
        '
        'HDBSwitch
        '
        Me.HDBSwitch.AutoSize = True
        Me.HDBSwitch.ForeColor = System.Drawing.Color.White
        Me.HDBSwitch.Location = New System.Drawing.Point(224, 115)
        Me.HDBSwitch.Name = "HDBSwitch"
        Me.HDBSwitch.Size = New System.Drawing.Size(165, 25)
        Me.HDBSwitch.TabIndex = 22
        Me.HDBSwitch.TabStop = True
        Me.HDBSwitch.Text = "Default background"
        Me.HDBSwitch.UseVisualStyleBackColor = True
        '
        'HUCSwitch
        '
        Me.HUCSwitch.AutoSize = True
        Me.HUCSwitch.ForeColor = System.Drawing.Color.White
        Me.HUCSwitch.Location = New System.Drawing.Point(224, 138)
        Me.HUCSwitch.Name = "HUCSwitch"
        Me.HUCSwitch.Size = New System.Drawing.Size(108, 25)
        Me.HUCSwitch.TabIndex = 23
        Me.HUCSwitch.TabStop = True
        Me.HUCSwitch.Text = "User colour"
        Me.HUCSwitch.UseVisualStyleBackColor = True
        '
        'RB1Box
        '
        Me.RB1Box.AutoSize = True
        Me.RB1Box.ForeColor = System.Drawing.Color.White
        Me.RB1Box.Location = New System.Drawing.Point(224, 161)
        Me.RB1Box.Name = "RB1Box"
        Me.RB1Box.Size = New System.Drawing.Size(169, 25)
        Me.RB1Box.TabIndex = 24
        Me.RB1Box.TabStop = True
        Me.RB1Box.Text = "Custom background"
        Me.RB1Box.UseVisualStyleBackColor = True
        '
        'WelcomeBackgroundLabel
        '
        Me.WelcomeBackgroundLabel.AutoSize = True
        Me.WelcomeBackgroundLabel.ForeColor = System.Drawing.Color.White
        Me.WelcomeBackgroundLabel.Location = New System.Drawing.Point(272, 441)
        Me.WelcomeBackgroundLabel.Name = "WelcomeBackgroundLabel"
        Me.WelcomeBackgroundLabel.Size = New System.Drawing.Size(142, 13)
        Me.WelcomeBackgroundLabel.TabIndex = 26
        Me.WelcomeBackgroundLabel.Text = "Welcome/Exit Background"
        '
        'HubBackgroundBox
        '
        Me.HubBackgroundBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HubBackgroundBox.Controls.Add(Me.CB1Button)
        Me.HubBackgroundBox.Controls.Add(Me.HubBackgroundPicture)
        Me.HubBackgroundBox.Controls.Add(Me.Label3)
        Me.HubBackgroundBox.Controls.Add(Me.RB1Box)
        Me.HubBackgroundBox.Controls.Add(Me.HDBSwitch)
        Me.HubBackgroundBox.Controls.Add(Me.HUCSwitch)
        Me.HubBackgroundBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HubBackgroundBox.ForeColor = System.Drawing.Color.White
        Me.HubBackgroundBox.Location = New System.Drawing.Point(217, 179)
        Me.HubBackgroundBox.Name = "HubBackgroundBox"
        Me.HubBackgroundBox.Size = New System.Drawing.Size(589, 208)
        Me.HubBackgroundBox.TabIndex = 27
        Me.HubBackgroundBox.TabStop = False
        Me.HubBackgroundBox.Text = "Hub Background"
        '
        'WelcomeBackgroundBox
        '
        Me.WelcomeBackgroundBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WelcomeBackgroundBox.Controls.Add(Me.WelcomeBackgroundPicture)
        Me.WelcomeBackgroundBox.Controls.Add(Me.RB2Box)
        Me.WelcomeBackgroundBox.Controls.Add(Me.CB2Button)
        Me.WelcomeBackgroundBox.Controls.Add(Me.WUCSwitch)
        Me.WelcomeBackgroundBox.Controls.Add(Me.Label1)
        Me.WelcomeBackgroundBox.Controls.Add(Me.WDBSwitch)
        Me.WelcomeBackgroundBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WelcomeBackgroundBox.ForeColor = System.Drawing.Color.White
        Me.WelcomeBackgroundBox.Location = New System.Drawing.Point(217, 393)
        Me.WelcomeBackgroundBox.Name = "WelcomeBackgroundBox"
        Me.WelcomeBackgroundBox.Size = New System.Drawing.Size(589, 208)
        Me.WelcomeBackgroundBox.TabIndex = 28
        Me.WelcomeBackgroundBox.TabStop = False
        Me.WelcomeBackgroundBox.Text = "Welcome/Exit Background"
        '
        'ssoobepersonalisationbackground
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1022, 643)
        Me.Controls.Add(Me.WelcomeBackgroundBox)
        Me.Controls.Add(Me.WelcomeBackgroundLabel)
        Me.Controls.Add(Me.RMLButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HubBackgroundBox)
        Me.Controls.Add(Me.WLSOOBEBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ssoobepersonalisationbackground"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hub Settings - OOBE"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WLSOOBEBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeBackgroundPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HubBackgroundPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HubBackgroundBox.ResumeLayout(False)
        Me.HubBackgroundBox.PerformLayout()
        Me.WelcomeBackgroundBox.ResumeLayout(False)
        Me.WelcomeBackgroundBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RMLButton As System.Windows.Forms.Button
    Friend WithEvents ForwardButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WLSOOBEBackground As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents WelcomeBackgroundPicture As System.Windows.Forms.PictureBox
    Friend WithEvents CB2Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WDBSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents WUCSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents RB2Box As System.Windows.Forms.RadioButton
    Friend WithEvents HubBackgroundPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HDBSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents HUCSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents RB1Box As System.Windows.Forms.RadioButton
    Friend WithEvents WelcomeBackgroundLabel As Label
    Friend WithEvents CB1Button As Button
    Friend WithEvents HubBackgroundBox As GroupBox
    Friend WithEvents WelcomeBackgroundBox As GroupBox
End Class
