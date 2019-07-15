Public Class Aiuto
    Public k As String
    Private Sub NovitaButton_Click(sender As Object, e As EventArgs) Handles NovitaButton.Click
        Novita.ShowDialog()
    End Sub

    Private Sub CercaTextBox_GotFocus(sender As Object, e As EventArgs) Handles CercaTextBox.GotFocus
        If (CercaTextBox.Text = "Cerca nel centro aiuto..." And CercaTextBox.ForeColor = Color.Red) Then
            CercaTextBox.ForeColor = Color.WhiteSmoke
            CercaTextBox.Text = ("")
        End If
    End Sub

    Private Sub CercaTextBox_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles CercaTextBox.HelpRequested

    End Sub

    Private Sub CercaTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CercaTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            CercaButton.PerformClick()
        End If
    End Sub

    Private Sub CercaTextBox_LostFocus(sender As Object, e As EventArgs) Handles CercaTextBox.LostFocus
        If CercaTextBox.Text = ("") Or CercaTextBox.Text.Replace(" ", "") = "" Then
            CercaTextBox.ForeColor = Color.Red
            CercaTextBox.Text = ("Cerca nel centro aiuto...")
        End If
    End Sub

    Private Sub TutorialButton_Click(sender As Object, e As EventArgs) Handles TutorialButton.Click
        CercaTextBox.ForeColor = Color.Red
        CercaTextBox.Text = ("Cerca nel centro aiuto...")
        TutorialButton.BackColor = Color.DimGray
        PrimoAvvioButton.BackColor = Color.DarkRed
        ApriNelSito.Visible = False
        TutorialPanel.Visible = True
        PrimoAvvioPanel.Visible = False
        RicercaPanel.Visible = False
    End Sub

    Private Sub PrimoAvvioButton_Click(sender As Object, e As EventArgs) Handles PrimoAvvioButton.Click
        CercaTextBox.ForeColor = Color.Red
        CercaTextBox.Text = ("Cerca nel centro aiuto...")
        TutorialButton.BackColor = Color.DarkRed
        PrimoAvvioButton.BackColor = Color.DimGray
        ApriNelSito.Visible = False
        TutorialPanel.Visible = False
        PrimoAvvioPanel.Visible = True
        RicercaPanel.Visible = False
    End Sub

    Private Sub CercaTextBox_TextChanged(sender As Object, e As EventArgs) Handles CercaTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CercaTextBox.ForeColor = Color.Red
        CercaTextBox.Text = ("Cerca nel centro aiuto...")
        TutorialButton.BackColor = Color.DarkRed
        PrimoAvvioButton.BackColor = Color.DarkRed
        TutorialPanel.Visible = False
        PrimoAvvioPanel.Visible = False
        RicercaPanel.Visible = True
        CercaOnlineNORESULT.Visible = False
        ApriNelSito.Visible = False
        CodiceErroreText.Text = ("Minion One Error (MOE)")
        DescrizioneErroreText.Text = ("Gli errori di Minion One verranno tutti descritti, gestiti e verranno mostrate delle possibili soluzioni agli stessi." & vbNewLine & "Se si dovessero verificare errori NON descritti, preghiamo di contattare il supporto, che è completamente gratuito.")
    End Sub

    Private Sub CercaButton_Click(sender As Object, e As EventArgs) Handles CercaButton.Click
        TutorialButton.BackColor = Color.DarkRed
        PrimoAvvioButton.BackColor = Color.DarkRed
        TutorialPanel.Visible = False
        PrimoAvvioPanel.Visible = False
        RicercaPanel.Visible = True
        CercaOnlineNORESULT.Visible = False
        ApriNelSito.Visible = True
        k = CercaTextBox.Text
        k = k.ToUpper
        If Not k = "CERCA NEL CENTRO AIUTO..." And Not k.Replace(" ", "") = "" Then
            Select Case k
                'Case "MOA3BZS72N2"
                '    CodiceErroreText.Text = k
                '    DescrizioneErroreText.Text = ("Un bottone è un elemento html." & vbNewLine & "La corretta sintassi è la seguente:" & vbNewLine & "<input type=" & Chr(34) & "button" & Chr(34) & " value=" & Chr(34) & "..." & Chr(34) & " >")
                'Case "MOA0STQ19R4"
                '    CodiceErroreText.Text = k
                '    DescrizioneErroreText.Text = ("Un commento NON è visibile sulla pagina web, ma solamente vedendo il codice di essa." & vbNewLine & "La sinstassi per inserire un testo come commento è la seguente:" & vbNewLine & "<!---- ... ---->")
                'Case "MOA6CNK12C7"
                '    CodiceErroreText.Text = k
                '    DescrizioneErroreText.Text = ("")
                Case "MOE7CCZ62M3"
                    CodiceErroreText.Text = k & " - Errore di connessione"
                    DescrizioneErroreText.Text = ("Non è stato possibile stabilire una connessione ad internet. Preghiamo di controllare il wifi, o in caso di cavo di controllare il corretto funzionamento.")
                Case "MOE2NCS79G7"
                    CodiceErroreText.Text = k & " - Errore di file"
                    DescrizioneErroreText.Text = ("Si è verificato un errore inaspettato nel caricamento del file. Riprovare o contattare il supporto.")
                Case "MOE1AZA62R1"
                    CodiceErroreText.Text = k & " - Errore di salvataggio"
                    DescrizioneErroreText.Text = ("Non è stato trovato il percorso file selezionato per il salvataggio del progetto. Verificare che sia esistente, quindi modificarlo se non lo è.")
                Case "MOE2ZCE41D9"
                    CodiceErroreText.Text = k & " - Errore di creazione HTML"
                    DescrizioneErroreText.Text = ("Si è verificato un errore inaspettato durante la creazione del progetto HTML. Riprovare o contattare il supporto.")
                Case "MOE5DEM66L4"
                    CodiceErroreText.Text = k & " - Errore di creazione CSS"
                    DescrizioneErroreText.Text = ("Si è verificato un errore inaspettato durante la creazione del progetto HTML + Foglio di stile (CSS). Riprovare o contattare il supporto.")
                Case "MOE7CMC88J0"
                    CodiceErroreText.Text = k & " - File non supportato"
                    DescrizioneErroreText.Text = ("Il file aperto non è supportato da Minion One pertanto potrebbe non essere aperto correttamente. Ricordare che Minion One supporta solo file HTML o HTML + CSS (il file css deve chiamarsi necessariamente uguale al file html e deve stare nella stessa cartella di quest'ultimo).")
                Case "MOE2YLN17D1"
                    CodiceErroreText.Text = k & " - Errore di salvataggio impostazioni"
                    DescrizioneErroreText.Text = ("Il file contenente le impostazioni è danneggiato o è inesistente, quindi potrebbe essere stato eliminato. Si consiglia, pertanto, di riavviare Minion One in modo tale che le stesse possano essere ripristinate a quelle predefinite.")
                Case "MOE5IRC14C3"
                    CodiceErroreText.Text = k & " - File inesistente"
                    DescrizioneErroreText.Text = ("Il file selezionato come web browser personalizzato è inesistente, per favore, provare con uno valido.")
                Case "MOE1HQG94M8"
                    CodiceErroreText.Text = k & " - File URI non supportati"
                    DescrizioneErroreText.Text = ("Il file che si sta tentando di aprire non è supportato da Minion One e pertanto non può essere aperto. Errore inaspettato nell'apertura del file o del file stesso.")
                Case "MOE2GBW85N6"
                    CodiceErroreText.Text = k & " - File non trovato"
                    DescrizioneErroreText.Text = ("Il file non è stato trovato pertanto potrebbe essere stato spostato, eliminato o potrebbe essere danneggiato.")
                Case "MOE1UXW79F4"
                    CodiceErroreText.Text = k & " - Impostazioni danneggiate"
                    DescrizioneErroreText.Text = ("Si è verificato un errore nel caricamento delle impostazioni. Verranno ripristinate, pertanto le impostazioni predefinite perdendo quindi tutte le preferenze.")
                    'Case ""
                    '    CodiceErroreText.Text = k & " - "
                    '    DescrizioneErroreText.Text = ("")
                Case Else
                    CercaOnlineNORESULT.Visible = True
                    CodiceErroreText.Text = ("NESSUN RISULTATO")
                    DescrizioneErroreText.Text = ("")
                    ApriNelSito.Visible = False
            End Select
        Else
            Button1.PerformClick()
            ApriNelSito.Visible = False
        End If
    End Sub

    Private Sub CercaOnlineNORISULT_Click(sender As Object, e As EventArgs) Handles CercaOnlineNORESULT.Click
        k = k.ToLower
        Process.Start("http://www.minionone.altervista.org/Wiki/?s=" & k)
    End Sub

    Private Sub Aiuto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CodiceErroreText.Text = ("Minion One Error (MOE)")
        DescrizioneErroreText.Text = ("Gli errori di Minion One verranno tutti descritti, gestiti e verranno mostrate delle possibili soluzioni agli stessi." & vbNewLine & "Se si dovessero verificare errori NON descritti, preghiamo di contattare il supporto, che è completamente gratuito.")
    End Sub

    Private Sub VideoPrimoAvvio1_Click(sender As Object, e As EventArgs) Handles VideoPrimoAvvio1.Click
        Process.Start("http://www.minionone.altervista.org/Wiki/?s=benvenuto")
    End Sub

    Private Sub VideoPrimoAvvio3_Click(sender As Object, e As EventArgs) Handles VideoPrimoAvvio3.Click
        Process.Start("http://www.minionone.altervista.org/Wiki/?s=come+creare+un+nuovo+progetto")
    End Sub

    Private Sub VideoPrimoAvvio2_Click(sender As Object, e As EventArgs) Handles VideoPrimoAvvio2.Click
        Process.Start("http://www.minionone.altervista.org/Wiki/?s=come+capire+minion+one")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        CercaTextBox.SelectAll()
        CercaTextBox.Copy()
    End Sub

    Private Sub IncollaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem.Click
        If (CercaTextBox.Text = "Cerca nel centro aiuto..." And CercaTextBox.ForeColor = Color.Red) Then
            CercaTextBox.ForeColor = Color.WhiteSmoke
            CercaTextBox.Text = ("")
        End If
        CercaTextBox.SelectAll()
        CercaTextBox.Clear()
        CercaTextBox.Paste()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("http://www.minionone.altervista.org/Wiki/?s=come+capire+minion+one")
    End Sub

    Private Sub ApriNelSito_Click(sender As Object, e As EventArgs) Handles ApriNelSito.Click
        Process.Start("http://www.minionone.altervista.org/Wiki/?s=" & CercaTextBox.Text)
    End Sub
End Class