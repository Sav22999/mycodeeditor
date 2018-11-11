Public Class EsciMessaggio

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Tipo.Text = ("Esci") Then
            End
        ElseIf Tipo.Text = ("Apri") Then
            MyCEF.ApriNuovoProgNonSalv.Text = ("Apri")
            Me.Close()
        ElseIf Tipo.Text = ("Nuovo") Then
            MyCEF.ApriNuovoProgNonSalv.Text = ("Nuovo")
            Me.Close()
        End If
    End Sub

    Private Sub AnteprimaButtonR_Click(sender As Object, e As EventArgs) Handles AnteprimaButtonR.Click
        If Tipo.Text = ("Esci") Then
            MyCEF.salvatutto_func()
            End
        ElseIf Tipo.Text = ("Apri") Then
            MyCEF.salvatutto_func()
            MyCEF.ApriNuovoProgNonSalv.Text = ("Apri")
            Me.Close()
        ElseIf Tipo.Text = ("Nuovo") Then
            MyCEF.salvatutto_func()
            MyCEF.ApriNuovoProgNonSalv.Text = ("Nuovo")
            Me.Close()
        End If
    End Sub

    Private Sub BackUpTrovato_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class