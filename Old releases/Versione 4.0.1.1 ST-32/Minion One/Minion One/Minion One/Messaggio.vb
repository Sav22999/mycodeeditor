Public Class MessaggioF

    Private Sub ChiudiMessaggio_Click(sender As Object, e As EventArgs) Handles ChiudiMessaggio.Click
        Me.Close()
    End Sub

    Private Sub MessaggioF_Load(sender As Object, e As EventArgs)
        ChiudiMessaggio.Select()
    End Sub

    Private Sub MessaggioF_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DettagliErroreButton_Click(sender As Object, e As EventArgs) Handles DettagliErroreButton.Click
        Process.Start("http://minionone.altervista.org/Wiki/?s=" & ErroreTxt.Text)
    End Sub
End Class