Public Class Avvio

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If ApriProgettoMinionOne.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = System.IO.File.ReadAllText(ApriProgettoMinionOne.FileName)
            MinionOne.FastColoredTextBox1.Text = (testo)
            MinionOne.Text = (ApriProgettoMinionOne.FileName & " - Minion One")
            MinionOne.TextBox1.Text = (ApriProgettoMinionOne.FileName)
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        MinionOne.FastColoredTextBox1.Text = ("<!---NUOVO PROGETTO HTML (VUOTO)--->")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        MinionOne.FastColoredTextBox1.Text = ("<!---Realizzato con il software Minion One - www.mixim.altervista.org--->" & Environment.NewLine & "<html>" & Environment.NewLine & "<head>" & Environment.NewLine & "<title></title>     <!---Tra i due tag inserire il nome/titolo da assegnare alla pagina (solitamente racchiude il contenuto della stessa)--->" & Environment.NewLine & "<link rel=" & Chr(34) & "shortcut icon" & Chr(34) & " href=" & Chr(34) & Chr(34) & ">     <!---Inserire tra le virgolette, l'indirizzo URL dell'immagine che si vuole avere come icona della pagina--->" & Environment.NewLine & Environment.NewLine & "</head>" & Environment.NewLine & "<body bgcolor=" & Chr(34) & Chr(34) & ">     <!---Inserite tra le virgolette il colore che volete impostare per lo sfonto--->" & Environment.NewLine & Environment.NewLine & Environment.NewLine & Environment.NewLine & "</body>" & Environment.NewLine & "</html>" & Environment.NewLine & "<!---Realizzato con il software Minion One - www.mixim.altervista.org--->")
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP
        MinionOne.FastColoredTextBox1.Text = ("#NUOVO PROGETTO PHP")
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
        MinionOne.FastColoredTextBox1.Text = ("//NUOVO PROGETTO JS")
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MinionOne.Text = ("Nuovo Progetto - Minion One")
        MinionOne.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
        MinionOne.FastColoredTextBox1.Text = ("#NUOVO PROGETTO PHP")
        Me.Close()
    End Sub
End Class