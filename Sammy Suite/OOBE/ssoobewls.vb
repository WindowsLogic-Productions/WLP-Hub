Public Class ssoobewls
#Region "Load Settings"
    Private Sub ssoobewls_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load background settings.
        If My.Settings.DWBWUC = 0 Then
            WLSOOBEBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DWBWUC = 1 Then
            WLSOOBEBackground.Image = Nothing
        End If

        If My.Settings.DWBWUC = 2 Then
            WLSOOBEBackground.Load(My.Settings.CB2)
        End If

        'Load parenting settings.
        Label2.Parent = WLSOOBEBackground
        Label4.Parent = WLSOOBEBackground
        Label7.Parent = WLSOOBEBackground
        Label8.Parent = WLSOOBEBackground
        Label9.Parent = WLSOOBEBackground
        RMLButton.Parent = WLSOOBEBackground
        ForwardButton.Parent = WLSOOBEBackground
    End Sub
#End Region
#Region "Other"
    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
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
            ssinformation.Label1.Text = "Hub ESR Locking System is now enabled. To disable, go to 'Settings Panel > Hub'."
        End If
    End Sub

    Private Sub RMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMLButton.Click
        My.Settings.ALS = 0
        ssoobehub.Show()
        Me.Close()
    End Sub
#End Region
End Class