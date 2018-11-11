﻿Public Class SegnalazioneProblema
    Private Sub SegnalazioneProblema_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Button2.Enabled = True Then
            e.Cancel = True
        Else
            e.Cancel = False
            Me.Dispose()
        End If
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles MotivoText.GotFocus
        If (MotivoText.Text = MyCEF.TraduzioneLinguaTxt.Lines(544) And MotivoText.ForeColor = Color.DarkGray) Then
            MotivoText.ForeColor = Color.DarkRed
            MotivoText.Text = ("")
        End If
        MotivoText.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles MotivoText.LostFocus
        If MotivoText.Text = ("") Or MotivoText.Text.Replace(" ", "") = "" Then
            MotivoText.ForeColor = Color.DarkGray
            MotivoText.Text = MyCEF.TraduzioneLinguaTxt.Lines(544)
        End If
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles MessaggioText.GotFocus
        If (MessaggioText.Text = MyCEF.TraduzioneLinguaTxt.Lines(545) And MessaggioText.ForeColor = Color.DarkGray) Then
            MessaggioText.ForeColor = Color.DarkRed
            MessaggioText.Text = ("")
        End If
        MessaggioText.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles MessaggioText.LostFocus
        If MessaggioText.Text = ("") Or MessaggioText.Text.Replace(" ", "") = "" Then
            MessaggioText.ForeColor = Color.DarkGray
            MessaggioText.Text = MyCEF.TraduzioneLinguaTxt.Lines(545)
        End If
    End Sub

    Private Sub TextBox9_GotFocus(sender As Object, e As EventArgs) Handles NomeCognomeText.GotFocus
        If (NomeCognomeText.Text = MyCEF.TraduzioneLinguaTxt.Lines(542) And NomeCognomeText.ForeColor = Color.DarkGray) Then
            NomeCognomeText.ForeColor = Color.DarkRed
            NomeCognomeText.Text = ("")
        End If
        NomeCognomeText.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles NomeCognomeText.LostFocus
        If NomeCognomeText.Text = ("") Or NomeCognomeText.Text.Replace(" ", "") = "" Then
            NomeCognomeText.ForeColor = Color.DarkGray
            NomeCognomeText.Text = MyCEF.TraduzioneLinguaTxt.Lines(542)
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles EmailText.GotFocus
        If (EmailText.Text = MyCEF.TraduzioneLinguaTxt.Lines(543) And EmailText.ForeColor = Color.DarkGray) Then
            EmailText.ForeColor = Color.DarkRed
            EmailText.Text = ("")
        End If
        EmailText.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles EmailText.LostFocus
        If EmailText.Text = ("") Or EmailText.Text.Replace(" ", "") = "" Then
            EmailText.ForeColor = Color.DarkGray
            EmailText.Text = MyCEF.TraduzioneLinguaTxt.Lines(543)
        End If
    End Sub

    Private Sub GeneraleCheck0_CheckedChanged(sender As Object, e As EventArgs) Handles AccettoCondCheck.CheckedChanged
        If AccettoCondCheck.Checked = True Then
            Button48.Enabled = True
        Else
            Button48.Enabled = False
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If NomeCognomeText.Text.Replace(" ", "") = "" Or NomeCognomeText.Text = MyCEF.TraduzioneLinguaTxt.Lines(542) And NomeCognomeText.ForeColor = Color.DarkGray Then
            NomeCognomeText.BackColor = Color.Red
        End If
        If MotivoText.Text.Replace(" ", "") = "" Or MotivoText.Text = MyCEF.TraduzioneLinguaTxt.Lines(544) And MotivoText.ForeColor = Color.DarkGray Then
            MotivoText.BackColor = Color.Red
        End If
        If EmailText.Text.Replace(" ", "") = "" Or EmailText.Text = MyCEF.TraduzioneLinguaTxt.Lines(543) And EmailText.ForeColor = Color.DarkGray Or Not EmailText.Text.Contains("@") Or Not EmailText.Text.Contains(".") Or EmailText.Text.Contains(" ") Then
            EmailText.BackColor = Color.Red
        End If
        If MessaggioText.Text.Replace(" ", "") = "" Or MessaggioText.Text = MyCEF.TraduzioneLinguaTxt.Lines(545) And MessaggioText.ForeColor = Color.DarkGray Then
            MessaggioText.BackColor = Color.Red
        End If
        MessaggioInvio.Text = MessaggioText.Text.Replace(" ", "+")
        MessaggioInvio.Text = MessaggioInvio.Text.Replace(vbNewLine, "%0D%0A")
        If Not (NomeCognomeText.BackColor = Color.Red Or EmailText.BackColor = Color.Red Or MotivoText.BackColor = Color.Red Or MessaggioText.BackColor = Color.Red) Then
            WebBrowser1.Navigate("https://minionone.altervista.org/Windows/ITA-IT/segnalaproblema.php?oggetto=" & MotivoText.Text.Replace(" ", "+") & "&email=" & EmailText.Text & "&messaggio=" & MessaggioInvio.Text & "&nomeecognome=" & NomeCognomeText.Text.Replace(" ", "+") & "&versione=" & Application.ProductVersion & "&submit=Invia")
            Button48.Enabled = False
            AccettoCondCheck.Enabled = False
            NomeCognomeText.Enabled = False
            MotivoText.Enabled = False
            MessaggioText.Enabled = False
            EmailText.Enabled = False

            Panel1.Visible = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub SegnalazioneProblema_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Panel1.Visible = False
        Button2.Enabled = False
        MessaggioF.Text = ("Mail inviata correttamente")
        MessaggioF.Button1.Text = ("La mail è stata inviata con successo al nostro team." & vbNewLine & "Se " & EmailText.Text & " non è la tua email ricompila il form.")
        MessaggioF.DettagliErroreButton.Visible = False
        MessaggioF.ErroreTxt.Text = ("")
        MessaggioF.ShowDialog()

        NomeCognomeText.Text = MyCEF.TraduzioneLinguaTxt.Lines(542)
        MotivoText.Text = MyCEF.TraduzioneLinguaTxt.Lines(544)
        MessaggioText.Text = MyCEF.TraduzioneLinguaTxt.Lines(545)
        EmailText.Text = MyCEF.TraduzioneLinguaTxt.Lines(543)

        Button48.Enabled = True
        AccettoCondCheck.Enabled = True
        AccettoCondCheck.Checked = False
        NomeCognomeText.Enabled = True
        NomeCognomeText.ForeColor = Color.DarkGray
        MotivoText.Enabled = True
        MotivoText.ForeColor = Color.DarkGray
        MessaggioText.Enabled = True
        MessaggioText.ForeColor = Color.DarkGray
        EmailText.Enabled = True
        EmailText.ForeColor = Color.DarkGray
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Button2.Enabled = False

        NomeCognomeText.Text = MyCEF.TraduzioneLinguaTxt.Lines(542)
        MotivoText.Text = MyCEF.TraduzioneLinguaTxt.Lines(544)
        MessaggioText.Text = MyCEF.TraduzioneLinguaTxt.Lines(545)
        EmailText.Text = MyCEF.TraduzioneLinguaTxt.Lines(543)

        Button48.Enabled = True
        AccettoCondCheck.Enabled = True
        AccettoCondCheck.Checked = False
        NomeCognomeText.Enabled = True
        NomeCognomeText.ForeColor = Color.DarkGray
        MotivoText.Enabled = True
        MotivoText.ForeColor = Color.DarkGray
        MessaggioText.Enabled = True
        MessaggioText.ForeColor = Color.DarkGray
        EmailText.Enabled = True
        EmailText.ForeColor = Color.DarkGray

        WebBrowser1.Stop()
        WebBrowser1.Navigate("")
        WebBrowser1.Stop()

        Me.Close()
    End Sub

    Private Sub NomeCognomeText_TextChanged(sender As Object, e As EventArgs) Handles NomeCognomeText.TextChanged

    End Sub

    Private Sub EmailText_TextChanged(sender As Object, e As EventArgs) Handles EmailText.TextChanged

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        NomeCognomeText.Copy()
    End Sub

    Private Sub IncollaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem.Click
        NomeCognomeText.Select()
        NomeCognomeText.Paste()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        EmailText.Copy()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        EmailText.Select()
        EmailText.Paste()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        MotivoText.Copy()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        MotivoText.Select()
        MotivoText.Paste()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        MessaggioText.Copy()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        MessaggioText.Select()
        MessaggioText.Paste()
    End Sub
End Class