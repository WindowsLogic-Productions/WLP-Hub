﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ssskype
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ssskype))
        Me.GeckoGeckoWebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'GeckoGeckoWebBrowser1
        '
        Me.GeckoGeckoWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GeckoGeckoWebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.GeckoGeckoWebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.GeckoGeckoWebBrowser1.Name = "GeckoGeckoWebBrowser1"
        Me.GeckoGeckoWebBrowser1.ScriptErrorsSuppressed = True
        Me.GeckoGeckoWebBrowser1.Size = New System.Drawing.Size(784, 562)
        Me.GeckoGeckoWebBrowser1.TabIndex = 0
        Me.GeckoGeckoWebBrowser1.Url = New System.Uri("http://web.skype.com", System.UriKind.Absolute)
        '
        'ssskype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GeckoGeckoWebBrowser1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "ssskype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skype"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GeckoGeckoWebBrowser1 As System.Windows.Forms.WebBrowser
End Class