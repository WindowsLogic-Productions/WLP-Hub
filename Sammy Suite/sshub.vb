Public Class sshub

        Private Sub Hub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Opening, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Opening2, AudioPlayMode.Background)
        End If
        ssscload.Show()
        End Sub

        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
            LinkLabel1.Text = TimeOfDay
        End Sub

    Private Sub ExitWLPHubToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitWLPHubToolStripMenuItem.Click
        ssexityesno.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        sssc.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ContextMenuStrip1.Show(Button1, 0, Button1.Height)
    End Sub

    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        ssrun.Show()
    End Sub

    Private Sub HelpTopicsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpTopicsToolStripMenuItem1.Click
        sshelponline.Show()
    End Sub

    Private Sub UpdateLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateLogToolStripMenuItem.Click
        sshelponline.Show()
        sshelponline.WebBrowser1.Navigate("http://www.wlphub.weebly.com/update-log")
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        ssabout.Show()
    End Sub

    Private Sub SystemPreferencesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemPreferencesToolStripMenuItem1.Click
        sssc.Show()
    End Sub
End Class