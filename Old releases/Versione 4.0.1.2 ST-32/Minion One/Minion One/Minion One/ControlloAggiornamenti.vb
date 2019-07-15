Imports System.Net
Public Class ControlloAggiornamenti
    Private Sub ControlloAggiornamneti_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Me.Text <> ("Controllo degli aggiornamenti") Then
            downloader.CancelAsync()
            Try
                If (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.!moexe") <> "" Then
                    Kill(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.!moexe")
                Else
                    Kill(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.exe")
                End If
            Catch ex As Exception

            End Try
            Panel8.Visible = False
            e.Cancel = False
        End If
    End Sub
    Private Sub ControlloAggiornamenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As New Random
        Dim num As Integer = R.Next(4, 24)
        Timer3.Interval = num * 250
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\") = "" Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\")
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\")
        End If
        InstallaButton.Visible = False
        ScaricaButton.Visible = True
        ScaricaButton.Enabled = False
        ScaricaDopoButton.Visible = True
        ScaricaDopoButton.Enabled = False
        Button1.Text = ("Ricerca di aggiornamenti in corso...")
        Me.Text = ("Controllo degli aggiornamenti")
        Dim progressione As New Size
        progressione.Height = BarraProgressione.Height
        progressione.Width = 0
        BarraProgressione.Size = progressione
        Timer1.Start()
        Timer3.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel8.Visible = False
        If Panel1.BackColor = Color.Red And Panel2.BackColor = Color.Red Then
            Panel1.BackColor = Color.DarkRed
        ElseIf Panel1.BackColor = Color.DarkRed And Panel2.BackColor = Color.Red Then
            Panel2.BackColor = Color.DarkRed
        ElseIf Panel2.BackColor = Color.DarkRed And Panel3.BackColor = Color.Red Then
            Panel3.BackColor = Color.DarkRed
        ElseIf Panel3.BackColor = Color.DarkRed And Panel4.BackColor = Color.Red Then
            Panel4.BackColor = Color.DarkRed
        ElseIf Panel4.BackColor = Color.DarkRed And Panel5.BackColor = Color.Red Then
            Panel5.BackColor = Color.DarkRed
        ElseIf Panel5.BackColor = Color.DarkRed And Panel6.BackColor = Color.Red Then
            Panel6.BackColor = Color.DarkRed
        ElseIf Panel6.BackColor = Color.DarkRed Then
            Timer2.Start()
            Panel6.BackColor = Color.Red
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Panel8.Visible = False
        If Panel6.BackColor = Color.DarkRed And Panel5.BackColor = Color.DarkRed Then
            Panel6.BackColor = Color.Red
        ElseIf Panel6.BackColor = Color.Red And Panel5.BackColor = Color.DarkRed Then
            Panel5.BackColor = Color.Red
        ElseIf Panel5.BackColor = Color.Red And Panel4.BackColor = Color.DarkRed Then
            Panel4.BackColor = Color.Red
        ElseIf Panel4.BackColor = Color.Red And Panel3.BackColor = Color.DarkRed Then
            Panel3.BackColor = Color.Red
        ElseIf Panel3.BackColor = Color.Red And Panel2.BackColor = Color.DarkRed Then
            Panel2.BackColor = Color.Red
        ElseIf Panel2.BackColor = Color.Red And Panel1.BackColor = Color.DarkRed Then
            Panel1.BackColor = Color.Red
        ElseIf Panel1.BackColor = Color.Red Then
            Timer1.Start()
            Panel1.BackColor = Color.DarkRed
            Timer2.Stop()
        End If
    End Sub

    Public Sub CheckForUpdates()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.minionone.altervista.org/Windows/ITA-IT/x86/version.txt") 'link del file versione (il fle txt della versione) .txt
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            If MinionOneF.aggiornamentoscaricaautomaticamenteavvio = False Then
                ScaricaButton.Enabled = False
                ScaricaDopoButton.Enabled = False
                Timer1.Stop()
                Timer2.Stop()
                Panel1.BackColor = Color.Red
                Panel2.BackColor = Color.Red
                Panel3.BackColor = Color.Red
                Panel4.BackColor = Color.Red
                Panel5.BackColor = Color.Red
                Panel6.BackColor = Color.Red
                Button1.Text = ("Stai utilizzando la versione più recente.")
                Panel8.Visible = True
            Else
                ScaricaButton.Enabled = False
                ScaricaDopoButton.Enabled = False
                Timer1.Stop()
                Timer2.Stop()
                Panel1.BackColor = Color.Red
                Panel2.BackColor = Color.Red
                Panel3.BackColor = Color.Red
                Panel4.BackColor = Color.Red
                Panel5.BackColor = Color.Red
                Panel6.BackColor = Color.Red
                Panel8.Visible = True
                Me.Close()
            End If
        Else
            If MinionOneF.aggiornamentoscaricaautomaticamenteavvio = False Then
                Button1.Text = ("E' stata trovata una versione più recente.")
                ScaricaButton.Enabled = True
                ScaricaDopoButton.Enabled = True
                Timer1.Stop()
                Timer2.Stop()
                Panel1.BackColor = Color.Red
                Panel2.BackColor = Color.Red
                Panel3.BackColor = Color.Red
                Panel4.BackColor = Color.Red
                Panel5.BackColor = Color.Red
                Panel6.BackColor = Color.Red
                Panel8.Visible = True
            Else
                Button1.Text = ("E' stata trovata una versione più recente.")
                ScaricaButton.Enabled = True
                ScaricaDopoButton.Enabled = True
                Timer1.Stop()
                Timer2.Stop()
                Panel1.BackColor = Color.Red
                Panel2.BackColor = Color.Red
                Panel3.BackColor = Color.Red
                Panel4.BackColor = Color.Red
                Panel5.BackColor = Color.Red
                Panel6.BackColor = Color.Red
                Panel8.Visible = True

                ScaricaButton.PerformClick()
            End If
        End If
    End Sub

    Dim WithEvents downloader As New WebClient

    Private Sub downloader_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles downloader.DownloadFileCompleted
        If MinionOneF.aggiornamentoscaricaautomaticamenteavvio = True Then
            Me.WindowState = FormWindowState.Normal
        End If
        Timer1.Stop()
        Timer2.Stop()
        Panel1.BackColor = Color.Red
        Panel2.BackColor = Color.Red
        Panel3.BackColor = Color.Red
        Panel4.BackColor = Color.Red
        Panel5.BackColor = Color.Red
        Panel6.BackColor = Color.Red
        Panel8.Visible = True
        Dim progressione As New Size
        progressione.Height = BarraProgressione.Height
        progressione.Width = 0
        BarraProgressione.Size = progressione
        If Me.Text.Contains("100") Then
            Me.Text = ("Controllo degli aggiornamenti")
            ScaricaButton.Visible = False
            ScaricaDopoButton.Visible = False
            InstallaButton.Visible = True
            Button1.Text = ("Aggiornamento scaricato correttamente.")
            If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.exe") <> "" Then
                Kill(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.exe")
            End If
            My.Computer.FileSystem.RenameFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.!moexe", "Minion One Setup.exe")
        Else
            Me.Text = ("Controllo degli aggiornamenti")
            Button1.Text = ("Il download dell'aggiornamento è stato interrotto.")
            Try
                If (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.!moexe") <> "" Then
                    Kill(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.!moexe")
                Else
                    Kill(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.exe")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        Me.Text = ("Controllo degli aggiornamenti - " & e.ProgressPercentage & "%")
        Dim progressione As New Size
        progressione.Height = BarraProgressione.Height
        progressione.Width = Fix((e.ProgressPercentage * 300) / 100)
        BarraProgressione.Size = progressione
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            If My.Computer.Network.IsAvailable Then
                CheckForUpdates()
                Timer3.Stop()
            Else
                MessaggioF.Text = ("Errore: Nessuna connessione disponibile")
                MessaggioF.Button1.Text = ("Non è stato possibile stabilire una connesione internet." & vbNewLine & "Codice errore: MOE7CCZ62M3")
                MessaggioF.DettagliErroreButton.Visible = True
                MessaggioF.ErroreTxt.Text = ("MOE7CCZ62M3")
                MessaggioF.ShowDialog()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ScaricaButton_Click(sender As Object, e As EventArgs) Handles ScaricaButton.Click
        If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Progetti\") = "" Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\")
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\")
        End If
        SaveFileDialog1.FileName = ("Minion One Setup")
        downloader.DownloadFileAsync(New Uri("http://minionone.altervista.org/Windows/ITA-IT/x86/Offline/Setup.exe"), (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.!moexe"))
        Timer1.Start()
        ScaricaButton.Enabled = False
        ScaricaDopoButton.Enabled = False
        Button1.Text = ("Download dell'aggiornamento...")
        Me.Text = ("Controllo degli aggiornamenti - 0%")
        Panel8.Visible = False
    End Sub

    Private Sub ScaricaDopoButton_Click(sender As Object, e As EventArgs) Handles ScaricaDopoButton.Click
        ScaricaButton.Enabled = False
        ScaricaDopoButton.Enabled = False
        Me.Close()
    End Sub

    Private Sub InstallaButton_Click(sender As Object, e As EventArgs) Handles InstallaButton.Click
        Dim Prc As New ProcessStartInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Minion One\Aggiornamenti\Minion One Setup.exe")
        Process.Start(Prc)
        End
    End Sub
End Class