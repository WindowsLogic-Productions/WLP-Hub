Public Class ssprocesslistyesno

    Private Sub ssprocesslistyesno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'colour settings
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub YesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesButton.Click
        For Each Process As ListViewItem In ssprocesslist.ListView1.SelectedItems
            System.Diagnostics.Process.GetProcessById(Process.SubItems(4).Text).Kill()
        Next
        Me.Close()
        ssinformation.Show()
        ssinformation.Label1.Text = "The process has been killed."
    End Sub

    
    Private Sub NoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoButton.Click
        Me.Close()
    End Sub
End Class