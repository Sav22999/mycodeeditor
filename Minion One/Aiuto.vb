Public Class Aiuto
    Private Sub NovitaButton_Click(sender As Object, e As EventArgs) Handles NewsButton.Click
        'Novita.ShowDialog()
        Dim currentversion As String = Application.ProductVersion
        currentversion = currentversion.Replace(".", "-")
        Process.Start("https://www.saveriomorelli.com/mycodeeditor/News/" & currentversion & "/")
    End Sub

    Private Sub Cerca_Button_TextBox_Click(sender As Object, e As EventArgs) Handles Cerca_Button_TextBox.Click
        If Cerca_Button_TextBox.Text = MyCEF.TraduzioneLinguaTxt.Lines(132) Then
            Cerca_Button_TextBox.Text = ""
        End If
        Cerca_TextBox.Visible = True
        Cerca_TextBox.Text = Cerca_Button_TextBox.Text

        Cerca_Button_TextBox.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
        Cerca_Button_TextBox.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke

        Cerca_TextBox.Select()
    End Sub

    Private Sub Cerca_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Cerca_TextBox.TextChanged

    End Sub

    Private Sub Cerca_TextBox_Leave(sender As Object, e As EventArgs) Handles Cerca_TextBox.Leave
        Cerca_TextBox.Visible = False
        Cerca_Button_TextBox.Text = Cerca_TextBox.Text
        If Cerca_Button_TextBox.Text.Replace(" ", "") = "" Then
            Cerca_Button_TextBox.Text = MyCEF.TraduzioneLinguaTxt.Lines(132)
        End If

        Cerca_Button_TextBox.FlatAppearance.MouseDownBackColor = Color.Silver
        Cerca_Button_TextBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        HomeButton.BackColor = Color.FromArgb(140, 140, 140)
        CercaButton.BackColor = Color.DarkRed

        HomePanel.Visible = True
        CercaPanel.Visible = False
    End Sub

    Private Sub CercaButton_Click(sender As Object, e As EventArgs) Handles CercaButton.Click
        HomeButton.BackColor = Color.DarkRed
        CercaButton.BackColor = Color.FromArgb(140, 140, 140)

        HomePanel.Visible = False
        CercaPanel.Visible = True
    End Sub

    Private Sub Cerca_Button_Click(sender As Object, e As EventArgs) Handles Cerca_Button.Click
        If Not Cerca_TextBox.Text.Replace(" ", "") = "" And Not Cerca_Button_TextBox.Text.Replace(" ", "") = "" And Not Cerca_Button_TextBox.Text = MyCEF.TraduzioneLinguaTxt.Lines(132) Then
            Process.Start("https://www.saveriomorelli.com/mycodeeditor/search/?s=" & Cerca_Button_TextBox.Text.Replace(" ", "%20"))
        End If
    End Sub

    Private Sub GetStarted_Button_Click(sender As Object, e As EventArgs) Handles GetStarted_Button.Click
        Process.Start("https://www.saveriomorelli.com/mycodeeditor/Support/?k=get%20started")
    End Sub

    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Process.Start("https://www.saveriomorelli.com/mycodeeditor/Support/?k=update%20and%20install")
    End Sub

    Private Sub ManageSettings_Button_Click(sender As Object, e As EventArgs) Handles ManageSettings_Button.Click
        Process.Start("https://www.saveriomorelli.com/mycodeeditor/Support/?k=manage%20settings")
    End Sub

    Private Sub FixProblems_Button_Click(sender As Object, e As EventArgs) Handles FixProblems_Button.Click
        Process.Start("https://www.saveriomorelli.com/mycodeeditor/Support/?k=fix%20problems")
    End Sub

    Private Sub Privacy_Button_Click(sender As Object, e As EventArgs) Handles Privacy_Button.Click
        Process.Start("https://www.saveriomorelli.com/mycodeeditor/Support/?k=privacy")
    End Sub

    Private Sub ContactUs_Button_Click(sender As Object, e As EventArgs) Handles ContactUs_Button.Click
        InformazioniF.iniziale = "contact us"
        MyCEF.informazioni_func()
    End Sub

    Private Sub GoToWebSite_Button_Click(sender As Object, e As EventArgs) Handles GoToWebSite_Button.Click
        Process.Start("https://www.saveriomorelli.com/mycodeeditor/Support/")
    End Sub

    Private Sub GuideButton_Click(sender As Object, e As EventArgs) Handles GuidaButton.Click
        Process.Start("https://www.saveriomorelli.com/mycodeeditor/Guide/")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Cerca_TextBox.Copy()
    End Sub

    Private Sub IncollaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem.Click
        Cerca_TextBox.Paste()
    End Sub

    Private Sub Search_Button_Click(sender As Object, e As EventArgs) Handles Search_Button.Click
        CercaButton.PerformClick()
    End Sub

    Private Sub Guide_Button_Click(sender As Object, e As EventArgs) Handles Guide_Button.Click
        GuidaButton.PerformClick()
    End Sub

    Private Sub News_Button_Click(sender As Object, e As EventArgs) Handles News_Button.Click
        NewsButton.PerformClick()
    End Sub
End Class