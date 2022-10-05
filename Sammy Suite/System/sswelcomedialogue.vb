Public Class sswelcomedialogue
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ssdevwhy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NewsFeed.Navigate("https://news.windowslogic.co.uk/")

        Website.Navigate("https://windowslogic.co.uk/")

        BS.Navigate("https://www.youtube.com/watch?v=Nvf4dTMo3oU")

        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        If My.Settings.ALS = 1 Then
            Panel1.Visible = False
        End If

        If My.Settings.ALS = 0 Then
            Panel1.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sswhatsnew.Show()
    End Sub

    Private Sub RMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMLButton.Click
        Panel1.Visible = False
    End Sub

    Private Sub StartWLSButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartWLSButton.Click
        If UsernameBox.Text = "" And PasswordBox.Text = "" Then
            sserror.Show()
            sserror.Label1.Text = "Please enter a username and password."
        Else
            My.Settings.Username = UsernameBox.Text
            My.Settings.Password = PasswordBox.Text
            My.Settings.ALS = 1
            My.Settings.Save()
            ssoobehub.Show()
            Me.Close()

            ssinformation.Show()
            ssinformation.Label1.Text = "Hub Locking System is now enabled. To disable, go to 'Settings Panel > Hub'."
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        sswhatsnew.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If My.Settings.SearchStyle = 0 Then
            ssmain.GeckoWebBrowser1.Show()
            ssmain.NavigateBack.Enabled = True
            ssmain.NavigateForward.Enabled = True
            ssmain.HomeButton.Enabled = True
            ssmain.GeckoWebBrowser1.Navigate("https://windowslogic.co.uk/feedback.php")
        Else
            sssearch.Show()
            sssearch.GeckoWebBrowser1.Navigate("https://windowslogic.co.uk/feedback.php")
        End If
    End Sub
End Class