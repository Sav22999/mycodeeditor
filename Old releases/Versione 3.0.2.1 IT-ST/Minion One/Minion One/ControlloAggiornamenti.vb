﻿Imports System.Net
Public Class ControlloAggiornamenti
    Public Sub CheckForUpdates()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.minionone.altervista.org/Windows/IT/version.txt") 'link del file versione (il fle txt della versione) .txt
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            Button3.Text = ("Nessun aggiornamento trovato.")
            Button10.Enabled = False
            Button30.Enabled = False
            Button4.Enabled = False
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            Messaggio.Close()
            Messaggio.Show()
            Messaggio.testo.Text = ("Stai usando già la versione più recente di Minion One.")
            Messaggio.Button1.Text = ("     Nessun aggiornamento trovato.")
            Messaggio.Text = ("Minion One - Nessun aggiornamento trovato")
            Me.Close()
        Else
            Button3.Text = ("Trovata una versione più recente! [" & WebBrowser1.DocumentText & "]")
            Button10.Enabled = True
            Button30.Enabled = True
            Button4.Enabled = True
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
        End If
    End Sub

    Private Sub ControlloAggiornamenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable Then
            Timer1.Start()
            Timer3.Start()
        Else
            Messaggio.Close()
            Messaggio.Show()
            Messaggio.testo.Text = ("Nessuna connessione internet: Non è possibile controllare gli aggiornamenti")
            Messaggio.Button1.Text = ("     Nessuna connessione internet")
            Messaggio.Text = ("Minion One - Nessuna connessione internet")
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

    Private IsFormBeingDragged As Boolean = True
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If PictureBox1.Location.X = ("175") Or PictureBox1.Location.X > ("175") Then
                Timer2.Start()
                Timer1.Stop()
            Else
                TextBox1.Text = PictureBox1.Location.X + 3
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("34")
                    temp.X = TextBox1.Text
                    PictureBox1.Location = temp
                End If
                TextBox3.Text = PictureBox3.Location.X - 3
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("34")
                    temp.X = TextBox3.Text
                    PictureBox3.Location = temp
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            If PictureBox1.Location.X = ("14") Or PictureBox1.Location.X < ("14") Then
                Timer1.Start()
                Timer2.Stop()
            Else
                TextBox1.Text = PictureBox1.Location.X - 3
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("34")
                    temp.X = TextBox1.Text
                    PictureBox1.Location = temp
                End If
                TextBox3.Text = PictureBox3.Location.X + 3
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("34")
                    temp.X = TextBox3.Text
                    PictureBox3.Location = temp
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Dim WithEvents downloader As New WebClient

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Timer4.Start()
        SaveFileDialog1.FileName = ("MinionOneInstall")
        downloader.DownloadFileAsync(New Uri("http://minionone.altervista.org/Windows/IT/Install.exe"), Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\MinionOneInstall.exe")
        Timer3.Stop()
        Timer1.Start()
        ProgressBar1.Visible = False
        Button30.Enabled = False
        Button10.Enabled = False
        PictureBox1.Visible = True
        PictureBox3.Visible = True
        Button3.Text = ("Sto scaricando la nuova versione...")
    End Sub

    Private Sub downloader_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles downloader.DownloadFileCompleted
        ProgressBar1.Value = 0
        ProgressBar1.Visible = False
        InstallaNuovaVersione.Show()
        Me.Close()
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        CheckForUpdates()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs)
        Try
            If PictureBox1.Location.X = ("175") Or PictureBox1.Location.X > ("175") Then
                Timer2.Start()
                Timer1.Stop()
            Else
                TextBox1.Text = PictureBox1.Location.X + 3
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("34")
                    temp.X = TextBox1.Text
                    PictureBox1.Location = temp
                End If
                TextBox3.Text = PictureBox3.Location.X - 3
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("34")
                    temp.X = TextBox3.Text
                    PictureBox3.Location = temp
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs)
        Try
            If PictureBox1.Location.X = ("14") Or PictureBox1.Location.X < ("14") Then
                Timer1.Start()
                Timer2.Stop()
            Else
                TextBox1.Text = PictureBox1.Location.X - 3
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("34")
                    temp.X = TextBox1.Text
                    PictureBox1.Location = temp
                End If
                TextBox3.Text = PictureBox3.Location.X + 3
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("34")
                    temp.X = TextBox3.Text
                    PictureBox3.Location = temp
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer4_Tick_1(sender As Object, e As EventArgs) Handles Timer4.Tick
        If ProgressBar1.Value = ("100") Then
            Timer4.Stop()
        Else
            Button3.Text = ("Sto scaricando la nuova versione... " & ProgressBar1.Value & "%")
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        If My.Computer.Network.IsAvailable Then
            Messaggio.Close()
            Messaggio.Show()
            Messaggio.Button1.Text = ("     Dettagli nuova versione")
            Messaggio.Text = ("Minion One - Dettagli nuova versione")
            Messaggio.testo.Text = ("Versione nuova: " & WebBrowser2.DocumentText & Environment.NewLine & "La versione è stata pubblicata il: " & WebBrowser3.DocumentText & Environment.NewLine & "Lingua: IT - Italiano")
        Else
        End If
    End Sub
End Class