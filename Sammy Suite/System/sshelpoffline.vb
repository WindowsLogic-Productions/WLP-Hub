Public Class sshelpoffline
#Region "Load Settings"
    Private Sub sshelpoffline_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForUpdates()

        sstasklist.HelpCentreButton.Show()

        sserror.Show()
        sserror.Label1.Text = "Work in progress..."

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
#End Region
#Region "Updates"
    Public Sub CheckForUpdates()

        If My.Settings.Updates = 1 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://dl.dropboxusercontent.com/u/93134108/Update%20Repo/SS/SS.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then
                Else
                    ssupdateprompt.Show()
                End If
            Catch
                sserror.Show()
                sserror.Label1.Text = "No connection to the update server."
            End Try
        End If

        If My.Settings.Updates = 0 Then

        End If
    End Sub
#End Region
End Class