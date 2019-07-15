Public Class Feedback
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub me_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub me_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub me_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Select()
        If My.Settings.colorebordi = ("black") Then
            Button1.BackColor = Color.Black
            Button1.FlatAppearance.BorderColor = Color.Black
            Button1.FlatAppearance.MouseDownBackColor = Color.Black
            Button1.FlatAppearance.MouseOverBackColor = Color.Black
            Button1.ForeColor = Color.Gray
            Button2.BackColor = Color.Black
            Button2.ForeColor = Color.Gray
            Button3.BackColor = Color.Black
            Button3.ForeColor = Color.Gray
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
            Button3.BackColor = Color.Gray
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.White
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.Yellow
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.Gold
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.OrangeRed
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.Red
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.Fuchsia
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.Purple
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.Navy
            Button3.ForeColor = Color.Gray
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
            Button3.BackColor = Color.Blue
            Button3.ForeColor = Color.Gray
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
            Button3.BackColor = Color.Cyan
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.Teal
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.Green
            Button1.ForeColor = Color.Black
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
            Button3.BackColor = Color.Lime
            Button1.ForeColor = Color.Black
            Panel1.BackColor = Color.Lime
            Panel2.BackColor = Color.Lime
            Panel4.BackColor = Color.Lime
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button11.Visible = True
        Button12.Visible = True
        Button10.Visible = True
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Messaggio.Show()
        Messaggio.testo.Text = ("Segnalazione inviata correttamente. Riceverete nostre risposte. Grazie.")
        Messaggio.Button1.Text = ("     Segnalazione inviata")
        Messaggio.Text = ("Minion One - Segnalazione inviata")
        Button8.Enabled = True
        Button7.Visible = False
        ComboBox1.Text = ("")
        TextBox1.Text = ("")
        TextBox2.Text = ("")
        Button2.Enabled = True
    End Sub

    Private Sub versionesoftware_KeyDown(sender As Object, e As KeyEventArgs) Handles versionesoftware.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                motivoinvio.Select()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub versionesoftware_TextChanged(sender As Object, e As EventArgs) Handles versionesoftware.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If My.Computer.Network.IsAvailable Then
            If ComboBox1.Text = ("") Then
                Messaggio.Close()
                Messaggio.Show()
                Messaggio.testo.Text = ("Seleziona una motivazione valida.")
                Messaggio.Button1.Text = ("     Nessuna motivazione selezionata")
                Messaggio.Text = ("Minion One - Nessuna motivazione selezionata")
            ElseIf TextBox1.Text = ("") Then
                Messaggio.Close()
                Messaggio.Show()
                Messaggio.testo.Text = ("Inserisci la tua email in modo corretto.")
                Messaggio.Button1.Text = ("     Email non valida")
                Messaggio.Text = ("Minion One - Email non valida")
            ElseIf TextBox1.Text.Replace(" ", "") = ("") Or Not TextBox1.Text.Contains("@") Or Not TextBox1.Text.Contains(".") Then
                Messaggio.Close()
                Messaggio.Show()
                Messaggio.testo.Text = ("Inserisci la tua email in modo corretto.")
                Messaggio.Button1.Text = ("     Email non valida")
                Messaggio.Text = ("Minion One - Email non valida")
            ElseIf TextBox2.Text = ("") Then
                Messaggio.Close()
                Messaggio.Show()
                Messaggio.testo.Text = ("Scrivi la tua segnalazione in modo dettagliato e chiaro.")
                Messaggio.Button1.Text = ("     Segnalazione dettagliata vuota")
                Messaggio.Text = ("Minion One - Segnalazione vuota")
            Else
                motivoinvio.Text = (ComboBox1.Text.Replace(" ", "+"))
                segndettinvio.Text = (TextBox2.Text.Replace(" ", "+"))
                segndettinvio.Text = (TextBox2.Text.Replace(Environment.NewLine, "<br>"))
                emailinvio.Text = (TextBox1.Text.Replace(" ", ""))
                emailinvio.Text = (TextBox1.Text.Replace("@", "%40"))
                WebBrowser1.Navigate("http://minionone.altervista.org/Contattaci/invio-contattacisoftware.php?oggetto=" & motivoinvio.Text & "&email=" & emailinvio.Text & "&messaggio=" & segndettinvio.Text & "&versione=" & versionesoftware.Text & "&submit=Invia")
                Button8.Enabled = False
                Messaggio.Close()
                Button7.Visible = True
                Button2.Enabled = False
            End If
        Else
            Messaggio.Close()
            Messaggio.Show()
            Messaggio.testo.Text = ("Nessuna connessione internet: Non è possibile inviare segnalazioni")
            Messaggio.Button1.Text = ("     Nessuna connessione internet")
            Messaggio.Text = ("Minion One - Nessuna connessione internet")
        End If
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub
End Class