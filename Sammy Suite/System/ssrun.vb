Public Class ssrun
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseButton.Click
        ssexplorer.Show()
        ssexplorer.Explorer1.Navigate("C:\")
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Try
            Process.Start(TextBox1.Text)
        Catch ex As Exception
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "The item specified does not exist or was typed incorrectly. (Error code: 0000x007)"
        End Try
    End Sub

    Private Sub Textbox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Process.Start(TextBox1.Text)
            Catch ex As Exception
                sserror.Show()
            End Try
        End If
    End Sub

    Private Sub ssrun_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
End Class