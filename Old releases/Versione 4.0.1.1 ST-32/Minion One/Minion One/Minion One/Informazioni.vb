Public Class InformazioniF

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MinionOneSitoLink.LinkClicked
        Process.Start("http://" & MinionOneSitoLink.Text)
    End Sub

    Private Sub FileButton_Click(sender As Object, e As EventArgs) Handles ControllaGliAggiornamentiButton.Click
        MinionOneF.aggiornamentoscaricaautomaticamenteavvio = False
        ControlloAggiornamenti.ShowDialog()
    End Sub

    Private Sub ContattaciButton_Click(sender As Object, e As EventArgs) Handles ContattaciButton.Click
        Contattaci.ShowDialog()
    End Sub

    Private Sub SegnalaUnProblemaButton_Click(sender As Object, e As EventArgs) Handles SegnalaUnProblemaButton.Click
        SegnalazioneProblema.ShowDialog()
    End Sub

    Private Sub RiconoscimentiButton_Click(sender As Object, e As EventArgs) Handles RiconoscimentiButton.Click
        Riconoscimenti.ShowDialog()
    End Sub

    Private Sub LicenzaButton_Click(sender As Object, e As EventArgs) Handles LicenzaButton.Click
        Licenza.ShowDialog()
    End Sub

    Private Sub CondizioniDUsoButton_Click(sender As Object, e As EventArgs) Handles CondizioniDUsoButton.Click
        CondizioniDUso.ShowDialog()
    End Sub
End Class