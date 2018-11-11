Public Class ContexMenu1_Inserisci
    Private Sub Bottone_Click(sender As Object, e As EventArgs) Handles Bottone.Click
        MyCEF.bottonefun()
    End Sub

    Private Sub Collegamento_Click(sender As Object, e As EventArgs) Handles Collegamento.Click
        MyCEF.collegamentofun()
    End Sub

    Private Sub Commento_Click(sender As Object, e As EventArgs) Handles Commento.Click
        MyCEF.commentofun()
    End Sub

    Private Sub Contenitore_Click(sender As Object, e As EventArgs) Handles Contenitore.Click
        MyCEF.contenitorefun()
    End Sub

    Private Sub Elenco_Click(sender As Object, e As EventArgs) Handles Elenco.Click
        MyCEF.elencofun()
    End Sub

    Private Sub Immagine_Click(sender As Object, e As EventArgs) Handles Immagine.Click
        MyCEF.immaginefun()
    End Sub

    Private Sub Paragrafo_Click(sender As Object, e As EventArgs) Handles Paragrafo.Click
        MyCEF.paragrafofun()
    End Sub

    Private Sub Separatore_Click(sender As Object, e As EventArgs) Handles Separatore.Click
        MyCEF.separatorefun()
    End Sub

    Private Sub Tabella_Click(sender As Object, e As EventArgs) Handles Tabella.Click
        MyCEF.tabellafun()
    End Sub

    Private Sub TestoPersonalizzato_Click(sender As Object, e As EventArgs) Handles TestoPersonalizzato.Click
        MyCEF.testopersonalizzatofun()
    End Sub

    Private Sub Titolo_Click(sender As Object, e As EventArgs) Handles Titolo.Click
        MyCEF.titolofun()
    End Sub

    Private Sub CaratteriSpeciali_Click(sender As Object, e As EventArgs) Handles CaratteriSpeciali.Click
        MyCEF.caratterispecialifun()
    End Sub

    Private Sub ContexMenu1_Inserisci_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class