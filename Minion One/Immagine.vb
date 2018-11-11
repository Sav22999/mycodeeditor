Public Class Immagine


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = ("file:\\\" & OpenFileDialog1.FileName)
            PictureBox20.ImageLocation = (TextBox1.Text)
        End If

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        PictureBox20.ImageLocation = (TextBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Contenitore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "%"
        ComboBox2.Text = "%"
        Dim i As New Integer
        i = 1
        If MyCEF.buttprogcss.Visible = True And MyCEF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Immagine" & i
                i += 1
            Loop While MyCEF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Immagine" & i
                i += 1
            Loop While MyCEF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MyCEF.CSSFTB.Text.Contains(TextBox9.Text)
        End If
    End Sub

    Private Sub IncollaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem1.Click
        TextBox1.ReadOnly = False
        TextBox1.Select()
        TextBox1.Paste()
        PictureBox20.ImageLocation = (TextBox1.Text)
        TextBox1.ReadOnly = True
    End Sub

    Private Sub EliminaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminaToolStripMenuItem.Click
        TextBox1.SelectAll()
        TextBox1.Clear()
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

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs)
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        TextBox24.Text = "si"
        If TextBox1.Text = "" Then
            TextBox1.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox9.Text = "" Then
            TextBox9.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox7.Text = "" Then
            TextBox7.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If ComboBox1.Text = "" Then
            ComboBox1.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox8.Text = "" Then
            TextBox8.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If ComboBox2.Text = "" Then
            ComboBox2.BackColor = Color.Red
            TextBox24.Text = ("no")
        End If
        If TextBox20.Text = "" Then
            Button24.BackColor = Color.Red
            Button23.BackColor = Color.Red
            Button22.BackColor = Color.Red
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
        If TextBox2.Text = "" Then
            TextBox2.BackColor = Color.Red
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
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@url immagine@@", TextBox1.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@titolo@@", TextBox2.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@altezza@@", TextBox7.Text + ComboBox1.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@larghezza@@", TextBox8.Text + ComboBox2.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@text-align@@", TextBox20.Text)
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
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@url immagine@@", TextBox1.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@titolo@@", TextBox2.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@altezza@@", TextBox7.Text + ComboBox1.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@larghezza@@", TextBox8.Text + ComboBox2.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@text-align@@", TextBox20.Text)
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

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click

    End Sub

    Private Sub PictureBox20_LocationChanged(sender As Object, e As EventArgs) Handles PictureBox20.LocationChanged

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        If TextBox7.Text = "" Then
            TextBox7.Text = ("1")
        End If
        TextBox7.Text += 1
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        If TextBox7.Text = "" Then
            TextBox7.Text = ("1")
        End If
        If TextBox7.Text = "" Or TextBox7.Text.Replace(" ", "") = "" Or TextBox7.Text = "1" Then
        Else
            TextBox7.Text -= 1
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox8.Text = "" Then
            TextBox8.Text = ("1")
        End If
        TextBox8.Text += 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox8.Text = "" Then
            TextBox8.Text = ("1")
        End If
        If TextBox8.Text = "" Or TextBox8.Text.Replace(" ", "") = "" Or TextBox8.Text = "1" Then
        Else
            TextBox8.Text -= 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/Immagine/")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox9.Select()
        TextBox9.Copy()
    End Sub

    Private Sub IncollaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem.Click
        TextBox9.Select()
        TextBox9.Paste()
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
        TextBox7.SelectAll()
        TextBox7.Copy()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        TextBox7.SelectAll()
        TextBox7.Paste()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        TextBox8.SelectAll()
        TextBox8.Copy()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        TextBox8.SelectAll()
        TextBox8.Paste()
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
        TextBox12.SelectAll()
        TextBox12.Copy()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        TextBox12.SelectAll()
        TextBox12.Paste()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        TextBox10.SelectAll()
        TextBox10.Copy()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
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

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox11.Text = "" Then TextBox11.Text = "0"
        TextBox11.Text -= 1
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox11.Text = "" Then TextBox11.Text = "0"
        TextBox11.Text += 1
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox12.Text = "" Then TextBox12.Text = "0"
        TextBox12.Text -= 1
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox12.Text = "" Then TextBox12.Text = "0"
        TextBox12.Text += 1
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox10.Text = "" Then TextBox10.Text = "0"
        TextBox10.Text -= 1
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox10.Text = "" Then TextBox10.Text = "0"
        TextBox10.Text += 1
    End Sub
End Class