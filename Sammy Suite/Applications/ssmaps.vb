Public Class ssmaps
#Region "Load Settings"
    Private Sub ssmaps_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        sstasklist.MapsButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
        End If

        GeckoWebBrowser1.Navigate("https://maps.google.com")
    End Sub
#End Region
#Region "Menu"
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssappabout.Text = "About Maps"
        ssappabout.AppPic.Image = My.Resources.ssMaps
        ssappabout.AppName.Text = "Maps"
        ssappabout.AppVer.Text = "Version 2.1"
        ssappabout.ShowDialog()
    End Sub
#End Region
#Region "Other"
    Private Sub ssmaps_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.MapsButton.Hide()
    End Sub
#End Region
End Class