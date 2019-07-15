Public Class Avvio

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If ApriProgettoMinionOne.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = System.IO.File.ReadAllText(ApriProgettoMinionOne.FileName)
            MinionOne.Text = (ApriProgettoMinionOne.FileName & " - Minion One")
            MinionOne.TextBox1.Text = (ApriProgettoMinionOne.FileName)
            If Text.Contains(".html") Or Text.Contains(".htm") Then
                MinionOne.TipoDiEditor.Text = ("Editor: HTML")
                MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
                MinionOne.AnteprimaProgettoBottone.Visible = True
                MinionOne.StrumentiButton.Visible = True
                MinionOne.Button39.Enabled = True
                MinionOne.Button39.Image = (My.Resources.si)
                MinionOne.Button35.Enabled = True
                MinionOne.Button35.Image = (My.Resources.si)
                My.Settings.strumenti = ("SI")
            ElseIf Text.Contains(".php") Then
                MinionOne.TipoDiEditor.Text = ("Editor: PHP")
                MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP
                MinionOne.AnteprimaProgettoBottone.Visible = False
                MinionOne.StrumentiButton.Visible = False
                MinionOne.Button39.Enabled = True
                MinionOne.Button39.Image = (My.Resources.si)
                MinionOne.Button35.Enabled = False
                MinionOne.Button35.Image = (My.Resources.no)
                My.Settings.strumenti = ("SI")
            ElseIf Text.Contains(".js") Then
                MinionOne.TipoDiEditor.Text = ("Editor: JS")
                MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
                MinionOne.AnteprimaProgettoBottone.Visible = False
                MinionOne.StrumentiButton.Visible = False
                MinionOne.Button39.Enabled = False
                MinionOne.Button39.Image = (My.Resources.no)
                MinionOne.Button35.Enabled = False
                MinionOne.Button35.Image = (My.Resources.no)
                My.Settings.strumenti = ("NO")
            ElseIf Text.Contains(".txt") Then
                MinionOne.TipoDiEditor.Text = ("Editor: TXT")
                MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
                MinionOne.AnteprimaProgettoBottone.Visible = False
                MinionOne.StrumentiButton.Visible = False
                MinionOne.Button39.Enabled = False
                MinionOne.Button39.Image = (My.Resources.no)
                MinionOne.Button35.Enabled = False
                MinionOne.Button35.Image = (My.Resources.no)
                My.Settings.strumenti = ("NO")
            Else
                MinionOne.TipoDiEditor.Text = ("Editor: N.R.")
                MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
                MinionOne.AnteprimaProgettoBottone.Visible = False
                MinionOne.StrumentiButton.Visible = False
                MinionOne.Button39.Enabled = False
                MinionOne.Button39.Image = (My.Resources.no)
                MinionOne.Button35.Enabled = False
                MinionOne.Button35.Image = (My.Resources.no)
                My.Settings.strumenti = ("NO")
            End If
            MinionOne.FastColoredTextBox1.Text = (testo)
            MinionOne.SaveFileDialog1.FileName = (ApriProgettoMinionOne.FileName)
            MinionOne.FastColoredTextBox1.Select()
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Settings.anteprimaprogetto = ("SI") Then
            MinionOne.Button35.Image = My.Resources.si
            MinionOne.AnteprimaProgettoBottone.Visible = True
        ElseIf My.Settings.anteprimaprogetto = ("NO") Then
            MinionOne.Button35.Image = My.Resources.no
            MinionOne.AnteprimaProgettoBottone.Visible = False
            MinionOne.AnteprimaProgetto.Visible = False
            MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
            MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        End If
        If My.Settings.strumenti = ("si") Then
            MinionOne.StrumentiButton.Visible = True
            MinionOne.Button39.Image = (My.Resources.si)
        ElseIf My.Settings.strumenti = ("no") Then
            MinionOne.StrumentiButton.Visible = False
            MinionOne.Button39.Image = (My.Resources.no)
        End If
        MinionOne.Button39.Enabled = True
        MinionOne.Button35.Enabled = True
        MinionOne.Button35.Image = (My.Resources.si)
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.TipoDiEditor.Text = ("Editor: HTML")
        MinionOne.FastColoredTextBox1.Clear()
        MinionOne.FastColoredTextBox1.Select()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
        MinionOne.Text = ("Nuovo Documento - Minion One")
        MinionOne.TipoDiEditor.Text = ("Editor: N.R.")
        MinionOne.FastColoredTextBox1.Clear()

        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        MinionOne.AnteprimaProgettoBottone.Visible = False
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.Button39.Enabled = True
        MinionOne.Button35.Enabled = False
        MinionOne.Button35.Image = (My.Resources.no)
        If My.Settings.strumenti = ("si") Then
            MinionOne.StrumentiButton.Visible = True
            MinionOne.Button39.Image = (My.Resources.si)
        ElseIf My.Settings.strumenti = ("no") Then
            MinionOne.StrumentiButton.Visible = False
            MinionOne.Button39.Image = (My.Resources.no)
        End If
        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP
        MinionOne.TipoDiEditor.Text = ("Editor: PHP")
        My.Settings.strumenti = ("SI")
        MinionOne.FastColoredTextBox1.Clear()
        MinionOne.FastColoredTextBox1.Select()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        MinionOne.AnteprimaProgettoBottone.Visible = False
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.Button35.Enabled = False
        MinionOne.Button35.Image = (My.Resources.no)
        If My.Settings.strumenti = ("si") Then
            MinionOne.StrumentiButton.Visible = True
            MinionOne.Button39.Image = (My.Resources.si)
        ElseIf My.Settings.strumenti = ("no") Then
            MinionOne.StrumentiButton.Visible = False
            MinionOne.Button39.Image = (My.Resources.no)
        End If

        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
        MinionOne.TipoDiEditor.Text = ("Editor: JS")
        MinionOne.FastColoredTextBox1.Clear()
        MinionOne.FastColoredTextBox1.Select()
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        MinionOne.AnteprimaProgettoBottone.Visible = False
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.Button39.Enabled = False
        MinionOne.Button39.Image = (My.Resources.no)
        MinionOne.Button35.Enabled = False
        MinionOne.Button35.Image = (My.Resources.no)
        MinionOne.StrumentiButton.Visible = False

        MinionOne.Text = ("Nuovo Documento - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
        MinionOne.TipoDiEditor.Text = ("Editor: TXT")
        My.Settings.strumenti = ("NO")
        MinionOne.FastColoredTextBox1.Clear()
        MinionOne.FastColoredTextBox1.Select()
        Me.Close()
    End Sub

    Private Sub Avvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Dir(My.Application.Info.DirectoryPath & "\impostazioni.imo") <> "" Then

        Else
            My.Settings.primoavvio = ("si")
        End If

        If My.Settings.primoavvio = ("si") Then
            Button6.Text = ("BENVENUTO IN MINION ONE!")
            My.Settings.primoavvio = ("no")
            My.Settings.Save()

            MinionOne.salvaimpostazionitext.Text = MinionOne.salvaimpostazionitext.Text.Replace("°üÄ>><.", "") 'inserire nelle prime virgolette il codice da sostituire
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", MinionOne.salvaimpostazionitext.Text)
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\impostazioni.imo", MinionOne.salvaimpostazionitext.Text & "^;;:^&") 'inserire nelle virgolette il codice da inserire
        Else
            Button6.Text = ("BENTORNATO!")
        End If

        If My.Settings.colorebordi = ("black") Then
            Button1.BackColor = Color.Black
            Button1.FlatAppearance.BorderColor = Color.Black
            Button1.FlatAppearance.MouseDownBackColor = Color.Black
            Button1.FlatAppearance.MouseOverBackColor = Color.Black
            Button1.ForeColor = Color.Gray
            Button2.BackColor = Color.Black
            Button2.ForeColor = Color.Gray
            Panel1.BackColor = Color.Black
            Panel2.BackColor = Color.Black
            Panel4.BackColor = Color.Black
        ElseIf My.Settings.colorebordi = ("gray") Then
            Button1.BackColor = Color.Gray
            Button1.FlatAppearance.BorderColor = Color.Gray
            Button1.FlatAppearance.MouseDownBackColor = Color.Gray
            Button1.FlatAppearance.MouseOverBackColor = Color.Gray
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Gray
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Gray
            Panel2.BackColor = Color.Gray
            Panel4.BackColor = Color.Gray
        ElseIf My.Settings.colorebordi = ("white") Then
            Button1.BackColor = Color.White
            Button1.FlatAppearance.BorderColor = Color.White
            Button1.FlatAppearance.MouseDownBackColor = Color.White
            Button1.FlatAppearance.MouseOverBackColor = Color.White
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.White
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.White
            Panel2.BackColor = Color.White
            Panel4.BackColor = Color.White
        ElseIf My.Settings.colorebordi = ("yellow") Then
            Button1.BackColor = Color.Yellow
            Button1.FlatAppearance.BorderColor = Color.Yellow
            Button1.FlatAppearance.MouseDownBackColor = Color.Yellow
            Button1.FlatAppearance.MouseOverBackColor = Color.Yellow
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Yellow
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Yellow
            Panel2.BackColor = Color.Yellow
            Panel4.BackColor = Color.Yellow
        ElseIf My.Settings.colorebordi = ("gold") Then
            Button1.BackColor = Color.Gold
            Button1.FlatAppearance.BorderColor = Color.Gold
            Button1.FlatAppearance.MouseDownBackColor = Color.Gold
            Button1.FlatAppearance.MouseOverBackColor = Color.Gold
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Gold
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Gold
            Panel2.BackColor = Color.Gold
            Panel4.BackColor = Color.Gold
        ElseIf My.Settings.colorebordi = ("orangered") Then
            Button1.BackColor = Color.OrangeRed
            Button1.FlatAppearance.BorderColor = Color.OrangeRed
            Button1.FlatAppearance.MouseDownBackColor = Color.OrangeRed
            Button1.FlatAppearance.MouseOverBackColor = Color.OrangeRed
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.OrangeRed
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.OrangeRed
            Panel2.BackColor = Color.OrangeRed
            Panel4.BackColor = Color.OrangeRed
        ElseIf My.Settings.colorebordi = ("red") Then
            Button1.BackColor = Color.Red
            Button1.FlatAppearance.BorderColor = Color.Red
            Button1.FlatAppearance.MouseDownBackColor = Color.Red
            Button1.FlatAppearance.MouseOverBackColor = Color.Red
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Red
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Red
            Panel2.BackColor = Color.Red
            Panel4.BackColor = Color.Red
        ElseIf My.Settings.colorebordi = ("fuchsia") Then
            Button1.BackColor = Color.Fuchsia
            Button1.FlatAppearance.BorderColor = Color.Fuchsia
            Button1.FlatAppearance.MouseDownBackColor = Color.Fuchsia
            Button1.FlatAppearance.MouseOverBackColor = Color.Fuchsia
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Fuchsia
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Fuchsia
            Panel2.BackColor = Color.Fuchsia
            Panel4.BackColor = Color.Fuchsia
        ElseIf My.Settings.colorebordi = ("purple") Then
            Button1.BackColor = Color.Purple
            Button1.FlatAppearance.BorderColor = Color.Purple
            Button1.FlatAppearance.MouseDownBackColor = Color.Purple
            Button1.FlatAppearance.MouseOverBackColor = Color.Purple
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Purple
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Purple
            Panel2.BackColor = Color.Purple
            Panel4.BackColor = Color.Purple
        ElseIf My.Settings.colorebordi = ("navy") Then
            Button1.BackColor = Color.Navy
            Button1.FlatAppearance.BorderColor = Color.Navy
            Button1.FlatAppearance.MouseDownBackColor = Color.Navy
            Button1.FlatAppearance.MouseOverBackColor = Color.Navy
            Button1.ForeColor = Color.Gray
            Button2.BackColor = Color.Navy
            Button2.ForeColor = Color.Gray
            Panel1.BackColor = Color.Navy
            Panel2.BackColor = Color.Navy
            Panel4.BackColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("blue") Then
            Button1.BackColor = Color.Blue
            Button1.FlatAppearance.BorderColor = Color.Blue
            Button1.FlatAppearance.MouseDownBackColor = Color.Blue
            Button1.FlatAppearance.MouseOverBackColor = Color.Blue
            Button1.ForeColor = Color.Gray
            Button2.BackColor = Color.Blue
            Button2.ForeColor = Color.Gray
            Panel1.BackColor = Color.Blue
            Panel2.BackColor = Color.Blue
            Panel4.BackColor = Color.Blue
        ElseIf My.Settings.colorebordi = ("cyan") Then
            Button1.BackColor = Color.Cyan
            Button1.FlatAppearance.BorderColor = Color.Cyan
            Button1.FlatAppearance.MouseDownBackColor = Color.Cyan
            Button1.FlatAppearance.MouseOverBackColor = Color.Cyan
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Cyan
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Cyan
            Panel2.BackColor = Color.Cyan
            Panel4.BackColor = Color.Cyan
        ElseIf My.Settings.colorebordi = ("teal") Then
            Button1.BackColor = Color.Teal
            Button1.FlatAppearance.BorderColor = Color.Teal
            Button1.FlatAppearance.MouseDownBackColor = Color.Teal
            Button1.FlatAppearance.MouseOverBackColor = Color.Teal
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Teal
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Teal
            Panel2.BackColor = Color.Teal
            Panel4.BackColor = Color.Teal
        ElseIf My.Settings.colorebordi = ("green") Then
            Button1.BackColor = Color.Green
            Button1.FlatAppearance.BorderColor = Color.Green
            Button1.FlatAppearance.MouseDownBackColor = Color.Green
            Button1.FlatAppearance.MouseOverBackColor = Color.Green
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Green
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Green
            Panel2.BackColor = Color.Green
            Panel4.BackColor = Color.Green
        ElseIf My.Settings.colorebordi = ("lime") Then
            Button1.BackColor = Color.Lime
            Button1.FlatAppearance.BorderColor = Color.Lime
            Button1.FlatAppearance.MouseDownBackColor = Color.Lime
            Button1.FlatAppearance.MouseOverBackColor = Color.Lime
            Button1.ForeColor = Color.Black
            Button2.BackColor = Color.Lime
            Button2.ForeColor = Color.Black
            Panel1.BackColor = Color.Lime
            Panel2.BackColor = Color.Lime
            Panel4.BackColor = Color.Lime
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        MinionOne.Button35.Image = My.Resources.no
        MinionOne.AnteprimaProgettoBottone.Visible = False
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        MinionOne.Button35.Enabled = False
        MinionOne.StrumentiButton.Visible = False

        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp
        MinionOne.TipoDiEditor.Text = ("Editor: C#")
        Me.Close()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ProgettoGuidato.Show()
        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        MinionOne.TipoDiEditor.Text = ("Editor: HTML")
        MinionOne.Button39.Enabled = True
        MinionOne.Button39.Image = (My.Resources.si)
        MinionOne.Button35.Enabled = True
        MinionOne.Button35.Image = (My.Resources.si)
        MinionOne.StrumentiButton.Visible = True
        MinionOne.AnteprimaProgettoBottone.Visible = True
        MinionOne.FastColoredTextBox1.Clear()
        My.Settings.strumenti = ("SI")
        Me.Close()
    End Sub
End Class