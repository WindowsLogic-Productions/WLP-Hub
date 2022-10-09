Public Class ssoobepersonalisationbackground
#Region "Load Settings"
    Private Sub ssoobehub_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load background settings.
        If My.Settings.DWBWUC = 0 Then
            WLSOOBEBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DWBWUC = 1 Then
            WLSOOBEBackground.Image = Nothing
        End If

        If My.Settings.DWBWUC = 2 Then
            WLSOOBEBackground.Load(My.Settings.CB2)
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

        'Load parent settings.
        Label2.Parent = WLSOOBEBackground
        Label4.Parent = WLSOOBEBackground
        RMLButton.Parent = WLSOOBEBackground
        ForwardButton.Parent = WLSOOBEBackground
        Label5.Parent = WLSOOBEBackground
        Label6.Parent = WLSOOBEBackground
    End Sub
#End Region
#Region "Settings"
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
            ssinformation.Show()
            ssinformation.Label1.Text = "Your background has been applied."
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
            ssinformation.Show()
            ssinformation.Label1.Text = "Your background has been applied."
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
#Region "Other"
    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        My.Settings.Save()
        ssoobepersonalisationcolours.Show()
        Me.Close()
    End Sub

    Private Sub RMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMLButton.Click
        ssoobepersonalisationcolours.Show()
        Me.Close()
    End Sub
#End Region
End Class