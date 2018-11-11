Public Class CaratteriSpeciali
    Private Sub CaratteriSpeciali_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button65_DoubleClick(sender As Object, e As EventArgs) Handles Button65.DoubleClick

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Function Ripetizione_Default()
        MyCEF.buttproghtml.BackColor = Color.Red
        MyCEF.buttprogcss.BackColor = Color.DarkRed
        MyCEF.AnteprimaWB.Visible = False
        MyCEF.ProgettazioneButtonR.BackColor = Color.DarkRed
        MyCEF.AnteprimaButtonR.BackColor = Color.FromArgb(140, 140, 140)
        MyCEF.CSSFTB.Visible = False
        MyCEF.FastColoredTextBox1.Visible = True
        MyCEF.DagliAppunti.Paste()
        MyCEF.DaIncollare.Text = TextBox1.Text
        MyCEF.DaIncollare.SelectAll()
        MyCEF.DaIncollare.Copy()
        MyCEF.FastColoredTextBox1.Paste()
        MyCEF.DaIncollare.Text = ""
        MyCEF.DagliAppunti.SelectAll()
        My.Computer.Clipboard.Clear()
        MyCEF.DagliAppunti.Copy()
        MyCEF.FastColoredTextBox1.Select()
        TextBox1.Text = "&#"
    End Function

    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        '!
        TextBox1.Text = TextBox1.Text & "33;"

        Ripetizione_Default()
    End Sub

    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        '
        TextBox1.Text = TextBox1.Text & "161;"

        Ripetizione_Default()
    End Sub

    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        '#
        TextBox1.Text = TextBox1.Text & "35;"

        Ripetizione_Default()
    End Sub

    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        '%
        TextBox1.Text = TextBox1.Text & "37;"

        Ripetizione_Default()
    End Sub

    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        '
        TextBox1.Text = TextBox1.Text & "137;"

        Ripetizione_Default()
    End Sub

    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        '&
        TextBox1.Text = TextBox1.Text & "38;"

        Ripetizione_Default()
    End Sub

    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        ''
        TextBox1.Text = TextBox1.Text & "39;"

        Ripetizione_Default()
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        '(
        TextBox1.Text = TextBox1.Text & "40;"

        Ripetizione_Default()
    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        ')
        TextBox1.Text = TextBox1.Text & "41;"

        Ripetizione_Default()
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        '[
        TextBox1.Text = TextBox1.Text & "91;"

        Ripetizione_Default()
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        ']
        TextBox1.Text = TextBox1.Text & "93;"

        Ripetizione_Default()
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        '{
        TextBox1.Text = TextBox1.Text & "123;"

        Ripetizione_Default()
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        '}
        TextBox1.Text = TextBox1.Text & "125;"

        Ripetizione_Default()
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        '*
        TextBox1.Text = TextBox1.Text & "42;"

        Ripetizione_Default()
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        '+
        TextBox1.Text = TextBox1.Text & "43;"

        Ripetizione_Default()
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        '/
        TextBox1.Text = TextBox1.Text & "47;"

        Ripetizione_Default()
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        '\
        TextBox1.Text = TextBox1.Text & "92;"

        Ripetizione_Default()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        '-
        TextBox1.Text = TextBox1.Text & "45;"

        Ripetizione_Default()
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        '
        TextBox1.Text = TextBox1.Text & "150;"

        Ripetizione_Default()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        '
        TextBox1.Text = TextBox1.Text & "151;"

        Ripetizione_Default()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        ',
        TextBox1.Text = TextBox1.Text & "44;"

        Ripetizione_Default()
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        '.
        TextBox1.Text = TextBox1.Text & "46;"

        Ripetizione_Default()
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        ':
        TextBox1.Text = TextBox1.Text & "58;"

        Ripetizione_Default()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        ';
        TextBox1.Text = TextBox1.Text & "59;"

        Ripetizione_Default()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        '<
        TextBox1.Text = TextBox1.Text & "60;"

        Ripetizione_Default()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        '=
        TextBox1.Text = TextBox1.Text & "61;"

        Ripetizione_Default()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        '>
        TextBox1.Text = TextBox1.Text & "62;"

        Ripetizione_Default()
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        '?
        TextBox1.Text = TextBox1.Text & "63;"

        Ripetizione_Default()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        '
        TextBox1.Text = TextBox1.Text & "191;"

        Ripetizione_Default()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        '"
        TextBox1.Text = TextBox1.Text & "34;"

        Ripetizione_Default()
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        '@
        TextBox1.Text = TextBox1.Text & "64;"

        Ripetizione_Default()
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        '^
        TextBox1.Text = TextBox1.Text & "94;"

        Ripetizione_Default()
    End Sub

    Private Sub Button129_Click(sender As Object, e As EventArgs) Handles Button129.Click
        '_
        TextBox1.Text = TextBox1.Text & "95;"

        Ripetizione_Default()
    End Sub

    Private Sub Button128_Click(sender As Object, e As EventArgs) Handles Button128.Click
        '
        TextBox1.Text = TextBox1.Text & "175;"

        Ripetizione_Default()
    End Sub

    Private Sub Button126_Click(sender As Object, e As EventArgs) Handles Button126.Click
        '
        TextBox1.Text = TextBox1.Text & "145;"

        Ripetizione_Default()
    End Sub

    Private Sub Button127_Click(sender As Object, e As EventArgs) Handles Button127.Click
        '
        TextBox1.Text = TextBox1.Text & "146;"

        Ripetizione_Default()
    End Sub

    Private Sub Button125_Click(sender As Object, e As EventArgs) Handles Button125.Click
        '~
        TextBox1.Text = TextBox1.Text & "126;"

        Ripetizione_Default()
    End Sub

    Private Sub Button124_Click(sender As Object, e As EventArgs) Handles Button124.Click
        '
        TextBox1.Text = TextBox1.Text & "162;"

        Ripetizione_Default()
    End Sub

    Private Sub Button122_Click(sender As Object, e As EventArgs) Handles Button122.Click
        '£
        TextBox1.Text = TextBox1.Text & "163;"

        Ripetizione_Default()
    End Sub

    Private Sub Button123_Click(sender As Object, e As EventArgs) Handles Button123.Click
        '
        TextBox1.Text = TextBox1.Text & "164;"

        Ripetizione_Default()
    End Sub

    Private Sub Button121_Click(sender As Object, e As EventArgs) Handles Button121.Click
        '
        TextBox1.Text = TextBox1.Text & "166;"

        Ripetizione_Default()
    End Sub

    Private Sub Button120_Click(sender As Object, e As EventArgs) Handles Button120.Click
        '
        TextBox1.Text = TextBox1.Text & "167;"

        Ripetizione_Default()
    End Sub

    Private Sub Button118_Click(sender As Object, e As EventArgs) Handles Button118.Click
        '
        TextBox1.Text = TextBox1.Text & "168;"

        Ripetizione_Default()
    End Sub

    Private Sub Button119_Click(sender As Object, e As EventArgs) Handles Button119.Click
        '
        TextBox1.Text = TextBox1.Text & "133;"

        Ripetizione_Default()
    End Sub

    Private Sub Button117_Click(sender As Object, e As EventArgs) Handles Button117.Click
        '|
        TextBox1.Text = TextBox1.Text & "124;"

        Ripetizione_Default()
    End Sub

    Private Sub Button116_Click(sender As Object, e As EventArgs) Handles Button116.Click
        '
        TextBox1.Text = TextBox1.Text & "169;"

        Ripetizione_Default()
    End Sub

    Private Sub Button114_Click(sender As Object, e As EventArgs) Handles Button114.Click
        '
        TextBox1.Text = TextBox1.Text & "171;"

        Ripetizione_Default()
    End Sub

    Private Sub Button115_Click(sender As Object, e As EventArgs) Handles Button115.Click
        '
        TextBox1.Text = TextBox1.Text & "187;"

        Ripetizione_Default()
    End Sub

    Private Sub Button113_Click(sender As Object, e As EventArgs) Handles Button113.Click
        '
        TextBox1.Text = TextBox1.Text & "172;"

        Ripetizione_Default()
    End Sub

    Private Sub Button112_Click(sender As Object, e As EventArgs) Handles Button112.Click
        '
        TextBox1.Text = TextBox1.Text & "8743;"

        Ripetizione_Default()
    End Sub

    Private Sub Button110_Click(sender As Object, e As EventArgs) Handles Button110.Click
        '
        TextBox1.Text = TextBox1.Text & "8744;"

        Ripetizione_Default()
    End Sub

    Private Sub Button111_Click(sender As Object, e As EventArgs) Handles Button111.Click
        '
        TextBox1.Text = TextBox1.Text & "174;"

        Ripetizione_Default()
    End Sub

    Private Sub Button109_Click(sender As Object, e As EventArgs) Handles Button109.Click
        '°
        TextBox1.Text = TextBox1.Text & "176;"

        Ripetizione_Default()
    End Sub

    Private Sub Button108_Click(sender As Object, e As EventArgs) Handles Button108.Click
        '
        TextBox1.Text = TextBox1.Text & "181;"

        Ripetizione_Default()
    End Sub

    Private Sub Button106_Click(sender As Object, e As EventArgs) Handles Button106.Click
        '
        TextBox1.Text = TextBox1.Text & "182;"

        Ripetizione_Default()
    End Sub

    Private Sub Button107_Click(sender As Object, e As EventArgs) Handles Button107.Click
        '
        TextBox1.Text = TextBox1.Text & "184;"

        Ripetizione_Default()
    End Sub

    Private Sub Button105_Click(sender As Object, e As EventArgs) Handles Button105.Click
        '
        TextBox1.Text = TextBox1.Text & "247;"

        Ripetizione_Default()
    End Sub

    Private Sub Button104_Click(sender As Object, e As EventArgs) Handles Button104.Click
        '
        TextBox1.Text = TextBox1.Text & "145;"

        Ripetizione_Default()
    End Sub

    Private Sub Button102_Click(sender As Object, e As EventArgs) Handles Button102.Click
        '
        TextBox1.Text = TextBox1.Text & "146;"

        Ripetizione_Default()
    End Sub

    Private Sub Button103_Click(sender As Object, e As EventArgs) Handles Button103.Click
        '
        TextBox1.Text = TextBox1.Text & "701;"

        Ripetizione_Default()
    End Sub

    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Button101.Click
        '
        TextBox1.Text = TextBox1.Text & "45;"

        Ripetizione_Default()
    End Sub

    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click
        '
        TextBox1.Text = TextBox1.Text & "46;"

        Ripetizione_Default()
    End Sub

    Private Sub Button98_Click(sender As Object, e As EventArgs) Handles Button98.Click
        '
        TextBox1.Text = TextBox1.Text & "703;"

        Ripetizione_Default()
    End Sub

    Private Sub Button99_Click(sender As Object, e As EventArgs) Handles Button99.Click
        '
        TextBox1.Text = TextBox1.Text & "702;"

        Ripetizione_Default()
    End Sub

    Private Sub Button97_Click(sender As Object, e As EventArgs) Handles Button97.Click
        '
        TextBox1.Text = TextBox1.Text & "735;"

        Ripetizione_Default()
    End Sub

    Private Sub Button96_Click(sender As Object, e As EventArgs) Handles Button96.Click
        '
        TextBox1.Text = TextBox1.Text & "215;"

        Ripetizione_Default()
    End Sub

    Private Sub Button94_Click(sender As Object, e As EventArgs) Handles Button94.Click
        '
        TextBox1.Text = TextBox1.Text & "8756;"

        Ripetizione_Default()
    End Sub

    Private Sub Button95_Click(sender As Object, e As EventArgs) Handles Button95.Click
        '
        TextBox1.Text = TextBox1.Text & "8592;"

        Ripetizione_Default()
    End Sub

    Private Sub Button93_Click(sender As Object, e As EventArgs) Handles Button93.Click
        '
        TextBox1.Text = TextBox1.Text & "8594;"

        Ripetizione_Default()
    End Sub

    Private Sub Button92_Click(sender As Object, e As EventArgs) Handles Button92.Click
        '
        TextBox1.Text = TextBox1.Text & "8593;"

        Ripetizione_Default()
    End Sub

    Private Sub Button90_Click(sender As Object, e As EventArgs) Handles Button90.Click
        '
        TextBox1.Text = TextBox1.Text & "8595;"

        Ripetizione_Default()
    End Sub

    Private Sub Button91_Click(sender As Object, e As EventArgs) Handles Button91.Click
        '
        TextBox1.Text = TextBox1.Text & "8596;"

        Ripetizione_Default()
    End Sub

    Private Sub Button89_Click(sender As Object, e As EventArgs) Handles Button89.Click
        '
        TextBox1.Text = TextBox1.Text & "8597;"

        Ripetizione_Default()
    End Sub

    Private Sub Button88_Click(sender As Object, e As EventArgs) Handles Button88.Click
        '
        TextBox1.Text = TextBox1.Text & "8598;"

        Ripetizione_Default()
    End Sub

    Private Sub Button86_Click(sender As Object, e As EventArgs) Handles Button86.Click
        '
        TextBox1.Text = TextBox1.Text & "8600;"

        Ripetizione_Default()
    End Sub

    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Button87.Click
        '
        TextBox1.Text = TextBox1.Text & "8601;"

        Ripetizione_Default()
    End Sub

    Private Sub Button85_Click(sender As Object, e As EventArgs) Handles Button85.Click
        '
        TextBox1.Text = TextBox1.Text & "8599;"

        Ripetizione_Default()
    End Sub

    Private Sub Button84_Click(sender As Object, e As EventArgs) Handles Button84.Click
        '
        TextBox1.Text = TextBox1.Text & "8656;"

        Ripetizione_Default()
    End Sub

    Private Sub Button82_Click(sender As Object, e As EventArgs) Handles Button82.Click
        '
        TextBox1.Text = TextBox1.Text & "8658;"

        Ripetizione_Default()
    End Sub

    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Button83.Click
        '
        TextBox1.Text = TextBox1.Text & "8657;"

        Ripetizione_Default()
    End Sub

    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        '
        TextBox1.Text = TextBox1.Text & "8659;"

        Ripetizione_Default()
    End Sub

    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        '
        TextBox1.Text = TextBox1.Text & "8660;"

        Ripetizione_Default()
    End Sub

    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        '
        TextBox1.Text = TextBox1.Text & "8661;"

        Ripetizione_Default()
    End Sub

    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        '
        TextBox1.Text = TextBox1.Text & "8662;"

        Ripetizione_Default()
    End Sub

    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        '
        TextBox1.Text = TextBox1.Text & "8664;"

        Ripetizione_Default()
    End Sub

    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        '
        TextBox1.Text = TextBox1.Text & "8665;"

        Ripetizione_Default()
    End Sub

    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        '
        TextBox1.Text = TextBox1.Text & "8663;"

        Ripetizione_Default()
    End Sub

    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        '
        TextBox1.Text = TextBox1.Text & "9824;"

        Ripetizione_Default()
    End Sub

    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        '
        TextBox1.Text = TextBox1.Text & "9828;"

        Ripetizione_Default()
    End Sub

    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        '
        TextBox1.Text = TextBox1.Text & "9829;"

        Ripetizione_Default()
    End Sub

    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        '
        TextBox1.Text = TextBox1.Text & "9825;"

        Ripetizione_Default()
    End Sub

    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        '
        TextBox1.Text = TextBox1.Text & "9827;"

        Ripetizione_Default()
    End Sub

    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        '
        TextBox1.Text = TextBox1.Text & "9831;"

        Ripetizione_Default()
    End Sub

    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        '
        TextBox1.Text = TextBox1.Text & "9830;"

        Ripetizione_Default()
    End Sub

    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        '
        TextBox1.Text = TextBox1.Text & "9826;"

        Ripetizione_Default()
    End Sub

    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        '
        TextBox1.Text = TextBox1.Text & "9823;"

        Ripetizione_Default()
    End Sub

    Private Sub Button193_Click(sender As Object, e As EventArgs) Handles Button193.Click
        '
        TextBox1.Text = TextBox1.Text & "9817;"

        Ripetizione_Default()
    End Sub

    Private Sub Button192_Click(sender As Object, e As EventArgs) Handles Button192.Click
        '
        TextBox1.Text = TextBox1.Text & "9822;"

        Ripetizione_Default()
    End Sub

    Private Sub Button190_Click(sender As Object, e As EventArgs) Handles Button190.Click
        '
        TextBox1.Text = TextBox1.Text & "9816;"

        Ripetizione_Default()
    End Sub

    Private Sub Button191_Click(sender As Object, e As EventArgs) Handles Button191.Click
        '
        TextBox1.Text = TextBox1.Text & "9821;"

        Ripetizione_Default()
    End Sub

    Private Sub Button189_Click(sender As Object, e As EventArgs) Handles Button189.Click
        '
        TextBox1.Text = TextBox1.Text & "9815;"

        Ripetizione_Default()
    End Sub

    Private Sub Button188_Click(sender As Object, e As EventArgs) Handles Button188.Click
        '
        TextBox1.Text = TextBox1.Text & "9820;"

        Ripetizione_Default()
    End Sub

    Private Sub Button186_Click(sender As Object, e As EventArgs) Handles Button186.Click
        '
        TextBox1.Text = TextBox1.Text & "9814;"

        Ripetizione_Default()
    End Sub

    Private Sub Button187_Click(sender As Object, e As EventArgs) Handles Button187.Click
        '
        TextBox1.Text = TextBox1.Text & "9819;"

        Ripetizione_Default()
    End Sub

    Private Sub Button185_Click(sender As Object, e As EventArgs) Handles Button185.Click
        '
        TextBox1.Text = TextBox1.Text & "9813;"

        Ripetizione_Default()
    End Sub

    Private Sub Button184_Click(sender As Object, e As EventArgs) Handles Button184.Click
        '
        TextBox1.Text = TextBox1.Text & "9818;"

        Ripetizione_Default()
    End Sub

    Private Sub Button182_Click(sender As Object, e As EventArgs) Handles Button182.Click
        '
        TextBox1.Text = TextBox1.Text & "9812;"

        Ripetizione_Default()
    End Sub

    Private Sub Button183_Click(sender As Object, e As EventArgs) Handles Button183.Click
        '
        TextBox1.Text = TextBox1.Text & "9792;"

        Ripetizione_Default()
    End Sub

    Private Sub Button181_Click(sender As Object, e As EventArgs) Handles Button181.Click
        '
        TextBox1.Text = TextBox1.Text & "9794;"

        Ripetizione_Default()
    End Sub

    Private Sub Button180_Click(sender As Object, e As EventArgs) Handles Button180.Click
        '
        TextBox1.Text = TextBox1.Text & "9800;"

        Ripetizione_Default()
    End Sub

    Private Sub Button178_Click(sender As Object, e As EventArgs) Handles Button178.Click
        '
        TextBox1.Text = TextBox1.Text & "9801;"

        Ripetizione_Default()
    End Sub

    Private Sub Button179_Click(sender As Object, e As EventArgs) Handles Button179.Click
        '
        TextBox1.Text = TextBox1.Text & "9802;"

        Ripetizione_Default()
    End Sub

    Private Sub Button177_Click(sender As Object, e As EventArgs) Handles Button177.Click
        '
        TextBox1.Text = TextBox1.Text & "9806;"

        Ripetizione_Default()
    End Sub

    Private Sub Button176_Click(sender As Object, e As EventArgs) Handles Button176.Click
        '
        TextBox1.Text = TextBox1.Text & "9803;"

        Ripetizione_Default()
    End Sub

    Private Sub Button174_Click(sender As Object, e As EventArgs) Handles Button174.Click
        '
        TextBox1.Text = TextBox1.Text & "9804;"

        Ripetizione_Default()
    End Sub

    Private Sub Button175_Click(sender As Object, e As EventArgs) Handles Button175.Click
        '
        TextBox1.Text = TextBox1.Text & "9805;"

        Ripetizione_Default()
    End Sub

    Private Sub Button173_Click(sender As Object, e As EventArgs) Handles Button173.Click
        '
        TextBox1.Text = TextBox1.Text & "9807;"

        Ripetizione_Default()
    End Sub

    Private Sub Button172_Click(sender As Object, e As EventArgs) Handles Button172.Click
        '
        TextBox1.Text = TextBox1.Text & "9808;"

        Ripetizione_Default()
    End Sub

    Private Sub Button170_Click(sender As Object, e As EventArgs) Handles Button170.Click
        '
        TextBox1.Text = TextBox1.Text & "9809;"

        Ripetizione_Default()
    End Sub

    Private Sub Button171_Click(sender As Object, e As EventArgs) Handles Button171.Click
        '
        TextBox1.Text = TextBox1.Text & "9810;"

        Ripetizione_Default()
    End Sub

    Private Sub Button169_Click(sender As Object, e As EventArgs) Handles Button169.Click
        '
        TextBox1.Text = TextBox1.Text & "9811;"

        Ripetizione_Default()
    End Sub

    Private Sub Button168_Click(sender As Object, e As EventArgs) Handles Button168.Click
        '
        TextBox1.Text = TextBox1.Text & "9833;"

        Ripetizione_Default()
    End Sub

    Private Sub Button166_Click(sender As Object, e As EventArgs) Handles Button166.Click
        '
        TextBox1.Text = TextBox1.Text & "9834;"

        Ripetizione_Default()
    End Sub

    Private Sub Button167_Click(sender As Object, e As EventArgs) Handles Button167.Click
        '
        TextBox1.Text = TextBox1.Text & "9835;"

        Ripetizione_Default()
    End Sub

    Private Sub Button165_Click(sender As Object, e As EventArgs) Handles Button165.Click
        '
        TextBox1.Text = TextBox1.Text & "9836;"

        Ripetizione_Default()
    End Sub

    Private Sub Button164_Click(sender As Object, e As EventArgs) Handles Button164.Click
        '
        TextBox1.Text = TextBox1.Text & "9837;"

        Ripetizione_Default()
    End Sub

    Private Sub Button162_Click(sender As Object, e As EventArgs) Handles Button162.Click
        '
        TextBox1.Text = TextBox1.Text & "9838;"

        Ripetizione_Default()
    End Sub

    Private Sub Button163_Click(sender As Object, e As EventArgs) Handles Button163.Click
        '
        TextBox1.Text = TextBox1.Text & "10084;"

        Ripetizione_Default()
    End Sub

    Private Sub Button161_Click(sender As Object, e As EventArgs) Handles Button161.Click
        '
        TextBox1.Text = TextBox1.Text & "9733;"

        Ripetizione_Default()
    End Sub

    Private Sub Button160_Click(sender As Object, e As EventArgs) Handles Button160.Click
        '
        TextBox1.Text = TextBox1.Text & "9734;"

        Ripetizione_Default()
    End Sub

    Private Sub Button158_Click(sender As Object, e As EventArgs) Handles Button158.Click
        '
        TextBox1.Text = TextBox1.Text & "9784;"

        Ripetizione_Default()
    End Sub

    Private Sub Button159_Click(sender As Object, e As EventArgs) Handles Button159.Click
        '
        TextBox1.Text = TextBox1.Text & "9786;"

        Ripetizione_Default()
    End Sub

    Private Sub Button157_Click(sender As Object, e As EventArgs) Handles Button157.Click
        '
        TextBox1.Text = TextBox1.Text & "9787;"

        Ripetizione_Default()
    End Sub

    Private Sub Button156_Click(sender As Object, e As EventArgs) Handles Button156.Click
        '
        TextBox1.Text = TextBox1.Text & "9788;"

        Ripetizione_Default()
    End Sub

    Private Sub Button154_Click(sender As Object, e As EventArgs) Handles Button154.Click
        '
        TextBox1.Text = TextBox1.Text & "9790;"

        Ripetizione_Default()
    End Sub

    Private Sub Button155_Click(sender As Object, e As EventArgs) Handles Button155.Click
        '
        TextBox1.Text = TextBox1.Text & "9789;"

        Ripetizione_Default()
    End Sub

    Private Sub Button153_Click(sender As Object, e As EventArgs) Handles Button153.Click
        '
        TextBox1.Text = TextBox1.Text & "9680;"

        Ripetizione_Default()
    End Sub

    Private Sub Button152_Click(sender As Object, e As EventArgs) Handles Button152.Click
        '
        TextBox1.Text = TextBox1.Text & "9681;"

        Ripetizione_Default()
    End Sub

    Private Sub Button150_Click(sender As Object, e As EventArgs) Handles Button150.Click
        '
        TextBox1.Text = TextBox1.Text & "9682;"

        Ripetizione_Default()
    End Sub

    Private Sub Button151_Click(sender As Object, e As EventArgs) Handles Button151.Click
        '
        TextBox1.Text = TextBox1.Text & "9683;"

        Ripetizione_Default()
    End Sub

    Private Sub Button149_Click(sender As Object, e As EventArgs) Handles Button149.Click
        '
        TextBox1.Text = TextBox1.Text & "9686;"

        Ripetizione_Default()
    End Sub

    Private Sub Button148_Click(sender As Object, e As EventArgs) Handles Button148.Click
        '
        TextBox1.Text = TextBox1.Text & "9687;"

        Ripetizione_Default()
    End Sub

    Private Sub Button146_Click(sender As Object, e As EventArgs) Handles Button146.Click
        '
        TextBox1.Text = TextBox1.Text & "9775;"

        Ripetizione_Default()
    End Sub

    Private Sub Button147_Click(sender As Object, e As EventArgs) Handles Button147.Click
        '
        TextBox1.Text = TextBox1.Text & "9774;"

        Ripetizione_Default()
    End Sub

    Private Sub Button139_Click(sender As Object, e As EventArgs) Handles Button139.Click
        '
        TextBox1.Text = TextBox1.Text & "8470;"

        Ripetizione_Default()
    End Sub

    Private Sub Button131_Click(sender As Object, e As EventArgs) Handles Button131.Click
        '
        TextBox1.Text = TextBox1.Text & "134;"

        Ripetizione_Default()
    End Sub

    Private Sub Button130_Click(sender As Object, e As EventArgs) Handles Button130.Click
        '
        TextBox1.Text = TextBox1.Text & "135;"

        Ripetizione_Default()
    End Sub

    Private Sub Button132_Click(sender As Object, e As EventArgs) Handles Button132.Click
        '
        TextBox1.Text = TextBox1.Text & "153;"

        Ripetizione_Default()
    End Sub

    Private Sub Button226_Click(sender As Object, e As EventArgs) Handles Button226.Click
        '
        TextBox1.Text = TextBox1.Text & "8451;"

        Ripetizione_Default()
    End Sub

    Private Sub Button144_Click(sender As Object, e As EventArgs) Handles Button144.Click
        '
        TextBox1.Text = TextBox1.Text & "8457;"

        Ripetizione_Default()
    End Sub

    Private Sub Button145_Click(sender As Object, e As EventArgs) Handles Button145.Click
        '
        TextBox1.Text = TextBox1.Text & "8456;"

        Ripetizione_Default()
    End Sub

    Private Sub Button143_Click(sender As Object, e As EventArgs) Handles Button143.Click
        '
        TextBox1.Text = TextBox1.Text & "8455;"

        Ripetizione_Default()
    End Sub

    Private Sub Button142_Click(sender As Object, e As EventArgs) Handles Button142.Click
        '
        TextBox1.Text = TextBox1.Text & "8491;"

        Ripetizione_Default()
    End Sub

    Private Sub Button141_Click(sender As Object, e As EventArgs) Handles Button141.Click
        '
        TextBox1.Text = TextBox1.Text & "8512;"

        Ripetizione_Default()
    End Sub

    Private Sub Button133_Click(sender As Object, e As EventArgs) Handles Button133.Click
        '
        TextBox1.Text = TextBox1.Text & "8485;"

        Ripetizione_Default()
    End Sub

    Private Sub Button225_Click(sender As Object, e As EventArgs) Handles Button225.Click
        '0
        TextBox1.Text = TextBox1.Text & "48;"

        Ripetizione_Default()
    End Sub

    Private Sub Button224_Click(sender As Object, e As EventArgs) Handles Button224.Click
        '1
        TextBox1.Text = TextBox1.Text & "49;"

        Ripetizione_Default()
    End Sub

    Private Sub Button222_Click(sender As Object, e As EventArgs) Handles Button222.Click
        '2
        TextBox1.Text = TextBox1.Text & "50;"

        Ripetizione_Default()
    End Sub

    Private Sub Button223_Click(sender As Object, e As EventArgs) Handles Button223.Click
        '3
        TextBox1.Text = TextBox1.Text & "51;"

        Ripetizione_Default()
    End Sub

    Private Sub Button221_Click(sender As Object, e As EventArgs) Handles Button221.Click
        '4
        TextBox1.Text = TextBox1.Text & "52;"

        Ripetizione_Default()
    End Sub

    Private Sub Button220_Click(sender As Object, e As EventArgs) Handles Button220.Click
        '5
        TextBox1.Text = TextBox1.Text & "53;"

        Ripetizione_Default()
    End Sub

    Private Sub Button218_Click(sender As Object, e As EventArgs) Handles Button218.Click
        '6
        TextBox1.Text = TextBox1.Text & "54;"

        Ripetizione_Default()
    End Sub

    Private Sub Button219_Click(sender As Object, e As EventArgs) Handles Button219.Click
        '7
        TextBox1.Text = TextBox1.Text & "55;"

        Ripetizione_Default()
    End Sub

    Private Sub Button217_Click(sender As Object, e As EventArgs) Handles Button217.Click
        '8
        TextBox1.Text = TextBox1.Text & "56;"

        Ripetizione_Default()
    End Sub

    Private Sub Button216_Click(sender As Object, e As EventArgs) Handles Button216.Click
        '9
        TextBox1.Text = TextBox1.Text & "57;"

        Ripetizione_Default()
    End Sub

    Private Sub Button214_Click(sender As Object, e As EventArgs) Handles Button214.Click
        '(
        TextBox1.Text = TextBox1.Text & "40;"

        Ripetizione_Default()
    End Sub

    Private Sub Button215_Click(sender As Object, e As EventArgs) Handles Button215.Click
        ')
        TextBox1.Text = TextBox1.Text & "41;"

        Ripetizione_Default()
    End Sub

    Private Sub Button213_Click(sender As Object, e As EventArgs) Handles Button213.Click
        '[
        TextBox1.Text = TextBox1.Text & "91;"

        Ripetizione_Default()
    End Sub

    Private Sub Button212_Click(sender As Object, e As EventArgs) Handles Button212.Click
        ']
        TextBox1.Text = TextBox1.Text & "93;"

        Ripetizione_Default()
    End Sub

    Private Sub Button210_Click(sender As Object, e As EventArgs) Handles Button210.Click
        '{
        TextBox1.Text = TextBox1.Text & "123;"

        Ripetizione_Default()
    End Sub

    Private Sub Button211_Click(sender As Object, e As EventArgs) Handles Button211.Click
        '}
        TextBox1.Text = TextBox1.Text & "125;"

        Ripetizione_Default()
    End Sub

    Private Sub Button209_Click(sender As Object, e As EventArgs) Handles Button209.Click
        '+
        TextBox1.Text = TextBox1.Text & "43;"

        Ripetizione_Default()
    End Sub

    Private Sub Button208_Click(sender As Object, e As EventArgs) Handles Button208.Click
        '-
        TextBox1.Text = TextBox1.Text & "45;"

        Ripetizione_Default()
    End Sub

    Private Sub Button206_Click(sender As Object, e As EventArgs) Handles Button206.Click
        '/
        TextBox1.Text = TextBox1.Text & "47;"

        Ripetizione_Default()
    End Sub

    Private Sub Button207_Click(sender As Object, e As EventArgs) Handles Button207.Click
        '*
        TextBox1.Text = TextBox1.Text & "42;"

        Ripetizione_Default()
    End Sub

    Private Sub Button205_Click(sender As Object, e As EventArgs) Handles Button205.Click
        ':
        TextBox1.Text = TextBox1.Text & "58;"

        Ripetizione_Default()
    End Sub

    Private Sub Button204_Click(sender As Object, e As EventArgs) Handles Button204.Click
        '
        TextBox1.Text = TextBox1.Text & "150;"

        Ripetizione_Default()
    End Sub

    Private Sub Button202_Click(sender As Object, e As EventArgs) Handles Button202.Click
        '
        TextBox1.Text = TextBox1.Text & "247;"

        Ripetizione_Default()
    End Sub

    Private Sub Button203_Click(sender As Object, e As EventArgs) Handles Button203.Click
        '
        TextBox1.Text = TextBox1.Text & "215;"

        Ripetizione_Default()
    End Sub

    Private Sub Button201_Click(sender As Object, e As EventArgs) Handles Button201.Click
        '<
        TextBox1.Text = TextBox1.Text & "60;"

        Ripetizione_Default()
    End Sub

    Private Sub Button200_Click(sender As Object, e As EventArgs) Handles Button200.Click
        '>
        TextBox1.Text = TextBox1.Text & "62;"

        Ripetizione_Default()
    End Sub

    Private Sub Button198_Click(sender As Object, e As EventArgs) Handles Button198.Click
        '=
        TextBox1.Text = TextBox1.Text & "61;"

        Ripetizione_Default()
    End Sub

    Private Sub Button199_Click(sender As Object, e As EventArgs) Handles Button199.Click
        '
        TextBox1.Text = TextBox1.Text & "8800;"

        Ripetizione_Default()
    End Sub

    Private Sub Button197_Click(sender As Object, e As EventArgs) Handles Button197.Click
        '
        TextBox1.Text = TextBox1.Text & "8804;"

        Ripetizione_Default()
    End Sub

    Private Sub Button196_Click(sender As Object, e As EventArgs) Handles Button196.Click
        '
        TextBox1.Text = TextBox1.Text & "8805;"

        Ripetizione_Default()
    End Sub

    Private Sub Button194_Click(sender As Object, e As EventArgs) Handles Button194.Click
        '
        TextBox1.Text = TextBox1.Text & "124;"

        Ripetizione_Default()
    End Sub

    Private Sub Button195_Click(sender As Object, e As EventArgs) Handles Button195.Click
        '
        TextBox1.Text = TextBox1.Text & "183;"

        Ripetizione_Default()
    End Sub

    Private Sub Button417_Click(sender As Object, e As EventArgs) Handles Button417.Click
        '
        TextBox1.Text = TextBox1.Text & "177;"

        Ripetizione_Default()
    End Sub

    Private Sub Button416_Click(sender As Object, e As EventArgs) Handles Button416.Click
        '
        TextBox1.Text = TextBox1.Text & "94;"

        Ripetizione_Default()
    End Sub

    Private Sub Button414_Click(sender As Object, e As EventArgs) Handles Button414.Click
        '
        TextBox1.Text = TextBox1.Text & "8744;"

        Ripetizione_Default()
    End Sub

    Private Sub Button415_Click(sender As Object, e As EventArgs) Handles Button415.Click
        '
        TextBox1.Text = TextBox1.Text & "8743;"

        Ripetizione_Default()
    End Sub

    Private Sub Button413_Click(sender As Object, e As EventArgs) Handles Button413.Click
        '
        TextBox1.Text = TextBox1.Text & "126;"

        Ripetizione_Default()
    End Sub

    Private Sub Button412_Click(sender As Object, e As EventArgs) Handles Button412.Click
        '
        TextBox1.Text = TextBox1.Text & "8773;"

        Ripetizione_Default()
    End Sub

    Private Sub Button410_Click(sender As Object, e As EventArgs) Handles Button410.Click
        '
        TextBox1.Text = TextBox1.Text & "8776;"

        Ripetizione_Default()
    End Sub

    Private Sub Button409_Click(sender As Object, e As EventArgs) Handles Button409.Click
        '
        TextBox1.Text = TextBox1.Text & "8801;"

        Ripetizione_Default()
    End Sub

    Private Sub Button362_Click(sender As Object, e As EventArgs) Handles Button362.Click
        '
        TextBox1.Text = TextBox1.Text & "8706;"

        Ripetizione_Default()
    End Sub

    Private Sub Button408_Click(sender As Object, e As EventArgs) Handles Button408.Click
        '
        TextBox1.Text = TextBox1.Text & "8869;"

        Ripetizione_Default()
    End Sub

    Private Sub Button406_Click(sender As Object, e As EventArgs) Handles Button406.Click
        '
        TextBox1.Text = TextBox1.Text & "8730;"

        Ripetizione_Default()
    End Sub

    Private Sub Button407_Click(sender As Object, e As EventArgs) Handles Button407.Click
        '%
        TextBox1.Text = TextBox1.Text & "37;"

        Ripetizione_Default()
    End Sub

    Private Sub Button405_Click(sender As Object, e As EventArgs) Handles Button405.Click
        '
        TextBox1.Text = TextBox1.Text & "137;"

        Ripetizione_Default()
    End Sub

    Private Sub Button404_Click(sender As Object, e As EventArgs) Handles Button404.Click
        '
        TextBox1.Text = TextBox1.Text & "947;"

        Ripetizione_Default()
    End Sub

    Private Sub Button402_Click(sender As Object, e As EventArgs) Handles Button402.Click
        '
        TextBox1.Text = TextBox1.Text & "946;"

        Ripetizione_Default()
    End Sub

    Private Sub Button403_Click(sender As Object, e As EventArgs) Handles Button403.Click
        '
        TextBox1.Text = TextBox1.Text & "947;"

        Ripetizione_Default()
    End Sub

    Private Sub Button401_Click(sender As Object, e As EventArgs) Handles Button401.Click
        '
        TextBox1.Text = TextBox1.Text & "955;"

        Ripetizione_Default()
    End Sub

    Private Sub Button400_Click(sender As Object, e As EventArgs) Handles Button400.Click
        '
        TextBox1.Text = TextBox1.Text & "954;"

        Ripetizione_Default()
    End Sub

    Private Sub Button398_Click(sender As Object, e As EventArgs) Handles Button398.Click
        '
        TextBox1.Text = TextBox1.Text & "181;"

        Ripetizione_Default()
    End Sub

    Private Sub Button399_Click(sender As Object, e As EventArgs) Handles Button399.Click
        '
        TextBox1.Text = TextBox1.Text & "960;"

        Ripetizione_Default()
    End Sub

    Private Sub Button397_Click(sender As Object, e As EventArgs) Handles Button397.Click
        '
        TextBox1.Text = TextBox1.Text & "966;"

        Ripetizione_Default()
    End Sub

    Private Sub Button396_Click(sender As Object, e As EventArgs) Handles Button396.Click
        '
        TextBox1.Text = TextBox1.Text & "937;"

        Ripetizione_Default()
    End Sub

    Private Sub Button394_Click(sender As Object, e As EventArgs) Handles Button394.Click
        '
        TextBox1.Text = TextBox1.Text & "916;"

        Ripetizione_Default()
    End Sub

    Private Sub Button395_Click(sender As Object, e As EventArgs) Handles Button395.Click
        '
        TextBox1.Text = TextBox1.Text & "931;"

        Ripetizione_Default()
    End Sub

    Private Sub Button393_Click(sender As Object, e As EventArgs) Handles Button393.Click
        '
        TextBox1.Text = TextBox1.Text & "934;"

        Ripetizione_Default()
    End Sub

    Private Sub Button392_Click(sender As Object, e As EventArgs) Handles Button392.Click
        '
        TextBox1.Text = TextBox1.Text & "8709;"

        Ripetizione_Default()
    End Sub

    Private Sub Button390_Click(sender As Object, e As EventArgs) Handles Button390.Click
        '
        TextBox1.Text = TextBox1.Text & "8711;"

        Ripetizione_Default()
    End Sub

    Private Sub Button391_Click(sender As Object, e As EventArgs) Handles Button391.Click
        '
        TextBox1.Text = TextBox1.Text & "8707;"

        Ripetizione_Default()
    End Sub

    Private Sub Button389_Click(sender As Object, e As EventArgs) Handles Button389.Click
        '
        TextBox1.Text = TextBox1.Text & "8704;"

        Ripetizione_Default()
    End Sub

    Private Sub Button388_Click(sender As Object, e As EventArgs) Handles Button388.Click
        '
        TextBox1.Text = TextBox1.Text & "8712;"

        Ripetizione_Default()
    End Sub

    Private Sub Button386_Click(sender As Object, e As EventArgs) Handles Button386.Click
        '
        TextBox1.Text = TextBox1.Text & "8715;"

        Ripetizione_Default()
    End Sub

    Private Sub Button387_Click(sender As Object, e As EventArgs) Handles Button387.Click
        '
        TextBox1.Text = TextBox1.Text & "8713;"

        Ripetizione_Default()
    End Sub

    Private Sub Button385_Click(sender As Object, e As EventArgs) Handles Button385.Click
        '
        TextBox1.Text = TextBox1.Text & "8734;"

        Ripetizione_Default()
    End Sub

    Private Sub Button384_Click(sender As Object, e As EventArgs) Handles Button384.Click
        '
        TextBox1.Text = TextBox1.Text & "8658;"

        Ripetizione_Default()
    End Sub

    Private Sub Button382_Click(sender As Object, e As EventArgs) Handles Button382.Click
        '
        TextBox1.Text = TextBox1.Text & "8656;"

        Ripetizione_Default()
    End Sub

    Private Sub Button383_Click(sender As Object, e As EventArgs) Handles Button383.Click
        '
        TextBox1.Text = TextBox1.Text & "8657;"

        Ripetizione_Default()
    End Sub

    Private Sub Button381_Click(sender As Object, e As EventArgs) Handles Button381.Click
        '
        TextBox1.Text = TextBox1.Text & "8659;"

        Ripetizione_Default()
    End Sub

    Private Sub Button380_Click(sender As Object, e As EventArgs) Handles Button380.Click
        '
        TextBox1.Text = TextBox1.Text & "8660;"

        Ripetizione_Default()
    End Sub

    Private Sub Button378_Click(sender As Object, e As EventArgs) Handles Button378.Click
        '
        TextBox1.Text = TextBox1.Text & "131;"

        Ripetizione_Default()
    End Sub

    Private Sub Button379_Click(sender As Object, e As EventArgs) Handles Button379.Click
        '
        TextBox1.Text = TextBox1.Text & "186;"

        Ripetizione_Default()
    End Sub

    Private Sub Button377_Click(sender As Object, e As EventArgs) Handles Button377.Click
        '
        TextBox1.Text = TextBox1.Text & "185;"

        Ripetizione_Default()
    End Sub

    Private Sub Button376_Click(sender As Object, e As EventArgs) Handles Button376.Click
        '
        TextBox1.Text = TextBox1.Text & "178;"

        Ripetizione_Default()
    End Sub

    Private Sub Button374_Click(sender As Object, e As EventArgs) Handles Button374.Click
        '
        TextBox1.Text = TextBox1.Text & "179;"

        Ripetizione_Default()
    End Sub

    Private Sub Button375_Click(sender As Object, e As EventArgs) Handles Button375.Click
        '
        TextBox1.Text = TextBox1.Text & "170;"

        Ripetizione_Default()
    End Sub

    Private Sub Button373_Click(sender As Object, e As EventArgs) Handles Button373.Click
        '
        TextBox1.Text = TextBox1.Text & "189;"

        Ripetizione_Default()
    End Sub

    Private Sub Button372_Click(sender As Object, e As EventArgs) Handles Button372.Click
        '
        TextBox1.Text = TextBox1.Text & "188;"

        Ripetizione_Default()
    End Sub

    Private Sub Button370_Click(sender As Object, e As EventArgs) Handles Button370.Click
        '
        TextBox1.Text = TextBox1.Text & "190;"

        Ripetizione_Default()
    End Sub

    Private Sub Button371_Click(sender As Object, e As EventArgs) Handles Button371.Click
        '
        TextBox1.Text = TextBox1.Text & "8745;"

        Ripetizione_Default()
    End Sub

    Private Sub Button369_Click(sender As Object, e As EventArgs) Handles Button369.Click
        '
        TextBox1.Text = TextBox1.Text & "8746;"

        Ripetizione_Default()
    End Sub

    Private Sub Button368_Click(sender As Object, e As EventArgs) Handles Button368.Click
        '
        TextBox1.Text = TextBox1.Text & "8834;"

        Ripetizione_Default()
    End Sub

    Private Sub Button366_Click(sender As Object, e As EventArgs) Handles Button366.Click
        '
        TextBox1.Text = TextBox1.Text & "8838;"

        Ripetizione_Default()
    End Sub

    Private Sub Button367_Click(sender As Object, e As EventArgs) Handles Button367.Click
        '
        TextBox1.Text = TextBox1.Text & "8835;"

        Ripetizione_Default()
    End Sub

    Private Sub Button365_Click(sender As Object, e As EventArgs) Handles Button365.Click
        '
        TextBox1.Text = TextBox1.Text & "8839;"

        Ripetizione_Default()
    End Sub

    Private Sub Button364_Click(sender As Object, e As EventArgs) Handles Button364.Click
        '
        TextBox1.Text = TextBox1.Text & "8836;"

        Ripetizione_Default()
    End Sub

    Private Sub Button138_Click(sender As Object, e As EventArgs) Handles Button138.Click
        '
        TextBox1.Text = TextBox1.Text & "8474;"

        Ripetizione_Default()
    End Sub

    Private Sub Button137_Click(sender As Object, e As EventArgs) Handles Button137.Click
        '
        TextBox1.Text = TextBox1.Text & "8484;"

        Ripetizione_Default()
    End Sub

    Private Sub Button136_Click(sender As Object, e As EventArgs) Handles Button136.Click
        '
        TextBox1.Text = TextBox1.Text & "8469;"

        Ripetizione_Default()
    End Sub

    Private Sub Button134_Click(sender As Object, e As EventArgs) Handles Button134.Click
        '
        TextBox1.Text = TextBox1.Text & "8476;"

        Ripetizione_Default()
    End Sub

    Private Sub Button135_Click(sender As Object, e As EventArgs) Handles Button135.Click
        '
        TextBox1.Text = TextBox1.Text & "8465;"

        Ripetizione_Default()
    End Sub

    Private Sub Button321_Click(sender As Object, e As EventArgs) Handles Button321.Click
        '$
        TextBox1.Text = TextBox1.Text & "36;"

        Ripetizione_Default()
    End Sub

    Private Sub Button320_Click(sender As Object, e As EventArgs) Handles Button320.Click
        '£
        TextBox1.Text = TextBox1.Text & "163;"

        Ripetizione_Default()
    End Sub

    Private Sub Button140_Click(sender As Object, e As EventArgs) Handles Button140.Click
        '€
        TextBox1.Text = TextBox1.Text & "128;"

        Ripetizione_Default()
    End Sub

    Private Sub Button319_Click(sender As Object, e As EventArgs) Handles Button319.Click
        '
        TextBox1.Text = TextBox1.Text & "165;"

        Ripetizione_Default()
    End Sub

    Private Sub Button317_Click(sender As Object, e As EventArgs) Handles Button317.Click
        '
        TextBox1.Text = TextBox1.Text & "164;"

        Ripetizione_Default()
    End Sub

    Private Sub Button316_Click(sender As Object, e As EventArgs) Handles Button316.Click
        '
        TextBox1.Text = TextBox1.Text & "162;"

        Ripetizione_Default()
    End Sub

    Private Sub Button314_Click(sender As Object, e As EventArgs) Handles Button314.Click
        '
        TextBox1.Text = TextBox1.Text & "131;"

        Ripetizione_Default()
    End Sub

    Private Sub Button301_Click(sender As Object, e As EventArgs) Handles Button301.Click
        '
        TextBox1.Text = TextBox1.Text & "9693;"

        Ripetizione_Default()
    End Sub

    Private Sub Button449_Click(sender As Object, e As EventArgs) Handles Button449.Click
        '
        TextBox1.Text = TextBox1.Text & "945;"

        Ripetizione_Default()
    End Sub

    Private Sub Button448_Click(sender As Object, e As EventArgs) Handles Button448.Click
        '
        TextBox1.Text = TextBox1.Text & "946;"

        Ripetizione_Default()
    End Sub

    Private Sub Button446_Click(sender As Object, e As EventArgs) Handles Button446.Click
        '
        TextBox1.Text = TextBox1.Text & "947;"

        Ripetizione_Default()
    End Sub

    Private Sub Button447_Click(sender As Object, e As EventArgs) Handles Button447.Click
        '
        TextBox1.Text = TextBox1.Text & "948;"

        Ripetizione_Default()
    End Sub

    Private Sub Button445_Click(sender As Object, e As EventArgs) Handles Button445.Click
        '
        TextBox1.Text = TextBox1.Text & "949;"

        Ripetizione_Default()
    End Sub

    Private Sub Button444_Click(sender As Object, e As EventArgs) Handles Button444.Click
        '
        TextBox1.Text = TextBox1.Text & "950;"

        Ripetizione_Default()
    End Sub

    Private Sub Button442_Click(sender As Object, e As EventArgs) Handles Button442.Click
        '
        TextBox1.Text = TextBox1.Text & "951;"

        Ripetizione_Default()
    End Sub

    Private Sub Button443_Click(sender As Object, e As EventArgs) Handles Button443.Click
        '
        TextBox1.Text = TextBox1.Text & "952;"

        Ripetizione_Default()
    End Sub

    Private Sub Button441_Click(sender As Object, e As EventArgs) Handles Button441.Click
        '
        TextBox1.Text = TextBox1.Text & "953;"

        Ripetizione_Default()
    End Sub

    Private Sub Button440_Click(sender As Object, e As EventArgs) Handles Button440.Click
        '
        TextBox1.Text = TextBox1.Text & "954;"

        Ripetizione_Default()
    End Sub

    Private Sub Button438_Click(sender As Object, e As EventArgs) Handles Button438.Click
        '
        TextBox1.Text = TextBox1.Text & "955;"

        Ripetizione_Default()
    End Sub

    Private Sub Button439_Click(sender As Object, e As EventArgs) Handles Button439.Click
        '
        TextBox1.Text = TextBox1.Text & "956;"

        Ripetizione_Default()
    End Sub

    Private Sub Button437_Click(sender As Object, e As EventArgs) Handles Button437.Click
        '
        TextBox1.Text = TextBox1.Text & "957;"

        Ripetizione_Default()
    End Sub

    Private Sub Button436_Click(sender As Object, e As EventArgs) Handles Button436.Click
        '
        TextBox1.Text = TextBox1.Text & "958;"

        Ripetizione_Default()
    End Sub

    Private Sub Button434_Click(sender As Object, e As EventArgs) Handles Button434.Click
        '
        TextBox1.Text = TextBox1.Text & "959;"

        Ripetizione_Default()
    End Sub

    Private Sub Button435_Click(sender As Object, e As EventArgs) Handles Button435.Click
        '
        TextBox1.Text = TextBox1.Text & "960;"

        Ripetizione_Default()
    End Sub

    Private Sub Button433_Click(sender As Object, e As EventArgs) Handles Button433.Click
        '
        TextBox1.Text = TextBox1.Text & "961;"

        Ripetizione_Default()
    End Sub

    Private Sub Button432_Click(sender As Object, e As EventArgs) Handles Button432.Click
        '
        TextBox1.Text = TextBox1.Text & "962;"

        Ripetizione_Default()
    End Sub

    Private Sub Button430_Click(sender As Object, e As EventArgs) Handles Button430.Click
        '
        TextBox1.Text = TextBox1.Text & "963;"

        Ripetizione_Default()
    End Sub

    Private Sub Button431_Click(sender As Object, e As EventArgs) Handles Button431.Click
        '
        TextBox1.Text = TextBox1.Text & "964;"

        Ripetizione_Default()
    End Sub

    Private Sub Button429_Click(sender As Object, e As EventArgs) Handles Button429.Click
        '
        TextBox1.Text = TextBox1.Text & "965;"

        Ripetizione_Default()
    End Sub

    Private Sub Button428_Click(sender As Object, e As EventArgs) Handles Button428.Click
        '
        TextBox1.Text = TextBox1.Text & "966;"

        Ripetizione_Default()
    End Sub

    Private Sub Button426_Click(sender As Object, e As EventArgs) Handles Button426.Click
        '
        TextBox1.Text = TextBox1.Text & "967;"

        Ripetizione_Default()
    End Sub

    Private Sub Button427_Click(sender As Object, e As EventArgs) Handles Button427.Click
        '
        TextBox1.Text = TextBox1.Text & "968;"

        Ripetizione_Default()
    End Sub

    Private Sub Button425_Click(sender As Object, e As EventArgs) Handles Button425.Click
        '
        TextBox1.Text = TextBox1.Text & "969;"

        Ripetizione_Default()
    End Sub

    Private Sub Button424_Click(sender As Object, e As EventArgs) Handles Button424.Click
        '
        TextBox1.Text = TextBox1.Text & "913;"

        Ripetizione_Default()
    End Sub

    Private Sub Button422_Click(sender As Object, e As EventArgs) Handles Button422.Click
        '
        TextBox1.Text = TextBox1.Text & "914;"

        Ripetizione_Default()
    End Sub

    Private Sub Button423_Click(sender As Object, e As EventArgs) Handles Button423.Click
        '
        TextBox1.Text = TextBox1.Text & "915;"

        Ripetizione_Default()
    End Sub

    Private Sub Button421_Click(sender As Object, e As EventArgs) Handles Button421.Click
        '
        TextBox1.Text = TextBox1.Text & "916;"

        Ripetizione_Default()
    End Sub

    Private Sub Button420_Click(sender As Object, e As EventArgs) Handles Button420.Click
        '
        TextBox1.Text = TextBox1.Text & "917;"

        Ripetizione_Default()
    End Sub

    Private Sub Button418_Click(sender As Object, e As EventArgs) Handles Button418.Click
        '
        TextBox1.Text = TextBox1.Text & "918;"

        Ripetizione_Default()
    End Sub

    Private Sub Button419_Click(sender As Object, e As EventArgs) Handles Button419.Click
        '
        TextBox1.Text = TextBox1.Text & "919;"

        Ripetizione_Default()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        '
        TextBox1.Text = TextBox1.Text & "920;"

        Ripetizione_Default()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        '
        TextBox1.Text = TextBox1.Text & "921;"

        Ripetizione_Default()
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        '
        TextBox1.Text = TextBox1.Text & "922;"

        Ripetizione_Default()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        '
        TextBox1.Text = TextBox1.Text & "923;"

        Ripetizione_Default()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        '
        TextBox1.Text = TextBox1.Text & "924;"

        Ripetizione_Default()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        '
        TextBox1.Text = TextBox1.Text & "925;"

        Ripetizione_Default()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        '
        TextBox1.Text = TextBox1.Text & "926;"

        Ripetizione_Default()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        '
        TextBox1.Text = TextBox1.Text & "927;"

        Ripetizione_Default()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        '
        TextBox1.Text = TextBox1.Text & "928;"

        Ripetizione_Default()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        '
        TextBox1.Text = TextBox1.Text & "929;"

        Ripetizione_Default()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        '
        TextBox1.Text = TextBox1.Text & "931;"

        Ripetizione_Default()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        '
        TextBox1.Text = TextBox1.Text & "932;"

        Ripetizione_Default()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        '
        TextBox1.Text = TextBox1.Text & "933;"

        Ripetizione_Default()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        '
        TextBox1.Text = TextBox1.Text & "934;"

        Ripetizione_Default()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        '
        TextBox1.Text = TextBox1.Text & "935;"

        Ripetizione_Default()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        '
        TextBox1.Text = TextBox1.Text & "936;"

        Ripetizione_Default()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        '
        TextBox1.Text = TextBox1.Text & "937;"

        Ripetizione_Default()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        '
        TextBox1.Text = TextBox1.Text & "976;"

        Ripetizione_Default()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        '
        TextBox1.Text = TextBox1.Text & "977;"

        Ripetizione_Default()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        '
        TextBox1.Text = TextBox1.Text & "978;"

        Ripetizione_Default()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        '
        TextBox1.Text = TextBox1.Text & "981;"

        Ripetizione_Default()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '
        TextBox1.Text = TextBox1.Text & "979;"

        Ripetizione_Default()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '
        TextBox1.Text = TextBox1.Text & "984;"

        Ripetizione_Default()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '
        TextBox1.Text = TextBox1.Text & "988;"

        Ripetizione_Default()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '
        TextBox1.Text = TextBox1.Text & "8501;"

        Ripetizione_Default()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '
        TextBox1.Text = TextBox1.Text & "994;"

        Ripetizione_Default()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '
        TextBox1.Text = TextBox1.Text & "995;"

        Ripetizione_Default()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '
        TextBox1.Text = TextBox1.Text & "1002;"

        Ripetizione_Default()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '
        TextBox1.Text = TextBox1.Text & "1003;"

        Ripetizione_Default()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '
        TextBox1.Text = TextBox1.Text & "1015;"

        Ripetizione_Default()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '
        TextBox1.Text = TextBox1.Text & "1016;"

        Ripetizione_Default()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '
        TextBox1.Text = TextBox1.Text & "1004;"

        Ripetizione_Default()
    End Sub

    Private Sub Button227_Click(sender As Object, e As EventArgs) Handles Button227.Click
        Process.Start("http://minionone.altervista.org/Wiki/TutteLeFunzioni/CaratteriSpeciali/")
    End Sub

    Private Sub Button247_Click(sender As Object, e As EventArgs) Handles Button247.Click
        TextBox1.Text = TextBox1.Text & "8363;"

        Ripetizione_Default()
    End Sub

    Private Sub Button248_Click(sender As Object, e As EventArgs) Handles Button248.Click
        TextBox1.Text = TextBox1.Text & "8362;"

        Ripetizione_Default()
    End Sub

    Private Sub Button235_Click(sender As Object, e As EventArgs) Handles Button235.Click
        TextBox1.Text = TextBox1.Text & "8365;"

        Ripetizione_Default()
    End Sub

    Private Sub Button236_Click(sender As Object, e As EventArgs) Handles Button236.Click
        TextBox1.Text = TextBox1.Text & "8373;"

        Ripetizione_Default()
    End Sub

    Private Sub Button237_Click(sender As Object, e As EventArgs) Handles Button237.Click
        TextBox1.Text = TextBox1.Text & "8371;"

        Ripetizione_Default()
    End Sub

    Private Sub Button238_Click(sender As Object, e As EventArgs) Handles Button238.Click
        TextBox1.Text = TextBox1.Text & "8369;"

        Ripetizione_Default()
    End Sub

    Private Sub Button239_Click(sender As Object, e As EventArgs) Handles Button239.Click
        TextBox1.Text = TextBox1.Text & "8370;"

        Ripetizione_Default()
    End Sub

    Private Sub Button240_Click(sender As Object, e As EventArgs) Handles Button240.Click
        TextBox1.Text = TextBox1.Text & "8368;"

        Ripetizione_Default()
    End Sub

    Private Sub Button241_Click(sender As Object, e As EventArgs) Handles Button241.Click
        TextBox1.Text = TextBox1.Text & "8366;"

        Ripetizione_Default()
    End Sub

    Private Sub Button229_Click(sender As Object, e As EventArgs) Handles Button229.Click
        TextBox1.Text = TextBox1.Text & "8367;"

        Ripetizione_Default()
    End Sub

    Private Sub Button230_Click(sender As Object, e As EventArgs) Handles Button230.Click
        TextBox1.Text = TextBox1.Text & "8372;"

        Ripetizione_Default()
    End Sub

    Private Sub Button231_Click(sender As Object, e As EventArgs) Handles Button231.Click
        TextBox1.Text = TextBox1.Text & "8361;"

        Ripetizione_Default()
    End Sub

    Private Sub Button232_Click(sender As Object, e As EventArgs) Handles Button232.Click
        TextBox1.Text = TextBox1.Text & "x20B9;"

        Ripetizione_Default()
    End Sub

    Private Sub Button233_Click(sender As Object, e As EventArgs) Handles Button233.Click
        TextBox1.Text = TextBox1.Text & "8359;"

        Ripetizione_Default()
    End Sub

    Private Sub Button234_Click(sender As Object, e As EventArgs) Handles Button234.Click
        TextBox1.Text = TextBox1.Text & "8356;"

        Ripetizione_Default()
    End Sub

    Private Sub Button228_Click(sender As Object, e As EventArgs) Handles Button228.Click
        TextBox1.Text = TextBox1.Text & "8355;"

        Ripetizione_Default()
    End Sub
End Class