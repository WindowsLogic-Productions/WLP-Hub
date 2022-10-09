Imports System.ComponentModel

Public Class ssmusic
#Region "Load Settings"


    Private Sub ssmusic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        sstasklist.MusicButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Player Functions"


    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll

        AxWindowsMediaPlayer2.Ctlcontrols.pause()

        AxWindowsMediaPlayer2.Ctlcontrols.currentPosition = TrackBar2.Value



    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PlayButton.Hide()
        PauseButton.Show()

        ListBox2.SelectedIndex = ListBox1.SelectedIndex

        AxWindowsMediaPlayer2.URL = ListBox2.SelectedItem

    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        PlayButton.Hide()
        PauseButton.Show()
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        AxWindowsMediaPlayer2.URL = ListBox2.SelectedItem
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        Dim cp As Integer = CInt(AxWindowsMediaPlayer2.Ctlcontrols.currentPosition)
        If cp < TrackBar2.Minimum Then
            cp = TrackBar2.Minimum
        End If
        If cp > TrackBar2.Maximum Then
            cp = TrackBar2.Maximum
        End If
        If AxWindowsMediaPlayer2.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            TrackBar2.Value = cp
            MillisecondsS.Text = AxWindowsMediaPlayer2.Ctlcontrols.currentPosition
        End If
    End Sub

    Private Sub AxWindowsMediaPlayer1_PlayStateChange(ByVal sender As System.Object,
 ByVal e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer2.PlayStateChange


        If AxWindowsMediaPlayer2.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            TrackBar2.Maximum = CInt(AxWindowsMediaPlayer2.Ctlcontrols.currentItem.duration)
            Timer2.Start()

        ElseIf AxWindowsMediaPlayer2.playState = WMPLib.WMPPlayState.wmppsPaused Then
            Timer2.Stop()

        ElseIf AxWindowsMediaPlayer2.playState = WMPLib.WMPPlayState.wmppsStopped Then
            Timer2.Stop()
            TrackBar2.Value = 0

        End If


    End Sub

    Private Sub TrackBar2_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles TrackBar2.MouseUp
        AxWindowsMediaPlayer2.Ctlcontrols.play()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayButton.Click
        If ListBox1.Items.Count = Nothing Then
            sserror.Label1.Text = "Playlist is empty. Please add music before attempting to play."
            sserror.ShowDialog()
        Else
            AxWindowsMediaPlayer2.Ctlcontrols.play()
            PlayButton.Hide()
            PauseButton.Show()
            TrackBar1.Value = 50
        End If


    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseButton.Click
        AxWindowsMediaPlayer2.Ctlcontrols.pause()
        PlayButton.Show()
        PauseButton.Hide()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        AxWindowsMediaPlayer2.Ctlcontrols.stop()
        PlayButton.Show()
        PauseButton.Hide()
        MillisecondsS.Text = "00.000"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousButton.Click
        Try
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            AxWindowsMediaPlayer2.URL = ListBox2.SelectedItem
        Catch ex As Exception
            sserror.Label1.Text = "No music left in playlist."
            sserror.ShowDialog()
        End Try
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        Try
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            AxWindowsMediaPlayer2.URL = ListBox2.SelectedItem
        Catch
            sserror.Label1.Text = "No music left in playlist."
            sserror.ShowDialog()
        End Try
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer2.settings.volume = TrackBar1.Value
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuteButton.Click
        AxWindowsMediaPlayer2.settings.volume = TrackBar1.Value = 0
        UnmuteButton.Visible = True
        MuteButton.Visible = False
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnmuteButton.Click
        AxWindowsMediaPlayer2.settings.volume = TrackBar1.Value
        UnmuteButton.Visible = False
        MuteButton.Visible = True
    End Sub

    Private Sub TrackBar2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles TrackBar2.ValueChanged
        If TrackBar2.Value = TrackBar2.Maximum Then
            Dim listbox As New Integer
            listbox = ListBox1.SelectedIndex
            If My.Settings.MPRepeat = 1 Then
                TrackBar2.Value = TrackBar2.Minimum
                AxWindowsMediaPlayer2.Ctlcontrols.currentPosition = 0
                Return
            End If

            Try
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            Catch
                If My.Settings.MPRepeatPlaylist = 1 Then
                    ListBox1.SelectedIndex = 0
                    AxWindowsMediaPlayer2.Ctlcontrols.stop()
                    AxWindowsMediaPlayer2.Ctlcontrols.play()
                    PlayButton.Hide()
                    PauseButton.Show()

                    AxWindowsMediaPlayer2.Ctlcontrols.currentPosition = 0
                End If
                Exit Try
            End Try

            If My.Settings.MPShuffle = 1 Then
                Dim ns As Integer = CInt(Math.Floor((ListBox1.Items.Count - 0) * Rnd())) + 0
                ListBox1.SelectedIndex = ns
                Return
            End If
        End If
    End Sub

    Private Sub RepeatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RepeatToolStripMenuItem.Click
        If RepeatToolStripMenuItem.Checked = True Then
            My.Settings.MPRepeat = 1
        End If

        If RepeatToolStripMenuItem.Checked = False Then
            My.Settings.MPRepeat = 0
        End If
    End Sub

    Private Sub RepeatPlaylistToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RepeatPlaylistToolStripMenuItem.Click
        If RepeatPlaylistToolStripMenuItem.Checked = True Then
            My.Settings.MPRepeatPlaylist = 1
        End If

        If RepeatPlaylistToolStripMenuItem.Checked = False Then
            My.Settings.MPRepeatPlaylist = 0
        End If
    End Sub

    Private Sub ShuffleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShuffleToolStripMenuItem.Click
        If ShuffleToolStripMenuItem.Checked = True Then
            My.Settings.MPShuffle = 1
        End If

        If ShuffleToolStripMenuItem.Checked = False Then
            My.Settings.MPShuffle = 0
        End If
    End Sub
#End Region
#Region "Menu"

    Private Sub PlaylistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaylistToolStripMenuItem.Click
        ssmusicplaylist.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub HelpCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpCentreToolStripMenuItem.Click
        sshelpoffline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ssappabout.Text = "About Music"
        ssappabout.AppPic.Image = My.Resources.ssMusic
        ssappabout.AppName.Text = "Music"
        ssappabout.AppVer.Text = "Version 6.0"
        ssappabout.ShowDialog()
    End sub
#End Region

#Region "Updates"
    Public Sub CheckForUpdates()

        If My.Settings.Updates = 1 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SS/SS.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                Else
                    ssupdateprompt.Show()
                End If
            Catch
                sserror.Show()
                sserror.Label1.Text = "No connection to the update server."
            End Try
        End If

        If My.Settings.Updates = 0 Then

        End If
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.MusicButton.Hide()
    End Sub
#End Region
End Class