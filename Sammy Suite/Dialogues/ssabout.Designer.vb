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
        Me.VerInfo = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Logopic = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MoreButton = New System.Windows.Forms.Button()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.Logopic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VerInfo
        '
        Me.VerInfo.AutoSize = True
        Me.VerInfo.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerInfo.Location = New System.Drawing.Point(50, 11)
        Me.VerInfo.Name = "VerInfo"
        Me.VerInfo.Size = New System.Drawing.Size(202, 30)
        Me.VerInfo.TabIndex = 1
        Me.VerInfo.Text = "%appname% %ver%"
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.ForeColor = System.Drawing.Color.White
        Me.OKButton.Location = New System.Drawing.Point(370, 139)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(78, 23)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.VerInfo)
        Me.Panel1.Controls.Add(Me.Logopic)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 53)
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
        Me.MoreButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MoreButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MoreButton.Location = New System.Drawing.Point(286, 139)
        Me.MoreButton.Name = "MoreButton"
        Me.MoreButton.Size = New System.Drawing.Size(78, 23)
        Me.MoreButton.TabIndex = 2
        Me.MoreButton.Text = "More..."
        Me.MoreButton.UseVisualStyleBackColor = True
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.ForeColor = System.Drawing.Color.White
        Me.Copyright.Location = New System.Drawing.Point(12, 69)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(438, 52)
        Me.Copyright.TabIndex = 17
        Me.Copyright.Text = "WLP Hub is Copyright © 2014 - 2022 WindowsLogic Productions. All rights reserved." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This product is licensed under the                                      to:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%user%"
        Me.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Cyan
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(254, 94)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(112, 13)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Software Agreement"
        '
        'ssabout
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(460, 174)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Copyright)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VerInfo As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Logopic As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MoreButton As System.Windows.Forms.Button
    Friend WithEvents Copyright As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
