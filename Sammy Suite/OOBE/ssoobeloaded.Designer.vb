<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssoobeloaded
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssoobeloaded))
        Me.VerInfo = New System.Windows.Forms.Label()
        Me.OOBELoadBackground = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForwardButton = New System.Windows.Forms.Button()
        CType(Me.OOBELoadBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VerInfo
        '
        Me.VerInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VerInfo.AutoSize = True
        Me.VerInfo.BackColor = System.Drawing.Color.Transparent
        Me.VerInfo.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerInfo.ForeColor = System.Drawing.Color.White
        Me.VerInfo.Location = New System.Drawing.Point(361, 96)
        Me.VerInfo.Name = "VerInfo"
        Me.VerInfo.Size = New System.Drawing.Size(154, 37)
        Me.VerInfo.TabIndex = 4
        Me.VerInfo.Text = "Hi, %user%."
        '
        'OOBELoadBackground
        '
        Me.OOBELoadBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OOBELoadBackground.Image = Global.ss.My.Resources.Resources.WLPBackground
        Me.OOBELoadBackground.Location = New System.Drawing.Point(0, 0)
        Me.OOBELoadBackground.Name = "OOBELoadBackground"
        Me.OOBELoadBackground.Size = New System.Drawing.Size(876, 463)
        Me.OOBELoadBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OOBELoadBackground.TabIndex = 0
        Me.OOBELoadBackground.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(98, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(681, 210)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ForwardButton
        '
        Me.ForwardButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ForwardButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForwardButton.Image = Global.ss.My.Resources.Resources.ssNavigateFoward
        Me.ForwardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ForwardButton.Location = New System.Drawing.Point(399, 382)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(80, 36)
        Me.ForwardButton.TabIndex = 22
        Me.ForwardButton.Text = "Start"
        Me.ForwardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'ssoobeloaded
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(876, 463)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VerInfo)
        Me.Controls.Add(Me.OOBELoadBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ssoobeloaded"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preparing..."
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.OOBELoadBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OOBELoadBackground As System.Windows.Forms.PictureBox
    Friend WithEvents VerInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ForwardButton As System.Windows.Forms.Button
End Class
