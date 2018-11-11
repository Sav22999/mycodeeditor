Public Class VisualizzaPanelMenu
    Private Sub VisualizzaPanelMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VisualizzaPanelMenu_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        MyCEF.VisualizzaButton.BackColor = Color.DarkRed
        MyCEF.VisualizzaButton.FlatAppearance.MouseOverBackColor = MyCEF.buttproghtml.FlatAppearance.MouseOverBackColor
        MyCEF.VisualizzaButton.FlatAppearance.MouseDownBackColor = Color.Red
        MyCEF.VisualizzaButton.ForeColor = Color.WhiteSmoke

        MyCEF.visualizza_menu = False

        If MyCEF.buttprogcss.BackColor = Color.Red Then
            MyCEF.CSSFTB.Select()
        Else
            MyCEF.FastColoredTextBox1.Select()
        End If
        Me.Close()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles ACapoAutomatico.Click
        MyCEF.acapoautomatico_func()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles ASchermoIntero.Click
        MyCEF.aschermointero_func()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles BarraInferiore.Click
        MyCEF.barrainferiore_func()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles FoglioHTMLeCSS.Click
        MyCEF.fogliocssehtml_func()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles AnteprimaProgetto.Click
        MyCEF.anteprimadelprogetto_func()
    End Sub
End Class