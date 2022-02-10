Public Class ssmail

    Private Sub AboutToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        ssabout.Text = "About Mail"
        ssabout.AppPic.Image = My.Resources.ssMail
        ssabout.AppName.Text = "Hub Mail - Version 3.1"
        ssabout.ShowDialog()
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
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.MailButton.Hide()
    End Sub

    Private Sub HelpCentreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpCentreToolStripMenuItem.Click
        sshelpoffline.Show()
    End Sub
#Region "Tool Bar"
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        GeckoGeckoWebBrowser1.Navigate("http://mail.google.com")
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        GeckoGeckoWebBrowser1.Navigate("http://login.yahoo.com")
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        GeckoGeckoWebBrowser1.Navigate("http://mail.aol.com")
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        GeckoGeckoWebBrowser1.Navigate("https://email.tesco.net/login/")
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        GeckoGeckoWebBrowser1.Navigate("http://outlook.live.com")
    End Sub
#End Region
End Class