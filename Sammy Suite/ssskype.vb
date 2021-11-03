Public Class ssskype

    Private Sub ssskype_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        sssc.Button13.Show()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sscalc.Button13.Hide()
    End Sub
End Class