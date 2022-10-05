Public Class sssecurity
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property

#Region "Load Settings"
    Private Sub sssecurity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ssmain.HomeButton.Visible = False
        ssmain.ExplorerButton.Visible = False
        ssmain.WindowsDesktopButton.Visible = False
        ssmain.VerInfo.Visible = False
        ssmain.NavigateBack.Visible = False
        ssmain.NavigateForward.Visible = False

        If My.Settings.DetachContextBar = 0 Then
            ssmain.ContextBar.Visible = False
        End If

        If My.Settings.DetachContextBar = 1 Then
            sscontextbar.Close()
            ssmain.ContextBarButton.Visible = False
        End If

        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        Label3.Text = "You are logged on as " + System.Windows.Forms.SystemInformation.UserName + "."
    End Sub
#End Region
#Region "Buttons"
    Private Sub LockPCButton_Click(sender As System.Object, e As System.EventArgs) Handles LockPCButton.Click
        If My.Settings.ALS = 1 Then
            sslock.ShowDialog()
            sssecuritybackground.Show()
            Me.Close()
        End If

        If My.Settings.ALS = 0 Then
            ssinformation.Label1.Text = "You need to enable Hub Locking System before you can use this feature."
            ssinformation.ShowDialog()
        End If
    End Sub

    Private Sub LogOffButton_Click(sender As System.Object, e As System.EventArgs) Handles LogOffButton.Click
        sslogoff.ShowDialog()
    End Sub

    Private Sub SystemPowerButton_Click(sender As System.Object, e As System.EventArgs) Handles SystemPowerButton.Click
        sspower.ShowDialog()
    End Sub

    Private Sub ChangePasswrdButton_Click(sender As System.Object, e As System.EventArgs) Handles ChangePasswrdButton.Click
        If My.Settings.ALS = 1 Then
            sschangepassword.ShowDialog()
            Me.Close()
        End If

        If My.Settings.ALS = 0 Then
            ssinformation.Label1.Text = "You need to enable Hub ESR Locking System before you can use this feature."
            ssinformation.ShowDialog()
        End If
    End Sub

    Private Sub TaskMgrButton_Click(sender As System.Object, e As System.EventArgs) Handles TaskMgrButton.Click
        Process.Start("C:\Windows\System32\taskmgr.exe")
    End Sub

    Private Sub CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
#End Region
#Region "Other"
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles DateTime.Tick
        Label6.Text = TimeOfDay & " - " & Date.Today
    End Sub

    Private Sub sssecurity_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ssmain.HomeButton.Visible = True
        ssmain.ExplorerButton.Visible = True
        ssmain.WindowsDesktopButton.Visible = True
        ssmain.VerInfo.Visible = True
        ssmain.NavigateBack.Visible = True
        ssmain.NavigateForward.Visible = True

        If My.Settings.DetachContextBar = 0 Then
            ssmain.ContextBar.Visible = True
        End If

        If My.Settings.DetachContextBar = 1 Then
            sscontextbar.Show()
            ssmain.ContextBarButton.Visible = True
        End If
    End Sub
#End Region
End Class