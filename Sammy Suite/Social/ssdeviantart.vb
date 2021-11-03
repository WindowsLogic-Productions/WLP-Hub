Public Class ssdeviantart
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub sstwitter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sstasklist.DeviantArtButton.Show()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sstasklist.DeviantArtButton.Hide()
    End Sub
End Class