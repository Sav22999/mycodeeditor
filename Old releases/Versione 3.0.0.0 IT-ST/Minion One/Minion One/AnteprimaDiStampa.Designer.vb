<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnteprimaDiStampa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AnteprimaDiStampa))
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.STAMPAprop = New System.Drawing.Printing.PrintDocument()
        Me.MinionOneButton = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreviewControl1.AutoZoom = False
        Me.PrintPreviewControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PrintPreviewControl1.Document = Me.STAMPAprop
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(12, 12)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(576, 593)
        Me.PrintPreviewControl1.TabIndex = 27
        Me.PrintPreviewControl1.Zoom = 0.5R
        '
        'STAMPAprop
        '
        '
        'MinionOneButton
        '
        Me.MinionOneButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MinionOneButton.BackColor = System.Drawing.Color.DarkRed
        Me.MinionOneButton.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.MinionOneButton.FlatAppearance.BorderSize = 0
        Me.MinionOneButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.MinionOneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.MinionOneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MinionOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinionOneButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinionOneButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MinionOneButton.Location = New System.Drawing.Point(12, 611)
        Me.MinionOneButton.Name = "MinionOneButton"
        Me.MinionOneButton.Size = New System.Drawing.Size(236, 39)
        Me.MinionOneButton.TabIndex = 28
        Me.MinionOneButton.Text = "Chiudi anteprima"
        Me.MinionOneButton.UseVisualStyleBackColor = False
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.Location = New System.Drawing.Point(254, 611)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(334, 45)
        Me.TrackBar1.TabIndex = 29
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.TrackBar1.Value = 50
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(525, 635)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "50%"
        '
        'AnteprimaDiStampa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 662)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.MinionOneButton)
        Me.Controls.Add(Me.PrintPreviewControl1)
        Me.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "AnteprimaDiStampa"
        Me.Text = "AnteprimaDiStampa"
        Me.TopMost = True
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintPreviewControl1 As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents STAMPAprop As System.Drawing.Printing.PrintDocument
    Friend WithEvents MinionOneButton As System.Windows.Forms.Button
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
