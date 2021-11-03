Public Class ssmain

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ssexityesno.ShowDialog()
        e.Cancel = True
    End Sub

    Private Sub ssmainbeta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Opening, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Opening2, AudioPlayMode.Background)
        End If

        WebBrowser1.Hide()
        Button12.Hide()
        Button13.Hide()
        ssscload.Show()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        WebBrowser1.Hide()
        Button12.Hide()
        Button13.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        WebBrowser1.Show()
        WebBrowser1.Navigate("http://www.windowslogic.co.uk/")
        Button12.Show()
        Button13.Show()
        PictureBox3.Show()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        WebBrowser1.Show()
        WebBrowser1.Navigate("http://www.bbc.co.uk/news/world/us_and_canada")
        Button12.Show()
        Button13.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ssskype.Show()

        'LEGACY CODE (UNUSED)

        'WebBrowser1.Show()
        'WebBrowser1.Navigate("http://web.skype.com")
        'Button12.Hide()
        'Button13.Hide()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        WebBrowser1.Show()
        WebBrowser1.Navigate("http://www.facebook.com")
        Button12.Show()
        Button13.Show()
        PictureBox3.Show()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs)
        ssabout.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        WebBrowser1.Show()
        WebBrowser1.Navigate("http://www.deviantart.com")
        Button12.Show()
        Button13.Show()
        PictureBox3.Show()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        sshelponline.Show()
        sshelponline.WebBrowser1.Navigate("http://wlphub.weebly.com/update-log")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ssexityesno.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        WebBrowser1.Show()
        WebBrowser1.Navigate("http://www.twitter.com")
        Button12.Show()
        Button13.Show()
        PictureBox3.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        sscalc.Show()
    End Sub

    Private Sub WriterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WriterToolStripMenuItem.Click
        ssffw.Show()
    End Sub

    Private Sub MediaPlayerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MediaPlayerToolStripMenuItem.Click
        ssmusic.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssabout.Show()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        WebBrowser1.Show()
        WebBrowser1.Navigate("http://www.tumblr.com")
        Button12.Show()
        Button13.Show()
        PictureBox3.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        WebBrowser1.Show()
        WebBrowser1.Navigate("http://www.youtube.com")
        Button12.Show()
        Button13.Show()
        PictureBox3.Show()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        WebBrowser1.Show()
        WebBrowser1.Navigate("http://plus.google.com")
        Button12.Show()
        Button13.Show()
        PictureBox3.Show()
    End Sub

    Private Sub UpdatesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdatesToolStripMenuItem.Click
        ssupdater.Show()
    End Sub

    Private Sub UpdateLogToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateLogToolStripMenuItem.Click
        sshelponline.Show()
        sshelponline.WebBrowser1.Navigate("http://wlphub.weebly.com/update-log")
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        sschat.Show()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        sshelponline.Show()
    End Sub

    Private Sub Button11_Click_1(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If My.Settings.HubSounds = "0" Then
            My.Computer.Audio.Play(My.Resources.System, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = "1" Then
            My.Computer.Audio.Play(My.Resources.SystemNew, AudioPlayMode.Background)
        End If

        If sssc.CheckBox1.Checked = True Then
            sssc.WindowState = FormWindowState.Normal
            sssc.Show()
        End If

        If sssc.CheckBox1.Checked = False Then
            sssc.TopMost = True
            sssc.TopMost = False
            sssc.WindowState = FormWindowState.Normal
            sssc.Show()
        End If
    End Sub

    Private Sub NotifyIcon2_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon2.MouseDoubleClick
        Try
            Me.Visible = True
            sssc.Visible = True
            Me.WindowState = FormWindowState.Maximized
            NotifyIcon2.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                sssc.Visible = False
                NotifyIcon2.Visible = True
                NotifyIcon2.ShowBalloonTip(1, "WLP Hub - Information", "WLP Hub is now running in the background.", ToolTipIcon.None)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem1.Click
        Try
            Me.Visible = True
            sssc.Visible = True
            Me.WindowState = FormWindowState.Maximized
            NotifyIcon2.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem2.Click
        ssabout.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem2.Click
        ssexityesno.Show()
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ssrun.Show()
    End Sub

    Private Sub ImageViewerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImageViewerToolStripMenuItem.Click
        ssimgview.Show()
    End Sub

    Private Sub SketchPadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SketchPadToolStripMenuItem.Click
        sssketchpad.Show()
    End Sub

    Private Sub MemoryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MemoryToolStripMenuItem.Click
        ssmemory.Show()
    End Sub

    Private Sub BreakoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BreakoutToolStripMenuItem.Click
        ssbreakout.Show()
    End Sub

    Private Sub WeatherToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WeatherToolStripMenuItem.Click
        ssweather.Show()
    End Sub

    Private Sub CDPlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDPlayerToolStripMenuItem.Click
        sscdplayer.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        sssc.Visible = False
        NotifyIcon2.Visible = True
        NotifyIcon2.ShowBalloonTip(1, "WLP Hub - Information", "WLP Hub is now running in the background.", ToolTipIcon.None)
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        sssearch.Show()
    End Sub
End Class