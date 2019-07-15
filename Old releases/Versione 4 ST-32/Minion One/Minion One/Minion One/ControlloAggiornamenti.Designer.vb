<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlloAggiornamenti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlloAggiornamenti))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.ScaricaButton = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.InstallaButton = New System.Windows.Forms.Button()
        Me.ScaricaDopoButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(105, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 10)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.Red
        Me.Panel2.Location = New System.Drawing.Point(121, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 10)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Location = New System.Drawing.Point(137, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 10)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Location = New System.Drawing.Point(153, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 10)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.Location = New System.Drawing.Point(169, 6)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 10)
        Me.Panel5.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel6.BackColor = System.Drawing.Color.Red
        Me.Panel6.Location = New System.Drawing.Point(185, 6)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 10)
        Me.Panel6.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(8, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(284, 38)
        Me.Button1.TabIndex = 419
        Me.Button1.TabStop = False
        Me.Button1.Text = "Ricerca di aggiornamenti in corso..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'ScaricaButton
        '
        Me.ScaricaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScaricaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ScaricaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ScaricaButton.Enabled = False
        Me.ScaricaButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.ScaricaButton.FlatAppearance.BorderSize = 0
        Me.ScaricaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ScaricaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ScaricaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScaricaButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScaricaButton.Location = New System.Drawing.Point(212, 8)
        Me.ScaricaButton.Name = "ScaricaButton"
        Me.ScaricaButton.Size = New System.Drawing.Size(81, 22)
        Me.ScaricaButton.TabIndex = 420
        Me.ScaricaButton.Text = "Scarica"
        Me.ScaricaButton.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.DarkRed
        Me.Panel7.Controls.Add(Me.InstallaButton)
        Me.Panel7.Controls.Add(Me.ScaricaDopoButton)
        Me.Panel7.Controls.Add(Me.ScaricaButton)
        Me.Panel7.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel7.Location = New System.Drawing.Point(0, 65)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(300, 37)
        Me.Panel7.TabIndex = 421
        '
        'InstallaButton
        '
        Me.InstallaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstallaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.InstallaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.InstallaButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.InstallaButton.FlatAppearance.BorderSize = 0
        Me.InstallaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.InstallaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.InstallaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InstallaButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstallaButton.Location = New System.Drawing.Point(212, 8)
        Me.InstallaButton.Name = "InstallaButton"
        Me.InstallaButton.Size = New System.Drawing.Size(81, 22)
        Me.InstallaButton.TabIndex = 422
        Me.InstallaButton.Text = "Installa"
        Me.InstallaButton.UseVisualStyleBackColor = False
        Me.InstallaButton.Visible = False
        '
        'ScaricaDopoButton
        '
        Me.ScaricaDopoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScaricaDopoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ScaricaDopoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ScaricaDopoButton.Enabled = False
        Me.ScaricaDopoButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.ScaricaDopoButton.FlatAppearance.BorderSize = 0
        Me.ScaricaDopoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ScaricaDopoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ScaricaDopoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScaricaDopoButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScaricaDopoButton.Location = New System.Drawing.Point(95, 8)
        Me.ScaricaDopoButton.Name = "ScaricaDopoButton"
        Me.ScaricaDopoButton.Size = New System.Drawing.Size(111, 22)
        Me.ScaricaDopoButton.TabIndex = 421
        Me.ScaricaDopoButton.Text = "Scarica dopo"
        Me.ScaricaDopoButton.UseVisualStyleBackColor = False
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Minion One"
        Me.SaveFileDialog1.FilterIndex = 5
        Me.SaveFileDialog1.RestoreDirectory = True
        Me.SaveFileDialog1.Title = "Minion One"
        '
        'Panel8
        '
        Me.Panel8.Location = New System.Drawing.Point(54, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 21)
        Me.Panel8.TabIndex = 422
        Me.Panel8.Visible = False
        '
        'ControlloAggiornamenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(300, 102)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ControlloAggiornamenti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controllo degli aggiornamenti"
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ScaricaButton As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ScaricaDopoButton As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents InstallaButton As System.Windows.Forms.Button
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
