<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinionOneAvvio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MinionOneAvvio))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.DarkRed
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.Location = New System.Drawing.Point(12, 81)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(271, 40)
        Me.Button6.TabIndex = 17
        Me.Button6.TabStop = False
        Me.Button6.Text = "~ L'editor di tutti ~"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(7, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(284, 64)
        Me.Button2.TabIndex = 18
        Me.Button2.TabStop = False
        Me.Button2.Text = "Minion One"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'MinionOneAvvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(300, 145)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MinionOneAvvio"
        Me.Opacity = 0.96R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soltanto un attimo..."
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
