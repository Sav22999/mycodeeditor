Public Class Impostazioni
    Private Sub Impostazioni_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If AvanzateRadio2.Checked = True Then
            If Dir(TextBox1.Text) <> "" Then
                AvanzateTxt0.Text = (TextBox1.Text)
            Else
                AvanzateRadio0.Checked = True
                AvanzateRadio2.Checked = False
                TextBox1.Enabled = False
                Button10.Enabled = False
                AvanzateTxt0.Text = ("WBI")
                MessaggioF.Text = ("File inesistente")
                MessaggioF.Button1.Text = ("Il file selezionato come web browser personalizzato è inesistente, per favore, provare con uno valido.")
                MessaggioF.ShowDialog()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GeneraleCheck1.CheckedChanged
        If GeneraleCheck1.CheckState = CheckState.Checked Then
            GeneraleTxt1.Text = "SI"
        Else
            GeneraleTxt1.Text = "NO"
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = "SCARICA GLI AGGIORNAMENTI - [[" & GeneraleTxt1.Text & "]]"
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        If GeneraleCheck0.Checked = True Then
            GeneraleCheck0.Checked = False
            GeneraleCheck1.Enabled = False
            GeneraleCheck1.Checked = False
        Else
            GeneraleCheck0.Checked = True
            GeneraleCheck1.Enabled = True
            GeneraleCheck1.Checked = False
        End If
    End Sub

    Private Sub AutoSaveButton_Click(sender As Object, e As EventArgs) Handles AutoSaveButton.Click
        GeneraleButton.BackColor = Color.DarkRed
        AutoSaveButton.BackColor = Color.DimGray
        InterfacciaButton.BackColor = Color.DarkRed
        PrivacyButton.BackColor = Color.DarkRed
        AvanzateButton.BackColor = Color.DarkRed

        GeneralePanel.Visible = False
        AutoSavePanel.Visible = True
        InterfacciaPanel.Visible = False
        PrivacyPanel.Visible = False
        AvanzatePanel.Visible = False
    End Sub

    Private Sub GeneraleButton_Click(sender As Object, e As EventArgs) Handles GeneraleButton.Click
        GeneraleButton.BackColor = Color.DimGray
        AutoSaveButton.BackColor = Color.DarkRed
        InterfacciaButton.BackColor = Color.DarkRed
        PrivacyButton.BackColor = Color.DarkRed
        AvanzateButton.BackColor = Color.DarkRed

        GeneralePanel.Visible = True
        AutoSavePanel.Visible = False
        InterfacciaPanel.Visible = False
        PrivacyPanel.Visible = False
        AvanzatePanel.Visible = False
    End Sub

    Private Sub InterfacciaButton_Click(sender As Object, e As EventArgs) Handles InterfacciaButton.Click
        GeneraleButton.BackColor = Color.DarkRed
        AutoSaveButton.BackColor = Color.DarkRed
        InterfacciaButton.BackColor = Color.DimGray
        PrivacyButton.BackColor = Color.DarkRed
        AvanzateButton.BackColor = Color.DarkRed

        GeneralePanel.Visible = False
        AutoSavePanel.Visible = False
        InterfacciaPanel.Visible = True
        PrivacyPanel.Visible = False
        AvanzatePanel.Visible = False
    End Sub

    Private Sub PrivacyButton_Click(sender As Object, e As EventArgs) Handles PrivacyButton.Click
        GeneraleButton.BackColor = Color.DarkRed
        AutoSaveButton.BackColor = Color.DarkRed
        InterfacciaButton.BackColor = Color.DarkRed
        PrivacyButton.BackColor = Color.DimGray
        AvanzateButton.BackColor = Color.DarkRed

        GeneralePanel.Visible = False
        AutoSavePanel.Visible = False
        InterfacciaPanel.Visible = False
        PrivacyPanel.Visible = True
        AvanzatePanel.Visible = False
    End Sub

    Private Sub AvanzateButton_Click(sender As Object, e As EventArgs) Handles AvanzateButton.Click
        GeneraleButton.BackColor = Color.DarkRed
        AutoSaveButton.BackColor = Color.DarkRed
        InterfacciaButton.BackColor = Color.DarkRed
        PrivacyButton.BackColor = Color.DarkRed
        AvanzateButton.BackColor = Color.DimGray

        GeneralePanel.Visible = False
        AutoSavePanel.Visible = False
        InterfacciaPanel.Visible = False
        PrivacyPanel.Visible = False
        AvanzatePanel.Visible = True
    End Sub

    Private Sub AggCheck_CheckedChanged(sender As Object, e As EventArgs) Handles GeneraleCheck0.CheckedChanged
        If GeneraleCheck0.CheckState = CheckState.Checked Then
            GeneraleTxt0.Text = "SI"
            GeneraleCheck1.Enabled = True
        Else
            GeneraleTxt0.Text = "NO"
            GeneraleCheck1.Enabled = False
            GeneraleCheck1.CheckState = CheckState.Unchecked
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = "CONTROLLA GLI AGGIORNAMENTI AUTOMATICAMENTE - [[" & GeneraleTxt0.Text & "]]"
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles GeneraleCheck2.CheckedChanged
        If GeneraleCheck2.CheckState = CheckState.Checked Then
            GeneraleTxt2.Text = "SI"
            MinionOneF.Button36.Image = My.Resources.si
            MinionOneF.FastColoredTextBox1.WordWrap = True
            MinionOneF.CSSFTB.WordWrap = True
        Else
            GeneraleTxt2.Text = "NO"
            MinionOneF.Button36.Image = My.Resources.no
            MinionOneF.FastColoredTextBox1.WordWrap = False
            MinionOneF.CSSFTB.WordWrap = False
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = ("VISUALIZZA IL TESTO A CAPO AUTOMATICAMENTE - [[" & GeneraleTxt2.Text & "]]")
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles GeneraleCheck3.CheckedChanged
        If GeneraleCheck3.CheckState = CheckState.Checked Then
            GeneraleTxt3.Text = "SI"
        Else
            GeneraleTxt3.Text = "NO"
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = ("VISUALIZZA SUGGERIMENTI W3SHOOLS - [[" & GeneraleTxt3.Text & "]]")
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles GeneraleCheck4.CheckedChanged
        If GeneraleCheck4.CheckState = CheckState.Checked Then
            GeneraleTxt4.Text = "SI"
        Else
            GeneraleTxt4.Text = "NO"
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = ("INSERISCI <BR/> QUANDO SI PREME SHIFT+ENTER - [[" & GeneraleTxt4.Text & "]]")
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles GeneraleCheck5.CheckedChanged
        If GeneraleCheck5.CheckState = CheckState.Checked Then
            GeneraleTxt5.Text = "SI"
        Else
            GeneraleTxt5.Text = "NO"
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = ("INSERISCI <HR/> QUANDO SI PREME CTRL+ENTER - [[" & GeneraleTxt5.Text & "]]")
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub HTML1m_Click(sender As Object, e As EventArgs) Handles HTML1m.Click
        HTML1m.BackColor = Color.DimGray
        HTML5m.BackColor = Color.DimGray
        HTML10m.BackColor = Color.DimGray
        HTML30m.BackColor = Color.DimGray
        HTML1h.BackColor = Color.DimGray
        HTML2h.BackColor = Color.DimGray
        HTMLPersonalizzato.BackColor = Color.DimGray

        HTML1m.BackColor = Color.DarkRed
        AutoSaveTxtHTML.Text = "60000"
        MinionOneF.HTMLTimerAutoSave.Stop()
        MinionOneF.HTMLTimerAutoSave.Interval = (AutoSaveTxtHTML.Text)
        MinionOneF.HTMLTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = ("SALVA IL FILE HTML OGNI - [[" & AutoSaveTxtHTML.Text & "]]")
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub HTML5m_Click(sender As Object, e As EventArgs) Handles HTML5m.Click
        HTML1m.BackColor = Color.DimGray
        HTML5m.BackColor = Color.DimGray
        HTML10m.BackColor = Color.DimGray
        HTML30m.BackColor = Color.DimGray
        HTML1h.BackColor = Color.DimGray
        HTML2h.BackColor = Color.DimGray
        HTMLPersonalizzato.BackColor = Color.DimGray

        HTML5m.BackColor = Color.DarkRed
        AutoSaveTxtHTML.Text = "300000"
        MinionOneF.HTMLTimerAutoSave.Stop()
        MinionOneF.HTMLTimerAutoSave.Interval = (AutoSaveTxtHTML.Text)
        MinionOneF.HTMLTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = ("SALVA IL FILE HTML OGNI - [[" & AutoSaveTxtHTML.Text & "]]")
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub HTML10m_Click(sender As Object, e As EventArgs) Handles HTML10m.Click
        HTML1m.BackColor = Color.DimGray
        HTML5m.BackColor = Color.DimGray
        HTML10m.BackColor = Color.DimGray
        HTML30m.BackColor = Color.DimGray
        HTML1h.BackColor = Color.DimGray
        HTML2h.BackColor = Color.DimGray
        HTMLPersonalizzato.BackColor = Color.DimGray

        HTML10m.BackColor = Color.DarkRed
        AutoSaveTxtHTML.Text = "600000"
        MinionOneF.HTMLTimerAutoSave.Stop()
        MinionOneF.HTMLTimerAutoSave.Interval = (AutoSaveTxtHTML.Text)
        MinionOneF.HTMLTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = ("SALVA IL FILE HTML OGNI - [[" & AutoSaveTxtHTML.Text & "]]")
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub HTML30m_Click(sender As Object, e As EventArgs) Handles HTML30m.Click
        HTML1m.BackColor = Color.DimGray
        HTML5m.BackColor = Color.DimGray
        HTML10m.BackColor = Color.DimGray
        HTML30m.BackColor = Color.DimGray
        HTML1h.BackColor = Color.DimGray
        HTML2h.BackColor = Color.DimGray
        HTMLPersonalizzato.BackColor = Color.DimGray

        HTML30m.BackColor = Color.DarkRed
        AutoSaveTxtHTML.Text = "1800000"
        MinionOneF.HTMLTimerAutoSave.Stop()
        MinionOneF.HTMLTimerAutoSave.Interval = (AutoSaveTxtHTML.Text)
        MinionOneF.HTMLTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = ("SALVA IL FILE HTML OGNI - [[" & AutoSaveTxtHTML.Text & "]]")
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub HTML1h_Click(sender As Object, e As EventArgs) Handles HTML1h.Click
        HTML1m.BackColor = Color.DimGray
        HTML5m.BackColor = Color.DimGray
        HTML10m.BackColor = Color.DimGray
        HTML30m.BackColor = Color.DimGray
        HTML1h.BackColor = Color.DimGray
        HTML2h.BackColor = Color.DimGray
        HTMLPersonalizzato.BackColor = Color.DimGray

        HTML1h.BackColor = Color.DarkRed
        AutoSaveTxtHTML.Text = "3600000"
        MinionOneF.HTMLTimerAutoSave.Stop()
        MinionOneF.HTMLTimerAutoSave.Interval = (AutoSaveTxtHTML.Text)
        MinionOneF.HTMLTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = ("SALVA IL FILE HTML OGNI - [[" & AutoSaveTxtHTML.Text & "]]")
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub HTML2h_Click(sender As Object, e As EventArgs) Handles HTML2h.Click
        HTML1m.BackColor = Color.DimGray
        HTML5m.BackColor = Color.DimGray
        HTML10m.BackColor = Color.DimGray
        HTML30m.BackColor = Color.DimGray
        HTML1h.BackColor = Color.DimGray
        HTML2h.BackColor = Color.DimGray
        HTMLPersonalizzato.BackColor = Color.DimGray

        HTML2h.BackColor = Color.DarkRed
        AutoSaveTxtHTML.Text = "7200000"
        MinionOneF.HTMLTimerAutoSave.Stop()
        MinionOneF.HTMLTimerAutoSave.Interval = (AutoSaveTxtHTML.Text)
        MinionOneF.HTMLTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = ("SALVA IL FILE HTML OGNI - [[" & AutoSaveTxtHTML.Text & "]]")
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub HTMLPersonalizzato_Click(sender As Object, e As EventArgs) Handles HTMLPersonalizzato.Click
        If HTMLPanelPersonalizzato.Visible = False Then
            HTML1m.BackColor = Color.DimGray
            HTML5m.BackColor = Color.DimGray
            HTML10m.BackColor = Color.DimGray
            HTML30m.BackColor = Color.DimGray
            HTML1h.BackColor = Color.DimGray
            HTML2h.BackColor = Color.DimGray
            HTMLPersonalizzato.BackColor = Color.DimGray

            HTMLPersonalizzato.BackColor = Color.DarkRed
            HTMLPersonalizzato.FlatAppearance.MouseDownBackColor = Color.DarkRed
            HTMLPersonalizzato.FlatAppearance.MouseOverBackColor = Color.DarkRed
            HTMLPanelPersonalizzato.Visible = True
            HTML1m.Enabled = False
            HTML5m.Enabled = False
            HTML10m.Enabled = False
            HTML30m.Enabled = False
            HTML1h.Enabled = False
            HTML2h.Enabled = False
            If HTMLComboBox.Text = "" Then
                HTMLComboBox.Text = ("m")
            End If
        End If
    End Sub

    Private Sub CSS1m_Click(sender As Object, e As EventArgs) Handles CSS1m.Click
        CSS1m.BackColor = Color.DimGray
        CSS5m.BackColor = Color.DimGray
        CSS10m.BackColor = Color.DimGray
        CSS30m.BackColor = Color.DimGray
        CSS1h.BackColor = Color.DimGray
        CSS2h.BackColor = Color.DimGray
        CSSPersonalizzato.BackColor = Color.DimGray

        CSS1m.BackColor = Color.DarkRed
        AutoSaveTxtCSS.Text = "60000"
        MinionOneF.CSSTimerAutoSave.Stop()
        MinionOneF.CSSTimerAutoSave.Interval = (AutoSaveTxtCSS.Text)
        MinionOneF.CSSTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = ("SALVA IL FILE CSS OGNI - [[" & AutoSaveTxtCSS.Text & "]]")
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CSS5m_Click(sender As Object, e As EventArgs) Handles CSS5m.Click
        CSS1m.BackColor = Color.DimGray
        CSS5m.BackColor = Color.DimGray
        CSS10m.BackColor = Color.DimGray
        CSS30m.BackColor = Color.DimGray
        CSS1h.BackColor = Color.DimGray
        CSS2h.BackColor = Color.DimGray
        CSSPersonalizzato.BackColor = Color.DimGray

        CSS5m.BackColor = Color.DarkRed
        AutoSaveTxtCSS.Text = "300000"
        MinionOneF.CSSTimerAutoSave.Stop()
        MinionOneF.CSSTimerAutoSave.Interval = (AutoSaveTxtCSS.Text)
        MinionOneF.CSSTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = ("SALVA IL FILE CSS OGNI - [[" & AutoSaveTxtCSS.Text & "]]")
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CSS10m_Click(sender As Object, e As EventArgs) Handles CSS10m.Click
        CSS1m.BackColor = Color.DimGray
        CSS5m.BackColor = Color.DimGray
        CSS10m.BackColor = Color.DimGray
        CSS30m.BackColor = Color.DimGray
        CSS1h.BackColor = Color.DimGray
        CSS2h.BackColor = Color.DimGray
        CSSPersonalizzato.BackColor = Color.DimGray

        CSS10m.BackColor = Color.DarkRed
        AutoSaveTxtCSS.Text = "600000"
        MinionOneF.CSSTimerAutoSave.Stop()
        MinionOneF.CSSTimerAutoSave.Interval = (AutoSaveTxtCSS.Text)
        MinionOneF.CSSTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = ("SALVA IL FILE CSS OGNI - [[" & AutoSaveTxtCSS.Text & "]]")
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CSS30m_Click(sender As Object, e As EventArgs) Handles CSS30m.Click
        CSS1m.BackColor = Color.DimGray
        CSS5m.BackColor = Color.DimGray
        CSS10m.BackColor = Color.DimGray
        CSS30m.BackColor = Color.DimGray
        CSS1h.BackColor = Color.DimGray
        CSS2h.BackColor = Color.DimGray
        CSSPersonalizzato.BackColor = Color.DimGray

        CSS30m.BackColor = Color.DarkRed
        AutoSaveTxtCSS.Text = "1800000"
        MinionOneF.CSSTimerAutoSave.Stop()
        MinionOneF.CSSTimerAutoSave.Interval = (AutoSaveTxtCSS.Text)
        MinionOneF.CSSTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = ("SALVA IL FILE CSS OGNI - [[" & AutoSaveTxtCSS.Text & "]]")
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CSS1h_Click(sender As Object, e As EventArgs) Handles CSS1h.Click
        CSS1m.BackColor = Color.DimGray
        CSS5m.BackColor = Color.DimGray
        CSS10m.BackColor = Color.DimGray
        CSS30m.BackColor = Color.DimGray
        CSS1h.BackColor = Color.DimGray
        CSS2h.BackColor = Color.DimGray
        CSSPersonalizzato.BackColor = Color.DimGray

        CSS1h.BackColor = Color.DarkRed
        AutoSaveTxtCSS.Text = "3600000"
        MinionOneF.CSSTimerAutoSave.Stop()
        MinionOneF.CSSTimerAutoSave.Interval = (AutoSaveTxtCSS.Text)
        MinionOneF.CSSTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = ("SALVA IL FILE CSS OGNI - [[" & AutoSaveTxtCSS.Text & "]]")
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CSS2h_Click(sender As Object, e As EventArgs) Handles CSS2h.Click
        CSS1m.BackColor = Color.DimGray
        CSS5m.BackColor = Color.DimGray
        CSS10m.BackColor = Color.DimGray
        CSS30m.BackColor = Color.DimGray
        CSS1h.BackColor = Color.DimGray
        CSS2h.BackColor = Color.DimGray
        CSSPersonalizzato.BackColor = Color.DimGray

        CSS2h.BackColor = Color.DarkRed
        AutoSaveTxtCSS.Text = "7200000"
        MinionOneF.CSSTimerAutoSave.Stop()
        MinionOneF.CSSTimerAutoSave.Interval = (AutoSaveTxtCSS.Text)
        MinionOneF.CSSTimerAutoSave.Stop()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = ("SALVA IL FILE CSS OGNI - [[" & AutoSaveTxtCSS.Text & "]]")
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CSSPersonalizzato_Click(sender As Object, e As EventArgs) Handles CSSPersonalizzato.Click
        If CSSPanelPersonalizzato.Visible = False Then
            CSS1m.BackColor = Color.DimGray
            CSS5m.BackColor = Color.DimGray
            CSS10m.BackColor = Color.DimGray
            CSS30m.BackColor = Color.DimGray
            CSS1h.BackColor = Color.DimGray
            CSS2h.BackColor = Color.DimGray
            CSSPersonalizzato.BackColor = Color.DimGray

            CSSPersonalizzato.BackColor = Color.DarkRed
            CSSPersonalizzato.FlatAppearance.MouseDownBackColor = Color.DarkRed
            CSSPersonalizzato.FlatAppearance.MouseOverBackColor = Color.DarkRed
            CSSPanelPersonalizzato.Visible = True
            CSS1m.Enabled = False
            CSS5m.Enabled = False
            CSS10m.Enabled = False
            CSS30m.Enabled = False
            CSS1h.Enabled = False
            CSS2h.Enabled = False
            If CSSComboBox.Text = "" Then
                CSSComboBox.Text = ("m")
            End If
        End If
    End Sub

    Private Sub HTMLPersonalizzaOkButton_Click(sender As Object, e As EventArgs) Handles HTMLPersonalizzaOkButton.Click
        If HTMLTextBox.Text.Replace(" ", "") <> ("") And HTMLComboBox.Text <> ("") And HTMLTextBox.Text > 0 Then
            HTML1m.BackColor = Color.DimGray
            HTML5m.BackColor = Color.DimGray
            HTML10m.BackColor = Color.DimGray
            HTML30m.BackColor = Color.DimGray
            HTML1h.BackColor = Color.DimGray
            HTML2h.BackColor = Color.DimGray
            HTMLPersonalizzato.BackColor = Color.DimGray

            HTMLPersonalizzato.BackColor = Color.DarkRed
            HTMLPersonalizzato.FlatAppearance.MouseDownBackColor = HTML1m.FlatAppearance.MouseDownBackColor
            HTMLPersonalizzato.FlatAppearance.MouseOverBackColor = HTML1m.FlatAppearance.MouseOverBackColor
            HTMLPanelPersonalizzato.Visible = False
            HTML1m.Enabled = True
            HTML5m.Enabled = True
            HTML10m.Enabled = True
            HTML30m.Enabled = True
            HTML1h.Enabled = True
            HTML2h.Enabled = True
            HTMLTextBox.Text = HTMLTextBox.Text.Replace(".", ",")
            HTMLTextBox.Text = HTMLTextBox.Text.Replace(" ", "")
            HTMLTextBox.Text = HTMLTextBox.Text.Replace("-", "")
            HTMLTextBox.Text = HTMLTextBox.Text.Replace("+", "")
            If HTMLTextBox.Text < 0 Then
                HTMLTextBox.Text = 1
            End If
            If HTMLComboBox.Text = ("s") Then
                AutoSaveTxtHTML.Text = HTMLTextBox.Text * 1000
            ElseIf HTMLComboBox.Text = ("m") Then
                AutoSaveTxtHTML.Text = HTMLTextBox.Text * 60000
            ElseIf HTMLComboBox.Text = ("h") Then
                If HTMLTextBox.Text > 99 Then
                    HTMLTextBox.Text = 99
                End If
                AutoSaveTxtHTML.Text = HTMLTextBox.Text * 3600000
            End If
            MinionOneF.HTMLTimerAutoSave.Stop()
            Dim intervallotimer As New Integer
            intervallotimer = Convert.ToInt32(AutoSaveTxtHTML.Text)
            MinionOneF.HTMLTimerAutoSave.Interval = (intervallotimer)
            MinionOneF.HTMLTimerAutoSave.Start()
            If AutoSaveTxtHTML.Text = ("60000") Then
                HTML1m.BackColor = Color.DimGray
                HTML5m.BackColor = Color.DimGray
                HTML10m.BackColor = Color.DimGray
                HTML30m.BackColor = Color.DimGray
                HTML1h.BackColor = Color.DimGray
                HTML2h.BackColor = Color.DimGray
                HTMLPersonalizzato.BackColor = Color.DimGray

                HTML1m.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtHTML.Text = ("300000") Then
                HTML1m.BackColor = Color.DimGray
                HTML5m.BackColor = Color.DimGray
                HTML10m.BackColor = Color.DimGray
                HTML30m.BackColor = Color.DimGray
                HTML1h.BackColor = Color.DimGray
                HTML2h.BackColor = Color.DimGray
                HTMLPersonalizzato.BackColor = Color.DimGray

                HTML5m.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtHTML.Text = ("600000") Then
                HTML1m.BackColor = Color.DimGray
                HTML5m.BackColor = Color.DimGray
                HTML10m.BackColor = Color.DimGray
                HTML30m.BackColor = Color.DimGray
                HTML1h.BackColor = Color.DimGray
                HTML2h.BackColor = Color.DimGray
                HTMLPersonalizzato.BackColor = Color.DimGray

                HTML10m.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtHTML.Text = ("1800000") Then
                HTML1m.BackColor = Color.DimGray
                HTML5m.BackColor = Color.DimGray
                HTML10m.BackColor = Color.DimGray
                HTML30m.BackColor = Color.DimGray
                HTML1h.BackColor = Color.DimGray
                HTML2h.BackColor = Color.DimGray
                HTMLPersonalizzato.BackColor = Color.DimGray

                HTML30m.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtHTML.Text = ("3600000") Then
                HTML1m.BackColor = Color.DimGray
                HTML5m.BackColor = Color.DimGray
                HTML10m.BackColor = Color.DimGray
                HTML30m.BackColor = Color.DimGray
                HTML1h.BackColor = Color.DimGray
                HTML2h.BackColor = Color.DimGray
                HTMLPersonalizzato.BackColor = Color.DimGray

                HTML1h.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtHTML.Text = ("7200000") Then
                HTML1m.BackColor = Color.DimGray
                HTML5m.BackColor = Color.DimGray
                HTML10m.BackColor = Color.DimGray
                HTML30m.BackColor = Color.DimGray
                HTML1h.BackColor = Color.DimGray
                HTML2h.BackColor = Color.DimGray
                HTMLPersonalizzato.BackColor = Color.DimGray

                HTML2h.BackColor = Color.DarkRed
            End If
        ElseIf HTMLTextBox.Text = ("") Or HTMLTextBox.Text.Replace(" ", "") = ("") Then
            HTMLTextBox.BackColor = Color.Red
        ElseIf HTMLComboBox.Text = ("") Then
            HTMLComboBox.BackColor = Color.Red
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = ("SALVA IL FILE HTML OGNI - [[" & AutoSaveTxtHTML.Text & "]]")
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub CSSPersonalizzaOkButton_Click(sender As Object, e As EventArgs) Handles CSSPersonalizzaOkButton.Click
        If CSSTextBox.Text.Replace(" ", "") <> ("") And CSSComboBox.Text <> ("") And CSSTextBox.Text > 0 Then
            CSS1m.BackColor = Color.DimGray
            CSS5m.BackColor = Color.DimGray
            CSS10m.BackColor = Color.DimGray
            CSS30m.BackColor = Color.DimGray
            CSS1h.BackColor = Color.DimGray
            CSS2h.BackColor = Color.DimGray
            CSSPersonalizzato.BackColor = Color.DimGray

            CSSPersonalizzato.BackColor = Color.DarkRed
            CSSPersonalizzato.FlatAppearance.MouseDownBackColor = CSS1m.FlatAppearance.MouseDownBackColor
            CSSPersonalizzato.FlatAppearance.MouseOverBackColor = CSS1m.FlatAppearance.MouseOverBackColor
            CSSPanelPersonalizzato.Visible = False
            CSS1m.Enabled = True
            CSS5m.Enabled = True
            CSS10m.Enabled = True
            CSS30m.Enabled = True
            CSS1h.Enabled = True
            CSS2h.Enabled = True
            CSSTextBox.Text = CSSTextBox.Text.Replace(".", ",")
            CSSTextBox.Text = CSSTextBox.Text.Replace(" ", "")
            CSSTextBox.Text = CSSTextBox.Text.Replace("-", "")
            CSSTextBox.Text = CSSTextBox.Text.Replace("+", "")
            If CSSTextBox.Text < 0 Then
                CSSTextBox.Text = 1
            End If
            If CSSComboBox.Text = ("s") Then
                AutoSaveTxtCSS.Text = CSSTextBox.Text * 1000
            ElseIf CSSComboBox.Text = ("m") Then
                AutoSaveTxtCSS.Text = CSSTextBox.Text * 60000
            ElseIf CSSComboBox.Text = ("h") Then
                If CSSTextBox.Text > 99 Then
                    CSSTextBox.Text = 99
                End If
                AutoSaveTxtCSS.Text = CSSTextBox.Text * 3600000
            End If
            MinionOneF.CSSTimerAutoSave.Stop()
            Dim intervallotimer As New Integer
            intervallotimer = Convert.ToInt32(AutoSaveTxtCSS.Text)
            MinionOneF.CSSTimerAutoSave.Interval = (intervallotimer)
            MinionOneF.CSSTimerAutoSave.Start()
            If AutoSaveTxtCSS.Text = ("60000") Then
                CSS1m.BackColor = Color.DimGray
                CSS5m.BackColor = Color.DimGray
                CSS10m.BackColor = Color.DimGray
                CSS30m.BackColor = Color.DimGray
                CSS1h.BackColor = Color.DimGray
                CSS2h.BackColor = Color.DimGray
                CSSPersonalizzato.BackColor = Color.DimGray

                CSS1m.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtCSS.Text = ("300000") Then
                CSS1m.BackColor = Color.DimGray
                CSS5m.BackColor = Color.DimGray
                CSS10m.BackColor = Color.DimGray
                CSS30m.BackColor = Color.DimGray
                CSS1h.BackColor = Color.DimGray
                CSS2h.BackColor = Color.DimGray
                CSSPersonalizzato.BackColor = Color.DimGray

                CSS5m.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtCSS.Text = ("600000") Then
                CSS1m.BackColor = Color.DimGray
                CSS5m.BackColor = Color.DimGray
                CSS10m.BackColor = Color.DimGray
                CSS30m.BackColor = Color.DimGray
                CSS1h.BackColor = Color.DimGray
                CSS2h.BackColor = Color.DimGray
                CSSPersonalizzato.BackColor = Color.DimGray

                CSS10m.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtCSS.Text = ("1800000") Then
                CSS1m.BackColor = Color.DimGray
                CSS5m.BackColor = Color.DimGray
                CSS10m.BackColor = Color.DimGray
                CSS30m.BackColor = Color.DimGray
                CSS1h.BackColor = Color.DimGray
                CSS2h.BackColor = Color.DimGray
                CSSPersonalizzato.BackColor = Color.DimGray

                CSS30m.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtCSS.Text = ("3600000") Then
                CSS1m.BackColor = Color.DimGray
                CSS5m.BackColor = Color.DimGray
                CSS10m.BackColor = Color.DimGray
                CSS30m.BackColor = Color.DimGray
                CSS1h.BackColor = Color.DimGray
                CSS2h.BackColor = Color.DimGray
                CSSPersonalizzato.BackColor = Color.DimGray

                CSS1h.BackColor = Color.DarkRed
            ElseIf AutoSaveTxtCSS.Text = ("7200000") Then
                CSS1m.BackColor = Color.DimGray
                CSS5m.BackColor = Color.DimGray
                CSS10m.BackColor = Color.DimGray
                CSS30m.BackColor = Color.DimGray
                CSS1h.BackColor = Color.DimGray
                CSS2h.BackColor = Color.DimGray
                CSSPersonalizzato.BackColor = Color.DimGray

                CSS2h.BackColor = Color.DarkRed
            End If
        ElseIf CSSTextBox.Text = ("") Or CSSTextBox.Text.Replace(" ", "") = ("") Then
            CSSTextBox.BackColor = Color.Red
        ElseIf CSSComboBox.Text = ("") Then
            CSSComboBox.BackColor = Color.Red
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = ("SALVA IL FILE CSS OGNI - [[" & AutoSaveTxtCSS.Text & "]]")
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub HTMLTextBox_Click(sender As Object, e As EventArgs) Handles HTMLTextBox.Click
        HTMLTextBox.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub HTMLTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles HTMLTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            HTMLPersonalizzaOkButton.PerformClick()
        End If
    End Sub

    Private Sub HTMLTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HTMLTextBox.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HTMLTextBox_TextChanged(sender As Object, e As EventArgs) Handles HTMLTextBox.TextChanged

    End Sub

    Private Sub CSSTextBox_Click(sender As Object, e As EventArgs) Handles CSSTextBox.Click
        CSSTextBox.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub CSSTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CSSTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            CSSPersonalizzaOkButton.PerformClick()
        End If
    End Sub

    Private Sub CSSTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CSSTextBox.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Asc(e.KeyChar) <> 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CSSTextBox_TextChanged(sender As Object, e As EventArgs) Handles CSSTextBox.TextChanged

    End Sub

    Private Sub HTMLComboBox_Click(sender As Object, e As EventArgs) Handles HTMLComboBox.Click
        HTMLComboBox.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub HTMLComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HTMLComboBox.SelectedIndexChanged

    End Sub

    Private Sub CSSComboBox_Click(sender As Object, e As EventArgs) Handles CSSComboBox.Click
        CSSComboBox.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub CSSComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CSSComboBox.SelectedIndexChanged

    End Sub

    Private Sub AutoSaveCheck0_CheckedChanged(sender As Object, e As EventArgs) Handles AutoSaveCheck0.CheckedChanged
        If AutoSaveCheck0.CheckState = CheckState.Checked Then
            AutoSaveTxt0.Text = "SI"
            HTML1m.Enabled = True
            HTML5m.Enabled = True
            HTML10m.Enabled = True
            HTML30m.Enabled = True
            HTML1h.Enabled = True
            HTML2h.Enabled = True
            HTMLPersonalizzato.Enabled = True
            CSS1m.Enabled = True
            CSS5m.Enabled = True
            CSS10m.Enabled = True
            CSS30m.Enabled = True
            CSS1h.Enabled = True
            CSS2h.Enabled = True
            CSSPersonalizzato.Enabled = True
            Label1.Enabled = True
            Label2.Enabled = True

            MinionOneF.HTMLTimerAutoSave.Start()
            MinionOneF.CSSTimerAutoSave.Start()
        Else
            AutoSaveTxt0.Text = "NO"
            HTMLPanelPersonalizzato.Visible = False
            HTML1m.Enabled = False
            HTML5m.Enabled = False
            HTML10m.Enabled = False
            HTML30m.Enabled = False
            HTML1h.Enabled = False
            HTML2h.Enabled = False
            HTMLPersonalizzato.Enabled = False
            CSSPanelPersonalizzato.Visible = False
            CSS1m.Enabled = False
            CSS5m.Enabled = False
            CSS10m.Enabled = False
            CSS30m.Enabled = False
            CSS1h.Enabled = False
            CSS2h.Enabled = False
            CSSPersonalizzato.Enabled = False
            Label1.Enabled = False
            Label2.Enabled = False

            MinionOneF.HTMLTimerAutoSave.Stop()
            MinionOneF.CSSTimerAutoSave.Stop()
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = ("SALVA AUTOMATICAMENTE IL PROGETTO APERTO - [[" & AutoSaveTxt0.Text & "]]")
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub InterfacciaBox0_CheckedChanged(sender As Object, e As EventArgs) Handles InterfacciaCheck0.CheckedChanged
        If InterfacciaCheck0.CheckState = CheckState.Checked Then
            InterfacciaTxt0.Text = "SI"
            My.Settings.barradistato = ("si")
            My.Settings.Save()
            MinionOneF.BarraInferiore.Visible = True
            MinionOneF.Button33.Image = My.Resources.si
        Else
            InterfacciaTxt0.Text = "NO"
            My.Settings.barradistato = ("no")
            My.Settings.Save()
            MinionOneF.BarraInferiore.Visible = False
            MinionOneF.Button33.Image = My.Resources.no
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = ("VISUALIZZA LA BARRA INFERIORE - [[" & InterfacciaTxt0.Text & "]]")
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub InterfacciaCheck1_CheckedChanged(sender As Object, e As EventArgs) Handles InterfacciaCheck1.CheckedChanged
        If InterfacciaCheck1.CheckState = CheckState.Checked Then
            InterfacciaTxt1.Text = "SI"
            MinionOneF.BarraLaterale.Visible = True
        Else
            InterfacciaTxt1.Text = "NO"
            MinionOneF.BarraLaterale.Visible = False
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = ("VISUALIZZA LA BARRA LATERALE - [[" & InterfacciaTxt1.Text & "]]")
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub InterfacciaCheck2_CheckedChanged(sender As Object, e As EventArgs) Handles InterfacciaCheck2.CheckedChanged
        If InterfacciaCheck2.CheckState = CheckState.Checked Then
            InterfacciaTxt2.Text = "SI"
        Else
            InterfacciaTxt2.Text = "NO"
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = ("VISUALIZZA A SCHERMO INTERO ALL'AVVIO - [[" & InterfacciaTxt2.Text & "]]")
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub GeneraleCheck6_CheckedChanged(sender As Object, e As EventArgs) Handles GeneraleCheck6.CheckedChanged
        If GeneraleCheck6.CheckState = CheckState.Checked Then
            GeneraleTxt6.Text = "SI"
        Else
            GeneraleTxt6.Text = "NO"
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = ("CANCELLA LA RIGA CORRENTE QUANDO SI PREME CTRL+SHIFT+D - [[" & GeneraleTxt6.Text & "]]")
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub PrivacyCombo0_CheckedChanged(sender As Object, e As EventArgs) Handles PrivacyCheck0.CheckedChanged
        If PrivacyCheck0.CheckState = CheckState.Checked Then
            PrivacyTxt0.Text = "SI"
        Else
            PrivacyTxt0.Text = "NO"
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = ("INVIA SEGNALAZIONI ANONIME - [[" & PrivacyTxt0.Text & "]]")
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = MinionOneF.ImpostazioniTxt.Lines(20)

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub AvanzateRadio2_CheckedChanged(sender As Object, e As EventArgs) Handles AvanzateRadio2.CheckedChanged

    End Sub

    Private Sub AvanzateRadio2_Click(sender As Object, e As EventArgs) Handles AvanzateRadio2.Click
        TextBox1.Enabled = True
        Button10.Enabled = True
        AvanzateTxt0.Text = ("")
        Button10.PerformClick()
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = ("APRI L'ANTEPRIMA DEL PROGETTO NEL - [[" & AvanzateTxt0.Text & "]]")

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim browser As String
            browser = OpenFileDialog1.FileName
            TextBox1.Text = browser
            AvanzateTxt0.Text = (TextBox1.Text)
        Else
            AvanzateRadio0.Checked = True
            AvanzateRadio2.Checked = False
            TextBox1.Enabled = False
            Button10.Enabled = False
            AvanzateTxt0.Text = ("WBI")
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = ("APRI L'ANTEPRIMA DEL PROGETTO NEL - [[" & AvanzateTxt0.Text & "]]")

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub AvanzateRadio0_CheckedChanged(sender As Object, e As EventArgs) Handles AvanzateRadio0.CheckedChanged

    End Sub

    Private Sub AvanzateRadio0_Click(sender As Object, e As EventArgs) Handles AvanzateRadio0.Click
        TextBox1.Enabled = False
        Button10.Enabled = False
        AvanzateTxt0.Text = ("WBI")
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = ("APRI L'ANTEPRIMA DEL PROGETTO NEL - [[" & AvanzateTxt0.Text & "]]")

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub AvanzateRadio1_CheckedChanged(sender As Object, e As EventArgs) Handles AvanzateRadio1.CheckedChanged

    End Sub

    Private Sub AvanzateRadio1_Click(sender As Object, e As EventArgs) Handles AvanzateRadio1.Click
        TextBox1.Enabled = False
        Button10.Enabled = False
        AvanzateTxt0.Text = ("WBP")
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = ("APRI L'ANTEPRIMA DEL PROGETTO NEL - [[" & AvanzateTxt0.Text & "]]")

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If Dir(TextBox1.Text) <> "" Then
            AvanzateTxt0.Text = (TextBox1.Text)
        Else
            AvanzateRadio0.Checked = True
            AvanzateRadio2.Checked = False
            TextBox1.Enabled = False
            Button10.Enabled = False
            AvanzateTxt0.Text = ("WBI")
            MessaggioF.Text = ("Errore: File inesistente")
            MessaggioF.Button1.Text = ("Il file selezionato come web browser personalizzato è inesistente, per favore, provare con uno valido." & vbNewLine & "Codice errore: MOE5IRC14C3")
            MessaggioF.Show()
        End If
        If Dir(My.Application.Info.DirectoryPath & "\Impostazioni.moix") <> "" Then
            Dim linee(20) As String
            linee(0) = MinionOneF.ImpostazioniTxt.Lines(0)
            linee(1) = MinionOneF.ImpostazioniTxt.Lines(1)
            linee(2) = MinionOneF.ImpostazioniTxt.Lines(2)
            linee(3) = MinionOneF.ImpostazioniTxt.Lines(3)
            linee(4) = MinionOneF.ImpostazioniTxt.Lines(4)
            linee(5) = MinionOneF.ImpostazioniTxt.Lines(5)
            linee(6) = MinionOneF.ImpostazioniTxt.Lines(6)
            linee(7) = MinionOneF.ImpostazioniTxt.Lines(7)
            linee(8) = MinionOneF.ImpostazioniTxt.Lines(8)
            linee(9) = MinionOneF.ImpostazioniTxt.Lines(9)
            linee(10) = MinionOneF.ImpostazioniTxt.Lines(10)
            linee(11) = MinionOneF.ImpostazioniTxt.Lines(11)
            linee(12) = MinionOneF.ImpostazioniTxt.Lines(12)
            linee(13) = MinionOneF.ImpostazioniTxt.Lines(13)
            linee(14) = MinionOneF.ImpostazioniTxt.Lines(14)
            linee(15) = MinionOneF.ImpostazioniTxt.Lines(15)
            linee(16) = MinionOneF.ImpostazioniTxt.Lines(16)
            linee(17) = MinionOneF.ImpostazioniTxt.Lines(17)
            linee(18) = MinionOneF.ImpostazioniTxt.Lines(18)
            linee(19) = MinionOneF.ImpostazioniTxt.Lines(19)
            linee(20) = ("APRI L'ANTEPRIMA DEL PROGETTO NEL - [[" & AvanzateTxt0.Text & "]]")

            MinionOneF.ImpostazioniTxt.Lines = linee
            System.IO.File.WriteAllText(My.Application.Info.DirectoryPath & "\Impostazioni.moix", MinionOneF.ImpostazioniTxt.Text)
        Else
            MessaggioF.Text = ("Errore: Non è possibile salvare le impostazioni")
            MessaggioF.Button1.Text = ("Attenzione, le impostazioni non saranno salvate a causa di un errore imprevisto." & vbNewLine & "Consigliamo di riavviare Minion One il prima possibile." & vbNewLine & "Codice errore: MOE2YLN17D1")
            MessaggioF.ShowDialog()
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Impostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AutoSavePanel_Paint(sender As Object, e As PaintEventArgs) Handles AutoSavePanel.Paint

    End Sub

    Private Sub GeneralePanel_Paint(sender As Object, e As PaintEventArgs) Handles GeneralePanel.Paint

    End Sub
End Class