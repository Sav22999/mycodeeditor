<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessaggioF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessaggioF))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErroreTxt = New System.Windows.Forms.TextBox()
        Me.DettagliErroreButton = New System.Windows.Forms.Button()
        Me.ChiudiMessaggio = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(389, 80)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.ErroreTxt)
        Me.Panel1.Controls.Add(Me.DettagliErroreButton)
        Me.Panel1.Controls.Add(Me.ChiudiMessaggio)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(389, 38)
        Me.Panel1.TabIndex = 389
        '
        'ErroreTxt
        '
        Me.ErroreTxt.Location = New System.Drawing.Point(110, 9)
        Me.ErroreTxt.Name = "ErroreTxt"
        Me.ErroreTxt.Size = New System.Drawing.Size(100, 21)
        Me.ErroreTxt.TabIndex = 4
        Me.ErroreTxt.Visible = False
        '
        'DettagliErroreButton
        '
        Me.DettagliErroreButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DettagliErroreButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DettagliErroreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DettagliErroreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.DettagliErroreButton.FlatAppearance.BorderSize = 0
        Me.DettagliErroreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.DettagliErroreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.DettagliErroreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DettagliErroreButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DettagliErroreButton.Location = New System.Drawing.Point(8, 8)
        Me.DettagliErroreButton.Name = "DettagliErroreButton"
        Me.DettagliErroreButton.Size = New System.Drawing.Size(96, 22)
        Me.DettagliErroreButton.TabIndex = 3
        Me.DettagliErroreButton.Text = "Dettagli..."
        Me.DettagliErroreButton.UseVisualStyleBackColor = False
        Me.DettagliErroreButton.Visible = False
        '
        'ChiudiMessaggio
        '
        Me.ChiudiMessaggio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChiudiMessaggio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChiudiMessaggio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ChiudiMessaggio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ChiudiMessaggio.FlatAppearance.BorderSize = 0
        Me.ChiudiMessaggio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.ChiudiMessaggio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ChiudiMessaggio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChiudiMessaggio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChiudiMessaggio.Location = New System.Drawing.Point(294, 8)
        Me.ChiudiMessaggio.Name = "ChiudiMessaggio"
        Me.ChiudiMessaggio.Size = New System.Drawing.Size(87, 22)
        Me.ChiudiMessaggio.TabIndex = 0
        Me.ChiudiMessaggio.Text = "Ok"
        Me.ChiudiMessaggio.UseVisualStyleBackColor = False
        '
        'MessaggioF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 117)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessaggioF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ChiudiMessaggio As System.Windows.Forms.Button
    Friend WithEvents DettagliErroreButton As System.Windows.Forms.Button
    Friend WithEvents ErroreTxt As System.Windows.Forms.TextBox
End Class
