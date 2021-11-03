<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sschat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sschat))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtClientIP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClientPort = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClientSend = New System.Windows.Forms.TextBox()
        Me.rtbClient = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpCentreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtClientName = New System.Windows.Forms.ToolStripTextBox()
        Me.btnClientConnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClientDisconnect = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmoticonButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(511, 50)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 329)
        Me.ListBox1.TabIndex = 6
        '
        'txtClientIP
        '
        Me.txtClientIP.Location = New System.Drawing.Point(78, 403)
        Me.txtClientIP.Name = "txtClientIP"
        Me.txtClientIP.Size = New System.Drawing.Size(128, 22)
        Me.txtClientIP.TabIndex = 12
        Me.txtClientIP.Text = "88.106.158.136"
        Me.txtClientIP.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Address :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'txtClientPort
        '
        Me.txtClientPort.Location = New System.Drawing.Point(249, 403)
        Me.txtClientPort.Name = "txtClientPort"
        Me.txtClientPort.Size = New System.Drawing.Size(40, 22)
        Me.txtClientPort.TabIndex = 10
        Me.txtClientPort.Text = "40404"
        Me.txtClientPort.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(214, 406)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Port:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'txtClientSend
        '
        Me.txtClientSend.Location = New System.Drawing.Point(11, 381)
        Me.txtClientSend.Name = "txtClientSend"
        Me.txtClientSend.Size = New System.Drawing.Size(494, 22)
        Me.txtClientSend.TabIndex = 8
        '
        'rtbClient
        '
        Me.rtbClient.Location = New System.Drawing.Point(11, 50)
        Me.rtbClient.Name = "rtbClient"
        Me.rtbClient.ReadOnly = True
        Me.rtbClient.Size = New System.Drawing.Size(494, 329)
        Me.rtbClient.TabIndex = 7
        Me.rtbClient.Text = ""
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(511, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 22)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.Button1, "Send Message")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.txtClientName, Me.btnClientConnect, Me.btnClientDisconnect})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(643, 40)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssExit
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpCentreToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 36)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpCentreToolStripMenuItem
        '
        Me.HelpCentreToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssQuestion
        Me.HelpCentreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpCentreToolStripMenuItem.Name = "HelpCentreToolStripMenuItem"
        Me.HelpCentreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpCentreToolStripMenuItem.Size = New System.Drawing.Size(142, 38)
        Me.HelpCentreToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(139, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssInfo
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(142, 38)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'txtClientName
        '
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(100, 36)
        Me.txtClientName.ToolTipText = "Enter your nickname."
        '
        'btnClientConnect
        '
        Me.btnClientConnect.ForeColor = System.Drawing.Color.White
        Me.btnClientConnect.Image = Global.ss.My.Resources.Resources.ssSet
        Me.btnClientConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClientConnect.Name = "btnClientConnect"
        Me.btnClientConnect.Size = New System.Drawing.Size(96, 36)
        Me.btnClientConnect.Text = "Connect"
        '
        'btnClientDisconnect
        '
        Me.btnClientDisconnect.Enabled = False
        Me.btnClientDisconnect.ForeColor = System.Drawing.Color.White
        Me.btnClientDisconnect.Image = Global.ss.My.Resources.Resources.ssDelete
        Me.btnClientDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClientDisconnect.Name = "btnClientDisconnect"
        Me.btnClientDisconnect.Size = New System.Drawing.Size(110, 36)
        Me.btnClientDisconnect.Text = "Disconnect"
        '
        'EmoticonButton
        '
        Me.EmoticonButton.Enabled = False
        Me.EmoticonButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.EmoticonButton.Location = New System.Drawing.Point(548, 381)
        Me.EmoticonButton.Name = "EmoticonButton"
        Me.EmoticonButton.Size = New System.Drawing.Size(83, 22)
        Me.EmoticonButton.TabIndex = 21
        Me.EmoticonButton.Text = "Emoticons"
        Me.ToolTip1.SetToolTip(Me.EmoticonButton, "Emoticons")
        Me.EmoticonButton.UseVisualStyleBackColor = True
        '
        'sschat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(643, 414)
        Me.Controls.Add(Me.EmoticonButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtClientIP)
        Me.Controls.Add(Me.txtClientSend)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rtbClient)
        Me.Controls.Add(Me.txtClientPort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "sschat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Messages"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtClientIP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtClientPort As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClientSend As TextBox
    Friend WithEvents rtbClient As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpCentreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtClientName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnClientConnect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClientDisconnect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmoticonButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
