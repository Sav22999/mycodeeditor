Imports System.Net
Public Class ControlloAggiornamenti

    Dim lungmax As Integer = 300
    Dim lunginiziale As Integer = 0
    Dim giascaricato As Boolean = False

    Private Sub ControlloAggiornamneti_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            downloader.CancelAsync()
        Catch ex As Exception

        End Try
        Me.Dispose()
        e.Cancel = False
    End Sub
    Private Sub ControlloAggiornamenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim percorso2 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            If My.Computer.FileSystem.FileExists(percorso2 & "\My Code Editor\Aggiornamenti\MyCE Updater.exe") And My.Computer.FileSystem.FileExists(percorso2 & "\My Code Editor\Aggiornamenti\MyCE.!MCEexe") Then
                ScaricaButton.Visible = False
                ScaricaDopoButton.Visible = False
                InstallaButton.Visible = True
                InstallaDopoButton.Visible = True
                Me.Text = MyCEF.TraduzioneLinguaTxt.Lines(347)
                Button1.Text = MyCEF.TraduzioneLinguaTxt.Lines(761)
                giascaricato = True
            Else
                Dim R As New Random
                Dim num As Integer = R.Next(4, 24)
                Timer3.Interval = num * 250
                If My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\") Then
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\")
                End If
                InstallaButton.Visible = False
                ScaricaButton.Visible = True
                ScaricaButton.Enabled = False
                ScaricaDopoButton.Visible = True
                ScaricaDopoButton.Enabled = False
                Button1.Text = (MyCEF.TraduzioneLinguaTxt.Lines(348))
                Me.Text = (MyCEF.TraduzioneLinguaTxt.Lines(347))
                Dim progressione As New Size
                progressione.Height = BarraProgressione.Height
                progressione.Width = 0
                BarraProgressione.Size = progressione
                Timer1.Start()
                Timer3.Start()
            End If
        Catch ex As Exception

        End Try
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
        Dim percorso2 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        If My.Computer.FileSystem.FileExists(percorso2 & "\My Code Editor\Aggiornamenti\MyCE Updater.exe") And My.Computer.FileSystem.FileExists(percorso2 & "\My Code Editor\Aggiornamenti\MyCE.!MCEexe") Then
            ScaricaButton.Visible = False
            ScaricaDopoButton.Visible = False
            InstallaButton.Visible = True
            InstallaDopoButton.Visible = True
            Me.Text = MyCEF.TraduzioneLinguaTxt.Lines(347)
            Button1.Text = MyCEF.TraduzioneLinguaTxt.Lines(761)
            giascaricato = True
            Me.WindowState = FormWindowState.Normal
        End If
        If Not giascaricato Then
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.saveriomorelli.com/mycodeeditor/Windows/x86/version.txt") 'link del file versione (il fle txt della versione) .txt
            Dim response As System.Net.HttpWebResponse = request.GetResponse()

            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            Dim newestversion As String = sr.ReadToEnd()
            Dim currentversion As String = Application.ProductVersion
            If newestversion.Contains(currentversion) Then
                If MyCEF.aggiornamentoscaricaautomaticamenteavvio = False Then
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
                    Button1.Text = (MyCEF.TraduzioneLinguaTxt.Lines(762))
                    Panel8.Visible = True
                    Me.WindowState = FormWindowState.Normal
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
                If MyCEF.aggiornamentoscaricaautomaticamenteavvio = False Then
                    Button1.Text = (MyCEF.TraduzioneLinguaTxt.Lines(763))
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
                    Me.WindowState = FormWindowState.Normal
                Else
                    Button1.Text = (MyCEF.TraduzioneLinguaTxt.Lines(763))
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
        End If
    End Sub

    Dim WithEvents downloader As New WebClient

    Private Sub downloader_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles downloader.DownloadFileCompleted
        If Not i = 29 Then
            i += 1
            'Button48.Text = "Installa"
            ScaricaButton.Enabled = True
            ScaricaButton.PerformClick()
            lunginiziale += lungmax / 29

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
            Timer1.Start()
        Else
            lunginiziale += lungmax / 29

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
            Timer1.Stop()
            Me.Text = MyCEF.TraduzioneLinguaTxt.Lines(764) & " - 100%"
        End If

        Try
            If Button1.Text <> MyCEF.TraduzioneLinguaTxt.Lines(765) Then
                If i = 29 And Me.Text.Contains("100%") Then

                    Dim s As Size = New Size()
                    s.Height = ProgressBarr.Height
                    's.Width = Fix((e.ProgressPercentage * lungmax) / 100)
                    s.Width = 586
                    ProgressBarr.Size = s

                    'controllo compatibità versione My Code Editor con la versione dell'installer
                    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://www.saveriomorelli.com/mycodeeditor/Windows/x86/version.txt") 'link del file versione (il fle txt della versione) .txt
                    Dim response As System.Net.HttpWebResponse = request.GetResponse()

                    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                    Dim newestversion As String = sr.ReadToEnd()

                    'versione corrente
                    Dim versionecorrente = newestversion

                    'creo file VERSIONE.mcesx
                    Button1.Text = MyCEF.TraduzioneLinguaTxt.Lines(766)
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\VERSIONE.!MCEmcesx", versionecorrente)


                    Panel8.Visible = True
                    ProgressBarr.Visible = False
                    BarraProgressione.Visible = False

                    Me.Text = MyCEF.TraduzioneLinguaTxt.Lines(347)
                    Button1.Text = MyCEF.TraduzioneLinguaTxt.Lines(761)
                    ScaricaButton.Visible = False
                    ScaricaDopoButton.Visible = False
                    If MyCEF.aggiornamentoscaricaautomaticamenteavvio = False Then
                        InstallaButton.Visible = True
                        InstallaDopoButton.Visible = True
                    Else
                        InstallaButton.Visible = True
                        InstallaDopoButton.Visible = True
                        InstallaButton.PerformClick()
                    End If

                    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\"
                        If My.Computer.FileSystem.DirectoryExists(path) Then
                            IO.File.SetAttributes(path, IO.FileAttributes.Hidden)
                        End If

                    End If
                End If
        Catch ex As Exception
            Button1.Text = "Errore 001"
        End Try

    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        Dim progressione As New Size
        progressione.Height = BarraProgressione.Height
        progressione.Width = Fix((e.ProgressPercentage * lungmax) / 100)
        BarraProgressione.Size = progressione

        If i = 1 Then
            url = "https://mycodeeditor.com/Installer/FastColoredTextBox.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\FastColoredTextBox.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " FastColoredTextBox.dll..."
        ElseIf i = 2 Then
            url = "https://mycodeeditor.com/Installer/MOTITAIT.mcelang"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\italian.!MCEmcelang"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " MOTITAIT.mcelang..."
        ElseIf i = 3 Then
            url = "https://mycodeeditor.com/Installer/MOTENGUK.mcelang"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\english-uk.!MCEmcelang"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " MOTENGUK.mcelang..."
        ElseIf i = 4 Then
            url = "https://mycodeeditor.com/Installer/MOTENGUS.mcelang"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\english-us.!MCEmcelang"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " MOTENGUS.mcelang..."
        ElseIf i = 5 Then
            url = "https://mycodeeditor.com/Installer/MOTFRAFR.mcelang"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\french.!MCEmcelang"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " MOTFRAFR.mcelang..."
        ElseIf i = 6 Then
            url = "https://mycodeeditor.com/Installer/MOTDEUDE.mcelang"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\german.!MCEmcelang"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " MOTDEUDE.mcelang..."
        ElseIf i = 7 Then
            url = "https://mycodeeditor.com/Installer/MOTESPES.mcelang"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\spanish.!MCEmcelang"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " MOTESPES.mcelang.."
        ElseIf i = 8 Then
            url = "https://mycodeeditor.com/Installer/MOTPYCPO.mcelang"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\russian.!MCEmcelang"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " MOTPYCPO.mcelang..."
        ElseIf i = 9 Then
            url = "https://mycodeeditor.com/Installer/WebKit/CFLite.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\CFLite.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " CFLite.dll..."
        ElseIf i = 10 Then
            url = "https://mycodeeditor.com/Installer/WebKit/icudt40.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\icudt40.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " icudt40.dll..."
        ElseIf i = 11 Then
            url = "https://mycodeeditor.com/Installer/WebKit/icuin40.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\icuin40.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " icuin40.dll..."
        ElseIf i = 12 Then
            url = "https://mycodeeditor.com/Installer/WebKit/icuuc40.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\icuuc40.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " icuuc40.dll..."
        ElseIf i = 13 Then
            url = "https://mycodeeditor.com/Installer/WebKit/JavaScriptCore.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\JavaScriptCore.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " JavaScriptCore.dll..."
        ElseIf i = 14 Then
            url = "https://mycodeeditor.com/Installer/WebKit/libcurl.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libcurl.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " libcurl.dll..."
        ElseIf i = 15 Then
            url = "https://mycodeeditor.com/Installer/WebKit/libeay32.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libeay32.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " libeay32.dll..."
        ElseIf i = 16 Then
            url = "https://mycodeeditor.com/Installer/WebKit/libexslt.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libexslt.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " libexslt.dll..."
        ElseIf i = 17 Then
            url = "https://mycodeeditor.com/Installer/WebKit/libxml2.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libxml2.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " libxml2.dll..."
        ElseIf i = 18 Then
            url = "https://mycodeeditor.com/Installer/WebKit/libxslt.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libxslt.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " libxslt.dll..."
        ElseIf i = 19 Then
            url = "https://mycodeeditor.com/Installer/WebKit/objc.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\objc.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " objc.dll..."
        ElseIf i = 20 Then
            url = "https://mycodeeditor.com/Installer/WebKit/pthreadVC2.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\pthreadVC2.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " pthreadVC2.dll..."
        ElseIf i = 21 Then
            url = "https://mycodeeditor.com/Installer/WebKit/SQLite3.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\SQLite3.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " SQLite3.dll..."
        ElseIf i = 22 Then
            url = "https://mycodeeditor.com/Installer/WebKit/ssleay32.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\ssleay32.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " ssleav32.dll..."
        ElseIf i = 23 Then
            url = "https://mycodeeditor.com/Installer/WebKit/WebKit.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\WebKit.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " WebKit.dll..."
        ElseIf i = 24 Then
            url = "https://mycodeeditor.com/Installer/WebKit/WebKit.Interop.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\WebKit.Interop.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " WebKit.Interop.dll..."
        ElseIf i = 25 Then
            url = "https://mycodeeditor.com/Installer/WebKit/WebKitBrowser.dll"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\WebKitBrowser.!MCEdll"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " WebKitBrowser.dll..."
        ElseIf i = 26 Then
            url = "https://mycodeeditor.com/Installer/WebKit/WebKitBrowser.dll.manifest"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\WebKitBrowser.dll.!MCEmanifest"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " WebKitBrowser.dll.manifest..."
        ElseIf i = 27 Then
            url = "https://mycodeeditor.com/Installer/MyCE.exe"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\MyCE.!MCEexe"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " My Code Editor..."
        ElseIf i = 28 Then
            url = "https://mycodeeditor.com/Installer/MyCE Uninstaller.exe"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\MyCE Uninstaller.!MCEexe"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " My Code Editor Uninstaller..."
        ElseIf i = 29 Then
            url = "https://mycodeeditor.com/Installer/MyCE Updater.exe"
            dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\MyCE Updater.exe"
            msg = MyCEF.TraduzioneLinguaTxt.Lines(767) & " My Code Editor Updater..."
        End If

        ProgressBarr.Visible = True
        Panel8.Visible = False

        Button1.Text = msg & " " & e.ProgressPercentage & "%"
        Dim perc As Integer = e.ProgressPercentage
        Dim lungmaxi As Integer = lungmax / 29
        Dim lungi As Integer = perc * lungmaxi / 100

        Dim lunghezza = lunginiziale + lungi

        Dim s As Size = New Size()
        s.Height = ProgressBarr.Height
        's.Width = Fix((e.ProgressPercentage * lungmax) / 100)
        s.Width = lunghezza
        ProgressBarr.Size = s

        Dim percentualetotale As Integer = lunghezza * 100 / lungmax
        Me.Text = MyCEF.TraduzioneLinguaTxt.Lines(764) & " - " & percentualetotale & "%"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            If My.Computer.Network.IsAvailable Then
                CheckForUpdates()
                Timer3.Stop()
            Else
                MessaggioF.Text = (MyCEF.TraduzioneLinguaTxt.Lines(768))
                MessaggioF.Button1.Text = (MyCEF.TraduzioneLinguaTxt.Lines(769) & vbNewLine & MyCEF.TraduzioneLinguaTxt.Lines(770) & " MOE7CCZ62M3")
                MessaggioF.DettagliErroreButton.Visible = True
                MessaggioF.ErroreTxt.Text = ("MOE7CCZ62M3")
                MessaggioF.ShowDialog()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Dim url As String = ""
    Dim dest As String = ""
    Dim msg As String = ""
    Public i As Integer = 0

    Private Sub ScaricaButton_Click(sender As Object, e As EventArgs) Handles ScaricaButton.Click
        Process.Start("https://mycodeeditor.com/Download/")
        Me.Close()
        'If i = 0 Then
        '    If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\") = "" Then
        '        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
        '        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\")
        '    End If

        '    Dim percorso As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        '    If Not My.Computer.FileSystem.DirectoryExists(percorso & "\My Code Editor\Aggiornamenti\") Then
        '        My.Computer.FileSystem.CreateDirectory(percorso & "\My Code Editor\Aggiornamenti\")
        '    End If
        '    If Not My.Computer.FileSystem.DirectoryExists(percorso & "\My Code Editor\Aggiornamenti\Language\") Then
        '        My.Computer.FileSystem.CreateDirectory(percorso & "\My Code Editor\Aggiornamenti\Language\")
        '    End If
        '    If Not My.Computer.FileSystem.DirectoryExists(percorso & "\My Code Editor\Aggiornamenti\Language\") Then
        '        My.Computer.FileSystem.CreateDirectory(percorso & "\My Code Editor\Aggiornamenti\Language\")
        '    End If
        '    If Not My.Computer.FileSystem.DirectoryExists(percorso & "\My Code Editor\Aggiornamenti\Language\") Then
        '        My.Computer.FileSystem.CreateDirectory(percorso & "\My Code Editor\Aggiornamenti\Language\")
        '    End If
        '    i += 1
        'End If

        'Try
        '    If i = 1 Then
        '        url = "https://mycodeeditor.com/Installer/FastColoredTextBox.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Installer\FastColoredTextBox.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " FastColoredTextBox.dll"
        '    ElseIf i = 2 Then
        '        url = "https://mycodeeditor.com/Installer/MOTITAIT.mcelang"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\italian.!MCEmcelang"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " MOTITAIT.mcelang..."
        '    ElseIf i = 3 Then
        '        url = "https://mycodeeditor.com/Installer/MOTENGUK.mcelang"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\english-uk.!MCEmcelang"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " MOTENGUK.mcelang..."
        '    ElseIf i = 4 Then
        '        url = "https://mycodeeditor.com/Installer/MOTENGUS.mcelang"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\english-us.!MCEmcelang"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " MOTENGUS.mcelang..."
        '    ElseIf i = 5 Then
        '        url = "https://mycodeeditor.com/Installer/MOTFRAFR.mcelang"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\french.!MCEmcelang"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " MOTFRAFR.mcelang..."
        '    ElseIf i = 6 Then
        '        url = "https://mycodeeditor.com/Installer/MOTDEUDE.mcelang"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\german.!MCEmcelang"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " MOTDEUDE.mcelang..."
        '    ElseIf i = 7 Then
        '        url = "https://mycodeeditor.com/Installer/MOTESPES.mcelang"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\spanish.!MCEmcelang"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " MOTESPES.mcelang..."
        '    ElseIf i = 8 Then
        '        url = "https://mycodeeditor.com/Installer/MOTPYCPO.mcelang"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\Language\russian.!MCEmcelang"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " MOTPYCPO.mcelang..."
        '    ElseIf i = 9 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/CFLite.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\CFLite.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " CFLite.dll..."
        '    ElseIf i = 10 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/icudt40.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\icudt40.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " icudt40.dll..."
        '    ElseIf i = 11 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/icuin40.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\icuin40.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " icuin40.dll..."
        '    ElseIf i = 12 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/icuuc40.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\icuuc40.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " icuuc40.dll..."
        '    ElseIf i = 13 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/JavaScriptCore.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\JavaScriptCore.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " JavaScriptCore.dll..."
        '    ElseIf i = 14 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/libcurl.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libcurl.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " libcurl.dll..."
        '    ElseIf i = 15 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/libeay32.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libeay32.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " libeay32.dll..."
        '    ElseIf i = 16 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/libexslt.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libexslt.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " libexslt.dll..."
        '    ElseIf i = 17 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/libxml2.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libxml2.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " libxml2.dll..."
        '    ElseIf i = 18 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/libxslt.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\libxslt.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " libxslt.dll..."
        '    ElseIf i = 19 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/objc.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\objc.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " objc.dll..."
        '    ElseIf i = 20 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/pthreadVC2.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\pthreadVC2.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " pthreadVC2.dll..."
        '    ElseIf i = 21 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/SQLite3.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\SQLite3.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " SQLite3.dll..."
        '    ElseIf i = 22 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/ssleay32.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\ssleay32.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " ssleay32.dll..."
        '    ElseIf i = 23 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/WebKit.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\WebKit.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " WebKit.dll..."
        '    ElseIf i = 24 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/WebKit.Interop.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\WebKit.Interop.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " WebKit.Interop.dll..."
        '    ElseIf i = 25 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/WebKitBrowser.dll"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\WebKitBrowser.!MCEdll"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " WebKitBrowser.dll..."
        '    ElseIf i = 26 Then
        '        url = "https://mycodeeditor.com/Installer/WebKit/WebKitBrowser.dll.manifest"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\WebKitBrowser.dll.!MCEmanifest"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " WebKitBrowser.dll.manifest..."
        '    ElseIf i = 27 Then
        '        url = "https://mycodeeditor.com/Installer/MyCE.exe"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\MyCE.!MCEexe"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " My Code Editor..."
        '    ElseIf i = 28 Then
        '        url = "https://mycodeeditor.com/Installer/MyCE Uninstaller.exe"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\MyCE Uninstaller.!MCEexe"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " My Code Editor Uninstaller..."
        '    ElseIf i = 29 Then
        '        url = "https://mycodeeditor.com/Installer/MyCE Updater.exe"
        '        dest = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\MyCE Updater.exe"
        '        msg = MyCEF.TraduzioneLinguaTxt.Lines(771) & " My Code Editor Updater..."
        '    End If

        '    Button1.Text = msg
        '    downloader.DownloadFileAsync(New Uri(url), dest)
        '    Timer1.Start()
        '    ScaricaButton.Enabled = False
        '    ScaricaDopoButton.Enabled = False
        '    Panel8.Visible = False
        '    ProgressBarr.Visible = True
        'Catch

        'End Try
    End Sub

    Private Sub ScaricaDopoButton_Click(sender As Object, e As EventArgs) Handles ScaricaDopoButton.Click
        ScaricaButton.Enabled = False
        ScaricaDopoButton.Enabled = False
        Me.Close()
    End Sub

    Private Sub InstallaButton_Click(sender As Object, e As EventArgs) Handles InstallaButton.Click
        MessaggioF.Close()
        MessaggioF.Text = MyCEF.TraduzioneLinguaTxt.Lines(772)
        MessaggioF.Button1.Text = MyCEF.TraduzioneLinguaTxt.Lines(773)
        MessaggioF.ShowDialog()
        MyCEF.salvatutto_func()
        Dim Prc As New ProcessStartInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Aggiornamenti\MyCE Updater.exe")
        Try
            Process.Start(Prc)
        Catch es As Exception

        End Try
        End
    End Sub

    Private Sub InstallaDopoButton_Click(sender As Object, e As EventArgs) Handles InstallaDopoButton.Click
        Me.Close()
    End Sub
End Class