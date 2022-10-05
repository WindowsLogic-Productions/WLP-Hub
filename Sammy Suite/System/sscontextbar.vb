Public Class sscontextbar
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
    Private Sub sscontextbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load always on top settings.
        If My.Settings.ContextBarOnTop = 1 Then
            Me.TopMost = True
        End If
        If My.Settings.ContextBarOnTop = 0 Then
            Me.TopMost = False
        End If

        'Show Context Bar button.
        ssmain.ContextBarButton.Show()
    End Sub
#End Region
#Region "Context Bar"

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Clock.Tick
        LinkLabel1.Text = TimeOfDay & vbCrLf & Date.Today
    End Sub

    Private Sub SystemButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SystemButton.Click
        SystemMenu.Show(SystemButton, 0, SystemButton.Height)
    End Sub

    Private Sub SettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskListButton.Click
        sstasklist.Show()
    End Sub

    Private Sub Watermark1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles SearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Variables.SearchBarSettings()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ssdateandtime.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundButton.Click
        Variables.SoundSettings()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetworkButton.Click
        Variables.NetworkConnections()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerButton.Click
        Variables.PowerOptions()
    End Sub
#End Region
#Region "Context Bar - System Menu"
    Private Sub FunctionsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Welcome_SM.Click
        Variables.ShowWelcomeDialog()
    End Sub

    Private Sub WLPHubSecurityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Security_SM.Click
        Variables.LogiverseHubSecurity()
    End Sub

    Private Sub WindowsTaskManagerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles WindowsTaskManager_SM.Click
        Variables.TaskManager()
    End Sub

    Private Sub UpdatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Updates_SM.Click
        Variables.Updates()
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

    Private Sub GoogleToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Google_SM.Click
        Variables.Discord()
    End Sub
#End Region
#Region "Documents"
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
#End Region
#Region "Settings"
    Private Sub SettingsPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsPanel_SM.Click
        Variables.SettingsPanel()
    End Sub

    Private Sub ProcessListToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessList_SM.Click
        Variables.ProcessList()
    End Sub

    Private Sub SystemInformationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemInformation_SM.Click
        Variables.SystemInfo()
    End Sub

    Private Sub ControlPanelToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlPanel_SM.Click
        Variables.ControlPanel()
    End Sub

    Private Sub NetworkAndSharingCentreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Network_SM.Click
        Variables.NetworkCentre()
    End Sub

    Private Sub DeviceManagerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeviceManager_SM.Click
        Variables.DeviceManager()
    End Sub

    Private Sub RegistryEditorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registry_SM.Click
        Variables.Regedit()
    End Sub

    Private Sub WindowsExplorerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsExplorer_SM.Click
        Variables.WindowsExplorer()
    End Sub

    Private Sub WindowsVersionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsVersion_SM.Click
        Variables.Winver()
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
    Private Sub RunToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Run_SM.Click
        Variables.Run()
    End Sub

    Private Sub QuickExitDoesNotSaveAnyChangesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickExit_SM.Click
        Variables.QuickExit()
    End Sub

    Private Sub LoggOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOff_SM.Click
        Variables.LogOff()
    End Sub

    Private Sub PowerToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SystemPower_SM.Click
        Variables.SystemPower()
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ssmain.ContextBarButton.Hide()
    End Sub
#End Region
End Class