Public Class ssload
#Region "Load Application"
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            If My.Settings.OOBE = 0 Then
                ssoobeload.Show()
                Me.Close()
            End If
            If My.Settings.OOBE = 1 Then
                sswelcome.Show()
                ssmain.Show()
                Me.Close()
            End If
        End If
    End Sub
#End Region
#Region "Load Settings"
    Private Sub ssload_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CheckForUpdates()

        'Fix compatibility issues.
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", "Hub ESR.exe", "11001", Microsoft.Win32.RegistryValueKind.DWord)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", "Hub ESR.vshost.exe", "11001", Microsoft.Win32.RegistryValueKind.DWord)
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BEHAVIORS", "Hub ESR.exe", "1", Microsoft.Win32.RegistryValueKind.DWord)

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Updates"
    Public Sub CheckForUpdates()

        If My.Settings.Updates = 2 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(Variables.vertext)
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Timer1.Start()
                    PictureBox2.Visible = True
                Else
                    ssupdateprompt.Show()
                    Timer1.Start()
                    PictureBox2.Visible = True
                End If
            Catch
                sserror.Show()
                sserror.Text = "Fatal Error (Sammie Suite Exception)"
                sserror.Label1.Text = "No connnection to update server. (Error code: 0000x006)"
                Timer1.Start()
                PictureBox2.Visible = True
            End Try
        End If

        If My.Settings.Updates = 1 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(Variables.vertext)
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                    Timer1.Start()
                    PictureBox2.Visible = True
                Else
                    ssupdateprompt.Show()
                    Timer1.Start()
                    PictureBox2.Visible = True
                    'MsgBox("There is an update available, would you like to download it?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                End If
            Catch
                sserror.Show()
                sserror.Text = "Fatal Error (Sammie Suite Exception)"
                sserror.Label1.Text = "No connnection to update server. (Error code: 0000x006)"
                Timer1.Start()
                PictureBox2.Visible = True
            End Try
        End If

        If My.Settings.Updates = 0 Then
            Timer1.Start()
            PictureBox2.Visible = True
        End If
    End Sub
#End Region
End Class