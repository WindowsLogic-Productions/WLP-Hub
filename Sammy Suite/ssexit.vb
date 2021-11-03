Public Class ssexit
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer3.Start()
            Label2.Text = "WLP Hub is shutting down..."
        End If
    End Sub

    Private Sub ssexit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub

    Private Sub ssexit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Parent = PictureBox2
        Label2.Parent = PictureBox2
        ssexityesno.Close()
        sssc.Close()
        ssabout.Close()
        sscalc.Close()
        sscalcconsts.Close()
        sschangelog.Close()
        sschangeloghelp.Close()
        sschat.Close()
        sserror.Close()
        sserror1.Close()
        ssffw.Close()
        sshelpoffline.Close()
        sshelponline.Close()
        ssimgview.Close()
        ssload.Close()
        ssloaded.Close()
        sslogicbox.Close()
        ssmain.Close()
        ssmusic.Close()
        ssrun.Close()
        sssearch.Close()
        ssskype.Close()
        ssupdater.Close()
        ssupdaterok.Close()
        ssupdateryesno.Close()
        sswritersaveyesno.Close()
        Timer2.Start()
        Label2.Text = "Saving settings and signing out..."
        My.Settings.Save()
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Closing, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Closing2, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ProgressBar2.Increment(1)
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            Me.Close()
            End
        End If
    End Sub
End Class