Public Class sstasklist
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
    Private Sub sstasklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub


#End Region
#Region "Task Buttons"

    Private Sub CalculatorButton_Click(sender As Object, e As EventArgs) Handles CalculatorButton.Click
        sscalc.TopMost = True
        sscalc.TopMost = False
        sscalc.WindowState = FormWindowState.Normal
    End Sub

    Private Sub WriterButton_Click(sender As Object, e As EventArgs) Handles WriterButton.Click
        sswriter.TopMost = True
        sswriter.TopMost = False
        sswriter.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MusicButton_Click(sender As Object, e As EventArgs) Handles MusicButton.Click
        ssmusic.TopMost = True
        ssmusic.TopMost = False
        ssmusic.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ImageViewerButton_Click(sender As Object, e As EventArgs) Handles ImageViewerButton.Click
        ssimgview.TopMost = True
        ssimgview.TopMost = False
        ssimgview.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CDPlayerButton_Click(sender As Object, e As EventArgs) Handles CDPlayerButton.Click
        sscdplayer.TopMost = True
        sscdplayer.TopMost = False
        sscdplayer.WindowState = FormWindowState.Normal
    End Sub

    Private Sub SketchPadButton_Click(sender As Object, e As EventArgs) Handles SketchPadButton.Click
        sssketchpad.TopMost = True
        sssketchpad.TopMost = False
        sssketchpad.WindowState = FormWindowState.Normal
    End Sub

    Private Sub WeatherButton_Click(sender As Object, e As EventArgs) Handles WeatherButton.Click
        ssweather.TopMost = True
        ssweather.TopMost = False
        ssweather.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MessagesButton_Click(sender As Object, e As EventArgs) Handles MessagesButton.Click
        sschat.TopMost = True
        sschat.TopMost = False
        sschat.WindowState = FormWindowState.Normal
    End Sub

    Private Sub AlarmButton_Click(sender As Object, e As EventArgs) Handles AlarmButton.Click
        ssalarm.TopMost = True
        ssalarm.TopMost = False
        ssalarm.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MailButton_Click(sender As Object, e As EventArgs) Handles MailButton.Click
        ssmail.TopMost = True
        ssmail.TopMost = False
        ssmail.WindowState = FormWindowState.Normal
    End Sub

    Private Sub AppointmentsButton_Click(sender As Object, e As EventArgs) Handles AppointmentsButton.Click
        sscalendar.TopMost = True
        sscalendar.TopMost = False
        sscalendar.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MapsButton_Click(sender As Object, e As EventArgs) Handles MapsButton.Click
        ssmaps.TopMost = True
        ssmaps.TopMost = False
        ssmaps.WindowState = FormWindowState.Normal
    End Sub

    Private Sub NewsButton_Click(sender As Object, e As EventArgs) Handles NewsButton.Click
        ssnews.TopMost = True
        ssnews.TopMost = False
        ssnews.WindowState = FormWindowState.Normal
    End Sub

    Private Sub GIFStudioButton_Click(sender As Object, e As EventArgs) Handles GIFStudioButton.Click
        ssgifstudio.TopMost = True
        ssgifstudio.TopMost = False
        ssgifstudio.WindowState = FormWindowState.Normal
    End Sub

    Private Sub SkypeButton_Click(sender As Object, e As EventArgs) Handles SkypeButton.Click
        ssskype.TopMost = True
        ssskype.TopMost = False
        ssskype.WindowState = FormWindowState.Normal
    End Sub

    Private Sub FacebookButton_Click(sender As Object, e As EventArgs) Handles FacebookButton.Click
        ssfacebook.TopMost = True
        ssfacebook.TopMost = False
        ssfacebook.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TwitterButton_Click(sender As Object, e As EventArgs) Handles TwitterButton.Click
        sstwitter.TopMost = True
        sstwitter.TopMost = False
        sstwitter.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TumblrButton_Click(sender As Object, e As EventArgs) Handles TumblrButton.Click
        sstumblr.TopMost = True
        sstumblr.TopMost = False
        sstumblr.WindowState = FormWindowState.Normal
    End Sub

    Private Sub DeviantArtButton_Click(sender As Object, e As EventArgs) Handles DeviantArtButton.Click
        ssdeviantart.TopMost = True
        ssdeviantart.TopMost = False
        ssdeviantart.WindowState = FormWindowState.Normal
    End Sub

    Private Sub YouTubeButton_Click(sender As Object, e As EventArgs) Handles YouTubeButton.Click
        ssyoutube.TopMost = True
        ssyoutube.TopMost = False
        ssyoutube.WindowState = FormWindowState.Normal
    End Sub

    Private Sub GooglePlusButton_Click(sender As Object, e As EventArgs) Handles GooglePlusButton.Click
        ssgoogleplus.TopMost = True
        ssgoogleplus.TopMost = False
        ssgoogleplus.WindowState = FormWindowState.Normal
    End Sub

    Private Sub HelpCentreButton_Click(sender As System.Object, e As System.EventArgs) Handles HelpCentreButton.Click
        sshelpoffline.TopMost = True
        sshelpoffline.TopMost = False
        sshelpoffline.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ProcessListButton_Click(sender As System.Object, e As System.EventArgs) Handles ProcessListButton.Click
        ssprocesslist.TopMost = True
        ssprocesslist.TopMost = False
        ssprocesslist.WindowState = FormWindowState.Normal
    End Sub

    Private Sub SettingsPanelButton_Click(sender As System.Object, e As System.EventArgs) Handles SettingsPanelButton.Click
        sssettingspanel.TopMost = True
        sssettingspanel.TopMost = False
        sssettingspanel.WindowState = FormWindowState.Normal
        sssettingspanelhub.TopMost = True
        sssettingspanelhub.TopMost = False
        sssettingspanelhub.WindowState = FormWindowState.Normal
        sssettingspanelpersonalise.TopMost = True
        sssettingspanelpersonalise.TopMost = False
        sssettingspanelpersonalise.WindowState = FormWindowState.Normal
        sssettingspanelupdates.TopMost = True
        sssettingspanelupdates.TopMost = False
        sssettingspanelupdates.WindowState = FormWindowState.Normal
    End Sub
#End Region
#Region "Task Button Menus"

    Private Sub SwitchToToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchToToolStripMenuItem.Click
        sscalc.TopMost = True
        sscalc.TopMost = False
        sscalc.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        sscalc.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        sswriter.TopMost = True
        sswriter.TopMost = False
        sswriter.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        sswriter.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        ssmusic.TopMost = True
        ssmusic.TopMost = False
        ssmusic.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        ssmusic.Close()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        ssimgview.TopMost = True
        ssimgview.TopMost = False
        ssimgview.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        ssimgview.Close()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        sscdplayer.TopMost = True
        sscdplayer.TopMost = False
        sscdplayer.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        sscdplayer.Close()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        sssketchpad.TopMost = True
        sssketchpad.TopMost = False
        sssketchpad.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        sssketchpad.Close()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        ssweather.TopMost = True
        ssweather.TopMost = False
        ssweather.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        ssweather.Close()
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        sschat.TopMost = True
        sschat.TopMost = False
        sschat.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        sschat.Close()
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem23.Click
        ssalarm.TopMost = True
        ssalarm.TopMost = False
        ssalarm.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem24.Click
        ssalarm.Close()
    End Sub

    Private Sub ToolStripMenuItem27_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem27.Click
        ssmail.TopMost = True
        ssmail.TopMost = False
        ssmail.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem28_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem28.Click
        ssmail.Close()
    End Sub

    Private Sub ToolStripMenuItem37_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem37.Click
        sscalendar.TopMost = True
        sscalendar.TopMost = False
        sscalendar.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem38_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem38.Click
        sscalendar.Close()
    End Sub

    Private Sub ToolStripMenuItem29_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem29.Click
        ssmaps.TopMost = True
        ssmaps.TopMost = False
        ssmaps.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem30_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem30.Click
        ssmaps.Close()
    End Sub

    Private Sub ToolStripMenuItem31_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem31.Click
        ssnews.TopMost = True
        ssnews.TopMost = False
        ssnews.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem32_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem32.Click
        ssnews.Close()
    End Sub

    Private Sub ToolStripMenuItem35_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem35.Click
        ssgifstudio.TopMost = True
        ssgifstudio.TopMost = False
        ssgifstudio.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem36_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem36.Click
        ssgifstudio.Close()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        ssskype.TopMost = True
        ssskype.TopMost = False
        ssskype.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        ssskype.Close()
    End Sub

    Private Sub ToolStripMenuItem39_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem39.Click
        ssfacebook.TopMost = True
        ssfacebook.TopMost = False
        ssfacebook.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem40_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem40.Click
        ssfacebook.Close()
    End Sub

    Private Sub ToolStripMenuItem41_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem41.Click
        sstwitter.TopMost = True
        sstwitter.TopMost = False
        sstwitter.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem42_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem42.Click
        sstwitter.Close()
    End Sub

    Private Sub ToolStripMenuItem43_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem43.Click
        sstumblr.TopMost = True
        sstumblr.TopMost = False
        sstumblr.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem44_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem44.Click
        sstumblr.Close()
    End Sub

    Private Sub ToolStripMenuItem45_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem45.Click
        ssdeviantart.TopMost = True
        ssdeviantart.TopMost = False
        ssdeviantart.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem46_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem46.Click
        ssdeviantart.Close()
    End Sub

    Private Sub ToolStripMenuItem47_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem47.Click
        ssyoutube.TopMost = True
        ssyoutube.TopMost = False
        ssyoutube.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem48_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem48.Click
        ssyoutube.Close()
    End Sub

    Private Sub ToolStripMenuItem49_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem49.Click
        ssgoogleplus.TopMost = True
        ssgoogleplus.TopMost = False
        ssgoogleplus.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem50_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem50.Click
        ssgoogleplus.Close()
    End Sub

    Private Sub ToolStripMenuItem26_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem26.Click
        'sspower.Show()
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem21.Click
        sshelpoffline.TopMost = True
        sshelpoffline.TopMost = False
        sshelpoffline.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem22.Click
        sshelpoffline.Close()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem15.Click
        ssprocesslist.TopMost = True
        ssprocesslist.TopMost = False
        ssprocesslist.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem16.Click
        ssprocesslist.Close()
    End Sub

    Private Sub ToolStripMenuItem51_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem51.Click
        sssettingspanel.TopMost = True
        sssettingspanel.TopMost = False
        sssettingspanel.WindowState = FormWindowState.Normal
        sssettingspanelhub.TopMost = True
        sssettingspanelhub.TopMost = False
        sssettingspanelhub.WindowState = FormWindowState.Normal
        sssettingspanelpersonalise.TopMost = True
        sssettingspanelpersonalise.TopMost = False
        sssettingspanelpersonalise.WindowState = FormWindowState.Normal
        sssettingspanelupdates.TopMost = True
        sssettingspanelupdates.TopMost = False
        sssettingspanelupdates.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem52_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem52.Click
        sssettingspanel.Close()
        sssettingspanelhub.Close()
        sssettingspanelpersonalise.Close()
        sssettingspanelupdates.Close()
    End Sub

    Private Sub ToolStripMenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem53.Click
        ssexplorer.TopMost = True
        ssexplorer.TopMost = False
        ssexplorer.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem54.Click
        ssexplorer.Close()
    End Sub
#End Region
#Region "Other"
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Hide()
    End Sub
#End Region
End Class