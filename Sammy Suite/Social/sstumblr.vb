Public Class sstumblr
    Private Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BackButton.Click
        GeckoGeckoWebBrowser1.GoBack()
    End Sub

    Private Sub Button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ForwardButton.Click
        GeckoGeckoWebBrowser1.GoForward()
    End Sub

    Private Sub sstumblr_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.TumblrButton.Hide()
    End Sub

    Private Sub sstwitter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sstasklist.TumblrButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub


End Class