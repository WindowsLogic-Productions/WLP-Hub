<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssgifstudiodark
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
        Me.OKButton = New System.Windows.Forms.Button()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.tbIntensity = New System.Windows.Forms.TrackBar()
        CType(Me.tbIntensity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.Location = New System.Drawing.Point(89, 84)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'lblValue
        '
        Me.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblValue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.ForeColor = System.Drawing.Color.White
        Me.lblValue.Location = New System.Drawing.Point(55, 39)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(65, 21)
        Me.lblValue.TabIndex = 134
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblValue.Visible = False
        '
        'tbIntensity
        '
        Me.tbIntensity.AutoSize = False
        Me.tbIntensity.BackColor = System.Drawing.SystemColors.Control
        Me.tbIntensity.LargeChange = 1
        Me.tbIntensity.Location = New System.Drawing.Point(32, 12)
        Me.tbIntensity.Maximum = 500
        Me.tbIntensity.Minimum = 1
        Me.tbIntensity.Name = "tbIntensity"
        Me.tbIntensity.Size = New System.Drawing.Size(113, 24)
        Me.tbIntensity.TabIndex = 133
        Me.tbIntensity.TickFrequency = 20
        Me.tbIntensity.Value = 10
        Me.tbIntensity.Visible = False
        '
        'ssgifstudiodark
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 119)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.tbIntensity)
        Me.Controls.Add(Me.OKButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ssgifstudiodark"
        Me.ShowIcon = False
        Me.Text = "GIF Studio - Dark Effect"
        CType(Me.tbIntensity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents tbIntensity As System.Windows.Forms.TrackBar
End Class
