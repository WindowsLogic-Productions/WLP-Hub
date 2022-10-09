Public Class ssoobepersonalisationsounds
#Region "Load Settings"
    Private Sub ssoobehub_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load background settings.
        If My.Settings.DWBWUC = 0 Then
            WLSOOBEBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DWBWUC = 1 Then
            WLSOOBEBackground.Image = Nothing
        End If

        If My.Settings.DWBWUC = 2 Then
            WLSOOBEBackground.Load(My.Settings.CB2)
        End If

        'Load custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load hub sound settings.
        If My.Settings.HubSounds = 0 Then
            DefaultSoundSwitch.Checked = True
        End If

        If My.Settings.HubSounds = 1 Then
            ModernSoundSwitch.Checked = True
        End If

        If My.Settings.HubSounds = 2 Then
            DefaultSoundSwitch.Checked = True
        End If

        'Load parent settings.
        Label2.Parent = WLSOOBEBackground
        Label4.Parent = WLSOOBEBackground
        RMLButton.Parent = WLSOOBEBackground
        ForwardButton.Parent = WLSOOBEBackground
        Label3.Parent = WLSOOBEBackground
        DefaultSoundSwitch.Parent = WLSOOBEBackground
        ModernSoundSwitch.Parent = WLSOOBEBackground
        MuteSoundSwitch.Parent = WLSOOBEBackground
    End Sub
#End Region
#Region "Settings"
    Private Sub DefaultSoundSwitch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DefaultSoundSwitch.CheckedChanged
        If DefaultSoundSwitch.Checked = True Then
            My.Settings.HubSounds = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub ModernSoundSwitch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ModernSoundSwitch.CheckedChanged
        If ModernSoundSwitch.Checked = True Then
            My.Settings.HubSounds = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub MuteSoundSwitch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MuteSoundSwitch.CheckedChanged
        If MuteSoundSwitch.Checked = True Then
            My.Settings.HubSounds = 2
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        My.Settings.Save()
        ssoobecontextbar.Show()
        Me.Close()
    End Sub

    Private Sub RMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMLButton.Click
        ssoobecontextbar.Show()
        Me.Close()
    End Sub
#End Region
End Class