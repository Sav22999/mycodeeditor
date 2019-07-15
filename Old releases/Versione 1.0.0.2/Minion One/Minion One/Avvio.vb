Public Class Avvio

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If ApriProgettoMinionOne.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim testo As String
            testo = System.IO.File.ReadAllText(ApriProgettoMinionOne.FileName)
            MinionOne.FastColoredTextBox1.Text = (testo)
            MinionOne.Text = (ApriProgettoMinionOne.FileName & " - Minion One")
            MinionOne.TextBox1.Text = (ApriProgettoMinionOne.FileName)
            Me.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MinionOne.Text = ("Nuovo Progetto - Minion One")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class