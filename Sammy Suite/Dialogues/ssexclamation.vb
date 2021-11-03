Public Class ssexclamation
#Region "Load Settings"
    Private Sub sserror1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Sound properties
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Exclamation, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Exclamation2, AudioPlayMode.Background)
        End If

        'Text properties.
        Label1.Text = "The alarm has been set for " & ssalarm.TextBox1.Text & "." & " Keep 'Alarm' open."

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
#End Region
End Class