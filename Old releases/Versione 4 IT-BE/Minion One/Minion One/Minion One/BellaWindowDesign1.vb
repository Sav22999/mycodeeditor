Public Class MinionOne
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Panel4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseDown, Button8.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Panel4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseMove, Button8.MouseMove
        If MuoviSiNo.Text = ("si") Then
            If IsFormBeingDragged Then
                Dim temp As Point = New Point()
                temp.X = Me.Location.X + (e.X - MouseDownX)
                temp.Y = Me.Location.Y + (e.Y - MouseDownY)
                Me.Location = temp
                temp = Nothing
            End If
        End If
    End Sub
    Private Sub Panel4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseUp, Button8.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Bottone Chiudi MyWindow
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If IsFormBeingDragged Then
            Dim temp2 As Point = New Point()
            temp2.X = Me.Size.Width + (e.X - MouseDownX)
            temp2.Y = Me.Size.Height
            Me.Size = temp2
            temp2 = Nothing
        End If
    End Sub
    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Panel3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Size.Width
            temp.Y = Me.Size.Height + (e.Y - MouseDownY)
            Me.Size = temp
            temp = Nothing
        End If
    End Sub
    Private Sub Panel3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Panel5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Panel5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseMove
        If IsFormBeingDragged Then
            Dim tempp As Point = New Point()
            tempp.Y = Me.Size.Height + (e.X - MouseDownX)
            tempp.X = Me.Size.Width + (e.X - MouseDownX)
            Me.Size = tempp
            tempp = Nothing
        End If
    End Sub
    Private Sub Panel5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Bottone Ingrandisci/Ripristina a normale MyWindow
        If Button4.Enabled = True And Button5.Enabled = False Then
            Dim temp As Point = New Point()
            temp.Y = "480"
            temp.X = "660"
            Me.Size = temp
            temp = Nothing
            Button4.Enabled = False
            Button5.Enabled = True
            Button2.BackgroundImage = My.Resources.ingrandisci_finestra
            Dim loca As Point = New Point()
            loca.Y = (My.Settings.height / 2) - 240
            loca.X = (My.Settings.width / 2) - 330
            Me.Location = loca
            loca = Nothing
            Panel1.Enabled = True
            Panel5.Enabled = True
            Panel3.Enabled = True
            MuoviSiNo.Text = ("si")
        ElseIf Button4.Enabled = False And Button5.Enabled = True Then
            Dim temp As Point = New Point()
            temp.Y = My.Settings.height - 16
            temp.X = My.Settings.width - 16
            Me.Size = temp
            temp = Nothing
            Button4.Enabled = True
            Button5.Enabled = False
            Button2.BackgroundImage = My.Resources.ripristina_finestra
            Dim loca As Point = New Point()
            loca.Y = "0"
            loca.X = "0"
            Me.Location = loca
            loca = Nothing
            Panel1.Enabled = False
            Panel5.Enabled = False
            Panel3.Enabled = False
            MuoviSiNo.Text = ("no")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Bottone Riduci a icona MyWindow
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Icona Click apre il menù
        Panel6.Visible = True
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        'Icona DoppioCLick chiude la finestra
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim temp As Point = New Point()
        temp.Y = My.Settings.height - 16
        temp.X = My.Settings.width - 16
        Me.Size = temp
        temp = Nothing
        Button4.Enabled = True
        Button5.Enabled = False
        Button2.BackgroundImage = My.Resources.ripristina_finestra
        Dim loca As Point = New Point()
        loca.Y = "0"
        loca.X = "0"
        Me.Location = loca
        loca = Nothing
        Panel1.Enabled = False
        Panel5.Enabled = False
        Panel3.Enabled = False
        MuoviSiNo.Text = ("no")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim temp As Point = New Point()
        temp.Y = "480"
        temp.X = "660"
        Me.Size = temp
        temp = Nothing
        Button4.Enabled = False
        Button5.Enabled = True
        Button2.BackgroundImage = My.Resources.ingrandisci_finestra
        Dim loca As Point = New Point()
        loca.Y = (My.Settings.height / 2) - 240
        loca.X = (My.Settings.width / 2) - 330
        Me.Location = loca
        loca = Nothing
        Panel1.Enabled = True
        Panel5.Enabled = True
        Panel3.Enabled = True
        MuoviSiNo.Text = ("si")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Panel7_MouseLeave(sender As Object, e As EventArgs) Handles Panel7.MouseLeave, Panel9.MouseLeave, Panel10.MouseLeave
        Panel6.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub MinionOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GrandezzaFinestra.Show()

        Dim temp As Point = New Point()
        temp.Y = My.Settings.height - 16
        temp.X = My.Settings.width - 16
        Me.Size = temp
        temp = Nothing
        Button4.Enabled = True
        Button5.Enabled = False
        Button2.BackgroundImage = My.Resources.ripristina_finestra
        Dim loca As Point = New Point()
        loca.Y = "0"
        loca.X = "0"
        Me.Location = loca
        loca = Nothing
        Panel1.Enabled = False
        Panel5.Enabled = False
        Panel3.Enabled = False
        MuoviSiNo.Text = ("no")

    End Sub
End Class
