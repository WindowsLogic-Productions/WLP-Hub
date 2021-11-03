Public Class ssoobeupdates
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

        'Load custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

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

        'Load parent settings.
        Label2.Parent = WLSOOBEBackground
        Label4.Parent = WLSOOBEBackground
        EnableUpdatesSwitch.Parent = WLSOOBEBackground
        AdhocUpdatesSwitch.Parent = WLSOOBEBackground
        DisableUpdatesSwitch.Parent = WLSOOBEBackground
        Label5.Parent = WLSOOBEBackground
        Label8.Parent = WLSOOBEBackground
        Label6.Parent = WLSOOBEBackground
        RMLButton.Parent = WLSOOBEBackground
        ForwardButton.Parent = WLSOOBEBackground
    End Sub
#End Region
#Region "Settings"
    'Update settings.
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableUpdatesSwitch.CheckedChanged
        If EnableUpdatesSwitch.Checked = True Then
            My.Settings.Updates = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub AdhocUpdatesSwitch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles AdhocUpdatesSwitch.CheckedChanged
        If AdhocUpdatesSwitch.Checked = True Then
            My.Settings.Updates = 2
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableUpdatesSwitch.CheckedChanged
        If DisableUpdatesSwitch.Checked = True Then
            My.Settings.Updates = 0
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        My.Settings.OOBE = 1
        My.Settings.Save()
        sswelcome.Show()
        ssmain.Show()
        Me.Close()
    End Sub

    Private Sub RMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMLButton.Click
        My.Settings.OOBE = 1
        sswelcome.Show()
        ssmain.Show()
        Me.Close()
    End Sub
#End Region
End Class