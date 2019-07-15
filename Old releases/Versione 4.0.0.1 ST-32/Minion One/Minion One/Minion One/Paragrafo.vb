Public Class Paragrafo

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If TextBox9.Text = "" Then
            TextBox9.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox1.Text = "" Then
            TextBox1.BackColor = Color.Red
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
        If ParagrafoColoreTesto.Text = "" Then
            Button43.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If ParagrafoTestoCarattere.Text = "" Then
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
        If MinionOneF.FastColoredTextBox1.Text.Contains("id=" & Chr(34) & TextBox9.Text & Chr(34)) Then

            Text = ("Nome già utilizzato.")
            MessaggioF.Button1.Text = ("Questo nome è stato già utilizzato nel progetto attualmente aperto." & vbNewLine & "Inseriscine un altro.")
            MessaggioF.DettagliErroreButton.Visible = False
            MessaggioF.ErroreTxt.Text = ("")
            MessaggioF.ShowDialog()
        Else
            If TextBox24.Text = ("si") Then
                If MinionOneF.CSSSIoNOtb.Text = ("no") Then
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@testo da visualizzare@@", TextBox1.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@colore testo@@", ParagrafoColoreTesto.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-family@@", ParagrafoTestoCarattere.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@text-align@@", TextBox19.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-style@@", TextBox22.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-weight@@", TextBox21.Text)
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
                    MinionOneF.DagliAppunti.Copy()
                    MinionOneF.FastColoredTextBox1.Select()
                    Me.Close()
                Else
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@testo da visualizzare@@", TextBox1.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@colore testo@@", ParagrafoColoreTesto.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-family@@", ParagrafoTestoCarattere.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@text-align@@", TextBox19.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-style@@", TextBox22.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-weight@@", TextBox21.Text)
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
                    MinionOneF.DagliAppunti.Copy()
                    MinionOneF.FastColoredTextBox1.Select()
                    MinionOneF.CSSFTB.Text = (MinionOneF.CSSFTB.Text & BottoneCodiceCSS.Text)
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke

        Button46.BackColor = Color.Silver
        TextBox19.Text = ("left")
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke

        Button45.BackColor = Color.Silver
        TextBox19.Text = ("center")
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Button46.BackColor = Color.WhiteSmoke
        Button45.BackColor = Color.WhiteSmoke
        Button44.BackColor = Color.WhiteSmoke

        Button44.BackColor = Color.Silver
        TextBox19.Text = ("right")
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Panel17.BackColor = PictureBox15.BackColor
        ParagrafoColoreTesto.Text = ("#000000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Panel17.BackColor = PictureBox13.BackColor
        ParagrafoColoreTesto.Text = ("#0000FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Panel17.BackColor = PictureBox12.BackColor
        ParagrafoColoreTesto.Text = ("#FF00FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Panel17.BackColor = PictureBox14.BackColor
        ParagrafoColoreTesto.Text = ("#FF0000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Panel17.BackColor = PictureBox19.BackColor
        ParagrafoColoreTesto.Text = ("#00FF00")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Panel17.BackColor = PictureBox18.BackColor
        ParagrafoColoreTesto.Text = ("#FFFF00")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Panel17.BackColor = PictureBox17.BackColor
        ParagrafoColoreTesto.Text = ("#00FFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Panel17.BackColor = PictureBox16.BackColor
        ParagrafoColoreTesto.Text = ("#FFFFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub Descrizione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox5.Text = "px"
        Dim i As New Integer
        i = 1
        If MinionOneF.buttprogcss.Visible = True And MinionOneF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Paragrafo" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Paragrafo" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MinionOneF.CSSFTB.Text.Contains(TextBox9.Text)
        End If
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If Panel27.Visible = False Then
            Panel27.Visible = True
            Button43.BackColor = Color.Gray
        Else
            Panel27.Visible = False
            Button43.BackColor = Panel1.BackColor
        End If
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

    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        TextBox10.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
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

    Private Sub ComboBox5_Click(sender As Object, e As EventArgs) Handles ComboBox5.Click
        ComboBox5.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Colori.Dove.Text = ("TestoColoreParagrafo")


        Colori.HEXTextBox.Text = ParagrafoColoreTesto.Text.Replace("#", "")
        Colori.TextBox1.Text = Colori.InvertiHEX(Colori.HEXTextBox.Text)
        Colori.AnteprimaColore.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & Colori.TextBox1.Text)


        Button43.BackColor = Panel1.BackColor
        Panel27.Visible = False
        Colori.ShowDialog()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Carattere.Dove.Text = ("ParagrafoTesto")


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
        If ParagrafoTestoCarattere.Text = "monospace" Then
            Carattere.Font1.BackColor = Color.Gray
            Carattere.Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font1.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ParagrafoTestoCarattere.Text
        ElseIf ParagrafoTestoCarattere.Text = "serif" Then
            Carattere.Font2.BackColor = Color.Gray
            Carattere.Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font2.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ParagrafoTestoCarattere.Text
        ElseIf ParagrafoTestoCarattere.Text = "sans-serif" Then
            Carattere.Font3.BackColor = Color.Gray
            Carattere.Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font3.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ParagrafoTestoCarattere.Text
        ElseIf ParagrafoTestoCarattere.Text = "script" Then
            Carattere.Font4.BackColor = Color.Gray
            Carattere.Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font4.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ParagrafoTestoCarattere.Text
        ElseIf ParagrafoTestoCarattere.Text = "open-serif" Then
            Carattere.Font5.BackColor = Color.Gray
            Carattere.Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font5.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ParagrafoTestoCarattere.Text
        ElseIf ParagrafoTestoCarattere.Text = "cursive" Then
            Carattere.Font6.BackColor = Color.Gray
            Carattere.Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font6.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ParagrafoTestoCarattere.Text
        End If


        Button47.BackColor = Panel1.BackColor
        Carattere.ShowDialog()
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        If TextBox15.Text = "" Then
            TextBox15.Text = ("1")
        End If
        TextBox15.Text += 1
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        If TextBox15.Text = "" Then
            TextBox15.Text = ("1")
        End If
        If TextBox15.Text = "" Or TextBox15.Text.Replace(" ", "") = "" Or TextBox15.Text = "1" Then
        Else
            TextBox15.Text -= 1
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/Paragrafo/")
    End Sub
End Class