<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cercaesostituisci
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cercaesostituisci))
        Me.Button8 = New System.Windows.Forms.Button()
        Me.cerca = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.sostituisci = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.Navy
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = Global.MinionOne.My.Resources.Resources.cerca
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(11, 105)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(208, 36)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Cerca e sostituisci"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button8, "Cerca e sostituisci la parola o la frase" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(non chiederà conferma)")
        Me.Button8.UseVisualStyleBackColor = False
        '
        'cerca
        '
        Me.cerca.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cerca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerca.ForeColor = System.Drawing.Color.Navy
        Me.cerca.Location = New System.Drawing.Point(11, 31)
        Me.cerca.Name = "cerca"
        Me.cerca.Size = New System.Drawing.Size(405, 31)
        Me.cerca.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cerca, "Inserisci la parola o la frase da ricercare nel progetto che sarà sostituita")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Cyan
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Navy
        Me.TextBox1.Location = New System.Drawing.Point(381, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(35, 31)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Visible = False
        '
        'sostituisci
        '
        Me.sostituisci.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sostituisci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sostituisci.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sostituisci.ForeColor = System.Drawing.Color.Navy
        Me.sostituisci.Location = New System.Drawing.Point(11, 68)
        Me.sostituisci.Name = "sostituisci"
        Me.sostituisci.Size = New System.Drawing.Size(405, 31)
        Me.sostituisci.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.sostituisci, "Inserisci la parola o la frase da sostituire a quella ricercata")
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Aqua
        Me.ToolTip1.ForeColor = System.Drawing.Color.Navy
        Me.ToolTip1.ToolTipTitle = "Informazioni"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Cyan
        Me.PictureBox4.BackgroundImage = Global.MinionOne.My.Resources.Resources.iconaMINIONONE
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.TabIndex = 82
        Me.PictureBox4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 123)
        Me.Panel2.TabIndex = 79
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Cyan
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(423, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 123)
        Me.Panel1.TabIndex = 78
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Cyan
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(428, 25)
        Me.Button1.TabIndex = 80
        Me.Button1.Text = "     Cerca e sostituisci"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Aqua
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 148)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(428, 5)
        Me.Panel4.TabIndex = 81
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Cyan
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Navy
        Me.Button3.Location = New System.Drawing.Point(340, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 22)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "-"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Cyan
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Location = New System.Drawing.Point(377, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 22)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "×"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Cercaesostituisci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(428, 153)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.sostituisci)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cerca)
        Me.Controls.Add(Me.Button8)
        Me.ForeColor = System.Drawing.Color.Aqua
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cercaesostituisci"
        Me.Text = "Cerca e sostituisci..."
        Me.TopMost = True
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents cerca As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents sostituisci As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
