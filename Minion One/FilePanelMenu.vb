Public Class FilePanelMenu
    Private Sub FilePanelMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FilePanelMenu_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        MyCEF.chiudi_tutti_menu()

        MyCEF.FileButton.BackColor = Color.DarkRed
        MyCEF.FileButton.FlatAppearance.MouseOverBackColor = MyCEF.buttproghtml.FlatAppearance.MouseOverBackColor
        MyCEF.FileButton.FlatAppearance.MouseDownBackColor = Color.Red
        MyCEF.FileButton.ForeColor = Color.WhiteSmoke

        MyCEF.file_menu = False

        If MyCEF.buttprogcss.BackColor = Color.Red Then
            MyCEF.CSSFTB.Select()
        Else
            MyCEF.FastColoredTextBox1.Select()
        End If
        Me.Close()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Nuovo.Click
        MyCEF.nuovo_func()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Apri.Click
        MyCEF.apri_func()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Salva.Click
        MyCEF.salva_func()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles SalvaTutto.Click
        MyCEF.salvatutto_func()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Chiudi.Click
        MyCEF.chiudi_func()
    End Sub
End Class