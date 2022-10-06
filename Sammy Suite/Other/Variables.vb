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
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("https://web.skype.com/")
        sssearch.Text = sssearch.GeckoWebBrowser1.DocumentTitle
    End Sub

    Public Shared Sub Discord()
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("https://discord.gg/")
        sssearch.Text = sssearch.GeckoWebBrowser1.DocumentTitle
    End Sub

    Public Shared Sub Facebook()
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("https://facebook.com/")
        sssearch.Text = sssearch.GeckoWebBrowser1.DocumentTitle
    End Sub

    Public Shared Sub Twitter()
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("https://twitter.com/")
        sssearch.Text = sssearch.GeckoWebBrowser1.DocumentTitle
    End Sub

    Public Shared Sub Tumblr()
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("https://tumblr.com/")
        sssearch.Text = sssearch.GeckoWebBrowser1.DocumentTitle
    End Sub

    Public Shared Sub DeviantArt()
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("https://deviantart.com/")
        sssearch.Text = sssearch.GeckoWebBrowser1.DocumentTitle
    End Sub

    Public Shared Sub YouTube()
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("https://youtube.com/")
        sssearch.Text = sssearch.GeckoWebBrowser1.DocumentTitle
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
#End Region
#Region "Search"
    Public Shared Sub InternetSearch()
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("http://www.google.com")
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
        ssupdater.ShowDialog()
    End Sub

    Public Shared Sub WhatsNew()
        sswhatsnew.ShowDialog()
    End Sub

    Public Shared Sub About()
        ssabout.Text = "About WLP Hub"
        ssabout.AppPic.Image = My.Resources.WLP
        ssabout.AppName.Text = "WLP Hub - Version 10.0"
        ssabout.ShowDialog()
    End Sub
#End Region
    Public Shared Sub Run()
        ssrun.ShowDialog()
    End Sub

    Public Shared Sub Lock()
        If My.Settings.ALS = 1 Then
            sslock.ShowDialog()
        End If

        If My.Settings.ALS = 0 Then
            ssinformation.Label1.Text = "You need to enable Hub Locking System before you can use this feature."
            ssinformation.ShowDialog()
        End If
    End Sub

    Public Shared Sub LogOff()
        sslogoff.ShowDialog()
    End Sub

    Public Shared Sub Shutdown()
        Shell("shutdown -s -t 00")
    End Sub

    Public Shared Sub Restart()
        Shell("shutdown -r -t 00")
    End Sub

    Public Shared Sub RestartHub()
        ssload.Show()
        ssmain.Dispose()
        sscontextbar.Dispose()
        My.Settings.Save()
    End Sub

    Public Shared Sub ExitHub()
        ssexit.Show()
        sstasklist.Close()
    End Sub
#End Region
#Region "Buttons"
    Public Shared Sub TaskListButton()
        sstasklist.Show()
    End Sub

    Public Shared Sub SearchBarSettings()
        If My.Settings.SearchStyle = 0 Then
            ssmain.GeckoWebBrowser1.Show()
            ssmain.NavigateBack.Enabled = True
            ssmain.NavigateForward.Enabled = True
            ssmain.HomeButton.Enabled = True
            If My.Settings.SearchEngine = 0 Then
                ssmain.GeckoWebBrowser1.Navigate("http://www.google.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 1 Then
                ssmain.GeckoWebBrowser1.Navigate("http://www.bing.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 2 Then
                ssmain.GeckoWebBrowser1.Navigate("http://uk.search.yahoo.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 3 Then
                ssmain.GeckoWebBrowser1.Navigate("https://duckduckgo.com/?q=" + ssmain.Watermark1.Text)
            End If
        End If
        If My.Settings.SearchStyle = 1 Then
            sssearch.Show()
            If My.Settings.SearchEngine = 0 Then
                sssearch.GeckoWebBrowser1.Navigate("http://www.google.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 1 Then
                sssearch.GeckoWebBrowser1.Navigate("http://www.bing.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 2 Then
                sssearch.GeckoWebBrowser1.Navigate("http://uk.search.yahoo.com/search?q=" + ssmain.Watermark1.Text)
            End If

            If My.Settings.SearchEngine = 3 Then
                sssearch.GeckoWebBrowser1.Navigate("https://duckduckgo.com/?q=" + ssmain.Watermark1.Text)
            End If
        End If
    End Sub

    Public Shared Sub PowerOptions()
        ssbattery.ShowDialog()
    End Sub

    Public Shared Sub NetworkConnections()
        ssnetmonitor.ShowDialog()
    End Sub

    Public Shared Sub SoundSettings()
        ssVolume.ShowDialog()
    End Sub

    Public Shared Sub DateTime()
        ssdateandtime.ShowDialog()
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