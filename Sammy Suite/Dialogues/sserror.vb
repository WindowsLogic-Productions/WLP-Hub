Public Class sserror
    
    Private Sub sserror_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Load sounds.
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Critical, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Critical2, AudioPlayMode.Background)
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub ErrorLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ErrorLink.LinkClicked
        sssearch.Show()
        sssearch.GeckoWebBrowser1.Navigate("dev.windowslogic.co.uk/sserrors.html")
    End Sub
End Class