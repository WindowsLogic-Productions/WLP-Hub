<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssmusicplaylist
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssmusicplaylist))
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SavePlaylistButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RemoveMusicButton = New System.Windows.Forms.Button()
        Me.AddMusicButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(12, 64)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(266, 277)
        Me.ListBox3.TabIndex = 0
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Title = "Open Music..."
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 53)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create your own playlist..."
        '
        'SavePlaylistButton
        '
        Me.SavePlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SavePlaylistButton.Location = New System.Drawing.Point(172, 347)
        Me.SavePlaylistButton.Name = "SavePlaylistButton"
        Me.SavePlaylistButton.Size = New System.Drawing.Size(106, 31)
        Me.SavePlaylistButton.TabIndex = 3
        Me.SavePlaylistButton.Text = "Create Playlist"
        Me.SavePlaylistButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(138, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(126, 264)
        Me.ListBox1.TabIndex = 11
        '
        'RemoveMusicButton
        '
        Me.RemoveMusicButton.Image = Global.ss.My.Resources.Resources.ssCloseTab
        Me.RemoveMusicButton.Location = New System.Drawing.Point(51, 347)
        Me.RemoveMusicButton.Name = "RemoveMusicButton"
        Me.RemoveMusicButton.Size = New System.Drawing.Size(33, 31)
        Me.RemoveMusicButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.RemoveMusicButton, "Remove music.")
        Me.RemoveMusicButton.UseVisualStyleBackColor = True
        '
        'AddMusicButton
        '
        Me.AddMusicButton.Image = Global.ss.My.Resources.Resources.ssNewTab
        Me.AddMusicButton.Location = New System.Drawing.Point(12, 347)
        Me.AddMusicButton.Name = "AddMusicButton"
        Me.AddMusicButton.Size = New System.Drawing.Size(33, 31)
        Me.AddMusicButton.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.AddMusicButton, "Add music...")
        Me.AddMusicButton.UseVisualStyleBackColor = True
        '
        'ssmusicplaylist
        '
        Me.AcceptButton = Me.SavePlaylistButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(290, 389)
        Me.Controls.Add(Me.RemoveMusicButton)
        Me.Controls.Add(Me.SavePlaylistButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AddMusicButton)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ssmusicplaylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music - Playlist Creator"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents AddMusicButton As Button
    Friend WithEvents RemoveMusicButton As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SavePlaylistButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
