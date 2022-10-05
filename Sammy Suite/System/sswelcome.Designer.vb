<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sswelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sswelcome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Loader = New System.Windows.Forms.PictureBox()
        Me.WelcomeBackground = New System.Windows.Forms.PictureBox()
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WelcomeBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(397, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 428)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(852, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Visible = False
        '
        'Loader
        '
        Me.Loader.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Loader.BackColor = System.Drawing.Color.Transparent
        Me.Loader.Image = Global.ss.My.Resources.Resources.ssLoading
        Me.Loader.Location = New System.Drawing.Point(357, 216)
        Me.Loader.Name = "Loader"
        Me.Loader.Size = New System.Drawing.Size(34, 34)
        Me.Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Loader.TabIndex = 0
        Me.Loader.TabStop = False
        '
        'WelcomeBackground
        '
        Me.WelcomeBackground.BackColor = System.Drawing.Color.DodgerBlue
        Me.WelcomeBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WelcomeBackground.Image = Global.ss.My.Resources.Resources.WLPBackground
        Me.WelcomeBackground.Location = New System.Drawing.Point(0, 0)
        Me.WelcomeBackground.Name = "WelcomeBackground"
        Me.WelcomeBackground.Size = New System.Drawing.Size(876, 463)
        Me.WelcomeBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WelcomeBackground.TabIndex = 3
        Me.WelcomeBackground.TabStop = False
        '
        'sswelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(876, 463)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Loader)
        Me.Controls.Add(Me.WelcomeBackground)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "sswelcome"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading..."
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WelcomeBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Loader As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents WelcomeBackground As System.Windows.Forms.PictureBox
End Class
