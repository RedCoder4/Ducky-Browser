Public Class Form1

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles BrowserView.DocumentCompleted
        SearchBox.Text = BrowserView.Url.ToString
        Me.Text = "Ducky Browser PRE-ALPHA v0.1 - " + BrowserView.DocumentTitle
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

    Private Sub SearchBox_Enter(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles SearchBox.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            BrowserView.Navigate(SearchBox.Text)
            SearchBox.Text = BrowserView.Url.ToString
        End If
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs)
        BrowserView.Navigate(SearchBox.Text)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        BrowserView.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        SearchBox.Width = Me.Width - 180
    End Sub
    Private Sub SearchBox_Click(sender As Object, e As EventArgs) Handles SearchBox.Click
        SearchBox.SelectAll()
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CnclButton.Click

    End Sub
End Class

