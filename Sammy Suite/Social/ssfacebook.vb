Public Class ssfacebook
#Region "Load Settings"
    Private Sub ssfacebook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sstasklist.FacebookButton.Show()
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region

    Private Sub Button12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BackButton.Click
        GeckoGeckoWebBrowser1.GoBack()
    End Sub

    Private Sub Button13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ForwardButton.Click
        GeckoGeckoWebBrowser1.GoForward()
    End Sub

    Private Sub ssfacebook_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.FacebookButton.Hide()
    End Sub
End Class