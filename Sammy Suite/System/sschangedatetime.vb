Imports System.Runtime.InteropServices

Public Class sschangedatetime

    Private Sub ssdateandtime_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Structure SYSTEMTIME

        Public year As Short

        Public month As Short

        Public dayOfWeek As Short

        Public day As Short

        Public hour As Short

        Public minute As Short

        Public second As Short

        Public milliseconds As Short

    End Structure

    <DllImport("Kernel32.dll")> Private Shared Function SetLocalTime(ByRef time As SYSTEMTIME) As Boolean

    End Function

    Private Sub ChangeDate()
        Try
            Dim st As SYSTEMTIME
            Dim NewDate As Date = DateText.Text & " " & TimeText.Text '28-April-1978 22:30:00
            st.year = NewDate.Year
            st.month = NewDate.Month
            st.dayOfWeek = NewDate.DayOfWeek
            st.day = NewDate.Day
            st.hour = NewDate.Hour
            st.minute = NewDate.Minute
            st.second = NewDate.Second
            st.milliseconds = NewDate.Millisecond

            'Set the new time...
            SetLocalTime(st)
        Catch
            sserror.Show()
            sserror.Text = "Fatal Error (Sammie Suite Exception)"
            sserror.Label1.Text = "Input invalid. Please try again. (Error code: 0000x008)"
        End Try
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        ChangeDate()
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class