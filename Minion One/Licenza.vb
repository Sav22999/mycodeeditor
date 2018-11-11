Public Class Licenza

    Private Sub Licenza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox1.SelectAll()
        TextBox1.Copy()
    End Sub
End Class