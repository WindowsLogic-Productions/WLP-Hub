Imports System.IO
Imports Microsoft.Win32

Public Class sssc

    Dim cpu As Integer
    Dim ram As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Width = 423
        Me.Height = 248
        Button1.Show()
        Button2.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Width = 423
        Me.Height = 591
        Button2.Show()
        Button1.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
        Label2.Text = TimeOfDay
    End Sub

    Private Sub sssc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Hide()
        WebBrowser1.Hide()
        MonthCalendar1.Hide()
        Me.Width = 423
        Me.Height = 248

        If My.Settings.SystemControlsOnTop = 1 Then
            CheckBox1.Checked = True
        End If

        If My.Settings.SystemControlsOnTop = 0 Then
            CheckBox1.Checked = False
        End If

        If My.Settings.Startup = 0 Then
            CheckBox2.Checked = False
        End If

        If My.Settings.Startup = 1 Then
            CheckBox2.Checked = True
        End If

        If My.Settings.Fullscreen = 0 Then
            CheckBox3.Checked = False
        End If

        If My.Settings.Fullscreen = 1 Then
            CheckBox3.Checked = True
        End If

        If My.Settings.HubSounds = 0 Then
            RadioButton1.Checked = True
        End If

        If My.Settings.HubSounds = 1 Then
            RadioButton2.Checked = True
        End If

        If My.Settings.Updates = 1 Then
            RadioButton3.Checked = True
        End If

        If My.Settings.Updates = 0 Then
            RadioButton4.Checked = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Label1.Show()
        WebBrowser1.Show()
        MonthCalendar1.Show()
        Label2.Hide()
        LinkLabel1.Hide()
        LinkLabel2.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Label1.Hide()
        WebBrowser1.Hide()
        MonthCalendar1.Hide()
        Label2.Show()
        LinkLabel1.Show()
        LinkLabel2.Hide()
    End Sub

    Private Sub System_Monitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TopMost = True
            My.Settings.SystemControlsOnTop = 1
            My.Settings.Save()
        End If
        If CheckBox1.Checked = False Then
            Me.TopMost = False
            My.Settings.SystemControlsOnTop = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        My.Settings.Save()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        For Each Process As ListViewItem In ListView1.SelectedItems
            System.Diagnostics.Process.GetProcessById(Process.SubItems(4).Text).Kill()
        Next
        System_Monitor_Load(Nothing, Nothing)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ssrun.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Process.Start("C:\Windows\system32\perfmon")
    End Sub

    Private Sub ActionCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionCentreToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.ActionCenter")
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Process.Start("taskmgr.exe")
    End Sub

    Private Sub WindowsFirewallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsFirewallToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.WindowsFirewall")
    End Sub

    Private Sub SystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.System")
    End Sub

    Private Sub WindowsUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsUpdateToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.WindowsUpdate")
    End Sub

    Private Sub PowerOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerOptionsToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.PowerOptions")
    End Sub

    Private Sub BackupAndRestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupAndRestoreToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.backupandrestore")
    End Sub

    Private Sub BitlockerDriveEncryptionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BitlockerDriveEncryptionToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.bitlockerdriveencryption")
    End Sub

    Private Sub AdministrativeToolsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministrativeToolsToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.administrativetools")
    End Sub

    Private Sub UserAccountsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountsToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.useraccounts")
    End Sub

    Private Sub ParentalControlsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParentalControlsToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.parentalcontrols")
    End Sub

    Private Sub WindowsCardspaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsCardspaceToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.cardspace")
    End Sub

    Private Sub CredentialManagerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CredentialManagerToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.credentialmanager")
    End Sub

    Private Sub NetworkAndSharingCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetworkAndSharingCentreToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.networkandsharingcenter")
    End Sub

    Private Sub HomeGroupToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeGroupToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.homegroup")
    End Sub

    Private Sub InternetOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternetOptionsToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.internetoptions")
    End Sub

    Private Sub PersonalisationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalisationToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.personalization")
    End Sub

    Private Sub DisplayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.display")
    End Sub

    Private Sub DesktopGadgetsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesktopGadgetsToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.desktopgadgets")
    End Sub

    Private Sub TaskbarAndStartMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskbarAndStartMenuToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.taskbarandstartmenu")
    End Sub

    Private Sub EaseOfAccessCentreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EaseOfAccessCentreToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.easeofaccesscenter")
    End Sub

    Private Sub FolderOptionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderOptionsToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.folderoptions")
    End Sub

    Private Sub FontsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontsToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.fonts")
    End Sub

    Private Sub DevicesAndPrintersToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevicesAndPrintersToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.devicesandprinters")
    End Sub

    Private Sub AutoplayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoplayToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.autoplay")
    End Sub

    Private Sub SoundToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoundToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.sound")
    End Sub

    Private Sub PowerOptionsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerOptionsToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.poweroptions")
    End Sub

    Private Sub DisplayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.display")
    End Sub

    Private Sub DateAndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateAndTimeToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.dateandtime")
    End Sub

    Private Sub RegionAndLanguageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegionAndLanguageToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.regionandlanguage")
    End Sub

    Private Sub ProgramsAndFeaturesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramsAndFeaturesToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.programsandfeatures")
    End Sub

    Private Sub DefaultProgramsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultProgramsToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.defaultprograms")
    End Sub

    Private Sub DesktopGadgetsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesktopGadgetsToolStripMenuItem1.Click
        Process.Start("control.exe", "/name Microsoft.desktopgadgets")
    End Sub

    Private Sub EaseOfAccessCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EaseOfAccessCentreToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.easeofaccesscenter")
    End Sub

    Private Sub SpeechRecognitionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeechRecognitionToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.speechrecognition")
    End Sub

    Private Sub ColourManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColourManagementToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.colormanagement")
    End Sub

    Private Sub DeviceManagerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeviceManagerToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.devicemanager")
    End Sub

    Private Sub GettingStartedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GettingStartedToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.indexingoptions")
    End Sub

    Private Sub KeyboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeyboardToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.keyboard")
    End Sub

    Private Sub LocationAndOtherSensorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationAndOtherSensorsToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.locationandothersensors")
    End Sub

    Private Sub MouseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MouseToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.mouse")
    End Sub

    Private Sub NotificationsAreaIconsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotificationsAreaIconsToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.notificationareaicons")
    End Sub

    Private Sub PerformanceAndInformationToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerformanceAndInformationToolsToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.performanceinformationandtools")
    End Sub

    Private Sub PhoneAndModemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhoneAndModemToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.phoneandmodem")
    End Sub

    Private Sub RecoveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecoveryToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.recovery")
    End Sub

    Private Sub RemoteAppAndDesktopConnectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoteAppAndDesktopConnectionsToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.remoteappanddesktopconnections")
    End Sub

    Private Sub SyncCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SyncCentreToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.synccenter")
    End Sub

    Private Sub TroubleshootingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TroubleshootingToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.troubleshooting")
    End Sub

    Private Sub WindowsDefenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsDefenderToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.windowsdefender")
    End Sub

    Private Sub TSAppInstallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSAppInstallToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.tsappinstall")
    End Sub

    Private Sub FileHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileHistoryToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.filehistory")
    End Sub

    Private Sub StorageSpacesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StorageSpacesToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.storagespaces")
    End Sub

    Private Sub WindowsToGoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsToGoToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.portableworkspacecreator")
    End Sub

    Private Sub WorkFoldersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkFoldersToolStripMenuItem.Click
        Process.Start("control.exe", "/name Microsoft.workspaces")
    End Sub

    Private Sub ShutdownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutdownToolStripMenuItem.Click
        Shell("shutdown -s")
    End Sub

    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        Shell("shutdown -r")
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        Shell("shutdown -l")
    End Sub

    Private Sub ExitWLPHubToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitWLPHubToolStripMenuItem.Click
        ssexityesno.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            My.Settings.HubSounds = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            My.Settings.HubSounds = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.Save()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            My.Settings.Updates = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            My.Settings.Updates = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            My.Settings.Startup = 1
            My.Settings.Save()
        End If

        If CheckBox2.Checked = False Then
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
            My.Settings.Startup = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        ssupdater.Show()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.Save()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Process.Start("c:\windows\system32\regedt32.exe")
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Process.Start("c:\windows\system32\winver.exe")
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            ssscload.BackColor = Color.DodgerBlue
            ssmain.BackColor = Color.DodgerBlue
            ssmain.Panel1.BackColor = Color.DodgerBlue
            ssmain.MenuStrip1.BackColor = Color.DodgerBlue
            Me.BackColor = Color.DodgerBlue
            sschat.Panel1.BackColor = Color.DodgerBlue
            sschat.Panel2.BackColor = Color.DodgerBlue
            sschat.Panel4.BackColor = Color.DodgerBlue
            sschat.Panel5.BackColor = Color.DodgerBlue
            sschat.Panel6.BackColor = Color.DodgerBlue
            sschat.Panel7.BackColor = Color.DodgerBlue
            sschat.Panel8.BackColor = Color.DodgerBlue
            ssabout.BackColor = Color.DodgerBlue
            ssrun.BackColor = Color.DodgerBlue
            sshelpoffline.BackColor = Color.DodgerBlue
            sshelponline.BackColor = Color.DodgerBlue
            sserror.BackColor = Color.DodgerBlue
            sserror1.BackColor = Color.DodgerBlue
            ssexityesno.BackColor = Color.DodgerBlue
            ssexit.BackColor = Color.DodgerBlue
            RadioButton6.Checked = True
            My.Settings.PersonaliseColour = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            ssscload.BackColor = Color.Maroon
            ssmain.BackColor = Color.Maroon
            ssmain.Panel1.BackColor = Color.Maroon
            ssmain.MenuStrip1.BackColor = Color.Maroon
            Me.BackColor = Color.Maroon
            sschat.Panel1.BackColor = Color.Maroon
            sschat.Panel2.BackColor = Color.Maroon
            sschat.Panel4.BackColor = Color.Maroon
            sschat.Panel5.BackColor = Color.Maroon
            sschat.Panel6.BackColor = Color.Maroon
            sschat.Panel7.BackColor = Color.Maroon
            sschat.Panel8.BackColor = Color.Maroon
            ssabout.BackColor = Color.Maroon
            ssrun.BackColor = Color.Maroon
            sshelpoffline.BackColor = Color.Maroon
            sshelponline.BackColor = Color.Maroon
            sserror.BackColor = Color.Maroon
            sserror1.BackColor = Color.Maroon
            ssexityesno.BackColor = Color.Maroon
            ssexit.BackColor = Color.Maroon
            RadioButton7.Checked = True
            My.Settings.PersonaliseColour = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            ssmain.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            ssmain.WindowState = FormWindowState.Maximized
            My.Settings.Fullscreen = 1
            My.Settings.Save()
        End If

        If CheckBox3.Checked = False Then
            ssmain.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            ssmain.WindowState = FormWindowState.Maximized
            My.Settings.Fullscreen = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Process.Start("C:\Windows\explorer.exe")
    End Sub

    Private Sub SwitchToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwitchToToolStripMenuItem.Click
        sscalc.TopMost = True
        sscalc.TopMost = False
        sscalc.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        sscalc.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sscalc.TopMost = True
        sscalc.TopMost = False
        sscalc.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        ssffw.TopMost = True
        ssffw.TopMost = False
        ssffw.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        ssffw.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ssffw.TopMost = True
        ssffw.TopMost = False
        ssffw.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        ssmusic.TopMost = True
        ssmusic.TopMost = False
        ssmusic.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        ssmusic.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ssmusic.TopMost = True
        ssmusic.TopMost = False
        ssmusic.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        ssimgview.TopMost = True
        ssimgview.TopMost = false
        ssimgview.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        ssimgview.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ssimgview.TopMost = True
        ssimgview.TopMost = False
        ssimgview.WindowState = FormWindowState.Normal
    End Sub

    Private Sub RestartWLPHubToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartWLPHubToolStripMenuItem.Click
        ssload.Show()
        ssmain.Dispose()
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            ssscload.BackColor = Color.Navy
            ssmain.BackColor = Color.Navy
            ssmain.Panel1.BackColor = Color.Navy
            ssmain.MenuStrip1.BackColor = Color.Navy
            Me.BackColor = Color.Navy
            sschat.Panel1.BackColor = Color.Navy
            sschat.Panel2.BackColor = Color.Navy
            sschat.Panel4.BackColor = Color.Navy
            sschat.Panel5.BackColor = Color.Navy
            sschat.Panel6.BackColor = Color.Navy
            sschat.Panel7.BackColor = Color.Navy
            sschat.Panel8.BackColor = Color.Navy
            ssabout.BackColor = Color.Navy
            ssrun.BackColor = Color.Navy
            sshelpoffline.BackColor = Color.Navy
            sshelponline.BackColor = Color.Navy
            sserror.BackColor = Color.Navy
            sserror1.BackColor = Color.Navy
            ssexityesno.BackColor = Color.Navy
            ssexit.BackColor = Color.Navy
            RadioButton8.Checked = True
            My.Settings.PersonaliseColour = 2
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            ssscload.BackColor = Color.DarkGreen
            ssmain.BackColor = Color.DarkGreen
            ssmain.Panel1.BackColor = Color.DarkGreen
            ssmain.MenuStrip1.BackColor = Color.DarkGreen
            Me.BackColor = Color.DarkGreen
            sschat.Panel1.BackColor = Color.DarkGreen
            sschat.Panel2.BackColor = Color.DarkGreen
            sschat.Panel4.BackColor = Color.DarkGreen
            sschat.Panel5.BackColor = Color.DarkGreen
            sschat.Panel6.BackColor = Color.DarkGreen
            sschat.Panel7.BackColor = Color.DarkGreen
            sschat.Panel8.BackColor = Color.DarkGreen
            ssabout.BackColor = Color.DarkGreen
            ssrun.BackColor = Color.DarkGreen
            sshelpoffline.BackColor = Color.DarkGreen
            sshelponline.BackColor = Color.DarkGreen
            sserror.BackColor = Color.DarkGreen
            sserror1.BackColor = Color.DarkGreen
            ssexityesno.BackColor = Color.DarkGreen
            ssexit.BackColor = Color.DarkGreen
            RadioButton9.Checked = True
            My.Settings.PersonaliseColour = 3
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            ssscload.BackColor = Color.DarkOrange
            ssmain.BackColor = Color.DarkOrange
            ssmain.Panel1.BackColor = Color.DarkOrange
            ssmain.MenuStrip1.BackColor = Color.DarkOrange
            Me.BackColor = Color.DarkOrange
            sschat.Panel1.BackColor = Color.DarkOrange
            sschat.Panel2.BackColor = Color.DarkOrange
            sschat.Panel4.BackColor = Color.DarkOrange
            sschat.Panel5.BackColor = Color.DarkOrange
            sschat.Panel6.BackColor = Color.DarkOrange
            sschat.Panel7.BackColor = Color.DarkOrange
            sschat.Panel8.BackColor = Color.DarkOrange
            ssabout.BackColor = Color.DarkOrange
            ssrun.BackColor = Color.DarkOrange
            sshelpoffline.BackColor = Color.DarkOrange
            sshelponline.BackColor = Color.DarkOrange
            sserror.BackColor = Color.DarkOrange
            sserror1.BackColor = Color.DarkOrange
            ssexityesno.BackColor = Color.DarkOrange
            ssexit.BackColor = Color.DarkOrange
            RadioButton10.Checked = True
            My.Settings.PersonaliseColour = 4
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            ssscload.BackColor = Color.Purple
            ssmain.BackColor = Color.Purple
            ssmain.Panel1.BackColor = Color.Purple
            ssmain.MenuStrip1.BackColor = Color.Purple
            Me.BackColor = Color.Purple
            sschat.Panel1.BackColor = Color.Purple
            sschat.Panel2.BackColor = Color.Purple
            sschat.Panel4.BackColor = Color.Purple
            sschat.Panel5.BackColor = Color.Purple
            sschat.Panel6.BackColor = Color.Purple
            sschat.Panel7.BackColor = Color.Purple
            sschat.Panel8.BackColor = Color.Purple
            ssabout.BackColor = Color.Purple
            ssrun.BackColor = Color.Purple
            sshelpoffline.BackColor = Color.Purple
            sshelponline.BackColor = Color.Purple
            sserror.BackColor = Color.Purple
            sserror1.BackColor = Color.Purple
            ssexityesno.BackColor = Color.Purple
            ssexit.BackColor = Color.Purple
            RadioButton11.Checked = True
            My.Settings.PersonaliseColour = 5
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            ssscload.BackColor = Color.DeepPink
            sshub.BackColor = Color.DeepPink
            ssmain.BackColor = Color.DeepPink
            ssmain.Panel1.BackColor = Color.DeepPink
            ssmain.MenuStrip1.BackColor = Color.DeepPink
            Me.BackColor = Color.DeepPink
            sschat.Panel1.BackColor = Color.DeepPink
            sschat.Panel2.BackColor = Color.DeepPink
            sschat.Panel4.BackColor = Color.DeepPink
            sschat.Panel5.BackColor = Color.DeepPink
            sschat.Panel6.BackColor = Color.DeepPink
            sschat.Panel7.BackColor = Color.DeepPink
            sschat.Panel8.BackColor = Color.DeepPink
            ssabout.BackColor = Color.DeepPink
            ssrun.BackColor = Color.DeepPink
            sshelpoffline.BackColor = Color.DeepPink
            sshelponline.BackColor = Color.DeepPink
            sserror.BackColor = Color.DeepPink
            sserror1.BackColor = Color.DeepPink
            ssexityesno.BackColor = Color.DeepPink
            ssexit.BackColor = Color.DeepPink
            RadioButton12.Checked = True
            My.Settings.PersonaliseColour = 6
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then
            ssscload.BackColor = Color.Indigo
            sshub.BackColor = Color.Indigo
            ssmain.BackColor = Color.Indigo
            ssmain.Panel1.BackColor = Color.Indigo
            ssmain.MenuStrip1.BackColor = Color.Indigo
            Me.BackColor = Color.Indigo
            sschat.Panel1.BackColor = Color.Indigo
            sschat.Panel2.BackColor = Color.Indigo
            sschat.Panel4.BackColor = Color.Indigo
            sschat.Panel5.BackColor = Color.Indigo
            sschat.Panel6.BackColor = Color.Indigo
            sschat.Panel7.BackColor = Color.Indigo
            sschat.Panel8.BackColor = Color.Indigo
            ssabout.BackColor = Color.Indigo
            ssrun.BackColor = Color.Indigo
            sshelpoffline.BackColor = Color.Indigo
            sshelponline.BackColor = Color.Indigo
            sserror.BackColor = Color.Indigo
            sserror1.BackColor = Color.Indigo
            ssexityesno.BackColor = Color.Indigo
            ssexit.BackColor = Color.Indigo
            RadioButton16.Checked = True
            My.Settings.PersonaliseColour = 8
            My.Settings.Save()
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then

            My.Settings.PersonaliseColour = 9
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        sscdplayer.TopMost = True
        sscdplayer.TopMost = False
        sscdplayer.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        sssketchpad.TopMost = True
        sssketchpad.TopMost = False
        sssketchpad.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        ssweather.TopMost = True
        ssweather.TopMost = False
        ssweather.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        ssmemory.TopMost = True
        ssmemory.TopMost = False
        ssmemory.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        ssbreakout.TopMost = True
        ssbreakout.TopMost = False
        ssbreakout.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        ssskype.TopMost = True
        ssskype.TopMost = False
        ssskype.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        sschat.TopMost = True
        sschat.TopMost = False
        sschat.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        sshelponline.TopMost = True
        sshelpoffline.TopMost = True
        sshelponline.TopMost = False
        sshelpoffline.TopMost = False
        sshelpbasicactions.TopMost = False
        sshelpbasicactions.TopMost = True
        sshelpgettingaround.TopMost = False
        sshelpgettingaround.TopMost = True
        sshelphubapps.TopMost = False
        sshelphubapps.TopMost = True
        sshelpsettings.TopMost = False
        sshelpsettings.TopMost = True
        sshelponline.WindowState = FormWindowState.Normal
        sshelpoffline.WindowState = FormWindowState.Normal
        sshelpbasicactions.WindowState = FormWindowState.Normal
        sshelpgettingaround.WindowState = FormWindowState.Normal
        sshelphubapps.WindowState = FormWindowState.Normal
        sshelpsettings.WindowState = FormWindowState.Normal
        sschangelog.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem7.Click
        sscdplayer.TopMost = True
        sscdplayer.TopMost = False
        sscdplayer.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem8.Click
        sscdplayer.Close()
    End Sub

    Private Sub ContextMenuStrip6_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip6.Opening
        sssketchpad.TopMost = True
        sssketchpad.TopMost = False
        sssketchpad.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem10.Click
        sssketchpad.Close()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem11.Click
        ssweather.TopMost = True
        ssweather.TopMost = False
        ssweather.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem12.Click
        ssweather.Close()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem15.Click
        ssmemory.TopMost = True
        ssmemory.TopMost = False
        ssmemory.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem16.Click
        ssmemory.Close()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem13.Click
        ssbreakout.TopMost = True
        ssbreakout.TopMost = False
        ssbreakout.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem14.Click
        ssbreakout.Close()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem17.Click
        sschat.TopMost = True
        sschat.TopMost = False
        sschat.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem18.Click
        sschat.Close()
    End Sub

    Private Sub ContextMenuStrip11_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip11.Opening
        ssskype.TopMost = True
        ssskype.TopMost = False
        ssskype.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem20.Click
        ssskype.Close()
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem21.Click
        sshelponline.TopMost = True
        sshelpoffline.TopMost = True
        sshelponline.TopMost = False
        sshelpoffline.TopMost = False
        sshelponline.WindowState = FormWindowState.Normal
        sshelpoffline.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem22.Click
        sshelponline.Close()
        sshelpoffline.Close()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Button16.Enabled = True
            ColorDialog1.ShowDialog()
        End If
    End Sub
End Class