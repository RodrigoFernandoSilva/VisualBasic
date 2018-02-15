<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheB_BonusAiye = New System.Windows.Forms.CheckBox()
        Me.CheB_BonusOrum = New System.Windows.Forms.CheckBox()
        Me.B_Batahlar = New System.Windows.Forms.Button()
        Me.ComB_Orum = New System.Windows.Forms.ComboBox()
        Me.ComB_Aiye = New System.Windows.Forms.ComboBox()
        Me.PicB_Aiye = New System.Windows.Forms.PictureBox()
        Me.PicB_Orum = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadB_AtkAiye = New System.Windows.Forms.RadioButton()
        Me.RadB_AtkOrum = New System.Windows.Forms.RadioButton()
        Me.ComB_AiyeNames = New System.Windows.Forms.ComboBox()
        Me.ComB_OrumNames = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PicB_Aiye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicB_Orum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema calcular Dano"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Orum"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(421, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Aiye"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheB_BonusAiye)
        Me.Panel1.Controls.Add(Me.CheB_BonusOrum)
        Me.Panel1.Location = New System.Drawing.Point(12, 330)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 39)
        Me.Panel1.TabIndex = 2
        '
        'CheB_BonusAiye
        '
        Me.CheB_BonusAiye.AutoSize = True
        Me.CheB_BonusAiye.Location = New System.Drawing.Point(512, 11)
        Me.CheB_BonusAiye.Name = "CheB_BonusAiye"
        Me.CheB_BonusAiye.Size = New System.Drawing.Size(56, 17)
        Me.CheB_BonusAiye.TabIndex = 4
        Me.CheB_BonusAiye.Text = "Bonus"
        Me.CheB_BonusAiye.UseVisualStyleBackColor = True
        '
        'CheB_BonusOrum
        '
        Me.CheB_BonusOrum.AutoSize = True
        Me.CheB_BonusOrum.Location = New System.Drawing.Point(3, 11)
        Me.CheB_BonusOrum.Name = "CheB_BonusOrum"
        Me.CheB_BonusOrum.Size = New System.Drawing.Size(56, 17)
        Me.CheB_BonusOrum.TabIndex = 3
        Me.CheB_BonusOrum.Text = "Bonus"
        Me.CheB_BonusOrum.UseVisualStyleBackColor = True
        '
        'B_Batahlar
        '
        Me.B_Batahlar.BackColor = System.Drawing.Color.White
        Me.B_Batahlar.Location = New System.Drawing.Point(270, 419)
        Me.B_Batahlar.Name = "B_Batahlar"
        Me.B_Batahlar.Size = New System.Drawing.Size(75, 23)
        Me.B_Batahlar.TabIndex = 8
        Me.B_Batahlar.Text = "Batalhar"
        Me.B_Batahlar.UseVisualStyleBackColor = False
        '
        'ComB_Orum
        '
        Me.ComB_Orum.BackColor = System.Drawing.Color.White
        Me.ComB_Orum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComB_Orum.FormattingEnabled = True
        Me.ComB_Orum.Items.AddRange(New Object() {"Olorum", "Ogum", "Boss - Diaboso", "Boss - Fixe man", "Boss - Inimigos", "Oxalá", "Inimigo - Turbante", "Inimigo - Adaga", "Inimigo - Escudo", "Inimigo"})
        Me.ComB_Orum.Location = New System.Drawing.Point(12, 301)
        Me.ComB_Orum.Name = "ComB_Orum"
        Me.ComB_Orum.Size = New System.Drawing.Size(271, 21)
        Me.ComB_Orum.TabIndex = 0
        '
        'ComB_Aiye
        '
        Me.ComB_Aiye.BackColor = System.Drawing.Color.White
        Me.ComB_Aiye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComB_Aiye.FormattingEnabled = True
        Me.ComB_Aiye.Items.AddRange(New Object() {"Abejide", "Ancião", "Ferreiro", "Vendedor", "Abejide pai", "Abejide Mãe", "NPC - Guerreiro", "NPC- Arqueiro", "NPC - Menina", "NPC - Menino"})
        Me.ComB_Aiye.Location = New System.Drawing.Point(314, 301)
        Me.ComB_Aiye.Name = "ComB_Aiye"
        Me.ComB_Aiye.Size = New System.Drawing.Size(271, 21)
        Me.ComB_Aiye.TabIndex = 1
        '
        'PicB_Aiye
        '
        Me.PicB_Aiye.BackColor = System.Drawing.Color.OliveDrab
        Me.PicB_Aiye.Location = New System.Drawing.Point(343, 92)
        Me.PicB_Aiye.Name = "PicB_Aiye"
        Me.PicB_Aiye.Size = New System.Drawing.Size(200, 200)
        Me.PicB_Aiye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicB_Aiye.TabIndex = 8
        Me.PicB_Aiye.TabStop = False
        '
        'PicB_Orum
        '
        Me.PicB_Orum.BackColor = System.Drawing.Color.OliveDrab
        Me.PicB_Orum.Location = New System.Drawing.Point(41, 92)
        Me.PicB_Orum.Name = "PicB_Orum"
        Me.PicB_Orum.Size = New System.Drawing.Size(200, 200)
        Me.PicB_Orum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicB_Orum.TabIndex = 6
        Me.PicB_Orum.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadB_AtkAiye)
        Me.Panel2.Controls.Add(Me.RadB_AtkOrum)
        Me.Panel2.Location = New System.Drawing.Point(12, 367)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(571, 39)
        Me.Panel2.TabIndex = 5
        '
        'RadB_AtkAiye
        '
        Me.RadB_AtkAiye.AutoSize = True
        Me.RadB_AtkAiye.Location = New System.Drawing.Point(475, 11)
        Me.RadB_AtkAiye.Name = "RadB_AtkAiye"
        Me.RadB_AtkAiye.Size = New System.Drawing.Size(93, 17)
        Me.RadB_AtkAiye.TabIndex = 7
        Me.RadB_AtkAiye.TabStop = True
        Me.RadB_AtkAiye.Text = "Ataca Primeiro"
        Me.RadB_AtkAiye.UseVisualStyleBackColor = True
        '
        'RadB_AtkOrum
        '
        Me.RadB_AtkOrum.AutoSize = True
        Me.RadB_AtkOrum.Location = New System.Drawing.Point(3, 11)
        Me.RadB_AtkOrum.Name = "RadB_AtkOrum"
        Me.RadB_AtkOrum.Size = New System.Drawing.Size(93, 17)
        Me.RadB_AtkOrum.TabIndex = 6
        Me.RadB_AtkOrum.TabStop = True
        Me.RadB_AtkOrum.Text = "Ataca Primeiro"
        Me.RadB_AtkOrum.UseVisualStyleBackColor = True
        '
        'ComB_AiyeNames
        '
        Me.ComB_AiyeNames.BackColor = System.Drawing.SystemColors.Window
        Me.ComB_AiyeNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComB_AiyeNames.FormattingEnabled = True
        Me.ComB_AiyeNames.Items.AddRange(New Object() {"Abejide", "Ancião", "Ferreiro", "Vendedor", "Abejide pai", "Abejide Mãe", "NPC - Guerreiro", "NPC- Arqueiro", "NPC - Menina", "NPC - Menino"})
        Me.ComB_AiyeNames.Location = New System.Drawing.Point(317, 32)
        Me.ComB_AiyeNames.Name = "ComB_AiyeNames"
        Me.ComB_AiyeNames.Size = New System.Drawing.Size(271, 21)
        Me.ComB_AiyeNames.TabIndex = 10
        Me.ComB_AiyeNames.Visible = False
        '
        'ComB_OrumNames
        '
        Me.ComB_OrumNames.BackColor = System.Drawing.SystemColors.Window
        Me.ComB_OrumNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComB_OrumNames.FormattingEnabled = True
        Me.ComB_OrumNames.Items.AddRange(New Object() {"Olorum", "Ogum", "Boss - Diaboso", "Boss - Fixe man", "Boss - Inimigos", "Oxalá", "Inimigo - Turbante", "Inimigo - Adaga", "Inimigo - Escudo", "Inimigo"})
        Me.ComB_OrumNames.Location = New System.Drawing.Point(15, 32)
        Me.ComB_OrumNames.Name = "ComB_OrumNames"
        Me.ComB_OrumNames.Size = New System.Drawing.Size(271, 21)
        Me.ComB_OrumNames.TabIndex = 9
        Me.ComB_OrumNames.Visible = False
        '
        'MenuPrin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(595, 454)
        Me.Controls.Add(Me.ComB_AiyeNames)
        Me.Controls.Add(Me.ComB_OrumNames)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ComB_Aiye)
        Me.Controls.Add(Me.PicB_Aiye)
        Me.Controls.Add(Me.ComB_Orum)
        Me.Controls.Add(Me.PicB_Orum)
        Me.Controls.Add(Me.B_Batahlar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MenuPrin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batalha Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicB_Aiye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicB_Orum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents B_Batahlar As System.Windows.Forms.Button
    Friend WithEvents CheB_BonusAiye As System.Windows.Forms.CheckBox
    Friend WithEvents CheB_BonusOrum As System.Windows.Forms.CheckBox
    Friend WithEvents PicB_Orum As System.Windows.Forms.PictureBox
    Friend WithEvents ComB_Orum As System.Windows.Forms.ComboBox
    Friend WithEvents ComB_Aiye As System.Windows.Forms.ComboBox
    Friend WithEvents PicB_Aiye As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadB_AtkAiye As System.Windows.Forms.RadioButton
    Friend WithEvents RadB_AtkOrum As System.Windows.Forms.RadioButton
    Friend WithEvents ComB_AiyeNames As System.Windows.Forms.ComboBox
    Friend WithEvents ComB_OrumNames As System.Windows.Forms.ComboBox

End Class
