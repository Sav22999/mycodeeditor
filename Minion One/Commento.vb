Public Class Commento

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If TextBox1.Text <> "" Then
            MyCEF.buttproghtml.BackColor = Color.Red
            MyCEF.buttprogcss.BackColor = Color.DarkRed
            MyCEF.AnteprimaWB.Visible = False
            MyCEF.ProgettazioneButtonR.BackColor = Color.DarkRed
            MyCEF.AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
            MyCEF.CSSFTB.Visible = False
            MyCEF.FastColoredTextBox1.Visible = True
            MyCEF.DagliAppunti.Paste()
            MyCEF.DaIncollare.Text = "<!----" & TextBox1.Text & "---->"
            MyCEF.DaIncollare.Text = MyCEF.DaIncollare.Text.Replace(vbNewLine, "---->" & vbNewLine & "<!----")
            MyCEF.DaIncollare.SelectAll()
            MyCEF.DaIncollare.Copy()
            MyCEF.FastColoredTextBox1.Paste()
            MyCEF.DaIncollare.Text = ""
            MyCEF.DagliAppunti.SelectAll()
            My.Computer.Clipboard.Clear()
            MyCEF.DagliAppunti.Copy()
            MyCEF.FastColoredTextBox1.Select()
            Me.Close()
        Else
            TextBox1.BackColor = Color.Red
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Commento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MyCEF.SelezionatoSalvatoDagliAppunti.Text <> "" Then
            TextBox1.Text = MyCEF.SelezionatoSalvatoDagliAppunti.Text
        Else
            TextBox1.Select()
        End If
        MyCEF.SelezionatoSalvatoDagliAppunti.SelectAll()
        MyCEF.SelezionatoSalvatoDagliAppunti.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/Commento/")
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox1.Select()
        TextBox1.Copy()
    End Sub

    Private Sub IncollaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncollaToolStripMenuItem.Click
        TextBox1.Select()
        TextBox1.Paste()
    End Sub
End Class