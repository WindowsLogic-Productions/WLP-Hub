<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssabout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssabout))
        Me.MainName = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Logopic = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MoreButton = New System.Windows.Forms.Button()
        Me.VerInfo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.AppName = New System.Windows.Forms.Label()
        Me.AppPic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Logopic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainName
        '
        Me.MainName.AutoSize = True
        Me.MainName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainName.Location = New System.Drawing.Point(50, 11)
        Me.MainName.Name = "MainName"
        Me.MainName.Size = New System.Drawing.Size(308, 30)
        Me.MainName.TabIndex = 1
        Me.MainName.Text = "WindowsLogic Productions Hub"
        '
        'OKButton
        '
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.ForeColor = System.Drawing.Color.White
        Me.OKButton.Location = New System.Drawing.Point(319, 350)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(78, 23)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MainName)
        Me.Panel1.Controls.Add(Me.Logopic)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 53)
        Me.Panel1.TabIndex = 4
        '
        'Logopic
        '
        Me.Logopic.Image = Global.ss.My.Resources.Resources.WLP
        Me.Logopic.Location = New System.Drawing.Point(12, 9)
        Me.Logopic.Name = "Logopic"
        Me.Logopic.Size = New System.Drawing.Size(32, 32)
        Me.Logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logopic.TabIndex = 5
        Me.Logopic.TabStop = False
        '
        'MoreButton
        '
        Me.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MoreButton.Location = New System.Drawing.Point(235, 350)
        Me.MoreButton.Name = "MoreButton"
        Me.MoreButton.Size = New System.Drawing.Size(78, 23)
        Me.MoreButton.TabIndex = 2
        Me.MoreButton.Text = "More..."
        Me.MoreButton.UseVisualStyleBackColor = True
        '
        'VerInfo
        '
        Me.VerInfo.AutoSize = True
        Me.VerInfo.ForeColor = System.Drawing.Color.White
        Me.VerInfo.Location = New System.Drawing.Point(44, 34)
        Me.VerInfo.Name = "VerInfo"
        Me.VerInfo.Size = New System.Drawing.Size(306, 221)
        Me.VerInfo.TabIndex = 13
        Me.VerInfo.Text = resources.GetString("VerInfo.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.AppName)
        Me.GroupBox1.Controls.Add(Me.VerInfo)
        Me.GroupBox1.Controls.Add(Me.AppPic)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 285)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Legal Information"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(220, 229)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(112, 13)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Software Agreement"
        '
        'AppName
        '
        Me.AppName.AutoSize = True
        Me.AppName.Location = New System.Drawing.Point(44, 21)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(127, 13)
        Me.AppName.TabIndex = 16
        Me.AppName.Text = "WLP Hub - Version: N/A"
        '
        'AppPic
        '
        Me.AppPic.Image = Global.ss.My.Resources.Resources.WLP
        Me.AppPic.Location = New System.Drawing.Point(6, 21)
        Me.AppPic.Name = "AppPic"
        Me.AppPic.Size = New System.Drawing.Size(32, 32)
        Me.AppPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AppPic.TabIndex = 15
        Me.AppPic.TabStop = False
        '
        'ssabout
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(409, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MoreButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.OKButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ssabout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About WLP Hub"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Logopic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainName As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Logopic As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MoreButton As System.Windows.Forms.Button
    Friend WithEvents VerInfo As System.Windows.Forms.Label
    Friend WithEvents AppPic As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AppName As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
