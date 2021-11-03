Public Class sschangepassword

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If UsernameBox1.Text = My.Settings.Username And PasswordBox1.Text = My.Settings.Password Then
            My.Settings.Username = UsernameBox2.Text
            My.Settings.Password = PasswordBox2.Text
            My.Settings.Save()
            sssecurity.Show()
            Me.Close()
            sssecuritybackground.Close()
        Else
            sserror.Show()
            sserror.Label1.Text = "You have entered the wrong credentials, please try again."
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        sssecurity.Show()
        Me.Close()
        sssecuritybackground.Close()
    End Sub
End Class