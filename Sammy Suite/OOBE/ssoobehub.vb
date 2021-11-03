Public Class ssoobehub
#Region "Load Settings"
    Private Sub ssoobehub_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load background settings.
        If My.Settings.DWBWUC = 0 Then
            WLSOOBEBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DWBWUC = 1 Then
            WLSOOBEBackground.Image = Nothing
        End If

        If My.Settings.DWBWUC = 2 Then
            WLSOOBEBackground.Load(My.Settings.CB2)
        End If

        'Load parent settings.
        Label2.Parent = WLSOOBEBackground
        Label4.Parent = WLSOOBEBackground
        CheckBox2.Parent = WLSOOBEBackground
        CheckBox3.Parent = WLSOOBEBackground
        CheckBox5.Parent = WLSOOBEBackground
        RMLButton.Parent = WLSOOBEBackground
        ForwardButton.Parent = WLSOOBEBackground

        'Load Enable/Disable Run At Startup Settings
        If My.Settings.Startup = 1 Then
            CheckBox2.Checked = True
        End If

        If My.Settings.Startup = 0 Then
            CheckBox2.Checked = False
        End If

        'Load Enable/Disable Fullscreen Mode Settings.
        If My.Settings.Fullscreen = 1 Then
            CheckBox3.Checked = True
        End If

        If My.Settings.Fullscreen = 0 Then
            CheckBox3.Checked = False
        End If

        'Load Minimise to system tray.
        If My.Settings.Minimise = 1 Then
            CheckBox5.Checked = True
        End If

        If My.Settings.Minimise = 0 Then
            CheckBox5.Checked = False
        End If
    End Sub
#End Region
#Region "Settings"
    'Enable/Disable Run At Startup.
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Try
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                My.Settings.Startup = 1
            Catch
                ssinformation.Show()
                ssinformation.Label1.Text = "You are not an administrator on the current system."
            End Try
        End If

        If CheckBox2.Checked = False Then
            Try
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                My.Settings.Startup = 0
            Catch
                ssinformation.Show()
                ssinformation.Label1.Text = "You are not an administrator on the current system."
            End Try
        End If
    End Sub

    'Enable/disable Fullscreen Mode.
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            ssmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            ssmain.WindowState = FormWindowState.Maximized
            My.Settings.Fullscreen = 1
        End If

        If CheckBox3.Checked = False Then
            ssmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
            ssmain.WindowState = FormWindowState.Maximized
            My.Settings.Fullscreen = 0
        End If
    End Sub

    'Enable/Disable Minimise To System Tray.
    Private Sub CheckBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            My.Settings.Minimise = 1
        End If

        If CheckBox5.Checked = False Then
            My.Settings.Minimise = 0
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        My.Settings.Save()
        ssoobepersonalisationbackground.Show()
        Me.Close()
    End Sub

    Private Sub RMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMLButton.Click
        ssoobepersonalisationbackground.Show()
        Me.Close()
    End Sub
#End Region
End Class