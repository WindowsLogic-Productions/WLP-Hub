Public Class ssfeedback
#Region "Load Settings"
    Private Sub ssfeedback_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Variables.CheckForUpdates()

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
End Class