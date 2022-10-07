Public Class ssinformation
#Region "Load Settings"
    Private Sub ssinformation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Load sounds.
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Info, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Information2, AudioPlayMode.Background)
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
#End Region
End Class