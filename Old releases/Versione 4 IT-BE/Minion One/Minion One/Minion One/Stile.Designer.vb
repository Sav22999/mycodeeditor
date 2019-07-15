<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stile))
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Stile4 = New System.Windows.Forms.Button()
        Me.Stile3 = New System.Windows.Forms.Button()
        Me.Dove = New System.Windows.Forms.TextBox()
        Me.StileTB = New System.Windows.Forms.TextBox()
        Me.Stile2 = New System.Windows.Forms.Button()
        Me.Stile1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.DarkRed
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.Location = New System.Drawing.Point(142, 100)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(72, 22)
        Me.Button10.TabIndex = 394
        Me.Button10.Text = "Ok"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Stile4
        '
        Me.Stile4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Stile4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Stile4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Stile4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Stile4.FlatAppearance.BorderSize = 0
        Me.Stile4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Stile4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Stile4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stile4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stile4.ForeColor = System.Drawing.Color.DarkRed
        Me.Stile4.Image = Global.Minion_One.My.Resources.Resources.tratteggiata
        Me.Stile4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Stile4.Location = New System.Drawing.Point(5, 74)
        Me.Stile4.Name = "Stile4"
        Me.Stile4.Size = New System.Drawing.Size(209, 22)
        Me.Stile4.TabIndex = 391
        Me.Stile4.Text = "Tratteggiata"
        Me.Stile4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Stile4.UseVisualStyleBackColor = False
        '
        'Stile3
        '
        Me.Stile3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Stile3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Stile3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Stile3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Stile3.FlatAppearance.BorderSize = 0
        Me.Stile3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Stile3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Stile3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stile3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stile3.ForeColor = System.Drawing.Color.DarkRed
        Me.Stile3.Image = Global.Minion_One.My.Resources.Resources.punteggiata
        Me.Stile3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Stile3.Location = New System.Drawing.Point(5, 51)
        Me.Stile3.Name = "Stile3"
        Me.Stile3.Size = New System.Drawing.Size(209, 22)
        Me.Stile3.TabIndex = 390
        Me.Stile3.Text = "Punteggiata"
        Me.Stile3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Stile3.UseVisualStyleBackColor = False
        '
        'Dove
        '
        Me.Dove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Dove.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Dove.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dove.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dove.ForeColor = System.Drawing.Color.DarkRed
        Me.Dove.Location = New System.Drawing.Point(75, 100)
        Me.Dove.Name = "Dove"
        Me.Dove.Size = New System.Drawing.Size(62, 22)
        Me.Dove.TabIndex = 396
        Me.Dove.Visible = False
        '
        'StileTB
        '
        Me.StileTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StileTB.BackColor = System.Drawing.Color.WhiteSmoke
        Me.StileTB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StileTB.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StileTB.ForeColor = System.Drawing.Color.DarkRed
        Me.StileTB.Location = New System.Drawing.Point(5, 100)
        Me.StileTB.Name = "StileTB"
        Me.StileTB.Size = New System.Drawing.Size(64, 22)
        Me.StileTB.TabIndex = 395
        Me.StileTB.Visible = False
        '
        'Stile2
        '
        Me.Stile2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Stile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Stile2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Stile2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Stile2.FlatAppearance.BorderSize = 0
        Me.Stile2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Stile2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Stile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stile2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stile2.ForeColor = System.Drawing.Color.DarkRed
        Me.Stile2.Image = CType(resources.GetObject("Stile2.Image"), System.Drawing.Image)
        Me.Stile2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Stile2.Location = New System.Drawing.Point(5, 28)
        Me.Stile2.Name = "Stile2"
        Me.Stile2.Size = New System.Drawing.Size(209, 22)
        Me.Stile2.TabIndex = 389
        Me.Stile2.Text = "Continua doppia"
        Me.Stile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Stile2.UseVisualStyleBackColor = False
        '
        'Stile1
        '
        Me.Stile1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Stile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Stile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Stile1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Stile1.FlatAppearance.BorderSize = 0
        Me.Stile1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Stile1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Stile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stile1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stile1.ForeColor = System.Drawing.Color.DarkRed
        Me.Stile1.Image = Global.Minion_One.My.Resources.Resources.continua
        Me.Stile1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Stile1.Location = New System.Drawing.Point(5, 5)
        Me.Stile1.Name = "Stile1"
        Me.Stile1.Size = New System.Drawing.Size(209, 22)
        Me.Stile1.TabIndex = 388
        Me.Stile1.Text = "Continua"
        Me.Stile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Stile1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(5, 100)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(109, 22)
        Me.PictureBox2.TabIndex = 397
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Minion_One.My.Resources.Resources.niente
        Me.Panel1.Location = New System.Drawing.Point(12, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(22, 22)
        Me.Panel1.TabIndex = 422
        Me.Panel1.Visible = False
        '
        'Stile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(219, 128)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Dove)
        Me.Controls.Add(Me.StileTB)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Stile4)
        Me.Controls.Add(Me.Stile3)
        Me.Controls.Add(Me.Stile2)
        Me.Controls.Add(Me.Stile1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Stile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stile"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Stile4 As System.Windows.Forms.Button
    Friend WithEvents Stile3 As System.Windows.Forms.Button
    Friend WithEvents Stile2 As System.Windows.Forms.Button
    Friend WithEvents Stile1 As System.Windows.Forms.Button
    Friend WithEvents Dove As System.Windows.Forms.TextBox
    Friend WithEvents StileTB As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
