Public Class ssoobesearch
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

        'Search engine settings.
        If My.Settings.SearchEngine = 0 Then
            GoogleSwitch.Checked = True
        End If

        If My.Settings.SearchEngine = 1 Then
            BingSwitch.Checked = True
        End If

        If My.Settings.SearchEngine = 2 Then
            YahooSwitch.Checked = True
        End If

        If My.Settings.SearchEngine = 3 Then
            DuckDuckGoSwitch.Checked = True
        End If

        'Search style settings
        If My.Settings.SearchStyle = 0 Then
            BuiltInSwitch.Checked = True
        End If

        If My.Settings.SearchStyle = 1 Then
            WindowSwitch.Checked = True
        End If

        'Load parent settings.
        Label2.Parent = WLSOOBEBackground
        Label4.Parent = WLSOOBEBackground
        GroupBox1.Parent = WLSOOBEBackground
        GroupBox2.Parent = WLSOOBEBackground
        RMLButton.Parent = WLSOOBEBackground
        ForwardButton.Parent = WLSOOBEBackground
    End Sub
#End Region
#Region "Settings"
    Private Sub GoogleSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleSwitch.CheckedChanged
        If GoogleSwitch.Checked = True Then
            My.Settings.SearchEngine = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub BingSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingSwitch.CheckedChanged
        If BingSwitch.Checked = True Then
            My.Settings.SearchEngine = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub YahooSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YahooSwitch.CheckedChanged
        If YahooSwitch.Checked = True Then
            My.Settings.SearchEngine = 2
            My.Settings.Save()
        End If
    End Sub

    Private Sub DuckDuckGoSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuckDuckGoSwitch.CheckedChanged
        If DuckDuckGoSwitch.Checked = True Then
            My.Settings.SearchEngine = 3
            My.Settings.Save()
        End If
    End Sub

    Private Sub BuiltInSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuiltInSwitch.CheckedChanged
        If BuiltInSwitch.Checked = True Then
            My.Settings.SearchStyle = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub WindowSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowSwitch.CheckedChanged
        If WindowSwitch.Checked = True Then
            My.Settings.SearchStyle = 1
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        My.Settings.Save()
        ssoobeupdates.Show()
        Me.Close()
    End Sub

    Private Sub RMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMLButton.Click
        ssoobeupdates.Show()
        Me.Close()
    End Sub
#End Region
End Class