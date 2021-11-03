<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssoobepersonalisationsounds
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MuteSoundSwitch = New System.Windows.Forms.RadioButton()
        Me.DefaultSoundSwitch = New System.Windows.Forms.RadioButton()
        Me.ModernSoundSwitch = New System.Windows.Forms.RadioButton()
        Me.WLSOOBEBackground = New System.Windows.Forms.PictureBox()
        CType(Me.WLSOOBEBackground, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(440, 37)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "1. > 2. > 3. Personalisation (Sounds)"
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
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "These settings personalise your experience." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can set these up to your liking " &
    "right now or do it later from the Settings Panel."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(406, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Choose your sound scheme..."
        '
        'MuteSoundSwitch
        '
        Me.MuteSoundSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MuteSoundSwitch.AutoSize = True
        Me.MuteSoundSwitch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MuteSoundSwitch.ForeColor = System.Drawing.Color.White
        Me.MuteSoundSwitch.Location = New System.Drawing.Point(470, 262)
        Me.MuteSoundSwitch.Name = "MuteSoundSwitch"
        Me.MuteSoundSwitch.Size = New System.Drawing.Size(64, 25)
        Me.MuteSoundSwitch.TabIndex = 4
        Me.MuteSoundSwitch.TabStop = True
        Me.MuteSoundSwitch.Text = "Mute"
        Me.MuteSoundSwitch.UseVisualStyleBackColor = True
        '
        'DefaultSoundSwitch
        '
        Me.DefaultSoundSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DefaultSoundSwitch.AutoSize = True
        Me.DefaultSoundSwitch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultSoundSwitch.ForeColor = System.Drawing.Color.White
        Me.DefaultSoundSwitch.Location = New System.Drawing.Point(470, 216)
        Me.DefaultSoundSwitch.Name = "DefaultSoundSwitch"
        Me.DefaultSoundSwitch.Size = New System.Drawing.Size(78, 25)
        Me.DefaultSoundSwitch.TabIndex = 1
        Me.DefaultSoundSwitch.Text = "Default"
        Me.DefaultSoundSwitch.UseVisualStyleBackColor = True
        '
        'ModernSoundSwitch
        '
        Me.ModernSoundSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ModernSoundSwitch.AutoSize = True
        Me.ModernSoundSwitch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModernSoundSwitch.ForeColor = System.Drawing.Color.White
        Me.ModernSoundSwitch.Location = New System.Drawing.Point(470, 239)
        Me.ModernSoundSwitch.Name = "ModernSoundSwitch"
        Me.ModernSoundSwitch.Size = New System.Drawing.Size(83, 25)
        Me.ModernSoundSwitch.TabIndex = 2
        Me.ModernSoundSwitch.Text = "Modern"
        Me.ModernSoundSwitch.UseVisualStyleBackColor = True
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
        'ssoobepersonalisationsounds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1022, 643)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MuteSoundSwitch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RMLButton)
        Me.Controls.Add(Me.ModernSoundSwitch)
        Me.Controls.Add(Me.DefaultSoundSwitch)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WLSOOBEBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ssoobepersonalisationsounds"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hub Settings - OOBE"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WLSOOBEBackground, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MuteSoundSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents DefaultSoundSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents ModernSoundSwitch As System.Windows.Forms.RadioButton
End Class
