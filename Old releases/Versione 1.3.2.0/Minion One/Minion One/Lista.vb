Public Class Lista
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

    Private Sub Lista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ul_Click(sender As Object, e As EventArgs) Handles ul.Click
        ol.BackColor = Color.Navy
        ul.BackColor = Color.Blue
        tipolista.Text = ("ul")
    End Sub

    Private Sub ol_Click(sender As Object, e As EventArgs) Handles ol.Click
        ul.BackColor = Color.Navy
        ol.BackColor = Color.Blue
        tipolista.Text = ("ol")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If Button31.BackColor = Color.Blue Then
            Button31.BackColor = Color.Navy
            grassetto.Text = ("Bno")
        Else
            Button31.BackColor = Color.Blue
            grassetto.Text = ("Bsi")
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If Button32.BackColor = Color.Blue Then
            Button32.BackColor = Color.Navy
            corsivo.Text = ("Ino")
        Else
            Button32.BackColor = Color.Blue
            corsivo.Text = ("Isi")
        End If
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If Button33.BackColor = Color.Blue Then
            Button33.BackColor = Color.Navy
            sottolineato.Text = ("Uno")
        Else
            Button33.BackColor = Color.Blue
            sottolineato.Text = ("Usi")
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If Button34.BackColor = Color.Blue Then
            Button34.BackColor = Color.Navy
            sbarrato.Text = ("Sno")
        Else
            Button34.BackColor = Color.Blue
            sbarrato.Text = ("Ssi")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = ("") Then
        Else
            MinionOne.TESTOINCOLLATO.Paste()
            MinionOne.TESTODAINSERIRE.Text = ("<" & tipolista.Text & ">" & Environment.NewLine & "<li>" & TextBox1.Text.Replace(Environment.NewLine, "</li>" & Environment.NewLine & "<li>") & "</li>" & Environment.NewLine & "</" & tipolista.Text & ">")
            If grassetto.Text = ("Bsi") Then
                MinionOne.TESTODAINSERIRE.Text = ("<b>" & MinionOne.TESTODAINSERIRE.Text & "</b>")
            Else
            End If
            If corsivo.Text = ("Isi") Then
                MinionOne.TESTODAINSERIRE.Text = ("<i>" & MinionOne.TESTODAINSERIRE.Text & "</i>")
            Else
            End If
            If sottolineato.Text = ("Usi") Then
                MinionOne.TESTODAINSERIRE.Text = ("<u>" & MinionOne.TESTODAINSERIRE.Text & "</u>")
            Else
            End If
            If sbarrato.Text = ("Ssi") Then
                MinionOne.TESTODAINSERIRE.Text = ("<s>" & MinionOne.TESTODAINSERIRE.Text & "</s>")
            Else
            End If
            MinionOne.TESTODAINSERIRE.Text = (MinionOne.TESTODAINSERIRE.Text & Environment.NewLine)
            MinionOne.TESTODAINSERIRE.SelectAll()
            MinionOne.TESTODAINSERIRE.Copy()
            MinionOne.FastColoredTextBox1.Paste()
            MinionOne.TESTOINCOLLATO.SelectAll()
            MinionOne.TESTOINCOLLATO.Copy()
        End If
    End Sub
End Class