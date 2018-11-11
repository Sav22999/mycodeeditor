Public Class Collegamento

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        Colori.Dove.Text = ("TestoColoreCollegamento")


        Colori.HEXTextBox.Text = CollegamentoColore.Text.Replace("#", "")
        Colori.TextBox1.Text = Colori.InvertiHEX(Colori.HEXTextBox.Text)
        Colori.AnteprimaColore.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & Colori.TextBox1.Text)


        Button90.BackColor = Panel1.BackColor
        Panel2.Visible = False
        Colori.ShowDialog()
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

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Panel10.BackColor = PictureBox6.BackColor
        CollegamentoColore.Text = ("#000000")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Panel10.BackColor = PictureBox4.BackColor
        CollegamentoColore.Text = ("#0000FF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel10.BackColor = PictureBox3.BackColor
        CollegamentoColore.Text = ("#FF00FF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Panel10.BackColor = PictureBox5.BackColor
        CollegamentoColore.Text = ("#FF0000")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Carattere.Dove.Text = ("CollegamentoTesto")


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
        If CollegamentoTestoCarattere.Text = "monospace" Then
            Carattere.Font1.BackColor = Color.Gray
            Carattere.Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font1.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = CollegamentoTestoCarattere.Text
        ElseIf CollegamentoTestoCarattere.Text = "serif" Then
            Carattere.Font2.BackColor = Color.Gray
            Carattere.Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font2.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = CollegamentoTestoCarattere.Text
        ElseIf CollegamentoTestoCarattere.Text = "sans-serif" Then
            Carattere.Font3.BackColor = Color.Gray
            Carattere.Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font3.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = CollegamentoTestoCarattere.Text
        ElseIf CollegamentoTestoCarattere.Text = "script" Then
            Carattere.Font4.BackColor = Color.Gray
            Carattere.Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font4.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = CollegamentoTestoCarattere.Text
        ElseIf CollegamentoTestoCarattere.Text = "open-serif" Then
            Carattere.Font5.BackColor = Color.Gray
            Carattere.Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font5.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = CollegamentoTestoCarattere.Text
        ElseIf CollegamentoTestoCarattere.Text = "cursive" Then
            Carattere.Font6.BackColor = Color.Gray
            Carattere.Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Carattere.Font6.FlatAppearance.MouseOverBackColor = Color.Gray

            Carattere.CarattereTB.Text = CollegamentoTestoCarattere.Text
        End If


        Button47.BackColor = Panel1.BackColor
        Carattere.ShowDialog()
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

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If TextBox1.Text = "" Then
            TextBox1.BackColor = Color.Red
        End If
        If TextBox2.Text = "" Then
            TextBox2.BackColor = Color.Red
        End If
        If TextBox9.Text = "" Then
            TextBox9.BackColor = Color.Red
        End If
        If CollegamentoColore.Text = "" Then
            Button90.BackColor = Color.Red
        End If
        If TextBox16.Text = "" Then
            TextBox16.BackColor = Color.Red
        End If
        If CollegamentoTestoCarattere.Text = "" Then
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

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox9.Text = "" Or TextBox9.Text = "" Or TextBox16.Text = "" Or TextBox15.Text = "" Then
            TextBox24.Text = "no"
        Else
            TextBox24.Text = "si"
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
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@testo da visualizzare@@", TextBox1.Text)
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@URL di destinazione@@", TextBox2.Text)
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@titolo@@", TextBox16.Text)
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@colore testo@@", CollegamentoColore.Text)
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@font-family@@", CollegamentoTestoCarattere.Text)
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@text-align@@", TextBox19.Text)
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@font-style@@", TextBox22.Text)
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    CollegamentoCodice.Text = CollegamentoCodice.Text.Replace("@@font-weight@@", TextBox21.Text)
                    MyCEF.buttproghtml.BackColor = Color.Red
                    MyCEF.buttprogcss.BackColor = Color.DarkRed
                    MyCEF.AnteprimaWB.Visible = False
                    MyCEF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MyCEF.AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
                    MyCEF.CSSFTB.Visible = False
                    MyCEF.FastColoredTextBox1.Visible = True
                    MyCEF.DagliAppunti.Paste()
                    MyCEF.DaIncollare.Text = vbNewLine & Me.CollegamentoCodice.Text & vbNewLine
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
                    CollegamentoCodiceCSS.Text = CollegamentoCodiceCSS.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    CollegamentoCodiceHTML.Text = CollegamentoCodiceHTML.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    CollegamentoCodiceHTML.Text = CollegamentoCodiceHTML.Text.Replace("@@testo da visualizzare@@", TextBox1.Text)
                    CollegamentoCodiceHTML.Text = CollegamentoCodiceHTML.Text.Replace("@@URL di destinazione@@", TextBox2.Text)
                    CollegamentoCodiceHTML.Text = CollegamentoCodiceHTML.Text.Replace("@@titolo@@", TextBox16.Text)
                    CollegamentoCodiceCSS.Text = CollegamentoCodiceCSS.Text.Replace("@@colore testo@@", CollegamentoColore.Text)
                    CollegamentoCodiceCSS.Text = CollegamentoCodiceCSS.Text.Replace("@@font-family@@", CollegamentoTestoCarattere.Text)
                    CollegamentoCodiceCSS.Text = CollegamentoCodiceCSS.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    CollegamentoCodiceCSS.Text = CollegamentoCodiceCSS.Text.Replace("@@text-align@@", TextBox19.Text)
                    CollegamentoCodiceCSS.Text = CollegamentoCodiceCSS.Text.Replace("@@font-style@@", TextBox22.Text)
                    CollegamentoCodiceCSS.Text = CollegamentoCodiceCSS.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    CollegamentoCodiceCSS.Text = CollegamentoCodiceCSS.Text.Replace("@@font-weight@@", TextBox21.Text)
                    MyCEF.buttproghtml.BackColor = Color.Red
                    MyCEF.buttprogcss.BackColor = Color.DarkRed
                    MyCEF.AnteprimaWB.Visible = False
                    MyCEF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MyCEF.AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
                    MyCEF.CSSFTB.Visible = False
                    MyCEF.FastColoredTextBox1.Visible = True
                    MyCEF.DagliAppunti.Paste()
                    MyCEF.DaIncollare.Text = vbNewLine & Me.CollegamentoCodiceHTML.Text & vbNewLine
                    MyCEF.DaIncollare.SelectAll()
                    MyCEF.DaIncollare.Copy()
                    MyCEF.FastColoredTextBox1.Paste()
                    MyCEF.DaIncollare.Text = ""
                    MyCEF.DagliAppunti.SelectAll()
                    My.Computer.Clipboard.Clear()
                    MyCEF.DagliAppunti.Copy()
                    MyCEF.FastColoredTextBox1.Select()
                    MyCEF.CSSFTB.Text = (MyCEF.CSSFTB.Text & CollegamentoCodiceCSS.Text)
                    Me.Close()
                End If
            End If
        End If
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

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_CausesValidationChanged(sender As Object, e As EventArgs) Handles TextBox2.CausesValidationChanged

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox16_Click(sender As Object, e As EventArgs) Handles TextBox16.Click
        TextBox16.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub ComboBox5_Click(sender As Object, e As EventArgs) Handles ComboBox5.Click
        ComboBox5.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Collegamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
        If MyCEF.SelezionatoSalvatoDagliAppunti.Text <> "" Then
            TextBox1.Text = MyCEF.SelezionatoSalvatoDagliAppunti.Text
            TextBox2.Select()
        End If
        MyCEF.SelezionatoSalvatoDagliAppunti.SelectAll()
        MyCEF.SelezionatoSalvatoDagliAppunti.Clear()
        ComboBox5.Text = "px"
        Dim i As New Integer
        i = 1
        If MyCEF.buttprogcss.Visible = True And MyCEF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Collegamento" & i
                i += 1
            Loop While MyCEF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Collegamento" & i
                i += 1
            Loop While MyCEF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MyCEF.CSSFTB.Text.Contains(TextBox9.Text)
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Panel10.BackColor = PictureBox11.BackColor
        CollegamentoColore.Text = ("#00FF00")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Panel10.BackColor = PictureBox10.BackColor
        CollegamentoColore.Text = ("#FFFF00")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Panel10.BackColor = PictureBox8.BackColor
        CollegamentoColore.Text = ("#00FFFF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel10.BackColor = PictureBox7.BackColor
        CollegamentoColore.Text = ("#FFFFFF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        If TextBox15.Text = "" Then
            TextBox15.Text = ("1")
        End If
        TextBox15.Text += 1
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        If TextBox15.Text = "" Then
            TextBox15.Text = ("1")
        End If
        If TextBox15.Text = "" Or TextBox15.Text.Replace(" ", "") = "" Or TextBox15.Text = "1" Then
        Else
            TextBox15.Text -= 1
        End If
    End Sub

    Private Sub CiaoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox2.Text = TextBox1.SelectionLength
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/Collegamento/")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox1.Select()
        TextBox1.Copy()
    End Sub

    Private Sub IncollaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem.Click
        TextBox1.Select()
        TextBox1.Paste()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        TextBox2.Select()
        TextBox2.Copy()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        TextBox2.Select()
        TextBox2.Paste()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        TextBox9.Select()
        TextBox9.Copy()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        TextBox9.Select()
        TextBox9.Paste()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        TextBox16.Select()
        TextBox16.Copy()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        TextBox16.Select()
        TextBox16.Paste()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        TextBox15.SelectAll()
        TextBox15.Copy()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        TextBox15.SelectAll()
        TextBox15.Paste()
    End Sub
End Class