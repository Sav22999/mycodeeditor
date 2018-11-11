Public Class Ringraziamenti
    Private Sub MinionOneLinkRiconoscimenti_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRisorseCompleteRingraziamenti.LinkClicked
        Process.Start("https://" & "www.saveriomorelli.com/mycodeeditor/Riconoscimenti")
    End Sub
End Class