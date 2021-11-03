<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssalarm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssalarm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoundsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChimesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XylophoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JingleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BounceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EchoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpCentreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "00:00:00"
        Me.ToolTip1.SetToolTip(Me.Label1, "Digital clock.")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(173, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Alarm Set"
        Me.Label2.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 56)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(147, 135)
        Me.WebBrowser1.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.WebBrowser1, "Analogue clock.")
        Me.WebBrowser1.Url = New System.Uri("http://www.gheos.net/js/clock/clock.swf", System.UriKind.Absolute)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 22)
        Me.TextBox1.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Set when the alarm goes off.")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SoundsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(250, 24)
        Me.MenuStrip1.TabIndex = 13
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SoundsToolStripMenuItem
        '
        Me.SoundsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChimesToolStripMenuItem, Me.XylophoneToolStripMenuItem, Me.ChordsToolStripMenuItem, Me.TapToolStripMenuItem, Me.JingleToolStripMenuItem, Me.TransitionToolStripMenuItem, Me.DescendingToolStripMenuItem, Me.BounceToolStripMenuItem, Me.EchoToolStripMenuItem, Me.AscendingToolStripMenuItem})
        Me.SoundsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SoundsToolStripMenuItem.Name = "SoundsToolStripMenuItem"
        Me.SoundsToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SoundsToolStripMenuItem.Text = "Sounds"
        '
        'ChimesToolStripMenuItem
        '
        Me.ChimesToolStripMenuItem.CheckOnClick = True
        Me.ChimesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ChimesToolStripMenuItem.Name = "ChimesToolStripMenuItem"
        Me.ChimesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChimesToolStripMenuItem.Text = "Chimes"
        '
        'XylophoneToolStripMenuItem
        '
        Me.XylophoneToolStripMenuItem.CheckOnClick = True
        Me.XylophoneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.XylophoneToolStripMenuItem.Name = "XylophoneToolStripMenuItem"
        Me.XylophoneToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.XylophoneToolStripMenuItem.Text = "Xylophone"
        '
        'ChordsToolStripMenuItem
        '
        Me.ChordsToolStripMenuItem.CheckOnClick = True
        Me.ChordsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ChordsToolStripMenuItem.Name = "ChordsToolStripMenuItem"
        Me.ChordsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChordsToolStripMenuItem.Text = "Chords"
        '
        'TapToolStripMenuItem
        '
        Me.TapToolStripMenuItem.CheckOnClick = True
        Me.TapToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TapToolStripMenuItem.Name = "TapToolStripMenuItem"
        Me.TapToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TapToolStripMenuItem.Text = "Tap"
        '
        'JingleToolStripMenuItem
        '
        Me.JingleToolStripMenuItem.CheckOnClick = True
        Me.JingleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.JingleToolStripMenuItem.Name = "JingleToolStripMenuItem"
        Me.JingleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JingleToolStripMenuItem.Text = "Jingle"
        '
        'TransitionToolStripMenuItem
        '
        Me.TransitionToolStripMenuItem.CheckOnClick = True
        Me.TransitionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TransitionToolStripMenuItem.Name = "TransitionToolStripMenuItem"
        Me.TransitionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TransitionToolStripMenuItem.Text = "Transition"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.CheckOnClick = True
        Me.DescendingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'BounceToolStripMenuItem
        '
        Me.BounceToolStripMenuItem.CheckOnClick = True
        Me.BounceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BounceToolStripMenuItem.Name = "BounceToolStripMenuItem"
        Me.BounceToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BounceToolStripMenuItem.Text = "Bounce"
        '
        'EchoToolStripMenuItem
        '
        Me.EchoToolStripMenuItem.CheckOnClick = True
        Me.EchoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EchoToolStripMenuItem.Name = "EchoToolStripMenuItem"
        Me.EchoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EchoToolStripMenuItem.Text = "Echo"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.CheckOnClick = True
        Me.AscendingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
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
        Me.HelpCentreToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.HelpCentreToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssInfo
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ss.My.Resources.Resources.ssSet
        Me.PictureBox1.Location = New System.Drawing.Point(184, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(165, 139)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(75, 23)
        Me.SetButton.TabIndex = 16
        Me.SetButton.Text = "Set Alarm"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(165, 168)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 23)
        Me.StopButton.TabIndex = 17
        Me.StopButton.Text = "Stop Alarm"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ssalarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(250, 242)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.SetButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ssalarm"
        Me.Text = "Alarm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpCentreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SoundsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChimesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XylophoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JingleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BounceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EchoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SetButton As Button
    Friend WithEvents StopButton As Button
End Class
