Public Class InserisciPanelMenu
    Private Sub InserisciPanelMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InserisciPanelMenu_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        MyCEF.InserisciButton.BackColor = Color.DarkRed
        MyCEF.InserisciButton.FlatAppearance.MouseOverBackColor = MyCEF.buttproghtml.FlatAppearance.MouseOverBackColor
        MyCEF.InserisciButton.FlatAppearance.MouseDownBackColor = Color.Red
        MyCEF.InserisciButton.ForeColor = Color.WhiteSmoke

        MyCEF.inserisci_menu = False

        If MyCEF.buttprogcss.BackColor = Color.Red Then
            MyCEF.CSSFTB.Select()
        Else
            MyCEF.FastColoredTextBox1.Select()
        End If
        Me.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Grassetto.Click
        MyCEF.grassetto_func()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Corsivo.Click
        MyCEF.corsivo_func()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Sottolineato.Click
        MyCEF.sottolineato_func()
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Barrato.Click
        MyCEF.barrato_func()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles ACapo.Click
        MyCEF.acapobr_func()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles SeparatoreRapido.Click
        MyCEF.separatorehr_func()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Bottone.Click
        MyCEF.bottonefun()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Collegamento.Click
        MyCEF.collegamentofun()
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Commento.Click
        MyCEF.commentofun()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Contenitore.Click
        MyCEF.contenitorefun()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Descrizione.Click
        MyCEF.descrizionefun()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Elenco.Click
        MyCEF.elencofun()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Immagine.Click
        MyCEF.immaginefun()
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Paragrafo.Click
        MyCEF.paragrafofun()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Separatore.Click
        MyCEF.separatorefun()
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Sottotitolo.Click
        MyCEF.sottotitolofun()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Tabella.Click
        MyCEF.tabellafun()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles TestoPersonalizzato.Click
        MyCEF.testopersonalizzatofun()
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Titolo.Click
        MyCEF.titolofun()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles CaratteriSpeciali.Click
        MyCEF.caratterispecialifun()
    End Sub
End Class