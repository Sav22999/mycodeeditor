Public Class NuovoProgettoEFoglioDiStile

    Private Sub AnteprimaButtonR_Click(sender As Object, e As EventArgs) Handles AnteprimaButtonR.Click
        If ((TextBox9.Text = "Nome progetto" And TextBox9.ForeColor = Color.DarkGray) Or TextBox9.Text.Replace(" ", "") = "") Then
            'TextBox9.BackColor = Color.Red
            Timer1.Start()
        ElseIf TextBox1.Text = "" Then
            Timer2.Start()
        Else
            If Dir(TextBox1.Text) <> "" Then
                If Dir(TextBox1.Text & TextBox9.Text & ".html") = "" And Dir(TextBox1.Text & TextBox9.Text & ".css") = "" Then
                    If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\") = "" Then
                        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\")
                        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\")
                    End If
                    System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", "")
                    System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".css", "")
                    MinionOneF.FileButton.Enabled = True
                    MinionOneF.ModificaButton.Enabled = True
                    MinionOneF.VisualizzaButton.Enabled = True
                    MinionOneF.InserisciButton.Enabled = True
                    MinionOneF.MinionOneButton.Enabled = True
                    MinionOneF.ProgettazioneButtonR.Enabled = True
                    MinionOneF.AnteprimaButtonR.Enabled = True
                    MinionOneF.FastColoredTextBox1.ReadOnly = False
                    MinionOneF.FastColoredTextBox1.Select()
                    MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

                    MinionOneF.buttprogling.Text = ("HTML")
                    MinionOneF.buttprogling.Enabled = True
                    MinionOneF.buttprogcss.Visible = True
                    MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
                    MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
                    MinionOneF.CSSSIoNOtb.Text = ("si")

                    Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente6.morec", Avvio.recente6butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC6.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC5.morec"))
                    Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente5.morec", Avvio.recente5butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC5.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC4.morec"))
                    Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente4.morec", Avvio.recente4butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC4.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC3.morec"))
                    Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente3.morec", Avvio.recente3butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC3.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC2.morec"))
                    Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente2.morec", Avvio.recente2butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC2.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC1.morec"))
                    Avvio.recente1butt.Text = (TextBox9.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente1.morec", Avvio.recente1butt.Text)
                    System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC1.morec", TextBox1.Text & TextBox9.Text & ".html")
                    MinionOneF.Text = (Avvio.recente1butt.Text & " - Minion One")
                    MinionOneF.TitoloProg.Text = (TextBox9.Text)
                    MinionOneF.Button4.Text = (TextBox1.Text & TextBox9.Text & ".html")
                    MinionOneF.FastColoredTextBox1.Text = "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & "type=" & Chr(34) & "text/css" & Chr(34) & "media=" & Chr(34) & "all" & Chr(34) & " href=" & Chr(34) & "file:\\\" & (TextBox1.Text & TextBox9.Text & ".css") & Chr(34) & " />"
                    System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", MinionOneF.FastColoredTextBox1.Text)
                    MinionOneF.buttprogling.Text = ("HTML")
                    MinionOneF.buttprogcss.Text = ("CSS")
                    MinionOneF.Button5.Text = ( Now.Hour & ":" & Now.Minute)
                    Avvio.Close()
                    MinionOneF.FastColoredTextBox1.ClearUndo()
                    Me.Close()
                Else
                    Timer1.Start()
                    MessaggioF.Text = ("Progetto già esistente")
                    MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Esiste già un progetto con lo stesso nome." & vbNewLine & "Cambiare il nome per poterne creare un nuovo.")
                    MessaggioF.ShowDialog()
                End If
            Else
                MessaggioF.Text = ("Percorso di salvataggio inesistente")
                MessaggioF.Button1.Text = ("Attenzione: " & vbNewLine & "Il percorso selezionato è inesistente." & vbNewLine & "Per favore, scegline uno esistente.")
                MessaggioF.ShowDialog()
            End If
        End If
    End Sub

    Private Sub CopiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaToolStripMenuItem.Click
        TextBox1.SelectAll()
        TextBox1.Copy()
    End Sub

    Private Sub IncollaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem1.Click
        TextBox1.SelectAll()
        TextBox1.Paste()
    End Sub

    Private Sub EliminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminaToolStripMenuItem.Click
        TextBox1.SelectAll()
        TextBox1.Clear()
    End Sub

    Private Sub NuovoProgetto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\") = "" Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\")
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\")
        End If
        TextBox1.Text = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\")
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
        If (TextBox9.Text = "Nome progetto" And TextBox9.ForeColor = Color.DarkGray) Then
            TextBox9.ForeColor = Color.DarkRed
            TextBox9.Text = ("")
        End If
    End Sub

    Private Sub TextBox9_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ((TextBox9.Text = "Nome progetto" And TextBox9.ForeColor = Color.DarkGray) Or TextBox9.Text.Replace(" ", "") = "") Then
                'TextBox9.BackColor = Color.Red
                Timer1.Start()
            ElseIf TextBox1.Text = "" Then
                Timer2.Start()
            Else
                If Dir(TextBox1.Text) <> "" Then
                    If Dir(TextBox1.Text & TextBox9.Text & ".html") = "" And Dir(TextBox1.Text & TextBox9.Text & ".css") = "" Then
                        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\") = "" Then
                            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\")
                            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\")
                        End If
                        System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", "")
                        System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".css", "")
                        MinionOneF.FileButton.Enabled = True
                        MinionOneF.ModificaButton.Enabled = True
                        MinionOneF.VisualizzaButton.Enabled = True
                        MinionOneF.InserisciButton.Enabled = True
                        MinionOneF.MinionOneButton.Enabled = True
                        MinionOneF.ProgettazioneButtonR.Enabled = True
                        MinionOneF.AnteprimaButtonR.Enabled = True
                        MinionOneF.FastColoredTextBox1.ReadOnly = False
                        MinionOneF.FastColoredTextBox1.Select()
                        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

                        MinionOneF.buttprogling.Text = ("HTML")
                        MinionOneF.buttprogling.Enabled = True
                        MinionOneF.buttprogcss.Visible = True
                        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
                        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
                        MinionOneF.CSSSIoNOtb.Text = ("si")

                        Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente6.morec", Avvio.recente6butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC6.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC5.morec"))
                        Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente5.morec", Avvio.recente5butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC5.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC4.morec"))
                        Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente4.morec", Avvio.recente4butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC4.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC3.morec"))
                        Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente3.morec", Avvio.recente3butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC3.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC2.morec"))
                        Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente2.morec", Avvio.recente2butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC2.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC1.morec"))
                        Avvio.recente1butt.Text = (TextBox9.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente1.morec", Avvio.recente1butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC1.morec", TextBox1.Text & TextBox9.Text & ".html")
                        MinionOneF.Text = (Avvio.recente1butt.Text & " - Minion One")
                        MinionOneF.TitoloProg.Text = (TextBox9.Text)
                        MinionOneF.Button4.Text = (TextBox1.Text & TextBox9.Text & ".html")
                        MinionOneF.FastColoredTextBox1.Text = "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & "type=" & Chr(34) & "text/css" & Chr(34) & "media=" & Chr(34) & "all" & Chr(34) & " href=" & Chr(34) & "file:\\\" & (TextBox1.Text & TextBox9.Text & ".css") & Chr(34) & " />"
                        System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", MinionOneF.FastColoredTextBox1.Text)
                        MinionOneF.buttprogling.Text = ("HTML")
                        MinionOneF.buttprogcss.Text = ("CSS")
                        MinionOneF.Button5.Text = ( Now.Hour & ":" & Now.Minute)
                        Avvio.Close()

                        Me.Close()
                    Else
                        Timer1.Start()
                        MessaggioF.Text = ("Progetto già esistente")
                        MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Esiste già un progetto con lo stesso nome." & vbNewLine & "Cambiare il nome per poterne creare un nuovo.")
                        MessaggioF.ShowDialog()
                    End If
                Else
                    MessaggioF.Text = ("Percorso di salvataggio inesistente")
                    MessaggioF.Button1.Text = ("Attenzione: " & vbNewLine & "Il percorso selezionato è inesistente." & vbNewLine & "Per favore, scegline uno esistente.")
                    MessaggioF.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        If TextBox9.Text = ("") Or TextBox9.Text.Replace(" ", "") = "" Then
            TextBox9.ForeColor = Color.DarkGray
            TextBox9.Text = ("Nome progetto")
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
            If ((TextBox9.Text = "Nome progetto" And TextBox9.ForeColor = Color.DarkGray) Or TextBox9.Text.Replace(" ", "") = "") Then
                'TextBox9.BackColor = Color.Red
                Timer1.Start()
            ElseIf TextBox1.Text = "" Then
                Timer2.Start()
            Else
                If Dir(TextBox1.Text) <> "" Then
                    If Dir(TextBox1.Text & TextBox9.Text & ".html") = "" And Dir(TextBox1.Text & TextBox9.Text & ".css") = "" Then
                        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\") = "" Then
                            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\")
                            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\")
                        End If
                        System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", "")
                        System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".css", "")
                        MinionOneF.FileButton.Enabled = True
                        MinionOneF.ModificaButton.Enabled = True
                        MinionOneF.VisualizzaButton.Enabled = True
                        MinionOneF.InserisciButton.Enabled = True
                        MinionOneF.MinionOneButton.Enabled = True
                        MinionOneF.ProgettazioneButtonR.Enabled = True
                        MinionOneF.AnteprimaButtonR.Enabled = True
                        MinionOneF.FastColoredTextBox1.ReadOnly = False
                        MinionOneF.FastColoredTextBox1.Select()
                        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

                        MinionOneF.buttprogling.Text = ("HTML")
                        MinionOneF.buttprogling.Enabled = True
                        MinionOneF.buttprogcss.Visible = True
                        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
                        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
                        MinionOneF.CSSSIoNOtb.Text = ("si")

                        Avvio.recente6butt.Text = (Avvio.recente5butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente6.morec", Avvio.recente6butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC6.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC5.morec"))
                        Avvio.recente5butt.Text = (Avvio.recente4butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente5.morec", Avvio.recente5butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC5.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC4.morec"))
                        Avvio.recente4butt.Text = (Avvio.recente3butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente4.morec", Avvio.recente4butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC4.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC3.morec"))
                        Avvio.recente3butt.Text = (Avvio.recente2butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente3.morec", Avvio.recente3butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC3.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC2.morec"))
                        Avvio.recente2butt.Text = (Avvio.recente1butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente2.morec", Avvio.recente2butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC2.morec", System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\RecenteC1.morec"))
                        Avvio.recente1butt.Text = (TextBox9.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Recente1.morec", Avvio.recente1butt.Text)
                        System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\RecenteC1.morec", TextBox1.Text & TextBox9.Text & ".html")
                        MinionOneF.Text = (Avvio.recente1butt.Text & " - Minion One")
                        MinionOneF.TitoloProg.Text = (TextBox9.Text)
                        MinionOneF.Button4.Text = (TextBox1.Text & TextBox9.Text & ".html")
                        MinionOneF.FastColoredTextBox1.Text = "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & "type=" & Chr(34) & "text/css" & Chr(34) & "media=" & Chr(34) & "all" & Chr(34) & " href=" & Chr(34) & "file:\\\" & (TextBox1.Text & TextBox9.Text & ".css") & Chr(34) & " />"
                        System.IO.File.WriteAllText(TextBox1.Text & TextBox9.Text & ".html", MinionOneF.FastColoredTextBox1.Text)
                        MinionOneF.buttprogling.Text = ("HTML")
                        MinionOneF.buttprogcss.Text = ("CSS")
                        MinionOneF.Button5.Text = ( Now.Hour & ":" & Now.Minute)
                        Avvio.Close()

                        Me.Close()
                    Else
                        Timer1.Start()
                        MessaggioF.Text = ("Progetto già esistente")
                        MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Esiste già un progetto con lo stesso nome." & vbNewLine & "Cambiare il nome per poterne creare un nuovo.")
                        MessaggioF.ShowDialog()
                    End If
                Else
                    MessaggioF.Text = ("Percorso di salvataggio inesistente")
                    MessaggioF.Button1.Text = ("Attenzione: " & vbNewLine & "Il percorso selezionato è inesistente." & vbNewLine & "Per favore, scegline uno esistente.")
                    MessaggioF.ShowDialog()
                End If
            End If
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
End Class