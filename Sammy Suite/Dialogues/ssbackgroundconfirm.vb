Public Class ssbackgroundconfirm

    Private Sub ssbackgroundconfirm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sssettingspanelpersonalise.Dispose()
        sssettingspanelpersonalise.Show()

        If My.Settings.DHBHUC = 0 Then
            sssettingspanelpersonalise.RB1Box.Checked = True
        End If

        If My.Settings.DWBWUC = 0 Then
            sssettingspanelpersonalise.RB2Box.Checked = True
        End If
    End Sub
End Class