Public Class ssupdateryesno

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ssload.PictureBox2.Show()
        ssload.Timer1.Start()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ssupdater.Show()
        ssload.Close()
        Me.Close()
    End Sub

    Private Sub ssupdateryesno_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub

    Private Sub ssupdateryesno_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If My.Settings.HubSounds = 0 Then
            sssc.RadioButton1.Checked = True
        End If

        If My.Settings.HubSounds = 1 Then
            sssc.RadioButton2.Checked = True
        End If

        Me.TopMost = True
    End Sub
End Class