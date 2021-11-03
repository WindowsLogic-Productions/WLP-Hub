Public Class ssweather

#Region "Load Settings"
    Private Sub ssweather_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        sstasklist.WeatherButton.Show()
    End Sub
#End Region

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.WeatherButton.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        sshelpoffline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssabout.Text = "About Weather"
        ssabout.AppPic.Image = My.Resources.ssWeather
        ssabout.AppName.Text = "Apollo Weather - Version 3.5"
        ssabout.ShowDialog()
    End Sub
End Class