Public Class Avvio
    Private Sub Avvio_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        recente7butt.Text = ""
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente7.mcerec", "")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec", "")
    End Sub
    Private Sub Avvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\")
        End If
        IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\", IO.FileAttributes.Hidden)
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec") <> "" Then
            If System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec") <> "" Then
                recente1butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec")
            End If
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec") <> "" Then
            If System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec") <> "" Then
                recente2butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec")
            End If
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec") <> "" Then
            If System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec") <> "" Then
                recente3butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec")
            End If
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec") <> "" Then
            If System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec") <> "" Then
                recente4butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec")
            End If
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec") <> "" Then
            If System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec") <> "" Then
                recente5butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec")
            End If
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6morec") <> "" Then
            If System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec") <> "" Then
                recente6butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec")
            End If
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente7.mcerec") <> "" Then
            recente7butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente7.mcerec")
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente7.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec", "")
        End If
        If recente1butt.Text.Contains("ERR.N.S.: ") Then
            recente1butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            recente2butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            recente3butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
        End If
        If recente2butt.Text.Contains("ERR.N.S.: ") Then
            recente2butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            recente3butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
        End If
        If recente3butt.Text.Contains("ERR.N.S.: ") Then
            recente3butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
        End If
        If recente4butt.Text.Contains("ERR.N.S.: ") Then
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
        End If
        If recente5butt.Text.Contains("ERR.N.S.: ") Then
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
        End If
        If recente6butt.Text.Contains("ERR.N.S.: ") Then
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
        End If
        If recente1butt.Text = ("") Then
            recente1butt.Visible = False
        Else
            recente1butt.Visible = True
        End If
        If recente2butt.Text = ("") Then
            recente2butt.Visible = False
        Else
            recente2butt.Visible = True
        End If
        If recente3butt.Text = ("") Then
            recente3butt.Visible = False
        Else
            recente3butt.Visible = True
        End If
        If recente4butt.Text = ("") Then
            recente4butt.Visible = False
        Else
            recente4butt.Visible = True
        End If
        If recente5butt.Text = ("") Then
            recente5butt.Visible = False
        Else
            recente5butt.Visible = True
        End If
        If recente6butt.Text = ("") Then
            recente6butt.Visible = False
        Else
            recente6butt.Visible = True
        End If
    End Sub

    Private Sub MinionOneButton_Click(sender As Object, e As EventArgs) Handles ApriButton.Click
        MyCEF.apri_func()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'MyCEF.FileButton.Enabled = True
        'MyCEF.ModificaButton.Enabled = True
        'MyCEF.VisualizzaButton.Enabled = True
        'MyCEF.InserisciButton.Enabled = True
        'MyCEF.MinionOneButton.Enabled = True
        'MyCEF.ProgettazioneButtonR.Enabled = True
        'MyCEF.AnteprimaButtonR.Enabled = True
        'MyCEF.FastColoredTextBox1.ReadOnly = False
        'MyCEF.FastColoredTextBox1.Select()
        'MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        'MyCEF.buttprogling.Text = (MyCEF.TraduzioneLinguaTxt.Lines(10))
        'MyCEF.buttprogling.Enabled = True
        'MyCEF.buttprogcss.Visible = False
        'MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
        'MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
        'MyCEF.CSSSIoNOtb.Text = ("no")
        ''System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileHtml.mopling", "")

        'recente6butt.Text = (recente5butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", recente6butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")
        'recente5butt.Text = (recente4butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente5butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")
        'recente4butt.Text = (recente3butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente4butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")
        'recente3butt.Text = (recente2butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente3butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")
        'recente2butt.Text = (recente1butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente2butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")
        'recente1butt.Text = ("Nuovo progetto HTML")
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente1butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", "ERRORE")
        'MyCEF.Text = (recente1butt.Text & " - My Code Editor")


        'Me.Close()
        NuovoProgetto.Dispose()
        NuovoProgetto.TextBox9.Text = MyCEF.TraduzioneLinguaTxt.Lines(502)
        NuovoProgetto.TextBox1.Text = MyCEF.TraduzioneLinguaTxt.Lines(576)
        NuovoProgetto.TextBox9.ForeColor = Color.DarkGray
        NuovoProgetto.TextBox9.Select()
        NuovoProgetto.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        MyCEF.FileButton.Enabled = True
        MyCEF.ModificaButton.Enabled = True
        MyCEF.VisualizzaButton.Enabled = True
        MyCEF.InserisciButton.Enabled = True
        MyCEF.InserisciToolStripMenuItem1.Enabled = True
        MyCEF.MCEButton.Enabled = True
        MyCEF.ProgettazioneButtonR.Enabled = True
        MyCEF.AnteprimaButtonR.Enabled = False
        MyCEF.FastColoredTextBox1.ReadOnly = False
        MyCEF.FastColoredTextBox1.Select()
        MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP

        MyCEF.buttproghtml.Enabled = True
        MyCEF.buttproghtml.Text = ("PHP")
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFilePhp.mopling", "")
        'MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")
        recente1butt.Text = ("Nuovo progetto PHP")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", "ERRORE")
        MyCEF.Text = (recente1butt.Text & " - My Code Editor")

        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        MyCEF.FileButton.Enabled = True
        MyCEF.ModificaButton.Enabled = True
        MyCEF.VisualizzaButton.Enabled = True
        MyCEF.InserisciButton.Enabled = True
        MyCEF.InserisciToolStripMenuItem1.Enabled = True
        MyCEF.MCEButton.Enabled = True
        MyCEF.ProgettazioneButtonR.Enabled = True
        MyCEF.AnteprimaButtonR.Enabled = False
        MyCEF.FastColoredTextBox1.ReadOnly = False
        MyCEF.FastColoredTextBox1.Select()
        MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS

        MyCEF.buttproghtml.Text = ("JavaScript")
        MyCEF.buttproghtml.Enabled = True
        MyCEF.buttprogcss.Visible = False
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileJavaScript.mopling", "")
        'MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")
        recente1butt.Text = ("Nuovo progetto JavaScript")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", "ERRORE")
        MyCEF.Text = (recente1butt.Text & " - My Code Editor")

        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        MyCEF.FileButton.Enabled = True
        MyCEF.ModificaButton.Enabled = True
        MyCEF.VisualizzaButton.Enabled = True
        MyCEF.InserisciButton.Enabled = True
        MyCEF.InserisciToolStripMenuItem1.Enabled = True
        MyCEF.MCEButton.Enabled = True
        MyCEF.ProgettazioneButtonR.Enabled = True
        MyCEF.AnteprimaButtonR.Enabled = False
        MyCEF.FastColoredTextBox1.ReadOnly = False
        MyCEF.FastColoredTextBox1.Select()
        MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB

        MyCEF.buttproghtml.Text = ("VB.NET")
        MyCEF.buttproghtml.Enabled = True
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileVbnet.mopling", "")
        'MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")
        recente1butt.Text = ("Nuovo progetto VB.NET")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", "ERRORE")
        MyCEF.Text = (recente1butt.Text & " - My Code Editor")

        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        MyCEF.FileButton.Enabled = True
        MyCEF.ModificaButton.Enabled = True
        MyCEF.VisualizzaButton.Enabled = True
        MyCEF.InserisciButton.Enabled = True
        MyCEF.InserisciToolStripMenuItem1.Enabled = True
        MyCEF.MCEButton.Enabled = True
        MyCEF.ProgettazioneButtonR.Enabled = True
        MyCEF.AnteprimaButtonR.Enabled = False
        MyCEF.FastColoredTextBox1.ReadOnly = False
        MyCEF.FastColoredTextBox1.Select()
        MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp

        MyCEF.buttproghtml.Text = ("C#")
        MyCEF.buttproghtml.Enabled = True
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileC#.mopling", "")
        'MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")
        recente1butt.Text = ("Nuovo progetto C#")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", "ERRORE")
        MyCEF.Text = (recente1butt.Text & " - My Code Editor")

        Me.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
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
        MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom

        MyCEF.buttproghtml.Text = ("N.D.")
        MyCEF.buttproghtml.Enabled = True
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
        MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileCustom.mopling", "")
        'MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")
        recente1butt.Text = ("Nuovo progetto")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", "ERRORE")
        MyCEF.Text = (recente1butt.Text & " - My Code Editor")

        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'MyCEF.FileButton.Enabled = True
        'MyCEF.ModificaButton.Enabled = True
        'MyCEF.VisualizzaButton.Enabled = True
        'MyCEF.InserisciButton.Enabled = True
        'MyCEF.MinionOneButton.Enabled = True
        'MyCEF.ProgettazioneButtonR.Enabled = True
        'MyCEF.AnteprimaButtonR.Enabled = True
        'MyCEF.FastColoredTextBox1.ReadOnly = False
        'MyCEF.FastColoredTextBox1.Select()
        'MyCEF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        'MyCEF.CSSSIoNOtb.Text = ("si")

        'MyCEF.buttprogling.Text = (MyCEF.TraduzioneLinguaTxt.Lines(10))
        'MyCEF.buttprogling.Enabled = True
        'MyCEF.buttprogcss.Visible = True
        'MyCEF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
        'MyCEF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
        ''System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileHtml.mopling", "")
        ''System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpCss.mopcss", "")
        ''MyCEF.FastColoredTextBox1.Text = ("<html>" & vbNewLine & "<head>" & vbNewLine & vbTab & "<link href=" & Chr(34) & ("file:\\\" & (My.Application.Info.DirectoryPath) & "\Css.css") & Chr(34) & " rel=" & Chr(34) & "stylesheet" & Chr(34) & " type=" & Chr(34) & "text/css" & Chr(34) & ">" & vbNewLine & "</head>" & vbNewLine & "<body>" & vbNewLine & vbNewLine & "</body>" & vbNewLine & "</html>")
        'MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")
        'MyCEF.CSSFTB.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewCss.mopcss")

        'recente6butt.Text = (recente5butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", recente6butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")
        'recente5butt.Text = (recente4butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente5butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")
        'recente4butt.Text = (recente3butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente4butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")
        'recente3butt.Text = (recente2butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente3butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")
        'recente2butt.Text = (recente1butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente2butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")
        'recente1butt.Text = ("Nuovo progetto HTML")
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente1butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", "ERRORE")
        'MyCEF.Text = (recente1butt.Text & " - My Code Editor")

        'Me.Close()
        NuovoProgettoEFoglioDiStile.Dispose()
        NuovoProgettoEFoglioDiStile.TextBox9.Text = MyCEF.TraduzioneLinguaTxt.Lines(510)
        NuovoProgettoEFoglioDiStile.TextBox1.Text = MyCEF.TraduzioneLinguaTxt.Lines(777)
        NuovoProgettoEFoglioDiStile.TextBox9.ForeColor = Color.DarkGray
        NuovoProgettoEFoglioDiStile.TextBox9.Select()
        NuovoProgettoEFoglioDiStile.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub recente1butt_Click(sender As Object, e As EventArgs) Handles recente1butt.Click
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
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec") And My.Computer.FileSystem.FileExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")) And My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec") And My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
            MyCEF.TitoloProg.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec")
            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If My.Computer.FileSystem.FileExists(Percorso.Text.Replace(".html", ".css")) Then
                    MyCEF.buttprogcss.Visible = True
                    MyCEF.CSSSIoNOtb.Text = ("si")
                    MyCEF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MyCEF.Text = MyCEF.TitoloProg.Text & " • My Code Editor"
            MyCEF.PercorsoFileHTML = (Percorso.Text)
            MyCEF.PercorsoFileCSS = Percorso.Text.Replace(".html", ".css")
            MyCEF.percorsoSALVATAGGIO.Text = Percorso.Text.Replace(MyCEF.TitoloProg.Text & ".html", "")
            MyCEF.PercorsoFileButton.Text = MyCEF.percorsoSALVATAGGIO.Text

            MyCEF.verifica_percorso()

            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MCEEAA0003")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0003")
            MessaggioF.ShowDialog()
            Try
                recente1butt.Text = (recente2butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente2butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente2butt.Text = (recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente3butt.Text = (recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente4butt.Text = (recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente5butt.Text = (recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente6butt.Text = ("")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
            Catch ex As Exception
            End Try

            If recente1butt.Text = ("") Then
                recente1butt.Visible = False
            Else
                recente1butt.Visible = True
            End If
            If recente2butt.Text = ("") Then
                recente2butt.Visible = False
            Else
                recente2butt.Visible = True
            End If
            If recente3butt.Text = ("") Then
                recente3butt.Visible = False
            Else
                recente3butt.Visible = True
            End If
            If recente4butt.Text = ("") Then
                recente4butt.Visible = False
            Else
                recente4butt.Visible = True
            End If
            If recente5butt.Text = ("") Then
                recente5butt.Visible = False
            Else
                recente5butt.Visible = True
            End If
            If recente6butt.Text = ("") Then
                recente6butt.Visible = False
            Else
                recente6butt.Visible = True
            End If
        End If
        MyCEF.buttproghtml.Text = MyCEF.TraduzioneLinguaTxt.Lines(10)
        MyCEF.buttprogcss.Text = MyCEF.TraduzioneLinguaTxt.Lines(11)
        MyCEF.FastColoredTextBox1.ClearUndo()
        MyCEF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente2butt_Click(sender As Object, e As EventArgs) Handles recente2butt.Click
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
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec") And My.Computer.FileSystem.FileExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")) And My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec") And My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
            MyCEF.TitoloProg.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec")
            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If My.Computer.FileSystem.FileExists(Percorso.Text.Replace(".html", ".css")) Then
                    MyCEF.buttprogcss.Visible = True
                    MyCEF.CSSSIoNOtb.Text = ("si")
                    MyCEF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MyCEF.Text = MyCEF.TitoloProg.Text & " • My Code Editor"
            MyCEF.PercorsoFileHTML = (Percorso.Text)
            MyCEF.PercorsoFileCSS = Percorso.Text.Replace(".html", ".css")
            MyCEF.percorsoSALVATAGGIO.Text = Percorso.Text.Replace(MyCEF.TitoloProg.Text & ".html", "")
            MyCEF.PercorsoFileButton.Text = MyCEF.percorsoSALVATAGGIO.Text
            recente7butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente7.mcerec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec"))

            MyCEF.verifica_percorso()

            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MCEEAA0003")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0003")
            MessaggioF.ShowDialog()
            Try
                recente2butt.Text = (recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente3butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente3butt.Text = (recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente4butt.Text = (recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente5butt.Text = (recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente6butt.Text = ("")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
            Catch ex As Exception
            End Try

            If recente1butt.Text = ("") Then
                recente1butt.Visible = False
            Else
                recente1butt.Visible = True
            End If
            If recente2butt.Text = ("") Then
                recente2butt.Visible = False
            Else
                recente2butt.Visible = True
            End If
            If recente3butt.Text = ("") Then
                recente3butt.Visible = False
            Else
                recente3butt.Visible = True
            End If
            If recente4butt.Text = ("") Then
                recente4butt.Visible = False
            Else
                recente4butt.Visible = True
            End If
            If recente5butt.Text = ("") Then
                recente5butt.Visible = False
            Else
                recente5butt.Visible = True
            End If
            If recente6butt.Text = ("") Then
                recente6butt.Visible = False
            Else
                recente6butt.Visible = True
            End If
        End If
        MyCEF.buttproghtml.Text = MyCEF.TraduzioneLinguaTxt.Lines(10)
        MyCEF.buttprogcss.Text = MyCEF.TraduzioneLinguaTxt.Lines(11)
        MyCEF.FastColoredTextBox1.ClearUndo()
        MyCEF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente3butt_Click(sender As Object, e As EventArgs) Handles recente3butt.Click
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
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec") And My.Computer.FileSystem.FileExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")) And My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec") And My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
            MyCEF.TitoloProg.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec")
            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If My.Computer.FileSystem.FileExists(Percorso.Text.Replace(".html", ".css")) Then
                    MyCEF.buttprogcss.Visible = True
                    MyCEF.CSSSIoNOtb.Text = ("si")
                    MyCEF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MyCEF.Text = MyCEF.TitoloProg.Text & " • My Code Editor"
            MyCEF.PercorsoFileHTML = (Percorso.Text)
            MyCEF.PercorsoFileCSS = Percorso.Text.Replace(".html", ".css")
            MyCEF.percorsoSALVATAGGIO.Text = Percorso.Text.Replace(MyCEF.TitoloProg.Text & ".html", "")
            MyCEF.PercorsoFileButton.Text = MyCEF.percorsoSALVATAGGIO.Text
            recente7butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente7.mcerec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            recente3butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec"))

            MyCEF.verifica_percorso()

            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MCEEAA0003")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0003")
            MessaggioF.ShowDialog()
            Try
                recente3butt.Text = (recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente4butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente4butt.Text = (recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente5butt.Text = (recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente6butt.Text = ("")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
            Catch ex As Exception
            End Try

            If recente1butt.Text = ("") Then
                recente1butt.Visible = False
            Else
                recente1butt.Visible = True
            End If
            If recente2butt.Text = ("") Then
                recente2butt.Visible = False
            Else
                recente2butt.Visible = True
            End If
            If recente3butt.Text = ("") Then
                recente3butt.Visible = False
            Else
                recente3butt.Visible = True
            End If
            If recente4butt.Text = ("") Then
                recente4butt.Visible = False
            Else
                recente4butt.Visible = True
            End If
            If recente5butt.Text = ("") Then
                recente5butt.Visible = False
            Else
                recente5butt.Visible = True
            End If
            If recente6butt.Text = ("") Then
                recente6butt.Visible = False
            Else
                recente6butt.Visible = True
            End If
        End If
        MyCEF.buttproghtml.Text = MyCEF.TraduzioneLinguaTxt.Lines(10)
        MyCEF.buttprogcss.Text = MyCEF.TraduzioneLinguaTxt.Lines(11)
        MyCEF.FastColoredTextBox1.ClearUndo()
        MyCEF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente4butt_Click(sender As Object, e As EventArgs) Handles recente4butt.Click
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
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec") And My.Computer.FileSystem.FileExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")) And My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec") And My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
            MyCEF.TitoloProg.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec")
            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If My.Computer.FileSystem.FileExists(Percorso.Text.Replace(".html", ".css")) Then
                    MyCEF.buttprogcss.Visible = True
                    MyCEF.CSSSIoNOtb.Text = ("si")
                    MyCEF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MyCEF.Text = MyCEF.TitoloProg.Text & " • My Code Editor"
            MyCEF.PercorsoFileHTML = (Percorso.Text)
            MyCEF.PercorsoFileCSS = Percorso.Text.Replace(".html", ".css")
            MyCEF.percorsoSALVATAGGIO.Text = Percorso.Text.Replace(MyCEF.TitoloProg.Text & ".html", "")
            MyCEF.PercorsoFileButton.Text = MyCEF.percorsoSALVATAGGIO.Text
            recente7butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente7.mcerec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            recente4butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            recente3butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec"))


            MyCEF.verifica_percorso()

            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MCEEAA003")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0003")
            MessaggioF.ShowDialog()
            Try
                recente4butt.Text = (recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente5butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente5butt.Text = (recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente6butt.Text = ("")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
            Catch ex As Exception
            End Try

            If recente1butt.Text = ("") Then
                recente1butt.Visible = False
            Else
                recente1butt.Visible = True
            End If
            If recente2butt.Text = ("") Then
                recente2butt.Visible = False
            Else
                recente2butt.Visible = True
            End If
            If recente3butt.Text = ("") Then
                recente3butt.Visible = False
            Else
                recente3butt.Visible = True
            End If
            If recente4butt.Text = ("") Then
                recente4butt.Visible = False
            Else
                recente4butt.Visible = True
            End If
            If recente5butt.Text = ("") Then
                recente5butt.Visible = False
            Else
                recente5butt.Visible = True
            End If
            If recente6butt.Text = ("") Then
                recente6butt.Visible = False
            Else
                recente6butt.Visible = True
            End If
        End If
        MyCEF.buttproghtml.Text = MyCEF.TraduzioneLinguaTxt.Lines(10)
        MyCEF.buttprogcss.Text = MyCEF.TraduzioneLinguaTxt.Lines(11)
        MyCEF.FastColoredTextBox1.ClearUndo()
        MyCEF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente5butt_Click(sender As Object, e As EventArgs) Handles recente5butt.Click
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
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec") And My.Computer.FileSystem.FileExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")) And My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec") And My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
            MyCEF.TitoloProg.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec")
            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If My.Computer.FileSystem.FileExists(Percorso.Text.Replace(".html", ".css")) Then
                    MyCEF.buttprogcss.Visible = True
                    MyCEF.CSSSIoNOtb.Text = ("si")
                    MyCEF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MyCEF.Text = MyCEF.TitoloProg.Text & " • My Code Editor"
            MyCEF.PercorsoFileHTML = (Percorso.Text)
            MyCEF.PercorsoFileCSS = Percorso.Text.Replace(".html", ".css")
            MyCEF.percorsoSALVATAGGIO.Text = Percorso.Text.Replace(MyCEF.TitoloProg.Text & ".html", "")
            MyCEF.PercorsoFileButton.Text = MyCEF.percorsoSALVATAGGIO.Text
            recente7butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente7.mcerec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            recente5butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            recente4butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            recente3butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec"))


            MyCEF.verifica_percorso()

            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MCEEAA0003")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0003")
            MessaggioF.ShowDialog()
            Try
                recente5butt.Text = (recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente6butt.Text = ("")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
            Catch ex As Exception
            End Try

            If recente1butt.Text = ("") Then
                recente1butt.Visible = False
            Else
                recente1butt.Visible = True
            End If
            If recente2butt.Text = ("") Then
                recente2butt.Visible = False
            Else
                recente2butt.Visible = True
            End If
            If recente3butt.Text = ("") Then
                recente3butt.Visible = False
            Else
                recente3butt.Visible = True
            End If
            If recente4butt.Text = ("") Then
                recente4butt.Visible = False
            Else
                recente4butt.Visible = True
            End If
            If recente5butt.Text = ("") Then
                recente5butt.Visible = False
            Else
                recente5butt.Visible = True
            End If
            If recente6butt.Text = ("") Then
                recente6butt.Visible = False
            Else
                recente6butt.Visible = True
            End If
        End If
        MyCEF.buttproghtml.Text = MyCEF.TraduzioneLinguaTxt.Lines(10)
        MyCEF.buttprogcss.Text = MyCEF.TraduzioneLinguaTxt.Lines(11)
        MyCEF.FastColoredTextBox1.ClearUndo()
        MyCEF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente6butt_Click(sender As Object, e As EventArgs) Handles recente6butt.Click
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
        MyCEF.buttprogcss.Visible = False
        MyCEF.CSSSIoNOtb.Text = ("no")
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec") And My.Computer.FileSystem.FileExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec")) And My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec") And My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
            MyCEF.TitoloProg.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec")
            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If My.Computer.FileSystem.FileExists(Percorso.Text.Replace(".html", ".css")) Then
                    MyCEF.buttprogcss.Visible = True
                    MyCEF.CSSSIoNOtb.Text = ("si")
                    MyCEF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec")
                MyCEF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MyCEF.Text = MyCEF.TitoloProg.Text & " • My Code Editor"
            MyCEF.PercorsoFileHTML = (Percorso.Text)
            MyCEF.PercorsoFileCSS = Percorso.Text.Replace(".html", ".css")
            MyCEF.percorsoSALVATAGGIO.Text = Percorso.Text.Replace(MyCEF.TitoloProg.Text & ".html", "")
            MyCEF.PercorsoFileButton.Text = MyCEF.percorsoSALVATAGGIO.Text
            recente7butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente7.mcerec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            recente6butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec"))
            recente5butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec"))
            recente4butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente4.mcerec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC4.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec"))
            recente3butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente3.mcerec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC3.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente2.mcerec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC2.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente1.mcerec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC1.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC7.mcerec"))


            MyCEF.verifica_percorso()

            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MCEEAA0003")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MCEEAA0003")
            MessaggioF.ShowDialog()
            Try
                recente5butt.Text = (recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente5.mcerec", recente6butt.Text)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC5.mcerec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec"))
            Catch ex As Exception
            End Try
            Try
                recente6butt.Text = ("")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Recente6.mcerec", "")
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\RecenteC6.mcerec", "")
            Catch ex As Exception
            End Try

            If recente1butt.Text = ("") Then
                recente1butt.Visible = False
            Else
                recente1butt.Visible = True
            End If
            If recente2butt.Text = ("") Then
                recente2butt.Visible = False
            Else
                recente2butt.Visible = True
            End If
            If recente3butt.Text = ("") Then
                recente3butt.Visible = False
            Else
                recente3butt.Visible = True
            End If
            If recente4butt.Text = ("") Then
                recente4butt.Visible = False
            Else
                recente4butt.Visible = True
            End If
            If recente5butt.Text = ("") Then
                recente5butt.Visible = False
            Else
                recente5butt.Visible = True
            End If
            If recente6butt.Text = ("") Then
                recente6butt.Visible = False
            Else
                recente6butt.Visible = True
            End If
        End If
        MyCEF.buttproghtml.Text = MyCEF.TraduzioneLinguaTxt.Lines(10)
        MyCEF.buttprogcss.Text = MyCEF.TraduzioneLinguaTxt.Lines(11)
        MyCEF.FastColoredTextBox1.ClearUndo()
        MyCEF.CSSFTB.ClearUndo()
    End Sub

    Private Sub Panel14_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub recente7butt_Click(sender As Object, e As EventArgs) Handles recente7butt.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
