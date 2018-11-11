Public Class NuovoProgettoEFoglioDiStile

    Private Sub AnteprimaButtonR_Click(sender As Object, e As EventArgs) Handles AnteprimaButtonR.Click
        Try
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\") Then
                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\")
            End If
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\")
            End If
            IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\", IO.FileAttributes.Hidden)
            If ((TextBox9.Text = MyCEF.TraduzioneLinguaTxt.Lines(510) And TextBox9.ForeColor = Color.DarkGray) Or TextBox9.Text.Replace(" ", "") = "") Then
                'TextBox9.BackColor = Color.Red
                Timer1.Start()
            ElseIf ((TextBox1.Text = MyCEF.TraduzioneLinguaTxt.Lines(777) And TextBox1.ForeColor = Color.DarkGray) Or TextBox1.Text.Replace(" ", "") = "") Then
                Timer2.Start()
            End If
            If Not (((TextBox9.Text = MyCEF.TraduzioneLinguaTxt.Lines(510) And TextBox9.ForeColor = Color.DarkGray) Or TextBox9.Text.Replace(" ", "") = "") Or ((TextBox1.Text = MyCEF.TraduzioneLinguaTxt.Lines(777) And TextBox1.ForeColor = Color.DarkGray) Or TextBox1.Text.Replace(" ", "") = "")) Then
                If My.Computer.FileSystem.DirectoryExists(TextBox1.Text) Then
                    If Not System.IO.File.Exists(TextBox1.Text & TextBox9.Text & ".html") And Not System.IO.File.Exists(TextBox1.Text & TextBox9.Text & ".css") Then
                        System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", "")
                        System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".css", "")
                        MyCEF.FileButton.Enabled = True
                        MyCEF.ModificaButton.Enabled = True
                        MyCEF.VisualizzaButton.Enabled = True
                        MyCEF.InserisciButton.Enabled = True
                        MyCEF.InserisciToolStripMenuItem1.Enabled = True
                        MyCEF.MCEButton.Enabled = True
                        MyCEF.ProgettazioneButtonR.Enabled = True
                        MyCEF.AnteprimaButtonR.Enabled = True
                        MyCEF.FastColoredTextBox1.ReadOnly = False
                        MyCEF.FastColoredTextBox1.Select()
                        MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

                        MyCEF.buttproghtml.Text = (MyCEF.TraduzioneLinguaTxt.Lines(10))
                        MyCEF.buttproghtml.Visible = True
                        MyCEF.buttproghtml.Enabled = True
                        MyCEF.buttprogcss.Visible = True
                        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
                        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
                        MyCEF.CSSSIoNOtb.Text = ("si")

                        Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", Avvio.recente6butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
                        Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", Avvio.recente5butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
                        Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", Avvio.recente4butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
                        Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", Avvio.recente3butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
                        Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", Avvio.recente2butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
                        Avvio.recente1butt.Text = (TextBox9.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", Avvio.recente1butt.Text)
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", TextBox1.Text & TextBox9.Text & ".html")
                        MyCEF.Text = (TextBox9.Text & " • My Code Editor")
                        MyCEF.TitoloProg.Text = TextBox9.Text
                        MyCEF.EstensioneFile = "html"
                        MyCEF.percorsoSALVATAGGIO.Text = TextBox1.Text
                        MyCEF.PercorsoFileButton.Text = TextBox1.Text
                        MyCEF.PercorsoFileHTML = MyCEF.percorsoSALVATAGGIO.Text & TextBox9.Text & ".html"
                        MyCEF.PercorsoFileCSS = MyCEF.percorsoSALVATAGGIO.Text & TextBox9.Text & ".css"
                        MyCEF.FastColoredTextBox1.Text = ("<html>" & vbNewLine & "<head>" & vbNewLine & vbTab & "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & "type=" & Chr(34) & "text/css" & Chr(34) & "media=" & Chr(34) & "all" & Chr(34) & " href=" & Chr(34) & "file:\\\" & (TextBox1.Text & TextBox9.Text & ".css") & Chr(34) & " />" & vbNewLine & "</head>" & vbNewLine & "<body>" & vbNewLine & vbTab & vbNewLine & "</body>" & vbNewLine & "</html>")
                        System.IO.File.WriteAllText(MyCEF.PercorsoFileHTML, MyCEF.FastColoredTextBox1.Text)
                        MyCEF.buttproghtml.Text = (MyCEF.TraduzioneLinguaTxt.Lines(10))
                        MyCEF.buttprogcss.Text = (MyCEF.TraduzioneLinguaTxt.Lines(11))
                        MyCEF.Button5.Text = (Now.Hour & ":" & Now.Minute)
                        Avvio.Close()
                        MyCEF.FastColoredTextBox1.ClearUndo()

                        MyCEF.verifica_percorso()

                        Me.Close()
                    Else
                        Timer1.Start()
                        MessaggioF.Text = ("Progetto già esistente")
                        MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Esiste già un progetto con lo stesso nome." & vbNewLine & "Cambiare il nome per poterne creare un nuovo.")
                        MessaggioF.DettagliErroreButton.Visible = False
                        MessaggioF.ErroreTxt.Text = ("MCEEAA0023")
                        MessaggioF.ShowDialog()
                    End If
                Else
                    MessaggioF.Text = ("Percorso inesistente")
                    MessaggioF.Button1.Text = ("Attenzione: " & vbNewLine & "Il percorso selezionato è inesistente." & vbNewLine & "Per favore, scegline uno esistente.")
                    MessaggioF.DettagliErroreButton.Visible = False
                    MessaggioF.ErroreTxt.Text = ("MCEEAA0022")
                    MessaggioF.ShowDialog()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaToolStripMenuItem.Click
        TextBox1.SelectAll()
        TextBox1.Copy()
        TextBox1.ForeColor = Color.DarkRed
        TextBox1.Select()
    End Sub

    Private Sub IncollaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem1.Click
        TextBox1.SelectAll()
        TextBox1.Paste()
        TextBox1.ForeColor = Color.DarkRed
        TextBox1.Select()
    End Sub

    Private Sub EliminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminaToolStripMenuItem.Click
        TextBox1.SelectAll()
        TextBox1.Clear()
        TextBox1.ForeColor = Color.DarkRed
        TextBox1.Select()
    End Sub

    Private Sub NuovoProgetto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\") Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\")
        End If
        Dim linea(0) As String
        linea(0) = MyCEF.ImpostazioniTxt.Lines(21).Replace("PERCORSO PREDEFINITO DEI PROGETTI - [[", "")
        linea(0) = linea(0).Replace("]]", "")
        If linea(0) = "##DEFAULT##" Then
            TextBox1.Text = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\")
        Else
            TextBox1.Text = linea(0)
            If Not My.Computer.FileSystem.DirectoryExists(TextBox1.Text) Then
                TextBox1.Text = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\")
                Impostazioni.AvanzatePercorsoRadio0.Checked = True
                Impostazioni.AvanzatePercorsoRadio1.Checked = False
            End If
        End If
        FolderBrowserDialog1.SelectedPath = TextBox1.Text
        TextBox9.Select()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub

    Private Sub TextBox9_Click(sender As Object, e As EventArgs) Handles TextBox9.Click
        'TextBox9.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox9_GotFocus(sender As Object, e As EventArgs) Handles TextBox9.GotFocus
        If (TextBox9.Text = MyCEF.TraduzioneLinguaTxt.Lines(510) And TextBox9.ForeColor = Color.DarkGray) Then
            TextBox9.ForeColor = Color.DarkRed
            TextBox9.Text = ("")
        End If
    End Sub

    Private Sub TextBox9_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            AnteprimaButtonR.PerformClick()
            'If ((TextBox9.Text = "Nome progetto" And TextBox9.ForeColor = Color.DarkGray) Or TextBox9.Text.Replace(" ", "") = "") Then
            '    'TextBox9.BackColor = Color.Red
            '    Timer1.Start()
            'ElseIf TextBox1.Text = "" Then
            '    Timer2.Start()
            'Else
            '    If Dir(TextBox1.Text) <> "" Then
            '        If Dir(TextBox1.Text & TextBox9.Text & ".html") = "" And Dir(TextBox1.Text & TextBox9.Text & ".css") = "" Then
            '            If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\") = "" Then
            '                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
            '                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\")
            '            End If
            '            System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", "")
            '            System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".css", "")
            '            MyCEF.FileButton.Enabled = True
            '            MyCEF.ModificaButton.Enabled = True
            '            MyCEF.VisualizzaButton.Enabled = True
            '            MyCEF.InserisciButton.Enabled = True
            '            MyCEF.MinionOneButton.Enabled = True
            '            MyCEF.ProgettazioneButtonR.Enabled = True
            '            MyCEF.AnteprimaButtonR.Enabled = True
            '            MyCEF.FastColoredTextBox1.ReadOnly = False
            '            MyCEF.FastColoredTextBox1.Select()
            '            MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

            '            MyCEF.buttprogling.Text = (TraduzioneLinguaTxt.Lines(10))
            '            MyCEF.buttprogling.Enabled = True
            '            MyCEF.buttprogcss.Visible = True
            '            MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
            '            MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
            '            MyCEF.CSSSIoNOtb.Text = ("si")

            '            Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", Avvio.recente6butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            '            Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", Avvio.recente5butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            '            Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", Avvio.recente4butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            '            Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", Avvio.recente3butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            '            Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", Avvio.recente2butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
            '            Avvio.recente1butt.Text = (TextBox9.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", Avvio.recente1butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", TextBox1.Text & TextBox9.Text & ".html")
            '            MyCEF.Text = (Avvio.recente1butt.Text & " - My Code Editor")
            '            MyCEF.TitoloProg.Text = (TextBox9.Text)
            '            MyCEF.PercorsoFileButton.Text = (TextBox1.Text & TextBox9.Text & ".html")
            '            MyCEF.FastColoredTextBox1.Text = "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & "type=" & Chr(34) & "text/css" & Chr(34) & "media=" & Chr(34) & "all" & Chr(34) & " href=" & Chr(34) & "file:\\\" & (TextBox1.Text & TextBox9.Text & ".css") & Chr(34) & " />"
            '            System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", MyCEF.FastColoredTextBox1.Text)
            '            MyCEF.buttprogling.Text = (TraduzioneLinguaTxt.Lines(10))
            '            MyCEF.buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
            '            MyCEF.Button5.Text = ( Now.Hour & ":" & Now.Minute)
            '            Avvio.Close()

            '            Me.Close()
            '        Else
            '            Timer1.Start()
            '            MessaggioF.Text = ("Progetto già esistente")
            '            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Esiste già un progetto con lo stesso nome." & vbNewLine & "Cambiare il nome per poterne creare un nuovo.")
            '            MessaggioF.ShowDialog()
            '        End If
            '    Else
            '        MessaggioF.Text = ("Percorso di salvataggio inesistente")
            '        MessaggioF.Button1.Text = ("Attenzione: " & vbNewLine & "Il percorso selezionato è inesistente." & vbNewLine & "Per favore, scegline uno esistente.")
            '        MessaggioF.ShowDialog()
            '    End If
            'End If
        End If
    End Sub

    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        If TextBox9.Text = ("") Or TextBox9.Text.Replace(" ", "") = "" Then
            TextBox9.ForeColor = Color.DarkGray
            TextBox9.Text = MyCEF.TraduzioneLinguaTxt.Lines(510)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timertxt.Text = ("0") Then
            TextBox9.BackColor = Color.Red
            timertxt.Text += 1
        ElseIf timertxt.Text = ("1") Then
            TextBox9.BackColor = Color.WhiteSmoke
            timertxt.Text += 1
        ElseIf timertxt.Text = ("2") Then
            TextBox9.BackColor = Color.Red
            timertxt.Text += 1
        ElseIf timertxt.Text = ("3") Then
            TextBox9.BackColor = Color.WhiteSmoke
            timertxt.Text = ("0")
            If ((TextBox1.Text = MyCEF.TraduzioneLinguaTxt.Lines(777) And TextBox1.ForeColor = Color.DarkGray) Or TextBox1.Text.Replace(" ", "") = "") Then
                Timer2.Start()
            End If
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub AnteprimaButtonR_KeyDown(sender As Object, e As KeyEventArgs) Handles AnteprimaButtonR.KeyDown

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            AnteprimaButtonR.PerformClick()
            'If ((TextBox9.Text = "Nome progetto" And TextBox9.ForeColor = Color.DarkGray) Or TextBox9.Text.Replace(" ", "") = "") Then
            '    'TextBox9.BackColor = Color.Red
            '    Timer1.Start()
            'ElseIf TextBox1.Text = "" Then
            '    Timer2.Start()
            'Else
            '    If Dir(TextBox1.Text) <> "" Then
            '        If Dir(TextBox1.Text & TextBox9.Text & ".html") = "" And Dir(TextBox1.Text & TextBox9.Text & ".css") = "" Then
            '            If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\") = "" Then
            '                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
            '                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Progetti\")
            '            End If
            '            System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", "")
            '            System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".css", "")
            '            MyCEF.FileButton.Enabled = True
            '            MyCEF.ModificaButton.Enabled = True
            '            MyCEF.VisualizzaButton.Enabled = True
            '            MyCEF.InserisciButton.Enabled = True
            '            MyCEF.MinionOneButton.Enabled = True
            '            MyCEF.ProgettazioneButtonR.Enabled = True
            '            MyCEF.AnteprimaButtonR.Enabled = True
            '            MyCEF.FastColoredTextBox1.ReadOnly = False
            '            MyCEF.FastColoredTextBox1.Select()
            '            MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

            '            MyCEF.buttprogling.Text = (TraduzioneLinguaTxt.Lines(10))
            '            MyCEF.buttprogling.Enabled = True
            '            MyCEF.buttprogcss.Visible = True
            '            MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
            '            MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
            '            MyCEF.CSSSIoNOtb.Text = ("si")

            '            Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", Avvio.recente6butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            '            Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", Avvio.recente5butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            '            Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", Avvio.recente4butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            '            Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", Avvio.recente3butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            '            Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", Avvio.recente2butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
            '            Avvio.recente1butt.Text = (TextBox9.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", Avvio.recente1butt.Text)
            '            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", TextBox1.Text & TextBox9.Text & ".html")
            '            MyCEF.Text = (Avvio.recente1butt.Text & " - My Code Editor")
            '            MyCEF.TitoloProg.Text = (TextBox9.Text)
            '            MyCEF.PercorsoFileButton.Text = (TextBox1.Text & TextBox9.Text & ".html")
            '            MyCEF.FastColoredTextBox1.Text = "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & "type=" & Chr(34) & "text/css" & Chr(34) & "media=" & Chr(34) & "all" & Chr(34) & " href=" & Chr(34) & "file:\\\" & (TextBox1.Text & TextBox9.Text & ".css") & Chr(34) & " />"
            '            System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", MyCEF.FastColoredTextBox1.Text)
            '            MyCEF.buttprogling.Text = (TraduzioneLinguaTxt.Lines(10))
            '            MyCEF.buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
            '            MyCEF.Button5.Text = ( Now.Hour & ":" & Now.Minute)
            '            Avvio.Close()

            '            Me.Close()
            '        Else
            '            Timer1.Start()
            '            MessaggioF.Text = ("Progetto già esistente")
            '            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Esiste già un progetto con lo stesso nome." & vbNewLine & "Cambiare il nome per poterne creare un nuovo.")
            '            MessaggioF.ShowDialog()
            '        End If
            '    Else
            '        MessaggioF.Text = ("Percorso di salvataggio inesistente")
            '        MessaggioF.Button1.Text = ("Attenzione: " & vbNewLine & "Il percorso selezionato è inesistente." & vbNewLine & "Per favore, scegline uno esistente.")
            '        MessaggioF.ShowDialog()
            '    End If
            'End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If timertxt.Text = ("0") Then
            TextBox1.BackColor = Color.Red
            timertxt.Text += 1
        ElseIf timertxt.Text = ("1") Then
            TextBox1.BackColor = Color.WhiteSmoke
            timertxt.Text += 1
        ElseIf timertxt.Text = ("2") Then
            TextBox1.BackColor = Color.Red
            timertxt.Text += 1
        ElseIf timertxt.Text = ("3") Then
            TextBox1.BackColor = Color.WhiteSmoke
            timertxt.Text = ("0")
            Timer2.Stop()
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = ("") Or TextBox1.Text.Replace(" ", "") = "" Then
            TextBox1.ForeColor = Color.DarkGray
            TextBox1.Text = MyCEF.TraduzioneLinguaTxt.Lines(777)
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If (TextBox1.Text = MyCEF.TraduzioneLinguaTxt.Lines(777) And TextBox1.ForeColor = Color.DarkGray) Then
            TextBox1.ForeColor = Color.DarkRed
            TextBox1.Text = ("")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox9.Select()
        TextBox9.Copy()
    End Sub

    Private Sub IncollaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem.Click
        TextBox9.Select()
        TextBox9.Paste()
    End Sub
End Class