Public Class ssnews
#Region "Load Settings"
    Private Sub ssnews_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        sstasklist.NewsButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Menu"
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HelpCentreToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpCentreToolStripMenuItem.Click
        sshelpoffline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssabout.Text = "About News"
        ssabout.AppPic.Image = My.Resources.ssNews
        ssabout.AppName.Text = "Hub News - Version 2.0"
        ssabout.ShowDialog()
    End Sub
#End Region
#Region "Toolbar"
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        WebBrowser1.Navigate("http://www.bbc.co.uk/news/uk")
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        WebBrowser1.Navigate("http://www.bbc.co.uk/news/world/us_and_canada")
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        WebBrowser1.Navigate("http://www.bbc.co.uk/news/world/africa")
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        WebBrowser1.Navigate("http://www.bbc.co.uk/news/world/asia")
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        WebBrowser1.Navigate("http://www.bbc.co.uk/news/world/australia")
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        WebBrowser1.Navigate("http://www.bbc.co.uk/news/world/europe")
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        WebBrowser1.Navigate("http://www.bbc.co.uk/news/world/latin_america")
    End Sub

    Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
        WebBrowser1.Navigate("http://www.bbc.co.uk/news/world/middle_east")
    End Sub
#End Region
#Region "Other"
    Private Sub ssnews_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.NewsButton.Hide()
    End Sub
#End Region
End Class