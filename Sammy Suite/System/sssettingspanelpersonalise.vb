Public Class sssettingspanelpersonalise
#Region "Load Settings"
    Private Sub sssettingspanelpersonalise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sstasklist.SettingsPanelButton.Show()

        'Load hub sound settings.
        If My.Settings.HubSounds = 0 Then
            DefaultSoundSwitch.Checked = True
        End If

        If My.Settings.HubSounds = 1 Then
            ModernSoundSwitch.Checked = True
        End If

        If My.Settings.HubSounds = 2 Then
            MuteSoundSwitch.Checked = True
        End If

        'Background settings.
        If My.Settings.DHBHUC = 0 Then
            HDBSwitch.Checked = True
        End If

        If My.Settings.DHBHUC = 1 Then
            HUCSwitch.Checked = True
        End If

        If My.Settings.DHBHUC = 2 Then
            RB1Box.Checked = True
            HubBackgroundPicture.Load(My.Settings.CB1)
        End If

        If My.Settings.DWBWUC = 0 Then
            WDBSwitch.Checked = True
        End If

        If My.Settings.DWBWUC = 1 Then
            WUCSwitch.Checked = True
        End If

        If My.Settings.DWBWUC = 2 Then
            RB2Box.Checked = True
            CB2Button.Enabled = True
            WelcomeBackgroundPicture.Load(My.Settings.CB2)
        End If

        'Load custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            CCEBox.Checked = True
        End If
    End Sub
#End Region
#Region "Background Settings"
#Region "Hub Background"
    Private Sub CB1Box_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1Box.Click
        If RB1Box.Checked = True Then
            CB1Button.Enabled = True
            HUCSwitch.Checked = False
            HDBSwitch.Checked = False
            Try
                HubBackgroundPicture.Load(My.Settings.CB1)
                ssmain.HubBackground.Load(My.Settings.CB1)
                My.Settings.DHBHUC = 2
                My.Settings.Save()
            Catch ex As Exception

            End Try
        End If

        If RB1Box.Checked = False Then
            My.Settings.DHBHUC = 0
            CB1Button.Enabled = False
            HubBackgroundPicture.Image = Nothing
            My.Settings.Save()
        End If
    End Sub

    Private Sub CB1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB1Button.Click
        OpenFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            HubBackgroundPicture.Load(OpenFileDialog1.FileName)
            My.Settings.CB1 = OpenFileDialog1.FileName
            ssmain.HubBackground.Load(My.Settings.CB1)
            ssbackgroundconfirm.Show()
            ssbackgroundconfirm.Dispose()
            My.Settings.Save()
        End If
    End Sub

    Private Sub HDBSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDBSwitch.CheckedChanged
        If HDBSwitch.Checked = True Then
            My.Settings.DHBHUC = 0
            CB1Button.Enabled = False
            RB1Box.Checked = False
            HubBackgroundPicture.Image = My.Resources.WLPBackground
            ssmain.HubBackground.Image = My.Resources.WLPBackground
            My.Settings.Save()
        End If
    End Sub

    Private Sub HUCSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HUCSwitch.CheckedChanged
        If HUCSwitch.Checked = True Then
            My.Settings.DHBHUC = 1
            CB1Button.Enabled = False
            RB1Box.Checked = False
            HubBackgroundPicture.Image = Nothing
            ssmain.HubBackground.Image = Nothing
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Welcome Background"
    Private Sub CB2Box_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB2Box.Click
        If RB2Box.Checked = True Then
            CB2Button.Enabled = True
            WUCSwitch.Checked = False
            WDBSwitch.Checked = False
            Try
                WelcomeBackgroundPicture.Load(My.Settings.CB2)
                sswelcome.WelcomeBackground.Load(My.Settings.CB2)
                My.Settings.DWBWUC = 2
                My.Settings.Save()
            Catch ex As Exception

            End Try
        End If

        If RB2Box.Checked = False Then
            My.Settings.DWBWUC = 0
            CB2Button.Enabled = False
            WelcomeBackgroundPicture.Image = Nothing
            My.Settings.Save()
        End If
    End Sub

    Private Sub CB2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB2Button.Click
        OpenFileDialog2.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            WelcomeBackgroundPicture.Load(OpenFileDialog2.FileName)
            My.Settings.CB2 = OpenFileDialog2.FileName
            sswelcome.WelcomeBackground.Load(My.Settings.CB2)
            ssexit.ExitBackground.Load(My.Settings.CB2)
            ssbackgroundconfirm.Show()
            ssbackgroundconfirm.Dispose()
            My.Settings.Save()
        End If
    End Sub

    Private Sub WDBSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WDBSwitch.CheckedChanged
        If WDBSwitch.Checked = True Then
            My.Settings.DWBWUC = 0
            CB2Button.Enabled = False
            RB2Box.Checked = False
            WelcomeBackgroundPicture.Image = My.Resources.WLPBackground
            sswelcome.WelcomeBackground.Image = My.Resources.WLPBackground
            ssexit.ExitBackground.Image = My.Resources.WLPBackground
            My.Settings.Save()
        End If
    End Sub

    Private Sub WUCSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WUCSwitch.CheckedChanged
        If WUCSwitch.Checked = True Then
            My.Settings.DWBWUC = 1
            CB2Button.Enabled = False
            RB2Box.Checked = False
            WelcomeBackgroundPicture.Image = Nothing
            sswelcome.WelcomeBackground.Image = Nothing
            ssexit.ExitBackground.Image = Nothing
            My.Settings.Save()
        End If
    End Sub
#End Region
#End Region
#Region "Colour Settings"

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CCEBox.CheckedChanged
        If CCEBox.Checked = True Then
            CustomColourButton.Enabled = True
            My.Settings.CCE = 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomColourButton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.CustomColour = ColorDialog1.Color
            Me.BackColor = My.Settings.CustomColour
            ssmain.ContextBar.BackColor = My.Settings.CustomColour
            My.Settings.Save()
        End If
    End Sub

    Private Sub BCEBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
#End Region
#Region "Sound Settings"
    Private Sub DefaultSoundSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles DefaultSoundSwitch.CheckedChanged
        If DefaultSoundSwitch.Checked = True Then
            My.Settings.HubSounds = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub ModernSoundSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles ModernSoundSwitch.CheckedChanged
        If ModernSoundSwitch.Checked = True Then
            My.Settings.HubSounds = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub MuteSoundSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles MuteSoundSwitch.CheckedChanged
        If MuteSoundSwitch.Checked = True Then
            My.Settings.HubSounds = 2
            My.Settings.Save()
        End If
    End Sub


#End Region
#Region "Other"
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BackButton.Click
        sssettingspanel.Show()
        My.Settings.Save()
        Me.Dispose()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.SettingsPanelButton.Hide()
    End Sub
#End Region
End Class