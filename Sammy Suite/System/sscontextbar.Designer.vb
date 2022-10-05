<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sscontextbar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sscontextbar))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TaskListButton = New System.Windows.Forms.Button()
        Me.PowerButton = New System.Windows.Forms.Button()
        Me.NetworkButton = New System.Windows.Forms.Button()
        Me.SoundButton = New System.Windows.Forms.Button()
        Me.SystemButton = New System.Windows.Forms.Button()
        Me.SystemMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Welcome_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Security_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsTaskManager_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Updates_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Applications_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Calculator_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Writer_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Music_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageView_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.CDPlayer_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SketchPad_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Weather_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Messages_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Alarm_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Mail_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Appointments_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Maps_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.News_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.GIFStudio_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Start_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Skype_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Facebook_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Twitter_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tumblr_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviantArt_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTube_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Google_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyDocuments_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyMusic_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyPictures_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Settings_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsPanel_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProcessList_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemInformation_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.WindowsSettings_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlPanel_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.Network_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceManager_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Registry_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsExplorer_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsVersion_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Search_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnTheInternet_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchSettings_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpAndSupport_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendFeedback_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpCentre_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdates_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateLog_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.About_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.Run_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuickExit_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOff_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemPower_SM = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchBox = New ss.Watermark()
        Me.SystemMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(872, 2)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(69, 26)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "00:00:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "00/00/0000"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Open 'Date and Time' dialogue.")
        '
        'Clock
        '
        Me.Clock.Enabled = True
        Me.Clock.Interval = 1
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Information"
        '
        'TaskListButton
        '
        Me.TaskListButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TaskListButton.Location = New System.Drawing.Point(29, 4)
        Me.TaskListButton.Name = "TaskListButton"
        Me.TaskListButton.Size = New System.Drawing.Size(63, 26)
        Me.TaskListButton.TabIndex = 6
        Me.TaskListButton.Text = "Task List..."
        Me.ToolTip1.SetToolTip(Me.TaskListButton, "View and close currently running tasks.")
        Me.TaskListButton.UseVisualStyleBackColor = True
        '
        'PowerButton
        '
        Me.PowerButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PowerButton.Image = Global.ss.My.Resources.Resources.ssBattery
        Me.PowerButton.Location = New System.Drawing.Point(790, 4)
        Me.PowerButton.Name = "PowerButton"
        Me.PowerButton.Size = New System.Drawing.Size(26, 26)
        Me.PowerButton.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.PowerButton, "Battery Status")
        Me.PowerButton.UseVisualStyleBackColor = True
        '
        'NetworkButton
        '
        Me.NetworkButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NetworkButton.Image = Global.ss.My.Resources.Resources.ssNetworkCentre
        Me.NetworkButton.Location = New System.Drawing.Point(815, 4)
        Me.NetworkButton.Name = "NetworkButton"
        Me.NetworkButton.Size = New System.Drawing.Size(26, 26)
        Me.NetworkButton.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.NetworkButton, "Network Monitor")
        Me.NetworkButton.UseVisualStyleBackColor = True
        '
        'SoundButton
        '
        Me.SoundButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoundButton.Image = Global.ss.My.Resources.Resources.ssSound
        Me.SoundButton.Location = New System.Drawing.Point(840, 4)
        Me.SoundButton.Name = "SoundButton"
        Me.SoundButton.Size = New System.Drawing.Size(26, 26)
        Me.SoundButton.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.SoundButton, "Volume Control")
        Me.SoundButton.UseVisualStyleBackColor = True
        '
        'SystemButton
        '
        Me.SystemButton.Image = Global.ss.My.Resources.Resources.ssWin
        Me.SystemButton.Location = New System.Drawing.Point(4, 4)
        Me.SystemButton.Name = "SystemButton"
        Me.SystemButton.Size = New System.Drawing.Size(26, 26)
        Me.SystemButton.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.SystemButton, "Click here to begin.")
        Me.SystemButton.UseVisualStyleBackColor = True
        '
        'SystemMenu
        '
        Me.SystemMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Welcome_SM, Me.Security_SM, Me.WindowsTaskManager_SM, Me.Updates_SM, Me.ToolStripSeparator6, Me.Applications_SM, Me.SocialToolStripMenuItem1, Me.DocumentsToolStripMenuItem, Me.Settings_SM, Me.Search_SM, Me.HelpAndSupport_SM, Me.Run_SM, Me.ToolStripSeparator8, Me.QuickExit_SM, Me.LogOff_SM, Me.SystemPower_SM})
        Me.SystemMenu.Name = "ContextMenuStrip3"
        Me.SystemMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SystemMenu.Size = New System.Drawing.Size(232, 570)
        '
        'Welcome_SM
        '
        Me.Welcome_SM.Image = CType(resources.GetObject("Welcome_SM.Image"), System.Drawing.Image)
        Me.Welcome_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Welcome_SM.Name = "Welcome_SM"
        Me.Welcome_SM.Size = New System.Drawing.Size(231, 38)
        Me.Welcome_SM.Text = "Show Welcome Dialogue..."
        Me.Welcome_SM.ToolTipText = "Opens the welcome dialogue."
        '
        'Security_SM
        '
        Me.Security_SM.Image = Global.ss.My.Resources.Resources.ssSystemInfo
        Me.Security_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Security_SM.Name = "Security_SM"
        Me.Security_SM.Size = New System.Drawing.Size(231, 38)
        Me.Security_SM.Text = "Hub ESR Security..."
        Me.Security_SM.ToolTipText = "View the Hub ESR security options."
        '
        'WindowsTaskManager_SM
        '
        Me.WindowsTaskManager_SM.Image = Global.ss.My.Resources.Resources.ssTaskMgr
        Me.WindowsTaskManager_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WindowsTaskManager_SM.Name = "WindowsTaskManager_SM"
        Me.WindowsTaskManager_SM.Size = New System.Drawing.Size(231, 38)
        Me.WindowsTaskManager_SM.Text = "Windows Task Manager..."
        Me.WindowsTaskManager_SM.ToolTipText = "View real-time information about this computer."
        '
        'Updates_SM
        '
        Me.Updates_SM.Image = Global.ss.My.Resources.Resources.ssUpdate
        Me.Updates_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Updates_SM.Name = "Updates_SM"
        Me.Updates_SM.Size = New System.Drawing.Size(231, 38)
        Me.Updates_SM.Text = "Updates..."
        Me.Updates_SM.ToolTipText = "Opens the Updates Settings Panel."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(228, 6)
        '
        'Applications_SM
        '
        Me.Applications_SM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Calculator_SM, Me.Writer_SM, Me.Music_SM, Me.ImageView_SM, Me.CDPlayer_SM, Me.SketchPad_SM, Me.Weather_SM, Me.Messages_SM, Me.Alarm_SM, Me.Mail_SM, Me.Appointments_SM, Me.Maps_SM, Me.News_SM, Me.GIFStudio_SM, Me.ToolStripSeparator1, Me.Start_SM})
        Me.Applications_SM.Image = Global.ss.My.Resources.Resources.ssTasklist
        Me.Applications_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Applications_SM.Name = "Applications_SM"
        Me.Applications_SM.Size = New System.Drawing.Size(231, 38)
        Me.Applications_SM.Text = "Applications"
        Me.Applications_SM.ToolTipText = "Applications to help you use the computer more efficiently."
        '
        'Calculator_SM
        '
        Me.Calculator_SM.Image = CType(resources.GetObject("Calculator_SM.Image"), System.Drawing.Image)
        Me.Calculator_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Calculator_SM.Name = "Calculator_SM"
        Me.Calculator_SM.Size = New System.Drawing.Size(168, 38)
        Me.Calculator_SM.Text = "Calculator"
        Me.Calculator_SM.ToolTipText = "Calculate simple and complex sums and look up mathematical terms."
        '
        'Writer_SM
        '
        Me.Writer_SM.Image = Global.ss.My.Resources.Resources.ssWriter
        Me.Writer_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Writer_SM.Name = "Writer_SM"
        Me.Writer_SM.Size = New System.Drawing.Size(168, 38)
        Me.Writer_SM.Text = "Writer"
        Me.Writer_SM.ToolTipText = "Create and view documents with extensive formatting."
        '
        'Music_SM
        '
        Me.Music_SM.Image = Global.ss.My.Resources.Resources.ssMusic
        Me.Music_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Music_SM.Name = "Music_SM"
        Me.Music_SM.Size = New System.Drawing.Size(168, 38)
        Me.Music_SM.Text = "Music"
        Me.Music_SM.ToolTipText = "Play your favourite music."
        '
        'ImageView_SM
        '
        Me.ImageView_SM.Image = CType(resources.GetObject("ImageView_SM.Image"), System.Drawing.Image)
        Me.ImageView_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ImageView_SM.Name = "ImageView_SM"
        Me.ImageView_SM.Size = New System.Drawing.Size(168, 38)
        Me.ImageView_SM.Tag = "View your pictures and photos."
        Me.ImageView_SM.Text = "Image Viewer"
        '
        'CDPlayer_SM
        '
        Me.CDPlayer_SM.Image = Global.ss.My.Resources.Resources.CDPlayer
        Me.CDPlayer_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CDPlayer_SM.Name = "CDPlayer_SM"
        Me.CDPlayer_SM.Size = New System.Drawing.Size(168, 38)
        Me.CDPlayer_SM.Text = "CD Player"
        '
        'SketchPad_SM
        '
        Me.SketchPad_SM.Image = CType(resources.GetObject("SketchPad_SM.Image"), System.Drawing.Image)
        Me.SketchPad_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SketchPad_SM.Name = "SketchPad_SM"
        Me.SketchPad_SM.Size = New System.Drawing.Size(168, 38)
        Me.SketchPad_SM.Text = "Sketch Pad"
        Me.SketchPad_SM.ToolTipText = "Paint pictures and save them to show your friends."
        '
        'Weather_SM
        '
        Me.Weather_SM.Image = Global.ss.My.Resources.Resources.Weather
        Me.Weather_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Weather_SM.Name = "Weather_SM"
        Me.Weather_SM.Size = New System.Drawing.Size(168, 38)
        Me.Weather_SM.Text = "Weather"
        Me.Weather_SM.ToolTipText = "See what the weather is doing."
        '
        'Messages_SM
        '
        Me.Messages_SM.Image = Global.ss.My.Resources.Resources.ssMessages
        Me.Messages_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Messages_SM.Name = "Messages_SM"
        Me.Messages_SM.Size = New System.Drawing.Size(168, 38)
        Me.Messages_SM.Text = "Messages"
        Me.Messages_SM.ToolTipText = "Chat and collaborate with other people using WindowsLogic Productions Hub."
        '
        'Alarm_SM
        '
        Me.Alarm_SM.Image = CType(resources.GetObject("Alarm_SM.Image"), System.Drawing.Image)
        Me.Alarm_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Alarm_SM.Name = "Alarm_SM"
        Me.Alarm_SM.Size = New System.Drawing.Size(168, 38)
        Me.Alarm_SM.Text = "Alarm"
        Me.Alarm_SM.ToolTipText = "Set an alarm or view the time."
        '
        'Mail_SM
        '
        Me.Mail_SM.Image = CType(resources.GetObject("Mail_SM.Image"), System.Drawing.Image)
        Me.Mail_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Mail_SM.Name = "Mail_SM"
        Me.Mail_SM.Size = New System.Drawing.Size(168, 38)
        Me.Mail_SM.Text = "Mail"
        Me.Mail_SM.ToolTipText = "Manage your e-mail."
        '
        'Appointments_SM
        '
        Me.Appointments_SM.Image = CType(resources.GetObject("Appointments_SM.Image"), System.Drawing.Image)
        Me.Appointments_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Appointments_SM.Name = "Appointments_SM"
        Me.Appointments_SM.Size = New System.Drawing.Size(168, 38)
        Me.Appointments_SM.Text = "Appointments"
        Me.Appointments_SM.ToolTipText = "View and edit your appointments."
        '
        'Maps_SM
        '
        Me.Maps_SM.Image = Global.ss.My.Resources.Resources.ssMaps
        Me.Maps_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Maps_SM.Name = "Maps_SM"
        Me.Maps_SM.Size = New System.Drawing.Size(168, 38)
        Me.Maps_SM.Text = "Maps"
        Me.Maps_SM.ToolTipText = "Search up locations or plot routes to places."
        '
        'News_SM
        '
        Me.News_SM.Image = Global.ss.My.Resources.Resources.ssNews
        Me.News_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.News_SM.Name = "News_SM"
        Me.News_SM.Size = New System.Drawing.Size(168, 38)
        Me.News_SM.Text = "News"
        Me.News_SM.ToolTipText = "Find out what's happening in the world."
        '
        'GIFStudio_SM
        '
        Me.GIFStudio_SM.Image = Global.ss.My.Resources.Resources.ssGIFStudio
        Me.GIFStudio_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GIFStudio_SM.Name = "GIFStudio_SM"
        Me.GIFStudio_SM.Size = New System.Drawing.Size(168, 38)
        Me.GIFStudio_SM.Text = "GIF Studio"
        Me.GIFStudio_SM.ToolTipText = "Process Graphic Interchange Format images."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'Start_SM
        '
        Me.Start_SM.Image = Global.ss.My.Resources.Resources.ssWinver
        Me.Start_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Start_SM.Name = "Start_SM"
        Me.Start_SM.Size = New System.Drawing.Size(168, 38)
        Me.Start_SM.Text = "Start"
        Me.Start_SM.ToolTipText = "Get to items on your Start menu."
        '
        'SocialToolStripMenuItem1
        '
        Me.SocialToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Skype_SM, Me.Google_SM, Me.Facebook_SM, Me.Twitter_SM, Me.Tumblr_SM, Me.DeviantArt_SM, Me.YouTube_SM})
        Me.SocialToolStripMenuItem1.Image = Global.ss.My.Resources.Resources.ssSkype
        Me.SocialToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SocialToolStripMenuItem1.Name = "SocialToolStripMenuItem1"
        Me.SocialToolStripMenuItem1.Size = New System.Drawing.Size(231, 38)
        Me.SocialToolStripMenuItem1.Text = "Social"
        Me.SocialToolStripMenuItem1.ToolTipText = "Applets for your social life."
        '
        'Skype_SM
        '
        Me.Skype_SM.Image = Global.ss.My.Resources.Resources.ssSkype
        Me.Skype_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Skype_SM.Name = "Skype_SM"
        Me.Skype_SM.Size = New System.Drawing.Size(168, 38)
        Me.Skype_SM.Text = "Skype"
        Me.Skype_SM.ToolTipText = "Keep in touch with friends and family all over the world."
        '
        'Facebook_SM
        '
        Me.Facebook_SM.Image = Global.ss.My.Resources.Resources.ssFacebook
        Me.Facebook_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Facebook_SM.Name = "Facebook_SM"
        Me.Facebook_SM.Size = New System.Drawing.Size(168, 38)
        Me.Facebook_SM.Text = "Facebook"
        Me.Facebook_SM.ToolTipText = "Socialise with people in your life who are close."
        '
        'Twitter_SM
        '
        Me.Twitter_SM.Image = Global.ss.My.Resources.Resources.ssTwitter
        Me.Twitter_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Twitter_SM.Name = "Twitter_SM"
        Me.Twitter_SM.Size = New System.Drawing.Size(168, 38)
        Me.Twitter_SM.Text = "Twitter"
        Me.Twitter_SM.ToolTipText = "Keep your fans and friends updated frequently."
        '
        'Tumblr_SM
        '
        Me.Tumblr_SM.Image = Global.ss.My.Resources.Resources.ssTumblr
        Me.Tumblr_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Tumblr_SM.Name = "Tumblr_SM"
        Me.Tumblr_SM.Size = New System.Drawing.Size(168, 38)
        Me.Tumblr_SM.Text = "Tumblr"
        Me.Tumblr_SM.ToolTipText = "Create your own blog. (Warning: We are not responsible if you somehow get eaten a" &
    "live.)"
        '
        'DeviantArt_SM
        '
        Me.DeviantArt_SM.Image = Global.ss.My.Resources.Resources.ssDeviantart
        Me.DeviantArt_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeviantArt_SM.Name = "DeviantArt_SM"
        Me.DeviantArt_SM.Size = New System.Drawing.Size(168, 38)
        Me.DeviantArt_SM.Text = "DeviantArt"
        Me.DeviantArt_SM.ToolTipText = "Create a virtual art portfolio."
        '
        'YouTube_SM
        '
        Me.YouTube_SM.Image = Global.ss.My.Resources.Resources.ssYouTube
        Me.YouTube_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.YouTube_SM.Name = "YouTube_SM"
        Me.YouTube_SM.Size = New System.Drawing.Size(168, 38)
        Me.YouTube_SM.Text = "YouTube"
        Me.YouTube_SM.ToolTipText = "Watch, create and share videos."
        '
        'Google_SM
        '
        Me.Google_SM.Image = Global.ss.My.Resources.Resources.Discord
        Me.Google_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Google_SM.Name = "Google_SM"
        Me.Google_SM.Size = New System.Drawing.Size(168, 38)
        Me.Google_SM.Text = "Discord"
        Me.Google_SM.ToolTipText = "It's Google's effort at a social media entity, I don't" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "even know why they bother" &
    "ed, it's a bit rubbish to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be honest."
        '
        'DocumentsToolStripMenuItem
        '
        Me.DocumentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MyDocuments_SM, Me.MyMusic_SM, Me.MyPictures_SM})
        Me.DocumentsToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssDocuments
        Me.DocumentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DocumentsToolStripMenuItem.Name = "DocumentsToolStripMenuItem"
        Me.DocumentsToolStripMenuItem.Size = New System.Drawing.Size(231, 38)
        Me.DocumentsToolStripMenuItem.Text = "Documents"
        Me.DocumentsToolStripMenuItem.ToolTipText = "Access notes, letters, pictures, music and other kinds of documents."
        '
        'MyDocuments_SM
        '
        Me.MyDocuments_SM.Image = Global.ss.My.Resources.Resources.ssDocuments
        Me.MyDocuments_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MyDocuments_SM.Name = "MyDocuments_SM"
        Me.MyDocuments_SM.Size = New System.Drawing.Size(171, 38)
        Me.MyDocuments_SM.Text = "My Documents"
        '
        'MyMusic_SM
        '
        Me.MyMusic_SM.Image = Global.ss.My.Resources.Resources.ssMusic
        Me.MyMusic_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MyMusic_SM.Name = "MyMusic_SM"
        Me.MyMusic_SM.Size = New System.Drawing.Size(171, 38)
        Me.MyMusic_SM.Text = "My Music"
        '
        'MyPictures_SM
        '
        Me.MyPictures_SM.Image = Global.ss.My.Resources.Resources.ssPictures
        Me.MyPictures_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MyPictures_SM.Name = "MyPictures_SM"
        Me.MyPictures_SM.Size = New System.Drawing.Size(171, 38)
        Me.MyPictures_SM.Text = "My Pictures"
        '
        'Settings_SM
        '
        Me.Settings_SM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsPanel_SM, Me.ToolStripSeparator5, Me.ProcessList_SM, Me.SystemInformation_SM, Me.ToolStripSeparator9, Me.WindowsSettings_SM})
        Me.Settings_SM.Image = Global.ss.My.Resources.Resources.Settings
        Me.Settings_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Settings_SM.Name = "Settings_SM"
        Me.Settings_SM.Size = New System.Drawing.Size(231, 38)
        Me.Settings_SM.Text = "Settings and Commands"
        Me.Settings_SM.ToolTipText = "Change settings and perform commands."
        '
        'SettingsPanel_SM
        '
        Me.SettingsPanel_SM.Image = Global.ss.My.Resources.Resources.Settings
        Me.SettingsPanel_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsPanel_SM.Name = "SettingsPanel_SM"
        Me.SettingsPanel_SM.Size = New System.Drawing.Size(272, 38)
        Me.SettingsPanel_SM.Text = "Settings Panel..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(269, 6)
        '
        'ProcessList_SM
        '
        Me.ProcessList_SM.Image = Global.ss.My.Resources.Resources.Processes
        Me.ProcessList_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProcessList_SM.Name = "ProcessList_SM"
        Me.ProcessList_SM.Size = New System.Drawing.Size(272, 38)
        Me.ProcessList_SM.Text = "Process List..."
        '
        'SystemInformation_SM
        '
        Me.SystemInformation_SM.Image = CType(resources.GetObject("SystemInformation_SM.Image"), System.Drawing.Image)
        Me.SystemInformation_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SystemInformation_SM.Name = "SystemInformation_SM"
        Me.SystemInformation_SM.Size = New System.Drawing.Size(272, 38)
        Me.SystemInformation_SM.Text = "System Information..."
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(269, 6)
        '
        'WindowsSettings_SM
        '
        Me.WindowsSettings_SM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlPanel_SM, Me.ToolStripSeparator12, Me.Network_SM, Me.DeviceManager_SM, Me.Registry_SM, Me.WindowsExplorer_SM, Me.WindowsVersion_SM})
        Me.WindowsSettings_SM.Image = Global.ss.My.Resources.Resources.ssWinver
        Me.WindowsSettings_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WindowsSettings_SM.Name = "WindowsSettings_SM"
        Me.WindowsSettings_SM.Size = New System.Drawing.Size(272, 38)
        Me.WindowsSettings_SM.Text = "Windows Settings and Commands"
        '
        'ControlPanel_SM
        '
        Me.ControlPanel_SM.Image = Global.ss.My.Resources.Resources.Settings
        Me.ControlPanel_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ControlPanel_SM.Name = "ControlPanel_SM"
        Me.ControlPanel_SM.Size = New System.Drawing.Size(248, 38)
        Me.ControlPanel_SM.Text = "Control Panel..."
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(245, 6)
        '
        'Network_SM
        '
        Me.Network_SM.Image = Global.ss.My.Resources.Resources.ssNetwork
        Me.Network_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Network_SM.Name = "Network_SM"
        Me.Network_SM.Size = New System.Drawing.Size(248, 38)
        Me.Network_SM.Text = "Network and Sharing Centre..."
        '
        'DeviceManager_SM
        '
        Me.DeviceManager_SM.Image = Global.ss.My.Resources.Resources.ssDevice
        Me.DeviceManager_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DeviceManager_SM.Name = "DeviceManager_SM"
        Me.DeviceManager_SM.Size = New System.Drawing.Size(248, 38)
        Me.DeviceManager_SM.Text = "Device Manager..."
        '
        'Registry_SM
        '
        Me.Registry_SM.Image = CType(resources.GetObject("Registry_SM.Image"), System.Drawing.Image)
        Me.Registry_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Registry_SM.Name = "Registry_SM"
        Me.Registry_SM.Size = New System.Drawing.Size(248, 38)
        Me.Registry_SM.Text = "Registry Editor..."
        '
        'WindowsExplorer_SM
        '
        Me.WindowsExplorer_SM.Image = Global.ss.My.Resources.Resources.ssApps
        Me.WindowsExplorer_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WindowsExplorer_SM.Name = "WindowsExplorer_SM"
        Me.WindowsExplorer_SM.Size = New System.Drawing.Size(248, 38)
        Me.WindowsExplorer_SM.Text = "Windows Explorer..."
        '
        'WindowsVersion_SM
        '
        Me.WindowsVersion_SM.Image = Global.ss.My.Resources.Resources.ssWinver
        Me.WindowsVersion_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WindowsVersion_SM.Name = "WindowsVersion_SM"
        Me.WindowsVersion_SM.Size = New System.Drawing.Size(248, 38)
        Me.WindowsVersion_SM.Text = "Windows Version..."
        '
        'Search_SM
        '
        Me.Search_SM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnTheInternet_SM, Me.ToolStripSeparator7, Me.SearchSettings_SM})
        Me.Search_SM.Image = CType(resources.GetObject("Search_SM.Image"), System.Drawing.Image)
        Me.Search_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Search_SM.Name = "Search_SM"
        Me.Search_SM.Size = New System.Drawing.Size(231, 38)
        Me.Search_SM.Text = "Search"
        Me.Search_SM.ToolTipText = "Search on the Internet or change search settings."
        '
        'OnTheInternet_SM
        '
        Me.OnTheInternet_SM.Image = CType(resources.GetObject("OnTheInternet_SM.Image"), System.Drawing.Image)
        Me.OnTheInternet_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OnTheInternet_SM.Name = "OnTheInternet_SM"
        Me.OnTheInternet_SM.Size = New System.Drawing.Size(182, 38)
        Me.OnTheInternet_SM.Text = "On The Internet..."
        Me.OnTheInternet_SM.ToolTipText = "Opens a new Search window so you can browse the web."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(179, 6)
        '
        'SearchSettings_SM
        '
        Me.SearchSettings_SM.Image = CType(resources.GetObject("SearchSettings_SM.Image"), System.Drawing.Image)
        Me.SearchSettings_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SearchSettings_SM.Name = "SearchSettings_SM"
        Me.SearchSettings_SM.Size = New System.Drawing.Size(182, 38)
        Me.SearchSettings_SM.Text = "Search Settings..."
        Me.SearchSettings_SM.ToolTipText = "Opens the Search Settings Panel."
        '
        'HelpAndSupport_SM
        '
        Me.HelpAndSupport_SM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendFeedback_SM, Me.ToolStripSeparator13, Me.HelpCentre_SM, Me.CheckForUpdates_SM, Me.UpdateLog_SM, Me.About_SM})
        Me.HelpAndSupport_SM.Image = Global.ss.My.Resources.Resources.Question
        Me.HelpAndSupport_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpAndSupport_SM.Name = "HelpAndSupport_SM"
        Me.HelpAndSupport_SM.Size = New System.Drawing.Size(231, 38)
        Me.HelpAndSupport_SM.Text = "Help and Support"
        Me.HelpAndSupport_SM.ToolTipText = "Get help, send feedback and check for updates."
        '
        'SendFeedback_SM
        '
        Me.SendFeedback_SM.Image = CType(resources.GetObject("SendFeedback_SM.Image"), System.Drawing.Image)
        Me.SendFeedback_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SendFeedback_SM.Name = "SendFeedback_SM"
        Me.SendFeedback_SM.Size = New System.Drawing.Size(198, 38)
        Me.SendFeedback_SM.Text = "Send Feedback..."
        Me.SendFeedback_SM.ToolTipText = "Help with the development with Hub ESR."
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(195, 6)
        '
        'HelpCentre_SM
        '
        Me.HelpCentre_SM.Image = Global.ss.My.Resources.Resources.ssQuestion
        Me.HelpCentre_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpCentre_SM.Name = "HelpCentre_SM"
        Me.HelpCentre_SM.Size = New System.Drawing.Size(198, 38)
        Me.HelpCentre_SM.Text = "Help..."
        Me.HelpCentre_SM.ToolTipText = "Get help."
        '
        'CheckForUpdates_SM
        '
        Me.CheckForUpdates_SM.Image = Global.ss.My.Resources.Resources.ssUpdate
        Me.CheckForUpdates_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CheckForUpdates_SM.Name = "CheckForUpdates_SM"
        Me.CheckForUpdates_SM.Size = New System.Drawing.Size(198, 38)
        Me.CheckForUpdates_SM.Text = "Check For Updates..."
        Me.CheckForUpdates_SM.ToolTipText = "Check if there's any updates."
        '
        'UpdateLog_SM
        '
        Me.UpdateLog_SM.Image = Global.ss.My.Resources.Resources.ssWhatsNew
        Me.UpdateLog_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpdateLog_SM.Name = "UpdateLog_SM"
        Me.UpdateLog_SM.Size = New System.Drawing.Size(198, 38)
        Me.UpdateLog_SM.Text = "What's New?"
        Me.UpdateLog_SM.ToolTipText = "See what's new."
        '
        'About_SM
        '
        Me.About_SM.Image = Global.ss.My.Resources.Resources.ssInfo
        Me.About_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.About_SM.Name = "About_SM"
        Me.About_SM.Size = New System.Drawing.Size(198, 38)
        Me.About_SM.Text = "About Hub ESR..."
        Me.About_SM.ToolTipText = "Opens the about dialogue."
        '
        'Run_SM
        '
        Me.Run_SM.Image = Global.ss.My.Resources.Resources.Run
        Me.Run_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Run_SM.Name = "Run_SM"
        Me.Run_SM.Size = New System.Drawing.Size(231, 38)
        Me.Run_SM.Text = "Run..."
        Me.Run_SM.ToolTipText = "Create a new process or browse a directory."
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(228, 6)
        '
        'QuickExit_SM
        '
        Me.QuickExit_SM.Image = Global.ss.My.Resources.Resources.ssExit
        Me.QuickExit_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuickExit_SM.Name = "QuickExit_SM"
        Me.QuickExit_SM.Size = New System.Drawing.Size(231, 38)
        Me.QuickExit_SM.Text = "Quick Exit"
        Me.QuickExit_SM.ToolTipText = "Perform a Quick Exit and end your session immediately"
        '
        'LogOff_SM
        '
        Me.LogOff_SM.Image = Global.ss.My.Resources.Resources.SysLogoff
        Me.LogOff_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogOff_SM.Name = "LogOff_SM"
        Me.LogOff_SM.Size = New System.Drawing.Size(231, 38)
        Me.LogOff_SM.Text = "Log Off"
        Me.LogOff_SM.ToolTipText = "Close applications and log off."
        '
        'SystemPower_SM
        '
        Me.SystemPower_SM.Image = Global.ss.My.Resources.Resources.SysPower
        Me.SystemPower_SM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SystemPower_SM.Name = "SystemPower_SM"
        Me.SystemPower_SM.Size = New System.Drawing.Size(231, 38)
        Me.SystemPower_SM.Text = "System Power..."
        Me.SystemPower_SM.ToolTipText = "View system power options or end your session."
        '
        'SearchBox
        '
        Me.SearchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchBox.Location = New System.Drawing.Point(98, 6)
        Me.SearchBox.markcolour = System.Drawing.Color.Gray
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(686, 22)
        Me.SearchBox.TabIndex = 62
        Me.SearchBox.Watermarktext = "Search the World Wide Web..."
        '
        'sscontextbar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(949, 34)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.PowerButton)
        Me.Controls.Add(Me.NetworkButton)
        Me.Controls.Add(Me.SoundButton)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TaskListButton)
        Me.Controls.Add(Me.SystemButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1920, 73)
        Me.MinimumSize = New System.Drawing.Size(965, 73)
        Me.Name = "sscontextbar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Context Bar"
        Me.SystemMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TaskListButton As Button
    Friend WithEvents SystemButton As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Clock As Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SoundButton As System.Windows.Forms.Button
    Friend WithEvents NetworkButton As System.Windows.Forms.Button
    Friend WithEvents PowerButton As System.Windows.Forms.Button
    Friend WithEvents SystemMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Welcome_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Security_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsTaskManager_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Updates_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Applications_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Calculator_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Writer_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Music_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageView_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CDPlayer_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SketchPad_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Weather_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Messages_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alarm_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mail_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Appointments_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Maps_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents News_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GIFStudio_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Start_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SocialToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Skype_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Facebook_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Twitter_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tumblr_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeviantArt_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YouTube_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Google_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyDocuments_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyMusic_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyPictures_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Settings_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsPanel_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProcessList_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemInformation_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WindowsSettings_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlPanel_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Network_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeviceManager_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Registry_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsExplorer_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsVersion_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Search_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnTheInternet_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SearchSettings_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpAndSupport_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendFeedback_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HelpCentre_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdates_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateLog_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents About_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Run_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuickExit_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOff_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemPower_SM As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchBox As Watermark
End Class
