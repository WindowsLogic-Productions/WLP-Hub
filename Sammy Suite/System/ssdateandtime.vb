Public Class ssdateandtime
    Private Sub ClockTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles ClockTimer.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub ssdateandtime_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub SettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsButton.Click
        sschangedatetime.ShowDialog()
    End Sub
End Class