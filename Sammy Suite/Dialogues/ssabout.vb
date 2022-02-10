Public Class ssabout
#Region "Load Settings"
    Private Sub ssabout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Information, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Information2, AudioPlayMode.Background)
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load information.
        Variables.ParseVariables(VerInfo)
    End Sub
#End Region
#Region "Other"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles MoreButton.Click
        ssdedicate.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ssmain.GeckoWebBrowser1.Navigate("https://www.windowslogic.co.uk/appagreement.php")
        Me.Close()
    End Sub
#End Region
End Class