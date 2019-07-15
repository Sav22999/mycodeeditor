<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sostituisci
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sostituisci))
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CercaButton = New System.Windows.Forms.Button()
        Me.SostituisciButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBox9.Location = New System.Drawing.Point(7, 8)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(352, 22)
        Me.TextBox9.TabIndex = 1
        Me.TextBox9.Text = "Trova"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.CercaButton)
        Me.Panel1.Controls.Add(Me.SostituisciButton)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(1, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 38)
        Me.Panel1.TabIndex = 546
        '
        'CercaButton
        '
        Me.CercaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CercaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CercaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CercaButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.CercaButton.FlatAppearance.BorderSize = 0
        Me.CercaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.CercaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.CercaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CercaButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CercaButton.Location = New System.Drawing.Point(122, 8)
        Me.CercaButton.Name = "CercaButton"
        Me.CercaButton.Size = New System.Drawing.Size(91, 22)
        Me.CercaButton.TabIndex = 3
        Me.CercaButton.Text = "Cerca"
        Me.CercaButton.UseVisualStyleBackColor = False
        '
        'SostituisciButton
        '
        Me.SostituisciButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SostituisciButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.SostituisciButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SostituisciButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.SostituisciButton.FlatAppearance.BorderSize = 0
        Me.SostituisciButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.SostituisciButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.SostituisciButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SostituisciButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SostituisciButton.Location = New System.Drawing.Point(219, 8)
        Me.SostituisciButton.Name = "SostituisciButton"
        Me.SostituisciButton.Size = New System.Drawing.Size(139, 22)
        Me.SostituisciButton.TabIndex = 4
        Me.SostituisciButton.Text = "Cerca e sostituisci"
        Me.SostituisciButton.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBox1.Location = New System.Drawing.Point(7, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 22)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Sostituisci"
        '
        'Sostituisci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(367, 106)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox9)
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sostituisci"
        Me.Text = "Cerca e sostituisci"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CercaButton As System.Windows.Forms.Button
    Friend WithEvents SostituisciButton As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
