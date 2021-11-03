Public Class ssupdateprompt
#Region "Load Settings"
    Private Sub ssupdateprompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox2
        PictureBox1.Parent = PictureBox2

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub


#End Region
#Region "Buttons"
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ssupdater.Show()
        ssload.Close()
        Me.Close()
    End Sub

    Private Sub PostponeButton_Click(sender As Object, e As EventArgs) Handles PostponeButton.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        sshelpoffline.Show()

    End Sub
#End Region
End Class