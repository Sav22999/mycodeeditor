Public Class Colori
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub Panel4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub Panel4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub Panel4_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        AnteprimaColore.BackColor = (PictureBox17.BackColor)
        CodiceHEX.Text = ("#00FF33")
    End Sub

    Private Sub Colori_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AnteprimaColore.BackColor = (PictureBox2.BackColor)
        CodiceHEX.Text = ("#00FF00")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        AnteprimaColore.BackColor = (PictureBox3.BackColor)
        CodiceHEX.Text = ("#33FF00")
    End Sub

    Private Sub PictureBox227_Click(sender As Object, e As EventArgs) Handles PictureBox227.Click
        AnteprimaColore.BackColor = (PictureBox227.BackColor)
        CodiceHEX.Text = ("#FFFFFF")
    End Sub

    Private Sub PictureBox226_Click(sender As Object, e As EventArgs) Handles PictureBox226.Click
        AnteprimaColore.BackColor = (PictureBox226.BackColor)
        CodiceHEX.Text = ("#DDDDDD")
    End Sub

    Private Sub PictureBox225_Click(sender As Object, e As EventArgs) Handles PictureBox225.Click
        AnteprimaColore.BackColor = (PictureBox225.BackColor)
        CodiceHEX.Text = ("#C0C0C0")
    End Sub

    Private Sub PictureBox224_Click(sender As Object, e As EventArgs) Handles PictureBox224.Click
        AnteprimaColore.BackColor = (PictureBox224.BackColor)
        CodiceHEX.Text = ("#969696")
    End Sub

    Private Sub PictureBox223_Click(sender As Object, e As EventArgs) Handles PictureBox223.Click
        AnteprimaColore.BackColor = (PictureBox223.BackColor)
        CodiceHEX.Text = ("#808080")
    End Sub

    Private Sub PictureBox222_Click(sender As Object, e As EventArgs) Handles PictureBox222.Click
        AnteprimaColore.BackColor = (PictureBox222.BackColor)
        CodiceHEX.Text = ("#646464")
    End Sub

    Private Sub PictureBox221_Click(sender As Object, e As EventArgs) Handles PictureBox221.Click
        AnteprimaColore.BackColor = (PictureBox221.BackColor)
        CodiceHEX.Text = ("#4B4B4B")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        AnteprimaColore.BackColor = (PictureBox11.BackColor)
        CodiceHEX.Text = ("#242424")
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        AnteprimaColore.BackColor = (PictureBox10.BackColor)
        CodiceHEX.Text = ("#000000")
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        AnteprimaColore.BackColor = (PictureBox18.BackColor)
        CodiceHEX.Text = ("#00FF66")
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        AnteprimaColore.BackColor = (PictureBox19.BackColor)
        CodiceHEX.Text = ("#00FF99")
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        AnteprimaColore.BackColor = (PictureBox20.BackColor)
        CodiceHEX.Text = ("#00FFCC")
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        AnteprimaColore.BackColor = (PictureBox21.BackColor)
        CodiceHEX.Text = ("#00FFFF")
    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs) Handles PictureBox50.Click
        AnteprimaColore.BackColor = (PictureBox50.BackColor)
        CodiceHEX.Text = ("#33FF33")
    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        AnteprimaColore.BackColor = (PictureBox49.BackColor)
        CodiceHEX.Text = ("#33FF66")
    End Sub

    Private Sub PictureBox48_Click(sender As Object, e As EventArgs) Handles PictureBox48.Click
        AnteprimaColore.BackColor = (PictureBox48.BackColor)
        CodiceHEX.Text = ("#33FF99")
    End Sub

    Private Sub PictureBox47_Click(sender As Object, e As EventArgs) Handles PictureBox47.Click
        AnteprimaColore.BackColor = (PictureBox47.BackColor)
        CodiceHEX.Text = ("#33FFCC")
    End Sub

    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        AnteprimaColore.BackColor = (PictureBox46.BackColor)
        CodiceHEX.Text = ("#33FFFF")
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If Dove.Text = ("SfondoBottone") Then
            Bottone.BottoneSfondoColore.Text = (CodiceHEX.Text)
            Bottone.Panel10.BackColor = (AnteprimaColore.BackColor)
            Bottone.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("BordiColoreBottone") Then
            Bottone.BottoneBordiColore.Text = (CodiceHEX.Text)
            Bottone.Panel15.BackColor = (AnteprimaColore.BackColor)
            Bottone.Panel21.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreBottone") Then
            Bottone.BottoneTestoColore.Text = (CodiceHEX.Text)
            Bottone.Panel17.BackColor = (AnteprimaColore.BackColor)
            Bottone.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreCollegamento") Then
            Collegamento.CollegamentoColore.Text = (CodiceHEX.Text)
            Collegamento.Panel10.BackColor = (AnteprimaColore.BackColor)
            Collegamento.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("ContenitoreColoreSfondo") Then
            Contenitore.ContenitoreSfondo.Text = (CodiceHEX.Text)
            Contenitore.Panel10.BackColor = (AnteprimaColore.BackColor)
            Contenitore.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("ColoreBordiContenitore") Then
            Contenitore.ContenitoreBordiColore.Text = (CodiceHEX.Text)
            Contenitore.Panel15.BackColor = (AnteprimaColore.BackColor)
            Contenitore.Panel21.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreDescrizione") Then
            Descrizione.DescrizioneColoreTesto.Text = (CodiceHEX.Text)
            Descrizione.Panel17.BackColor = (AnteprimaColore.BackColor)
            Descrizione.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreSottotitolo") Then
            Sottotitolo.SottotitoloColoreTesto.Text = (CodiceHEX.Text)
            Sottotitolo.Panel17.BackColor = (AnteprimaColore.BackColor)
            Sottotitolo.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreTitolo") Then
            Titolo.TitoloColoreTesto.Text = (CodiceHEX.Text)
            Titolo.Panel17.BackColor = (AnteprimaColore.BackColor)
            Titolo.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreParagrafo") Then
            Paragrafo.ParagrafoColoreTesto.Text = (CodiceHEX.Text)
            Paragrafo.Panel17.BackColor = (AnteprimaColore.BackColor)
            Paragrafo.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreElenco") Then
            Elenco.ElencoColoreTesto.Text = (CodiceHEX.Text)
            Elenco.Panel17.BackColor = (AnteprimaColore.BackColor)
            Elenco.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("SfondoTestoPersonalizzato") Then
            TestoPersonalizzato.TestoPersonalizzatoSfondoColore.Text = (CodiceHEX.Text)
            TestoPersonalizzato.Panel10.BackColor = (AnteprimaColore.BackColor)
            TestoPersonalizzato.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreTestoPersonalizzato") Then
            TestoPersonalizzato.TestoPersonalizzatoTestoColore.Text = (CodiceHEX.Text)
            TestoPersonalizzato.Panel17.BackColor = (AnteprimaColore.BackColor)
            TestoPersonalizzato.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreSeparatore") Then
            Separatore.SeparatoreTestoColore.Text = (CodiceHEX.Text)
            Separatore.Panel17.BackColor = (AnteprimaColore.BackColor)
            Separatore.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("SfondoTabella") Then
            Tabella.TabellaSfondoColore.Text = (CodiceHEX.Text)
            Tabella.Panel10.BackColor = (AnteprimaColore.BackColor)
            Tabella.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("BordiColoreTabella") Then
            Tabella.TabellaBordiColore.Text = (CodiceHEX.Text)
            Tabella.Panel15.BackColor = (AnteprimaColore.BackColor)
            Tabella.Panel21.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreTabella") Then
            Tabella.TabellaTestoColore.Text = (CodiceHEX.Text)
            Tabella.Panel17.BackColor = (AnteprimaColore.BackColor)
            Tabella.Panel27.Visible = False
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        AnteprimaColore.BackColor = (PictureBox4.BackColor)
        CodiceHEX.Text = ("#66FF00")
    End Sub

    Private Sub PictureBox67_Click(sender As Object, e As EventArgs) Handles PictureBox67.Click
        AnteprimaColore.BackColor = (PictureBox67.BackColor)
        CodiceHEX.Text = ("#66FF33")
    End Sub

    Private Sub PictureBox66_Click(sender As Object, e As EventArgs) Handles PictureBox66.Click
        AnteprimaColore.BackColor = (PictureBox66.BackColor)
        CodiceHEX.Text = ("#66FF66")
    End Sub

    Private Sub PictureBox65_Click(sender As Object, e As EventArgs) Handles PictureBox65.Click
        AnteprimaColore.BackColor = (PictureBox65.BackColor)
        CodiceHEX.Text = ("#66FF99")
    End Sub

    Private Sub PictureBox64_Click(sender As Object, e As EventArgs) Handles PictureBox64.Click
        AnteprimaColore.BackColor = (PictureBox64.BackColor)
        CodiceHEX.Text = ("#66FFCC")
    End Sub

    Private Sub PictureBox63_Click(sender As Object, e As EventArgs) Handles PictureBox63.Click
        AnteprimaColore.BackColor = (PictureBox63.BackColor)
        CodiceHEX.Text = ("#66FFFF")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        AnteprimaColore.BackColor = (PictureBox5.BackColor)
        CodiceHEX.Text = ("#99FF00")
    End Sub

    Private Sub PictureBox118_Click(sender As Object, e As EventArgs) Handles PictureBox118.Click
        AnteprimaColore.BackColor = (PictureBox118.BackColor)
        CodiceHEX.Text = ("#99FF33")
    End Sub

    Private Sub PictureBox117_Click(sender As Object, e As EventArgs) Handles PictureBox117.Click
        AnteprimaColore.BackColor = (PictureBox117.BackColor)
        CodiceHEX.Text = ("#99FF66")
    End Sub

    Private Sub PictureBox116_Click(sender As Object, e As EventArgs) Handles PictureBox116.Click
        AnteprimaColore.BackColor = (PictureBox116.BackColor)
        CodiceHEX.Text = ("#99FF99")
    End Sub

    Private Sub PictureBox115_Click(sender As Object, e As EventArgs) Handles PictureBox115.Click
        AnteprimaColore.BackColor = (PictureBox115.BackColor)
        CodiceHEX.Text = ("#99FFCC")
    End Sub

    Private Sub PictureBox114_Click(sender As Object, e As EventArgs) Handles PictureBox114.Click
        AnteprimaColore.BackColor = (PictureBox114.BackColor)
        CodiceHEX.Text = ("#99FFFF")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        AnteprimaColore.BackColor = (PictureBox6.BackColor)
        CodiceHEX.Text = ("#CCFF00")
    End Sub

    Private Sub PictureBox101_Click(sender As Object, e As EventArgs) Handles PictureBox101.Click
        AnteprimaColore.BackColor = (PictureBox101.BackColor)
        CodiceHEX.Text = ("#CCFF33")
    End Sub

    Private Sub PictureBox100_Click(sender As Object, e As EventArgs) Handles PictureBox100.Click
        AnteprimaColore.BackColor = (PictureBox100.BackColor)
        CodiceHEX.Text = ("#CCFF66")
    End Sub

    Private Sub PictureBox99_Click(sender As Object, e As EventArgs) Handles PictureBox99.Click
        AnteprimaColore.BackColor = (PictureBox99.BackColor)
        CodiceHEX.Text = ("#CCFF99")
    End Sub

    Private Sub PictureBox98_Click(sender As Object, e As EventArgs) Handles PictureBox98.Click
        AnteprimaColore.BackColor = (PictureBox98.BackColor)
        CodiceHEX.Text = ("#CCFFCC")
    End Sub

    Private Sub PictureBox97_Click(sender As Object, e As EventArgs) Handles PictureBox97.Click
        AnteprimaColore.BackColor = (PictureBox97.BackColor)
        CodiceHEX.Text = ("#CCFFFF")
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        AnteprimaColore.BackColor = (PictureBox9.BackColor)
        CodiceHEX.Text = ("#FFFF00")
    End Sub

    Private Sub PictureBox84_Click(sender As Object, e As EventArgs) Handles PictureBox84.Click
        AnteprimaColore.BackColor = (PictureBox84.BackColor)
        CodiceHEX.Text = ("#FFFF33")
    End Sub

    Private Sub PictureBox83_Click(sender As Object, e As EventArgs) Handles PictureBox83.Click
        AnteprimaColore.BackColor = (PictureBox83.BackColor)
        CodiceHEX.Text = ("#FFFF66")
    End Sub

    Private Sub PictureBox82_Click(sender As Object, e As EventArgs) Handles PictureBox82.Click
        AnteprimaColore.BackColor = (PictureBox82.BackColor)
        CodiceHEX.Text = ("#FFFF99")
    End Sub

    Private Sub PictureBox81_Click(sender As Object, e As EventArgs) Handles PictureBox81.Click
        AnteprimaColore.BackColor = (PictureBox81.BackColor)
        CodiceHEX.Text = ("#FFFFCC")
    End Sub

    Private Sub PictureBox80_Click(sender As Object, e As EventArgs) Handles PictureBox80.Click
        AnteprimaColore.BackColor = (PictureBox80.BackColor)
        CodiceHEX.Text = ("#FFFFFF")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        AnteprimaColore.BackColor = (PictureBox8.BackColor)
        CodiceHEX.Text = ("#00CC00")
    End Sub

    Private Sub PictureBox220_Click(sender As Object, e As EventArgs) Handles PictureBox220.Click
        AnteprimaColore.BackColor = (PictureBox220.BackColor)
        CodiceHEX.Text = ("#00CC33")
    End Sub

    Private Sub PictureBox219_Click(sender As Object, e As EventArgs) Handles PictureBox219.Click
        AnteprimaColore.BackColor = (PictureBox219.BackColor)
        CodiceHEX.Text = ("#00CC66")
    End Sub

    Private Sub PictureBox218_Click(sender As Object, e As EventArgs) Handles PictureBox218.Click
        AnteprimaColore.BackColor = (PictureBox218.BackColor)
        CodiceHEX.Text = ("#00CC99")
    End Sub

    Private Sub PictureBox217_Click(sender As Object, e As EventArgs) Handles PictureBox217.Click
        AnteprimaColore.BackColor = (PictureBox217.BackColor)
        CodiceHEX.Text = ("#00CCCC")
    End Sub

    Private Sub PictureBox216_Click(sender As Object, e As EventArgs) Handles PictureBox216.Click
        AnteprimaColore.BackColor = (PictureBox216.BackColor)
        CodiceHEX.Text = ("#00CCFF")
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        AnteprimaColore.BackColor = (PictureBox16.BackColor)
        CodiceHEX.Text = ("#33CC00")
    End Sub

    Private Sub PictureBox203_Click(sender As Object, e As EventArgs) Handles PictureBox203.Click
        AnteprimaColore.BackColor = (PictureBox203.BackColor)
        CodiceHEX.Text = ("#33CC33")
    End Sub

    Private Sub PictureBox202_Click(sender As Object, e As EventArgs) Handles PictureBox202.Click
        AnteprimaColore.BackColor = (PictureBox202.BackColor)
        CodiceHEX.Text = ("#33CC66")
    End Sub

    Private Sub PictureBox201_Click(sender As Object, e As EventArgs) Handles PictureBox201.Click
        AnteprimaColore.BackColor = (PictureBox201.BackColor)
        CodiceHEX.Text = ("#33CC99")
    End Sub

    Private Sub PictureBox200_Click(sender As Object, e As EventArgs) Handles PictureBox200.Click
        AnteprimaColore.BackColor = (PictureBox200.BackColor)
        CodiceHEX.Text = ("#33CCCC")
    End Sub

    Private Sub PictureBox199_Click(sender As Object, e As EventArgs) Handles PictureBox199.Click
        AnteprimaColore.BackColor = (PictureBox199.BackColor)
        CodiceHEX.Text = ("#33CCFF")
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        AnteprimaColore.BackColor = (PictureBox15.BackColor)
        CodiceHEX.Text = ("#66CC00")
    End Sub

    Private Sub PictureBox186_Click(sender As Object, e As EventArgs) Handles PictureBox186.Click
        AnteprimaColore.BackColor = (PictureBox186.BackColor)
        CodiceHEX.Text = ("#66CC33")
    End Sub

    Private Sub PictureBox185_Click(sender As Object, e As EventArgs) Handles PictureBox185.Click
        AnteprimaColore.BackColor = (PictureBox185.BackColor)
        CodiceHEX.Text = ("#66CC66")
    End Sub

    Private Sub PictureBox184_Click(sender As Object, e As EventArgs) Handles PictureBox184.Click
        AnteprimaColore.BackColor = (PictureBox184.BackColor)
        CodiceHEX.Text = ("#66CC99")
    End Sub

    Private Sub PictureBox183_Click(sender As Object, e As EventArgs) Handles PictureBox183.Click
        AnteprimaColore.BackColor = (PictureBox183.BackColor)
        CodiceHEX.Text = ("#66CCCC")
    End Sub

    Private Sub PictureBox182_Click(sender As Object, e As EventArgs) Handles PictureBox182.Click
        AnteprimaColore.BackColor = (PictureBox182.BackColor)
        CodiceHEX.Text = ("#66CCFF")
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        AnteprimaColore.BackColor = (PictureBox14.BackColor)
        CodiceHEX.Text = ("#99CC00")
    End Sub

    Private Sub PictureBox169_Click(sender As Object, e As EventArgs) Handles PictureBox169.Click
        AnteprimaColore.BackColor = (PictureBox169.BackColor)
        CodiceHEX.Text = ("#99CC33")
    End Sub

    Private Sub PictureBox168_Click(sender As Object, e As EventArgs) Handles PictureBox168.Click
        AnteprimaColore.BackColor = (PictureBox168.BackColor)
        CodiceHEX.Text = ("#99CC66")
    End Sub

    Private Sub PictureBox167_Click(sender As Object, e As EventArgs) Handles PictureBox167.Click
        AnteprimaColore.BackColor = (PictureBox167.BackColor)
        CodiceHEX.Text = ("#99CC99")
    End Sub

    Private Sub PictureBox166_Click(sender As Object, e As EventArgs) Handles PictureBox166.Click
        AnteprimaColore.BackColor = (PictureBox166.BackColor)
        CodiceHEX.Text = ("#99CCCC")
    End Sub

    Private Sub PictureBox165_Click(sender As Object, e As EventArgs) Handles PictureBox165.Click
        AnteprimaColore.BackColor = (PictureBox165.BackColor)
        CodiceHEX.Text = ("#99CCFF")
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        AnteprimaColore.BackColor = (PictureBox13.BackColor)
        CodiceHEX.Text = ("#CCCC00")
    End Sub

    Private Sub PictureBox152_Click(sender As Object, e As EventArgs) Handles PictureBox152.Click
        AnteprimaColore.BackColor = (PictureBox152.BackColor)
        CodiceHEX.Text = ("#CCCC33")
    End Sub

    Private Sub PictureBox151_Click(sender As Object, e As EventArgs) Handles PictureBox151.Click
        AnteprimaColore.BackColor = (PictureBox151.BackColor)
        CodiceHEX.Text = ("#CCCC66")
    End Sub

    Private Sub PictureBox150_Click(sender As Object, e As EventArgs) Handles PictureBox150.Click
        AnteprimaColore.BackColor = (PictureBox150.BackColor)
        CodiceHEX.Text = ("#CCCC99")
    End Sub

    Private Sub PictureBox149_Click(sender As Object, e As EventArgs) Handles PictureBox149.Click
        AnteprimaColore.BackColor = (PictureBox149.BackColor)
        CodiceHEX.Text = ("#CCCCCC")
    End Sub

    Private Sub PictureBox148_Click(sender As Object, e As EventArgs) Handles PictureBox148.Click
        AnteprimaColore.BackColor = (PictureBox148.BackColor)
        CodiceHEX.Text = ("#CCCCFF")
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        AnteprimaColore.BackColor = (PictureBox12.BackColor)
        CodiceHEX.Text = ("#FFCC00")
    End Sub

    Private Sub PictureBox135_Click(sender As Object, e As EventArgs) Handles PictureBox135.Click
        AnteprimaColore.BackColor = (PictureBox135.BackColor)
        CodiceHEX.Text = ("#FFCC33")
    End Sub

    Private Sub PictureBox134_Click(sender As Object, e As EventArgs) Handles PictureBox134.Click
        AnteprimaColore.BackColor = (PictureBox134.BackColor)
        CodiceHEX.Text = ("#FFCC66")
    End Sub

    Private Sub PictureBox133_Click(sender As Object, e As EventArgs) Handles PictureBox133.Click
        AnteprimaColore.BackColor = (PictureBox133.BackColor)
        CodiceHEX.Text = ("#FFCC99")
    End Sub

    Private Sub PictureBox132_Click(sender As Object, e As EventArgs) Handles PictureBox132.Click
        AnteprimaColore.BackColor = (PictureBox132.BackColor)
        CodiceHEX.Text = ("#FFCCCC")
    End Sub

    Private Sub PictureBox131_Click(sender As Object, e As EventArgs) Handles PictureBox131.Click
        AnteprimaColore.BackColor = (PictureBox131.BackColor)
        CodiceHEX.Text = ("#FFCCFF")
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        AnteprimaColore.BackColor = (PictureBox27.BackColor)
        CodiceHEX.Text = ("#009900")
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        AnteprimaColore.BackColor = (PictureBox26.BackColor)
        CodiceHEX.Text = ("#009933")
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        AnteprimaColore.BackColor = (PictureBox25.BackColor)
        CodiceHEX.Text = ("#009966")
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        AnteprimaColore.BackColor = (PictureBox24.BackColor)
        CodiceHEX.Text = ("#009999")
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        AnteprimaColore.BackColor = (PictureBox23.BackColor)
        CodiceHEX.Text = ("#0099CC")
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        AnteprimaColore.BackColor = (PictureBox22.BackColor)
        CodiceHEX.Text = ("#0099FF")
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        AnteprimaColore.BackColor = (PictureBox45.BackColor)
        CodiceHEX.Text = ("#339900")
    End Sub

    Private Sub PictureBox44_Click(sender As Object, e As EventArgs) Handles PictureBox44.Click
        AnteprimaColore.BackColor = (PictureBox44.BackColor)
        CodiceHEX.Text = ("#339933")
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        AnteprimaColore.BackColor = (PictureBox43.BackColor)
        CodiceHEX.Text = ("#339966")
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        AnteprimaColore.BackColor = (PictureBox42.BackColor)
        CodiceHEX.Text = ("#339999")
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        AnteprimaColore.BackColor = (PictureBox41.BackColor)
        CodiceHEX.Text = ("#3399CC")
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        AnteprimaColore.BackColor = (PictureBox40.BackColor)
        CodiceHEX.Text = ("#3399FF")
    End Sub

    Private Sub PictureBox62_Click(sender As Object, e As EventArgs) Handles PictureBox62.Click
        AnteprimaColore.BackColor = (PictureBox62.BackColor)
        CodiceHEX.Text = ("#669900")
    End Sub

    Private Sub PictureBox61_Click(sender As Object, e As EventArgs) Handles PictureBox61.Click
        AnteprimaColore.BackColor = (PictureBox61.BackColor)
        CodiceHEX.Text = ("#669933")
    End Sub

    Private Sub PictureBox60_Click(sender As Object, e As EventArgs) Handles PictureBox60.Click
        AnteprimaColore.BackColor = (PictureBox60.BackColor)
        CodiceHEX.Text = ("#669966")
    End Sub

    Private Sub PictureBox59_Click(sender As Object, e As EventArgs) Handles PictureBox59.Click
        AnteprimaColore.BackColor = (PictureBox59.BackColor)
        CodiceHEX.Text = ("#669999")
    End Sub

    Private Sub PictureBox58_Click(sender As Object, e As EventArgs) Handles PictureBox58.Click
        AnteprimaColore.BackColor = (PictureBox58.BackColor)
        CodiceHEX.Text = ("#6699CC")
    End Sub

    Private Sub PictureBox57_Click(sender As Object, e As EventArgs) Handles PictureBox57.Click
        AnteprimaColore.BackColor = (PictureBox57.BackColor)
        CodiceHEX.Text = ("#6699FF")
    End Sub

    Private Sub PictureBox113_Click(sender As Object, e As EventArgs) Handles PictureBox113.Click
        AnteprimaColore.BackColor = (PictureBox113.BackColor)
        CodiceHEX.Text = ("#999900")
    End Sub

    Private Sub PictureBox112_Click(sender As Object, e As EventArgs) Handles PictureBox112.Click
        AnteprimaColore.BackColor = (PictureBox112.BackColor)
        CodiceHEX.Text = ("#999933")
    End Sub

    Private Sub PictureBox111_Click(sender As Object, e As EventArgs) Handles PictureBox111.Click
        AnteprimaColore.BackColor = (PictureBox111.BackColor)
        CodiceHEX.Text = ("#999966")
    End Sub

    Private Sub PictureBox110_Click(sender As Object, e As EventArgs) Handles PictureBox110.Click
        AnteprimaColore.BackColor = (PictureBox110.BackColor)
        CodiceHEX.Text = ("#999999")
    End Sub

    Private Sub PictureBox109_Click(sender As Object, e As EventArgs) Handles PictureBox109.Click
        AnteprimaColore.BackColor = (PictureBox109.BackColor)
        CodiceHEX.Text = ("#9999CC")
    End Sub

    Private Sub PictureBox108_Click(sender As Object, e As EventArgs) Handles PictureBox108.Click
        AnteprimaColore.BackColor = (PictureBox108.BackColor)
        CodiceHEX.Text = ("#9999FF")
    End Sub

    Private Sub PictureBox96_Click(sender As Object, e As EventArgs) Handles PictureBox96.Click
        AnteprimaColore.BackColor = (PictureBox96.BackColor)
        CodiceHEX.Text = ("#CC9900")
    End Sub

    Private Sub PictureBox95_Click(sender As Object, e As EventArgs) Handles PictureBox95.Click
        AnteprimaColore.BackColor = (PictureBox95.BackColor)
        CodiceHEX.Text = ("#CC9933")
    End Sub

    Private Sub PictureBox94_Click(sender As Object, e As EventArgs) Handles PictureBox94.Click
        AnteprimaColore.BackColor = (PictureBox94.BackColor)
        CodiceHEX.Text = ("#CC9966")
    End Sub

    Private Sub PictureBox93_Click(sender As Object, e As EventArgs) Handles PictureBox93.Click
        AnteprimaColore.BackColor = (PictureBox93.BackColor)
        CodiceHEX.Text = ("#CC9999")
    End Sub

    Private Sub PictureBox92_Click(sender As Object, e As EventArgs) Handles PictureBox92.Click
        AnteprimaColore.BackColor = (PictureBox92.BackColor)
        CodiceHEX.Text = ("#CC99CC")
    End Sub

    Private Sub PictureBox91_Click(sender As Object, e As EventArgs) Handles PictureBox91.Click
        AnteprimaColore.BackColor = (PictureBox91.BackColor)
        CodiceHEX.Text = ("#CC99FF")
    End Sub

    Private Sub PictureBox79_Click(sender As Object, e As EventArgs) Handles PictureBox79.Click
        AnteprimaColore.BackColor = (PictureBox79.BackColor)
        CodiceHEX.Text = ("#FF9900")
    End Sub

    Private Sub PictureBox78_Click(sender As Object, e As EventArgs) Handles PictureBox78.Click
        AnteprimaColore.BackColor = (PictureBox78.BackColor)
        CodiceHEX.Text = ("#FF9933")
    End Sub

    Private Sub PictureBox77_Click(sender As Object, e As EventArgs) Handles PictureBox77.Click
        AnteprimaColore.BackColor = (PictureBox77.BackColor)
        CodiceHEX.Text = ("#FF9966")
    End Sub

    Private Sub PictureBox76_Click(sender As Object, e As EventArgs) Handles PictureBox76.Click
        AnteprimaColore.BackColor = (PictureBox76.BackColor)
        CodiceHEX.Text = ("#FF9999")
    End Sub

    Private Sub PictureBox75_Click(sender As Object, e As EventArgs) Handles PictureBox75.Click
        AnteprimaColore.BackColor = (PictureBox75.BackColor)
        CodiceHEX.Text = ("#FF99CC")
    End Sub

    Private Sub PictureBox74_Click(sender As Object, e As EventArgs) Handles PictureBox74.Click
        AnteprimaColore.BackColor = (PictureBox74.BackColor)
        CodiceHEX.Text = ("#FF99FF")
    End Sub

    Private Sub PictureBox215_Click(sender As Object, e As EventArgs) Handles PictureBox215.Click
        AnteprimaColore.BackColor = (PictureBox215.BackColor)
        CodiceHEX.Text = ("#006600")
    End Sub

    Private Sub PictureBox214_Click(sender As Object, e As EventArgs) Handles PictureBox214.Click
        AnteprimaColore.BackColor = (PictureBox214.BackColor)
        CodiceHEX.Text = ("#006633")
    End Sub

    Private Sub PictureBox213_Click(sender As Object, e As EventArgs) Handles PictureBox213.Click
        AnteprimaColore.BackColor = (PictureBox213.BackColor)
        CodiceHEX.Text = ("#006666")
    End Sub

    Private Sub PictureBox212_Click(sender As Object, e As EventArgs) Handles PictureBox212.Click
        AnteprimaColore.BackColor = (PictureBox212.BackColor)
        CodiceHEX.Text = ("#006699")
    End Sub

    Private Sub PictureBox211_Click(sender As Object, e As EventArgs) Handles PictureBox211.Click
        AnteprimaColore.BackColor = (PictureBox211.BackColor)
        CodiceHEX.Text = ("#0066CC")
    End Sub

    Private Sub PictureBox210_Click(sender As Object, e As EventArgs) Handles PictureBox210.Click
        AnteprimaColore.BackColor = (PictureBox210.BackColor)
        CodiceHEX.Text = ("#0066FF")
    End Sub

    Private Sub PictureBox198_Click(sender As Object, e As EventArgs) Handles PictureBox198.Click
        AnteprimaColore.BackColor = (PictureBox198.BackColor)
        CodiceHEX.Text = ("#336600")
    End Sub

    Private Sub PictureBox197_Click(sender As Object, e As EventArgs) Handles PictureBox197.Click
        AnteprimaColore.BackColor = (PictureBox197.BackColor)
        CodiceHEX.Text = ("#336633")
    End Sub

    Private Sub PictureBox196_Click(sender As Object, e As EventArgs) Handles PictureBox196.Click
        AnteprimaColore.BackColor = (PictureBox196.BackColor)
        CodiceHEX.Text = ("#336666")
    End Sub

    Private Sub PictureBox195_Click(sender As Object, e As EventArgs) Handles PictureBox195.Click
        AnteprimaColore.BackColor = (PictureBox195.BackColor)
        CodiceHEX.Text = ("#336699")
    End Sub

    Private Sub PictureBox194_Click(sender As Object, e As EventArgs) Handles PictureBox194.Click
        AnteprimaColore.BackColor = (PictureBox194.BackColor)
        CodiceHEX.Text = ("#3366CC")
    End Sub

    Private Sub PictureBox193_Click(sender As Object, e As EventArgs) Handles PictureBox193.Click
        AnteprimaColore.BackColor = (PictureBox193.BackColor)
        CodiceHEX.Text = ("#3366FF")
    End Sub

    Private Sub PictureBox181_Click(sender As Object, e As EventArgs) Handles PictureBox181.Click
        AnteprimaColore.BackColor = (PictureBox181.BackColor)
        CodiceHEX.Text = ("#666600")
    End Sub

    Private Sub PictureBox180_Click(sender As Object, e As EventArgs) Handles PictureBox180.Click
        AnteprimaColore.BackColor = (PictureBox180.BackColor)
        CodiceHEX.Text = ("#666633")
    End Sub

    Private Sub PictureBox179_Click(sender As Object, e As EventArgs) Handles PictureBox179.Click
        AnteprimaColore.BackColor = (PictureBox179.BackColor)
        CodiceHEX.Text = ("#666666")
    End Sub

    Private Sub PictureBox178_Click(sender As Object, e As EventArgs) Handles PictureBox178.Click
        AnteprimaColore.BackColor = (PictureBox178.BackColor)
        CodiceHEX.Text = ("#666699")
    End Sub

    Private Sub PictureBox177_Click(sender As Object, e As EventArgs) Handles PictureBox177.Click
        AnteprimaColore.BackColor = (PictureBox177.BackColor)
        CodiceHEX.Text = ("#6666CC")
    End Sub

    Private Sub PictureBox176_Click(sender As Object, e As EventArgs) Handles PictureBox176.Click
        AnteprimaColore.BackColor = (PictureBox176.BackColor)
        CodiceHEX.Text = ("#6666FF")
    End Sub

    Private Sub PictureBox164_Click(sender As Object, e As EventArgs) Handles PictureBox164.Click
        AnteprimaColore.BackColor = (PictureBox164.BackColor)
        CodiceHEX.Text = ("#996600")
    End Sub

    Private Sub PictureBox163_Click(sender As Object, e As EventArgs) Handles PictureBox163.Click
        AnteprimaColore.BackColor = (PictureBox163.BackColor)
        CodiceHEX.Text = ("#996633")
    End Sub

    Private Sub PictureBox162_Click(sender As Object, e As EventArgs) Handles PictureBox162.Click
        AnteprimaColore.BackColor = (PictureBox162.BackColor)
        CodiceHEX.Text = ("#996666")
    End Sub

    Private Sub PictureBox161_Click(sender As Object, e As EventArgs) Handles PictureBox161.Click
        AnteprimaColore.BackColor = (PictureBox161.BackColor)
        CodiceHEX.Text = ("#996699")
    End Sub

    Private Sub PictureBox160_Click(sender As Object, e As EventArgs) Handles PictureBox160.Click
        AnteprimaColore.BackColor = (PictureBox160.BackColor)
        CodiceHEX.Text = ("#9966CC")
    End Sub

    Private Sub PictureBox159_Click(sender As Object, e As EventArgs) Handles PictureBox159.Click
        AnteprimaColore.BackColor = (PictureBox159.BackColor)
        CodiceHEX.Text = ("#9966FF")
    End Sub

    Private Sub PictureBox147_Click(sender As Object, e As EventArgs) Handles PictureBox147.Click
        AnteprimaColore.BackColor = (PictureBox147.BackColor)
        CodiceHEX.Text = ("#CC6600")
    End Sub

    Private Sub PictureBox146_Click(sender As Object, e As EventArgs) Handles PictureBox146.Click
        AnteprimaColore.BackColor = (PictureBox146.BackColor)
        CodiceHEX.Text = ("#CC6633")
    End Sub

    Private Sub PictureBox145_Click(sender As Object, e As EventArgs) Handles PictureBox145.Click
        AnteprimaColore.BackColor = (PictureBox145.BackColor)
        CodiceHEX.Text = ("#CC6666")
    End Sub

    Private Sub PictureBox144_Click(sender As Object, e As EventArgs) Handles PictureBox144.Click
        AnteprimaColore.BackColor = (PictureBox144.BackColor)
        CodiceHEX.Text = ("#CC6699")
    End Sub

    Private Sub PictureBox143_Click(sender As Object, e As EventArgs) Handles PictureBox143.Click
        AnteprimaColore.BackColor = (PictureBox143.BackColor)
        CodiceHEX.Text = ("#CC66CC")
    End Sub

    Private Sub PictureBox142_Click(sender As Object, e As EventArgs) Handles PictureBox142.Click
        AnteprimaColore.BackColor = (PictureBox142.BackColor)
        CodiceHEX.Text = ("#CC66FF")
    End Sub

    Private Sub PictureBox130_Click(sender As Object, e As EventArgs) Handles PictureBox130.Click
        AnteprimaColore.BackColor = (PictureBox130.BackColor)
        CodiceHEX.Text = ("#FF6600")
    End Sub

    Private Sub PictureBox129_Click(sender As Object, e As EventArgs) Handles PictureBox129.Click
        AnteprimaColore.BackColor = (PictureBox129.BackColor)
        CodiceHEX.Text = ("#FF6633")
    End Sub

    Private Sub PictureBox128_Click(sender As Object, e As EventArgs) Handles PictureBox128.Click
        AnteprimaColore.BackColor = (PictureBox128.BackColor)
        CodiceHEX.Text = ("#FF6666")
    End Sub

    Private Sub PictureBox127_Click(sender As Object, e As EventArgs) Handles PictureBox127.Click
        AnteprimaColore.BackColor = (PictureBox127.BackColor)
        CodiceHEX.Text = ("#FF6699")
    End Sub

    Private Sub PictureBox126_Click(sender As Object, e As EventArgs) Handles PictureBox126.Click
        AnteprimaColore.BackColor = (PictureBox126.BackColor)
        CodiceHEX.Text = ("#FF66CC")
    End Sub

    Private Sub PictureBox125_Click(sender As Object, e As EventArgs) Handles PictureBox125.Click
        AnteprimaColore.BackColor = (PictureBox125.BackColor)
        CodiceHEX.Text = ("#FF66FF")
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        AnteprimaColore.BackColor = (PictureBox33.BackColor)
        CodiceHEX.Text = ("#003300")
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        AnteprimaColore.BackColor = (PictureBox32.BackColor)
        CodiceHEX.Text = ("#003333")
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        AnteprimaColore.BackColor = (PictureBox31.BackColor)
        CodiceHEX.Text = ("#003366")
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        AnteprimaColore.BackColor = (PictureBox30.BackColor)
        CodiceHEX.Text = ("#003399")
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        AnteprimaColore.BackColor = (PictureBox29.BackColor)
        CodiceHEX.Text = ("#0033CC")
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        AnteprimaColore.BackColor = (PictureBox28.BackColor)
        CodiceHEX.Text = ("#0033FF")
    End Sub

    Private Sub PictureBox39_Click(sender As Object, e As EventArgs) Handles PictureBox39.Click
        AnteprimaColore.BackColor = (PictureBox39.BackColor)
        CodiceHEX.Text = ("#333300")
    End Sub

    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        AnteprimaColore.BackColor = (PictureBox38.BackColor)
        CodiceHEX.Text = ("#333333")
    End Sub

    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        AnteprimaColore.BackColor = (PictureBox37.BackColor)
        CodiceHEX.Text = ("#333366")
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        AnteprimaColore.BackColor = (PictureBox36.BackColor)
        CodiceHEX.Text = ("#333399")
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        AnteprimaColore.BackColor = (PictureBox35.BackColor)
        CodiceHEX.Text = ("#3333CC")
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        AnteprimaColore.BackColor = (PictureBox34.BackColor)
        CodiceHEX.Text = ("#3333FF")
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        AnteprimaColore.BackColor = (PictureBox56.BackColor)
        CodiceHEX.Text = ("#663300")
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        AnteprimaColore.BackColor = (PictureBox55.BackColor)
        CodiceHEX.Text = ("#663333")
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        AnteprimaColore.BackColor = (PictureBox54.BackColor)
        CodiceHEX.Text = ("#663366")
    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        AnteprimaColore.BackColor = (PictureBox53.BackColor)
        CodiceHEX.Text = ("#663399")
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        AnteprimaColore.BackColor = (PictureBox52.BackColor)
        CodiceHEX.Text = ("#6633CC")
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        AnteprimaColore.BackColor = (PictureBox51.BackColor)
        CodiceHEX.Text = ("#6633FF")
    End Sub

    Private Sub PictureBox107_Click(sender As Object, e As EventArgs) Handles PictureBox107.Click
        AnteprimaColore.BackColor = (PictureBox107.BackColor)
        CodiceHEX.Text = ("#993300")
    End Sub

    Private Sub PictureBox106_Click(sender As Object, e As EventArgs) Handles PictureBox106.Click
        AnteprimaColore.BackColor = (PictureBox106.BackColor)
        CodiceHEX.Text = ("#993333")
    End Sub

    Private Sub PictureBox105_Click(sender As Object, e As EventArgs) Handles PictureBox105.Click
        AnteprimaColore.BackColor = (PictureBox105.BackColor)
        CodiceHEX.Text = ("#993366")
    End Sub

    Private Sub PictureBox104_Click(sender As Object, e As EventArgs) Handles PictureBox104.Click
        AnteprimaColore.BackColor = (PictureBox104.BackColor)
        CodiceHEX.Text = ("#993399")
    End Sub

    Private Sub PictureBox103_Click(sender As Object, e As EventArgs) Handles PictureBox103.Click
        AnteprimaColore.BackColor = (PictureBox103.BackColor)
        CodiceHEX.Text = ("#9933CC")
    End Sub

    Private Sub PictureBox102_Click(sender As Object, e As EventArgs) Handles PictureBox102.Click
        AnteprimaColore.BackColor = (PictureBox102.BackColor)
        CodiceHEX.Text = ("#9933FF")
    End Sub

    Private Sub PictureBox90_Click(sender As Object, e As EventArgs) Handles PictureBox90.Click
        AnteprimaColore.BackColor = (PictureBox90.BackColor)
        CodiceHEX.Text = ("#CC3300")
    End Sub

    Private Sub PictureBox89_Click(sender As Object, e As EventArgs) Handles PictureBox89.Click
        AnteprimaColore.BackColor = (PictureBox89.BackColor)
        CodiceHEX.Text = ("#CC3333")
    End Sub

    Private Sub PictureBox88_Click(sender As Object, e As EventArgs) Handles PictureBox88.Click
        AnteprimaColore.BackColor = (PictureBox88.BackColor)
        CodiceHEX.Text = ("#CC3366")
    End Sub

    Private Sub PictureBox87_Click(sender As Object, e As EventArgs) Handles PictureBox87.Click
        AnteprimaColore.BackColor = (PictureBox87.BackColor)
        CodiceHEX.Text = ("#CC3399")
    End Sub

    Private Sub PictureBox86_Click(sender As Object, e As EventArgs) Handles PictureBox86.Click
        AnteprimaColore.BackColor = (PictureBox86.BackColor)
        CodiceHEX.Text = ("#CC33CC")
    End Sub

    Private Sub PictureBox85_Click(sender As Object, e As EventArgs) Handles PictureBox85.Click
        AnteprimaColore.BackColor = (PictureBox85.BackColor)
        CodiceHEX.Text = ("#CC33FF")
    End Sub

    Private Sub PictureBox73_Click(sender As Object, e As EventArgs) Handles PictureBox73.Click
        AnteprimaColore.BackColor = (PictureBox73.BackColor)
        CodiceHEX.Text = ("#FF3300")
    End Sub

    Private Sub PictureBox72_Click(sender As Object, e As EventArgs) Handles PictureBox72.Click
        AnteprimaColore.BackColor = (PictureBox72.BackColor)
        CodiceHEX.Text = ("#FF3333")
    End Sub

    Private Sub PictureBox71_Click(sender As Object, e As EventArgs) Handles PictureBox71.Click
        AnteprimaColore.BackColor = (PictureBox71.BackColor)
        CodiceHEX.Text = ("#FF3366")
    End Sub

    Private Sub PictureBox70_Click(sender As Object, e As EventArgs) Handles PictureBox70.Click
        AnteprimaColore.BackColor = (PictureBox70.BackColor)
        CodiceHEX.Text = ("#FF3399")
    End Sub

    Private Sub PictureBox69_Click(sender As Object, e As EventArgs) Handles PictureBox69.Click
        AnteprimaColore.BackColor = (PictureBox69.BackColor)
        CodiceHEX.Text = ("#FF33CC")
    End Sub

    Private Sub PictureBox68_Click(sender As Object, e As EventArgs) Handles PictureBox68.Click
        AnteprimaColore.BackColor = (PictureBox68.BackColor)
        CodiceHEX.Text = ("#FF33FF")
    End Sub

    Private Sub PictureBox209_Click(sender As Object, e As EventArgs) Handles PictureBox209.Click
        AnteprimaColore.BackColor = (PictureBox209.BackColor)
        CodiceHEX.Text = ("#000000")
    End Sub

    Private Sub PictureBox208_Click(sender As Object, e As EventArgs) Handles PictureBox208.Click
        AnteprimaColore.BackColor = (PictureBox208.BackColor)
        CodiceHEX.Text = ("#000033")
    End Sub

    Private Sub PictureBox207_Click(sender As Object, e As EventArgs) Handles PictureBox207.Click
        AnteprimaColore.BackColor = (PictureBox207.BackColor)
        CodiceHEX.Text = ("#000066")
    End Sub

    Private Sub PictureBox206_Click(sender As Object, e As EventArgs) Handles PictureBox206.Click
        AnteprimaColore.BackColor = (PictureBox206.BackColor)
        CodiceHEX.Text = ("#000099")
    End Sub

    Private Sub PictureBox205_Click(sender As Object, e As EventArgs) Handles PictureBox205.Click
        AnteprimaColore.BackColor = (PictureBox205.BackColor)
        CodiceHEX.Text = ("#0000CC")
    End Sub

    Private Sub PictureBox204_Click(sender As Object, e As EventArgs) Handles PictureBox204.Click
        AnteprimaColore.BackColor = (PictureBox204.BackColor)
        CodiceHEX.Text = ("#0000FF")
    End Sub

    Private Sub PictureBox192_Click(sender As Object, e As EventArgs) Handles PictureBox192.Click
        AnteprimaColore.BackColor = (PictureBox192.BackColor)
        CodiceHEX.Text = ("#330000")
    End Sub

    Private Sub PictureBox191_Click(sender As Object, e As EventArgs) Handles PictureBox191.Click
        AnteprimaColore.BackColor = (PictureBox191.BackColor)
        CodiceHEX.Text = ("#330033")
    End Sub

    Private Sub PictureBox190_Click(sender As Object, e As EventArgs) Handles PictureBox190.Click
        AnteprimaColore.BackColor = (PictureBox190.BackColor)
        CodiceHEX.Text = ("#330066")
    End Sub

    Private Sub PictureBox189_Click(sender As Object, e As EventArgs) Handles PictureBox189.Click
        AnteprimaColore.BackColor = (PictureBox189.BackColor)
        CodiceHEX.Text = ("#330099")
    End Sub

    Private Sub PictureBox188_Click(sender As Object, e As EventArgs) Handles PictureBox188.Click
        AnteprimaColore.BackColor = (PictureBox188.BackColor)
        CodiceHEX.Text = ("#3300CC")
    End Sub

    Private Sub PictureBox187_Click(sender As Object, e As EventArgs) Handles PictureBox187.Click
        AnteprimaColore.BackColor = (PictureBox187.BackColor)
        CodiceHEX.Text = ("#3300FF")
    End Sub

    Private Sub PictureBox175_Click(sender As Object, e As EventArgs) Handles PictureBox175.Click
        AnteprimaColore.BackColor = (PictureBox175.BackColor)
        CodiceHEX.Text = ("#660000")
    End Sub

    Private Sub PictureBox174_Click(sender As Object, e As EventArgs) Handles PictureBox174.Click
        AnteprimaColore.BackColor = (PictureBox174.BackColor)
        CodiceHEX.Text = ("#660033")
    End Sub

    Private Sub PictureBox173_Click(sender As Object, e As EventArgs) Handles PictureBox173.Click
        AnteprimaColore.BackColor = (PictureBox173.BackColor)
        CodiceHEX.Text = ("#660066")
    End Sub

    Private Sub PictureBox172_Click(sender As Object, e As EventArgs) Handles PictureBox172.Click
        AnteprimaColore.BackColor = (PictureBox172.BackColor)
        CodiceHEX.Text = ("#660099")
    End Sub

    Private Sub PictureBox171_Click(sender As Object, e As EventArgs) Handles PictureBox171.Click
        AnteprimaColore.BackColor = (PictureBox171.BackColor)
        CodiceHEX.Text = ("#6600CC")
    End Sub

    Private Sub PictureBox170_Click(sender As Object, e As EventArgs) Handles PictureBox170.Click
        AnteprimaColore.BackColor = (PictureBox170.BackColor)
        CodiceHEX.Text = ("#6600FF")
    End Sub

    Private Sub PictureBox158_Click(sender As Object, e As EventArgs) Handles PictureBox158.Click
        AnteprimaColore.BackColor = (PictureBox158.BackColor)
        CodiceHEX.Text = ("#990000")
    End Sub

    Private Sub PictureBox157_Click(sender As Object, e As EventArgs) Handles PictureBox157.Click
        AnteprimaColore.BackColor = (PictureBox157.BackColor)
        CodiceHEX.Text = ("#990033")
    End Sub

    Private Sub PictureBox156_Click(sender As Object, e As EventArgs) Handles PictureBox156.Click
        AnteprimaColore.BackColor = (PictureBox156.BackColor)
        CodiceHEX.Text = ("#990066")
    End Sub

    Private Sub PictureBox155_Click(sender As Object, e As EventArgs) Handles PictureBox155.Click
        AnteprimaColore.BackColor = (PictureBox155.BackColor)
        CodiceHEX.Text = ("#990099")
    End Sub

    Private Sub PictureBox154_Click(sender As Object, e As EventArgs) Handles PictureBox154.Click
        AnteprimaColore.BackColor = (PictureBox154.BackColor)
        CodiceHEX.Text = ("#9900CC")
    End Sub

    Private Sub PictureBox153_Click(sender As Object, e As EventArgs) Handles PictureBox153.Click
        AnteprimaColore.BackColor = (PictureBox153.BackColor)
        CodiceHEX.Text = ("#9900FF")
    End Sub

    Private Sub PictureBox141_Click(sender As Object, e As EventArgs) Handles PictureBox141.Click
        AnteprimaColore.BackColor = (PictureBox141.BackColor)
        CodiceHEX.Text = ("#CC0000")
    End Sub

    Private Sub PictureBox140_Click(sender As Object, e As EventArgs) Handles PictureBox140.Click
        AnteprimaColore.BackColor = (PictureBox140.BackColor)
        CodiceHEX.Text = ("#CC0033")
    End Sub

    Private Sub PictureBox139_Click(sender As Object, e As EventArgs) Handles PictureBox139.Click
        AnteprimaColore.BackColor = (PictureBox139.BackColor)
        CodiceHEX.Text = ("#CC0066")
    End Sub

    Private Sub PictureBox138_Click(sender As Object, e As EventArgs) Handles PictureBox138.Click
        AnteprimaColore.BackColor = (PictureBox138.BackColor)
        CodiceHEX.Text = ("#CC0099")
    End Sub

    Private Sub PictureBox137_Click(sender As Object, e As EventArgs) Handles PictureBox137.Click
        AnteprimaColore.BackColor = (PictureBox137.BackColor)
        CodiceHEX.Text = ("#CC00CC")
    End Sub

    Private Sub PictureBox136_Click(sender As Object, e As EventArgs) Handles PictureBox136.Click
        AnteprimaColore.BackColor = (PictureBox136.BackColor)
        CodiceHEX.Text = ("#CC00FF")
    End Sub

    Private Sub PictureBox124_Click(sender As Object, e As EventArgs) Handles PictureBox124.Click
        AnteprimaColore.BackColor = (PictureBox124.BackColor)
        CodiceHEX.Text = ("#FF0000")
    End Sub

    Private Sub PictureBox123_Click(sender As Object, e As EventArgs) Handles PictureBox123.Click
        AnteprimaColore.BackColor = (PictureBox123.BackColor)
        CodiceHEX.Text = ("#FF0033")
    End Sub

    Private Sub PictureBox122_Click(sender As Object, e As EventArgs) Handles PictureBox122.Click
        AnteprimaColore.BackColor = (PictureBox122.BackColor)
        CodiceHEX.Text = ("#FF0066")
    End Sub

    Private Sub PictureBox121_Click(sender As Object, e As EventArgs) Handles PictureBox121.Click
        AnteprimaColore.BackColor = (PictureBox121.BackColor)
        CodiceHEX.Text = ("#FF0099")
    End Sub

    Private Sub PictureBox120_Click(sender As Object, e As EventArgs) Handles PictureBox120.Click
        AnteprimaColore.BackColor = (PictureBox120.BackColor)
        CodiceHEX.Text = ("#FF00CC")
    End Sub

    Private Sub PictureBox119_Click(sender As Object, e As EventArgs) Handles PictureBox119.Click
        AnteprimaColore.BackColor = (PictureBox119.BackColor)
        CodiceHEX.Text = ("#FF00FF")
    End Sub

    Private Sub CodiceHEX_TextChanged(sender As Object, e As EventArgs) Handles CodiceHEX.TextChanged

    End Sub

    Private Sub Dove_TextChanged(sender As Object, e As EventArgs) Handles Dove.TextChanged

    End Sub

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick, PictureBox3.DoubleClick, PictureBox4.DoubleClick, PictureBox5.DoubleClick, PictureBox6.DoubleClick, PictureBox8.DoubleClick, PictureBox9.DoubleClick, PictureBox10.DoubleClick, PictureBox11.DoubleClick, PictureBox12.DoubleClick, PictureBox13.DoubleClick, PictureBox14.DoubleClick, PictureBox15.DoubleClick, PictureBox16.DoubleClick, PictureBox17.DoubleClick, PictureBox18.DoubleClick, PictureBox19.DoubleClick, PictureBox20.DoubleClick, PictureBox21.DoubleClick, PictureBox22.DoubleClick, PictureBox23.DoubleClick, PictureBox24.DoubleClick, PictureBox25.DoubleClick, PictureBox26.DoubleClick, PictureBox27.DoubleClick, PictureBox28.DoubleClick, PictureBox29.DoubleClick, PictureBox30.DoubleClick, PictureBox31.DoubleClick, PictureBox32.DoubleClick, PictureBox33.DoubleClick, PictureBox34.DoubleClick, PictureBox35.DoubleClick, PictureBox36.DoubleClick, PictureBox37.DoubleClick, PictureBox38.DoubleClick, PictureBox39.DoubleClick, PictureBox40.DoubleClick, PictureBox41.DoubleClick, PictureBox42.DoubleClick, PictureBox43.DoubleClick, PictureBox44.DoubleClick, PictureBox45.DoubleClick, PictureBox46.DoubleClick, PictureBox47.DoubleClick, PictureBox48.DoubleClick, PictureBox49.DoubleClick, PictureBox50.DoubleClick, PictureBox51.DoubleClick, PictureBox52.DoubleClick, PictureBox53.DoubleClick, PictureBox54.DoubleClick, PictureBox55.DoubleClick, PictureBox56.DoubleClick, PictureBox57.DoubleClick, PictureBox58.DoubleClick, PictureBox59.DoubleClick, PictureBox60.DoubleClick, PictureBox61.DoubleClick, PictureBox62.DoubleClick, PictureBox63.DoubleClick, PictureBox64.DoubleClick, PictureBox65.DoubleClick, PictureBox66.DoubleClick, PictureBox67.DoubleClick, PictureBox68.DoubleClick, PictureBox69.DoubleClick, PictureBox70.DoubleClick, PictureBox71.DoubleClick, PictureBox72.DoubleClick, PictureBox73.DoubleClick, PictureBox74.DoubleClick, PictureBox75.DoubleClick, PictureBox76.DoubleClick, PictureBox77.DoubleClick, PictureBox78.DoubleClick, PictureBox79.DoubleClick, PictureBox80.DoubleClick, PictureBox81.DoubleClick, PictureBox82.DoubleClick, PictureBox83.DoubleClick, PictureBox84.DoubleClick, PictureBox85.DoubleClick, PictureBox86.DoubleClick, PictureBox87.DoubleClick, PictureBox88.DoubleClick, PictureBox89.DoubleClick, PictureBox90.DoubleClick, PictureBox91.DoubleClick, PictureBox92.DoubleClick, PictureBox93.DoubleClick, PictureBox94.DoubleClick, PictureBox95.DoubleClick, PictureBox96.DoubleClick, PictureBox97.DoubleClick, PictureBox98.DoubleClick, PictureBox99.DoubleClick, PictureBox100.DoubleClick, PictureBox101.DoubleClick, PictureBox102.DoubleClick, PictureBox103.DoubleClick, PictureBox104.DoubleClick, PictureBox105.DoubleClick, PictureBox106.DoubleClick, PictureBox107.DoubleClick, PictureBox108.DoubleClick, PictureBox109.DoubleClick, PictureBox110.DoubleClick, PictureBox111.DoubleClick, PictureBox112.DoubleClick, PictureBox113.DoubleClick, PictureBox114.DoubleClick, PictureBox115.DoubleClick, PictureBox116.DoubleClick, PictureBox117.DoubleClick, PictureBox118.DoubleClick, PictureBox119.DoubleClick, PictureBox120.DoubleClick, PictureBox121.DoubleClick, PictureBox122.DoubleClick, PictureBox123.DoubleClick, PictureBox124.DoubleClick, PictureBox125.DoubleClick, PictureBox126.DoubleClick, PictureBox127.DoubleClick, PictureBox128.DoubleClick, PictureBox129.DoubleClick, PictureBox130.DoubleClick, PictureBox131.DoubleClick, PictureBox132.DoubleClick, PictureBox133.DoubleClick, PictureBox134.DoubleClick, PictureBox135.DoubleClick, PictureBox136.DoubleClick, PictureBox137.DoubleClick, PictureBox138.DoubleClick, PictureBox139.DoubleClick, PictureBox140.DoubleClick, PictureBox141.DoubleClick, PictureBox142.DoubleClick, PictureBox143.DoubleClick, PictureBox144.DoubleClick, PictureBox145.DoubleClick, PictureBox146.DoubleClick, PictureBox147.DoubleClick, PictureBox148.DoubleClick, PictureBox149.DoubleClick, PictureBox150.DoubleClick, PictureBox151.DoubleClick, PictureBox152.DoubleClick, PictureBox153.DoubleClick, PictureBox154.DoubleClick, PictureBox155.DoubleClick, PictureBox156.DoubleClick, PictureBox157.DoubleClick, PictureBox158.DoubleClick, PictureBox159.DoubleClick, PictureBox160.DoubleClick, PictureBox161.DoubleClick, PictureBox162.DoubleClick, PictureBox163.DoubleClick, PictureBox164.DoubleClick, PictureBox165.DoubleClick, PictureBox166.DoubleClick, PictureBox167.DoubleClick, PictureBox168.DoubleClick, PictureBox169.DoubleClick, PictureBox170.DoubleClick, PictureBox171.DoubleClick, PictureBox172.DoubleClick, PictureBox173.DoubleClick, PictureBox174.DoubleClick, PictureBox175.DoubleClick, PictureBox176.DoubleClick, PictureBox177.DoubleClick, PictureBox178.DoubleClick, PictureBox179.DoubleClick, PictureBox180.DoubleClick, PictureBox181.DoubleClick, PictureBox182.DoubleClick, PictureBox183.DoubleClick, PictureBox184.DoubleClick, PictureBox185.DoubleClick, PictureBox186.DoubleClick, PictureBox187.DoubleClick, PictureBox188.DoubleClick, PictureBox189.DoubleClick, PictureBox190.DoubleClick, PictureBox191.DoubleClick, PictureBox192.DoubleClick, PictureBox193.DoubleClick, PictureBox194.DoubleClick, PictureBox195.DoubleClick, PictureBox196.DoubleClick, PictureBox197.DoubleClick, PictureBox198.DoubleClick, PictureBox199.DoubleClick, PictureBox200.DoubleClick, PictureBox201.DoubleClick, PictureBox202.DoubleClick, PictureBox203.DoubleClick, PictureBox204.DoubleClick, PictureBox205.DoubleClick, PictureBox206.DoubleClick, PictureBox207.DoubleClick, PictureBox208.DoubleClick, PictureBox209.DoubleClick, PictureBox210.DoubleClick, PictureBox211.DoubleClick, PictureBox212.DoubleClick, PictureBox213.DoubleClick, PictureBox214.DoubleClick, PictureBox215.DoubleClick, PictureBox216.DoubleClick, PictureBox217.DoubleClick, PictureBox218.DoubleClick, PictureBox219.DoubleClick, PictureBox220.DoubleClick, PictureBox221.DoubleClick, PictureBox222.DoubleClick, PictureBox223.DoubleClick, PictureBox224.DoubleClick, PictureBox225.DoubleClick, PictureBox226.DoubleClick, PictureBox227.DoubleClick
        If Dove.Text = ("SfondoBottone") Then
            Bottone.BottoneSfondoColore.Text = (CodiceHEX.Text)
            Bottone.Panel10.BackColor = (AnteprimaColore.BackColor)
            Bottone.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("BordiColoreBottone") Then
            Bottone.BottoneBordiColore.Text = (CodiceHEX.Text)
            Bottone.Panel15.BackColor = (AnteprimaColore.BackColor)
            Bottone.Panel21.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreBottone") Then
            Bottone.BottoneTestoColore.Text = (CodiceHEX.Text)
            Bottone.Panel17.BackColor = (AnteprimaColore.BackColor)
            Bottone.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreCollegamento") Then
            Collegamento.CollegamentoColore.Text = (CodiceHEX.Text)
            Collegamento.Panel10.BackColor = (AnteprimaColore.BackColor)
            Collegamento.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("ContenitoreColoreSfondo") Then
            Contenitore.ContenitoreSfondo.Text = (CodiceHEX.Text)
            Contenitore.Panel10.BackColor = (AnteprimaColore.BackColor)
            Contenitore.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("ColoreBordiContenitore") Then
            Contenitore.ContenitoreBordiColore.Text = (CodiceHEX.Text)
            Contenitore.Panel15.BackColor = (AnteprimaColore.BackColor)
            Contenitore.Panel21.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreDescrizione") Then
            Descrizione.DescrizioneColoreTesto.Text = (CodiceHEX.Text)
            Descrizione.Panel17.BackColor = (AnteprimaColore.BackColor)
            Descrizione.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreSottotitolo") Then
            Sottotitolo.SottotitoloColoreTesto.Text = (CodiceHEX.Text)
            Sottotitolo.Panel17.BackColor = (AnteprimaColore.BackColor)
            Sottotitolo.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreTitolo") Then
            Titolo.TitoloColoreTesto.Text = (CodiceHEX.Text)
            Titolo.Panel17.BackColor = (AnteprimaColore.BackColor)
            Titolo.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreParagrafo") Then
            Paragrafo.ParagrafoColoreTesto.Text = (CodiceHEX.Text)
            Paragrafo.Panel17.BackColor = (AnteprimaColore.BackColor)
            Paragrafo.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreElenco") Then
            Elenco.ElencoColoreTesto.Text = (CodiceHEX.Text)
            Elenco.Panel17.BackColor = (AnteprimaColore.BackColor)
            Elenco.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("SfondoTestoPersonalizzato") Then
            TestoPersonalizzato.TestoPersonalizzatoSfondoColore.Text = (CodiceHEX.Text)
            TestoPersonalizzato.Panel10.BackColor = (AnteprimaColore.BackColor)
            TestoPersonalizzato.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreTestoPersonalizzato") Then
            TestoPersonalizzato.TestoPersonalizzatoTestoColore.Text = (CodiceHEX.Text)
            TestoPersonalizzato.Panel17.BackColor = (AnteprimaColore.BackColor)
            TestoPersonalizzato.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreSeparatore") Then
            Separatore.SeparatoreTestoColore.Text = (CodiceHEX.Text)
            Separatore.Panel17.BackColor = (AnteprimaColore.BackColor)
            Separatore.Panel27.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("SfondoTabella") Then
            Tabella.TabellaSfondoColore.Text = (CodiceHEX.Text)
            Tabella.Panel10.BackColor = (AnteprimaColore.BackColor)
            Tabella.Panel2.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("BordiColoreTabella") Then
            Tabella.TabellaBordiColore.Text = (CodiceHEX.Text)
            Tabella.Panel15.BackColor = (AnteprimaColore.BackColor)
            Tabella.Panel21.Visible = False
            Me.Close()
        ElseIf Dove.Text = ("TestoColoreTabella") Then
            Tabella.TabellaTestoColore.Text = (CodiceHEX.Text)
            Tabella.Panel17.BackColor = (AnteprimaColore.BackColor)
            Tabella.Panel27.Visible = False
            Me.Close()
        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RossoTextBox.KeyPress, VerdeTextBox.KeyPress, BluTextBox.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RossoTextBox_LostFocus(sender As Object, e As EventArgs) Handles RossoTextBox.LostFocus
        If RossoTextBox.Text > 255 Then
            RossoTextBox.Text = "255"
        ElseIf RossoTextBox.Text < 0 Then
            RossoTextBox.Text = "0"
        End If
        CodiceRGB.Text = (Hex(RossoTextBox.Text) & Hex(VerdeTextBox.Text) & Hex(BluTextBox.Text))
        AnteprimaRGB.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & CodiceRGB.Text)
        CodiceRGB.Text = ("#" & Hex(RossoTextBox.Text) & Hex(VerdeTextBox.Text) & Hex(BluTextBox.Text))
        AnteprimaColore.BackColor = (AnteprimaRGB.BackColor)
        CodiceHEX.Text = (CodiceRGB.Text)
    End Sub

    Private Sub VerdeTextBox_LostFocus(sender As Object, e As EventArgs) Handles VerdeTextBox.LostFocus
        If VerdeTextBox.Text > 255 Then
            VerdeTextBox.Text = "255"
        ElseIf VerdeTextBox.Text < 0 Then
            VerdeTextBox.Text = "0"
        End If
        CodiceRGB.Text = (Hex(RossoTextBox.Text) & Hex(VerdeTextBox.Text) & Hex(BluTextBox.Text))
        AnteprimaRGB.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & CodiceRGB.Text)
        CodiceRGB.Text = ("#" & Hex(RossoTextBox.Text) & Hex(VerdeTextBox.Text) & Hex(BluTextBox.Text))
        AnteprimaColore.BackColor = (AnteprimaRGB.BackColor)
        CodiceHEX.Text = (CodiceRGB.Text)
    End Sub

    Private Sub BluTextBox_LostFocus(sender As Object, e As EventArgs) Handles BluTextBox.LostFocus
        If BluTextBox.Text > 255 Then
            BluTextBox.Text = "255"
        ElseIf BluTextBox.Text < 0 Then
            BluTextBox.Text = "0"
        End If
        CodiceRGB.Text = (Hex(RossoTextBox.Text) & Hex(VerdeTextBox.Text) & Hex(BluTextBox.Text))
        AnteprimaRGB.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & CodiceRGB.Text)
        CodiceRGB.Text = ("#" & Hex(RossoTextBox.Text) & Hex(VerdeTextBox.Text) & Hex(BluTextBox.Text))
        AnteprimaColore.BackColor = (AnteprimaRGB.BackColor)
        CodiceHEX.Text = (CodiceRGB.Text)
    End Sub

    Private Sub RossoTextBox_TextChanged(sender As Object, e As EventArgs) Handles RossoTextBox.TextChanged

    End Sub

    Private Sub HEXTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HEXTextBox.KeyPress
        If ((Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 70) Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 102) Or Asc(e.KeyChar) = 8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub HEXTextBox_LostFocus(sender As Object, e As EventArgs) Handles HEXTextBox.LostFocus
        AnteprimaHEX.BackColor = System.Drawing.ColorTranslator.FromOle("&h" & HEXTextBox.Text)
        AnteprimaColore.BackColor = (AnteprimaHEX.BackColor)
        CodiceHEX.Text = ("#" & CodiceHEX.Text)
    End Sub

    Private Sub HEXTextBox_TextChanged(sender As Object, e As EventArgs) Handles HEXTextBox.TextChanged

    End Sub
End Class
