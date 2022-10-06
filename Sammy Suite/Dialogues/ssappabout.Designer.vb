<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssappabout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssappabout))
        Me.AppPic = New System.Windows.Forms.PictureBox()
        Me.AppName = New System.Windows.Forms.Label()
        Me.AppVer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AppPic
        '
        Me.AppPic.Image = Global.ss.My.Resources.Resources.CDPlayer
        Me.AppPic.Location = New System.Drawing.Point(12, 12)
        Me.AppPic.Name = "AppPic"
        Me.AppPic.Size = New System.Drawing.Size(32, 32)
        Me.AppPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AppPic.TabIndex = 0
        Me.AppPic.TabStop = False
        '
        'AppName
        '
        Me.AppName.AutoSize = True
        Me.AppName.ForeColor = System.Drawing.Color.White
        Me.AppName.Location = New System.Drawing.Point(50, 12)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(57, 13)
        Me.AppName.TabIndex = 1
        Me.AppName.Text = "AppName"
        '
        'AppVer
        '
        Me.AppVer.AutoSize = True
        Me.AppVer.ForeColor = System.Drawing.Color.White
        Me.AppVer.Location = New System.Drawing.Point(50, 42)
        Me.AppVer.Name = "AppVer"
        Me.AppVer.Size = New System.Drawing.Size(44, 13)
        Me.AppVer.TabIndex = 2
        Me.AppVer.Text = "AppVer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "WindowsLogic Productions"
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.Location = New System.Drawing.Point(126, 70)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'ssappabout
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(213, 105)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AppVer)
        Me.Controls.Add(Me.AppName)
        Me.Controls.Add(Me.AppPic)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ssappabout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About App"
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AppPic As PictureBox
    Friend WithEvents AppName As Label
    Friend WithEvents AppVer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OKButton As Button
End Class
