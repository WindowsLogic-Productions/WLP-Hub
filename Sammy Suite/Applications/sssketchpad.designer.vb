<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sssketchpad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sssketchpad))
        Me.Rb1 = New System.Windows.Forms.RadioButton()
        Me.Rb2 = New System.Windows.Forms.RadioButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.Rb5 = New System.Windows.Forms.RadioButton()
        Me.Rb4 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbTransparency = New System.Windows.Forms.TrackBar()
        Me.pbPicker = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Flip90DegreesLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Flip90DegressRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FlipHorizontallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearCavasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpCentreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.tbTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rb1
        '
        Me.Rb1.AutoSize = True
        Me.Rb1.Checked = True
        Me.Rb1.ForeColor = System.Drawing.Color.White
        Me.Rb1.Location = New System.Drawing.Point(428, 43)
        Me.Rb1.Name = "Rb1"
        Me.Rb1.Size = New System.Drawing.Size(59, 17)
        Me.Rb1.TabIndex = 1
        Me.Rb1.TabStop = True
        Me.Rb1.Text = "Scrape"
        Me.ToolTip1.SetToolTip(Me.Rb1, "Scrape paint on the canvas.")
        Me.Rb1.UseVisualStyleBackColor = True
        '
        'Rb2
        '
        Me.Rb2.AutoSize = True
        Me.Rb2.ForeColor = System.Drawing.Color.White
        Me.Rb2.Location = New System.Drawing.Point(428, 66)
        Me.Rb2.Name = "Rb2"
        Me.Rb2.Size = New System.Drawing.Size(67, 17)
        Me.Rb2.TabIndex = 2
        Me.Rb2.TabStop = True
        Me.Rb2.Text = "Smudge"
        Me.ToolTip1.SetToolTip(Me.Rb2, "Smudge paint on the canvas.")
        Me.Rb2.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1Pixel.jpg")
        Me.ImageList1.Images.SetKeyName(1, "2Pixel.jpg")
        Me.ImageList1.Images.SetKeyName(2, "3Pixel.jpg")
        Me.ImageList1.Images.SetKeyName(3, "4Pixel.jpg")
        Me.ImageList1.Images.SetKeyName(4, "5Pixel.jpg")
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(185, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(68, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Pick the thickness of the brush.")
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.ForeColor = System.Drawing.Color.White
        Me.lblWidth.Location = New System.Drawing.Point(53, 43)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(126, 13)
        Me.lblWidth.TabIndex = 8
        Me.lblWidth.Text = "Brush stroke thickness:"
        '
        'Rb5
        '
        Me.Rb5.AutoSize = True
        Me.Rb5.ForeColor = System.Drawing.Color.White
        Me.Rb5.Location = New System.Drawing.Point(501, 65)
        Me.Rb5.Name = "Rb5"
        Me.Rb5.Size = New System.Drawing.Size(55, 17)
        Me.Rb5.TabIndex = 9
        Me.Rb5.Text = "Brush"
        Me.ToolTip1.SetToolTip(Me.Rb5, "Paint ribbons on the canvas.")
        Me.Rb5.UseVisualStyleBackColor = True
        '
        'Rb4
        '
        Me.Rb4.AutoSize = True
        Me.Rb4.ForeColor = System.Drawing.Color.White
        Me.Rb4.Location = New System.Drawing.Point(501, 43)
        Me.Rb4.Name = "Rb4"
        Me.Rb4.Size = New System.Drawing.Size(52, 17)
        Me.Rb4.TabIndex = 11
        Me.Rb4.TabStop = True
        Me.Rb4.Text = "Erase"
        Me.ToolTip1.SetToolTip(Me.Rb4, "Erase paint that is on the canvas.")
        Me.Rb4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(567, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(36, 36)
        Me.Panel2.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.Panel2, "Selected colours.")
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(6, 6)
        Me.Label9.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(6, 6)
        Me.Label8.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(6, 6)
        Me.Label7.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(6, 6)
        Me.Label6.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(6, 6)
        Me.Label5.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(6, 6)
        Me.Label4.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(28, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(6, 6)
        Me.Label3.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(6, 6)
        Me.Label1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(6, 6)
        Me.Label2.TabIndex = 22
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(102, 66)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Normal Stroke"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Draw with the standard ribbon brush.")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(207, 66)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox2.TabIndex = 24
        Me.CheckBox2.Text = "Vertical Stroke"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "Draw with the vertical stroke ribbon brush.")
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(313, 66)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(116, 17)
        Me.CheckBox3.TabIndex = 25
        Me.CheckBox3.Text = "Horizontal Stroke"
        Me.ToolTip1.SetToolTip(Me.CheckBox3, "Draw with the horizontal stroke ribbon brush.")
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Cornsilk
        Me.ToolTip1.IsBalloon = True
        '
        'tbTransparency
        '
        Me.tbTransparency.AutoSize = False
        Me.tbTransparency.LargeChange = 25
        Me.tbTransparency.Location = New System.Drawing.Point(339, 43)
        Me.tbTransparency.Maximum = 255
        Me.tbTransparency.Minimum = 50
        Me.tbTransparency.Name = "tbTransparency"
        Me.tbTransparency.Size = New System.Drawing.Size(52, 17)
        Me.tbTransparency.SmallChange = 10
        Me.tbTransparency.TabIndex = 32
        Me.tbTransparency.TickFrequency = 5
        Me.tbTransparency.TickStyle = System.Windows.Forms.TickStyle.None
        Me.ToolTip1.SetToolTip(Me.tbTransparency, "Set the transparency of the canvas.")
        Me.tbTransparency.Value = 255
        '
        'pbPicker
        '
        Me.pbPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPicker.Image = Global.ss.My.Resources.Resources.ssColours
        Me.pbPicker.Location = New System.Drawing.Point(609, 43)
        Me.pbPicker.Name = "pbPicker"
        Me.pbPicker.Size = New System.Drawing.Size(219, 43)
        Me.pbPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbPicker.TabIndex = 10
        Me.pbPicker.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbPicker, "Select up to nine different colours to create the ribbon.")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(259, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Transparency:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(397, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "255"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(564, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Colours:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(425, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Tools:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(53, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Stroke:"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip2.Size = New System.Drawing.Size(881, 24)
        Me.MenuStrip2.TabIndex = 37
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssNew
        Me.NewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(177, 38)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssOpen
        Me.OpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(177, 38)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(174, 6)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssSave
        Me.SaveAsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(177, 38)
        Me.SaveAsToolStripMenuItem.Text = "Save as..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(174, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(177, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Flip90DegreesLeftToolStripMenuItem, Me.Flip90DegressRightToolStripMenuItem, Me.ToolStripSeparator6, Me.FlipHorizontallyToolStripMenuItem, Me.FlipVerticalToolStripMenuItem, Me.ToolStripSeparator5, Me.ClearCavasToolStripMenuItem})
        Me.EditToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'Flip90DegreesLeftToolStripMenuItem
        '
        Me.Flip90DegreesLeftToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssRotateLeft
        Me.Flip90DegreesLeftToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Flip90DegreesLeftToolStripMenuItem.Name = "Flip90DegreesLeftToolStripMenuItem"
        Me.Flip90DegreesLeftToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.Flip90DegreesLeftToolStripMenuItem.Text = "Flip 90 degrees left"
        '
        'Flip90DegressRightToolStripMenuItem
        '
        Me.Flip90DegressRightToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssRotateRight
        Me.Flip90DegressRightToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Flip90DegressRightToolStripMenuItem.Name = "Flip90DegressRightToolStripMenuItem"
        Me.Flip90DegressRightToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.Flip90DegressRightToolStripMenuItem.Text = "Flip 90 degress right"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(192, 6)
        '
        'FlipHorizontallyToolStripMenuItem
        '
        Me.FlipHorizontallyToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssFlipH
        Me.FlipHorizontallyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FlipHorizontallyToolStripMenuItem.Name = "FlipHorizontallyToolStripMenuItem"
        Me.FlipHorizontallyToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.FlipHorizontallyToolStripMenuItem.Text = "Flip horizontally"
        '
        'FlipVerticalToolStripMenuItem
        '
        Me.FlipVerticalToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssFlipV
        Me.FlipVerticalToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FlipVerticalToolStripMenuItem.Name = "FlipVerticalToolStripMenuItem"
        Me.FlipVerticalToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.FlipVerticalToolStripMenuItem.Text = "Flip vertical"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(192, 6)
        '
        'ClearCavasToolStripMenuItem
        '
        Me.ClearCavasToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssDelete
        Me.ClearCavasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClearCavasToolStripMenuItem.Name = "ClearCavasToolStripMenuItem"
        Me.ClearCavasToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.ClearCavasToolStripMenuItem.Text = "Clear canvas"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpCentreToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'HelpCentreToolStripMenuItem
        '
        Me.HelpCentreToolStripMenuItem.Image = Global.ss.My.Resources.Resources.ssQuestion
        Me.HelpCentreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpCentreToolStripMenuItem.Name = "HelpCentreToolStripMenuItem"
        Me.HelpCentreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpCentreToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.HelpCentreToolStripMenuItem.Text = "Help"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Image = Global.ss.My.Resources.Resources.ssInfo
        Me.AboutToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(168, 38)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Title = "Open Image..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(120, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 480)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'sssketchpad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(881, 568)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.tbTransparency)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Rb4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Rb5)
        Me.Controls.Add(Me.pbPicker)
        Me.Controls.Add(Me.Rb2)
        Me.Controls.Add(Me.Rb1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CheckBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "sssketchpad"
        Me.Text = "Sketch Pad"
        Me.Panel2.ResumeLayout(False)
        CType(Me.tbTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblWidth As System.Windows.Forms.Label
    Friend WithEvents Rb5 As System.Windows.Forms.RadioButton
    Friend WithEvents pbPicker As System.Windows.Forms.PictureBox
    Friend WithEvents Rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbTransparency As System.Windows.Forms.TrackBar
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Flip90DegreesLeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Flip90DegressRightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents FlipHorizontallyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ClearCavasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents HelpCentreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
