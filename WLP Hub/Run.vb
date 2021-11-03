Public Class Run

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComSearch.ShowDialog()
    End Sub

    Private Sub Run_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MsgBox("This program is not working right now, please just use this feature to see what's to come.", MsgBoxStyle.Exclamation, "BEWARE!")
    End Sub
End Class