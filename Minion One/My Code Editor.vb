Imports System.Drawing.Printing
Imports System.Net
Imports System
Public Class MyCEF
    Public finestrastato As String = My.Settings.impostazionistatofinestra

    Public PercorsoFileHTML As String = ""
    Public PercorsoFileCSS As String = ""

    Public EstensioneFile As String = ""

    Public file_menu As Boolean = False
    Public modifica_menu As Boolean = False
    Public visualizza_menu As Boolean = False
    Public inserisci_menu As Boolean = False
    Public mce_menu As Boolean = False

    Public contex_menu_1 As Boolean = False

    Public screenWidth As Integer = 0
    Public screenHeight As Integer = 0

    Public Function verifica_percorso()
        Dim stringa_percorso As String = percorsoSALVATAGGIO.Text
        If PercorsoFileButton.Size.Width < 500 And stringa_percorso.Length > 40 Then stringa_percorso = stringa_percorso.Substring(0, 20) + " ... " + stringa_percorso.Substring(stringa_percorso.Length - 20, 20)
        If PercorsoFileButton.Size.Width < 400 And stringa_percorso.Length > 30 Then stringa_percorso = stringa_percorso.Substring(0, 15) + " ... " + stringa_percorso.Substring(stringa_percorso.Length - 15, 15)
        If PercorsoFileButton.Size.Width < 300 And stringa_percorso.Length > 20 Then stringa_percorso = stringa_percorso.Substring(0, 10) + " ... " + stringa_percorso.Substring(stringa_percorso.Length - 10, 10)
        If PercorsoFileButton.Size.Width < 200 And stringa_percorso.Length > 10 Then stringa_percorso = stringa_percorso.Substring(0, 5) + " ... " + stringa_percorso.Substring(stringa_percorso.Length - 5, 5)

        PercorsoFileButton.Text = stringa_percorso
    End Function

    Public Function file_mostra_menu()
        file_menu = True
        Dim pos As Point
        pos.X = Me.Location.X + 0 + 8
        pos.Y = Me.Location.Y + 22 + 16 + 15

        If My.Settings.aschermointero = ("si") Then
            pos.Y = 22
            pos.X = Me.Location.X + 0
        End If

        Dim posX As Boolean = False 'modificato pos.X
        Dim posY As Boolean = False 'modificato pos.Y
        If pos.Y + FilePanelMenu.Size.Height >= screenHeight Then
            If pos.X + FilePanelMenu.Size.Width + FileButton.Size.Width >= screenWidth Then
                pos.X -= FilePanelMenu.Size.Width
            Else
                pos.X += FileButton.Size.Width
            End If
            Dim a1 As Integer = screenHeight - pos.Y
            a1 = FilePanelMenu.Size.Height - a1
            pos.Y -= a1
            posY = True
        End If
        If pos.X + FilePanelMenu.Size.Width >= screenWidth Then
            pos.X -= (FilePanelMenu.Size.Width - FileButton.Size.Width)
            posX = True
        End If

        FilePanelMenu.Location = pos

        FilePanelMenu.Nuovo.Text = TraduzioneLinguaTxt.Lines(18)
        FilePanelMenu.Apri.Text = TraduzioneLinguaTxt.Lines(19)
        FilePanelMenu.Salva.Text = TraduzioneLinguaTxt.Lines(20)
        FilePanelMenu.SalvaTutto.Text = TraduzioneLinguaTxt.Lines(21)
        FilePanelMenu.Chiudi.Text = TraduzioneLinguaTxt.Lines(22)

        FilePanelMenu.Show()
    End Function
    Public Function modifica_mostra_menu()
        modifica_menu = True
        Dim pos As Point
        pos.X = Me.Location.X + 58 + 8
        pos.Y = Me.Location.Y + 22 + 16 + 15

        If My.Settings.aschermointero = ("si") Then
            pos.Y = 22
            pos.X = Me.Location.X + 58
        End If

        Dim posX As Boolean = False 'modificato pos.X
        Dim posY As Boolean = False 'modificato pos.Y
        If pos.Y + ModificaPanelMenu.Size.Height >= screenHeight Then
            If pos.X + ModificaPanelMenu.Size.Width + ModificaButton.Size.Width >= screenWidth Then
                pos.X -= ModificaPanelMenu.Size.Width
            Else
                pos.X += ModificaButton.Size.Width
            End If
            Dim a1 As Integer = screenHeight - pos.Y
            a1 = ModificaPanelMenu.Size.Height - a1
            pos.Y -= a1
            posY = True
        End If
        If pos.X + ModificaPanelMenu.Size.Width >= screenWidth Then
            pos.X -= (ModificaPanelMenu.Size.Width - ModificaButton.Size.Width)
            posX = True
        End If

        ModificaPanelMenu.Annulla.Text = TraduzioneLinguaTxt.Lines(23)
        ModificaPanelMenu.Ripeti.Text = TraduzioneLinguaTxt.Lines(24)
        ModificaPanelMenu.Taglia.Text = TraduzioneLinguaTxt.Lines(25)
        ModificaPanelMenu.Copia.Text = TraduzioneLinguaTxt.Lines(26)
        ModificaPanelMenu.Incolla.Text = TraduzioneLinguaTxt.Lines(27)
        ModificaPanelMenu.Elimina.Text = TraduzioneLinguaTxt.Lines(28)
        ModificaPanelMenu.SelezionaTutto.Text = TraduzioneLinguaTxt.Lines(29)
        ModificaPanelMenu.CercaESostituisci.Text = TraduzioneLinguaTxt.Lines(30)

        ModificaPanelMenu.Location = pos
        ModificaPanelMenu.Show()
    End Function
    Public Function visualizza_mostra_menu()
        visualizza_menu = True
        Dim pos As Point
        pos.X = Me.Location.X + 58 + 83 + 8
        pos.Y = Me.Location.Y + 22 + 16 + 15

        If My.Settings.aschermointero = ("si") Then
            pos.Y = 22
            pos.X = Me.Location.X + 58 + 83
        End If

        Dim posX As Boolean = False 'modificato pos.X
        Dim posY As Boolean = False 'modificato pos.Y
        If pos.Y + VisualizzaPanelMenu.Size.Height >= screenHeight Then
            If pos.X + VisualizzaPanelMenu.Size.Width + VisualizzaButton.Size.Width >= screenWidth Then
                pos.X -= VisualizzaPanelMenu.Size.Width
            Else
                pos.X += VisualizzaButton.Size.Width
            End If
            Dim a1 As Integer = screenHeight - pos.Y
            a1 = VisualizzaPanelMenu.Size.Height - a1
            pos.Y -= a1
            posY = True
        End If
        If pos.X + VisualizzaPanelMenu.Size.Width >= screenWidth Then
            pos.X -= (VisualizzaPanelMenu.Size.Width - VisualizzaButton.Size.Width)
            posX = True
        End If

        VisualizzaPanelMenu.ACapoAutomatico.Text = TraduzioneLinguaTxt.Lines(31)
        VisualizzaPanelMenu.ASchermoIntero.Text = TraduzioneLinguaTxt.Lines(32)
        VisualizzaPanelMenu.BarraInferiore.Text = TraduzioneLinguaTxt.Lines(33)
        VisualizzaPanelMenu.FoglioHTMLeCSS.Text = TraduzioneLinguaTxt.Lines(34)
        VisualizzaPanelMenu.AnteprimaProgetto.Text = TraduzioneLinguaTxt.Lines(35)

        If (ImpostazioniTxt.Lines(4).Replace("VISUALIZZA IL TESTO A CAPO AUTOMATICAMENTE - [[", "")).Replace("]]", "") = "SI" Then
            Impostazioni.GeneraleCheck2.Checked = True
            Impostazioni.GeneraleTxt2.Text = "SI"
            FastColoredTextBox1.WordWrap = True
            CSSFTB.WordWrap = True
            VisualizzaPanelMenu.ACapoAutomatico.Image = My.Resources.si
        Else
            Impostazioni.GeneraleCheck2.Checked = False
            Impostazioni.GeneraleTxt2.Text = "NO"
            FastColoredTextBox1.WordWrap = False
            CSSFTB.WordWrap = False
            VisualizzaPanelMenu.ACapoAutomatico.Image = My.Resources.no
        End If

        If (ImpostazioniTxt.Lines(14).Replace("VISUALIZZA LA BARRA INFERIORE - [[", "")).Replace("]]", "") = "SI" Then
            Impostazioni.InterfacciaCheck0.Checked = True
            Impostazioni.InterfacciaTxt0.Text = "SI"
            VisualizzaPanelMenu.BarraInferiore.Image = My.Resources.si
            BarraInferiore.Visible = True
        Else
            Impostazioni.InterfacciaCheck0.Checked = False
            Impostazioni.InterfacciaTxt0.Text = "NO"
            VisualizzaPanelMenu.BarraInferiore.Image = My.Resources.no
            BarraInferiore.Visible = False
        End If

        If My.Settings.aschermointero = ("si") Then
            VisualizzaPanelMenu.ASchermoIntero.Image = My.Resources.si
        Else
            VisualizzaPanelMenu.ASchermoIntero.Image = My.Resources.no
        End If

        If buttprogcss.Visible Then
            If buttprogcss.BackColor = Color.Red Then
                VisualizzaPanelMenu.FoglioHTMLeCSS.Text = TraduzioneLinguaTxt.Lines(697)
                VisualizzaPanelMenu.ACapoAutomatico.Enabled = False
            Else
                VisualizzaPanelMenu.FoglioHTMLeCSS.Text = TraduzioneLinguaTxt.Lines(34)
                VisualizzaPanelMenu.ACapoAutomatico.Enabled = True
            End If
            VisualizzaPanelMenu.FoglioHTMLeCSS.Enabled = True
        End If

        If buttproghtml.Visible Then
            VisualizzaPanelMenu.AnteprimaProgetto.Enabled = True
        Else
            VisualizzaPanelMenu.AnteprimaProgetto.Enabled = False
        End If

        VisualizzaPanelMenu.Location = pos
        VisualizzaPanelMenu.Show()
    End Function
    Public Function inserisci_mostra_menu()
        inserisci_menu = True
        Dim pos As Point
        pos.X = Me.Location.X + 58 + 83 + 83 + 8
        pos.Y = Me.Location.Y + 22 + 16 + 15

        If My.Settings.aschermointero = ("si") Then
            pos.Y = 22
            pos.X = Me.Location.X + 58 + 83 + 83
        End If

        Dim posX As Boolean = False 'modificato pos.X
        Dim posY As Boolean = False 'modificato pos.Y
        If pos.Y + InserisciPanelMenu.Size.Height >= screenHeight Then
            If pos.X + InserisciPanelMenu.Size.Width + InserisciButton.Size.Width >= screenWidth Then
                pos.X -= InserisciPanelMenu.Size.Width
            Else
                pos.X += InserisciButton.Size.Width
            End If
            Dim a1 As Integer = screenHeight - pos.Y
            a1 = InserisciPanelMenu.Size.Height - a1
            pos.Y -= a1
            posY = True
        End If
        If pos.X + InserisciPanelMenu.Size.Width >= screenWidth Then
            pos.X -= (InserisciPanelMenu.Size.Width - InserisciButton.Size.Width)
            posX = True
        End If

        InserisciPanelMenu.Grassetto.Text = TraduzioneLinguaTxt.Lines(36)
        InserisciPanelMenu.Corsivo.Text = TraduzioneLinguaTxt.Lines(37)
        InserisciPanelMenu.Sottolineato.Text = TraduzioneLinguaTxt.Lines(38)
        InserisciPanelMenu.Barrato.Text = TraduzioneLinguaTxt.Lines(39)
        InserisciPanelMenu.ACapo.Text = TraduzioneLinguaTxt.Lines(40)
        InserisciPanelMenu.SeparatoreRapido.Text = TraduzioneLinguaTxt.Lines(41)
        InserisciPanelMenu.Label1.Text = TraduzioneLinguaTxt.Lines(42)
        InserisciPanelMenu.Bottone.Text = TraduzioneLinguaTxt.Lines(43)
        InserisciPanelMenu.Collegamento.Text = TraduzioneLinguaTxt.Lines(44)
        InserisciPanelMenu.Commento.Text = TraduzioneLinguaTxt.Lines(45)
        InserisciPanelMenu.Contenitore.Text = TraduzioneLinguaTxt.Lines(46)
        InserisciPanelMenu.Descrizione.Text = TraduzioneLinguaTxt.Lines(47)
        InserisciPanelMenu.Elenco.Text = TraduzioneLinguaTxt.Lines(48)
        InserisciPanelMenu.Immagine.Text = TraduzioneLinguaTxt.Lines(49)
        InserisciPanelMenu.Paragrafo.Text = TraduzioneLinguaTxt.Lines(50)
        InserisciPanelMenu.Separatore.Text = TraduzioneLinguaTxt.Lines(51)
        InserisciPanelMenu.Sottotitolo.Text = TraduzioneLinguaTxt.Lines(52)
        InserisciPanelMenu.Tabella.Text = TraduzioneLinguaTxt.Lines(53)
        InserisciPanelMenu.TestoPersonalizzato.Text = TraduzioneLinguaTxt.Lines(54)
        InserisciPanelMenu.Titolo.Text = TraduzioneLinguaTxt.Lines(55)
        InserisciPanelMenu.CaratteriSpeciali.Text = TraduzioneLinguaTxt.Lines(56)

        InserisciPanelMenu.Location = pos
        InserisciPanelMenu.Show()
    End Function
    Public Function mce_mostra_menu()
        mce_menu = True
        Dim pos As Point
        pos.X = Me.Location.X + 58 + 83 + 83 + 83 + 8
        pos.Y = Me.Location.Y + 22 + 16 + 15

        If My.Settings.aschermointero = ("si") Then
            pos.Y = 22
            pos.X = Me.Location.X + 58 + 83 + 83 + 83
        End If

        Dim posX As Boolean = False 'modificato pos.X
        Dim posY As Boolean = False 'modificato pos.Y
        If pos.Y + MCEPanelMenu.Size.Height >= screenHeight Then
            If pos.X + MCEPanelMenu.Size.Width + MCEButton.Size.Width >= screenWidth Then
                pos.X -= MCEPanelMenu.Size.Width
            Else
                pos.X += MCEButton.Size.Width
            End If
            Dim a1 As Integer = screenHeight - pos.Y
            a1 = MCEPanelMenu.Size.Height - a1
            pos.Y -= a1
            posY = True
        End If
        If pos.X + MCEPanelMenu.Size.Width >= screenWidth Then
            pos.X -= (MCEPanelMenu.Size.Width - MCEButton.Size.Width)
            posX = True
        End If

        MCEPanelMenu.Informazioni.Text = TraduzioneLinguaTxt.Lines(57)
        MCEPanelMenu.Impostazioni.Text = TraduzioneLinguaTxt.Lines(58)
        MCEPanelMenu.CheCeDiNuovo.Text = TraduzioneLinguaTxt.Lines(59)
        MCEPanelMenu.Aiuto.Text = TraduzioneLinguaTxt.Lines(60)
        MCEPanelMenu.Riconoscimenti.Text = TraduzioneLinguaTxt.Lines(463)
        MCEPanelMenu.Aggiornamenti.Text = TraduzioneLinguaTxt.Lines(470)

        MCEPanelMenu.Location = pos
        MCEPanelMenu.Show()
    End Function

    Public Function chiudi_tutti_menu()
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanelMenu.Close()
        file_menu = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanelMenu.Close()
        modifica_menu = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanelMenu.Close()
        visualizza_menu = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanelMenu.Close()
        inserisci_menu = False
        MCEButton.BackColor = Color.DarkRed
        MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
        MCEButton.ForeColor = Color.WhiteSmoke
        MCEPanelMenu.Close()
        mce_menu = False

        contex_menu_1 = False
        ContexMenu1.Close()
        ContexMenu2.Close()
        ContexMenu1_Inserisci.Close()
        ContexMenu1_CercaNelWeb.Close()

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Select()
        End If
    End Function

    Public Function nuovo_func()
        chiudi_tutti_menu()

        buttproghtml.PerformClick()
        If buttprogcss.Text = ("CSS*") Or buttproghtml.Text = ("HTML*") Then
            EsciMessaggio.Text = ("Vuoi salvare il progetto prima di crearne uno nuovo?")
            EsciMessaggio.Button1.Text = ("Il progetto attuale non è stato salvato. Vuoi farlo prima di crearne uno nuovo?" & vbNewLine & "NOTA: Non sarà possibile recuperare il progetto se non lo si salva.")
            EsciMessaggio.Tipo.Text = ("Nuovo")
            EsciMessaggio.ShowDialog()
            If ApriNuovoProgNonSalv.Text = ("Nuovo") Then
                FastColoredTextBox1.Clear()
                CSSFTB.Text = ("")
                buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                buttproghtml.Visible = True
                Avvio.ShowDialog()
            End If
        Else
            FastColoredTextBox1.Clear()
            CSSFTB.Text = ("")
            buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
            buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
            Me.Text = (TraduzioneLinguaTxt.Lines(0))
            Avvio.ShowDialog()
        End If
    End Function

    Public Function apri_func()
        chiudi_tutti_menu()

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = OpenFileDialog1.FileName
            FastColoredTextBox1.Text = (My.Computer.FileSystem.ReadAllText(testo))
            TitoloProg.Text = My.Computer.FileSystem.GetName(testo)
            percorsoSALVATAGGIO.Text = testo.Replace(TitoloProg.Text, "")
            PercorsoFileHTML = percorsoSALVATAGGIO.Text & TitoloProg.Text
            If TitoloProg.Text.Contains(".html") Then
                TitoloProg.Text = TitoloProg.Text.Replace(".html", "")
                EstensioneFile = "html"
            ElseIf TitoloProg.Text.Contains(".htm") Then
                TitoloProg.Text = TitoloProg.Text.Replace(".htm", "")
                EstensioneFile = "htm"
            ElseIf TitoloProg.Text.Contains(".shtml") Then
                TitoloProg.Text = TitoloProg.Text.Replace(".shtml", "")
                EstensioneFile = "shtml"
            ElseIf TitoloProg.Text.Contains(".shtm") Then
                TitoloProg.Text = TitoloProg.Text.Replace(".shtm", "")
                EstensioneFile = "shtm"
            End If
            PercorsoFileCSS = percorsoSALVATAGGIO.Text & TitoloProg.Text & ".css"
            Me.Text = TitoloProg.Text & " • My Code Editor"
            PercorsoFileButton.Text = percorsoSALVATAGGIO.Text
            buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
            buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
            SaveFileDialog1.FileName = ""
            If System.IO.File.Exists(PercorsoFileCSS) Then
                buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                buttproghtml.Enabled = True
                buttprogcss.Visible = True
                CSSSIoNOtb.Text = ("si")
                ProgettazioneButtonR.Enabled = True
                AnteprimaButtonR.Enabled = True
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                FastColoredTextBox1.Select()
                CSSFTB.Text = (System.IO.File.ReadAllText(PercorsoFileCSS))
                buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
            Else
                buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                buttproghtml.Enabled = True
                buttprogcss.Visible = False
                CSSSIoNOtb.Text = ("no")
                ProgettazioneButtonR.Enabled = True
                AnteprimaButtonR.Enabled = True
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                FastColoredTextBox1.Select()
            End If
            FastColoredTextBox1.Select()
            FileButton.Enabled = True
            ModificaButton.Enabled = True
            VisualizzaButton.Enabled = True
            InserisciButton.Enabled = True
            InserisciToolStripMenuItem1.Enabled = True
            MCEButton.Enabled = True
            Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", Avvio.recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", Avvio.recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", Avvio.recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", Avvio.recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", Avvio.recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
            TitoloProg.Text = (Text.Replace(" • My Code Editor", ""))
            Avvio.recente1butt.Text = (TitoloProg.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", TitoloProg.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", PercorsoFileButton.Text)
            ultimoProgettoSalvato.Text = (FastColoredTextBox1.Text)
            FastColoredTextBox1.Select()
            FastColoredTextBox1.ClearUndo()

            verifica_percorso()

            Avvio.Close()
        End If
    End Function

    Public Function salva_func()
        chiudi_tutti_menu()

        Try
            If buttprogcss.BackColor = Color.Red And buttprogcss.Visible = True Then
                System.IO.File.WriteAllText(PercorsoFileCSS, CSSFTB.Text)
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
                UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Else
                If buttproghtml.Visible Then
                    System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                Else
                    If (PercorsoFileButton.Text <> "") Then
                        System.IO.File.WriteAllText(percorsoSALVATAGGIO.Text & TitoloProg.Text & "." & EstensioneFile, FastColoredTextBox1.Text)
                    End If
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            End If
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            verifica_percorso()
        Catch ex As Exception
            MessaggioF.Text = ("Errore: Salvataggio non riuscito")
            MessaggioF.Button1.Text = ("Non è stato trovato il percorso file selezionato per il salvataggio del progetto. Verificare che sia esistente, quindi modificarlo se non lo è." & vbNewLine & "Codice errore: MCEEAA0008")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0008")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
    End Function

    Public Function salvatutto_func()
        chiudi_tutti_menu()

        Try
            If buttprogcss.Visible = True Then
                System.IO.File.WriteAllText(PercorsoFileCSS, CSSFTB.Text)
                If buttproghtml.Visible Then
                    System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                Else
                    System.IO.File.WriteAllText(percorsoSALVATAGGIO.Text & TitoloProg.Text & "." & EstensioneFile, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            Else
                If buttproghtml.Visible Then
                    System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                Else
                    System.IO.File.WriteAllText(percorsoSALVATAGGIO.Text & TitoloProg.Text & "." & EstensioneFile, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            verifica_percorso()
        Catch ex As Exception
            MessaggioF.Text = ("Errore: Salvataggio non riuscito")
            MessaggioF.Button1.Text = ("Non è stato trovato il percorso file selezionato per il salvataggio del progetto. Verificare che sia esistente, quindi modificarlo se non lo è." & vbNewLine & "Codice errore: MCEEAA0008")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0008")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
    End Function

    Public Function chiudi_func()
        chiudi_tutti_menu()

        Me.Close()
    End Function

    Public Function annulla_func()
        chiudi_tutti_menu()

        If AnteprimaButtonR.BackColor = Color.DarkRed Then
            WebBrowser1.GoBack()
        ElseIf buttprogcss.BackColor = Color.Red Then
            CSSFTB.Undo()
            CSSFTB.Select()
        ElseIf buttproghtml.BackColor = Color.Red Then
            FastColoredTextBox1.Undo()
            FastColoredTextBox1.Select()
        End If
    End Function

    Public Function ripeti_func()
        chiudi_tutti_menu()

        If AnteprimaButtonR.BackColor = Color.DarkRed Then
            WebBrowser1.GoForward()
        ElseIf buttprogcss.BackColor = Color.Red Then
            CSSFTB.Redo()
            CSSFTB.Select()
        ElseIf buttproghtml.BackColor = Color.Red Then
            FastColoredTextBox1.Redo()
            FastColoredTextBox1.Select()
        End If
    End Function

    Public Function taglia_func()
        chiudi_tutti_menu()

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Cut()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Cut()
            FastColoredTextBox1.Select()
        End If
    End Function

    Public Function copia_func()
        chiudi_tutti_menu()

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Copy()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Copy()
            FastColoredTextBox1.Select()
        End If
    End Function

    Public Function incolla_func()
        chiudi_tutti_menu()

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Paste()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Paste()
            FastColoredTextBox1.Select()
        End If
    End Function

    Public Function elimina_func()
        chiudi_tutti_menu()

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.ClearSelected()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.ClearSelected()
            FastColoredTextBox1.Select()
        End If
    End Function

    Public Function selezionatutto_func()
        chiudi_tutti_menu()

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.SelectAll()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.SelectAll()
            FastColoredTextBox1.Select()
        End If
    End Function

    Public Function cercaesostituisci_func()
        chiudi_tutti_menu()

        cercasostituisci()
    End Function

    Public Function acapoautomatico_func()
        chiudi_tutti_menu()

        If Impostazioni.GeneraleCheck2.Checked = True Then
            Impostazioni.GeneraleCheck2.Checked = False
        Else
            Impostazioni.GeneraleCheck2.Checked = True
        End If
    End Function

    Public Function aschermointero_func()
        chiudi_tutti_menu()

        If My.Settings.aschermointero = ("si") Then
            My.Settings.aschermointero = ("no")
            'codici
            VisualizzaPanelMenu.ASchermoIntero.Image = My.Resources.no
            If finestrastato = "mass" Then
                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                Me.WindowState = FormWindowState.Normal
            End If
        Else
            My.Settings.aschermointero = ("si")
            'codici
            VisualizzaPanelMenu.ASchermoIntero.Image = My.Resources.si
            If Me.WindowState = FormWindowState.Maximized Then
                finestrastato = "mass"
            Else
                finestrastato = "norm"
            End If
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If
    End Function

    Public Function barrainferiore_func()
        chiudi_tutti_menu()

        If Impostazioni.InterfacciaCheck0.CheckState = CheckState.Checked Then
            Impostazioni.InterfacciaCheck0.CheckState = CheckState.Unchecked
        Else
            Impostazioni.InterfacciaCheck0.CheckState = CheckState.Checked
        End If
    End Function

    Public Function fogliocssehtml_func()
        chiudi_tutti_menu()

        If Not buttprogcss.BackColor = Color.Red And buttprogcss.Visible = True Then
            buttproghtml.BackColor = Color.DarkRed
            buttprogcss.BackColor = Color.Red
            CSSFTB.Visible = True
            FastColoredTextBox1.Visible = False
            Button9.Text = ("")
            Button9.Text = (CSSFTB.Text.Length)
            Button2.Text = ("")
            Button2.Text = (CSSFTB.Lines.Count)
            InserisciButton.Enabled = False
            InserisciToolStripMenuItem1.Enabled = False
            PercorsoFileButton.Text = PercorsoFileButton.Text.Replace(".html", ".css")
            Button5.Text = (UltSalCSS.Text)

            BarraDegliStrumenti.Visible = False

            CSSFTB.Select()
        Else
            buttproghtml.BackColor = Color.Red
            buttprogcss.BackColor = Color.DarkRed
            CSSFTB.Visible = False
            FastColoredTextBox1.Visible = True
            Button9.Text = ("")
            Button9.Text = (FastColoredTextBox1.Text.Length)
            Button2.Text = ("")
            Button2.Text = (FastColoredTextBox1.Lines.Count)
            InserisciButton.Enabled = True
            InserisciToolStripMenuItem1.Enabled = True
            PercorsoFileButton.Text = PercorsoFileButton.Text.Replace(".css", ".html")
            Button5.Text = (UltSalHTML.Text)

            BarraDegliStrumenti.Visible = True

            FastColoredTextBox1.Select()
        End If
    End Function

    Public Function anteprimadelprogetto_func()
        chiudi_tutti_menu()

        If Not AnteprimaWB.Visible = True Then
            If Impostazioni.AvanzateTxt0.Text = ("WBI") Then
                FastColoredTextBoxPanel.Visible = False
                AnteprimaWB.Visible = True
                FTPPanel.Visible = False
                WebBrowser1.Select()
                ProgettazioneButtonR.BackColor = Color.FromArgb(140, 140, 140)
                AnteprimaButtonR.BackColor = Color.DarkRed
                FTPButton.BackColor = Color.FromArgb(140, 140, 140)

                BarraDegliStrumenti.Visible = False
                BarraDeiMenu.Visible = False
                'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("/*è/", "&#200;")
                'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("/*é/", "&#201;")
                'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace(".-.è", "&#232;")
                'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace(".-.é", "&#234;")

                'If buttprogcss.Visible = True Then
                'FastColoredTextBox1.Text = "<style>" & vbNewLine & CSSFTB.Text & vbNewLine & "</style>" & FastColoredTextBox1.Text
                'Else
                'End If
                'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("\Css.mopcss", "\Css.css")
                'Try
                '    If buttprogling.Text = (TraduzioneLinguaTxt.Lines(10)) Then
                '        System.Diagnostics.Process.Start("file:\\" & "\" & (My.Application.Info.DirectoryPath) & "\FIle.html")
                '    End If
                'Catch
                '    MessaggioF.Text = ("Errore non gestito.")
                '    MessaggioF.Button1.Text = "Non è stato possibile aprire l'anteprima nel web browser predefito per un errore non riconosciuto e non gestito."
                'End Try
                ANTEPRIMAPROGETTO.Text = FastColoredTextBox1.Text
                BarraDeiMenuWebBrowser.Visible = True
                If buttprogcss.Visible = True Then
                    If PercorsoFileButton.Text.Contains(".css") Then
                        System.IO.File.WriteAllText(PercorsoFileCSS, CSSFTB.Text)
                    Else
                        System.IO.File.WriteAllText(PercorsoFileCSS, CSSFTB.Text)
                    End If
                    If PercorsoFileButton.Text.Contains(".html") Then
                        System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                    End If
                    buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                    buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)

                    ANTEPRIMAPROGETTO.Text = "<html><style>" & vbNewLine & CSSFTB.Text & vbNewLine & "</style></html>" & vbNewLine & ANTEPRIMAPROGETTO.Text

                Else
                    If PercorsoFileButton.Text.Contains(".html") Then
                        System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                    End If
                    buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                End If
                UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
                UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
                Button5.Text = (Now.Hour & ":" & Now.Minute)

                chiudi_tutti_menu()

                'BarraDeiMenu.Enabled = False
                BarraInferiore.Visible = False
                WebBrowser1.DocumentText = (ANTEPRIMAPROGETTO.Text)
            ElseIf Impostazioni.AvanzateTxt0.Text = ("WBP") Then
                If buttprogcss.Visible = True Then
                    If PercorsoFileButton.Text.Contains(".css") Then
                        System.IO.File.WriteAllText(PercorsoFileCSS, CSSFTB.Text)
                    Else
                        System.IO.File.WriteAllText(PercorsoFileCSS, CSSFTB.Text)
                    End If
                    If PercorsoFileButton.Text.Contains(".html") Then
                        System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                    End If
                    buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                    buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
                Else
                    If PercorsoFileButton.Text.Contains(".html") Then
                        System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                    End If
                    buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                End If
                UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
                UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
                Button5.Text = (Now.Hour & ":" & Now.Minute)

                If My.Settings.aschermointero = ("si") Then
                    If finestrastato = "mass" Then
                        Me.WindowState = FormWindowState.Normal
                        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                        Me.WindowState = FormWindowState.Maximized
                    Else
                        Me.WindowState = FormWindowState.Normal
                        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                        Me.WindowState = FormWindowState.Normal
                    End If
                    My.Settings.aschermointero = "no"
                End If

                Process.Start("file:\\\" & PercorsoFileButton.Text.Replace(".css", ".html"))
            Else
                If buttprogcss.Visible = True Then
                    If PercorsoFileButton.Text.Contains(".css") Then
                        System.IO.File.WriteAllText(PercorsoFileCSS, CSSFTB.Text)
                    Else
                        System.IO.File.WriteAllText(PercorsoFileCSS, CSSFTB.Text)
                    End If
                    If PercorsoFileButton.Text.Contains(".html") Then
                        System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                    End If
                    buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                    buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
                Else
                    If PercorsoFileButton.Text.Contains(".html") Then
                        System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                    End If
                    buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                End If
                UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
                UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
                Button5.Text = (Now.Hour & ":" & Now.Minute)

                If My.Settings.aschermointero = ("si") Then
                    If finestrastato = "mass" Then
                        Me.WindowState = FormWindowState.Normal
                        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                        Me.WindowState = FormWindowState.Maximized
                    Else
                        Me.WindowState = FormWindowState.Normal
                        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                        Me.WindowState = FormWindowState.Normal
                    End If
                    My.Settings.aschermointero = "no"
                End If
                Dim perc As String = PercorsoFileHTML
                perc = perc.Replace(" ", "%20")
                Process.Start(Impostazioni.AvanzateTxt0.Text, "file:\\\" & perc)
            End If
        End If
    End Function

    Public Function progetto_func()
        chiudi_tutti_menu()

        AnteprimaWB.Visible = False
        FTPPanel.Visible = False
        ProgettazioneButtonR.BackColor = Color.DarkRed
        AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
        FTPButton.BackColor = Color.FromArgb(140, 140, 140)
        WebBrowser1.Navigate("about:blank")
        ANTEPRIMAPROGETTO.Text = ""

        FastColoredTextBoxPanel.Visible = True
        BarraDeiMenu.Visible = True
        BarraDegliStrumenti.Visible = True
        'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("<style>" & vbNewLine & CSSFTB.Text & vbNewLine & "</style>", "")
        'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("\Css.css", "\Css.mopcss")
        chiudi_tutti_menu()

        BarraDeiMenu.Enabled = True
        If Impostazioni.InterfacciaCheck0.CheckState = CheckState.Checked Then
            BarraInferiore.Visible = True
        End If
        BarraDeiMenuWebBrowser.Visible = False
    End Function

    Public Function grassetto_func()
        chiudi_tutti_menu()

        SelezionatoSalvatoDagliAppunti.Text = "<b>"
        SelezionatoSalvatoDagliAppunti.Text &= FastColoredTextBox1.SelectedText
        SelezionatoSalvatoDagliAppunti.Text &= "</b>"
        DaIncollare.Text = SelezionatoSalvatoDagliAppunti.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        SelezionatoSalvatoDagliAppunti.SelectAll()
        SelezionatoSalvatoDagliAppunti.Clear()
        FastColoredTextBox1.Select()
    End Function

    Public Function corsivo_func()
        chiudi_tutti_menu()

        SelezionatoSalvatoDagliAppunti.Text = "<i>"
        SelezionatoSalvatoDagliAppunti.Text &= FastColoredTextBox1.SelectedText
        SelezionatoSalvatoDagliAppunti.Text &= "</i>"
        DaIncollare.Text = SelezionatoSalvatoDagliAppunti.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        SelezionatoSalvatoDagliAppunti.SelectAll()
        SelezionatoSalvatoDagliAppunti.Clear()
        FastColoredTextBox1.Select()
    End Function

    Public Function sottolineato_func()
        chiudi_tutti_menu()

        SelezionatoSalvatoDagliAppunti.Text = "<u>"
        SelezionatoSalvatoDagliAppunti.Text &= FastColoredTextBox1.SelectedText
        SelezionatoSalvatoDagliAppunti.Text &= "</u>"
        DaIncollare.Text = SelezionatoSalvatoDagliAppunti.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        SelezionatoSalvatoDagliAppunti.SelectAll()
        SelezionatoSalvatoDagliAppunti.Clear()
        FastColoredTextBox1.Select()
    End Function

    Public Function barrato_func()
        chiudi_tutti_menu()

        SelezionatoSalvatoDagliAppunti.Text = "<s>"
        SelezionatoSalvatoDagliAppunti.Text &= FastColoredTextBox1.SelectedText
        SelezionatoSalvatoDagliAppunti.Text &= "</s>"
        DaIncollare.Text = SelezionatoSalvatoDagliAppunti.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        SelezionatoSalvatoDagliAppunti.SelectAll()
        SelezionatoSalvatoDagliAppunti.Clear()
        FastColoredTextBox1.Select()
    End Function

    Public Function acapobr_func()
        chiudi_tutti_menu()

        DagliAppunti.Paste()
        DaIncollare.Text = vbNewLine & "<br/>" & vbNewLine
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        FastColoredTextBox1.Select()
    End Function

    Public Function separatorehr_func()
        chiudi_tutti_menu()

        DagliAppunti.Paste()
        DaIncollare.Text = vbNewLine & "<hr/>" & vbNewLine
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        FastColoredTextBox1.Select()
    End Function

    Public Function informazioni_func()
        chiudi_tutti_menu()

        InformazioniF.Text = TraduzioneLinguaTxt.Lines(462)
        InformazioniF.GeneraleButton.Text = TraduzioneLinguaTxt.Lines(755)
        InformazioniF.LicenzaButton.Text = TraduzioneLinguaTxt.Lines(464)
        InformazioniF.TerminiDUsoButton.Text = TraduzioneLinguaTxt.Lines(465)
        InformazioniF.VersioneCompletaLabel.Text = TraduzioneLinguaTxt.Lines(466)
        InformazioniF.VersioneLabel.Text = TraduzioneLinguaTxt.Lines(467)
        InformazioniF.CreativeCommonsLabel.Text = TraduzioneLinguaTxt.Lines(468)
        InformazioniF.MinionOneSitoLink.Text = TraduzioneLinguaTxt.Lines(469)
        InformazioniF.ControllaGliAggiornamentiButton.Text = TraduzioneLinguaTxt.Lines(470)
        InformazioniF.ContattaciButton.Text = TraduzioneLinguaTxt.Lines(472)

        InformazioniF.Segnalazione_Informazioni.Text = TraduzioneLinguaTxt.Lines(782)
        InformazioniF.RichiediSupporto_Informazioni.Text = TraduzioneLinguaTxt.Lines(783)
        InformazioniF.Altro_Informazioni.Text = TraduzioneLinguaTxt.Lines(784)

        InformazioniF.Show()
    End Function

    Public Function impostazioni_func()
        chiudi_tutti_menu()


        Impostazioni.Text = TraduzioneLinguaTxt.Lines(420)
        Impostazioni.GeneraleCheck0.Text = TraduzioneLinguaTxt.Lines(421)
        Impostazioni.GeneraleCheck1.Text = TraduzioneLinguaTxt.Lines(422)
        Impostazioni.GeneraleCheck2.Text = TraduzioneLinguaTxt.Lines(423)
        Impostazioni.GeneraleCheck3.Text = TraduzioneLinguaTxt.Lines(424)
        Impostazioni.GeneraleCheck4.Text = TraduzioneLinguaTxt.Lines(425) & vbNewLine & TraduzioneLinguaTxt.Lines(426)
        Impostazioni.GeneraleCheck5.Text = TraduzioneLinguaTxt.Lines(427) & vbNewLine & TraduzioneLinguaTxt.Lines(428)
        Impostazioni.GeneraleCheck6.Text = TraduzioneLinguaTxt.Lines(429)
        Impostazioni.AutoSaveCheck0.Text = TraduzioneLinguaTxt.Lines(430)
        Impostazioni.Label1.Text = TraduzioneLinguaTxt.Lines(431)
        Impostazioni.Label2.Text = TraduzioneLinguaTxt.Lines(432)
        Impostazioni.HTML1m.Text = TraduzioneLinguaTxt.Lines(433)
        Impostazioni.HTML5m.Text = TraduzioneLinguaTxt.Lines(434)
        Impostazioni.HTML10m.Text = TraduzioneLinguaTxt.Lines(435)
        Impostazioni.HTML30m.Text = TraduzioneLinguaTxt.Lines(436)
        Impostazioni.HTML1h.Text = TraduzioneLinguaTxt.Lines(437)
        Impostazioni.HTML2h.Text = TraduzioneLinguaTxt.Lines(438)
        Impostazioni.HTMLPersonalizzato.Text = TraduzioneLinguaTxt.Lines(439)
        Impostazioni.HTMLPersonalizzaOkButton.Text = TraduzioneLinguaTxt.Lines(440)
        Impostazioni.CSS1m.Text = TraduzioneLinguaTxt.Lines(441)
        Impostazioni.CSS5m.Text = TraduzioneLinguaTxt.Lines(442)
        Impostazioni.CSS10m.Text = TraduzioneLinguaTxt.Lines(443)
        Impostazioni.CSS30m.Text = TraduzioneLinguaTxt.Lines(444)
        Impostazioni.CSS1h.Text = TraduzioneLinguaTxt.Lines(445)
        Impostazioni.CSS2h.Text = TraduzioneLinguaTxt.Lines(446)
        Impostazioni.CSSPersonalizzato.Text = TraduzioneLinguaTxt.Lines(447)
        Impostazioni.CSSPersonalizzaOkButton.Text = TraduzioneLinguaTxt.Lines(448)
        Impostazioni.InterfacciaCheck0.Text = TraduzioneLinguaTxt.Lines(449)
        Impostazioni.InterfacciaCheck1.Text = TraduzioneLinguaTxt.Lines(450)
        Impostazioni.InterfacciaCheck2.Text = TraduzioneLinguaTxt.Lines(451)
        Impostazioni.PrivacyCheck0.Text = TraduzioneLinguaTxt.Lines(452)
        Impostazioni.AvanzateLabel0.Text = TraduzioneLinguaTxt.Lines(453)
        Impostazioni.AvanzateRadio0.Text = TraduzioneLinguaTxt.Lines(454)
        Impostazioni.AvanzateRadio1.Text = TraduzioneLinguaTxt.Lines(455)
        Impostazioni.AvanzateRadio2.Text = TraduzioneLinguaTxt.Lines(456)
        Impostazioni.Button10.Text = TraduzioneLinguaTxt.Lines(457)
        Impostazioni.AvanzateLabel1.Text = TraduzioneLinguaTxt.Lines(458)
        Impostazioni.AvanzatePercorsoRadio0.Text = TraduzioneLinguaTxt.Lines(459)
        Impostazioni.AvanzatePercorsoRadio1.Text = TraduzioneLinguaTxt.Lines(460)
        Impostazioni.Button1.Text = TraduzioneLinguaTxt.Lines(461)

        Impostazioni.GeneraleButton.Text = TraduzioneLinguaTxt.Lines(755)
        Impostazioni.AutoSaveButton.Text = TraduzioneLinguaTxt.Lines(756)
        Impostazioni.InterfacciaButton.Text = TraduzioneLinguaTxt.Lines(757)
        Impostazioni.PrivacyButton.Text = TraduzioneLinguaTxt.Lines(758)
        Impostazioni.AvanzateButton.Text = TraduzioneLinguaTxt.Lines(759)

        Impostazioni.ShowDialog()
    End Function

    Public Function checedinuovo_func()
        chiudi_tutti_menu()

        Dim currentversion As String = Application.ProductVersion
        currentversion = currentversion.Replace(".", "-")
        Process.Start("https://www.saveriomorelli.com/mycodeeditor/News/" & currentversion & "/")
    End Function

    Public Function aiuto_func()
        chiudi_tutti_menu()

        Aiuto.Text = TraduzioneLinguaTxt.Lines(131)
        Aiuto.Cerca_Button_TextBox.Text = TraduzioneLinguaTxt.Lines(132)

        Aiuto.ShowDialog()
    End Function

    Public Function contattaci_func()
        chiudi_tutti_menu()

        SegnalazioneProblema.Text = TraduzioneLinguaTxt.Lines(301)
        SegnalazioneProblema.NomeCognomeText.Text = TraduzioneLinguaTxt.Lines(542)
        SegnalazioneProblema.EmailText.Text = TraduzioneLinguaTxt.Lines(543)
        SegnalazioneProblema.MotivoText.Text = TraduzioneLinguaTxt.Lines(544)
        SegnalazioneProblema.MessaggioText.Text = TraduzioneLinguaTxt.Lines(545)
        SegnalazioneProblema.Button1.Text = TraduzioneLinguaTxt.Lines(546)
        SegnalazioneProblema.AccettoCondCheck.Text = TraduzioneLinguaTxt.Lines(547) & vbNewLine & TraduzioneLinguaTxt.Lines(548)
        SegnalazioneProblema.Button2.Text = TraduzioneLinguaTxt.Lines(549)
        SegnalazioneProblema.Button48.Text = TraduzioneLinguaTxt.Lines(550)
        SegnalazioneProblema.MotivoText.Enabled = True
        SegnalazioneProblema.ShowDialog()
    End Function

    Public Function segnalazione_func()
        chiudi_tutti_menu()

        SegnalazioneProblema.Text = TraduzioneLinguaTxt.Lines(301)
        SegnalazioneProblema.NomeCognomeText.Text = TraduzioneLinguaTxt.Lines(542)
        SegnalazioneProblema.EmailText.Text = TraduzioneLinguaTxt.Lines(543)
        SegnalazioneProblema.MotivoText.Text = TraduzioneLinguaTxt.Lines(307)
        SegnalazioneProblema.MessaggioText.Text = TraduzioneLinguaTxt.Lines(545)
        SegnalazioneProblema.Button1.Text = TraduzioneLinguaTxt.Lines(546)
        SegnalazioneProblema.AccettoCondCheck.Text = TraduzioneLinguaTxt.Lines(547) & vbNewLine & TraduzioneLinguaTxt.Lines(548)
        SegnalazioneProblema.Button2.Text = TraduzioneLinguaTxt.Lines(549)
        SegnalazioneProblema.Button48.Text = TraduzioneLinguaTxt.Lines(550)
        SegnalazioneProblema.MotivoText.ForeColor = Color.DarkRed
        SegnalazioneProblema.MotivoText.Enabled = False
        SegnalazioneProblema.ShowDialog()
    End Function

    Public Function supporto_func()
        chiudi_tutti_menu()

        SegnalazioneProblema.Text = TraduzioneLinguaTxt.Lines(301)
        SegnalazioneProblema.NomeCognomeText.Text = TraduzioneLinguaTxt.Lines(542)
        SegnalazioneProblema.EmailText.Text = TraduzioneLinguaTxt.Lines(543)
        SegnalazioneProblema.MotivoText.Text = TraduzioneLinguaTxt.Lines(781)
        SegnalazioneProblema.MessaggioText.Text = TraduzioneLinguaTxt.Lines(545)
        SegnalazioneProblema.Button1.Text = TraduzioneLinguaTxt.Lines(546)
        SegnalazioneProblema.AccettoCondCheck.Text = TraduzioneLinguaTxt.Lines(547) & vbNewLine & TraduzioneLinguaTxt.Lines(548)
        SegnalazioneProblema.Button2.Text = TraduzioneLinguaTxt.Lines(549)
        SegnalazioneProblema.Button48.Text = TraduzioneLinguaTxt.Lines(550)
        SegnalazioneProblema.MotivoText.ForeColor = Color.DarkRed
        SegnalazioneProblema.MotivoText.Enabled = False
        SegnalazioneProblema.ShowDialog()
    End Function

    Public Function riconoscimenti_func()
        chiudi_tutti_menu()

        Ringraziamenti.ShowDialog()
    End Function

    Public Function controlloaggiornamenti_func()
        chiudi_tutti_menu()

        aggiornamentoscaricaautomaticamenteavvio = False
        ControlloAggiornamenti.Text = TraduzioneLinguaTxt.Lines(347)
        ControlloAggiornamenti.Button1.Text = TraduzioneLinguaTxt.Lines(348)
        ControlloAggiornamenti.ScaricaDopoButton.Text = TraduzioneLinguaTxt.Lines(349)
        ControlloAggiornamenti.ScaricaButton.Text = TraduzioneLinguaTxt.Lines(350)
        ControlloAggiornamenti.InstallaButton.Text = TraduzioneLinguaTxt.Lines(351)
        ControlloAggiornamenti.SaveFileDialog1.FileName = TraduzioneLinguaTxt.Lines(352)
        ControlloAggiornamenti.SaveFileDialog1.Title = TraduzioneLinguaTxt.Lines(353)
        ControlloAggiornamenti.WindowState = FormWindowState.Normal
        ControlloAggiornamenti.Show()
    End Function

    Public Function raggrupparighe_func()
        chiudi_tutti_menu()

        If buttproghtml.BackColor = Color.Red Then
            FastColoredTextBox1.CollapseBlock(FastColoredTextBox1.Selection.Start.iLine, FastColoredTextBox1.Selection.End.iLine)
        Else
            CSSFTB.CollapseBlock(CSSFTB.Selection.Start.iLine, CSSFTB.Selection.End.iLine)
        End If
    End Function

    Private Sub MyCEF_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If buttprogcss.Text = ("CSS*") Or buttproghtml.Text = ("HTML*") Then
            EsciMessaggio.Text = ("Vuoi salvare il progetto prima di uscire?")
            EsciMessaggio.Button1.Text = ("Il progetto attuale non è stato salvato. Vuoi farlo prima di uscire?" & vbNewLine & "NOTA: Non sarà possibile recuperare il progetto se non lo si salva.")
            EsciMessaggio.Tipo.Text = ("Esci")
            EsciMessaggio.ShowDialog()
            e.Cancel = True
        Else
            If Me.WindowState = FormWindowState.Normal Then
                My.Settings.impostazionistatofinestra = "norm"
                My.Settings.Save()
            ElseIf Me.WindowState = FormWindowState.Maximized Then
                My.Settings.impostazionistatofinestra = "mass"
                My.Settings.Save()
            End If
            e.Cancel = False
        End If
    End Sub
    Function bottonefun()
        'bottone
        chiudi_tutti_menu()

        Bottone.Text = TraduzioneLinguaTxt.Lines(161)
        Bottone.Button1.Text = TraduzioneLinguaTxt.Lines(162)
        Bottone.Button9.Text = TraduzioneLinguaTxt.Lines(163)
        Bottone.Informazioni.SetToolTip(Bottone.Button9, TraduzioneLinguaTxt.Lines(164)) 'tooltip
        Bottone.Button10.Text = TraduzioneLinguaTxt.Lines(165)
        Bottone.Informazioni.SetToolTip(Bottone.Button10, TraduzioneLinguaTxt.Lines(166)) 'tooltip
        Bottone.Button2.Text = TraduzioneLinguaTxt.Lines(167)
        Bottone.Button16.Text = TraduzioneLinguaTxt.Lines(168)
        Bottone.Button90.Text = TraduzioneLinguaTxt.Lines(169)
        Bottone.Informazioni.SetToolTip(Bottone.Panel10, TraduzioneLinguaTxt.Lines(170)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox209, TraduzioneLinguaTxt.Lines(171)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox204, TraduzioneLinguaTxt.Lines(172)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox119, TraduzioneLinguaTxt.Lines(173)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox124, TraduzioneLinguaTxt.Lines(174)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox1, TraduzioneLinguaTxt.Lines(175)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox9, TraduzioneLinguaTxt.Lines(176)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox21, TraduzioneLinguaTxt.Lines(177)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox80, TraduzioneLinguaTxt.Lines(178)) 'tooltip
        Bottone.Button8.Text = TraduzioneLinguaTxt.Lines(179)
        Bottone.Label1.Text = TraduzioneLinguaTxt.Lines(180)
        Bottone.Informazioni.SetToolTip(Bottone.Label1, TraduzioneLinguaTxt.Lines(181)) 'tooltip
        Bottone.Button34.Text = TraduzioneLinguaTxt.Lines(182)
        Bottone.Button14.Text = TraduzioneLinguaTxt.Lines(183)
        Bottone.Label2.Text = TraduzioneLinguaTxt.Lines(184)
        Bottone.Informazioni.SetToolTip(Bottone.Label2, TraduzioneLinguaTxt.Lines(185)) 'tooltip
        Bottone.Button21.Text = TraduzioneLinguaTxt.Lines(186)
        Bottone.Informazioni.SetToolTip(Bottone.Button21, TraduzioneLinguaTxt.Lines(187)) 'tooltip
        Bottone.Button27.Text = TraduzioneLinguaTxt.Lines(188)
        Bottone.Informazioni.SetToolTip(Bottone.Button27, TraduzioneLinguaTxt.Lines(189)) 'tooltip
        Bottone.Button31.Text = TraduzioneLinguaTxt.Lines(190)
        Bottone.Informazioni.SetToolTip(Bottone.Button31, TraduzioneLinguaTxt.Lines(191)) 'tooltip
        Bottone.Button29.Text = TraduzioneLinguaTxt.Lines(192)
        Bottone.Informazioni.SetToolTip(Bottone.Button29, TraduzioneLinguaTxt.Lines(193)) 'tooltip
        Bottone.Button38.Text = TraduzioneLinguaTxt.Lines(194)
        Bottone.Button41.Text = TraduzioneLinguaTxt.Lines(195)
        Bottone.Button40.Text = TraduzioneLinguaTxt.Lines(196)
        Bottone.Button54.Text = TraduzioneLinguaTxt.Lines(197)
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox6, TraduzioneLinguaTxt.Lines(198)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox4, TraduzioneLinguaTxt.Lines(199)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox3, TraduzioneLinguaTxt.Lines(200)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox5, TraduzioneLinguaTxt.Lines(201)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox11, TraduzioneLinguaTxt.Lines(202)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox10, TraduzioneLinguaTxt.Lines(203)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox8, TraduzioneLinguaTxt.Lines(204)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox7, TraduzioneLinguaTxt.Lines(205)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.Panel15, TraduzioneLinguaTxt.Lines(206)) 'tooltip
        Bottone.Button42.Text = TraduzioneLinguaTxt.Lines(207)
        Bottone.Button52.Text = TraduzioneLinguaTxt.Lines(208)
        Bottone.Informazioni.SetToolTip(Bottone.Panel18, TraduzioneLinguaTxt.Lines(209)) 'tooltip
        Bottone.Label3.Text = TraduzioneLinguaTxt.Lines(210)
        Bottone.Button37.Text = TraduzioneLinguaTxt.Lines(211)
        Bottone.Informazioni.SetToolTip(Bottone.Button37, TraduzioneLinguaTxt.Lines(212)) 'tooltip
        Bottone.Button36.Text = TraduzioneLinguaTxt.Lines(213)
        Bottone.Informazioni.SetToolTip(Bottone.Button36, TraduzioneLinguaTxt.Lines(214)) 'tooltip
        Bottone.Button35.Text = TraduzioneLinguaTxt.Lines(215)
        Bottone.Informazioni.SetToolTip(Bottone.Button35, TraduzioneLinguaTxt.Lines(216)) 'tooltip
        Bottone.Button7.Text = TraduzioneLinguaTxt.Lines(217)
        Bottone.Informazioni.SetToolTip(Bottone.Button7, TraduzioneLinguaTxt.Lines(218)) 'tooltip
        Bottone.Label4.Text = TraduzioneLinguaTxt.Lines(219)
        Bottone.Button15.Text = TraduzioneLinguaTxt.Lines(220)
        Bottone.Button43.Text = TraduzioneLinguaTxt.Lines(221)
        Bottone.Informazioni.SetToolTip(Bottone.Panel17, TraduzioneLinguaTxt.Lines(222)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox15, TraduzioneLinguaTxt.Lines(223)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox13, TraduzioneLinguaTxt.Lines(224)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox12, TraduzioneLinguaTxt.Lines(225)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox14, TraduzioneLinguaTxt.Lines(226)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox19, TraduzioneLinguaTxt.Lines(227)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox18, TraduzioneLinguaTxt.Lines(228)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox17, TraduzioneLinguaTxt.Lines(229)) 'tooltip
        Bottone.Informazioni.SetToolTip(Bottone.PictureBox16, TraduzioneLinguaTxt.Lines(230)) 'tooltip
        Bottone.Button55.Text = TraduzioneLinguaTxt.Lines(231)
        Bottone.Button11.Text = TraduzioneLinguaTxt.Lines(232)
        Bottone.Button47.Text = TraduzioneLinguaTxt.Lines(233)
        Bottone.Informazioni.SetToolTip(Bottone.Button53, TraduzioneLinguaTxt.Lines(234)) 'tooltip
        Bottone.Button13.Text = TraduzioneLinguaTxt.Lines(235)
        Bottone.Button17.Text = TraduzioneLinguaTxt.Lines(236)
        Bottone.Informazioni.SetToolTip(Bottone.Button17, TraduzioneLinguaTxt.Lines(237)) 'tooltip
        Bottone.Button18.Text = TraduzioneLinguaTxt.Lines(238)
        Bottone.Informazioni.SetToolTip(Bottone.Button18, TraduzioneLinguaTxt.Lines(239)) 'tooltip
        Bottone.Button19.Text = TraduzioneLinguaTxt.Lines(240)
        Bottone.Informazioni.SetToolTip(Bottone.Button19, TraduzioneLinguaTxt.Lines(241) & vbNewLine & TraduzioneLinguaTxt.Lines(242)) 'tooltip
        Bottone.Button20.Text = TraduzioneLinguaTxt.Lines(243)
        Bottone.Informazioni.SetToolTip(Bottone.Button20, TraduzioneLinguaTxt.Lines(244) & vbNewLine & TraduzioneLinguaTxt.Lines(245)) 'tooltip
        Bottone.Button32.Text = TraduzioneLinguaTxt.Lines(246)
        Bottone.Button33.Text = TraduzioneLinguaTxt.Lines(247)
        Bottone.Label5.Text = TraduzioneLinguaTxt.Lines(248)
        Bottone.Informazioni.SetToolTip(Bottone.Label5, TraduzioneLinguaTxt.Lines(249)) 'tooltip
        Bottone.Button12.Text = TraduzioneLinguaTxt.Lines(250)
        Bottone.Button50.Text = TraduzioneLinguaTxt.Lines(251)
        Bottone.Button48.Text = TraduzioneLinguaTxt.Lines(252)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        Bottone.Show()
    End Function
    Function collegamentofun()
        'collegamento
        chiudi_tutti_menu()

        Collegamento.Text = TraduzioneLinguaTxt.Lines(262)
        Collegamento.Button1.Text = TraduzioneLinguaTxt.Lines(263)
        Collegamento.Button9.Text = TraduzioneLinguaTxt.Lines(264)
        Collegamento.Button10.Text = TraduzioneLinguaTxt.Lines(265)
        Collegamento.Button2.Text = TraduzioneLinguaTxt.Lines(266)
        Collegamento.Button16.Text = TraduzioneLinguaTxt.Lines(267)
        Collegamento.Button90.Text = TraduzioneLinguaTxt.Lines(268)
        Collegamento.Button54.Text = TraduzioneLinguaTxt.Lines(269)
        Collegamento.Button49.Text = TraduzioneLinguaTxt.Lines(270)
        Collegamento.Button33.Text = TraduzioneLinguaTxt.Lines(271)
        Collegamento.Button11.Text = TraduzioneLinguaTxt.Lines(272)
        Collegamento.Button47.Text = TraduzioneLinguaTxt.Lines(273)
        Collegamento.Button13.Text = TraduzioneLinguaTxt.Lines(274)
        Collegamento.Button17.Text = TraduzioneLinguaTxt.Lines(275)
        Collegamento.Button18.Text = TraduzioneLinguaTxt.Lines(276)
        Collegamento.Button19.Text = TraduzioneLinguaTxt.Lines(277)
        Collegamento.Button20.Text = TraduzioneLinguaTxt.Lines(278)
        Collegamento.Button32.Text = TraduzioneLinguaTxt.Lines(279)
        Collegamento.Button48.Text = TraduzioneLinguaTxt.Lines(280)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        Collegamento.Show()
    End Function
    Function commentofun()
        'commento
        chiudi_tutti_menu()

        Commento.Text = TraduzioneLinguaTxt.Lines(296)
        Commento.Button1.Text = TraduzioneLinguaTxt.Lines(297)
        Commento.Button9.Text = TraduzioneLinguaTxt.Lines(298)
        Commento.Button48.Text = TraduzioneLinguaTxt.Lines(299)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        Commento.Show()
    End Function
    Function contenitorefun()
        'contenitore
        chiudi_tutti_menu()

        Contenitore.Text = TraduzioneLinguaTxt.Lines(315)
        Contenitore.Button1.Text = TraduzioneLinguaTxt.Lines(316)
        Contenitore.Button2.Text = TraduzioneLinguaTxt.Lines(317)
        Contenitore.Button16.Text = TraduzioneLinguaTxt.Lines(318)
        Contenitore.Button90.Text = TraduzioneLinguaTxt.Lines(319)
        Contenitore.Button8.Text = TraduzioneLinguaTxt.Lines(320)
        Contenitore.Button10.Text = TraduzioneLinguaTxt.Lines(321)
        Contenitore.Button9.Text = TraduzioneLinguaTxt.Lines(322)
        Contenitore.Button34.Text = TraduzioneLinguaTxt.Lines(323)
        Contenitore.Button14.Text = TraduzioneLinguaTxt.Lines(324)
        Contenitore.Button12.Text = TraduzioneLinguaTxt.Lines(325)
        Contenitore.Label3.Text = TraduzioneLinguaTxt.Lines(326)
        Contenitore.Button37.Text = TraduzioneLinguaTxt.Lines(327)
        Contenitore.Button36.Text = TraduzioneLinguaTxt.Lines(328)
        Contenitore.Button35.Text = TraduzioneLinguaTxt.Lines(329)
        Contenitore.Button7.Text = TraduzioneLinguaTxt.Lines(330)
        Contenitore.Label2.Text = TraduzioneLinguaTxt.Lines(331)
        Contenitore.Button21.Text = TraduzioneLinguaTxt.Lines(332)
        Contenitore.Button27.Text = TraduzioneLinguaTxt.Lines(333)
        Contenitore.Button31.Text = TraduzioneLinguaTxt.Lines(334)
        Contenitore.Button29.Text = TraduzioneLinguaTxt.Lines(335)
        Contenitore.Button38.Text = TraduzioneLinguaTxt.Lines(336)
        Contenitore.Button41.Text = TraduzioneLinguaTxt.Lines(337)
        Contenitore.Button40.Text = TraduzioneLinguaTxt.Lines(338)
        Contenitore.Button42.Text = TraduzioneLinguaTxt.Lines(339)
        Contenitore.Button52.Text = TraduzioneLinguaTxt.Lines(340)
        Contenitore.Button48.Text = TraduzioneLinguaTxt.Lines(341)
        Contenitore.OpenFileDialog1.Filter = TraduzioneLinguaTxt.Lines(342)
        Contenitore.OpenFileDialog1.Title = TraduzioneLinguaTxt.Lines(343)
        Contenitore.CopiaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(344)
        Contenitore.IncollaToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(345)
        Contenitore.EliminaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(346)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        Contenitore.Show()
    End Function
    Function descrizionefun()
        'descrizione
        chiudi_tutti_menu()

        Descrizione.Text = TraduzioneLinguaTxt.Lines(354)
        Descrizione.Button1.Text = TraduzioneLinguaTxt.Lines(355)
        Descrizione.Button9.Text = TraduzioneLinguaTxt.Lines(356)
        Descrizione.Button2.Text = TraduzioneLinguaTxt.Lines(357)
        Descrizione.Button33.Text = TraduzioneLinguaTxt.Lines(358)
        Descrizione.Label3.Text = TraduzioneLinguaTxt.Lines(359)
        Descrizione.Button37.Text = TraduzioneLinguaTxt.Lines(360)
        Descrizione.Button36.Text = TraduzioneLinguaTxt.Lines(361)
        Descrizione.Button35.Text = TraduzioneLinguaTxt.Lines(362)
        Descrizione.Button7.Text = TraduzioneLinguaTxt.Lines(363)
        Descrizione.Label4.Text = TraduzioneLinguaTxt.Lines(364)
        Descrizione.Button15.Text = TraduzioneLinguaTxt.Lines(365)
        Descrizione.Button43.Text = TraduzioneLinguaTxt.Lines(366)
        Descrizione.Button55.Text = TraduzioneLinguaTxt.Lines(367)
        Descrizione.Button11.Text = TraduzioneLinguaTxt.Lines(368)
        Descrizione.Button47.Text = TraduzioneLinguaTxt.Lines(369)
        Descrizione.Button13.Text = TraduzioneLinguaTxt.Lines(370)
        Descrizione.Button17.Text = TraduzioneLinguaTxt.Lines(371)
        Descrizione.Button18.Text = TraduzioneLinguaTxt.Lines(372)
        Descrizione.Button19.Text = TraduzioneLinguaTxt.Lines(373)
        Descrizione.Button20.Text = TraduzioneLinguaTxt.Lines(374)
        Descrizione.Button32.Text = TraduzioneLinguaTxt.Lines(375)
        Descrizione.Button48.Text = TraduzioneLinguaTxt.Lines(376)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        Descrizione.Show()
    End Function
    Function elencofun()
        'elenco
        chiudi_tutti_menu()

        Elenco.Text = TraduzioneLinguaTxt.Lines(377)
        Elenco.Button1.Text = TraduzioneLinguaTxt.Lines(378)
        Elenco.Button9.Text = TraduzioneLinguaTxt.Lines(379)
        Elenco.Button2.Text = TraduzioneLinguaTxt.Lines(380)
        Elenco.Button33.Text = TraduzioneLinguaTxt.Lines(381)
        Elenco.Button14.Text = TraduzioneLinguaTxt.Lines(382)
        Elenco.Button8.Text = TraduzioneLinguaTxt.Lines(383)
        Elenco.Button10.Text = TraduzioneLinguaTxt.Lines(384)
        Elenco.Label3.Text = TraduzioneLinguaTxt.Lines(385)
        Elenco.Button37.Text = TraduzioneLinguaTxt.Lines(386)
        Elenco.Button36.Text = TraduzioneLinguaTxt.Lines(387)
        Elenco.Button35.Text = TraduzioneLinguaTxt.Lines(388)
        Elenco.Button7.Text = TraduzioneLinguaTxt.Lines(389)
        Elenco.Label4.Text = TraduzioneLinguaTxt.Lines(390)
        Elenco.Button15.Text = TraduzioneLinguaTxt.Lines(391)
        Elenco.Button43.Text = TraduzioneLinguaTxt.Lines(392)
        Elenco.Button55.Text = TraduzioneLinguaTxt.Lines(393)
        Elenco.Button11.Text = TraduzioneLinguaTxt.Lines(394)
        Elenco.Button47.Text = TraduzioneLinguaTxt.Lines(395)
        Elenco.Button13.Text = TraduzioneLinguaTxt.Lines(396)
        Elenco.Button17.Text = TraduzioneLinguaTxt.Lines(397)
        Elenco.Button18.Text = TraduzioneLinguaTxt.Lines(398)
        Elenco.Button19.Text = TraduzioneLinguaTxt.Lines(399)
        Elenco.Button20.Text = TraduzioneLinguaTxt.Lines(400)
        Elenco.Button32.Text = TraduzioneLinguaTxt.Lines(401)
        Elenco.Button48.Text = TraduzioneLinguaTxt.Lines(402)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        Elenco.Show()
    End Function
    Function immaginefun()
        'immagine
        chiudi_tutti_menu()

        Immagine.Text = TraduzioneLinguaTxt.Lines(406)
        Immagine.Button1.Text = TraduzioneLinguaTxt.Lines(407)
        Immagine.Button10.Text = TraduzioneLinguaTxt.Lines(408)
        Immagine.Button2.Text = TraduzioneLinguaTxt.Lines(409)
        Immagine.Button11.Text = TraduzioneLinguaTxt.Lines(410)
        Immagine.Button34.Text = TraduzioneLinguaTxt.Lines(411)
        Immagine.Button14.Text = TraduzioneLinguaTxt.Lines(412)
        Immagine.Button12.Text = TraduzioneLinguaTxt.Lines(413)
        Immagine.Label3.Text = TraduzioneLinguaTxt.Lines(414)
        Immagine.Button37.Text = TraduzioneLinguaTxt.Lines(415)
        Immagine.Button36.Text = TraduzioneLinguaTxt.Lines(416)
        Immagine.Button35.Text = TraduzioneLinguaTxt.Lines(417)
        Immagine.Button7.Text = TraduzioneLinguaTxt.Lines(418)
        Immagine.Button48.Text = TraduzioneLinguaTxt.Lines(419)

        Immagine.Show()
    End Function
    Function paragrafofun()
        'paragrafo
        chiudi_tutti_menu()

        Paragrafo.Text = TraduzioneLinguaTxt.Lines(514)
        Paragrafo.Button1.Text = TraduzioneLinguaTxt.Lines(515)
        Paragrafo.Button9.Text = TraduzioneLinguaTxt.Lines(516)
        Paragrafo.Button2.Text = TraduzioneLinguaTxt.Lines(517)
        Paragrafo.Button33.Text = TraduzioneLinguaTxt.Lines(518)
        Paragrafo.Label3.Text = TraduzioneLinguaTxt.Lines(519)
        Paragrafo.Button37.Text = TraduzioneLinguaTxt.Lines(520)
        Paragrafo.Button36.Text = TraduzioneLinguaTxt.Lines(521)
        Paragrafo.Button35.Text = TraduzioneLinguaTxt.Lines(522)
        Paragrafo.Button7.Text = TraduzioneLinguaTxt.Lines(523)
        Paragrafo.Label4.Text = TraduzioneLinguaTxt.Lines(524)
        Paragrafo.Button15.Text = TraduzioneLinguaTxt.Lines(525)
        Paragrafo.Button43.Text = TraduzioneLinguaTxt.Lines(526)
        Paragrafo.Button55.Text = TraduzioneLinguaTxt.Lines(527)
        Paragrafo.Button11.Text = TraduzioneLinguaTxt.Lines(528)
        Paragrafo.Button47.Text = TraduzioneLinguaTxt.Lines(529)
        Paragrafo.Button13.Text = TraduzioneLinguaTxt.Lines(530)
        Paragrafo.Button17.Text = TraduzioneLinguaTxt.Lines(531)
        Paragrafo.Button18.Text = TraduzioneLinguaTxt.Lines(532)
        Paragrafo.Button19.Text = TraduzioneLinguaTxt.Lines(533)
        Paragrafo.Button20.Text = TraduzioneLinguaTxt.Lines(534)
        Paragrafo.Button32.Text = TraduzioneLinguaTxt.Lines(535)
        Paragrafo.Button48.Text = TraduzioneLinguaTxt.Lines(536)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        Paragrafo.Show()
    End Function
    Function separatorefun()
        'separatore
        chiudi_tutti_menu()

        Separatore.Text = TraduzioneLinguaTxt.Lines(551)
        Separatore.Button1.Text = TraduzioneLinguaTxt.Lines(552)
        Separatore.Button2.Text = TraduzioneLinguaTxt.Lines(553)
        Separatore.Button15.Text = TraduzioneLinguaTxt.Lines(554)
        Separatore.Button43.Text = TraduzioneLinguaTxt.Lines(555)
        Separatore.Button55.Text = TraduzioneLinguaTxt.Lines(556)
        Separatore.Button12.Text = TraduzioneLinguaTxt.Lines(557)
        Separatore.Button32.Text = TraduzioneLinguaTxt.Lines(558)
        Separatore.Button10.Text = TraduzioneLinguaTxt.Lines(559)
        Separatore.Label3.Text = TraduzioneLinguaTxt.Lines(560)
        Separatore.Button37.Text = TraduzioneLinguaTxt.Lines(561)
        Separatore.Button36.Text = TraduzioneLinguaTxt.Lines(562)
        Separatore.Button35.Text = TraduzioneLinguaTxt.Lines(563)
        Separatore.Button7.Text = TraduzioneLinguaTxt.Lines(564)
        Separatore.Button48.Text = TraduzioneLinguaTxt.Lines(565)

        Separatore.Show()
    End Function
    Function sottotitolofun()
        'sottotitolo
        chiudi_tutti_menu()

        Sottotitolo.Text = TraduzioneLinguaTxt.Lines(575)
        Sottotitolo.Button1.Text = TraduzioneLinguaTxt.Lines(576)
        Sottotitolo.Button9.Text = TraduzioneLinguaTxt.Lines(577)
        Sottotitolo.Button2.Text = TraduzioneLinguaTxt.Lines(578)
        Sottotitolo.Button33.Text = TraduzioneLinguaTxt.Lines(579)
        Sottotitolo.Label3.Text = TraduzioneLinguaTxt.Lines(580)
        Sottotitolo.Button37.Text = TraduzioneLinguaTxt.Lines(581)
        Sottotitolo.Button36.Text = TraduzioneLinguaTxt.Lines(582)
        Sottotitolo.Button35.Text = TraduzioneLinguaTxt.Lines(583)
        Sottotitolo.Button7.Text = TraduzioneLinguaTxt.Lines(584)
        Sottotitolo.Label4.Text = TraduzioneLinguaTxt.Lines(585)
        Sottotitolo.Button15.Text = TraduzioneLinguaTxt.Lines(586)
        Sottotitolo.Button43.Text = TraduzioneLinguaTxt.Lines(587)
        Sottotitolo.Button55.Text = TraduzioneLinguaTxt.Lines(588)
        Sottotitolo.Button11.Text = TraduzioneLinguaTxt.Lines(589)
        Sottotitolo.Button47.Text = TraduzioneLinguaTxt.Lines(590)
        Sottotitolo.Button13.Text = TraduzioneLinguaTxt.Lines(591)
        Sottotitolo.Button17.Text = TraduzioneLinguaTxt.Lines(592)
        Sottotitolo.Button18.Text = TraduzioneLinguaTxt.Lines(593)
        Sottotitolo.Button19.Text = TraduzioneLinguaTxt.Lines(594)
        Sottotitolo.Button20.Text = TraduzioneLinguaTxt.Lines(595)
        Sottotitolo.Button32.Text = TraduzioneLinguaTxt.Lines(596)
        Sottotitolo.Button48.Text = TraduzioneLinguaTxt.Lines(597)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        Sottotitolo.Show()
    End Function
    Function tabellafun()
        'tabella
        chiudi_tutti_menu()

        Tabella.Text = TraduzioneLinguaTxt.Lines(604)
        Tabella.Button1.Text = TraduzioneLinguaTxt.Lines(605)
        Tabella.Button22.Text = TraduzioneLinguaTxt.Lines(606)
        Tabella.Button14.Text = TraduzioneLinguaTxt.Lines(607)
        Tabella.Button12.Text = TraduzioneLinguaTxt.Lines(608)
        Tabella.Button2.Text = TraduzioneLinguaTxt.Lines(609)
        Tabella.Button16.Text = TraduzioneLinguaTxt.Lines(610)
        Tabella.Button90.Text = TraduzioneLinguaTxt.Lines(611)
        Tabella.Button8.Text = TraduzioneLinguaTxt.Lines(612)
        Tabella.Label4.Text = TraduzioneLinguaTxt.Lines(613)
        Tabella.Button15.Text = TraduzioneLinguaTxt.Lines(614)
        Tabella.Button43.Text = TraduzioneLinguaTxt.Lines(615)
        Tabella.Button55.Text = TraduzioneLinguaTxt.Lines(616)
        Tabella.Button11.Text = TraduzioneLinguaTxt.Lines(617)
        Tabella.Button47.Text = TraduzioneLinguaTxt.Lines(618)
        Tabella.Button13.Text = TraduzioneLinguaTxt.Lines(619)
        Tabella.Button17.Text = TraduzioneLinguaTxt.Lines(620)
        Tabella.Button18.Text = TraduzioneLinguaTxt.Lines(621)
        Tabella.Button19.Text = TraduzioneLinguaTxt.Lines(622)
        Tabella.Button20.Text = TraduzioneLinguaTxt.Lines(623)
        Tabella.Button32.Text = TraduzioneLinguaTxt.Lines(624)
        Tabella.Button33.Text = TraduzioneLinguaTxt.Lines(625)
        Tabella.Button57.Text = TraduzioneLinguaTxt.Lines(626)
        Tabella.Label1.Text = TraduzioneLinguaTxt.Lines(627)
        Tabella.Button34.Text = TraduzioneLinguaTxt.Lines(628)
        Tabella.Button49.Text = TraduzioneLinguaTxt.Lines(629)
        Tabella.Label3.Text = TraduzioneLinguaTxt.Lines(630)
        Tabella.Button37.Text = TraduzioneLinguaTxt.Lines(631)
        Tabella.Button36.Text = TraduzioneLinguaTxt.Lines(632)
        Tabella.Button35.Text = TraduzioneLinguaTxt.Lines(633)
        Tabella.Button7.Text = TraduzioneLinguaTxt.Lines(634)
        Tabella.Label2.Text = TraduzioneLinguaTxt.Lines(635)
        Tabella.Button21.Text = TraduzioneLinguaTxt.Lines(636)
        Tabella.Button27.Text = TraduzioneLinguaTxt.Lines(637)
        Tabella.Button31.Text = TraduzioneLinguaTxt.Lines(638)
        Tabella.Button29.Text = TraduzioneLinguaTxt.Lines(639)
        Tabella.Button38.Text = TraduzioneLinguaTxt.Lines(640)
        Tabella.Button41.Text = TraduzioneLinguaTxt.Lines(641)
        Tabella.Button40.Text = TraduzioneLinguaTxt.Lines(642)
        Tabella.Button54.Text = TraduzioneLinguaTxt.Lines(643)
        Tabella.Button42.Text = TraduzioneLinguaTxt.Lines(644)
        Tabella.Button52.Text = TraduzioneLinguaTxt.Lines(645)
        Tabella.CheckBox1.Text = TraduzioneLinguaTxt.Lines(646)
        Tabella.CheckBox2.Text = TraduzioneLinguaTxt.Lines(647)
        Tabella.Button48.Text = TraduzioneLinguaTxt.Lines(648)

        Tabella.Show()
    End Function
    Function testopersonalizzatofun()
        'testo personalizzato
        chiudi_tutti_menu()

        TestoPersonalizzato.Text = TraduzioneLinguaTxt.Lines(649)
        TestoPersonalizzato.Button9.Text = TraduzioneLinguaTxt.Lines(650)
        TestoPersonalizzato.Button1.Text = TraduzioneLinguaTxt.Lines(651)
        TestoPersonalizzato.Button2.Text = TraduzioneLinguaTxt.Lines(652)
        TestoPersonalizzato.Button16.Text = TraduzioneLinguaTxt.Lines(653)
        TestoPersonalizzato.Button90.Text = TraduzioneLinguaTxt.Lines(654)
        TestoPersonalizzato.Button8.Text = TraduzioneLinguaTxt.Lines(655)
        TestoPersonalizzato.Button15.Text = TraduzioneLinguaTxt.Lines(656)
        TestoPersonalizzato.Button43.Text = TraduzioneLinguaTxt.Lines(657)
        TestoPersonalizzato.Button55.Text = TraduzioneLinguaTxt.Lines(658)
        TestoPersonalizzato.Button11.Text = TraduzioneLinguaTxt.Lines(659)
        TestoPersonalizzato.Button47.Text = TraduzioneLinguaTxt.Lines(660)
        TestoPersonalizzato.Button13.Text = TraduzioneLinguaTxt.Lines(661)
        TestoPersonalizzato.Button17.Text = TraduzioneLinguaTxt.Lines(662)
        TestoPersonalizzato.Button18.Text = TraduzioneLinguaTxt.Lines(663)
        TestoPersonalizzato.Button19.Text = TraduzioneLinguaTxt.Lines(664)
        TestoPersonalizzato.Button20.Text = TraduzioneLinguaTxt.Lines(665)
        TestoPersonalizzato.Button32.Text = TraduzioneLinguaTxt.Lines(666)
        TestoPersonalizzato.Button12.Text = TraduzioneLinguaTxt.Lines(667)
        TestoPersonalizzato.Label3.Text = TraduzioneLinguaTxt.Lines(668)
        TestoPersonalizzato.Button37.Text = TraduzioneLinguaTxt.Lines(669)
        TestoPersonalizzato.Button36.Text = TraduzioneLinguaTxt.Lines(670)
        TestoPersonalizzato.Button35.Text = TraduzioneLinguaTxt.Lines(671)
        TestoPersonalizzato.Button7.Text = TraduzioneLinguaTxt.Lines(672)
        TestoPersonalizzato.Button48.Text = TraduzioneLinguaTxt.Lines(673)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        TestoPersonalizzato.Show()
    End Function
    Function titolofun()
        'titolo
        chiudi_tutti_menu()

        Titolo.Text = TraduzioneLinguaTxt.Lines(674)
        Titolo.Button1.Text = TraduzioneLinguaTxt.Lines(675)
        Titolo.Button9.Text = TraduzioneLinguaTxt.Lines(676)
        Titolo.Button2.Text = TraduzioneLinguaTxt.Lines(677)
        Titolo.Button33.Text = TraduzioneLinguaTxt.Lines(678)
        Titolo.Label3.Text = TraduzioneLinguaTxt.Lines(679)
        Titolo.Button37.Text = TraduzioneLinguaTxt.Lines(680)
        Titolo.Button36.Text = TraduzioneLinguaTxt.Lines(681)
        Titolo.Button35.Text = TraduzioneLinguaTxt.Lines(682)
        Titolo.Button7.Text = TraduzioneLinguaTxt.Lines(683)
        Titolo.Label4.Text = TraduzioneLinguaTxt.Lines(684)
        Titolo.Button15.Text = TraduzioneLinguaTxt.Lines(685)
        Titolo.Button43.Text = TraduzioneLinguaTxt.Lines(686)
        Titolo.Button55.Text = TraduzioneLinguaTxt.Lines(687)
        Titolo.Button11.Text = TraduzioneLinguaTxt.Lines(688)
        Titolo.Button47.Text = TraduzioneLinguaTxt.Lines(689)
        Titolo.Button13.Text = TraduzioneLinguaTxt.Lines(690)
        Titolo.Button17.Text = TraduzioneLinguaTxt.Lines(691)
        Titolo.Button18.Text = TraduzioneLinguaTxt.Lines(692)
        Titolo.Button19.Text = TraduzioneLinguaTxt.Lines(693)
        Titolo.Button20.Text = TraduzioneLinguaTxt.Lines(694)
        Titolo.Button32.Text = TraduzioneLinguaTxt.Lines(695)
        Titolo.Button48.Text = TraduzioneLinguaTxt.Lines(696)

        SelezionatoSalvatoDagliAppunti.Text = FastColoredTextBox1.SelectedText
        Titolo.Show()
    End Function
    Function caratterispecialifun()
        'caratteri speciali
        chiudi_tutti_menu()

        CaratteriSpeciali.Text = TraduzioneLinguaTxt.Lines(255)
        CaratteriSpeciali.Label1.Text = TraduzioneLinguaTxt.Lines(256)
        CaratteriSpeciali.Label2.Text = TraduzioneLinguaTxt.Lines(257)
        CaratteriSpeciali.Label3.Text = TraduzioneLinguaTxt.Lines(258)
        CaratteriSpeciali.Label4.Text = TraduzioneLinguaTxt.Lines(259)
        CaratteriSpeciali.Button227.Text = TraduzioneLinguaTxt.Lines(260)
        CaratteriSpeciali.Button10.Text = TraduzioneLinguaTxt.Lines(261)

        CaratteriSpeciali.Show()
    End Function
    Function cercasostituisci()
        'cerca e sostituisci
        chiudi_tutti_menu()

        Sostituisci.Text = TraduzioneLinguaTxt.Lines(566)
        Sostituisci.TextBox9.Text = TraduzioneLinguaTxt.Lines(567)
        Sostituisci.trovatxt = TraduzioneLinguaTxt.Lines(567)
        Sostituisci.TextBox1.Text = TraduzioneLinguaTxt.Lines(568)
        Sostituisci.sostituiscitxt = TraduzioneLinguaTxt.Lines(568)
        Sostituisci.CercaButton.Text = TraduzioneLinguaTxt.Lines(569)
        Sostituisci.SostituisciButton.Text = TraduzioneLinguaTxt.Lines(570)
        Sostituisci.ToolStripMenuItem2.Text = TraduzioneLinguaTxt.Lines(571)
        Sostituisci.ToolStripMenuItem3.Text = TraduzioneLinguaTxt.Lines(572)
        Sostituisci.ToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(573)
        Sostituisci.IncollaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(574)

        Sostituisci.Show()
    End Function
    Function calcalatricefun()
        chiudi_tutti_menu()

        Calcolatrice.DECButton.Text = TraduzioneLinguaTxt.Lines(699)

        Calcolatrice.F2NDButton.Text = TraduzioneLinguaTxt.Lines(700)
        Calcolatrice.Text = TraduzioneLinguaTxt.Lines(701)
        Calcolatrice.ACButton.Text = TraduzioneLinguaTxt.Lines(702)
        Calcolatrice.Button1.Text = TraduzioneLinguaTxt.Lines(703)
        Calcolatrice.DELButton.Text = TraduzioneLinguaTxt.Lines(704)
        Calcolatrice.PiuMenoButton.Text = TraduzioneLinguaTxt.Lines(705)
        Calcolatrice.SetteButton.Text = TraduzioneLinguaTxt.Lines(706)
        Calcolatrice.OttoButton.Text = TraduzioneLinguaTxt.Lines(707)
        Calcolatrice.NoveButton.Text = TraduzioneLinguaTxt.Lines(708)
        Calcolatrice.QuattroButton.Text = TraduzioneLinguaTxt.Lines(709)
        Calcolatrice.CinqueButton.Text = TraduzioneLinguaTxt.Lines(710)
        Calcolatrice.SeiButton.Text = TraduzioneLinguaTxt.Lines(711)
        Calcolatrice.UnoButton.Text = TraduzioneLinguaTxt.Lines(712)
        Calcolatrice.DueButton.Text = TraduzioneLinguaTxt.Lines(713)
        Calcolatrice.TreButton.Text = TraduzioneLinguaTxt.Lines(714)
        Calcolatrice.ZeroButton.Text = TraduzioneLinguaTxt.Lines(715)
        Calcolatrice.PiuButton.Text = TraduzioneLinguaTxt.Lines(716)
        Calcolatrice.PerButton.Text = TraduzioneLinguaTxt.Lines(717)
        Calcolatrice.MenoButton.Text = TraduzioneLinguaTxt.Lines(718)
        Calcolatrice.DivisioneButton.Text = TraduzioneLinguaTxt.Lines(719)
        Calcolatrice.UgualeButton.Text = TraduzioneLinguaTxt.Lines(720)
        Calcolatrice.ElevazioneButton.Text = TraduzioneLinguaTxt.Lines(721)
        Calcolatrice.RadiceButton.Text = TraduzioneLinguaTxt.Lines(722)
        Calcolatrice.PerMilleButton.Text = TraduzioneLinguaTxt.Lines(723)
        Calcolatrice.PerCentoButton.Text = TraduzioneLinguaTxt.Lines(724)
        Calcolatrice.Button2.Text = TraduzioneLinguaTxt.Lines(725)
        Calcolatrice.VirgolaButton.Text = TraduzioneLinguaTxt.Lines(726)
        Calcolatrice.MostraMemoriaButton.Text = TraduzioneLinguaTxt.Lines(727)
        Calcolatrice.MemoriaPiuButton.Text = TraduzioneLinguaTxt.Lines(728)
        Calcolatrice.ToolStripMenuItem4.Text = TraduzioneLinguaTxt.Lines(735)
        Calcolatrice.ToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(736)

        Calcolatrice.Show()
    End Function

    Private Sub Form1_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Select Case Me.WindowState
            Case FormWindowState.Maximized
                'massimizzata
            Case FormWindowState.Normal
                'ridotta a normale
            Case Else
                'ridotta a icona
        End Select

        verifica_percorso()
    End Sub

    <System.Runtime.InteropServices.DllImport("shell32.dll")>
    Shared Sub SHChangeNotify(ByVal wEventId As Integer, ByVal uFlags As Integer, ByVal dwItem1 As Integer, ByVal dwItem2 As Integer)
    End Sub

    ' Extension is the extension to be registered (eg ".cad"
    ' ClassName is the name of the associated class (eg "CADDoc")
    ' Description is the textual description (eg "CAD Document"
    ' ExeProgram is the app that manages that extension (eg "c:\Cad\MyCad.exe")

    Function CreateFileAssociation(ByVal extension As String, ByVal className As String, ByVal description As String, ByVal exeProgram As String) As Boolean
        Const SHCNE_ASSOCCHANGED = &H8000000
        Const SHCNF_IDLIST = 0

        ' ensure that there is a leading dot
        If extension.Substring(0, 1) <> "." Then
            extension = "." & extension
        End If

        Dim key1, key2, key3 As Microsoft.Win32.RegistryKey
        Try
            ' create a value for this key that contains the classname
            key1 = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(extension)
            key1.SetValue("", className)
            ' create a new key for the Class name
            key2 = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(className)
            key2.SetValue("", description)
            ' associate the program to open the files with this extension
            key3 = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(className & "\Shell\Open\Command")
            key3.SetValue("", exeProgram & " ""%1""")
        Catch e As Exception
            Return False
        Finally
            If Not key1 Is Nothing Then key1.Close()
            If Not key2 Is Nothing Then key2.Close()
            If Not key3 Is Nothing Then key3.Close()
        End Try

        ' notify Windows that file associations have changed
        SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_IDLIST, 0, 0)
        Return True
    End Function

    ''ALTEZZA DELLA BARRA DELLE APPLICAZIONI
    Dim altezzaBarraApplicazioni = SystemInformation.CaptionHeight
    ''FINE ALTEZZA DELLA BARRA DELLE APPLICAZIONI

    ''POSIZIONE DELLA BARRA DELLE APPLICAZIONI
    Public Function GetTaskbarLocation() As String
        Dim bounds As Rectangle = Screen.PrimaryScreen.Bounds
        Dim working As Rectangle = Screen.PrimaryScreen.WorkingArea
        If working.Height < bounds.Height And working.Y > 0 Then
            Return "Top"
        ElseIf working.Height < bounds.Height And working.Y = 0 Then
            Return "Bottom"
        ElseIf working.Width < bounds.Width And working.X > 0 Then
            Return "Left"
        ElseIf working.Width < bounds.Width And working.X = 0 Then
            Return "Right"
        Else
            Return Nothing
        End If
    End Function
    ''FINE POSIZIONE DELLA BARRA DELLE APPLICAZIONI

    Public Property AutoCompleteMode As AutoCompleteMode
    Public aggiornamentoscaricaautomaticamenteavvio As Boolean = False
    Private Sub MinionOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.impostazionistatofinestra = "mass" Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf My.Settings.impostazionistatofinestra = "norm" Then
            Me.WindowState = FormWindowState.Normal
        End If
        Dim posizioneBarraApplicazioni = GetTaskbarLocation()
        screenWidth = Screen.PrimaryScreen.Bounds.Width
        screenHeight = Screen.PrimaryScreen.Bounds.Height
        If posizioneBarraApplicazioni = "Bottom" Then screenHeight -= 40
        If posizioneBarraApplicazioni = "Right" Then screenWidth -= 40
        Try
            Dim percorso2 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            If My.Computer.FileSystem.FileExists(percorso2 & "\My Code Editor\Aggiornamenti\MyCE Updater.exe") And My.Computer.FileSystem.FileExists(percorso2 & "\My Code Editor\Aggiornamenti\MyCE.!MCEexe") Then
                Dim Prc As New ProcessStartInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\MyCE Updater.exe")
                Process.Start(Prc)
                End
            ElseIf My.Computer.FileSystem.FileExists(percorso2 & "\My Code Editor\Aggiornamenti\MyCE Updater.exe") Then
                My.Computer.FileSystem.DeleteFile(percorso2 & "\My Code Editor\Aggiornamenti\MyCE Updater.exe")
            End If
        Catch ex As Exception

        End Try

        'MsgBox(Environment.OSVersion.ToString())

        MyCodeEditorAvvio.Show()
        Me.Hide()

        'associazione file a My Code Editor (mcesx, mcerec, mcelang, html)
        Dim percorso As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
        If My.Computer.FileSystem.DirectoryExists(percorso & "\SM Project\My Code Editor\") And My.Computer.FileSystem.FileExists(percorso & "\SM Project\My Code Editor\MyCE.exe") Then
            CreateFileAssociation(".mcesx", "MCESX", "My Code Editor - Impostazioni Avanzate (Settings)", percorso & "\SM Project\My Code Editor\MyCE.exe")
            CreateFileAssociation(".mcerec", "MCEREC", "My Code Editor - Recenti", percorso & "\SM Project\My Code Editor\MyCE.exe")
            CreateFileAssociation(".mcelang", "MCELANG", "My Code Editor - Lingue", percorso & "\SM Project\My Code Editor\MyCE.exe")
            CreateFileAssociation(".html", "HTML", "HypertText Markup Language", percorso & "\SM Project\My Code Editor\MyCE.exe")
        End If

        If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\")
        End If
        IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\", IO.FileAttributes.Hidden)
        'lingua
        Dim p As Point
        p.X = Impostazioni.LinguaPanel.Location.X
        p.Y = 16

        Impostazioni.enguk.BackColor = Color.FromArgb(140, 140, 140)
        Impostazioni.enguk.FlatAppearance.MouseOverBackColor = Color.Gray
        Impostazioni.enguk.FlatAppearance.MouseDownBackColor = Color.Silver
        Impostazioni.ita.BackColor = Color.FromArgb(140, 140, 140)
        Impostazioni.ita.FlatAppearance.MouseOverBackColor = Color.Gray
        Impostazioni.ita.FlatAppearance.MouseDownBackColor = Color.Silver
        Impostazioni.engus.BackColor = Color.FromArgb(140, 140, 140)
        Impostazioni.engus.FlatAppearance.MouseOverBackColor = Color.Gray
        Impostazioni.engus.FlatAppearance.MouseDownBackColor = Color.Silver
        Impostazioni.fra.BackColor = Color.FromArgb(140, 140, 140)
        Impostazioni.fra.FlatAppearance.MouseOverBackColor = Color.Gray
        Impostazioni.fra.FlatAppearance.MouseDownBackColor = Color.Silver
        Impostazioni.ger.BackColor = Color.FromArgb(140, 140, 140)
        Impostazioni.ger.FlatAppearance.MouseOverBackColor = Color.Gray
        Impostazioni.ger.FlatAppearance.MouseDownBackColor = Color.Silver
        Impostazioni.spa.BackColor = Color.FromArgb(140, 140, 140)
        Impostazioni.spa.FlatAppearance.MouseOverBackColor = Color.Gray
        Impostazioni.spa.FlatAppearance.MouseDownBackColor = Color.Silver
        Impostazioni.rus.BackColor = Color.FromArgb(140, 140, 140)
        Impostazioni.rus.FlatAppearance.MouseOverBackColor = Color.Gray
        Impostazioni.rus.FlatAppearance.MouseDownBackColor = Color.Silver

        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\language.mcesx") Then
            LinguaTxt.Text = (System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\language.mcesx"))

            If LinguaTxt.Text = "ENG-US" Then
                'traduzione in americano (inglese-us)
                TraduzioneLinguaTxt.Text = (System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Language\english-us.mcelang"))
                p.Y = 38
                Impostazioni.engus.BackColor = Color.DarkRed
                Impostazioni.engus.FlatAppearance.MouseOverBackColor = Color.DarkRed
                Impostazioni.engus.FlatAppearance.MouseDownBackColor = Color.DarkRed
                Impostazioni.LinguaButton.Text = Impostazioni.engus.Text
            ElseIf LinguaTxt.Text = "ITA-IT" Then
                'traduzione in italiano
                TraduzioneLinguaTxt.Text = (System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Language\italian.mcelang"))
                p.Y = 60
                Impostazioni.ita.BackColor = Color.DarkRed
                Impostazioni.ita.FlatAppearance.MouseOverBackColor = Color.DarkRed
                Impostazioni.ita.FlatAppearance.MouseDownBackColor = Color.DarkRed
                Impostazioni.LinguaButton.Text = Impostazioni.ita.Text
            ElseIf LinguaTxt.Text = "FRA-FR" Then
                'traduzione in francese
                TraduzioneLinguaTxt.Text = (System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Language\french.mcelang"))
                p.Y = 16
                Impostazioni.fra.BackColor = Color.DarkRed
                Impostazioni.fra.FlatAppearance.MouseOverBackColor = Color.DarkRed
                Impostazioni.fra.FlatAppearance.MouseDownBackColor = Color.DarkRed
                Impostazioni.LinguaButton.Text = Impostazioni.fra.Text
            ElseIf LinguaTxt.Text = "DEU-DE" Then
                'traduzione in tedesco
                TraduzioneLinguaTxt.Text = (System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Language\german.mcelang"))
                Impostazioni.ger.BackColor = Color.DarkRed
                Impostazioni.ger.FlatAppearance.MouseOverBackColor = Color.DarkRed
                Impostazioni.ger.FlatAppearance.MouseDownBackColor = Color.DarkRed
                Impostazioni.LinguaButton.Text = Impostazioni.ger.Text
            ElseIf LinguaTxt.Text = "ESP-ES" Then
                'traduzione in spagnolo
                TraduzioneLinguaTxt.Text = (System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Language\spanish.mcelang"))
                Impostazioni.spa.BackColor = Color.DarkRed
                Impostazioni.spa.FlatAppearance.MouseOverBackColor = Color.DarkRed
                Impostazioni.spa.FlatAppearance.MouseDownBackColor = Color.DarkRed
                Impostazioni.LinguaButton.Text = Impostazioni.spa.Text
            ElseIf LinguaTxt.Text = "PYC-PO" Then
                'traduzione in russo
                TraduzioneLinguaTxt.Text = (System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Language\russian.mcelang"))
                Impostazioni.rus.BackColor = Color.DarkRed
                Impostazioni.rus.FlatAppearance.MouseOverBackColor = Color.DarkRed
                Impostazioni.rus.FlatAppearance.MouseDownBackColor = Color.DarkRed
                Impostazioni.LinguaButton.Text = Impostazioni.rus.Text
            Else
                If Not LinguaTxt.Text = "ENG-UK" Then
                    MessaggioF.Button1.Text = ("The file containing the language is corrupted or unavailable." & vbNewLine & "It will be, then, reset to the default language (English UK)." & vbNewLine & "Error code: MCEEAA0012")
                    MessaggioF.Text = ("Error: Language is not available")
                    MessaggioF.DettagliErroreButton.Visible = True
                    MessaggioF.ErroreTxt.Text = ("MCEEAA0012")
                    MessaggioF.ShowDialog()
                End If
                LinguaTxt.Text = "ENG-UK"

                p.Y = 82
                Impostazioni.enguk.BackColor = Color.DarkRed
                Impostazioni.enguk.FlatAppearance.MouseOverBackColor = Color.DarkRed
                Impostazioni.enguk.FlatAppearance.MouseDownBackColor = Color.DarkRed
                Impostazioni.LinguaButton.Text = Impostazioni.enguk.Text
                TraduzioneLinguaTxt.Text = (System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\Language\english-uk.mcelang"))
                'traduzione in inglese
            End If
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\language.mcesx", LinguaTxt.Text)
            MessaggioF.Button1.Text = ("The file containing the translation of language is not available or is damaged." & vbNewLine & "Please reistall My Code Editor. For now it will be displayed in Italian." & vbNewLine & "Error code: MCEEAA0013")
            MessaggioF.Text = ("Error: The language file is not available")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0013")
            MessaggioF.ShowDialog()

            LinguaTxt.Text = "ITA-IT"

            p.Y = 60
            Impostazioni.ita.BackColor = Color.DarkRed
            Impostazioni.ita.FlatAppearance.MouseOverBackColor = Color.DarkRed
            Impostazioni.ita.FlatAppearance.MouseDownBackColor = Color.DarkRed
            Impostazioni.LinguaButton.Text = Impostazioni.ita.Text
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\language.mcesx", LinguaTxt.Text)
        End If

        If TraduzioneLinguaTxt.Lines.Count = 785 Then
            Me.Text = TraduzioneLinguaTxt.Lines(0)
            FileButton.Text = TraduzioneLinguaTxt.Lines(1)
            ModificaButton.Text = TraduzioneLinguaTxt.Lines(2)
            VisualizzaButton.Text = TraduzioneLinguaTxt.Lines(3)
            InserisciButton.Text = TraduzioneLinguaTxt.Lines(4)
            MCEButton.Text = TraduzioneLinguaTxt.Lines(5)
            ProgettazioneButtonR.Text = TraduzioneLinguaTxt.Lines(6)
            AnteprimaButtonR.Text = TraduzioneLinguaTxt.Lines(7)
            'ImpostazioniButton.Text = TraduzioneLinguaTxt.Lines(8)
            'AiutoButton.Text = TraduzioneLinguaTxt.Lines(9)
            buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
            buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            PercorsoFileButton.Text = TraduzioneLinguaTxt.Lines(12)
            Button5.Text = TraduzioneLinguaTxt.Lines(13)
            Button2.Text = TraduzioneLinguaTxt.Lines(14)
            Button9.Text = TraduzioneLinguaTxt.Lines(15)
            'Button11.Text = TraduzioneLinguaTxt.Lines(16)
            'Button10.Text = TraduzioneLinguaTxt.Lines(17)
            'GallenApriNelSitoButton.Text = TraduzioneLinguaTxt.Lines(61)
            Informazioni.SetToolTip(FileButton, TraduzioneLinguaTxt.Lines(62)) 'tooltip
            Informazioni.SetToolTip(ModificaButton, TraduzioneLinguaTxt.Lines(63)) 'tooltip
            Informazioni.SetToolTip(VisualizzaButton, TraduzioneLinguaTxt.Lines(64)) 'tooltip
            Informazioni.SetToolTip(InserisciButton, TraduzioneLinguaTxt.Lines(65)) 'tooltip
            Informazioni.SetToolTip(MCEButton, TraduzioneLinguaTxt.Lines(66)) 'tooltip
            Informazioni.SetToolTip(ProgettazioneButtonR, TraduzioneLinguaTxt.Lines(67)) 'tooltip
            Informazioni.SetToolTip(AnteprimaButtonR, TraduzioneLinguaTxt.Lines(68)) 'tooltip
            'Informazioni.SetToolTip(ImpostazioniButton, TraduzioneLinguaTxt.Lines(69)) 'tooltip
            'Informazioni.SetToolTip(AiutoButton, TraduzioneLinguaTxt.Lines(70)) 'tooltip
            Informazioni.SetToolTip(buttproghtml, TraduzioneLinguaTxt.Lines(71)) 'tooltip
            Informazioni.SetToolTip(buttprogcss, TraduzioneLinguaTxt.Lines(72)) 'tooltip
            Informazioni.SetToolTip(PercorsoFileButton, TraduzioneLinguaTxt.Lines(73)) 'tooltip
            Informazioni.SetToolTip(Button5, TraduzioneLinguaTxt.Lines(74)) 'tooltip
            Informazioni.SetToolTip(Button2, TraduzioneLinguaTxt.Lines(75)) 'tooltip
            Informazioni.SetToolTip(Button9, TraduzioneLinguaTxt.Lines(76)) 'tooltip
            'Informazioni.SetToolTip(GallenApriNelSitoButton, TraduzioneLinguaTxt.Lines(77)) 'tooltip
            'GallenDescrizioneElemento.Text = TraduzioneLinguaTxt.Lines(78)
            'Informazioni.SetToolTip(Button11, TraduzioneLinguaTxt.Lines(79)) 'tooltip
            'Informazioni.SetToolTip(Button10, TraduzioneLinguaTxt.Lines(80)) 'tooltip
            'Informazioni.SetToolTip(Button18, TraduzioneLinguaTxt.Lines(81)) 'tooltip
            'Informazioni.SetToolTip(Button19, TraduzioneLinguaTxt.Lines(82)) 'tooltip
            'Informazioni.SetToolTip(Button20, TraduzioneLinguaTxt.Lines(83)) 'tooltip
            'Informazioni.SetToolTip(Button34, TraduzioneLinguaTxt.Lines(84)) 'tooltip
            'Informazioni.SetToolTip(Button45, TraduzioneLinguaTxt.Lines(85)) 'tooltip
            'Informazioni.SetToolTip(Button50, TraduzioneLinguaTxt.Lines(86)) 'tooltip
            Informazioni.ToolTipTitle = TraduzioneLinguaTxt.Lines(87)
            SaveFileDialog1.FileName = TraduzioneLinguaTxt.Lines(88)
            SaveFileDialog1.Title = TraduzioneLinguaTxt.Lines(89)
            SaveFileDialog1.Filter = TraduzioneLinguaTxt.Lines(90)
            OpenFileDialog1.FileName = TraduzioneLinguaTxt.Lines(91)
            OpenFileDialog1.Filter = TraduzioneLinguaTxt.Lines(92)
            OpenFileDialog1.Title = TraduzioneLinguaTxt.Lines(93)
            ToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(94)
            ToolStripMenuItem3.Text = TraduzioneLinguaTxt.Lines(95)
            ToolStripMenuItem4.Text = TraduzioneLinguaTxt.Lines(96)
            ToolStripMenuItem5.Text = TraduzioneLinguaTxt.Lines(97)
            ToolStripMenuItem6.Text = TraduzioneLinguaTxt.Lines(98)
            ToolStripMenuItem7.Text = TraduzioneLinguaTxt.Lines(99)

            VediLanteprimaDelProgettoToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(100)
            SalvaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(101)
            EsciToolStripMenuItem2.Text = TraduzioneLinguaTxt.Lines(102)
            HhhToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(129)
            EsciToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(130)
            Aiuto.Text = TraduzioneLinguaTxt.Lines(131)
            Aiuto.Cerca_Button_TextBox.Text = TraduzioneLinguaTxt.Lines(132)
            'Aiuto.CercaButton.Text = TraduzioneLinguaTxt.Lines(133)
            'Aiuto.GuideButton.Text = TraduzioneLinguaTxt.Lines(134)
            'Aiuto.HomeButton.Text = TraduzioneLinguaTxt.Lines(135)
            'Aiuto.NewsButton.Text = TraduzioneLinguaTxt.Lines(136)
            'Aiuto.CercaButton.Text = TraduzioneLinguaTxt.Lines(137)
            'Aiuto.TitoloVideoPrimoAvvio1.Text = TraduzioneLinguaTxt.Lines(138)
            'Aiuto.DescrizioneVideoPrimoAvvio1.Text = TraduzioneLinguaTxt.Lines(139)
            'Aiuto.TitoloVideoPrimoAvvio2.Text = TraduzioneLinguaTxt.Lines(140)
            'Aiuto.DescrizioneVideoPrimoAvvio2.Text = TraduzioneLinguaTxt.Lines(141)
            'Aiuto.TitoloVideoPrimoAvvio3.Text = TraduzioneLinguaTxt.Lines(142)
            'Aiuto.DescrizioneVideoPrimoAvvio3.Text = TraduzioneLinguaTxt.Lines(143)
            'Aiuto.TitoloVideoTutorial1.Text = TraduzioneLinguaTxt.Lines(144)
            'Aiuto.DescrizioneVideoTutorial1.Text = TraduzioneLinguaTxt.Lines(145)
            'Aiuto.CodiceErroreText.Text = TraduzioneLinguaTxt.Lines(146)
            'Aiuto.DescrizioneErroreText.Text = TraduzioneLinguaTxt.Lines(147)
            'Aiuto.CercaOnlineNORESULT.Text = TraduzioneLinguaTxt.Lines(148)
            'Aiuto.ToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(149)
            'Aiuto.IncollaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(150)
            Avvio.ApriButton.Text = TraduzioneLinguaTxt.Lines(151)
            Avvio.Label1.Text = TraduzioneLinguaTxt.Lines(152)
            Avvio.Label2.Text = TraduzioneLinguaTxt.Lines(153)
            Avvio.Button8.Text = TraduzioneLinguaTxt.Lines(154)
            Avvio.Button7.Text = TraduzioneLinguaTxt.Lines(155)
            Avvio.Button14.Text = TraduzioneLinguaTxt.Lines(156)
            Avvio.Button1.Text = TraduzioneLinguaTxt.Lines(157)
            Avvio.Text = TraduzioneLinguaTxt.Lines(158)
            Avvio.OpenFileDialog1.Filter = TraduzioneLinguaTxt.Lines(159)
            Avvio.OpenFileDialog1.Title = TraduzioneLinguaTxt.Lines(160)
            Bottone.Text = TraduzioneLinguaTxt.Lines(161)
            Bottone.Button1.Text = TraduzioneLinguaTxt.Lines(162)
            Bottone.Button9.Text = TraduzioneLinguaTxt.Lines(163)
            Bottone.Informazioni.SetToolTip(Bottone.Button9, TraduzioneLinguaTxt.Lines(164)) 'tooltip
            Bottone.Button10.Text = TraduzioneLinguaTxt.Lines(165)
            Bottone.Informazioni.SetToolTip(Bottone.Button10, TraduzioneLinguaTxt.Lines(166)) 'tooltip
            Bottone.Button2.Text = TraduzioneLinguaTxt.Lines(167)
            Bottone.Button16.Text = TraduzioneLinguaTxt.Lines(168)
            Bottone.Button90.Text = TraduzioneLinguaTxt.Lines(169)
            Bottone.Informazioni.SetToolTip(Bottone.Panel10, TraduzioneLinguaTxt.Lines(170)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox209, TraduzioneLinguaTxt.Lines(171)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox204, TraduzioneLinguaTxt.Lines(172)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox119, TraduzioneLinguaTxt.Lines(173)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox124, TraduzioneLinguaTxt.Lines(174)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox1, TraduzioneLinguaTxt.Lines(175)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox9, TraduzioneLinguaTxt.Lines(176)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox21, TraduzioneLinguaTxt.Lines(177)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox80, TraduzioneLinguaTxt.Lines(178)) 'tooltip
            Bottone.Button8.Text = TraduzioneLinguaTxt.Lines(179)
            Bottone.Label1.Text = TraduzioneLinguaTxt.Lines(180)
            Bottone.Informazioni.SetToolTip(Bottone.Label1, TraduzioneLinguaTxt.Lines(181)) 'tooltip
            Bottone.Button34.Text = TraduzioneLinguaTxt.Lines(182)
            Bottone.Button14.Text = TraduzioneLinguaTxt.Lines(183)
            Bottone.Label2.Text = TraduzioneLinguaTxt.Lines(184)
            Bottone.Informazioni.SetToolTip(Bottone.Label2, TraduzioneLinguaTxt.Lines(185)) 'tooltip
            Bottone.Button21.Text = TraduzioneLinguaTxt.Lines(186)
            Bottone.Informazioni.SetToolTip(Bottone.Button21, TraduzioneLinguaTxt.Lines(187)) 'tooltip
            Bottone.Button27.Text = TraduzioneLinguaTxt.Lines(188)
            Bottone.Informazioni.SetToolTip(Bottone.Button27, TraduzioneLinguaTxt.Lines(189)) 'tooltip
            Bottone.Button31.Text = TraduzioneLinguaTxt.Lines(190)
            Bottone.Informazioni.SetToolTip(Bottone.Button31, TraduzioneLinguaTxt.Lines(191)) 'tooltip
            Bottone.Button29.Text = TraduzioneLinguaTxt.Lines(192)
            Bottone.Informazioni.SetToolTip(Bottone.Button29, TraduzioneLinguaTxt.Lines(193)) 'tooltip
            Bottone.Button38.Text = TraduzioneLinguaTxt.Lines(194)
            Bottone.Button41.Text = TraduzioneLinguaTxt.Lines(195)
            Bottone.Button40.Text = TraduzioneLinguaTxt.Lines(196)
            Bottone.Button54.Text = TraduzioneLinguaTxt.Lines(197)
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox6, TraduzioneLinguaTxt.Lines(198)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox4, TraduzioneLinguaTxt.Lines(199)) 'tooltip

            Bottone.Informazioni.SetToolTip(Bottone.PictureBox3, TraduzioneLinguaTxt.Lines(200)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox5, TraduzioneLinguaTxt.Lines(201)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox11, TraduzioneLinguaTxt.Lines(202)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox10, TraduzioneLinguaTxt.Lines(203)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox8, TraduzioneLinguaTxt.Lines(204)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox7, TraduzioneLinguaTxt.Lines(205)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.Panel15, TraduzioneLinguaTxt.Lines(206)) 'tooltip
            Bottone.Button42.Text = TraduzioneLinguaTxt.Lines(207)
            Bottone.Button52.Text = TraduzioneLinguaTxt.Lines(208)
            Bottone.Informazioni.SetToolTip(Bottone.Panel18, TraduzioneLinguaTxt.Lines(209)) 'tooltip
            Bottone.Label3.Text = TraduzioneLinguaTxt.Lines(210)
            Bottone.Button37.Text = TraduzioneLinguaTxt.Lines(211)
            Bottone.Informazioni.SetToolTip(Bottone.Button37, TraduzioneLinguaTxt.Lines(212)) 'tooltip
            Bottone.Button36.Text = TraduzioneLinguaTxt.Lines(213)
            Bottone.Informazioni.SetToolTip(Bottone.Button36, TraduzioneLinguaTxt.Lines(214)) 'tooltip
            Bottone.Button35.Text = TraduzioneLinguaTxt.Lines(215)
            Bottone.Informazioni.SetToolTip(Bottone.Button35, TraduzioneLinguaTxt.Lines(216)) 'tooltip
            Bottone.Button7.Text = TraduzioneLinguaTxt.Lines(217)
            Bottone.Informazioni.SetToolTip(Bottone.Button7, TraduzioneLinguaTxt.Lines(218)) 'tooltip
            Bottone.Label4.Text = TraduzioneLinguaTxt.Lines(219)
            Bottone.Button15.Text = TraduzioneLinguaTxt.Lines(220)
            Bottone.Button43.Text = TraduzioneLinguaTxt.Lines(221)
            Bottone.Informazioni.SetToolTip(Bottone.Panel17, TraduzioneLinguaTxt.Lines(222)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox15, TraduzioneLinguaTxt.Lines(223)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox13, TraduzioneLinguaTxt.Lines(224)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox12, TraduzioneLinguaTxt.Lines(225)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox14, TraduzioneLinguaTxt.Lines(226)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox19, TraduzioneLinguaTxt.Lines(227)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox18, TraduzioneLinguaTxt.Lines(228)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox17, TraduzioneLinguaTxt.Lines(229)) 'tooltip
            Bottone.Informazioni.SetToolTip(Bottone.PictureBox16, TraduzioneLinguaTxt.Lines(230)) 'tooltip
            Bottone.Button55.Text = TraduzioneLinguaTxt.Lines(231)
            Bottone.Button11.Text = TraduzioneLinguaTxt.Lines(232)
            Bottone.Button47.Text = TraduzioneLinguaTxt.Lines(233)
            Bottone.Informazioni.SetToolTip(Bottone.Button53, TraduzioneLinguaTxt.Lines(234)) 'tooltip
            Bottone.Button13.Text = TraduzioneLinguaTxt.Lines(235)
            Bottone.Button17.Text = TraduzioneLinguaTxt.Lines(236)
            Bottone.Informazioni.SetToolTip(Bottone.Button17, TraduzioneLinguaTxt.Lines(237)) 'tooltip
            Bottone.Button18.Text = TraduzioneLinguaTxt.Lines(238)
            Bottone.Informazioni.SetToolTip(Bottone.Button18, TraduzioneLinguaTxt.Lines(239)) 'tooltip
            Bottone.Button19.Text = TraduzioneLinguaTxt.Lines(240)
            Bottone.Informazioni.SetToolTip(Bottone.Button19, TraduzioneLinguaTxt.Lines(241) & vbNewLine & TraduzioneLinguaTxt.Lines(242)) 'tooltip
            Bottone.Button20.Text = TraduzioneLinguaTxt.Lines(243)
            Bottone.Informazioni.SetToolTip(Bottone.Button20, TraduzioneLinguaTxt.Lines(244) & vbNewLine & TraduzioneLinguaTxt.Lines(245)) 'tooltip
            Bottone.Button32.Text = TraduzioneLinguaTxt.Lines(246)
            Bottone.Button33.Text = TraduzioneLinguaTxt.Lines(247)
            Bottone.Label5.Text = TraduzioneLinguaTxt.Lines(248)
            Bottone.Informazioni.SetToolTip(Bottone.Label5, TraduzioneLinguaTxt.Lines(249)) 'tooltip
            Bottone.Button12.Text = TraduzioneLinguaTxt.Lines(250)
            Bottone.Button50.Text = TraduzioneLinguaTxt.Lines(251)
            Bottone.Button48.Text = TraduzioneLinguaTxt.Lines(252)
            Carattere.Text = TraduzioneLinguaTxt.Lines(253)
            Carattere.Button10.Text = TraduzioneLinguaTxt.Lines(254)
            CaratteriSpeciali.Text = TraduzioneLinguaTxt.Lines(255)
            CaratteriSpeciali.Label1.Text = TraduzioneLinguaTxt.Lines(256)
            CaratteriSpeciali.Label2.Text = TraduzioneLinguaTxt.Lines(257)
            CaratteriSpeciali.Label3.Text = TraduzioneLinguaTxt.Lines(258)
            CaratteriSpeciali.Label4.Text = TraduzioneLinguaTxt.Lines(259)
            CaratteriSpeciali.Button227.Text = TraduzioneLinguaTxt.Lines(260)
            CaratteriSpeciali.Button10.Text = TraduzioneLinguaTxt.Lines(261)
            Collegamento.Text = TraduzioneLinguaTxt.Lines(262)
            Collegamento.Button1.Text = TraduzioneLinguaTxt.Lines(263)
            Collegamento.Button9.Text = TraduzioneLinguaTxt.Lines(264)
            Collegamento.Button10.Text = TraduzioneLinguaTxt.Lines(265)
            Collegamento.Button2.Text = TraduzioneLinguaTxt.Lines(266)
            Collegamento.Button16.Text = TraduzioneLinguaTxt.Lines(267)
            Collegamento.Button90.Text = TraduzioneLinguaTxt.Lines(268)
            Collegamento.Button54.Text = TraduzioneLinguaTxt.Lines(269)
            Collegamento.Button49.Text = TraduzioneLinguaTxt.Lines(270)
            Collegamento.Button33.Text = TraduzioneLinguaTxt.Lines(271)
            Collegamento.Button11.Text = TraduzioneLinguaTxt.Lines(272)
            Collegamento.Button47.Text = TraduzioneLinguaTxt.Lines(273)
            Collegamento.Button13.Text = TraduzioneLinguaTxt.Lines(274)
            Collegamento.Button17.Text = TraduzioneLinguaTxt.Lines(275)
            Collegamento.Button18.Text = TraduzioneLinguaTxt.Lines(276)
            Collegamento.Button19.Text = TraduzioneLinguaTxt.Lines(277)
            Collegamento.Button20.Text = TraduzioneLinguaTxt.Lines(278)
            Collegamento.Button32.Text = TraduzioneLinguaTxt.Lines(279)
            Collegamento.Button48.Text = TraduzioneLinguaTxt.Lines(280)
            Colori.Text = TraduzioneLinguaTxt.Lines(281)
            Colori.Label4.Text = TraduzioneLinguaTxt.Lines(282)
            Colori.Button37.Text = TraduzioneLinguaTxt.Lines(283)
            Colori.Button1.Text = TraduzioneLinguaTxt.Lines(284)
            Colori.Button2.Text = TraduzioneLinguaTxt.Lines(285)
            Colori.Button43.Text = TraduzioneLinguaTxt.Lines(286)
            Colori.ToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(287)
            Colori.IncollaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(288)
            Colori.ToolStripMenuItem6.Text = TraduzioneLinguaTxt.Lines(289)
            Colori.ToolStripMenuItem7.Text = TraduzioneLinguaTxt.Lines(290)
            Colori.ToolStripMenuItem2.Text = TraduzioneLinguaTxt.Lines(291)
            Colori.ToolStripMenuItem3.Text = TraduzioneLinguaTxt.Lines(292)
            Colori.ToolStripMenuItem4.Text = TraduzioneLinguaTxt.Lines(293)
            Colori.ToolStripMenuItem5.Text = TraduzioneLinguaTxt.Lines(294)
            Colori.Label2.Text = TraduzioneLinguaTxt.Lines(295)
            Commento.Text = TraduzioneLinguaTxt.Lines(296)
            Commento.Button1.Text = TraduzioneLinguaTxt.Lines(297)
            Commento.Button9.Text = TraduzioneLinguaTxt.Lines(298)
            Commento.Button48.Text = TraduzioneLinguaTxt.Lines(299)

            CondizioniDUso.Text = TraduzioneLinguaTxt.Lines(300)
            Contattaci.Text = TraduzioneLinguaTxt.Lines(301)
            Contattaci.NomeCognomeText.Text = TraduzioneLinguaTxt.Lines(302)
            Contattaci.EmailText.Text = TraduzioneLinguaTxt.Lines(303)
            Contattaci.MotivoText.Text = TraduzioneLinguaTxt.Lines(304)
            Contattaci.InformazioniMotivoText.Text = TraduzioneLinguaTxt.Lines(305)
            Contattaci.SupportoMotivoText.Text = TraduzioneLinguaTxt.Lines(306)
            Contattaci.SegnalazioneMotivoText.Text = TraduzioneLinguaTxt.Lines(307)
            Contattaci.AltroMotivoText.Text = TraduzioneLinguaTxt.Lines(308)
            Contattaci.MessaggioText.Text = TraduzioneLinguaTxt.Lines(309)
            Contattaci.Button1.Text = TraduzioneLinguaTxt.Lines(310)
            Contattaci.AccettoCondCheck.Text = TraduzioneLinguaTxt.Lines(311) & vbNewLine & TraduzioneLinguaTxt.Lines(312)
            Contattaci.Button2.Text = TraduzioneLinguaTxt.Lines(313)
            Contattaci.Button48.Text = TraduzioneLinguaTxt.Lines(314)
            Contenitore.Text = TraduzioneLinguaTxt.Lines(315)
            Contenitore.Button1.Text = TraduzioneLinguaTxt.Lines(316)
            Contenitore.Button2.Text = TraduzioneLinguaTxt.Lines(317)
            Contenitore.Button16.Text = TraduzioneLinguaTxt.Lines(318)
            Contenitore.Button90.Text = TraduzioneLinguaTxt.Lines(319)
            Contenitore.Button8.Text = TraduzioneLinguaTxt.Lines(320)
            Contenitore.Button10.Text = TraduzioneLinguaTxt.Lines(321)
            Contenitore.Button9.Text = TraduzioneLinguaTxt.Lines(322)
            Contenitore.Button34.Text = TraduzioneLinguaTxt.Lines(323)
            Contenitore.Button14.Text = TraduzioneLinguaTxt.Lines(324)
            Contenitore.Button12.Text = TraduzioneLinguaTxt.Lines(325)
            Contenitore.Label3.Text = TraduzioneLinguaTxt.Lines(326)
            Contenitore.Button37.Text = TraduzioneLinguaTxt.Lines(327)
            Contenitore.Button36.Text = TraduzioneLinguaTxt.Lines(328)
            Contenitore.Button35.Text = TraduzioneLinguaTxt.Lines(329)
            Contenitore.Button7.Text = TraduzioneLinguaTxt.Lines(330)
            Contenitore.Label2.Text = TraduzioneLinguaTxt.Lines(331)
            Contenitore.Button21.Text = TraduzioneLinguaTxt.Lines(332)
            Contenitore.Button27.Text = TraduzioneLinguaTxt.Lines(333)
            Contenitore.Button31.Text = TraduzioneLinguaTxt.Lines(334)
            Contenitore.Button29.Text = TraduzioneLinguaTxt.Lines(335)
            Contenitore.Button38.Text = TraduzioneLinguaTxt.Lines(336)
            Contenitore.Button41.Text = TraduzioneLinguaTxt.Lines(337)
            Contenitore.Button40.Text = TraduzioneLinguaTxt.Lines(338)
            Contenitore.Button42.Text = TraduzioneLinguaTxt.Lines(339)
            Contenitore.Button52.Text = TraduzioneLinguaTxt.Lines(340)
            Contenitore.Button48.Text = TraduzioneLinguaTxt.Lines(341)
            Contenitore.OpenFileDialog1.Filter = TraduzioneLinguaTxt.Lines(342)
            Contenitore.OpenFileDialog1.Title = TraduzioneLinguaTxt.Lines(343)
            Contenitore.CopiaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(344)
            Contenitore.IncollaToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(345)
            Contenitore.EliminaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(346)
            ControlloAggiornamenti.Text = TraduzioneLinguaTxt.Lines(347)
            ControlloAggiornamenti.Button1.Text = TraduzioneLinguaTxt.Lines(348)
            ControlloAggiornamenti.ScaricaDopoButton.Text = TraduzioneLinguaTxt.Lines(349)
            ControlloAggiornamenti.ScaricaButton.Text = TraduzioneLinguaTxt.Lines(350)
            ControlloAggiornamenti.InstallaButton.Text = TraduzioneLinguaTxt.Lines(351)
            ControlloAggiornamenti.SaveFileDialog1.FileName = TraduzioneLinguaTxt.Lines(352)
            ControlloAggiornamenti.SaveFileDialog1.Title = TraduzioneLinguaTxt.Lines(353)
            Descrizione.Text = TraduzioneLinguaTxt.Lines(354)
            Descrizione.Button1.Text = TraduzioneLinguaTxt.Lines(355)
            Descrizione.Button9.Text = TraduzioneLinguaTxt.Lines(356)
            Descrizione.Button2.Text = TraduzioneLinguaTxt.Lines(357)
            Descrizione.Button33.Text = TraduzioneLinguaTxt.Lines(358)
            Descrizione.Label3.Text = TraduzioneLinguaTxt.Lines(359)
            Descrizione.Button37.Text = TraduzioneLinguaTxt.Lines(360)
            Descrizione.Button36.Text = TraduzioneLinguaTxt.Lines(361)
            Descrizione.Button35.Text = TraduzioneLinguaTxt.Lines(362)
            Descrizione.Button7.Text = TraduzioneLinguaTxt.Lines(363)
            Descrizione.Label4.Text = TraduzioneLinguaTxt.Lines(364)
            Descrizione.Button15.Text = TraduzioneLinguaTxt.Lines(365)
            Descrizione.Button43.Text = TraduzioneLinguaTxt.Lines(366)
            Descrizione.Button55.Text = TraduzioneLinguaTxt.Lines(367)
            Descrizione.Button11.Text = TraduzioneLinguaTxt.Lines(368)
            Descrizione.Button47.Text = TraduzioneLinguaTxt.Lines(369)
            Descrizione.Button13.Text = TraduzioneLinguaTxt.Lines(370)
            Descrizione.Button17.Text = TraduzioneLinguaTxt.Lines(371)
            Descrizione.Button18.Text = TraduzioneLinguaTxt.Lines(372)
            Descrizione.Button19.Text = TraduzioneLinguaTxt.Lines(373)
            Descrizione.Button20.Text = TraduzioneLinguaTxt.Lines(374)
            Descrizione.Button32.Text = TraduzioneLinguaTxt.Lines(375)
            Descrizione.Button48.Text = TraduzioneLinguaTxt.Lines(376)
            Elenco.Text = TraduzioneLinguaTxt.Lines(377)
            Elenco.Button1.Text = TraduzioneLinguaTxt.Lines(378)
            Elenco.Button9.Text = TraduzioneLinguaTxt.Lines(379)
            Elenco.Button2.Text = TraduzioneLinguaTxt.Lines(380)
            Elenco.Button33.Text = TraduzioneLinguaTxt.Lines(381)
            Elenco.Button14.Text = TraduzioneLinguaTxt.Lines(382)
            Elenco.Button8.Text = TraduzioneLinguaTxt.Lines(383)
            Elenco.Button10.Text = TraduzioneLinguaTxt.Lines(384)
            Elenco.Label3.Text = TraduzioneLinguaTxt.Lines(385)
            Elenco.Button37.Text = TraduzioneLinguaTxt.Lines(386)
            Elenco.Button36.Text = TraduzioneLinguaTxt.Lines(387)
            Elenco.Button35.Text = TraduzioneLinguaTxt.Lines(388)
            Elenco.Button7.Text = TraduzioneLinguaTxt.Lines(389)
            Elenco.Label4.Text = TraduzioneLinguaTxt.Lines(390)
            Elenco.Button15.Text = TraduzioneLinguaTxt.Lines(391)
            Elenco.Button43.Text = TraduzioneLinguaTxt.Lines(392)
            Elenco.Button55.Text = TraduzioneLinguaTxt.Lines(393)
            Elenco.Button11.Text = TraduzioneLinguaTxt.Lines(394)
            Elenco.Button47.Text = TraduzioneLinguaTxt.Lines(395)
            Elenco.Button13.Text = TraduzioneLinguaTxt.Lines(396)
            Elenco.Button17.Text = TraduzioneLinguaTxt.Lines(397)
            Elenco.Button18.Text = TraduzioneLinguaTxt.Lines(398)
            Elenco.Button19.Text = TraduzioneLinguaTxt.Lines(399)

            Elenco.Button20.Text = TraduzioneLinguaTxt.Lines(400)
            Elenco.Button32.Text = TraduzioneLinguaTxt.Lines(401)
            Elenco.Button48.Text = TraduzioneLinguaTxt.Lines(402)
            EsciMessaggio.AnteprimaButtonR.Text = TraduzioneLinguaTxt.Lines(403)
            EsciMessaggio.Button3.Text = TraduzioneLinguaTxt.Lines(404)
            EsciMessaggio.Button2.Text = TraduzioneLinguaTxt.Lines(405)
            Immagine.Text = TraduzioneLinguaTxt.Lines(406)
            Immagine.Button1.Text = TraduzioneLinguaTxt.Lines(407)
            Immagine.Button10.Text = TraduzioneLinguaTxt.Lines(408)
            Immagine.Button2.Text = TraduzioneLinguaTxt.Lines(409)
            Immagine.Button11.Text = TraduzioneLinguaTxt.Lines(410)
            Immagine.Button34.Text = TraduzioneLinguaTxt.Lines(411)
            Immagine.Button14.Text = TraduzioneLinguaTxt.Lines(412)
            Immagine.Button12.Text = TraduzioneLinguaTxt.Lines(413)
            Immagine.Label3.Text = TraduzioneLinguaTxt.Lines(414)
            Immagine.Button37.Text = TraduzioneLinguaTxt.Lines(415)
            Immagine.Button36.Text = TraduzioneLinguaTxt.Lines(416)
            Immagine.Button35.Text = TraduzioneLinguaTxt.Lines(417)
            Immagine.Button7.Text = TraduzioneLinguaTxt.Lines(418)
            Immagine.Button48.Text = TraduzioneLinguaTxt.Lines(419)
            Impostazioni.Text = TraduzioneLinguaTxt.Lines(420)
            Impostazioni.GeneraleCheck0.Text = TraduzioneLinguaTxt.Lines(421)
            Impostazioni.GeneraleCheck1.Text = TraduzioneLinguaTxt.Lines(422)
            Impostazioni.GeneraleCheck2.Text = TraduzioneLinguaTxt.Lines(423)
            Impostazioni.GeneraleCheck3.Text = TraduzioneLinguaTxt.Lines(424)
            Impostazioni.GeneraleCheck4.Text = TraduzioneLinguaTxt.Lines(425) & vbNewLine & TraduzioneLinguaTxt.Lines(426)
            Impostazioni.GeneraleCheck5.Text = TraduzioneLinguaTxt.Lines(427) & vbNewLine & TraduzioneLinguaTxt.Lines(428)
            Impostazioni.GeneraleCheck6.Text = TraduzioneLinguaTxt.Lines(429)
            Impostazioni.AutoSaveCheck0.Text = TraduzioneLinguaTxt.Lines(430)
            Impostazioni.Label1.Text = TraduzioneLinguaTxt.Lines(431)
            Impostazioni.Label2.Text = TraduzioneLinguaTxt.Lines(432)
            Impostazioni.HTML1m.Text = TraduzioneLinguaTxt.Lines(433)
            Impostazioni.HTML5m.Text = TraduzioneLinguaTxt.Lines(434)
            Impostazioni.HTML10m.Text = TraduzioneLinguaTxt.Lines(435)
            Impostazioni.HTML30m.Text = TraduzioneLinguaTxt.Lines(436)
            Impostazioni.HTML1h.Text = TraduzioneLinguaTxt.Lines(437)
            Impostazioni.HTML2h.Text = TraduzioneLinguaTxt.Lines(438)
            Impostazioni.HTMLPersonalizzato.Text = TraduzioneLinguaTxt.Lines(439)
            Impostazioni.HTMLPersonalizzaOkButton.Text = TraduzioneLinguaTxt.Lines(440)
            Impostazioni.CSS1m.Text = TraduzioneLinguaTxt.Lines(441)
            Impostazioni.CSS5m.Text = TraduzioneLinguaTxt.Lines(442)
            Impostazioni.CSS10m.Text = TraduzioneLinguaTxt.Lines(443)
            Impostazioni.CSS30m.Text = TraduzioneLinguaTxt.Lines(444)
            Impostazioni.CSS1h.Text = TraduzioneLinguaTxt.Lines(445)
            Impostazioni.CSS2h.Text = TraduzioneLinguaTxt.Lines(446)
            Impostazioni.CSSPersonalizzato.Text = TraduzioneLinguaTxt.Lines(447)
            Impostazioni.CSSPersonalizzaOkButton.Text = TraduzioneLinguaTxt.Lines(448)
            Impostazioni.InterfacciaCheck0.Text = TraduzioneLinguaTxt.Lines(449)
            Impostazioni.InterfacciaCheck1.Text = TraduzioneLinguaTxt.Lines(450)
            Impostazioni.InterfacciaCheck2.Text = TraduzioneLinguaTxt.Lines(451)
            Impostazioni.PrivacyCheck0.Text = TraduzioneLinguaTxt.Lines(452)
            Impostazioni.AvanzateLabel0.Text = TraduzioneLinguaTxt.Lines(453)
            Impostazioni.AvanzateRadio0.Text = TraduzioneLinguaTxt.Lines(454)
            Impostazioni.AvanzateRadio1.Text = TraduzioneLinguaTxt.Lines(455)
            Impostazioni.AvanzateRadio2.Text = TraduzioneLinguaTxt.Lines(456)
            Impostazioni.Button10.Text = TraduzioneLinguaTxt.Lines(457)
            Impostazioni.AvanzateLabel1.Text = TraduzioneLinguaTxt.Lines(458)
            Impostazioni.AvanzatePercorsoRadio0.Text = TraduzioneLinguaTxt.Lines(459)
            Impostazioni.AvanzatePercorsoRadio1.Text = TraduzioneLinguaTxt.Lines(460)
            Impostazioni.Button1.Text = TraduzioneLinguaTxt.Lines(461)
            Licenza.Text = TraduzioneLinguaTxt.Lines(473)
            MessaggioF.DettagliErroreButton.Text = TraduzioneLinguaTxt.Lines(474)
            MessaggioF.ChiudiMessaggio.Text = TraduzioneLinguaTxt.Lines(475)
            MessaggioErroreFileNonSupportato.Text = TraduzioneLinguaTxt.Lines(476)
            MessaggioErroreFileNonSupportato.Button1.Text = TraduzioneLinguaTxt.Lines(477) & vbNewLine & TraduzioneLinguaTxt.Lines(478)
            MessaggioErroreFileNonSupportato.Button3.Text = TraduzioneLinguaTxt.Lines(479)
            MessaggioErroreFileNonSupportato.Button2.Text = TraduzioneLinguaTxt.Lines(480)
            MessaggioErroreFileNonSupportato.ChiudiMessaggio.Text = TraduzioneLinguaTxt.Lines(481)

            NuovoProgetto.Text = TraduzioneLinguaTxt.Lines(501)
            NuovoProgetto.TextBox9.Text = TraduzioneLinguaTxt.Lines(502)
            NuovoProgetto.Button10.Text = TraduzioneLinguaTxt.Lines(503)
            NuovoProgetto.Button1.Text = TraduzioneLinguaTxt.Lines(504)
            NuovoProgetto.AnteprimaButtonR.Text = TraduzioneLinguaTxt.Lines(505)
            NuovoProgetto.CopiaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(506)
            NuovoProgetto.IncollaToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(507)
            NuovoProgetto.EliminaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(508)
            NuovoProgettoEFoglioDiStile.Text = TraduzioneLinguaTxt.Lines(509)
            NuovoProgettoEFoglioDiStile.TextBox9.Text = TraduzioneLinguaTxt.Lines(510)
            NuovoProgettoEFoglioDiStile.Button10.Text = TraduzioneLinguaTxt.Lines(511)
            NuovoProgettoEFoglioDiStile.Button1.Text = TraduzioneLinguaTxt.Lines(512)
            NuovoProgettoEFoglioDiStile.AnteprimaButtonR.Text = TraduzioneLinguaTxt.Lines(513)
            Paragrafo.Text = TraduzioneLinguaTxt.Lines(514)
            Paragrafo.Button1.Text = TraduzioneLinguaTxt.Lines(515)
            Paragrafo.Button9.Text = TraduzioneLinguaTxt.Lines(516)
            Paragrafo.Button2.Text = TraduzioneLinguaTxt.Lines(517)
            Paragrafo.Button33.Text = TraduzioneLinguaTxt.Lines(518)
            Paragrafo.Label3.Text = TraduzioneLinguaTxt.Lines(519)
            Paragrafo.Button37.Text = TraduzioneLinguaTxt.Lines(520)
            Paragrafo.Button36.Text = TraduzioneLinguaTxt.Lines(521)
            Paragrafo.Button35.Text = TraduzioneLinguaTxt.Lines(522)
            Paragrafo.Button7.Text = TraduzioneLinguaTxt.Lines(523)
            Paragrafo.Label4.Text = TraduzioneLinguaTxt.Lines(524)
            Paragrafo.Button15.Text = TraduzioneLinguaTxt.Lines(525)
            Paragrafo.Button43.Text = TraduzioneLinguaTxt.Lines(526)
            Paragrafo.Button55.Text = TraduzioneLinguaTxt.Lines(527)
            Paragrafo.Button11.Text = TraduzioneLinguaTxt.Lines(528)
            Paragrafo.Button47.Text = TraduzioneLinguaTxt.Lines(529)
            Paragrafo.Button13.Text = TraduzioneLinguaTxt.Lines(530)
            Paragrafo.Button17.Text = TraduzioneLinguaTxt.Lines(531)
            Paragrafo.Button18.Text = TraduzioneLinguaTxt.Lines(532)
            Paragrafo.Button19.Text = TraduzioneLinguaTxt.Lines(533)
            Paragrafo.Button20.Text = TraduzioneLinguaTxt.Lines(534)
            Paragrafo.Button32.Text = TraduzioneLinguaTxt.Lines(535)
            Paragrafo.Button48.Text = TraduzioneLinguaTxt.Lines(536)
            Ringraziamenti.Text = TraduzioneLinguaTxt.Lines(537)
            Ringraziamenti.Button1.Text = TraduzioneLinguaTxt.Lines(538) & vbNewLine & TraduzioneLinguaTxt.Lines(539) & vbNewLine & TraduzioneLinguaTxt.Lines(540)
            SegnalazioneProblema.Text = TraduzioneLinguaTxt.Lines(541)
            SegnalazioneProblema.NomeCognomeText.Text = TraduzioneLinguaTxt.Lines(542)
            SegnalazioneProblema.EmailText.Text = TraduzioneLinguaTxt.Lines(543)
            SegnalazioneProblema.MotivoText.Text = TraduzioneLinguaTxt.Lines(544)
            SegnalazioneProblema.MessaggioText.Text = TraduzioneLinguaTxt.Lines(545)
            SegnalazioneProblema.Button1.Text = TraduzioneLinguaTxt.Lines(546)
            SegnalazioneProblema.AccettoCondCheck.Text = TraduzioneLinguaTxt.Lines(547) & vbNewLine & TraduzioneLinguaTxt.Lines(548)
            SegnalazioneProblema.Button2.Text = TraduzioneLinguaTxt.Lines(549)
            SegnalazioneProblema.Button48.Text = TraduzioneLinguaTxt.Lines(550)
            Separatore.Text = TraduzioneLinguaTxt.Lines(551)
            Separatore.Button1.Text = TraduzioneLinguaTxt.Lines(552)
            Separatore.Button2.Text = TraduzioneLinguaTxt.Lines(553)
            Separatore.Button15.Text = TraduzioneLinguaTxt.Lines(554)
            Separatore.Button43.Text = TraduzioneLinguaTxt.Lines(555)
            Separatore.Button55.Text = TraduzioneLinguaTxt.Lines(556)
            Separatore.Button12.Text = TraduzioneLinguaTxt.Lines(557)
            Separatore.Button32.Text = TraduzioneLinguaTxt.Lines(558)
            Separatore.Button10.Text = TraduzioneLinguaTxt.Lines(559)
            Separatore.Label3.Text = TraduzioneLinguaTxt.Lines(560)
            Separatore.Button37.Text = TraduzioneLinguaTxt.Lines(561)
            Separatore.Button36.Text = TraduzioneLinguaTxt.Lines(562)
            Separatore.Button35.Text = TraduzioneLinguaTxt.Lines(563)
            Separatore.Button7.Text = TraduzioneLinguaTxt.Lines(564)
            Separatore.Button48.Text = TraduzioneLinguaTxt.Lines(565)
            Sostituisci.Text = TraduzioneLinguaTxt.Lines(566)
            Sostituisci.TextBox9.Text = TraduzioneLinguaTxt.Lines(567)
            Sostituisci.TextBox1.Text = TraduzioneLinguaTxt.Lines(568)
            Sostituisci.CercaButton.Text = TraduzioneLinguaTxt.Lines(569)
            Sostituisci.SostituisciButton.Text = TraduzioneLinguaTxt.Lines(570)
            Sostituisci.ToolStripMenuItem2.Text = TraduzioneLinguaTxt.Lines(571)
            Sostituisci.ToolStripMenuItem3.Text = TraduzioneLinguaTxt.Lines(572)
            Sostituisci.ToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(573)
            Sostituisci.IncollaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(574)
            Sottotitolo.Text = TraduzioneLinguaTxt.Lines(575)
            Sottotitolo.Button1.Text = TraduzioneLinguaTxt.Lines(576)
            Sottotitolo.Button9.Text = TraduzioneLinguaTxt.Lines(577)
            Sottotitolo.Button2.Text = TraduzioneLinguaTxt.Lines(578)
            Sottotitolo.Button33.Text = TraduzioneLinguaTxt.Lines(579)
            Sottotitolo.Label3.Text = TraduzioneLinguaTxt.Lines(580)
            Sottotitolo.Button37.Text = TraduzioneLinguaTxt.Lines(581)
            Sottotitolo.Button36.Text = TraduzioneLinguaTxt.Lines(582)
            Sottotitolo.Button35.Text = TraduzioneLinguaTxt.Lines(583)
            Sottotitolo.Button7.Text = TraduzioneLinguaTxt.Lines(584)
            Sottotitolo.Label4.Text = TraduzioneLinguaTxt.Lines(585)
            Sottotitolo.Button15.Text = TraduzioneLinguaTxt.Lines(586)
            Sottotitolo.Button43.Text = TraduzioneLinguaTxt.Lines(587)
            Sottotitolo.Button55.Text = TraduzioneLinguaTxt.Lines(588)
            Sottotitolo.Button11.Text = TraduzioneLinguaTxt.Lines(589)
            Sottotitolo.Button47.Text = TraduzioneLinguaTxt.Lines(590)
            Sottotitolo.Button13.Text = TraduzioneLinguaTxt.Lines(591)
            Sottotitolo.Button17.Text = TraduzioneLinguaTxt.Lines(592)
            Sottotitolo.Button18.Text = TraduzioneLinguaTxt.Lines(593)
            Sottotitolo.Button19.Text = TraduzioneLinguaTxt.Lines(594)
            Sottotitolo.Button20.Text = TraduzioneLinguaTxt.Lines(595)
            Sottotitolo.Button32.Text = TraduzioneLinguaTxt.Lines(596)
            Sottotitolo.Button48.Text = TraduzioneLinguaTxt.Lines(597)
            Stile.Text = TraduzioneLinguaTxt.Lines(598)
            Stile.Stile1.Text = TraduzioneLinguaTxt.Lines(599)

            Stile.Stile2.Text = TraduzioneLinguaTxt.Lines(600)
            Stile.Stile3.Text = TraduzioneLinguaTxt.Lines(601)
            Stile.Stile4.Text = TraduzioneLinguaTxt.Lines(602)
            Stile.Button10.Text = TraduzioneLinguaTxt.Lines(603)
            Tabella.Text = TraduzioneLinguaTxt.Lines(604)
            Tabella.Button1.Text = TraduzioneLinguaTxt.Lines(605)
            Tabella.Button22.Text = TraduzioneLinguaTxt.Lines(606)
            Tabella.Button14.Text = TraduzioneLinguaTxt.Lines(607)
            Tabella.Button12.Text = TraduzioneLinguaTxt.Lines(608)
            Tabella.Button2.Text = TraduzioneLinguaTxt.Lines(609)
            Tabella.Button16.Text = TraduzioneLinguaTxt.Lines(610)
            Tabella.Button90.Text = TraduzioneLinguaTxt.Lines(611)
            Tabella.Button8.Text = TraduzioneLinguaTxt.Lines(612)
            Tabella.Label4.Text = TraduzioneLinguaTxt.Lines(613)
            Tabella.Button15.Text = TraduzioneLinguaTxt.Lines(614)
            Tabella.Button43.Text = TraduzioneLinguaTxt.Lines(615)
            Tabella.Button55.Text = TraduzioneLinguaTxt.Lines(616)
            Tabella.Button11.Text = TraduzioneLinguaTxt.Lines(617)
            Tabella.Button47.Text = TraduzioneLinguaTxt.Lines(618)
            Tabella.Button13.Text = TraduzioneLinguaTxt.Lines(619)
            Tabella.Button17.Text = TraduzioneLinguaTxt.Lines(620)
            Tabella.Button18.Text = TraduzioneLinguaTxt.Lines(621)
            Tabella.Button19.Text = TraduzioneLinguaTxt.Lines(622)
            Tabella.Button20.Text = TraduzioneLinguaTxt.Lines(623)
            Tabella.Button32.Text = TraduzioneLinguaTxt.Lines(624)
            Tabella.Button33.Text = TraduzioneLinguaTxt.Lines(625)
            Tabella.Button57.Text = TraduzioneLinguaTxt.Lines(626)
            Tabella.Label1.Text = TraduzioneLinguaTxt.Lines(627)
            Tabella.Button34.Text = TraduzioneLinguaTxt.Lines(628)
            Tabella.Button49.Text = TraduzioneLinguaTxt.Lines(629)
            Tabella.Label3.Text = TraduzioneLinguaTxt.Lines(630)
            Tabella.Button37.Text = TraduzioneLinguaTxt.Lines(631)
            Tabella.Button36.Text = TraduzioneLinguaTxt.Lines(632)
            Tabella.Button35.Text = TraduzioneLinguaTxt.Lines(633)
            Tabella.Button7.Text = TraduzioneLinguaTxt.Lines(634)
            Tabella.Label2.Text = TraduzioneLinguaTxt.Lines(635)
            Tabella.Button21.Text = TraduzioneLinguaTxt.Lines(636)
            Tabella.Button27.Text = TraduzioneLinguaTxt.Lines(637)
            Tabella.Button31.Text = TraduzioneLinguaTxt.Lines(638)
            Tabella.Button29.Text = TraduzioneLinguaTxt.Lines(639)
            Tabella.Button38.Text = TraduzioneLinguaTxt.Lines(640)
            Tabella.Button41.Text = TraduzioneLinguaTxt.Lines(641)
            Tabella.Button40.Text = TraduzioneLinguaTxt.Lines(642)
            Tabella.Button54.Text = TraduzioneLinguaTxt.Lines(643)
            Tabella.Button42.Text = TraduzioneLinguaTxt.Lines(644)
            Tabella.Button52.Text = TraduzioneLinguaTxt.Lines(645)
            Tabella.CheckBox1.Text = TraduzioneLinguaTxt.Lines(646)
            Tabella.CheckBox2.Text = TraduzioneLinguaTxt.Lines(647)
            Tabella.Button48.Text = TraduzioneLinguaTxt.Lines(648)
            TestoPersonalizzato.Text = TraduzioneLinguaTxt.Lines(649)
            TestoPersonalizzato.Button9.Text = TraduzioneLinguaTxt.Lines(650)
            TestoPersonalizzato.Button1.Text = TraduzioneLinguaTxt.Lines(651)
            TestoPersonalizzato.Button2.Text = TraduzioneLinguaTxt.Lines(652)
            TestoPersonalizzato.Button16.Text = TraduzioneLinguaTxt.Lines(653)
            TestoPersonalizzato.Button90.Text = TraduzioneLinguaTxt.Lines(654)
            TestoPersonalizzato.Button8.Text = TraduzioneLinguaTxt.Lines(655)
            TestoPersonalizzato.Button15.Text = TraduzioneLinguaTxt.Lines(656)
            TestoPersonalizzato.Button43.Text = TraduzioneLinguaTxt.Lines(657)
            TestoPersonalizzato.Button55.Text = TraduzioneLinguaTxt.Lines(658)
            TestoPersonalizzato.Button11.Text = TraduzioneLinguaTxt.Lines(659)
            TestoPersonalizzato.Button47.Text = TraduzioneLinguaTxt.Lines(660)
            TestoPersonalizzato.Button13.Text = TraduzioneLinguaTxt.Lines(661)
            TestoPersonalizzato.Button17.Text = TraduzioneLinguaTxt.Lines(662)
            TestoPersonalizzato.Button18.Text = TraduzioneLinguaTxt.Lines(663)
            TestoPersonalizzato.Button19.Text = TraduzioneLinguaTxt.Lines(664)
            TestoPersonalizzato.Button20.Text = TraduzioneLinguaTxt.Lines(665)
            TestoPersonalizzato.Button32.Text = TraduzioneLinguaTxt.Lines(666)
            TestoPersonalizzato.Button12.Text = TraduzioneLinguaTxt.Lines(667)
            TestoPersonalizzato.Label3.Text = TraduzioneLinguaTxt.Lines(668)
            TestoPersonalizzato.Button37.Text = TraduzioneLinguaTxt.Lines(669)
            TestoPersonalizzato.Button36.Text = TraduzioneLinguaTxt.Lines(670)
            TestoPersonalizzato.Button35.Text = TraduzioneLinguaTxt.Lines(671)
            TestoPersonalizzato.Button7.Text = TraduzioneLinguaTxt.Lines(672)
            TestoPersonalizzato.Button48.Text = TraduzioneLinguaTxt.Lines(673)
            Titolo.Text = TraduzioneLinguaTxt.Lines(674)
            Titolo.Button1.Text = TraduzioneLinguaTxt.Lines(675)
            Titolo.Button9.Text = TraduzioneLinguaTxt.Lines(676)
            Titolo.Button2.Text = TraduzioneLinguaTxt.Lines(677)
            Titolo.Button33.Text = TraduzioneLinguaTxt.Lines(678)
            Titolo.Label3.Text = TraduzioneLinguaTxt.Lines(679)
            Titolo.Button37.Text = TraduzioneLinguaTxt.Lines(680)
            Titolo.Button36.Text = TraduzioneLinguaTxt.Lines(681)
            Titolo.Button35.Text = TraduzioneLinguaTxt.Lines(682)
            Titolo.Button7.Text = TraduzioneLinguaTxt.Lines(683)
            Titolo.Label4.Text = TraduzioneLinguaTxt.Lines(684)
            Titolo.Button15.Text = TraduzioneLinguaTxt.Lines(685)
            Titolo.Button43.Text = TraduzioneLinguaTxt.Lines(686)
            Titolo.Button55.Text = TraduzioneLinguaTxt.Lines(687)
            Titolo.Button11.Text = TraduzioneLinguaTxt.Lines(688)
            Titolo.Button47.Text = TraduzioneLinguaTxt.Lines(689)
            Titolo.Button13.Text = TraduzioneLinguaTxt.Lines(690)
            Titolo.Button17.Text = TraduzioneLinguaTxt.Lines(691)
            Titolo.Button18.Text = TraduzioneLinguaTxt.Lines(692)
            Titolo.Button19.Text = TraduzioneLinguaTxt.Lines(693)
            Titolo.Button20.Text = TraduzioneLinguaTxt.Lines(694)
            Titolo.Button32.Text = TraduzioneLinguaTxt.Lines(695)
            Titolo.Button48.Text = TraduzioneLinguaTxt.Lines(696)
            'Button12.Text = TraduzioneLinguaTxt.Lines(697) '2 caso: "Pagina HTML"
            'Button57.Text = TraduzioneLinguaTxt.Lines(698)
            'Calcolatrice.DECButton.Text = TraduzioneLinguaTxt.Lines(699)

            'Calcolatrice.F2NDButton.Text = TraduzioneLinguaTxt.Lines(700)
            'Calcolatrice.Text = TraduzioneLinguaTxt.Lines(701)
            'Calcolatrice.ACButton.Text = TraduzioneLinguaTxt.Lines(702)
            'Calcolatrice.Button1.Text = TraduzioneLinguaTxt.Lines(703)
            'Calcolatrice.DELButton.Text = TraduzioneLinguaTxt.Lines(704)
            'Calcolatrice.PiuMenoButton.Text = TraduzioneLinguaTxt.Lines(705)
            'Calcolatrice.SetteButton.Text = TraduzioneLinguaTxt.Lines(706)
            'Calcolatrice.OttoButton.Text = TraduzioneLinguaTxt.Lines(707)
            'Calcolatrice.NoveButton.Text = TraduzioneLinguaTxt.Lines(708)
            'Calcolatrice.QuattroButton.Text = TraduzioneLinguaTxt.Lines(709)
            'Calcolatrice.CinqueButton.Text = TraduzioneLinguaTxt.Lines(710)
            'Calcolatrice.SeiButton.Text = TraduzioneLinguaTxt.Lines(711)
            'Calcolatrice.UnoButton.Text = TraduzioneLinguaTxt.Lines(712)
            'Calcolatrice.DueButton.Text = TraduzioneLinguaTxt.Lines(713)
            'Calcolatrice.TreButton.Text = TraduzioneLinguaTxt.Lines(714)
            'Calcolatrice.ZeroButton.Text = TraduzioneLinguaTxt.Lines(715)
            'Calcolatrice.PiuButton.Text = TraduzioneLinguaTxt.Lines(716)
            'Calcolatrice.PerButton.Text = TraduzioneLinguaTxt.Lines(717)
            'Calcolatrice.MenoButton.Text = TraduzioneLinguaTxt.Lines(718)
            'Calcolatrice.DivisioneButton.Text = TraduzioneLinguaTxt.Lines(719)
            'Calcolatrice.UgualeButton.Text = TraduzioneLinguaTxt.Lines(720)
            'Calcolatrice.ElevazioneButton.Text = TraduzioneLinguaTxt.Lines(721)
            'Calcolatrice.RadiceButton.Text = TraduzioneLinguaTxt.Lines(722)
            'Calcolatrice.PerMilleButton.Text = TraduzioneLinguaTxt.Lines(723)
            'Calcolatrice.PerCentoButton.Text = TraduzioneLinguaTxt.Lines(724)
            'Calcolatrice.Button2.Text = TraduzioneLinguaTxt.Lines(725)
            'Calcolatrice.VirgolaButton.Text = TraduzioneLinguaTxt.Lines(726)
            'Calcolatrice.MostraMemoriaButton.Text = TraduzioneLinguaTxt.Lines(727)
            'Calcolatrice.MemoriaPiuButton.Text = TraduzioneLinguaTxt.Lines(728)
            '.Text = TraduzioneLinguaTxt.Lines(729) '2 caso: "MC"
            '.Text = TraduzioneLinguaTxt.Lines(730) '2 caso: "M-"
            '.Text = TraduzioneLinguaTxt.Lines(731) '2 caso: "!n"
            '.Text = TraduzioneLinguaTxt.Lines(732) '2 caso: "log"
            '.Text = TraduzioneLinguaTxt.Lines(733) '2 caso: "e"
            '.Text = TraduzioneLinguaTxt.Lines(734) '2 caso: "##pigreco##"
            Calcolatrice.ToolStripMenuItem4.Text = TraduzioneLinguaTxt.Lines(735)
            Calcolatrice.ToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(736)
            GrassettoBarraStrumenti.Text = TraduzioneLinguaTxt.Lines(737)
            Informazioni.SetToolTip(GrassettoBarraStrumenti, TraduzioneLinguaTxt.Lines(738)) 'tooltip
            CorsivoBarraStrumenti.Text = TraduzioneLinguaTxt.Lines(739)
            Informazioni.SetToolTip(CorsivoBarraStrumenti, TraduzioneLinguaTxt.Lines(740)) 'tooltip
            SottolineatoBarraStrumenti.Text = TraduzioneLinguaTxt.Lines(741)
            Informazioni.SetToolTip(SottolineatoBarraStrumenti, TraduzioneLinguaTxt.Lines(742)) 'tooltip
            BarratoBarraStrumenti.Text = TraduzioneLinguaTxt.Lines(743)
            Informazioni.SetToolTip(BarratoBarraStrumenti, TraduzioneLinguaTxt.Lines(744)) 'tooltip
            ACapoBarraStrumenti.Text = TraduzioneLinguaTxt.Lines(745)
            Informazioni.SetToolTip(ACapoBarraStrumenti, TraduzioneLinguaTxt.Lines(746)) 'tooltip
            SeparatoreBarraStrumenti.Text = TraduzioneLinguaTxt.Lines(747)
            Informazioni.SetToolTip(SeparatoreBarraStrumenti, TraduzioneLinguaTxt.Lines(748)) 'tooltip
            'Button51.Text = TraduzioneLinguaTxt.Lines(749)
            'Button52.Text = TraduzioneLinguaTxt.Lines(750)
            'Button53.Text = TraduzioneLinguaTxt.Lines(751)
            'Button54.Text = TraduzioneLinguaTxt.Lines(752)
            'Button55.Text = TraduzioneLinguaTxt.Lines(753)
            'Button56.Text = TraduzioneLinguaTxt.Lines(754)

            Impostazioni.GeneraleButton.Text = TraduzioneLinguaTxt.Lines(755)
            Impostazioni.AutoSaveButton.Text = TraduzioneLinguaTxt.Lines(756)
            Impostazioni.InterfacciaButton.Text = TraduzioneLinguaTxt.Lines(757)
            Impostazioni.PrivacyButton.Text = TraduzioneLinguaTxt.Lines(758)
            Impostazioni.AvanzateButton.Text = TraduzioneLinguaTxt.Lines(759)
            InserisciToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(760)

            Ringraziamenti.LinkRisorseCompleteRingraziamenti.Text = TraduzioneLinguaTxt.Lines(778)

            Impostazioni.LinguaLabel.Text = TraduzioneLinguaTxt.Lines(779)

            ContexMenu2.CercaNelWeb.Text = TraduzioneLinguaTxt.Lines(780)

            '.Text = TraduzioneLinguaTxt.Lines()
            '.Informazioni.SetToolTip(, TraduzioneLinguaTxt.Lines()) 'tooltip
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\language.mcesx", LinguaTxt.Text)
            MessaggioF.Button1.Text = ("The file containing the translation of language is not available or is damaged." & vbNewLine & "Please reistall My Code Editor. For now it will be displayed in Italian." & vbNewLine & "Error code: MCEEAA0013")
            MessaggioF.Text = ("Error: The language file is not available")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0013")
            MessaggioF.ShowDialog()

            LinguaTxt.Text = "ITA-IT"

            p.Y = 60
            Impostazioni.ita.BackColor = Color.DarkRed
            Impostazioni.ita.FlatAppearance.MouseOverBackColor = Color.DarkRed
            Impostazioni.ita.FlatAppearance.MouseDownBackColor = Color.DarkRed
            Impostazioni.LinguaButton.Text = Impostazioni.ita.Text
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\language.mcesx", LinguaTxt.Text)
        End If
        Impostazioni.LinguaPanel.Location = p

        'fine lingua

        'impostazioni
inizioimpostazioni:
        Try
            If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\settings.mcesx") <> "" Then
                ImpostazioniTxt.Text = (System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\settings.mcesx"))

                Dim linea(0) As String
                linea(0) = ImpostazioniTxt.Lines(2).Replace("CONTROLLA GLI AGGIORNAMENTI AUTOMATICAMENTE - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.GeneraleCheck0.Checked = True
                    Impostazioni.GeneraleTxt0.Text = "SI"
                    linea(0) = ImpostazioniTxt.Lines(3).Replace("SCARICA GLI AGGIORNAMENTI - [[", "")
                    linea(0) = linea(0).Replace("]]", "")
                    If linea(0) = "SI" Then
                        Impostazioni.GeneraleCheck1.Checked = True
                        Impostazioni.GeneraleTxt1.Text = "SI"
                        aggiornamentoscaricaautomaticamenteavvio = True
                    End If
                    ControlloAggiornamenti.Text = TraduzioneLinguaTxt.Lines(347)
                    ControlloAggiornamenti.Button1.Text = TraduzioneLinguaTxt.Lines(348)
                    ControlloAggiornamenti.ScaricaDopoButton.Text = TraduzioneLinguaTxt.Lines(349)
                    ControlloAggiornamenti.ScaricaButton.Text = TraduzioneLinguaTxt.Lines(350)
                    ControlloAggiornamenti.InstallaButton.Text = TraduzioneLinguaTxt.Lines(351)
                    ControlloAggiornamenti.SaveFileDialog1.FileName = TraduzioneLinguaTxt.Lines(352)
                    ControlloAggiornamenti.SaveFileDialog1.Title = TraduzioneLinguaTxt.Lines(353)
                    ControlloAggiornamenti.MinimizeBox = False
                    ControlloAggiornamenti.ShowDialog()
                    Impostazioni.GeneraleCheck1.Enabled = True
                Else
                    Impostazioni.GeneraleCheck0.Checked = False
                    Impostazioni.GeneraleTxt0.Text = "NO"
                    Impostazioni.GeneraleCheck1.Checked = False
                    Impostazioni.GeneraleCheck1.Enabled = False
                    Impostazioni.GeneraleTxt1.Text = "NO"
                End If

                linea(0) = ImpostazioniTxt.Lines(4).Replace("VISUALIZZA IL TESTO A CAPO AUTOMATICAMENTE - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.GeneraleCheck2.Checked = True
                    Impostazioni.GeneraleTxt2.Text = "SI"
                    FastColoredTextBox1.WordWrap = True
                    CSSFTB.WordWrap = True
                    VisualizzaPanelMenu.ACapoAutomatico.Image = My.Resources.si
                Else
                    Impostazioni.GeneraleCheck2.Checked = False
                    Impostazioni.GeneraleTxt2.Text = "NO"
                    FastColoredTextBox1.WordWrap = False
                    CSSFTB.WordWrap = False
                    VisualizzaPanelMenu.ACapoAutomatico.Image = My.Resources.no
                End If

                linea(0) = ImpostazioniTxt.Lines(5).Replace("VISUALIZZA SUGGERIMENTI W3SHOOLS - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.GeneraleCheck3.Checked = True
                    Impostazioni.GeneraleTxt3.Text = "SI"
                Else
                    Impostazioni.GeneraleCheck3.Checked = False
                    Impostazioni.GeneraleTxt3.Text = "NO"
                End If

                linea(0) = ImpostazioniTxt.Lines(6).Replace("INSERISCI <BR/> QUANDO SI PREME SHIFT+ENTER - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.GeneraleCheck4.Checked = True
                    Impostazioni.GeneraleTxt4.Text = "SI"
                Else
                    Impostazioni.GeneraleCheck4.Checked = False
                    Impostazioni.GeneraleTxt4.Text = "NO"
                End If

                linea(0) = ImpostazioniTxt.Lines(7).Replace("INSERISCI <HR/> QUANDO SI PREME CTRL+ENTER - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.GeneraleCheck5.Checked = True
                    Impostazioni.GeneraleTxt5.Text = "SI"
                Else
                    Impostazioni.GeneraleCheck5.Checked = False
                    Impostazioni.GeneraleTxt5.Text = "NO"
                End If

                linea(0) = ImpostazioniTxt.Lines(8).Replace("CANCELLA LA RIGA CORRENTE QUANDO SI PREME CTRL+SHIFT+D - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.GeneraleCheck6.Checked = True
                    Impostazioni.GeneraleTxt6.Text = "SI"
                Else
                    Impostazioni.GeneraleCheck6.Checked = False
                    Impostazioni.GeneraleTxt6.Text = "NO"
                End If

                linea(0) = ImpostazioniTxt.Lines(10).Replace("SALVA AUTOMATICAMENTE IL PROGETTO APERTO - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.AutoSaveCheck0.Checked = True
                    Impostazioni.AutoSaveTxt0.Text = "SI"
                    Impostazioni.HTML1m.Enabled = True
                    Impostazioni.HTML5m.Enabled = True
                    Impostazioni.HTML10m.Enabled = True
                    Impostazioni.HTML30m.Enabled = True
                    Impostazioni.HTML1h.Enabled = True
                    Impostazioni.HTML2h.Enabled = True
                    Impostazioni.HTMLPersonalizzato.Enabled = True
                    Impostazioni.CSS1m.Enabled = True
                    Impostazioni.CSS5m.Enabled = True
                    Impostazioni.CSS10m.Enabled = True
                    Impostazioni.CSS30m.Enabled = True
                    Impostazioni.CSS1h.Enabled = True
                    Impostazioni.CSS2h.Enabled = True
                    Impostazioni.CSSPersonalizzato.Enabled = True
                Else
                    Impostazioni.AutoSaveCheck0.Checked = False
                    Impostazioni.AutoSaveTxt0.Text = "NO"
                    Impostazioni.HTML1m.Enabled = False
                    Impostazioni.HTML5m.Enabled = False
                    Impostazioni.HTML10m.Enabled = False
                    Impostazioni.HTML30m.Enabled = False
                    Impostazioni.HTML1h.Enabled = False
                    Impostazioni.HTML2h.Enabled = False
                    Impostazioni.HTMLPersonalizzato.Enabled = False
                    Impostazioni.CSS1m.Enabled = False
                    Impostazioni.CSS5m.Enabled = False
                    Impostazioni.CSS10m.Enabled = False
                    Impostazioni.CSS30m.Enabled = False
                    Impostazioni.CSS1h.Enabled = False
                    Impostazioni.CSS2h.Enabled = False
                    Impostazioni.CSSPersonalizzato.Enabled = False
                End If
                linea(0) = ImpostazioniTxt.Lines(11).Replace("SALVA IL FILE HTML OGNI - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                Impostazioni.AutoSaveTxtHTML.Text = linea(0)
                linea(0) = ImpostazioniTxt.Lines(12).Replace("SALVA IL FILE CSS OGNI - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                Impostazioni.AutoSaveTxtCSS.Text = linea(0)
                If Impostazioni.AutoSaveTxtHTML.Text = "60000" Then
                    Impostazioni.HTML1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.HTML1m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "300000" Then
                    Impostazioni.HTML1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.HTML5m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "600000" Then
                    Impostazioni.HTML1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.HTML10m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "1800000" Then
                    Impostazioni.HTML1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.HTML30m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "3600000" Then
                    Impostazioni.HTML1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.HTML1h.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "7200000" Then
                    Impostazioni.HTML1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.HTML2h.BackColor = Color.DarkRed
                Else
                    Impostazioni.HTML1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTML2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.HTMLPersonalizzato.BackColor = Color.DarkRed
                    If (Impostazioni.AutoSaveTxtHTML.Text >= 1000 And Impostazioni.AutoSaveTxtHTML.Text < 60000) Then
                        Impostazioni.HTMLTextBox.Text = Impostazioni.AutoSaveTxtHTML.Text / 1000
                        Impostazioni.HTMLComboBox.Text = ("s")
                    ElseIf (Impostazioni.AutoSaveTxtHTML.Text >= 60000 And Impostazioni.AutoSaveTxtHTML.Text < 3600000) Then
                        Impostazioni.HTMLTextBox.Text = Impostazioni.AutoSaveTxtHTML.Text / 60000
                        Impostazioni.HTMLComboBox.Text = ("m")
                    ElseIf (Impostazioni.AutoSaveTxtHTML.Text >= 3600000 And Impostazioni.AutoSaveTxtHTML.Text < 99 * 3600000) Then
                        Impostazioni.HTMLTextBox.Text = Impostazioni.AutoSaveTxtHTML.Text / 3600000
                        Impostazioni.HTMLComboBox.Text = ("h")
                    End If
                End If
                If Impostazioni.AutoSaveTxtCSS.Text = "60000" Then
                    Impostazioni.CSS1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSSPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.CSS1m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "300000" Then
                    Impostazioni.CSS1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSSPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.CSS5m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "600000" Then
                    Impostazioni.CSS1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSSPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.CSS10m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "1800000" Then
                    Impostazioni.CSS1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSSPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.CSS30m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "3600000" Then
                    Impostazioni.CSS1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSSPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.CSS1h.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "7200000" Then
                    Impostazioni.CSS1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSSPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    Impostazioni.CSS2h.BackColor = Color.DarkRed
                Else
                    Impostazioni.CSS1m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS5m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS10m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS30m.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS1h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSS2h.BackColor = Color.FromArgb(140, 140, 140)
                    Impostazioni.CSSPersonalizzato.BackColor = Color.FromArgb(140, 140, 140)

                    If (Impostazioni.AutoSaveTxtCSS.Text >= 1000 And Impostazioni.AutoSaveTxtCSS.Text < 60000) Then
                        Impostazioni.CSSTextBox.Text = Impostazioni.AutoSaveTxtCSS.Text / 1000
                        Impostazioni.CSSComboBox.Text = ("s")
                    ElseIf (Impostazioni.AutoSaveTxtCSS.Text >= 60000 And Impostazioni.AutoSaveTxtCSS.Text < 3600000) Then
                        Impostazioni.CSSTextBox.Text = Impostazioni.AutoSaveTxtCSS.Text / 60000
                        Impostazioni.CSSComboBox.Text = ("m")
                    ElseIf (Impostazioni.AutoSaveTxtCSS.Text >= 3600000 And Impostazioni.AutoSaveTxtCSS.Text < 99 * 3600000) Then
                        Impostazioni.CSSTextBox.Text = Impostazioni.AutoSaveTxtCSS.Text / 3600000
                        Impostazioni.CSSComboBox.Text = ("h")
                    End If
                    Impostazioni.CSSPersonalizzato.BackColor = Color.DarkRed
                End If

                linea(0) = ImpostazioniTxt.Lines(14).Replace("VISUALIZZA LA BARRA INFERIORE - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.InterfacciaCheck0.Checked = True
                    Impostazioni.InterfacciaTxt0.Text = "SI"
                    VisualizzaPanelMenu.BarraInferiore.Image = My.Resources.si
                    BarraInferiore.Visible = True
                Else
                    Impostazioni.InterfacciaCheck0.Checked = False
                    Impostazioni.InterfacciaTxt0.Text = "NO"
                    VisualizzaPanelMenu.BarraInferiore.Image = My.Resources.no
                    BarraInferiore.Visible = False
                End If

                linea(0) = ImpostazioniTxt.Lines(15).Replace("VISUALIZZA LA BARRA LATERALE - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.InterfacciaCheck1.Checked = True
                    Impostazioni.InterfacciaTxt1.Text = "SI"
                    BarraLaterale.Visible = True
                Else
                    Impostazioni.InterfacciaCheck1.Checked = False
                    Impostazioni.InterfacciaTxt1.Text = "NO"
                    BarraLaterale.Visible = False
                End If

                linea(0) = ImpostazioniTxt.Lines(16).Replace("VISUALIZZA A SCHERMO INTERO ALL'AVVIO - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.InterfacciaCheck2.Checked = True
                    Impostazioni.InterfacciaTxt2.Text = "SI"

                    My.Settings.aschermointero = ("si")
                    VisualizzaPanelMenu.ASchermoIntero.Image = My.Resources.si

                    If Me.WindowState = FormWindowState.Maximized Then
                        finestrastato = "mass"
                    Else
                        finestrastato = "norm"
                    End If
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    Me.WindowState = FormWindowState.Maximized
                Else
                    Impostazioni.InterfacciaCheck2.Checked = False
                    Impostazioni.InterfacciaTxt2.Text = "NO"

                    My.Settings.aschermointero = ("no")
                    VisualizzaPanelMenu.ASchermoIntero.Image = My.Resources.no
                End If

                linea(0) = ImpostazioniTxt.Lines(18).Replace("INVIA SEGNALAZIONI ANONIME - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "SI" Then
                    Impostazioni.PrivacyCheck0.Checked = True
                    Impostazioni.PrivacyTxt0.Text = "SI"
                Else
                    Impostazioni.PrivacyCheck0.Checked = False
                    Impostazioni.PrivacyTxt0.Text = "NO"
                End If

                linea(0) = ImpostazioniTxt.Lines(20).Replace("APRI L'ANTEPRIMA DEL PROGETTO NEL - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "WBI" Then
                    Impostazioni.AvanzateRadio0.Checked = True
                    Impostazioni.TextBox1.Enabled = False
                    Impostazioni.TextBox1.Text = ""
                    Impostazioni.Button10.Enabled = False
                    Impostazioni.AvanzateTxt0.Text = "WBI"
                ElseIf linea(0) = "WBP" Then
                    Impostazioni.AvanzateRadio1.Checked = True
                    Impostazioni.TextBox1.Enabled = False
                    Impostazioni.TextBox1.Text = ""
                    Impostazioni.Button10.Enabled = False
                    Impostazioni.AvanzateTxt0.Text = "WBP"
                Else
                    If Dir(linea(0)) <> "" Then
                        Impostazioni.AvanzateRadio2.Checked = True
                        Impostazioni.TextBox1.Enabled = True
                        Impostazioni.TextBox1.Text = linea(0)
                        Impostazioni.Button10.Enabled = True
                        Impostazioni.AvanzateTxt0.Text = linea(0)
                    Else
                        Impostazioni.AvanzateRadio0.Checked = True
                        Impostazioni.TextBox1.Enabled = False
                        Impostazioni.TextBox1.Text = ""
                        Impostazioni.Button10.Enabled = False
                        Impostazioni.AvanzateTxt0.Text = "WBI"
                    End If
                End If

                linea(0) = ImpostazioniTxt.Lines(21).Replace("PERCORSO PREDEFINITO DEI PROGETTI - [[", "")
                linea(0) = linea(0).Replace("]]", "")
                If linea(0) = "##DEFAULT##" Then
                    Impostazioni.AvanzatePercorsoRadio0.Checked = True
                    Impostazioni.TextBox2.Enabled = False
                    Impostazioni.TextBox2.Text = ""
                    Impostazioni.Button1.Enabled = False
                    Impostazioni.AvanzateTxt1.Text = "##DEFAULT##"
                Else
                    If My.Computer.FileSystem.DirectoryExists(linea(0)) Then
                        Impostazioni.AvanzatePercorsoRadio1.Checked = True
                        Impostazioni.TextBox2.Enabled = True
                        Impostazioni.TextBox2.Text = linea(0)
                        Impostazioni.Button1.Enabled = True
                        Impostazioni.AvanzateTxt1.Text = linea(0)
                    Else
                        Impostazioni.AvanzatePercorsoRadio0.Checked = True
                        Impostazioni.TextBox2.Enabled = False
                        Impostazioni.TextBox2.Text = ""
                        Impostazioni.Button1.Enabled = False
                        Impostazioni.AvanzateTxt1.Text = "##DAFAULT##"
                    End If
                End If
            Else
                Dim linee(21) As String
                linee(0) = "IMPOSTAZIONI - MY CODE EDITOR"
                linee(1) = "GENERALE"
                linee(2) = "CONTROLLA GLI AGGIORNAMENTI AUTOMATICAMENTE - [[NO]]"
                linee(3) = "SCARICA GLI AGGIORNAMENTI - [[NO]]"
                linee(4) = "VISUALIZZA IL TESTO A CAPO AUTOMATICAMENTE - [[NO]]"
                linee(5) = "VISUALIZZA SUGGERIMENTI W3SHOOLS - [[SI]]"
                linee(6) = "INSERISCI <BR/> QUANDO SI PREME SHIFT+ENTER - [[SI]]"
                linee(7) = "INSERISCI <HR/> QUANDO SI PREME CTRL+ENTER - [[SI]]"
                linee(8) = "CANCELLA LA RIGA CORRENTE QUANDO SI PREME CTRL+SHIFT+D - [[SI]]"
                linee(9) = "AUTO-SALVATAGGIO"
                linee(10) = "SALVA AUTOMATICAMENTE IL PROGETTO APERTO - [[NO]]"
                linee(11) = "SALVA IL FILE HTML OGNI - [[3600000]]"
                linee(12) = "SALVA IL FILE CSS OGNI - [[3600000]]"
                linee(13) = "INTERFACCIA"
                linee(14) = "VISUALIZZA LA BARRA INFERIORE - [[SI]]"
                linee(15) = "VISUALIZZA LA BARRA LATERALE - [[SI]]"
                linee(16) = "VISUALIZZA A SCHERMO INTERO ALL'AVVIO - [[NO]]"
                linee(17) = "PRIVACY"
                linee(18) = "INVIA SEGNALAZIONI ANONIME - [[NO]]"
                linee(19) = "AVANZATE"
                linee(20) = "APRI L'ANTEPRIMA DEL PROGETTO NEL - [[WBI]]"
                linee(21) = "PERCORSO PREDEFINITO DEI PROGETTI - [[##DEFAULT##]]"

                ImpostazioniTxt.Lines = linee
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\settings.mcesx", ImpostazioniTxt.Text)
            End If
        Catch ex As Exception
            MessaggioF.Button1.Text = ("Si è verificato un errore nel caricamento delle impostazioni. Verranno ripristinate quelle predefinite perchè sono danneggiate." & vbNewLine & "Codice errore: MCEAA0001")
            MessaggioF.Text = ("Errore: Impostazioni danneggiate")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0001")
            MessaggioF.ShowDialog()
            Dim linee(21) As String
            linee(0) = "IMPOSTAZIONI - MY CODE EDITOR"
            linee(1) = "GENERALE"
            linee(2) = "CONTROLLA GLI AGGIORNAMENTI AUTOMATICAMENTE - [[NO]]"
            linee(3) = "SCARICA GLI AGGIORNAMENTI - [[NO]]"
            linee(4) = "VISUALIZZA IL TESTO A CAPO AUTOMATICAMENTE - [[NO]]"
            linee(5) = "VISUALIZZA SUGGERIMENTI W3SHOOLS - [[SI]]"
            linee(6) = "INSERISCI <BR/> QUANDO SI PREME SHIFT+ENTER - [[SI]]"
            linee(7) = "INSERISCI <HR/> QUANDO SI PREME CTRL+ENTER - [[SI]]"
            linee(8) = "CANCELLA LA RIGA CORRENTE QUANDO SI PREME CTRL+SHIFT+D - [[SI]]"
            linee(9) = "AUTO-SALVATAGGIO"
            linee(10) = "SALVA AUTOMATICAMENTE IL PROGETTO APERTO - [[NO]]"
            linee(11) = "SALVA IL FILE HTML OGNI - [[3600000]]"
            linee(12) = "SALVA IL FILE CSS OGNI - [[3600000]]"
            linee(13) = "INTERFACCIA"
            linee(14) = "VISUALIZZA LA BARRA INFERIORE - [[SI]]"
            linee(15) = "VISUALIZZA LA BARRA LATERALE - [[SI]]"
            linee(16) = "VISUALIZZA A SCHERMO INTERO ALL'AVVIO - [[NO]]"
            linee(17) = "PRIVACY"
            linee(18) = "INVIA SEGNALAZIONI ANONIME - [[NO]]"
            linee(19) = "AVANZATE"
            linee(20) = "APRI L'ANTEPRIMA DEL PROGETTO NEL - [[WBI]]"
            linee(21) = "PERCORSO PREDEFINITO DEI PROGETTI - [[##DEFAULT##]]"

            ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\settings.mcesx", ImpostazioniTxt.Text)
            GoTo inizioimpostazioni
        End Try
        'fine impostazioni

        FastColoredTextBox1.Select()
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        VisualizzaButton.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        MCEButton.Enabled = True
        Try
            Dim argomenti As String() = My.Application.CommandLineArgs.ToArray
            Dim filenonsupportato As Boolean = False
            If argomenti.Length > 0 Then
                Dim testo As String
                testo = argomenti(0)
                FastColoredTextBox1.Text = (My.Computer.FileSystem.ReadAllText(testo))
                TitoloProg.Text = My.Computer.FileSystem.GetName(testo)
                percorsoSALVATAGGIO.Text = testo.Replace(TitoloProg.Text, "")
                PercorsoFileHTML = percorsoSALVATAGGIO.Text & TitoloProg.Text
                If TitoloProg.Text.Contains(".html") Then
                    TitoloProg.Text = TitoloProg.Text.Replace(".html", "")
                    EstensioneFile = "html"
                ElseIf TitoloProg.Text.Contains(".htm") Then
                    TitoloProg.Text = TitoloProg.Text.Replace(".htm", "")
                    EstensioneFile = "htm"
                ElseIf TitoloProg.Text.Contains(".shtml") Then
                    TitoloProg.Text = TitoloProg.Text.Replace(".shtml", "")
                    EstensioneFile = "shtml"
                ElseIf TitoloProg.Text.Contains(".shtm") Then
                    TitoloProg.Text = TitoloProg.Text.Replace(".shtm", "")
                    EstensioneFile = "shtm"
                ElseIf TitoloProg.Text.Contains(".mcesx") Then
                    EstensioneFile = "mcesx"
                ElseIf TitoloProg.Text.Contains(".mcerec") Then
                    EstensioneFile = "mcerec"
                ElseIf TitoloProg.Text.Contains(".mcelang") Then
                    EstensioneFile = "mcelang"
                Else
                    filenonsupportato = True
                End If
                PercorsoFileCSS = percorsoSALVATAGGIO.Text & TitoloProg.Text & ".css"
                Me.Text = TitoloProg.Text & " • My Code Editor"
                PercorsoFileButton.Text = percorsoSALVATAGGIO.Text
                buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                SaveFileDialog1.FileName = ""

                If Not filenonsupportato And System.IO.File.Exists(PercorsoFileCSS) Then
                    buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                    buttproghtml.Enabled = True
                    buttprogcss.Visible = True
                    CSSSIoNOtb.Text = ("si")
                    ProgettazioneButtonR.Enabled = True
                    AnteprimaButtonR.Enabled = True
                    FTPButton.Enabled = True
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                    FastColoredTextBox1.Select()
                    CSSFTB.Text = (System.IO.File.ReadAllText(PercorsoFileCSS))
                    buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                ElseIf Not filenonsupportato And Not System.IO.File.Exists(PercorsoFileCSS) Then
                    buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                    buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                    buttproghtml.Enabled = True
                    buttprogcss.Visible = False
                    CSSSIoNOtb.Text = ("no")
                    ProgettazioneButtonR.Enabled = True
                    AnteprimaButtonR.Enabled = True
                    FTPButton.Enabled = True
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                    FastColoredTextBox1.Select()
                    filenonsupportato = False
                ElseIf Text.Contains(".mcesx") Or Text.Contains(".mcerec") Or Text.Contains(".mcelang") Then
                    buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                    buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                    buttproghtml.Enabled = False
                    buttprogcss.Visible = False
                    CSSSIoNOtb.Text = ("no")
                    ProgettazioneButtonR.Enabled = False
                    AnteprimaButtonR.Enabled = False
                    FTPButton.Enabled = False
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
                    FastColoredTextBox1.Select()
                    filenonsupportato = True
                Else
                    MessaggioErroreFileNonSupportato.ShowDialog()
                    buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                    buttproghtml.Visible = False
                    buttprogcss.Visible = False
                    CSSSIoNOtb.Text = ("no")
                    ProgettazioneButtonR.Enabled = True
                    AnteprimaButtonR.Enabled = False
                    FTPButton.Enabled = False
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
                    FastColoredTextBox1.Select()
                    InserisciButton.Enabled = False
                    InserisciToolStripMenuItem1.Enabled = False
                    buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                    buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                    filenonsupportato = True
                End If
                If filenonsupportato = False Then
                    Avvio.Show()
                    Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
                    Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
                    Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
                    Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
                    Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
                    Me.TitoloProg.Text = (Me.Text.Replace(" • My Code Editor", ""))
                    Avvio.recente1butt.Text = (TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", PercorsoFileHTML)
                    Avvio.Close()
                End If
                ultimoProgettoSalvato.Text = (FastColoredTextBox1.Text)
                FastColoredTextBox1.ClearUndo()
                CSSFTB.ClearUndo()
            Else
                Me.Show()
                Avvio.ShowDialog()
            End If
            verifica_percorso()
        Catch ex As Exception
            MessaggioF.Text = ("Errore: File URI non supportati")
            MessaggioF.Button1.Text = ("Il file che si sta tentando di aprire non è supportato da My Code Editor e pertanto non può essere aperto." & vbNewLine & "Errore inaspettato nell'apertura del file o del file stesso." & vbNewLine & "Codice errore: MCEEAA0002")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0002")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
        MyCodeEditorAvvio.Close()
        Me.Show()
    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles AnteprimaButtonR.Click
        anteprimadelprogetto_func()
    End Sub

    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles FileButton.Click
        If file_menu Then
            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke

            file_menu = False
            FilePanelMenu.Close()

            If buttprogcss.BackColor = Color.Red Then
                CSSFTB.Select()
            Else
                FastColoredTextBox1.Select()
            End If
        Else
            FileButton.BackColor = Color.WhiteSmoke
            FileButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            FileButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            FileButton.ForeColor = Color.DarkRed

            file_mostra_menu()
        End If

        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanelMenu.Close()
        modifica_menu = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanelMenu.Close()
        visualizza_menu = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanelMenu.Close()
        inserisci_menu = False
        MCEButton.BackColor = Color.DarkRed
        MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
        MCEButton.ForeColor = Color.WhiteSmoke
        MCEPanelMenu.Close()
        mce_menu = False
    End Sub

    Private Sub ModificaButton_Click(sender As Object, e As EventArgs) Handles ModificaButton.Click
        If modifica_menu Then
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke

            modifica_menu = False
            ModificaPanelMenu.Close()

            If buttprogcss.BackColor = Color.Red Then
                CSSFTB.Select()
            Else
                FastColoredTextBox1.Select()
            End If
        Else
            ModificaButton.BackColor = Color.WhiteSmoke
            ModificaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            ModificaButton.ForeColor = Color.DarkRed

            modifica_mostra_menu()
        End If

        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanelMenu.Close()
        file_menu = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanelMenu.Close()
        visualizza_menu = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanelMenu.Close()
        inserisci_menu = False
        MCEButton.BackColor = Color.DarkRed
        MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
        MCEButton.ForeColor = Color.WhiteSmoke
        MCEPanelMenu.Close()
        mce_menu = False
    End Sub

    Private Sub VisualizzaButton_Click(sender As Object, e As EventArgs) Handles VisualizzaButton.Click
        If visualizza_menu Then
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke

            VisualizzaPanelMenu.Close()
            visualizza_menu = False

            If buttprogcss.BackColor = Color.Red Then
                CSSFTB.Select()
            Else
                FastColoredTextBox1.Select()
            End If
        Else
            VisualizzaButton.BackColor = Color.WhiteSmoke
            VisualizzaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            VisualizzaButton.ForeColor = Color.DarkRed

            visualizza_mostra_menu()
        End If

        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanelMenu.Close()
        file_menu = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanelMenu.Close()
        modifica_menu = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanelMenu.Close()
        inserisci_menu = False
        MCEButton.BackColor = Color.DarkRed
        MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
        MCEButton.ForeColor = Color.WhiteSmoke
        MCEPanelMenu.Close()
        mce_menu = False
    End Sub

    Private Sub InserisciButton_Click(sender As Object, e As EventArgs) Handles InserisciButton.Click
        If inserisci_menu Then
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke

            InserisciPanelMenu.Close()
            inserisci_menu = False

            If buttprogcss.BackColor = Color.Red Then
                CSSFTB.Select()
            Else
                FastColoredTextBox1.Select()
            End If
        Else
            InserisciButton.BackColor = Color.WhiteSmoke
            InserisciButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            InserisciButton.ForeColor = Color.DarkRed

            inserisci_mostra_menu()
        End If

        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanelMenu.Close()
        file_menu = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanelMenu.Close()
        modifica_menu = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanelMenu.Close()
        visualizza_menu = False
        MCEButton.BackColor = Color.DarkRed
        MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
        MCEButton.ForeColor = Color.WhiteSmoke
        MCEPanelMenu.Close()
        mce_menu = False
    End Sub

    Private Sub MinionOneButton_Click(sender As Object, e As EventArgs) Handles MCEButton.Click
        If mce_menu Then
            MCEButton.BackColor = Color.DarkRed
            MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
            MCEButton.ForeColor = Color.WhiteSmoke

            mce_menu = False
            MCEPanelMenu.Close()

            If buttprogcss.BackColor = Color.Red Then
                CSSFTB.Select()
            Else
                FastColoredTextBox1.Select()
            End If
        Else
            MCEButton.BackColor = Color.WhiteSmoke
            MCEButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            MCEButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            MCEButton.ForeColor = Color.DarkRed

            mce_mostra_menu()
        End If

        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanelMenu.Close()
        file_menu = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanelMenu.Close()
        modifica_menu = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanelMenu.Close()
        visualizza_menu = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanelMenu.Close()
        inserisci_menu = False
    End Sub

    Private Sub BarraDeiMenu_MouseEnter(sender As Object, e As EventArgs) Handles BarraDeiMenu.MouseEnter
        chiudi_tutti_menu()

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub FastColoredTextBox1_MouseEnter(sender As Object, e As EventArgs) Handles FastColoredTextBox1.MouseEnter
        chiudi_tutti_menu()
    End Sub

    Private Sub buttprogcss_Click(sender As Object, e As EventArgs) Handles buttprogcss.Click
        buttproghtml.BackColor = Color.DarkRed
        buttprogcss.BackColor = Color.Red
        CSSFTB.Visible = True
        FastColoredTextBox1.Visible = False
        Button9.Text = ("")
        Button9.Text = (CSSFTB.Text.Length)
        Button2.Text = ("")
        Button2.Text = (CSSFTB.Lines.Count)
        InserisciButton.Enabled = False
        InserisciToolStripMenuItem1.Enabled = False
        Button5.Text = (UltSalCSS.Text)

        BarraDegliStrumenti.Visible = True

        GrassettoBarraStrumenti.Enabled = False
        CorsivoBarraStrumenti.Enabled = False
        SottolineatoBarraStrumenti.Enabled = False
        BarratoBarraStrumenti.Enabled = False
        ACapoBarraStrumenti.Enabled = False
        SeparatoreBarraStrumenti.Enabled = False

        CSSFTB.Select()
    End Sub

    Private Sub buttprogling_Click(sender As Object, e As EventArgs) Handles buttproghtml.Click
        buttproghtml.BackColor = Color.Red
        buttprogcss.BackColor = Color.DarkRed
        CSSFTB.Visible = False
        FastColoredTextBox1.Visible = True
        Button9.Text = ("")
        Button9.Text = (FastColoredTextBox1.Text.Length)
        Button2.Text = ("")
        Button2.Text = (FastColoredTextBox1.Lines.Count)
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        Button5.Text = (UltSalHTML.Text)

        BarraDegliStrumenti.Visible = True

        GrassettoBarraStrumenti.Enabled = True
        CorsivoBarraStrumenti.Enabled = True
        SottolineatoBarraStrumenti.Enabled = True
        BarratoBarraStrumenti.Enabled = True
        ACapoBarraStrumenti.Enabled = True
        SeparatoreBarraStrumenti.Enabled = True

        FastColoredTextBox1.Select()
    End Sub

    Private Sub ProgettazioneButtonR_Click(sender As Object, e As EventArgs) Handles ProgettazioneButtonR.Click
        progetto_func()
    End Sub

    Private Sub FastColoredTextBox1_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles FastColoredTextBox1.TextChanged
        Button9.Text = (FastColoredTextBox1.Text.Length)
        Button2.Text = (FastColoredTextBox1.Lines.Count)
        buttproghtml.Text = "HTML*"
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs)
        commentofun()
    End Sub

    'Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)
    '    If Me.Text = "Senza titolo [Anteprima] - My Code Editor" And WebBrowser1.DocumentTitle <> "" Then
    '        Me.Text = WebBrowser1.DocumentTitle & "[Anteprima] - My Code Editor"
    '    End If
    'End Sub

    Private Sub CSSFTB_Load(sender As Object, e As EventArgs) Handles CSSFTB.Load

    End Sub

    Private Sub CSSFTB_MouseEnter(sender As Object, e As EventArgs) Handles CSSFTB.MouseEnter
        chiudi_tutti_menu()

        'If buttprogcss.BackColor = Color.Red Then
        '    CSSFTB.Select()
        'Else
        '    FastColoredTextBox1.Select()
        'End If
    End Sub

    Private Sub CSSFTB_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles CSSFTB.PreviewKeyDown
        'If e.KeyCode = Keys.Enter And e.Shift = True Then
        '    DagliAppunti.Paste()
        '    DaIncollare.Text = ";"
        '    DaIncollare.SelectAll()
        '    DaIncollare.Copy()
        '    CSSFTB.Paste()
        '    DaIncollare.Text = ""
        '    DagliAppunti.SelectAll()
        '    DagliAppunti.Copy()
        'End If
        If e.KeyCode = Keys.Tab Then
            DagliAppunti.Paste()
            DaIncollare.Text = vbTab
            DaIncollare.SelectAll()
            DaIncollare.Copy()
            CSSFTB.Paste()
            DaIncollare.Text = ""
            DagliAppunti.SelectAll()
            My.Computer.Clipboard.Clear()
            DagliAppunti.Copy()
        End If
        If Impostazioni.GeneraleTxt6.Text = "SI" And e.KeyCode = Keys.D And e.Control = True And e.Shift = True Then
            CSSFTB.ClearCurrentLine()
        End If
    End Sub

    Private Sub CSSFTB_SystemColorsChanged(sender As Object, e As EventArgs) Handles CSSFTB.SystemColorsChanged

    End Sub
    Private Sub CSSFTB_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles CSSFTB.TextChanged
        Button9.Text = (CSSFTB.Text.Length)
        Button2.Text = (CSSFTB.Lines.Count)
        buttprogcss.Text = "CSS*"

        e.ChangedRange.SetFoldingMarkers("{", "}")
    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.Load

    End Sub

    Private Sub HhhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HhhToolStripMenuItem.Click
        AnteprimaWB.Visible = False
        ProgettazioneButtonR.BackColor = Color.DarkRed
        AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
        WebBrowser1.Navigate("about:blank")

        'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("<style>" & vbNewLine & CSSFTB.Text & vbNewLine & "</style>", "")
        'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("\Css.css", "\Css.mopcss")
        chiudi_tutti_menu()

        BarraDeiMenu.Enabled = True
        If Impostazioni.InterfacciaCheck0.CheckState = CheckState.Checked Then
            BarraInferiore.Visible = True
        End If
        BarraDeiMenuWebBrowser.Visible = False
    End Sub

    Private Sub BarraDeiMenu_Paint(sender As Object, e As PaintEventArgs) Handles BarraDeiMenu.Paint

    End Sub

    Private Sub FileButton_MouseEnter(sender As Object, e As EventArgs) Handles FileButton.MouseEnter
        If modifica_menu Or visualizza_menu Or inserisci_menu Or mce_menu Then
            FileButton.BackColor = Color.WhiteSmoke
            FileButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            FileButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            FileButton.ForeColor = Color.DarkRed
            file_mostra_menu()

            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanelMenu.Close()
            modifica_menu = False
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanelMenu.Close()
            visualizza_menu = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanelMenu.Close()
            inserisci_menu = False
            MCEButton.BackColor = Color.DarkRed
            MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
            MCEButton.ForeColor = Color.WhiteSmoke
            MCEPanelMenu.Close()
            mce_menu = False
        End If
    End Sub

    Private Sub ModificaButton_MouseEnter(sender As Object, e As EventArgs) Handles ModificaButton.MouseEnter
        If file_menu Or visualizza_menu Or inserisci_menu Or mce_menu Then
            ModificaButton.BackColor = Color.WhiteSmoke
            ModificaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            ModificaButton.ForeColor = Color.DarkRed
            modifica_mostra_menu()

            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanelMenu.Close()
            file_menu = False
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanelMenu.Close()
            visualizza_menu = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanelMenu.Close()
            inserisci_menu = False
            MCEButton.BackColor = Color.DarkRed
            MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
            MCEButton.ForeColor = Color.WhiteSmoke
            MCEPanelMenu.Close()
            mce_menu = False
        End If
    End Sub

    Private Sub VisualizzaButton_MouseEnter(sender As Object, e As EventArgs) Handles VisualizzaButton.MouseEnter
        If file_menu Or modifica_menu Or inserisci_menu Or mce_menu Then
            VisualizzaButton.BackColor = Color.WhiteSmoke
            VisualizzaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            VisualizzaButton.ForeColor = Color.DarkRed
            visualizza_mostra_menu()

            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanelMenu.Close()
            file_menu = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanelMenu.Close()
            modifica_menu = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanelMenu.Close()
            inserisci_menu = False
            MCEButton.BackColor = Color.DarkRed
            MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
            MCEButton.ForeColor = Color.WhiteSmoke
            MCEPanelMenu.Close()
            mce_menu = False
        End If
    End Sub

    Private Sub InserisciButton_MouseEnter(sender As Object, e As EventArgs) Handles InserisciButton.MouseEnter
        If file_menu Or modifica_menu Or visualizza_menu Or mce_menu Then
            InserisciButton.BackColor = Color.WhiteSmoke
            InserisciButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            InserisciButton.ForeColor = Color.DarkRed
            inserisci_mostra_menu()

            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanelMenu.Close()
            file_menu = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanelMenu.Close()
            modifica_menu = False
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanelMenu.Close()
            visualizza_menu = False
            MCEButton.BackColor = Color.DarkRed
            MCEButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
            MCEButton.ForeColor = Color.WhiteSmoke
            MCEPanelMenu.Close()
            mce_menu = False
        End If
    End Sub

    Private Sub MinionOneButton_MouseEnter(sender As Object, e As EventArgs) Handles MCEButton.MouseEnter
        If file_menu Or modifica_menu Or visualizza_menu Or inserisci_menu Then
            MCEButton.BackColor = Color.WhiteSmoke
            MCEButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            MCEButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            MCEButton.ForeColor = Color.DarkRed
            mce_mostra_menu()

            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanelMenu.Close()
            file_menu = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanelMenu.Close()
            modifica_menu = False
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanelMenu.Close()
            visualizza_menu = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttproghtml.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanelMenu.Close()
            inserisci_menu = False
        End If
    End Sub

    Private Sub BarraDiStato_MouseEnter(sender As Object, e As EventArgs) Handles BarraInferiore.MouseEnter
        chiudi_tutti_menu()

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub BarraDiStato_Paint(sender As Object, e As PaintEventArgs) Handles BarraInferiore.Paint

    End Sub

    Private Sub VediLanteprimaDelProgettoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VediLanteprimaDelProgettoToolStripMenuItem.Click
        If Impostazioni.AvanzateTxt0.Text = ("WBI") Then
            AnteprimaWB.Visible = True
            ProgettazioneButtonR.BackColor = Color.FromArgb(140, 140, 140)
            AnteprimaButtonR.BackColor = Color.DarkRed

            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("/*è/", "&#200;")
            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("/*é/", "&#201;")
            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace(".-.è", "&#232;")
            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace(".-.é", "&#234;")

            'If buttprogcss.Visible = True Then
            'FastColoredTextBox1.Text = "<style>" & vbNewLine & CSSFTB.Text & vbNewLine & "</style>" & FastColoredTextBox1.Text
            'Else
            'End If
            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("\Css.mopcss", "\Css.css")
            'Try
            '    If buttprogling.Text = (TraduzioneLinguaTxt.Lines(10)) Then
            '        System.Diagnostics.Process.Start("file:\\" & "\" & (My.Application.Info.DirectoryPath) & "\FIle.html")
            '    End If
            'Catch
            '    MessaggioF.Text = ("Errore non gestito.")
            '    MessaggioF.Button1.Text = "Non è stato possibile aprire l'anteprima nel web browser predefito per un errore non riconosciuto e non gestito."
            'End Try

            If buttprogcss.Visible = True Then
                If PercorsoFileButton.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(PercorsoFileButton.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            Else
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            chiudi_tutti_menu()

            'BarraDeiMenu.Enabled = False
            BarraInferiore.Visible = False
            WebBrowser1.DocumentText = (FastColoredTextBox1.Text)
            BarraDeiMenuWebBrowser.Visible = True
        ElseIf Impostazioni.AvanzateTxt0.Text = ("WBP") Then
            If buttprogcss.Visible = True Then
                If PercorsoFileButton.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(PercorsoFileButton.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            Else
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            If My.Settings.aschermointero = ("si") Then
                If finestrastato = "mass" Then
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    Me.WindowState = FormWindowState.Maximized
                Else
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    Me.WindowState = FormWindowState.Normal
                End If
                My.Settings.aschermointero = "no"
            End If

            Process.Start("file:\\\" & PercorsoFileButton.Text.Replace(".css", ".html"))
        Else
            If buttprogcss.Visible = True Then
                If PercorsoFileButton.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(PercorsoFileButton.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            Else
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            If My.Settings.aschermointero = ("si") Then
                If finestrastato = "mass" Then
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    Me.WindowState = FormWindowState.Maximized
                Else
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    Me.WindowState = FormWindowState.Normal
                End If
                My.Settings.aschermointero = "no"
            End If

            Process.Start(Impostazioni.AvanzateTxt0.Text, "file:\\\" & PercorsoFileButton.Text.Replace(" ", "%20"))
        End If
    End Sub

    Private Sub VediLanteprimaDelProgettoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VediLanteprimaDelProgettoToolStripMenuItem1.Click
        If Impostazioni.AvanzateTxt0.Text = ("WBI") Then
            AnteprimaWB.Visible = True
            ProgettazioneButtonR.BackColor = Color.FromArgb(140, 140, 140)
            AnteprimaButtonR.BackColor = Color.DarkRed

            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("/*è/", "&#200;")
            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("/*é/", "&#201;")
            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace(".-.è", "&#232;")
            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace(".-.é", "&#234;")

            'If buttprogcss.Visible = True Then
            'FastColoredTextBox1.Text = "<style>" & vbNewLine & CSSFTB.Text & vbNewLine & "</style>" & FastColoredTextBox1.Text
            'Else
            'End If
            'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("\Css.mopcss", "\Css.css")
            'Try
            '    If buttprogling.Text = (TraduzioneLinguaTxt.Lines(10)) Then
            '        System.Diagnostics.Process.Start("file:\\" & "\" & (My.Application.Info.DirectoryPath) & "\FIle.html")
            '    End If
            'Catch
            '    MessaggioF.Text = ("Errore non gestito.")
            '    MessaggioF.Button1.Text = "Non è stato possibile aprire l'anteprima nel web browser predefito per un errore non riconosciuto e non gestito."
            'End Try

            If buttprogcss.Visible = True Then
                If PercorsoFileButton.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(PercorsoFileButton.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            Else
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            chiudi_tutti_menu()

            'BarraDeiMenu.Enabled = False
            BarraInferiore.Visible = False
            WebBrowser1.DocumentText = (FastColoredTextBox1.Text)
            BarraDeiMenuWebBrowser.Visible = True
        ElseIf Impostazioni.AvanzateTxt0.Text = ("WBP") Then
            If buttprogcss.Visible = True Then
                If PercorsoFileButton.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(PercorsoFileButton.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            Else
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            If My.Settings.aschermointero = ("si") Then
                If finestrastato = "mass" Then
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    Me.WindowState = FormWindowState.Maximized
                Else
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    Me.WindowState = FormWindowState.Normal
                End If
                My.Settings.aschermointero = "no"
            End If

            Process.Start("file:\\\" & PercorsoFileButton.Text.Replace(".css", ".html"))
        Else
            If buttprogcss.Visible = True Then
                If PercorsoFileButton.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(PercorsoFileButton.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            Else
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            If My.Settings.aschermointero = ("si") Then
                If finestrastato = "mass" Then
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    Me.WindowState = FormWindowState.Maximized
                Else
                    Me.WindowState = FormWindowState.Normal
                    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    Me.WindowState = FormWindowState.Normal
                End If
                My.Settings.aschermointero = "no"
            End If

            Process.Start(Impostazioni.AvanzateTxt0.Text, "file:\\\" & PercorsoFileButton.Text.Replace(" ", "%20"))
        End If
    End Sub

    Private Sub PercorsoFileButton_Click(sender As Object, e As EventArgs) Handles PercorsoFileButton.Click
        FolderBrowserDialog1.SelectedPath = percorsoSALVATAGGIO.Text
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            PercorsoVecchioSalvataggio.Text = percorsoSALVATAGGIO.Text
            percorsoSALVATAGGIO.Text = FolderBrowserDialog1.SelectedPath & "\"
            PercorsoFileHTML = PercorsoFileHTML.Replace(PercorsoVecchioSalvataggio.Text, percorsoSALVATAGGIO.Text)
            PercorsoFileCSS = PercorsoFileCSS.Replace(PercorsoVecchioSalvataggio.Text, percorsoSALVATAGGIO.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", PercorsoFileHTML)

            salvatutto_func()

            FolderBrowserDialog1.SelectedPath = percorsoSALVATAGGIO.Text
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            verifica_percorso()
        End If
    End Sub

    Private Sub FastColoredTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles FastColoredTextBox1.SelectionChanged

    End Sub

    Private Sub buttprogling_MouseEnter(sender As Object, e As EventArgs) Handles buttproghtml.MouseEnter
        chiudi_tutti_menu()
    End Sub

    Private Sub buttprogcss_MouseEnter(sender As Object, e As EventArgs) Handles buttprogcss.MouseEnter
        chiudi_tutti_menu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    End Sub

    Private Sub EsciToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub EsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EsciToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EsciToolStripMenuItem2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If AnteprimaButtonR.BackColor = Color.DarkRed Then
            WebBrowser1.GoBack()
        ElseIf buttprogcss.BackColor = Color.Red Then
            CSSFTB.Undo()
            CSSFTB.Select()
        ElseIf buttproghtml.BackColor = Color.Red Then
            FastColoredTextBox1.Undo()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If AnteprimaButtonR.BackColor = Color.DarkRed Then
            WebBrowser1.GoForward()
        ElseIf buttprogcss.BackColor = Color.Red Then
            CSSFTB.Redo()
            CSSFTB.Select()
        ElseIf buttproghtml.BackColor = Color.Red Then
            FastColoredTextBox1.Redo()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Cut()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Cut()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Copy()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Copy()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Paste()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Paste()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.ClearSelected()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.ClearSelected()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub SalvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvaToolStripMenuItem.Click
        Try
            If buttprogcss.BackColor = Color.Red And buttprogcss.Visible = True Then
                If PercorsoFileButton.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, CSSFTB.Text)
                End If
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
                UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Else
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            End If
            Button5.Text = (Now.Hour & ":" & Now.Minute)
        Catch ex As Exception
            MessaggioF.Text = ("Errore: Salvataggio non riuscito")
            MessaggioF.Button1.Text = ("Non è stato trovato il percorso file selezionato per il salvataggio del progetto. Verificare che sia esistente, quindi modificarlo se non lo è." & vbNewLine & "Codice errore: MCEEAA0008")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0008")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Try
            If buttprogcss.BackColor = Color.Red And buttprogcss.Visible = True Then
                If PercorsoFileButton.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, CSSFTB.Text)
                End If
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
                UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Else
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            End If
            Button5.Text = (Now.Hour & ":" & Now.Minute)
        Catch ex As Exception
            MessaggioF.Text = ("Errore: Salvataggio non riuscito")
            MessaggioF.Button1.Text = ("Non è stato trovato il percorso file selezionato per il salvataggio del progetto. Verificare che sia esistente, quindi modificarlo se non lo è." & vbNewLine & "Codice errore: MCEEAA0008")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0008")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
    End Sub

    Private Sub CarattteriSpecialiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaratteriSpecialiToolStripMenuItem.Click
        caratterispecialifun()
    End Sub

    Private Sub ParagrafoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParagrafoToolStripMenuItem.Click
        bottonefun()
    End Sub

    Private Sub CollegamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CollegamentoToolStripMenuItem1.Click
        collegamentofun()
    End Sub

    Private Sub ImmagineToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImmagineToolStripMenuItem1.Click
        commentofun()
    End Sub

    Private Sub TestoPersonalizzatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestoPersonalizzatoToolStripMenuItem.Click
        contenitorefun()
    End Sub

    Private Sub CommentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CommentoToolStripMenuItem1.Click
        descrizionefun()
    End Sub

    Private Sub SeparatoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeparatoreToolStripMenuItem.Click
        elencofun()
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        immaginefun()
    End Sub

    Private Sub TitoloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitoloToolStripMenuItem.Click
        paragrafofun()
    End Sub

    Private Sub SottotitoloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SottotitoloToolStripMenuItem.Click
        separatorefun()
    End Sub

    Private Sub DescrizioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescrizioneToolStripMenuItem.Click
        sottotitolofun()
    End Sub

    Private Sub BottoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottoneToolStripMenuItem.Click
        tabellafun()
    End Sub

    Private Sub CaratteriSpecialiToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CaratteriSpecialiToolStripMenuItem2.Click
        testopersonalizzatofun()
    End Sub

    Private Sub TitoloToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TitoloToolStripMenuItem1.Click
        titolofun()
    End Sub

    Private Sub FastColoredTextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles FastColoredTextBox1.PreviewKeyDown
        If Impostazioni.GeneraleTxt4.Text = "SI" And e.KeyCode = Keys.Enter And e.Shift = True Then
            DagliAppunti.Paste()
            DaIncollare.Text = vbNewLine & "<br/>"
            DaIncollare.SelectAll()
            DaIncollare.Copy()
            FastColoredTextBox1.Paste()
            DaIncollare.Text = ""
            DagliAppunti.SelectAll()
            My.Computer.Clipboard.Clear()
            DagliAppunti.Copy()
        End If
        If Impostazioni.GeneraleTxt5.Text = "SI" And e.KeyCode = Keys.Enter And e.Control = True Then
            DagliAppunti.Paste()
            DaIncollare.Text = vbNewLine & "<hr/>" & vbNewLine
            DaIncollare.SelectAll()
            DaIncollare.Copy()
            FastColoredTextBox1.Paste()
            DaIncollare.Text = ""
            DagliAppunti.SelectAll()
            My.Computer.Clipboard.Clear()
            DagliAppunti.Copy()
        End If
        If Impostazioni.GeneraleTxt6.Text = "SI" And e.KeyCode = Keys.D And e.Control = True And e.Shift = True Then
            FastColoredTextBox1.ClearCurrentLine()
        End If
        If e.KeyCode = Keys.Tab Then
            DagliAppunti.Paste()
            DaIncollare.Text = vbTab
            DaIncollare.SelectAll()
            DaIncollare.Copy()
            FastColoredTextBox1.Paste()
            DaIncollare.Text = ""
            DagliAppunti.SelectAll()
            My.Computer.Clipboard.Clear()
            DagliAppunti.Copy()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If buttprogcss.Text = ("CSS*") Or buttproghtml.Text = ("HTML*") Then
            EsciMessaggio.Text = ("Vuoi salvare il progetto prima di aprirne uno nuovo?")
            EsciMessaggio.Button1.Text = ("Il progetto attuale non è stato salvato. Vuoi farlo prima di aprirne uno nuovo?" & vbNewLine & "NOTA: Non sarà possibile recuperare il progetto se non lo si salva.")
            EsciMessaggio.Tipo.Text = ("Apri")
            EsciMessaggio.ShowDialog()
            If ApriNuovoProgNonSalv.Text = ("Apri") Then
                If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim testo As String
                    testo = OpenFileDialog1.FileName
                    FastColoredTextBox1.Clear()
                    FastColoredTextBox1.Text = (My.Computer.FileSystem.ReadAllText(testo))
                    Me.Text = (My.Computer.FileSystem.GetName(testo) & " - My Code Editor")
                    Me.Text = Me.Text.Replace(".html", "")
                    PercorsoFileButton.Text = (OpenFileDialog1.FileName)
                    buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                    buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                    SaveFileDialog1.FileName = (testo)
                    If Dir(PercorsoFileButton.Text.Replace(".html", ".css")) <> "" Then
                        buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                        buttproghtml.Enabled = True
                        buttprogcss.Visible = True
                        CSSSIoNOtb.Text = ("si")
                        ProgettazioneButtonR.Enabled = True
                        AnteprimaButtonR.Enabled = True
                        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                        FastColoredTextBox1.Select()
                        CSSFTB.Text = (System.IO.File.ReadAllText(PercorsoFileButton.Text.Replace(".html", ".css")))
                        buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                    Else
                        buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                        buttproghtml.Enabled = True
                        buttprogcss.Visible = False
                        CSSSIoNOtb.Text = ("no")
                        ProgettazioneButtonR.Enabled = True
                        AnteprimaButtonR.Enabled = True
                        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                        FastColoredTextBox1.Select()
                    End If
                    FastColoredTextBox1.Select()
                    FileButton.Enabled = True
                    ModificaButton.Enabled = True
                    VisualizzaButton.Enabled = True
                    InserisciButton.Enabled = True
                    InserisciToolStripMenuItem1.Enabled = True
                    MCEButton.Enabled = True
                    Avvio.Show()
                    Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
                    Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
                    Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
                    Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code EditorTemp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
                    Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
                    Me.TitoloProg.Text = (Me.Text.Replace(" - My Code Editor", ""))
                    Avvio.recente1butt.Text = (TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", PercorsoFileButton.Text)
                    Avvio.Close()
                    ultimoProgettoSalvato.Text = (FastColoredTextBox1.Text)
                End If
                FastColoredTextBox1.Select()
            End If
        Else
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim testo As String
                testo = OpenFileDialog1.FileName
                FastColoredTextBox1.Text = (My.Computer.FileSystem.ReadAllText(testo))
                Me.Text = (My.Computer.FileSystem.GetName(testo) & " - My Code Editor")
                Me.Text = Me.Text.Replace(".html", "")
                PercorsoFileButton.Text = (OpenFileDialog1.FileName)
                buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                SaveFileDialog1.FileName = (testo)
                If Dir(PercorsoFileButton.Text.Replace(".html", ".css")) <> "" Then
                    buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                    buttproghtml.Enabled = True
                    buttprogcss.Visible = True
                    CSSSIoNOtb.Text = ("si")
                    ProgettazioneButtonR.Enabled = True
                    AnteprimaButtonR.Enabled = True
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                    FastColoredTextBox1.Select()
                    CSSFTB.Text = (System.IO.File.ReadAllText(PercorsoFileButton.Text.Replace(".html", ".css")))
                    buttprogcss.Text = (TraduzioneLinguaTxt.Lines(11))
                Else
                    buttproghtml.Text = (TraduzioneLinguaTxt.Lines(10))
                    buttproghtml.Enabled = True
                    buttprogcss.Visible = False
                    CSSSIoNOtb.Text = ("no")
                    ProgettazioneButtonR.Enabled = True
                    AnteprimaButtonR.Enabled = True
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                    FastColoredTextBox1.Select()
                End If
                FastColoredTextBox1.Select()
                FileButton.Enabled = True
                ModificaButton.Enabled = True
                VisualizzaButton.Enabled = True
                InserisciButton.Enabled = True
                InserisciToolStripMenuItem1.Enabled = True
                MCEButton.Enabled = True
                Avvio.Show()
                Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", Avvio.recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
                Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", Avvio.recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
                Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", Avvio.recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
                Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", Avvio.recente2butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
                Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", Avvio.recente1butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
                Me.TitoloProg.Text = (Me.Text.Replace(" - My Code Editor", ""))
                Avvio.recente1butt.Text = (TitoloProg.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", TitoloProg.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", PercorsoFileButton.Text)
                Avvio.Close()
                ultimoProgettoSalvato.Text = (FastColoredTextBox1.Text)
            End If
            FastColoredTextBox1.Select()
            FastColoredTextBox1.ClearUndo()
        End If
    End Sub

    Private Sub AnnullaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnnullaToolStripMenuItem1.Click
        If AnteprimaButtonR.BackColor = Color.DarkRed Then
            WebBrowser1.GoBack()
        ElseIf buttprogcss.BackColor = Color.Red Then
            CSSFTB.Undo()
            CSSFTB.Select()
        ElseIf buttproghtml.BackColor = Color.Red Then
            FastColoredTextBox1.Undo()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub RipetiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RipetiToolStripMenuItem1.Click
        If AnteprimaButtonR.BackColor = Color.DarkRed Then
            WebBrowser1.GoForward()
        ElseIf buttprogcss.BackColor = Color.Red Then
            CSSFTB.Redo()
            CSSFTB.Select()
        ElseIf buttproghtml.BackColor = Color.Red Then
            FastColoredTextBox1.Redo()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub TagliaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TagliaToolStripMenuItem1.Click
        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Cut()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Cut()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub CopiaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopiaToolStripMenuItem1.Click
        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Copy()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Copy()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub IncollaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem1.Click
        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Paste()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Paste()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub EliminaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminaToolStripMenuItem1.Click
        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.ClearSelected()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.ClearSelected()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub ToolStripMenuItem10_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        raggrupparighe_func()
    End Sub

    Private Sub BarraLaterale_Paint(sender As Object, e As PaintEventArgs) Handles BarraLaterale.Paint

    End Sub

    Private Sub HTMLTimerAutoSave_Tick(sender As Object, e As EventArgs) Handles HTMLTimerAutoSave.Tick
        If PercorsoFileButton.Text.Contains(".html") Then
            System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
        End If
        buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
        UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
        If buttproghtml.BackColor = Color.Red Then
            Button5.Text = (Now.Hour & ":" & Now.Minute)
        End If
    End Sub

    Private Sub CSSTimerAutoSave_Tick(sender As Object, e As EventArgs) Handles CSSTimerAutoSave.Tick
        If buttprogcss.Visible = True Then
            If PercorsoFileButton.Text.Contains(".css") Then
                System.IO.File.WriteAllText(PercorsoFileButton.Text, CSSFTB.Text)
            End If
            buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            If buttprogcss.BackColor = Color.Red Then
                Button5.Text = (Now.Hour & ":" & Now.Minute)
            End If
        End If
    End Sub

    Private Sub ContextMenuFile_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuFile.Opening

    End Sub

    Private Sub GrassettoBarraStrumenti_Click(sender As Object, e As EventArgs) Handles GrassettoBarraStrumenti.Click
        'grassetto -> barra strumenti
        SelezionatoSalvatoDagliAppunti.Text = "<b>"
        SelezionatoSalvatoDagliAppunti.Text &= FastColoredTextBox1.SelectedText
        SelezionatoSalvatoDagliAppunti.Text &= "</b>"
        DaIncollare.Text = SelezionatoSalvatoDagliAppunti.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        SelezionatoSalvatoDagliAppunti.SelectAll()
        SelezionatoSalvatoDagliAppunti.Clear()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub CorsivoBarraStrumenti_Click(sender As Object, e As EventArgs) Handles CorsivoBarraStrumenti.Click
        'corsivo -> barra strumenti
        SelezionatoSalvatoDagliAppunti.Text = "<i>"
        SelezionatoSalvatoDagliAppunti.Text &= FastColoredTextBox1.SelectedText
        SelezionatoSalvatoDagliAppunti.Text &= "</i>"
        DaIncollare.Text = SelezionatoSalvatoDagliAppunti.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        SelezionatoSalvatoDagliAppunti.SelectAll()
        SelezionatoSalvatoDagliAppunti.Clear()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles SottolineatoBarraStrumenti.Click
        'sottolineato -> barra strumenti
        SelezionatoSalvatoDagliAppunti.Text = "<u>"
        SelezionatoSalvatoDagliAppunti.Text &= FastColoredTextBox1.SelectedText
        SelezionatoSalvatoDagliAppunti.Text &= "</u>"
        DaIncollare.Text = SelezionatoSalvatoDagliAppunti.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        SelezionatoSalvatoDagliAppunti.SelectAll()
        SelezionatoSalvatoDagliAppunti.Clear()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles BarratoBarraStrumenti.Click
        'barratore -> barra strumenti
        SelezionatoSalvatoDagliAppunti.Text = "<s>"
        SelezionatoSalvatoDagliAppunti.Text &= FastColoredTextBox1.SelectedText
        SelezionatoSalvatoDagliAppunti.Text &= "</s>"
        DaIncollare.Text = SelezionatoSalvatoDagliAppunti.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        SelezionatoSalvatoDagliAppunti.SelectAll()
        SelezionatoSalvatoDagliAppunti.Clear()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles ACapoBarraStrumenti.Click
        'a capo -> barra strumenti
        DagliAppunti.Paste()
        DaIncollare.Text = vbNewLine & "<br/>" & vbNewLine
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles SeparatoreBarraStrumenti.Click
        'separatore -> barra strumenti
        DagliAppunti.Paste()
        DaIncollare.Text = vbNewLine & "<hr/>" & vbNewLine
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        DagliAppunti.Copy()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub FTPButton_Click(sender As Object, e As EventArgs) Handles FTPButton.Click
        If Not FTPPanel.Visible = True Then
            AnteprimaWB.Visible = False
            FastColoredTextBoxPanel.Visible = False
            FTPPanel.Visible = True
            WebBrowser1.Select()
            ProgettazioneButtonR.BackColor = Color.FromArgb(140, 140, 140)
            AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
            FTPButton.BackColor = Color.DarkRed

            BarraDeiMenu.Visible = False
            BarraDeiMenuWebBrowser.Visible = False

            If buttprogcss.Visible = True Then
                If buttprogcss.BackColor = Color.Red Then
                    System.IO.File.WriteAllText(PercorsoFileCSS, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(PercorsoFileHTML, CSSFTB.Text)
                End If
                If buttproghtml.BackColor = Color.Red Then
                    System.IO.File.WriteAllText(PercorsoFileHTML, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
                buttprogcss.Text = TraduzioneLinguaTxt.Lines(11)
            Else
                If PercorsoFileButton.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(PercorsoFileButton.Text, FastColoredTextBox1.Text)
                End If
                buttproghtml.Text = TraduzioneLinguaTxt.Lines(10)
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            chiudi_tutti_menu()

            BarraDeiMenu.Enabled = False
            BarraInferiore.Visible = False
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        If TextBox14.Text = "" Then
            TextBox14.Text = ("0")
        End If
        TextBox14.Text += 1
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        If TextBox14.Text = "" Then
            TextBox14.Text = ("1")
        End If
        If Not TextBox14.Text = "" And Not TextBox14.Text.Replace(" ", "") = "" And Not TextBox14.Text = "1" Then
            TextBox14.Text -= 1
        End If
    End Sub

    Private Sub ConnettiDisconnettiButton_Click(sender As Object, e As EventArgs) Handles ConnettiDisconnettiButton.Click
        Try
            If Not TextBox12.Text.Replace(" ", "") = "" And Not TextBox13.Text.Replace(" ", "") = "" And Not TextBox15.Text.Replace(" ", "") = "" Then
                My.Computer.Network.UploadFile(PercorsoFileButton.Text.Replace(".css", ".html"), "ftp://" & TextBox12.Text & "/" & Me.Text.Replace(" - My Code Editor", "") & ".html", TextBox13.Text, TextBox15.Text)
                If CSSSIoNOtb.Text = "si" Then My.Computer.Network.UploadFile(PercorsoFileButton.Text.Replace(".html", ".css"), "ftp://" & TextBox12.Text & "/" & Me.Text.Replace(" - My Code Editor", "") & ".css", TextBox13.Text, TextBox15.Text)
                MessaggioF.Text = "File caricato correttamente"
                MessaggioF.Button1.Text = "Il file " & Me.Text.Replace(" - My Code Editor", "") & " è stato caricato sul server correttamente."
                MessaggioF.DettagliErroreButton.Visible = False
                MessaggioF.ShowDialog()
            Else
                MessaggioF.Text = "Errore: Completare tutti i campi"
                MessaggioF.Button1.Text = "Completare tutti i campi prima di poter effettuare l'accesso e il caricamento del file sul server."
                MessaggioF.DettagliErroreButton.Visible = False
                MessaggioF.ShowDialog()
            End If
        Catch ex As Exception
            MessaggioF.Text = "Errore: Non gestito"
            MessaggioF.Button1.Text = "Si è verificato un errore improvviso non gestito" & vbNewLine & ex.Message
            MessaggioF.DettagliErroreButton.Visible = False
            MessaggioF.ShowDialog()
        End Try
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click

    End Sub

    Private Sub Button61_MouseUp(sender As Object, e As MouseEventArgs) Handles Button61.MouseUp
        TextBox15.PasswordChar = "•"
        TextBox15.Select()
    End Sub

    Private Sub Button61_MouseDown(sender As Object, e As MouseEventArgs) Handles Button61.MouseDown
        TextBox15.PasswordChar = ""
        TextBox15.Select()
    End Sub

    Private Sub TextBox14_LostFocus(sender As Object, e As EventArgs) Handles TextBox14.LostFocus
        If TextBox14.Text.Replace(" ", "") = "" Then
            TextBox14.Text = "1"
        End If
    End Sub

    Private Sub WebBrowser1_Load(sender As Object, e As EventArgs) Handles WebBrowser1.Load

    End Sub

    Private Sub ProgettazioneButtonR_MouseEnter(sender As Object, e As EventArgs) Handles ProgettazioneButtonR.MouseEnter

    End Sub

    Private Sub MyCEF_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Select Case Me.WindowState
            Case FormWindowState.Maximized
                'massimizzata
                InformazioniF.WindowState = FormWindowState.Normal
                ControlloAggiornamenti.WindowState = FormWindowState.Normal
            Case FormWindowState.Normal
                'ridotta a normale
                InformazioniF.WindowState = FormWindowState.Normal
                ControlloAggiornamenti.WindowState = FormWindowState.Normal
            Case Else
                'ridotta a icona
                InformazioniF.WindowState = FormWindowState.Minimized
                ControlloAggiornamenti.WindowState = FormWindowState.Minimized
        End Select
    End Sub

    Private Sub MyCEF_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        If file_menu Or modifica_menu Or visualizza_menu Or inserisci_menu Or mce_menu Then
            chiudi_tutti_menu()
        End If
    End Sub

    Private Sub MyCEF_Move(sender As Object, e As EventArgs) Handles Me.Move
        If file_menu Or modifica_menu Or visualizza_menu Or inserisci_menu Or mce_menu Then
            chiudi_tutti_menu()
        End If
    End Sub

    Private Sub FastColoredTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles FastColoredTextBox1.MouseClick

    End Sub

    Public Shared ReadOnly Property MousePosition As Point
    Private Sub FastColoredTextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles FastColoredTextBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            'pulsante destro
            contex_menu_1 = True
            ContexMenu1.Close()
            Dim pos As New Point(Cursor.Position.X, Cursor.Position.Y)
            If pos.X + ContexMenu2.Size.Width >= screenWidth Then
                pos.X -= ContexMenu2.Size.Width
            End If
            If pos.Y + ContexMenu2.Size.Height >= screenHeight Then
                pos.Y -= ContexMenu2.Size.Height
            End If

            'ContexMenu1.Annulla.Text = TraduzioneLinguaTxt.Lines(103)
            'ContexMenu1.Ripeti.Text = TraduzioneLinguaTxt.Lines(104)
            ContexMenu1.Taglia.Text = TraduzioneLinguaTxt.Lines(105)
            'ContexMenu1.Copia.Text = TraduzioneLinguaTxt.Lines(106)
            'ContexMenu1.Incolla.Text = TraduzioneLinguaTxt.Lines(107)
            'ContexMenu1.Elimina.Text = TraduzioneLinguaTxt.Lines(108)
            ContexMenu1.RaggruppaRighe.Text = TraduzioneLinguaTxt.Lines(109)
            ContexMenu1.VisualizzaAnteprima.Text = TraduzioneLinguaTxt.Lines(110)
            'ContexMenu1.Salva.Text = TraduzioneLinguaTxt.Lines(111)
            ContexMenu1.Apri.Text = TraduzioneLinguaTxt.Lines(112)
            ContexMenu1.Inserisci.Text = TraduzioneLinguaTxt.Lines(113)
            'ParagrafoToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(114)
            'CollegamentoToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(115)
            'ImmagineToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(116)
            'TestoPersonalizzatoToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(117)
            'CommentoToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(118)
            'SeparatoreToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(119)
            'ListaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(120)
            'TitoloToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(121)
            'SottotitoloToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(122)
            'DescrizioneToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(123)
            'BottoneToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(124)
            'CaratteriSpecialiToolStripMenuItem2.Text = TraduzioneLinguaTxt.Lines(125)
            'TitoloToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(126)
            'CaratteriSpecialiToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(127)

            'EsciToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(128)
            ContexMenu1.SalvaTutto.Text = TraduzioneLinguaTxt.Lines(21)
            ContexMenu1.CercaNelWeb.Text = TraduzioneLinguaTxt.Lines(780)

            If FastColoredTextBox1.SelectedText <> "" Then
                ContexMenu1.CercaNelWeb.Enabled = True
            Else
                ContexMenu1.CercaNelWeb.Enabled = False
            End If

            If buttproghtml.Visible Then
                ContexMenu1.VisualizzaAnteprima.Enabled = True
            Else
                ContexMenu1.VisualizzaAnteprima.Enabled = False
            End If

            If InserisciButton.Enabled Then
                ContexMenu1.Inserisci.Enabled = True
            Else
                ContexMenu1.Inserisci.Enabled = False
            End If

            ContexMenu1.Location = pos
            ContexMenu1.Show()
        ElseIf e.Button = Windows.Forms.MouseButtons.Middle Then
            'pulsante centrale
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            'pulsante sinistro
        End If
    End Sub

    Private Sub TornaAProgettoButton_Click(sender As Object, e As EventArgs) Handles TornaAProgettoButton.Click
        progetto_func()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Annulla.Click
        annulla_func()
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Ripeti.Click
        ripeti_func()
    End Sub

    Private Sub NuovoBarraStrumenti_Click(sender As Object, e As EventArgs) Handles NuovoBarraStrumenti.Click
        nuovo_func()
    End Sub

    Private Sub ApriBarraStrumenti_Click(sender As Object, e As EventArgs) Handles ApriBarraStrumenti.Click
        apri_func()
    End Sub

    Private Sub SalvaBarraStrumenti_Click(sender As Object, e As EventArgs) Handles SalvaBarraStrumenti.Click
        salva_func()
    End Sub

    Private Sub SalvaTuttoBarraStrumenti_Click(sender As Object, e As EventArgs) Handles SalvaTuttoBarraStrumenti.Click
        salvatutto_func()
    End Sub

    Private Sub CopiaBarraStrumenti_Click(sender As Object, e As EventArgs) Handles CopiaBarraStrumenti.Click
        copia_func()
    End Sub

    Private Sub IncollaBarraStrumenti_Click(sender As Object, e As EventArgs)
        incolla_func()
    End Sub

    Private Sub EliminaBarraStrumenti_Click(sender As Object, e As EventArgs)
        elimina_func()
    End Sub

    Private Sub CSSFTB_MouseDown(sender As Object, e As MouseEventArgs) Handles CSSFTB.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            'pulsante destro
            contex_menu_1 = True
            ContexMenu2.Close()
            Dim pos As New Point(Cursor.Position.X, Cursor.Position.Y)
            If pos.X + ContexMenu2.Size.Width >= screenWidth Then
                pos.X -= ContexMenu2.Size.Width
            End If
            If pos.Y + ContexMenu2.Size.Height >= screenHeight Then
                pos.Y -= ContexMenu2.Size.Height
            End If

            'ContexMenu1.Annulla.Text = TraduzioneLinguaTxt.Lines(103)
            'ContexMenu1.Ripeti.Text = TraduzioneLinguaTxt.Lines(104)
            ContexMenu2.Taglia.Text = TraduzioneLinguaTxt.Lines(105)
            'ContexMenu1.Copia.Text = TraduzioneLinguaTxt.Lines(106)
            'ContexMenu1.Incolla.Text = TraduzioneLinguaTxt.Lines(107)
            'ContexMenu1.Elimina.Text = TraduzioneLinguaTxt.Lines(108)
            ContexMenu2.RaggruppaRighe.Text = TraduzioneLinguaTxt.Lines(109)
            ContexMenu2.VisualizzaAnteprima.Text = TraduzioneLinguaTxt.Lines(110)
            'ContexMenu1.Salva.Text = TraduzioneLinguaTxt.Lines(111)
            ContexMenu2.Apri.Text = TraduzioneLinguaTxt.Lines(112)
            'ParagrafoToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(114)
            'CollegamentoToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(115)
            'ImmagineToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(116)
            'TestoPersonalizzatoToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(117)
            'CommentoToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(118)
            'SeparatoreToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(119)
            'ListaToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(120)
            'TitoloToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(121)
            'SottotitoloToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(122)
            'DescrizioneToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(123)
            'BottoneToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(124)
            'CaratteriSpecialiToolStripMenuItem2.Text = TraduzioneLinguaTxt.Lines(125)
            'TitoloToolStripMenuItem1.Text = TraduzioneLinguaTxt.Lines(126)
            'CaratteriSpecialiToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(127)

            'EsciToolStripMenuItem.Text = TraduzioneLinguaTxt.Lines(128)
            ContexMenu2.SalvaTutto.Text = TraduzioneLinguaTxt.Lines(21)
            ContexMenu2.CercaNelWeb.Text = TraduzioneLinguaTxt.Lines(780)

            If FastColoredTextBox1.SelectedText <> "" Then
                ContexMenu2.CercaNelWeb.Enabled = True
            Else
                ContexMenu2.CercaNelWeb.Enabled = False
            End If

            If buttproghtml.Visible Then
                ContexMenu2.VisualizzaAnteprima.Enabled = True
            Else
                ContexMenu2.VisualizzaAnteprima.Enabled = False
            End If

            ContexMenu2.Location = pos
            ContexMenu2.Show()
        ElseIf e.Button = Windows.Forms.MouseButtons.Middle Then
            'pulsante centrale
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            'pulsante sinistro
        End If
    End Sub
End Class