Public Class ssbatterylow

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Dispose()
    End Sub

    Private Sub ssbatterylow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'colour settings
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        My.Computer.Audio.Play(My.Resources.LowBattery, AudioPlayMode.Background)
    End Sub
End Class