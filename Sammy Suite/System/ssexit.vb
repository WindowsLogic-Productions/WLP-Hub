Public Class ssexit
#Region "Load Settings"
    Private Sub ssexit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load Background Settings.
        If My.Settings.DWBWUC = 0 Then
            ExitBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DWBWUC = 1 Then
            ExitBackground.Image = Nothing
        End If

        If My.Settings.DWBWUC = 2 Then
            ExitBackground.Load(My.Settings.CB2)
        End If

        Loader.Parent = ExitBackground
        Label2.Parent = ExitBackground
        ssabout.Close()
        sscalc.Close()
        sscalcconsts.Close()
        sswhatsnew.Close()
        sschat.Close()
        sserror.Close()
        ssexclamation.Close()
        sswriter.Close()
        sshelpoffline.Close()
        ssimgview.Close()
        ssload.Close()
        ssmain.Close()
        ssmusic.Close()
        ssrun.Close()
        ssskype.Close()
        ssupdater.Close()
        ssupdateprompt.Close()
        sswritersaveyesno.Close()
        sspower.Close()
        sssecuritybackground.Close()
        Timer2.Start()
        Label2.Text = "Saving your settings..."
        My.Settings.Save()
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Closing, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Closing2, AudioPlayMode.Background)
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Timers"
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer3.Start()
            Label2.Text = "Ending session..."
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            Me.Close()
            End
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub ssexit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub
#End Region
End Class