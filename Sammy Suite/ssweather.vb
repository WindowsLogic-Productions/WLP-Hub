Public Class ssweather

    Private Sub ssweather_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sssc.Button9.Show()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sssc.Button9.Hide()
    End Sub
End Class