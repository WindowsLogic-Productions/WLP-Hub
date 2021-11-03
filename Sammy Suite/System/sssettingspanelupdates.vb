Public Class sssettingspanelupdates
    Private Sub sssettingspanelupdates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sstasklist.SettingsPanelButton.Show()

        'Load update settings.
        If My.Settings.Updates = 1 Then
            EnableUpdatesSwitch.Checked = True
        End If

        If My.Settings.Updates = 2 Then
            AdhocUpdatesSwitch.Checked = True
        End If

        If My.Settings.Updates = 0 Then
            DisableUpdatesSwitch.Checked = True
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    'Update settings.
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableUpdatesSwitch.CheckedChanged
        If EnableUpdatesSwitch.Checked = True Then
            My.Settings.Updates = 1
            PictureBox1.Image = My.Resources.GoodGradient
            My.Settings.Save()
        End If
    End Sub

    Private Sub AdhocUpdatesSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles AdhocUpdatesSwitch.CheckedChanged
        If AdhocUpdatesSwitch.Checked = True Then
            My.Settings.Updates = 2
            PictureBox1.Image = My.Resources.WarningGradient
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableUpdatesSwitch.CheckedChanged
        If DisableUpdatesSwitch.Checked = True Then
            My.Settings.Updates = 0
            PictureBox1.Image = My.Resources.BadGradient
            My.Settings.Save()
        End If
    End Sub

    'Manually check for updates.
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualUpdateButton.Click
        ssupdater.Show()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        sssettingspanel.Show()
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.SettingsPanelButton.Hide()
    End Sub
End Class