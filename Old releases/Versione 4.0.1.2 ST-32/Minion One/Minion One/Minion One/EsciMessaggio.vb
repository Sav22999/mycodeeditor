Public Class EsciMessaggio

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Tipo.Text = ("Esci") Then
            End
        ElseIf Tipo.Text = ("Apri") Then
            MinionOneF.ApriNuovoProgNonSalv.Text = ("Apri")
            Me.Close()
        ElseIf Tipo.Text = ("Nuovo") Then
            MinionOneF.ApriNuovoProgNonSalv.Text = ("Nuovo")
            Me.Close()
        End If
    End Sub

    Private Sub AnteprimaButtonR_Click(sender As Object, e As EventArgs) Handles AnteprimaButtonR.Click
        If Tipo.Text = ("Esci") Then
            If MinionOneF.buttprogcss.Visible = True Then
                If MinionOneF.Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text.Replace(".html", ".css"), MinionOneF.CSSFTB.Text)
                End If
                If MinionOneF.Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.FastColoredTextBox1.Text)
                End If
                MinionOneF.buttprogling.Text = "&HTML"
                MinionOneF.buttprogcss.Text = "&CSS"
            Else
                If MinionOneF.Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.FastColoredTextBox1.Text)
                Else
                    If (MinionOneF.Button4.Text <> "") Then
                        System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.FastColoredTextBox1.Text)
                    End If
                End If
                MinionOneF.buttprogling.Text = "&HTML"
            End If
            MinionOneF.UltSalHTML.Text = ( Now.Hour & ":" & Now.Minute)
            MinionOneF.UltSalCSS.Text = ( Now.Hour & ":" & Now.Minute)
            MinionOneF.Button5.Text = ( Now.Hour & ":" & Now.Minute)
            End
        ElseIf Tipo.Text = ("Apri") Then
            If MinionOneF.buttprogcss.Visible = True Then
                If MinionOneF.Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text.Replace(".html", ".css"), MinionOneF.CSSFTB.Text)
                End If
                If MinionOneF.Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.FastColoredTextBox1.Text)
                End If
                MinionOneF.buttprogling.Text = "&HTML"
                MinionOneF.buttprogcss.Text = "&CSS"
            Else
                If MinionOneF.Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.FastColoredTextBox1.Text)
                Else
                    If (MinionOneF.Button4.Text <> "") Then
                        System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.FastColoredTextBox1.Text)
                    End If
                End If
                MinionOneF.buttprogling.Text = "&HTML"
            End If
            MinionOneF.UltSalHTML.Text = ( Now.Hour & ":" & Now.Minute)
            MinionOneF.UltSalCSS.Text = ( Now.Hour & ":" & Now.Minute)
            MinionOneF.Button5.Text = ( Now.Hour & ":" & Now.Minute)
            MinionOneF.ApriNuovoProgNonSalv.Text = ("Apri")
            Me.Close()
        ElseIf Tipo.Text = ("Nuovo") Then
            If MinionOneF.buttprogcss.Visible = True Then
                If MinionOneF.Button4.Text.Contains(".css") Then
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.CSSFTB.Text)
                Else
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text.Replace(".html", ".css"), MinionOneF.CSSFTB.Text)
                End If
                If MinionOneF.Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.FastColoredTextBox1.Text)
                End If
                MinionOneF.buttprogling.Text = "&HTML"
                MinionOneF.buttprogcss.Text = "&CSS"
            Else
                If MinionOneF.Button4.Text.Contains(".html") Then
                    System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.FastColoredTextBox1.Text)
                Else
                    If (MinionOneF.Button4.Text <> "") Then
                        System.IO.File.WriteAllText(MinionOneF.Button4.Text, MinionOneF.FastColoredTextBox1.Text)
                    End If
                End If
                MinionOneF.buttprogling.Text = "&HTML"
            End If
            MinionOneF.UltSalHTML.Text = ( Now.Hour & ":" & Now.Minute)
            MinionOneF.UltSalCSS.Text = ( Now.Hour & ":" & Now.Minute)
            MinionOneF.Button5.Text = ( Now.Hour & ":" & Now.Minute)
            MinionOneF.ApriNuovoProgNonSalv.Text = ("Nuovo")
            Me.Close()
        End If
    End Sub

    Private Sub BackUpTrovato_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class