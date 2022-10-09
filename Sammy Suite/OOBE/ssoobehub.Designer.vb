<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssoobehub
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
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.WLSOOBEBackground = New System.Windows.Forms.PictureBox()
        CType(Me.WLSOOBEBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RMLButton
        '
        Me.RMLButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RMLButton.BackColor = System.Drawing.Color.Transparent
        Me.RMLButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMLButton.Location = New System.Drawing.Point(710, 415)
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
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 37)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "1. > 2. Hub"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(53, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(771, 60)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "These settings change the way WLP Hub works." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can set these up to your liking" &
    " right now or do it later from the Settings Panel."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ForwardButton
        '
        Me.ForwardButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ForwardButton.BackColor = System.Drawing.Color.Transparent
        Me.ForwardButton.Image = Global.ss.My.Resources.Resources.ssNavigateFoward
        Me.ForwardButton.Location = New System.Drawing.Point(828, 415)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 36)
        Me.ForwardButton.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Save changes and continue.")
        Me.ForwardButton.UseVisualStyleBackColor = False
        '
        'CheckBox5
        '
        Me.CheckBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.Color.White
        Me.CheckBox5.Location = New System.Drawing.Point(206, 259)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(465, 25)
        Me.CheckBox5.TabIndex = 25
        Me.CheckBox5.Text = "Automatically minimise to system tray when running at startup"
        Me.CheckBox5.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(206, 228)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(196, 25)
        Me.CheckBox3.TabIndex = 24
        Me.CheckBox3.Text = "Enable immersive mode"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(206, 197)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(127, 25)
        Me.CheckBox2.TabIndex = 23
        Me.CheckBox2.Text = "Run at startup"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'WLSOOBEBackground
        '
        Me.WLSOOBEBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WLSOOBEBackground.Image = Global.ss.My.Resources.Resources.WLPBackground
        Me.WLSOOBEBackground.Location = New System.Drawing.Point(0, 0)
        Me.WLSOOBEBackground.Name = "WLSOOBEBackground"
        Me.WLSOOBEBackground.Size = New System.Drawing.Size(876, 463)
        Me.WLSOOBEBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WLSOOBEBackground.TabIndex = 18
        Me.WLSOOBEBackground.TabStop = False
        '
        'ssoobehub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(876, 463)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.RMLButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WLSOOBEBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ssoobehub"
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WLSOOBEBackground As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
End Class
