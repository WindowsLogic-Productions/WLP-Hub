<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sscdplayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sscdplayer))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MillisecondsS = New System.Windows.Forms.Label()
        Me.Colon2S = New System.Windows.Forms.Label()
        Me.Colon1S = New System.Windows.Forms.Label()
        Me.MinutesS = New System.Windows.Forms.Label()
        Me.SecondsS = New System.Windows.Forms.Label()
        Me.TrackS = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "CD Status: Please Insert CD"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(12, 57)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(128, 22)
        Me.NumericUpDown1.TabIndex = 33
        Me.NumericUpDown1.Visible = False
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = Global.ss.My.Resources.Resources.Play
        Me.Button8.Location = New System.Drawing.Point(146, 10)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(76, 23)
        Me.Button8.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.Button8, "Play")
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Global.ss.My.Resources.Resources.PreviousTrack
        Me.Button6.Location = New System.Drawing.Point(146, 32)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 23)
        Me.Button6.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.Button6, "Previous Track")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Global.ss.My.Resources.Resources.NextTrack
        Me.Button4.Location = New System.Drawing.Point(195, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 23)
        Me.Button4.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.Button4, "Next Track")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Global.ss.My.Resources.Resources.Pause
        Me.Button2.Location = New System.Drawing.Point(221, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 23)
        Me.Button2.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.Button2, "Pause")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 18)
        Me.Label7.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 45)
        Me.Label2.TabIndex = 31
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Global.ss.My.Resources.Resources.Eject
        Me.Button3.Location = New System.Drawing.Point(246, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 23)
        Me.Button3.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.Button3, "Eject")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.ss.My.Resources.Resources.ssStop
        Me.Button1.Location = New System.Drawing.Point(246, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 23)
        Me.Button1.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.Button1, "Stop")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MillisecondsS
        '
        Me.MillisecondsS.AutoSize = True
        Me.MillisecondsS.BackColor = System.Drawing.Color.Black
        Me.MillisecondsS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MillisecondsS.ForeColor = System.Drawing.Color.Lime
        Me.MillisecondsS.Location = New System.Drawing.Point(111, 33)
        Me.MillisecondsS.Name = "MillisecondsS"
        Me.MillisecondsS.Size = New System.Drawing.Size(28, 21)
        Me.MillisecondsS.TabIndex = 32
        Me.MillisecondsS.Text = "00"
        '
        'Colon2S
        '
        Me.Colon2S.AutoSize = True
        Me.Colon2S.BackColor = System.Drawing.Color.Black
        Me.Colon2S.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colon2S.ForeColor = System.Drawing.Color.Lime
        Me.Colon2S.Location = New System.Drawing.Point(94, 33)
        Me.Colon2S.Name = "Colon2S"
        Me.Colon2S.Size = New System.Drawing.Size(13, 21)
        Me.Colon2S.TabIndex = 40
        Me.Colon2S.Text = ":"
        '
        'Colon1S
        '
        Me.Colon1S.AutoSize = True
        Me.Colon1S.BackColor = System.Drawing.Color.Black
        Me.Colon1S.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Colon1S.ForeColor = System.Drawing.Color.Lime
        Me.Colon1S.Location = New System.Drawing.Point(44, 33)
        Me.Colon1S.Name = "Colon1S"
        Me.Colon1S.Size = New System.Drawing.Size(13, 21)
        Me.Colon1S.TabIndex = 39
        Me.Colon1S.Text = ":"
        '
        'MinutesS
        '
        Me.MinutesS.AutoSize = True
        Me.MinutesS.BackColor = System.Drawing.Color.Black
        Me.MinutesS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesS.ForeColor = System.Drawing.Color.Lime
        Me.MinutesS.Location = New System.Drawing.Point(19, 33)
        Me.MinutesS.Name = "MinutesS"
        Me.MinutesS.Size = New System.Drawing.Size(28, 21)
        Me.MinutesS.TabIndex = 38
        Me.MinutesS.Text = "00"
        '
        'SecondsS
        '
        Me.SecondsS.AutoSize = True
        Me.SecondsS.BackColor = System.Drawing.Color.Black
        Me.SecondsS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsS.ForeColor = System.Drawing.Color.Lime
        Me.SecondsS.Location = New System.Drawing.Point(64, 33)
        Me.SecondsS.Name = "SecondsS"
        Me.SecondsS.Size = New System.Drawing.Size(28, 21)
        Me.SecondsS.TabIndex = 37
        Me.SecondsS.Text = "00"
        '
        'TrackS
        '
        Me.TrackS.AutoSize = True
        Me.TrackS.BackColor = System.Drawing.Color.Black
        Me.TrackS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackS.ForeColor = System.Drawing.Color.Lime
        Me.TrackS.Location = New System.Drawing.Point(44, 12)
        Me.TrackS.Name = "TrackS"
        Me.TrackS.Size = New System.Drawing.Size(62, 21)
        Me.TrackS.TabIndex = 30
        Me.TrackS.Text = "[00/00]"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(163, 54)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 23)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "About"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'sscdplayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 88)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Colon2S)
        Me.Controls.Add(Me.Colon1S)
        Me.Controls.Add(Me.MinutesS)
        Me.Controls.Add(Me.SecondsS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MillisecondsS)
        Me.Controls.Add(Me.TrackS)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "sscdplayer"
        Me.Text = "WLP Hub - CD Player"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MillisecondsS As System.Windows.Forms.Label
    Friend WithEvents Colon2S As System.Windows.Forms.Label
    Friend WithEvents Colon1S As System.Windows.Forms.Label
    Friend WithEvents MinutesS As System.Windows.Forms.Label
    Friend WithEvents SecondsS As System.Windows.Forms.Label
    Friend WithEvents TrackS As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
