Public Class ssmusic

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sssc.Button5.Hide()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        AxWindowsMediaPlayer2.Ctlcontrols.play()
        Label3.Text = "Music Status: Playing"
        Button12.Hide()
        Button13.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        AxWindowsMediaPlayer2.Ctlcontrols.pause()
        Label3.Text = "Music Status: Paused"
        Button12.Show()
        Button13.Hide()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        AxWindowsMediaPlayer2.Ctlcontrols.stop()
        Label3.Text = "Music Status: Stopped"
        Button12.Show()
        Button13.Hide()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        AxWindowsMediaPlayer2.Ctlcontrols.previous()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        AxWindowsMediaPlayer2.Ctlcontrols.next()
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer2.settings.volume = TrackBar1.Value
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        AxWindowsMediaPlayer2.settings.volume = TrackBar1.Value = 0
        Button18.Visible = True
        Button17.Visible = False
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        AxWindowsMediaPlayer2.settings.volume = TrackBar1.Value
        Button18.Visible = False
        Button17.Visible = True
    End Sub

    Private Sub AboutSAMMYSuiteMusicPlayerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ssabout.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer2.URL = OpenFileDialog1.FileName
        Label3.Text = "Music Status: Playing"
        Button12.Hide()
        Button13.Show()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        ssabout.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.Hide()
        AxWindowsMediaPlayer2.Location = New Point(0, 22)
        AxWindowsMediaPlayer2.Width = 627
        AxWindowsMediaPlayer2.Height = 274
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.Show()
        AxWindowsMediaPlayer2.Location = New Point(0, 82)
        AxWindowsMediaPlayer2.Width = 627
        AxWindowsMediaPlayer2.Height = 214
    End Sub

    Private Sub ssmusic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sssc.Button5.Show()
    End Sub
End Class