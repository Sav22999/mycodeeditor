Public Class Stile
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Panel4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Panel4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub Panel4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Bottone Chiudi MyWindow
        Me.Close()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Stile1.Click
        Stile1.BackColor = Panel1.BackColor
        Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile1.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile2.BackColor = Panel1.BackColor
        Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile2.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile3.BackColor = Panel1.BackColor
        Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile3.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile4.BackColor = Panel1.BackColor
        Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile4.FlatAppearance.MouseOverBackColor = Color.Silver

        Stile1.BackColor = Color.Gray
        Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile1.FlatAppearance.MouseOverBackColor = Color.Gray

        StileTB.Text = ("solid")
        PictureBox2.BackgroundImage = (Stile1.Image)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Stile2.Click
        Stile1.BackColor = Panel1.BackColor
        Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile1.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile2.BackColor = Panel1.BackColor
        Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile2.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile3.BackColor = Panel1.BackColor
        Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile3.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile4.BackColor = Panel1.BackColor
        Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile4.FlatAppearance.MouseOverBackColor = Color.Silver

        Stile2.BackColor = Color.Gray
        Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile2.FlatAppearance.MouseOverBackColor = Color.Gray

        StileTB.Text = ("double")
        PictureBox2.BackgroundImage = (Stile2.Image)
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Stile3.Click
        Stile1.BackColor = Panel1.BackColor
        Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile1.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile2.BackColor = Panel1.BackColor
        Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile2.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile3.BackColor = Panel1.BackColor
        Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile3.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile4.BackColor = Panel1.BackColor
        Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile4.FlatAppearance.MouseOverBackColor = Color.Silver

        Stile3.BackColor = Color.Gray
        Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile3.FlatAppearance.MouseOverBackColor = Color.Gray

        StileTB.Text = ("dotted")
        PictureBox2.BackgroundImage = (Stile3.Image)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Stile4.Click
        Stile1.BackColor = Panel1.BackColor
        Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile1.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile2.BackColor = Panel1.BackColor
        Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile2.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile3.BackColor = Panel1.BackColor
        Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile3.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile4.BackColor = Panel1.BackColor
        Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile4.FlatAppearance.MouseOverBackColor = Color.Silver

        Stile4.BackColor = Color.Gray
        Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile4.FlatAppearance.MouseOverBackColor = Color.Gray

        StileTB.Text = ("dashed")
        PictureBox2.BackgroundImage = (Stile4.Image)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Dove.Text = ("BottoneBordi") Then
            Bottone.Panel18.BackgroundImage = (PictureBox2.BackgroundImage)
            Bottone.TextBox18.Text = (StileTB.Text)

            Stile1.BackColor = Panel1.BackColor
            Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile1.FlatAppearance.MouseOverBackColor = Color.Silver
            Stile2.BackColor = Panel1.BackColor
            Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile2.FlatAppearance.MouseOverBackColor = Color.Silver
            Stile3.BackColor = Panel1.BackColor
            Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile3.FlatAppearance.MouseOverBackColor = Color.Silver
            Stile4.BackColor = Panel1.BackColor
            Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile4.FlatAppearance.MouseOverBackColor = Color.Silver

            StileTB.Text = ("")
            PictureBox2.BackgroundImage = My.Resources.niente

            Me.Close()
        ElseIf Dove.Text = ("ContenitoreBordi") Then
            Contenitore.Panel18.BackgroundImage = (PictureBox2.BackgroundImage)
            Contenitore.TextBox18.Text = (StileTB.Text)

            Stile1.BackColor = Panel1.BackColor
            Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile1.FlatAppearance.MouseOverBackColor = Color.Silver
            Stile2.BackColor = Panel1.BackColor
            Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile2.FlatAppearance.MouseOverBackColor = Color.Silver
            Stile3.BackColor = Panel1.BackColor
            Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile3.FlatAppearance.MouseOverBackColor = Color.Silver
            Stile4.BackColor = Panel1.BackColor
            Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile4.FlatAppearance.MouseOverBackColor = Color.Silver

            StileTB.Text = ("")
            PictureBox2.BackgroundImage = My.Resources.niente

            Me.Close()
        ElseIf Dove.Text = ("TabellaBordi") Then
            Tabella.Panel18.BackgroundImage = (PictureBox2.BackgroundImage)
            Tabella.TextBox18.Text = (StileTB.Text)

            Stile1.BackColor = Panel1.BackColor
            Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile1.FlatAppearance.MouseOverBackColor = Color.Silver
            Stile2.BackColor = Panel1.BackColor
            Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile2.FlatAppearance.MouseOverBackColor = Color.Silver
            Stile3.BackColor = Panel1.BackColor
            Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile3.FlatAppearance.MouseOverBackColor = Color.Silver
            Stile4.BackColor = Panel1.BackColor
            Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile4.FlatAppearance.MouseOverBackColor = Color.Silver

            StileTB.Text = ("")
            PictureBox2.BackgroundImage = My.Resources.niente

            Me.Close()
        End If
    End Sub

    Private Sub Stile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
