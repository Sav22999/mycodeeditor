Public Class InformazioniF
    Public iniziale As String = ""
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MinionOneSitoLink.LinkClicked
        Process.Start("https://" & MinionOneSitoLink.Text)
    End Sub

    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles ControllaGliAggiornamentiButton.Click
        MyCEF.controlloaggiornamenti_func()
    End Sub

    Private Sub ContattaciButton_Click(sender As Object, e As EventArgs) Handles ContattaciButton.Click
        'GeneraleButton.BackColor = Color.DarkRed
        'LicenzaButton.BackColor = Color.DarkRed
        'TerminiDUsoButton.BackColor = Color.DarkRed
        'ContattaciButton.BackColor = Color.FromArgb(140, 140, 140)

        'GeneralePanel.Visible = False
        'LicenzaPanel.Visible = False
        'TerminiDUsoPanel.Visible = False
        'ContattaciPanel.Visible = True
        Process.Start("https://saveriomorelli.com")
    End Sub

    Private Sub SegnalaUnProblemaButton_Click(sender As Object, e As EventArgs)
        SegnalazioneProblema.Text = MyCEF.TraduzioneLinguaTxt.Lines(541)
        SegnalazioneProblema.NomeCognomeText.Text = MyCEF.TraduzioneLinguaTxt.Lines(542)
        SegnalazioneProblema.EmailText.Text = MyCEF.TraduzioneLinguaTxt.Lines(543)
        SegnalazioneProblema.MotivoText.Text = MyCEF.TraduzioneLinguaTxt.Lines(544)
        SegnalazioneProblema.MessaggioText.Text = MyCEF.TraduzioneLinguaTxt.Lines(545)
        SegnalazioneProblema.Button1.Text = MyCEF.TraduzioneLinguaTxt.Lines(546)
        SegnalazioneProblema.AccettoCondCheck.Text = MyCEF.TraduzioneLinguaTxt.Lines(547) & vbNewLine & MyCEF.TraduzioneLinguaTxt.Lines(548)
        SegnalazioneProblema.Button2.Text = MyCEF.TraduzioneLinguaTxt.Lines(549)
        SegnalazioneProblema.Button48.Text = MyCEF.TraduzioneLinguaTxt.Lines(550)
        SegnalazioneProblema.MotivoText.Text = "Report a problem"
        SegnalazioneProblema.MotivoText.Enabled = False
        SegnalazioneProblema.ShowDialog()
    End Sub

    Private Sub RiconoscimentiButton_Click(sender As Object, e As EventArgs)
        Ringraziamenti.ShowDialog()
    End Sub

    Private Sub LicenzaButton_Click(sender As Object, e As EventArgs) Handles LicenzaButton.Click
        GeneraleButton.BackColor = Color.DarkRed
        LicenzaButton.BackColor = Color.FromArgb(140, 140, 140)
        TerminiDUsoButton.BackColor = Color.DarkRed
        ContattaciButton.BackColor = Color.DarkRed

        GeneralePanel.Visible = False
        LicenzaPanel.Visible = True
        TerminiDUsoPanel.Visible = False
        ContattaciPanel.Visible = False
    End Sub

    Private Sub CondizioniDUsoButton_Click(sender As Object, e As EventArgs) Handles TerminiDUsoButton.Click
        GeneraleButton.BackColor = Color.DarkRed
        LicenzaButton.BackColor = Color.DarkRed
        TerminiDUsoButton.BackColor = Color.FromArgb(140, 140, 140)
        ContattaciButton.BackColor = Color.DarkRed

        GeneralePanel.Visible = False
        LicenzaPanel.Visible = False
        TerminiDUsoPanel.Visible = True
        ContattaciPanel.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://saveriomorelli.com")
    End Sub

    Private Sub InformazioniF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If iniziale = "contact us" Then
            ContattaciButton.PerformClick()
        End If
    End Sub

    Private Sub Copia_LicenzaMenuStrip_Click(sender As Object, e As EventArgs) Handles Copia_LicenzaMenuStrip.Click
        LicenzaTextBox.SelectAll()
        LicenzaTextBox.Copy()
    End Sub

    Private Sub Copia_TerminiDUsoMenuStrip_Click(sender As Object, e As EventArgs) Handles Copia_TerminiDUsoMenuStrip.Click
        TerminiDUsoTextBox.SelectAll()
        TerminiDUsoTextBox.Copy()
    End Sub

    Private Sub GeneraleButton_Click(sender As Object, e As EventArgs) Handles GeneraleButton.Click
        GeneraleButton.BackColor = Color.FromArgb(140, 140, 140)
        LicenzaButton.BackColor = Color.DarkRed
        TerminiDUsoButton.BackColor = Color.DarkRed
        ContattaciButton.BackColor = Color.DarkRed

        GeneralePanel.Visible = True
        LicenzaPanel.Visible = False
        TerminiDUsoPanel.Visible = False
        ContattaciPanel.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Altro_Informazioni.Click
        MyCEF.contattaci_func()
    End Sub

    Private Sub Segnalazione_Informazioni_Click(sender As Object, e As EventArgs) Handles Segnalazione_Informazioni.Click
        MyCEF.segnalazione_func()
    End Sub

    Private Sub RichiediSupporto_Informazioni_Click(sender As Object, e As EventArgs) Handles RichiediSupporto_Informazioni.Click
        MyCEF.supporto_func()
    End Sub

    Private Sub Facebook_Click(sender As Object, e As EventArgs) Handles Facebook.Click
        Process.Start("https://facebook.com/")
    End Sub

    Private Sub Twitter_Click(sender As Object, e As EventArgs) Handles Twitter.Click
        Process.Start("https://twitter.com/")
    End Sub

    Private Sub Youtube_Click(sender As Object, e As EventArgs) Handles Youtube.Click
        Process.Start("https://youtube.com/")
    End Sub

    Private Sub Dailymotion_Click(sender As Object, e As EventArgs) Handles Dailymotion.Click
        Process.Start("https://dailymotion.com/")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://saveriomorelli.com")
    End Sub
End Class