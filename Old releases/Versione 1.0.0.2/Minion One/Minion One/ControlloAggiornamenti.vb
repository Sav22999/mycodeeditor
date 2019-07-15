Public Class ControlloAggiornamenti
    Public Sub CheckForUpdates()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://www.retminion.altervista.org/MinionOne/Software/versione.txt") 'link del file versione (il fle txt della versione) .txt
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            Button3.Text = ("Nessun aggiornamento trovato.")
            Button2.Enabled = False
            Button30.Enabled = False
            Timer1.Stop()
            Timer2.Stop()
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
        Else
            Button3.Text = ("Aggiornamento trovato.")
            Button2.Enabled = True
            Button30.Enabled = True
            Timer1.Stop()
            Timer2.Stop()
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
        End If
    End Sub

    Private Sub ControlloAggiornamenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer3.Start()
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

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        System.Diagnostics.Process.Start("http://www.retminion.altervista.org/MinionOne/Software/MinionOneInstall.exe") 'link della nuova versione del software (la versione aggiornata) .exe
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        CheckForUpdates()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class