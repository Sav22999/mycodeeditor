Public Class Paragrafo

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

    Private Sub Paragrafo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
        If My.Settings.finestremenuinseriscitopmost = ("si") Then
            Me.TopMost = True
        ElseIf My.Settings.finestremenuinseriscitopmost = ("no") Then
            Me.TopMost = False
        End If

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
        If TextBox1.Text = ("") Then
        Else
            MinionOne.TESTOINCOLLATO.Paste()
            MinionOne.TESTODAINSERIRE.Text = ("<p style=" & Chr(34) & "color:'" & colore.Text & "'" & Chr(34) & ">")
            If grassetto.Text = ("Bsi") Then
                MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & "<b>")
            Else
            End If
            If corsivo.Text = ("Isi") Then
                MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & "<i>")
            Else
            End If
            If sottolineato.Text = ("Usi") Then
                MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & "<u>")
            Else
            End If
            If sbarrato.Text = ("Ssi") Then
                MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & "<s>")
            Else
            End If
            MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & Environment.NewLine & TextBox1.Text & Environment.NewLine)
            If grassetto.Text = ("Bsi") Then
                MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & "</b>")
            Else
            End If
            If corsivo.Text = ("Isi") Then
                MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & "</i>")
            Else
            End If
            If sottolineato.Text = ("Usi") Then
                MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & "</u>")
            Else
            End If
            If sbarrato.Text = ("Ssi") Then
                MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & "</s>")
            Else
            End If
            MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & "</p>")
            MinionOne.TESTODAINSERIRE.SelectAll()
            MinionOne.TESTODAINSERIRE.Copy()
            MinionOne.FastColoredTextBox1.Paste()
            MinionOne.TESTOINCOLLATO.SelectAll()
            MinionOne.TESTOINCOLLATO.Copy()
            MinionOne.FastColoredTextBox1.Select()
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If Button31.BackColor = Color.Red Then
            Button31.BackColor = Color.DarkRed
            grassetto.Text = ("Bno")
        Else
            Button31.BackColor = Color.Red
            grassetto.Text = ("Bsi")
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If Button32.BackColor = Color.Red Then
            Button32.BackColor = Color.DarkRed
            corsivo.Text = ("Ino")
        Else
            Button32.BackColor = Color.Red
            corsivo.Text = ("Isi")
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If Button33.BackColor = Color.Red Then
            Button33.BackColor = Color.DarkRed
            sottolineato.Text = ("Uno")
        Else
            Button33.BackColor = Color.Red
            sottolineato.Text = ("Usi")
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If Button34.BackColor = Color.Red Then
            Button34.BackColor = Color.DarkRed
            sbarrato.Text = ("Sno")
        Else
            Button34.BackColor = Color.Red
            sbarrato.Text = ("Ssi")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AntColo.BackColor = Color.White
        colore.Text = ("white")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AntColo.BackColor = Color.Silver
        colore.Text = ("silver")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AntColo.BackColor = Color.Gray
        colore.Text = ("gray")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AntColo.BackColor = Color.Blue
        colore.Text = ("blue")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AntColo.BackColor = Color.Navy
        colore.Text = ("navy")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AntColo.BackColor = Color.Black
        colore.Text = ("black")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        AntColo.BackColor = Color.Green
        colore.Text = ("green")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AntColo.BackColor = Color.Teal
        colore.Text = ("teal")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AntColo.BackColor = Color.Cyan
        colore.Text = ("cyan")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        AntColo.BackColor = Color.Yellow
        colore.Text = ("yellow")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        AntColo.BackColor = Color.Olive
        colore.Text = ("olive")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        AntColo.BackColor = Color.Lime
        colore.Text = ("lime")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        AntColo.BackColor = Color.Maroon
        colore.Text = ("maroon")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        AntColo.BackColor = Color.SaddleBrown
        colore.Text = ("saddlebrown")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        AntColo.BackColor = Color.Orange
        colore.Text = ("orange")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        AntColo.BackColor = Color.Red
        colore.Text = ("red")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        AntColo.BackColor = Color.Fuchsia
        colore.Text = ("fuchsia")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        AntColo.BackColor = Color.Purple
        colore.Text = ("purple")
    End Sub
End Class