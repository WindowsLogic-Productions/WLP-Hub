Public Class sstwitter
    Private Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BackButton.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ForwardButton.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub sstwitter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sstasklist.TwitterButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.TwitterButton.Hide()
    End Sub
End Class