<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssVolume
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssVolume))
        Me.VolumeSlider = New System.Windows.Forms.TrackBar()
        Me.SoundLevelLabel = New System.Windows.Forms.Label()
        Me.ADPButton = New System.Windows.Forms.Button()
        Me.MixerButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        CType(Me.VolumeSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VolumeSlider
        '
        Me.VolumeSlider.Location = New System.Drawing.Point(75, 9)
        Me.VolumeSlider.Maximum = 100
        Me.VolumeSlider.Name = "VolumeSlider"
        Me.VolumeSlider.Size = New System.Drawing.Size(264, 45)
        Me.VolumeSlider.TabIndex = 0
        Me.VolumeSlider.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'SoundLevelLabel
        '
        Me.SoundLevelLabel.AutoSize = True
        Me.SoundLevelLabel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoundLevelLabel.ForeColor = System.Drawing.Color.White
        Me.SoundLevelLabel.Location = New System.Drawing.Point(1, 9)
        Me.SoundLevelLabel.Name = "SoundLevelLabel"
        Me.SoundLevelLabel.Size = New System.Drawing.Size(62, 37)
        Me.SoundLevelLabel.TabIndex = 4
        Me.SoundLevelLabel.Text = "100"
        '
        'ADPButton
        '
        Me.ADPButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ADPButton.Location = New System.Drawing.Point(25, 60)
        Me.ADPButton.Name = "ADPButton"
        Me.ADPButton.Size = New System.Drawing.Size(152, 23)
        Me.ADPButton.TabIndex = 1
        Me.ADPButton.Text = "Audio Device Properties..."
        Me.ADPButton.UseVisualStyleBackColor = True
        '
        'MixerButton
        '
        Me.MixerButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MixerButton.Location = New System.Drawing.Point(183, 60)
        Me.MixerButton.Name = "MixerButton"
        Me.MixerButton.Size = New System.Drawing.Size(75, 23)
        Me.MixerButton.TabIndex = 2
        Me.MixerButton.Text = "Mixer..."
        Me.MixerButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AboutButton.Location = New System.Drawing.Point(264, 60)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(75, 23)
        Me.AboutButton.TabIndex = 3
        Me.AboutButton.Text = "About..."
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'ssVolume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(351, 95)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.MixerButton)
        Me.Controls.Add(Me.ADPButton)
        Me.Controls.Add(Me.SoundLevelLabel)
        Me.Controls.Add(Me.VolumeSlider)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ssVolume"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volume Control"
        CType(Me.VolumeSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VolumeSlider As System.Windows.Forms.TrackBar
    Friend WithEvents SoundLevelLabel As System.Windows.Forms.Label
    Friend WithEvents ADPButton As System.Windows.Forms.Button
    Friend WithEvents MixerButton As System.Windows.Forms.Button
    Friend WithEvents AboutButton As System.Windows.Forms.Button
End Class
