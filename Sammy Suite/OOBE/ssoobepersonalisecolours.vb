Public Class ssoobepersonalisationcolours
#Region "Load Settings"
    Private Sub ssoobehub_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        'Load custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            CCEBox.Checked = True
        End If

        'Load parent settings.
        Label2.Parent = WLSOOBEBackground
        Label4.Parent = WLSOOBEBackground
        RMLButton.Parent = WLSOOBEBackground
        ForwardButton.Parent = WLSOOBEBackground
        CustomColourLabel.Parent = WLSOOBEBackground
        CustomColourButton.Parent = WLSOOBEBackground
    End Sub
#End Region
#Region "Settings"
    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CCEBox.CheckedChanged
        If CCEBox.Checked = True Then
            CustomColourButton.Enabled = True
            My.Settings.CCE = 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomColourButton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.CustomColour = ColorDialog1.Color
            Me.BackColor = My.Settings.CustomColour
            ssmain.ContextBar.BackColor = My.Settings.CustomColour
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Other"
    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        My.Settings.Save()
        ssoobepersonalisationsounds.Show()
        Me.Close()
    End Sub

    Private Sub RMLButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RMLButton.Click
        ssoobepersonalisationsounds.Show()
        Me.Close()
    End Sub
#End Region
End Class