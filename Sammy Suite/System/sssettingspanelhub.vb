Public Class sssettingspanelhub
#Region "Load Settings"
    Private Sub sssettingspanelgeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sstasklist.SettingsPanelButton.Show()

        'Load Always On Top Settings
        If My.Settings.ContextBarOnTop = 1 Then
            CheckBox1.Checked = True
        End If

        If My.Settings.ContextBarOnTop = 0 Then
            CheckBox1.Checked = False
        End If

        'Load Attach/Detach Context Bar Settings.
        If My.Settings.DetachContextBar = 1 Then
            CheckBox4.Checked = True
        End If

        If My.Settings.DetachContextBar = 0 Then
            CheckBox4.Checked = False
        End If

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

        'Load Classic Mode settings.
        If My.Settings.ClassicMode = 0 Then
            Me.ClassicBox.Checked = False
        Else
            Me.ClassicBox.Checked = True
        End If

        'Search engine settings.
        If My.Settings.SearchEngine = 0 Then
            GoogleSwitch.Checked = True
        End If

        If My.Settings.SearchEngine = 1 Then
            BingSwitch.Checked = True
        End If

        If My.Settings.SearchEngine = 2 Then
            YahooSwitch.Checked = True
        End If

        If My.Settings.SearchEngine = 3 Then
            DuckDuckGoSwitch.Checked = True
        End If

        'Search style settings
        If My.Settings.SearchStyle = 0 Then
            BuiltInSwitch.Checked = True
        End If

        If My.Settings.SearchStyle = 1 Then
            WindowSwitch.Checked = True
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Settings"

    'Enable/disable always on top.
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            sscontextbar.TopMost = True
            My.Settings.ContextBarOnTop = 1
            My.Settings.Save()
        End If
        If CheckBox1.Checked = False Then
            sscontextbar.TopMost = False
            My.Settings.ContextBarOnTop = 0
            My.Settings.Save()
        End If
    End Sub

    'Attach/Detach Context Bar.
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            My.Settings.DetachContextBar = 1
            ssmain.ContextBar.Visible = False
            sscontextbar.Show()
            ssmain.VerInfo.Visible = False
            My.Settings.Save()
        End If

        If CheckBox4.Checked = False Then
            My.Settings.DetachContextBar = 0
            ssmain.ContextBar.Visible = True
            sscontextbar.Close()
            ssmain.VerInfo.Visible = True
            My.Settings.Save()
        End If
    End Sub

    'Enable/Disable Run At Startup.
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Try
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
                My.Settings.Startup = 1
                My.Settings.Save()
            Catch
                ssinformation.Show()
                ssinformation.Label1.Text = "You are not an administrator on the current system."
            End Try
        End If

        If CheckBox2.Checked = False Then
            Try
                My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
                My.Settings.Startup = 0
                My.Settings.Save()
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
            My.Settings.Save()
        End If

        If CheckBox3.Checked = False Then
            ssmain.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
            ssmain.WindowState = FormWindowState.Maximized
            My.Settings.Fullscreen = 0
            My.Settings.Save()
        End If
    End Sub

    'Enable/Disable Minimise To System Tray.
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            My.Settings.Minimise = 1
            My.Settings.Save()
        End If

        If CheckBox5.Checked = False Then
            My.Settings.Minimise = 0
            My.Settings.Save()
        End If
    End Sub

#End Region
#Region "Other"
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        sssettingspanel.Show()
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.CalculatorButton.Hide()
    End Sub

    'Enable/Disable Classic Mode.
    Private Sub ClassicBox_CheckedChanged(sender As Object, e As EventArgs) Handles ClassicBox.CheckedChanged

        If ClassicBox.Checked = False Then
            ssmain.ClassicPanel.Visible = False
            ssmain.ClassicSidePanel.Visible = False
            ssmain.WindowsDesktopButton.Visible = True
            ssmain.ExplorerButton.Visible = True
            My.Settings.ClassicMode = 0
            My.Settings.Save()
        Else
            ssmain.ClassicPanel.Visible = True
            ssmain.ClassicSidePanel.Visible = True
            ssmain.NewsFeedBrowser.Navigate("https://news.windowslogic.co.uk")
            ssmain.ClassicSidePanel.Parent = ssmain.HubBackground
            ssmain.ClassicPanel.Parent = ssmain.HubBackground
            ssmain.WindowsDesktopButton.Visible = False
            ssmain.ExplorerButton.Visible = False
            My.Settings.ClassicMode = 1
            My.Settings.Save()
        End If

    End Sub

    'Search settings.
    Private Sub GoogleSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleSwitch.CheckedChanged
        If GoogleSwitch.Checked = True Then
            My.Settings.SearchEngine = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub BingSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BingSwitch.CheckedChanged
        If BingSwitch.Checked = True Then
            My.Settings.SearchEngine = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub YahooSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YahooSwitch.CheckedChanged
        If YahooSwitch.Checked = True Then
            My.Settings.SearchEngine = 2
            My.Settings.Save()
        End If
    End Sub

    Private Sub DuckDuckGoSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuckDuckGoSwitch.CheckedChanged
        If DuckDuckGoSwitch.Checked = True Then
            My.Settings.SearchEngine = 3
            My.Settings.Save()
        End If
    End Sub

    Private Sub BuiltInSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuiltInSwitch.CheckedChanged
        If BuiltInSwitch.Checked = True Then
            My.Settings.SearchStyle = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub WindowSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowSwitch.CheckedChanged
        If WindowSwitch.Checked = True Then
            My.Settings.SearchStyle = 1
            My.Settings.Save()
        End If
    End Sub
#End Region
End Class