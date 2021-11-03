Public Class sscdplayer
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    'Drives.

    Dim Ddrive As String = "D:\" 'D is the default CD/DVD drive letter.
    Dim Edrive As String = "E:\" 'Some CD/DVD drives have E as the letter.
    Dim Fdrive As String = "F:\" 'Uncommon, but here nontheless.
    Dim Gdrive As String = "G:\" 'Uncommon, but here nontheless.
    'Other things.
    Dim retVal As Integer
    Dim buf As String = Space(128)
    Dim buf2 As String = Space(128)
    Dim buf3 As String = Space(128)
    Dim trackCount As Integer
    Dim currentTrack As Integer
#Region "Load Settings"
    Private Sub sscdplayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        sstasklist.CDPlayerButton.Show()
        Ddrive = Chr(34) & Ddrive & Chr(34)
        Edrive = Chr(34) & Edrive & Chr(34)
        Fdrive = Chr(34) & Fdrive & Chr(34)
        Gdrive = Chr(34) & Gdrive & Chr(34)
        retVal = mciSendString("open " & Ddrive & " type cdaudio alias cd wait shareable", vbNullString, 0, 0)
        retVal = mciSendString("open " & Edrive & " type cdaudio alias cd wait shareable", vbNullString, 0, 0)
        retVal = mciSendString("open " & Fdrive & " type cdaudio alias cd wait shareable", vbNullString, 0, 0)
        retVal = mciSendString("open " & Gdrive & " type cdaudio alias cd wait shareable", vbNullString, 0, 0)
        retVal = mciSendString("set cd time format tmsf", vbNullString, 0, 0) 'This will set it so the tracks are recognized as 1 2 3 4...
        retVal = mciSendString("status cd number of tracks", buf, 128, 0) 'Get Num. Of Tracks
        retVal = mciSendString("status cd current track", buf2, 128, 0) 'Get Current Track
        trackCount = CInt(Val(buf)) 'This Will Get the Number Of Tracks (Convert it Into 1 2 3 4...)
        currentTrack = CInt(Val(buf2)) 'This Will get the Current Track (Convert it Into 1 2 3 4...)
        TrackS.Text = "Track: " & currentTrack & " / " & trackCount
        NumericUpDown1.Maximum = trackCount + 1

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        retVal = mciSendString("play cd", vbNullString, 0, 0) 'Tell the system to play the CD.
        Label4.Text = "CD Status: Playing"
        sscdplayer_Load(Nothing, Nothing)
        Timer2.Start()
        Button8.Hide()
        Button2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        retVal = mciSendString("stop cd", vbNullString, 0, 0) 'Tell the system to stop the CD.
        Timer2.Stop()
        MillisecondsS.Text = "00"
        SecondsS.Text = "00"
        MinutesS.Text = "00"
        Label4.Text = "CD Status: Stopped"
        Button2.Hide()
        Button8.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        retVal = mciSendString("pause cd", vbNullString, 0, 0) 'Tell the system to pause the CD.
        Timer2.Stop()
        Label4.Text = "CD Status: Paused"
        Button2.Hide()
        Button8.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        retVal = mciSendString("set cd door open", vbNullString, 0, 0)
        Timer2.Stop()
        MillisecondsS.Text = "00"
        SecondsS.Text = "00"
        MinutesS.Text = "00"
        Label4.Text = "CD Status: Please Insert CD"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        NumericUpDown1.UpButton()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        NumericUpDown1.DownButton()
    End Sub
#End Region
#Region "Menu"

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayToolStripMenuItem.Click
        retVal = mciSendString("play cd", vbNullString, 0, 0) 'Tell the system to play the CD.
        Label4.Text = "CD Status: Playing"
        sscdplayer_Load(Nothing, Nothing)
        Timer2.Start()
        Button8.Hide()
        Button2.Show()
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        retVal = mciSendString("stop cd", vbNullString, 0, 0) 'Tell the system to stop the CD.
        Timer2.Stop()
        MillisecondsS.Text = "00"
        SecondsS.Text = "00"
        MinutesS.Text = "00"
        Label4.Text = "CD Status: Stopped"
        Button2.Hide()
        Button8.Show()
    End Sub

    Private Sub PreviousToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousToolStripMenuItem.Click
        NumericUpDown1.DownButton()
    End Sub

    Private Sub NextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextToolStripMenuItem.Click
        NumericUpDown1.UpButton()
    End Sub

    Private Sub EjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EjectToolStripMenuItem.Click
        retVal = mciSendString("set cd door open", vbNullString, 0, 0)
        Timer2.Stop()
        MillisecondsS.Text = "00"
        SecondsS.Text = "00"
        MinutesS.Text = "00"
        Label4.Text = "CDStatus: Please Insert CD"
    End Sub

    Private Sub HelpCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpCentreToolStripMenuItem.Click
        sshelpoffline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssabout.Text = "About CD Player"
        ssabout.AppPic.Image = My.Resources.ssCDPlayer
        ssabout.AppName.Text = "Hub CD Player - Version 7.1"
        ssabout.ShowDialog()
    End Sub
#End Region
#Region "Track System"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        retVal = mciSendString("status cd current track", buf2, 128, 0) 'This will get the current Track
        currentTrack = CInt(Val(buf2)) 'Converts it into 1 2 3 4...
        TrackS.Text = "Track: " & currentTrack & " / " & trackCount
        NumericUpDown1.Value = currentTrack
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        MillisecondsS.Text += 1
        If MillisecondsS.Text = 65 Then
            SecondsS.Text += 1
            MillisecondsS.Text = 0
            If SecondsS.Text = 60 Then
                MinutesS.Text += 1
                SecondsS.Text = 0
            End If
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 0 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 1 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 2 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
            End If
        If NumericUpDown1.Value = 3 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 4 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 5 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
            End If
        If NumericUpDown1.Value = 6 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 7 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 8 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 9 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 10 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 11 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 12 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 13 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 14 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 15 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 16 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 17 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 18 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 19 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 20 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 21 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 22 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 23 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 24 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 25 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 26 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If
        If NumericUpDown1.Value = 27 Then
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Timer2.Start()
        End If

        If My.Settings.CDShuffle = 1 Then
            Dim ns As Integer = CInt(Math.Floor((NumericUpDown1.Value - 0) * Rnd())) + 0
            NumericUpDown1.Value = ns
            Return
        End If

        If NumericUpDown1.Value = 0 Then
            NumericUpDown1.Value = trackCount
        End If

        If NumericUpDown1.Value = NumericUpDown1.Maximum Then
            retVal = mciSendString("stop cd", vbNullString, 0, 0) 'Tell the system to stop the CD.
            Timer2.Stop()
            MillisecondsS.Text = "00"
            SecondsS.Text = "00"
            MinutesS.Text = "00"
            Label4.Text = "CD Status: Stopped"
        End If

        sscdplayer_Load(Nothing, Nothing)
        retVal = mciSendString("set cd time format tmsf", vbNullString, 0, 0) 'Sets it into 1 2 3 4...
        retVal = mciSendString("seek cd to " & NumericUpDown1.Value, vbNullString, 0, 0) 'Seeks CD to track number inputed.
        If retVal = mciSendString("play cd", vbNullString, 0, 0) Then 'Tell the system to play the CD.
            Label4.Text = "CD Status: Awaiting Input"
            Button8.Hide()
            Button2.Show()
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.CDPlayerButton.Hide()
        retVal = mciSendString("stop cd", vbNullString, 0, 0) 'Tell the system to stop the CD.
        Timer2.Stop()
        MillisecondsS.Text = "00"
        SecondsS.Text = "00"
        MinutesS.Text = "00"
        Label4.Text = "CD Status: Stopped"
    End Sub
#End Region
End Class