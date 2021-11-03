Imports System.IO

Public Class sssysinfo
#Region "Load Settings"


    Private Sub sssysinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load system information.
        RegisteredTextBox.Text = System.Environment.UserName
        OperatingSystemTextBox.Text = System.Environment.OSVersion.ToString
        If System.Environment.Is64BitOperatingSystem.ToString = "False" Then
            BitTextBox.Text = "32-Bit"
        End If

        If System.Environment.Is64BitOperatingSystem.ToString = "True" Then
            BitTextBox.Text = "64-Bit"
        End If

        Try
            Dim i As System.Management.ManagementObject
            Dim searchInfo_Processor As New System.Management.ManagementObjectSearcher("Select * from Win32_Processor")
            For Each i In searchInfo_Processor.Get()
                txtProcessorName.Text = i("Name").ToString
                txtProcessorID.Text = i("ProcessorID").ToString
                txtProcessorDescription.Text = i("Description").ToString
                txtProcessorManufacturer.Text = i("Manufacturer").ToString
                txtProcessorL2CacheSize.Text = i("L2CacheSize").ToString
                txtProcessorClockSpeed.Text = i("CurrentClockSpeed").ToString & " Mhz"
                txtProcessorDataWidth.Text = i("DataWidth").ToString
                txtProcessorExtClock.Text = i("ExtClock").ToString & " Mhz"
                txtProcessorFamily.Text = i("Family").ToString
            Next
            Dim searchInfo_Board As New System.Management.ManagementObjectSearcher("Select * from Win32_BaseBoard")
            For Each i In searchInfo_Board.Get()
                txtBoardDescription.Text = i("Description").ToString
                txtBoardManufacturer.Text = i("Manufacturer").ToString
                txtBoardName.Text = i("Name").ToString
                txtBoardSerialNumber.Text = i("SerialNumber").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try

    End Sub
#End Region
#Region "System Information Refresh"
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        RegisteredTextBox.Text = System.Environment.UserName
        OperatingSystemTextBox.Text = System.Environment.OSVersion.ToString
        If System.Environment.Is64BitOperatingSystem.ToString = "False" Then
            BitTextBox.Text = "32-Bit"
        End If
        If System.Environment.Is64BitOperatingSystem.ToString = "True" Then
            BitTextBox.Text = "64-Bit"
        End If

        Try
            Dim i As System.Management.ManagementObject
            Dim searchInfo_Processor As New System.Management.ManagementObjectSearcher("Select * from Win32_Processor")
            For Each i In searchInfo_Processor.Get()
                txtProcessorName.Text = i("Name").ToString
                txtProcessorID.Text = i("ProcessorID").ToString
                txtProcessorDescription.Text = i("Description").ToString
                txtProcessorManufacturer.Text = i("Manufacturer").ToString
                txtProcessorL2CacheSize.Text = i("L2CacheSize").ToString
                txtProcessorClockSpeed.Text = i("CurrentClockSpeed").ToString & " Mhz"
                txtProcessorDataWidth.Text = i("DataWidth").ToString
                txtProcessorExtClock.Text = i("ExtClock").ToString & " Mhz"
                txtProcessorFamily.Text = i("Family").ToString
            Next
            Dim searchInfo_Board As New System.Management.ManagementObjectSearcher("Select * from Win32_BaseBoard")
            For Each i In searchInfo_Board.Get()
                txtBoardDescription.Text = i("Description").ToString
                txtBoardManufacturer.Text = i("Manufacturer").ToString
                txtBoardName.Text = i("Name").ToString
                txtBoardSerialNumber.Text = i("SerialNumber").ToString
            Next
        Catch ex As Exception
            sserror.Show()
            sserror.Label1.Text = "Unable to collect system information."
            End
        End Try
    End Sub
#End Region
End Class