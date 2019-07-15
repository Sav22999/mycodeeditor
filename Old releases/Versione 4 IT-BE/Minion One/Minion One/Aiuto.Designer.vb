<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aiuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aiuto))
        Me.BarraLaterale = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.NovitaButton = New System.Windows.Forms.Button()
        Me.PrimoAvvioButton = New System.Windows.Forms.Button()
        Me.TutorialButton = New System.Windows.Forms.Button()
        Me.CercaPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CercaButton = New System.Windows.Forms.Button()
        Me.CercaTextBox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TutorialPanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrimoAvvioPanel = New System.Windows.Forms.Panel()
        Me.DescrizioneVideoPrimoAvvio3 = New System.Windows.Forms.Button()
        Me.VideoPrimoAvvio3 = New System.Windows.Forms.Button()
        Me.TitoloVideoPrimoAvvio3 = New System.Windows.Forms.Button()
        Me.DescrizioneVideoPrimoAvvio4 = New System.Windows.Forms.Button()
        Me.VideoPrimoAvvio4 = New System.Windows.Forms.Button()
        Me.TitoloVideoPrimoAvvio4 = New System.Windows.Forms.Button()
        Me.DescrizioneVideoPrimoAvvio2 = New System.Windows.Forms.Button()
        Me.VideoPrimoAvvio2 = New System.Windows.Forms.Button()
        Me.TitoloVideoPrimoAvvio2 = New System.Windows.Forms.Button()
        Me.DescrizioneVideoPrimoAvvio1 = New System.Windows.Forms.Button()
        Me.VideoPrimoAvvio1 = New System.Windows.Forms.Button()
        Me.TitoloVideoPrimoAvvio1 = New System.Windows.Forms.Button()
        Me.RicercaPanel = New System.Windows.Forms.Panel()
        Me.CercaOnlineNORESULT = New System.Windows.Forms.Button()
        Me.CodiceErroreText = New System.Windows.Forms.Button()
        Me.DescrizioneErroreText = New System.Windows.Forms.Button()
        Me.BarraLaterale.SuspendLayout()
        Me.CercaPanel.SuspendLayout()
        Me.TutorialPanel.SuspendLayout()
        Me.PrimoAvvioPanel.SuspendLayout()
        Me.RicercaPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraLaterale
        '
        Me.BarraLaterale.BackColor = System.Drawing.Color.DarkRed
        Me.BarraLaterale.Controls.Add(Me.Panel2)
        Me.BarraLaterale.Controls.Add(Me.NovitaButton)
        Me.BarraLaterale.Controls.Add(Me.PrimoAvvioButton)
        Me.BarraLaterale.Controls.Add(Me.TutorialButton)
        Me.BarraLaterale.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarraLaterale.Location = New System.Drawing.Point(529, 0)
        Me.BarraLaterale.Name = "BarraLaterale"
        Me.BarraLaterale.Size = New System.Drawing.Size(126, 339)
        Me.BarraLaterale.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 22)
        Me.Panel2.TabIndex = 559
        '
        'NovitaButton
        '
        Me.NovitaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NovitaButton.BackColor = System.Drawing.Color.DarkRed
        Me.NovitaButton.BackgroundImage = Global.Minion_One.My.Resources.Resources.aiuto_novita_mo4
        Me.NovitaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NovitaButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.NovitaButton.FlatAppearance.BorderSize = 0
        Me.NovitaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.NovitaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.NovitaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NovitaButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NovitaButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.NovitaButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NovitaButton.Location = New System.Drawing.Point(0, 134)
        Me.NovitaButton.Name = "NovitaButton"
        Me.NovitaButton.Size = New System.Drawing.Size(126, 56)
        Me.NovitaButton.TabIndex = 19
        Me.NovitaButton.Text = "Novità"
        Me.NovitaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NovitaButton.UseVisualStyleBackColor = False
        '
        'PrimoAvvioButton
        '
        Me.PrimoAvvioButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrimoAvvioButton.BackColor = System.Drawing.Color.DarkRed
        Me.PrimoAvvioButton.BackgroundImage = Global.Minion_One.My.Resources.Resources.aiuto_primoavvio_mo4
        Me.PrimoAvvioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PrimoAvvioButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.PrimoAvvioButton.FlatAppearance.BorderSize = 0
        Me.PrimoAvvioButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.PrimoAvvioButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.PrimoAvvioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrimoAvvioButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrimoAvvioButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PrimoAvvioButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PrimoAvvioButton.Location = New System.Drawing.Point(0, 78)
        Me.PrimoAvvioButton.Name = "PrimoAvvioButton"
        Me.PrimoAvvioButton.Size = New System.Drawing.Size(126, 56)
        Me.PrimoAvvioButton.TabIndex = 12
        Me.PrimoAvvioButton.Text = "Primo avvio"
        Me.PrimoAvvioButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.PrimoAvvioButton.UseVisualStyleBackColor = False
        '
        'TutorialButton
        '
        Me.TutorialButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TutorialButton.BackColor = System.Drawing.Color.DarkRed
        Me.TutorialButton.BackgroundImage = Global.Minion_One.My.Resources.Resources.aiuto_tutorial_mo4
        Me.TutorialButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TutorialButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.TutorialButton.FlatAppearance.BorderSize = 0
        Me.TutorialButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.TutorialButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.TutorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TutorialButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TutorialButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TutorialButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutorialButton.Location = New System.Drawing.Point(0, 22)
        Me.TutorialButton.Name = "TutorialButton"
        Me.TutorialButton.Size = New System.Drawing.Size(126, 56)
        Me.TutorialButton.TabIndex = 11
        Me.TutorialButton.Text = "Tutorial"
        Me.TutorialButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutorialButton.UseVisualStyleBackColor = False
        '
        'CercaPanel
        '
        Me.CercaPanel.BackColor = System.Drawing.Color.DarkRed
        Me.CercaPanel.Controls.Add(Me.Button1)
        Me.CercaPanel.Controls.Add(Me.CercaButton)
        Me.CercaPanel.Controls.Add(Me.CercaTextBox)
        Me.CercaPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.CercaPanel.Location = New System.Drawing.Point(0, 0)
        Me.CercaPanel.Name = "CercaPanel"
        Me.CercaPanel.Size = New System.Drawing.Size(529, 22)
        Me.CercaPanel.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 22)
        Me.Button1.TabIndex = 557
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CercaButton
        '
        Me.CercaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CercaButton.BackColor = System.Drawing.Color.DarkRed
        Me.CercaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CercaButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.CercaButton.FlatAppearance.BorderSize = 0
        Me.CercaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.CercaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CercaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CercaButton.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CercaButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CercaButton.Location = New System.Drawing.Point(448, 0)
        Me.CercaButton.Name = "CercaButton"
        Me.CercaButton.Size = New System.Drawing.Size(81, 22)
        Me.CercaButton.TabIndex = 556
        Me.CercaButton.Text = "Cerca"
        Me.CercaButton.UseVisualStyleBackColor = False
        '
        'CercaTextBox
        '
        Me.CercaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CercaTextBox.BackColor = System.Drawing.Color.DarkRed
        Me.CercaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CercaTextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.CercaTextBox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CercaTextBox.ForeColor = System.Drawing.Color.Red
        Me.CercaTextBox.Location = New System.Drawing.Point(28, 0)
        Me.CercaTextBox.Name = "CercaTextBox"
        Me.CercaTextBox.Size = New System.Drawing.Size(414, 22)
        Me.CercaTextBox.TabIndex = 555
        Me.CercaTextBox.Text = "Cerca nel centro aiuto..."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TutorialPanel
        '
        Me.TutorialPanel.Controls.Add(Me.Button2)
        Me.TutorialPanel.Location = New System.Drawing.Point(0, 22)
        Me.TutorialPanel.Name = "TutorialPanel"
        Me.TutorialPanel.Size = New System.Drawing.Size(530, 317)
        Me.TutorialPanel.TabIndex = 11
        Me.TutorialPanel.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(530, 56)
        Me.Button2.TabIndex = 506
        Me.Button2.TabStop = False
        Me.Button2.Text = "AL MOMENTO NON E' DISPONIBILE ALCUN TUTORIAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Prova a vedere le guide/video in P" & _
    "rimo Avvio)"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PrimoAvvioPanel
        '
        Me.PrimoAvvioPanel.AutoScroll = True
        Me.PrimoAvvioPanel.Controls.Add(Me.DescrizioneVideoPrimoAvvio3)
        Me.PrimoAvvioPanel.Controls.Add(Me.VideoPrimoAvvio3)
        Me.PrimoAvvioPanel.Controls.Add(Me.TitoloVideoPrimoAvvio3)
        Me.PrimoAvvioPanel.Controls.Add(Me.DescrizioneVideoPrimoAvvio4)
        Me.PrimoAvvioPanel.Controls.Add(Me.VideoPrimoAvvio4)
        Me.PrimoAvvioPanel.Controls.Add(Me.TitoloVideoPrimoAvvio4)
        Me.PrimoAvvioPanel.Controls.Add(Me.DescrizioneVideoPrimoAvvio2)
        Me.PrimoAvvioPanel.Controls.Add(Me.VideoPrimoAvvio2)
        Me.PrimoAvvioPanel.Controls.Add(Me.TitoloVideoPrimoAvvio2)
        Me.PrimoAvvioPanel.Controls.Add(Me.DescrizioneVideoPrimoAvvio1)
        Me.PrimoAvvioPanel.Controls.Add(Me.VideoPrimoAvvio1)
        Me.PrimoAvvioPanel.Controls.Add(Me.TitoloVideoPrimoAvvio1)
        Me.PrimoAvvioPanel.Location = New System.Drawing.Point(0, 22)
        Me.PrimoAvvioPanel.Name = "PrimoAvvioPanel"
        Me.PrimoAvvioPanel.Size = New System.Drawing.Size(530, 317)
        Me.PrimoAvvioPanel.TabIndex = 12
        Me.PrimoAvvioPanel.Visible = False
        '
        'DescrizioneVideoPrimoAvvio3
        '
        Me.DescrizioneVideoPrimoAvvio3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescrizioneVideoPrimoAvvio3.BackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DescrizioneVideoPrimoAvvio3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio3.FlatAppearance.BorderSize = 0
        Me.DescrizioneVideoPrimoAvvio3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescrizioneVideoPrimoAvvio3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneVideoPrimoAvvio3.ForeColor = System.Drawing.Color.DarkRed
        Me.DescrizioneVideoPrimoAvvio3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DescrizioneVideoPrimoAvvio3.Location = New System.Drawing.Point(173, 219)
        Me.DescrizioneVideoPrimoAvvio3.Name = "DescrizioneVideoPrimoAvvio3"
        Me.DescrizioneVideoPrimoAvvio3.Size = New System.Drawing.Size(337, 58)
        Me.DescrizioneVideoPrimoAvvio3.TabIndex = 525
        Me.DescrizioneVideoPrimoAvvio3.TabStop = False
        Me.DescrizioneVideoPrimoAvvio3.Text = "In questo guida sarà illustrato come capire Minion One, la sua interfaccia, i suo" & _
    "i messaggi, i suoi avvisi, errori, ecc..."
        Me.DescrizioneVideoPrimoAvvio3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DescrizioneVideoPrimoAvvio3.UseVisualStyleBackColor = False
        '
        'VideoPrimoAvvio3
        '
        Me.VideoPrimoAvvio3.BackColor = System.Drawing.Color.Gray
        Me.VideoPrimoAvvio3.BackgroundImage = CType(resources.GetObject("VideoPrimoAvvio3.BackgroundImage"), System.Drawing.Image)
        Me.VideoPrimoAvvio3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VideoPrimoAvvio3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VideoPrimoAvvio3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.VideoPrimoAvvio3.FlatAppearance.BorderSize = 0
        Me.VideoPrimoAvvio3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.VideoPrimoAvvio3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.VideoPrimoAvvio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VideoPrimoAvvio3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoPrimoAvvio3.ForeColor = System.Drawing.Color.DarkRed
        Me.VideoPrimoAvvio3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VideoPrimoAvvio3.Location = New System.Drawing.Point(3, 187)
        Me.VideoPrimoAvvio3.Name = "VideoPrimoAvvio3"
        Me.VideoPrimoAvvio3.Size = New System.Drawing.Size(170, 90)
        Me.VideoPrimoAvvio3.TabIndex = 524
        Me.VideoPrimoAvvio3.TabStop = False
        Me.VideoPrimoAvvio3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.VideoPrimoAvvio3.UseVisualStyleBackColor = False
        '
        'TitoloVideoPrimoAvvio3
        '
        Me.TitoloVideoPrimoAvvio3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitoloVideoPrimoAvvio3.BackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TitoloVideoPrimoAvvio3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio3.FlatAppearance.BorderSize = 0
        Me.TitoloVideoPrimoAvvio3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TitoloVideoPrimoAvvio3.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TitoloVideoPrimoAvvio3.ForeColor = System.Drawing.Color.DarkRed
        Me.TitoloVideoPrimoAvvio3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TitoloVideoPrimoAvvio3.Location = New System.Drawing.Point(173, 187)
        Me.TitoloVideoPrimoAvvio3.Name = "TitoloVideoPrimoAvvio3"
        Me.TitoloVideoPrimoAvvio3.Size = New System.Drawing.Size(337, 32)
        Me.TitoloVideoPrimoAvvio3.TabIndex = 523
        Me.TitoloVideoPrimoAvvio3.TabStop = False
        Me.TitoloVideoPrimoAvvio3.Text = "Come capire Minion One"
        Me.TitoloVideoPrimoAvvio3.UseVisualStyleBackColor = False
        '
        'DescrizioneVideoPrimoAvvio4
        '
        Me.DescrizioneVideoPrimoAvvio4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescrizioneVideoPrimoAvvio4.BackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DescrizioneVideoPrimoAvvio4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio4.FlatAppearance.BorderSize = 0
        Me.DescrizioneVideoPrimoAvvio4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescrizioneVideoPrimoAvvio4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneVideoPrimoAvvio4.ForeColor = System.Drawing.Color.DarkRed
        Me.DescrizioneVideoPrimoAvvio4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DescrizioneVideoPrimoAvvio4.Location = New System.Drawing.Point(173, 311)
        Me.DescrizioneVideoPrimoAvvio4.Name = "DescrizioneVideoPrimoAvvio4"
        Me.DescrizioneVideoPrimoAvvio4.Size = New System.Drawing.Size(337, 58)
        Me.DescrizioneVideoPrimoAvvio4.TabIndex = 522
        Me.DescrizioneVideoPrimoAvvio4.TabStop = False
        Me.DescrizioneVideoPrimoAvvio4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DescrizioneVideoPrimoAvvio4.UseVisualStyleBackColor = False
        Me.DescrizioneVideoPrimoAvvio4.Visible = False
        '
        'VideoPrimoAvvio4
        '
        Me.VideoPrimoAvvio4.BackColor = System.Drawing.Color.Gray
        Me.VideoPrimoAvvio4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VideoPrimoAvvio4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VideoPrimoAvvio4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.VideoPrimoAvvio4.FlatAppearance.BorderSize = 0
        Me.VideoPrimoAvvio4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.VideoPrimoAvvio4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.VideoPrimoAvvio4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VideoPrimoAvvio4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoPrimoAvvio4.ForeColor = System.Drawing.Color.DarkRed
        Me.VideoPrimoAvvio4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VideoPrimoAvvio4.Location = New System.Drawing.Point(3, 279)
        Me.VideoPrimoAvvio4.Name = "VideoPrimoAvvio4"
        Me.VideoPrimoAvvio4.Size = New System.Drawing.Size(170, 90)
        Me.VideoPrimoAvvio4.TabIndex = 521
        Me.VideoPrimoAvvio4.TabStop = False
        Me.VideoPrimoAvvio4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.VideoPrimoAvvio4.UseVisualStyleBackColor = False
        Me.VideoPrimoAvvio4.Visible = False
        '
        'TitoloVideoPrimoAvvio4
        '
        Me.TitoloVideoPrimoAvvio4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitoloVideoPrimoAvvio4.BackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TitoloVideoPrimoAvvio4.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio4.FlatAppearance.BorderSize = 0
        Me.TitoloVideoPrimoAvvio4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TitoloVideoPrimoAvvio4.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TitoloVideoPrimoAvvio4.ForeColor = System.Drawing.Color.DarkRed
        Me.TitoloVideoPrimoAvvio4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TitoloVideoPrimoAvvio4.Location = New System.Drawing.Point(173, 279)
        Me.TitoloVideoPrimoAvvio4.Name = "TitoloVideoPrimoAvvio4"
        Me.TitoloVideoPrimoAvvio4.Size = New System.Drawing.Size(337, 32)
        Me.TitoloVideoPrimoAvvio4.TabIndex = 520
        Me.TitoloVideoPrimoAvvio4.TabStop = False
        Me.TitoloVideoPrimoAvvio4.UseVisualStyleBackColor = False
        Me.TitoloVideoPrimoAvvio4.Visible = False
        '
        'DescrizioneVideoPrimoAvvio2
        '
        Me.DescrizioneVideoPrimoAvvio2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescrizioneVideoPrimoAvvio2.BackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DescrizioneVideoPrimoAvvio2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio2.FlatAppearance.BorderSize = 0
        Me.DescrizioneVideoPrimoAvvio2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescrizioneVideoPrimoAvvio2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneVideoPrimoAvvio2.ForeColor = System.Drawing.Color.DarkRed
        Me.DescrizioneVideoPrimoAvvio2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DescrizioneVideoPrimoAvvio2.Location = New System.Drawing.Point(173, 127)
        Me.DescrizioneVideoPrimoAvvio2.Name = "DescrizioneVideoPrimoAvvio2"
        Me.DescrizioneVideoPrimoAvvio2.Size = New System.Drawing.Size(337, 58)
        Me.DescrizioneVideoPrimoAvvio2.TabIndex = 519
        Me.DescrizioneVideoPrimoAvvio2.TabStop = False
        Me.DescrizioneVideoPrimoAvvio2.Text = "In questo video viene mostrato i modi per creare un nuovo progetto."
        Me.DescrizioneVideoPrimoAvvio2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DescrizioneVideoPrimoAvvio2.UseVisualStyleBackColor = False
        '
        'VideoPrimoAvvio2
        '
        Me.VideoPrimoAvvio2.BackColor = System.Drawing.Color.Gray
        Me.VideoPrimoAvvio2.BackgroundImage = CType(resources.GetObject("VideoPrimoAvvio2.BackgroundImage"), System.Drawing.Image)
        Me.VideoPrimoAvvio2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VideoPrimoAvvio2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VideoPrimoAvvio2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.VideoPrimoAvvio2.FlatAppearance.BorderSize = 0
        Me.VideoPrimoAvvio2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.VideoPrimoAvvio2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.VideoPrimoAvvio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VideoPrimoAvvio2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoPrimoAvvio2.ForeColor = System.Drawing.Color.DarkRed
        Me.VideoPrimoAvvio2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VideoPrimoAvvio2.Location = New System.Drawing.Point(3, 95)
        Me.VideoPrimoAvvio2.Name = "VideoPrimoAvvio2"
        Me.VideoPrimoAvvio2.Size = New System.Drawing.Size(170, 90)
        Me.VideoPrimoAvvio2.TabIndex = 518
        Me.VideoPrimoAvvio2.TabStop = False
        Me.VideoPrimoAvvio2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.VideoPrimoAvvio2.UseVisualStyleBackColor = False
        '
        'TitoloVideoPrimoAvvio2
        '
        Me.TitoloVideoPrimoAvvio2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitoloVideoPrimoAvvio2.BackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TitoloVideoPrimoAvvio2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio2.FlatAppearance.BorderSize = 0
        Me.TitoloVideoPrimoAvvio2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TitoloVideoPrimoAvvio2.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TitoloVideoPrimoAvvio2.ForeColor = System.Drawing.Color.DarkRed
        Me.TitoloVideoPrimoAvvio2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TitoloVideoPrimoAvvio2.Location = New System.Drawing.Point(173, 95)
        Me.TitoloVideoPrimoAvvio2.Name = "TitoloVideoPrimoAvvio2"
        Me.TitoloVideoPrimoAvvio2.Size = New System.Drawing.Size(337, 32)
        Me.TitoloVideoPrimoAvvio2.TabIndex = 517
        Me.TitoloVideoPrimoAvvio2.TabStop = False
        Me.TitoloVideoPrimoAvvio2.Text = "Come creare un nuovo progetto"
        Me.TitoloVideoPrimoAvvio2.UseVisualStyleBackColor = False
        '
        'DescrizioneVideoPrimoAvvio1
        '
        Me.DescrizioneVideoPrimoAvvio1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescrizioneVideoPrimoAvvio1.BackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DescrizioneVideoPrimoAvvio1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio1.FlatAppearance.BorderSize = 0
        Me.DescrizioneVideoPrimoAvvio1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneVideoPrimoAvvio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescrizioneVideoPrimoAvvio1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneVideoPrimoAvvio1.ForeColor = System.Drawing.Color.DarkRed
        Me.DescrizioneVideoPrimoAvvio1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DescrizioneVideoPrimoAvvio1.Location = New System.Drawing.Point(173, 35)
        Me.DescrizioneVideoPrimoAvvio1.Name = "DescrizioneVideoPrimoAvvio1"
        Me.DescrizioneVideoPrimoAvvio1.Size = New System.Drawing.Size(337, 58)
        Me.DescrizioneVideoPrimoAvvio1.TabIndex = 509
        Me.DescrizioneVideoPrimoAvvio1.TabStop = False
        Me.DescrizioneVideoPrimoAvvio1.Text = "Questo è un video dedicato a tutti voi (anche a te) che avete scelto Minion One." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Un grazie dal cuore."
        Me.DescrizioneVideoPrimoAvvio1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DescrizioneVideoPrimoAvvio1.UseVisualStyleBackColor = False
        '
        'VideoPrimoAvvio1
        '
        Me.VideoPrimoAvvio1.BackColor = System.Drawing.Color.Gray
        Me.VideoPrimoAvvio1.BackgroundImage = CType(resources.GetObject("VideoPrimoAvvio1.BackgroundImage"), System.Drawing.Image)
        Me.VideoPrimoAvvio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VideoPrimoAvvio1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VideoPrimoAvvio1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.VideoPrimoAvvio1.FlatAppearance.BorderSize = 0
        Me.VideoPrimoAvvio1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.VideoPrimoAvvio1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.VideoPrimoAvvio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VideoPrimoAvvio1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoPrimoAvvio1.ForeColor = System.Drawing.Color.DarkRed
        Me.VideoPrimoAvvio1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VideoPrimoAvvio1.Location = New System.Drawing.Point(3, 3)
        Me.VideoPrimoAvvio1.Name = "VideoPrimoAvvio1"
        Me.VideoPrimoAvvio1.Size = New System.Drawing.Size(170, 90)
        Me.VideoPrimoAvvio1.TabIndex = 508
        Me.VideoPrimoAvvio1.TabStop = False
        Me.VideoPrimoAvvio1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.VideoPrimoAvvio1.UseVisualStyleBackColor = False
        '
        'TitoloVideoPrimoAvvio1
        '
        Me.TitoloVideoPrimoAvvio1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitoloVideoPrimoAvvio1.BackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TitoloVideoPrimoAvvio1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio1.FlatAppearance.BorderSize = 0
        Me.TitoloVideoPrimoAvvio1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.TitoloVideoPrimoAvvio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TitoloVideoPrimoAvvio1.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.TitoloVideoPrimoAvvio1.ForeColor = System.Drawing.Color.DarkRed
        Me.TitoloVideoPrimoAvvio1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TitoloVideoPrimoAvvio1.Location = New System.Drawing.Point(173, 3)
        Me.TitoloVideoPrimoAvvio1.Name = "TitoloVideoPrimoAvvio1"
        Me.TitoloVideoPrimoAvvio1.Size = New System.Drawing.Size(337, 32)
        Me.TitoloVideoPrimoAvvio1.TabIndex = 507
        Me.TitoloVideoPrimoAvvio1.TabStop = False
        Me.TitoloVideoPrimoAvvio1.Text = "Benvenuto/a in Minion One"
        Me.TitoloVideoPrimoAvvio1.UseVisualStyleBackColor = False
        '
        'RicercaPanel
        '
        Me.RicercaPanel.Controls.Add(Me.CercaOnlineNORESULT)
        Me.RicercaPanel.Controls.Add(Me.CodiceErroreText)
        Me.RicercaPanel.Controls.Add(Me.DescrizioneErroreText)
        Me.RicercaPanel.Location = New System.Drawing.Point(0, 22)
        Me.RicercaPanel.Name = "RicercaPanel"
        Me.RicercaPanel.Size = New System.Drawing.Size(530, 317)
        Me.RicercaPanel.TabIndex = 13
        '
        'CercaOnlineNORESULT
        '
        Me.CercaOnlineNORESULT.BackColor = System.Drawing.Color.DarkRed
        Me.CercaOnlineNORESULT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CercaOnlineNORESULT.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.CercaOnlineNORESULT.FlatAppearance.BorderSize = 0
        Me.CercaOnlineNORESULT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.CercaOnlineNORESULT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CercaOnlineNORESULT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CercaOnlineNORESULT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CercaOnlineNORESULT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CercaOnlineNORESULT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CercaOnlineNORESULT.Location = New System.Drawing.Point(139, 88)
        Me.CercaOnlineNORESULT.Name = "CercaOnlineNORESULT"
        Me.CercaOnlineNORESULT.Size = New System.Drawing.Size(254, 35)
        Me.CercaOnlineNORESULT.TabIndex = 506
        Me.CercaOnlineNORESULT.Text = "Cerca online ••►"
        Me.CercaOnlineNORESULT.UseVisualStyleBackColor = False
        Me.CercaOnlineNORESULT.Visible = False
        '
        'CodiceErroreText
        '
        Me.CodiceErroreText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodiceErroreText.BackColor = System.Drawing.Color.DimGray
        Me.CodiceErroreText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CodiceErroreText.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.CodiceErroreText.FlatAppearance.BorderSize = 0
        Me.CodiceErroreText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.CodiceErroreText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.CodiceErroreText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CodiceErroreText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodiceErroreText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CodiceErroreText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CodiceErroreText.Location = New System.Drawing.Point(0, 0)
        Me.CodiceErroreText.Name = "CodiceErroreText"
        Me.CodiceErroreText.Size = New System.Drawing.Size(530, 36)
        Me.CodiceErroreText.TabIndex = 505
        Me.CodiceErroreText.TabStop = False
        Me.CodiceErroreText.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CodiceErroreText.UseVisualStyleBackColor = False
        '
        'DescrizioneErroreText
        '
        Me.DescrizioneErroreText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescrizioneErroreText.BackColor = System.Drawing.Color.DimGray
        Me.DescrizioneErroreText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DescrizioneErroreText.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.DescrizioneErroreText.FlatAppearance.BorderSize = 0
        Me.DescrizioneErroreText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneErroreText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.DescrizioneErroreText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DescrizioneErroreText.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescrizioneErroreText.ForeColor = System.Drawing.Color.DarkRed
        Me.DescrizioneErroreText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DescrizioneErroreText.Location = New System.Drawing.Point(0, 36)
        Me.DescrizioneErroreText.Name = "DescrizioneErroreText"
        Me.DescrizioneErroreText.Size = New System.Drawing.Size(530, 281)
        Me.DescrizioneErroreText.TabIndex = 504
        Me.DescrizioneErroreText.TabStop = False
        Me.DescrizioneErroreText.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.DescrizioneErroreText.UseVisualStyleBackColor = False
        '
        'Aiuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(655, 339)
        Me.Controls.Add(Me.CercaPanel)
        Me.Controls.Add(Me.BarraLaterale)
        Me.Controls.Add(Me.PrimoAvvioPanel)
        Me.Controls.Add(Me.TutorialPanel)
        Me.Controls.Add(Me.RicercaPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Aiuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aiuto"
        Me.BarraLaterale.ResumeLayout(False)
        Me.CercaPanel.ResumeLayout(False)
        Me.CercaPanel.PerformLayout()
        Me.TutorialPanel.ResumeLayout(False)
        Me.PrimoAvvioPanel.ResumeLayout(False)
        Me.RicercaPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarraLaterale As System.Windows.Forms.Panel
    Friend WithEvents NovitaButton As System.Windows.Forms.Button
    Friend WithEvents PrimoAvvioButton As System.Windows.Forms.Button
    Friend WithEvents TutorialButton As System.Windows.Forms.Button
    Friend WithEvents CercaPanel As System.Windows.Forms.Panel
    Friend WithEvents CercaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TutorialPanel As System.Windows.Forms.Panel
    Friend WithEvents PrimoAvvioPanel As System.Windows.Forms.Panel
    Friend WithEvents CercaButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RicercaPanel As System.Windows.Forms.Panel
    Friend WithEvents DescrizioneErroreText As System.Windows.Forms.Button
    Friend WithEvents CodiceErroreText As System.Windows.Forms.Button
    Friend WithEvents CercaOnlineNORESULT As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DescrizioneVideoPrimoAvvio1 As System.Windows.Forms.Button
    Friend WithEvents VideoPrimoAvvio1 As System.Windows.Forms.Button
    Friend WithEvents TitoloVideoPrimoAvvio1 As System.Windows.Forms.Button
    Friend WithEvents DescrizioneVideoPrimoAvvio3 As System.Windows.Forms.Button
    Friend WithEvents VideoPrimoAvvio3 As System.Windows.Forms.Button
    Friend WithEvents TitoloVideoPrimoAvvio3 As System.Windows.Forms.Button
    Friend WithEvents DescrizioneVideoPrimoAvvio4 As System.Windows.Forms.Button
    Friend WithEvents VideoPrimoAvvio4 As System.Windows.Forms.Button
    Friend WithEvents TitoloVideoPrimoAvvio4 As System.Windows.Forms.Button
    Friend WithEvents DescrizioneVideoPrimoAvvio2 As System.Windows.Forms.Button
    Friend WithEvents VideoPrimoAvvio2 As System.Windows.Forms.Button
    Friend WithEvents TitoloVideoPrimoAvvio2 As System.Windows.Forms.Button
End Class
