Public Class Separatore
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

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        AntColo.BackColor = Color.White
        colore.Text = ("white")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AntColo.BackColor = Color.Silver
        colore.Text = ("silver")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
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

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        AntLung.Text = ("5%")
        lunghezza.Text = ("5%")
    End Sub

    Private Sub spessore_TextChanged(sender As Object, e As EventArgs) Handles spessore.TextChanged

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AntSpes.Text = ("8")
        spessore.Text = ("8")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AntSpes.Text = ("9")
        spessore.Text = ("9")
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        AntLung.Text = ("10%")
        lunghezza.Text = ("10%")
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        AntLung.Text = ("15%")
        lunghezza.Text = ("15%")
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        AntLung.Text = ("20%")
        lunghezza.Text = ("20%")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        AntLung.Text = ("25%")
        lunghezza.Text = ("25%")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        AntLung.Text = ("30%")
        lunghezza.Text = ("30%")
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        AntLung.Text = ("40%")
        lunghezza.Text = ("40%")
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        AntLung.Text = ("50%")
        lunghezza.Text = ("50%")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        AntLung.Text = ("55%")
        lunghezza.Text = ("55%")
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        AntLung.Text = ("70%")
        lunghezza.Text = ("70%")
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        AntLung.Text = ("75%")
        lunghezza.Text = ("75%")
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        AntLung.Text = ("80%")
        lunghezza.Text = ("80%")
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        AntLung.Text = ("85%")
        lunghezza.Text = ("85%")
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        AntLung.Text = ("90%")
        lunghezza.Text = ("90%")
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        AntLung.Text = ("100%")
        lunghezza.Text = ("100%")
    End Sub

    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        TextBox1.Text = ("")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)

        If KeyAscii < 48 And KeyAscii <> 24 And KeyAscii <> 8 Then
            KeyAscii = 0
        ElseIf KeyAscii > 57 Then
            KeyAscii = 0
        End If

        If e.KeyChar = "0" And TextBox1.TextLength = 0 Then
            KeyAscii = 0
        End If
        e.KeyChar = Chr(KeyAscii)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Visible = True
    End Sub

    Private Sub Button6_Leave(sender As Object, e As EventArgs) Handles Button6.Leave

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        AntSpes.Text = (TextBox1.Text)
        spessore.Text = (TextBox1.Text)
        If TextBox1.Text = ("") Then
            TextBox1.Text = ("1")
        End If
    End Sub

    Private Sub Separatore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.finestremenuinseriscitopmost = ("si") Then
            Me.TopMost = True
        ElseIf My.Settings.finestremenuinseriscitopmost = ("no") Then
            Me.TopMost = False
        End If

        AntSpes.Text = ("3")
        spessore.Text = ("3")
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
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Gray
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Gray
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.Gray
            Panel2.BackColor = Color.Gray
            Panel4.BackColor = Color.Gray
        ElseIf My.Settings.colorebordi = ("white") Then
            Button1.BackColor = Color.White
            Button1.FlatAppearance.BorderColor = Color.White
            Button1.FlatAppearance.MouseDownBackColor = Color.White
            Button1.FlatAppearance.MouseOverBackColor = Color.White
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.White
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.White
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.White
            Panel2.BackColor = Color.White
            Panel4.BackColor = Color.White
        ElseIf My.Settings.colorebordi = ("yellow") Then
            Button1.BackColor = Color.Yellow
            Button1.FlatAppearance.BorderColor = Color.Yellow
            Button1.FlatAppearance.MouseDownBackColor = Color.Yellow
            Button1.FlatAppearance.MouseOverBackColor = Color.Yellow
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Yellow
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Yellow
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.Yellow
            Panel2.BackColor = Color.Yellow
            Panel4.BackColor = Color.Yellow
        ElseIf My.Settings.colorebordi = ("gold") Then
            Button1.BackColor = Color.Gold
            Button1.FlatAppearance.BorderColor = Color.Gold
            Button1.FlatAppearance.MouseDownBackColor = Color.Gold
            Button1.FlatAppearance.MouseOverBackColor = Color.Gold
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Gold
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Gold
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.Gold
            Panel2.BackColor = Color.Gold
            Panel4.BackColor = Color.Gold
        ElseIf My.Settings.colorebordi = ("orangered") Then
            Button1.BackColor = Color.OrangeRed
            Button1.FlatAppearance.BorderColor = Color.OrangeRed
            Button1.FlatAppearance.MouseDownBackColor = Color.OrangeRed
            Button1.FlatAppearance.MouseOverBackColor = Color.OrangeRed
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.OrangeRed
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.OrangeRed
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.OrangeRed
            Panel2.BackColor = Color.OrangeRed
            Panel4.BackColor = Color.OrangeRed
        ElseIf My.Settings.colorebordi = ("red") Then
            Button1.BackColor = Color.Red
            Button1.FlatAppearance.BorderColor = Color.Red
            Button1.FlatAppearance.MouseDownBackColor = Color.Red
            Button1.FlatAppearance.MouseOverBackColor = Color.Red
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Red
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Red
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.Red
            Panel2.BackColor = Color.Red
            Panel4.BackColor = Color.Red
        ElseIf My.Settings.colorebordi = ("fuchsia") Then
            Button1.BackColor = Color.Fuchsia
            Button1.FlatAppearance.BorderColor = Color.Fuchsia
            Button1.FlatAppearance.MouseDownBackColor = Color.Fuchsia
            Button1.FlatAppearance.MouseOverBackColor = Color.Fuchsia
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Fuchsia
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Fuchsia
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.Fuchsia
            Panel2.BackColor = Color.Fuchsia
            Panel4.BackColor = Color.Fuchsia
        ElseIf My.Settings.colorebordi = ("purple") Then
            Button1.BackColor = Color.Purple
            Button1.FlatAppearance.BorderColor = Color.Purple
            Button1.FlatAppearance.MouseDownBackColor = Color.Purple
            Button1.FlatAppearance.MouseOverBackColor = Color.Purple
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Purple
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Purple
            Button3.ForeColor = Color.Navy
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
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Cyan
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Cyan
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.Cyan
            Panel2.BackColor = Color.Cyan
            Panel4.BackColor = Color.Cyan
        ElseIf My.Settings.colorebordi = ("teal") Then
            Button1.BackColor = Color.Teal
            Button1.FlatAppearance.BorderColor = Color.Teal
            Button1.FlatAppearance.MouseDownBackColor = Color.Teal
            Button1.FlatAppearance.MouseOverBackColor = Color.Teal
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Teal
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Teal
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.Teal
            Panel2.BackColor = Color.Teal
            Panel4.BackColor = Color.Teal
        ElseIf My.Settings.colorebordi = ("green") Then
            Button1.BackColor = Color.Green
            Button1.FlatAppearance.BorderColor = Color.Green
            Button1.FlatAppearance.MouseDownBackColor = Color.Green
            Button1.FlatAppearance.MouseOverBackColor = Color.Green
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Green
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Green
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.Green
            Panel2.BackColor = Color.Green
            Panel4.BackColor = Color.Green
        ElseIf My.Settings.colorebordi = ("lime") Then
            Button1.BackColor = Color.Lime
            Button1.FlatAppearance.BorderColor = Color.Lime
            Button1.FlatAppearance.MouseDownBackColor = Color.Lime
            Button1.FlatAppearance.MouseOverBackColor = Color.Lime
            Button1.ForeColor = Color.Navy
            Button2.BackColor = Color.Lime
            Button2.ForeColor = Color.Navy
            Button3.BackColor = Color.Lime
            Button3.ForeColor = Color.Navy
            Panel1.BackColor = Color.Lime
            Panel2.BackColor = Color.Lime
            Panel4.BackColor = Color.Lime
        End If
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs)
        TextBox1.Clear()
    End Sub

    Private Sub Separatore_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        TextBox1.Visible = False
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If TextBox1.Text = ("") Then
        Else
            MinionOne.TESTOINCOLLATO.Paste()
            MinionOne.TESTODAINSERIRE.Text = ("<hr" & " color=" & Chr(34) & colore.Text & Chr(34) & " size=" & Chr(34) & spessore.Text & Chr(34) & " width=" & Chr(34) & lunghezza.Text & Chr(34) & " align=" & Chr(34) & posizione.Text & Chr(34) & " >")
            MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & Environment.NewLine)
            MinionOne.TESTODAINSERIRE.SelectAll()
            MinionOne.TESTODAINSERIRE.Copy()
            MinionOne.FastColoredTextBox1.Paste()
            MinionOne.TESTOINCOLLATO.SelectAll()
            MinionOne.TESTOINCOLLATO.Copy()
        End If
    End Sub

    Private Sub sinistra_Click(sender As Object, e As EventArgs) Handles sinistra.Click
        sinistra.BackColor = Color.Blue
        centro.BackColor = Color.Navy
        destra.BackColor = Color.Navy
        posizione.Text = ("left")
    End Sub

    Private Sub centro_Click(sender As Object, e As EventArgs) Handles centro.Click
        sinistra.BackColor = Color.Navy
        centro.BackColor = Color.Blue
        destra.BackColor = Color.Navy
        posizione.Text = ("center")
    End Sub

    Private Sub destra_Click(sender As Object, e As EventArgs) Handles destra.Click
        sinistra.BackColor = Color.Navy
        centro.BackColor = Color.Navy
        destra.BackColor = Color.Blue
        posizione.Text = ("right")
    End Sub
End Class