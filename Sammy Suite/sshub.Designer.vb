<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sshub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sshub))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemPreferencesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchComputerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopicsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShutDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitWLPHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShutdownToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartWLPHubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WriterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusicPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageViewerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CDPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SketchPadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeatherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BreakoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoundRecorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchInternetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1024, 735)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 736)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 32)
        Me.Panel1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "WLP Hub"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.FindToolStripMenuItem, Me.HelpToolStripMenuItem, Me.RunToolStripMenuItem, Me.ToolStripSeparator1, Me.ShutDownToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 142)
        '
        'ProgramsToolStripMenuItem
        '
        Me.ProgramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.WriterToolStripMenuItem, Me.MusicPlayerToolStripMenuItem, Me.ImageViewerToolStripMenuItem1, Me.CDPlayerToolStripMenuItem, Me.SketchPadToolStripMenuItem, Me.WeatherToolStripMenuItem, Me.SoundRecorderToolStripMenuItem, Me.GamesToolStripMenuItem})
        Me.ProgramsToolStripMenuItem.Name = "ProgramsToolStripMenuItem"
        Me.ProgramsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ProgramsToolStripMenuItem.Text = "Apps"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemPreferencesToolStripMenuItem1})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SystemPreferencesToolStripMenuItem1
        '
        Me.SystemPreferencesToolStripMenuItem1.Name = "SystemPreferencesToolStripMenuItem1"
        Me.SystemPreferencesToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.SystemPreferencesToolStripMenuItem1.Text = "System Controls"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchComputerToolStripMenuItem1, Me.SearchInternetToolStripMenuItem})
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'SearchComputerToolStripMenuItem1
        '
        Me.SearchComputerToolStripMenuItem1.Name = "SearchComputerToolStripMenuItem1"
        Me.SearchComputerToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.SearchComputerToolStripMenuItem1.Text = "Search PC..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpTopicsToolStripMenuItem1, Me.ToolStripSeparator3, Me.UpdateLogToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpTopicsToolStripMenuItem1
        '
        Me.HelpTopicsToolStripMenuItem1.Name = "HelpTopicsToolStripMenuItem1"
        Me.HelpTopicsToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.HelpTopicsToolStripMenuItem1.Text = "Help Centre"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RunToolStripMenuItem.Text = "Run..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(113, 6)
        '
        'ShutDownToolStripMenuItem
        '
        Me.ShutDownToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShutdownToolStripMenuItem1, Me.RestartToolStripMenuItem, Me.RestartWLPHubToolStripMenuItem, Me.ExitWLPHubToolStripMenuItem})
        Me.ShutDownToolStripMenuItem.Name = "ShutDownToolStripMenuItem"
        Me.ShutDownToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ShutDownToolStripMenuItem.Text = "Power"
        '
        'ExitWLPHubToolStripMenuItem
        '
        Me.ExitWLPHubToolStripMenuItem.Name = "ExitWLPHubToolStripMenuItem"
        Me.ExitWLPHubToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExitWLPHubToolStripMenuItem.Text = "Exit WLP Hub"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(940, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(78, 29)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 11)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(61, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ShutdownToolStripMenuItem1
        '
        Me.ShutdownToolStripMenuItem1.Name = "ShutdownToolStripMenuItem1"
        Me.ShutdownToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.ShutdownToolStripMenuItem1.Text = "Shutdown"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'RestartWLPHubToolStripMenuItem
        '
        Me.RestartWLPHubToolStripMenuItem.Name = "RestartWLPHubToolStripMenuItem"
        Me.RestartWLPHubToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RestartWLPHubToolStripMenuItem.Text = "Restart WLP Hub"
        '
        'UpdateLogToolStripMenuItem
        '
        Me.UpdateLogToolStripMenuItem.Name = "UpdateLogToolStripMenuItem"
        Me.UpdateLogToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateLogToolStripMenuItem.Text = "Update Log"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'WriterToolStripMenuItem
        '
        Me.WriterToolStripMenuItem.Name = "WriterToolStripMenuItem"
        Me.WriterToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.WriterToolStripMenuItem.Text = "Writer"
        '
        'MusicPlayerToolStripMenuItem
        '
        Me.MusicPlayerToolStripMenuItem.Name = "MusicPlayerToolStripMenuItem"
        Me.MusicPlayerToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.MusicPlayerToolStripMenuItem.Text = "Music Player"
        '
        'ImageViewerToolStripMenuItem1
        '
        Me.ImageViewerToolStripMenuItem1.Name = "ImageViewerToolStripMenuItem1"
        Me.ImageViewerToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.ImageViewerToolStripMenuItem1.Text = "Image Viewer"
        '
        'CDPlayerToolStripMenuItem
        '
        Me.CDPlayerToolStripMenuItem.Name = "CDPlayerToolStripMenuItem"
        Me.CDPlayerToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CDPlayerToolStripMenuItem.Text = "CD Player"
        '
        'SketchPadToolStripMenuItem
        '
        Me.SketchPadToolStripMenuItem.Name = "SketchPadToolStripMenuItem"
        Me.SketchPadToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SketchPadToolStripMenuItem.Text = "Sketch Pad"
        '
        'WeatherToolStripMenuItem
        '
        Me.WeatherToolStripMenuItem.Name = "WeatherToolStripMenuItem"
        Me.WeatherToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.WeatherToolStripMenuItem.Text = "Weather"
        '
        'GamesToolStripMenuItem
        '
        Me.GamesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemoryToolStripMenuItem, Me.BreakoutToolStripMenuItem})
        Me.GamesToolStripMenuItem.Name = "GamesToolStripMenuItem"
        Me.GamesToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.GamesToolStripMenuItem.Text = "Games"
        '
        'MemoryToolStripMenuItem
        '
        Me.MemoryToolStripMenuItem.Name = "MemoryToolStripMenuItem"
        Me.MemoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MemoryToolStripMenuItem.Text = "Memory"
        '
        'BreakoutToolStripMenuItem
        '
        Me.BreakoutToolStripMenuItem.Name = "BreakoutToolStripMenuItem"
        Me.BreakoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BreakoutToolStripMenuItem.Text = "Breakout"
        '
        'SoundRecorderToolStripMenuItem
        '
        Me.SoundRecorderToolStripMenuItem.Name = "SoundRecorderToolStripMenuItem"
        Me.SoundRecorderToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SoundRecorderToolStripMenuItem.Text = "Sound Recorder"
        '
        'SearchInternetToolStripMenuItem
        '
        Me.SearchInternetToolStripMenuItem.Name = "SearchInternetToolStripMenuItem"
        Me.SearchInternetToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SearchInternetToolStripMenuItem.Text = "Search Internet..."
        '
        'sshub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "sshub"
        Me.Text = "sshub"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemPreferencesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchComputerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpTopicsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShutDownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ExitWLPHubToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutdownToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartWLPHubToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WriterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MusicPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageViewerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CDPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SketchPadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeatherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoundRecorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GamesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BreakoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchInternetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
