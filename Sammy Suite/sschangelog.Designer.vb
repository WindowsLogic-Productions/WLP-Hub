<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sschangelog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sschangelog))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 67)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WLP Hub Update Log"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"~.Version 6.0.0.0.~ (The personalisation patch)", "1. General fixes.", "2. Added user account creation.", "3. Updated UI.", "4. Added colour personalisation.", "5. Added more apps.", "6. ", "", "~.Version 5.4.2.0.~ (5.4's Service Pack 2 Update)", "1. Added online and offline help topics in the 'Help Centre'.", "2. Fixed a bug that opened WLP Hub when pressing the close button in the updater." & _
                "", "3. Added WLP Hub app switcher.", "4. Added 'Windows Explorer' button on the 'System' tab in 'System Controls'.", "5. Added 'Windows Desktop' button on the 'Hub' so you can go back to the desktop " & _
                "in full screen.", "6. General fixes.", "", "~.Version 5.4.1.0.~ (5.4's Service Pack 1 Update)", "1. Changed the name of 'Media Player' to 'Music Player'.", "2. Fixed a bug that didn't show the pause icon on the 'Music Player'.", "3. Fixed a bug that turned the 'Music Player' blue after 5 minutes of being used." & _
                "", "4. Changed names of sound sheme options to 'Default' and 'Modern'.", "5. Added option that allows the changing of full screen and windowed mode.", "6. Fixed 'Run at startup' option.", "7. Replaced 'Help' with 'Help Centre'.", "", "~.Version 5.4.0.0.~ (The Windows 10 patch)", "1. Bug fixes", "2. Added the ability to change sound scheme.", "3. Added even more tooltips.", "4. Added the ability to select if updates are installed or not.", "5. Added 'Run at startup' option.", "6. Deleted LogicBox intergration due to server costs.", "7. New icon set.", "8. Redesigned a few screens ready for version 6.0.0.0.", "9. WLP Hub is now full screen by default, you can temporarily change this in 'Sys" & _
                "tem Controls'.", "10. WLP Hub now uses Fusion 2.0.", "11. Built-in apps now have their own accent colour.", "", "~.Version 5.3.0.0.~", "1. Changed the progress indicator for 'Loading' and 'Safe Exit'.", "2. Added temporary integration for WindowsLogic Productions LogicBox.", "3. Added tooltips. (Little boxes that appear explaining what something does.)", "4. Skype now opens in a separate window, much like the chatroom.", "5. Redesigned 'Processes' tab and renamed it 'System'.", "6. General fixes.", "", "~.Version 5.2.0.0.~", "1. Renamed 'Applications' on the 'WLP Hub' menu to 'Apps'", "2. Recoloured the menu on 'Calculator'.", "3. Added a sound to 'System Controls' when restarting.", "4. Changed WLP Hub sounds. (You will be able to revert to the old sounds in versi" & _
                "on 5.4.0.0.)", "5. Prepared the 'Personalise' tab in 'System Controls' for use in version 6.0.0.0" & _
                ".", "6. Prepared the 'Updates' tab in System Controls' for use in version 6.0.0.0.", "7. Changed the updater dialogues so they fit the user interface.", "8. Added a percentage counter to the loading screen.", "9. Added 'Safe Exit', this safely exits WLP Hub.", "10. Made minor changes to the way the chatroom works.", "11. Fixed a bug that caused the back and forward buttons for browsing social medi" & _
                "a to get stuck.", "12. The main WLP Hub window is now maximised by default.", "", "~.Version 5.1.0.0.~", "1. Removed the Address Book since it was not saving people's addresses correctly." & _
                "", "2. Added the names for several new apps coming in version 6.0.0.0.", "3. Added error message for features that are not yet implemented.", "4. Renamed the 'Monitor' tab on 'System Controls' to 'Processes'.", "5. Added a new 'Updates' tab to 'System Controls' for version 6.0.0.0.", "6. Added the WLP logo to the loading screen.", "", "~.Version 5.0.2.0.~", "1. Removed CPU and RAM usage from System Controls since it was throwing too many " & _
                "exceptions.", "2. Removed maximise option from Image Viewer.", "", "~.Version 5.0.0.0.~", "1. Updated entire user interface with a nice cool blue colour.", "2. Removed mostly every asset from WLP Hub 4.0.0.0.", "3. Updated icons to provide a cleaner, flatter feel.", "4. New social buttons let you browse your social media in a flash.", "5. New built-in applications let you get work done better than ever before.", "6. Redesigned System Controls that lets you get to what you need faster.", "7. New chatroom that lets you chat to other users of WLP Hub. "})
        Me.ListBox1.Location = New System.Drawing.Point(0, 66)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(531, 301)
        Me.ListBox1.TabIndex = 1
        '
        'sschangelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(531, 367)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sschangelog"
        Me.Text = "WLP Hub - Update Log"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
