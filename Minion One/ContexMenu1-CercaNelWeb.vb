Public Class ContexMenu1_CercaNelWeb
    Private Sub Google_Click(sender As Object, e As EventArgs) Handles Google.Click
        Process.Start("https://www.google.com/search?q=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub Yahoo_Click(sender As Object, e As EventArgs) Handles Yahoo.Click
        Process.Start("https://search.yahoo.com/search;?p=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub Bing_Click(sender As Object, e As EventArgs) Handles Bing.Click
        Process.Start("https://www.bing.com/search?q=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub Wikipedia_Click(sender As Object, e As EventArgs) Handles Wikipedia.Click
        Process.Start("https://en.wikipedia.org/wiki/" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub Yandex_Click(sender As Object, e As EventArgs) Handles Yandex.Click
        Process.Start("https://www.yandex.com/search/?text=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub MSDN_Click(sender As Object, e As EventArgs) Handles MSDN.Click
        Process.Start("https://social.msdn.microsoft.com/Search/en-US?query=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub Baidu_Click(sender As Object, e As EventArgs) Handles Baidu.Click
        Process.Start("https://www.baidu.com/s?wd=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub Ask_Click(sender As Object, e As EventArgs) Handles Ask.Click
        Process.Start("https://it.ask.com/web?q=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub AOL_Click(sender As Object, e As EventArgs) Handles AOL.Click
        Process.Start("https://search.aol.com/aol/search?q=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub Wolframalpha_Click(sender As Object, e As EventArgs) Handles Wolframalpha.Click
        Process.Start("https://www.wolframalpha.com/input/?i=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub

    Private Sub DuckDuckGo_Click(sender As Object, e As EventArgs) Handles DuckDuckGo.Click
        Process.Start("https://duckduckgo.com/?q=" & MyCEF.FastColoredTextBox1.SelectedText.Replace(vbNewLine, " ").Replace(" ", "%20"))
        MyCEF.chiudi_tutti_menu()
    End Sub
End Class