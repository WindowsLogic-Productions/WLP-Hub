<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sssysinfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sssysinfo))
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RegisteredTextBox = New System.Windows.Forms.TextBox()
        Me.BitTextBox = New System.Windows.Forms.TextBox()
        Me.OperatingSystemTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtProcessorFamily = New System.Windows.Forms.TextBox()
        Me.txtProcessorExtClock = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProcessorClockSpeed = New System.Windows.Forms.TextBox()
        Me.txtProcessorDataWidth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProcessorL2CacheSize = New System.Windows.Forms.TextBox()
        Me.txtProcessorManufacturer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProcessorDescription = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProcessorID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProcessorName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtBoardSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBoardDescription = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBoardManufacturer = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBoardName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RefreshButton
        '
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RefreshButton.Location = New System.Drawing.Point(301, 346)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 8
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(364, 281)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.RegisteredTextBox)
        Me.TabPage1.Controls.Add(Me.BitTextBox)
        Me.TabPage1.Controls.Add(Me.OperatingSystemTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(356, 255)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Registered to:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "32-Bit or 64-Bit:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Operating System:"
        '
        'RegisteredTextBox
        '
        Me.RegisteredTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RegisteredTextBox.Location = New System.Drawing.Point(6, 101)
        Me.RegisteredTextBox.Name = "RegisteredTextBox"
        Me.RegisteredTextBox.ReadOnly = True
        Me.RegisteredTextBox.Size = New System.Drawing.Size(344, 22)
        Me.RegisteredTextBox.TabIndex = 48
        Me.RegisteredTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BitTextBox
        '
        Me.BitTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BitTextBox.Location = New System.Drawing.Point(6, 60)
        Me.BitTextBox.Name = "BitTextBox"
        Me.BitTextBox.ReadOnly = True
        Me.BitTextBox.Size = New System.Drawing.Size(344, 22)
        Me.BitTextBox.TabIndex = 47
        Me.BitTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OperatingSystemTextBox
        '
        Me.OperatingSystemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OperatingSystemTextBox.Location = New System.Drawing.Point(6, 19)
        Me.OperatingSystemTextBox.Name = "OperatingSystemTextBox"
        Me.OperatingSystemTextBox.ReadOnly = True
        Me.OperatingSystemTextBox.Size = New System.Drawing.Size(344, 22)
        Me.OperatingSystemTextBox.TabIndex = 46
        Me.OperatingSystemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtProcessorFamily)
        Me.TabPage2.Controls.Add(Me.txtProcessorExtClock)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtProcessorClockSpeed)
        Me.TabPage2.Controls.Add(Me.txtProcessorDataWidth)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtProcessorL2CacheSize)
        Me.TabPage2.Controls.Add(Me.txtProcessorManufacturer)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtProcessorDescription)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtProcessorID)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtProcessorName)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(356, 255)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Processor"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtProcessorFamily
        '
        Me.txtProcessorFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorFamily.Location = New System.Drawing.Point(181, 225)
        Me.txtProcessorFamily.Name = "txtProcessorFamily"
        Me.txtProcessorFamily.ReadOnly = True
        Me.txtProcessorFamily.Size = New System.Drawing.Size(165, 22)
        Me.txtProcessorFamily.TabIndex = 55
        Me.txtProcessorFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessorExtClock
        '
        Me.txtProcessorExtClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorExtClock.Location = New System.Drawing.Point(10, 225)
        Me.txtProcessorExtClock.Name = "txtProcessorExtClock"
        Me.txtProcessorExtClock.ReadOnly = True
        Me.txtProcessorExtClock.Size = New System.Drawing.Size(165, 22)
        Me.txtProcessorExtClock.TabIndex = 54
        Me.txtProcessorExtClock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(178, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Family:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Ext Clock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Data Width:"
        '
        'txtProcessorClockSpeed
        '
        Me.txtProcessorClockSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorClockSpeed.Location = New System.Drawing.Point(10, 184)
        Me.txtProcessorClockSpeed.Name = "txtProcessorClockSpeed"
        Me.txtProcessorClockSpeed.ReadOnly = True
        Me.txtProcessorClockSpeed.Size = New System.Drawing.Size(165, 22)
        Me.txtProcessorClockSpeed.TabIndex = 50
        Me.txtProcessorClockSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessorDataWidth
        '
        Me.txtProcessorDataWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorDataWidth.Location = New System.Drawing.Point(181, 184)
        Me.txtProcessorDataWidth.Name = "txtProcessorDataWidth"
        Me.txtProcessorDataWidth.ReadOnly = True
        Me.txtProcessorDataWidth.Size = New System.Drawing.Size(165, 22)
        Me.txtProcessorDataWidth.TabIndex = 49
        Me.txtProcessorDataWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Clock Speed:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Level 2 Cache Size:"
        '
        'txtProcessorL2CacheSize
        '
        Me.txtProcessorL2CacheSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorL2CacheSize.Location = New System.Drawing.Point(10, 143)
        Me.txtProcessorL2CacheSize.Name = "txtProcessorL2CacheSize"
        Me.txtProcessorL2CacheSize.ReadOnly = True
        Me.txtProcessorL2CacheSize.Size = New System.Drawing.Size(336, 22)
        Me.txtProcessorL2CacheSize.TabIndex = 46
        Me.txtProcessorL2CacheSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProcessorManufacturer
        '
        Me.txtProcessorManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorManufacturer.Location = New System.Drawing.Point(10, 19)
        Me.txtProcessorManufacturer.Name = "txtProcessorManufacturer"
        Me.txtProcessorManufacturer.ReadOnly = True
        Me.txtProcessorManufacturer.Size = New System.Drawing.Size(165, 22)
        Me.txtProcessorManufacturer.TabIndex = 45
        Me.txtProcessorManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Manufacturer:"
        '
        'txtProcessorDescription
        '
        Me.txtProcessorDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorDescription.Location = New System.Drawing.Point(9, 101)
        Me.txtProcessorDescription.Name = "txtProcessorDescription"
        Me.txtProcessorDescription.ReadOnly = True
        Me.txtProcessorDescription.Size = New System.Drawing.Size(337, 22)
        Me.txtProcessorDescription.TabIndex = 43
        Me.txtProcessorDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Description:"
        '
        'txtProcessorID
        '
        Me.txtProcessorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorID.Location = New System.Drawing.Point(9, 60)
        Me.txtProcessorID.Name = "txtProcessorID"
        Me.txtProcessorID.ReadOnly = True
        Me.txtProcessorID.Size = New System.Drawing.Size(337, 22)
        Me.txtProcessorID.TabIndex = 41
        Me.txtProcessorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Processor ID:"
        '
        'txtProcessorName
        '
        Me.txtProcessorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessorName.Location = New System.Drawing.Point(181, 19)
        Me.txtProcessorName.Name = "txtProcessorName"
        Me.txtProcessorName.ReadOnly = True
        Me.txtProcessorName.Size = New System.Drawing.Size(165, 22)
        Me.txtProcessorName.TabIndex = 39
        Me.txtProcessorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(178, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Processor Name:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtBoardSerialNumber)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.txtBoardDescription)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.txtBoardManufacturer)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.txtBoardName)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(356, 255)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Motherboard"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtBoardSerialNumber
        '
        Me.txtBoardSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoardSerialNumber.Location = New System.Drawing.Point(9, 190)
        Me.txtBoardSerialNumber.Name = "txtBoardSerialNumber"
        Me.txtBoardSerialNumber.ReadOnly = True
        Me.txtBoardSerialNumber.Size = New System.Drawing.Size(337, 22)
        Me.txtBoardSerialNumber.TabIndex = 31
        Me.txtBoardSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Serial Number:"
        '
        'txtBoardDescription
        '
        Me.txtBoardDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoardDescription.Location = New System.Drawing.Point(9, 134)
        Me.txtBoardDescription.Name = "txtBoardDescription"
        Me.txtBoardDescription.ReadOnly = True
        Me.txtBoardDescription.Size = New System.Drawing.Size(337, 22)
        Me.txtBoardDescription.TabIndex = 29
        Me.txtBoardDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Description:"
        '
        'txtBoardManufacturer
        '
        Me.txtBoardManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoardManufacturer.Location = New System.Drawing.Point(9, 78)
        Me.txtBoardManufacturer.Name = "txtBoardManufacturer"
        Me.txtBoardManufacturer.ReadOnly = True
        Me.txtBoardManufacturer.Size = New System.Drawing.Size(337, 22)
        Me.txtBoardManufacturer.TabIndex = 27
        Me.txtBoardManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Manufacturer:"
        '
        'txtBoardName
        '
        Me.txtBoardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoardName.Location = New System.Drawing.Point(9, 22)
        Me.txtBoardName.Name = "txtBoardName"
        Me.txtBoardName.ReadOnly = True
        Me.txtBoardName.Size = New System.Drawing.Size(337, 22)
        Me.txtBoardName.TabIndex = 25
        Me.txtBoardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Motherboard Name:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 53)
        Me.Panel1.TabIndex = 10
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(339, 30)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Information about your computer..."
        '
        'sssysinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(388, 377)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.RefreshButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sssysinfo"
        Me.Text = "System Information"
        Me.TopMost = True
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RefreshButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtProcessorFamily As TextBox
    Friend WithEvents txtProcessorExtClock As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProcessorClockSpeed As TextBox
    Friend WithEvents txtProcessorDataWidth As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProcessorL2CacheSize As TextBox
    Friend WithEvents txtProcessorManufacturer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProcessorDescription As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtProcessorID As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProcessorName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RegisteredTextBox As TextBox
    Friend WithEvents BitTextBox As TextBox
    Friend WithEvents OperatingSystemTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBoardSerialNumber As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBoardDescription As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBoardManufacturer As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBoardName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
