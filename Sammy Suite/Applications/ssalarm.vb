Public Class ssalarm
#Region "Load Settings"
    Private Sub ssalarm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        Timer1.Start()
        sstasklist.AlarmButton.Show()

        'Load colour settings.

        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Timers"
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If Label1.Text = TextBox1.Text Then

            If My.Settings.Alarm = 1 Then
                My.Computer.Audio.Play(My.Resources.Alarm01, AudioPlayMode.BackgroundLoop)
                ChimesToolStripMenuItem.Checked = True
            End If

            If My.Settings.Alarm = 2 Then
                My.Computer.Audio.Play(My.Resources.Alarm02, AudioPlayMode.BackgroundLoop)
                XylophoneToolStripMenuItem.Checked = True
            End If

            If My.Settings.Alarm = 3 Then
                My.Computer.Audio.Play(My.Resources.Alarm03, AudioPlayMode.BackgroundLoop)
                ChordsToolStripMenuItem.Checked = True
            End If

            If My.Settings.Alarm = 4 Then
                My.Computer.Audio.Play(My.Resources.Alarm04, AudioPlayMode.BackgroundLoop)
                TapToolStripMenuItem.Checked = True
            End If

            If My.Settings.Alarm = 5 Then
                My.Computer.Audio.Play(My.Resources.Alarm05, AudioPlayMode.BackgroundLoop)
                JingleToolStripMenuItem.Checked = True
            End If

            If My.Settings.Alarm = 6 Then
                My.Computer.Audio.Play(My.Resources.Alarm06, AudioPlayMode.BackgroundLoop)
                TransitionToolStripMenuItem.Checked = True
            End If

            If My.Settings.Alarm = 7 Then
                My.Computer.Audio.Play(My.Resources.Alarm07, AudioPlayMode.BackgroundLoop)
                DescendingToolStripMenuItem.Checked = True
            End If

            If My.Settings.Alarm = 8 Then
                My.Computer.Audio.Play(My.Resources.Alarm08, AudioPlayMode.BackgroundLoop)
                BounceToolStripMenuItem.Checked = True
            End If

            If My.Settings.Alarm = 9 Then
                My.Computer.Audio.Play(My.Resources.Alarm09, AudioPlayMode.BackgroundLoop)
                DescendingToolStripMenuItem.Checked = True
            End If

            If My.Settings.Alarm = 10 Then
                My.Computer.Audio.Play(My.Resources.Alarm10, AudioPlayMode.BackgroundLoop)
                AscendingToolStripMenuItem.Checked = True
            End If

        End If
    End Sub
#End Region
#Region "Functions"

#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.AlarmButton.Hide()
    End Sub

    Dim charactersAllowed As String = "1234567890:AMP "

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim theText As String = TextBox1.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBox1.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextBox1.Text.Length - 1
            Letter = TextBox1.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextBox1.Text = theText
        TextBox1.Select(SelectionIndex - Change, 0)
    End Sub
#End Region

    Private Sub ChimesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChimesToolStripMenuItem.Click
        If ChimesToolStripMenuItem.Checked = True Then
            XylophoneToolStripMenuItem.Checked = False
            ChordsToolStripMenuItem.Checked = False
            TapToolStripMenuItem.Checked = False
            JingleToolStripMenuItem.Checked = False
            TransitionToolStripMenuItem.Checked = False
            DescendingToolStripMenuItem.Checked = False
            BounceToolStripMenuItem.Checked = False
            EchoToolStripMenuItem.Checked = False
            AscendingToolStripMenuItem.Checked = False
            My.Settings.Alarm = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub XylophoneToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles XylophoneToolStripMenuItem.Click
        If XylophoneToolStripMenuItem.Checked = True Then
            ChimesToolStripMenuItem.Checked = False
            ChordsToolStripMenuItem.Checked = False
            TapToolStripMenuItem.Checked = False
            JingleToolStripMenuItem.Checked = False
            TransitionToolStripMenuItem.Checked = False
            DescendingToolStripMenuItem.Checked = False
            BounceToolStripMenuItem.Checked = False
            EchoToolStripMenuItem.Checked = False
            AscendingToolStripMenuItem.Checked = False
            My.Settings.Alarm = 2
            My.Settings.Save()
        End If
    End Sub

    Private Sub ChordsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChordsToolStripMenuItem.Click
        If ChordsToolStripMenuItem.Checked = True Then
            ChimesToolStripMenuItem.Checked = False
            XylophoneToolStripMenuItem.Checked = False
            TapToolStripMenuItem.Checked = False
            JingleToolStripMenuItem.Checked = False
            TransitionToolStripMenuItem.Checked = False
            DescendingToolStripMenuItem.Checked = False
            BounceToolStripMenuItem.Checked = False
            EchoToolStripMenuItem.Checked = False
            AscendingToolStripMenuItem.Checked = False
            My.Settings.Alarm = 3
            My.Settings.Save()
        End If
    End Sub

    Private Sub TapToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TapToolStripMenuItem.Click
        If TapToolStripMenuItem.Checked = True Then
            ChimesToolStripMenuItem.Checked = False
            XylophoneToolStripMenuItem.Checked = False
            ChordsToolStripMenuItem.Checked = False
            JingleToolStripMenuItem.Checked = False
            TransitionToolStripMenuItem.Checked = False
            DescendingToolStripMenuItem.Checked = False
            BounceToolStripMenuItem.Checked = False
            EchoToolStripMenuItem.Checked = False
            AscendingToolStripMenuItem.Checked = False
            My.Settings.Alarm = 4
            My.Settings.Save()
        End If
    End Sub

    Private Sub JingleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles JingleToolStripMenuItem.Click
        If JingleToolStripMenuItem.Checked = True Then
            ChimesToolStripMenuItem.Checked = False
            XylophoneToolStripMenuItem.Checked = False
            TapToolStripMenuItem.Checked = False
            ChordsToolStripMenuItem.Checked = False
            TransitionToolStripMenuItem.Checked = False
            DescendingToolStripMenuItem.Checked = False
            BounceToolStripMenuItem.Checked = False
            EchoToolStripMenuItem.Checked = False
            AscendingToolStripMenuItem.Checked = False
            My.Settings.Alarm = 5
            My.Settings.Save()
        End If
    End Sub

    Private Sub TransitionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TransitionToolStripMenuItem.Click
        If TransitionToolStripMenuItem.Checked = True Then
            ChimesToolStripMenuItem.Checked = False
            XylophoneToolStripMenuItem.Checked = False
            TapToolStripMenuItem.Checked = False
            JingleToolStripMenuItem.Checked = False
            ChordsToolStripMenuItem.Checked = False
            DescendingToolStripMenuItem.Checked = False
            BounceToolStripMenuItem.Checked = False
            EchoToolStripMenuItem.Checked = False
            AscendingToolStripMenuItem.Checked = False
            My.Settings.Alarm = 6
            My.Settings.Save()
        End If
    End Sub

    Private Sub DescendingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DescendingToolStripMenuItem.Click
        If DescendingToolStripMenuItem.Checked = True Then
            ChimesToolStripMenuItem.Checked = False
            XylophoneToolStripMenuItem.Checked = False
            TapToolStripMenuItem.Checked = False
            JingleToolStripMenuItem.Checked = False
            TransitionToolStripMenuItem.Checked = False
            ChordsToolStripMenuItem.Checked = False
            BounceToolStripMenuItem.Checked = False
            EchoToolStripMenuItem.Checked = False
            AscendingToolStripMenuItem.Checked = False
            My.Settings.Alarm = 7
            My.Settings.Save()
        End If
    End Sub

    Private Sub BounceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BounceToolStripMenuItem.Click
        If BounceToolStripMenuItem.Checked = True Then
            ChimesToolStripMenuItem.Checked = False
            XylophoneToolStripMenuItem.Checked = False
            TapToolStripMenuItem.Checked = False
            JingleToolStripMenuItem.Checked = False
            TransitionToolStripMenuItem.Checked = False
            DescendingToolStripMenuItem.Checked = False
            ChordsToolStripMenuItem.Checked = False
            EchoToolStripMenuItem.Checked = False
            AscendingToolStripMenuItem.Checked = False
            My.Settings.Alarm = 8
            My.Settings.Save()
        End If
    End Sub

    Private Sub EchoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EchoToolStripMenuItem.Click
        If EchoToolStripMenuItem.Checked = True Then
            ChimesToolStripMenuItem.Checked = False
            XylophoneToolStripMenuItem.Checked = False
            TapToolStripMenuItem.Checked = False
            JingleToolStripMenuItem.Checked = False
            TransitionToolStripMenuItem.Checked = False
            DescendingToolStripMenuItem.Checked = False
            BounceToolStripMenuItem.Checked = False
            ChordsToolStripMenuItem.Checked = False
            AscendingToolStripMenuItem.Checked = False
            My.Settings.Alarm = 9
            My.Settings.Save()
        End If
    End Sub

    Private Sub AscendingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AscendingToolStripMenuItem.Click
        If AscendingToolStripMenuItem.Checked = True Then
            ChimesToolStripMenuItem.Checked = False
            XylophoneToolStripMenuItem.Checked = False
            TapToolStripMenuItem.Checked = False
            JingleToolStripMenuItem.Checked = False
            TransitionToolStripMenuItem.Checked = False
            DescendingToolStripMenuItem.Checked = False
            BounceToolStripMenuItem.Checked = False
            EchoToolStripMenuItem.Checked = False
            ChordsToolStripMenuItem.Checked = False
            My.Settings.Alarm = 10
            My.Settings.Save()
        End If
    End Sub

    Private Sub HelpCentreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpCentreToolStripMenuItem.Click
        sshelpoffline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssabout.Text = "About Alarm"
        ssabout.AppPic.Image = My.Resources.ssAlarm
        ssabout.AppName.Text = "Hub Alarm - Version 4.2"
        ssabout.ShowDialog()
    End Sub

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        Timer2.Start()
        Label2.Show()
        PictureBox1.Show()
        ssexclamation.Show()
        SetButton.Enabled = False
        StopButton.Enabled = True
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        My.Computer.Audio.Stop()
        Label2.Hide()
        PictureBox1.Hide()
        ssexclamation.Show()
        ssexclamation.Text = "Alarm Stopped"
        ssexclamation.Label1.Text = "The alarm set for " & TextBox1.Text & " has been stopped."
        SetButton.Enabled = True
        StopButton.Enabled = False
    End Sub
End Class