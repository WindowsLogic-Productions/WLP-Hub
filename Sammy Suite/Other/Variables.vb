Public Class Variables
    Public Shared ver As String = My.Application.Info.Version.ToString + ".main.dev.N/A"
    Public Shared user As String = System.Windows.Forms.SystemInformation.UserName
    Public Shared vertext As String = "http://u.windowslogic.co.uk/HUB/SS.txt"
    Public Shared setup As String = "http://u.windowslogic.co.uk/HUB/WLP%20Hub%20Setup.exe"

    Public Shared Sub ParseVariables(ByVal input As Label)
        input.Text = input.Text.Replace("%ver%", Variables.ver).Replace("%user%", Variables.user)
    End Sub

#Region "Context Bar"
#Region "System Menu"
    Public Shared Sub ShowWelcomeDialog()
        sswelcomedialogue.Show()
    End Sub

    Public Shared Sub LogiverseHubSecurity()
        sssecurity.Show()
    End Sub

    Public Shared Sub TaskManager()
        Process.Start("C:\Windows\System32\taskmgr.exe")
    End Sub

    Public Shared Sub Updates()
        sssettingspanelupdates.Show()
    End Sub
#Region "Applications"
    Public Shared Sub Calculator()
        sscalc.Show()
    End Sub

    Public Shared Sub Writer()
        sswriter.Show()
    End Sub

    Public Shared Sub MusicPlayer()
        ssmusic.Show()
    End Sub

    Public Shared Sub ImageViewer()
        ssimgview.Show()
    End Sub

    Public Shared Sub CDPlayer()
        sscdplayer.Show()
    End Sub

    Public Shared Sub SketchPad()
        sssketchpad.Show()
    End Sub

    Public Shared Sub Weather()
        ssweather.Show()
    End Sub

    Public Shared Sub Messages()
        sschat.Show()
    End Sub

    Public Shared Sub Alarm()
        ssalarm.Show()
    End Sub

    Public Shared Sub Mail()
        ssmail.Show()
    End Sub

    Public Shared Sub Calendar()
        sscalendar.Show()
    End Sub

    Public Shared Sub Maps()
        ssmaps.Show()
    End Sub

    Public Shared Sub News()
        ssnews.Show()
    End Sub

    Public Shared Sub GIFStudio()
        ssgifstudio.Show()
    End Sub

    Public Shared Sub Start()
        ssexplorer.Show()
        ssexplorer.Explorer1.Navigate("C:\ProgramData\Microsoft\Windows\Start Menu")
    End Sub
#End Region
#Region "Social"
    Public Shared Sub Skype()
        ssskype.Show()
    End Sub

    Public Shared Sub Facebook()
        ssfacebook.Show()
    End Sub

    Public Shared Sub Twitter()
        sstwitter.Show()
    End Sub

    Public Shared Sub Tumblr()
        sstumblr.Show()
    End Sub

    Public Shared Sub DeviantArt()
        ssdeviantart.Show()
    End Sub

    Public Shared Sub YouTube()
        ssyoutube.Show()
    End Sub

    Public Shared Sub GooglePlus()
        ssgoogleplus.Show()
    End Sub
#End Region
#Region "Documents"
    Public Shared Sub Documents()
        Dim userdocs As String = "C:\Users\" + System.Windows.Forms.SystemInformation.UserName + "\Documents"
        ssexplorer.Show()
        ssexplorer.Explorer1.Navigate(userdocs)
    End Sub

    Public Shared Sub Music()
        Dim usermusic As String = "C:\Users\" + System.Windows.Forms.SystemInformation.UserName + "\Music"
        ssexplorer.Show()
        ssexplorer.Explorer1.Navigate(usermusic)
    End Sub

    Public Shared Sub Pictures()
        Dim userpics As String = "C:\Users\" + System.Windows.Forms.SystemInformation.UserName + "\Pictures"
        ssexplorer.Show()
        ssexplorer.Explorer1.Navigate(userpics)
    End Sub
#End Region
#Region "Settings"
    Public Shared Sub SettingsPanel()
        sssettingspanel.Show()
    End Sub

    Public Shared Sub ProcessList()
        ssprocesslist.Show()
    End Sub

    Public Shared Sub SystemInfo()
        sssysinfo.Show()
    End Sub

    Public Shared Sub ControlPanel()
        Process.Start("control")
    End Sub

    Public Shared Sub NetworkCentre()
        Shell("control /name Microsoft.NetworkAndSharingCenter")
    End Sub

    Public Shared Sub DeviceManager()
        Shell("control /name Microsoft.DeviceManager")
    End Sub

    Public Shared Sub Regedit()
        Process.Start("regedit")
    End Sub

    Public Shared Sub WindowsExplorer()
        Process.Start("explorer")
    End Sub

    Public Shared Sub Winver()
        Process.Start("winver")
    End Sub
#End Region
#Region "Search"
    Public Shared Sub InternetSearch()
        sssearch.Show()
        sssearch.WebBrowser1.Navigate("http://www.google.com")
    End Sub

    Public Shared Sub SearchSettings()
        sssettingspanelsearch.Show()
    End Sub
#End Region
#Region "Help and Support"
    Public Shared Sub Feedback()
        If My.Settings.SearchStyle = 1 Then

        End If
    End Sub

    Public Shared Sub Help()
        sshelpoffline.Show()
    End Sub

    Public Shared Sub Updater()
        ssupdater.Show()
    End Sub

    Public Shared Sub WhatsNew()
        sswhatsnew.Show()
    End Sub

    Public Shared Sub About()
        ssabout.Text = "About Hub ESR"
        ssabout.AppPic.Image = My.Resources.WLP
        ssabout.AppName.Text = "Hub ESR - Version N/A"
        ssabout.ShowDialog()
    End Sub
#End Region
    Public Shared Sub Run()
        ssrun.Show()
    End Sub

    Public Shared Sub QuickExit()
        sssecuritybackground.Show()
        ssquickexit.Show()
    End Sub

    Public Shared Sub LogOff()
        sssecuritybackground.Show()
        sslogoff.Show()
    End Sub

    Public Shared Sub SystemPower()
        sssecuritybackground.Show()
        sspower.Show()
    End Sub
#End Region
#Region "Buttons"
    Public Shared Sub TaskListButton()
        sstasklist.Show()
    End Sub

    Public Shared Sub SearchBarSettings()
        If My.Settings.SearchStyle = 0 Then
            ssmain.WebBrowser1.Show()
            ssmain.NavigateBack.Enabled = True
            ssmain.NavigateForward.Enabled = True
            ssmain.HomeButton.Enabled = True
            If My.Settings.SearchEngine = 0 Then
                ssmain.WebBrowser1.Navigate("http://www.google.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 1 Then
                ssmain.WebBrowser1.Navigate("http://www.bing.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 2 Then
                ssmain.WebBrowser1.Navigate("http://uk.search.yahoo.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 3 Then
                ssmain.WebBrowser1.Navigate("https://duckduckgo.com/?q=" + ssmain.Watermark1.Text)
            End If
        End If
        If My.Settings.SearchStyle = 1 Then
            sssearch.Show()
            If My.Settings.SearchEngine = 0 Then
                sssearch.WebBrowser1.Navigate("http://www.google.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 1 Then
                sssearch.WebBrowser1.Navigate("http://www.bing.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 2 Then
                sssearch.WebBrowser1.Navigate("http://uk.search.yahoo.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 3 Then
                sssearch.WebBrowser1.Navigate("https://duckduckgo.com/?q=" + ssmain.Watermark1.Text)
            End If
        End If
    End Sub

    Public Shared Sub PowerOptions()
        ssbattery.Show()
    End Sub

    Public Shared Sub NetworkConnections()
        ssnetmonitor.Show()
    End Sub

    Public Shared Sub SoundSettings()
        ssVolume.Show()
    End Sub

    Public Shared Sub DateTime()
        ssdateandtime.Show()
    End Sub
#End Region
#End Region
#Region "Updates"
    Public Shared Sub CheckForUpdates()

        If My.Settings.Updates = 1 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(vertext)
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                Else
                    ssupdateprompt.Show()
                End If
            Catch
                sserror.Show()
                sserror.Label1.Text = "No connection to the update server."
            End Try
        End If

        If My.Settings.Updates = 0 Then

        End If
    End Sub
#End Region
End Class