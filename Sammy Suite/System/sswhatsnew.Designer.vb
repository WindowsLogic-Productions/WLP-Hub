<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sswhatsnew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sswhatsnew))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 53)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ss.My.Resources.Resources.ssRun
        Me.PictureBox1.Location = New System.Drawing.Point(487, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "See what's changed in the application..."
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"~Version 9.3.0.10~ (Hub ESR 10 Beta 3)", "1. Updated about information and main icon.", "2. Changed default colour to black.", "3. Disabled 'Messages'.", "4. ", "", "~Version 9.2.0.10~ (Hub ESR 10 Beta 2)", "1. Removed 'Sample Music' option from 'Music Player'.", "2. Fixed a bug that stopped 'Search' from displaying properly.", "3. Updated .NET Framework to 4.5.2.", "4. Fixed a bug on Out Of Box Experience where some elements would appear in rando" &
                "m places.", "5. Updated 'Context Bar' applications.", "6. Bug fixes, performance improvements and clean up.", "", "~Version 9.1.0.10~ (Hub ESR 10 Beta 1)", "1. Updated 'CD Player' with bug fixes and new design.", "2. Added a right click menu on the desktop.", "3. Changed the sound when changing the volume of your system on 'Volume Control'." &
                "", "4. Added a sound when clicking on the darkened background that appears when showi" &
                "ng the", "'Log Off', 'System Power' and 'Quick Exit' dialogues.", "5. When opening 'Hub ESR Security', the entire desktop hides itself to only show " &
                "the background.", "6. Fixed a bug where opening windowed search still enables the search buttons for" &
                " the built-in", "browser.", "7. Fixed a bug on 'File Explorer' where all drive letters would be shown instead " &
                "of connected ones", "only.", "8. Fixed a bug on 'File Explorer' where the current directory would show ""/"" inst" &
                "ead of ""\"".", "9. 'Weather' now uses BBC Weather.", "10. Reverted icons back to the Windows 7 style since they look nicer.", "11. Redesigned the 'Welcome' dialogue.", "13. Updated assets to fit the new WindowsLogic Productions style.", "14. Fixed a bug on 'File Explorer' in which the file view would not resize with t" &
                "he window.", "15. Made a few changes to the Out Of Box Experience.", "", "~Version 8.1.0.1~ (Small Launch Update)", "1. Fixed a bug that would cause the welcome dialogue to appear even when minimisi" &
                "ng at startup.", "2. Fixed a bug on the Out Of Box Experience where after selecting a background, i" &
                "t would open", "the 'Settings Panel'.", "3. Fixed a bug on 'CD Player' where the menu colour would stay on default no matt" &
                "er what colour", "you chose.", "4. Fixed a bug where if you restarted the application, a darkened background woul" &
                "d appear,", "stopping you from using your computer.", "5. Fixed a bug where searching on the detached 'Context Bar' would not work.", "6. Added error handling into 'GIF Studio'.", "7. Added the ability to change the date and time of your system from the 'Date an" &
                "d Time' dialogue.", "", "~Version 8.1.0.0~ (The biggest and the best update ever)", "1. Updated 'CD Player'.", "2. Updated 'Mail'.", "3. Updated 'News'.", "4. Updated 'Music Player'.", "5. Updated 'Appointments'.", "6. Updated 'Calculator'.", "7. Added DuckDuckGo to search settings.", "8. Updated 'Back to Settings Panel.' buttons on 'Settings Panel' windows to a mor" &
                "e modern style.", "9. Added a confirmation dialogue to 'Process List' for ending processes.", "10. Added 'File Explorer'.", "11. Fixed a bug on 'Writer' where the 'Unsaved Changes' dialogue would appear", "when there were no changes made.", "12. Added Sound, Network and Power buttons to the 'Context Bar'.", "13. Centralised about dialogues for all applications into one.", "14. Added 'Volume Control'.", "15. Added 'Battery Status'.", "16. Changed the 'Settings' link on 'Date and Time' to a button.", "17. Changed 'Home' button on 'Hub ESR' to 'Hide Search'.", "18. Added the ability to access the Start menu from inside the Apollo environment" &
                ".", "Just go to; System > Applications > Start.", "19. A darkened background now appears when opening 'Quick Exit', 'Log Off' or 'Sy" &
                "stem Power'.", "20. Added 'Hub ESR Security'.", "21. Added confirmation dialogue for 'Quick Exit'.", "22. Redesigned 'Settings Panel'.", "23. Revised all icons.", "24. Added 'Context Bar', 'Search' and 'Firewall' to 'Settings Panel'.", "25. Added 'Task List' button to the 'Context Bar'.", "26. My Documents, My Pictures and My Music now opens in 'File Explorer'.", "27. Redesigned the 'System' menu and deleted 'Settings' and 'Help' menu.", "28. Added the ability to change the search engine and search style on the 'Contex" &
                "t Bar'.", "29. Added the ability to choose custom backgrounds.", "30. Removed default backgrounds.", "31. Fixed a bug on 'GIF Studio' where the user's colour wouldn't show on the menu" &
                ".", "32. 'Messages' now connects to the server.", "33. The 'About' dialogue is now used for all applications.", "34. Updated icons for social applications.", "35. Added ability to open the old customisation dialogues in Windows 10.", "36. Redesigned 'System Power' dialogue.", "37. 'System Information' now shows if your computer is 32 or 64 Bit.", "38. Changed 'Help Centre' button on 'Task List' to 'Help'.", "39. Disabled close button on 'Quick Exit', 'Log Off' and 'System Power'.", "40. Added the 'Hub ESR Locking System'.", "41. Updated the design of the social applications.", "42. Added Out Of Box Experience.", "43. Removed 'Control Panel' from 'Settings Panel > Personalisation'.", "44. Added 'Network Monitor'.", "", "~Version 8.0.1.1.~ (8.0s Service Pack 1 Small Launch Update)", "1. Bug fixes.", "2. Readded missing social icons.", "3. Fixed system tray menu.", "", "~Version 8.0.1.0.~ (8.0s Service Pack 1 Update)", "1. Added exception to all update procedures.", "2. Added more help sections for applications.", "3. Added more tooltips.", "4. Resized the detached 'Context Bar'.", "5. 'Alarm' can now only accept numbers 0 - 9 and "": A M P"" for setting a time.", "6. Removed games.", "7. 'Context Bar' can now be resized when detached.", "8. Added exception when trying to change 'Run at startup' when not running as an " &
                "administrator.", "9. Created new 'System Power' icon and replaced the old one.", "10. Created new Log Off icon and moved 'Log Off' to the 'System' menu.", "11. Redesigned 'CD Player'.", "12. Fixed a resizing issue on 'Writer'.", "13. Fixed a bug that made 'Send Feedback' not show the whole page.", "14. Redesigned 'Messages' and fixed bugs.", "15. Added 'Welcome'.", "16. Fixed a multitude of bugs present in 'Task List'.", "17. Redesigned 'News'.", "18. Updated a few icons.", "19. Added 'Quick Exit'.", "20. Cleaned up code and internal files.", "", "~Version 8.0.0.1.~ (Small Launch Update)", "1. Bug fixes.", "2. Removed 'Under Construction' dialogue.", "", "~Version 8.0.0.0.~ (Everything's Changing)", "1. Cleaned up code and general appearance.", "2. Added link to date and time control panel in 'Date and Time' dialogue.", "3. Fixed a multitude of bugs.", "4. Added 'New Process...' button to 'Process List'.", "5. Added 'Context Bar' button to 'Hub'.", "6. Revised 'GIF Studio' design.", "", "~Version 7.9.9.11.~ (Version 8.0.0.0 Beta 1.2)", "1. Added new backgrounds and finalised background set.", "2. Cleaned up code and general appearance.", "3. Fixed error on 'System Power' help where it would show an error page.", "4. Detached 'Context Bar' is now fully functional.", "5. Redesigned 'Maps'.", "6. Redesigned 'Memory'.", "7. Redesigned 'GIF Studio'.", "8. Added exception to the update system so the application doesn't throw a unhand" &
                "led error", "when there is no connection to the update server.", "9. Added 'Calculator' help topic.", "", "~Version 7.9.9.10.~ (Version 8.0.0.0 Beta 1.1)", "1. Fixed resizing on 'Calculator'.", "2. Added error to 'Music' when cancelling the creation of a playlist.", "3. Fixed numerous errors in the social applications.", "4. Fixed 'Task List' not showing some open applications or services.", "5. Fixed the layout of 'Sketchpad'.", "6. Fixed bug where the 'Updates' dialogue in the 'Settings Panel' could be resize" &
                "d.", "7. Fixed bug where switching the 'Hub' to immersive mode would break it.", "8. Redesigned 'Image Viewer'.", "9. Cleaned up code and general appearance.", "10. Added 'System Power' help topic.", "11. Added date under time on the 'Context Bar'.", "12. Added tooltips.", "", "~Version 7.9.9.9.~ (Version 8.0.0.0 Beta 1)", "1. Removed 'System Controls' and replaced it with the 'Context Bar'.", "2. Added 'Process List'.", "3. Added 'Task List'.", "4. Removed 'Help' menu from the top of the 'Hub'.", "5. Redesigned 'Music', added new playlist option and removed old open dialogue.", "6. Fixed issue that stopped the 'News' about screen from showing when clicking th" &
                "e link.", "7. Removed immersive style update prompt at start up and redesigned it.", "8. Removed immersive style exit prompt.", "9. Added gradient to security dialogues.", "10. Renamed 'Alarm and Clock' to 'Alarm'.", "11. Redesigned and rebuilt 'Messages' from the ground up.", "12. Added 'Settings Panel' and completely reworked the application's settings.", "13. Redesigned updater to match the update prompt.", "14. Added 'System Power' dialogue to choose power options gracefully.", "15. Edited the loading screen slightly.", "16. Redesigned the 'Hub'.", "17. Redesigned 'Writer' and added the ability to print and zoom.", "18. Redesigned 'Mail'.", "19. Added custom colours and deleted the old predefined colours.", "20. Fixed a bug where the modern sound scheme would play a sound on random dialog" &
                "ues.", "21. Added 'Social' to the system tray icon menu.", "22. Redesigned 'Calculator' and added new functions.", "23. Added option to detach the 'Context Bar'.", "24. Added option to minimise Hub ESR to system tray at startup.", "25. Social Media now opens in separate windows.", "", "~Version 7.0.2.0.~ (7.0s Service Pack 2 Update)", "1. Renamed 'Preferences Panel' to 'Settings Panel'.", "2. Fixed the 'Appointments' task button sticking in 'Application Switcher'.", "3. Altered sizing on 'What's New?' slightly.", "4. Updated 'Alarm and Clock' to version 2.0.", "5. Added 'Date and Time' dialogue to the 'Context Bar'.", "6. Fixed numerous bugs in the 'Appointments' application.", "", "~Version 7.0.1.0.~ (7.0s Service Pack 1 Update)", "1. Added the new 'Context Bar' at the bottom of the 'Hub'", "2. Removed 'Internet Search' and integrated it into the 'Context Bar'.", "3. Added 'Under Construction' dialogue.", "4. Fixed minor bugs.", "", "~Version 7.0.0.0.~ (Merry Christmas and a Happy New Year from WindowsLogic Produc" &
                "tions~)", "1. Upgraded to Microsoft .NET Framework 4.5.", "2. Fixed issues caused with upgrading .NET versions.", "3. Fixed resizing issue on 'System Controls'.", "4. Edited tooltips on 'System Controls'.", "5. Cleaned up dialogues, tied up loose ends and changed small bits around the use" &
                "r interface.", "6. Added update prompt.", "7. Updated accent colours.", "8. Fixed a problem which caused the application to crash when loading 'Help Centr" &
                "e'.", "9. Added 'Appointments'.", "10. Edited tooltips on the 'Hub'.", "11. Updated 'Internet Search' by adding new features and new built-in internet br" &
                "owser.", "12. Added 'Internet Search' to the system tray icon menu.", "", "~Version 6.9.1.0.~ (Version 7.0.0.0 Beta 3.1)", "1. Fixed a bug that was causing the 'News' application to throw an Exclamation di" &
                "alogue.", "2. Fixed a bug in 'GIF Studio' that was throwing an exception when extracting ima" &
                "ges.", "3. Removed 'Help Centre' music.", "4. Removed two songs from 'Music' as it was causing the entire application to cra" &
                "sh.", "5. Added back and forward buttons to the 'YouTube' social application.", "6. Fixed an issue that caused 'GIF Studio' to cut people's internet out when dele" &
                "ting frames.", "", "~.Version 6.9.0.0.~ (Version 7.0.0.0 Beta 3)", "1. Fixed colours not working on bottom bar of 'calculator'.", "2. Changed gold accent colour to grey.", "3. Built-in application updates.", "4. Added 'Maps', 'News' and 'GIF Studio'.", "5. Updated the News Feed on the main Hub ESR window.", "6. Fixed colours not working on menu bar of 'Mail'.", "7. Renamed 'App Switcher' in 'System Controls' to 'Application Switcher'.", "8. Fixed colours on 'LogicBox'.", "9. Fixed 'LogicBox' not showing on 'Application Switcher' in 'System Controls'.", "10. Hub ESR now uses the Fusion 3.0 design engine.", "11. Fixed multiple bugs across all of the built-in applications.", "12. Fixed colours on 'About LogicBox' dialogue.", "13. Added fade in and fade out effect to 'Internet Search'.", "14. Renamed 'Search' button to 'Internet Search'.", "15. Added 'Sample Music' to 'Music'.", "16. Changed 'Music' icon.", "17. Added error codes.", "18. Added error reporter.", "", "~.Version 6.8.0.0.~ (Version 7.0.0.0 Beta 2)", "1. Renamed 'Apps and Social' button to 'Applications and Social'.", "2. Renamed 'Apps' menu in 'Applications and Social' to 'Applications'.", "3. Added 'Applications' menu to the Hub ESR System Tray menu.", "4. Fixed colours not working in 'Music Player'.", "", "~.Version 6.7.8.8.~ (Version 7.0.0.0 Beta 1.1)", "1. Cleaned up code and deleted unused and unwanted code.", "2. Removed 'Custom Colour' setting from 'System Controls'.", "3. Added new backgrounds.", "4. Updated the 'Help Centre'.", "5. Added a mute button to the 'Sounds' option in 'System Controls'.", "6. Removed 'Appearance' from the 'Preferences Panel'.", "7. 'YouTube' now opens much like 'Skype', in its own window.", "8. Added 'Send Feedback' to the 'Help' menu.", "9. Cleaned up resources to make Hub ESR faster.", "", "~.Version 6.7.7.7.~ (Version 7.0.0.0 Beta 1)", "1. Bug fixes.", "2. Removed 'Help Centre (Online)' to optimise the application more.", "3. Removed 'Sign In' to optimise the application more.", "4. Reverted all icons back to the original ones.", "5. Fixed the colours not working properly.", "6. New programs, these are: 'Alarm and Clock' and 'Mail'.", "7. Updated a number of old programs.", "", "~.Version 6.0.1.0.~ (6.0's Service Pack 1 Update)", "1. Fixed a bug that caused 'Skype' to stick on the 'Application Switcher' in 'Sys" &
                "tem Controls'.", "2. Changed version number on the tray icon.", "3. Fixed 'Run' not functioning properly.", "4. Moved applications and social into one menu.", "", "~.Version 6.0.0.0.~ (The personalisation patch)", "1. Bug fixes.", "2. Added user account creation.", "3. Updated user interface.", "4. Added colour personalisation.", "5. Added more applications.", "6. Added sign in screen backgrounds.", "7. Added background to the 'Hub' ready for version 6.1.0.0.", "8. Cleaned up internal files.", "", "~.Version 5.4.2.0.~ (5.4's Service Pack 2 Update)", "1. Added online and offline help topics in the 'Help Centre'.", "2. Fixed a bug that opened Hub ESR when pressing the close button in the updater." &
                "", "3. Added Hub ESR application switcher.", "4. Added 'Windows Explorer' button on the 'System' tab in 'System Controls'.", "5. Added 'Windows Desktop' button on the 'Hub' so you can go back to the desktop " &
                "in full screen.", "6. General fixes.", "", "~.Version 5.4.1.0.~ (5.4's Service Pack 1 Update)", "1. Changed the name of 'Media Player' to 'Music Player'.", "2. Fixed a bug that didn't show the pause icon on the 'Music Player'.", "3. Fixed a bug that turned the 'Music Player' blue after 5 minutes of being used." &
                "", "4. Changed names of sound sheme options to 'Default' and 'Modern'.", "5. Added option that allows the changing of full screen and windowed mode.", "6. Fixed 'Run at startup' option.", "7. Replaced 'Help' with 'Help Centre'.", "", "~.Version 5.4.0.0.~ (The Windows 10 patch)", "1. Bug fixes.", "2. Added the ability to change sound scheme.", "3. Added even more tooltips.", "4. Added the ability to select if updates are installed or not.", "5. Added 'Run at startup' option.", "6. Deleted LogicBox intergration due to server costs.", "7. New icon set.", "8. Redesigned a few screens ready for version 6.0.0.0.", "9. Hub ESR is now full screen by default, you can temporarily change this in 'Sys" &
                "tem Controls'.", "10. Hub ESR now uses the Fusion 2.0 design engine.", "11. Built-in applications now have their own accent colour.", "", "~.Version 5.3.0.0.~", "1. Changed the progress indicator for 'Loading' and 'Safe Exit'.", "2. Added temporary integration for WindowsLogic Productions LogicBox.", "3. Added tooltips. (Little boxes that appear explaining what something does.)", "4. Skype now opens in a separate window, much like the chatroom.", "5. Redesigned 'Processes' tab and renamed it 'System'.", "6. General fixes.", "", "~.Version 5.2.0.0.~", "1. Renamed 'Applications' on the 'Hub ESR' menu to 'Apps'", "2. Recoloured the menu on 'Calculator'.", "3. Added a sound to 'System Controls' when restarting.", "4. Changed Hub ESR sounds. (You will be able to revert to the old sounds in versi" &
                "on 5.4.0.0.)", "5. Prepared the 'Personalise' tab in 'System Controls' for use in version 6.0.0.0" &
                ".", "6. Prepared the 'Updates' tab in System Controls' for use in version 5.4.0.0.", "7. Changed the updater dialogues so they fit the user interface.", "8. Added a percentage counter to the loading screen.", "9. Added 'Safe Exit', this safely exits Hub ESR.", "10. Made minor changes to the way the chatroom works.", "11. Fixed a bug that caused the back and forward buttons for browsing social medi" &
                "a to get stuck.", "12. The main Hub ESR window is now maximised by default.", "", "~.Version 5.1.0.0.~", "1. Removed 'Address Book' since it was not saving people's addresses correctly.", "2. Added the names for several new applications coming in version 6.0.0.0.", "3. Added error message for features that are not yet implemented.", "4. Renamed the 'Monitor' tab on 'System Controls' to 'Processes'.", "5. Added a new 'Updates' tab to 'System Controls' for version 5.4.0.0.", "6. Added the WLP logo to the loading screen.", "", "~.Version 5.0.2.0.~", "1. Removed CPU and RAM usage from 'System Controls' since it was throwing too man" &
                "y exceptions.", "2. Removed maximise option from 'Image Viewer'.", "", "~.Version 5.0.0.0.~", "1. Updated entire user interface with a nice cool blue colour.", "2. Removed mostly every asset from Hub ESR 4.0.0.0.", "3. Updated icons to provide a cleaner, flatter feel.", "4. New social buttons let you browse your social media in a flash.", "5. New built-in applications let you get work done better than ever before.", "6. Redesigned 'System Controls' that lets you get to what you need faster.", "7. New 'chatroom' that lets you chat to other users of Hub ESR. "})
        Me.ListBox1.Location = New System.Drawing.Point(0, 53)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(531, 314)
        Me.ListBox1.TabIndex = 1
        '
        'sswhatsnew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(531, 367)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sswhatsnew"
        Me.Text = "What's New?"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
