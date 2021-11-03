Public Class sswhatsnew

    Private Sub sschangelog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            ListBox1.BackColor = My.Settings.CustomColour
        End If
    End Sub
End Class