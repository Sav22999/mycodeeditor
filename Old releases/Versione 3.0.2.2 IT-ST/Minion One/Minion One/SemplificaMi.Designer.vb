<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SemplificaMi
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"/*e/", "e", "&#...;"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"/*è*", "E'", "&#...;"}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SemplificaMi))
        Me.MinionOneSemplificaMiSi = New System.Windows.Forms.Button()
        Me.MinionOneSemplificaMiNo = New System.Windows.Forms.Button()
        Me.TipoDiEditor = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'MinionOneSemplificaMiSi
        '
        Me.MinionOneSemplificaMiSi.BackColor = System.Drawing.Color.Red
        Me.MinionOneSemplificaMiSi.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.MinionOneSemplificaMiSi.FlatAppearance.BorderSize = 0
        Me.MinionOneSemplificaMiSi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.MinionOneSemplificaMiSi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.MinionOneSemplificaMiSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MinionOneSemplificaMiSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinionOneSemplificaMiSi.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinionOneSemplificaMiSi.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MinionOneSemplificaMiSi.Location = New System.Drawing.Point(387, 12)
        Me.MinionOneSemplificaMiSi.Name = "MinionOneSemplificaMiSi"
        Me.MinionOneSemplificaMiSi.Size = New System.Drawing.Size(120, 39)
        Me.MinionOneSemplificaMiSi.TabIndex = 7
        Me.MinionOneSemplificaMiSi.Text = "ATTIVATA"
        Me.MinionOneSemplificaMiSi.UseVisualStyleBackColor = False
        '
        'MinionOneSemplificaMiNo
        '
        Me.MinionOneSemplificaMiNo.BackColor = System.Drawing.Color.DarkRed
        Me.MinionOneSemplificaMiNo.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.MinionOneSemplificaMiNo.FlatAppearance.BorderSize = 0
        Me.MinionOneSemplificaMiNo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.MinionOneSemplificaMiNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.MinionOneSemplificaMiNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MinionOneSemplificaMiNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinionOneSemplificaMiNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinionOneSemplificaMiNo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.MinionOneSemplificaMiNo.Location = New System.Drawing.Point(507, 12)
        Me.MinionOneSemplificaMiNo.Name = "MinionOneSemplificaMiNo"
        Me.MinionOneSemplificaMiNo.Size = New System.Drawing.Size(141, 39)
        Me.MinionOneSemplificaMiNo.TabIndex = 8
        Me.MinionOneSemplificaMiNo.Text = "DISATTIVATA"
        Me.MinionOneSemplificaMiNo.UseVisualStyleBackColor = False
        '
        'TipoDiEditor
        '
        Me.TipoDiEditor.AccessibleDescription = ""
        Me.TipoDiEditor.AccessibleName = ""
        Me.TipoDiEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TipoDiEditor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TipoDiEditor.FlatAppearance.BorderSize = 0
        Me.TipoDiEditor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.TipoDiEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TipoDiEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TipoDiEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoDiEditor.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoDiEditor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TipoDiEditor.Location = New System.Drawing.Point(12, 12)
        Me.TipoDiEditor.Name = "TipoDiEditor"
        Me.TipoDiEditor.Size = New System.Drawing.Size(369, 39)
        Me.TipoDiEditor.TabIndex = 26
        Me.TipoDiEditor.Text = "Modalità Minion One SemplificaMi"
        Me.TipoDiEditor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TipoDiEditor.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(654, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 39)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Cos'è?"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.DarkRed
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.ListView1.Location = New System.Drawing.Point(12, 57)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListView1.Size = New System.Drawing.Size(755, 330)
        Me.ListView1.TabIndex = 30
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader
        '
        Me.ColumnHeader.Text = "Abbreviazione"
        Me.ColumnHeader.Width = 198
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Simbolo corrispondente"
        Me.ColumnHeader2.Width = 223
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Codice HTML corrispondente"
        Me.ColumnHeader3.Width = 334
        '
        'SemplificaMi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 398)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TipoDiEditor)
        Me.Controls.Add(Me.MinionOneSemplificaMiNo)
        Me.Controls.Add(Me.MinionOneSemplificaMiSi)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "SemplificaMi"
        Me.Text = "Minion One SemplificaMi"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MinionOneSemplificaMiSi As System.Windows.Forms.Button
    Friend WithEvents MinionOneSemplificaMiNo As System.Windows.Forms.Button
    Friend WithEvents TipoDiEditor As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader As System.Windows.Forms.ColumnHeader
End Class
