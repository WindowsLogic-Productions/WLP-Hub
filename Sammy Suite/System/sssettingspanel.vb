Public Class sssettingspanel
#Region "Load Settings"
    Private Sub sscontrolpanel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sstasklist.SettingsPanelButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Panel Buttons"
    Private Sub HubSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HubSettingsButton.Click
        sssettingspanelhub.Show()
        Me.Close()
    End Sub

    Private Sub PersonaliseSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaliseSettingsButton.Click
        sssettingspanelpersonalise.Show()
        Me.Close()
    End Sub

    Private Sub SearchSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sssettingspanelsearch.Show()
        Me.Close()
    End Sub

    Private Sub UpdatesSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatesSettingsButton.Click
        sssettingspanelupdates.Show()
        Me.Close()
    End Sub

    Private Sub FirewallSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sserror.Show()
        sserror.Label1.Text = "We're currently working on this..."
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click

    End Sub

    Private Sub HelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpButton.Click
        sserror.Show()
        sserror.Label1.Text = "We're currently working on this..."
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.SettingsPanelButton.Hide()
    End Sub
#End Region
End Class