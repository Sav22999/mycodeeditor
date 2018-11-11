Public Class ContexMenu1
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Annulla.Click
        MyCEF.annulla_func()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Ripeti.Click
        MyCEF.ripeti_func()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Copia.Click
        MyCEF.copia_func()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Incolla.Click
        MyCEF.incolla_func()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Elimina.Click
        MyCEF.elimina_func()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Salva.Click
        MyCEF.salva_func()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Taglia.Click
        MyCEF.taglia_func()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles SalvaTutto.Click
        MyCEF.selezionatutto_func()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Apri.Click
        MyCEF.apri_func()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles RaggruppaRighe.Click
        MyCEF.raggrupparighe_func()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles VisualizzaAnteprima.Click
        MyCEF.anteprimadelprogetto_func()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Inserisci.Click
        ContexMenu1_Inserisci.Location = Me.Location
        ContexMenu1_Inserisci.Show()
        Me.Close()
    End Sub

    Private Sub CercaNelWeb_Click(sender As Object, e As EventArgs) Handles CercaNelWeb.Click
        ContexMenu1_CercaNelWeb.Location = Me.Location
        ContexMenu1_CercaNelWeb.Show()
        Me.Close()
    End Sub
End Class