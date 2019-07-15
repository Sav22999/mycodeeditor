Public Class Contattaci
    Private Sub Contattaci_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Button2.Enabled = True Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles EspandiMotivoText.Click
        If MotivoPanel.Visible = True Then
            MotivoPanel.Visible = False
        Else
            MotivoPanel.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles InformazioniMotivoText.Click
        MotivoText.Text = "Informazioni"
        MotivoText.ForeColor = Color.DarkRed
        MotivoPanel.Visible = False
        MotivoText.ReadOnly = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SupportoMotivoText.Click
        MotivoText.Text = "Supporto"
        MotivoText.ForeColor = Color.DarkRed
        MotivoPanel.Visible = False
        MotivoText.ReadOnly = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SegnalazioneMotivoText.Click
        MotivoText.Text = "Segnalazione"
        MotivoText.ForeColor = Color.DarkRed
        MotivoText.ReadOnly = True
        MotivoPanel.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles AltroMotivoText.Click
        MotivoText.Select()
        MotivoPanel.Visible = False
        MotivoText.Text = ("")
        MotivoText.ReadOnly = False
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles MotivoText.Click
        MotivoPanel.Visible = True
        MotivoText.ReadOnly = True
    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles MotivoText.GotFocus
        If (MotivoText.Text = "Motivo" And MotivoText.ForeColor = Color.DarkGray) Then
            MotivoText.ForeColor = Color.DarkRed
            MotivoText.BackColor = Color.WhiteSmoke
            MotivoText.Text = ("")
        End If
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles MotivoText.LostFocus
        If MotivoText.Text = ("") Or MotivoText.Text.Replace(" ", "") = "" Then
            MotivoText.ForeColor = Color.DarkGray
            MotivoText.Text = ("Motivo")
        End If
    End Sub

    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles MessaggioText.GotFocus
        If (MessaggioText.Text = "Messaggio..." And MessaggioText.ForeColor = Color.DarkGray) Then
            MessaggioText.ForeColor = Color.DarkRed
            MessaggioText.BackColor = Color.WhiteSmoke
            MessaggioText.Text = ("")
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles MessaggioText.LostFocus
        If MessaggioText.Text = ("") Or MessaggioText.Text.Replace(" ", "") = "" Then
            MessaggioText.ForeColor = Color.DarkGray
            MessaggioText.Text = ("Messaggio...")
        End If
    End Sub

    Private Sub TextBox9_GotFocus(sender As Object, e As EventArgs) Handles NomeCognomeText.GotFocus
        If (NomeCognomeText.Text = "Nome e Cognome" And NomeCognomeText.ForeColor = Color.DarkGray) Then
            NomeCognomeText.ForeColor = Color.DarkRed
            NomeCognomeText.BackColor = Color.WhiteSmoke
            NomeCognomeText.Text = ("")
        End If
    End Sub

    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles NomeCognomeText.LostFocus
        If NomeCognomeText.Text = ("") Or NomeCognomeText.Text.Replace(" ", "") = "" Then
            NomeCognomeText.ForeColor = Color.DarkGray
            NomeCognomeText.Text = ("Nome e Cognome")
        End If
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles EmailText.GotFocus
        If (EmailText.Text = "E-mail" And EmailText.ForeColor = Color.DarkGray) Then
            EmailText.ForeColor = Color.DarkRed
            EmailText.BackColor = Color.WhiteSmoke
            EmailText.Text = ("")
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles EmailText.LostFocus
        If EmailText.Text = ("") Or EmailText.Text.Replace(" ", "") = "" Then
            EmailText.ForeColor = Color.DarkGray
            EmailText.Text = ("E-mail")
        End If
    End Sub

    Private Sub GeneraleCheck0_CheckedChanged(sender As Object, e As EventArgs) Handles AccettoCondCheck.CheckedChanged
        If AccettoCondCheck.Checked = True Then
            Button48.Enabled = True
        Else
            Button48.Enabled = False
        End If
    End Sub

    Private Sub Contattaci_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles NomeCognomeText.TextChanged

    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If NomeCognomeText.Text.Replace(" ", "") = "" Or NomeCognomeText.Text = ("Nome e Cognome") And NomeCognomeText.ForeColor = Color.DarkGray Then
            NomeCognomeText.BackColor = Color.Red
        End If
        If MotivoText.Text.Replace(" ", "") = "" Or MotivoText.Text = ("Motivo") And MotivoText.ForeColor = Color.DarkGray Then
            MotivoText.BackColor = Color.Red
        End If
        If EmailText.Text.Replace(" ", "") = "" Or EmailText.Text = ("E-mail") And EmailText.ForeColor = Color.DarkGray Or Not EmailText.Text.Contains("@") Or Not EmailText.Text.Contains(".") Or EmailText.Text.Contains(" ") Then
            EmailText.BackColor = Color.Red
        End If
        If MessaggioText.Text.Replace(" ", "") = "" Or MessaggioText.Text = ("Messaggio...") And MessaggioText.ForeColor = Color.DarkGray Then
            MessaggioText.BackColor = Color.Red
        End If
        MotivoPanel.Visible = False
        MessaggioInvio.Text = MessaggioText.Text.Replace(" ", "+")
        MessaggioInvio.Text = MessaggioInvio.Text.Replace(vbNewLine, "%0D%0A")
        If Not (NomeCognomeText.BackColor = Color.Red Or EmailText.BackColor = Color.Red Or MotivoText.BackColor = Color.Red Or MessaggioText.BackColor = Color.Red) Then
            WebBrowser1.Navigate("http://minionone.altervista.org/Windows/ITA-IT/contattaci.php?oggetto=" & MotivoText.Text.Replace(" ", "+") & "&email=" & EmailText.Text.Replace("@", "%40") & "&messaggio=" & MessaggioInvio.Text & "&nomeecognome=" & NomeCognomeText.Text.Replace(" ", "+") & "&versione=" & Application.ProductVersion & "&submit=Invia")
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

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Panel1.Visible = False
        Button2.Enabled = False
        MessaggioF.Text = ("Mail inviata correttamente")
        MessaggioF.Button1.Text = ("La mail è stata inviata con successo al nostro team." & vbNewLine & "Se " & EmailText.Text & " non è la tua email ricompila il form.")
        MessaggioF.ShowDialog()

        NomeCognomeText.Text = ("Nome e Cognome")
        MotivoText.Text = ("Motivo")
        MessaggioText.Text = ("Messaggio...")
        EmailText.Text = ("E-mail")

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
        MotivoPanel.Visible = False
        MotivoText.ReadOnly = True
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Button2.Enabled = False

        NomeCognomeText.Text = ("Nome e Cognome")
        MotivoText.Text = ("Motivo")
        MessaggioText.Text = ("Messaggio...")
        EmailText.Text = ("E-mail")

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
        MotivoPanel.Visible = False
        MotivoText.ReadOnly = True

        WebBrowser1.Stop()
        WebBrowser1.Navigate("")
        WebBrowser1.Stop()

        Me.Close()
    End Sub
End Class