
Public Class MinionOne
    Dim num_lung As Long

    Private IsFormBeingDragged As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FastColoredTextBox1_ForeColorChanged(sender As Object, e As EventArgs) Handles FastColoredTextBox1.ForeColorChanged

    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.Load
        
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles FileButton.Click
        If FilePanel.Visible = False Then
            FileButton.BackColor = Color.Blue
            FilePanel.Visible = True
            ModificaButton.BackColor = Color.Navy
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.Navy
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.Navy
            MinionOnePanel.Visible = False
            InserisciButton.BackColor = Color.Navy
            InserisciPanel.Visible = False
        Else
            FileButton.BackColor = Color.Navy
            FilePanel.Visible = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Avvio.Show()
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
            ProgrammazioneProgettoBottone.BackColor = Color.Blue
            AnteprimaProgettoBottone.BackColor = Color.Navy
            My.Settings.Save()
        ElseIf My.Settings.anteprimaprogetto = ("SI") Then
            Button35.Image = My.Resources.si
            AnteprimaProgettoBottone.Visible = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ModificaButton_Click(sender As Object, e As EventArgs) Handles ModificaButton.Click
        If ModificaPanel.Visible = False Then
            ModificaButton.BackColor = Color.Blue
            ModificaPanel.Visible = True
            FileButton.BackColor = Color.Navy
            FilePanel.Visible = False
            ProgettoButton.BackColor = Color.Navy
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.Navy
            MinionOnePanel.Visible = False
            InserisciButton.BackColor = Color.Navy
            InserisciPanel.Visible = False
        Else
            ModificaButton.BackColor = Color.Navy
            ModificaPanel.Visible = False
        End If
    End Sub

    Private Sub ProgettoButton_Click(sender As Object, e As EventArgs) Handles ProgettoButton.Click
        If ProgettoPanel.Visible = False Then
            ProgettoButton.BackColor = Color.Blue
            ProgettoPanel.Visible = True
            FileButton.BackColor = Color.Navy
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.Navy
            ModificaPanel.Visible = False
            MinionOneButton.BackColor = Color.Navy
            MinionOnePanel.Visible = False
            InserisciButton.BackColor = Color.Navy
            InserisciPanel.Visible = False
        Else
            ProgettoButton.BackColor = Color.Navy
            ProgettoPanel.Visible = False
        End If
    End Sub

    Private Sub InserisciButton_Click(sender As Object, e As EventArgs) Handles InserisciButton.Click
        If InserisciPanel.Visible = False Then
            InserisciButton.BackColor = Color.Blue
            InserisciPanel.Visible = True
            FileButton.BackColor = Color.Navy
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.Navy
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.Navy
            ProgettoPanel.Visible = False
            MinionOneButton.BackColor = Color.Navy
            MinionOnePanel.Visible = False
        Else
            InserisciButton.BackColor = Color.Navy
            InserisciPanel.Visible = False
        End If
    End Sub

    Private Sub MinionOneButton_Click(sender As Object, e As EventArgs) Handles MinionOneButton.Click
        If MinionOnePanel.Visible = False Then
            MinionOneButton.BackColor = Color.Blue
            MinionOnePanel.Visible = True
            FileButton.BackColor = Color.Navy
            FilePanel.Visible = False
            ModificaButton.BackColor = Color.Navy
            ModificaPanel.Visible = False
            ProgettoButton.BackColor = Color.Navy
            ProgettoPanel.Visible = False
            InserisciButton.BackColor = Color.Navy
            InserisciPanel.Visible = False
        Else
            MinionOneButton.BackColor = Color.Navy
            MinionOnePanel.Visible = False
        End If
    End Sub

    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub FastColoredTextBox1_MouseEnter(sender As Object, e As EventArgs) Handles FastColoredTextBox1.MouseEnter
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        Dim NuovoProgettoNuovaFinestra As New MinionOne
        NuovoProgettoNuovaFinestra.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

        End
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        WebBrowser1.ShowPageSetupDialog()
    End Sub

    Private Sub FastColoredTextBox1_TextChanged(sender As Object, e As FastColoredTextBoxNS.TextChangedEventArgs) Handles FastColoredTextBox1.TextChanged
        WebBrowser1.DocumentText = (FastColoredTextBox1.Text)
        WebBrowser2.DocumentText = (FastColoredTextBox1.Text)
        num_lung = Len(FastColoredTextBox1.Text)
        Button37.Text = (num_lung)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        WebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        WebBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

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
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
            FastColoredTextBox1.Text = (testo)
            Me.Text = (OpenFileDialog1.FileName & " - Minion One")
            TextBox1.Text = (OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
            TextBox1.Text = (SaveFileDialog1.FileName)
            Me.Text = (SaveFileDialog1.FileName & " - Minion One")
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        If TextBox1.Text <> "" Then
            System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
        Else
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
                TextBox1.Text = (SaveFileDialog1.FileName)
                Me.Text = (SaveFileDialog1.FileName & " - Minion One")
            End If
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        FastColoredTextBox1.Undo()
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        FastColoredTextBox1.Redo()
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        FastColoredTextBox1.Cut()
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        FastColoredTextBox1.Copy()
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        FastColoredTextBox1.Paste()
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        FastColoredTextBox1.ClearSelected()
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        FastColoredTextBox1.SelectAll()
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        FastColoredTextBox1.SelectAll()
        FastColoredTextBox1.Copy()
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Paragrafo.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        CaratteriSpeciali.Show()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        If My.Settings.anteprimaprogetto = ("NO") Then
            My.Settings.anteprimaprogetto = ("SI")
            Button35.Image = My.Resources.si
            AnteprimaProgettoBottone.Visible = True
            My.Settings.Save()
        ElseIf My.Settings.anteprimaprogetto = ("SI") Then
            My.Settings.anteprimaprogetto = ("NO")
            Button35.Image = My.Resources.no
            AnteprimaProgettoBottone.Visible = False
            AnteprimaProgetto.Visible = False
            ProgrammazioneProgettoBottone.BackColor = Color.Blue
            AnteprimaProgettoBottone.BackColor = Color.Navy
            My.Settings.Save()
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
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        FastColoredTextBox1.Text = (FastColoredTextBox1.Text & Environment.NewLine & "<?php" & Environment.NewLine & Environment.NewLine & "?>")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Separatore.Show()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False


    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs)
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False


    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        TestoPersonalizzato.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Immagine.Show()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FastColoredTextBox1_TextChanging(sender As Object, e As FastColoredTextBoxNS.TextChangingEventArgs) Handles FastColoredTextBox1.TextChanging

    End Sub

    Private Sub AnteprimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnteprimaToolStripMenuItem.Click

    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        If My.Settings.acapoautomatico = ("NO") Then
            My.Settings.acapoautomatico = ("SI")
            Button15.Image = My.Resources.si
            FastColoredTextBox1.WordWrap = True
            My.Settings.Save()
        ElseIf My.Settings.acapoautomatico = ("SI") Then
            My.Settings.acapoautomatico = ("NO")
            Button15.Image = My.Resources.no
            FastColoredTextBox1.WordWrap = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

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
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Info.Close()
        Info.Show()
    End Sub

    Private Sub Button17_Click_2(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Commento.Show()
    End Sub

    Private Sub Button31_Click_1(sender As Object, e As EventArgs) Handles AnteprimaProgettoBottone.Click
        AnteprimaProgetto.Visible = True
        ProgrammazioneProgettoBottone.BackColor = Color.Navy
        AnteprimaProgettoBottone.BackColor = Color.Blue
    End Sub

    Private Sub ProgrammazioneProgettoBottone_Click(sender As Object, e As EventArgs) Handles ProgrammazioneProgettoBottone.Click
        AnteprimaProgetto.Visible = False
        ProgrammazioneProgettoBottone.BackColor = Color.Blue
        AnteprimaProgettoBottone.BackColor = Color.Navy
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
            If TitoloProgetto.Width > "608" Then
                TitoloProgetto.Text = ("Errore: Titolo troppo lungo")
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("39")
                    temp.X = ("608")
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

    Private Sub Button30_Click(sender As Object, e As EventArgs)
        MinionOneAvvio.Show()
    End Sub

    Private Sub Button30_Click_1(sender As Object, e As EventArgs) Handles Button30.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub Button31_Click_2(sender As Object, e As EventArgs) Handles Button31.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub Button33_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Collegamento.Show()
    End Sub

    Private Sub Button8_Click_2(sender As Object, e As EventArgs) Handles Button8.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Lista.Show()
    End Sub

    Private Sub Button17_Click_3(sender As Object, e As EventArgs) Handles Button17.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Titolo.Show()
    End Sub

    Private Sub Button28_Click_1(sender As Object, e As EventArgs) Handles Button28.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Sottotitolo.Show()
    End Sub

    Private Sub Button29_Click_1(sender As Object, e As EventArgs) Handles Button29.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Descrizione.Show()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False

        Bottone.Show()
    End Sub

    Private Sub Button33_Click_2(sender As Object, e As EventArgs) Handles Button33.Click
        If WebBrowser2.CanGoBack Then
            WebBrowser2.GoBack()
        Else
            WebBrowser2.DocumentText = (FastColoredTextBox1.Text)
        End If
    End Sub

    Private Sub Button34_Click_1(sender As Object, e As EventArgs) Handles Button34.Click
        WebBrowser2.GoForward()
    End Sub

    Private Sub Button33_MouseEnter(sender As Object, e As EventArgs) Handles Button33.MouseEnter
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub Button34_MouseEnter(sender As Object, e As EventArgs) Handles Button34.MouseEnter
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
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
                        AnteprimaProgettoBottone.BackColor = Color.Navy
                        AnteprimaProgettoBottone.Visible = True
                        ProgrammazioneProgettoBottone.BackColor = Color.Blue
                    End If
                Else
                    System.IO.File.WriteAllText(TextBox1.Text, FastColoredTextBox1.Text)
                    FastColoredTextBox1.Clear()
                    TextBox1.Text = ("")
                    SaveFileDialog1.FileName = ("Progetto")
                    FastColoredTextBox1.Text = (WebBrowser2.DocumentText)
                    AnteprimaProgetto.Visible = False
                    AnteprimaProgettoBottone.BackColor = Color.Navy
                    AnteprimaProgettoBottone.Visible = True
                    ProgrammazioneProgettoBottone.BackColor = Color.Blue
                End If

            ElseIf result = MsgBoxResult.No Then
                FastColoredTextBox1.Text = (WebBrowser2.DocumentText)
                AnteprimaProgetto.Visible = False
                AnteprimaProgettoBottone.BackColor = Color.Navy
                AnteprimaProgettoBottone.Visible = True
                ProgrammazioneProgettoBottone.BackColor = Color.Blue
            ElseIf result = MsgBoxResult.Cancel Then

            End If
        Else
            FastColoredTextBox1.Text = (WebBrowser2.DocumentText)
            AnteprimaProgetto.Visible = False
            AnteprimaProgettoBottone.BackColor = Color.Navy
            AnteprimaProgettoBottone.Visible = True
            ProgrammazioneProgettoBottone.BackColor = Color.Blue
        End If
    End Sub

    Private Sub TitoloProgetto_MouseEnter(sender As Object, e As EventArgs) Handles TitoloProgetto.MouseEnter
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
    End Sub

    Private Sub AnteprimaProgetto_MouseEnter(sender As Object, e As EventArgs) Handles AnteprimaProgetto.MouseEnter
        FileButton.BackColor = Color.Navy
        FilePanel.Visible = False
        ModificaButton.BackColor = Color.Navy
        ModificaPanel.Visible = False
        ProgettoButton.BackColor = Color.Navy
        ProgettoPanel.Visible = False
        MinionOneButton.BackColor = Color.Navy
        MinionOnePanel.Visible = False
        InserisciButton.BackColor = Color.Navy
        InserisciPanel.Visible = False
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
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click

    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text)
            TextBox1.Text = (SaveFileDialog1.FileName)
            Me.Text = (SaveFileDialog1.FileName & " - Minion One")
        End If
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
            FastColoredTextBox1.Text = (testo)
            Me.Text = (OpenFileDialog1.FileName & " - Minion One")
            TextBox1.Text = (OpenFileDialog1.FileName)
        End If
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

    Private Sub Button38_Click_2(sender As Object, e As EventArgs)

    End Sub
End Class

