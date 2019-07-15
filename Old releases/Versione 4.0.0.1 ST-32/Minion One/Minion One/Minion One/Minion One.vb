Imports System.Drawing.Printing
Public Class MinionOneF
    Public finestrastato As String = "mass"
    Private Sub MinionOneF_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If buttprogcss.Text = ("CSS*") Or buttprogling.Text = ("HTML*") Then
            EsciMessaggio.Text = ("Vuoi salvare il progetto prima di uscire?")
            EsciMessaggio.Button1.Text = ("Il progetto attuale non è stato salvato. Vuoi farlo prima di uscire?" & vbNewLine & "NOTA: Non sarà possibile recuperare il progetto se non lo si salva.")
            EsciMessaggio.Tipo.Text = ("Esci")
            EsciMessaggio.ShowDialog()
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Form1_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Select Case Me.WindowState
            Case FormWindowState.Maximized
                'massimizzata
            Case FormWindowState.Normal
                'ridotta a normale
            Case Else
                'ridotta a icona
        End Select
    End Sub

    Public Property AutoCompleteMode As AutoCompleteMode
    Public aggiornamentoscaricaautomaticamenteavvio As Boolean = True
    Private Sub MinionOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'impostazione
        If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\") Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\")
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\")
        End If
        IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\", IO.FileAttributes.Hidden)
inizioimpostazioni:
        Try
            If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Impostazioni.moix") <> "" Then
                ImpostazioniTxt.Text = (System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Impostazioni.moix"))

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
                    End If
                    ControlloAggiornamenti.ShowDialog()
                    Impostazioni.GeneraleCheck1.Enabled = True
                    aggiornamentoscaricaautomaticamenteavvio = False
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
                    Button36.Image = My.Resources.si
                Else
                    Impostazioni.GeneraleCheck2.Checked = False
                    Impostazioni.GeneraleTxt2.Text = "NO"
                    FastColoredTextBox1.WordWrap = False
                    CSSFTB.WordWrap = False
                    Button36.Image = My.Resources.no
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
                    Impostazioni.HTML1m.BackColor = Color.DimGray
                    Impostazioni.HTML5m.BackColor = Color.DimGray
                    Impostazioni.HTML10m.BackColor = Color.DimGray
                    Impostazioni.HTML30m.BackColor = Color.DimGray
                    Impostazioni.HTML1h.BackColor = Color.DimGray
                    Impostazioni.HTML2h.BackColor = Color.DimGray
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.HTML1m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "300000" Then
                    Impostazioni.HTML1m.BackColor = Color.DimGray
                    Impostazioni.HTML5m.BackColor = Color.DimGray
                    Impostazioni.HTML10m.BackColor = Color.DimGray
                    Impostazioni.HTML30m.BackColor = Color.DimGray
                    Impostazioni.HTML1h.BackColor = Color.DimGray
                    Impostazioni.HTML2h.BackColor = Color.DimGray
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.HTML5m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "600000" Then
                    Impostazioni.HTML1m.BackColor = Color.DimGray
                    Impostazioni.HTML5m.BackColor = Color.DimGray
                    Impostazioni.HTML10m.BackColor = Color.DimGray
                    Impostazioni.HTML30m.BackColor = Color.DimGray
                    Impostazioni.HTML1h.BackColor = Color.DimGray
                    Impostazioni.HTML2h.BackColor = Color.DimGray
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.HTML10m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "1800000" Then
                    Impostazioni.HTML1m.BackColor = Color.DimGray
                    Impostazioni.HTML5m.BackColor = Color.DimGray
                    Impostazioni.HTML10m.BackColor = Color.DimGray
                    Impostazioni.HTML30m.BackColor = Color.DimGray
                    Impostazioni.HTML1h.BackColor = Color.DimGray
                    Impostazioni.HTML2h.BackColor = Color.DimGray
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.HTML30m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "3600000" Then
                    Impostazioni.HTML1m.BackColor = Color.DimGray
                    Impostazioni.HTML5m.BackColor = Color.DimGray
                    Impostazioni.HTML10m.BackColor = Color.DimGray
                    Impostazioni.HTML30m.BackColor = Color.DimGray
                    Impostazioni.HTML1h.BackColor = Color.DimGray
                    Impostazioni.HTML2h.BackColor = Color.DimGray
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.HTML1h.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtHTML.Text = "7200000" Then
                    Impostazioni.HTML1m.BackColor = Color.DimGray
                    Impostazioni.HTML5m.BackColor = Color.DimGray
                    Impostazioni.HTML10m.BackColor = Color.DimGray
                    Impostazioni.HTML30m.BackColor = Color.DimGray
                    Impostazioni.HTML1h.BackColor = Color.DimGray
                    Impostazioni.HTML2h.BackColor = Color.DimGray
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.HTML2h.BackColor = Color.DarkRed
                Else
                    Impostazioni.HTML1m.BackColor = Color.DimGray
                    Impostazioni.HTML5m.BackColor = Color.DimGray
                    Impostazioni.HTML10m.BackColor = Color.DimGray
                    Impostazioni.HTML30m.BackColor = Color.DimGray
                    Impostazioni.HTML1h.BackColor = Color.DimGray
                    Impostazioni.HTML2h.BackColor = Color.DimGray
                    Impostazioni.HTMLPersonalizzato.BackColor = Color.DimGray

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
                    Impostazioni.CSS1m.BackColor = Color.DimGray
                    Impostazioni.CSS5m.BackColor = Color.DimGray
                    Impostazioni.CSS10m.BackColor = Color.DimGray
                    Impostazioni.CSS30m.BackColor = Color.DimGray
                    Impostazioni.CSS1h.BackColor = Color.DimGray
                    Impostazioni.CSS2h.BackColor = Color.DimGray
                    Impostazioni.CSSPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.CSS1m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "300000" Then
                    Impostazioni.CSS1m.BackColor = Color.DimGray
                    Impostazioni.CSS5m.BackColor = Color.DimGray
                    Impostazioni.CSS10m.BackColor = Color.DimGray
                    Impostazioni.CSS30m.BackColor = Color.DimGray
                    Impostazioni.CSS1h.BackColor = Color.DimGray
                    Impostazioni.CSS2h.BackColor = Color.DimGray
                    Impostazioni.CSSPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.CSS5m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "600000" Then
                    Impostazioni.CSS1m.BackColor = Color.DimGray
                    Impostazioni.CSS5m.BackColor = Color.DimGray
                    Impostazioni.CSS10m.BackColor = Color.DimGray
                    Impostazioni.CSS30m.BackColor = Color.DimGray
                    Impostazioni.CSS1h.BackColor = Color.DimGray
                    Impostazioni.CSS2h.BackColor = Color.DimGray
                    Impostazioni.CSSPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.CSS10m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "1800000" Then
                    Impostazioni.CSS1m.BackColor = Color.DimGray
                    Impostazioni.CSS5m.BackColor = Color.DimGray
                    Impostazioni.CSS10m.BackColor = Color.DimGray
                    Impostazioni.CSS30m.BackColor = Color.DimGray
                    Impostazioni.CSS1h.BackColor = Color.DimGray
                    Impostazioni.CSS2h.BackColor = Color.DimGray
                    Impostazioni.CSSPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.CSS30m.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "3600000" Then
                    Impostazioni.CSS1m.BackColor = Color.DimGray
                    Impostazioni.CSS5m.BackColor = Color.DimGray
                    Impostazioni.CSS10m.BackColor = Color.DimGray
                    Impostazioni.CSS30m.BackColor = Color.DimGray
                    Impostazioni.CSS1h.BackColor = Color.DimGray
                    Impostazioni.CSS2h.BackColor = Color.DimGray
                    Impostazioni.CSSPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.CSS1h.BackColor = Color.DarkRed
                ElseIf Impostazioni.AutoSaveTxtCSS.Text = "7200000" Then
                    Impostazioni.CSS1m.BackColor = Color.DimGray
                    Impostazioni.CSS5m.BackColor = Color.DimGray
                    Impostazioni.CSS10m.BackColor = Color.DimGray
                    Impostazioni.CSS30m.BackColor = Color.DimGray
                    Impostazioni.CSS1h.BackColor = Color.DimGray
                    Impostazioni.CSS2h.BackColor = Color.DimGray
                    Impostazioni.CSSPersonalizzato.BackColor = Color.DimGray

                    Impostazioni.CSS2h.BackColor = Color.DarkRed
                Else
                    Impostazioni.CSS1m.BackColor = Color.DimGray
                    Impostazioni.CSS5m.BackColor = Color.DimGray
                    Impostazioni.CSS10m.BackColor = Color.DimGray
                    Impostazioni.CSS30m.BackColor = Color.DimGray
                    Impostazioni.CSS1h.BackColor = Color.DimGray
                    Impostazioni.CSS2h.BackColor = Color.DimGray
                    Impostazioni.CSSPersonalizzato.BackColor = Color.DimGray

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
                    Button33.Image = My.Resources.si
                    BarraInferiore.Visible = True
                Else
                    Impostazioni.InterfacciaCheck0.Checked = False
                    Impostazioni.InterfacciaTxt0.Text = "NO"
                    Button33.Image = My.Resources.no
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
                    Button35.Image = My.Resources.si

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
                    Button35.Image = My.Resources.no

                    If finestrastato = "mass" Then
                        Me.WindowState = FormWindowState.Normal
                        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                        Me.WindowState = FormWindowState.Maximized
                    Else
                        Me.WindowState = FormWindowState.Normal
                        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                        Me.WindowState = FormWindowState.Normal
                    End If
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
                        Impostazioni.AvanzateTxt0.Text = "##DAFAULT##"
                    End If
                End If
            Else
                Dim linee(21) As String
                linee(0) = "IMPOSTAZIONI - MINION ONE"
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
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Impostazioni.moix", ImpostazioniTxt.Text)
            End If
        Catch ex As Exception
            MessaggioF.Button1.Text = ("Si è verificato un errore nel caricamento delle impostazioni. Verranno ripristinate quelle predefinite perchè sono danneggiate." & vbNewLine & "Codice errore: MOE1UXW79F4")
            MessaggioF.Text = ("Errore: Impostazioni danneggiate")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE1UXW79F4")
            MessaggioF.ShowDialog()
            Dim linee(21) As String
            linee(0) = "IMPOSTAZIONI - MINION ONE"
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
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Impostazioni.moix", ImpostazioniTxt.Text)
            GoTo inizioimpostazioni
        End Try
        'fine impostazione
        FastColoredTextBox1.Select()
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        VisualizzaButton.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        MinionOneButton.Enabled = True
        Try
            Dim argomenti As String() = My.Application.CommandLineArgs.ToArray
            Dim filenonsupportato As Boolean = False
            If argomenti.Length > 0 Then
                Dim fileName As String = argomenti(0)
                FastColoredTextBox1.Text = (My.Computer.FileSystem.ReadAllText(fileName))
                Me.Text = (My.Computer.FileSystem.GetName(fileName) & " - Minion One")
                TitoloProg.Text = Me.Text
                SaveFileDialog1.FileName = (fileName)
                Button4.Text = (SaveFileDialog1.FileName)
                SaveFileDialog1.FileName = (Me.Text.Replace(" - Minion One", ""))
                Me.Text = Me.Text.Replace(".html", "")
                If (TitoloProg.Text.Contains(".html") Or TitoloProg.Text.Contains(".htm") Or TitoloProg.Text.Contains(".shtm") Or TitoloProg.Text.Contains(".shtml")) And Dir(Button4.Text.Replace(".html", ".css")) <> "" Then
                    buttprogling.Text = ("&HTML")
                    buttprogling.Enabled = True
                    buttprogcss.Visible = True
                    Button12.Enabled = True
                    CSSSIoNOtb.Text = ("si")
                    ProgettazioneButtonR.Enabled = True
                    AnteprimaButtonR.Enabled = True
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                    FastColoredTextBox1.Select()
                    CSSFTB.Text = (System.IO.File.ReadAllText(Button4.Text.Replace(".html", ".css")))
                    buttprogcss.Text = ("&CSS")
                    Button12.Enabled = True
                ElseIf TitoloProg.Text.Contains(".html") Or TitoloProg.Text.Contains(".htm") Or TitoloProg.Text.Contains(".shtm") Or TitoloProg.Text.Contains(".shtml") Then
                    buttprogling.Text = ("&HTML")
                    buttprogcss.Text = ("&CSS")
                    buttprogling.Enabled = True
                    buttprogcss.Visible = False
                    Button12.Enabled = False
                    CSSSIoNOtb.Text = ("no")
                    ProgettazioneButtonR.Enabled = True
                    AnteprimaButtonR.Enabled = True
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                    FastColoredTextBox1.Select()
                    filenonsupportato = False
                    Button12.Enabled = False
                ElseIf Text.Contains(".moix") Then
                    'se viene aperto un file: Minion (m) One (o/1) IMPOSTAZIONI (i) Avanzate (x)
                    'allora inizia l'importazione delle impostazioni --> le impostazioni vengo sovrascritte con quelle del file
                    filenonsupportato = True
                Else
                    Me.Text = Me.Text.Replace(".css", "")
                    Me.Text = Me.Text.Replace(".txt", "")
                    Me.Text = Me.Text.Replace(".cpp", "")
                    Me.Text = Me.Text.Replace(".doc", "")
                    Me.Text = Me.Text.Replace(".odt", "")
                    MessaggioErroreFileNonSupportato.ShowDialog()
                    buttprogling.Text = ("&HTML")
                    buttprogling.Visible = False
                    buttprogcss.Visible = False
                    Button12.Enabled = False
                    CSSSIoNOtb.Text = ("no")
                    ProgettazioneButtonR.Enabled = False
                    AnteprimaButtonR.Enabled = False
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
                    FastColoredTextBox1.Select()
                    InserisciButton.Enabled = False
                    InserisciToolStripMenuItem1.Enabled = False
                    buttprogling.Text = ("&HTML")
                    buttprogcss.Text = ("&CSS")
                    filenonsupportato = True
                    Button12.Enabled = False
                End If
                If filenonsupportato = False Then
                    Avvio.Show()
                    Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
                    Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
                    Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
                    Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
                    Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
                    Me.TitoloProg.Text = (Me.Text.Replace(" - Minion One", ""))
                    Avvio.recente1butt.Text = (TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", Button4.Text)
                    Avvio.Close()
                End If
                ultimoProgettoSalvato.Text = (FastColoredTextBox1.Text)
                FastColoredTextBox1.ClearUndo()
                CSSFTB.ClearUndo()
            Else
                Avvio.ShowDialog()
            End If
        Catch ex As Exception
            MessaggioF.Text = ("Errore: File URI non supportati")
            MessaggioF.Button1.Text = ("Il file che si sta tentando di aprire non è supportato da Minion One e pertanto non può essere aperto." & vbNewLine & "Errore inaspettato nell'apertura del file o del file stesso." & vbNewLine & "Codice errore: MOE1HQG94M8")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE1HQG94M8")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles AnteprimaButtonR.Click
        If Impostazioni.AvanzateTxt0.Text = ("WBI") Then
            AnteprimaWB.Visible = True
            ProgettazioneButtonR.BackColor = Color.DimGray
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
            '    If buttprogling.Text = ("&HTML") Then
            '        System.Diagnostics.Process.Start("file:\\" & "\" & (My.Application.Info.DirectoryPath) & "\FIle.html")
            '    End If
            'Catch
            '    MessaggioF.Text = ("Errore non gestito.")
            '    MessaggioF.Button1.Text = "Non è stato possibile aprire l'anteprima nel web browser predefito per un errore non riconosciuto e non gestito."
            'End Try

            If buttprogcss.Visible = True Then
                If Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(Button4.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(Button4.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
                buttprogcss.Text = "&CSS"
            Else
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)

            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanel.Visible = False
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
            MinionOneButton.ForeColor = Color.WhiteSmoke
            MinionOnePanel.Visible = False

            Button11.Visible = False
            Button10.Visible = False
            BarraDeiMenu.Enabled = False
            BarraInferiore.Visible = False
            WebBrowser1.DocumentText = (FastColoredTextBox1.Text)
        ElseIf Impostazioni.AvanzateTxt0.Text = ("WBP") Then
            If buttprogcss.Visible = True Then
                If Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(Button4.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(Button4.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
                buttprogcss.Text = "&CSS"
            Else
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
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
                Button35.Image = My.Resources.no
                My.Settings.aschermointero = "no"
            End If

            Process.Start("file:\\\" & Button4.Text.Replace(".css", ".html"))
        Else
            If buttprogcss.Visible = True Then
                If Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(Button4.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(Button4.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
                buttprogcss.Text = "&CSS"
            Else
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
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
                Button35.Image = My.Resources.no
                My.Settings.aschermointero = "no"
            End If

            Process.Start(Impostazioni.AvanzateTxt0.Text, "file:\\\" & Button4.Text.Replace(" ", "%20"))
        End If
    End Sub

    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles FileButton.Click
        If FilePanel.Visible = True Then
            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanel.Visible = False
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
            FilePanel.Visible = True
        End If

        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False
    End Sub

    Private Sub ModificaButton_Click(sender As Object, e As EventArgs) Handles ModificaButton.Click
        If ModificaPanel.Visible = True Then
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanel.Visible = False
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
            ModificaPanel.Visible = True
        End If

        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False
    End Sub

    Private Sub VisualizzaButton_Click(sender As Object, e As EventArgs) Handles VisualizzaButton.Click
        If VisualizzaPanel.Visible = True Then
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanel.Visible = False
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
            VisualizzaPanel.Visible = True
        End If

        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False
    End Sub

    Private Sub InserisciButton_Click(sender As Object, e As EventArgs) Handles InserisciButton.Click
        If InserisciPanel.Visible = True Then
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanel.Visible = False
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
            InserisciPanel.Visible = True
        End If

        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False
    End Sub

    Private Sub MinionOneButton_Click(sender As Object, e As EventArgs) Handles MinionOneButton.Click
        If MinionOnePanel.Visible = True Then
            MinionOneButton.BackColor = Color.DarkRed
            MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
            MinionOneButton.ForeColor = Color.WhiteSmoke
            MinionOnePanel.Visible = False
            If buttprogcss.BackColor = Color.Red Then
                CSSFTB.Select()
            Else
                FastColoredTextBox1.Select()
            End If
        Else
            MinionOneButton.BackColor = Color.WhiteSmoke
            MinionOneButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            MinionOneButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            MinionOneButton.ForeColor = Color.DarkRed
            MinionOnePanel.Visible = True
        End If

        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
    End Sub

    Private Sub BarraDeiMenu_MouseEnter(sender As Object, e As EventArgs) Handles BarraDeiMenu.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub FastColoredTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FastColoredTextBox1.KeyPress

    End Sub

    Private Sub FastColoredTextBox1_MouseEnter(sender As Object, e As EventArgs) Handles FastColoredTextBox1.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub buttprogcss_Click(sender As Object, e As EventArgs) Handles buttprogcss.Click
        buttprogling.BackColor = Color.DarkRed
        buttprogcss.BackColor = Color.Red
        CSSFTB.Visible = True
        FastColoredTextBox1.Visible = False
        Button9.Text = ("")
        Button9.Text = (CSSFTB.Text.Length)
        Button2.Text = ("")
        Button2.Text = (CSSFTB.Lines.Count)
        Button36.Enabled = False
        InserisciButton.Enabled = False
        InserisciToolStripMenuItem1.Enabled = False
        Button4.Text = Button4.Text.Replace(".html", ".css")
        Button5.Text = (UltSalCSS.Text)
        Button12.Text = "Pagina HTML"
        CSSFTB.Select()
    End Sub

    Private Sub buttprogling_Click(sender As Object, e As EventArgs) Handles buttprogling.Click
        buttprogling.BackColor = Color.Red
        buttprogcss.BackColor = Color.DarkRed
        CSSFTB.Visible = False
        FastColoredTextBox1.Visible = True
        Button9.Text = ("")
        Button9.Text = (FastColoredTextBox1.Text.Length)
        Button2.Text = ("")
        Button2.Text = (FastColoredTextBox1.Lines.Count)
        Button36.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        Button4.Text = Button4.Text.Replace(".css", ".html")
        Button5.Text = (UltSalHTML.Text)
        Button12.Text = "Foglio di stile (CSS)"
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        'bottone
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Bottone.Show()
    End Sub

    Private Sub ProgettazioneButtonR_Click(sender As Object, e As EventArgs) Handles ProgettazioneButtonR.Click
        AnteprimaWB.Visible = False
        ProgettazioneButtonR.BackColor = Color.DarkRed
        AnteprimaButtonR.BackColor = Color.DimGray

        'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("<style>" & vbNewLine & CSSFTB.Text & vbNewLine & "</style>", "")
        'FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("\Css.css", "\Css.mopcss")
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Button11.Visible = True
        Button10.Visible = True
        BarraDeiMenu.Enabled = True
        BarraInferiore.Visible = True
    End Sub

    Private Sub FastColoredTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles FastColoredTextBox1.KeyDown

    End Sub

    Private Sub FastColoredTextBox1_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles FastColoredTextBox1.TextChanged
        Button9.Text = (FastColoredTextBox1.Text.Length)
        Button2.Text = (FastColoredTextBox1.Lines.Count)
        buttprogling.Text = "HTML*"
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        'commento
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Commento.Show()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If Me.Text = "Senza titolo [Anteprima] - Minion One" And WebBrowser1.DocumentTitle <> "" Then
            Me.Text = WebBrowser1.DocumentTitle & "[Anteprima] - Minion One"
        End If
    End Sub

    Private Sub CSSFTB_Load(sender As Object, e As EventArgs) Handles CSSFTB.Load

    End Sub

    Private Sub CSSFTB_MouseEnter(sender As Object, e As EventArgs) Handles CSSFTB.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Select()
        End If
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
            DagliAppunti.Copy()
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

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", Me.Text.Replace(" - Minion One", ""))
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", FastColoredTextBox1.Text)
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        If AnteprimaButtonR.BackColor = Color.DarkRed Then
            WebBrowser1.GoBack()
        ElseIf buttprogcss.BackColor = Color.Red Then
            CSSFTB.Undo()
            CSSFTB.Select()
        ElseIf buttprogling.BackColor = Color.Red Then
            FastColoredTextBox1.Undo()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If AnteprimaButtonR.BackColor = Color.DarkRed Then
            WebBrowser1.GoForward()
        ElseIf buttprogcss.BackColor = Color.Red Then
            CSSFTB.Redo()
            CSSFTB.Select()
        ElseIf buttprogling.BackColor = Color.Red Then
            FastColoredTextBox1.Redo()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False
        If buttprogcss.Text = ("CSS*") Or buttprogling.Text = ("HTML*") Then
            EsciMessaggio.Text = ("Vuoi salvare il progetto prima di crearne uno nuovo?")
            EsciMessaggio.Button1.Text = ("Il progetto attuale non è stato salvato. Vuoi farlo prima di crearne uno nuovo?" & vbNewLine & "NOTA: Non sarà possibile recuperare il progetto se non lo si salva.")
            EsciMessaggio.Tipo.Text = ("Nuovo")
            EsciMessaggio.ShowDialog()
            If ApriNuovoProgNonSalv.Text = ("Nuovo") Then
                FastColoredTextBox1.Clear()
                CSSFTB.Text = ("")
                buttprogcss.Text = ("&CSS")
                buttprogling.Text = ("&HTML")
                buttprogling.Visible = True
                Avvio.ShowDialog()
            End If
        Else
            FastColoredTextBox1.Clear()
            CSSFTB.Text = ("")
            buttprogcss.Text = ("&CSS")
            buttprogling.Text = ("&HTML")
            Avvio.ShowDialog()
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If Impostazioni.GeneraleCheck2.Checked = True Then
            Impostazioni.GeneraleCheck2.Checked = False
        Else
            Impostazioni.GeneraleCheck2.Checked = True
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If My.Settings.aschermointero = ("si") Then
            My.Settings.aschermointero = ("no")
            'codici
            Button35.Image = My.Resources.no
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
            Button35.Image = My.Resources.si
            If Me.WindowState = FormWindowState.Maximized Then
                finestrastato = "mass"
            Else
                finestrastato = "norm"
            End If
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If Impostazioni.InterfacciaCheck0.CheckState = CheckState.Checked Then
            Impostazioni.InterfacciaCheck0.CheckState = CheckState.Unchecked
        Else
            Impostazioni.InterfacciaCheck0.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Button11.PerformClick()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Button10.PerformClick()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Cut()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Cut()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Copy()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Copy()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Paste()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Paste()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.ClearSelected()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.ClearSelected()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.SelectAll()
            CSSFTB.Select()
        Else
            FastColoredTextBox1.SelectAll()
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub IndietroToolStripMenuItem_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub AvantiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoForward()
    End Sub

    Private Sub UiuiuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        WebBrowser1.Refresh()
    End Sub

    Private Sub HhhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HhhToolStripMenuItem.Click
        ProgettazioneButtonR.PerformClick()
    End Sub

    Private Sub BarraDeiMenu_Paint(sender As Object, e As PaintEventArgs) Handles BarraDeiMenu.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'collegamento
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Collegamento.Show()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        'contenitore
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Contenitore.Show()
    End Sub

    Private Sub FileButton_MouseEnter(sender As Object, e As EventArgs) Handles FileButton.MouseEnter
        If ModificaPanel.Visible = True Or VisualizzaPanel.Visible = True Or InserisciPanel.Visible = True Or MinionOnePanel.Visible = True Then
            FileButton.BackColor = Color.WhiteSmoke
            FileButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            FileButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            FileButton.ForeColor = Color.DarkRed
            FilePanel.Visible = True
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanel.Visible = False
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
            MinionOneButton.ForeColor = Color.WhiteSmoke
            MinionOnePanel.Visible = False
        End If
    End Sub

    Private Sub ModificaButton_MouseEnter(sender As Object, e As EventArgs) Handles ModificaButton.MouseEnter
        If FilePanel.Visible = True Or VisualizzaPanel.Visible = True Or InserisciPanel.Visible = True Or MinionOnePanel.Visible = True Then
            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.WhiteSmoke
            ModificaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            ModificaButton.ForeColor = Color.DarkRed
            ModificaPanel.Visible = True
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
            MinionOneButton.ForeColor = Color.WhiteSmoke
            MinionOnePanel.Visible = False
        End If
    End Sub

    Private Sub VisualizzaButton_MouseEnter(sender As Object, e As EventArgs) Handles VisualizzaButton.MouseEnter
        If FilePanel.Visible = True Or ModificaPanel.Visible = True Or InserisciPanel.Visible = True Or MinionOnePanel.Visible = True Then
            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanel.Visible = False
            VisualizzaButton.BackColor = Color.WhiteSmoke
            VisualizzaButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            VisualizzaButton.ForeColor = Color.DarkRed
            VisualizzaPanel.Visible = True
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
            MinionOneButton.ForeColor = Color.WhiteSmoke
            MinionOnePanel.Visible = False
        End If
    End Sub

    Private Sub InserisciButton_MouseEnter(sender As Object, e As EventArgs) Handles InserisciButton.MouseEnter
        If FilePanel.Visible = True Or ModificaPanel.Visible = True Or VisualizzaPanel.Visible = True Or MinionOnePanel.Visible = True Then
            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanel.Visible = False
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanel.Visible = False
            InserisciButton.BackColor = Color.WhiteSmoke
            InserisciButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            InserisciButton.ForeColor = Color.DarkRed
            InserisciPanel.Visible = True
            MinionOneButton.BackColor = Color.DarkRed
            MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
            MinionOneButton.ForeColor = Color.WhiteSmoke
            MinionOnePanel.Visible = False
        End If
    End Sub

    Private Sub MinionOneButton_MouseEnter(sender As Object, e As EventArgs) Handles MinionOneButton.MouseEnter
        If FilePanel.Visible = True Or ModificaPanel.Visible = True Or VisualizzaPanel.Visible = True Or InserisciPanel.Visible = True Then
            FileButton.BackColor = Color.DarkRed
            FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            FileButton.FlatAppearance.MouseDownBackColor = Color.Red
            FileButton.ForeColor = Color.WhiteSmoke
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
            ModificaButton.ForeColor = Color.WhiteSmoke
            ModificaPanel.Visible = False
            VisualizzaButton.BackColor = Color.DarkRed
            VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
            VisualizzaButton.ForeColor = Color.WhiteSmoke
            VisualizzaPanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
            InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
            InserisciButton.ForeColor = Color.WhiteSmoke
            InserisciPanel.Visible = False
            MinionOneButton.BackColor = Color.WhiteSmoke
            MinionOneButton.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke
            MinionOneButton.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
            MinionOneButton.ForeColor = Color.DarkRed
            MinionOnePanel.Visible = True
        End If
    End Sub

    Private Sub ImpostazioniButton_Click(sender As Object, e As EventArgs) Handles ImpostazioniButton.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Impostazioni.ShowDialog()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        InformazioniF.ShowDialog()
    End Sub

    Private Sub BarraDiStato_MouseEnter(sender As Object, e As EventArgs) Handles BarraInferiore.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.BackColor = Color.Red Then
            CSSFTB.Select()
        Else
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub BarraDiStato_Paint(sender As Object, e As PaintEventArgs) Handles BarraInferiore.Paint

    End Sub

    Private Sub VediLanteprimaDelProgettoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VediLanteprimaDelProgettoToolStripMenuItem.Click
        AnteprimaButtonR.PerformClick()
    End Sub

    Private Sub VediLanteprimaDelProgettoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VediLanteprimaDelProgettoToolStripMenuItem1.Click
        AnteprimaButtonR.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs)
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        VisualizzaButton.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        MinionOneButton.Enabled = True
        ProgettazioneButtonR.Enabled = True
        AnteprimaButtonR.Enabled = True
        FastColoredTextBox1.ReadOnly = False
        FastColoredTextBox1.Select()
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        buttprogling.Enabled = True
        buttprogling.Text = ("&HTML")
        buttprogcss.Visible = False
        Button12.Enabled = False
        CSSSIoNOtb.Text = ("no")
        VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
        VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True

        CSSFTB.Visible = False
        FastColoredTextBox1.Visible = True
        buttprogling.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs)
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        VisualizzaButton.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        MinionOneButton.Enabled = True
        ProgettazioneButtonR.Enabled = True
        AnteprimaButtonR.Enabled = True
        FastColoredTextBox1.ReadOnly = False
        FastColoredTextBox1.Select()
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        buttprogling.Enabled = True
        buttprogling.Text = ("&HTML")
        buttprogcss.Visible = True
        Button12.Enabled = True
        CSSSIoNOtb.Text = ("si")
        VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
        VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs)
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        VisualizzaButton.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        MinionOneButton.Enabled = True
        ProgettazioneButtonR.Enabled = True
        AnteprimaButtonR.Enabled = False
        FastColoredTextBox1.ReadOnly = False
        FastColoredTextBox1.Select()
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP

        buttprogling.Enabled = True
        buttprogling.Text = ("PHP")
        buttprogcss.Visible = False
        Button12.Enabled = False
        CSSSIoNOtb.Text = ("no")
        VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False

        CSSFTB.Visible = False
        FastColoredTextBox1.Visible = True
        buttprogling.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs)
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        VisualizzaButton.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        MinionOneButton.Enabled = True
        ProgettazioneButtonR.Enabled = True
        AnteprimaButtonR.Enabled = False
        FastColoredTextBox1.ReadOnly = False
        FastColoredTextBox1.Select()
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS

        buttprogling.Enabled = True
        buttprogling.Text = ("JavaScript")
        buttprogcss.Visible = False
        Button12.Enabled = False
        CSSSIoNOtb.Text = ("no")
        VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False

        CSSFTB.Visible = False
        FastColoredTextBox1.Visible = True
        buttprogling.BackColor = Color.Red
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        VisualizzaButton.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        MinionOneButton.Enabled = True
        ProgettazioneButtonR.Enabled = True
        AnteprimaButtonR.Enabled = False
        FastColoredTextBox1.ReadOnly = False
        FastColoredTextBox1.Select()
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp

        buttprogling.Enabled = True
        buttprogling.Text = ("C#")
        buttprogcss.Visible = False
        Button12.Enabled = False
        CSSSIoNOtb.Text = ("no")
        VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False

        CSSFTB.Visible = False
        FastColoredTextBox1.Visible = True
        buttprogling.BackColor = Color.Red
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs)
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        VisualizzaButton.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        MinionOneButton.Enabled = True
        ProgettazioneButtonR.Enabled = True
        AnteprimaButtonR.Enabled = False
        FastColoredTextBox1.ReadOnly = False
        FastColoredTextBox1.Select()
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB

        buttprogling.Enabled = True
        buttprogling.Text = ("VB.NET")
        buttprogcss.Visible = False
        Button12.Enabled = False
        CSSSIoNOtb.Text = ("no")
        VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False

        CSSFTB.Visible = False
        FastColoredTextBox1.Visible = True
        buttprogling.BackColor = Color.Red
    End Sub

    Private Sub NonDefinitoNDToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        VisualizzaButton.Enabled = True
        InserisciButton.Enabled = True
        InserisciToolStripMenuItem1.Enabled = True
        MinionOneButton.Enabled = True
        ProgettazioneButtonR.Enabled = True
        AnteprimaButtonR.Enabled = True
        FastColoredTextBox1.ReadOnly = False
        FastColoredTextBox1.Select()
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom

        buttprogling.Enabled = True
        buttprogling.Text = ("N.D.")
        buttprogcss.Visible = False
        Button12.Enabled = False
        CSSSIoNOtb.Text = ("no")
        VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
        VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True

        CSSFTB.Visible = False
        FastColoredTextBox1.Visible = True
        buttprogling.BackColor = Color.Red
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        'descrizione
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Descrizione.Show()
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        'titolo
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Titolo.Show()
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        'sottotitolo
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Sottotitolo.Show()
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        'paragrafo
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Paragrafo.Show()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        'elenco
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Elenco.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FolderBrowserDialog1.SelectedPath = Button4.Text.Replace(Me.Text.Replace(" - Minion One", ""), "")
        FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath.Replace(".css", "")
        FolderBrowserDialog1.SelectedPath = FolderBrowserDialog1.SelectedPath.Replace(".html", "")
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            If Button4.Text.Contains(".css") Then
                PercorsoVecchioSalvataggio.Text = Button4.Text
            Else
                PercorsoVecchioSalvataggio.Text = Button4.Text.Replace(".html", ".css")
            End If
            If buttprogcss.BackColor = Color.Red Then
                Button4.Text = FolderBrowserDialog1.SelectedPath & "\" & Avvio.recente1butt.Text & ".css"
            Else
                Button4.Text = FolderBrowserDialog1.SelectedPath & "\" & Avvio.recente1butt.Text & ".html"
            End If
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", Button4.Text)
            If buttprogcss.BackColor = Color.Red Or buttprogcss.Visible = True Then
                If buttprogcss.Visible = True Then
                    If Button4.Text.Contains(".css") Then
                        System.IO.File.WriteAllText(Button4.Text, CSSFTB.Text)
                    Else
                        System.IO.File.WriteAllText(Button4.Text.Replace(".html", ".css"), CSSFTB.Text)
                    End If
                    If Button4.Text.Contains(".html") Then
                        System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                    Else
                        System.IO.File.WriteAllText(Button4.Text.Replace(".css", ".html"), FastColoredTextBox1.Text)
                    End If
                    buttprogling.Text = "&HTML"
                    buttprogcss.Text = "&CSS"
                Else
                    If Button4.Text.Contains(".html") Then
                        System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                    End If
                    buttprogling.Text = "&HTML"
                End If
                FastColoredTextBox1.Text = FastColoredTextBox1.Text.Replace("file:\\\" & PercorsoVecchioSalvataggio.Text.Replace(".html", ".css"), "file:\\\" & Button4.Text.Replace(".html", ".css"))
            Else
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
            End If
            FolderBrowserDialog1.SelectedPath = Button4.Text
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Try
            If buttprogcss.BackColor = Color.Red And buttprogcss.Visible = True Then
                If Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(Button4.Text, CSSFTB.Text)
                End If
                buttprogcss.Text = "&CSS"
                UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Else
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                Else
                    If (Button4.Text <> "") Then
                        System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                    End If
                End If
                buttprogling.Text = "&HTML"
                UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            End If
            Button5.Text = (Now.Hour & ":" & Now.Minute)
        Catch ex As Exception
            MessaggioF.Text = ("Errore: Salvataggio non riuscito")
            MessaggioF.Button1.Text = ("Non è stato trovato il percorso file selezionato per il salvataggio del progetto. Verificare che sia esistente, quindi modificarlo se non lo è." & vbNewLine & "Codice errore: MOE1AZA62R1")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE1AZA62R1")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        'immagine
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Immagine.Show()
    End Sub

    Private Sub FastColoredTextBox1_SelectionChanged(sender As Object, e As EventArgs) Handles FastColoredTextBox1.SelectionChanged
        If Impostazioni.GeneraleTxt3.Text = "SI" Then
            Dim testo As String = FastColoredTextBox1.SelectedText
            testo = testo.ToLower
            If testo.Contains("<img ") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_img.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "IMMAGINE" & vbNewLine & "E' il tag che indica" & vbNewLine & "un'immagine." & vbNewLine & vbNewLine & "<img src=" & Chr(34) & "..." & Chr(34) & " />")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<progress") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_progress.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "PROGRESSIONE" & vbNewLine & "E' il tag che permette di" & vbNewLine & "inserire una barra di" & vbNewLine & "caricamento." & vbNewLine & vbNewLine & "<progress value=" & Chr(34) & "..." & Chr(34) & "max=" & Chr(34) & "..." & Chr(34) & ">" & vbNewLine & "  </progress>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<iframe") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_iframe.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "IFRAME" & vbNewLine & "E' il tag che permette" & vbNewLine & "di implementare, nella pagina" & vbNewLine & "attuale, un ulteriore pagina." & vbNewLine & vbNewLine & "<iframe src=" & Chr(34) & "..." & Chr(34) & "></iframe>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<a ") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_a.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "COLLEGAMENTO" & vbNewLine & "E' il tag che indica" & vbNewLine & "un collegamento" & vbNewLine & "ipertestuale." & vbNewLine & vbNewLine & "<a href=" & Chr(34) & "..." & Chr(34) & "> ... </a>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<div") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_div.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "CONTENITORE" & vbNewLine & "E' il tag che indica" & vbNewLine & "un contenitore." & vbNewLine & vbNewLine & "<div> ... </div>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<input") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_input.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "INPUT" & vbNewLine & "E' il tag che identifica" & vbNewLine & "l'elemento input." & vbNewLine & "Può essere di diversi" & vbNewLine & "tipi: button, submit," & vbNewLine & "text, ecc..." & vbNewLine & vbNewLine & "<input type=" & Chr(34) & "..." & Chr(34) & vbNewLine & "value=" & Chr(34) & "..." & Chr(34) & " />")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<button") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_button.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "BOTTONE" & "E' il tag che identifica" & vbNewLine & "un bottone." & vbNewLine & vbNewLine & "<button onclick=" & Chr(34) & "location." & vbNewLine & "href:'...'" & Chr(34) & "> ... " & vbNewLine & "</button>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<p") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_p.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "PARAGRAFO" & vbNewLine & "E' il tag che identifica" & vbNewLine & "un paragrafo." & vbNewLine & vbNewLine & "<p> ... </p>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<font") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_font.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "TESTO" & vbNewLine & "E' il tag che identifica" & vbNewLine & "un testo." & vbNewLine & vbNewLine & "<font> ... </font>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<!----") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_comment.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "COMMENTO" & vbNewLine & "E' il tag che identifica" & vbNewLine & "un commento." & vbNewLine & "N.B. I commenti NON" & vbNewLine & "sono visibili nella pagina," & vbNewLine & "ma solamente vedendo il" & vbNewLine & "codice di essa." & vbNewLine & vbNewLine & "<!---- ... ---->" & vbNewLine & vbNewLine & vbNewLine)
                GallenPanel.Visible = True
            ElseIf testo.Contains("<hr ") Or testo.Contains("<hr/>") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_hr.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "SEPARATORE" & vbNewLine & "E' il tag che identifica" & vbNewLine & "un separatore." & vbNewLine & vbNewLine & "<hr/> oppure" & vbNewLine & "<hr /> oppure <hr>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<br ") Or testo.Contains("<br/>") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_br.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "A CAPO" & vbNewLine & "E' il tag che permette" & vbNewLine & "di andare a capo." & vbNewLine & vbNewLine & "<br/> oppure" & vbNewLine & "<br /> oppure <br>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<table") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_table.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "TABELLA" & vbNewLine & "E' il tag che identifica" & vbNewLine & "una tabella." & vbNewLine & "Essa al suo interno ha," & vbNewLine & "solitamente, altri tre" & vbNewLine & "tag:" & vbNewLine & "TR -> righe" & vbNewLine & "TD -> colonne (contenuto" & vbNewLine & "in TR)" & vbNewLine & "TH -> intestazione (contenuto" & vbNewLine & "in TR)" & vbNewLine & vbNewLine & "<table>" & vbNewLine & "  <tr>" & vbNewLine & "    <th> ... </th>" & vbNewLine & "  </tr>" & vbNewLine & "  <tr>" & vbNewLine & "    <td> ... </td>" & vbNewLine & "  </tr>" & vbNewLine & "</table>" & vbNewLine & vbNewLine & vbNewLine)
                GallenPanel.Visible = True
            ElseIf testo.Contains("<ul") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_ul.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "ELENCO" & vbNewLine & "E' il tag che identifica" & vbNewLine & "una lista, un elenco." & vbNewLine & "Può essere di due tipi:" & vbNewLine & "OL -> Numerato" & vbNewLine & "Ul -> Non numerato" & vbNewLine & "Al loro interno hanno" & vbNewLine & "un altro tag " & Chr(34) & "LI" & Chr(34) & " che serve per aggiungere" & vbNewLine & "una nuova voce alla lista." & vbNewLine & vbNewLine & "<ol>" & vbNewLine & "  <li> ... </li>" & vbNewLine & "</ol>" & vbNewLine & vbNewLine & "oppure" & vbNewLine & vbNewLine & "<ul>" & vbNewLine & "  <li> ... </li>" & vbNewLine & "</ul>" & vbNewLine & vbNewLine & vbNewLine)
                GallenPanel.Visible = True
            ElseIf testo.Contains("<ol") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_ol.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "ELENCO" & vbNewLine & "E' il tag che identifica" & vbNewLine & "una lista, un elenco." & vbNewLine & "Può essere di due tipi:" & vbNewLine & "OL -> Numerato" & vbNewLine & "Ul -> Non numerato" & vbNewLine & "Al loro interno hanno" & vbNewLine & "un altro tag " & Chr(34) & "LI" & Chr(34) & " che serve per aggiungere" & vbNewLine & "una nuova voce alla lista." & vbNewLine & vbNewLine & "<ol>" & vbNewLine & "  <li> ... </li>" & vbNewLine & "</ol>" & vbNewLine & vbNewLine & "oppure" & vbNewLine & vbNewLine & "<ul>" & vbNewLine & "  <li> ... </li>" & vbNewLine & "</ul>" & vbNewLine & vbNewLine & vbNewLine)
                GallenPanel.Visible = True
            ElseIf testo.Contains("<title>") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_title.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "TITOLO" & vbNewLine & "E' il tag che identifica" & vbNewLine & "il titolo della pagina," & vbNewLine & "essenziale per ogni pagina." & vbNewLine & "E' contenuto nel tag" & vbNewLine & "HEAD." & vbNewLine & vbNewLine & "<title> ... </title>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<html") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_html.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "&HTML" & vbNewLine & "E' il tag che identifica" & vbNewLine & "l'inizio della pagina." & vbNewLine & "E' il primo tag che" & vbNewLine & "bisogna inserire." & vbNewLine & vbNewLine & "<html>" & vbNewLine & "..." & vbNewLine & "</html>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<head") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_head.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "HEAD" & vbNewLine & "E' il tag che identifica" & vbNewLine & "la parte " & Chr(34) & "non visibile" & Chr(34) & vbNewLine & "della pagina, la" & Chr(34) & "testa" & Chr(34) & "." & vbNewLine & "E' necessaria per" & vbNewLine & "ogni pagina." & vbNewLine & "E' contenuto nel tag HTML." & vbNewLine & vbNewLine & "<head>" & vbNewLine & "..." & vbNewLine & "</head>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<body") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_body.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "E' il tag che identifica" & vbNewLine & "la parte visibile della" & vbNewLine & "pagina e dove sono contenuti" & vbNewLine & "tutti gli altrin elementi." & vbNewLine & "E' necessaria per ogni" & vbNewLine & "pagina." & vbNewLine & "E' contenuto nel tag HTML." & vbNewLine & vbNewLine & "<body>" & vbNewLine & "..." & vbNewLine & "</body>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<h1") Or testo.Contains("<h2") Or testo.Contains("<h3") Or testo.Contains("<h4") Or testo.Contains("<h5") Or testo.Contains("<h6") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_hn.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "H1-6" & vbNewLine & "Sono i tag che identifica" & vbNewLine & "un titolo, quindi un" & vbNewLine & "testo scritto più grande" & vbNewLine & "rispetto al resto della" & vbNewLine & "pagina." & vbNewLine & "Va dal numero 1, il" & vbNewLine & "più grande, al 6, il più" & vbNewLine & "piccolo." & vbNewLine & vbNewLine & "<h1> ... </h1>" & vbNewLine & "<h2> ... </h2>" & vbNewLine & "<h3> ... </h3>" & vbNewLine & "<h4> ... </h4>" & vbNewLine & "<h5> ... </h5>" & vbNewLine & "<h6> ... </h6>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<script") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_script.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "SCRIPT" & vbNewLine & "E' il tag che identifica" & vbNewLine & Chr(34) & "un'implementazione" & Chr(34) & " di codice" & vbNewLine & "JavaScript in una pagina" & vbNewLine & "HTML." & vbNewLine & vbNewLine & "<script>" & vbNewLine & "..." & vbNewLine & "</script>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<style") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_style.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "STYLE" & vbNewLine & "E' il tag che identifica" & vbNewLine & Chr(34) & "un'implementazione" & Chr(34) & " di codice" & vbNewLine & "CSS in una pagina" & vbNewLine & "HTML." & vbNewLine & vbNewLine & "<style>" & vbNewLine & "..." & vbNewLine & "</style>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<span") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_span.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "SPAN" & vbNewLine & "E' il tag che permette" & vbNewLine & "di formattare un testo tramite" & vbNewLine & "codice CSS." & vbNewLine & vbNewLine & "<span style=" & Chr(34) & "..." & Chr(34) & "> ... </span>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<b") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_b.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "NERETTO" & vbNewLine & "E' il tag che permette" & vbNewLine & "di mettere un testo in" & vbNewLine & "neretto/grassetto." & vbNewLine & "B e STRONG permettono di fare la stessa cosa." & vbNewLine & vbNewLine & "<b> ... </b>" & vbNewLine & "<strong> ... </strong>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<strong") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_strong.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "NERETTO" & vbNewLine & "E' il tag che permette" & vbNewLine & "di mettere un testo in" & vbNewLine & "neretto/grassetto." & vbNewLine & "B e STRONG permettono di fare la stessa cosa." & vbNewLine & vbNewLine & "<b> ... </b>" & vbNewLine & "<strong> ... </strong>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<form") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_form.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "MODULO" & vbNewLine & "E' il tag che identifica" & vbNewLine & "un modulo." & vbNewLine & "Solitamente contiene elementi" & vbNewLine & "di tipo INPUT o LABEL." & vbNewLine & vbNewLine & "<form>" & vbNewLine & "..." & vbNewLine & "</form>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<center") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_center.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "CENTRO" & vbNewLine & "E' il tag che permette di" & vbNewLine & "allinearegli elementi che" & vbNewLine & "contiene al centro." & vbNewLine & vbNewLine & "<center> ... </center>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<i") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_i.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "CORSIVO" & vbNewLine & "E' il tag che permette di" & vbNewLine & "mettere un testo in" & vbNewLine & "italico/corsivo." & vbNewLine & "I e EM permettono di" & vbNewLine & "fare la stessa cosa." & vbNewLine & vbNewLine & "<i> ... </i>" & vbNewLine & "<em> ... </em>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<em") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_em.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "CORSIVO" & vbNewLine & "E' il tag che permette di" & vbNewLine & "mettere un testo in" & vbNewLine & "italico/corsivo." & vbNewLine & "I e EM permettono di" & vbNewLine & "fare la stessa cosa." & vbNewLine & vbNewLine & "<i> ... </i>" & vbNewLine & "<em> ... </em>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<u") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_u.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "SOTTOLINEATO" & vbNewLine & "E' il tag che permette" & vbNewLine & "di sottolineare un testo." & vbNewLine & vbNewLine & "<u> ... </u>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<sub") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_sub.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "SOTTOTITOLO" & vbNewLine & "E' il tag che permette" & vbNewLine & "di mettere un testo come" & vbNewLine & "pedice." & vbNewLine & vbNewLine & "<sub> ... </sub>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<sup") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_sup.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "APICE" & vbNewLine & "E' il tag che permette" & vbNewLine & "di mettere un testo come" & vbNewLine & "apice." & vbNewLine & vbNewLine & "<sup> ... </sup>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<big") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_big.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "TESTO GRANDE" & vbNewLine & "E' il tag che permette" & vbNewLine & "di inserire un testo più" & vbNewLine & "grande di quello predefinito." & vbNewLine & vbNewLine & "<big> ... </big>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("small") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_small.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "TESTO PICCOLO" & vbNewLine & "E' il tag che permette di" & vbNewLine & "inserire un testo più piccolo" & vbNewLine & "di quello predefinito." & vbNewLine & vbNewLine & "<small> ... </small>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<s") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_s.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "BARRATO" & vbNewLine & "E' il tag che permette di" & vbNewLine & "barrare un testo." & vbNewLine & "S, STRIKE e DEL permettono" & vbNewLine & "di fare la stessa cosa." & vbNewLine & vbNewLine & "<s> ... </s>" & vbNewLine & "<strike> ... </strike>" & vbNewLine & "<del> ... </del>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<del") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_del.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "BARRATO" & vbNewLine & "E' il tag che permette di" & vbNewLine & "barrare un testo." & vbNewLine & "S, STRIKE e DEL permettono" & vbNewLine & "di fare la stessa cosa." & vbNewLine & vbNewLine & "<s> ... </s>" & vbNewLine & "<strike> ... </strike>" & vbNewLine & "<del> ... </del>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<strike") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_strike.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "BARRATO" & vbNewLine & "E' il tag che permette di" & vbNewLine & "barrare un testo." & vbNewLine & "S, STRIKE e DEL permettono" & vbNewLine & "di fare la stessa cosa." & vbNewLine & vbNewLine & "<s> ... </s>" & vbNewLine & "<strike> ... </strike>" & vbNewLine & "<del> ... </del>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<frame") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_frame.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "FRAME" & vbNewLine & "E' il tag che permette" & vbNewLine & "di dividere la pagina in" & vbNewLine & "più zone tra loro" & vbNewLine & "indipendenti." & vbNewLine & vbNewLine & "<frame> ... </frame>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<video") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_video.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "VIDEO" & vbNewLine & "E' il tag che permette" & vbNewLine & "di inserire un video." & vbNewLine & vbNewLine & "<video controls>" & vbNewLine & "  <source src=" & Chr(34) & "..." & Chr(34) & vbNewLine & "  type=" & Chr(34) & "..." & Chr(34) & ">" & vbNewLine & "</video>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<audio") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_audio.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "AUDIO" & vbNewLine & "E' il tag che permette" & vbNewLine & "di inserire un video." & vbNewLine & vbNewLine & "<audio controls>" & vbNewLine & "  <source src=" & Chr(34) & "..." & Chr(34) & vbNewLine & "  type=" & Chr(34) & "..." & Chr(34) & ">" & vbNewLine & "</audio>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<map") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_map.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "MAP" & vbNewLine & "E' il tag che permette di" & vbNewLine & "gestire le coordinate di" & vbNewLine & "un'immagine." & vbNewLine & vbNewLine & "<img src=" & Chr(34) & "..." & Chr(34) & vbNewLine & "usemap=" & Chr(34) & "#..." & Chr(34) & " />" & vbNewLine & "<map name=" & Chr(34) & "..." & Chr(34) & ">" & vbNewLine & "<area shape=" & Chr(34) & "..." & Chr(34) & vbNewLine & "  coords=" & Chr(34) & "..." & Chr(34) & "  href=" & Chr(34) & "..." & Chr(34) & ">" & vbNewLine & "</map>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<menu") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_menu.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "MENU" & vbNewLine & "E' il tag che permette di" & vbNewLine & "gestire il menù del web" & vbNewLine & "browser (il tasto destro)." & vbNewLine & vbNewLine & "<menu type=" & Chr(34) & "context" & Chr(34) & ">" & vbNewLine & "  <menuitem label=" & Chr(34) & "..." & Chr(34) & vbNewLine & "  onclick=" & Chr(34) & "..." & Chr(34) & ">" & vbNewLine & "  </menuitem>" & vbNewLine & "</menu>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<meta") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_meta.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "META" & vbNewLine & "E' il tag che permette di" & vbNewLine & "inserire informazioni non visibili" & vbNewLine & "a chi vede la pagina, ma" & vbNewLine & "visibili dal web browser." & vbNewLine & "E' necessario inserire il" & vbNewLine & "tag META all'interno del" & vbNewLine & "tag HEAD." & vbNewLine & vbNewLine & "<meta name=" & Chr(34) & "..." & Chr(34) & vbNewLine & "  content=" & Chr(34) & "..." & Chr(34) & ">")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<q") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_q.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "CITAZIONE" & vbNewLine & "E' il tag che permette di" & vbNewLine & "inserire le citazioni." & vbNewLine & vbNewLine & "<q> ... </q>")
                GallenPanel.Visible = True
            ElseIf testo.Contains("<ruby") Then
                GallenApriNelSito.Text = ("http://www.w3schools.com/tags/tag_ruby.asp")
                GallenDescrizioneElemento.Text = ("&HTML" & vbNewLine & "RUBY" & vbNewLine & "E' il tag che permette" & vbNewLine & "di inserire un testo sopra" & vbNewLine & "un altro." & vbNewLine & vbNewLine & "<ruby>" & vbNewLine & "  ... <rt> ... </rt>" & vbNewLine & "</ruby>")
                GallenPanel.Visible = True
            Else
                GallenApriNelSito.Text = ("")
                GallenPanel.Visible = False
            End If
        Else
            GallenApriNelSito.Text = ("")
            GallenPanel.Visible = False
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If buttprogcss.Text = ("CSS*") Or buttprogling.Text = ("HTML*") Then
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
                    Me.Text = (My.Computer.FileSystem.GetName(testo) & " - Minion One")
                    Me.Text = Me.Text.Replace(".html", "")
                    Button4.Text = (OpenFileDialog1.FileName)
                    buttprogcss.Text = ("&CSS")
                    buttprogling.Text = ("&HTML")
                    SaveFileDialog1.FileName = (testo)
                    If Dir(Button4.Text.Replace(".html", ".css")) <> "" Then
                        buttprogling.Text = ("&HTML")
                        buttprogling.Enabled = True
                        buttprogcss.Visible = True
                        Button12.Enabled = True
                        CSSSIoNOtb.Text = ("si")
                        ProgettazioneButtonR.Enabled = True
                        AnteprimaButtonR.Enabled = True
                        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                        FastColoredTextBox1.Select()
                        CSSFTB.Text = (System.IO.File.ReadAllText(Button4.Text.Replace(".html", ".css")))
                        buttprogcss.Text = ("&CSS")
                    Else
                        buttprogling.Text = ("&HTML")
                        buttprogling.Enabled = True
                        buttprogcss.Visible = False
                        Button12.Enabled = False
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
                    MinionOneButton.Enabled = True
                    Avvio.Show()
                    Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
                    Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
                    Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
                    Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
                    Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
                    Me.TitoloProg.Text = (Me.Text.Replace(" - Minion One", ""))
                    Avvio.recente1butt.Text = (TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", Button4.Text)
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
                Me.Text = (My.Computer.FileSystem.GetName(testo) & " - Minion One")
                Me.Text = Me.Text.Replace(".html", "")
                Button4.Text = (OpenFileDialog1.FileName)
                buttprogcss.Text = ("&CSS")
                buttprogling.Text = ("&HTML")
                SaveFileDialog1.FileName = (testo)
                If Dir(Button4.Text.Replace(".html", ".css")) <> "" Then
                    buttprogling.Text = ("&HTML")
                    buttprogling.Enabled = True
                    buttprogcss.Visible = True
                    Button12.Enabled = True
                    CSSSIoNOtb.Text = ("si")
                    ProgettazioneButtonR.Enabled = True
                    AnteprimaButtonR.Enabled = True
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                    FastColoredTextBox1.Select()
                    CSSFTB.Text = (System.IO.File.ReadAllText(Button4.Text.Replace(".html", ".css")))
                    buttprogcss.Text = ("&CSS")
                Else
                    buttprogling.Text = ("&HTML")
                    buttprogling.Enabled = True
                    buttprogcss.Visible = False
                    Button12.Enabled = False
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
                MinionOneButton.Enabled = True
                Avvio.Show()
                Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", Avvio.recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
                Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", Avvio.recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
                Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", Avvio.recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
                Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", Avvio.recente2butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
                Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", Avvio.recente1butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
                Me.TitoloProg.Text = (Me.Text.Replace(" - Minion One", ""))
                Avvio.recente1butt.Text = (TitoloProg.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", TitoloProg.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", Button4.Text)
                Avvio.Close()
                ultimoProgettoSalvato.Text = (FastColoredTextBox1.Text)
            End If
            FastColoredTextBox1.Select()
            FastColoredTextBox1.ClearUndo()
        End If
    End Sub

    Private Sub buttprogling_MouseEnter(sender As Object, e As EventArgs) Handles buttprogling.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False
    End Sub

    Private Sub buttprogcss_MouseEnter(sender As Object, e As EventArgs) Handles buttprogcss.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Try
            If buttprogcss.Visible = True Then
                If Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(Button4.Text, CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(Button4.Text.Replace(".html", ".css"), CSSFTB.Text)
                End If
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
                buttprogcss.Text = "&CSS"
            Else
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
            End If
            UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Button5.Text = (Now.Hour & ":" & Now.Minute)
        Catch ex As Exception
            MessaggioF.Text = ("Errore: Salvataggio non riuscito")
            MessaggioF.Button1.Text = ("Non è stato trovato il percorso file selezionato per il salvataggio del progetto. Verificare che sia esistente, quindi modificarlo se non lo è." & vbNewLine & "Codice errore: MOE1AZA62R1")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE1AZA62R1")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Sostituisci.Show()
        'If buttprogling.BackColor = Color.Red Then
        '    FastColoredTextBox1.ShowReplaceDialog()
        'ElseIf buttprogcss.BackColor = Color.Red And buttprogcss.Visible = True Then
        '    CSSFTB.ShowReplaceDialog()
        'End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        'caratteri speciali
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        CaratteriSpeciali.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        'testo personalizzato
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        TestoPersonalizzato.Show()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        'separatore
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Separatore.Show()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        'tabella

        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Tabella.Show()
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
        Button11.PerformClick()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Button10.PerformClick()
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
                If Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(Button4.Text, CSSFTB.Text)
                End If
                buttprogcss.Text = "&CSS"
                UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Else
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
                UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            End If
            Button5.Text = (Now.Hour & ":" & Now.Minute)
        Catch ex As Exception
            MessaggioF.Text = ("Errore: Salvataggio non riuscito")
            MessaggioF.Button1.Text = ("Non è stato trovato il percorso file selezionato per il salvataggio del progetto. Verificare che sia esistente, quindi modificarlo se non lo è." & vbNewLine & "Codice errore: MOE1AZA62R1")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE1AZA62R1")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        Try
            If buttprogcss.BackColor = Color.Red And buttprogcss.Visible = True Then
                If Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(Button4.Text, CSSFTB.Text)
                End If
                buttprogcss.Text = "&CSS"
                UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            Else
                If Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
                End If
                buttprogling.Text = "&HTML"
                UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
            End If
            Button5.Text = (Now.Hour & ":" & Now.Minute)
        Catch ex As Exception
            MessaggioF.Text = ("Errore: Salvataggio non riuscito")
            MessaggioF.Button1.Text = ("Non è stato trovato il percorso file selezionato per il salvataggio del progetto. Verificare che sia esistente, quindi modificarlo se non lo è." & vbNewLine & "Codice errore: MOE1AZA62R1")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE1AZA62R1")
            MessaggioF.ShowDialog()
            Avvio.ShowDialog()
        End Try
    End Sub

    Private Sub CarattteriSpecialiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarattteriSpecialiToolStripMenuItem.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        CaratteriSpeciali.Show()
    End Sub

    Private Sub ParagrafoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParagrafoToolStripMenuItem.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Bottone.Show()
    End Sub

    Private Sub CollegamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CollegamentoToolStripMenuItem1.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Collegamento.Show()
    End Sub

    Private Sub ImmagineToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImmagineToolStripMenuItem1.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Commento.Show()
    End Sub

    Private Sub TestoPersonalizzatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestoPersonalizzatoToolStripMenuItem.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Contenitore.Show()
    End Sub

    Private Sub CommentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CommentoToolStripMenuItem1.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Descrizione.Show()
    End Sub

    Private Sub SeparatoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeparatoreToolStripMenuItem.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Elenco.Show()
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Immagine.Show()
    End Sub

    Private Sub TitoloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitoloToolStripMenuItem.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Paragrafo.Show()
    End Sub

    Private Sub SottotitoloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SottotitoloToolStripMenuItem.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Separatore.Show()
    End Sub

    Private Sub DescrizioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescrizioneToolStripMenuItem.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Sottotitolo.Show()
    End Sub

    Private Sub BottoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottoneToolStripMenuItem.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Tabella.Show()
    End Sub

    Private Sub CaratteriSpecialiToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CaratteriSpecialiToolStripMenuItem2.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        TestoPersonalizzato.Show()
    End Sub

    Private Sub TitoloToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TitoloToolStripMenuItem1.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Titolo.Show()
    End Sub

    Private Sub FastColoredTextBox1_KeyPressed(sender As Object, e As KeyPressEventArgs) Handles FastColoredTextBox1.KeyPressed

    End Sub

    Private Sub FastColoredTextBox1_KeyPressing(sender As Object, e As KeyPressEventArgs) Handles FastColoredTextBox1.KeyPressing

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
            DagliAppunti.Copy()
        End If
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs)
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If buttprogcss.Text = ("CSS*") Or buttprogling.Text = ("HTML*") Then
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
                    Me.Text = (My.Computer.FileSystem.GetName(testo) & " - Minion One")
                    Me.Text = Me.Text.Replace(".html", "")
                    Button4.Text = (OpenFileDialog1.FileName)
                    buttprogcss.Text = ("&CSS")
                    buttprogling.Text = ("&HTML")
                    SaveFileDialog1.FileName = (testo)
                    If Dir(Button4.Text.Replace(".html", ".css")) <> "" Then
                        buttprogling.Text = ("&HTML")
                        buttprogling.Enabled = True
                        buttprogcss.Visible = True
                        Button12.Enabled = True
                        CSSSIoNOtb.Text = ("si")
                        ProgettazioneButtonR.Enabled = True
                        AnteprimaButtonR.Enabled = True
                        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                        FastColoredTextBox1.Select()
                        CSSFTB.Text = (System.IO.File.ReadAllText(Button4.Text.Replace(".html", ".css")))
                        buttprogcss.Text = ("&CSS")
                    Else
                        buttprogling.Text = ("&HTML")
                        buttprogling.Enabled = True
                        buttprogcss.Visible = False
                        Button12.Enabled = False
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
                    MinionOneButton.Enabled = True
                    Avvio.Show()
                    Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
                    Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
                    Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
                    Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
                    Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
                    Me.TitoloProg.Text = (Me.Text.Replace(" - Minion One", ""))
                    Avvio.recente1butt.Text = (TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", TitoloProg.Text)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", Button4.Text)
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
                Me.Text = (My.Computer.FileSystem.GetName(testo) & " - Minion One")
                Me.Text = Me.Text.Replace(".html", "")
                Button4.Text = (OpenFileDialog1.FileName)
                buttprogcss.Text = ("&CSS")
                buttprogling.Text = ("&HTML")
                SaveFileDialog1.FileName = (testo)
                If Dir(Button4.Text.Replace(".html", ".css")) <> "" Then
                    buttprogling.Text = ("&HTML")
                    buttprogling.Enabled = True
                    buttprogcss.Visible = True
                    Button12.Enabled = True
                    CSSSIoNOtb.Text = ("si")
                    ProgettazioneButtonR.Enabled = True
                    AnteprimaButtonR.Enabled = True
                    FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                    FastColoredTextBox1.Select()
                    CSSFTB.Text = (System.IO.File.ReadAllText(Button4.Text.Replace(".html", ".css")))
                    buttprogcss.Text = ("&CSS")
                Else
                    buttprogling.Text = ("&HTML")
                    buttprogling.Enabled = True
                    buttprogcss.Visible = False
                    Button12.Enabled = False
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
                MinionOneButton.Enabled = True
                Avvio.Show()
                Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", Avvio.recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
                Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", Avvio.recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
                Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", Avvio.recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
                Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", Avvio.recente2butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
                Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", Avvio.recente1butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
                Me.TitoloProg.Text = (Me.Text.Replace(" - Minion One", ""))
                Avvio.recente1butt.Text = (TitoloProg.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", TitoloProg.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", Button4.Text)
                Avvio.Close()
                ultimoProgettoSalvato.Text = (FastColoredTextBox1.Text)
            End If
            FastColoredTextBox1.Select()
            FastColoredTextBox1.ClearUndo()
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Impostazioni.ShowDialog()
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Novita.ShowDialog()
    End Sub

    Private Sub AiutoButton_Click(sender As Object, e As EventArgs) Handles AiutoButton.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        Aiuto.ShowDialog()
    End Sub

    Private Sub AnnullaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnnullaToolStripMenuItem1.Click
        Button11.PerformClick()
    End Sub

    Private Sub RipetiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RipetiToolStripMenuItem1.Click
        Button10.PerformClick()
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
        FastColoredTextBox1.CollapseBlock(FastColoredTextBox1.Selection.Start.iLine, FastColoredTextBox1.Selection.End.iLine)
    End Sub

    Private Sub BarraLaterale_Paint(sender As Object, e As PaintEventArgs) Handles BarraLaterale.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles GallenDescrizioneElemento.Click

    End Sub

    Private Sub GallenApriNelSitoButton_Click(sender As Object, e As EventArgs) Handles GallenApriNelSitoButton.Click
        Process.Start(GallenApriNelSito.Text)
    End Sub

    Private Sub HTMLTimerAutoSave_Tick(sender As Object, e As EventArgs) Handles HTMLTimerAutoSave.Tick
        If Button4.Text.Contains(".html") Then
            System.IO.File.WriteAllText(Button4.Text, FastColoredTextBox1.Text)
        End If
        buttprogling.Text = "&HTML"
        UltSalHTML.Text = (Now.Hour & ":" & Now.Minute)
        If buttprogling.BackColor = Color.Red Then
            Button5.Text = (Now.Hour & ":" & Now.Minute)
        End If
    End Sub

    Private Sub CSSTimerAutoSave_Tick(sender As Object, e As EventArgs) Handles CSSTimerAutoSave.Tick
        If buttprogcss.Visible = True Then
            If Button4.Text.Contains(".css") Then
                System.IO.File.WriteAllText(Button4.Text, CSSFTB.Text)
            End If
            buttprogcss.Text = "&CSS"
            UltSalCSS.Text = (Now.Hour & ":" & Now.Minute)
            If buttprogcss.BackColor = Color.Red Then
                Button5.Text = (Now.Hour & ":" & Now.Minute)
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        AiutoButton.PerformClick()
    End Sub

    Private Sub ContextMenuFile_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuFile.Opening

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        If Button12.Text = "Foglio di stile (CSS)" Then
            buttprogcss.PerformClick()
        Else
            buttprogling.PerformClick()
        End If
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        AnteprimaButtonR.PerformClick()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'grassetto -> inserisci
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        TextBox1.Text = "<b></b>"
        DagliAppunti.Paste()
        DaIncollare.Text = TextBox1.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        DagliAppunti.Copy()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        'corsivo -> inserisci
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        TextBox1.Text = "<i></i>"
        DagliAppunti.Paste()
        DaIncollare.Text = TextBox1.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        DagliAppunti.Copy()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        'sottolineato -> inserisci
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        TextBox1.Text = "<u></u>"
        DagliAppunti.Paste()
        DaIncollare.Text = TextBox1.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        DagliAppunti.Copy()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        'a capo <br/> -> inserisci
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        TextBox1.Text = vbNewLine & "<br/>" & vbNewLine
        DagliAppunti.Paste()
        DaIncollare.Text = TextBox1.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        DagliAppunti.Copy()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        'separatore <hr/> -> inserisci
        FileButton.BackColor = Color.DarkRed
        FileButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        FileButton.ForeColor = Color.WhiteSmoke
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        ModificaButton.ForeColor = Color.WhiteSmoke
        ModificaPanel.Visible = False
        VisualizzaButton.BackColor = Color.DarkRed
        VisualizzaButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        VisualizzaButton.ForeColor = Color.WhiteSmoke
        VisualizzaPanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        InserisciButton.ForeColor = Color.WhiteSmoke
        InserisciPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOneButton.FlatAppearance.MouseOverBackColor = buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOnePanel.Visible = False

        TextBox1.Text = vbNewLine & "<hr/>" & vbNewLine
        DagliAppunti.Paste()
        DaIncollare.Text = TextBox1.Text
        DaIncollare.SelectAll()
        DaIncollare.Copy()
        FastColoredTextBox1.Paste()
        DaIncollare.Text = ""
        DagliAppunti.SelectAll()
        DagliAppunti.Copy()
        FastColoredTextBox1.Select()
    End Sub
End Class