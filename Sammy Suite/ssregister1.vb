Public Class ssregister1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Settings.Username = TextBox1.Text
        My.Settings.Password = TextBox2.Text
        My.Settings.Save()
        MsgBox("Account created successfully.", MsgBoxStyle.Information, "Create account")
        Button3.Hide()
        Button1.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        Label4.Show()
        PictureBox1.Show()
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        sssignin.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ssmain.Show()
            ssscload.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ssregister1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub ssregister1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.CA, AudioPlayMode.Background)
    End Sub
End Class