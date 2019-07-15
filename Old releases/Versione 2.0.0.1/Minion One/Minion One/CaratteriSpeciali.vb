Public Class CaratteriSpeciali

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub me_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button86.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub me_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button86.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub me_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button86.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub



    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = "&#162;"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = ("") Then
        Else
            MinionOne.TESTOINCOLLATO.Paste()
            TextBox1.SelectAll()
            TextBox1.Copy()
            MinionOne.FastColoredTextBox1.Paste()
            MinionOne.TESTOINCOLLATO.SelectAll()
            MinionOne.TESTOINCOLLATO.Copy()
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = "&#163;"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = "&#36;"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = "&#8364;"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "&#191;"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "&#161;"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = "&#34;"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = "&#8220;"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = "&#8221;"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = "&#37;"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = "&#8211;"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = "&#8212;"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = "&#171;"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = "&#187;"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = "&#169;"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = "&#174;"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = "&#165;"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = "&#177;"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = "&#182;"
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        TextBox1.Text = "&#247;"
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        TextBox1.Text = "&#167;"
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        TextBox1.Text = "&#40;"
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        TextBox1.Text = "&#41;"
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        TextBox1.Text = "&#91;"
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TextBox1.Text = "&#93;"
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        TextBox1.Text = "&#123;"
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        TextBox1.Text = "&#125;"
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TextBox1.Text = "&#153;"
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TextBox1.Text = "&#181;"
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        TextBox1.Text = "&#183;"
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TextBox1.Text = "&#184;"
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox1.Text = "&#x262f;"
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox1.Text = "&#x262e;"
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox1.Text = "&#x263d;"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox1.Text = "&#x263e;"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox1.Text = "&#x263c;"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Text = "&#x2194;"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = "&#x2195;"
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        TextBox1.Text = "&#x2193;"
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        TextBox1.Text = "&#x2191;"
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        TextBox1.Text = "&#x2190;"
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        TextBox1.Text = "&#x2192;"
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        TextBox1.Text = "&#x265f;"
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        TextBox1.Text = "&#x265e;"
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        TextBox1.Text = "&#x265d;"
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        TextBox1.Text = "&#x265c;"
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        TextBox1.Text = "&#x265b;"
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        TextBox1.Text = "&#x265a;"
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        TextBox1.Text = "&#225;"
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        TextBox1.Text = "&#224;"
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        TextBox1.Text = "&#226;"
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        TextBox1.Text = "&#229;"
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        TextBox1.Text = "&#227;"
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        TextBox1.Text = "&#228;"
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        TextBox1.Text = "&#230;"
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        TextBox1.Text = "&#193;"
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        TextBox1.Text = "&#192;"
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        TextBox1.Text = "&#194;"
    End Sub

    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        TextBox1.Text = "&#197;"
    End Sub

    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        TextBox1.Text = "&#195;"
    End Sub

    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        TextBox1.Text = "&#196;"
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        TextBox1.Text = "&#198;"
    End Sub

    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        TextBox1.Text = "&#231;"
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        TextBox1.Text = "&#199;"
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        TextBox1.Text = "&#233;"
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        TextBox1.Text = "&#232;"
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        TextBox1.Text = "&#234;"
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        TextBox1.Text = "&#235;"
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        TextBox1.Text = "&#201;"
    End Sub

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        TextBox1.Text = "&#200;"
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        TextBox1.Text = "&#202;"
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        TextBox1.Text = "&#203;"
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        TextBox1.Text = "&#237;"
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        TextBox1.Text = "&#236;"
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        TextBox1.Text = "&#238;"
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        TextBox1.Text = "&#239;"
    End Sub

    Private Sub Button153_Click(sender As Object, e As EventArgs) Handles Button153.Click
        TextBox1.Text = "&#205;"
    End Sub

    Private Sub Button152_Click(sender As Object, e As EventArgs) Handles Button152.Click
        TextBox1.Text = "&#204;"
    End Sub

    Private Sub Button151_Click(sender As Object, e As EventArgs) Handles Button151.Click
        TextBox1.Text = "&#206;"
    End Sub

    Private Sub Button150_Click(sender As Object, e As EventArgs) Handles Button150.Click
        TextBox1.Text = "&#207;"
    End Sub

    Private Sub Button149_Click(sender As Object, e As EventArgs) Handles Button149.Click
        TextBox1.Text = "&#241;"
    End Sub

    Private Sub Button148_Click(sender As Object, e As EventArgs) Handles Button148.Click
        TextBox1.Text = "&#209;"
    End Sub

    Private Sub Button147_Click(sender As Object, e As EventArgs) Handles Button147.Click
        TextBox1.Text = "&#243;"
    End Sub

    Private Sub Button146_Click(sender As Object, e As EventArgs) Handles Button146.Click
        TextBox1.Text = "&#242;"
    End Sub

    Private Sub Button145_Click(sender As Object, e As EventArgs) Handles Button145.Click
        TextBox1.Text = "&#244;"
    End Sub

    Private Sub Button144_Click(sender As Object, e As EventArgs) Handles Button144.Click
        TextBox1.Text = "&#248;"
    End Sub

    Private Sub Button143_Click(sender As Object, e As EventArgs) Handles Button143.Click
        TextBox1.Text = "&#245;"
    End Sub

    Private Sub Button142_Click(sender As Object, e As EventArgs) Handles Button142.Click
        TextBox1.Text = "&#246;"
    End Sub

    Private Sub Button141_Click(sender As Object, e As EventArgs) Handles Button141.Click
        TextBox1.Text = "&#211;"
    End Sub

    Private Sub Button140_Click(sender As Object, e As EventArgs) Handles Button140.Click
        TextBox1.Text = "&#210;"
    End Sub

    Private Sub Button139_Click(sender As Object, e As EventArgs) Handles Button139.Click
        TextBox1.Text = "&#212;"
    End Sub

    Private Sub Button138_Click(sender As Object, e As EventArgs) Handles Button138.Click
        TextBox1.Text = "&#216;"
    End Sub

    Private Sub Button137_Click(sender As Object, e As EventArgs) Handles Button137.Click
        TextBox1.Text = "&#213;"
    End Sub

    Private Sub Button136_Click(sender As Object, e As EventArgs) Handles Button136.Click
        TextBox1.Text = "&#214;"
    End Sub

    Private Sub Button135_Click(sender As Object, e As EventArgs) Handles Button135.Click
        TextBox1.Text = "&#223;"
    End Sub

    Private Sub Button134_Click(sender As Object, e As EventArgs) Handles Button134.Click
        TextBox1.Text = "&#250;"
    End Sub

    Private Sub Button133_Click(sender As Object, e As EventArgs) Handles Button133.Click
        TextBox1.Text = "&#249;"
    End Sub

    Private Sub Button132_Click(sender As Object, e As EventArgs) Handles Button132.Click
        TextBox1.Text = "&#251;"
    End Sub

    Private Sub Button131_Click(sender As Object, e As EventArgs) Handles Button131.Click
        TextBox1.Text = "&#252;"
    End Sub

    Private Sub Button130_Click(sender As Object, e As EventArgs) Handles Button130.Click
        TextBox1.Text = "&#218;"
    End Sub

    Private Sub Button129_Click(sender As Object, e As EventArgs) Handles Button129.Click
        TextBox1.Text = "&#217;"
    End Sub

    Private Sub Button128_Click(sender As Object, e As EventArgs) Handles Button128.Click
        TextBox1.Text = "&#219;"
    End Sub

    Private Sub Button127_Click(sender As Object, e As EventArgs) Handles Button127.Click
        TextBox1.Text = "&#220;"
    End Sub

    Private Sub Button126_Click(sender As Object, e As EventArgs) Handles Button126.Click
        TextBox1.Text = "&#255;"
    End Sub

    Private Sub Button125_Click(sender As Object, e As EventArgs) Handles Button125.Click
        TextBox1.Text = "&#188;"
    End Sub

    Private Sub Button124_Click(sender As Object, e As EventArgs) Handles Button124.Click
        TextBox1.Text = "&ETH;"
    End Sub

    Private Sub Button123_Click(sender As Object, e As EventArgs) Handles Button123.Click
        TextBox1.Text = "&#222;"
    End Sub

    Private Sub Button122_Click(sender As Object, e As EventArgs) Handles Button122.Click
        TextBox1.Text = "&#176;"
    End Sub

    Private Sub Button121_Click(sender As Object, e As EventArgs) Handles Button121.Click
        TextBox1.Text = "&#35;"
    End Sub

    Private Sub Button120_Click(sender As Object, e As EventArgs) Handles Button120.Click
        TextBox1.Text = "&#94;"
    End Sub

    Private Sub Button119_Click(sender As Object, e As EventArgs) Handles Button119.Click
        TextBox1.Text = "&#189;"
    End Sub

    Private Sub Button118_Click(sender As Object, e As EventArgs) Handles Button118.Click
        TextBox1.Text = "&#190;"
    End Sub

    Private Sub Button117_Click(sender As Object, e As EventArgs) Handles Button117.Click
        TextBox1.Text = "&#185;"
    End Sub

    Private Sub Button116_Click(sender As Object, e As EventArgs) Handles Button116.Click
        TextBox1.Text = "&#178;"
    End Sub

    Private Sub Button115_Click(sender As Object, e As EventArgs) Handles Button115.Click
        TextBox1.Text = "&#179;"
    End Sub

    Private Sub Button114_Click(sender As Object, e As EventArgs) Handles Button114.Click
        TextBox1.Text = "&#175;"
    End Sub

    Private Sub Button113_Click(sender As Object, e As EventArgs) Handles Button113.Click
        TextBox1.Text = "&#215;"
    End Sub

    Private Sub Button112_Click(sender As Object, e As EventArgs) Handles Button112.Click
        TextBox1.Text = "&hellip;"
    End Sub

    Private Sub Button111_Click(sender As Object, e As EventArgs) Handles Button111.Click
        TextBox1.Text = "&tilde;"
    End Sub

    Private Sub Button110_Click(sender As Object, e As EventArgs) Handles Button110.Click
        TextBox1.Text = "&circ;"
    End Sub

    Private Sub Button109_Click(sender As Object, e As EventArgs) Handles Button109.Click
        TextBox1.Text = "&not;"
    End Sub

    Private Sub Button108_Click(sender As Object, e As EventArgs) Handles Button108.Click
        TextBox1.Text = "&curren;"
    End Sub

    Private Sub Button107_Click(sender As Object, e As EventArgs) Handles Button107.Click
        TextBox1.Text = "&uml;"
    End Sub

    Private Sub Button106_Click(sender As Object, e As EventArgs) Handles Button106.Click
        TextBox1.Text = "&brvbar;"
    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        TextBox1.Text = "&#8216;"
    End Sub

    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        TextBox1.Text = "&#8217;"
    End Sub

    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        TextBox1.Text = "&#64;"
    End Sub

    Private Sub Button82_Click(sender As Object, e As EventArgs) Handles Button82.Click
        TextBox1.Text = "&#60;"
    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        TextBox1.Text = "&#62;"
    End Sub

    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Button83.Click
        TextBox1.Text = "&#61;"
    End Sub

    Private Sub Button84_Click(sender As Object, e As EventArgs) Handles Button84.Click
        TextBox1.Text = "&#126;"
    End Sub

    Private Sub Button85_Click(sender As Object, e As EventArgs) Handles Button85.Click
        TextBox1.Text = "&#170;"
    End Sub

    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Button87.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button88_Click(sender As Object, e As EventArgs) Handles Button88.Click
        Me.Close()
    End Sub

    Private Sub CaratteriSpeciali_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.finestremenuinseriscitopmost = ("si") Then
            Me.TopMost = True
        ElseIf My.Settings.finestremenuinseriscitopmost = ("no") Then
            Me.TopMost = False
        End If

        If My.Settings.colorebordi = ("black") Then
            Button86.BackColor = Color.Black
            Button86.FlatAppearance.BorderColor = Color.Black
            Button86.FlatAppearance.MouseDownBackColor = Color.Black
            Button86.FlatAppearance.MouseOverBackColor = Color.Black
            Button86.ForeColor = Color.Gray
            Button87.BackColor = Color.Black
            Button87.ForeColor = Color.Gray
            Button88.BackColor = Color.Black
            Button88.ForeColor = Color.Gray
            Panel1.BackColor = Color.Black
            Panel2.BackColor = Color.Black
            Panel4.BackColor = Color.Black
        ElseIf My.Settings.colorebordi = ("gray") Then
            Button86.BackColor = Color.Gray
            Button86.FlatAppearance.BorderColor = Color.Gray
            Button86.FlatAppearance.MouseDownBackColor = Color.Gray
            Button86.FlatAppearance.MouseOverBackColor = Color.Gray
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Gray
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Gray
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Gray
            Panel2.BackColor = Color.Gray
            Panel4.BackColor = Color.Gray
        ElseIf My.Settings.colorebordi = ("white") Then
            Button86.BackColor = Color.White
            Button86.FlatAppearance.BorderColor = Color.White
            Button86.FlatAppearance.MouseDownBackColor = Color.White
            Button86.FlatAppearance.MouseOverBackColor = Color.White
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.White
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.White
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.White
            Panel2.BackColor = Color.White
            Panel4.BackColor = Color.White
        ElseIf My.Settings.colorebordi = ("yellow") Then
            Button86.BackColor = Color.Yellow
            Button86.FlatAppearance.BorderColor = Color.Yellow
            Button86.FlatAppearance.MouseDownBackColor = Color.Yellow
            Button86.FlatAppearance.MouseOverBackColor = Color.Yellow
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Yellow
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Yellow
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Yellow
            Panel2.BackColor = Color.Yellow
            Panel4.BackColor = Color.Yellow
        ElseIf My.Settings.colorebordi = ("gold") Then
            Button86.BackColor = Color.Gold
            Button86.FlatAppearance.BorderColor = Color.Gold
            Button86.FlatAppearance.MouseDownBackColor = Color.Gold
            Button86.FlatAppearance.MouseOverBackColor = Color.Gold
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Gold
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Gold
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Gold
            Panel2.BackColor = Color.Gold
            Panel4.BackColor = Color.Gold
        ElseIf My.Settings.colorebordi = ("orangered") Then
            Button86.BackColor = Color.OrangeRed
            Button86.FlatAppearance.BorderColor = Color.OrangeRed
            Button86.FlatAppearance.MouseDownBackColor = Color.OrangeRed
            Button86.FlatAppearance.MouseOverBackColor = Color.OrangeRed
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.OrangeRed
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.OrangeRed
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.OrangeRed
            Panel2.BackColor = Color.OrangeRed
            Panel4.BackColor = Color.OrangeRed
        ElseIf My.Settings.colorebordi = ("red") Then
            Button86.BackColor = Color.Red
            Button86.FlatAppearance.BorderColor = Color.Red
            Button86.FlatAppearance.MouseDownBackColor = Color.Red
            Button86.FlatAppearance.MouseOverBackColor = Color.Red
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Red
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Red
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Red
            Panel2.BackColor = Color.Red
            Panel4.BackColor = Color.Red
        ElseIf My.Settings.colorebordi = ("fuchsia") Then
            Button86.BackColor = Color.Fuchsia
            Button86.FlatAppearance.BorderColor = Color.Fuchsia
            Button86.FlatAppearance.MouseDownBackColor = Color.Fuchsia
            Button86.FlatAppearance.MouseOverBackColor = Color.Fuchsia
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Fuchsia
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Fuchsia
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Fuchsia
            Panel2.BackColor = Color.Fuchsia
            Panel4.BackColor = Color.Fuchsia
        ElseIf My.Settings.colorebordi = ("purple") Then
            Button86.BackColor = Color.Purple
            Button86.FlatAppearance.BorderColor = Color.Purple
            Button86.FlatAppearance.MouseDownBackColor = Color.Purple
            Button86.FlatAppearance.MouseOverBackColor = Color.Purple
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Purple
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Purple
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Purple
            Panel2.BackColor = Color.Purple
            Panel4.BackColor = Color.Purple
        ElseIf My.Settings.colorebordi = ("navy") Then
            Button86.BackColor = Color.Navy
            Button86.FlatAppearance.BorderColor = Color.Navy
            Button86.FlatAppearance.MouseDownBackColor = Color.Navy
            Button86.FlatAppearance.MouseOverBackColor = Color.Navy
            Button86.ForeColor = Color.Gray
            Button87.BackColor = Color.Navy
            Button87.ForeColor = Color.Gray
            Button88.BackColor = Color.Navy
            Button88.ForeColor = Color.Gray
            Panel1.BackColor = Color.Navy
            Panel2.BackColor = Color.Navy
            Panel4.BackColor = Color.Navy
        ElseIf My.Settings.colorebordi = ("blue") Then
            Button86.BackColor = Color.Blue
            Button86.FlatAppearance.BorderColor = Color.Blue
            Button86.FlatAppearance.MouseDownBackColor = Color.Blue
            Button86.FlatAppearance.MouseOverBackColor = Color.Blue
            Button86.ForeColor = Color.Gray
            Button87.BackColor = Color.Blue
            Button87.ForeColor = Color.Gray
            Button88.BackColor = Color.Blue
            Button88.ForeColor = Color.Gray
            Panel1.BackColor = Color.Blue
            Panel2.BackColor = Color.Blue
            Panel4.BackColor = Color.Blue
        ElseIf My.Settings.colorebordi = ("cyan") Then
            Button86.BackColor = Color.Cyan
            Button86.FlatAppearance.BorderColor = Color.Cyan
            Button86.FlatAppearance.MouseDownBackColor = Color.Cyan
            Button86.FlatAppearance.MouseOverBackColor = Color.Cyan
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Cyan
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Cyan
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Cyan
            Panel2.BackColor = Color.Cyan
            Panel4.BackColor = Color.Cyan
        ElseIf My.Settings.colorebordi = ("teal") Then
            Button86.BackColor = Color.Teal
            Button86.FlatAppearance.BorderColor = Color.Teal
            Button86.FlatAppearance.MouseDownBackColor = Color.Teal
            Button86.FlatAppearance.MouseOverBackColor = Color.Teal
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Teal
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Teal
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Teal
            Panel2.BackColor = Color.Teal
            Panel4.BackColor = Color.Teal
        ElseIf My.Settings.colorebordi = ("green") Then
            Button86.BackColor = Color.Green
            Button86.FlatAppearance.BorderColor = Color.Green
            Button86.FlatAppearance.MouseDownBackColor = Color.Green
            Button86.FlatAppearance.MouseOverBackColor = Color.Green
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Green
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Green
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Green
            Panel2.BackColor = Color.Green
            Panel4.BackColor = Color.Green
        ElseIf My.Settings.colorebordi = ("lime") Then
            Button86.BackColor = Color.Lime
            Button86.FlatAppearance.BorderColor = Color.Lime
            Button86.FlatAppearance.MouseDownBackColor = Color.Lime
            Button86.FlatAppearance.MouseOverBackColor = Color.Lime
            Button86.ForeColor = Color.Navy
            Button87.BackColor = Color.Lime
            Button87.ForeColor = Color.Navy
            Button88.BackColor = Color.Lime
            Button88.ForeColor = Color.Navy
            Panel1.BackColor = Color.Lime
            Panel2.BackColor = Color.Lime
            Panel4.BackColor = Color.Lime
        End If
    End Sub
End Class