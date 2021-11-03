Public Class ssoobeload
#Region "Timer Settings"
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ssoobeloaded.Show()
            Me.Close()
        End If
    End Sub
#End Region
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
        Loader.Parent = OOBELoadBackground
        Label1.Parent = OOBELoadBackground
        Timer1.Start()
    End Sub
#End Region
End Class