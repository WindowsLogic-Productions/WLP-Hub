<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sssearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sssearch))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Watermark1 = New ss.Watermark()
        Me.GeckoWebBrowser1 = New Gecko.GeckoWebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchButton
        '
        Me.SearchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchButton.Image = Global.ss.My.Resources.Resources.ssSearch
        Me.SearchButton.Location = New System.Drawing.Point(747, -1)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(42, 42)
        Me.SearchButton.TabIndex = 4
        Me.SearchButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SearchButton, "Search")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ForwardButton
        '
        Me.ForwardButton.Image = Global.ss.My.Resources.Resources.ssNavigateFoward
        Me.ForwardButton.Location = New System.Drawing.Point(39, -1)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(42, 42)
        Me.ForwardButton.TabIndex = 2
        Me.ForwardButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ForwardButton, "Navigate Forward")
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Image = Global.ss.My.Resources.Resources.ssNavigateBack
        Me.BackButton.Location = New System.Drawing.Point(-1, -1)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(42, 42)
        Me.BackButton.TabIndex = 1
        Me.BackButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BackButton, "Navigate Back")
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Watermark1
        '
        Me.Watermark1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Watermark1.Font = New System.Drawing.Font("Segoe UI Semilight", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Watermark1.Location = New System.Drawing.Point(80, 1)
        Me.Watermark1.markcolour = System.Drawing.Color.Gray
        Me.Watermark1.Name = "Watermark1"
        Me.Watermark1.Size = New System.Drawing.Size(668, 39)
        Me.Watermark1.TabIndex = 5
        Me.Watermark1.TabStop = False
        Me.Watermark1.Watermarktext = "Specify a search query."
        '
        'GeckoWebBrowser1
        '
        Me.GeckoWebBrowser1.ConsoleMessageEventReceivesConsoleLogCalls = True
        Me.GeckoWebBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GeckoWebBrowser1.FrameEventsPropagateToMainWindow = False
        Me.GeckoWebBrowser1.Location = New System.Drawing.Point(0, 38)
        Me.GeckoWebBrowser1.Name = "GeckoWebBrowser1"
        Me.GeckoWebBrowser1.Size = New System.Drawing.Size(788, 527)
        Me.GeckoWebBrowser1.TabIndex = 61
        Me.GeckoWebBrowser1.UseHttpActivityObserver = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.ForwardButton)
        Me.Panel1.Controls.Add(Me.Watermark1)
        Me.Panel1.Controls.Add(Me.SearchButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 40)
        Me.Panel1.TabIndex = 62
        '
        'sssearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(788, 565)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GeckoWebBrowser1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "sssearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents ForwardButton As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents Watermark1 As ss.Watermark
    Friend WithEvents GeckoWebBrowser1 As Gecko.GeckoWebBrowser
    Friend WithEvents Panel1 As Panel
End Class
