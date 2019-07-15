Public Class BackUpRipristino

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Tipo.Text = ("Css") Then
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
            MinionOneF.CSSSIoNOtb.Text = ("si")
            MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\BackUpFileHtml.mopling")
            MinionOneF.CSSFTB.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\BackUpCss.mopcss")
        ElseIf Tipo.Text = ("Html") Then
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
            MinionOneF.buttprogcss.Visible = False
            MinionOneF.CSSSIoNOtb.Text = ("no")
            MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\BackUpFileHtml.mopling")
        ElseIf Tipo.Text = ("Php") Then
            MinionOneF.FileButton.Enabled = True
            MinionOneF.ModificaButton.Enabled = True
            MinionOneF.VisualizzaButton.Enabled = True
            MinionOneF.InserisciButton.Enabled = True
            MinionOneF.MinionOneButton.Enabled = True
            MinionOneF.ProgettazioneButtonR.Enabled = True
            MinionOneF.AnteprimaButtonR.Enabled = True
            MinionOneF.FastColoredTextBox1.ReadOnly = False
            MinionOneF.FastColoredTextBox1.Select()
            MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP

            MinionOneF.buttprogling.Text = ("PHP")
            MinionOneF.buttprogling.Enabled = True
            MinionOneF.buttprogcss.Visible = False
            MinionOneF.CSSSIoNOtb.Text = ("no")
            MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\BackUpFilePhp.mopling")
        ElseIf Tipo.Text = ("JavaScript") Then
            MinionOneF.FileButton.Enabled = True
            MinionOneF.ModificaButton.Enabled = True
            MinionOneF.VisualizzaButton.Enabled = True
            MinionOneF.InserisciButton.Enabled = True
            MinionOneF.MinionOneButton.Enabled = True
            MinionOneF.ProgettazioneButtonR.Enabled = True
            MinionOneF.AnteprimaButtonR.Enabled = True
            MinionOneF.FastColoredTextBox1.ReadOnly = False
            MinionOneF.FastColoredTextBox1.Select()
            MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS

            MinionOneF.buttprogling.Text = ("JavaScript")
            MinionOneF.buttprogling.Enabled = True
            MinionOneF.buttprogcss.Visible = False
            MinionOneF.CSSSIoNOtb.Text = ("no")
            MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\BackUpFileJavaScript.mopling")
        ElseIf Tipo.Text = ("Vbnet") Then
            MinionOneF.FileButton.Enabled = True
            MinionOneF.ModificaButton.Enabled = True
            MinionOneF.VisualizzaButton.Enabled = True
            MinionOneF.InserisciButton.Enabled = True
            MinionOneF.MinionOneButton.Enabled = True
            MinionOneF.ProgettazioneButtonR.Enabled = True
            MinionOneF.AnteprimaButtonR.Enabled = True
            MinionOneF.FastColoredTextBox1.ReadOnly = False
            MinionOneF.FastColoredTextBox1.Select()
            MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB

            MinionOneF.buttprogling.Text = ("VB.NET")
            MinionOneF.buttprogling.Enabled = True
            MinionOneF.buttprogcss.Visible = False
            MinionOneF.CSSSIoNOtb.Text = ("no")
            MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\BackUpFileVbnet.mopling")
        ElseIf Tipo.Text = ("C#") Then
            MinionOneF.FileButton.Enabled = True
            MinionOneF.ModificaButton.Enabled = True
            MinionOneF.VisualizzaButton.Enabled = True
            MinionOneF.InserisciButton.Enabled = True
            MinionOneF.MinionOneButton.Enabled = True
            MinionOneF.ProgettazioneButtonR.Enabled = True
            MinionOneF.AnteprimaButtonR.Enabled = True
            MinionOneF.FastColoredTextBox1.ReadOnly = False
            MinionOneF.FastColoredTextBox1.Select()
            MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp

            MinionOneF.buttprogling.Text = ("C#")
            MinionOneF.buttprogling.Enabled = True
            MinionOneF.buttprogcss.Visible = False
            MinionOneF.CSSSIoNOtb.Text = ("no")
            MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\BackUpFileC#.mopling")
        ElseIf Tipo.Text = ("Custom") Then
            MinionOneF.FileButton.Enabled = True
            MinionOneF.ModificaButton.Enabled = True
            MinionOneF.VisualizzaButton.Enabled = True
            MinionOneF.InserisciButton.Enabled = True
            MinionOneF.MinionOneButton.Enabled = True
            MinionOneF.ProgettazioneButtonR.Enabled = True
            MinionOneF.AnteprimaButtonR.Enabled = True
            MinionOneF.FastColoredTextBox1.ReadOnly = False
            MinionOneF.FastColoredTextBox1.Select()
            MinionOneF.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom

            MinionOneF.buttprogling.Text = ("N.D.")
            MinionOneF.buttprogling.Enabled = True
            MinionOneF.buttprogcss.Visible = False
            MinionOneF.CSSSIoNOtb.Text = ("no")
            MinionOneF.FastColoredTextBox1.Text = System.IO.File.ReadAllText(My.Application.Info.DirectoryPath & "\BackUpFileCustom.mopling")
        End If
        Me.Close()
    End Sub

    Private Sub BackUpRipristino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class