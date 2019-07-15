Public Class SemplificaMi

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MinionOneSemplificaMiNo.Click
        MinionOneSemplificaMiSi.BackColor = Color.DarkRed
        MinionOneSemplificaMiNo.BackColor = Color.Red
        My.Settings.semplificami = ("no")
        My.Settings.Save()
    End Sub
    Private Sub ProgrammazioneProgettoBottone_Click(sender As Object, e As EventArgs) Handles MinionOneSemplificaMiSi.Click
        MinionOneSemplificaMiSi.BackColor = Color.Red
        MinionOneSemplificaMiNo.BackColor = Color.DarkRed
        My.Settings.semplificami = ("si")
        My.Settings.Save()
    End Sub

    Private Sub SemplificaMi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.semplificami = ("si") Then
            MinionOneSemplificaMiSi.BackColor = Color.Red
            MinionOneSemplificaMiNo.BackColor = Color.DarkRed
        Else
            MinionOneSemplificaMiSi.BackColor = Color.DarkRed
            MinionOneSemplificaMiNo.BackColor = Color.Red
        End If

        ListView1.Update()
        Dim li As ListViewItem
        li = (ListView1.Items.Add("n1.0"))
        li.SubItems.Add("n1.1")
        li.SubItems.Add("n1.2")

        ListView1.EndUpdate()
        ListView1.Refresh()
    End Sub
End Class