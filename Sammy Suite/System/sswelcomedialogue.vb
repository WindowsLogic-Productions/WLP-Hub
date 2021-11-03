Public Class sswelcomedialogue
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub ssdevwhy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhatsNewButton.Click
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
            ssinformation.Label1.Text = "Hub ESR Lo cking System is now enabled. To disable, go to 'Settings Panel > Hub'."
        End If
    End Sub
End Class