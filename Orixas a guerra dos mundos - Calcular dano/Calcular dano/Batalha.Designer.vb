<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Batalhar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Batalhar))
        Me.PicB_Aiye = New System.Windows.Forms.PictureBox()
        Me.PicB_Orum = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Vida = New System.Windows.Forms.ComboBox()
        Me.L_VidaOrum = New System.Windows.Forms.Label()
        Me.L_VidaAiye = New System.Windows.Forms.Label()
        Me.Ataque = New System.Windows.Forms.ComboBox()
        Me.ProB_Vida_Orum = New System.Windows.Forms.ProgressBar()
        Me.ProB_Vida_Aiye = New System.Windows.Forms.ProgressBar()
        Me.MasB_OrumDado = New System.Windows.Forms.MaskedTextBox()
        Me.L_OrumDado = New System.Windows.Forms.Label()
        Me.B_OrumAtachar = New System.Windows.Forms.Button()
        Me.B_AiyeAtacar = New System.Windows.Forms.Button()
        Me.L_AiyeDado = New System.Windows.Forms.Label()
        Me.MasB_AiyeDado = New System.Windows.Forms.MaskedTextBox()
        Me.L_teste = New System.Windows.Forms.Label()
        CType(Me.PicB_Aiye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicB_Orum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicB_Aiye
        '
        Me.PicB_Aiye.BackColor = System.Drawing.Color.OliveDrab
        Me.PicB_Aiye.Location = New System.Drawing.Point(343, 91)
        Me.PicB_Aiye.Name = "PicB_Aiye"
        Me.PicB_Aiye.Size = New System.Drawing.Size(200, 200)
        Me.PicB_Aiye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicB_Aiye.TabIndex = 13
        Me.PicB_Aiye.TabStop = False
        '
        'PicB_Orum
        '
        Me.PicB_Orum.BackColor = System.Drawing.Color.OliveDrab
        Me.PicB_Orum.Location = New System.Drawing.Point(41, 91)
        Me.PicB_Orum.Name = "PicB_Orum"
        Me.PicB_Orum.Size = New System.Drawing.Size(200, 200)
        Me.PicB_Orum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicB_Orum.TabIndex = 12
        Me.PicB_Orum.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(421, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Aiye"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Orum"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Sistema calcular Dano"
        '
        'Vida
        '
        Me.Vida.FormattingEnabled = True
        Me.Vida.Items.AddRange(New Object() {"100", "80", "90", "60", "70", "55", "50", "40", "30", "20"})
        Me.Vida.Location = New System.Drawing.Point(300, 64)
        Me.Vida.Name = "Vida"
        Me.Vida.Size = New System.Drawing.Size(45, 21)
        Me.Vida.TabIndex = 14
        Me.Vida.Visible = False
        '
        'L_VidaOrum
        '
        Me.L_VidaOrum.AutoSize = True
        Me.L_VidaOrum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_VidaOrum.Location = New System.Drawing.Point(32, 304)
        Me.L_VidaOrum.Name = "L_VidaOrum"
        Me.L_VidaOrum.Size = New System.Drawing.Size(51, 18)
        Me.L_VidaOrum.TabIndex = 15
        Me.L_VidaOrum.Text = "Label4"
        '
        'L_VidaAiye
        '
        Me.L_VidaAiye.AutoSize = True
        Me.L_VidaAiye.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_VidaAiye.Location = New System.Drawing.Point(334, 304)
        Me.L_VidaAiye.Name = "L_VidaAiye"
        Me.L_VidaAiye.Size = New System.Drawing.Size(51, 18)
        Me.L_VidaAiye.TabIndex = 16
        Me.L_VidaAiye.Text = "Label4"
        '
        'Ataque
        '
        Me.Ataque.FormattingEnabled = True
        Me.Ataque.Items.AddRange(New Object() {"100", "90", "80", "70", "60", "75", "40", "50", "20", "30"})
        Me.Ataque.Location = New System.Drawing.Point(239, 64)
        Me.Ataque.Name = "Ataque"
        Me.Ataque.Size = New System.Drawing.Size(55, 21)
        Me.Ataque.TabIndex = 17
        Me.Ataque.Visible = False
        '
        'ProB_Vida_Orum
        '
        Me.ProB_Vida_Orum.BackColor = System.Drawing.Color.White
        Me.ProB_Vida_Orum.ForeColor = System.Drawing.Color.Red
        Me.ProB_Vida_Orum.Location = New System.Drawing.Point(41, 327)
        Me.ProB_Vida_Orum.Name = "ProB_Vida_Orum"
        Me.ProB_Vida_Orum.Size = New System.Drawing.Size(200, 23)
        Me.ProB_Vida_Orum.TabIndex = 18
        Me.ProB_Vida_Orum.Value = 50
        '
        'ProB_Vida_Aiye
        '
        Me.ProB_Vida_Aiye.BackColor = System.Drawing.Color.White
        Me.ProB_Vida_Aiye.ForeColor = System.Drawing.Color.Red
        Me.ProB_Vida_Aiye.Location = New System.Drawing.Point(343, 327)
        Me.ProB_Vida_Aiye.Name = "ProB_Vida_Aiye"
        Me.ProB_Vida_Aiye.Size = New System.Drawing.Size(200, 23)
        Me.ProB_Vida_Aiye.TabIndex = 19
        Me.ProB_Vida_Aiye.Value = 50
        '
        'MasB_OrumDado
        '
        Me.MasB_OrumDado.BackColor = System.Drawing.Color.White
        Me.MasB_OrumDado.Location = New System.Drawing.Point(41, 385)
        Me.MasB_OrumDado.Name = "MasB_OrumDado"
        Me.MasB_OrumDado.Size = New System.Drawing.Size(119, 20)
        Me.MasB_OrumDado.TabIndex = 20
        '
        'L_OrumDado
        '
        Me.L_OrumDado.AutoSize = True
        Me.L_OrumDado.Location = New System.Drawing.Point(38, 369)
        Me.L_OrumDado.Name = "L_OrumDado"
        Me.L_OrumDado.Size = New System.Drawing.Size(76, 13)
        Me.L_OrumDado.TabIndex = 21
        Me.L_OrumDado.Text = "Valor do dado:"
        '
        'B_OrumAtachar
        '
        Me.B_OrumAtachar.BackColor = System.Drawing.Color.White
        Me.B_OrumAtachar.Location = New System.Drawing.Point(166, 385)
        Me.B_OrumAtachar.Name = "B_OrumAtachar"
        Me.B_OrumAtachar.Size = New System.Drawing.Size(75, 23)
        Me.B_OrumAtachar.TabIndex = 22
        Me.B_OrumAtachar.Text = "Atacar"
        Me.B_OrumAtachar.UseVisualStyleBackColor = False
        '
        'B_AiyeAtacar
        '
        Me.B_AiyeAtacar.BackColor = System.Drawing.Color.White
        Me.B_AiyeAtacar.Location = New System.Drawing.Point(468, 388)
        Me.B_AiyeAtacar.Name = "B_AiyeAtacar"
        Me.B_AiyeAtacar.Size = New System.Drawing.Size(75, 23)
        Me.B_AiyeAtacar.TabIndex = 25
        Me.B_AiyeAtacar.Text = "Atacar"
        Me.B_AiyeAtacar.UseVisualStyleBackColor = False
        '
        'L_AiyeDado
        '
        Me.L_AiyeDado.AutoSize = True
        Me.L_AiyeDado.Location = New System.Drawing.Point(340, 372)
        Me.L_AiyeDado.Name = "L_AiyeDado"
        Me.L_AiyeDado.Size = New System.Drawing.Size(76, 13)
        Me.L_AiyeDado.TabIndex = 24
        Me.L_AiyeDado.Text = "Valor do dado:"
        '
        'MasB_AiyeDado
        '
        Me.MasB_AiyeDado.BackColor = System.Drawing.Color.White
        Me.MasB_AiyeDado.Location = New System.Drawing.Point(343, 388)
        Me.MasB_AiyeDado.Name = "MasB_AiyeDado"
        Me.MasB_AiyeDado.Size = New System.Drawing.Size(119, 20)
        Me.MasB_AiyeDado.TabIndex = 23
        '
        'L_teste
        '
        Me.L_teste.AutoSize = True
        Me.L_teste.Location = New System.Drawing.Point(44, 429)
        Me.L_teste.Name = "L_teste"
        Me.L_teste.Size = New System.Drawing.Size(39, 13)
        Me.L_teste.TabIndex = 26
        Me.L_teste.Text = "Label4"
        '
        'Batalhar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(595, 451)
        Me.Controls.Add(Me.L_teste)
        Me.Controls.Add(Me.B_AiyeAtacar)
        Me.Controls.Add(Me.L_AiyeDado)
        Me.Controls.Add(Me.MasB_AiyeDado)
        Me.Controls.Add(Me.B_OrumAtachar)
        Me.Controls.Add(Me.L_OrumDado)
        Me.Controls.Add(Me.MasB_OrumDado)
        Me.Controls.Add(Me.ProB_Vida_Aiye)
        Me.Controls.Add(Me.ProB_Vida_Orum)
        Me.Controls.Add(Me.Ataque)
        Me.Controls.Add(Me.L_VidaAiye)
        Me.Controls.Add(Me.L_VidaOrum)
        Me.Controls.Add(Me.Vida)
        Me.Controls.Add(Me.PicB_Aiye)
        Me.Controls.Add(Me.PicB_Orum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Batalhar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batalha"
        CType(Me.PicB_Aiye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicB_Orum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicB_Aiye As System.Windows.Forms.PictureBox
    Friend WithEvents PicB_Orum As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Vida As System.Windows.Forms.ComboBox
    Friend WithEvents L_VidaOrum As System.Windows.Forms.Label
    Friend WithEvents L_VidaAiye As System.Windows.Forms.Label
    Friend WithEvents Ataque As System.Windows.Forms.ComboBox
    Friend WithEvents ProB_Vida_Orum As System.Windows.Forms.ProgressBar
    Friend WithEvents ProB_Vida_Aiye As System.Windows.Forms.ProgressBar
    Friend WithEvents MasB_OrumDado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_OrumDado As System.Windows.Forms.Label
    Friend WithEvents B_OrumAtachar As System.Windows.Forms.Button
    Friend WithEvents B_AiyeAtacar As System.Windows.Forms.Button
    Friend WithEvents L_AiyeDado As System.Windows.Forms.Label
    Friend WithEvents MasB_AiyeDado As System.Windows.Forms.MaskedTextBox
    Friend WithEvents L_teste As System.Windows.Forms.Label
End Class
