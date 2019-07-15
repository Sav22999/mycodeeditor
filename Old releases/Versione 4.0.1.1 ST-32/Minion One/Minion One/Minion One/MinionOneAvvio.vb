Public Class MinionOneAvvio

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Panel1.BackColor = Color.silver And Panel2.BackColor = Color.silver Then
            Panel1.BackColor = Color.dimgray
        ElseIf Panel1.BackColor = Color.dimgray And Panel2.BackColor = Color.silver Then
            Panel2.BackColor = Color.dimgray
        ElseIf Panel2.BackColor = Color.dimgray And Panel3.BackColor = Color.silver Then
            Panel3.BackColor = Color.dimgray
        ElseIf Panel3.BackColor = Color.dimgray And Panel4.BackColor = Color.silver Then
            Panel4.BackColor = Color.dimgray
        ElseIf Panel4.BackColor = Color.dimgray And Panel5.BackColor = Color.silver Then
            Panel5.BackColor = Color.dimgray
        ElseIf Panel5.BackColor = Color.dimgray And Panel6.BackColor = Color.silver Then
            Panel6.BackColor = Color.dimgray
        ElseIf Panel6.BackColor = Color.dimgray Then
            Timer2.Start()
            Panel6.BackColor = Color.silver
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Panel6.BackColor = Color.dimgray And Panel5.BackColor = Color.dimgray Then
            Panel6.BackColor = Color.silver
        ElseIf Panel6.BackColor = Color.silver And Panel5.BackColor = Color.dimgray Then
            Panel5.BackColor = Color.silver
        ElseIf Panel5.BackColor = Color.silver And Panel4.BackColor = Color.dimgray Then
            Panel4.BackColor = Color.silver
        ElseIf Panel4.BackColor = Color.silver And Panel3.BackColor = Color.dimgray Then
            Panel3.BackColor = Color.silver
        ElseIf Panel3.BackColor = Color.silver And Panel2.BackColor = Color.dimgray Then
            Panel2.BackColor = Color.silver
        ElseIf Panel2.BackColor = Color.silver And Panel1.BackColor = Color.dimgray Then
            Panel1.BackColor = Color.silver
        ElseIf Panel1.BackColor = Color.silver Then
            Timer1.Start()
            Panel1.BackColor = Color.dimgray
            Timer2.Stop()
        End If
    End Sub

    Private Sub MinionOneAvvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
