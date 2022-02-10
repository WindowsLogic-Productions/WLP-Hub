<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssdeviantart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssdeviantart))
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GeckoGeckoWebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Image = Global.ss.My.Resources.Resources.ssNavigateBack
        Me.Button12.Location = New System.Drawing.Point(0, 0)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(36, 36)
        Me.Button12.TabIndex = 1
        Me.Button12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button12, "Back")
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.ForeColor = System.Drawing.Color.White
        Me.Button13.Image = Global.ss.My.Resources.Resources.ssNavigateFoward
        Me.Button13.Location = New System.Drawing.Point(35, 0)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(36, 36)
        Me.Button13.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button13, "Forward")
        Me.Button13.UseVisualStyleBackColor = False
        '
        'GeckoGeckoWebBrowser1
        '
        Me.GeckoGeckoWebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeckoGeckoWebBrowser1.Location = New System.Drawing.Point(0, 36)
        Me.GeckoGeckoWebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.GeckoGeckoWebBrowser1.Name = "GeckoGeckoWebBrowser1"
        Me.GeckoGeckoWebBrowser1.ScriptErrorsSuppressed = True
        Me.GeckoGeckoWebBrowser1.Size = New System.Drawing.Size(784, 526)
        Me.GeckoGeckoWebBrowser1.TabIndex = 14
        Me.GeckoGeckoWebBrowser1.Url = New System.Uri("http://www.deviantart.com", System.UriKind.Absolute)
        '
        'ssdeviantart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.GeckoGeckoWebBrowser1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "ssdeviantart"
        Me.Text = "DeviantArt"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents GeckoGeckoWebBrowser1 As WebBrowser
    Friend WithEvents ToolTip1 As ToolTip
End Class
