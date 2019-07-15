Public Class Sostituisci
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CercaButton.Click
        If TextBox9.Text = "Trova" And TextBox9.ForeColor = Color.DarkGray Then
        Else
            Me.TopMost = False
            If MinionOneF.buttprogling.BackColor = Color.Red Then
                If MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Then
                    MessaggioF.Text = ("Parola trovata.")
                    MessaggioF.Button1.Text = (Chr(34) & TextBox9.Text & Chr(34) & " è stata trovata.")
                    MessaggioF.ShowDialog()
                Else
                    MessaggioF.Text = ("Parola non trovata.")
                    MessaggioF.Button1.Text = (Chr(34) & TextBox9.Text & Chr(34) & " non è stata trovata.")
                    MessaggioF.ShowDialog()
                End If
            ElseIf MinionOneF.buttprogcss.BackColor = Color.Red And MinionOneF.buttprogcss.Visible = True Then
                If MinionOneF.CSSFTB.Text.Contains(TextBox9.Text) Then
                    MessaggioF.Text = ("Parola trovata.")
                    MessaggioF.Button1.Text = (Chr(34) & TextBox9.Text & Chr(34) & " è stata trovata.")
                    MessaggioF.ShowDialog()
                Else
                    MessaggioF.Text = ("Parola non trovata.")
                    MessaggioF.Button1.Text = (Chr(34) & TextBox9.Text & Chr(34) & " non è stata trovata.")
                    MessaggioF.ShowDialog()
                End If
            End If
            Me.TopMost = True
        End If
    End Sub

    Private Sub SostituisciButton_Click(sender As Object, e As EventArgs) Handles SostituisciButton.Click
        If TextBox9.Text = "Trova" And TextBox9.ForeColor = Color.DarkGray Or TextBox1.Text = "Sostituisci" And TextBox1.ForeColor = Color.DarkGray Then
        Else
            Me.TopMost = False
            If MinionOneF.buttprogling.BackColor = Color.Red Then
                If MinionOneF.FastColoredTextBox1.Text.Contains(TextBox9.Text) Then
                    MinionOneF.FastColoredTextBox1.Text = MinionOneF.FastColoredTextBox1.Text.Replace(TextBox9.Text, TextBox1.Text)
                    MessaggioF.Text = ("Parola sostituita correttamente.")
                    MessaggioF.Button1.Text = (Chr(34) & TextBox9.Text & Chr(34) & " è stata sostituita correttamente con " & Chr(34) & TextBox1.Text & Chr(34) & ".")
                    MessaggioF.ShowDialog()
                Else
                    MessaggioF.Text = ("Parola non trovata.")
                    MessaggioF.Button1.Text = (Chr(34) & TextBox9.Text & Chr(34) & " non è stata trovata.")
                    MessaggioF.ShowDialog()
                End If
            ElseIf MinionOneF.buttprogcss.BackColor = Color.Red And MinionOneF.buttprogcss.Visible = True Then
                If MinionOneF.CSSFTB.Text.Contains(TextBox9.Text) Then
                    MinionOneF.CSSFTB.Text = MinionOneF.CSSFTB.Text.Replace(TextBox9.Text, TextBox1.Text)
                    MessaggioF.Text = ("Parola sostituita correttamente.")
                    MessaggioF.Button1.Text = (Chr(34) & TextBox9.Text & Chr(34) & " è stata sostituita correttamente con " & Chr(34) & TextBox1.Text & Chr(34) & ".")
                    MessaggioF.ShowDialog()
                Else
                    MessaggioF.Text = ("Parola non trovata.")
                    MessaggioF.Button1.Text = (Chr(34) & TextBox9.Text & Chr(34) & " non è stata trovata.")
                    MessaggioF.ShowDialog()
                End If
            End If
            Me.TopMost = True
        End If
    End Sub

    Private Sub Sostituisci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If MinionOneF.buttprogling.BackColor = Color.Red Then
                TextBox9.Text = MinionOneF.FastColoredTextBox1.SelectedText
            ElseIf MinionOneF.buttprogcss.BackColor = Color.Red And MinionOneF.buttprogcss.Visible = True Then
                TextBox9.Text = MinionOneF.CSSFTB.SelectedText
            End If
        Catch ex As Exception

        End Try
        TextBox9.Select()
    End Sub

    Private Sub TextBox9_GotFocus(sender As Object, e As EventArgs) Handles TextBox9.GotFocus
        If (TextBox9.Text = "Trova" And TextBox9.ForeColor = Color.DarkGray) Then
            TextBox9.ForeColor = Color.DarkRed
            TextBox9.Text = ("")
        End If
    End Sub

    Private Sub TextBox9_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        If e.KeyCode = Keys.Enter Then
            CercaButton.PerformClick()
        End If
    End Sub

    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        If TextBox9.Text = ("") Or TextBox9.Text.Replace(" ", "") = "" Then
            TextBox9.ForeColor = Color.DarkGray
            TextBox9.Text = ("Trova")
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        If (TextBox1.Text = "Sostituisci" And TextBox1.ForeColor = Color.DarkGray) Then
            TextBox1.ForeColor = Color.DarkRed
            TextBox1.Text = ("")
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            CercaButton.PerformClick()
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = ("") Or TextBox1.Text.Replace(" ", "") = "" Then
            TextBox1.ForeColor = Color.DarkGray
            TextBox1.Text = ("Sostituisci")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class