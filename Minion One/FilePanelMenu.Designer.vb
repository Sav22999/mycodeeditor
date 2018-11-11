<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilePanelMenu
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
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilePanelMenu))
        Me.SalvaTutto = New System.Windows.Forms.Button()
        Me.Nuovo = New System.Windows.Forms.Button()
        Me.Chiudi = New System.Windows.Forms.Button()
        Me.Salva = New System.Windows.Forms.Button()
        Me.Apri = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SalvaTutto
        '
        Me.SalvaTutto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalvaTutto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SalvaTutto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SalvaTutto.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.SalvaTutto.FlatAppearance.BorderSize = 0
        Me.SalvaTutto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.SalvaTutto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SalvaTutto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalvaTutto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalvaTutto.ForeColor = System.Drawing.Color.DarkRed
        Me.SalvaTutto.Image = CType(resources.GetObject("SalvaTutto.Image"), System.Drawing.Image)
        Me.SalvaTutto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SalvaTutto.Location = New System.Drawing.Point(0, 66)
        Me.SalvaTutto.Name = "SalvaTutto"
        Me.SalvaTutto.Size = New System.Drawing.Size(145, 22)
        Me.SalvaTutto.TabIndex = 12
        Me.SalvaTutto.Text = "Salva tutto"
        Me.SalvaTutto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SalvaTutto.UseVisualStyleBackColor = False
        '
        'Nuovo
        '
        Me.Nuovo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nuovo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Nuovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Nuovo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Nuovo.FlatAppearance.BorderSize = 0
        Me.Nuovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Nuovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Nuovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuovo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuovo.ForeColor = System.Drawing.Color.DarkRed
        Me.Nuovo.Image = CType(resources.GetObject("Nuovo.Image"), System.Drawing.Image)
        Me.Nuovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Nuovo.Location = New System.Drawing.Point(0, 0)
        Me.Nuovo.Name = "Nuovo"
        Me.Nuovo.Size = New System.Drawing.Size(145, 22)
        Me.Nuovo.TabIndex = 14
        Me.Nuovo.Text = "Nuovo..."
        Me.Nuovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Nuovo.UseVisualStyleBackColor = False
        '
        'Chiudi
        '
        Me.Chiudi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chiudi.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Chiudi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Chiudi.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Chiudi.FlatAppearance.BorderSize = 0
        Me.Chiudi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Chiudi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Chiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Chiudi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chiudi.ForeColor = System.Drawing.Color.DarkRed
        Me.Chiudi.Image = CType(resources.GetObject("Chiudi.Image"), System.Drawing.Image)
        Me.Chiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Chiudi.Location = New System.Drawing.Point(0, 88)
        Me.Chiudi.Name = "Chiudi"
        Me.Chiudi.Size = New System.Drawing.Size(145, 22)
        Me.Chiudi.TabIndex = 13
        Me.Chiudi.Text = "Chiudi"
        Me.Chiudi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Chiudi.UseVisualStyleBackColor = False
        '
        'Salva
        '
        Me.Salva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salva.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Salva.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Salva.FlatAppearance.BorderSize = 0
        Me.Salva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Salva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salva.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salva.ForeColor = System.Drawing.Color.DarkRed
        Me.Salva.Image = CType(resources.GetObject("Salva.Image"), System.Drawing.Image)
        Me.Salva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Salva.Location = New System.Drawing.Point(0, 44)
        Me.Salva.Name = "Salva"
        Me.Salva.Size = New System.Drawing.Size(145, 22)
        Me.Salva.TabIndex = 11
        Me.Salva.Text = "Salva"
        Me.Salva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Salva.UseVisualStyleBackColor = False
        '
        'Apri
        '
        Me.Apri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Apri.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Apri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Apri.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Apri.FlatAppearance.BorderSize = 0
        Me.Apri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Apri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Apri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Apri.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apri.ForeColor = System.Drawing.Color.DarkRed
        Me.Apri.Image = CType(resources.GetObject("Apri.Image"), System.Drawing.Image)
        Me.Apri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Apri.Location = New System.Drawing.Point(0, 22)
        Me.Apri.Name = "Apri"
        Me.Apri.Size = New System.Drawing.Size(145, 22)
        Me.Apri.TabIndex = 10
        Me.Apri.Text = "Apri..."
        Me.Apri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Apri.UseVisualStyleBackColor = False
        '
        'FilePanelMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(145, 110)
        Me.Controls.Add(Me.Nuovo)
        Me.Controls.Add(Me.Chiudi)
        Me.Controls.Add(Me.SalvaTutto)
        Me.Controls.Add(Me.Salva)
        Me.Controls.Add(Me.Apri)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FilePanelMenu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "File"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chiudi As Button
    Friend WithEvents SalvaTutto As Button
    Friend WithEvents Salva As Button
    Friend WithEvents Apri As Button
    Friend WithEvents Nuovo As Button
End Class
