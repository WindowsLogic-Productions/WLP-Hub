Public Class ssload

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ssloaded.Show()
            Me.Close()
        End If

        Label2.Text = "Loading..." & ProgressBar1.Value() & "%"
    End Sub

    Private Sub ssload_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckForUpdates()
    End Sub

    Public Sub CheckForUpdates()

        If My.Settings.Updates = 1 Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://u.windowslogic.co.uk/HUB/HUB.txt")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                ssupdaterok.Show()
            Else
                ssupdateryesno.Show()
                'MsgBox("There is an update available, would you like to download it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End If
        End If

        If My.Settings.Updates = 0 Then
            Timer1.Start()
            PictureBox2.Visible = True
        End If
    End Sub
End Class