Public Class Cercaesostituisci

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub me_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub me_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub me_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub



    Private Sub Cercaesostituisci_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            TextBox1.Text = MinionOne.FastColoredTextBox1.Text.Replace((cerca.Text), (sostituisci.Text))
            MinionOne.FastColoredTextBox1.Text = (TextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub sostituisci_DoubleClick(sender As Object, e As EventArgs) Handles sostituisci.DoubleClick
        sostituisci.Text = ("")
    End Sub

    Private Sub sostituisci_KeyDown(sender As Object, e As KeyEventArgs) Handles sostituisci.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                TextBox1.Text = MinionOne.FastColoredTextBox1.Text.Replace((cerca.Text), (sostituisci.Text))
                MinionOne.FastColoredTextBox1.Text = (TextBox1.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub sostituisci_TextChanged(sender As Object, e As EventArgs) Handles sostituisci.TextChanged

    End Sub

    Private Sub cerca_DoubleClick(sender As Object, e As EventArgs) Handles cerca.DoubleClick
        cerca.Text = ("")
    End Sub

    Private Sub cerca_TextChanged(sender As Object, e As EventArgs) Handles cerca.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class