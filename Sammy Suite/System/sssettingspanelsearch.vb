Public Class sssettingspanelsearch
#Region "Load Settings"
    Private Sub sssettingspanelsearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'Custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
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
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        sssettingspanel.Show()
        Me.Close()
    End Sub
#End Region
End Class