<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssoobewls
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssoobewls))
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RMLButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.WLSOOBEBackground = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.WLSOOBEBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordBox
        '
        Me.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.Location = New System.Drawing.Point(367, 209)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(232, 29)
        Me.PasswordBox.TabIndex = 13
        '
        'UsernameBox
        '
        Me.UsernameBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UsernameBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameBox.Location = New System.Drawing.Point(367, 174)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(232, 29)
        Me.UsernameBox.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(281, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Password:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(277, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(829, 60)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "The WLP Hub Locking System enables security features built into WLP Hub." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Before " &
    "these security features are enabled, you need to enter a username and password."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 37)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "1. WLP Hub Locking System"
        '
        'RMLButton
        '
        Me.RMLButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RMLButton.BackColor = System.Drawing.Color.Transparent
        Me.RMLButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMLButton.Location = New System.Drawing.Point(710, 415)
        Me.RMLButton.Name = "RMLButton"
        Me.RMLButton.Size = New System.Drawing.Size(112, 36)
        Me.RMLButton.TabIndex = 17
        Me.RMLButton.Text = "Do It Later"
        Me.RMLButton.UseVisualStyleBackColor = False
        '
        'ForwardButton
        '
        Me.ForwardButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ForwardButton.BackColor = System.Drawing.Color.Transparent
        Me.ForwardButton.Image = Global.ss.My.Resources.Resources.ssNavigateFoward
        Me.ForwardButton.Location = New System.Drawing.Point(828, 415)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 36)
        Me.ForwardButton.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Save changes and continue.")
        Me.ForwardButton.UseVisualStyleBackColor = False
        '
        'WLSOOBEBackground
        '
        Me.WLSOOBEBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WLSOOBEBackground.Image = Global.ss.My.Resources.Resources.WLPBackground
        Me.WLSOOBEBackground.Location = New System.Drawing.Point(0, 0)
        Me.WLSOOBEBackground.Name = "WLSOOBEBackground"
        Me.WLSOOBEBackground.Size = New System.Drawing.Size(876, 463)
        Me.WLSOOBEBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WLSOOBEBackground.TabIndex = 1
        Me.WLSOOBEBackground.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(98, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(680, 63)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Usernames and passwords are kept local to your system and are not send to a serve" &
    "r of any kind." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you choose to do this process later, click 'Do It Later'."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ssoobewls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(876, 463)
        Me.Controls.Add(Me.RMLButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WLSOOBEBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ssoobewls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WLS - OOBE"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WLSOOBEBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WLSOOBEBackground As System.Windows.Forms.PictureBox
    Friend WithEvents PasswordBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ForwardButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents RMLButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
