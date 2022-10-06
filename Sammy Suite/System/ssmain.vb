Imports Gecko

Public Class ssmain
#Region "Disable Close Button"
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
#End Region
#Region "Load Settings"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Xpcom.Initialize("Firefox")

        Dim sUserAgent As String = "Mozilla/5.0 (Windows; Win64; x64; rv:63.0) Gecko/20100101 Firefox/999.0 (.NET CLR 3.5.30729)"
        Gecko.GeckoPreferences.User("general.useragent.override") = sUserAgent

    End Sub
    Private Sub ssmainbeta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Load System Tray icon.
        SystemTrayIcon.Visible = True

        'Load Parent Settings.
        ExplorerButton.Parent = HubBackground
        ExplorerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, Color.MidnightBlue)
        VerInfo.Parent = HubBackground
        HomeButton.Parent = HubBackground
        HomeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, Color.MidnightBlue)
        WindowsDesktopButton.Parent = HubBackground
        WindowsDesktopButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, Color.MidnightBlue)
        ContextBarButton.Parent = HubBackground
        ContextBarButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, Color.MidnightBlue)
        NavigateBack.Parent = HubBackground
        NavigateBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, Color.MidnightBlue)
        NavigateForward.Parent = HubBackground
        NavigateForward.FlatAppearance.MouseOverBackColor = Color.FromArgb(170, Color.MidnightBlue)
        ContextBar.Parent = HubBackground
        LinkLabel1.Parent = ContextBar
        HubBackground.Show()

        'Load classic mode settings.
        If My.Settings.ClassicMode = 0 Then
            NewsFeedBrowser.Stop()
            WindowsDesktopButton.Visible = True
            ExplorerButton.Visible = True
        Else
            NewsFeedBrowser.Navigate("https://news.windowslogic.co.uk")
            ClassicSidePanel.Parent = HubBackground
            ClassicPanel.Parent = HubBackground
            WindowsDesktopButton.Visible = False
            ExplorerButton.Visible = False
        End If

        'Load Sound Settings.
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Opening, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Opening2, AudioPlayMode.Background)
        End If

        GeckoWebBrowser1.Hide()
        NavigateBack.Enabled = False
        NavigateForward.Enabled = False
        sswelcome.Show()

        'Load Minimise At Startup Settings.
        If My.Settings.Minimise = 1 Then
            Me.WindowState = FormWindowState.Minimized
        End If

        If My.Settings.Minimise = 0 Then

        End If

        'Load Detached Context Bar Settings.
        If My.Settings.DetachContextBar = 1 Then
            sscontextbar.Show()
            ContextBar.Visible = False
        End If

        If My.Settings.DetachContextBar = 0 Then
            sscontextbar.Close()
            ContextBar.Visible = True
        End If

        'Load Background Settings.
        If My.Settings.DHBHUC = 0 Then
            HubBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DHBHUC = 1 Then
            HubBackground.Image = Nothing
        End If

        If My.Settings.DHBHUC = 2 Then
            HubBackground.Load(My.Settings.CB1)
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            ContextBar.BackColor = Color.FromArgb(170, My.Settings.CustomColour)
        End If

        'Load version number and license.
        Variables.ParseVariables(VerInfo)
    End Sub
#End Region
#Region "Hub Buttons & Links"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeButton.Click
        GeckoWebBrowser1.Hide()
        NavigateBack.Enabled = False
        NavigateForward.Enabled = False
        HomeButton.Enabled = False
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavigateBack.Click
        GeckoWebBrowser1.GoBack()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NavigateForward.Click
        GeckoWebBrowser1.GoForward()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExplorerButton.Click
        ssexplorer.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsDesktopButton.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        SystemTrayIcon.Visible = True
        SystemTrayIcon.ShowBalloonTip(1, "WLP Hub - Notification", "WLP Hub is now running in the background.", ToolTipIcon.Info)
    End Sub

    Private Sub ContextBarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextBarButton.Click
        sscontextbar.TopMost = True
        sscontextbar.TopMost = False
        sscontextbar.WindowState = FormWindowState.Normal
    End Sub

    'Classic Buttons

    Private Sub ClassicExplorerButton_Click(sender As Object, e As EventArgs) Handles ClassicExplorerButton.Click
        ssexplorer.Show()
    End Sub


#End Region
#Region "System Tray Menu"

    Private Sub NotifyIcon2_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SystemTrayIcon.DoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Maximized
            SystemTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Restore_Tray_Click(sender As Object, e As EventArgs) Handles Restore_Tray.Click
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Maximized
            SystemTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Context Bar"
    Private Sub SystemButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SystemButton.Click
        SystemMenu.Show(SystemButton, 0, SystemButton.Height)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Clock.Tick
        LinkLabel1.Text = TimeOfDay & vbCrLf & Date.Today
        LinkLabel1.Parent = ContextBar
    End Sub

    Private Sub TaskListButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskListButton.Click
        Variables.TaskListButton()
    End Sub

    Private Sub Watermark1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Watermark1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Variables.SearchBarSettings()
        End If
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundButton.Click
        Variables.SoundSettings()
    End Sub

    Private Sub NetworkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetworkButton.Click
        Variables.NetworkConnections()
    End Sub

    Private Sub PowerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerButton.Click
        Variables.PowerOptions()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Variables.DateTime()
    End Sub
#End Region
#Region "Context Bar - System Menu"
    Private Sub FunctionsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Welcome_SM.Click
        Variables.ShowWelcomeDialog()
    End Sub
#Region "Applications"
    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Calculator_SM.Click
        Variables.Calculator()
    End Sub

    Private Sub WriterToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Writer_SM.Click
        Variables.Writer()
    End Sub

    Private Sub MusicToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Music_SM.Click
        Variables.MusicPlayer()
    End Sub

    Private Sub ImageViewerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ImageView_SM.Click
        Variables.ImageViewer()
    End Sub

    Private Sub CDPlayerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CDPlayer_SM.Click
        Variables.CDPlayer()
    End Sub

    Private Sub SketchPadToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SketchPad_SM.Click
        Variables.SketchPad()
    End Sub

    Private Sub WeatherToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Weather_SM.Click
        Variables.Weather()
    End Sub

    Private Sub MessagesToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Messages_SM.Click
        Variables.Messages()
    End Sub

    Private Sub AlarmToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Alarm_SM.Click
        Variables.Alarm()
    End Sub

    Private Sub MailToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Mail_SM.Click
        Variables.Mail()
    End Sub

    Private Sub AppointmentsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Appointments_SM.Click
        Variables.Calendar()
    End Sub

    Private Sub MapsToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Maps_SM.Click
        Variables.Maps()
    End Sub

    Private Sub NewsToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles News_SM.Click
        Variables.News()
    End Sub

    Private Sub GIFStudioToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GIFStudio_SM.Click
        Variables.GIFStudio()
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_SM.Click
        Variables.Start()
    End Sub
#End Region
#Region "Social"
    Private Sub SkypeToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Skype_SM.Click
        Variables.Skype()
    End Sub

    Private Sub FacebookToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Facebook_SM.Click
        Variables.Facebook()
    End Sub

    Private Sub TwitterToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Twitter_SM.Click
        Variables.Twitter()
    End Sub

    Private Sub TumblrToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Tumblr_SM.Click
        Variables.Tumblr()
    End Sub

    Private Sub DeviantArtToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeviantArt_SM.Click
        Variables.DeviantArt()
    End Sub

    Private Sub YouTubeToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles YouTube_SM.Click
        Variables.YouTube()
    End Sub
#End Region
#Region "Documents and Settings"
    Private Sub MyDocumentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyDocuments_SM.Click
        Dim userdocs As String = "C:\Users\" + System.Windows.Forms.SystemInformation.UserName + "\Documents"
        ssexplorer.Show()
        ssexplorer.Explorer1.Navigate(userdocs)
    End Sub


    Private Sub MyMusicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyMusic_SM.Click
        Dim usermusic As String = "C:\Users\" + System.Windows.Forms.SystemInformation.UserName + "\Music"
        ssexplorer.Show()
        ssexplorer.Explorer1.Navigate(usermusic)
    End Sub

    Private Sub MyPicturesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyPictures_SM.Click
        Dim userpics As String = "C:\Users\" + System.Windows.Forms.SystemInformation.UserName + "\Pictures"
        ssexplorer.Show()
        ssexplorer.Explorer1.Navigate(userpics)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Variables.SettingsPanel()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Variables.ProcessList()
    End Sub
#End Region
#Region "Search"
    Private Sub OnTheInternetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnTheInternet_SM.Click
        Variables.InternetSearch()
    End Sub

    Private Sub SearchSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSettings_SM.Click
        Variables.SearchSettings()
    End Sub
#End Region
#Region "Help and Support"
    Private Sub SendFeedbackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendFeedback_SM.Click
        Variables.Feedback()
    End Sub

    Private Sub HelpCentreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpCentre_SM.Click
        Variables.Help()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckForUpdates_SM.Click
        Variables.Updater()
    End Sub

    Private Sub UpdateLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateLog_SM.Click
        Variables.WhatsNew()
    End Sub

    Private Sub AboutWindowsLogicProductionsHubToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About_SM.Click
        Variables.About()
    End Sub
#End Region

    Private Sub LockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockToolStripMenuItem.Click
        Variables.Lock()
    End Sub

    Private Sub LoggOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOff_SM.Click
        Variables.LogOff()
    End Sub
#End Region
#Region "Right Click Menu"

    Private Sub PropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        sssettingspanelpersonalise.Show()
    End Sub

    Private Sub Discord_SM_Click(sender As Object, e As EventArgs) Handles Discord_SM.Click
        Variables.Discord()
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Variables.Restart()
    End Sub

    Private Sub ShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutDownToolStripMenuItem.Click
        Variables.Shutdown()
    End Sub

    Private Sub RestartWLPHubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartWLPHubToolStripMenuItem.Click
        Variables.RestartHub()
    End Sub

    Private Sub ExitWLPHubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitWLPHubToolStripMenuItem.Click
        Variables.ExitHub()
    End Sub

    Private Sub ClassicWLPButton_Click(sender As Object, e As EventArgs) Handles ClassicWLPButton.Click
        GeckoWebBrowser1.Show()
        NavigateBack.Enabled = True
        NavigateForward.Enabled = True
        HomeButton.Enabled = True
        GeckoWebBrowser1.Navigate("https://windowslogic.co.uk")
    End Sub

    Private Sub ClassicDesktopButton_Click(sender As Object, e As EventArgs) Handles ClassicDesktopButton.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        SystemTrayIcon.Visible = True
        SystemTrayIcon.ShowBalloonTip(1, "WLP Hub - Notification", "WLP Hub is now running in the background.", ToolTipIcon.Info)
    End Sub

    Private Sub ClassicSCButton_Click(sender As Object, e As EventArgs) Handles ClassicSCButton.Click
        sscontextbar.TopMost = True
        sscontextbar.TopMost = False
        sscontextbar.WindowState = FormWindowState.Normal
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        sswhatsnew.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("https://windowslogic.co.uk/feedback.php")
    End Sub
#End Region
End Class