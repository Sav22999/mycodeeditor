Public Class ModificaPanelMenu
    Private Sub ModificaPanelMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ModificaPanelMenu_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        MyCEF.ModificaButton.BackColor = Color.DarkRed
        MyCEF.ModificaButton.FlatAppearance.MouseOverBackColor = MyCEF.buttproghtml.FlatAppearance.MouseOverBackColor
        MyCEF.ModificaButton.FlatAppearance.MouseDownBackColor = Color.Red
        MyCEF.ModificaButton.ForeColor = Color.WhiteSmoke

        MyCEF.modifica_menu = False

        If MyCEF.buttprogcss.BackColor = Color.Red Then
            MyCEF.CSSFTB.Select()
        Else
            MyCEF.FastColoredTextBox1.Select()
        End If
        Me.Close()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Annulla.Click
        MyCEF.annulla_func()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Ripeti.Click
        MyCEF.ripeti_func()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Taglia.Click
        MyCEF.taglia_func()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Copia.Click
        MyCEF.copia_func()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Incolla.Click
        MyCEF.incolla_func()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Elimina.Click
        MyCEF.elimina_func()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles SelezionaTutto.Click
        MyCEF.selezionatutto_func()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles CercaESostituisci.Click
        MyCEF.cercaesostituisci_func()
    End Sub
End Class