Public Class sssecuritybackground

    Private Sub sssecuritybackground_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.System, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.SystemNew, AudioPlayMode.Background)
        End If
    End Sub
End Class