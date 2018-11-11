Imports System.Math
Public Class Calcolatrice
    Dim CMax As Integer = 15
    Dim ris As Boolean = False

    Dim negativo1 As Boolean = False
    Dim negativo2 As Boolean = False

    Dim operazione As Char = ""

    Dim modalita As String = "dec"

    Dim secondaf As Boolean = False

    Function Lunghezza(lung As Boolean) As Boolean
        Dim lu As String = Display.Text
        lu = lu.Replace(",", "")
        lu = lu.Replace(".", "")
        lu = lu.Replace("-", "")
        If lu.Length <= CMax Then
            lung = True
        Else
            lung = False
        End If

        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            If Display2.Text = "" Then
                If Display.Text < 0 Then
                    negativo1 = True
                Else
                    negativo1 = False
                End If
            Else
                If Display.Text < 0 Then
                    negativo2 = True
                Else
                    negativo2 = False
                End If
            End If
        End If

        Return lung
    End Function

    Private Sub Calcolatrice_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, DECButton.KeyDown, Display2.KeyDown, Display.KeyDown, F2NDButton.KeyDown, ACButton.KeyDown, DELButton.KeyDown, UnoButton.KeyDown, DueButton.KeyDown, TreButton.KeyDown, QuattroButton.KeyDown, CinqueButton.KeyDown, SeiButton.KeyDown, SetteButton.KeyDown, OttoButton.KeyDown, NoveButton.KeyDown, ZeroButton.KeyDown, VirgolaButton.KeyDown, PiuButton.KeyDown, MenoButton.KeyDown, PerButton.KeyDown, DivisioneButton.KeyDown, UgualeButton.KeyDown, ElevazioneButton.KeyDown, RadiceButton.KeyDown, MemoriaPiuButton.KeyDown, MostraMemoriaButton.KeyDown, PerCentoButton.KeyDown, PerMilleButton.KeyDown, Label1.KeyDown
        If e.KeyCode = Keys.Back Then
            DELButton.PerformClick()
        End If
        If e.KeyCode = Keys.Enter Then
            UgualeButton.PerformClick()
        End If
    End Sub

    Private Sub Calcolatrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, DECButton.KeyPress, Display2.KeyPress, Display.KeyPress, F2NDButton.KeyPress, ACButton.KeyPress, DELButton.KeyPress, UnoButton.KeyPress, DueButton.KeyPress, TreButton.KeyPress, QuattroButton.KeyPress, CinqueButton.KeyPress, SeiButton.KeyPress, SetteButton.KeyPress, OttoButton.KeyPress, NoveButton.KeyPress, ZeroButton.KeyPress, VirgolaButton.KeyPress, PiuButton.KeyPress, MenoButton.KeyPress, PerButton.KeyPress, DivisioneButton.KeyPress, UgualeButton.KeyPress, ElevazioneButton.KeyPress, RadiceButton.KeyPress, MemoriaPiuButton.KeyPress, MostraMemoriaButton.KeyPress, PerCentoButton.KeyPress, PerMilleButton.KeyPress, Label1.KeyPress
        If e.KeyChar = "0"c Then
            ZeroButton.PerformClick()
        End If
        If e.KeyChar = "1"c Then
            UnoButton.PerformClick()
        End If
        If e.KeyChar = "2"c Then
            DueButton.PerformClick()
        End If
        If e.KeyChar = "3"c Then
            TreButton.PerformClick()
        End If
        If e.KeyChar = "4"c Then
            QuattroButton.PerformClick()
        End If
        If e.KeyChar = "5"c Then
            CinqueButton.PerformClick()
        End If
        If e.KeyChar = "6"c Then
            SeiButton.PerformClick()
        End If
        If e.KeyChar = "7"c Then
            SetteButton.PerformClick()
        End If
        If e.KeyChar = "8"c Then
            OttoButton.PerformClick()
        End If
        If e.KeyChar = "9"c Then
            NoveButton.PerformClick()
        End If

        If e.KeyChar = "+"c Then
            PiuButton.PerformClick()
        End If
        If e.KeyChar = "-"c Then
            MenoButton.PerformClick()
        End If
        If e.KeyChar = "*"c Then
            PerButton.PerformClick()
        End If
        If e.KeyChar = "/"c Then
            DivisioneButton.PerformClick()
        End If

        If e.KeyChar = "."c Or e.KeyChar = ","c Then
            VirgolaButton.PerformClick()
        End If
    End Sub

    Private Sub Calcolatrice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim osv As Version = System.Environment.OSVersion.Version
        If osv.Major = 6 And osv.Minor = 1 Then
            'Console.WriteLine("win7!!")
        End If
    End Sub

    Private Sub ZeroButton_Click(sender As Object, e As EventArgs) Handles ZeroButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "0"
            Else
                Display.Text = "0"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub VirgolaButton_Click(sender As Object, e As EventArgs) Handles VirgolaButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Not Display.Text.Contains(".") Then
                Display.Text &= "."
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub DELButton_Click(sender As Object, e As EventArgs) Handles DELButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            If Display.Text <> "0" Then
                Dim valore As Integer = 0
                valore = (Len(Display.Text)) - 1

                Display.Text = Display.Text.Remove(valore, 1)
                If Display.Text = "" Or Display.Text = "-" Or Display.Text = "-0" Then
                    Display.Text = ("0")
                End If
                If Display2.Text = "" Then
                    If Display.Text < 0 Then
                        negativo1 = True
                    Else
                        negativo1 = False
                    End If
                Else
                    If Display.Text < 0 Then
                        negativo2 = True
                    Else
                        negativo2 = False
                    End If
                End If
            ElseIf Display.Text = "0" And Display2.Text <> "" Then
                Display.Text = Display2.Text.Replace(" " & operazione, "")
                Display2.Text = ""
            End If
        Else
            Display.Text = "0"
        End If

        Label1.Select()
    End Sub

    Private Sub UnoButton_Click(sender As Object, e As EventArgs) Handles UnoButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "1"
            Else
                Display.Text = "1"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub DueButton_Click(sender As Object, e As EventArgs) Handles DueButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "2"
            Else
                Display.Text = "2"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub TreButton_Click(sender As Object, e As EventArgs) Handles TreButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "3"
            Else
                Display.Text = "3"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub QuattroButton_Click(sender As Object, e As EventArgs) Handles QuattroButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "4"
            Else
                Display.Text = "4"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub CinqueButton_Click(sender As Object, e As EventArgs) Handles CinqueButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "5"
            Else
                Display.Text = "5"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub SeiButton_Click(sender As Object, e As EventArgs) Handles SeiButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "6"
            Else
                Display.Text = "6"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub SetteButton_Click(sender As Object, e As EventArgs) Handles SetteButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "7"
            Else
                Display.Text = "7"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub OttoButton_Click(sender As Object, e As EventArgs) Handles OttoButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "8"
            Else
                Display.Text = "8"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub NoveButton_Click(sender As Object, e As EventArgs) Handles NoveButton.Click
        If ris = True Then
            Display2.Text = ""
            ris = False
        End If
        Dim bool As Boolean = Lunghezza(bool)
        If bool = True Then
            If Display.Text <> "0" And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                Display.Text &= "9"
            Else
                Display.Text = "9"
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub PiuMenoButton_Click(sender As Object, e As EventArgs) Handles PiuMenoButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            Try
                If Display.Text <> "0" Then
                    Display.Text *= -1
                End If
                If Display2.Text = "" Then
                    If negativo1 = False Then
                        negativo1 = True
                    Else
                        negativo1 = False
                    End If
                Else
                    If negativo2 = False Then
                        negativo2 = True
                    Else
                        negativo2 = False
                    End If
                End If
            Catch ex As Exception

            End Try
            Label1.Select()
        End If
    End Sub

    Private Sub ACButton_Click(sender As Object, e As EventArgs) Handles ACButton.Click
        Display2.Text = ""
        Display.Text = "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Display.Text = "0"
    End Sub

    Private Sub UgualeButton_Click(sender As Object, e As EventArgs) Handles UgualeButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            Dim primo As Decimal = 0
            Dim secondo As Decimal = 0
            If Display2.Text <> "" Then
                If Display2.Text.Contains(" +") Then
                    primo = Display2.Text.Replace(" +", "")
                    secondo = Display.Text
                    Display.Text = (primo + secondo)
                    Display2.Text = ""
                ElseIf Display2.Text.Contains(" -") Then
                    primo = Display2.Text.Replace(" -", "")
                    secondo = Display.Text
                    Display.Text = (primo - secondo)
                    Display2.Text = ""
                ElseIf Display2.Text.Contains(" ×") Then
                    primo = Display2.Text.Replace(" ×", "")
                    secondo = Display.Text
                    Display.Text = (primo * secondo)
                    Display2.Text = ""
                ElseIf Display2.Text.Contains(" ÷") Then
                    primo = Display2.Text.Replace(" ÷", "")
                    secondo = Display.Text
                    Display.Text = (primo / secondo)
                    Display2.Text = ""
                ElseIf Display2.Text.Contains(" ^") Then
                    primo = Display2.Text.Replace(" ^", "")
                    secondo = Display.Text
                    Display.Text = (primo ^ secondo)
                    Display2.Text = ""
                    'ElseIf Display2.Text.Contains(" ") Then
                End If
            End If

            If Display.Text = "Infinity" Then
                Display.Text = "∞"
                ris = True
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub RadiceButton_Click(sender As Object, e As EventArgs) Handles RadiceButton.Click
        If secondaf = False Then
            Dim bool As Boolean = Lunghezza(bool)
            If bool = True And Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                If Display.Text >= 0 Then
                    Display.Text = Sqrt(Display.Text)
                Else
                    Display.Text = "Imp. ℜ"
                    ris = True
                End If
            End If
        Else
            Try
                Display.Text = Log10(Display.Text)
                If Display.Text = "-Infinity" Then
                    Display.Text = "-∞"
                    ris = True
                End If
            Catch ex As Exception

            End Try
        End If
        Label1.Select()
    End Sub

    Private Sub PiuButton_Click(sender As Object, e As EventArgs) Handles PiuButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            operazione = "+"
            If Display2.Text <> "" Then
                Dim primo As Decimal = 0
                Dim secondo As Decimal = 0
                If Display2.Text <> "" Then
                    If Display2.Text.Contains(" +") Then
                        primo = Display2.Text.Replace(" +", "")
                        secondo = Display.Text
                        Display.Text = (primo + secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" -") Then
                        primo = Display2.Text.Replace(" -", "")
                        secondo = Display.Text
                        Display.Text = (primo - secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ×") Then
                        primo = Display2.Text.Replace(" ×", "")
                        secondo = Display.Text
                        Display.Text = (primo * secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ÷") Then
                        primo = Display2.Text.Replace(" ÷", "")
                        secondo = Display.Text
                        Display.Text = (primo / secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ^") Then
                        primo = Display2.Text.Replace(" ^", "")
                        secondo = Display.Text
                        Display.Text = (primo ^ secondo)
                        Display2.Text = ""
                        'ElseIf Display2.Text.Contains(" ") Then
                    End If
                End If
            End If
            Display2.Text = Display.Text & " +"
            Display.Text = "0"
        End If

        Label1.Select()
    End Sub

    Private Sub MenoButton_Click(sender As Object, e As EventArgs) Handles MenoButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            operazione = "-"
            If Display2.Text <> "" Then
                Dim primo As Decimal = 0
                Dim secondo As Decimal = 0
                If Display2.Text <> "" Then
                    If Display2.Text.Contains(" +") Then
                        primo = Display2.Text.Replace(" +", "")
                        secondo = Display.Text
                        Display.Text = (primo + secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" -") Then
                        primo = Display2.Text.Replace(" -", "")
                        secondo = Display.Text
                        Display.Text = (primo - secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ×") Then
                        primo = Display2.Text.Replace(" ×", "")
                        secondo = Display.Text
                        Display.Text = (primo * secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ÷") Then
                        primo = Display2.Text.Replace(" ÷", "")
                        secondo = Display.Text
                        Display.Text = (primo / secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ^") Then
                        primo = Display2.Text.Replace(" ^", "")
                        secondo = Display.Text
                        Display.Text = (primo ^ secondo)
                        Display2.Text = ""
                        'ElseIf Display2.Text.Contains(" ") Then
                    End If
                End If
            End If
            Display2.Text = Display.Text & " -"
            Display.Text = "0"
        End If

        Label1.Select()
    End Sub

    Private Sub PerButton_Click(sender As Object, e As EventArgs) Handles PerButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            operazione = "×"
            If Display2.Text <> "" Then
                Dim primo As Decimal = 0
                Dim secondo As Decimal = 0
                If Display2.Text <> "" Then
                    If Display2.Text.Contains(" +") Then
                        primo = Display2.Text.Replace(" +", "")
                        secondo = Display.Text
                        Display.Text = (primo + secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" -") Then
                        primo = Display2.Text.Replace(" -", "")
                        secondo = Display.Text
                        Display.Text = (primo - secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ×") Then
                        primo = Display2.Text.Replace(" ×", "")
                        secondo = Display.Text
                        Display.Text = (primo * secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ÷") Then
                        primo = Display2.Text.Replace(" ÷", "")
                        secondo = Display.Text
                        Display.Text = (primo / secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ^") Then
                        primo = Display2.Text.Replace(" ^", "")
                        secondo = Display.Text
                        Display.Text = (primo ^ secondo)
                        Display2.Text = ""
                        'ElseIf Display2.Text.Contains(" ") Then
                    End If
                End If
            End If
            Display2.Text = Display.Text & " ×"
            Display.Text = "0"
        End If

        Label1.Select()
    End Sub

    Private Sub DivisioneButton_Click(sender As Object, e As EventArgs) Handles DivisioneButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            operazione = "÷"
            If Display2.Text <> "" Then
                Dim primo As Decimal = 0
                Dim secondo As Decimal = 0
                If Display2.Text <> "" Then
                    If Display2.Text.Contains(" +") Then
                        primo = Display2.Text.Replace(" +", "")
                        secondo = Display.Text
                        Display.Text = (primo + secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" -") Then
                        primo = Display2.Text.Replace(" -", "")
                        secondo = Display.Text
                        Display.Text = (primo - secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ×") Then
                        primo = Display2.Text.Replace(" ×", "")
                        secondo = Display.Text
                        Display.Text = (primo * secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ÷") Then
                        primo = Display2.Text.Replace(" ÷", "")
                        secondo = Display.Text
                        Display.Text = (primo / secondo)
                        Display2.Text = ""
                    ElseIf Display2.Text.Contains(" ^") Then
                        primo = Display2.Text.Replace(" ^", "")
                        secondo = Display.Text
                        Display.Text = (primo ^ secondo)
                        Display2.Text = ""
                        'ElseIf Display2.Text.Contains(" ") Then
                    End If
                End If
            End If
            Display2.Text = Display.Text & " ÷"
            Display.Text = "0"
        End If

        Label1.Select()
    End Sub

    Private Sub ElevazioneButton_Click(sender As Object, e As EventArgs) Handles ElevazioneButton.Click
        If secondaf = False Then
            If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                operazione = "^"
                If Display2.Text <> "" Then
                    Dim primo As Decimal = 0
                    Dim secondo As Decimal = 0
                    If Display2.Text <> "" Then
                        If Display2.Text.Contains(" +") Then
                            primo = Display2.Text.Replace(" +", "")
                            secondo = Display.Text
                            Display.Text = (primo + secondo)
                            Display2.Text = ""
                        ElseIf Display2.Text.Contains(" -") Then
                            primo = Display2.Text.Replace(" -", "")
                            secondo = Display.Text
                            Display.Text = (primo - secondo)
                            Display2.Text = ""
                        ElseIf Display2.Text.Contains(" ×") Then
                            primo = Display2.Text.Replace(" ×", "")
                            secondo = Display.Text
                            Display.Text = (primo * secondo)
                            Display2.Text = ""
                        ElseIf Display2.Text.Contains(" ÷") Then
                            primo = Display2.Text.Replace(" ÷", "")
                            secondo = Display.Text
                            Display.Text = (primo / secondo)
                            Display2.Text = ""
                        ElseIf Display2.Text.Contains(" ^") Then
                            primo = Display2.Text.Replace(" ^", "")
                            secondo = Display.Text
                            Display.Text = (primo ^ secondo)
                            Display2.Text = ""
                            'ElseIf Display2.Text.Contains(" ") Then
                        End If
                    End If
                End If
                Display2.Text = Display.Text & " ^"
                Display.Text = "0"
            End If
        Else
            If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
                If Display.Text = "0" Then
                    Display.Text = "1"
                Else
                    Try
                        Dim n As Integer = Display.Text
                        Dim i As Integer
                        Display.Text = "1"
                        For i = 1 To n
                            Display.Text *= i
                        Next i
                        If Display.Text = "Infinity" Then
                            Display.Text = "∞"
                            ris = True
                        End If
                    Catch ex As Exception

                    End Try
                End If
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub F2NDButton_Click(sender As Object, e As EventArgs) Handles F2NDButton.Click
        Try
            If secondaf = True Then
                secondaf = False

                F2NDButton.BackColor = Color.DarkRed

                MemoriaPiuButton.Text = "M+"
                MostraMemoriaButton.Text = "MR"
                PerCentoButton.Text = "%"
                PerMilleButton.Text = "‰"
                ElevazioneButton.Text = "∧"
                RadiceButton.Text = "√"
            Else
                secondaf = True

                F2NDButton.BackColor = Color.Red

                MemoriaPiuButton.Text = "M-"
                MostraMemoriaButton.Text = "MC"
                PerCentoButton.Text = "π"
                PerMilleButton.Text = "e"
                ElevazioneButton.Text = "n!"
                RadiceButton.Text = "log"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MemoriaPiuButton_Click(sender As Object, e As EventArgs) Handles MemoriaPiuButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            Try
                If secondaf = False Then
                    If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
                        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
                        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\")
                    End If
                    IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\", IO.FileAttributes.Hidden)
                    If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx") <> "" Then
                        Dim p As Integer = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx")
                        Dim s As Integer = Display.Text
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx", p + s)
                    Else
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx", Display.Text)
                    End If
                Else
                    If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
                        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
                        My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\")
                    End If
                    IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\", IO.FileAttributes.Normal)
                    Dim p As Integer = System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx")
                    Dim s As Integer = Display.Text
                    If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx") <> "" Then
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx", p - s)
                    Else
                        System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx", Display.Text)
                    End If
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub MostraMemoriaButton_Click(sender As Object, e As EventArgs) Handles MostraMemoriaButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            If secondaf = False Then
                If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\")
                End If
                IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\", IO.FileAttributes.Hidden)
                If Dir(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx") <> "" Then
                    Display.Text = (System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx"))
                Else
                    System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx", "0")
                    Display.Text = (System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx"))
                End If
            Else
                If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\") Then
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\")
                    My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\")
                End If
                IO.File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\", IO.FileAttributes.Hidden)
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\My Code Editor\Temp\Calcolatrice_Memoria.mcesx", "0")
            End If
        End If
    End Sub

    Private Sub PerCentoButton_Click(sender As Object, e As EventArgs) Handles PerCentoButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            If secondaf = False Then
                Display.Text = (Display.Text * 100)
            Else
                Display.Text = (Display.Text * PI)
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub PerMilleButton_Click(sender As Object, e As EventArgs) Handles PerMilleButton.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            If secondaf = False Then
                Display.Text = (Display.Text * 1000)
            Else
                Display.Text = (Display.Text * 2.7182818285)
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub DECButton_Click(sender As Object, e As EventArgs) Handles DECButton.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Display.Text <> "Imp. ℜ" And Display.Text <> "∞" And Display.Text <> "-∞" And Display.Text <> "NaN" Then
            Display.Text *= Display.Text
            If Display.Text = "Infinity" Then
                Display.Text = "∞"
                ris = True
            End If
        End If

        Label1.Select()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Display_Click(sender As Object, e As EventArgs) Handles Display.Click
        TextBox1.Text = Display.Text
        TextBox1.SelectAll()
        TextBox1.Copy()
        TextBox1.SelectAll()
        TextBox1.Clear()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        TextBox1.Text = Display.Text
        TextBox1.SelectAll()
        TextBox1.Copy()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TextBox1.SelectAll()
        TextBox1.Paste()
        Display.Text = TextBox1.Text
    End Sub
End Class