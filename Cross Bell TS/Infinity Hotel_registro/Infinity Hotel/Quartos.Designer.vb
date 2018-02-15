<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quartos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quartos))
        Me.B_Sair = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.M_CelularN = New System.Windows.Forms.MaskedTextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.T_Nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.N_quarto = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_ValorTotal = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.L_restaurante = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.L_Diaria = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.M_NdeDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.T_TipoDeDocumento = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.T_observação = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.T_Email = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.L_CheckOut = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.L_Ndias = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.L_dataCheckIn = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.L_EstatusDoQuarto = New System.Windows.Forms.Label()
        Me.B_VerTodosDados = New System.Windows.Forms.Button()
        Me.L_data = New System.Windows.Forms.Label()
        Me.L_hora = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_quarto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_Sair
        '
        Me.B_Sair.BackColor = System.Drawing.Color.White
        Me.B_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_Sair.Location = New System.Drawing.Point(608, 375)
        Me.B_Sair.Name = "B_Sair"
        Me.B_Sair.Size = New System.Drawing.Size(54, 23)
        Me.B_Sair.TabIndex = 161
        Me.B_Sair.Text = "Sair"
        Me.B_Sair.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox2.Image = Global.Infinity_Hotel.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(218, -25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(259, 173)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 143
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox3.Image = Global.Infinity_Hotel.My.Resources.Resources.Plano_de_fundo
        Me.PictureBox3.Location = New System.Drawing.Point(-42, -72)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(749, 495)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 160
        Me.PictureBox3.TabStop = False
        '
        'M_CelularN
        '
        Me.M_CelularN.BackColor = System.Drawing.Color.White
        Me.M_CelularN.Enabled = False
        Me.M_CelularN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_CelularN.Location = New System.Drawing.Point(11, 276)
        Me.M_CelularN.Name = "M_CelularN"
        Me.M_CelularN.Size = New System.Drawing.Size(358, 21)
        Me.M_CelularN.TabIndex = 222
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label33.Image = CType(resources.GetObject("Label33.Image"), System.Drawing.Image)
        Me.Label33.Location = New System.Drawing.Point(9, 258)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(52, 15)
        Me.Label33.TabIndex = 223
        Me.Label33.Text = "Celular :"
        '
        'T_Nome
        '
        Me.T_Nome.BackColor = System.Drawing.Color.White
        Me.T_Nome.Enabled = False
        Me.T_Nome.Location = New System.Drawing.Point(11, 185)
        Me.T_Nome.Name = "T_Nome"
        Me.T_Nome.Size = New System.Drawing.Size(358, 20)
        Me.T_Nome.TabIndex = 219
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(11, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 218
        Me.Label2.Text = "Nome:"
        '
        'N_quarto
        '
        Me.N_quarto.Location = New System.Drawing.Point(11, 141)
        Me.N_quarto.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.N_quarto.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.N_quarto.Name = "N_quarto"
        Me.N_quarto.Size = New System.Drawing.Size(120, 20)
        Me.N_quarto.TabIndex = 224
        Me.N_quarto.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(8, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 226
        Me.Label1.Text = "Escola um quarto:"
        '
        'L_ValorTotal
        '
        Me.L_ValorTotal.AutoSize = True
        Me.L_ValorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ValorTotal.ForeColor = System.Drawing.Color.Red
        Me.L_ValorTotal.Image = CType(resources.GetObject("L_ValorTotal.Image"), System.Drawing.Image)
        Me.L_ValorTotal.Location = New System.Drawing.Point(323, 379)
        Me.L_ValorTotal.Name = "L_ValorTotal"
        Me.L_ValorTotal.Size = New System.Drawing.Size(19, 20)
        Me.L_ValorTotal.TabIndex = 243
        Me.L_ValorTotal.Text = "0"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Image = CType(resources.GetObject("Label30.Image"), System.Drawing.Image)
        Me.Label30.Location = New System.Drawing.Point(291, 379)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(38, 20)
        Me.Label30.TabIndex = 244
        Me.Label30.Text = "-R$"
        '
        'L_restaurante
        '
        Me.L_restaurante.AutoSize = True
        Me.L_restaurante.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_restaurante.ForeColor = System.Drawing.Color.Red
        Me.L_restaurante.Image = CType(resources.GetObject("L_restaurante.Image"), System.Drawing.Image)
        Me.L_restaurante.Location = New System.Drawing.Point(162, 379)
        Me.L_restaurante.Name = "L_restaurante"
        Me.L_restaurante.Size = New System.Drawing.Size(19, 20)
        Me.L_restaurante.TabIndex = 241
        Me.L_restaurante.Text = "0"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.Location = New System.Drawing.Point(130, 379)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 20)
        Me.Label29.TabIndex = 242
        Me.Label29.Text = "-R$"
        '
        'L_Diaria
        '
        Me.L_Diaria.AutoSize = True
        Me.L_Diaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Diaria.ForeColor = System.Drawing.Color.Red
        Me.L_Diaria.Image = CType(resources.GetObject("L_Diaria.Image"), System.Drawing.Image)
        Me.L_Diaria.Location = New System.Drawing.Point(41, 380)
        Me.L_Diaria.Name = "L_Diaria"
        Me.L_Diaria.Size = New System.Drawing.Size(19, 20)
        Me.L_Diaria.TabIndex = 236
        Me.L_Diaria.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Image = CType(resources.GetObject("Label26.Image"), System.Drawing.Image)
        Me.Label26.Location = New System.Drawing.Point(9, 380)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 20)
        Me.Label26.TabIndex = 240
        Me.Label26.Text = "-R$"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.Location = New System.Drawing.Point(287, 361)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 16)
        Me.Label24.TabIndex = 239
        Me.Label24.Text = "Valor total:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
        Me.Label16.Location = New System.Drawing.Point(130, 361)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(156, 16)
        Me.Label16.TabIndex = 238
        Me.Label16.Text = "Multa por dias amais:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(11, 361)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 237
        Me.Label10.Text = "Valor daDiaria:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Image = CType(resources.GetObject("Label28.Image"), System.Drawing.Image)
        Me.Label28.Location = New System.Drawing.Point(177, 308)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(138, 15)
        Me.Label28.TabIndex = 248
        Me.Label28.Text = "N° Tipo de Documento :"
        '
        'M_NdeDocumento
        '
        Me.M_NdeDocumento.BackColor = System.Drawing.Color.White
        Me.M_NdeDocumento.Enabled = False
        Me.M_NdeDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_NdeDocumento.Location = New System.Drawing.Point(180, 326)
        Me.M_NdeDocumento.Name = "M_NdeDocumento"
        Me.M_NdeDocumento.Size = New System.Drawing.Size(189, 21)
        Me.M_NdeDocumento.TabIndex = 247
        '
        'T_TipoDeDocumento
        '
        Me.T_TipoDeDocumento.BackColor = System.Drawing.Color.White
        Me.T_TipoDeDocumento.Enabled = False
        Me.T_TipoDeDocumento.Location = New System.Drawing.Point(12, 325)
        Me.T_TipoDeDocumento.Name = "T_TipoDeDocumento"
        Me.T_TipoDeDocumento.Size = New System.Drawing.Size(151, 20)
        Me.T_TipoDeDocumento.TabIndex = 246
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.Location = New System.Drawing.Point(11, 307)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 15)
        Me.Label18.TabIndex = 245
        Me.Label18.Text = "Tipo de Documento :"
        '
        'T_observação
        '
        Me.T_observação.BackColor = System.Drawing.Color.White
        Me.T_observação.Enabled = False
        Me.T_observação.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_observação.Location = New System.Drawing.Point(392, 183)
        Me.T_observação.Multiline = True
        Me.T_observação.Name = "T_observação"
        Me.T_observação.Size = New System.Drawing.Size(277, 73)
        Me.T_observação.TabIndex = 249
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(389, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 15)
        Me.Label8.TabIndex = 250
        Me.Label8.Text = "Observaçães - Notes"
        '
        'T_Email
        '
        Me.T_Email.BackColor = System.Drawing.Color.White
        Me.T_Email.Enabled = False
        Me.T_Email.Location = New System.Drawing.Point(11, 230)
        Me.T_Email.Name = "T_Email"
        Me.T_Email.Size = New System.Drawing.Size(358, 20)
        Me.T_Email.TabIndex = 251
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(8, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 252
        Me.Label12.Text = "Email :"
        '
        'L_CheckOut
        '
        Me.L_CheckOut.AutoSize = True
        Me.L_CheckOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_CheckOut.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_CheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_CheckOut.Image = CType(resources.GetObject("L_CheckOut.Image"), System.Drawing.Image)
        Me.L_CheckOut.Location = New System.Drawing.Point(508, 290)
        Me.L_CheckOut.Name = "L_CheckOut"
        Me.L_CheckOut.Size = New System.Drawing.Size(80, 18)
        Me.L_CheckOut.TabIndex = 258
        Me.L_CheckOut.Text = "00/00/0000"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.Location = New System.Drawing.Point(506, 271)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 18)
        Me.Label22.TabIndex = 257
        Me.Label22.Text = "Check Out:"
        '
        'L_Ndias
        '
        Me.L_Ndias.AutoSize = True
        Me.L_Ndias.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_Ndias.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Ndias.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_Ndias.Image = CType(resources.GetObject("L_Ndias.Image"), System.Drawing.Image)
        Me.L_Ndias.Location = New System.Drawing.Point(394, 345)
        Me.L_Ndias.Name = "L_Ndias"
        Me.L_Ndias.Size = New System.Drawing.Size(18, 19)
        Me.L_Ndias.TabIndex = 256
        Me.L_Ndias.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(392, 327)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 18)
        Me.Label11.TabIndex = 255
        Me.Label11.Text = "Nº de Dias da hospedagem"
        '
        'L_dataCheckIn
        '
        Me.L_dataCheckIn.AutoSize = True
        Me.L_dataCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_dataCheckIn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_dataCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_dataCheckIn.Image = CType(resources.GetObject("L_dataCheckIn.Image"), System.Drawing.Image)
        Me.L_dataCheckIn.Location = New System.Drawing.Point(392, 291)
        Me.L_dataCheckIn.Name = "L_dataCheckIn"
        Me.L_dataCheckIn.Size = New System.Drawing.Size(80, 18)
        Me.L_dataCheckIn.TabIndex = 254
        Me.L_dataCheckIn.Text = "00/00/0000"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.Location = New System.Drawing.Point(389, 271)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 18)
        Me.Label21.TabIndex = 253
        Me.Label21.Text = "Check in :"
        '
        'L_EstatusDoQuarto
        '
        Me.L_EstatusDoQuarto.AutoSize = True
        Me.L_EstatusDoQuarto.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_EstatusDoQuarto.ForeColor = System.Drawing.Color.White
        Me.L_EstatusDoQuarto.Image = CType(resources.GetObject("L_EstatusDoQuarto.Image"), System.Drawing.Image)
        Me.L_EstatusDoQuarto.Location = New System.Drawing.Point(135, 144)
        Me.L_EstatusDoQuarto.Name = "L_EstatusDoQuarto"
        Me.L_EstatusDoQuarto.Size = New System.Drawing.Size(107, 19)
        Me.L_EstatusDoQuarto.TabIndex = 259
        Me.L_EstatusDoQuarto.Text = "SELECIONE"
        '
        'B_VerTodosDados
        '
        Me.B_VerTodosDados.BackColor = System.Drawing.Color.White
        Me.B_VerTodosDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_VerTodosDados.Location = New System.Drawing.Point(485, 375)
        Me.B_VerTodosDados.Name = "B_VerTodosDados"
        Me.B_VerTodosDados.Size = New System.Drawing.Size(102, 23)
        Me.B_VerTodosDados.TabIndex = 260
        Me.B_VerTodosDados.Text = "Abrir todo registro"
        Me.B_VerTodosDados.UseVisualStyleBackColor = False
        '
        'L_data
        '
        Me.L_data.AutoSize = True
        Me.L_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_data.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_data.Image = CType(resources.GetObject("L_data.Image"), System.Drawing.Image)
        Me.L_data.Location = New System.Drawing.Point(3, 2)
        Me.L_data.Name = "L_data"
        Me.L_data.Size = New System.Drawing.Size(69, 15)
        Me.L_data.TabIndex = 262
        Me.L_data.Text = "00/00/0000"
        '
        'L_hora
        '
        Me.L_hora.AutoSize = True
        Me.L_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_hora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_hora.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_hora.Image = CType(resources.GetObject("L_hora.Image"), System.Drawing.Image)
        Me.L_hora.Location = New System.Drawing.Point(623, 2)
        Me.L_hora.Name = "L_hora"
        Me.L_hora.Size = New System.Drawing.Size(55, 15)
        Me.L_hora.TabIndex = 261
        Me.L_hora.Text = "00:00:00"
        '
        'Quartos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(681, 410)
        Me.Controls.Add(Me.L_data)
        Me.Controls.Add(Me.L_hora)
        Me.Controls.Add(Me.B_VerTodosDados)
        Me.Controls.Add(Me.L_EstatusDoQuarto)
        Me.Controls.Add(Me.L_CheckOut)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.L_Ndias)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.L_dataCheckIn)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.T_Email)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.T_observação)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.M_NdeDocumento)
        Me.Controls.Add(Me.T_TipoDeDocumento)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.L_ValorTotal)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.L_restaurante)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.L_Diaria)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.N_quarto)
        Me.Controls.Add(Me.M_CelularN)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.T_Nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.B_Sair)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Quartos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Infinity Hotel"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_quarto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents B_Sair As System.Windows.Forms.Button
    Friend WithEvents M_CelularN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents T_Nome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents N_quarto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents L_ValorTotal As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents L_restaurante As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents L_Diaria As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents M_NdeDocumento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents T_TipoDeDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents T_observação As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents T_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents L_CheckOut As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents L_Ndias As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents L_dataCheckIn As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents L_EstatusDoQuarto As System.Windows.Forms.Label
    Friend WithEvents B_VerTodosDados As System.Windows.Forms.Button
    Friend WithEvents L_data As System.Windows.Forms.Label
    Friend WithEvents L_hora As System.Windows.Forms.Label
End Class
