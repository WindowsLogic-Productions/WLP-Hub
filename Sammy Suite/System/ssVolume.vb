Imports CoreAudioApi

Public Class ssVolume
    Dim Svol As Integer = 0

    'FUNCTION SET VOLUME
    Private Function SetVol() As Integer
        Dim DevEnum As New MMDeviceEnumerator
        Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
        device.AudioEndpointVolume.MasterVolumeLevelScalar = Svol / 100.0F
    End Function

    'FUNCTION GET VOLUME
    Private Function GetVol() As Integer
        Dim MasterMin As Integer = 0
        Dim DevEnum As New MMDeviceEnumerator
        Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)
        Dim Vol As Integer = 0

        With device.AudioEndpointvolume
            Vol = CInt(.MasterVolumeLevelScalar * 100)
            If Vol < MasterMin Then
                Vol = MasterMin / 100
            End If
        End With
        Return Vol
    End Function

    Private Sub ssVolume_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'custom colours.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'displays the current system volume.
        SoundLevelLabel.Text = GetVol() & "%"
        VolumeSlider.Value = GetVol()
    End Sub

    Private Sub VolumeSlider_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VolumeSlider.MouseUp
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.System, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.SystemNew, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub VolumeSlider_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolumeSlider.Scroll
        Svol = VolumeSlider.Value
        If Svol < 0 Then
            Svol = 0
        ElseIf Svol > 100 Then
            Svol = 100
        End If
        SoundLevelLabel.Text = GetVol() & "%"
        SetVol()
    End Sub

    Private Sub ADPButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADPButton.Click
        Shell("control mmsys.cpl")
    End Sub

    Private Sub MixerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MixerButton.Click
        Process.Start("SndVol.exe")
    End Sub

    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click
        ssabout.Text = "About Volume Control"
        ssabout.AppPic.Image = My.Resources.ssUnmute
        ssabout.AppName.Text = "Hub Volume Control - Version 1.1"
        ssabout.ShowDialog()
    End Sub
End Class