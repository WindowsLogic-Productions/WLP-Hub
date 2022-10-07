Public Class ssmail

    Private Sub AboutToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        ssappabout.Text = "About Mail"
        ssappabout.AppPic.Image = My.Resources.ssMail
        ssappabout.AppName.Text = "Mail"
        ssappabout.AppVer.Text = "Version 3.1"
        ssappabout.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub ssmail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        sstasklist.MailButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
        End If

        If My.Settings.RememberMail = 0 Then
            RememberProviderToolStripMenuItem.Checked = False
        Else
            GeckoWebBrowser1.Navigate(My.Settings.MailProvider)
            RememberProviderToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.MailButton.Hide()
    End Sub

    Private Sub HelpCentreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpCentreToolStripMenuItem.Click
        sshelpoffline.Show()
    End Sub
#Region "Tool Bar"
    Private Sub RememberProviderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RememberProviderToolStripMenuItem.Click
        If RememberProviderToolStripMenuItem.Checked = True Then
            My.Settings.MailProvider = GeckoWebBrowser1.Url.ToString
            My.Settings.RememberMail = 1
            My.Settings.Save()
        Else
            My.Settings.RememberMail = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub GoogleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleToolStripMenuItem.Click
        GeckoWebBrowser1.Navigate("http://mail.google.com")
    End Sub

    Private Sub YahooToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YahooToolStripMenuItem.Click
        GeckoWebBrowser1.Navigate("http://login.yahoo.com")
    End Sub

    Private Sub MicrosoftOutlookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MicrosoftOutlookToolStripMenuItem.Click
        GeckoWebBrowser1.Navigate("http://outlook.live.com")
    End Sub

    Private Sub AolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AolToolStripMenuItem.Click
        GeckoWebBrowser1.Navigate("http://mail.aol.com")
    End Sub

    Private Sub ProtonMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProtonMailToolStripMenuItem.Click
        GeckoWebBrowser1.Navigate("https://protonmail.com")
    End Sub


#End Region
End Class