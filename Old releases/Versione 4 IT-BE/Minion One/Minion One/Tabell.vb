Public Class Tabell

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Try
            Button5.Text = "Celle totali: " & (TextBox8.Text * TextBox1.Text)
        Catch ex As Exception

        End Try
        If TextBox8.Text.Replace(" ", "") = "" Then
            TextBox8.Text = ("1")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Button5.Text = "Celle totali: " & (TextBox8.Text * TextBox1.Text)
        Catch ex As Exception

        End Try
        If TextBox1.Text.Replace(" ", "") = "" Then
            TextBox1.Text = ("1")
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim Colonna As New Integer
        Dim Riga As New Integer
        Colonna = 1
        Riga = 1
        TextBox2.Text = TextBox2.Text & ("<table>") & vbNewLine
        Do While Colonna <= TextBox1.Text
            Riga = 1
            TextBox2.Text = TextBox2.Text & ("<tr>") & vbNewLine
            Do While Riga <= TextBox8.Text
                TextBox2.Text = TextBox2.Text & vbTab & ("<td>") & Riga & "-" & Colonna & vbNewLine & vbTab & ("</td>") & vbNewLine
                Riga = Riga + 1
            Loop
            TextBox2.Text = TextBox2.Text & ("</tr>") & vbNewLine
            Colonna = Colonna + 1
        Loop
        TextBox2.Text = TextBox2.Text & ("</table>")

    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click

    End Sub
End Class