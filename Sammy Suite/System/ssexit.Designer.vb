<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssexit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssexit))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Loader = New System.Windows.Forms.PictureBox()
        Me.ExitBackground = New System.Windows.Forms.PictureBox()
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 428)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(294, 23)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(330, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 37)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Saving your settings..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(548, 428)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(316, 23)
        Me.ProgressBar2.TabIndex = 7
        Me.ProgressBar2.Visible = False
        '
        'Timer3
        '
        '
        'Loader
        '
        Me.Loader.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Loader.BackColor = System.Drawing.Color.Transparent
        Me.Loader.Image = Global.ss.My.Resources.Resources.ssLoading
        Me.Loader.Location = New System.Drawing.Point(290, 216)
        Me.Loader.Name = "Loader"
        Me.Loader.Size = New System.Drawing.Size(34, 34)
        Me.Loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Loader.TabIndex = 8
        Me.Loader.TabStop = False
        '
        'ExitBackground
        '
        Me.ExitBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitBackground.Image = Global.ss.My.Resources.Resources.WLPBackground
        Me.ExitBackground.Location = New System.Drawing.Point(0, 0)
        Me.ExitBackground.Name = "ExitBackground"
        Me.ExitBackground.Size = New System.Drawing.Size(876, 463)
        Me.ExitBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitBackground.TabIndex = 9
        Me.ExitBackground.TabStop = False
        '
        'ssexit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(876, 463)
        Me.Controls.Add(Me.Loader)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ExitBackground)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ssexit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please wait..."
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Loader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Loader As System.Windows.Forms.PictureBox
    Friend WithEvents ExitBackground As System.Windows.Forms.PictureBox
End Class
