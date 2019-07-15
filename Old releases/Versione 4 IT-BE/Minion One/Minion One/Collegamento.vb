Public Class Collegamento

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        Colori.Dove.Text = ("TestoColoreCollegamento")
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
        If CollegamentoColore.Text = "" Then
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
        If CollegamentoTestoCarattere.Text = "" Then
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
                    MinionOneF.buttprogling.BackColor = Color.Red
                    MinionOneF.buttprogcss.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaWB.Visible = False
                    MinionOneF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaButtonR.BackColor = Color.DimGray
                    MinionOneF.CSSFTB.Visible = False
                    MinionOneF.FastColoredTextBox1.Visible = True
                    MinionOneF.DagliAppunti.Paste()
                    MinionOneF.DaIncollare.Text = vbNewLine & Me.CollegamentoCodice.Text & vbNewLine
                    MinionOneF.DaIncollare.SelectAll()
                    MinionOneF.DaIncollare.Copy()
                    MinionOneF.FastColoredTextBox1.Paste()
                    MinionOneF.DaIncollare.Text = ""
                    MinionOneF.DagliAppunti.SelectAll()
                    MinionOneF.DagliAppunti.Copy()
                    MinionOneF.FastColoredTextBox1.Select()
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
                    MinionOneF.buttprogling.BackColor = Color.Red
                    MinionOneF.buttprogcss.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaWB.Visible = False
                    MinionOneF.ProgettazioneButtonR.BackColor = Color.DarkRed
                    MinionOneF.AnteprimaButtonR.BackColor = Color.DimGray
                    MinionOneF.CSSFTB.Visible = False
                    MinionOneF.FastColoredTextBox1.Visible = True
                    MinionOneF.DagliAppunti.Paste()
                    MinionOneF.DaIncollare.Text = vbNewLine & Me.CollegamentoCodiceHTML.Text & vbNewLine
                    MinionOneF.DaIncollare.SelectAll()
                    MinionOneF.DaIncollare.Copy()
                    MinionOneF.FastColoredTextBox1.Paste()
                    MinionOneF.DaIncollare.Text = ""
                    MinionOneF.DagliAppunti.SelectAll()
                    MinionOneF.DagliAppunti.Copy()
                    MinionOneF.FastColoredTextBox1.Select()
                    MinionOneF.CSSFTB.Text = (MinionOneF.CSSFTB.Text & CollegamentoCodiceCSS.Text)
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
            TextBox23.Text = ("underline")
            Button19.BackColor = Color.White
            Button20.BackColor = Color.Silver
        ElseIf Button19.BackColor = Color.Silver Then
            TextBox23.Text = ("none")
            Button20.BackColor = Color.White
            Button19.BackColor = Color.White
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
        Dim i As New Integer
        i = 1
        If MinionOneF.buttprogcss.Visible = True And MinionOneF.buttprogcss.BackColor = Color.Red Then
            Do
                TextBox9.Text = "Collegamento" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text)
        Else
            Do
                TextBox9.Text = "Collegamento" & i
                i += 1
            Loop While MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Or MinionOneF.CSSFTB.Text.Contains(TextBox9.Text)
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
End Class