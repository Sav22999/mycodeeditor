Public Class AnteprimaDiStampa

    Private Sub STAMPAprop_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles STAMPAprop.PrintPage
        e.Graphics.DrawString("-- Realizzato con Minion One by MixiM (versione 3) --", MinionOne.TextBox1.Font, Brushes.DimGray, 150, 40)
        e.Graphics.DrawString(MinionOne.FastColoredTextBox1.Text, MinionOne.FastColoredTextBox1.Font, Brushes.Black, 50, 60)
    End Sub

    Private Sub MinionOneButton_Click(sender As Object, e As EventArgs) Handles MinionOneButton.Click
        Me.Close()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        PrintPreviewControl1.Zoom = (TrackBar1.Value / 100)
        Label1.Text = (TrackBar1.Value & "%")
    End Sub

    Private Sub AnteprimaDiStampa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewControl1.Zoom = (TrackBar1.Value / 100)
        Label1.Text = (TrackBar1.Value & "%")
    End Sub

    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs) Handles PrintPreviewControl1.Click
        PrintPreviewControl1.BackColor = Color.Black
        AutoSize = True
        AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
    End Sub
End Class