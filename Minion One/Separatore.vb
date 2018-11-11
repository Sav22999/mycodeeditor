﻿Public Class Separatore

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If Panel27.Visible = False Then
            Panel27.Visible = True
            Button43.BackColor = Color.Gray
        Else
            Panel27.Visible = False
            Button43.BackColor = Panel1.BackColor
        End If
    End Sub
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Panel17.BackColor = PictureBox15.BackColor
        SeparatoreTestoColore.Text = ("#000000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Panel17.BackColor = PictureBox13.BackColor
        SeparatoreTestoColore.Text = ("#0000FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Panel17.BackColor = PictureBox12.BackColor
        SeparatoreTestoColore.Text = ("#FF00FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Panel17.BackColor = PictureBox14.BackColor
        SeparatoreTestoColore.Text = ("#FF0000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Panel17.BackColor = PictureBox19.BackColor
        SeparatoreTestoColore.Text = ("#00FF00")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Panel17.BackColor = PictureBox18.BackColor
        SeparatoreTestoColore.Text = ("#FF00FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Panel17.BackColor = PictureBox17.BackColor
        SeparatoreTestoColore.Text = ("#00FFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Panel17.BackColor = PictureBox16.BackColor
        SeparatoreTestoColore.Text = ("#FFFFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Colori.Dove.Text = ("TestoColoreSeparatore")


        Colori.HEXTextBox.Text = SeparatoreTestoColore.Text.Replace("#", "")
        Colori.TextBox1.Text = Colori.InvertiHEX(Colori.HEXTextBox.Text)
        Colori.AnteprimaColore.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & Colori.TextBox1.Text)


        Button43.BackColor = Panel1.BackColor
        Panel27.Visible = False
        Colori.ShowDialog()
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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.BackColor = Color.WhiteSmoke
        If TextBox1.Text = "" Then
            TextBox1.Text = ("0")
        End If
        TextBox1.Text += 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.BackColor = Color.WhiteSmoke
        If TextBox1.Text = "" Then
            TextBox1.Text = ("0")
        End If
        If TextBox1.Text = "" Or TextBox1.Text.Replace(" ", "") = "" Or TextBox1.Text = "1" Then
        Else
            TextBox1.Text -= 1
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

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        TextBox24.Text = "si"
        If TextBox9.Text = "" Then
            TextBox9.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If SeparatoreTestoColore.Text = "" Then
            Button43.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox13.Text = "" Then
            TextBox13.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox11.Text = "" Then
            TextBox11.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox12.Text = "" Then
            TextBox12.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox10.Text = "" Then
            TextBox10.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox1.Text = "" Then
            TextBox1.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox15.Text = "" Then
            TextBox15.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox20.Text = "" Then
            TextBox20.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If ComboBox1.Text = "" Then
            ComboBox1.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If ComboBox5.Text = "" Then
            ComboBox5.BackColor = Color.Red
            TextBox24.Text = ("no")
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
                    SeparatoreCodice.Text = SeparatoreCodice.Text.Replace("@@name@@", TextBox9.Text.Replace(" ", "-"))
                    SeparatoreCodice.Text = SeparatoreCodice.Text.Replace("@@colore@@", SeparatoreTestoColore.Text)
                    SeparatoreCodice.Text = SeparatoreCodice.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    SeparatoreCodice.Text = SeparatoreCodice.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    SeparatoreCodice.Text = SeparatoreCodice.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    SeparatoreCodice.Text = SeparatoreCodice.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    SeparatoreCodice.Text = SeparatoreCodice.Text.Replace("@@lunghezza@@", TextBox1.Text & ComboBox1.Text)
                    SeparatoreCodice.Text = SeparatoreCodice.Text.Replace("@@spessore@@", TextBox15.Text & ComboBox5.Text)
                    SeparatoreCodice.Text = SeparatoreCodice.Text.Replace("@@posizione@@", TextBox20.Text)
                    MyCEF.buttproghtml.BackColor = Color.Red
                    MyCEF.buttprogcss.BackColor = Color.DarkRed
                    MyCEF.AnteprimaWB.Visible = False
                    MyCEF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MyCEF.AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
                    MyCEF.CSSFTB.Visible = False
                    MyCEF.FastColoredTextBox1.Visible = True
                    MyCEF.DagliAppunti.Paste()
                    MyCEF.DaIncollare.Text = vbNewLine & Me.SeparatoreCodice.Text & vbNewLine
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
                    SeparatoreCodiceHTML.Text = SeparatoreCodiceHTML.Text.Replace("@@name@@", TextBox9.Text.Replace(" ", "-"))
                    SeparatoreCodiceCSS.Text = SeparatoreCodiceCSS.Text.Replace("@@name@@", TextBox9.Text.Replace(" ", "-"))
                    SeparatoreCodiceCSS.Text = SeparatoreCodiceCSS.Text.Replace("@@colore@@", SeparatoreTestoColore.Text)
                    SeparatoreCodiceCSS.Text = SeparatoreCodiceCSS.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    SeparatoreCodiceCSS.Text = SeparatoreCodiceCSS.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    SeparatoreCodiceCSS.Text = SeparatoreCodiceCSS.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    SeparatoreCodiceCSS.Text = SeparatoreCodiceCSS.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    SeparatoreCodiceCSS.Text = SeparatoreCodiceCSS.Text.Replace("@@lunghezza@@", TextBox1.Text & ComboBox1.Text)
                    SeparatoreCodiceCSS.Text = SeparatoreCodiceCSS.Text.Replace("@@spessore@@", TextBox15.Text & ComboBox5.Text)
                    SeparatoreCodiceCSS.Text = SeparatoreCodiceCSS.Text.Replace("@@posizione@@", TextBox20.Text)
                    MyCEF.buttproghtml.BackColor = Color.Red
                    MyCEF.buttprogcss.BackColor = Color.DarkRed
                    MyCEF.AnteprimaWB.Visible = False
                    MyCEF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MyCEF.AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
                    MyCEF.CSSFTB.Visible = False
                    MyCEF.FastColoredTextBox1.Visible = True
                    MyCEF.DagliAppunti.Paste()
                    MyCEF.DaIncollare.Text = vbNewLine & Me.SeparatoreCodiceHTML.Text & vbNewLine
                    MyCEF.DaIncollare.SelectAll()
                    MyCEF.DaIncollare.Copy()
                    MyCEF.FastColoredTextBox1.Paste()
                    MyCEF.DaIncollare.Text = ""
                    MyCEF.DagliAppunti.SelectAll()
                    My.Computer.Clipboard.Clear()
                    MyCEF.DagliAppunti.Copy()
                    MyCEF.FastColoredTextBox1.Select()
                    MyCEF.CSSFTB.Text = (MyCEF.CSSFTB.Text & SeparatoreCodiceCSS.Text)
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

    Private Sub ComboBox5_Click(sender As Object, e As EventArgs) Handles ComboBox5.Click
        ComboBox5.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox13_Click(sender As Object, e As EventArgs) Handles TextBox13.Click
        TextBox13.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub TextBox12_Click(sender As Object, e As EventArgs) Handles TextBox12.Click
        TextBox12.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub TextBox11_Click(sender As Object, e As EventArgs) Handles TextBox11.Click
        TextBox11.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        TextBox10.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Separatore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox5.Text = "px"
        ComboBox1.Text = "%"
        Dim i As New Integer
        i = 1
        If MyCEF.buttprogcss.Visible = True And MyCEF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Separatore" & i
                i += 1
            Loop While MyCEF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Separatore" & i
                i += 1
            Loop While MyCEF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MyCEF.CSSFTB.Text.Contains(TextBox9.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/Separatore/")
    End Sub

    Private Sub TextBox11_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox11.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
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
        TextBox15.SelectAll()
        TextBox15.Copy()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        TextBox15.SelectAll()
        TextBox15.Paste()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        TextBox1.SelectAll()
        TextBox1.Copy()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        TextBox1.SelectAll()
        TextBox1.Paste()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        TextBox13.SelectAll()
        TextBox13.Copy()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        TextBox13.SelectAll()
        TextBox13.Paste()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        TextBox11.SelectAll()
        TextBox11.Copy()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        TextBox11.SelectAll()
        TextBox11.Paste()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        TextBox10.SelectAll()
        TextBox10.Copy()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        TextBox10.SelectAll()
        TextBox10.Paste()
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        If TextBox13.Text = "" Then TextBox13.Text = "0"
        TextBox13.Text += 1
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        If TextBox13.Text = "" Then TextBox13.Text = "0"
        TextBox13.Text -= 1
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox11.Text = "" Then TextBox11.Text = "0"
        TextBox11.Text -= 1
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox11.Text = "" Then TextBox11.Text = "0"
        TextBox11.Text += 1
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox12.Text = "" Then TextBox12.Text = "0"
        TextBox12.Text -= 1
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox12.Text = "" Then TextBox12.Text = "0"
        TextBox12.Text += 1
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox10.Text = "" Then TextBox10.Text = "0"
        TextBox10.Text -= 1
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox10.Text = "" Then TextBox10.Text = "0"
        TextBox10.Text += 1
    End Sub
End Class