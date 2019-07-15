Public Class ProgettoGuidato

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MinionOne.TESTOINCOLLATO.Paste()
        If Button1.BackColor = Color.DarkRed Then
            MinionOne.TESTODAINSERIRE.Text = ("<b>")
            TextBox1.Select()
            Button1.BackColor = Color.Red
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</b>" & Environment.NewLine)
            Button1.BackColor = Color.DarkRed
            TextBox1.Select()
        End If
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MinionOne.TESTOINCOLLATO.Paste()
        If Button2.BackColor = Color.DarkRed Then
            MinionOne.TESTODAINSERIRE.Text = ("<i>")
            Button2.BackColor = Color.Red
            TextBox1.Select()
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</i>" & Environment.NewLine)
            Button2.BackColor = Color.DarkRed
            TextBox1.Select()
        End If
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MinionOne.TESTOINCOLLATO.Paste()
        If Button3.BackColor = Color.DarkRed Then
            MinionOne.TESTODAINSERIRE.Text = ("<u>")
            Button3.BackColor = Color.Red
            TextBox1.Select()
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</u>" & Environment.NewLine)
            Button3.BackColor = Color.DarkRed
            TextBox1.Select()
        End If
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MinionOne.TESTOINCOLLATO.Paste()
        If Button4.BackColor = Color.DarkRed Then
            MinionOne.TESTODAINSERIRE.Text = ("<s>")
            Button4.BackColor = Color.Red
            TextBox1.Select()
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</s>" & Environment.NewLine)
            Button4.BackColor = Color.DarkRed
            TextBox1.Select()
        End If
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Select()
        ImmagineBarraStrumenti.Show()
        TextBox1.Select()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Select()
        If Button10.BackColor = Color.DarkRed Then
            CollegamentoBarraStrumenti.Show()
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</a>" & Environment.NewLine)
            Button10.BackColor = Color.DarkRed
            MinionOne.TESTODAINSERIRE.SelectAll()
            MinionOne.TESTODAINSERIRE.Copy()
            TextBox1.Paste()
            MinionOne.TESTOINCOLLATO.SelectAll()
            MinionOne.TESTOINCOLLATO.Copy()
        End If
        TextBox1.Select()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MinionOne.TESTOINCOLLATO.Paste()
        MinionOne.TESTODAINSERIRE.Text = (Environment.NewLine & "/*/" & Environment.NewLine)
        TextBox1.Select()
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MinionOne.TESTOINCOLLATO.Paste()
        MinionOne.TESTODAINSERIRE.Text = (Environment.NewLine & "+------------------------+" & Environment.NewLine)
        TextBox1.Select()
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MinionOne.TESTOINCOLLATO.Paste()
        If Button6.BackColor = Color.DarkRed Then
            MinionOne.TESTODAINSERIRE.Text = ("<p>" & Environment.NewLine)
            TextBox1.Select()
            Button6.BackColor = Color.Red
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</p>" & Environment.NewLine)
            TextBox1.Select()
            Button6.BackColor = Color.DarkRed
        End If
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MinionOne.TESTOINCOLLATO.Paste()
        If Button7.BackColor = Color.DarkRed Then
            MinionOne.TESTODAINSERIRE.Text = ("<big>")
            TextBox1.Select()
            Button7.BackColor = Color.Red
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</big>" & Environment.NewLine)
            TextBox1.Select()
            Button7.BackColor = Color.DarkRed
        End If
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MinionOne.TESTOINCOLLATO.Paste()
        If Button13.BackColor = Color.DarkRed Then
            MinionOne.TESTODAINSERIRE.Text = ("<small>")
            TextBox1.Select()
            Button13.BackColor = Color.Red
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</small>" & Environment.NewLine)
            TextBox1.Select()
            Button13.BackColor = Color.DarkRed
        End If
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MinionOne.TESTOINCOLLATO.Paste()
        If Button14.BackColor = Color.DarkRed Then
            MinionOne.TESTODAINSERIRE.Text = ("<sub>")
            TextBox1.Select()
            Button14.BackColor = Color.Red
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</sub>" & Environment.NewLine)
            TextBox1.Select()
            Button14.BackColor = Color.DarkRed
        End If
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        MinionOne.TESTOINCOLLATO.Paste()
        If Button15.BackColor = Color.DarkRed Then
            MinionOne.TESTODAINSERIRE.Text = ("<sup>")
            TextBox1.Select()
            Button15.BackColor = Color.Red
        Else
            MinionOne.TESTODAINSERIRE.Text = ("</sup>" & Environment.NewLine)
            TextBox1.Select()
            Button15.BackColor = Color.DarkRed
        End If
        MinionOne.TESTODAINSERIRE.SelectAll()
        MinionOne.TESTODAINSERIRE.Copy()
        TextBox1.Paste()
        MinionOne.TESTOINCOLLATO.SelectAll()
        MinionOne.TESTOINCOLLATO.Copy()

        TextBox1.Select()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ComboBox1.Text = ("Nero") Then
            coloresfondo.Text = ("black")
        ElseIf ComboBox1.Text = ("Bianco") Then
            coloresfondo.Text = ("white")
        ElseIf ComboBox1.Text = ("Giallo") Then
            coloresfondo.Text = ("yellow")
        ElseIf ComboBox1.Text = ("Rosso") Then
            coloresfondo.Text = ("red")
        ElseIf ComboBox1.Text = ("Verde") Then
            coloresfondo.Text = ("green")
        ElseIf ComboBox1.Text = ("Blu") Then
            coloresfondo.Text = ("blue")
        ElseIf ComboBox1.Text = ("Grigio") Then
            coloresfondo.Text = ("gray")
        ElseIf ComboBox1.Text = ("Fuchsia") Then
            coloresfondo.Text = ("fuchsia")
        ElseIf ComboBox1.Text = ("Viola") Then
            coloresfondo.Text = ("purple")
        ElseIf ComboBox1.Text = ("Rosa") Then
            coloresfondo.Text = ("pink")
        ElseIf ComboBox1.Text = ("Arancione") Then
            coloresfondo.Text = ("orange")
        ElseIf ComboBox1.Text = ("Celeste") Then
            coloresfondo.Text = ("cyan")
        ElseIf ComboBox1.Text = ("Lime") Then
            coloresfondo.Text = ("lime")
        ElseIf ComboBox1.Text = ("Oro") Then
            coloresfondo.Text = ("gold")
        ElseIf ComboBox1.Text = ("Argento") Then
            coloresfondo.Text = ("silver")
        End If
        If ComboBox2.Text = ("Nero") Then
            coloretesto.Text = ("black")
        ElseIf ComboBox2.Text = ("Bianco") Then
            coloretesto.Text = ("white")
        ElseIf ComboBox2.Text = ("Giallo") Then
            coloretesto.Text = ("yellow")
        ElseIf ComboBox2.Text = ("Rosso") Then
            coloretesto.Text = ("red")
        ElseIf ComboBox2.Text = ("Verde") Then
            coloretesto.Text = ("green")
        ElseIf ComboBox2.Text = ("Blu") Then
            coloretesto.Text = ("blue")
        ElseIf ComboBox2.Text = ("Grigio") Then
            coloretesto.Text = ("gray")
        ElseIf ComboBox2.Text = ("Fuchsia") Then
            coloretesto.Text = ("fuchsia")
        ElseIf ComboBox2.Text = ("Viola") Then
            coloretesto.Text = ("purple")
        ElseIf ComboBox2.Text = ("Rosa") Then
            coloretesto.Text = ("pink")
        ElseIf ComboBox2.Text = ("Arancione") Then
            coloretesto.Text = ("orange")
        ElseIf ComboBox2.Text = ("Celeste") Then
            coloretesto.Text = ("cyan")
        ElseIf ComboBox2.Text = ("Lime") Then
            coloretesto.Text = ("lime")
        ElseIf ComboBox2.Text = ("Oro") Then
            coloretesto.Text = ("gold")
        ElseIf ComboBox2.Text = ("Argento") Then
            coloretesto.Text = ("silver")
        End If
        If ComboBox3.Text = ("Nero") Then
            colorelink.Text = ("black")
        ElseIf ComboBox3.Text = ("Bianco") Then
            colorelink.Text = ("white")
        ElseIf ComboBox3.Text = ("Giallo") Then
            colorelink.Text = ("yellow")
        ElseIf ComboBox3.Text = ("Rosso") Then
            colorelink.Text = ("red")
        ElseIf ComboBox3.Text = ("Verde") Then
            colorelink.Text = ("green")
        ElseIf ComboBox3.Text = ("Blu") Then
            colorelink.Text = ("blue")
        ElseIf ComboBox3.Text = ("Grigio") Then
            colorelink.Text = ("gray")
        ElseIf ComboBox3.Text = ("Fuchsia") Then
            colorelink.Text = ("fuchsia")
        ElseIf ComboBox3.Text = ("Viola") Then
            colorelink.Text = ("purple")
        ElseIf ComboBox3.Text = ("Rosa") Then
            colorelink.Text = ("pink")
        ElseIf ComboBox3.Text = ("Arancione") Then
            colorelink.Text = ("orange")
        ElseIf ComboBox3.Text = ("Celeste") Then
            colorelink.Text = ("cyan")
        ElseIf ComboBox3.Text = ("Lime") Then
            colorelink.Text = ("lime")
        ElseIf ComboBox3.Text = ("Oro") Then
            colorelink.Text = ("gold")
        ElseIf ComboBox3.Text = ("Argento") Then
            colorelink.Text = ("silver")
        End If
        MinionOne.FastColoredTextBox1.Clear()
        MinionOne.FastColoredTextBox1.Text = ("<html>")
        MinionOne.FastColoredTextBox1.Text = (MinionOne.FastColoredTextBox1.Text & Environment.NewLine & "<head>")
        MinionOne.FastColoredTextBox1.Text = (MinionOne.FastColoredTextBox1.Text & Environment.NewLine & "<title>" & TextBox2.Text & "</title>")
        MinionOne.FastColoredTextBox1.Text = (MinionOne.FastColoredTextBox1.Text & Environment.NewLine & "</head>")
        MinionOne.FastColoredTextBox1.Text = (MinionOne.FastColoredTextBox1.Text & Environment.NewLine & "<body bgcolor=" & Chr(34) & coloresfondo.Text & Chr(34) & " text=" & Chr(34) & coloretesto.Text & Chr(34) & " link=" & Chr(34) & colorelink.Text & Chr(34) & ">")
        TextBox1.Text = (TextBox1.Text.Replace("+------------------------+", "<hr/>"))
        TextBox1.Text = (TextBox1.Text.Replace("/*/", "<br/>"))
        MinionOne.FastColoredTextBox1.Text = (MinionOne.FastColoredTextBox1.Text & Environment.NewLine & TextBox1.Text)
        MinionOne.FastColoredTextBox1.Text = (MinionOne.FastColoredTextBox1.Text & Environment.NewLine & "</body>")
        MinionOne.FastColoredTextBox1.Text = (MinionOne.FastColoredTextBox1.Text & Environment.NewLine & "</html>")
        Me.Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ProgettoGuidato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Select()
    End Sub
End Class