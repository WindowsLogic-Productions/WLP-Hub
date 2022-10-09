<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sssettingspanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sssettingspanel))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.UpdatesSettingsButton = New System.Windows.Forms.Button()
        Me.PersonaliseSettingsButton = New System.Windows.Forms.Button()
        Me.HubSettingsButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.ResetButton.Enabled = False
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(280, 210)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(95, 23)
        Me.ResetButton.TabIndex = 6
        Me.ResetButton.Text = "Reset Settings"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'HelpButton
        '
        Me.HelpButton.BackColor = System.Drawing.Color.MidnightBlue
        Me.HelpButton.Enabled = False
        Me.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HelpButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton.ForeColor = System.Drawing.Color.White
        Me.HelpButton.Location = New System.Drawing.Point(381, 210)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(95, 23)
        Me.HelpButton.TabIndex = 7
        Me.HelpButton.Text = "Help..."
        Me.HelpButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TitleLabel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 53)
        Me.Panel1.TabIndex = 37
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 11)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(395, 30)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Select a setting to change to your liking..."
        '
        'UpdatesSettingsButton
        '
        Me.UpdatesSettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.UpdatesSettingsButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatesSettingsButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UpdatesSettingsButton.Image = Global.ss.My.Resources.Resources.ssUpdate
        Me.UpdatesSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdatesSettingsButton.Location = New System.Drawing.Point(326, 59)
        Me.UpdatesSettingsButton.Name = "UpdatesSettingsButton"
        Me.UpdatesSettingsButton.Size = New System.Drawing.Size(151, 43)
        Me.UpdatesSettingsButton.TabIndex = 4
        Me.UpdatesSettingsButton.Text = "Updates"
        Me.UpdatesSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UpdatesSettingsButton.UseVisualStyleBackColor = False
        '
        'PersonaliseSettingsButton
        '
        Me.PersonaliseSettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.PersonaliseSettingsButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonaliseSettingsButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PersonaliseSettingsButton.Image = Global.ss.My.Resources.Resources.ssSketchPad
        Me.PersonaliseSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PersonaliseSettingsButton.Location = New System.Drawing.Point(169, 59)
        Me.PersonaliseSettingsButton.Name = "PersonaliseSettingsButton"
        Me.PersonaliseSettingsButton.Size = New System.Drawing.Size(151, 43)
        Me.PersonaliseSettingsButton.TabIndex = 1
        Me.PersonaliseSettingsButton.Text = "Personalise"
        Me.PersonaliseSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PersonaliseSettingsButton.UseVisualStyleBackColor = False
        '
        'HubSettingsButton
        '
        Me.HubSettingsButton.BackColor = System.Drawing.Color.Transparent
        Me.HubSettingsButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HubSettingsButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HubSettingsButton.Image = Global.ss.My.Resources.Resources.WLP
        Me.HubSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HubSettingsButton.Location = New System.Drawing.Point(12, 59)
        Me.HubSettingsButton.Name = "HubSettingsButton"
        Me.HubSettingsButton.Size = New System.Drawing.Size(151, 43)
        Me.HubSettingsButton.TabIndex = 0
        Me.HubSettingsButton.Text = "General"
        Me.HubSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.HubSettingsButton.UseVisualStyleBackColor = False
        '
        'sssettingspanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(488, 245)
        Me.Controls.Add(Me.UpdatesSettingsButton)
        Me.Controls.Add(Me.PersonaliseSettingsButton)
        Me.Controls.Add(Me.HubSettingsButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "sssettingspanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings Panel"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents UpdatesSettingsButton As System.Windows.Forms.Button
    Friend WithEvents PersonaliseSettingsButton As System.Windows.Forms.Button
    Friend WithEvents HubSettingsButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents HelpButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
End Class
