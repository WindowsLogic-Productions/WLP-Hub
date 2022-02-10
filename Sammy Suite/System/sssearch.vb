Public Class sssearch
#Region "Load Settings"
    Private Sub sssearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Colour settings.
        If My.Settings.CCE = 0 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Functions"
    Private Sub BackButton_Click(sender As System.Object, e As System.EventArgs) Handles BackButton.Click
        GeckoWebBrowser1.GoBack()
    End Sub

    Private Sub ForwardButton_Click(sender As System.Object, e As System.EventArgs) Handles ForwardButton.Click
        GeckoWebBrowser1.GoForward()
    End Sub

    Private Sub SearchButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchButton.Click
        If My.Settings.SearchEngine = 0 Then
            GeckoWebBrowser1.Navigate("http://www.google.com/search?q=" + Watermark1.Text)
        End If

        If My.Settings.SearchEngine = 1 Then
            GeckoWebBrowser1.Navigate("http://www.bing.com/search?q=" + Watermark1.Text)
        End If

        If My.Settings.SearchEngine = 2 Then
            GeckoWebBrowser1.Navigate("http://uk.search.yahoo.com/search?q=" + Watermark1.Text)
        End If

        If My.Settings.SearchEngine = 3 Then
            GeckoWebBrowser1.Navigate("https://duckduckgo.com/?q=" + Watermark1.Text)
        End If
    End Sub
#End Region
End Class