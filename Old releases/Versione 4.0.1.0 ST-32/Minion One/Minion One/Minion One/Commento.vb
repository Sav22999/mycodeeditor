Public Class Commento

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If TextBox1.Text <> "" Then
            MinionOneF.buttprogling.BackColor = Color.Red
            MinionOneF.buttprogcss.BackColor = Color.DarkRed
            MinionOneF.AnteprimaWB.Visible = False
            MinionOneF.ProgettazioneButtonR.BackColor = Color.DarkRed
            MinionOneF.AnteprimaButtonR.BackColor = Color.DimGray
            MinionOneF.CSSFTB.Visible = False
            MinionOneF.FastColoredTextBox1.Visible = True
            MinionOneF.DagliAppunti.Paste()
            MinionOneF.DaIncollare.Text = "<!----" & TextBox1.Text & "---->"
            MinionOneF.DaIncollare.Text = MinionOneF.DaIncollare.Text.Replace(vbNewLine, "---->" & vbNewLine & "<!----")
            MinionOneF.DaIncollare.SelectAll()
            MinionOneF.DaIncollare.Copy()
            MinionOneF.FastColoredTextBox1.Paste()
            MinionOneF.DaIncollare.Text = ""
            MinionOneF.DagliAppunti.SelectAll()
            My.Computer.Clipboard.Clear()
            MinionOneF.DagliAppunti.Copy()
            MinionOneF.FastColoredTextBox1.Select()
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
        If MinionOneF.SelezionatoSalvatoDagliAppunti.Text <> "" Then
            TextBox1.Text = MinionOneF.SelezionatoSalvatoDagliAppunti.Text
        Else
            TextBox1.Select()
        End If
        MinionOneF.SelezionatoSalvatoDagliAppunti.SelectAll()
        MinionOneF.SelezionatoSalvatoDagliAppunti.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/Commento/")
    End Sub
End Class