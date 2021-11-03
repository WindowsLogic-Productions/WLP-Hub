<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sscdplayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sscdplayer))
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.MillisecondsS = New System.Windows.Forms.Label()
        Me.Colon2S = New System.Windows.Forms.Label()
        Me.Colon1S = New System.Windows.Forms.Label()
        Me.MinutesS = New System.Windows.Forms.Label()
        Me.SecondsS = New System.Windows.Forms.Label()
        Me.TrackS = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaybackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpCentreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(236, 12)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(128, 22)
        Me.NumericUpDown1.TabIndex = 33
        Me.NumericUpDown1.Visible = False
        '
        'MillisecondsS
        '
        Me.MillisecondsS.AutoSize = True
        Me.MillisecondsS.BackColor = System.Drawing.Color.Black
        Me.MillisecondsS.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MillisecondsS.ForeColor = System.Drawing.Color.Lime
        Me.MillisecondsS.Location = New System.Drawing.Point(148, 56)
        Me.MillisecondsS.Name = "MillisecondsS"
        Me.MillisecondsS.Size = New System.Drawing.Size(35, 30)
        Me.MillisecondsS.TabIndex = 32
        Me.MillisecondsS.Text = "00"
        '
        'Colon2S
        '
        Me.Colon2S.AutoSize = True
        Me.Colon2S.BackColor = System.Drawing.Color.Black
        Me.Colon2S.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colon2S.ForeColor = System.Drawing.Color.Lime
        Me.Colon2S.Location = New System.Drawing.Point(124, 56)
        Me.Colon2S.Name = "Colon2S"
        Me.Colon2S.Size = New System.Drawing.Size(18, 30)
        Me.Colon2S.TabIndex = 40
        Me.Colon2S.Text = ":"
        '
        'Colon1S
        '
        Me.Colon1S.AutoSize = True
        Me.Colon1S.BackColor = System.Drawing.Color.Black
        Me.Colon1S.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colon1S.ForeColor = System.Drawing.Color.Lime
        Me.Colon1S.Location = New System.Drawing.Point(59, 56)
        Me.Colon1S.Name = "Colon1S"
        Me.Colon1S.Size = New System.Drawing.Size(18, 30)
        Me.Colon1S.TabIndex = 39
        Me.Colon1S.Text = ":"
        '
        'MinutesS
        '
        Me.MinutesS.AutoSize = True
        Me.MinutesS.BackColor = System.Drawing.Color.Black
        Me.MinutesS.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesS.ForeColor = System.Drawing.Color.Lime
        Me.MinutesS.Location = New System.Drawing.Point(18, 56)
        Me.MinutesS.Name = "MinutesS"
        Me.MinutesS.Size = New System.Drawing.Size(35, 30)
        Me.MinutesS.TabIndex = 38
        Me.MinutesS.Text = "00"
        '
        'SecondsS
        '
        Me.SecondsS.AutoSize = True
        Me.SecondsS.BackColor = System.Drawing.Color.Black
        Me.SecondsS.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsS.ForeColor = System.Drawing.Color.Lime
        Me.SecondsS.Location = New System.Drawing.Point(83, 56)
        Me.SecondsS.Name = "SecondsS"
        Me.SecondsS.Size = New System.Drawing.Size(35, 30)
        Me.SecondsS.TabIndex = 37
        Me.SecondsS.Text = "00"
        '
        'TrackS
        '
        Me.TrackS.AutoSize = True
        Me.TrackS.BackColor = System.Drawing.Color.Black
        Me.TrackS.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackS.ForeColor = System.Drawing.Color.Lime
        Me.TrackS.Location = New System.Drawing.Point(32, 15)
        Me.TrackS.Name = "TrackS"
        Me.TrackS.Size = New System.Drawing.Size(135, 30)
        Me.TrackS.TabIndex = 30
        Me.TrackS.Text = "Track: 00 / 00"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(213, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 21)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "CD Status: Please Insert CD"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlaybackToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(425, 24)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssExit
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PlaybackToolStripMenuItem
        '
        Me.PlaybackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.StopToolStripMenuItem, Me.PreviousToolStripMenuItem, Me.NextToolStripMenuItem, Me.EjectToolStripMenuItem})
        Me.PlaybackToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PlaybackToolStripMenuItem.Name = "PlaybackToolStripMenuItem"
        Me.PlaybackToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PlaybackToolStripMenuItem.Text = "Playback"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Image = CType(resources.GetObject("PlayToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlayToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(135, 38)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssStop
        Me.StopToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(135, 38)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssPreviousTrack
        Me.PreviousToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(135, 38)
        Me.PreviousToolStripMenuItem.Text = "Previous"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssNextTrack
        Me.NextToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(135, 38)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'EjectToolStripMenuItem
        '
        Me.EjectToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssEject
        Me.EjectToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EjectToolStripMenuItem.Name = "EjectToolStripMenuItem"
        Me.EjectToolStripMenuItem.Size = New System.Drawing.Size(135, 38)
        Me.EjectToolStripMenuItem.Text = "Eject"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpCentreToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpCentreToolStripMenuItem
        '
        Me.HelpCentreToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssQuestion
        Me.HelpCentreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpCentreToolStripMenuItem.Name = "HelpCentreToolStripMenuItem"
        Me.HelpCentreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpCentreToolStripMenuItem.Size = New System.Drawing.Size(142, 38)
        Me.HelpCentreToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(139, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssInfo
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 38)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.TrackS)
        Me.Panel1.Controls.Add(Me.Colon1S)
        Me.Panel1.Controls.Add(Me.MillisecondsS)
        Me.Panel1.Controls.Add(Me.SecondsS)
        Me.Panel1.Controls.Add(Me.Colon2S)
        Me.Panel1.Controls.Add(Me.MinutesS)
        Me.Panel1.Location = New System.Drawing.Point(213, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 46
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Image = Global.ss.My.Resources.Resources.ssEject
        Me.Button3.Location = New System.Drawing.Point(12, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 39)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Eject"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = Global.ss.My.Resources.Resources.ssStop
        Me.Button1.Location = New System.Drawing.Point(108, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Stop"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button6.Image = Global.ss.My.Resources.Resources.ssPreviousTrack
        Me.Button6.Location = New System.Drawing.Point(12, 80)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 39)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Previous"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Image = Global.ss.My.Resources.Resources.ssNextTrack
        Me.Button4.Location = New System.Drawing.Point(108, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 39)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Next"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(12, 35)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(90, 39)
        Me.Button8.TabIndex = 29
        Me.Button8.Text = "Play"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Image = Global.ss.My.Resources.Resources.ssPause
        Me.Button2.Location = New System.Drawing.Point(12, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 39)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Pause"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'sscdplayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(425, 173)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "sscdplayer"
        Me.Text = "CD Player"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MillisecondsS As System.Windows.Forms.Label
    Friend WithEvents Colon2S As System.Windows.Forms.Label
    Friend WithEvents Colon1S As System.Windows.Forms.Label
    Friend WithEvents MinutesS As System.Windows.Forms.Label
    Friend WithEvents SecondsS As System.Windows.Forms.Label
    Friend WithEvents TrackS As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaybackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpCentreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
