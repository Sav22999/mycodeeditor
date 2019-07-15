Public Class Contenitore

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = (OpenFileDialog1.FileName)
            Panel2.Visible = False
            PictureBox20.ImageLocation = (TextBox1.Text)
            Button90.BackColor = Panel1.BackColor
            ContenitoreSfondo.Text = (TextBox1.Text)
            Panel10.BackColor = Color.Transparent
            PictureBox20.Visible = True

            Dim w As Integer
            Dim h As Integer
            Dim grand As Size
            w = "323"
            h = "136"
            grand = New Size(w, h)
            Panel2.Size = grand
        End If

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

    End Sub

    Private Sub TextBox1_RightToLeftChanged(sender As Object, e As EventArgs) Handles TextBox1.RightToLeftChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Contenitore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "px"
        ComboBox2.Text = "px"
        Dim i As New Integer
        i = 1
        If MinionOneF.buttprogcss.Visible = True And MinionOneF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Contenitore" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Contenitore" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MinionOneF.CSSFTB.Text.Contains(TextBox9.Text)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ContenitoreSfondo.Text = ("none")
        TextBox1.Text = ""
        Panel10.BackColor = Color.Transparent
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
    End Sub

    Private Sub Button90_Click(sender As Object, e As EventArgs) Handles Button90.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
            Button90.BackColor = Panel1.BackColor
        Else
            Panel2.Visible = True
            Button90.BackColor = Color.Gray
        End If
    End Sub

    Private Sub IncollaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem1.Click
        TextBox1.ReadOnly = False
        TextBox1.SelectAll()
        TextBox1.Paste()
        ContenitoreSfondo.Text = (TextBox1.Text)
        Panel2.Visible = False
        PictureBox20.ImageLocation = (TextBox1.Text)
        Button90.BackColor = Panel1.BackColor
        TextBox1.ReadOnly = True
    End Sub

    Private Sub EliminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminaToolStripMenuItem.Click
        TextBox1.SelectAll()
        TextBox1.Clear()
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        Colori.Dove.Text = ("ColoreBordiContenitore")


        Colori.HEXTextBox.Text = ContenitoreBordiColore.Text.Replace("#", "")
        Colori.TextBox1.Text = Colori.InvertiHEX(Colori.HEXTextBox.Text)
        Colori.AnteprimaColore.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & Colori.TextBox1.Text)


        Button54.BackColor = Panel1.BackColor
        Panel21.Visible = False
        Button90.BackColor = Panel1.BackColor
        Colori.ShowDialog()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If Panel21.Visible = False Then
            Panel21.Visible = True
            Button40.BackColor = Color.Gray
        Else
            Panel21.Visible = False
            Button40.BackColor = Panel1.BackColor
        End If
    End Sub

    Private Sub AltreOpzioniCheck_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox7_Click(sender As Object, e As EventArgs) Handles TextBox7.Click
        TextBox7.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_Click(sender As Object, e As EventArgs) Handles TextBox8.Click
        TextBox8.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox13_Click(sender As Object, e As EventArgs) Handles TextBox13.Click
        TextBox13.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TextBox12_Click(sender As Object, e As EventArgs) Handles TextBox12.Click
        TextBox12.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        TextBox10.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox11_Click(sender As Object, e As EventArgs) Handles TextBox11.Click
        TextBox11.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub CopiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiaToolStripMenuItem.Click
        TextBox1.SelectAll()
        TextBox1.Copy()
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click
        TextBox6.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox4.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        TextBox5.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox14_Click(sender As Object, e As EventArgs) Handles TextBox14.Click
        TextBox14.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox14.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Stile.Dove.Text = ("ContenitoreBordi")


        Stile.Stile1.BackColor = Panel1.BackColor
        Stile.Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile.Stile1.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile.Stile2.BackColor = Panel1.BackColor
        Stile.Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile.Stile2.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile.Stile3.BackColor = Panel1.BackColor
        Stile.Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile.Stile3.FlatAppearance.MouseOverBackColor = Color.Silver
        Stile.Stile4.BackColor = Panel1.BackColor
        Stile.Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
        Stile.Stile4.FlatAppearance.MouseOverBackColor = Color.Silver
        If TextBox18.Text = "solid" Then
            Stile.Stile1.BackColor = Color.Gray
            Stile.Stile1.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile.Stile1.FlatAppearance.MouseOverBackColor = Color.Gray

            Stile.PictureBox2.BackgroundImage = (Stile.Stile1.Image)
            Stile.StileTB.Text = TextBox18.Text
        ElseIf TextBox18.Text = "double" Then
            Stile.Stile2.BackColor = Color.Gray
            Stile.Stile2.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile.Stile2.FlatAppearance.MouseOverBackColor = Color.Gray

            Stile.PictureBox2.BackgroundImage = (Stile.Stile2.Image)
            Stile.StileTB.Text = TextBox18.Text
        ElseIf TextBox18.Text = "dotted" Then
            Stile.Stile3.BackColor = Color.Gray
            Stile.Stile3.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile.Stile3.FlatAppearance.MouseOverBackColor = Color.Gray

            Stile.PictureBox2.BackgroundImage = (Stile.Stile3.Image)
            Stile.StileTB.Text = TextBox18.Text
        ElseIf TextBox18.Text = "dashed" Then
            Stile.Stile4.BackColor = Color.Gray
            Stile.Stile4.FlatAppearance.MouseDownBackColor = Color.Gray
            Stile.Stile4.FlatAppearance.MouseOverBackColor = Color.Gray

            Stile.PictureBox2.BackgroundImage = (Stile.Stile4.Image)
            Stile.StileTB.Text = TextBox18.Text
        End If


        Button52.BackColor = Panel1.BackColor
        Stile.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Colori.Dove.Text = ("ContenitoreColoreSfondo")


        Colori.HEXTextBox.Text = ContenitoreSfondo.Text.Replace("#", "")
        Colori.TextBox1.Text = Colori.InvertiHEX(Colori.HEXTextBox.Text)
        Colori.AnteprimaColore.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & Colori.TextBox1.Text)


        Button90.BackColor = Panel1.BackColor
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        TextBox1.Text = ""
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
        Colori.ShowDialog()
    End Sub

    Private Sub PictureBox209_Click(sender As Object, e As EventArgs) Handles PictureBox209.Click
        Panel10.BackColor = PictureBox209.BackColor
        ContenitoreSfondo.Text = ("#000000")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        TextBox1.Text = ""
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
    End Sub

    Private Sub PictureBox204_Click(sender As Object, e As EventArgs) Handles PictureBox204.Click
        Panel10.BackColor = PictureBox204.BackColor
        ContenitoreSfondo.Text = ("#0000FF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        TextBox1.Text = ""
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
    End Sub

    Private Sub PictureBox119_Click(sender As Object, e As EventArgs) Handles PictureBox119.Click
        Panel10.BackColor = PictureBox119.BackColor
        ContenitoreSfondo.Text = ("#FF00FF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        TextBox1.Text = ""
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
    End Sub

    Private Sub PictureBox124_Click(sender As Object, e As EventArgs) Handles PictureBox124.Click
        Panel10.BackColor = PictureBox124.BackColor
        ContenitoreSfondo.Text = ("#FF0000")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        TextBox1.Text = ""
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel10.BackColor = PictureBox1.BackColor
        ContenitoreSfondo.Text = ("#00FF00")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        TextBox1.Text = ""
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Panel10.BackColor = PictureBox9.BackColor
        ContenitoreSfondo.Text = ("#FFFF00")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        TextBox1.Text = ""
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Panel10.BackColor = PictureBox21.BackColor
        ContenitoreSfondo.Text = ("#00FFFF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        TextBox1.Text = ""
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
    End Sub

    Private Sub PictureBox80_Click(sender As Object, e As EventArgs) Handles PictureBox80.Click
        Panel10.BackColor = PictureBox80.BackColor
        ContenitoreSfondo.Text = ("#FFFFFF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
        TextBox1.Text = ""
        PictureBox20.Visible = False

        Dim w As Integer
        Dim h As Integer
        Dim grand As Size
        w = "323"
        h = "80"
        grand = New Size(w, h)
        Panel2.Size = grand
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Panel15.BackColor = PictureBox6.BackColor
        ContenitoreBordiColore.Text = ("#000000")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Panel15.BackColor = PictureBox4.BackColor
        ContenitoreBordiColore.Text = ("#0000FF")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel15.BackColor = PictureBox3.BackColor
        ContenitoreBordiColore.Text = ("#FF00FF")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Panel15.BackColor = PictureBox5.BackColor
        ContenitoreBordiColore.Text = ("#FF0000")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Panel15.BackColor = PictureBox11.BackColor
        ContenitoreBordiColore.Text = ("#00FF00")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Panel15.BackColor = PictureBox10.BackColor
        ContenitoreBordiColore.Text = ("#FFFF00")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Panel15.BackColor = PictureBox8.BackColor
        ContenitoreBordiColore.Text = ("#00FFFF")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel15.BackColor = PictureBox7.BackColor
        ContenitoreBordiColore.Text = ("#FFFFFF")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If TextBox9.Text = "" Then
            TextBox9.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If ContenitoreSfondo.Text = "" Then
            ContenitoreSfondo.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox7.Text = "" Then
            TextBox7.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If ComboBox1.Text = "" Then
            ComboBox1.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox8.Text = "" Then
            TextBox8.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If ComboBox2.Text = "" Then
            ComboBox2.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox20.Text = "" Then
            Button24.BackColor = Color.Red
            Button23.BackColor = Color.Red
            Button22.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox13.Text = "" Then
            TextBox13.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox11.Text = "" Then
            TextBox11.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox12.Text = "" Then
            TextBox12.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox10.Text = "" Then
            TextBox10.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox3.Text = "" Then
            TextBox3.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox6.Text = "" Then
            TextBox6.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox4.Text = "" Then
            TextBox4.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox5.Text = "" Then
            TextBox5.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox14.Text = "" Then
            TextBox14.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If ContenitoreBordiColore.Text = "" Then
            ContenitoreBordiColore.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox18.Text = "" Then
            TextBox18.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If MinionOneF.FastColoredTextBox1.Text.Contains("id=" & Chr(34) & TextBox9.Text & Chr(34)) Then
            MessaggioF.Text = ("Nome già utilizzato.")
            MessaggioF.Button1.Text = ("Questo nome è stato già utilizzato nel progetto attualmente aperto." & vbNewLine & "Inseriscine un altro.")
            MessaggioF.DettagliErroreButton.Visible = False
            MessaggioF.ErroreTxt.Text = ("")
            MessaggioF.ShowDialog()
        Else
            If TextBox24.Text = ("si") Then
                If MinionOneF.CSSSIoNOtb.Text = ("no") Then
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    If ContenitoreSfondo.Text.Contains("#") And ContenitoreSfondo.Text.Contains("none") Then
                        BottoneCodice.Text = BottoneCodice.Text.Replace("@@sfondo@@", ContenitoreSfondo.Text)
                    Else
                        BottoneCodice.Text = BottoneCodice.Text.Replace("@@sfondo@@", "url(" & Chr(34) & ContenitoreSfondo.Text & Chr(34) & ")")
                    End If
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@altezza bottone@@", TextBox7.Text + ComboBox1.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@larghezza bottone@@", TextBox8.Text + ComboBox2.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@text-align@@", TextBox20.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@bordo sinistro@@", TextBox3.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@bordo destro@@", TextBox6.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@bordo superiore@@", TextBox4.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@bordo inferiore@@", TextBox5.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@stile bordi@@", TextBox18.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@colore bordi@@", ContenitoreBordiColore.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@raccordo bordi@@", TextBox14.Text & "px")
                    If MinionOneF.SelezionatoSalvatoDagliAppunti.Text <> "" Then
                        BottoneCodice.Text = BottoneCodice.Text.Replace("@@contenuto div@@", MinionOneF.SelezionatoSalvatoDagliAppunti.Text)
                    End If
                    MinionOneF.SelezionatoSalvatoDagliAppunti.SelectAll()
                    MinionOneF.SelezionatoSalvatoDagliAppunti.Clear()
                    MinionOneF.buttprogling.BackColor = Color.Red
                    MinionOneF.buttprogcss.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaWB.Visible = False
                    MinionOneF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaButtonR.BackColor = Color.DimGray
                    MinionOneF.CSSFTB.Visible = False
                    MinionOneF.FastColoredTextBox1.Visible = True
                    MinionOneF.DagliAppunti.Paste()
                    MinionOneF.DaIncollare.Text = vbNewLine & Me.BottoneCodice.Text & vbNewLine
                    MinionOneF.DaIncollare.SelectAll()
                    MinionOneF.DaIncollare.Copy()
                    MinionOneF.FastColoredTextBox1.Paste()
                    MinionOneF.DaIncollare.Text = ""
                    MinionOneF.DagliAppunti.SelectAll()
                    My.Computer.Clipboard.Clear()
                    MinionOneF.DagliAppunti.Copy()
                    MinionOneF.FastColoredTextBox1.Select()
                    Me.Close()
                Else
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    If ContenitoreSfondo.Text.Contains("#") And ContenitoreSfondo.Text.Contains("none") Then
                        BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@sfondo@@", ContenitoreSfondo.Text)
                    Else
                        BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@sfondo@@", "url(" & Chr(34) & ContenitoreSfondo.Text & Chr(34) & ")")
                    End If
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@altezza bottone@@", TextBox7.Text + ComboBox1.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@larghezza bottone@@", TextBox8.Text + ComboBox2.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@text-align@@", TextBox20.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@bordo sinistro@@", TextBox3.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@bordo destro@@", TextBox6.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@bordo superiore@@", TextBox4.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@bordo inferiore@@", TextBox5.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@stile bordi@@", TextBox18.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@colore bordi@@", ContenitoreBordiColore.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@raccordo bordi@@", TextBox14.Text & "px")
                    If MinionOneF.SelezionatoSalvatoDagliAppunti.Text <> "" Then
                        BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@contenuto div@@", MinionOneF.SelezionatoSalvatoDagliAppunti.Text)
                    End If
                    MinionOneF.SelezionatoSalvatoDagliAppunti.SelectAll()
                    MinionOneF.SelezionatoSalvatoDagliAppunti.Clear()
                    MinionOneF.buttprogling.BackColor = Color.Red
                    MinionOneF.buttprogcss.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaWB.Visible = False
                    MinionOneF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaButtonR.BackColor = Color.DimGray
                    MinionOneF.CSSFTB.Visible = False
                    MinionOneF.FastColoredTextBox1.Visible = True
                    MinionOneF.DagliAppunti.Paste()
                    MinionOneF.DaIncollare.Text = vbNewLine & Me.BottoneCodiceHTML.Text & vbNewLine
                    MinionOneF.DaIncollare.SelectAll()
                    MinionOneF.DaIncollare.Copy()
                    MinionOneF.FastColoredTextBox1.Paste()
                    MinionOneF.DaIncollare.Text = ""
                    MinionOneF.DagliAppunti.SelectAll()
                    My.Computer.Clipboard.Clear()
                    MinionOneF.DagliAppunti.Copy()
                    MinionOneF.FastColoredTextBox1.Select()
                    MinionOneF.CSSFTB.Text = (MinionOneF.CSSFTB.Text & BottoneCodiceCSS.Text)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Button24.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke

        Button24.BackColor = Color.Silver
        TextBox20.Text = ("left")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Button24.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke

        Button23.BackColor = Color.Silver
        TextBox20.Text = ("center")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Button24.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke

        Button22.BackColor = Color.Silver
        TextBox20.Text = ("right")
    End Sub

    Private Sub TextBox9_Click(sender As Object, e As EventArgs) Handles TextBox9.Click
        TextBox9.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        ComboBox2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        If TextBox7.Text = "" Then
            TextBox7.Text = ("1")
        End If
        TextBox7.Text += 1
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        If TextBox7.Text = "" Then
            TextBox7.Text = ("1")
        End If
        If TextBox7.Text = "" Or TextBox7.Text.Replace(" ", "") = "" Or TextBox7.Text = "1" Then
        Else
            TextBox7.Text -= 1
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox8.Text = "" Then
            TextBox8.Text = ("1")
        End If
        TextBox8.Text += 1
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox8.Text = "" Then
            TextBox8.Text = ("1")
        End If
        If TextBox8.Text = "" Or TextBox8.Text.Replace(" ", "") = "" Or TextBox8.Text = "1" Then
        Else
            TextBox8.Text -= 1
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox14.Text = "" Then
            TextBox14.Text = ("1")
        End If
        TextBox14.Text += 1
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox14.Text = "" Then
            TextBox14.Text = ("1")
        End If
        If TextBox14.Text = "" Or TextBox14.Text.Replace(" ", "") = "" Or TextBox14.Text = "1" Then
        Else
            TextBox14.Text -= 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/Contenitore/")
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class