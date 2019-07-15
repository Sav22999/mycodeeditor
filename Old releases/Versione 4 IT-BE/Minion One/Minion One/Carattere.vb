Public Class Carattere
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Font1.Click
        Font1.BackColor = Panel1.BackColor
        Font1.FlatAppearance.MouseDownBackColor = Color.Gray
        Font1.FlatAppearance.MouseOverBackColor = Color.Silver
        Font2.BackColor = Panel1.BackColor
        Font2.FlatAppearance.MouseDownBackColor = Color.Gray
        Font2.FlatAppearance.MouseOverBackColor = Color.Silver
        Font3.BackColor = Panel1.BackColor
        Font3.FlatAppearance.MouseDownBackColor = Color.Gray
        Font3.FlatAppearance.MouseOverBackColor = Color.Silver
        Font4.BackColor = Panel1.BackColor
        Font4.FlatAppearance.MouseDownBackColor = Color.Gray
        Font4.FlatAppearance.MouseOverBackColor = Color.Silver
        Font5.BackColor = Panel1.BackColor
        Font5.FlatAppearance.MouseDownBackColor = Color.Gray
        Font5.FlatAppearance.MouseOverBackColor = Color.Silver
        Font6.BackColor = Panel1.BackColor
        Font6.FlatAppearance.MouseDownBackColor = Color.Gray
        Font6.FlatAppearance.MouseOverBackColor = Color.Silver

        Font1.BackColor = Color.Gray
        Font1.FlatAppearance.MouseDownBackColor = Color.Gray
        Font1.FlatAppearance.MouseOverBackColor = Color.Gray

        CarattereTB.Text = ("monospace")
        Button53.Text = (CarattereTB.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Font2.Click
        Font1.BackColor = Panel1.BackColor
        Font1.FlatAppearance.MouseDownBackColor = Color.Gray
        Font1.FlatAppearance.MouseOverBackColor = Color.Silver
        Font2.BackColor = Panel1.BackColor
        Font2.FlatAppearance.MouseDownBackColor = Color.Gray
        Font2.FlatAppearance.MouseOverBackColor = Color.Silver
        Font3.BackColor = Panel1.BackColor
        Font3.FlatAppearance.MouseDownBackColor = Color.Gray
        Font3.FlatAppearance.MouseOverBackColor = Color.Silver
        Font4.BackColor = Panel1.BackColor
        Font4.FlatAppearance.MouseDownBackColor = Color.Gray
        Font4.FlatAppearance.MouseOverBackColor = Color.Silver
        Font5.BackColor = Panel1.BackColor
        Font5.FlatAppearance.MouseDownBackColor = Color.Gray
        Font5.FlatAppearance.MouseOverBackColor = Color.Silver
        Font6.BackColor = Panel1.BackColor
        Font6.FlatAppearance.MouseDownBackColor = Color.Gray
        Font6.FlatAppearance.MouseOverBackColor = Color.Silver

        Font2.BackColor = Color.Gray
        Font2.FlatAppearance.MouseDownBackColor = Color.Gray
        Font2.FlatAppearance.MouseOverBackColor = Color.Gray

        CarattereTB.Text = ("serif")
        Button53.Text = (CarattereTB.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Font3.Click
        Font1.BackColor = Panel1.BackColor
        Font1.FlatAppearance.MouseDownBackColor = Color.Gray
        Font1.FlatAppearance.MouseOverBackColor = Color.Silver
        Font2.BackColor = Panel1.BackColor
        Font2.FlatAppearance.MouseDownBackColor = Color.Gray
        Font2.FlatAppearance.MouseOverBackColor = Color.Silver
        Font3.BackColor = Panel1.BackColor
        Font3.FlatAppearance.MouseDownBackColor = Color.Gray
        Font3.FlatAppearance.MouseOverBackColor = Color.Silver
        Font4.BackColor = Panel1.BackColor
        Font4.FlatAppearance.MouseDownBackColor = Color.Gray
        Font4.FlatAppearance.MouseOverBackColor = Color.Silver
        Font5.BackColor = Panel1.BackColor
        Font5.FlatAppearance.MouseDownBackColor = Color.Gray
        Font5.FlatAppearance.MouseOverBackColor = Color.Silver
        Font6.BackColor = Panel1.BackColor
        Font6.FlatAppearance.MouseDownBackColor = Color.Gray
        Font6.FlatAppearance.MouseOverBackColor = Color.Silver

        Font3.BackColor = Color.Gray
        Font3.FlatAppearance.MouseDownBackColor = Color.Gray
        Font3.FlatAppearance.MouseOverBackColor = Color.Gray

        CarattereTB.Text = ("sans-serif")
        Button53.Text = (CarattereTB.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Font4.Click
        Font1.BackColor = Panel1.BackColor
        Font1.FlatAppearance.MouseDownBackColor = Color.Gray
        Font1.FlatAppearance.MouseOverBackColor = Color.Silver
        Font2.BackColor = Panel1.BackColor
        Font2.FlatAppearance.MouseDownBackColor = Color.Gray
        Font2.FlatAppearance.MouseOverBackColor = Color.Silver
        Font3.BackColor = Panel1.BackColor
        Font3.FlatAppearance.MouseDownBackColor = Color.Gray
        Font3.FlatAppearance.MouseOverBackColor = Color.Silver
        Font4.BackColor = Panel1.BackColor
        Font4.FlatAppearance.MouseDownBackColor = Color.Gray
        Font4.FlatAppearance.MouseOverBackColor = Color.Silver
        Font5.BackColor = Panel1.BackColor
        Font5.FlatAppearance.MouseDownBackColor = Color.Gray
        Font5.FlatAppearance.MouseOverBackColor = Color.Silver
        Font6.BackColor = Panel1.BackColor
        Font6.FlatAppearance.MouseDownBackColor = Color.Gray
        Font6.FlatAppearance.MouseOverBackColor = Color.Silver

        Font4.BackColor = Color.Gray
        Font4.FlatAppearance.MouseDownBackColor = Color.Gray
        Font4.FlatAppearance.MouseOverBackColor = Color.Gray

        CarattereTB.Text = ("script")
        Button53.Text = (CarattereTB.Text)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Font5.Click
        Font1.BackColor = Panel1.BackColor
        Font1.FlatAppearance.MouseDownBackColor = Color.Gray
        Font1.FlatAppearance.MouseOverBackColor = Color.Silver
        Font2.BackColor = Panel1.BackColor
        Font2.FlatAppearance.MouseDownBackColor = Color.Gray
        Font2.FlatAppearance.MouseOverBackColor = Color.Silver
        Font3.BackColor = Panel1.BackColor
        Font3.FlatAppearance.MouseDownBackColor = Color.Gray
        Font3.FlatAppearance.MouseOverBackColor = Color.Silver
        Font4.BackColor = Panel1.BackColor
        Font4.FlatAppearance.MouseDownBackColor = Color.Gray
        Font4.FlatAppearance.MouseOverBackColor = Color.Silver
        Font5.BackColor = Panel1.BackColor
        Font5.FlatAppearance.MouseDownBackColor = Color.Gray
        Font5.FlatAppearance.MouseOverBackColor = Color.Silver
        Font6.BackColor = Panel1.BackColor
        Font6.FlatAppearance.MouseDownBackColor = Color.Gray
        Font6.FlatAppearance.MouseOverBackColor = Color.Silver

        Font5.BackColor = Color.Gray
        Font5.FlatAppearance.MouseDownBackColor = Color.Gray
        Font5.FlatAppearance.MouseOverBackColor = Color.Gray

        CarattereTB.Text = ("open-serif")
        Button53.Text = (CarattereTB.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Font6.Click
        Font1.BackColor = Panel1.BackColor
        Font1.FlatAppearance.MouseDownBackColor = Color.Gray
        Font1.FlatAppearance.MouseOverBackColor = Color.Silver
        Font2.BackColor = Panel1.BackColor
        Font2.FlatAppearance.MouseDownBackColor = Color.Gray
        Font2.FlatAppearance.MouseOverBackColor = Color.Silver
        Font3.BackColor = Panel1.BackColor
        Font3.FlatAppearance.MouseDownBackColor = Color.Gray
        Font3.FlatAppearance.MouseOverBackColor = Color.Silver
        Font4.BackColor = Panel1.BackColor
        Font4.FlatAppearance.MouseDownBackColor = Color.Gray
        Font4.FlatAppearance.MouseOverBackColor = Color.Silver
        Font5.BackColor = Panel1.BackColor
        Font5.FlatAppearance.MouseDownBackColor = Color.Gray
        Font5.FlatAppearance.MouseOverBackColor = Color.Silver
        Font6.BackColor = Panel1.BackColor
        Font6.FlatAppearance.MouseDownBackColor = Color.Gray
        Font6.FlatAppearance.MouseOverBackColor = Color.Silver

        Font6.BackColor = Color.Gray
        Font6.FlatAppearance.MouseDownBackColor = Color.Gray
        Font6.FlatAppearance.MouseOverBackColor = Color.Gray

        CarattereTB.Text = ("cursive")
        Button53.Text = (CarattereTB.Text)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Dove.Text = ("BottoneTesto") Then
            Bottone.Button53.Text = (CarattereTB.Text)
            Bottone.BottoneTestoCarattere.Text = (CarattereTB.Text)

            Font1.BackColor = Panel1.BackColor
            Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Font1.FlatAppearance.MouseOverBackColor = Color.Silver
            Font2.BackColor = Panel1.BackColor
            Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Font2.FlatAppearance.MouseOverBackColor = Color.Silver
            Font3.BackColor = Panel1.BackColor
            Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Font3.FlatAppearance.MouseOverBackColor = Color.Silver
            Font4.BackColor = Panel1.BackColor
            Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Font4.FlatAppearance.MouseOverBackColor = Color.Silver
            Font5.BackColor = Panel1.BackColor
            Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Font5.FlatAppearance.MouseOverBackColor = Color.Silver
            Font6.BackColor = Panel1.BackColor
            Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Font6.FlatAppearance.MouseOverBackColor = Color.Silver

            CarattereTB.Text = ("")
            Button53.Text = ("")

            Me.Close()
        ElseIf Dove.Text = ("CollegamentoTesto") Then
            Collegamento.Button53.Text = (CarattereTB.Text)
            Collegamento.CollegamentoTestoCarattere.Text = (CarattereTB.Text)

            Font1.BackColor = Panel1.BackColor
            Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Font1.FlatAppearance.MouseOverBackColor = Color.Silver
            Font2.BackColor = Panel1.BackColor
            Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Font2.FlatAppearance.MouseOverBackColor = Color.Silver
            Font3.BackColor = Panel1.BackColor
            Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Font3.FlatAppearance.MouseOverBackColor = Color.Silver
            Font4.BackColor = Panel1.BackColor
            Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Font4.FlatAppearance.MouseOverBackColor = Color.Silver
            Font5.BackColor = Panel1.BackColor
            Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Font5.FlatAppearance.MouseOverBackColor = Color.Silver
            Font6.BackColor = Panel1.BackColor
            Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Font6.FlatAppearance.MouseOverBackColor = Color.Silver

            CarattereTB.Text = ("")
            Button53.Text = ("")


            Me.Close()
        ElseIf Dove.Text = ("DescrizioneTesto") Then
            Descrizione.Button53.Text = (CarattereTB.Text)
            Descrizione.DescrizioneTestoCarattere.Text = (CarattereTB.Text)

            Font1.BackColor = Panel1.BackColor
            Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Font1.FlatAppearance.MouseOverBackColor = Color.Silver
            Font2.BackColor = Panel1.BackColor
            Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Font2.FlatAppearance.MouseOverBackColor = Color.Silver
            Font3.BackColor = Panel1.BackColor
            Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Font3.FlatAppearance.MouseOverBackColor = Color.Silver
            Font4.BackColor = Panel1.BackColor
            Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Font4.FlatAppearance.MouseOverBackColor = Color.Silver
            Font5.BackColor = Panel1.BackColor
            Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Font5.FlatAppearance.MouseOverBackColor = Color.Silver
            Font6.BackColor = Panel1.BackColor
            Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Font6.FlatAppearance.MouseOverBackColor = Color.Silver

            CarattereTB.Text = ("")
            Button53.Text = ("")


            Me.Close()
        ElseIf Dove.Text = ("SottotitoloTesto") Then
            Sottotitolo.Button53.Text = (CarattereTB.Text)
            Sottotitolo.SottotitoloTestoCarattere.Text = (CarattereTB.Text)

            Font1.BackColor = Panel1.BackColor
            Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Font1.FlatAppearance.MouseOverBackColor = Color.Silver
            Font2.BackColor = Panel1.BackColor
            Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Font2.FlatAppearance.MouseOverBackColor = Color.Silver
            Font3.BackColor = Panel1.BackColor
            Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Font3.FlatAppearance.MouseOverBackColor = Color.Silver
            Font4.BackColor = Panel1.BackColor
            Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Font4.FlatAppearance.MouseOverBackColor = Color.Silver
            Font5.BackColor = Panel1.BackColor
            Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Font5.FlatAppearance.MouseOverBackColor = Color.Silver
            Font6.BackColor = Panel1.BackColor
            Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Font6.FlatAppearance.MouseOverBackColor = Color.Silver

            CarattereTB.Text = ("")
            Button53.Text = ("")


            Me.Close()
        ElseIf Dove.Text = ("TitoloTesto") Then
            Titolo.Button53.Text = (CarattereTB.Text)
            Titolo.TitoloTestoCarattere.Text = (CarattereTB.Text)

            Font1.BackColor = Panel1.BackColor
            Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Font1.FlatAppearance.MouseOverBackColor = Color.Silver
            Font2.BackColor = Panel1.BackColor
            Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Font2.FlatAppearance.MouseOverBackColor = Color.Silver
            Font3.BackColor = Panel1.BackColor
            Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Font3.FlatAppearance.MouseOverBackColor = Color.Silver
            Font4.BackColor = Panel1.BackColor
            Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Font4.FlatAppearance.MouseOverBackColor = Color.Silver
            Font5.BackColor = Panel1.BackColor
            Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Font5.FlatAppearance.MouseOverBackColor = Color.Silver
            Font6.BackColor = Panel1.BackColor
            Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Font6.FlatAppearance.MouseOverBackColor = Color.Silver

            CarattereTB.Text = ("")
            Button53.Text = ("")


            Me.Close()
        ElseIf Dove.Text = ("ParagrafoTesto") Then
            Paragrafo.Button53.Text = (CarattereTB.Text)
            Paragrafo.ParagrafoTestoCarattere.Text = (CarattereTB.Text)

            Font1.BackColor = Panel1.BackColor
            Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Font1.FlatAppearance.MouseOverBackColor = Color.Silver
            Font2.BackColor = Panel1.BackColor
            Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Font2.FlatAppearance.MouseOverBackColor = Color.Silver
            Font3.BackColor = Panel1.BackColor
            Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Font3.FlatAppearance.MouseOverBackColor = Color.Silver
            Font4.BackColor = Panel1.BackColor
            Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Font4.FlatAppearance.MouseOverBackColor = Color.Silver
            Font5.BackColor = Panel1.BackColor
            Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Font5.FlatAppearance.MouseOverBackColor = Color.Silver
            Font6.BackColor = Panel1.BackColor
            Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Font6.FlatAppearance.MouseOverBackColor = Color.Silver

            CarattereTB.Text = ("")
            Button53.Text = ("")


            Me.Close()
        ElseIf Dove.Text = ("ElencoTesto") Then
            Elenco.Button53.Text = (CarattereTB.Text)
            Elenco.ElencoTestoCarattere.Text = (CarattereTB.Text)

            Font1.BackColor = Panel1.BackColor
            Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Font1.FlatAppearance.MouseOverBackColor = Color.Silver
            Font2.BackColor = Panel1.BackColor
            Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Font2.FlatAppearance.MouseOverBackColor = Color.Silver
            Font3.BackColor = Panel1.BackColor
            Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Font3.FlatAppearance.MouseOverBackColor = Color.Silver
            Font4.BackColor = Panel1.BackColor
            Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Font4.FlatAppearance.MouseOverBackColor = Color.Silver
            Font5.BackColor = Panel1.BackColor
            Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Font5.FlatAppearance.MouseOverBackColor = Color.Silver
            Font6.BackColor = Panel1.BackColor
            Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Font6.FlatAppearance.MouseOverBackColor = Color.Silver

            CarattereTB.Text = ("")
            Button53.Text = ("")


            Me.Close()
        ElseIf Dove.Text = ("TestoCarattereTestoPersonalizzato") Then
            TestoPersonalizzato.Button53.Text = (CarattereTB.Text)
            TestoPersonalizzato.TestoPersonalizzatoTestoCarattere.Text = (CarattereTB.Text)

            Font1.BackColor = Panel1.BackColor
            Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Font1.FlatAppearance.MouseOverBackColor = Color.Silver
            Font2.BackColor = Panel1.BackColor
            Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Font2.FlatAppearance.MouseOverBackColor = Color.Silver
            Font3.BackColor = Panel1.BackColor
            Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Font3.FlatAppearance.MouseOverBackColor = Color.Silver
            Font4.BackColor = Panel1.BackColor
            Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Font4.FlatAppearance.MouseOverBackColor = Color.Silver
            Font5.BackColor = Panel1.BackColor
            Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Font5.FlatAppearance.MouseOverBackColor = Color.Silver
            Font6.BackColor = Panel1.BackColor
            Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Font6.FlatAppearance.MouseOverBackColor = Color.Silver

            CarattereTB.Text = ("")
            Button53.Text = ("")


            Me.Close()
        ElseIf Dove.Text = ("TabellaTesto") Then
            Tabella.Button53.Text = (CarattereTB.Text)
            Tabella.TabellaTestoCarattere.Text = (CarattereTB.Text)

            Font1.BackColor = Panel1.BackColor
            Font1.FlatAppearance.MouseDownBackColor = Color.Gray
            Font1.FlatAppearance.MouseOverBackColor = Color.Silver
            Font2.BackColor = Panel1.BackColor
            Font2.FlatAppearance.MouseDownBackColor = Color.Gray
            Font2.FlatAppearance.MouseOverBackColor = Color.Silver
            Font3.BackColor = Panel1.BackColor
            Font3.FlatAppearance.MouseDownBackColor = Color.Gray
            Font3.FlatAppearance.MouseOverBackColor = Color.Silver
            Font4.BackColor = Panel1.BackColor
            Font4.FlatAppearance.MouseDownBackColor = Color.Gray
            Font4.FlatAppearance.MouseOverBackColor = Color.Silver
            Font5.BackColor = Panel1.BackColor
            Font5.FlatAppearance.MouseDownBackColor = Color.Gray
            Font5.FlatAppearance.MouseOverBackColor = Color.Silver
            Font6.BackColor = Panel1.BackColor
            Font6.FlatAppearance.MouseDownBackColor = Color.Gray
            Font6.FlatAppearance.MouseOverBackColor = Color.Silver

            CarattereTB.Text = ("")
            Button53.Text = ("")


            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Carattere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bottone.Text = ("Bottone")
    End Sub
End Class
