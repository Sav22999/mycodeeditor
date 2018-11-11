<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuovoProgetto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuovoProgetto))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.timertxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AnteprimaButtonR = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncollaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncollaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.timertxt)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.AnteprimaButtonR)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(1, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 38)
        Me.Panel1.TabIndex = 389
        '
        'timertxt
        '
        Me.timertxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timertxt.Location = New System.Drawing.Point(11, 8)
        Me.timertxt.Name = "timertxt"
        Me.timertxt.Size = New System.Drawing.Size(45, 21)
        Me.timertxt.TabIndex = 16
        Me.timertxt.Text = "0"
        Me.timertxt.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(114, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 22)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Annulla"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AnteprimaButtonR
        '
        Me.AnteprimaButtonR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnteprimaButtonR.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AnteprimaButtonR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AnteprimaButtonR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.AnteprimaButtonR.FlatAppearance.BorderSize = 0
        Me.AnteprimaButtonR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.AnteprimaButtonR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.AnteprimaButtonR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnteprimaButtonR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnteprimaButtonR.Location = New System.Drawing.Point(211, 8)
        Me.AnteprimaButtonR.Name = "AnteprimaButtonR"
        Me.AnteprimaButtonR.Size = New System.Drawing.Size(87, 22)
        Me.AnteprimaButtonR.TabIndex = 13
        Me.AnteprimaButtonR.Text = "Crea"
        Me.AnteprimaButtonR.UseVisualStyleBackColor = False
        '
        'Button10
        '
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
        Me.Button10.Location = New System.Drawing.Point(213, 38)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(86, 22)
        Me.Button10.TabIndex = 546
        Me.Button10.Text = "Cambia"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBox1.Location = New System.Drawing.Point(7, 38)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 22)
        Me.TextBox1.TabIndex = 545
        Me.TextBox1.Text = "Percorso"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiaToolStripMenuItem, Me.IncollaToolStripMenuItem1, Me.EliminaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "Principale"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 70)
        '
        'CopiaToolStripMenuItem
        '
        Me.CopiaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed
        Me.CopiaToolStripMenuItem.Name = "CopiaToolStripMenuItem"
        Me.CopiaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CopiaToolStripMenuItem.Text = "Copia"
        '
        'IncollaToolStripMenuItem1
        '
        Me.IncollaToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IncollaToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncollaToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkRed
        Me.IncollaToolStripMenuItem1.Name = "IncollaToolStripMenuItem1"
        Me.IncollaToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.IncollaToolStripMenuItem1.Text = "Incolla"
        '
        'EliminaToolStripMenuItem
        '
        Me.EliminaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EliminaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed
        Me.EliminaToolStripMenuItem.Name = "EliminaToolStripMenuItem"
        Me.EliminaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.EliminaToolStripMenuItem.Text = "Elimina"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.ContextMenuStrip = Me.ContextMenuStrip3
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBox9.Location = New System.Drawing.Point(7, 8)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(292, 22)
        Me.TextBox9.TabIndex = 544
        Me.TextBox9.Text = "Nome progetto"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.IncollaToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(111, 48)
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
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Timer2
        '
        Me.Timer2.Interval = 40
        '
        'NuovoProgetto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(307, 104)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(323, 143)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(323, 143)
        Me.Name = "NuovoProgetto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuovo progetto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AnteprimaButtonR As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncollaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents timertxt As System.Windows.Forms.TextBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IncollaToolStripMenuItem As ToolStripMenuItem
End Class
