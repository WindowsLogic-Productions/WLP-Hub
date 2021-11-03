<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ssmusic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssmusic))
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MillisecondsS = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatPlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpCentreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnmuteButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.MuteButton = New System.Windows.Forms.Button()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(399, 344)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(113, 44)
        Me.TrackBar1.TabIndex = 8
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar1.Value = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Music Status: Awaiting Input"
        '
        'AxWindowsMediaPlayer2
        '
        Me.AxWindowsMediaPlayer2.Enabled = True
        Me.AxWindowsMediaPlayer2.Location = New System.Drawing.Point(17, 62)
        Me.AxWindowsMediaPlayer2.Name = "AxWindowsMediaPlayer2"
        Me.AxWindowsMediaPlayer2.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer2.Size = New System.Drawing.Size(497, 244)
        Me.AxWindowsMediaPlayer2.TabIndex = 4
        '
        'TrackBar2
        '
        Me.TrackBar2.AutoSize = False
        Me.TrackBar2.Location = New System.Drawing.Point(10, 311)
        Me.TrackBar2.Maximum = 100
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(396, 42)
        Me.TrackBar2.TabIndex = 17
        Me.TrackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(518, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 360)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Playlist"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 21)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(144, 329)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(6, 21)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(144, 329)
        Me.ListBox2.TabIndex = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'MillisecondsS
        '
        Me.MillisecondsS.AutoSize = True
        Me.MillisecondsS.BackColor = System.Drawing.Color.Transparent
        Me.MillisecondsS.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MillisecondsS.ForeColor = System.Drawing.Color.White
        Me.MillisecondsS.Location = New System.Drawing.Point(410, 320)
        Me.MillisecondsS.Name = "MillisecondsS"
        Me.MillisecondsS.Size = New System.Drawing.Size(40, 13)
        Me.MillisecondsS.TabIndex = 41
        Me.MillisecondsS.Text = "00.000"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(678, 24)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaylistToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PlaylistToolStripMenuItem
        '
        Me.PlaylistToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssOpen
        Me.PlaylistToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PlaylistToolStripMenuItem.Name = "PlaylistToolStripMenuItem"
        Me.PlaylistToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PlaylistToolStripMenuItem.Size = New System.Drawing.Size(215, 38)
        Me.PlaylistToolStripMenuItem.Text = "Playlist Creator..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(212, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssExit
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(215, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RepeatToolStripMenuItem, Me.RepeatPlaylistToolStripMenuItem, Me.ShuffleToolStripMenuItem})
        Me.OptionsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.OptionsToolStripMenuItem.Text = "Play"
        '
        'RepeatToolStripMenuItem
        '
        Me.RepeatToolStripMenuItem.CheckOnClick = True
        Me.RepeatToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem"
        Me.RepeatToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RepeatToolStripMenuItem.Text = "Repeat Song"
        '
        'RepeatPlaylistToolStripMenuItem
        '
        Me.RepeatPlaylistToolStripMenuItem.CheckOnClick = True
        Me.RepeatPlaylistToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RepeatPlaylistToolStripMenuItem.Name = "RepeatPlaylistToolStripMenuItem"
        Me.RepeatPlaylistToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RepeatPlaylistToolStripMenuItem.Text = "Repeat Playlist"
        '
        'ShuffleToolStripMenuItem
        '
        Me.ShuffleToolStripMenuItem.CheckOnClick = True
        Me.ShuffleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ShuffleToolStripMenuItem.Name = "ShuffleToolStripMenuItem"
        Me.ShuffleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShuffleToolStripMenuItem.Text = "Shuffle"
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
        'UnmuteButton
        '
        Me.UnmuteButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UnmuteButton.Image = Global.ss.My.Resources.Resources.ssMute
        Me.UnmuteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UnmuteButton.Location = New System.Drawing.Point(351, 344)
        Me.UnmuteButton.Name = "UnmuteButton"
        Me.UnmuteButton.Size = New System.Drawing.Size(42, 44)
        Me.UnmuteButton.TabIndex = 12
        Me.UnmuteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UnmuteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UnmuteButton.UseVisualStyleBackColor = True
        Me.UnmuteButton.Visible = False
        '
        'PlayButton
        '
        Me.PlayButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PlayButton.Image = CType(resources.GetObject("PlayButton.Image"), System.Drawing.Image)
        Me.PlayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PlayButton.Location = New System.Drawing.Point(12, 344)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(78, 44)
        Me.PlayButton.TabIndex = 5
        Me.PlayButton.Text = "Play"
        Me.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'PauseButton
        '
        Me.PauseButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PauseButton.Image = CType(resources.GetObject("PauseButton.Image"), System.Drawing.Image)
        Me.PauseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PauseButton.Location = New System.Drawing.Point(12, 344)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(78, 44)
        Me.PauseButton.TabIndex = 6
        Me.PauseButton.Text = "Pause"
        Me.PauseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NextButton.Image = Global.ss.My.Resources.Resources.ssNextTrack
        Me.NextButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NextButton.Location = New System.Drawing.Point(275, 344)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(70, 44)
        Me.NextButton.TabIndex = 10
        Me.NextButton.Text = "Next"
        Me.NextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StopButton.Image = Global.ss.My.Resources.Resources.ssStop
        Me.StopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StopButton.Location = New System.Drawing.Point(96, 344)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(77, 44)
        Me.StopButton.TabIndex = 7
        Me.StopButton.Text = "Stop"
        Me.StopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PreviousButton.Image = Global.ss.My.Resources.Resources.ssPreviousTrack
        Me.PreviousButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PreviousButton.Location = New System.Drawing.Point(179, 344)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(90, 44)
        Me.PreviousButton.TabIndex = 9
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'MuteButton
        '
        Me.MuteButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MuteButton.Image = Global.ss.My.Resources.Resources.ssUnmute
        Me.MuteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MuteButton.Location = New System.Drawing.Point(351, 344)
        Me.MuteButton.Name = "MuteButton"
        Me.MuteButton.Size = New System.Drawing.Size(42, 44)
        Me.MuteButton.TabIndex = 11
        Me.MuteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.MuteButton.UseVisualStyleBackColor = True
        '
        'ssmusic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(678, 398)
        Me.Controls.Add(Me.MillisecondsS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer2)
        Me.Controls.Add(Me.UnmuteButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.MuteButton)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ssmusic"
        Me.Text = "Music"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents PauseButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents MuteButton As System.Windows.Forms.Button
    Friend WithEvents UnmuteButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MillisecondsS As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaylistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpCentreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShuffleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatPlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
