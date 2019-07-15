Public Class Editor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        If My.Settings.strumenti = ("SI") Then
            MinionOne.StrumentiButton.Visible = True
            MinionOne.Button39.Image = (My.Resources.si)
        ElseIf My.Settings.strumenti = ("NO") Then
            MinionOne.StrumentiButton.Visible = False
            MinionOne.Button39.Image = (My.Resources.no)
        End If
        MinionOne.Button35.Enabled = True
        MinionOne.Button39.Enabled = True
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        MinionOne.TipoDiEditor.Text = ("Editor: HTML")
        MinionOne.FastColoredTextBox1.Select()
        MinionOne.TESTOINCOLLATO.Paste()
        If MinionOne.FastColoredTextBox1.Text <> "" Then
            MinionOne.FastColoredTextBox1.SelectAll()
            MinionOne.FastColoredTextBox1.Copy()
            MinionOne.FastColoredTextBox1.Paste()
        End If
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        MinionOne.AnteprimaProgettoBottone.Visible = False
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.Button39.Enabled = False
        MinionOne.Button39.Image = (My.Resources.no)
        MinionOne.Button35.Enabled = False
        MinionOne.Button35.Image = (My.Resources.no)
        MinionOne.StrumentiButton.Visible = False

        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
        MinionOne.TipoDiEditor.Text = ("Editor: TXT")
        MinionOne.FastColoredTextBox1.Select()
        MinionOne.TESTOINCOLLATO.Paste()
        If MinionOne.FastColoredTextBox1.Text <> "" Then
            MinionOne.FastColoredTextBox1.SelectAll()
            MinionOne.FastColoredTextBox1.Copy()
            MinionOne.FastColoredTextBox1.Paste()
        End If
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        MinionOne.AnteprimaProgettoBottone.Visible = False
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.Button39.Enabled = True
        MinionOne.Button35.Enabled = False
        MinionOne.Button35.Image = (My.Resources.no)
        If My.Settings.strumenti = ("SI") Then
            MinionOne.StrumentiButton.Visible = True
            MinionOne.Button39.Image = (My.Resources.si)
        ElseIf My.Settings.strumenti = ("NO") Then
            MinionOne.StrumentiButton.Visible = False
            MinionOne.Button39.Image = (My.Resources.no)
        End If
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP
        MinionOne.TipoDiEditor.Text = ("Editor: PHP")
        MinionOne.FastColoredTextBox1.Select()
        MinionOne.TESTOINCOLLATO.Paste()
        If MinionOne.FastColoredTextBox1.Text <> "" Then
            MinionOne.FastColoredTextBox1.SelectAll()
            MinionOne.FastColoredTextBox1.Copy()
            MinionOne.FastColoredTextBox1.Paste()
        End If
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        MinionOne.AnteprimaProgettoBottone.Visible = False
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.Button39.Enabled = False
        MinionOne.Button39.Image = (My.Resources.no)
        MinionOne.Button35.Enabled = False
        MinionOne.Button35.Image = (My.Resources.no)
        MinionOne.StrumentiButton.Visible = False
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
        MinionOne.TipoDiEditor.Text = ("Editor: JS")
        MinionOne.FastColoredTextBox1.Select()
        MinionOne.TESTOINCOLLATO.Paste()
        If MinionOne.FastColoredTextBox1.Text <> "" Then
            MinionOne.FastColoredTextBox1.SelectAll()
            MinionOne.FastColoredTextBox1.Copy()
            MinionOne.FastColoredTextBox1.Paste()
        End If
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        MinionOne.AnteprimaProgettoBottone.Visible = False
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.Button39.Enabled = False
        MinionOne.Button39.Image = (My.Resources.no)
        MinionOne.Button35.Enabled = False
        MinionOne.Button35.Image = (My.Resources.no)
        MinionOne.StrumentiButton.Visible = False

        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB
        MinionOne.TipoDiEditor.Text = ("Editor: VB.NET")
        MinionOne.FastColoredTextBox1.Select()
        MinionOne.TESTOINCOLLATO.Paste()
        If MinionOne.FastColoredTextBox1.Text <> "" Then
            MinionOne.FastColoredTextBox1.SelectAll()
            MinionOne.FastColoredTextBox1.Copy()
            MinionOne.FastColoredTextBox1.Paste()
        End If
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Red
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.DarkRed
        MinionOne.AnteprimaProgettoBottone.Visible = False
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.Button39.Enabled = False
        MinionOne.Button39.Image = (My.Resources.no)
        MinionOne.Button35.Enabled = False
        MinionOne.Button35.Image = (My.Resources.no)
        MinionOne.StrumentiButton.Visible = False
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp
        MinionOne.TipoDiEditor.Text = ("Editor: C#")
        MinionOne.FastColoredTextBox1.Select()
        MinionOne.TESTOINCOLLATO.Paste()
        If MinionOne.FastColoredTextBox1.Text <> "" Then
            MinionOne.FastColoredTextBox1.SelectAll()
            MinionOne.FastColoredTextBox1.Copy()
            MinionOne.FastColoredTextBox1.Paste()
        End If
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()
        Me.Close()
    End Sub

    Private Sub Editor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MinionOne.TipoDiEditor.Text = ("Editor: HTML") Then
            Button1.BackColor = Color.Red
        ElseIf MinionOne.TipoDiEditor.Text = ("Editor: PHP") Then
            Button4.BackColor = Color.Red
        ElseIf MinionOne.TipoDiEditor.Text = ("Editor: JS") Then
            Button6.BackColor = Color.Red
        ElseIf MinionOne.TipoDiEditor.Text = ("Editor: TXT") Then
            Button2.BackColor = Color.Red
        ElseIf MinionOne.TipoDiEditor.Text = ("Editor: VB.NET") Then
            Button5.BackColor = Color.Red
        ElseIf MinionOne.TipoDiEditor.Text = ("Editor: C#") Then
            Button3.BackColor = Color.Red
        Else

        End If
    End Sub
End Class