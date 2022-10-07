Imports System.IO
Public Class sscalendar
#Region "Load Settings"
    Private Sub sscalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sstasklist.AppointmentsButton.Show()

        Dim m1 As MsgBoxResult
        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        If Date.Today = MonthCalendar1.TodayDate Then
            m1 = MsgBox("Would you like to view the appointment(s) set for today?", MsgBoxStyle.YesNo, "Question")
            If m1 = MsgBoxResult.Yes Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                TextBox1.Enabled = True
                TextBox1.Show()
                SaveButton.Enabled = True
                SaveButton.Show()
                DiscardButton.Enabled = True
                DiscardButton.Show()
                TextBox1.Text = File.ReadAllText(t & ".txt")
            End If
        End If

        Variables.CheckForUpdates()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            MenuStrip1.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Menu"
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub HelpAndSupportCentreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpAndSupportCentreToolStripMenuItem.Click
        sshelpoffline.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        ssappabout.Text = "About Appointments"
        ssappabout.AppPic.Image = My.Resources.ssAppointments
        ssappabout.AppName.Text = "Appointments"
        ssappabout.AppVer.Text = "Version 2.1"
        ssappabout.ShowDialog()
    End Sub
#End Region
#Region "Other"
    Dim m As MsgBoxResult
    Dim t As String
    Private Sub MonthCalendar1_DateChanged(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        t = MonthCalendar1.SelectionRange.Start.Month.ToString & MonthCalendar1.SelectionRange.Start.Day.ToString

        Try
            If File.Exists(t & ".txt") Then
                MonthCalendar1.Enabled = False
                MonthCalendar1.Hide()
                TextBox1.Enabled = True
                TextBox1.Show()
                SaveButton.Enabled = True
                SaveButton.Show()
                DiscardButton.Enabled = True
                DiscardButton.Show()
                TextBox1.Text = File.ReadAllText(t & ".txt")
            Else
                m = MsgBox("Enter appointment(s) for this date?", MsgBoxStyle.YesNo, "Question")
                If m = MsgBoxResult.Yes Then
                    MonthCalendar1.Enabled = False
                    MonthCalendar1.Hide()
                    TextBox1.Enabled = True
                    TextBox1.Show()
                    TextBox1.Text = ""
                    SaveButton.Enabled = True
                    SaveButton.Show()
                    DiscardButton.Enabled = True
                    DiscardButton.Show()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DiscardButton.Click
        TextBox1.Enabled = False
        TextBox1.Hide()
        SaveButton.Enabled = False
        SaveButton.Hide()
        DiscardButton.Enabled = False
        DiscardButton.Hide()
        MonthCalendar1.Enabled = True
        MonthCalendar1.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveButton.Click
        Try
            If TextBox1.Text = "" Then
                If File.Exists(t & ".txt") = True Then
                    File.Delete(t & ".txt")
                End If
            End If
            If TextBox1.Text.Length > 0 Then
                File.WriteAllText(t & ".txt", TextBox1.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.AppointmentsButton.Hide()
    End Sub
#End Region
End Class