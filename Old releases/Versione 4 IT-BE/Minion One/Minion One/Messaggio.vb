Public Class MessaggioF

    Private Sub ChiudiMessaggio_Click(sender As Object, e As EventArgs) Handles ChiudiMessaggio.Click
        Me.Close()
    End Sub

    Private Sub MessaggioF_Load(sender As Object, e As EventArgs)
        ChiudiMessaggio.Select()
    End Sub
End Class