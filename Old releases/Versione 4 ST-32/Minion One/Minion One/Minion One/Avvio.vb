Public Class Avvio
    Private Sub Avvio_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        recente7butt.Text = ""
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente7.morec", "")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec", "")
    End Sub
    Private Sub Avvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\") Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\")
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\")
        End If
        IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\", IO.FileAttributes.Hidden)
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec") <> "" Then
            recente1butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec")
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec") <> "" Then
            recente2butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec")
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec") <> "" Then
            recente3butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec")
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec") <> "" Then
            recente4butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec")
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec") <> "" Then
            recente5butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec")
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec") <> "" Then
            recente6butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec")
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente7.morec") <> "" Then
            recente7butt.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente7.morec")
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente7.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
        End If
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec") <> "" Then
        Else
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec", "")
        End If
        MinionOneAvvio.Timer1.Start()
        If recente1butt.Text.Contains("ERR.N.S.: ") Then
            recente1butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
            recente2butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
            recente3butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
        End If
        If recente2butt.Text.Contains("ERR.N.S.: ") Then
            recente2butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
            recente3butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
        End If
        If recente3butt.Text.Contains("ERR.N.S.: ") Then
            recente3butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
        End If
        If recente4butt.Text.Contains("ERR.N.S.: ") Then
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
        End If
        If recente5butt.Text.Contains("ERR.N.S.: ") Then
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
        End If
        If recente6butt.Text.Contains("ERR.N.S.: ") Then
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
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

    Private Sub MinionOneButton_Click(sender As Object, e As EventArgs) Handles MinionOneButton.Click
        MinionOneF.FileButton.BackColor = Color.DarkRed
        MinionOneF.FileButton.FlatAppearance.MouseOverBackColor = MinionOneF.buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneF.FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneF.FileButton.ForeColor = Color.WhiteSmoke
        MinionOneF.FilePanel.Visible = False
        MinionOneF.ModificaButton.BackColor = Color.DarkRed
        MinionOneF.ModificaButton.FlatAppearance.MouseOverBackColor = MinionOneF.buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneF.ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneF.ModificaButton.ForeColor = Color.WhiteSmoke
        MinionOneF.ModificaPanel.Visible = False
        MinionOneF.VisualizzaButton.BackColor = Color.DarkRed
        MinionOneF.VisualizzaButton.FlatAppearance.MouseOverBackColor = MinionOneF.buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneF.VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneF.VisualizzaButton.ForeColor = Color.WhiteSmoke
        MinionOneF.VisualizzaPanel.Visible = False
        MinionOneF.InserisciButton.BackColor = Color.DarkRed
        MinionOneF.InserisciButton.FlatAppearance.MouseOverBackColor = MinionOneF.buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneF.InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneF.InserisciButton.ForeColor = Color.WhiteSmoke
        MinionOneF.InserisciPanel.Visible = False
        MinionOneF.MinionOneButton.BackColor = Color.DarkRed
        MinionOneF.MinionOneButton.FlatAppearance.MouseOverBackColor = MinionOneF.buttprogling.FlatAppearance.MouseOverBackColor
        MinionOneF.MinionOneButton.FlatAppearance.MouseDownBackColor = Color.Red
        MinionOneF.MinionOneButton.ForeColor = Color.WhiteSmoke
        MinionOneF.MinionOnePanel.Visible = False
        If MinionOneF.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = MinionOneF.OpenFileDialog1.FileName
            MinionOneF.FastColoredTextBox1.Text = (My.Computer.FileSystem.ReadAllText(testo))
            MinionOneF.Text = (My.Computer.FileSystem.GetName(testo) & " - Minion One")
            MinionOneF.Text = MinionOneF.Text.Replace(".html", "")
            MinionOneF.Button4.Text = (MinionOneF.OpenFileDialog1.FileName)
            MinionOneF.buttprogcss.Text = ("&CSS")
            MinionOneF.buttprogling.Text = ("&HTML")
            MinionOneF.SaveFileDialog1.FileName = (testo)
            If Dir(MinionOneF.Button4.Text.Replace(".html", ".css")) <> "" Then
                MinionOneF.buttprogling.Text = ("&HTML")
                MinionOneF.buttprogling.Enabled = True
                MinionOneF.buttprogcss.Visible = True
                MinionOneF.Button12.Enabled = True
                MinionOneF.CSSSIoNOtb.Text = ("si")
                MinionOneF.ProgettazioneButtonR.Enabled = True
                MinionOneF.AnteprimaButtonR.Enabled = True
                MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                MinionOneF.FastColoredTextBox1.Select()
                MinionOneF.CSSFTB.Text = (System.IO.File.ReadAllText(MinionOneF.Button4.Text.Replace(".html", ".css")))
                MinionOneF.buttprogcss.Text = ("&CSS")
            Else
                MinionOneF.buttprogling.Text = ("&HTML")
                MinionOneF.buttprogling.Enabled = True
                MinionOneF.buttprogcss.Visible = False
                MinionOneF.CSSSIoNOtb.Text = ("no")
                MinionOneF.ProgettazioneButtonR.Enabled = True
                MinionOneF.AnteprimaButtonR.Enabled = True
                MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                MinionOneF.FastColoredTextBox1.Select()
            End If
            MinionOneF.FastColoredTextBox1.Select()
            MinionOneF.FileButton.Enabled = True
            MinionOneF.ModificaButton.Enabled = True
            MinionOneF.VisualizzaButton.Enabled = True
            MinionOneF.InserisciButton.Enabled = True
            MinionOneF.InserisciToolStripMenuItem1.Enabled = True
            MinionOneF.MinionOneButton.Enabled = True
            recente6butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
            recente3butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
            MinionOneF.TitoloProg.Text = (MinionOneF.Text.Replace(" - Minion One", ""))
            recente1butt.Text = (MinionOneF.TitoloProg.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", MinionOneF.TitoloProg.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", MinionOneF.Button4.Text)
            MinionOneF.ultimoProgettoSalvato.Text = (MinionOneF.FastColoredTextBox1.Text)
            MinionOneF.FastColoredTextBox1.Select()
            MinionOneF.FastColoredTextBox1.ClearUndo()
            Me.Close()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'MinionOneF.FileButton.Enabled = True
        'MinionOneF.ModificaButton.Enabled = True
        'MinionOneF.VisualizzaButton.Enabled = True
        'MinionOneF.InserisciButton.Enabled = True
        'MinionOneF.MinionOneButton.Enabled = True
        'MinionOneF.ProgettazioneButtonR.Enabled = True
        'MinionOneF.AnteprimaButtonR.Enabled = True
        'MinionOneF.FastColoredTextBox1.ReadOnly = False
        'MinionOneF.FastColoredTextBox1.Select()
        'MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        'MinionOneF.buttprogling.Text = ("&HTML")
        'MinionOneF.buttprogling.Enabled = True
        'MinionOneF.buttprogcss.Visible = False
        'MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
        'MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
        'MinionOneF.CSSSIoNOtb.Text = ("no")
        ''System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileHtml.mopling", "")

        'recente6butt.Text = (recente5butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", recente6butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec")
        'recente5butt.Text = (recente4butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente5butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec")
        'recente4butt.Text = (recente3butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente4butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec")
        'recente3butt.Text = (recente2butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente3butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec")
        'recente2butt.Text = (recente1butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente2butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")
        'recente1butt.Text = ("Nuovo progetto HTML")
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente1butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", "ERRORE")
        'MinionOneF.Text = (recente1butt.Text & " - Minion One")


        'Me.Close()
        NuovoProgetto.TextBox9.Text = ("Nome progetto")
        NuovoProgetto.TextBox9.ForeColor = Color.DarkGray
        NuovoProgetto.TextBox9.Select()
        NuovoProgetto.ShowDialog()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = False
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP

        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogling.Text = ("PHP")
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.Button12.Enabled = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFilePhp.mopling", "")
        'MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")
        recente1butt.Text = ("Nuovo progetto PHP")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", "ERRORE")
        MinionOneF.Text = (recente1butt.Text & " - Minion One")

        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = False
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS

        MinionOneF.buttprogling.Text = ("JavaScript")
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.Button12.Enabled = False
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileJavaScript.mopling", "")
        'MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")
        recente1butt.Text = ("Nuovo progetto JavaScript")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", "ERRORE")
        MinionOneF.Text = (recente1butt.Text & " - Minion One")

        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = False
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB

        MinionOneF.buttprogling.Text = ("VB.NET")
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.Button12.Enabled = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileVbnet.mopling", "")
        'MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")
        recente1butt.Text = ("Nuovo progetto VB.NET")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", "ERRORE")
        MinionOneF.Text = (recente1butt.Text & " - Minion One")

        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = False
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp

        MinionOneF.buttprogling.Text = ("C#")
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.Button12.Enabled = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = False
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = False
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileC#.mopling", "")
        'MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")
        recente1butt.Text = ("Nuovo progetto C#")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", "ERRORE")
        MinionOneF.Text = (recente1butt.Text & " - Minion One")

        Me.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = True
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom

        MinionOneF.buttprogling.Text = ("N.D.")
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.Button12.Enabled = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
        MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
        'System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileCustom.mopling", "")
        'MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")

        recente6butt.Text = (recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", recente6butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec")
        recente5butt.Text = (recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente5butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec")
        recente4butt.Text = (recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente4butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec")
        recente3butt.Text = (recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente3butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec")
        recente2butt.Text = (recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente2butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")
        recente1butt.Text = ("Nuovo progetto")
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente1butt.Text)
        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", "ERRORE")
        MinionOneF.Text = (recente1butt.Text & " - Minion One")

        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'MinionOneF.FileButton.Enabled = True
        'MinionOneF.ModificaButton.Enabled = True
        'MinionOneF.VisualizzaButton.Enabled = True
        'MinionOneF.InserisciButton.Enabled = True
        'MinionOneF.MinionOneButton.Enabled = True
        'MinionOneF.ProgettazioneButtonR.Enabled = True
        'MinionOneF.AnteprimaButtonR.Enabled = True
        'MinionOneF.FastColoredTextBox1.ReadOnly = False
        'MinionOneF.FastColoredTextBox1.Select()
        'MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        'MinionOneF.CSSSIoNOtb.Text = ("si")

        'MinionOneF.buttprogling.Text = ("&HTML")
        'MinionOneF.buttprogling.Enabled = True
        'MinionOneF.buttprogcss.Visible = True
        'MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem.Enabled = True
        'MinionOneF.VediLanteprimaDelProgettoToolStripMenuItem1.Enabled = True
        ''System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpFileHtml.mopling", "")
        ''System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\BackUpCss.mopcss", "")
        ''MinionOneF.FastColoredTextBox1.Text = ("<html>" & vbNewLine & "<head>" & vbNewLine & vbTab & "<link href=" & Chr(34) & ("file:\\\" & (My.Application.Info.DirectoryPath) & "\Css.css") & Chr(34) & " rel=" & Chr(34) & "stylesheet" & Chr(34) & " type=" & Chr(34) & "text/css" & Chr(34) & ">" & vbNewLine & "</head>" & vbNewLine & "<body>" & vbNewLine & vbNewLine & "</body>" & vbNewLine & "</html>")
        'MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewFile.mopling")
        'MinionOneF.CSSFTB.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\NewCss.mopcss")

        'recente6butt.Text = (recente5butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", recente6butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec")
        'recente5butt.Text = (recente4butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente5butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec")
        'recente4butt.Text = (recente3butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente4butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec")
        'recente3butt.Text = (recente2butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente3butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec")
        'recente2butt.Text = (recente1butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente2butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")
        'recente1butt.Text = ("Nuovo progetto HTML")
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente1butt.Text)
        'System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", "ERRORE")
        'MinionOneF.Text = (recente1butt.Text & " - Minion One")

        'Me.Close()
        NuovoProgettoEFoglioDiStile.TextBox9.Text = ("Nome progetto")
        NuovoProgettoEFoglioDiStile.TextBox9.ForeColor = Color.DarkGray
        NuovoProgettoEFoglioDiStile.TextBox9.Select()
        NuovoProgettoEFoglioDiStile.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub recente1butt_Click(sender As Object, e As EventArgs) Handles recente1butt.Click
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = True
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        MinionOneF.buttprogling.Text = ("&HTML")
        MinionOneF.buttprogling.Visible = True
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.Button12.Enabled = False
        If My.Computer.FileSystem.DirectoryExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")) Then
            MinionOneF.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec") & " - Minion One"
            If My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If Dir(Percorso.Text.Replace(".html", ".css")) <> "" Then
                    MinionOneF.buttprogcss.Visible = True
                    MinionOneF.Button12.Enabled = True
                    MinionOneF.CSSSIoNOtb.Text = ("si")
                    MinionOneF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MinionOneF.Button4.Text = (Percorso.Text)
            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MOE2GBW85N6")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE2GBW85N6")
            MessaggioF.ShowDialog()
            recente1butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
            recente2butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
            recente3butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
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
        MinionOneF.TitoloProg.Text = (MinionOneF.Text.Replace(" - Minion One", ""))
        MinionOneF.buttprogling.Text = "&HTML"
        MinionOneF.buttprogcss.Text = "&CSS"
        MinionOneF.FastColoredTextBox1.ClearUndo()
        MinionOneF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente2butt_Click(sender As Object, e As EventArgs) Handles recente2butt.Click
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = True
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        MinionOneF.buttprogling.Text = ("&HTML")
        MinionOneF.buttprogling.Visible = True
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.Button12.Enabled = False
        If My.Computer.FileSystem.DirectoryExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecentC2.morec")) Then
            MinionOneF.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec") & " - Minion One"
            If My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If Dir(Percorso.Text.Replace(".html", ".css")) <> "" Then
                    MinionOneF.buttprogcss.Visible = True
                    MinionOneF.Button12.Enabled = True
                    MinionOneF.CSSSIoNOtb.Text = ("si")
                    MinionOneF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MinionOneF.Button4.Text = (Percorso.Text)

            recente7butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente7.morec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec"))
            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MOE2GBW85N6")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE2GBW85N6")
            MessaggioF.ShowDialog()
            recente2butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
            recente3butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
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
        MinionOneF.TitoloProg.Text = (MinionOneF.Text.Replace(" - Minion One", ""))
        MinionOneF.buttprogling.Text = "&HTML"
        MinionOneF.buttprogcss.Text = "&CSS"
        MinionOneF.FastColoredTextBox1.ClearUndo()
        MinionOneF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente3butt_Click(sender As Object, e As EventArgs) Handles recente3butt.Click
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = True
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        MinionOneF.buttprogling.Text = ("&HTML")
        MinionOneF.buttprogling.Visible = True
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.Button12.Enabled = False
        If My.Computer.FileSystem.DirectoryExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecentC3.morec")) Then
            MinionOneF.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec") & " - Minion One"
            If My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If Dir(Percorso.Text.Replace(".html", ".css")) <> "" Then
                    MinionOneF.buttprogcss.Visible = True
                    MinionOneF.Button12.Enabled = True
                    MinionOneF.CSSSIoNOtb.Text = ("si")
                    MinionOneF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MinionOneF.Button4.Text = (Percorso.Text)
            recente7butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente7.morec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
            recente3butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec"))
            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MOE2GBW85N6")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE2GBW85N6")
            MessaggioF.ShowDialog()
            recente3butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
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
        MinionOneF.buttprogling.Text = "&HTML"
        MinionOneF.buttprogcss.Text = "&CSS"
        MinionOneF.FastColoredTextBox1.ClearUndo()
        MinionOneF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente4butt_Click(sender As Object, e As EventArgs) Handles recente4butt.Click
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = True
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        MinionOneF.buttprogling.Text = ("&HTML")
        MinionOneF.buttprogling.Visible = True
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.Button12.Enabled = False
        If My.Computer.FileSystem.DirectoryExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecentC4.morec")) Then
            MinionOneF.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec") & " - Minion One"
            If My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If Dir(Percorso.Text.Replace(".html", ".css")) <> "" Then
                    MinionOneF.buttprogcss.Visible = True
                    MinionOneF.Button12.Enabled = True
                    MinionOneF.CSSSIoNOtb.Text = ("si")
                    MinionOneF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MinionOneF.Button4.Text = (Percorso.Text)
            recente7butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente7.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
            recente3butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec"))
            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MOE2GBW85N6")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE2GBW85N6")
            MessaggioF.ShowDialog()
            recente4butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
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
        MinionOneF.buttprogling.Text = "&HTML"
        MinionOneF.buttprogcss.Text = "&CSS"
        MinionOneF.FastColoredTextBox1.ClearUndo()
        MinionOneF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente5butt_Click(sender As Object, e As EventArgs) Handles recente5butt.Click
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = True
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        MinionOneF.buttprogling.Text = ("&HTML")
        MinionOneF.buttprogling.Visible = True
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.Button12.Enabled = False
        If My.Computer.FileSystem.DirectoryExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecentC5.morec")) Then
            MinionOneF.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec") & " - Minion One"
            If My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If Dir(Percorso.Text.Replace(".html", ".css")) <> "" Then
                    MinionOneF.buttprogcss.Visible = True
                    MinionOneF.Button12.Enabled = True
                    MinionOneF.CSSSIoNOtb.Text = ("si")
                    MinionOneF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MinionOneF.Button4.Text = (Percorso.Text)
            recente7butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente7.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
            recente3butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec"))
            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MOE2GBW85N6")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE2GBW85N6")
            MessaggioF.ShowDialog()
            recente5butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
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
        MinionOneF.buttprogling.Text = "&HTML"
        MinionOneF.buttprogcss.Text = "&CSS"
        MinionOneF.FastColoredTextBox1.ClearUndo()
        MinionOneF.CSSFTB.ClearUndo()
    End Sub

    Private Sub recente6butt_Click(sender As Object, e As EventArgs) Handles recente6butt.Click
        MinionOneF.FileButton.Enabled = True
        MinionOneF.ModificaButton.Enabled = True
        MinionOneF.VisualizzaButton.Enabled = True
        MinionOneF.InserisciButton.Enabled = True
        MinionOneF.InserisciToolStripMenuItem1.Enabled = True
        MinionOneF.MinionOneButton.Enabled = True
        MinionOneF.ProgettazioneButtonR.Enabled = True
        MinionOneF.AnteprimaButtonR.Enabled = True
        MinionOneF.FastColoredTextBox1.ReadOnly = False
        MinionOneF.FastColoredTextBox1.Select()
        MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML

        MinionOneF.buttprogling.Text = ("&HTML")
        MinionOneF.buttprogling.Visible = True
        MinionOneF.buttprogling.Enabled = True
        MinionOneF.buttprogcss.Visible = False
        MinionOneF.CSSSIoNOtb.Text = ("no")
        MinionOneF.Button12.Enabled = False
        If My.Computer.FileSystem.DirectoryExists(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecentC6.morec")) Then
            MinionOneF.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec") & " - Minion One"
            If My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec") Then
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
                If Dir(Percorso.Text.Replace(".html", ".css")) <> "" Then
                    MinionOneF.buttprogcss.Visible = True
                    MinionOneF.Button12.Enabled = True
                    MinionOneF.CSSSIoNOtb.Text = ("si")
                    MinionOneF.CSSFTB.Text = System.IO.File.ReadAllText(Percorso.Text.Replace(".html", ".css"))
                End If
            Else
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
                Percorso.Text = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec")
                MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(Percorso.Text)
            End If
            MinionOneF.Button4.Text = (Percorso.Text)
            recente7butt.Text = (recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente7.morec", recente6butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec"))
            recente6butt.Text = (recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", recente5butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec"))
            recente5butt.Text = (recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente5.morec", recente4butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC5.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec"))
            recente4butt.Text = (recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente4.morec", recente3butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC4.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec"))
            recente3butt.Text = (recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente3.morec", recente2butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC3.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec"))
            recente2butt.Text = (recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente2.morec", recente1butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC2.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec"))
            recente1butt.Text = (recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente1.morec", recente7butt.Text)
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC1.morec", System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC7.morec"))
            Me.Close()
        Else
            MessaggioF.Text = ("Errore: File non trovato.")
            MessaggioF.Button1.Text = ("Attenzione:" & vbNewLine & "Il file non è stato trovato." & vbNewLine & "Potrebbe essere stato spostato o eliminato." & vbNewLine & "Codice errore: MOE2GBW85N6")
            MessaggioF.DettagliErroreButton.Visible = True
            MessaggioF.ErroreTxt.Text = ("MOE2GBW85N6")
            MessaggioF.ShowDialog()
            recente6butt.Text = ("")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\Recente6.morec", "")
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Temp\RecenteC6.morec", "")
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
        MinionOneF.buttprogling.Text = "&HTML"
        MinionOneF.buttprogcss.Text = "&CSS"
        MinionOneF.FastColoredTextBox1.ClearUndo()
        MinionOneF.CSSFTB.ClearUndo()
    End Sub

    Private Sub Panel14_Click(sender As Object, e As EventArgs) Handles Panel14.Click
        End
    End Sub

    Private Sub Panel14_Paint(sender As Object, e As PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub recente7butt_Click(sender As Object, e As EventArgs) Handles recente7butt.Click

    End Sub
End Class
