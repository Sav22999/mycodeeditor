Public Class WebBrowser

    Private Sub ButtonIndietroAnteprima_Click(sender As Object, e As EventArgs) Handles ButtonIndietroAnteprima.Click
        If WebBrowser2.CanGoBack Then
            WebBrowser2.GoBack()
        Else
            WebBrowser2.DocumentText = (MinionOne.FastColoredTextBox1.Text)
        End If
    End Sub

    Private Sub ButtonAvantiAnteprima_Click(sender As Object, e As EventArgs) Handles ButtonAvantiAnteprima.Click
        WebBrowser2.GoForward()
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        If WebBrowser2.DocumentTitle = ("") Then
            Me.Text = ("Senza titolo")
        Else
            Me.Text = (WebBrowser2.DocumentTitle & " - Minion One")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.webbrowserfinestranormaletopmost = ("si") Then
            Button1.Image = (My.Resources.xchiudi1)
            Me.TopMost = False
            My.Settings.webbrowserfinestranormaletopmost = ("no")
            My.Settings.Save()
        Else
            Me.TopMost = True
            Button1.Image = (My.Resources.okapplica1)
            My.Settings.webbrowserfinestranormaletopmost = ("si")
            My.Settings.Save()
        End If
    End Sub

    Private Sub WebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.webbrowserfinestranormaletopmost = ("no") Then
            Button1.Image = (My.Resources.xchiudi1)
            Me.TopMost = False
        Else
            Button1.Image = (My.Resources.okapplica1)
            Me.TopMost = True
        End If
    End Sub
End Class