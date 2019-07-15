Public Class Immagine

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


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If linkimmagine.Text = ("") Then
        Else
            MinionOne.TESTOINCOLLATO.Paste()
            MinionOne.TESTODAINSERIRE.Text = ("<img" & " src=" & Chr(34) & linkimmagine.Text & Chr(34) & " width=" & Chr(34) & larghezza.Text & Chr(34) & " height=" & Chr(34) & altezza.Text & Chr(34) & " title=" & Chr(34) & title.Text & Chr(34) & " alt=" & Chr(34) & alt.Text & Chr(34) & " />")
            MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & Environment.NewLine)
            MinionOne.TESTODAINSERIRE.SelectAll()
            MinionOne.TESTODAINSERIRE.Copy()
            MinionOne.FastColoredTextBox1.Paste()
            MinionOne.TESTOINCOLLATO.SelectAll()
            MinionOne.TESTOINCOLLATO.Copy()
        End If
    End Sub

    Private Sub cerca_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles linkimmagine.DoubleClick
        
    End Sub

    Private Sub linkimmagine_DragLeave(sender As Object, e As EventArgs) Handles linkimmagine.DragLeave

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles linkimmagine.TextChanged
        Try
            PictureBox1.ImageLocation = (linkimmagine.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Immagine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        linkimmagine.SelectAll()
        linkimmagine.Paste()
    End Sub
End Class