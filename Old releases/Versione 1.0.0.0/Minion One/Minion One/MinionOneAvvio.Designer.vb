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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MinionOneButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cercando il percorso..."
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(546, 365)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Navy
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-95, 397)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 16)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(2, 394)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(644, 22)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(546, 336)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "1"
        Me.TextBox2.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 419)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 28)
        Me.Panel1.TabIndex = 6
        '
        'MinionOneButton
        '
        Me.MinionOneButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinionOneButton.BackColor = System.Drawing.Color.Navy
        Me.MinionOneButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.MinionOneButton.FlatAppearance.BorderSize = 0
        Me.MinionOneButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.MinionOneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.MinionOneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.MinionOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinionOneButton.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinionOneButton.ForeColor = System.Drawing.Color.White
        Me.MinionOneButton.Location = New System.Drawing.Point(2, 1)
        Me.MinionOneButton.Name = "MinionOneButton"
        Me.MinionOneButton.Size = New System.Drawing.Size(644, 41)
        Me.MinionOneButton.TabIndex = 7
        Me.MinionOneButton.Text = "www.MixiM.altervista.org"
        Me.MinionOneButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.BackgroundImage = Global.MinionOne.My.Resources.Resources.MinionOne1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(2, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(300, 300)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Navy
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(308, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(338, 300)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Minion One"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Navy
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(393, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 41)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "v. 1.0 BETA"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Navy
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Silver
        Me.Button4.Location = New System.Drawing.Point(2, 347)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(385, 41)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "mixim-italia@outlook.com"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'MinionOneAvvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(648, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MinionOneButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MinionOneAvvio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MinionOneButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
