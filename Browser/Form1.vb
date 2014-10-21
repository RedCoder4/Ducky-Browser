Public Class Form1

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        SearchBox.Text = WebBrowser1.Url.ToString
        Me.Text = "Ducky Browser PRE-ALPHA v0.1 - " + WebBrowser1.DocumentTitle
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        WebBrowser1.Navigate("http://duckduckgo.com/")
    End Sub

    Private Sub SearchBox_Enter(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles SearchBox.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            WebBrowser1.Navigate(SearchBox.Text)
            SearchBox.Text = WebBrowser1.Url.ToString
        End If
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs)
        WebBrowser1.Navigate(SearchBox.Text)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        WebBrowser1.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        WebBrowser1.Refresh()
    End Sub
    Private Sub ToolStripButton7_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        WebBrowser1.Navigate("http://www.facebook.com/")
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        WebBrowser1.Navigate("http://www.twitter.com/")
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        WebBrowser1.Navigate("http://plus.google.com/")
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        WebBrowser1.Navigate("http://www.github.com/")
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        WebBrowser1.Navigate("http://youtube.com/")
    End Sub

    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles ToolStripButton16.Click
        Me.BackColor = Color.DarkMagenta
        ToolStrip1.BackColor = Color.Orchid
    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        Me.BackColor = Color.Green
        ToolStrip1.BackColor = Color.LimeGreen
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        Me.BackColor = Color.Red
        ToolStrip1.BackColor = Color.IndianRed
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        Me.BackColor = Color.DarkOrange
        ToolStrip1.BackColor = Color.Orange
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Me.BackColor = Color.DarkTurquoise
        ToolStrip1.BackColor = Color.Cyan
    End Sub
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SearchBox.Width = Me.Width - 180
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class

