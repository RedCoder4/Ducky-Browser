Public Class Form1

    Dim img1 As Image
    Dim img2 As Image
    Dim img3 As Image
    Dim img4 As Image

    Private Sub SearchBoxEnterDown(sender As Object, e As KeyEventArgs) Handles SearchBox.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            BrowserView.Navigate(SearchBox.Text)
            SearchBox.Text = BrowserView.Url.ToString
        End If
    End Sub

    Private Sub SearchEngBoxEnterDown(sender As Object, e As KeyEventArgs) Handles SearchEngBox.KeyDown
        img1 = DuckGo.Image
        img2 = Google.Image
        img3 = Yahoo.Image
        img4 = Bing.Image

        If (e.KeyCode = Keys.Enter) And SrchEngine.Image Is img1 Then
            BrowserView.Navigate("https://duckduckgo.com/?q=" + SearchEngBox.Text)
            SearchBox.Text = BrowserView.Url.ToString
        End If

        If (e.KeyCode = Keys.Enter) And SrchEngine.Image Is img2 Then
            BrowserView.Navigate("https://www.google.com/?gws_rd=ssl#q=" + SearchEngBox.Text)
            SearchBox.Text = BrowserView.Url.ToString
        End If

        If (e.KeyCode = Keys.Enter) And SrchEngine.Image Is img3 Then
            BrowserView.Navigate("https://search.yahoo.com/search;_ylt=?p=" + SearchEngBox.Text)
            SearchBox.Text = BrowserView.Url.ToString
        End If

        If (e.KeyCode = Keys.Enter) And SrchEngine.Image Is img4 Then
            BrowserView.Navigate("http://www.bing.com/search?q=" + SearchEngBox.Text)
            SearchBox.Text = BrowserView.Url.ToString
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles BrowserView.DocumentCompleted
        Me.Text = "Ducky Browser PRE-ALPHA v0.1 - " + BrowserView.DocumentTitle
        SearchBox.Text = BrowserView.Url.ToString
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        BrowserView.GoBack()
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        BrowserView.GoForward()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        BrowserView.Navigate("http://duckduckgo.com/")
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs)
        BrowserView.Navigate(SearchBox.Text)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        BrowserView.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        img1 = DuckGo.Image

        SrchEngine.Image = img1
    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        BrowserView.Refresh()
    End Sub
    Private Sub ToolStripButton7_Click_1(sender As Object, e As EventArgs) Handles BkMrkFacebook.Click
        BrowserView.Navigate("http://www.facebook.com/")
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles BkMrkTwitter.Click
        BrowserView.Navigate("http://www.twitter.com/")
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles BkMrkGPlus.Click
        BrowserView.Navigate("http://plus.google.com/")
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles BkMrkGitHub.Click
        BrowserView.Navigate("http://www.github.com/")
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles BkMrkYouTube.Click
        BrowserView.Navigate("http://youtube.com/")
    End Sub

    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles Purple.Click
        Me.BackColor = Color.DarkMagenta
        ToolStrip1.BackColor = Color.Orchid
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles Green.Click
        Me.BackColor = Color.Green
        ToolStrip1.BackColor = Color.LimeGreen
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles Red.Click
        Me.BackColor = Color.Red
        ToolStrip1.BackColor = Color.IndianRed
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles Orange.Click
        Me.BackColor = Color.DarkOrange
        ToolStrip1.BackColor = Color.Orange
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles Blue.Click
        Me.BackColor = Color.DarkTurquoise
        ToolStrip1.BackColor = Color.Cyan
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SearchBox.Width = Me.Width - 340
    End Sub

    Private Sub SearchBox_Click(sender As Object, e As EventArgs) Handles SearchBox.Click
        SearchBox.SelectAll()
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CnclButton.Click

    End Sub

    Private Sub DuckGo_Click(sender As Object, e As EventArgs) Handles DuckGo.Click
        img1 = DuckGo.Image

        SrchEngine.Image = img1
    End Sub

    Private Sub Google_Click(sender As Object, e As EventArgs) Handles Google.Click
        img2 = Google.Image

        SrchEngine.Image = img2
    End Sub

    Private Sub Yahoo_Click(sender As Object, e As EventArgs) Handles Yahoo.Click
        img3 = Yahoo.Image

        SrchEngine.Image = img3
    End Sub

    Private Sub Bing_Click(sender As Object, e As EventArgs) Handles Bing.Click
        img4 = Bing.Image

        SrchEngine.Image = img4
    End Sub

    Private Sub SearchEngBox_Click(sender As Object, e As EventArgs) Handles SearchEngBox.Click
        SearchEngBox.SelectAll()
    End Sub

    Private Sub Gray_Click(sender As Object, e As EventArgs) Handles Gray.Click
        Me.BackColor = Color.DarkGray
        ToolStrip1.BackColor = Color.Gainsboro
    End Sub
End Class