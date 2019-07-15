Public NotInheritable Class MinionOneAvvio
    Private IsFormBeingDragged As Boolean = True
    Private Sub MinionOneAvvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer3.Start()

        If My.Settings.colorebordi = ("black") Then
            Button5.FlatAppearance.BorderColor = Color.Black
            Button5.ForeColor = Color.Gray
        ElseIf My.Settings.colorebordi = ("gray") Then
            Button5.FlatAppearance.BorderColor = Color.Gray
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("white") Then
            Button5.FlatAppearance.BorderColor = Color.White
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("yellow") Then
            Button5.FlatAppearance.BorderColor = Color.Yellow
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("gold") Then
            Button5.FlatAppearance.BorderColor = Color.Gold
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("orangered") Then
            Button5.FlatAppearance.BorderColor = Color.OrangeRed
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("red") Then
            Button5.FlatAppearance.BorderColor = Color.Red
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("fuchsia") Then
            Button5.FlatAppearance.BorderColor = Color.Fuchsia
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("purple") Then
            Button5.FlatAppearance.BorderColor = Color.Purple
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("navy") Then
            Button5.FlatAppearance.BorderColor = Color.Navy
            Button5.ForeColor = Color.Gray
        ElseIf My.Settings.colorebordi = ("blue") Then
            Button5.FlatAppearance.BorderColor = Color.Blue
            Button5.ForeColor = Color.Gray
        ElseIf My.Settings.colorebordi = ("cyan") Then
            Button5.FlatAppearance.BorderColor = Color.Cyan
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("teal") Then
            Button5.FlatAppearance.BorderColor = Color.Teal
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("green") Then
            Button5.FlatAppearance.BorderColor = Color.Green
            Button5.ForeColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("lime") Then
            Button5.FlatAppearance.BorderColor = Color.Lime
            Button5.ForeColor = Color.Navy
        End If
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
        ElseIf TextBox2.Text = ("60") Then
            Label1.Text = ("Soltanto un attimo...")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class
