﻿Public Class ssexityesno

    Private Sub ssexityesno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.HubSounds = 0 Then
            My.Computer.Audio.Play(My.Resources.Question, AudioPlayMode.Background)
        End If

        If My.Settings.HubSounds = 1 Then
            My.Computer.Audio.Play(My.Resources.Question2, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ssmain.Dispose()
        ssexit.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class