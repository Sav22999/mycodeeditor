Public Class TestoPersonalizzato

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If Panel27.Visible = False Then
            Panel27.Visible = True
            Button43.BackColor = Color.Gray
        Else
            Panel27.Visible = False
            Button43.BackColor = Panel1.BackColor
        End If
    End Sub

    Private Sub Button90_Click(sender As Object, e As EventArgs) Handles Button90.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
            Button90.BackColor = Color.Gray
        Else
            Panel2.Visible = False
            Button90.BackColor = Panel1.BackColor
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Colori.Dove.Text = ("SfondoTestoPersonalizzato")


        Colori.HEXTextBox.Text = TestoPersonalizzatoSfondoColore.Text.Replace("#", "")
        Colori.TextBox1.Text = Colori.InvertiHEX(Colori.HEXTextBox.Text)
        Colori.AnteprimaColore.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & Colori.TextBox1.Text)


        Button90.BackColor = Panel1.BackColor
        Panel2.Visible = False
        Colori.ShowDialog()
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Colori.Dove.Text = ("TestoColoreTestoPersonalizzato")


        Colori.HEXTextBox.Text = TestoPersonalizzatoTestoColore.Text.Replace("#", "")
        Colori.TextBox1.Text = Colori.InvertiHEX(Colori.HEXTextBox.Text)
        Colori.AnteprimaColore.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & Colori.TextBox1.Text)


        Button43.BackColor = Panel1.BackColor
        Panel27.Visible = False
        Colori.ShowDialog()
    End Sub
    Private Sub PictureBox209_Click(sender As Object, e As EventArgs) Handles PictureBox209.Click
        Panel10.BackColor = PictureBox209.BackColor
        TestoPersonalizzatoSfondoColore.Text = ("#000000")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox204_Click(sender As Object, e As EventArgs) Handles PictureBox204.Click
        Panel10.BackColor = PictureBox204.BackColor
        TestoPersonalizzatoSfondoColore.Text = ("#0000FF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox119_Click(sender As Object, e As EventArgs) Handles PictureBox119.Click
        Panel10.BackColor = PictureBox119.BackColor
        TestoPersonalizzatoSfondoColore.Text = ("#FF00FF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox124_Click(sender As Object, e As EventArgs) Handles PictureBox124.Click
        Panel10.BackColor = PictureBox124.BackColor
        TestoPersonalizzatoSfondoColore.Text = ("#FF0000")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel10.BackColor = PictureBox1.BackColor
        TestoPersonalizzatoSfondoColore.Text = ("#00FF00")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Panel10.BackColor = PictureBox9.BackColor
        TestoPersonalizzatoSfondoColore.Text = ("#FFFF00")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Panel10.BackColor = PictureBox21.BackColor
        TestoPersonalizzatoSfondoColore.Text = ("#00FFFF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox80_Click(sender As Object, e As EventArgs) Handles PictureBox80.Click
        Panel10.BackColor = PictureBox80.BackColor
        TestoPersonalizzatoSfondoColore.Text = ("#FFFFFF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Panel17.BackColor = PictureBox15.BackColor
        TestoPersonalizzatoTestoColore.Text = ("#000000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Panel17.BackColor = PictureBox13.BackColor
        TestoPersonalizzatoTestoColore.Text = ("#0000FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Panel17.BackColor = PictureBox12.BackColor
        TestoPersonalizzatoTestoColore.Text = ("#FF00FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Panel17.BackColor = PictureBox14.BackColor
        TestoPersonalizzatoTestoColore.Text = ("#FF0000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Panel17.BackColor = PictureBox19.BackColor
        TestoPersonalizzatoTestoColore.Text = ("#00FF00")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Panel17.BackColor = PictureBox18.BackColor
        TestoPersonalizzatoTestoColore.Text = ("#FF00FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Panel17.BackColor = PictureBox17.BackColor
        TestoPersonalizzatoTestoColore.Text = ("#00FFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Panel17.BackColor = PictureBox16.BackColor
        TestoPersonalizzatoTestoColore.Text = ("#FFFFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub
    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        TextBox15.BackColor = Color.WhiteSmoke
        If TextBox15.Text = "" Then
            TextBox15.Text = ("0")
        End If
        TextBox15.Text += 1
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        TextBox15.BackColor = Color.WhiteSmoke
        If TextBox15.Text = "" Then
            TextBox15.Text = ("0")
        End If
        If TextBox15.Text = "" Or TextBox15.Text.Replace(" ", "") = "" Or TextBox15.Text = "1" Then
        Else
            TextBox15.Text -= 1
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Button24.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke

        Button24.BackColor = Color.Silver
        TextBox20.Text = ("left")
        TextBox11.BackColor = Color.WhiteSmoke

        TextBox11.Text = ("auto")
        Button5.Text = ("0")
        TextBox11.Enabled = False
        If TextBox13.Text = ("auto") Then
            TextBox13.Text = ("0")
            Button6.Text = ("px")
        End If
        TextBox13.Enabled = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Button24.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke

        Button23.BackColor = Color.Silver
        TextBox20.Text = ("center")
        TextBox11.BackColor = Color.WhiteSmoke
        TextBox13.BackColor = Color.WhiteSmoke

        TextBox11.Text = ("auto")
        TextBox11.Enabled = False
        Button5.Text = ("0")
        TextBox13.Text = ("auto")
        TextBox13.Enabled = False
        Button6.Text = ("0")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Button24.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke

        Button22.BackColor = Color.Silver
        TextBox20.Text = ("right")
        TextBox13.BackColor = Color.WhiteSmoke

        TextBox13.Text = ("auto")
        Button6.Text = ("0")
        TextBox13.Enabled = False
        If TextBox11.Text = ("auto") Then
            TextBox11.Text = ("")
            Button5.Text = ("px")
        End If
        TextBox11.Enabled = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox21.Text = ("bold") Then
            TextBox21.Text = ("none")
            Button17.BackColor = Color.WhiteSmoke
        Else
            TextBox21.Text = ("bold")
            Button17.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox22.Text = ("italic") Then
            TextBox22.Text = ("none")
            Button18.BackColor = Color.WhiteSmoke
        Else
            TextBox22.Text = ("italic")
            Button18.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Button19.BackColor = Color.WhiteSmoke Then
            TextBox23.Text = ("underline")
            Button20.BackColor = Color.WhiteSmoke
            Button19.BackColor = Color.Silver
        ElseIf Button19.BackColor = Color.Silver Then
            TextBox23.Text = ("none")
            Button20.BackColor = Color.WhiteSmoke
            Button19.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Button20.BackColor = Color.WhiteSmoke Then
            TextBox23.Text = ("line-through")
            Button20.BackColor = Color.Silver
            Button19.BackColor = Color.WhiteSmoke
        ElseIf Button20.BackColor = Color.Silver Then
            TextBox23.Text = ("none")
            Button20.BackColor = Color.WhiteSmoke
            Button19.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Carattere.Dove.Text = ("TestoCarattereTestoPersonalizzato")


        Carattere.Font1.BackColor = Panel1.BackColor
        Carattere.Font1.FlatAppearance.MouseDownBackColor = Color.Gray
        Carattere.Font1.FlatAppearance.MouseOverBackColor = Color.Silver
        Carattere.Font2.BackColor = Panel1.BackColor
        Carattere.Font2.FlatAppearance.MouseDownBackColor = Color.Gray
        Carattere.Font2.FlatAppearance.MouseOverBackColor = Color.Silver
        Carattere.Font3.BackColor = Panel1.BackColor
        Carattere.Font3.FlatAppearance.MouseDownBackColor = Color.Gray
        Carattere.Font3.FlatAppearance.MouseOverBackColor = Color.Silver
        Carattere.Font4.BackColor = Panel1.BackColor
        Carattere.Font4.FlatAppearance.MouseDownBackColor = Color.Gray
        Carattere.Font4.FlatAppearance.MouseOverBackColor = Color.Silver
        Carattere.Font5.BackColor = Panel1.BackColor
        Carattere.Font5.FlatAppearance.MouseDownBackColor = Color.Gray
        Carattere.Font5.FlatAppearance.MouseOverBackColor = Color.Silver
        Carattere.Font6.BackColor = Panel1.BackColor
        Carattere.Font6.FlatAppearance.MouseDownBackColor = Color.Gray
        Carattere.Font6.FlatAppearance.MouseOverBackColor = Color.Silver
        If TestoPersonalizzatoTestoCarattere.Text = "monospace" Then
            Carattere.Font1.BackColor = Color.Gray
            Carattere.Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font1.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = TestoPersonalizzatoTestoCarattere.Text
        ElseIf TestoPersonalizzatoTestoCarattere.Text = "serif" Then
            Carattere.Font2.BackColor = Color.Gray
            Carattere.Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font2.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = TestoPersonalizzatoTestoCarattere.Text
        ElseIf TestoPersonalizzatoTestoCarattere.Text = "sans-serif" Then
            Carattere.Font3.BackColor = Color.Gray
            Carattere.Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font3.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = TestoPersonalizzatoTestoCarattere.Text
        ElseIf TestoPersonalizzatoTestoCarattere.Text = "script" Then
            Carattere.Font4.BackColor = Color.Gray
            Carattere.Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font4.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = TestoPersonalizzatoTestoCarattere.Text
        ElseIf TestoPersonalizzatoTestoCarattere.Text = "open-serif" Then
            Carattere.Font5.BackColor = Color.Gray
            Carattere.Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font5.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = TestoPersonalizzatoTestoCarattere.Text
        ElseIf TestoPersonalizzatoTestoCarattere.Text = "cursive" Then
            Carattere.Font6.BackColor = Color.Gray
            Carattere.Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font6.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = TestoPersonalizzatoTestoCarattere.Text
        End If


        Button47.BackColor = Panel1.BackColor
        Carattere.ShowDialog()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If TextBox1.Text = "" Then
            TextBox1.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox9.Text = "" Then
            TextBox9.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TestoPersonalizzatoSfondoColore.Text = "" Then
            Button90.BackColor = Color.Red
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
        If TestoPersonalizzatoTestoColore.Text = "" Then
            Button43.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TestoPersonalizzatoTestoCarattere.Text = "" Then
            Button47.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox15.Text = "" Then
            TextBox15.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If ComboBox5.Text = "" Then
            ComboBox5.BackColor = Color.Red
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
        If (TextBox9.Text = "") Or (TextBox9.Text.Replace(" ", "") = "") Then
            TextBox9.BackColor = Color.Red
            TextBox24.Text = "no"
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
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@testo da visualizzare@@", TextBox1.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@sfondo@@", TestoPersonalizzatoSfondoColore.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@margine sinistro@@", TextBox13.Text & Button6.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@margine destro@@", TextBox11.Text & Button5.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@margine superiore@@", TextBox12.Text & Button4.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@margine inferiore@@", TextBox10.Text & Button3.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@colore testo@@", TestoPersonalizzatoTestoColore.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@font-family@@", TestoPersonalizzatoTestoCarattere.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@font-style@@", TextBox22.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    TestoPersonalizzatoCodice.Text = TestoPersonalizzatoCodice.Text.Replace("@@font-weight@@", TextBox21.Text)
                    MinionOneF.buttprogling.BackColor = Color.Red
                    MinionOneF.buttprogcss.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaWB.Visible = False
                    MinionOneF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaButtonR.BackColor = Color.DimGray
                    MinionOneF.CSSFTB.Visible = False
                    MinionOneF.FastColoredTextBox1.Visible = True
                    MinionOneF.DagliAppunti.Paste()
                    MinionOneF.DaIncollare.Text = vbNewLine & Me.TestoPersonalizzatoCodice.Text & vbNewLine
                    MinionOneF.DaIncollare.SelectAll()
                    MinionOneF.DaIncollare.Copy()
                    MinionOneF.FastColoredTextBox1.Paste()
                    MinionOneF.DaIncollare.Text = ""
                    MinionOneF.DagliAppunti.SelectAll()
                    MinionOneF.DagliAppunti.Copy()
                    MinionOneF.FastColoredTextBox1.Select()
                    Me.Close()
                Else
                    TestoPersonalizzatoCodiceHTML.Text = TestoPersonalizzatoCodiceHTML.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    TestoPersonalizzatoCodiceHTML.Text = TestoPersonalizzatoCodiceHTML.Text.Replace("@@testo da visualizzare@@", TextBox1.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@sfondo@@", TestoPersonalizzatoSfondoColore.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@margine sinistro@@", TextBox13.Text & Button6.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@margine destro@@", TextBox11.Text & Button5.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@margine superiore@@", TextBox12.Text & Button4.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@margine inferiore@@", TextBox10.Text & Button3.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@colore testo@@", TestoPersonalizzatoTestoColore.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@font-family@@", TestoPersonalizzatoTestoCarattere.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@font-style@@", TextBox22.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    TestoPersonalizzatoCodiceCSS.Text = TestoPersonalizzatoCodiceCSS.Text.Replace("@@font-weight@@", TextBox21.Text)
                    MinionOneF.buttprogling.BackColor = Color.Red
                    MinionOneF.buttprogcss.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaWB.Visible = False
                    MinionOneF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaButtonR.BackColor = Color.DimGray
                    MinionOneF.CSSFTB.Visible = False
                    MinionOneF.FastColoredTextBox1.Visible = True
                    MinionOneF.DagliAppunti.Paste()
                    MinionOneF.DaIncollare.Text = vbNewLine & Me.TestoPersonalizzatoCodiceHTML.Text & vbNewLine
                    MinionOneF.DaIncollare.SelectAll()
                    MinionOneF.DaIncollare.Copy()
                    MinionOneF.FastColoredTextBox1.Paste()
                    MinionOneF.DaIncollare.Text = ""
                    MinionOneF.DagliAppunti.SelectAll()
                    MinionOneF.DagliAppunti.Copy()
                    MinionOneF.FastColoredTextBox1.Select()
                    MinionOneF.CSSFTB.Text = (MinionOneF.CSSFTB.Text & TestoPersonalizzatoCodiceCSS.Text)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox9_Click(sender As Object, e As EventArgs) Handles TextBox9.Click
        TextBox9.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox15_Click(sender As Object, e As EventArgs) Handles TextBox15.Click
        TextBox15.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub TextBox13_Click(sender As Object, e As EventArgs) Handles TextBox13.Click
        TextBox13.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox13_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox13.KeyDown

    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

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

    Private Sub TextBox12_Click(sender As Object, e As EventArgs) Handles TextBox12.Click
        TextBox12.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        TextBox10.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub ComboBox5_Click(sender As Object, e As EventArgs) Handles ComboBox5.Click
        ComboBox5.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub TestoPersonalizzato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox5.Text = "px"
        Dim i As New Integer
        i = 1
        If MinionOneF.buttprogcss.Visible = True And MinionOneF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "TestoPersonalizzato" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "TestoPersonalizzato" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MinionOneF.CSSFTB.Text.Contains(TextBox9.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/TestoPersonalizzato/")
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub
End Class