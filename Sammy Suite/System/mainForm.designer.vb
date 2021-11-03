<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
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
        Me.RefreshIpLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'NICComboBox
        '
        Me.NICComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NICComboBox.FormattingEnabled = True
        Me.NICComboBox.Location = New System.Drawing.Point(12, 12)
        Me.NICComboBox.Name = "NICComboBox"
        Me.NICComboBox.Size = New System.Drawing.Size(256, 21)
        Me.NICComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 94)
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
        Me.Label2.Location = New System.Drawing.Point(135, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Download:"
        '
        'UploadLabel
        '
        Me.UploadLabel.AutoSize = True
        Me.UploadLabel.ForeColor = System.Drawing.Color.White
        Me.UploadLabel.Location = New System.Drawing.Point(66, 94)
        Me.UploadLabel.Name = "UploadLabel"
        Me.UploadLabel.Size = New System.Drawing.Size(43, 13)
        Me.UploadLabel.TabIndex = 1
        Me.UploadLabel.Text = "0 bytes"
        '
        'DownloadLabel
        '
        Me.DownloadLabel.AutoSize = True
        Me.DownloadLabel.ForeColor = System.Drawing.Color.White
        Me.DownloadLabel.Location = New System.Drawing.Point(205, 94)
        Me.DownloadLabel.Name = "DownloadLabel"
        Me.DownloadLabel.Size = New System.Drawing.Size(43, 13)
        Me.DownloadLabel.TabIndex = 1
        Me.DownloadLabel.Text = "0 bytes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
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
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Download :"
        '
        'TotalDLLabel
        '
        Me.TotalDLLabel.AutoSize = True
        Me.TotalDLLabel.ForeColor = System.Drawing.Color.White
        Me.TotalDLLabel.Location = New System.Drawing.Point(113, 138)
        Me.TotalDLLabel.Name = "TotalDLLabel"
        Me.TotalDLLabel.Size = New System.Drawing.Size(43, 13)
        Me.TotalDLLabel.TabIndex = 1
        Me.TotalDLLabel.Text = "0 Bytes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Total Upload :"
        '
        'TotalUploadLabel
        '
        Me.TotalUploadLabel.AutoSize = True
        Me.TotalUploadLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalUploadLabel.ForeColor = System.Drawing.Color.White
        Me.TotalUploadLabel.Location = New System.Drawing.Point(113, 116)
        Me.TotalUploadLabel.Name = "TotalUploadLabel"
        Me.TotalUploadLabel.Size = New System.Drawing.Size(43, 13)
        Me.TotalUploadLabel.TabIndex = 1
        Me.TotalUploadLabel.Text = "0 Bytes"
        '
        'IpaddrLabel
        '
        Me.IpaddrLabel.AutoSize = True
        Me.IpaddrLabel.ForeColor = System.Drawing.Color.White
        Me.IpaddrLabel.Location = New System.Drawing.Point(62, 45)
        Me.IpaddrLabel.Name = "IpaddrLabel"
        Me.IpaddrLabel.Size = New System.Drawing.Size(40, 13)
        Me.IpaddrLabel.TabIndex = 1
        Me.IpaddrLabel.Text = "0.0.0.0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ext IP :"
        '
        'ExtIpLabel
        '
        Me.ExtIpLabel.AutoSize = True
        Me.ExtIpLabel.ForeColor = System.Drawing.Color.White
        Me.ExtIpLabel.Location = New System.Drawing.Point(62, 58)
        Me.ExtIpLabel.Name = "ExtIpLabel"
        Me.ExtIpLabel.Size = New System.Drawing.Size(40, 13)
        Me.ExtIpLabel.TabIndex = 1
        Me.ExtIpLabel.Text = "0.0.0.0"
        '
        'RefreshIpLinkLabel
        '
        Me.RefreshIpLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RefreshIpLinkLabel.AutoSize = True
        Me.RefreshIpLinkLabel.ForeColor = System.Drawing.Color.White
        Me.RefreshIpLinkLabel.LinkColor = System.Drawing.Color.White
        Me.RefreshIpLinkLabel.Location = New System.Drawing.Point(210, 138)
        Me.RefreshIpLinkLabel.Name = "RefreshIpLinkLabel"
        Me.RefreshIpLinkLabel.Size = New System.Drawing.Size(58, 13)
        Me.RefreshIpLinkLabel.TabIndex = 2
        Me.RefreshIpLinkLabel.TabStop = True
        Me.RefreshIpLinkLabel.Text = "Refresh IP"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(280, 160)
        Me.Controls.Add(Me.RefreshIpLinkLabel)
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
        Me.Name = "mainForm"
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
    Friend WithEvents RefreshIpLinkLabel As System.Windows.Forms.LinkLabel

End Class
