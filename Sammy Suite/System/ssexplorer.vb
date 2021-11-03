Imports System
Imports System.IO

Public Class ssexplorer
#Region "Load Settings"
    Private Sub ssexplorer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Load disk drives.
        Dim ADrive As New System.IO.DirectoryInfo("A:")
        If ADrive.Exists() Then
            DriveBox.Items.Add("A:\")
        End If

        Dim BDrive As New System.IO.DirectoryInfo("B:")
        If BDrive.Exists() Then
            DriveBox.Items.Add("B:\")
        End If

        Dim CDrive As New System.IO.DirectoryInfo("C:")
        If CDrive.Exists() Then
            DriveBox.Items.Add("C:\")
        End If

        Dim DDrive As New System.IO.DirectoryInfo("D:")
        If DDrive.Exists() Then
            DriveBox.Items.Add("D:\")
        End If

        Dim EDrive As New System.IO.DirectoryInfo("E:")
        If EDrive.Exists() Then
            DriveBox.Items.Add("E:\")
        End If

        Dim FDrive As New System.IO.DirectoryInfo("F:")
        If FDrive.Exists() Then
            DriveBox.Items.Add("F:\")
        End If

        Dim GDrive As New System.IO.DirectoryInfo("G:")
        If GDrive.Exists() Then
            DriveBox.Items.Add("G:\")
        End If

        Dim HDrive As New System.IO.DirectoryInfo("H:")
        If HDrive.Exists() Then
            DriveBox.Items.Add("H:\")
        End If

        Dim IDrive As New System.IO.DirectoryInfo("I:")
        If IDrive.Exists() Then
            DriveBox.Items.Add("I:\")
        End If

        Dim JDrive As New System.IO.DirectoryInfo("J:")
        If JDrive.Exists() Then
            DriveBox.Items.Add("J:\")
        End If

        Dim KDrive As New System.IO.DirectoryInfo("K:")
        If KDrive.Exists() Then
            DriveBox.Items.Add("K:\")
        End If

        Dim LDrive As New System.IO.DirectoryInfo("L:")
        If LDrive.Exists() Then
            DriveBox.Items.Add("L:\")
        End If

        Dim MDrive As New System.IO.DirectoryInfo("M:")
        If MDrive.Exists() Then
            DriveBox.Items.Add("M:\")
        End If

        Dim NDrive As New System.IO.DirectoryInfo("N:")
        If NDrive.Exists() Then
            DriveBox.Items.Add("N:\")
        End If

        Dim ODrive As New System.IO.DirectoryInfo("O:")
        If ODrive.Exists() Then
            DriveBox.Items.Add("O:\")
        End If

        Dim PDrive As New System.IO.DirectoryInfo("P:")
        If PDrive.Exists() Then
            DriveBox.Items.Add("P:\")
        End If

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.MenuStrip1.BackColor = My.Settings.CustomColour
            Me.BackColor = My.Settings.CustomColour
        End If

        sstasklist.ExplorerButton.Show()
    End Sub
#End Region
#Region "Functions"
    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        Explorer1.GoBack()
    End Sub

    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        Explorer1.GoForward()
    End Sub

    Private Sub Browser_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles Explorer1.Navigated
        TextBox1.Text = Explorer1.Url.AbsolutePath

        If TextBox1.Text.Contains("/") Then
            TextBox1.Text = TextBox1.Text.Replace("/", "\")
        End If

    End Sub

    Private Sub DriveBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveBox.SelectedIndexChanged
        If DriveBox.SelectedItem = "A:\" Then
            Explorer1.Navigate("A:\")
        End If

        If DriveBox.SelectedItem = "B:\" Then
            Explorer1.Navigate("B:\")
        End If

        If DriveBox.SelectedItem = "C:\" Then
            Explorer1.Navigate("C:\")
        End If

        If DriveBox.SelectedItem = "D:\" Then
            Explorer1.Navigate("D:\")
        End If

        If DriveBox.SelectedItem = "E:\" Then
            Explorer1.Navigate("E:\")
        End If

        If DriveBox.SelectedItem = "F:\" Then
            Explorer1.Navigate("F:\")
        End If

        If DriveBox.SelectedItem = "G:\" Then
            Explorer1.Navigate("G:\")
        End If

        If DriveBox.SelectedItem = "H:\" Then
            Explorer1.Navigate("H:\")
        End If

        If DriveBox.SelectedItem = "I:\" Then
            Explorer1.Navigate("I:\")
        End If

        If DriveBox.SelectedItem = "J:\" Then
            Explorer1.Navigate("J:\")
        End If

        If DriveBox.SelectedItem = "K:\" Then
            Explorer1.Navigate("K:\")
        End If

        If DriveBox.SelectedItem = "L:\" Then
            Explorer1.Navigate("L:\")
        End If

        If DriveBox.SelectedItem = "M:\" Then
            Explorer1.Navigate("M:\")
        End If

        If DriveBox.SelectedItem = "N:\" Then
            Explorer1.Navigate("N:\")
        End If

        If DriveBox.SelectedItem = "O:\" Then
            Explorer1.Navigate("O:\")
        End If

        If DriveBox.SelectedItem = "P:\" Then
            Explorer1.Navigate("P:\")
        End If

        If DriveBox.SelectedItem = "Q:\" Then
            Explorer1.Navigate("Q:\")
        End If

        If DriveBox.SelectedItem = "R:\" Then
            Explorer1.Navigate("R:\")
        End If

        If DriveBox.SelectedItem = "S:\" Then
            Explorer1.Navigate("S:\")
        End If

        If DriveBox.SelectedItem = "T:\" Then
            Explorer1.Navigate("T:\")
        End If
    End Sub
#End Region
#Region "Menu"
    
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub SettingsPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsPanelToolStripMenuItem.Click
        sssettingspanel.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssabout.Text = "About File Explorer"
        ssabout.AppPic.Image = My.Resources.ssApps
        ssabout.AppName.Text = "Hub File Explorer - Version 2.0"
        ssabout.ShowDialog()
    End Sub
#End Region
#Region "Other"
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.ExplorerButton.Hide()
    End Sub
#End Region
End Class