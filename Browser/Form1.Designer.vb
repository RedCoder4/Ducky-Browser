<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BrowserView = New System.Windows.Forms.WebBrowser()
        Me.BackButton = New System.Windows.Forms.ToolStripButton()
        Me.HomeButton = New System.Windows.Forms.ToolStripButton()
        Me.ForwardButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshButton = New System.Windows.Forms.ToolStripButton()
        Me.SearchBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CnclButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SrchEngine = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DuckGo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Google = New System.Windows.Forms.ToolStripMenuItem()
        Me.Yahoo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bing = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchEngBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BlackBar2 = New System.Windows.Forms.ToolStrip()
        Me.BlackBar1 = New System.Windows.Forms.ToolStrip()
        Me.BookmarkBar = New System.Windows.Forms.ToolStrip()
        Me.Blue = New System.Windows.Forms.ToolStripButton()
        Me.Orange = New System.Windows.Forms.ToolStripButton()
        Me.Red = New System.Windows.Forms.ToolStripButton()
        Me.Green = New System.Windows.Forms.ToolStripButton()
        Me.Purple = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BkMrkTwitter = New System.Windows.Forms.ToolStripButton()
        Me.BkMrkFacebook = New System.Windows.Forms.ToolStripButton()
        Me.BkMrkGPlus = New System.Windows.Forms.ToolStripButton()
        Me.BkMrkYouTube = New System.Windows.Forms.ToolStripButton()
        Me.BkMrkGitHub = New System.Windows.Forms.ToolStripButton()
        Me.BlackBar3 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Gray = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.Tabs.SuspendLayout()
        Me.BookmarkBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrowserView
        '
        Me.BrowserView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowserView.Location = New System.Drawing.Point(0, 96)
        Me.BrowserView.Margin = New System.Windows.Forms.Padding(2)
        Me.BrowserView.MinimumSize = New System.Drawing.Size(15, 16)
        Me.BrowserView.Name = "BrowserView"
        Me.BrowserView.Size = New System.Drawing.Size(1264, 564)
        Me.BrowserView.TabIndex = 0
        Me.BrowserView.Url = New System.Uri("http://duckduckgo.com", System.UriKind.Absolute)
        '
        'BackButton
        '
        Me.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackButton.Image = CType(resources.GetObject("BackButton.Image"), System.Drawing.Image)
        Me.BackButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(36, 41)
        Me.BackButton.Text = "Back"
        '
        'HomeButton
        '
        Me.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), System.Drawing.Image)
        Me.HomeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(36, 41)
        Me.HomeButton.Text = "Home"
        '
        'ForwardButton
        '
        Me.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardButton.Image = CType(resources.GetObject("ForwardButton.Image"), System.Drawing.Image)
        Me.ForwardButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(36, 41)
        Me.ForwardButton.Text = "Forward"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 44)
        '
        'RefreshButton
        '
        Me.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshButton.Image = CType(resources.GetObject("RefreshButton.Image"), System.Drawing.Image)
        Me.RefreshButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(23, 41)
        Me.RefreshButton.Text = "Refresh"
        '
        'SearchBox
        '
        Me.SearchBox.AcceptsReturn = True
        Me.SearchBox.AutoSize = False
        Me.SearchBox.BackColor = System.Drawing.SystemColors.Control
        Me.SearchBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SearchBox.MaxLength = 42767
        Me.SearchBox.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(950, 44)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackButton, Me.HomeButton, Me.ForwardButton, Me.ToolStripSeparator1, Me.RefreshButton, Me.SearchBox, Me.CnclButton, Me.ToolStripSeparator2, Me.SrchEngine, Me.SearchEngBox})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1654, 44)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        '
        'CnclButton
        '
        Me.CnclButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CnclButton.Image = CType(resources.GetObject("CnclButton.Image"), System.Drawing.Image)
        Me.CnclButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CnclButton.Name = "CnclButton"
        Me.CnclButton.Size = New System.Drawing.Size(23, 41)
        Me.CnclButton.Text = "Cancel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 44)
        '
        'SrchEngine
        '
        Me.SrchEngine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SrchEngine.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DuckGo, Me.Google, Me.Yahoo, Me.Bing})
        Me.SrchEngine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SrchEngine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SrchEngine.Name = "SrchEngine"
        Me.SrchEngine.Size = New System.Drawing.Size(13, 41)
        '
        'DuckGo
        '
        Me.DuckGo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DuckGo.Image = CType(resources.GetObject("DuckGo.Image"), System.Drawing.Image)
        Me.DuckGo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DuckGo.Name = "DuckGo"
        Me.DuckGo.Size = New System.Drawing.Size(160, 30)
        Me.DuckGo.Text = "DuckDuckGo"
        '
        'Google
        '
        Me.Google.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Google.Image = Global.Browser.My.Resources.Resources._1414034239_social_google_box
        Me.Google.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Google.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Google.Name = "Google"
        Me.Google.Size = New System.Drawing.Size(160, 30)
        Me.Google.Text = "Google"
        '
        'Yahoo
        '
        Me.Yahoo.Image = CType(resources.GetObject("Yahoo.Image"), System.Drawing.Image)
        Me.Yahoo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Yahoo.Name = "Yahoo"
        Me.Yahoo.Size = New System.Drawing.Size(160, 30)
        Me.Yahoo.Text = "Yahoo"
        '
        'Bing
        '
        Me.Bing.Image = CType(resources.GetObject("Bing.Image"), System.Drawing.Image)
        Me.Bing.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Bing.Name = "Bing"
        Me.Bing.Size = New System.Drawing.Size(160, 30)
        Me.Bing.Text = "Bing"
        '
        'SearchEngBox
        '
        Me.SearchEngBox.AutoSize = False
        Me.SearchEngBox.Name = "SearchEngBox"
        Me.SearchEngBox.Size = New System.Drawing.Size(110, 44)
        '
        'Tabs
        '
        Me.Tabs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabs.Controls.Add(Me.TabPage1)
        Me.Tabs.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Tabs.Location = New System.Drawing.Point(3, 2)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.RightToLeftLayout = True
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(1261, 24)
        Me.Tabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.Tabs.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1253, 0)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tabs Coming Soon!"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BlackBar2
        '
        Me.BlackBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BlackBar2.AutoSize = False
        Me.BlackBar2.BackColor = System.Drawing.Color.DimGray
        Me.BlackBar2.Dock = System.Windows.Forms.DockStyle.None
        Me.BlackBar2.Location = New System.Drawing.Point(-2, 65)
        Me.BlackBar2.Name = "BlackBar2"
        Me.BlackBar2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BlackBar2.Size = New System.Drawing.Size(1270, 4)
        Me.BlackBar2.TabIndex = 5
        '
        'BlackBar1
        '
        Me.BlackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BlackBar1.AutoSize = False
        Me.BlackBar1.BackColor = System.Drawing.Color.Black
        Me.BlackBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.BlackBar1.Location = New System.Drawing.Point(-17, 22)
        Me.BlackBar1.Name = "BlackBar1"
        Me.BlackBar1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BlackBar1.Size = New System.Drawing.Size(1300, 4)
        Me.BlackBar1.TabIndex = 6
        '
        'BookmarkBar
        '
        Me.BookmarkBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookmarkBar.AutoSize = False
        Me.BookmarkBar.BackColor = System.Drawing.SystemColors.Control
        Me.BookmarkBar.CanOverflow = False
        Me.BookmarkBar.Dock = System.Windows.Forms.DockStyle.None
        Me.BookmarkBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BookmarkBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Gray, Me.Blue, Me.Orange, Me.Red, Me.Green, Me.Purple, Me.ToolStripSeparator3, Me.BkMrkTwitter, Me.BkMrkFacebook, Me.BkMrkGPlus, Me.BkMrkYouTube, Me.BkMrkGitHub})
        Me.BookmarkBar.Location = New System.Drawing.Point(0, 67)
        Me.BookmarkBar.Name = "BookmarkBar"
        Me.BookmarkBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BookmarkBar.Size = New System.Drawing.Size(1264, 27)
        Me.BookmarkBar.TabIndex = 7
        '
        'Blue
        '
        Me.Blue.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Blue.AutoSize = False
        Me.Blue.BackColor = System.Drawing.Color.Cyan
        Me.Blue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Blue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(20, 20)
        '
        'Orange
        '
        Me.Orange.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Orange.AutoSize = False
        Me.Orange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Orange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Orange.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Orange.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Orange.Name = "Orange"
        Me.Orange.Size = New System.Drawing.Size(20, 20)
        '
        'Red
        '
        Me.Red.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Red.AutoSize = False
        Me.Red.BackColor = System.Drawing.Color.IndianRed
        Me.Red.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Red.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(20, 20)
        '
        'Green
        '
        Me.Green.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Green.AutoSize = False
        Me.Green.BackColor = System.Drawing.Color.LimeGreen
        Me.Green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Green.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(20, 20)
        '
        'Purple
        '
        Me.Purple.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Purple.AutoSize = False
        Me.Purple.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Purple.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Purple.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Purple.Name = "Purple"
        Me.Purple.Size = New System.Drawing.Size(20, 20)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator3.ForeColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        Me.ToolStripSeparator3.Visible = False
        '
        'BkMrkTwitter
        '
        Me.BkMrkTwitter.AutoSize = False
        Me.BkMrkTwitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BkMrkTwitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BkMrkTwitter.Image = CType(resources.GetObject("BkMrkTwitter.Image"), System.Drawing.Image)
        Me.BkMrkTwitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BkMrkTwitter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BkMrkTwitter.Name = "BkMrkTwitter"
        Me.BkMrkTwitter.Size = New System.Drawing.Size(20, 20)
        Me.BkMrkTwitter.Text = "Twitter"
        '
        'BkMrkFacebook
        '
        Me.BkMrkFacebook.AutoSize = False
        Me.BkMrkFacebook.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BkMrkFacebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BkMrkFacebook.Image = CType(resources.GetObject("BkMrkFacebook.Image"), System.Drawing.Image)
        Me.BkMrkFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BkMrkFacebook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BkMrkFacebook.Name = "BkMrkFacebook"
        Me.BkMrkFacebook.Size = New System.Drawing.Size(20, 20)
        Me.BkMrkFacebook.Text = "Facebook"
        '
        'BkMrkGPlus
        '
        Me.BkMrkGPlus.AutoSize = False
        Me.BkMrkGPlus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BkMrkGPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BkMrkGPlus.Image = CType(resources.GetObject("BkMrkGPlus.Image"), System.Drawing.Image)
        Me.BkMrkGPlus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BkMrkGPlus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BkMrkGPlus.Name = "BkMrkGPlus"
        Me.BkMrkGPlus.Size = New System.Drawing.Size(20, 20)
        Me.BkMrkGPlus.Text = "Google+"
        '
        'BkMrkYouTube
        '
        Me.BkMrkYouTube.AutoSize = False
        Me.BkMrkYouTube.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BkMrkYouTube.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BkMrkYouTube.Image = CType(resources.GetObject("BkMrkYouTube.Image"), System.Drawing.Image)
        Me.BkMrkYouTube.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BkMrkYouTube.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BkMrkYouTube.Name = "BkMrkYouTube"
        Me.BkMrkYouTube.Size = New System.Drawing.Size(20, 20)
        Me.BkMrkYouTube.Text = "YouTube"
        '
        'BkMrkGitHub
        '
        Me.BkMrkGitHub.AutoSize = False
        Me.BkMrkGitHub.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BkMrkGitHub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BkMrkGitHub.Image = CType(resources.GetObject("BkMrkGitHub.Image"), System.Drawing.Image)
        Me.BkMrkGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BkMrkGitHub.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BkMrkGitHub.Name = "BkMrkGitHub"
        Me.BkMrkGitHub.Size = New System.Drawing.Size(20, 20)
        Me.BkMrkGitHub.Text = "GitHub"
        '
        'BlackBar3
        '
        Me.BlackBar3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BlackBar3.AutoSize = False
        Me.BlackBar3.BackColor = System.Drawing.Color.DimGray
        Me.BlackBar3.Dock = System.Windows.Forms.DockStyle.None
        Me.BlackBar3.Location = New System.Drawing.Point(-3, 92)
        Me.BlackBar3.Name = "BlackBar3"
        Me.BlackBar3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BlackBar3.Size = New System.Drawing.Size(1270, 4)
        Me.BlackBar3.TabIndex = 8
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 660)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Gray
        '
        Me.Gray.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Gray.AutoSize = False
        Me.Gray.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Gray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Gray.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Gray.Name = "Gray"
        Me.Gray.Size = New System.Drawing.Size(20, 20)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1264, 682)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.BlackBar3)
        Me.Controls.Add(Me.BookmarkBar)
        Me.Controls.Add(Me.BlackBar1)
        Me.Controls.Add(Me.BlackBar2)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BrowserView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1280, 720)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DuckyBrowser PRE-ALPHA v0.1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Tabs.ResumeLayout(False)
        Me.BookmarkBar.ResumeLayout(False)
        Me.BookmarkBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrowserView As System.Windows.Forms.WebBrowser
    Friend WithEvents BackButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents HomeButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ForwardButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SearchBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents BlackBar2 As System.Windows.Forms.ToolStrip
    Friend WithEvents BlackBar1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BookmarkBar As System.Windows.Forms.ToolStrip
    Friend WithEvents BkMrkFacebook As System.Windows.Forms.ToolStripButton
    Friend WithEvents BkMrkTwitter As System.Windows.Forms.ToolStripButton
    Friend WithEvents BkMrkGPlus As System.Windows.Forms.ToolStripButton
    Friend WithEvents BkMrkGitHub As System.Windows.Forms.ToolStripButton
    Friend WithEvents BkMrkYouTube As System.Windows.Forms.ToolStripButton
    Friend WithEvents Blue As System.Windows.Forms.ToolStripButton
    Friend WithEvents Orange As System.Windows.Forms.ToolStripButton
    Friend WithEvents Red As System.Windows.Forms.ToolStripButton
    Friend WithEvents Green As System.Windows.Forms.ToolStripButton
    Friend WithEvents Purple As System.Windows.Forms.ToolStripButton
    Friend WithEvents CnclButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BlackBar3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SrchEngine As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SearchEngBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DuckGo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Google As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Yahoo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Gray As System.Windows.Forms.ToolStripButton

End Class
