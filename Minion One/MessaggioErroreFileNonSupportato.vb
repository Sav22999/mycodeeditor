Public Class MessaggioErroreFileNonSupportato

    Private Sub ChiudiMessaggio_Click(sender As Object, e As EventArgs) Handles ChiudiMessaggio.Click
        Me.Close()
    End Sub

    Private Sub MessaggioF_Load(sender As Object, e As EventArgs)
        ChiudiMessaggio.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("http://www.mycodeeditor.com/search/?s=" & "MOEAA0006")
    End Sub
End Class