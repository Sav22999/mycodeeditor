<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebBrowser))
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.ButtonAvantiAnteprima = New System.Windows.Forms.Button()
        Me.ButtonIndietroAnteprima = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser2.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser2.Location = New System.Drawing.Point(12, 52)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScriptErrorsSuppressed = True
        Me.WebBrowser2.Size = New System.Drawing.Size(1184, 559)
        Me.WebBrowser2.TabIndex = 1
        Me.WebBrowser2.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser2.WebBrowserShortcutsEnabled = False
        '
        'ButtonAvantiAnteprima
        '
        Me.ButtonAvantiAnteprima.AccessibleDescription = ""
        Me.ButtonAvantiAnteprima.AccessibleName = ""
        Me.ButtonAvantiAnteprima.BackColor = System.Drawing.Color.White
        Me.ButtonAvantiAnteprima.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonAvantiAnteprima.FlatAppearance.BorderSize = 0
        Me.ButtonAvantiAnteprima.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.ButtonAvantiAnteprima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonAvantiAnteprima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonAvantiAnteprima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAvantiAnteprima.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAvantiAnteprima.ForeColor = System.Drawing.Color.Navy
        Me.ButtonAvantiAnteprima.Location = New System.Drawing.Point(85, 12)
        Me.ButtonAvantiAnteprima.Name = "ButtonAvantiAnteprima"
        Me.ButtonAvantiAnteprima.Size = New System.Drawing.Size(72, 39)
        Me.ButtonAvantiAnteprima.TabIndex = 7
        Me.ButtonAvantiAnteprima.Text = "••►"
        Me.ButtonAvantiAnteprima.UseVisualStyleBackColor = False
        '
        'ButtonIndietroAnteprima
        '
        Me.ButtonIndietroAnteprima.AccessibleDescription = ""
        Me.ButtonIndietroAnteprima.AccessibleName = ""
        Me.ButtonIndietroAnteprima.BackColor = System.Drawing.Color.White
        Me.ButtonIndietroAnteprima.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonIndietroAnteprima.FlatAppearance.BorderSize = 0
        Me.ButtonIndietroAnteprima.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.ButtonIndietroAnteprima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonIndietroAnteprima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ButtonIndietroAnteprima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIndietroAnteprima.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIndietroAnteprima.ForeColor = System.Drawing.Color.Navy
        Me.ButtonIndietroAnteprima.Location = New System.Drawing.Point(12, 12)
        Me.ButtonIndietroAnteprima.Name = "ButtonIndietroAnteprima"
        Me.ButtonIndietroAnteprima.Size = New System.Drawing.Size(72, 39)
        Me.ButtonIndietroAnteprima.TabIndex = 6
        Me.ButtonIndietroAnteprima.Text = "◄••"
        Me.ButtonIndietroAnteprima.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = ""
        Me.Button1.AccessibleName = ""
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Navy
        Me.Button1.Image = Global.MinionOne.My.Resources.Resources.xchiudi1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(1032, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "PIANO PIANO"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'WebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1208, 623)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonAvantiAnteprima)
        Me.Controls.Add(Me.ButtonIndietroAnteprima)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "WebBrowser"
        Me.Text = " - Minion One"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents ButtonAvantiAnteprima As System.Windows.Forms.Button
    Friend WithEvents ButtonIndietroAnteprima As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
