<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SegnalazioneProblema
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SegnalazioneProblema))
        Me.Button48 = New System.Windows.Forms.Button()
        Me.AccettoCondCheck = New System.Windows.Forms.CheckBox()
        Me.MotivoText = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MessaggioText = New System.Windows.Forms.TextBox()
        Me.EmailText = New System.Windows.Forms.TextBox()
        Me.NomeCognomeText = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MessaggioInvio = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncollaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip4 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip5 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.ContextMenuStrip4.SuspendLayout()
        Me.ContextMenuStrip5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button48
        '
        Me.Button48.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button48.BackColor = System.Drawing.Color.DarkRed
        Me.Button48.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button48.Enabled = False
        Me.Button48.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.Button48.FlatAppearance.BorderSize = 0
        Me.Button48.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button48.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button48.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button48.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button48.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button48.Location = New System.Drawing.Point(377, 327)
        Me.Button48.Name = "Button48"
        Me.Button48.Size = New System.Drawing.Size(84, 22)
        Me.Button48.TabIndex = 6
        Me.Button48.Text = "Invia"
        Me.Button48.UseVisualStyleBackColor = False
        '
        'AccettoCondCheck
        '
        Me.AccettoCondCheck.AutoSize = True
        Me.AccettoCondCheck.BackColor = System.Drawing.Color.Transparent
        Me.AccettoCondCheck.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.AccettoCondCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed
        Me.AccettoCondCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.AccettoCondCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.AccettoCondCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AccettoCondCheck.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccettoCondCheck.ForeColor = System.Drawing.Color.DarkRed
        Me.AccettoCondCheck.Location = New System.Drawing.Point(12, 294)
        Me.AccettoCondCheck.Name = "AccettoCondCheck"
        Me.AccettoCondCheck.Size = New System.Drawing.Size(326, 34)
        Me.AccettoCondCheck.TabIndex = 5
        Me.AccettoCondCheck.Text = "Accetto le Condizioni d'uso (dei dati) di My Code Editor." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(per leggerle andare i" &
    "n Informazioni > Condizioni d'uso)"
        Me.AccettoCondCheck.UseVisualStyleBackColor = False
        '
        'MotivoText
        '
        Me.MotivoText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MotivoText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MotivoText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MotivoText.ContextMenuStrip = Me.ContextMenuStrip4
        Me.MotivoText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotivoText.ForeColor = System.Drawing.Color.DarkGray
        Me.MotivoText.Location = New System.Drawing.Point(5, 57)
        Me.MotivoText.Name = "MotivoText"
        Me.MotivoText.Size = New System.Drawing.Size(456, 22)
        Me.MotivoText.TabIndex = 3
        Me.MotivoText.Text = "Motivo"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MessaggioText
        '
        Me.MessaggioText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessaggioText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MessaggioText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MessaggioText.ContextMenuStrip = Me.ContextMenuStrip5
        Me.MessaggioText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessaggioText.ForeColor = System.Drawing.Color.DarkGray
        Me.MessaggioText.Location = New System.Drawing.Point(4, 83)
        Me.MessaggioText.Multiline = True
        Me.MessaggioText.Name = "MessaggioText"
        Me.MessaggioText.Size = New System.Drawing.Size(457, 205)
        Me.MessaggioText.TabIndex = 4
        Me.MessaggioText.Text = "Messaggio..."
        '
        'EmailText
        '
        Me.EmailText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailText.ContextMenuStrip = Me.ContextMenuStrip3
        Me.EmailText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailText.ForeColor = System.Drawing.Color.DarkGray
        Me.EmailText.Location = New System.Drawing.Point(4, 31)
        Me.EmailText.Name = "EmailText"
        Me.EmailText.Size = New System.Drawing.Size(457, 22)
        Me.EmailText.TabIndex = 2
        Me.EmailText.Text = "E-mail"
        '
        'NomeCognomeText
        '
        Me.NomeCognomeText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NomeCognomeText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NomeCognomeText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomeCognomeText.ContextMenuStrip = Me.ContextMenuStrip2
        Me.NomeCognomeText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeCognomeText.ForeColor = System.Drawing.Color.DarkGray
        Me.NomeCognomeText.Location = New System.Drawing.Point(4, 5)
        Me.NomeCognomeText.Name = "NomeCognomeText"
        Me.NomeCognomeText.Size = New System.Drawing.Size(457, 22)
        Me.NomeCognomeText.TabIndex = 1
        Me.NomeCognomeText.Text = "Nome e Cognome"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(4, 329)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(37, 20)
        Me.WebBrowser1.TabIndex = 7
        Me.WebBrowser1.Visible = False
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(172, 154)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 44)
        Me.Panel1.TabIndex = 558
        Me.Panel1.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(140, 140, 140)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(140, 140, 140)
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(140, 140, 140)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.TabStop = False
        Me.Button1.Text = "Invio della mail in corso..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(282, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 22)
        Me.Button2.TabIndex = 559
        Me.Button2.Text = "Annulla"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MessaggioInvio
        '
        Me.MessaggioInvio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessaggioInvio.BackColor = System.Drawing.Color.Red
        Me.MessaggioInvio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MessaggioInvio.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessaggioInvio.ForeColor = System.Drawing.Color.White
        Me.MessaggioInvio.Location = New System.Drawing.Point(121, 334)
        Me.MessaggioInvio.Multiline = True
        Me.MessaggioInvio.Name = "MessaggioInvio"
        Me.MessaggioInvio.Size = New System.Drawing.Size(63, 16)
        Me.MessaggioInvio.TabIndex = 562
        Me.MessaggioInvio.Visible = False
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.IncollaToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(111, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkRed
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem1.Text = "Copia"
        '
        'IncollaToolStripMenuItem
        '
        Me.IncollaToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.IncollaToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.IncollaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed
        Me.IncollaToolStripMenuItem.Name = "IncollaToolStripMenuItem"
        Me.IncollaToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.IncollaToolStripMenuItem.Text = "Incolla"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(111, 48)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.DarkRed
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem2.Text = "Copia"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.DarkRed
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem3.Text = "Incolla"
        '
        'ContextMenuStrip4
        '
        Me.ContextMenuStrip4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ContextMenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ContextMenuStrip4.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip4.Size = New System.Drawing.Size(111, 48)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.DarkRed
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem4.Text = "Copia"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.DarkRed
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem5.Text = "Incolla"
        '
        'ContextMenuStrip5
        '
        Me.ContextMenuStrip5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ContextMenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.ToolStripMenuItem7})
        Me.ContextMenuStrip5.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip5.Size = New System.Drawing.Size(111, 48)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.DarkRed
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem6.Text = "Copia"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.DarkRed
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem7.Text = "Incolla"
        '
        'SegnalazioneProblema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(466, 353)
        Me.Controls.Add(Me.MessaggioInvio)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button48)
        Me.Controls.Add(Me.AccettoCondCheck)
        Me.Controls.Add(Me.MotivoText)
        Me.Controls.Add(Me.MessaggioText)
        Me.Controls.Add(Me.EmailText)
        Me.Controls.Add(Me.NomeCognomeText)
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SegnalazioneProblema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Segnala un problema"
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ContextMenuStrip4.ResumeLayout(False)
        Me.ContextMenuStrip5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button48 As System.Windows.Forms.Button
    Friend WithEvents AccettoCondCheck As System.Windows.Forms.CheckBox
    Friend WithEvents MotivoText As System.Windows.Forms.TextBox
    Friend WithEvents MessaggioText As System.Windows.Forms.TextBox
    Friend WithEvents EmailText As System.Windows.Forms.TextBox
    Friend WithEvents NomeCognomeText As System.Windows.Forms.TextBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MessaggioInvio As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IncollaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip4 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip5 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
End Class
