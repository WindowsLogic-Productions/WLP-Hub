Public Class sswritersaveyesno

    Private Sub sswritersaveyesno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Exclamation, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Exclamation2, AudioPlayMode.Background)
        End If

        SaveButton.Enabled = True

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DontSaveButton.Click
        Me.Dispose()
        sstasklist.WriterButton.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        sswriter.SaveFileDialog1.ShowDialog()
        Me.Dispose()
        sstasklist.WriterButton.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        SaveButton.Enabled = False
        Me.Dispose()
    End Sub
End Class