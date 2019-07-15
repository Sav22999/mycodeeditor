Public Class Impostazioni

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub ButtonLuminoso_Click(sender As Object, e As EventArgs) Handles ButtonLuminoso.Click
        ButtonLuminoso.BackColor = Color.Blue
        ButtonChiaro.BackColor = Color.Navy
        ButtonScuro.BackColor = Color.Navy
        ButtonGiallastro.BackColor = Color.Navy
        My.Settings.tema = ("luminoso")
        My.Settings.Save()
        MinionOne.FastColoredTextBox1.BackColor = Color.White
        MinionOne.FastColoredTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub ButtonChiaro_Click(sender As Object, e As EventArgs) Handles ButtonChiaro.Click
        ButtonLuminoso.BackColor = Color.Navy
        ButtonChiaro.BackColor = Color.Blue
        ButtonScuro.BackColor = Color.Navy
        ButtonGiallastro.BackColor = Color.Navy
        My.Settings.tema = ("chiaro")
        My.Settings.Save()
        MinionOne.FastColoredTextBox1.BackColor = Color.Silver
        MinionOne.FastColoredTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub ButtonScuro_Click(sender As Object, e As EventArgs) Handles ButtonScuro.Click
        ButtonLuminoso.BackColor = Color.Navy
        ButtonChiaro.BackColor = Color.Navy
        ButtonScuro.BackColor = Color.Blue
        ButtonGiallastro.BackColor = Color.Navy
        My.Settings.tema = ("scuro")
        My.Settings.Save()
        MinionOne.FastColoredTextBox1.BackColor = Color.Black
        MinionOne.FastColoredTextBox1.ForeColor = Color.Silver
    End Sub

    Private Sub Impostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.finestremenuinseriscitopmost = ("si") Then
            Button26.BackColor = Color.Navy
            Button27.BackColor = Color.Blue
        ElseIf My.Settings.finestremenuinseriscitopmost = ("no") Then
            Button27.BackColor = Color.Navy
            Button26.BackColor = Color.Blue
        End If

        If My.Settings.webbrowserfinestra = ("form") Then
            Button23.BackColor = Color.Navy
            Button24.BackColor = Color.Blue
        ElseIf My.Settings.webbrowserfinestra = ("panel") Then
            Button23.BackColor = Color.Blue
            Button24.BackColor = Color.Navy
        End If

        If My.Settings.aggiornamentoautomatico = ("no") Then
            Button22.BackColor = Color.Navy
            Button21.BackColor = Color.Blue
        Else
            Button22.BackColor = Color.Blue
            Button21.BackColor = Color.Navy
        End If

        If My.Settings.tema = ("chiaro") Then
            ButtonLuminoso.BackColor = Color.Navy
            ButtonChiaro.BackColor = Color.Blue
            ButtonScuro.BackColor = Color.Navy
            ButtonGiallastro.BackColor = Color.Navy
        ElseIf My.Settings.tema = ("scuro") Then
            ButtonLuminoso.BackColor = Color.Navy
            ButtonChiaro.BackColor = Color.Navy
            ButtonScuro.BackColor = Color.Blue
            ButtonGiallastro.BackColor = Color.Navy
        ElseIf My.Settings.tema = ("luminoso") Then
            ButtonLuminoso.BackColor = Color.Blue
            ButtonChiaro.BackColor = Color.Navy
            ButtonScuro.BackColor = Color.Navy
            ButtonGiallastro.BackColor = Color.Navy
        ElseIf My.Settings.tema = ("giallastro") Then
            ButtonLuminoso.BackColor = Color.Navy
            ButtonChiaro.BackColor = Color.Navy
            ButtonScuro.BackColor = Color.Navy
            ButtonGiallastro.BackColor = Color.Blue
        End If

        If My.Settings.colorebordi = ("black") Then
            PictureBox1.BackColor = Color.Black
        ElseIf My.Settings.colorebordi = ("gray") Then
            PictureBox1.BackColor = Color.Gray
        ElseIf My.Settings.colorebordi = ("white") Then
            PictureBox1.BackColor = Color.White
        ElseIf My.Settings.colorebordi = ("yellow") Then
            PictureBox1.BackColor = Color.Yellow
        ElseIf My.Settings.colorebordi = ("gold") Then
            PictureBox1.BackColor = Color.Gold
        ElseIf My.Settings.colorebordi = ("orangered") Then
            PictureBox1.BackColor = Color.OrangeRed
        ElseIf My.Settings.colorebordi = ("red") Then
            PictureBox1.BackColor = Color.Red
        ElseIf My.Settings.colorebordi = ("fuchsia") Then
            PictureBox1.BackColor = Color.Fuchsia
        ElseIf My.Settings.colorebordi = ("purple") Then
            PictureBox1.BackColor = Color.Purple
        ElseIf My.Settings.colorebordi = ("navy") Then
            PictureBox1.BackColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("blue") Then
            PictureBox1.BackColor = Color.Blue
        ElseIf My.Settings.colorebordi = ("cyan") Then
            PictureBox1.BackColor = Color.Cyan
        ElseIf My.Settings.colorebordi = ("teal") Then
            PictureBox1.BackColor = Color.Teal
        ElseIf My.Settings.colorebordi = ("green") Then
            PictureBox1.BackColor = Color.Green
        ElseIf My.Settings.colorebordi = ("lime") Then
            PictureBox1.BackColor = Color.Lime
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

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        PictureBox1.BackColor = Color.Black
        My.Settings.colorebordi = ("black")
        My.Settings.Save()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        PictureBox1.BackColor = Color.Gray
        My.Settings.colorebordi = ("gray")
        My.Settings.Save()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.BackColor = Color.White
        My.Settings.colorebordi = ("white")
        My.Settings.Save()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.BackColor = Color.Yellow
        My.Settings.colorebordi = ("yellow")
        My.Settings.Save()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.BackColor = Color.Gold
        My.Settings.colorebordi = ("gold")
        My.Settings.Save()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PictureBox1.BackColor = Color.OrangeRed
        My.Settings.colorebordi = ("orangered")
        My.Settings.Save()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        PictureBox1.BackColor = Color.Red
        My.Settings.colorebordi = ("red")
        My.Settings.Save()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        PictureBox1.BackColor = Color.Fuchsia
        My.Settings.colorebordi = ("fuchsia")
        My.Settings.Save()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PictureBox1.BackColor = Color.Purple
        My.Settings.colorebordi = ("purple")
        My.Settings.Save()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PictureBox1.BackColor = Color.Navy
        My.Settings.colorebordi = ("navy")
        My.Settings.Save()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        PictureBox1.BackColor = Color.Blue
        My.Settings.colorebordi = ("blue")
        My.Settings.Save()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        PictureBox1.BackColor = Color.Cyan
        My.Settings.colorebordi = ("cyan")
        My.Settings.Save()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        PictureBox1.BackColor = Color.Teal
        My.Settings.colorebordi = ("teal")
        My.Settings.Save()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        PictureBox1.BackColor = Color.Green
        My.Settings.colorebordi = ("green")
        My.Settings.Save()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PictureBox1.BackColor = Color.Lime
        My.Settings.colorebordi = ("lime")
        My.Settings.Save()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Button22.BackColor = Color.Blue
        Button21.BackColor = Color.Navy
        My.Settings.aggiornamentoautomatico = ("si")
        My.Settings.Save()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Button22.BackColor = Color.Navy
        Button21.BackColor = Color.Blue
        My.Settings.aggiornamentoautomatico = ("no")
        My.Settings.Save()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles ButtonGiallastro.Click
        ButtonLuminoso.BackColor = Color.Navy
        ButtonChiaro.BackColor = Color.Navy
        ButtonScuro.BackColor = Color.Navy
        ButtonGiallastro.BackColor = Color.Blue
        My.Settings.tema = ("giallastro")
        My.Settings.Save()
        MinionOne.FastColoredTextBox1.BackColor = Color.LemonChiffon
        MinionOne.FastColoredTextBox1.ForeColor = Color.DimGray
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Button23.BackColor = Color.Navy
        Button24.BackColor = Color.Blue
        My.Settings.webbrowserfinestra = ("form")
        My.Settings.Save()
        MinionOne.AnteprimaProgetto.Visible = False
        MinionOne.ProgrammazioneProgettoBottone.BackColor = Color.Blue
        MinionOne.AnteprimaProgettoBottone.BackColor = Color.Navy
        MinionOne.Button36.Enabled = True
        MinionOne.Button42.Enabled = True
        MinionOne.Button43.Enabled = True
        MinionOne.Button45.Enabled = True
        MinionOne.FileButton.Enabled = True
        MinionOne.ModificaButton.Enabled = True
        MinionOne.ProgettoButton.Enabled = True
        MinionOne.InserisciButton.Enabled = True
        MinionOne.Button31.Enabled = True
        MinionOne.Button30.Enabled = True
    End Sub

    Private Sub Button23_Click_1(sender As Object, e As EventArgs) Handles Button23.Click
        Button24.BackColor = Color.Navy
        Button23.BackColor = Color.Blue
        My.Settings.webbrowserfinestra = ("panel")
        My.Settings.Save()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Button26.BackColor = Color.Navy
        Button27.BackColor = Color.Blue
        My.Settings.finestremenuinseriscitopmost = ("si")
        My.Settings.Save()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Button27.BackColor = Color.Navy
        Button26.BackColor = Color.Blue
        My.Settings.finestremenuinseriscitopmost = ("no")
        My.Settings.Save()
    End Sub
End Class