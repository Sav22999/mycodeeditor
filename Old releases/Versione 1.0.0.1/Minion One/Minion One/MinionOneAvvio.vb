Public NotInheritable Class MinionOneAvvio
    Private IsFormBeingDragged As Boolean = True
    Private Sub MinionOneAvvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer3.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If PictureBox1.Location.X = ("547") Or PictureBox1.Location.X > ("547") Then
                Timer2.Start()
                Timer1.Stop()
            Else
                TextBox1.Text = PictureBox1.Location.X + 5
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.Y = ("397")
                    temp.X = TextBox1.Text
                    PictureBox1.Location = temp
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            If PictureBox1.Location.X = ("-95") Or PictureBox1.Location.X < ("-95") Then
                Timer1.Start()
                Timer2.Stop()
            Else
                TextBox1.Text = PictureBox1.Location.X - 5
                If IsFormBeingDragged Then
                    Dim temp As Point = New Point()
                    temp.X = TextBox1.Text
                    temp.Y = ("397")
                    PictureBox1.Location = temp
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        TextBox2.Text = (TextBox2.Text + 1)
        If TextBox2.Text = ("25") Then
            Label1.Text = ("Controllo componenti...")
        ElseIf TextBox2.Text = ("30") Then
            Label1.Text = ("Controllo errori...")
        ElseIf TextBox2.Text = ("45") Then
            Label1.Text = ("Riparazione errori...")
        ElseIf TextBox2.Text = ("50") Then
            Label1.Text = ("Apertura Minion One...")
        End If
    End Sub
End Class
