Public Class MCEPanelMenu
    Private Sub MCEPanelMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MCEPanelMenu_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        MyCEF.MCEButton.BackColor = Color.DarkRed
        MyCEF.MCEButton.FlatAppearance.MouseOverBackColor = MyCEF.buttproghtml.FlatAppearance.MouseOverBackColor
        MyCEF.MCEButton.FlatAppearance.MouseDownBackColor = Color.Red
        MyCEF.MCEButton.ForeColor = Color.WhiteSmoke

        MyCEF.mce_menu = False

        If MyCEF.buttprogcss.BackColor = Color.Red Then
            MyCEF.CSSFTB.Select()
        Else
            MyCEF.FastColoredTextBox1.Select()
        End If
        Me.Close()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Informazioni.Click
        MyCEF.informazioni_func()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Impostazioni.Click
        MyCEF.impostazioni_func()
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles CheCeDiNuovo.Click
        MyCEF.checedinuovo_func()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Aiuto.Click
        MyCEF.aiuto_func()
    End Sub

    Private Sub Aggiornamenti_Click(sender As Object, e As EventArgs) Handles Aggiornamenti.Click
        MyCEF.controlloaggiornamenti_func()
    End Sub

    Private Sub Riconoscimenti_Click(sender As Object, e As EventArgs) Handles Riconoscimenti.Click
        MyCEF.riconoscimenti_func()
    End Sub
End Class