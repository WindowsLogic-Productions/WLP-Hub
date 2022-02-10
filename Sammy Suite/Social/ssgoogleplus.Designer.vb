<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ssgoogleplus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssgoogleplus))
        Me.GeckoGeckoWebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.GeckoGeckoWebBrowser1.Url = New System.Uri("http://plus.google.com", System.UriKind.Absolute)
        '
        'ForwardButton
        '
        Me.ForwardButton.Image = Global.ss.My.Resources.Resources.ssNavigateFoward
        Me.ForwardButton.Location = New System.Drawing.Point(35, 0)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 36)
        Me.ForwardButton.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Navigate Forward")
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Image = Global.ss.My.Resources.Resources.ssNavigateBack
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 36)
        Me.BackButton.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BackButton, "Navigate Back")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ssgoogleplus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GeckoGeckoWebBrowser1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "ssgoogleplus"
        Me.Text = "Google+"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeckoGeckoWebBrowser1 As WebBrowser
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ForwardButton As System.Windows.Forms.Button
    Friend WithEvents BackButton As System.Windows.Forms.Button
End Class
