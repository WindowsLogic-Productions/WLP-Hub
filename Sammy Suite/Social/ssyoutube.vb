Public Class ssyoutube

    Private Sub ssyoutube_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sstasklist.YouTubeButton.Show()

        If My.Settings.CCE = True Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.YouTubeButton.Hide()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        GeckoGeckoWebBrowser1.GoBack()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        GeckoGeckoWebBrowser1.GoForward()
    End Sub
End Class