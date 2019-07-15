Public Class Immagine


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = (OpenFileDialog1.FileName)
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
        Dim i As New Integer
        i = 1
        If MinionOneF.buttprogcss.Visible = True And MinionOneF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Immagine" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Immagine" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MinionOneF.CSSFTB.Text.Contains(TextBox9.Text)
        End If
    End Sub

    Private Sub IncollaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem1.Click
        TextBox1.ReadOnly = False
        TextBox1.SelectAll()
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
        If TextBox2.Text = "" Then
            TextBox2.BackColor = Color.Red
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
End Class