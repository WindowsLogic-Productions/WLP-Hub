Public Class ssprocesslist
#Region "Load Settings & Processes"
    Private Sub System_Monitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sstasklist.ProcessListButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load locking system settings.
        If My.Settings.ALS = 0 Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If

        Dim Process As New Process()
        Dim Count As Integer = 0
        ListView1.Items.Clear()
        For Each Process In Process.GetProcesses(My.Computer.Name)
            On Error Resume Next
            ListView1.Items.Add(Process.ProcessName)
            ListView1.Items(Count).SubItems.Add(FormatNumber(Math.Round(Process.PrivateMemorySize64 / 1024), 0))
            ListView1.Items(Count).SubItems.Add(Process.Responding)
            ListView1.Items(Count).SubItems.Add(Process.StartTime.ToString.Trim)
            ListView1.Items(Count).SubItems.Add(Process.Id)
            Count += 1
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ssprocesslistyesno.ShowDialog()
        System_Monitor_Load(Nothing, Nothing)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ssrun.Text = "New Process..."
        ssrun.PictureBox1.Image = My.Resources.ssProcessList
        ssrun.ShowDialog()
    End Sub
#End Region
#Region "System"
    Private Sub ShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutDownToolStripMenuItem.Click
        Shell("shutdown -s -t 00")
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Shell("shutdown -r -t 00")
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        sslogoff.ShowDialog()
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.ProcessListButton.Hide()
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        If UsernameBox1.Text = My.Settings.Username And PasswordBox1.Text = My.Settings.Password Then
            My.Settings.Username = UsernameBox2.Text
            My.Settings.Password = PasswordBox2.Text
            My.Settings.Save()
            ssinformation.Label1.Text = "Hub Locking System password has been changed."
            ssinformation.ShowDialog()
        Else
            sserror.Show()
            sserror.Label1.Text = "You have entered the wrong credentials, please try again."
        End If
    End Sub

    Private Sub RestartWLPHubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartWLPHubToolStripMenuItem.Click
        ssload.Show()
        ssmain.Dispose()
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ExitWLPHubToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitWLPHubToolStripMenuItem.Click
        ssexit.Show()
        sstasklist.Close()
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ssrun.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ssprocesslistyesno.ShowDialog()
        System_Monitor_Load(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Process.Start("resmon.exe")
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Process.Start("control.exe")
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Process.Start("taskmgr.exe")
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        sssysinfo.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Process.Start("winver.exe")
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Process.Start("explorer.exe")
    End Sub


#End Region
End Class