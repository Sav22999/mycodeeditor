
Public Class MinionOne
    Dim num_lung As Long
    Private IsFormBeingDragged As Boolean = True

    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If My.Settings.finestremenuinseriscitopmost = ("si") Then
            Paragrafo.TopMost = False
            Immagine.TopMost = False
            TestoPersonalizzato.TopMost = False
            Commento.TopMost = False
            Collegamento.TopMost = False
            Separatore.TopMost = False
            Lista.TopMost = False
            Titolo.TopMost = False
            Sottotitolo.TopMost = False
            Descrizione.TopMost = False
            Bottone.TopMost = False
            CaratteriSpeciali.TopMost = False
        Else
        End If
        Avvio.TopMost = False
        If FastColoredTextBox1.Text <> TextBox88.Text Then
            Dim result As Integer = MsgBox("Vuoi salvare il progetto prima di chiuderlo?", MsgBoxStyle.YesNoCancel, "Minion One - Chiusura")
            If result = MsgBoxResult.Yes Then
                If TextBox1.Text <> "" Then
                    System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
                Else
                    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                        Me.Text = (SaveFileDialog1.FileName & " - Minion One")
                        TextBox1.Text = (SaveFileDialog1.FileName)
                    End If
                End If
            ElseIf result = MsgBoxResult.No Then
                e.Cancel = False
            ElseIf result = MsgBoxResult.Cancel Then
                e.Cancel = True
                If My.Settings.finestremenuinseriscitopmost = ("si") Then
                    Paragrafo.TopMost = True
                    Immagine.TopMost = True
                    TestoPersonalizzato.TopMost = True
                    Commento.TopMost = True
                    Collegamento.TopMost = True
                    Separatore.TopMost = True
                    Lista.TopMost = True
                    Titolo.TopMost = True
                    Sottotitolo.TopMost = True
                    Descrizione.TopMost = True
                    Bottone.TopMost = True
                    CaratteriSpeciali.TopMost = True
                Else
                End If
                Avvio.TopMost = True
            End If
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FastColoredTextBox1_ForeColorChanged(sender As Object, e As EventArgs) Handles FastColoredTextBox1.ForeColorChanged

    End Sub

    Private Sub FastColoredTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles FastColoredTextBox1.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            If FastColoredTextBox1.Text <> "" Then
                Dim result As Integer = MsgBox("Prima di creare un nuovo progetto volete salvare il medesimo?", MsgBoxStyle.YesNoCancel, "Minion One - Avvertimento")
                If result = MsgBoxResult.Yes Then
                    If TextBox1.Text = ("") Then
                        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                            System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                            TextBox1.Text = (SaveFileDialog1.FileName)
                            FastColoredTextBox1.Clear()
                            Avvio.Show()
                            Avvio.Button6.Text = ("Crea o apri un progetto")
                            TextBox1.Text = ("")
                            SaveFileDialog1.FileName = ("Progetto")
                        End If
                    Else
                        System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
                        FastColoredTextBox1.Clear()
                        Avvio.Show()
                        Avvio.Button6.Text = ("Crea o apri un progetto")
                        TextBox1.Text = ("")
                        SaveFileDialog1.FileName = ("Progetto")
                    End If

                ElseIf result = MsgBoxResult.No Then
                    FastColoredTextBox1.Clear()
                    Avvio.Show()
                    Avvio.Button6.Text = ("Crea o apri un progetto")
                    TextBox1.Text = ("")
                    SaveFileDialog1.FileName = ("Progetto")
                ElseIf result = MsgBoxResult.Cancel Then


                End If
            Else
                Avvio.Show()
                Avvio.Button6.Text = ("Crea o apri un progetto")
                TextBox1.Text = ("")
                SaveFileDialog1.FileName = ("Progetto")
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            If My.Settings.finestremenuinseriscitopmost = ("si") Then
                Paragrafo.TopMost = False
                Immagine.TopMost = False
                TestoPersonalizzato.TopMost = False
                Commento.TopMost = False
                Collegamento.TopMost = False
                Separatore.TopMost = False
                Lista.TopMost = False
                Titolo.TopMost = False
                Sottotitolo.TopMost = False
                Descrizione.TopMost = False
                Bottone.TopMost = False
                CaratteriSpeciali.TopMost = False
            Else
            End If
            Avvio.TopMost = False
            If FastColoredTextBox1.Text <> TextBox88.Text Then
                Dim result As Integer = MsgBox("Vuoi salvare il progetto prima di chiuderlo?", MsgBoxStyle.YesNoCancel, "Minion One - Chiusura")
                If result = MsgBoxResult.Yes Then
                    If TextBox1.Text <> "" Then
                        System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
                    Else
                        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                            System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                            Me.Text = (SaveFileDialog1.FileName & " - Minion One")
                            TextBox1.Text = (SaveFileDialog1.FileName)
                        End If
                    End If
                ElseIf result = MsgBoxResult.No Then
                    Me.Close()
                ElseIf result = MsgBoxResult.Cancel Then
                    If My.Settings.finestremenuinseriscitopmost = ("si") Then
                        Paragrafo.TopMost = True
                        Immagine.TopMost = True
                        TestoPersonalizzato.TopMost = True
                        Commento.TopMost = True
                        Collegamento.TopMost = True
                        Separatore.TopMost = True
                        Lista.TopMost = True
                        Titolo.TopMost = True
                        Sottotitolo.TopMost = True
                        Descrizione.TopMost = True
                        Bottone.TopMost = True
                        CaratteriSpeciali.TopMost = True
                    Else
                    End If
                    Avvio.TopMost = True
                End If
            Else
                End
            End If
        ElseIf e.Alt AndAlso e.KeyCode = Keys.O Then
            MinionOneButton.BackColor = Color.Red
            MinionOnePanel.Visible = True
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
            StrumentiPanel.Visible = False
        ElseIf e.Alt AndAlso e.KeyCode = Keys.I Then
            InserisciButton.BackColor = Color.Red
            InserisciPanel.Visible = True
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            StrumentiPanel.Visible = False
        ElseIf e.Alt AndAlso e.KeyCode = Keys.V Then
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.Red
            ProgettoPanel.Visible = True
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            StrumentiPanel.Visible = False
        ElseIf e.Alt AndAlso e.KeyCode = Keys.M Then
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.Red
            ModificaPanel.Visible = True
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            StrumentiPanel.Visible = False
        ElseIf e.Alt AndAlso e.KeyCode = Keys.F Then
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
            FileButton.BackColor = Color.Red
            FilePanel.Visible = True
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            StrumentiPanel.Visible = False
        End If
    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.Load
        
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles FileButton.Click
        If FilePanel.Visible = False Then
            FileButton.BackColor = Color.Red
            FilePanel.Visible = True
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
            StrumentiPanel.Visible = False
        Else
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FastColoredTextBox1.Select()
        If Dir(My.Application.Info.DirectoryPath & "\impostazioni.imo") <> "" Then
            salvaimpostazionitext.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo")
            If salvaimpostazionitext.Text.Contains("{*/+*") Then
                My.Settings.aggiornamentoautomatico = ("si")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("°§ç@è}") Then
                My.Settings.aggiornamentoautomatico = ("no")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("¤ü«Ä") Then
                My.Settings.tema = ("scuro")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("Ûáà♣") Then
                My.Settings.tema = ("chiaro")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("♫♥gòó") Then
                My.Settings.tema = ("giallastro")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("0Ìü☼Ë") Then
                My.Settings.tema = ("luminoso")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("ì*=<>") Then
                My.Settings.barrastrumentiapri = ("passaggio")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains(";_¯-?^") Then
                My.Settings.barrastrumentiapri = ("click")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("3!?}{{") Then
                My.Settings.acapoautomatico = ("SI")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("|\;:.¯_") Then
                My.Settings.acapoautomatico = ("NO")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("%&&#à") Then
                My.Settings.finestremenuinseriscitopmost = ("si")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("%!?#") Then
                My.Settings.finestremenuinseriscitopmost = ("no")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("?à<<") Then
                My.Settings.webbrowserfinestra = ("form")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("é###") Then
                My.Settings.webbrowserfinestra = ("panel")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("♥ìË") Then
                My.Settings.webbrowserfinestranormaletopmost = ("si")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("é¤»èì") Then
                My.Settings.webbrowserfinestranormaletopmost = ("no")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("°üÄ>><.") Then
                My.Settings.primoavvio = ("si")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("^;;:^&") Then
                My.Settings.primoavvio = ("no")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("##?#") Then
                My.Settings.colorebordi = ("black")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("&#&!£") Then
                My.Settings.colorebordi = ("gray")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("%/<\") Then
                My.Settings.colorebordi = ("white")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("??#?!") Then
                My.Settings.colorebordi = ("yellow")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("%?#%%!") Then
                My.Settings.colorebordi = ("gold")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("%%?%!") Then
                My.Settings.colorebordi = ("orangered")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("%££$!") Then
                My.Settings.colorebordi = ("red")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("%$£(=") Then
                My.Settings.colorebordi = ("fuchsia")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("%=)^'") Then
                My.Settings.colorebordi = ("purple")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("|\ì^☸") Then
                My.Settings.colorebordi = ("navy")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains(";-!_^") Then
                My.Settings.colorebordi = ("blue")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("<!><_!;") Then
                My.Settings.colorebordi = ("cyan")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains(":*+-ò") Then
                My.Settings.colorebordi = ("teal")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("ù[è[+*") Then
                My.Settings.colorebordi = ("green")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("ò@#.,{") Then
                My.Settings.colorebordi = ("lime")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("/\++*") Then
                My.Settings.anteprimaprogetto = ("SI")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("3/--*\*+") Then
                My.Settings.anteprimaprogetto = ("NO")
                My.Settings.Save()
            End If
            If salvaimpostazionitext.Text.Contains("g<>b.-") Then
                My.Settings.strumenti = ("SI")
                My.Settings.Save()
            ElseIf salvaimpostazionitext.Text.Contains("[]*]-") Then
                My.Settings.strumenti = ("NO")
                My.Settings.Save()
            End If
        Else
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text)
            My.Settings.primoavvio = ("si")
        End If

        If My.Settings.tema = ("chiaro") Then
            FastColoredTextBox1.BackColor = Color.Silver
            FastColoredTextBox1.ForeColor = Color.Black
        ElseIf My.Settings.tema = ("scuro") Then
            FastColoredTextBox1.BackColor = Color.Black
            FastColoredTextBox1.ForeColor = Color.Silver
        ElseIf My.Settings.tema = ("luminoso") Then
            FastColoredTextBox1.BackColor = Color.White
            FastColoredTextBox1.ForeColor = Color.Black
        ElseIf My.Settings.tema = ("giallastro") Then
            FastColoredTextBox1.BackColor = Color.LemonChiffon
            FastColoredTextBox1.ForeColor = Color.DimGray
        End If

        If My.Settings.acapoautomatico = ("NO") Then
            Button15.Image = My.Resources.no
            FastColoredTextBox1.WordWrap = False
            My.Settings.Save()
        ElseIf My.Settings.acapoautomatico = ("SI") Then
            Button15.Image = My.Resources.si
            FastColoredTextBox1.WordWrap = True
            My.Settings.Save()
        End If
        If My.Settings.anteprimaprogetto = ("NO") Then
            Button35.Image = My.Resources.no
            AnteprimaProgettoBottone.Visible = False
            AnteprimaProgetto.Visible = False
            ProgrammazioneProgettoBottone.BackColor = Color.Red
            AnteprimaProgettoBottone.BackColor = Color.DarkRed
            My.Settings.Save()
        ElseIf My.Settings.anteprimaprogetto = ("SI") Then
            Button35.Image = My.Resources.si
            AnteprimaProgettoBottone.Visible = True
            My.Settings.Save()
        End If
        If My.Settings.strumenti = ("NO") Then
            Button39.Image = My.Resources.no
            StrumentiButton.Visible = False
            StrumentiPanel.Visible = False
            My.Settings.Save()
        ElseIf My.Settings.strumenti = ("SI") Then
            Button39.Image = My.Resources.si
            StrumentiButton.Visible = True
            My.Settings.Save()
        End If

        Dim argomenti As String() = My.Application.CommandLineArgs.ToArray
        If argomenti.Length > 0 Then
            Dim fileName As String = argomenti(0)
            FastColoredTextBox1.Text = (My.Computer.FileSystem.ReadAllText(fileName))
            Me.Text = (My.Computer.FileSystem.GetName(fileName) & " - Minion One")
            If Text.Contains(".html") Or Text.Contains(".htm") Or Text.Contains(".shtm") Or Text.Contains(".shtml") Then
                If My.Settings.anteprimaprogetto = ("SI") Then
                    Button35.Image = My.Resources.si
                    AnteprimaProgettoBottone.Visible = True
                ElseIf My.Settings.anteprimaprogetto = ("NO") Then
                    Button35.Image = My.Resources.no
                    AnteprimaProgettoBottone.Visible = False
                    AnteprimaProgetto.Visible = False
                    ProgrammazioneProgettoBottone.BackColor = Color.Red
                    AnteprimaProgettoBottone.BackColor = Color.DarkRed
                End If
                If My.Settings.strumenti = ("SI") Then
                    StrumentiButton.Visible = True
                    Button39.Image = (My.Resources.si)
                ElseIf My.Settings.strumenti = ("NO") Then
                    StrumentiButton.Visible = False
                    Button39.Image = (My.Resources.no)
                End If
                Button35.Enabled = True
                Button39.Enabled = True
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                TipoDiEditor.Text = ("Editor: HTML")
                FastColoredTextBox1.Select()
            ElseIf Text.Contains(".php") Then
                ProgrammazioneProgettoBottone.BackColor = Color.Red
                AnteprimaProgettoBottone.BackColor = Color.DarkRed
                AnteprimaProgettoBottone.Visible = False
                AnteprimaProgetto.Visible = False
                Button39.Enabled = True
                Button35.Enabled = False
                Button35.Image = (My.Resources.no)
                If My.Settings.strumenti = ("SI") Then
                    StrumentiButton.Visible = True
                    Button39.Image = (My.Resources.si)
                ElseIf My.Settings.strumenti = ("NO") Then
                    StrumentiButton.Visible = False
                    Button39.Image = (My.Resources.no)
                End If
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP
                TipoDiEditor.Text = ("Editor: PHP")
                FastColoredTextBox1.Select()
            ElseIf Text.Contains(".js") Then
                ProgrammazioneProgettoBottone.BackColor = Color.Red
                AnteprimaProgettoBottone.BackColor = Color.DarkRed
                AnteprimaProgettoBottone.Visible = False
                AnteprimaProgetto.Visible = False
                Button39.Enabled = False
                Button39.Image = (My.Resources.no)
                Button35.Enabled = False
                Button35.Image = (My.Resources.no)
                StrumentiButton.Visible = False
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
                TipoDiEditor.Text = ("Editor: JS")
                FastColoredTextBox1.Select()
            ElseIf Text.Contains(".txt") Then
                ProgrammazioneProgettoBottone.BackColor = Color.Red
                AnteprimaProgettoBottone.BackColor = Color.DarkRed
                AnteprimaProgettoBottone.Visible = False
                AnteprimaProgetto.Visible = False
                Button39.Enabled = False
                Button39.Image = (My.Resources.no)
                Button35.Enabled = False
                Button35.Image = (My.Resources.no)
                StrumentiButton.Visible = False

                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
                TipoDiEditor.Text = ("Editor: TXT")
                FastColoredTextBox1.Select()
            ElseIf Text.Contains(".vb") Or Text.Contains(".vbproj") Or Text.Contains(".resx") Or Text.Contains(".sln") Then
                ProgrammazioneProgettoBottone.BackColor = Color.Red
                AnteprimaProgettoBottone.BackColor = Color.DarkRed
                AnteprimaProgettoBottone.Visible = False
                AnteprimaProgetto.Visible = False
                Button39.Enabled = False
                Button39.Image = (My.Resources.no)
                Button35.Enabled = False
                Button35.Image = (My.Resources.no)
                StrumentiButton.Visible = False

                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB
                TipoDiEditor.Text = ("Editor: VB.NET")
                FastColoredTextBox1.Select()
            ElseIf Text.Contains(".cs") Or Text.Contains(".csproj") Then
                ProgrammazioneProgettoBottone.BackColor = Color.Red
                AnteprimaProgettoBottone.BackColor = Color.DarkRed
                AnteprimaProgettoBottone.Visible = False
                AnteprimaProgetto.Visible = False
                Button39.Enabled = False
                Button39.Image = (My.Resources.no)
                Button35.Enabled = False
                Button35.Image = (My.Resources.no)
                StrumentiButton.Visible = False
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp
                TipoDiEditor.Text = ("Editor: C#")
                FastColoredTextBox1.Select()
            ElseIf Text.Contains(".imo") Or Text.Contains(".im1") Then
                TipoDiEditor.Text = ("Editor: iMO")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
                AnteprimaProgettoBottone.Visible = False
                StrumentiButton.Visible = False
                Button39.Enabled = False
                Button39.Image = (My.Resources.no)
                Button35.Enabled = False
                Button35.Image = (My.Resources.no)
                My.Settings.strumenti = ("NO")
                Me.Text = (Me.Text.Replace("impostazioni.imo", "Impostazioni di Minion One salvate"))
            Else
                TipoDiEditor.Text = ("Editor: N.R.")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
                AnteprimaProgettoBottone.Visible = False
                StrumentiButton.Visible = False
                Button39.Enabled = False
                Button39.Image = (My.Resources.no)
                Button35.Enabled = False
                Button35.Image = (My.Resources.no)
                My.Settings.strumenti = ("NO")
            End If
            SaveFileDialog1.FileName = (fileName)
            SaveFileDialog1.FilterIndex = (4)
            TextBox1.Text = (SaveFileDialog1.FileName)
            SaveFileDialog1.FileName = (Me.Text.Replace(" - Minion One", ""))

            TextBox88.Text = (FastColoredTextBox1.Text)
        Else
            Avvio.Show()
        End If

        If My.Settings.aggiornamentoautomatico = ("si") Then
            ControlloAggiornamenti.Show()
        ElseIf My.Settings.aggiornamentoautomatico = ("no") Then
        End If

        Timer1.Start()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ModificaButton_Click(sender As Object, e As EventArgs) Handles ModificaButton.Click
        If ModificaPanel.Visible = False Then
            ModificaButton.BackColor = Color.Red
            ModificaPanel.Visible = True
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
            StrumentiPanel.Visible = False
        Else
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub ProgettoButton_Click(sender As Object, e As EventArgs) Handles ProgettoButton.Click
        If ProgettoPanel.Visible = False Then
            ProgettoButton.BackColor = Color.Red
            ProgettoPanel.Visible = True
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
            StrumentiPanel.Visible = False
        Else
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub InserisciButton_Click(sender As Object, e As EventArgs) Handles InserisciButton.Click
        If InserisciPanel.Visible = False Then
            InserisciButton.BackColor = Color.Red
            InserisciPanel.Visible = True
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            StrumentiPanel.Visible = False
        Else
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub MinionOneButton_Click(sender As Object, e As EventArgs) Handles MinionOneButton.Click
        If MinionOnePanel.Visible = False Then
            MinionOneButton.BackColor = Color.Red
            MinionOnePanel.Visible = True
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
            StrumentiPanel.Visible = False
        Else
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()
    End Sub

    Private Sub FastColoredTextBox1_MouseEnter(sender As Object, e As EventArgs) Handles FastColoredTextBox1.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Dim NuovoProgettoNuovaFinestra As New MinionOne
        NuovoProgettoNuovaFinestra.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If My.Settings.finestremenuinseriscitopmost = ("si") Then
            Paragrafo.TopMost = False
            Immagine.TopMost = False
            TestoPersonalizzato.TopMost = False
            Commento.TopMost = False
            Collegamento.TopMost = False
            Separatore.TopMost = False
            Lista.TopMost = False
            Titolo.TopMost = False
            Sottotitolo.TopMost = False
            Descrizione.TopMost = False
            Bottone.TopMost = False
            CaratteriSpeciali.TopMost = False
        Else
        End If
        Avvio.TopMost = False
        If FastColoredTextBox1.Text <> TextBox88.Text Then
            Dim result As Integer = MsgBox("Vuoi salvare il progetto prima di chiuderlo?", MsgBoxStyle.YesNoCancel, "Minion One - Chiusura")
            If result = MsgBoxResult.Yes Then
                If TextBox1.Text <> "" Then
                    System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
                Else
                    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                        Me.Text = (SaveFileDialog1.FileName & " - Minion One")
                        TextBox1.Text = (SaveFileDialog1.FileName)
                    End If
                End If
            ElseIf result = MsgBoxResult.No Then
                End
            ElseIf result = MsgBoxResult.Cancel Then
                If My.Settings.finestremenuinseriscitopmost = ("si") Then
                    Paragrafo.TopMost = True
                    Immagine.TopMost = True
                    TestoPersonalizzato.TopMost = True
                    Commento.TopMost = True
                    Collegamento.TopMost = True
                    Separatore.TopMost = True
                    Lista.TopMost = True
                    Titolo.TopMost = True
                    Sottotitolo.TopMost = True
                    Descrizione.TopMost = True
                    Bottone.TopMost = True
                    CaratteriSpeciali.TopMost = True
                Else
                End If
                Avvio.TopMost = True
            End If
        Else
            End
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

        End
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        ImpostaStampa.ShowDialog()
    End Sub

    Private Sub FastColoredTextBox1_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles FastColoredTextBox1.TextChanged
        WebBrowser2.DocumentText = (FastColoredTextBox1.Text)
        WebBrowser.WebBrowser2.DocumentText = (FastColoredTextBox1.Text)
        num_lung = Len(FastColoredTextBox1.Text)
        Button37.Text = (num_lung)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        Stampa.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        AnteprimaStampa.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        If FastColoredTextBox1.Text <> "" Then
            Dim result As Integer = MsgBox("Prima di creare un nuovo progetto volete salvare il medesimo?", MsgBoxStyle.YesNoCancel, "Minion One - Avvertimento")
            If result = MsgBoxResult.Yes Then
                If TextBox1.Text = ("") Then
                    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                        TextBox1.Text = (SaveFileDialog1.FileName)
                        FastColoredTextBox1.Clear()
                        Avvio.Show()
                        Avvio.Button6.Text = ("Crea o apri un progetto")
                        TextBox1.Text = ("")
                        SaveFileDialog1.FileName = ("Progetto")
                    End If
                Else
                    System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
                    FastColoredTextBox1.Clear()
                    Avvio.Show()
                    Avvio.Button6.Text = ("Crea o apri un progetto")
                    TextBox1.Text = ("")
                    SaveFileDialog1.FileName = ("Progetto")
                End If

            ElseIf result = MsgBoxResult.No Then
                FastColoredTextBox1.Clear()
                Avvio.Show()
                Avvio.Button6.Text = ("Crea o apri un progetto")
                TextBox1.Text = ("")
                SaveFileDialog1.FileName = ("Progetto")
            ElseIf result = MsgBoxResult.Cancel Then


            End If
        Else
            Avvio.Show()
            Avvio.Button6.Text = ("Crea o apri un progetto")
            TextBox1.Text = ("")
            SaveFileDialog1.FileName = ("Progetto")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
            Me.Text = (OpenFileDialog1.FileName & " - Minion One")
            TextBox1.Text = (OpenFileDialog1.FileName)
            If Text.Contains(".html") Or Text.Contains(".htm") Then
                TipoDiEditor.Text = ("Editor: HTML")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
            ElseIf Text.Contains(".php") Then
                TipoDiEditor.Text = ("Editor: PHP")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP
            ElseIf Text.Contains(".js") Then
                TipoDiEditor.Text = ("Editor: JS")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
            ElseIf Text.Contains(".txt") Then
                TipoDiEditor.Text = ("Editor: TXT")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
            Else
                TipoDiEditor.Text = ("Editor: N.R.")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
            End If
            FastColoredTextBox1.Text = (testo)
            SaveFileDialog1.FileName = (OpenFileDialog1.FileName)
        End If
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
            TextBox1.Text = (SaveFileDialog1.FileName)
            Me.Text = (SaveFileDialog1.FileName & " - Minion One")
        End If
        TextBox88.Text = (FastColoredTextBox1.Text)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        If TextBox1.Text <> "" Then
            System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
        Else
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                TextBox1.Text = (SaveFileDialog1.FileName)
                Me.Text = (SaveFileDialog1.FileName & " - Minion One")
            End If
        End If
        TextBox88.Text = (FastColoredTextBox1.Text)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        FastColoredTextBox1.Undo()

        FastColoredTextBox1.Select()
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        FastColoredTextBox1.Redo()

        FastColoredTextBox1.Select()
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        FastColoredTextBox1.Cut()

        FastColoredTextBox1.Select()
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        FastColoredTextBox1.Copy()

        FastColoredTextBox1.Select()
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        FastColoredTextBox1.Paste()

        FastColoredTextBox1.Select()
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        FastColoredTextBox1.ClearSelected()

        FastColoredTextBox1.Select()
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        FastColoredTextBox1.SelectAll()

        FastColoredTextBox1.Select()
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        FastColoredTextBox1.SelectAll()
        FastColoredTextBox1.Copy()

        FastColoredTextBox1.Select()
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()
        Paragrafo.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        CaratteriSpeciali.Show()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        If My.Settings.anteprimaprogetto = ("NO") Then
            My.Settings.anteprimaprogetto = ("SI")
            Button35.Image = My.Resources.si
            AnteprimaProgettoBottone.Visible = True
            My.Settings.Save()

            salvaimpostazionitext.Text = salvaimpostazionitext.Text.Replace("3/--*\*+", "") 'inserire nelle prime virgolette il codice da sostituire
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text)
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text & "/\++*") 'inserire nelle virgolette il codice da inserire
        ElseIf My.Settings.anteprimaprogetto = ("SI") Then
            My.Settings.anteprimaprogetto = ("NO")
            Button35.Image = My.Resources.no
            AnteprimaProgettoBottone.Visible = False
            AnteprimaProgetto.Visible = False
            ProgrammazioneProgettoBottone.BackColor = Color.Red
            AnteprimaProgettoBottone.BackColor = Color.DarkRed
            My.Settings.Save()

            salvaimpostazionitext.Text = salvaimpostazionitext.Text.Replace("/\++*", "") 'inserire nelle prime virgolette il codice da sostituire
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text)
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text & "3/--*\*+") 'inserire nelle virgolette il codice da inserire
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InserisciToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AnnullaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnnullaToolStripMenuItem1.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub RipetiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RipetiToolStripMenuItem1.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub TagliaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TagliaToolStripMenuItem1.Click
        FastColoredTextBox1.Cut()
    End Sub

    Private Sub CopiaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopiaToolStripMenuItem1.Click
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub IncollaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem1.Click
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub SelezionaTuttoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelezionaTuttoToolStripMenuItem1.Click
        WebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub SelezionaECopiaTuttoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelezionaECopiaTuttoToolStripMenuItem1.Click
        If FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML Then
            SaveFileDialog1.FilterIndex = ("3")
        ElseIf FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP Then
            SaveFileDialog1.FilterIndex = ("8")
        ElseIf FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS Then
            SaveFileDialog1.FilterIndex = ("11")
        ElseIf FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB Then
            SaveFileDialog1.FilterIndex = ("10")
        ElseIf FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.SQL Then
            SaveFileDialog1.FilterIndex = ("11")
        ElseIf FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom Then
            SaveFileDialog1.FilterIndex = ("11")
        End If
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
            TextBox1.Text = (SaveFileDialog1.FileName)
            Me.Text = (SaveFileDialog1.FileName & " - Minion One")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
            FastColoredTextBox1.Text = (testo)
            Me.Text = (OpenFileDialog1.FileName & " - Minion One")
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs)
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        FastColoredTextBox1.Text = (FastColoredTextBox1.Text & Environment.NewLine & "<?php" & Environment.NewLine & Environment.NewLine & "?>")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        Separatore.Show()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False


    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs)
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False


    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        TestoPersonalizzato.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        Immagine.Show()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AnteprimaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        If My.Settings.acapoautomatico = ("NO") Then
            My.Settings.acapoautomatico = ("SI")
            Button15.Image = My.Resources.si
            FastColoredTextBox1.WordWrap = True
            My.Settings.Save()

            salvaimpostazionitext.Text = salvaimpostazionitext.Text.Replace("|\;:.¯_", "") 'inserire nelle prime virgolette il codice da sostituire
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text)
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text & "3!?}{{") 'inserire nelle virgolette il codice da inserire
        ElseIf My.Settings.acapoautomatico = ("SI") Then
            My.Settings.acapoautomatico = ("NO")
            Button15.Image = My.Resources.no
            FastColoredTextBox1.WordWrap = False
            My.Settings.Save()

            salvaimpostazionitext.Text = salvaimpostazionitext.Text.Replace("3!?}{{", "") 'inserire nelle prime virgolette il codice da sostituire
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text)
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text & "|\;:.¯_") 'inserire nelle virgolette il codice da inserire
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        FileButton.BackColor = Color.DarkRed

        FastColoredTextBox1.Select()
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        Cercaesostituisci.Show()
    End Sub

    Private Sub EliminaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminaToolStripMenuItem1.Click
        FastColoredTextBox1.ClearSelected()
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        Info.Close()
        Info.Show()
    End Sub

    Private Sub Button17_Click_2(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        Commento.Show()
    End Sub

    Private Sub Button31_Click_1(sender As Object, e As EventArgs) Handles AnteprimaProgettoBottone.Click
        If My.Settings.webbrowserfinestra = ("form") Then
            WebBrowser.Show()
        ElseIf My.Settings.webbrowserfinestra = ("panel") Then
            AnteprimaProgetto.Visible = True
            ProgrammazioneProgettoBottone.BackColor = Color.DarkRed
            AnteprimaProgettoBottone.BackColor = Color.Red
            Button36.Enabled = False
            Button42.Enabled = False
            Button43.Enabled = False
            Button45.Enabled = False
            FileButton.Enabled = False
            ModificaButton.Enabled = False
            ProgettoButton.Enabled = False
            InserisciButton.Enabled = False
            Button30.Enabled = False
            Button31.Enabled = False
            StrumentiButton.Visible = False
            WebBrowser2.DocumentText = (FastColoredTextBox1.Text)
        End If
    End Sub

    Private Sub ProgrammazioneProgettoBottone_Click(sender As Object, e As EventArgs) Handles ProgrammazioneProgettoBottone.Click
        AnteprimaProgetto.Visible = False
        ProgrammazioneProgettoBottone.BackColor = Color.Red
        AnteprimaProgettoBottone.BackColor = Color.DarkRed
        Button36.Enabled = True
        Button42.Enabled = True
        Button43.Enabled = True
        Button45.Enabled = True
        FileButton.Enabled = True
        ModificaButton.Enabled = True
        ProgettoButton.Enabled = True
        InserisciButton.Enabled = True
        Button31.Enabled = True
        Button30.Enabled = True
        If My.Settings.strumenti = ("SI") Then
            StrumentiButton.Visible = True
        Else
        End If
        FastColoredTextBox1.Select()
    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        If WebBrowser2.DocumentTitle = ("") Then
            Label2.Text = ("Senza titolo")
            If IsFormBeingDragged Then
                Dim temp As Point = New Point()
                temp.Y = ("39")
                temp.X = Label2.Width + 14
                TitoloProgetto.Size = temp
                TitoloProgetto.Text = ("Senza titolo")
            End If
        Else
            If TitoloProgetto.Width > "610" Then
                TitoloProgetto.Text = ("Errore: Titolo troppo lungo")
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("39")
                    temp.X = ("610")
                    TitoloProgetto.Size = temp
                End If
            Else
                Label2.Text = (WebBrowser2.DocumentTitle)
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("39")
                    temp.X = Label2.Width + 14
                    TitoloProgetto.Size = temp
                    TitoloProgetto.Text = (WebBrowser2.DocumentTitle)
                End If
            End If

        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        FastColoredTextBox1.Undo()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button31_i_Click(sender As Object, e As EventArgs) Handles Button31.Click
        FastColoredTextBox1.Redo()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button33_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        Collegamento.Show()
    End Sub

    Private Sub Button8_Click_2(sender As Object, e As EventArgs) Handles Button8.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        Lista.Show()
    End Sub

    Private Sub Button17_Click_3(sender As Object, e As EventArgs) Handles Button17.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        Titolo.Show()
    End Sub

    Private Sub Button28_Click_1(sender As Object, e As EventArgs) Handles Button28.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        Sottotitolo.Show()
    End Sub

    Private Sub Button29_Click_1(sender As Object, e As EventArgs) Handles Button29.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        Descrizione.Show()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
        FastColoredTextBox1.Select()

        Bottone.Show()
    End Sub

    Private Sub Button33_Click_2(sender As Object, e As EventArgs) Handles ButtonIndietroAnteprima.Click
        If WebBrowser2.CanGoBack Then
            WebBrowser2.GoBack()
        Else
            WebBrowser2.DocumentText = (FastColoredTextBox1.Text)
        End If
    End Sub

    Private Sub Button34_Click_1(sender As Object, e As EventArgs) Handles ButtonAvantiAnteprima.Click
        WebBrowser2.GoForward()
    End Sub

    Private Sub Button33_MouseEnter(sender As Object, e As EventArgs) Handles ButtonIndietroAnteprima.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub Button34_MouseEnter(sender As Object, e As EventArgs) Handles ButtonAvantiAnteprima.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub TitoloProgetto_Click(sender As Object, e As EventArgs) Handles TitoloProgetto.Click
        If FastColoredTextBox1.Text <> ("") Then
            Dim result As Integer = MsgBox("Prima di modificare i codici di questa pagina, vuoi salvare il progetto iniziato in precedenza?", MsgBoxStyle.YesNoCancel, "Minion One - Avvertimento")
            If result = MsgBoxResult.Yes Then
                If TextBox1.Text = ("") Then
                    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                        TextBox1.Text = (SaveFileDialog1.FileName)
                        FastColoredTextBox1.Clear()
                        TextBox1.Text = ("")
                        SaveFileDialog1.FileName = ("Progetto")
                        FastColoredTextBox1.Text = (WebBrowser2.DocumentText)
                        AnteprimaProgetto.Visible = False
                        AnteprimaProgettoBottone.BackColor = Color.DarkRed
                        AnteprimaProgettoBottone.Visible = True
                        ProgrammazioneProgettoBottone.BackColor = Color.Red
                        AnteprimaProgetto.Visible = False
                        ProgrammazioneProgettoBottone.BackColor = Color.Red
                        AnteprimaProgettoBottone.BackColor = Color.DarkRed
                        Button36.Enabled = True
                        Button42.Enabled = True
                        Button43.Enabled = True
                        Button45.Enabled = True
                        FileButton.Enabled = True
                        ModificaButton.Enabled = True
                        ProgettoButton.Enabled = True
                        InserisciButton.Enabled = True
                        Button31.Enabled = True
                        Button30.Enabled = True
                        If My.Settings.strumenti = ("SI") Then
                            StrumentiButton.Visible = True
                        Else
                        End If
                    End If
                Else
                    System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
                    FastColoredTextBox1.Clear()
                    TextBox1.Text = ("")
                    SaveFileDialog1.FileName = ("Progetto")
                    FastColoredTextBox1.Text = (WebBrowser2.DocumentText)
                    AnteprimaProgetto.Visible = False
                    AnteprimaProgettoBottone.BackColor = Color.DarkRed
                    AnteprimaProgettoBottone.Visible = True
                    ProgrammazioneProgettoBottone.BackColor = Color.Red
                    AnteprimaProgetto.Visible = False
                    ProgrammazioneProgettoBottone.BackColor = Color.Red
                    AnteprimaProgettoBottone.BackColor = Color.DarkRed
                    Button36.Enabled = True
                    Button42.Enabled = True
                    Button43.Enabled = True
                    Button45.Enabled = True
                    FileButton.Enabled = True
                    ModificaButton.Enabled = True
                    ProgettoButton.Enabled = True
                    InserisciButton.Enabled = True
                    Button31.Enabled = True
                    Button30.Enabled = True
                    If My.Settings.strumenti = ("SI") Then
                        StrumentiButton.Visible = True
                    Else
                    End If
                End If

            ElseIf result = MsgBoxResult.No Then
                FastColoredTextBox1.Text = (WebBrowser2.DocumentText)
                AnteprimaProgetto.Visible = False
                AnteprimaProgettoBottone.BackColor = Color.DarkRed
                AnteprimaProgettoBottone.Visible = True
                ProgrammazioneProgettoBottone.BackColor = Color.Red
                AnteprimaProgetto.Visible = False
                ProgrammazioneProgettoBottone.BackColor = Color.Red
                AnteprimaProgettoBottone.BackColor = Color.DarkRed
                Button36.Enabled = True
                Button42.Enabled = True
                Button43.Enabled = True
                Button45.Enabled = True
                FileButton.Enabled = True
                ModificaButton.Enabled = True
                ProgettoButton.Enabled = True
                InserisciButton.Enabled = True
                Button31.Enabled = True
                Button30.Enabled = True
                If My.Settings.strumenti = ("SI") Then
                    StrumentiButton.Visible = True
                Else
                End If
            ElseIf result = MsgBoxResult.Cancel Then

            End If
        Else
            FastColoredTextBox1.Text = (WebBrowser2.DocumentText)
            AnteprimaProgetto.Visible = False
            AnteprimaProgettoBottone.BackColor = Color.DarkRed
            AnteprimaProgettoBottone.Visible = True
            ProgrammazioneProgettoBottone.BackColor = Color.Red
            AnteprimaProgetto.Visible = False
            ProgrammazioneProgettoBottone.BackColor = Color.Red
            AnteprimaProgettoBottone.BackColor = Color.DarkRed
            Button36.Enabled = True
            Button42.Enabled = True
            Button43.Enabled = True
            Button45.Enabled = True
            FileButton.Enabled = True
            ModificaButton.Enabled = True
            ProgettoButton.Enabled = True
            InserisciButton.Enabled = True
            Button31.Enabled = True
            Button30.Enabled = True
            If My.Settings.strumenti = ("SI") Then
                StrumentiButton.Visible = True
            Else
            End If
        End If
    End Sub

    Private Sub TitoloProgetto_MouseEnter(sender As Object, e As EventArgs) Handles TitoloProgetto.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub AnteprimaProgetto_MouseEnter(sender As Object, e As EventArgs) Handles AnteprimaProgetto.MouseEnter
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False
    End Sub

    Private Sub ParagrafoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParagrafoToolStripMenuItem.Click
        Paragrafo.Show()
    End Sub

    Private Sub ImmagineToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImmagineToolStripMenuItem1.Click
        Immagine.Show()
    End Sub

    Private Sub TestoPersonalizzatoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestoPersonalizzatoToolStripMenuItem.Click
        TestoPersonalizzato.Show()
    End Sub

    Private Sub CommentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CommentoToolStripMenuItem1.Click
        Commento.Show()
    End Sub

    Private Sub CollegamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CollegamentoToolStripMenuItem1.Click
        Collegamento.Show()
    End Sub

    Private Sub SeparatoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeparatoreToolStripMenuItem.Click
        Separatore.Show()
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        Lista.Show()
    End Sub

    Private Sub TitoloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TitoloToolStripMenuItem.Click
        Titolo.Show()
    End Sub

    Private Sub SottotitoloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SottotitoloToolStripMenuItem.Click
        Sottotitolo.Show()
    End Sub

    Private Sub DescrizioneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescrizioneToolStripMenuItem.Click
        Descrizione.Show()
    End Sub

    Private Sub BottoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BottoneToolStripMenuItem.Click
        Bottone.Show()
    End Sub

    Private Sub CaratteriSpecialiToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CaratteriSpecialiToolStripMenuItem2.Click
        CaratteriSpeciali.Show()
    End Sub

    Private Sub Button36_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button36_Click_2(sender As Object, e As EventArgs) Handles Button36.Click
        Cercaesostituisci.Show()
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click

    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        If TextBox1.Text <> "" Then
            System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
        Else
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                TextBox1.Text = (SaveFileDialog1.FileName)
                Me.Text = (SaveFileDialog1.FileName & " - Minion One")
            End If
        End If
        TextBox88.Text = (FastColoredTextBox1.Text)
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
            Me.Text = (OpenFileDialog1.FileName & " - Minion One")
            TextBox1.Text = (OpenFileDialog1.FileName)
            If Text.Contains(".html") Or Text.Contains(".htm") Then
                TipoDiEditor.Text = ("Editor: HTML")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
            ElseIf Text.Contains(".php") Then
                TipoDiEditor.Text = ("Editor: PHP")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP
            ElseIf Text.Contains(".js") Then
                TipoDiEditor.Text = ("Editor: JS")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
            ElseIf Text.Contains(".txt") Then
                TipoDiEditor.Text = ("Editor: TXT")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
            Else
                TipoDiEditor.Text = ("Editor: N.R.")
                FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
            End If
            FastColoredTextBox1.Text = (testo)
            SaveFileDialog1.FileName = (OpenFileDialog1.FileName)
        End If
        FastColoredTextBox1.Select()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        If FastColoredTextBox1.Text <> "" Then
            Dim result As Integer = MsgBox("Prima di creare un nuovo progetto volete salvare il medesimo?", MsgBoxStyle.YesNoCancel, "Minion One - Avvertimento")
            If result = MsgBoxResult.Yes Then
                If TextBox1.Text = ("") Then
                    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                        TextBox1.Text = (SaveFileDialog1.FileName)
                        FastColoredTextBox1.Clear()
                        Avvio.Show()
                        Avvio.Button6.Text = ("Crea o apri un progetto")
                        TextBox1.Text = ("")
                        SaveFileDialog1.FileName = ("Progetto")
                    End If
                Else
                    System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
                    FastColoredTextBox1.Clear()
                    Avvio.Show()
                    Avvio.Button6.Text = ("Crea o apri un progetto")
                    TextBox1.Text = ("")
                    SaveFileDialog1.FileName = ("Progetto")
                End If

            ElseIf result = MsgBoxResult.No Then
                FastColoredTextBox1.Clear()
                Avvio.Show()
                Avvio.Button6.Text = ("Crea o apri un progetto")
                TextBox1.Text = ("")
                SaveFileDialog1.FileName = ("Progetto")
            ElseIf result = MsgBoxResult.Cancel Then


            End If
        Else
            Avvio.Show()
            Avvio.Button6.Text = ("Crea o apri un progetto")
            TextBox1.Text = ("")
            SaveFileDialog1.FileName = ("Progetto")
        End If
    End Sub

    Private Sub Button38_Click_1(sender As Object, e As EventArgs)
        FastColoredTextBox1.Cut()
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs)
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs)
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs)
        FastColoredTextBox1.ClearSelected()
    End Sub

    Private Sub ButtonImpostazioni_Click(sender As Object, e As EventArgs) Handles ButtonImpostazioni.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        Impostazioni.Show()
    End Sub

    Private Sub Button38_Click_2(sender As Object, e As EventArgs) Handles Button38.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        Novita.Show()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub STAMPAprop_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles STAMPAprop.PrintPage
        e.Graphics.DrawString("-- Realizzato con Minion One by MixiM (versione 3) --", TextBox1.Font, Brushes.DimGray, 120, 40)
        e.Graphics.DrawString(FastColoredTextBox1.Text, FastColoredTextBox1.Font, Brushes.Black, 50, 60)
    End Sub

    Private Sub Button33_Click_3(sender As Object, e As EventArgs) Handles Button33.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        If TextBox2.Text = ("NO") Then
            Button33.Image = My.Resources.si
            TextBox2.Text = ("SI")
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
            Me.TopMost = True
        ElseIf TextBox2.Text = ("SI") Then
            Button33.Image = My.Resources.no
            TextBox2.Text = ("NO")
            Me.TopMost = False
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub TipoDiEditor_Click(sender As Object, e As EventArgs) Handles TipoDiEditor.Click
        Editor.Show()
    End Sub

    Private Sub StrumentiButton_Click(sender As Object, e As EventArgs) Handles StrumentiButton.Click
        If StrumentiPanel.Visible = False Then
            StrumentiPanel.Visible = True
            FileButton.BackColor = Color.DarkRed
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.DarkRed
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.DarkRed
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.DarkRed
            MinionOnePanel.Visible = False
            InserisciButton.BackColor = Color.DarkRed
            InserisciPanel.Visible = False
        Else
            StrumentiPanel.Visible = False
        End If
    End Sub

    Private Sub Button39_Click_1(sender As Object, e As EventArgs) Handles Button39.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        If My.Settings.strumenti = ("NO") Then
            My.Settings.strumenti = ("SI")
            Button39.Image = My.Resources.si
            StrumentiButton.Visible = True
            My.Settings.Save()

            salvaimpostazionitext.Text = salvaimpostazionitext.Text.Replace("[]*]-", "") 'inserire nelle prime virgolette il codice da sostituire
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text)
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text & "g<>b.-") 'inserire nelle virgolette il codice da inserire
        ElseIf My.Settings.strumenti = ("SI") Then
            My.Settings.strumenti = ("NO")
            Button39.Image = My.Resources.no
            StrumentiButton.Visible = False
            StrumentiPanel.Visible = False
            My.Settings.Save()

            salvaimpostazionitext.Text = salvaimpostazionitext.Text.Replace("g<>b.-", "") 'inserire nelle prime virgolette il codice da sostituire
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text)
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", salvaimpostazionitext.Text & "[]*]-") 'inserire nelle virgolette il codice da inserire
        End If
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        StrumentiPanel.Visible = False
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False

        Separatore.Show()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button47.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<b>")
            Button47.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("</b>")
            Button47.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub StrumentiButton_MouseEnter(sender As Object, e As EventArgs) Handles StrumentiButton.MouseEnter
        If My.Settings.barrastrumentiapri = ("passaggio") Then
            If StrumentiPanel.Visible = False Then
                StrumentiPanel.Visible = True
                FileButton.BackColor = Color.DarkRed
                FilePanel.Visible = False
                ModificaButton.BackColor = Color.DarkRed
                ModificaPanel.Visible = False
                ProgettoButton.BackColor = Color.DarkRed
                ProgettoPanel.Visible = False
                MinionOneButton.BackColor = Color.DarkRed
                MinionOnePanel.Visible = False
                InserisciButton.BackColor = Color.DarkRed
                InserisciPanel.Visible = False
            Else
                StrumentiPanel.Visible = False
            End If
        Else
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button46.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<i>")
            Button46.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("</i>")
            Button46.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub Button41_Click_1(sender As Object, e As EventArgs) Handles Button41.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button41.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<u>")
            Button41.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("</u>")
            Button41.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub Button40_Click_1(sender As Object, e As EventArgs) Handles Button40.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button40.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<s>")
            Button40.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("</s>")
            Button40.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        TESTODAINSERIRE.Text = ("<hr/>")
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button50.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<p>")
            Button50.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("</p>")
            Button50.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button51.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<sub>")
            Button51.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("</sub>")
            Button51.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button52.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<sup>")
            Button52.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("</sup>")
            Button52.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        StrumentiPanel.Visible = False
        If Button53.BackColor = Color.WhiteSmoke Then
            CollegamentoBarraStrumenti.Show()
        Else
            TESTOINCOLLATO.Paste()
            TESTODAINSERIRE.Text = ("</a>")
            Button53.BackColor = Color.WhiteSmoke
            TESTODAINSERIRE.SelectAll()
            TESTODAINSERIRE.Copy()
            FastColoredTextBox1.Paste()
            TESTOINCOLLATO.SelectAll()
            TESTOINCOLLATO.Copy()
        End If
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button54.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<big>")
            Button54.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("</big>")
            Button54.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button55.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<small>")
            Button55.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("</small>")
            Button55.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        StrumentiPanel.Visible = False

        TESTOINCOLLATO.Paste()
        If Button56.BackColor = Color.WhiteSmoke Then
            TESTODAINSERIRE.Text = ("<!---")
            Button56.BackColor = Color.Silver
        Else
            TESTODAINSERIRE.Text = ("--->")
            Button56.BackColor = Color.WhiteSmoke
        End If
        TESTODAINSERIRE.SelectAll()
        TESTODAINSERIRE.Copy()
        FastColoredTextBox1.Paste()
        TESTOINCOLLATO.SelectAll()
        TESTOINCOLLATO.Copy()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs)
        FastColoredTextBox1.Text = (My.Settings.ripristinatesto)
    End Sub

    Private Sub Button57_Click_1(sender As Object, e As EventArgs) Handles Button57.Click
        StrumentiPanel.Visible = False
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False

        Paragrafo.Show()
    End Sub

    Private Sub Button34_Click_2(sender As Object, e As EventArgs) Handles Button34.Click
        FileButton.BackColor = Color.DarkRed
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.DarkRed
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.DarkRed
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.DarkRed
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.DarkRed
        InserisciPanel.Visible = False
        StrumentiPanel.Visible = False

        SemplificaMi.Show()
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click

    End Sub

    Private Sub InserisciPanel_Paint(sender As Object, e As PaintEventArgs) Handles InserisciPanel.Paint

    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        Immagine.Show()
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        ImmagineBarraStrumenti.Show()
    End Sub

    Private Sub orawb_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles orawb.DocumentCompleted
        oratb.Text = orawb.DocumentText
    End Sub

    Private Sub datawb_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles datawb.DocumentCompleted
        datatb.Text = datawb.DocumentText
    End Sub

    Private Sub ipwb_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles ipwb.DocumentCompleted
        iptb.Text = ipwb.DocumentText
    End Sub

    Private Sub datatb_TextChanged(sender As Object, e As EventArgs) Handles datatb.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox3.Text = "1" Then
            If My.Computer.Network.IsAvailable Then
                Panel1.BackColor = Color.Yellow
                If iptb.Text <> "" And oratb.Text <> "" And datatb.Text <> "" Then
                    WebBrowser3.Navigate("http://minionone.altervista.org/Software/avvio.php?versione=" & My.Settings.avvioversione & "&tipoversione=" & My.Settings.avviotipoversione & "&ip=" & iptb.Text & "&data=" & datatb.Text & "&ora=" & oratb.Text & "&submit=Invia")
                    Panel1.BackColor = Color.Green
                End If
                TextBox3.Text = "2"
            Else
                Panel1.BackColor = Color.Red
            End If
        End If
    End Sub
End Class

