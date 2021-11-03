Public Class sssearch

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ssmain.WebBrowser1.Show()
        ssmain.Button12.Show()
        ssmain.Button13.Show()
        ssmain.PictureBox3.Show()
        ssmain.WebBrowser1.Navigate("http://www.google.com/search?q=" & TextBox1.Text)
        Me.Close()
    End Sub
End Class