Public Class Elenco
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
        If ElencoColoreTesto.Text = "" Then
            Button43.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If ElencoTestoCarattere.Text = "" Then
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
        If TextBox19.Text = "" Then
            Button46.BackColor = Color.Red
            Button45.BackColor = Color.Red
            Button44.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If MinionOneF.FastColoredTextBox1.Text.Contains("id=" & Chr(34) & TextBox9.Text & Chr(34)) Then
            MessaggioF.Text = ("Nome già utilizzato.")
            MessaggioF.Button1.Text = ("Questo nome è stato già utilizzato nel progetto attualmente aperto." & vbNewLine & "Inseriscine un altro.")
            MessaggioF.ShowDialog()
        Else
            If TextBox24.Text = ("si") Then
                If MinionOneF.CSSSIoNOtb.Text = ("no") Then
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@tipo@@", TextBox2.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@name@@", TextBox9.Text.Replace(" ", "-"))
                    If TextBox2.Text = ("ol") Then
                        FastTextBox1.Text = ("<li>" & FastTextBox1.Text)
                        FastTextBox1.Text = (FastTextBox1.Text.Replace(vbNewLine, "</li>##@@##@@<li>"))
                        FastTextBox1.Text = (FastTextBox1.Text.Replace("##@@##@@", vbNewLine))
                        BottoneCodice.Text = BottoneCodice.Text.Replace("@@elenco@@", FastTextBox1.Text & "</li>")
                    Else
                        TextBox1.Text = (TextBox1.Text.Replace(vbNewLine & " •   ", ""))
                        TextBox1.Text = (TextBox1.Text.Replace(" •   ", ""))
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
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@name@@", TextBox9.Text.Replace(" ", "-"))
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@name@@", TextBox9.Text.Replace(" ", "-"))
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@tipo@@", TextBox2.Text)
                    If TextBox2.Text = ("ol") Then
                        FastTextBox1.Text = ("<li>" & FastTextBox1.Text)
                        FastTextBox1.Text = (FastTextBox1.Text.Replace(vbNewLine, "</li>##@@##@@<li>"))
                        FastTextBox1.Text = (FastTextBox1.Text.Replace("##@@##@@", vbNewLine))
                        BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@elenco@@", FastTextBox1.Text & "</li>")
                    Else
                        TextBox1.Text = (TextBox1.Text.Replace(vbNewLine & " •   ", ""))
                        TextBox1.Text = (TextBox1.Text.Replace(" •   ", ""))
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
        Dim i As New Integer
        i = 1
        If MinionOneF.buttprogcss.Visible = True And MinionOneF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Elenco" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Elenco" & i
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
        If TextBox1.Text.Replace(" ", "") = "" Or TextBox1.Text = "" Then
            MinionOneF.DagliAppunti.Paste()
            MinionOneF.DaIncollare.Text = " •   "
            MinionOneF.DaIncollare.SelectAll()
            MinionOneF.DaIncollare.Copy()
            TextBox1.Paste()
            MinionOneF.DaIncollare.Text = ""
            MinionOneF.DagliAppunti.SelectAll()
            MinionOneF.DagliAppunti.Copy()
            TextBox1.Select()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            MinionOneF.DagliAppunti.Paste()
            MinionOneF.DaIncollare.Text = vbNewLine & " •   "
            MinionOneF.DaIncollare.SelectAll()
            MinionOneF.DaIncollare.Copy()
            TextBox1.Paste()
            MinionOneF.DaIncollare.Text = ""
            MinionOneF.DagliAppunti.SelectAll()
            MinionOneF.DagliAppunti.Copy()
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
        Button43.BackColor = Panel1.BackColor
        Panel27.Visible = False
        Colori.ShowDialog()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Carattere.Dove.Text = ("ElencoTesto")
        Button47.BackColor = Panel1.BackColor
        Carattere.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.BackColor = Color.WhiteSmoke
        Button10.BackColor = Color.WhiteSmoke

        If TextBox2.Text = ("ul") Then
            TextBox1.Text = (TextBox1.Text.Replace(vbNewLine & " •   ", ""))
            TextBox1.Text = (TextBox1.Text.Replace(" •   ", ""))
            FastTextBox1.Text = (TextBox1.Text)
        End If

        TextBox1.Visible = False
        FastTextBox1.Visible = True
        Button8.BackColor = Color.Silver
        TextBox2.Text = ("ol")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button8.BackColor = Color.WhiteSmoke
        Button10.BackColor = Color.WhiteSmoke

        If TextBox2.Text = ("ol") Then
            FastTextBox1.Text = (" •   " & FastTextBox1.Text)
            FastTextBox1.Text = (FastTextBox1.Text.Replace(vbNewLine, "##@@##@@ •   "))
            FastTextBox1.Text = (FastTextBox1.Text.Replace("##@@##@@", vbNewLine))
            TextBox1.Text = (FastTextBox1.Text)
        End If

        TextBox1.Visible = True
        FastTextBox1.Visible = False
        Button10.BackColor = Color.Silver
        TextBox2.Text = ("ul")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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
End Class