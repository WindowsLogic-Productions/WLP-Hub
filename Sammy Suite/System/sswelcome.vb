Public Class sswelcome
#Region "Timer Settings"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            If My.Settings.Minimise = 1 Then
            Me.Close()
        End If

        If My.Settings.Minimise = 0 Then

                If My.Settings.ClassicMode = 0 Then
                    sswelcomedialogue.Show()
                    ssmain.ClassicSidePanel.Visible = False
                    ssmain.ClassicSidePanel.Visible = False
                Else
                    ssmain.ClassicSidePanel.Visible = True
                    ssmain.ClassicSidePanel.Visible = True
                End If

                Me.Close()
            End If
        End If
    End Sub
#End Region
#Region "Fade Settings"
    Private Sub ssscload_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub
#End Region
#Region "Load Settings"
    Private Sub ssscload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Load Background Settings.
        If My.Settings.DWBWUC = 0 Then
            WelcomeBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DWBWUC = 1 Then
            WelcomeBackground.Image = Nothing
        End If

        If My.Settings.DWBWUC = 2 Then
            WelcomeBackground.Load(My.Settings.CB2)
        End If

        'Load picture parent settings.
        Loader.Parent = WelcomeBackground
        Label1.Parent = WelcomeBackground
        Timer1.Start()

        'Load sound settings.
        If My.Settings.HubSounds = 0 Then
            sssettingspanelpersonalise.DefaultSoundSwitch.Checked = True
        End If

        If My.Settings.HubSounds = 1 Then
            sssettingspanelpersonalise.ModernSoundSwitch.Checked = True
        End If

        'Load fullscreen settings.
        If My.Settings.Fullscreen = 0 Then
            sssettingspanelhub.CheckBox3.Checked = False
            ssmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
            ssmain.WindowState = FormWindowState.Maximized
        End If

        If My.Settings.Fullscreen = 1 Then
            sssettingspanelhub.CheckBox3.Checked = True
            ssmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            ssmain.WindowState = FormWindowState.Maximized
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
End Class