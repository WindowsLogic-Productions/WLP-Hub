<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sssettingspanelpersonalise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sssettingspanelpersonalise))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WelcomeBackgroundBox = New System.Windows.Forms.GroupBox()
        Me.RB2Box = New System.Windows.Forms.RadioButton()
        Me.WUCSwitch = New System.Windows.Forms.RadioButton()
        Me.WDBSwitch = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB2Button = New System.Windows.Forms.Button()
        Me.WelcomeBackgroundPicture = New System.Windows.Forms.PictureBox()
        Me.HubBackgroundBox = New System.Windows.Forms.GroupBox()
        Me.RB1Box = New System.Windows.Forms.RadioButton()
        Me.HUCSwitch = New System.Windows.Forms.RadioButton()
        Me.HDBSwitch = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB1Button = New System.Windows.Forms.Button()
        Me.HubBackgroundPicture = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CustomColourBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CCEBox = New System.Windows.Forms.CheckBox()
        Me.CustomColourLabel = New System.Windows.Forms.Label()
        Me.CustomColourButton = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SoundBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MuteSoundSwitch = New System.Windows.Forms.RadioButton()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.DefaultSoundSwitch = New System.Windows.Forms.RadioButton()
        Me.ModernSoundSwitch = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.WelcomeBackgroundBox.SuspendLayout()
        CType(Me.WelcomeBackgroundPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HubBackgroundBox.SuspendLayout()
        CType(Me.HubBackgroundPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.CustomColourBox.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SoundBox.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(536, 349)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WelcomeBackgroundBox)
        Me.TabPage1.Controls.Add(Me.HubBackgroundBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(528, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Backgrounds"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WelcomeBackgroundBox
        '
        Me.WelcomeBackgroundBox.Controls.Add(Me.RB2Box)
        Me.WelcomeBackgroundBox.Controls.Add(Me.WUCSwitch)
        Me.WelcomeBackgroundBox.Controls.Add(Me.WDBSwitch)
        Me.WelcomeBackgroundBox.Controls.Add(Me.Label2)
        Me.WelcomeBackgroundBox.Controls.Add(Me.CB2Button)
        Me.WelcomeBackgroundBox.Controls.Add(Me.WelcomeBackgroundPicture)
        Me.WelcomeBackgroundBox.Location = New System.Drawing.Point(6, 163)
        Me.WelcomeBackgroundBox.Name = "WelcomeBackgroundBox"
        Me.WelcomeBackgroundBox.Size = New System.Drawing.Size(510, 151)
        Me.WelcomeBackgroundBox.TabIndex = 4
        Me.WelcomeBackgroundBox.TabStop = False
        Me.WelcomeBackgroundBox.Text = "Welcome/Exit Background"
        '
        'RB2Box
        '
        Me.RB2Box.AutoSize = True
        Me.RB2Box.Location = New System.Drawing.Point(220, 121)
        Me.RB2Box.Name = "RB2Box"
        Me.RB2Box.Size = New System.Drawing.Size(130, 17)
        Me.RB2Box.TabIndex = 6
        Me.RB2Box.TabStop = True
        Me.RB2Box.Text = "Custom background"
        Me.RB2Box.UseVisualStyleBackColor = True
        '
        'WUCSwitch
        '
        Me.WUCSwitch.AutoSize = True
        Me.WUCSwitch.Location = New System.Drawing.Point(220, 98)
        Me.WUCSwitch.Name = "WUCSwitch"
        Me.WUCSwitch.Size = New System.Drawing.Size(84, 17)
        Me.WUCSwitch.TabIndex = 5
        Me.WUCSwitch.TabStop = True
        Me.WUCSwitch.Text = "User colour"
        Me.WUCSwitch.UseVisualStyleBackColor = True
        '
        'WDBSwitch
        '
        Me.WDBSwitch.AutoSize = True
        Me.WDBSwitch.Location = New System.Drawing.Point(220, 75)
        Me.WDBSwitch.Name = "WDBSwitch"
        Me.WDBSwitch.Size = New System.Drawing.Size(129, 17)
        Me.WDBSwitch.TabIndex = 4
        Me.WDBSwitch.TabStop = True
        Me.WDBSwitch.Text = "Default background"
        Me.WDBSwitch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 52)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Enabling the background will disable the default" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "background or colour. When pick" &
    "ing a background" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "make sure you have set up a dedicated folder that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hub ESR can" &
    " read the file from."
        '
        'CB2Button
        '
        Me.CB2Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB2Button.Location = New System.Drawing.Point(442, 122)
        Me.CB2Button.Name = "CB2Button"
        Me.CB2Button.Size = New System.Drawing.Size(62, 23)
        Me.CB2Button.TabIndex = 7
        Me.CB2Button.Text = "Browse..."
        Me.ToolTip1.SetToolTip(Me.CB2Button, "Browse for a welcome background...")
        Me.CB2Button.UseVisualStyleBackColor = True
        '
        'WelcomeBackgroundPicture
        '
        Me.WelcomeBackgroundPicture.Location = New System.Drawing.Point(6, 20)
        Me.WelcomeBackgroundPicture.Name = "WelcomeBackgroundPicture"
        Me.WelcomeBackgroundPicture.Size = New System.Drawing.Size(208, 125)
        Me.WelcomeBackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WelcomeBackgroundPicture.TabIndex = 0
        Me.WelcomeBackgroundPicture.TabStop = False
        '
        'HubBackgroundBox
        '
        Me.HubBackgroundBox.Controls.Add(Me.RB1Box)
        Me.HubBackgroundBox.Controls.Add(Me.HUCSwitch)
        Me.HubBackgroundBox.Controls.Add(Me.HDBSwitch)
        Me.HubBackgroundBox.Controls.Add(Me.Label1)
        Me.HubBackgroundBox.Controls.Add(Me.CB1Button)
        Me.HubBackgroundBox.Controls.Add(Me.HubBackgroundPicture)
        Me.HubBackgroundBox.Location = New System.Drawing.Point(6, 6)
        Me.HubBackgroundBox.Name = "HubBackgroundBox"
        Me.HubBackgroundBox.Size = New System.Drawing.Size(510, 151)
        Me.HubBackgroundBox.TabIndex = 3
        Me.HubBackgroundBox.TabStop = False
        Me.HubBackgroundBox.Text = "Hub Background"
        '
        'RB1Box
        '
        Me.RB1Box.AutoSize = True
        Me.RB1Box.Location = New System.Drawing.Point(220, 122)
        Me.RB1Box.Name = "RB1Box"
        Me.RB1Box.Size = New System.Drawing.Size(130, 17)
        Me.RB1Box.TabIndex = 2
        Me.RB1Box.TabStop = True
        Me.RB1Box.Text = "Custom background"
        Me.RB1Box.UseVisualStyleBackColor = True
        '
        'HUCSwitch
        '
        Me.HUCSwitch.AutoSize = True
        Me.HUCSwitch.Location = New System.Drawing.Point(220, 99)
        Me.HUCSwitch.Name = "HUCSwitch"
        Me.HUCSwitch.Size = New System.Drawing.Size(84, 17)
        Me.HUCSwitch.TabIndex = 1
        Me.HUCSwitch.TabStop = True
        Me.HUCSwitch.Text = "User colour"
        Me.HUCSwitch.UseVisualStyleBackColor = True
        '
        'HDBSwitch
        '
        Me.HDBSwitch.AutoSize = True
        Me.HDBSwitch.Location = New System.Drawing.Point(220, 76)
        Me.HDBSwitch.Name = "HDBSwitch"
        Me.HDBSwitch.Size = New System.Drawing.Size(129, 17)
        Me.HDBSwitch.TabIndex = 0
        Me.HDBSwitch.TabStop = True
        Me.HDBSwitch.Text = "Default background"
        Me.HDBSwitch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 52)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Enabling the background will disable the default" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "background or colour. When pick" &
    "ing a background" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "make sure you have set up a dedicated folder that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hub ESR can" &
    " read the file from."
        '
        'CB1Button
        '
        Me.CB1Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CB1Button.Location = New System.Drawing.Point(442, 122)
        Me.CB1Button.Name = "CB1Button"
        Me.CB1Button.Size = New System.Drawing.Size(62, 23)
        Me.CB1Button.TabIndex = 3
        Me.CB1Button.Text = "Browse..."
        Me.ToolTip1.SetToolTip(Me.CB1Button, "Browse for a hub background...")
        Me.CB1Button.UseVisualStyleBackColor = True
        '
        'HubBackgroundPicture
        '
        Me.HubBackgroundPicture.Location = New System.Drawing.Point(6, 21)
        Me.HubBackgroundPicture.Name = "HubBackgroundPicture"
        Me.HubBackgroundPicture.Size = New System.Drawing.Size(208, 125)
        Me.HubBackgroundPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HubBackgroundPicture.TabIndex = 2
        Me.HubBackgroundPicture.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CustomColourBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(528, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Colours"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CustomColourBox
        '
        Me.CustomColourBox.Controls.Add(Me.PictureBox2)
        Me.CustomColourBox.Controls.Add(Me.CCEBox)
        Me.CustomColourBox.Controls.Add(Me.CustomColourLabel)
        Me.CustomColourBox.Controls.Add(Me.CustomColourButton)
        Me.CustomColourBox.Location = New System.Drawing.Point(6, 6)
        Me.CustomColourBox.Name = "CustomColourBox"
        Me.CustomColourBox.Size = New System.Drawing.Size(516, 59)
        Me.CustomColourBox.TabIndex = 7
        Me.CustomColourBox.TabStop = False
        Me.CustomColourBox.Text = "Colour"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ss.My.Resources.Resources.ssUIColours
        Me.PictureBox2.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'CCEBox
        '
        Me.CCEBox.AutoSize = True
        Me.CCEBox.Checked = True
        Me.CCEBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CCEBox.Location = New System.Drawing.Point(44, 36)
        Me.CCEBox.Name = "CCEBox"
        Me.CCEBox.Size = New System.Drawing.Size(142, 17)
        Me.CCEBox.TabIndex = 8
        Me.CCEBox.Text = "Enable custom colours"
        Me.CCEBox.UseVisualStyleBackColor = True
        Me.CCEBox.Visible = False
        '
        'CustomColourLabel
        '
        Me.CustomColourLabel.AutoSize = True
        Me.CustomColourLabel.Location = New System.Drawing.Point(41, 21)
        Me.CustomColourLabel.Name = "CustomColourLabel"
        Me.CustomColourLabel.Size = New System.Drawing.Size(230, 13)
        Me.CustomColourLabel.TabIndex = 7
        Me.CustomColourLabel.Text = "Set your own colour by clicking the button."
        '
        'CustomColourButton
        '
        Me.CustomColourButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CustomColourButton.Location = New System.Drawing.Point(352, 21)
        Me.CustomColourButton.Name = "CustomColourButton"
        Me.CustomColourButton.Size = New System.Drawing.Size(158, 32)
        Me.CustomColourButton.TabIndex = 0
        Me.CustomColourButton.Text = "Select your colour..."
        Me.CustomColourButton.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SoundBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(528, 323)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sounds"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SoundBox
        '
        Me.SoundBox.Controls.Add(Me.Label3)
        Me.SoundBox.Controls.Add(Me.MuteSoundSwitch)
        Me.SoundBox.Controls.Add(Me.PictureBox7)
        Me.SoundBox.Controls.Add(Me.DefaultSoundSwitch)
        Me.SoundBox.Controls.Add(Me.ModernSoundSwitch)
        Me.SoundBox.Location = New System.Drawing.Point(6, 6)
        Me.SoundBox.Name = "SoundBox"
        Me.SoundBox.Size = New System.Drawing.Size(516, 61)
        Me.SoundBox.TabIndex = 4
        Me.SoundBox.TabStop = False
        Me.SoundBox.Text = "Sounds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Below you can change the sound scheme."
        '
        'MuteSoundSwitch
        '
        Me.MuteSoundSwitch.AutoSize = True
        Me.MuteSoundSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MuteSoundSwitch.Location = New System.Drawing.Point(197, 35)
        Me.MuteSoundSwitch.Name = "MuteSoundSwitch"
        Me.MuteSoundSwitch.Size = New System.Drawing.Size(58, 18)
        Me.MuteSoundSwitch.TabIndex = 2
        Me.MuteSoundSwitch.TabStop = True
        Me.MuteSoundSwitch.Text = "Mute"
        Me.MuteSoundSwitch.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ss.My.Resources.Resources.ssSounds
        Me.PictureBox7.Location = New System.Drawing.Point(6, 21)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        '
        'DefaultSoundSwitch
        '
        Me.DefaultSoundSwitch.AutoSize = True
        Me.DefaultSoundSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DefaultSoundSwitch.Location = New System.Drawing.Point(44, 35)
        Me.DefaultSoundSwitch.Name = "DefaultSoundSwitch"
        Me.DefaultSoundSwitch.Size = New System.Drawing.Size(69, 18)
        Me.DefaultSoundSwitch.TabIndex = 0
        Me.DefaultSoundSwitch.Text = "Default"
        Me.DefaultSoundSwitch.UseVisualStyleBackColor = True
        '
        'ModernSoundSwitch
        '
        Me.ModernSoundSwitch.AutoSize = True
        Me.ModernSoundSwitch.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ModernSoundSwitch.Location = New System.Drawing.Point(119, 35)
        Me.ModernSoundSwitch.Name = "ModernSoundSwitch"
        Me.ModernSoundSwitch.Size = New System.Drawing.Size(72, 18)
        Me.ModernSoundSwitch.TabIndex = 1
        Me.ModernSoundSwitch.Text = "Modern"
        Me.ModernSoundSwitch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 53)
        Me.Panel1.TabIndex = 2
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
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(54, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(283, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Personalise your experience..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Title = "Choose Hub Background..."
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Title = "Choose Welcome/Exit Background..."
        '
        'sssettingspanelpersonalise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(560, 420)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sssettingspanelpersonalise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel > Personalise"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.WelcomeBackgroundBox.ResumeLayout(False)
        Me.WelcomeBackgroundBox.PerformLayout()
        CType(Me.WelcomeBackgroundPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HubBackgroundBox.ResumeLayout(False)
        Me.HubBackgroundBox.PerformLayout()
        CType(Me.HubBackgroundPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.CustomColourBox.ResumeLayout(False)
        Me.CustomColourBox.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.SoundBox.ResumeLayout(False)
        Me.SoundBox.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents WelcomeBackgroundBox As GroupBox
    Friend WithEvents WelcomeBackgroundPicture As PictureBox
    Friend WithEvents HubBackgroundBox As GroupBox
    Friend WithEvents HubBackgroundPicture As PictureBox
    Friend WithEvents CustomColourButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents SoundBox As GroupBox
    Friend WithEvents MuteSoundSwitch As RadioButton
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents DefaultSoundSwitch As RadioButton
    Friend WithEvents ModernSoundSwitch As RadioButton
    Friend WithEvents CustomColourBox As GroupBox
    Friend WithEvents CustomColourLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents CCEBox As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CB2Button As System.Windows.Forms.Button
    Friend WithEvents CB1Button As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WUCSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents WDBSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HUCSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents HDBSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents RB2Box As System.Windows.Forms.RadioButton
    Friend WithEvents RB1Box As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
