Public Class TestoPersonalizzato

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



    Private Sub TestoPersonalizzato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        AntSpes.Text = ("1")
        spessore.Text = ("1")
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        AntSpes.Text = ("2")
        spessore.Text = ("2")
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        AntSpes.Text = ("3")
        spessore.Text = ("3")
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        AntSpes.Text = ("4")
        spessore.Text = ("4")
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        AntSpes.Text = ("5")
        spessore.Text = ("5")
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        AntSpes.Text = ("6")
        spessore.Text = ("6")
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        AntSpes.Text = ("7")
        spessore.Text = ("7")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        AntCara.Text = ("Arial")
        carattere.Text = ("Arial")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        AntCara.Text = ("Times New Roman")
        carattere.Text = ("Times New Roman")
    End Sub

    Private Sub AntCara_Click(sender As Object, e As EventArgs) Handles AntCara.Click

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        AntCara.Text = ("Cambria")
        carattere.Text = ("Cambria")
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        AntCara.Text = ("Comic Sans MS")
        carattere.Text = ("Comic Sans MS")
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        AntCara.Text = ("Courier")
        carattere.Text = ("Courier")
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        AntCara.Text = ("Verdana")
        carattere.Text = ("Verdana")
    End Sub

    Private Sub spessore_TextChanged(sender As Object, e As EventArgs) Handles spessore.TextChanged

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = ("") Then
        Else
            MinionOne.TESTOINCOLLATO.Paste()
            MinionOne.TESTODAINSERIRE.Text = ("<font" & " style=" & Chr(34) & "background-color:" & sfondo.Text & ";" & Chr(34) & " color=" & Chr(34) & colore.Text & Chr(34) & " face=" & Chr(34) & carattere.Text & Chr(34) & " size=" & Chr(34) & spessore.Text & Chr(34) & ">" & TextBox1.Text & "</font>")
            If grassetto.Text = ("Bsi") Then
                MinionOne.TESTODAINSERIRE.Text = ("<b>" & MinionOne.TESTODAINSERIRE.Text & "</b>")
            Else
            End If
            If corsivo.Text = ("Isi") Then
                MinionOne.TESTODAINSERIRE.Text = ("<i>" & MinionOne.TESTODAINSERIRE.Text & "</i>")
            Else
            End If
            If sottolineato.Text = ("Usi") Then
                MinionOne.TESTODAINSERIRE.Text = ("<u>" & MinionOne.TESTODAINSERIRE.Text & "</u>")
            Else
            End If
            If sbarrato.Text = ("Ssi") Then
                MinionOne.TESTODAINSERIRE.Text = ("<s>" & MinionOne.TESTODAINSERIRE.Text & "</s>")
            Else
            End If
            MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & Environment.NewLine)
            MinionOne.TESTODAINSERIRE.SelectAll()
            MinionOne.TESTODAINSERIRE.Copy()
            MinionOne.FastColoredTextBox1.Paste()
            MinionOne.TESTOINCOLLATO.SelectAll()
            MinionOne.TESTOINCOLLATO.Copy()
            MinionOne.FastColoredTextBox1.Select()
            Me.Close()
        End If
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        AntSfo.BackColor = Color.White
        sfondo.Text = ("white")
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        AntSfo.BackColor = Color.Silver
        sfondo.Text = ("silver")
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        AntSfo.BackColor = Color.Gray
        sfondo.Text = ("gray")
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        AntSfo.BackColor = Color.Blue
        sfondo.Text = ("blue")
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        AntSfo.BackColor = Color.Navy
        sfondo.Text = ("navy")
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        AntSfo.BackColor = Color.Black
        sfondo.Text = ("black")
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        AntSfo.BackColor = Color.Cyan
        sfondo.Text = ("cyan")
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        AntSfo.BackColor = Color.Teal
        sfondo.Text = ("teal")
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        AntSfo.BackColor = Color.Green
        sfondo.Text = ("green")
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        AntSfo.BackColor = Color.Lime
        sfondo.Text = ("lime")
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        AntSfo.BackColor = Color.Maroon
        sfondo.Text = ("maroon")
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        AntSfo.BackColor = Color.Olive
        sfondo.Text = ("olive")
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        AntSfo.BackColor = Color.Yellow
        sfondo.Text = ("yellow")
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        AntSfo.BackColor = Color.Orange
        sfondo.Text = ("orange")
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        AntSfo.BackColor = Color.SaddleBrown
        sfondo.Text = ("saddlebrown")
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        AntSfo.BackColor = Color.Red
        sfondo.Text = ("red")
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        AntSfo.BackColor = Color.Fuchsia
        sfondo.Text = ("fuchsia")
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        AntSfo.BackColor = Color.Purple
        sfondo.Text = ("purple")
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        If AntSfo.BackColor = Color.DarkRed Then
            AntSfo.BackgroundImage = (My.Resources.niente)
            AntSfo.BackColor = Color.White
            sfondo.Text = ("white")
            Button62.Image = (My.Resources.no)

            Button43.Enabled = True
            Button44.Enabled = True
            Button45.Enabled = True
            Button46.Enabled = True
            Button47.Enabled = True
            Button48.Enabled = True
            Button49.Enabled = True
            Button50.Enabled = True
            Button51.Enabled = True
            Button52.Enabled = True
            Button53.Enabled = True
            Button54.Enabled = True
            Button55.Enabled = True
            Button56.Enabled = True
            Button57.Enabled = True
            Button58.Enabled = True
            Button59.Enabled = True
            Button60.Enabled = True
        Else
            AntSfo.BackgroundImage = (My.Resources.Trasparente105x31)
            AntSfo.BackColor = Color.DarkRed
            sfondo.Text = ("")
            Button62.Image = (My.Resources.si)

            Button43.Enabled = False
            Button44.Enabled = False
            Button45.Enabled = False
            Button46.Enabled = False
            Button47.Enabled = False
            Button48.Enabled = False
            Button49.Enabled = False
            Button50.Enabled = False
            Button51.Enabled = False
            Button52.Enabled = False
            Button53.Enabled = False
            Button54.Enabled = False
            Button55.Enabled = False
            Button56.Enabled = False
            Button57.Enabled = False
            Button58.Enabled = False
            Button59.Enabled = False
            Button60.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class