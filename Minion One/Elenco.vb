Public Class Elenco
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If TextBox9.Text = "" Then
            TextBox9.BackColor = Color.Red
        End If
        If TextBox1.Text.Replace("•  ", "") = "" And TextBox2.Text = "ul" Then
            TextBox1.BackColor = Color.Red
        ElseIf FastTextBox1.Text = "" And TextBox2.Text = "ol" Then
            FastTextBox1.BackColor = Color.Red
        End If
        If TextBox13.Text = "" Then
            TextBox13.BackColor = Color.Red
        End If
        If TextBox11.Text = "" Then
            TextBox11.BackColor = Color.Red
        End If
        If TextBox12.Text = "" Then
            TextBox12.BackColor = Color.Red
        End If
        If TextBox10.Text = "" Then
            TextBox10.BackColor = Color.Red
        End If
        If ElencoColoreTesto.Text = "" Then
            Button43.BackColor = Color.Red
        End If
        If ElencoTestoCarattere.Text = "" Then
            Button47.BackColor = Color.Red
        End If
        If TextBox15.Text = "" Then
            TextBox15.BackColor = Color.Red
        End If
        If ComboBox5.Text = "" Then
            ComboBox5.BackColor = Color.Red
        End If
        If TextBox19.Text = "" Then
            Button46.BackColor = Color.Red
            Button45.BackColor = Color.Red
            Button44.BackColor = Color.Red
        End If

        If TextBox9.Text = "" Or TextBox9.Text = "" Or TextBox13.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox10.Text = "" Or TextBox15.Text = "" Or ComboBox5.Text = "" Then
            TextBox24.Text = "no"
        Else
            If TextBox2.Text = "ol" And FastTextBox1.Text <> "" Then
                TextBox24.Text = "si"
            ElseIf TextBox2.Text = "ul" And TextBox1.Text.Replace("•  ", "") <> "" Then
                TextBox24.Text = "si"
            Else
                TextBox24.Text = "no"
            End If
        End If

        If MyCEF.FastColoredTextBox1.Text.Contains("id=" & Chr(34) & TextBox9.Text & Chr(34)) Then
            MessaggioF.Text = ("Nome già utilizzato.")
            MessaggioF.Button1.Text = ("Questo nome è stato già utilizzato nel progetto attualmente aperto." & vbNewLine & "Inseriscine un altro.")
            MessaggioF.DettagliErroreButton.Visible = False
            MessaggioF.ErroreTxt.Text = ("")
            MessaggioF.ShowDialog()
        Else
            If TextBox24.Text = ("si") Then
                If MyCEF.CSSSIoNOtb.Text = ("no") Then
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@tipo@@", TextBox2.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@name@@", TextBox9.Text.Replace(" ", "-"))
                    If TextBox2.Text = ("ol") Then
                        FastTextBox1.Text = ("<li>" & FastTextBox1.Text)
                        FastTextBox1.Text = (FastTextBox1.Text.Replace(vbNewLine, "</li>##@@##@@<li>"))
                        FastTextBox1.Text = (FastTextBox1.Text.Replace("##@@##@@", vbNewLine))
                        BottoneCodice.Text = BottoneCodice.Text.Replace("@@elenco@@", FastTextBox1.Text & "</li>")
                    Else
                        TextBox1.Text = (TextBox1.Text.Replace(vbNewLine & "•  ", ""))
                        TextBox1.Text = (TextBox1.Text.Replace("•  ", ""))
                        FastTextBox1.Text = (TextBox1.Text)
                        FastTextBox1.Text = ("<li>" & FastTextBox1.Text)
                        FastTextBox1.Text = (FastTextBox1.Text.Replace(vbNewLine, "</li>##@@##@@<li>"))
                        FastTextBox1.Text = (FastTextBox1.Text.Replace("##@@##@@", vbNewLine))
                        BottoneCodice.Text = BottoneCodice.Text.Replace("@@elenco@@", FastTextBox1.Text & "</li>")
                    End If
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@colore testo@@", ElencoColoreTesto.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-family@@", ElencoTestoCarattere.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@text-align@@", TextBox19.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-style@@", TextBox22.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-weight@@", TextBox21.Text)
                    MyCEF.buttproghtml.BackColor = Color.Red
                    MyCEF.buttprogcss.BackColor = Color.DarkRed
                    MyCEF.AnteprimaWB.Visible = False
                    MyCEF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MyCEF.AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
                    MyCEF.CSSFTB.Visible = False
                    MyCEF.FastColoredTextBox1.Visible = True
                    MyCEF.DagliAppunti.Paste()
                    MyCEF.DaIncollare.Text = vbNewLine & Me.BottoneCodice.Text & vbNewLine
                    MyCEF.DaIncollare.SelectAll()
                    MyCEF.DaIncollare.Copy()
                    MyCEF.FastColoredTextBox1.Paste()
                    MyCEF.DaIncollare.Text = ""
                    MyCEF.DagliAppunti.SelectAll()
                    My.Computer.Clipboard.Clear()
                    MyCEF.DagliAppunti.Copy()
                    MyCEF.FastColoredTextBox1.Select()
                    Me.Close()
                Else
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@name@@", TextBox9.Text.Replace(" ", "-"))
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@name@@", TextBox9.Text.Replace(" ", "-"))
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@tipo@@", TextBox2.Text)
                    If TextBox2.Text = ("ol") Then
                        FastTextBox1.Text = ("<li>" & FastTextBox1.Text)
                        FastTextBox1.Text = (FastTextBox1.Text.Replace(vbNewLine, "</li>##@@##@@<li>"))
                        FastTextBox1.Text = (FastTextBox1.Text.Replace("##@@##@@", vbNewLine))
                        BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@elenco@@", FastTextBox1.Text & "</li>")
                    Else
                        TextBox1.Text = (TextBox1.Text.Replace(vbNewLine & "•  ", ""))
                        TextBox1.Text = (TextBox1.Text.Replace("•  ", ""))
                        FastTextBox1.Text = (TextBox1.Text)
                        FastTextBox1.Text = ("<li>" & FastTextBox1.Text)
                        FastTextBox1.Text = (FastTextBox1.Text.Replace(vbNewLine, "</li>##@@##@@<li>"))
                        FastTextBox1.Text = (FastTextBox1.Text.Replace("##@@##@@", vbNewLine))
                        BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@elenco@@", FastTextBox1.Text & "</li>")
                    End If
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@colore testo@@", ElencoColoreTesto.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-family@@", ElencoTestoCarattere.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@text-align@@", TextBox19.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-style@@", TextBox22.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-weight@@", TextBox21.Text)
                    MyCEF.buttproghtml.BackColor = Color.Red
                    MyCEF.buttprogcss.BackColor = Color.DarkRed
                    MyCEF.AnteprimaWB.Visible = False
                    MyCEF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MyCEF.AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
                    MyCEF.CSSFTB.Visible = False
                    MyCEF.FastColoredTextBox1.Visible = True
                    MyCEF.DagliAppunti.Paste()
                    MyCEF.DaIncollare.Text = vbNewLine & Me.BottoneCodiceHTML.Text & vbNewLine
                    MyCEF.DaIncollare.SelectAll()
                    MyCEF.DaIncollare.Copy()
                    MyCEF.FastColoredTextBox1.Paste()
                    MyCEF.DaIncollare.Text = ""
                    MyCEF.DagliAppunti.SelectAll()
                    My.Computer.Clipboard.Clear()
                    MyCEF.DagliAppunti.Copy()
                    MyCEF.FastColoredTextBox1.Select()
                    MyCEF.CSSFTB.Text = (MyCEF.CSSFTB.Text & BottoneCodiceCSS.Text)
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
        ElencoColoreTesto.Text = ("#000000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Panel17.BackColor = PictureBox13.BackColor
        ElencoColoreTesto.Text = ("#0000FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Panel17.BackColor = PictureBox12.BackColor
        ElencoColoreTesto.Text = ("#FF00FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Panel17.BackColor = PictureBox14.BackColor
        ElencoColoreTesto.Text = ("#FF0000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Panel17.BackColor = PictureBox19.BackColor
        ElencoColoreTesto.Text = ("#00FF00")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Panel17.BackColor = PictureBox18.BackColor
        ElencoColoreTesto.Text = ("#FFFF00")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Panel17.BackColor = PictureBox17.BackColor
        ElencoColoreTesto.Text = ("#00FFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Panel17.BackColor = PictureBox16.BackColor
        ElencoColoreTesto.Text = ("#FFFFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub Descrizione_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FastTextBox1.Select()
        If MyCEF.SelezionatoSalvatoDagliAppunti.Text <> "" Then
            TextBox1.Text = MyCEF.SelezionatoSalvatoDagliAppunti.Text
            FastTextBox1.Text = MyCEF.SelezionatoSalvatoDagliAppunti.Text
            TextBox9.Select()
        End If
        MyCEF.SelezionatoSalvatoDagliAppunti.SelectAll()
        MyCEF.SelezionatoSalvatoDagliAppunti.Clear()
        ComboBox5.Text = "px"
        Dim i As New Integer
        i = 1
        If MyCEF.buttprogcss.Visible = True And MyCEF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Elenco" & i
                i += 1
            Loop While MyCEF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Elenco" & i
                i += 1
            Loop While MyCEF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MyCEF.CSSFTB.Text.Contains(TextBox9.Text)
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
        If TextBox1.Text.Replace(" ", "") = "" Or TextBox1.Text = "" Then
            MyCEF.DagliAppunti.Paste()
            MyCEF.DaIncollare.Text = "•  "
            MyCEF.DaIncollare.SelectAll()
            MyCEF.DaIncollare.Copy()
            TextBox1.Paste()
            MyCEF.DaIncollare.Text = ""
            MyCEF.DagliAppunti.SelectAll()
            My.Computer.Clipboard.Clear()
            MyCEF.DagliAppunti.Copy()
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            MyCEF.DagliAppunti.Paste()
            MyCEF.DaIncollare.Text = vbNewLine & "•  "
            MyCEF.DaIncollare.SelectAll()
            MyCEF.DaIncollare.Copy()
            TextBox1.Paste()
            MyCEF.DaIncollare.Text = ""
            MyCEF.DagliAppunti.SelectAll()
            My.Computer.Clipboard.Clear()
            MyCEF.DagliAppunti.Copy()
            TextBox1.Select()
        End If
        If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
            e.SuppressKeyPress = False
        End If
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
        Colori.Dove.Text = ("TestoColoreElenco")


        Colori.HEXTextBox.Text = ElencoColoreTesto.Text.Replace("#", "")
        Colori.TextBox1.Text = Colori.InvertiHEX(Colori.HEXTextBox.Text)
        Colori.AnteprimaColore.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & Colori.TextBox1.Text)


        Button43.BackColor = Panel1.BackColor
        Panel27.Visible = False
        Colori.ShowDialog()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Carattere.Dove.Text = ("ElencoTesto")

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
        If ElencoTestoCarattere.Text = "monospace" Then
            Carattere.Font1.BackColor = Color.Gray
            Carattere.Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font1.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ElencoTestoCarattere.Text
        ElseIf ElencoTestoCarattere.Text = "serif" Then
            Carattere.Font2.BackColor = Color.Gray
            Carattere.Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font2.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ElencoTestoCarattere.Text
        ElseIf ElencoTestoCarattere.Text = "sans-serif" Then
            Carattere.Font3.BackColor = Color.Gray
            Carattere.Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font3.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ElencoTestoCarattere.Text
        ElseIf ElencoTestoCarattere.Text = "script" Then
            Carattere.Font4.BackColor = Color.Gray
            Carattere.Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font4.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ElencoTestoCarattere.Text
        ElseIf ElencoTestoCarattere.Text = "open-serif" Then
            Carattere.Font5.BackColor = Color.Gray
            Carattere.Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font5.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ElencoTestoCarattere.Text
        ElseIf ElencoTestoCarattere.Text = "cursive" Then
            Carattere.Font6.BackColor = Color.Gray
            Carattere.Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font6.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = ElencoTestoCarattere.Text
        End If


        Button47.BackColor = Panel1.BackColor
        Carattere.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.BackColor = Color.WhiteSmoke
        Button10.BackColor = Color.WhiteSmoke
        If TextBox2.Text = ("ul") Then
            TextBox1.Text = (TextBox1.Text.Replace(vbNewLine & "•  ", ""))
            TextBox1.Text = (TextBox1.Text.Replace("•  ", ""))
            FastTextBox1.Text = (TextBox1.Text)
        End If

        TextBox1.Visible = False
        FastTextBox1.Visible = True
        Button8.BackColor = Color.Silver
        TextBox2.Text = ("ol")
        FastTextBox1.Select()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button8.BackColor = Color.WhiteSmoke
        Button10.BackColor = Color.WhiteSmoke
        If TextBox2.Text = ("ol") Then
            FastTextBox1.Text = ("•  " & FastTextBox1.Text)
            FastTextBox1.Text = (FastTextBox1.Text.Replace(vbNewLine, "##@@##@@ •   "))
            FastTextBox1.Text = (FastTextBox1.Text.Replace("##@@##@@", vbNewLine))
            TextBox1.Text = (FastTextBox1.Text)
        End If

        TextBox1.Visible = True
        FastTextBox1.Visible = False
        Button10.BackColor = Color.Silver
        TextBox2.Text = ("ul")
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/Elenco/")
    End Sub

    Private Sub TextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        If TextBox15.Text = "" Then
            TextBox15.Text = ("1")
        End If
        TextBox15.Text += 1
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
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
            Button17.BackColor = Color.White
        Else
            TextBox21.Text = ("bold")
            Button17.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox22.Text = ("italic") Then
            TextBox22.Text = ("none")
            Button18.BackColor = Color.White
        Else
            TextBox22.Text = ("italic")
            Button18.BackColor = Color.Silver
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If Button19.BackColor = Color.White Then
            TextBox23.Text = ("underline")
            Button20.BackColor = Color.White
            Button19.BackColor = Color.Silver
        ElseIf Button19.BackColor = Color.Silver Then
            TextBox23.Text = ("none")
            Button20.BackColor = Color.White
            Button19.BackColor = Color.White
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If Button20.BackColor = Color.White Then
            TextBox23.Text = ("line-through")
            Button20.BackColor = Color.Silver
            Button19.BackColor = Color.White
        ElseIf Button20.BackColor = Color.Silver Then
            TextBox23.Text = ("none")
            Button20.BackColor = Color.White
            Button19.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If TextBox2.Text = "ol" Then
            FastTextBox1.Select()
            FastTextBox1.Copy()
        Else
            FastTextBox1.Select()
            TextBox1.Copy()
        End If
    End Sub

    Private Sub IncollaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem.Click
        If TextBox2.Text = "ol" Then
            FastTextBox1.Select()
            FastTextBox1.Paste()
        Else
            TextBox1.Select()
            TextBox1.Paste()
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        TextBox9.SelectAll()
        TextBox9.Copy()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        TextBox9.SelectAll()
        TextBox9.Paste()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        TextBox13.SelectAll()
        TextBox13.Copy()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        TextBox13.SelectAll()
        TextBox13.Paste()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        TextBox11.SelectAll()
        TextBox11.Copy()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        TextBox11.SelectAll()
        TextBox11.Paste()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        TextBox12.SelectAll()
        TextBox12.Copy()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        TextBox12.SelectAll()
        TextBox12.Paste()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        TextBox10.SelectAll()
        TextBox10.Copy()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        TextBox10.SelectAll()
        TextBox10.Paste()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        TextBox15.SelectAll()
        TextBox15.Copy()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        TextBox15.SelectAll()
        TextBox15.Paste()
    End Sub

    Private Sub FastTextBox1_Load(sender As Object, e As EventArgs) Handles FastTextBox1.Load

    End Sub

    Private Sub FastTextBox1_Click(sender As Object, e As EventArgs) Handles FastTextBox1.Click
        FastTextBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        If TextBox13.Text = "" Then TextBox13.Text = "0"
        TextBox13.Text += 1
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        If TextBox13.Text = "" Then TextBox13.Text = "0"
        TextBox13.Text -= 1
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox11.Text = "" Then TextBox11.Text = "0"
        TextBox11.Text -= 1
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox11.Text = "" Then TextBox11.Text = "0"
        TextBox11.Text += 1
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox12.Text = "" Then TextBox12.Text = "0"
        TextBox12.Text -= 1
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox12.Text = "" Then TextBox12.Text = "0"
        TextBox12.Text += 1
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox10.Text = "" Then TextBox10.Text = "0"
        TextBox10.Text -= 1
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If TextBox10.Text = "" Then TextBox10.Text = "0"
        TextBox10.Text += 1
    End Sub
End Class