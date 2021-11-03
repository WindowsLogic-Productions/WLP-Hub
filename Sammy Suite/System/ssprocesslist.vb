Public Class ssprocesslist
#Region "Load Settings & Processes"
    Private Sub System_Monitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sstasklist.ProcessListButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
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

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EndProcessButton.Click
        ssprocesslistyesno.ShowDialog()
        ssinformation.Show()
        ssinformation.Label1.Text = "Process ended successfully."
        System_Monitor_Load(Nothing, Nothing)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewProcessButton.Click
        ssrun.Text = "New Process..."
        ssrun.PictureBox1.Image = My.Resources.ssProcessList
        ssrun.Show()
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.ProcessListButton.Hide()
    End Sub
#End Region
End Class