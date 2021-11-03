Public Class ssscload

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            sssc.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ssscload_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub

    Private Sub ssscload_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Parent = PictureBox2
        Label1.Parent = PictureBox2
        Timer1.Start()
        Me.TopMost = True

        If My.Settings.HubSounds = 0 Then
            sssc.RadioButton1.Checked = True
        End If

        If My.Settings.HubSounds = 1 Then
            sssc.RadioButton2.Checked = True
        End If

        If My.Settings.Fullscreen = 0 Then
            sssc.CheckBox3.Checked = False
            ssmain.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            ssmain.WindowState = FormWindowState.Maximized
        End If

        If My.Settings.Fullscreen = 1 Then
            sssc.CheckBox3.Checked = True
        End If

        If My.Settings.PersonaliseColour = 0 Then
            Me.BackColor = Color.DodgerBlue
            ssmain.BackColor = Color.DodgerBlue
            ssmain.Panel1.BackColor = Color.DodgerBlue
            ssmain.MenuStrip1.BackColor = Color.DodgerBlue
            sssc.BackColor = Color.DodgerBlue
            sschat.Panel1.BackColor = Color.DodgerBlue
            sschat.Panel2.BackColor = Color.DodgerBlue
            sschat.Panel4.BackColor = Color.DodgerBlue
            sschat.Panel5.BackColor = Color.DodgerBlue
            sschat.Panel6.BackColor = Color.DodgerBlue
            sschat.Panel7.BackColor = Color.DodgerBlue
            sschat.Panel8.BackColor = Color.DodgerBlue
            ssabout.BackColor = Color.DodgerBlue
            ssrun.BackColor = Color.DodgerBlue
            sshelpoffline.BackColor = Color.DodgerBlue
            sshelponline.BackColor = Color.DodgerBlue
            sserror.BackColor = Color.DodgerBlue
            sserror1.BackColor = Color.DodgerBlue
            ssexityesno.BackColor = Color.DodgerBlue
            ssexit.BackColor = Color.DodgerBlue
            sssc.RadioButton6.Checked = True
        End If

        If My.Settings.PersonaliseColour = 1 Then
            Me.BackColor = Color.Maroon
            ssmain.BackColor = Color.Maroon
            ssmain.Panel1.BackColor = Color.Maroon
            ssmain.MenuStrip1.BackColor = Color.Maroon
            sssc.BackColor = Color.Maroon
            sschat.Panel1.BackColor = Color.Maroon
            sschat.Panel2.BackColor = Color.Maroon
            sschat.Panel4.BackColor = Color.Maroon
            sschat.Panel5.BackColor = Color.Maroon
            sschat.Panel6.BackColor = Color.Maroon
            sschat.Panel7.BackColor = Color.Maroon
            sschat.Panel8.BackColor = Color.Maroon
            ssabout.BackColor = Color.Maroon
            ssrun.BackColor = Color.Maroon
            sshelpoffline.BackColor = Color.Maroon
            sshelponline.BackColor = Color.Maroon
            sserror.BackColor = Color.Maroon
            sserror1.BackColor = Color.Maroon
            ssexityesno.BackColor = Color.Maroon
            ssexit.BackColor = Color.Maroon
            sssc.RadioButton7.Checked = True
        End If

        If My.Settings.PersonaliseColour = 2 Then
            Me.BackColor = Color.Navy
            ssmain.BackColor = Color.Navy
            ssmain.Panel1.BackColor = Color.Navy
            ssmain.MenuStrip1.BackColor = Color.Navy
            sssc.BackColor = Color.Navy
            sschat.Panel1.BackColor = Color.Navy
            sschat.Panel2.BackColor = Color.Navy
            sschat.Panel4.BackColor = Color.Navy
            sschat.Panel5.BackColor = Color.Navy
            sschat.Panel6.BackColor = Color.Navy
            sschat.Panel7.BackColor = Color.Navy
            sschat.Panel8.BackColor = Color.Navy
            ssabout.BackColor = Color.Navy
            ssrun.BackColor = Color.Navy
            sshelpoffline.BackColor = Color.Navy
            sshelponline.BackColor = Color.Navy
            sserror.BackColor = Color.Navy
            sserror1.BackColor = Color.Navy
            ssexityesno.BackColor = Color.Navy
            ssexit.BackColor = Color.Navy
            sssc.RadioButton8.Checked = True
        End If

        If My.Settings.PersonaliseColour = 3 Then
            Me.BackColor = Color.DarkGreen
            ssmain.BackColor = Color.DarkGreen
            ssmain.Panel1.BackColor = Color.DarkGreen
            ssmain.MenuStrip1.BackColor = Color.DarkGreen
            sssc.BackColor = Color.DarkGreen
            sschat.Panel1.BackColor = Color.DarkGreen
            sschat.Panel2.BackColor = Color.DarkGreen
            sschat.Panel4.BackColor = Color.DarkGreen
            sschat.Panel5.BackColor = Color.DarkGreen
            sschat.Panel6.BackColor = Color.DarkGreen
            sschat.Panel7.BackColor = Color.DarkGreen
            sschat.Panel8.BackColor = Color.DarkGreen
            ssabout.BackColor = Color.DarkGreen
            ssrun.BackColor = Color.DarkGreen
            sshelpoffline.BackColor = Color.DarkGreen
            sshelponline.BackColor = Color.DarkGreen
            sserror.BackColor = Color.DarkGreen
            sserror1.BackColor = Color.DarkGreen
            ssexityesno.BackColor = Color.DarkGreen
            ssexit.BackColor = Color.DarkGreen
            sssc.RadioButton9.Checked = True
        End If

        If My.Settings.PersonaliseColour = 4 Then
            Me.BackColor = Color.DarkOrange
            ssmain.BackColor = Color.DarkOrange
            ssmain.Panel1.BackColor = Color.DarkOrange
            ssmain.MenuStrip1.BackColor = Color.DarkOrange
            sssc.BackColor = Color.DarkOrange
            sschat.Panel1.BackColor = Color.DarkOrange
            sschat.Panel2.BackColor = Color.DarkOrange
            sschat.Panel4.BackColor = Color.DarkOrange
            sschat.Panel5.BackColor = Color.DarkOrange
            sschat.Panel6.BackColor = Color.DarkOrange
            sschat.Panel7.BackColor = Color.DarkOrange
            sschat.Panel8.BackColor = Color.DarkOrange
            ssabout.BackColor = Color.DarkOrange
            ssrun.BackColor = Color.DarkOrange
            sshelpoffline.BackColor = Color.DarkOrange
            sshelponline.BackColor = Color.DarkOrange
            sserror.BackColor = Color.DarkOrange
            sserror1.BackColor = Color.DarkOrange
            ssexityesno.BackColor = Color.DarkOrange
            ssexit.BackColor = Color.DarkOrange
            sssc.RadioButton10.Checked = True
        End If

        If My.Settings.PersonaliseColour = 5 Then
            Me.BackColor = Color.Purple
            ssmain.BackColor = Color.Purple
            ssmain.Panel1.BackColor = Color.Purple
            ssmain.MenuStrip1.BackColor = Color.Purple
            sssc.BackColor = Color.Purple
            sschat.Panel1.BackColor = Color.Purple
            sschat.Panel2.BackColor = Color.Purple
            sschat.Panel4.BackColor = Color.Purple
            sschat.Panel5.BackColor = Color.Purple
            sschat.Panel6.BackColor = Color.Purple
            sschat.Panel7.BackColor = Color.Purple
            sschat.Panel8.BackColor = Color.Purple
            ssabout.BackColor = Color.Purple
            ssrun.BackColor = Color.Purple
            sshelpoffline.BackColor = Color.Purple
            sshelponline.BackColor = Color.Purple
            sserror.BackColor = Color.Purple
            sserror1.BackColor = Color.Purple
            ssexityesno.BackColor = Color.Purple
            ssexit.BackColor = Color.Purple
            sssc.RadioButton11.Checked = True
        End If

        If My.Settings.PersonaliseColour = 6 Then
            Me.BackColor = Color.DeepPink
            sshub.BackColor = Color.DeepPink
            ssmain.BackColor = Color.DeepPink
            ssmain.Panel1.BackColor = Color.DeepPink
            ssmain.MenuStrip1.BackColor = Color.DeepPink
            sssc.BackColor = Color.DeepPink
            sschat.Panel1.BackColor = Color.DeepPink
            sschat.Panel2.BackColor = Color.DeepPink
            sschat.Panel4.BackColor = Color.DeepPink
            sschat.Panel5.BackColor = Color.DeepPink
            sschat.Panel6.BackColor = Color.DeepPink
            sschat.Panel7.BackColor = Color.DeepPink
            sschat.Panel8.BackColor = Color.DeepPink
            ssabout.BackColor = Color.DeepPink
            ssrun.BackColor = Color.DeepPink
            sshelpoffline.BackColor = Color.DeepPink
            sshelponline.BackColor = Color.DeepPink
            sserror.BackColor = Color.DeepPink
            sserror1.BackColor = Color.DeepPink
            ssexityesno.BackColor = Color.DeepPink
            ssexit.BackColor = Color.DeepPink
            sssc.RadioButton12.Checked = True
        End If

        If My.Settings.PersonaliseColour = 8 Then
            Me.BackColor = Color.Indigo
            sshub.BackColor = Color.Indigo
            ssmain.BackColor = Color.Indigo
            ssmain.Panel1.BackColor = Color.Indigo
            ssmain.MenuStrip1.BackColor = Color.Indigo
            sssc.BackColor = Color.Indigo
            sschat.Panel1.BackColor = Color.Indigo
            sschat.Panel2.BackColor = Color.Indigo
            sschat.Panel4.BackColor = Color.Indigo
            sschat.Panel5.BackColor = Color.Indigo
            sschat.Panel6.BackColor = Color.Indigo
            sschat.Panel7.BackColor = Color.Indigo
            sschat.Panel8.BackColor = Color.Indigo
            ssabout.BackColor = Color.Indigo
            ssrun.BackColor = Color.Indigo
            sshelpoffline.BackColor = Color.Indigo
            sshelponline.BackColor = Color.Indigo
            sserror.BackColor = Color.Indigo
            sserror1.BackColor = Color.Indigo
            ssexityesno.BackColor = Color.Indigo
            ssexit.BackColor = Color.Indigo
            sssc.RadioButton16.Checked = True
        End If

        If My.Settings.PersonaliseColour = 15 Then
            Me.BackColor = Color.AliceBlue
            Me.Label1.ForeColor = Color.Black
            Me.ProgressBar1.Show()
            sshub.BackColor = Color.AliceBlue
            ssmain.BackColor = Color.AliceBlue
            ssmain.Panel1.BackColor = Color.AliceBlue
            ssmain.MenuStrip1.BackColor = Color.AliceBlue
            ssmain.Button1.ForeColor = Color.Black
            ssmain.Button2.ForeColor = Color.Black
            ssmain.Button3.ForeColor = Color.Black
            ssmain.Button4.ForeColor = Color.Black
            ssmain.Button5.ForeColor = Color.Black
            sssc.BackColor = Color.AliceBlue
            sschat.Panel1.BackColor = Color.AliceBlue
            sschat.Panel2.BackColor = Color.AliceBlue
            sschat.Panel4.BackColor = Color.AliceBlue
            sschat.Panel5.BackColor = Color.AliceBlue
            sschat.Panel6.BackColor = Color.AliceBlue
            sschat.Panel7.BackColor = Color.AliceBlue
            sschat.Panel8.BackColor = Color.AliceBlue
            ssabout.BackColor = Color.AliceBlue
            ssrun.BackColor = Color.AliceBlue
            sshelpoffline.BackColor = Color.AliceBlue
            sshelponline.BackColor = Color.AliceBlue
            sserror.BackColor = Color.AliceBlue
            sserror1.BackColor = Color.AliceBlue
            ssexityesno.BackColor = Color.AliceBlue
            ssexit.BackColor = Color.AliceBlue
            sssc.RadioButton18.Checked = True
        End If

    End Sub
End Class