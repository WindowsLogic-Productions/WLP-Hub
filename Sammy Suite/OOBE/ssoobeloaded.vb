Public Class ssoobeloaded
#Region "Load Settings"
    Private Sub ssoobeload_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load background settings.
        If My.Settings.DWBWUC = 0 Then
            OOBELoadBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DWBWUC = 1 Then
            OOBELoadBackground.Image = Nothing
        End If

        If My.Settings.DWBWUC = 2 Then
            OOBELoadBackground.Load(My.Settings.CB2)
        End If

        'Load parenting settings.
        VerInfo.Parent = OOBELoadBackground
        Label1.Parent = OOBELoadBackground
        ForwardButton.Parent = OOBELoadBackground

        'Load information.
        Variables.ParseVariables(VerInfo)
    End Sub
#End Region
#Region "Other"
    Private Sub ForwardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardButton.Click
        ssoobewls.Show()
        Me.Close()
    End Sub
#End Region
End Class