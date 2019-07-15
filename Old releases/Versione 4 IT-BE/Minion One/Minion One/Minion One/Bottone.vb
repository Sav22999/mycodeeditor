Public Class Bottone

    Private Sub Bottone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
        ComboBox1.Text = ("px")
        ComboBox2.Text = ("px")
        ComboBox5.Text = ("px")
        Dim i As New Integer
        i = 1
        If MinionOneF.buttprogcss.Visible = True And MinionOneF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Bottone" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Bottone" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MinionOneF.CSSFTB.Text.Contains(TextBox9.Text)
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click

    End Sub

    Private Sub TextBox6_Click(sender As Object, e As EventArgs) Handles TextBox6.Click
        TextBox6.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox4.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub BordiCheck_CheckedChanged(sender As Object, e As EventArgs) Handles BordiCheck.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If TextBox3.Enabled = False Then
            BordiCheck.CheckState = CheckState.Checked
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox14.Enabled = True
            Button40.Enabled = True
            Button52.Enabled = True
        Else
            BordiCheck.CheckState = CheckState.Unchecked
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox14.Enabled = False
            Button40.Enabled = False
            Button52.Enabled = False
        End If
    End Sub

    Private Sub AnteprimaButtonR_Click(sender As Object, e As EventArgs) Handles Button90.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
            Button90.BackColor = Color.Gray
        Else
            Panel2.Visible = False
            Button90.BackColor = Panel1.BackColor
        End If
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If TextBox17.Enabled = True Then
            AltreOpzioniCheck.CheckState = CheckState.Unchecked
            TextBox17.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
            Button56.Enabled = False
            Button57.Enabled = False

            Button24.BackColor = Color.WhiteSmoke
            Button23.BackColor = Color.WhiteSmoke
            Button22.BackColor = Color.WhiteSmoke
            TextBox20.Text = ("none")
            If TextBox11.Text = ("auto") Then
                TextBox11.Text = ("0")
                Button5.Text = ("px")
            End If
            TextBox11.Enabled = True
            If TextBox13.Text = ("auto") Then
                TextBox13.Text = ("0")
                Button6.Text = ("px")
            End If
            TextBox13.Enabled = True
        Else
            AltreOpzioniCheck.CheckState = CheckState.Checked
            TextBox17.Enabled = True
            Button22.Enabled = True
            Button23.Enabled = True
            Button24.Enabled = True
            Button56.Enabled = True
            Button57.Enabled = True
        End If
    End Sub

    Private Sub AltreOpzioniCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AltreOpzioniCheck.CheckedChanged

    End Sub

    Private Sub AltreOpzioniCheck_Click(sender As Object, e As EventArgs) Handles AltreOpzioniCheck.Click
        If TextBox17.Enabled = True Then
            AltreOpzioniCheck.CheckState = CheckState.Unchecked
            TextBox17.Enabled = False
            Button22.Enabled = False
            Button23.Enabled = False
            Button24.Enabled = False
            Button56.Enabled = False
            Button57.Enabled = False

            Button24.BackColor = Color.WhiteSmoke
            Button23.BackColor = Color.WhiteSmoke
            Button22.BackColor = Color.WhiteSmoke
            TextBox20.Text = ("none")
            If TextBox11.Text = ("auto") Then
                TextBox11.Text = ("0")
                Button5.Text = ("px")
            End If
            TextBox11.Enabled = True
            If TextBox13.Text = ("auto") Then
                TextBox13.Text = ("0")
                Button6.Text = ("px")
            End If
            TextBox13.Enabled = True
        Else
            AltreOpzioniCheck.CheckState = CheckState.Checked
            TextBox17.Enabled = True
            Button22.Enabled = True
            Button23.Enabled = True
            Button24.Enabled = True
            Button56.Enabled = True
            Button57.Enabled = True
        End If
    End Sub

    Private Sub BordiCheck_Click(sender As Object, e As EventArgs) Handles BordiCheck.Click
        If TextBox3.Enabled = False Then
            BordiCheck.CheckState = CheckState.Checked
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox14.Enabled = True
            Button40.Enabled = True
            Button52.Enabled = True
        Else
            BordiCheck.CheckState = CheckState.Unchecked
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox14.Enabled = False
            Button40.Enabled = False
            Button52.Enabled = False
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

    Private Sub TextBox9_Click(sender As Object, e As EventArgs) Handles TextBox9.Click
        TextBox9.BackColor = Color.WhiteSmoke
    End Sub
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If TextBox1.Text = "" Then
            TextBox1.BackColor = Color.Red
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
        If TextBox9.Text = "" Then
            TextBox9.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If BottoneSfondoColore.Text = "" Then
            Button90.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If TextBox16.Text = "" Then
            TextBox16.BackColor = Color.Red
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
        If BordiCheck.CheckState = CheckState.Checked Then
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
            If BottoneBordiColore.Text = "" Then
                Button40.BackColor = Color.Red
                TextBox24.Text = ("no")
            Else
                TextBox24.Text = ("si")
            End If
            If TextBox18.Text = "" Then
                Button52.BackColor = Color.Red
                TextBox24.Text = ("no")
            Else
                TextBox24.Text = ("si")
            End If
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
        If BottoneTestoColore.Text = "" Then
            Button43.BackColor = Color.Red
            TextBox24.Text = ("no")
        Else
            TextBox24.Text = ("si")
        End If
        If BottoneTestoCarattere.Text = "" Then
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
        If AltreOpzioniCheck.CheckState = CheckState.Checked Then
            If TextBox20.Text = "" Then
                Button24.BackColor = Color.Red
                Button23.BackColor = Color.Red
                Button22.BackColor = Color.Red
                TextBox24.Text = ("no")
            Else
                TextBox24.Text = ("si")
            End If
            If TextBox17.Text = "" Then
                TextBox17.BackColor = Color.Red
                TextBox24.Text = ("no")
            Else
                TextBox24.Text = ("si")
            End If
        End If
        If MinionOneF.FastColoredTextBox1.Text.Contains("id=" & Chr(34) & TextBox9.Text & Chr(34)) Then
            MessaggioF.Text = ("Nome già utilizzato.")
            MessaggioF.Button1.Text = ("Questo nome è stato già utilizzato nel progetto attualmente aperto." & vbNewLine & "Inseriscine un altro.")
            MessaggioF.ShowDialog()
        Else
            If TextBox24.Text = ("si") Then
                If MinionOneF.CSSSIoNOtb.Text = ("no") Then
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@name@@", TextBox9.Text.Replace(" ","-"))
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@testo da visualizzare@@", TextBox1.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@URL di destinazione@@", TextBox2.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@sfondo@@", BottoneSfondoColore.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@titolo@@", TextBox16.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@altezza bottone@@", TextBox7.Text + ComboBox1.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@larghezza bottone@@", TextBox8.Text + ComboBox2.Text)
                    TextBox25.Text = TextBox17.Text / 100
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@opacità bottone@@", TextBox25.Text.Replace(",", "."))
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@colore testo@@", BottoneTestoColore.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-family@@", BottoneTestoCarattere.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@text-align@@", TextBox19.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-style@@", TextBox22.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@font-weight@@", TextBox21.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@bordo sinistro@@", TextBox3.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@bordo destro@@", TextBox6.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@bordo superiore@@", TextBox4.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@bordo inferiore@@", TextBox5.Text & "px")
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@stile bordi@@", TextBox18.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@colore bordi@@", BottoneBordiColore.Text)
                    BottoneCodice.Text = BottoneCodice.Text.Replace("@@raccordo bordi@@", TextBox14.Text & "px")
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
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@URL di destinazione@@", TextBox2.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@sfondo@@", BottoneSfondoColore.Text)
                    BottoneCodiceHTML.Text = BottoneCodiceHTML.Text.Replace("@@titolo@@", TextBox16.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@altezza bottone@@", TextBox7.Text + ComboBox1.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@larghezza bottone@@", TextBox8.Text + ComboBox2.Text)
                    TextBox25.Text = TextBox17.Text / 100
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@opacità bottone@@", TextBox25.Text.Replace(",", "."))
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine sinistro@@", TextBox13.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine destro@@", TextBox11.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine superiore@@", TextBox12.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@margine inferiore@@", TextBox10.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@colore testo@@", BottoneTestoColore.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-family@@", BottoneTestoCarattere.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-size@@", TextBox15.Text + ComboBox5.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@text-align@@", TextBox19.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-style@@", TextBox22.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@text-decoration@@", TextBox23.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@font-weight@@", TextBox21.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@bordo sinistro@@", TextBox3.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@bordo destro@@", TextBox6.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@bordo superiore@@", TextBox4.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@bordo inferiore@@", TextBox5.Text & "px")
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@stile bordi@@", TextBox18.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@colore bordi@@", BottoneBordiColore.Text)
                    BottoneCodiceCSS.Text = BottoneCodiceCSS.Text.Replace("@@raccordo bordi@@", TextBox14.Text & "px")
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

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Carattere.Dove.Text = ("BottoneTesto")
        Button47.BackColor = Panel1.BackColor
        Carattere.ShowDialog()
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Stile.Dove.Text = ("BottoneBordi")
        Button52.BackColor = Panel1.BackColor
        Stile.ShowDialog()
    End Sub

    Private Sub TextBox16_Click(sender As Object, e As EventArgs) Handles TextBox16.Click
        TextBox16.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

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

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        ComboBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

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

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        ComboBox2.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress, TextBox6.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_Click(sender As Object, e As EventArgs) Handles TextBox5.Click
        TextBox5.BackColor = Color.WhiteSmoke
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

    Private Sub TextBox13_Click(sender As Object, e As EventArgs) Handles TextBox13.Click
        TextBox13.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox10_CausesValidationChanged(sender As Object, e As EventArgs) Handles TextBox10.CausesValidationChanged

    End Sub

    Private Sub TextBox10_Click(sender As Object, e As EventArgs) Handles TextBox10.Click
        TextBox10.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub TextBox12_Click(sender As Object, e As EventArgs) Handles TextBox12.Click
        TextBox12.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub TextBox11_Click(sender As Object, e As EventArgs) Handles TextBox11.Click
        TextBox11.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

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

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Button24.BackColor = Color.WhiteSmoke
        Button23.BackColor = Color.WhiteSmoke
        Button22.BackColor = Color.WhiteSmoke

        Button24.BackColor = Color.Silver
        TextBox20.Text = ("left")

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
        TextBox13.Text = ("auto")
        Button6.Text = ("0")
        TextBox13.Enabled = False
        If TextBox11.Text = ("auto") Then
            TextBox11.Text = ("0")
            Button5.Text = ("px")
        End If
        TextBox11.Enabled = True
    End Sub

    Private Sub TextBox17_Click(sender As Object, e As EventArgs) Handles TextBox17.Click
        TextBox17.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If TextBox7.Enabled = False Then
            AltezzaLarghezzaAutoCheck.CheckState = CheckState.Checked
            TextBox7.Enabled = True
            ComboBox1.Enabled = True
            TextBox8.Enabled = True
            ComboBox2.Enabled = True
            TextBox7.Text = ("0")
            TextBox8.Text = ("0")
            ComboBox1.Text = ("px")
            ComboBox2.Text = ("px")
            Button58.Enabled = True
            Button59.Enabled = True
            Button60.Enabled = True
            Button61.Enabled = True
        Else
            AltezzaLarghezzaAutoCheck.CheckState = CheckState.Unchecked
            TextBox7.Enabled = False
            ComboBox1.Enabled = False
            TextBox8.Enabled = False
            ComboBox2.Enabled = False
            TextBox7.Text = ("auto")
            TextBox8.Text = ("auto")
            ComboBox1.Text = ("")
            ComboBox2.Text = ("")
            Button58.Enabled = False
            Button59.Enabled = False
            Button60.Enabled = False
            Button61.Enabled = False
        End If
    End Sub

    Private Sub AltezzaLarghezzaAutoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AltezzaLarghezzaAutoCheck.CheckedChanged

    End Sub

    Private Sub AltezzaLarghezzaAutoCheck_Click(sender As Object, e As EventArgs) Handles AltezzaLarghezzaAutoCheck.Click
        If TextBox7.Enabled = False Then
            AltezzaLarghezzaAutoCheck.CheckState = CheckState.Checked
            TextBox7.Enabled = True
            ComboBox1.Enabled = True
            TextBox8.Enabled = True
            ComboBox2.Enabled = True
            TextBox7.Text = ("0")
            TextBox8.Text = ("0")
            ComboBox1.Text = ("px")
            ComboBox2.Text = ("px")
            Button58.Enabled = True
            Button59.Enabled = True
            Button60.Enabled = True
            Button61.Enabled = True
        Else
            AltezzaLarghezzaAutoCheck.CheckState = CheckState.Unchecked
            TextBox7.Enabled = False
            ComboBox1.Enabled = False
            TextBox8.Enabled = False
            ComboBox2.Enabled = False
            TextBox7.Text = ("auto")
            TextBox8.Text = ("auto")
            ComboBox1.Text = ("")
            ComboBox2.Text = ("")
            Button58.Enabled = False
            Button59.Enabled = False
            Button60.Enabled = False
            Button61.Enabled = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Colori.Dove.Text = ("SfondoBottone")
        Button90.BackColor = Panel1.BackColor
        Panel2.Visible = False
        Colori.ShowDialog()
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        Colori.Dove.Text = ("BordiColoreBottone")
        Button40.BackColor = Panel1.BackColor
        Panel21.Visible = False
        Colori.ShowDialog()
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        Colori.Dove.Text = ("TestoColoreBottone")
        Button43.BackColor = Panel1.BackColor
        Panel27.Visible = False
        Colori.ShowDialog()
    End Sub

    Private Sub PictureBox209_Click(sender As Object, e As EventArgs) Handles PictureBox209.Click
        Panel10.BackColor = PictureBox209.BackColor
        BottoneSfondoColore.Text = ("#000000")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox204_Click(sender As Object, e As EventArgs) Handles PictureBox204.Click
        Panel10.BackColor = PictureBox204.BackColor
        BottoneSfondoColore.Text = ("#0000FF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox119_Click(sender As Object, e As EventArgs) Handles PictureBox119.Click
        Panel10.BackColor = PictureBox119.BackColor
        BottoneSfondoColore.Text = ("#FF00FF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox124_Click(sender As Object, e As EventArgs) Handles PictureBox124.Click
        Panel10.BackColor = PictureBox124.BackColor
        BottoneSfondoColore.Text = ("#FF0000")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel10.BackColor = PictureBox1.BackColor
        BottoneSfondoColore.Text = ("#00FF00")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Panel10.BackColor = PictureBox9.BackColor
        BottoneSfondoColore.Text = ("#FFFF00")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        Panel10.BackColor = PictureBox21.BackColor
        BottoneSfondoColore.Text = ("#00FFFF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox80_Click(sender As Object, e As EventArgs) Handles PictureBox80.Click
        Panel10.BackColor = PictureBox80.BackColor
        BottoneSfondoColore.Text = ("#FFFFFF")
        Panel2.Visible = False
        Button90.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Panel15.BackColor = PictureBox6.BackColor
        BottoneBordiColore.Text = ("#000000")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Panel15.BackColor = PictureBox4.BackColor
        BottoneBordiColore.Text = ("#0000FF")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel15.BackColor = PictureBox3.BackColor
        BottoneBordiColore.Text = ("#FF00FF")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Panel15.BackColor = PictureBox5.BackColor
        BottoneBordiColore.Text = ("#FF0000")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Panel15.BackColor = PictureBox11.BackColor
        BottoneBordiColore.Text = ("#00FF00")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Panel15.BackColor = PictureBox10.BackColor
        BottoneBordiColore.Text = ("#FFFF00")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Panel15.BackColor = PictureBox8.BackColor
        BottoneBordiColore.Text = ("#00FFFF")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Panel15.BackColor = PictureBox6.BackColor
        BottoneBordiColore.Text = ("#FFFFFF")
        Panel21.Visible = False
        Button40.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        Panel17.BackColor = PictureBox15.BackColor
        BottoneTestoColore.Text = ("#000000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Panel17.BackColor = PictureBox13.BackColor
        BottoneTestoColore.Text = ("#0000FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Panel17.BackColor = PictureBox12.BackColor
        BottoneTestoColore.Text = ("#FF00FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Panel17.BackColor = PictureBox14.BackColor
        BottoneTestoColore.Text = ("#FF0000")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Panel17.BackColor = PictureBox19.BackColor
        BottoneTestoColore.Text = ("#00FF00")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Panel17.BackColor = PictureBox18.BackColor
        BottoneTestoColore.Text = ("#FF00FF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Panel17.BackColor = PictureBox17.BackColor
        BottoneTestoColore.Text = ("#00FFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        Panel17.BackColor = PictureBox16.BackColor
        BottoneTestoColore.Text = ("#FFFFFF")
        Panel27.Visible = False
        Button43.BackColor = Panel1.BackColor
    End Sub

    Private Sub Panel21_Paint(sender As Object, e As PaintEventArgs) Handles Panel21.Paint

    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        If TextBox15.Text = "" Then
            TextBox15.Text = ("0")
        End If
        TextBox15.Text += 1
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        If TextBox15.Text = "" Then
            TextBox15.Text = ("0")
        End If
        If TextBox15.Text = "" Or TextBox15.Text.Replace(" ", "") = "" Or TextBox15.Text = "1" Then
        Else
            TextBox15.Text -= 1
        End If
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        If TextBox7.Text = "" Then
            TextBox7.Text = ("0")
        End If
        TextBox7.Text += 1
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        If TextBox7.Text = "" Then
            TextBox7.Text = ("1")
        End If
        If TextBox7.Text = "" Or TextBox7.Text.Replace(" ", "") = "" Or TextBox7.Text = "1" Then
        Else
            TextBox7.Text -= 1
        End If
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        If TextBox8.Text = "" Then
            TextBox8.Text = ("0")
        End If
        TextBox8.Text += 1
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        If TextBox8.Text = "" Then
            TextBox8.Text = ("1")
        End If
        If TextBox8.Text = "" Or TextBox8.Text.Replace(" ", "") = "" Or TextBox8.Text = "1" Then
        Else
            TextBox8.Text -= 1
        End If
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        If TextBox17.Text = "" Then
            TextBox17.Text = ("0")
        End If
        TextBox17.Text += 1
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        If TextBox17.Text = "" Or TextBox17.Text.Replace(" ", "") = "" Or TextBox17.Text = "0" Then
        Else
            TextBox17.Text -= 1
        End If
    End Sub
End Class