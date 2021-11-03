Public Class sspower
#Region "Disable Close Button"
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
#End Region
#Region "Load Settings"
    Private Sub sspower_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click

        If ComboBox1.SelectedItem = "Shut down" Then
            Label3.Text = "Ends your session and shuts down Windows so that" & vbNewLine & "you can safely turn off power."
            Shell("shutdown -s -t 00")
        End If

        If ComboBox1.SelectedItem = "Restart" Then
            Label3.Text = "Ends your session, shuts down Windows, and starts" & vbNewLine & "Windows again."
            Shell("shutdown -r -t 00")
            My.Settings.Save()
            End
        End If

        If ComboBox1.SelectedItem = "Exit WindowsLogic Productions Hub" Then
            Label3.Text = "Saves settings and closes WindowsLogic Productions Hub."
            ssexit.Show()
            sstasklist.Close()
            Me.Close()
        End If

        If ComboBox1.SelectedItem = "Restart WindowsLogic Productions Hub" Then
            Label3.Text = "Saves settings, closes WindowsLogic Productions Hub" & vbNewLine & "and starts WindowsLogic Productions Hub again."
            ssload.Show()
            sssecuritybackground.Dispose()
            ssmain.Dispose()
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.Click
        Me.Dispose()
        sssecuritybackground.Dispose()
    End Sub

    Private Sub HelpButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GetHelpButton.Click
        sshelpoffline.Show()
    End Sub

#End Region
#Region "Other"
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedItem = "Shut down" Then
            Label3.Text = "Ends your session and shuts down Windows so that" & vbNewLine & "you can safely turn off power."
        End If

        If ComboBox1.SelectedItem = "Restart" Then
            Label3.Text = "Ends your session, shuts down Windows, and starts" & vbNewLine & "Windows again."
        End If

        If ComboBox1.SelectedItem = "Exit WindowsLogic Productions Hub" Then
            Label3.Text = "Saves settings and closes WindowsLogic Productions Hub."
        End If

        If ComboBox1.SelectedItem = "Restart WindowsLogic Productions Hub" Then
            Label3.Text = "Saves settings, closes WindowsLogic Productions Hub" & vbNewLine & "and starts WindowsLogic Productions Hub again."
        End If
    End Sub
#End Region
End Class