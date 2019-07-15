Public Class CollegamentoBarraStrumenti

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ProgettoGuidato.Visible = False Then
            MinionOne.Button53.BackColor = Color.Silver
            MinionOne.TESTOINCOLLATO.Paste()
            MinionOne.TESTODAINSERIRE.Text = ("<a href=" & Chr(34) & TextBox1.Text & Chr(34) & " >")
            MinionOne.TESTODAINSERIRE.SelectAll()
            MinionOne.TESTODAINSERIRE.Copy()
            MinionOne.FastColoredTextBox1.Paste()
            MinionOne.TESTOINCOLLATO.SelectAll()
            MinionOne.TESTOINCOLLATO.Copy()
            MinionOne.FastColoredTextBox1.Select()
            Me.Close()
        Else
            ProgettoGuidato.Button10.BackColor = Color.Red
            MinionOne.TESTOINCOLLATO.Paste()
            MinionOne.TESTODAINSERIRE.Text = ("<a href=" & Chr(34) & TextBox1.Text & Chr(34) & " >")
            MinionOne.TESTODAINSERIRE.SelectAll()
            MinionOne.TESTODAINSERIRE.Copy()
            ProgettoGuidato.TextBox1.Paste()
            MinionOne.TESTOINCOLLATO.SelectAll()
            MinionOne.TESTOINCOLLATO.Copy()
            ProgettoGuidato.TextBox1.Select()
            Me.Close()
        End If
    End Sub

    Private Sub CollegamentoBarraStrumenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ProgettoGuidato.Visible = False Then
                MinionOne.Button53.BackColor = Color.Silver
                MinionOne.TESTOINCOLLATO.Paste()
                MinionOne.TESTODAINSERIRE.Text = ("<a href=" & Chr(34) & TextBox1.Text & Chr(34) & " >")
                MinionOne.TESTODAINSERIRE.SelectAll()
                MinionOne.TESTODAINSERIRE.Copy()
                MinionOne.FastColoredTextBox1.Paste()
                MinionOne.TESTOINCOLLATO.SelectAll()
                MinionOne.TESTOINCOLLATO.Copy()
                MinionOne.FastColoredTextBox1.Select()
                Me.Close()
            Else
                ProgettoGuidato.Button10.BackColor = Color.Red
                MinionOne.TESTOINCOLLATO.Paste()
                MinionOne.TESTODAINSERIRE.Text = ("<a href=" & Chr(34) & TextBox1.Text & Chr(34) & " >")
                MinionOne.TESTODAINSERIRE.SelectAll()
                MinionOne.TESTODAINSERIRE.Copy()
                ProgettoGuidato.TextBox1.Paste()
                MinionOne.TESTOINCOLLATO.SelectAll()
                MinionOne.TESTOINCOLLATO.Copy()
                ProgettoGuidato.TextBox1.Select()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class