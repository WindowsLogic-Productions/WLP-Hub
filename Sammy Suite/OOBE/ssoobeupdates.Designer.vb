<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssoobeupdates
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
        Me.AdhocUpdatesSwitch = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DisableUpdatesSwitch = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EnableUpdatesSwitch = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(405, 37)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = " 1. > 2. > 3. > 4. > 5. > 6. Updates"
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
        Me.Label4.Location = New System.Drawing.Point(126, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(771, 60)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "These settings change how your computer handles updates." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can set these up to" &
    " your liking right now or do it later from the Settings Panel."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AdhocUpdatesSwitch
        '
        Me.AdhocUpdatesSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AdhocUpdatesSwitch.AutoSize = True
        Me.AdhocUpdatesSwitch.BackColor = System.Drawing.Color.Transparent
        Me.AdhocUpdatesSwitch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdhocUpdatesSwitch.ForeColor = System.Drawing.Color.White
        Me.AdhocUpdatesSwitch.Location = New System.Drawing.Point(172, 228)
        Me.AdhocUpdatesSwitch.Name = "AdhocUpdatesSwitch"
        Me.AdhocUpdatesSwitch.Size = New System.Drawing.Size(264, 25)
        Me.AdhocUpdatesSwitch.TabIndex = 31
        Me.AdhocUpdatesSwitch.Text = "Enable adhoc updates (suggested)"
        Me.AdhocUpdatesSwitch.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(172, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(417, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Adhoc updates will only check for updates when the application starts."
        '
        'DisableUpdatesSwitch
        '
        Me.DisableUpdatesSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DisableUpdatesSwitch.AutoSize = True
        Me.DisableUpdatesSwitch.BackColor = System.Drawing.Color.Transparent
        Me.DisableUpdatesSwitch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisableUpdatesSwitch.ForeColor = System.Drawing.Color.White
        Me.DisableUpdatesSwitch.Location = New System.Drawing.Point(172, 276)
        Me.DisableUpdatesSwitch.Name = "DisableUpdatesSwitch"
        Me.DisableUpdatesSwitch.Size = New System.Drawing.Size(383, 25)
        Me.DisableUpdatesSwitch.TabIndex = 29
        Me.DisableUpdatesSwitch.Text = "Disable updates (not suggested nor recommended)"
        Me.DisableUpdatesSwitch.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(172, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(384, 17)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Disabling updates will stop the application checking for updates."
        '
        'EnableUpdatesSwitch
        '
        Me.EnableUpdatesSwitch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EnableUpdatesSwitch.AutoSize = True
        Me.EnableUpdatesSwitch.BackColor = System.Drawing.Color.Transparent
        Me.EnableUpdatesSwitch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnableUpdatesSwitch.ForeColor = System.Drawing.Color.White
        Me.EnableUpdatesSwitch.Location = New System.Drawing.Point(172, 180)
        Me.EnableUpdatesSwitch.Name = "EnableUpdatesSwitch"
        Me.EnableUpdatesSwitch.Size = New System.Drawing.Size(320, 25)
        Me.EnableUpdatesSwitch.TabIndex = 27
        Me.EnableUpdatesSwitch.Text = "Enable persistant updates (recommended)"
        Me.EnableUpdatesSwitch.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(172, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(679, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Persistant updates will check for updates throughout your usage of the applicatio" &
    "n and will notify you if it finds any."
        '
        'ssoobeupdates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1022, 643)
        Me.Controls.Add(Me.AdhocUpdatesSwitch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DisableUpdatesSwitch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EnableUpdatesSwitch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RMLButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WLSOOBEBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ssoobeupdates"
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
    Friend WithEvents AdhocUpdatesSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DisableUpdatesSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EnableUpdatesSwitch As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
