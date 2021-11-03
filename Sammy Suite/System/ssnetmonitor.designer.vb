<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssnetmonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssnetmonitor))
        Me.NICComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UploadLabel = New System.Windows.Forms.Label()
        Me.DownloadLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BandwidthUpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalDLLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalUploadLabel = New System.Windows.Forms.Label()
        Me.IpaddrLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ExtIpLabel = New System.Windows.Forms.Label()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NICComboBox
        '
        Me.NICComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NICComboBox.FormattingEnabled = True
        Me.NICComboBox.Location = New System.Drawing.Point(12, 89)
        Me.NICComboBox.Name = "NICComboBox"
        Me.NICComboBox.Size = New System.Drawing.Size(256, 21)
        Me.NICComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Upload:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(135, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Download:"
        '
        'UploadLabel
        '
        Me.UploadLabel.AutoSize = True
        Me.UploadLabel.ForeColor = System.Drawing.Color.White
        Me.UploadLabel.Location = New System.Drawing.Point(56, 125)
        Me.UploadLabel.Name = "UploadLabel"
        Me.UploadLabel.Size = New System.Drawing.Size(43, 13)
        Me.UploadLabel.TabIndex = 1
        Me.UploadLabel.Text = "0 bytes"
        '
        'DownloadLabel
        '
        Me.DownloadLabel.AutoSize = True
        Me.DownloadLabel.ForeColor = System.Drawing.Color.White
        Me.DownloadLabel.Location = New System.Drawing.Point(195, 125)
        Me.DownloadLabel.Name = "DownloadLabel"
        Me.DownloadLabel.Size = New System.Drawing.Size(43, 13)
        Me.DownloadLabel.TabIndex = 1
        Me.DownloadLabel.Text = "0 bytes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 32)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Int IP :"
        '
        'BandwidthUpdateTimer
        '
        Me.BandwidthUpdateTimer.Enabled = True
        Me.BandwidthUpdateTimer.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(134, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Download:"
        '
        'TotalDLLabel
        '
        Me.TotalDLLabel.AutoSize = True
        Me.TotalDLLabel.ForeColor = System.Drawing.Color.White
        Me.TotalDLLabel.Location = New System.Drawing.Point(222, 148)
        Me.TotalDLLabel.Name = "TotalDLLabel"
        Me.TotalDLLabel.Size = New System.Drawing.Size(43, 13)
        Me.TotalDLLabel.TabIndex = 1
        Me.TotalDLLabel.Text = "0 bytes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Total Upload:"
        '
        'TotalUploadLabel
        '
        Me.TotalUploadLabel.AutoSize = True
        Me.TotalUploadLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalUploadLabel.ForeColor = System.Drawing.Color.White
        Me.TotalUploadLabel.Location = New System.Drawing.Point(84, 148)
        Me.TotalUploadLabel.Name = "TotalUploadLabel"
        Me.TotalUploadLabel.Size = New System.Drawing.Size(43, 13)
        Me.TotalUploadLabel.TabIndex = 1
        Me.TotalUploadLabel.Text = "0 bytes"
        '
        'IpaddrLabel
        '
        Me.IpaddrLabel.AutoSize = True
        Me.IpaddrLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IpaddrLabel.ForeColor = System.Drawing.Color.White
        Me.IpaddrLabel.Location = New System.Drawing.Point(92, 9)
        Me.IpaddrLabel.Name = "IpaddrLabel"
        Me.IpaddrLabel.Size = New System.Drawing.Size(82, 32)
        Me.IpaddrLabel.TabIndex = 1
        Me.IpaddrLabel.Text = "0.0.0.0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(8, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 32)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ext IP :"
        '
        'ExtIpLabel
        '
        Me.ExtIpLabel.AutoSize = True
        Me.ExtIpLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtIpLabel.ForeColor = System.Drawing.Color.White
        Me.ExtIpLabel.Location = New System.Drawing.Point(92, 46)
        Me.ExtIpLabel.Name = "ExtIpLabel"
        Me.ExtIpLabel.Size = New System.Drawing.Size(82, 32)
        Me.ExtIpLabel.TabIndex = 1
        Me.ExtIpLabel.Text = "0.0.0.0"
        '
        'AboutButton
        '
        Me.AboutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AboutButton.Location = New System.Drawing.Point(193, 168)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(75, 23)
        Me.AboutButton.TabIndex = 1
        Me.AboutButton.Text = "About..."
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RefreshButton.Location = New System.Drawing.Point(112, 168)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 0
        Me.RefreshButton.Text = "Refresh IP"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'ssnetmonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(280, 203)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.DownloadLabel)
        Me.Controls.Add(Me.UploadLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TotalUploadLabel)
        Me.Controls.Add(Me.TotalDLLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ExtIpLabel)
        Me.Controls.Add(Me.IpaddrLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NICComboBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ssnetmonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Network Monitor"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NICComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UploadLabel As System.Windows.Forms.Label
    Friend WithEvents DownloadLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BandwidthUpdateTimer As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TotalDLLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TotalUploadLabel As System.Windows.Forms.Label
    Friend WithEvents IpaddrLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ExtIpLabel As System.Windows.Forms.Label
    Friend WithEvents AboutButton As Button
    Friend WithEvents RefreshButton As Button
End Class
