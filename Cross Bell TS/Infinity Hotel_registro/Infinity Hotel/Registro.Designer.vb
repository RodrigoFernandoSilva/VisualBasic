<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.T_lerNOME = New System.Windows.Forms.TextBox()
        Me.T_lerEMAIL = New System.Windows.Forms.TextBox()
        Me.C_emailDominio = New System.Windows.Forms.ComboBox()
        Me.C_comEcombr = New System.Windows.Forms.ComboBox()
        Me.C_PreferenciaQuarto = New System.Windows.Forms.ComboBox()
        Me.M_DataDeNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.M_CelularN = New System.Windows.Forms.MaskedTextBox()
        Me.M_CelularDDD = New System.Windows.Forms.MaskedTextBox()
        Me.C_Nacionalidade = New System.Windows.Forms.ComboBox()
        Me.C_Genero = New System.Windows.Forms.ComboBox()
        Me.M_NdeDocumento = New System.Windows.Forms.MaskedTextBox()
        Me.M_OrgaoExpedidor = New System.Windows.Forms.MaskedTextBox()
        Me.T_ResidenciaPermanente = New System.Windows.Forms.TextBox()
        Me.C_ResidenciaPais = New System.Windows.Forms.ComboBox()
        Me.C_ResidenciaUF = New System.Windows.Forms.ComboBox()
        Me.C_UltimaProcedenciaPais = New System.Windows.Forms.ComboBox()
        Me.C_UltimaProcedenciaUF = New System.Windows.Forms.ComboBox()
        Me.C_ProximoDestinoPais = New System.Windows.Forms.ComboBox()
        Me.T_ResidenciaCidade = New System.Windows.Forms.TextBox()
        Me.C_MotivoDaViagem = New System.Windows.Forms.ComboBox()
        Me.C_MeioDeTransporte = New System.Windows.Forms.ComboBox()
        Me.T_ProximoDestinoCidade = New System.Windows.Forms.TextBox()
        Me.T_UltimaProcedenciaCidade = New System.Windows.Forms.TextBox()
        Me.T_Profissao = New System.Windows.Forms.TextBox()
        Me.T_observação = New System.Windows.Forms.TextBox()
        Me.T_ultimaProcedenciaUF = New System.Windows.Forms.TextBox()
        Me.T_próximoDestinoUF = New System.Windows.Forms.TextBox()
        Me.C_tipoDeDocumento = New System.Windows.Forms.ComboBox()
        Me.T_ResidenciaUF = New System.Windows.Forms.TextBox()
        Me.T_TelefoneDDI = New System.Windows.Forms.TextBox()
        Me.M_TelefoneN = New System.Windows.Forms.MaskedTextBox()
        Me.M_TelefoneDDD = New System.Windows.Forms.MaskedTextBox()
        Me.T_CelularDDI = New System.Windows.Forms.TextBox()
        Me.C_ProximoDestinoUF = New System.Windows.Forms.ComboBox()
        Me.B_Cancelar = New System.Windows.Forms.Button()
        Me.B_Registrar = New System.Windows.Forms.Button()
        Me.L_data = New System.Windows.Forms.Label()
        Me.L_hora = New System.Windows.Forms.Label()
        Me.P_Cancelar = New System.Windows.Forms.PictureBox()
        Me.P_registrar = New System.Windows.Forms.PictureBox()
        Me.L_DataCheckIn = New System.Windows.Forms.Label()
        Me.L_CheckOutERRO = New System.Windows.Forms.Label()
        Me.L_ObservaçãoERRO = New System.Windows.Forms.Label()
        Me.L_MeioDeTransporteERRO = New System.Windows.Forms.Label()
        Me.L_MotivoDaViagemERRO = New System.Windows.Forms.Label()
        Me.L_PróximoDestinoCidadeERRO = New System.Windows.Forms.Label()
        Me.L_PróximoDestinoPaisERRO = New System.Windows.Forms.Label()
        Me.L_ultimaProcCidadeErro = New System.Windows.Forms.Label()
        Me.L_ultimaProcPaisErro = New System.Windows.Forms.Label()
        Me.L_ResidenciaCidadeERRO = New System.Windows.Forms.Label()
        Me.L_ResidenciapaisERRO = New System.Windows.Forms.Label()
        Me.L_OrgãoExpdidorERRO = New System.Windows.Forms.Label()
        Me.L_NdDocumentoERRO = New System.Windows.Forms.Label()
        Me.L_tipoDocumentoERRO = New System.Windows.Forms.Label()
        Me.L_nacionalidadeERRO = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.L_profissãoERRO = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.L_preferencia_Q_INEXISTENTE = New System.Windows.Forms.Label()
        Me.L_DataDeNascimentoERRO = New System.Windows.Forms.Label()
        Me.L_ResidenciaPermanenteERRO = New System.Windows.Forms.Label()
        Me.L_celularERRO = New System.Windows.Forms.Label()
        Me.L_GeneroERRO = New System.Windows.Forms.Label()
        Me.L_emailLocalideERRO = New System.Windows.Forms.Label()
        Me.L_emaildominioERRO = New System.Windows.Forms.Label()
        Me.L_EmaiERRO = New System.Windows.Forms.Label()
        Me.L_nomeERRO = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.L_total = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.L_ultimaProcUfErro = New System.Windows.Forms.Label()
        Me.L_PróximoDestinoUfERRO = New System.Windows.Forms.Label()
        Me.L_ResidenciaUfERRO = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.L_tefefoneERRO = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_DataCheckOut = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.N_Ndias = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.P_Cancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_registrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Ndias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'T_lerNOME
        '
        Me.T_lerNOME.Location = New System.Drawing.Point(13, 135)
        Me.T_lerNOME.Name = "T_lerNOME"
        Me.T_lerNOME.Size = New System.Drawing.Size(355, 20)
        Me.T_lerNOME.TabIndex = 0
        '
        'T_lerEMAIL
        '
        Me.T_lerEMAIL.Location = New System.Drawing.Point(405, 135)
        Me.T_lerEMAIL.Name = "T_lerEMAIL"
        Me.T_lerEMAIL.Size = New System.Drawing.Size(230, 20)
        Me.T_lerEMAIL.TabIndex = 1
        '
        'C_emailDominio
        '
        Me.C_emailDominio.FormattingEnabled = True
        Me.C_emailDominio.Items.AddRange(New Object() {"hotmail", "outlook", "gmail", "yahoo"})
        Me.C_emailDominio.Location = New System.Drawing.Point(658, 135)
        Me.C_emailDominio.Name = "C_emailDominio"
        Me.C_emailDominio.Size = New System.Drawing.Size(108, 21)
        Me.C_emailDominio.TabIndex = 2
        '
        'C_comEcombr
        '
        Me.C_comEcombr.FormattingEnabled = True
        Me.C_comEcombr.Items.AddRange(New Object() {"com", "com.br"})
        Me.C_comEcombr.Location = New System.Drawing.Point(779, 135)
        Me.C_comEcombr.Name = "C_comEcombr"
        Me.C_comEcombr.Size = New System.Drawing.Size(74, 21)
        Me.C_comEcombr.TabIndex = 3
        '
        'C_PreferenciaQuarto
        '
        Me.C_PreferenciaQuarto.DropDownHeight = 160
        Me.C_PreferenciaQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_PreferenciaQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_PreferenciaQuarto.FormattingEnabled = True
        Me.C_PreferenciaQuarto.IntegralHeight = False
        Me.C_PreferenciaQuarto.Location = New System.Drawing.Point(719, 454)
        Me.C_PreferenciaQuarto.Name = "C_PreferenciaQuarto"
        Me.C_PreferenciaQuarto.Size = New System.Drawing.Size(121, 21)
        Me.C_PreferenciaQuarto.TabIndex = 36
        '
        'M_DataDeNascimento
        '
        Me.M_DataDeNascimento.Location = New System.Drawing.Point(514, 242)
        Me.M_DataDeNascimento.Mask = "00/00/0000"
        Me.M_DataDeNascimento.Name = "M_DataDeNascimento"
        Me.M_DataDeNascimento.Size = New System.Drawing.Size(74, 20)
        Me.M_DataDeNascimento.TabIndex = 12
        Me.M_DataDeNascimento.ValidatingType = GetType(Date)
        '
        'M_CelularN
        '
        Me.M_CelularN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_CelularN.Location = New System.Drawing.Point(529, 190)
        Me.M_CelularN.Name = "M_CelularN"
        Me.M_CelularN.Size = New System.Drawing.Size(106, 21)
        Me.M_CelularN.TabIndex = 9
        '
        'M_CelularDDD
        '
        Me.M_CelularDDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_CelularDDD.Location = New System.Drawing.Point(451, 190)
        Me.M_CelularDDD.Name = "M_CelularDDD"
        Me.M_CelularDDD.Size = New System.Drawing.Size(51, 21)
        Me.M_CelularDDD.TabIndex = 8
        '
        'C_Nacionalidade
        '
        Me.C_Nacionalidade.DropDownHeight = 205
        Me.C_Nacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_Nacionalidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_Nacionalidade.FormattingEnabled = True
        Me.C_Nacionalidade.IntegralHeight = False
        Me.C_Nacionalidade.Items.AddRange(New Object() {"albanês", "alemão", "argelino", "australiano", "afegão", "angolano", "austríaco", "sul-africano", "argentino", "brasileiro", "belga", "búlgaro", "croata", "cipriota", "chinês", "canadiano", "chileno", "colombiano", "cubano, cubana", "cabo-verdiano", "norte-coreano", "sul-coreano", "dinamarquês", "eslovaco", "norte-americano / americano", "esloveno", "espanhol", "francês", "finlandês", "grego", "guineense", "húngaro", "islandês", "irlandês", "indiano", "indoneso", "iraniano", "iraquiano", "israelita", "italiano", "japonês", "jordano", "kosovar", "lituano", "libanês", "líbio", "luxemburguês", "nigeriano", "neozelandês", "marroquino", "moçambicano", "montenegrino", "mexicano", "holandês", "norueguês", "polaco", "paquistanês", "português", "queniano", "inglês", "romenos", "russo", "ruandês", "suíço", "sueco", "sírio", "santomense", "senegalês", "somalí", "sudanês", "turc", "tailandês", "timorense", "tunisino", "ucraniano", "venezuelano", "vietnamita", "Outos"})
        Me.C_Nacionalidade.Location = New System.Drawing.Point(294, 242)
        Me.C_Nacionalidade.Name = "C_Nacionalidade"
        Me.C_Nacionalidade.Size = New System.Drawing.Size(184, 21)
        Me.C_Nacionalidade.TabIndex = 11
        '
        'C_Genero
        '
        Me.C_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_Genero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_Genero.FormattingEnabled = True
        Me.C_Genero.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.C_Genero.Location = New System.Drawing.Point(623, 242)
        Me.C_Genero.Name = "C_Genero"
        Me.C_Genero.Size = New System.Drawing.Size(184, 21)
        Me.C_Genero.TabIndex = 13
        '
        'M_NdeDocumento
        '
        Me.M_NdeDocumento.BackColor = System.Drawing.Color.LightGray
        Me.M_NdeDocumento.Enabled = False
        Me.M_NdeDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_NdeDocumento.Location = New System.Drawing.Point(185, 314)
        Me.M_NdeDocumento.Name = "M_NdeDocumento"
        Me.M_NdeDocumento.Size = New System.Drawing.Size(251, 21)
        Me.M_NdeDocumento.TabIndex = 16
        '
        'M_OrgaoExpedidor
        '
        Me.M_OrgaoExpedidor.BackColor = System.Drawing.Color.LightGray
        Me.M_OrgaoExpedidor.Enabled = False
        Me.M_OrgaoExpedidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_OrgaoExpedidor.Location = New System.Drawing.Point(469, 314)
        Me.M_OrgaoExpedidor.Name = "M_OrgaoExpedidor"
        Me.M_OrgaoExpedidor.Size = New System.Drawing.Size(189, 21)
        Me.M_OrgaoExpedidor.TabIndex = 17
        '
        'T_ResidenciaPermanente
        '
        Me.T_ResidenciaPermanente.Location = New System.Drawing.Point(12, 367)
        Me.T_ResidenciaPermanente.Name = "T_ResidenciaPermanente"
        Me.T_ResidenciaPermanente.Size = New System.Drawing.Size(252, 20)
        Me.T_ResidenciaPermanente.TabIndex = 18
        '
        'C_ResidenciaPais
        '
        Me.C_ResidenciaPais.DropDownHeight = 205
        Me.C_ResidenciaPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_ResidenciaPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_ResidenciaPais.FormattingEnabled = True
        Me.C_ResidenciaPais.IntegralHeight = False
        Me.C_ResidenciaPais.Items.AddRange(New Object() {"Afghanistão", "África do Sul ", "Albânia", "Alemanha", "Andora", "Angola", "Anguilla", "Antarctica", "Antígua e Barbuda", "Argentina", "Argélia", "Arménia", "Aruba", "Arábia Saudita", "Austrália", "Áustria" & Global.Microsoft.VisualBasic.ChrW(9), "Azerbaijão", "Brasil", "Bahamas", "Bahrein" & Global.Microsoft.VisualBasic.ChrW(9) & "BH", "Bangladesh", "Barbados", "Bélgica" & Global.Microsoft.VisualBasic.ChrW(9), "Belize", "Benim", "Bermuda ", "Butão", "Bielorrússia", "Bolívia" & Global.Microsoft.VisualBasic.ChrW(9), "Bósnia e Herzegovina", "Botswana", "British Indian Ocean Territory" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Brunei ", "Bulgária", "Burkina ", "Myanmar", "Burundi", "Camarões", "Cabo Verde", "Camboja", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Christmas Island", "Cingapura", "Colômbia", "Comores" & Global.Microsoft.VisualBasic.ChrW(9), "Coreia do Norte" & Global.Microsoft.VisualBasic.ChrW(9), "Coreia do Sul", "Costa do Marfim", "Costa Rica", "Croácia" & Global.Microsoft.VisualBasic.ChrW(9), "Cuba", "Dinamarca", "Djibouti", "Dominica", "Egito" & Global.Microsoft.VisualBasic.ChrW(9), "El Salvador", "Emirados Árabes Unidos", "Equador" & Global.Microsoft.VisualBasic.ChrW(9), "Eritreia", "Estónia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Espanha" & Global.Microsoft.VisualBasic.ChrW(9), "Etiópia", "Fiji" & Global.Microsoft.VisualBasic.ChrW(9), "Finlândia", "França", "Gabão", "Gâmbia", "Banda de Gaza (Palestina)", "Geórgia" & Global.Microsoft.VisualBasic.ChrW(9), "Gana" & Global.Microsoft.VisualBasic.ChrW(9), "Gibraltar", "Grécia", "Groelândia", "Granada" & Global.Microsoft.VisualBasic.ChrW(9), "Guam", "Guatemala", "Guiana" & Global.Microsoft.VisualBasic.ChrW(9), "Guiné" & Global.Microsoft.VisualBasic.ChrW(9), "Guiné Equatorial", "Guiné-Bissau" & Global.Microsoft.VisualBasic.ChrW(9), "Haiti" & Global.Microsoft.VisualBasic.ChrW(9), "Honduras", "Hong Kong", "Hungria" & Global.Microsoft.VisualBasic.ChrW(9), "Islândia", "Ilhas Cayman", "Ilhas Cocos (Keeling)", "Ilha de Man", "Ilhas Cook", "Ilhas Falkland (Malvinas)", "Ilhas Feroé", "Ilhas Mariana do Norte", "Ilhas Marshall", "Ilhas Norfolk", "Ilhas Pitcairn" & Global.Microsoft.VisualBasic.ChrW(9), "Ilhas Salomão" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Ilhas Turcas e Caicos", "Ilhas Virgens Americanas", "Ilhas Virgens Britânicas", "India", "Indonésia", "Inglaterra (Reino Unido)", "Irã", "Iraque" & Global.Microsoft.VisualBasic.ChrW(9), "Irlanda" & Global.Microsoft.VisualBasic.ChrW(9), "Israel", "Itália", "Jamaica", "Japão", "Jersey" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Jordânia", "Cazaquistão", "Quénia (Kenya)", "Kiribati", "Kosovo", "Kuwait", "Quirguistão", "Laos" & Global.Microsoft.VisualBasic.ChrW(9), "Letônia ", "Líbano" & Global.Microsoft.VisualBasic.ChrW(9), "Lesoto", "Libéria", "Líbia", "Liechtenstein", "Lituânia", "Luxemburgo", "Macau", "Macedónia", "Madagáscar", "Malawi", "Malásia", "Maldivas", "Mali", "Malta", "Mauritânia", "Maurícia", "Mayotte" & Global.Microsoft.VisualBasic.ChrW(9), "México", "Micronésia", "Moldávia", "Monaco", "Mongólia", "Montenegro", "Montserrat", "Marrocos", "Moçambique", "Namíbia", "Nauru", "Nepal", "Netherlands Antilles", "Nova Caledônia", "Nova Zelândia", "Nicaragua", "Níger", "Nigéria", "Niue", "Noruega", "Omã", "Países Baixos", "Paquistão", "Palau", "Panamá ", "Papua-Nova Guiné", "Paraguai", "Peru", "Filipinas", "Polónia" & Global.Microsoft.VisualBasic.ChrW(9), "Polinésia Francesa", "Portugal", "Porto Rico" & Global.Microsoft.VisualBasic.ChrW(9) & "1 ", "República do Congo", "República Democrática do Congo", "República Centro-Africana", "República Checa" & Global.Microsoft.VisualBasic.ChrW(9), "República Dominicana ", "Roménia", "Ruanda", "Rússia", "Saint Barthelemy", "Samoa", "Samoa Americana", "San Marino", "Sao Tome e Principe", "Senegal", "Serbia", "Serra Leoa", "Seychelles", "Slovakia", "Slovenia", "Somalia", "Sri Lanka", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Martin", "Saint Pierre and Miquelon ", "Saint Vincent and the Grenadines ", "Sudão" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Suriname ", "Svalbard " & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Suazilândia ", "Suécia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Suiça" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Syria" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Taiwan" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Tajiquistão ", "Tanzânia ", "Timor-Leste ", "Tailândia ", "Togo ", "Tokelau" & Global.Microsoft.VisualBasic.ChrW(9), "Tonga" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Trinidad e Tobago ", "Tunísia" & Global.Microsoft.VisualBasic.ChrW(9), "Turquemenistão ", "Turquia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Tuvalu" & Global.Microsoft.VisualBasic.ChrW(9) & "  ", "Uganda" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Ucrânia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Uruguai" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Estados Unidos ", "Uzbequistão ", "Vanuatu" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Vaticano", "Venezuela", "Vietnã (Vietname)", "Wallis e Futuna", "West Bank", "Western Sahara" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Iémen (Iémen, Yemen)", "Zimbabwe(Zimbabué)", "Zâmbia", "Outros"})
        Me.C_ResidenciaPais.Location = New System.Drawing.Point(287, 367)
        Me.C_ResidenciaPais.Name = "C_ResidenciaPais"
        Me.C_ResidenciaPais.Size = New System.Drawing.Size(204, 21)
        Me.C_ResidenciaPais.TabIndex = 19
        '
        'C_ResidenciaUF
        '
        Me.C_ResidenciaUF.BackColor = System.Drawing.Color.LightGray
        Me.C_ResidenciaUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_ResidenciaUF.Enabled = False
        Me.C_ResidenciaUF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_ResidenciaUF.FormattingEnabled = True
        Me.C_ResidenciaUF.Items.AddRange(New Object() {"Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro ", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina ", "São Paulo", "Sergipe", "Tocantins", "Outros"})
        Me.C_ResidenciaUF.Location = New System.Drawing.Point(515, 367)
        Me.C_ResidenciaUF.Name = "C_ResidenciaUF"
        Me.C_ResidenciaUF.Size = New System.Drawing.Size(140, 21)
        Me.C_ResidenciaUF.TabIndex = 20
        '
        'C_UltimaProcedenciaPais
        '
        Me.C_UltimaProcedenciaPais.DropDownHeight = 205
        Me.C_UltimaProcedenciaPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_UltimaProcedenciaPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_UltimaProcedenciaPais.FormattingEnabled = True
        Me.C_UltimaProcedenciaPais.IntegralHeight = False
        Me.C_UltimaProcedenciaPais.Items.AddRange(New Object() {"Afghanistão", "África do Sul ", "Albânia", "Alemanha", "Andora", "Angola", "Anguilla", "Antarctica", "Antígua e Barbuda", "Argentina", "Argélia", "Arménia", "Aruba", "Arábia Saudita", "Austrália", "Áustria" & Global.Microsoft.VisualBasic.ChrW(9), "Azerbaijão", "Brasil", "Bahamas", "Bahrein" & Global.Microsoft.VisualBasic.ChrW(9) & "BH", "Bangladesh", "Barbados", "Bélgica" & Global.Microsoft.VisualBasic.ChrW(9), "Belize", "Benim", "Bermuda ", "Butão", "Bielorrússia", "Bolívia" & Global.Microsoft.VisualBasic.ChrW(9), "Bósnia e Herzegovina", "Botswana", "British Indian Ocean Territory" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Brunei ", "Bulgária", "Burkina ", "Myanmar", "Burundi", "Camarões", "Cabo Verde", "Camboja", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Christmas Island", "Cingapura", "Colômbia", "Comores" & Global.Microsoft.VisualBasic.ChrW(9), "Coreia do Norte" & Global.Microsoft.VisualBasic.ChrW(9), "Coreia do Sul", "Costa do Marfim", "Costa Rica", "Croácia" & Global.Microsoft.VisualBasic.ChrW(9), "Cuba", "Dinamarca", "Djibouti", "Dominica", "Egito" & Global.Microsoft.VisualBasic.ChrW(9), "El Salvador", "Emirados Árabes Unidos", "Equador" & Global.Microsoft.VisualBasic.ChrW(9), "Eritreia", "Estónia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Espanha" & Global.Microsoft.VisualBasic.ChrW(9), "Etiópia", "Fiji" & Global.Microsoft.VisualBasic.ChrW(9), "Finlândia", "França", "Gabão", "Gâmbia", "Banda de Gaza (Palestina)", "Geórgia" & Global.Microsoft.VisualBasic.ChrW(9), "Gana" & Global.Microsoft.VisualBasic.ChrW(9), "Gibraltar", "Grécia", "Groelândia", "Granada" & Global.Microsoft.VisualBasic.ChrW(9), "Guam", "Guatemala", "Guiana" & Global.Microsoft.VisualBasic.ChrW(9), "Guiné" & Global.Microsoft.VisualBasic.ChrW(9), "Guiné Equatorial", "Guiné-Bissau" & Global.Microsoft.VisualBasic.ChrW(9), "Haiti" & Global.Microsoft.VisualBasic.ChrW(9), "Honduras", "Hong Kong", "Hungria" & Global.Microsoft.VisualBasic.ChrW(9), "Islândia", "Ilhas Cayman", "Ilhas Cocos (Keeling)", "Ilha de Man", "Ilhas Cook", "Ilhas Falkland (Malvinas)", "Ilhas Feroé", "Ilhas Mariana do Norte", "Ilhas Marshall", "Ilhas Norfolk", "Ilhas Pitcairn" & Global.Microsoft.VisualBasic.ChrW(9), "Ilhas Salomão" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Ilhas Turcas e Caicos", "Ilhas Virgens Americanas", "Ilhas Virgens Britânicas", "India", "Indonésia", "Inglaterra (Reino Unido)", "Irã", "Iraque" & Global.Microsoft.VisualBasic.ChrW(9), "Irlanda" & Global.Microsoft.VisualBasic.ChrW(9), "Israel", "Itália", "Jamaica", "Japão", "Jersey" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Jordânia", "Cazaquistão", "Quénia (Kenya)", "Kiribati", "Kosovo", "Kuwait", "Quirguistão", "Laos" & Global.Microsoft.VisualBasic.ChrW(9), "Letônia ", "Líbano" & Global.Microsoft.VisualBasic.ChrW(9), "Lesoto", "Libéria", "Líbia", "Liechtenstein", "Lituânia", "Luxemburgo", "Macau", "Macedónia", "Madagáscar", "Malawi", "Malásia", "Maldivas", "Mali", "Malta", "Mauritânia", "Maurícia", "Mayotte" & Global.Microsoft.VisualBasic.ChrW(9), "México", "Micronésia", "Moldávia", "Monaco", "Mongólia", "Montenegro", "Montserrat", "Marrocos", "Moçambique", "Namíbia", "Nauru", "Nepal", "Netherlands Antilles", "Nova Caledônia", "Nova Zelândia", "Nicaragua", "Níger", "Nigéria", "Niue", "Noruega", "Omã", "Países Baixos", "Paquistão", "Palau", "Panamá ", "Papua-Nova Guiné", "Paraguai", "Peru", "Filipinas", "Polónia" & Global.Microsoft.VisualBasic.ChrW(9), "Polinésia Francesa", "Portugal", "Porto Rico" & Global.Microsoft.VisualBasic.ChrW(9) & "1 ", "República do Congo", "República Democrática do Congo", "República Centro-Africana", "República Checa" & Global.Microsoft.VisualBasic.ChrW(9), "República Dominicana ", "Roménia", "Ruanda", "Rússia", "Saint Barthelemy", "Samoa", "Samoa Americana", "San Marino", "Sao Tome e Principe", "Senegal", "Serbia", "Serra Leoa", "Seychelles", "Slovakia", "Slovenia", "Somalia", "Sri Lanka", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Martin", "Saint Pierre and Miquelon ", "Saint Vincent and the Grenadines ", "Sudão" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Suriname ", "Svalbard " & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Suazilândia ", "Suécia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Suiça" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Syria" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Taiwan" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Tajiquistão ", "Tanzânia ", "Timor-Leste ", "Tailândia ", "Togo ", "Tokelau" & Global.Microsoft.VisualBasic.ChrW(9), "Tonga" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Trinidad e Tobago ", "Tunísia" & Global.Microsoft.VisualBasic.ChrW(9), "Turquemenistão ", "Turquia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Tuvalu" & Global.Microsoft.VisualBasic.ChrW(9) & "  ", "Uganda" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Ucrânia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Uruguai" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Estados Unidos ", "Uzbequistão ", "Vanuatu" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Vaticano", "Venezuela", "Vietnã (Vietname)", "Wallis e Futuna", "West Bank", "Western Sahara" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Iémen (Iémen, Yemen)", "Zimbabwe(Zimbabué)", "Zâmbia", "Outros"})
        Me.C_UltimaProcedenciaPais.Location = New System.Drawing.Point(43, 425)
        Me.C_UltimaProcedenciaPais.Name = "C_UltimaProcedenciaPais"
        Me.C_UltimaProcedenciaPais.Size = New System.Drawing.Size(204, 21)
        Me.C_UltimaProcedenciaPais.TabIndex = 22
        '
        'C_UltimaProcedenciaUF
        '
        Me.C_UltimaProcedenciaUF.BackColor = System.Drawing.Color.LightGray
        Me.C_UltimaProcedenciaUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_UltimaProcedenciaUF.Enabled = False
        Me.C_UltimaProcedenciaUF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_UltimaProcedenciaUF.FormattingEnabled = True
        Me.C_UltimaProcedenciaUF.Items.AddRange(New Object() {"Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro ", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina ", "São Paulo", "Sergipe", "Tocantins", "Outros"})
        Me.C_UltimaProcedenciaUF.Location = New System.Drawing.Point(273, 425)
        Me.C_UltimaProcedenciaUF.Name = "C_UltimaProcedenciaUF"
        Me.C_UltimaProcedenciaUF.Size = New System.Drawing.Size(200, 21)
        Me.C_UltimaProcedenciaUF.TabIndex = 23
        '
        'C_ProximoDestinoPais
        '
        Me.C_ProximoDestinoPais.DropDownHeight = 205
        Me.C_ProximoDestinoPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_ProximoDestinoPais.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_ProximoDestinoPais.FormattingEnabled = True
        Me.C_ProximoDestinoPais.IntegralHeight = False
        Me.C_ProximoDestinoPais.Items.AddRange(New Object() {"Afghanistão", "África do Sul ", "Albânia", "Alemanha", "Andora", "Angola", "Anguilla", "Antarctica", "Antígua e Barbuda", "Argentina", "Argélia", "Arménia", "Aruba", "Arábia Saudita", "Austrália", "Áustria" & Global.Microsoft.VisualBasic.ChrW(9), "Azerbaijão", "Brasil", "Bahamas", "Bahrein" & Global.Microsoft.VisualBasic.ChrW(9) & "BH", "Bangladesh", "Barbados", "Bélgica" & Global.Microsoft.VisualBasic.ChrW(9), "Belize", "Benim", "Bermuda ", "Butão", "Bielorrússia", "Bolívia" & Global.Microsoft.VisualBasic.ChrW(9), "Bósnia e Herzegovina", "Botswana", "British Indian Ocean Territory" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Brunei ", "Bulgária", "Burkina ", "Myanmar", "Burundi", "Camarões", "Cabo Verde", "Camboja", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Christmas Island", "Cingapura", "Colômbia", "Comores" & Global.Microsoft.VisualBasic.ChrW(9), "Coreia do Norte" & Global.Microsoft.VisualBasic.ChrW(9), "Coreia do Sul", "Costa do Marfim", "Costa Rica", "Croácia" & Global.Microsoft.VisualBasic.ChrW(9), "Cuba", "Dinamarca", "Djibouti", "Dominica", "Egito" & Global.Microsoft.VisualBasic.ChrW(9), "El Salvador", "Emirados Árabes Unidos", "Equador" & Global.Microsoft.VisualBasic.ChrW(9), "Eritreia", "Estónia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Espanha" & Global.Microsoft.VisualBasic.ChrW(9), "Etiópia", "Fiji" & Global.Microsoft.VisualBasic.ChrW(9), "Finlândia", "França", "Gabão", "Gâmbia", "Banda de Gaza (Palestina)", "Geórgia" & Global.Microsoft.VisualBasic.ChrW(9), "Gana" & Global.Microsoft.VisualBasic.ChrW(9), "Gibraltar", "Grécia", "Groelândia", "Granada" & Global.Microsoft.VisualBasic.ChrW(9), "Guam", "Guatemala", "Guiana" & Global.Microsoft.VisualBasic.ChrW(9), "Guiné" & Global.Microsoft.VisualBasic.ChrW(9), "Guiné Equatorial", "Guiné-Bissau" & Global.Microsoft.VisualBasic.ChrW(9), "Haiti" & Global.Microsoft.VisualBasic.ChrW(9), "Honduras", "Hong Kong", "Hungria" & Global.Microsoft.VisualBasic.ChrW(9), "Islândia", "Ilhas Cayman", "Ilhas Cocos (Keeling)", "Ilha de Man", "Ilhas Cook", "Ilhas Falkland (Malvinas)", "Ilhas Feroé", "Ilhas Mariana do Norte", "Ilhas Marshall", "Ilhas Norfolk", "Ilhas Pitcairn" & Global.Microsoft.VisualBasic.ChrW(9), "Ilhas Salomão" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Ilhas Turcas e Caicos", "Ilhas Virgens Americanas", "Ilhas Virgens Britânicas", "India", "Indonésia", "Inglaterra (Reino Unido)", "Irã", "Iraque" & Global.Microsoft.VisualBasic.ChrW(9), "Irlanda" & Global.Microsoft.VisualBasic.ChrW(9), "Israel", "Itália", "Jamaica", "Japão", "Jersey" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Jordânia", "Cazaquistão", "Quénia (Kenya)", "Kiribati", "Kosovo", "Kuwait", "Quirguistão", "Laos" & Global.Microsoft.VisualBasic.ChrW(9), "Letônia ", "Líbano" & Global.Microsoft.VisualBasic.ChrW(9), "Lesoto", "Libéria", "Líbia", "Liechtenstein", "Lituânia", "Luxemburgo", "Macau", "Macedónia", "Madagáscar", "Malawi", "Malásia", "Maldivas", "Mali", "Malta", "Mauritânia", "Maurícia", "Mayotte" & Global.Microsoft.VisualBasic.ChrW(9), "México", "Micronésia", "Moldávia", "Monaco", "Mongólia", "Montenegro", "Montserrat", "Marrocos", "Moçambique", "Namíbia", "Nauru", "Nepal", "Netherlands Antilles", "Nova Caledônia", "Nova Zelândia", "Nicaragua", "Níger", "Nigéria", "Niue", "Noruega", "Omã", "Países Baixos", "Paquistão", "Palau", "Panamá ", "Papua-Nova Guiné", "Paraguai", "Peru", "Filipinas", "Polónia" & Global.Microsoft.VisualBasic.ChrW(9), "Polinésia Francesa", "Portugal", "Porto Rico" & Global.Microsoft.VisualBasic.ChrW(9) & "1 ", "República do Congo", "República Democrática do Congo", "República Centro-Africana", "República Checa" & Global.Microsoft.VisualBasic.ChrW(9), "República Dominicana ", "Roménia", "Ruanda", "Rússia", "Saint Barthelemy", "Samoa", "Samoa Americana", "San Marino", "Sao Tome e Principe", "Senegal", "Serbia", "Serra Leoa", "Seychelles", "Slovakia", "Slovenia", "Somalia", "Sri Lanka", "Saint Helena", "Saint Kitts and Nevis", "Saint Lucia", "Saint Martin", "Saint Pierre and Miquelon ", "Saint Vincent and the Grenadines ", "Sudão" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Suriname ", "Svalbard " & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Suazilândia ", "Suécia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Suiça" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Syria" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Taiwan" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Tajiquistão ", "Tanzânia ", "Timor-Leste ", "Tailândia ", "Togo ", "Tokelau" & Global.Microsoft.VisualBasic.ChrW(9), "Tonga" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Trinidad e Tobago ", "Tunísia" & Global.Microsoft.VisualBasic.ChrW(9), "Turquemenistão ", "Turquia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Tuvalu" & Global.Microsoft.VisualBasic.ChrW(9) & "  ", "Uganda" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Ucrânia" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Uruguai" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Estados Unidos ", "Uzbequistão ", "Vanuatu" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Vaticano", "Venezuela", "Vietnã (Vietname)", "Wallis e Futuna", "West Bank", "Western Sahara" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "Iémen (Iémen, Yemen)", "Zimbabwe(Zimbabué)", "Zâmbia", "Outros"})
        Me.C_ProximoDestinoPais.Location = New System.Drawing.Point(44, 478)
        Me.C_ProximoDestinoPais.Name = "C_ProximoDestinoPais"
        Me.C_ProximoDestinoPais.Size = New System.Drawing.Size(204, 21)
        Me.C_ProximoDestinoPais.TabIndex = 25
        '
        'T_ResidenciaCidade
        '
        Me.T_ResidenciaCidade.BackColor = System.Drawing.Color.LightGray
        Me.T_ResidenciaCidade.Enabled = False
        Me.T_ResidenciaCidade.Location = New System.Drawing.Point(679, 367)
        Me.T_ResidenciaCidade.Name = "T_ResidenciaCidade"
        Me.T_ResidenciaCidade.Size = New System.Drawing.Size(175, 20)
        Me.T_ResidenciaCidade.TabIndex = 21
        '
        'C_MotivoDaViagem
        '
        Me.C_MotivoDaViagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_MotivoDaViagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_MotivoDaViagem.FormattingEnabled = True
        Me.C_MotivoDaViagem.Items.AddRange(New Object() {"Lazer - Férias", "Negócios", "Congresso - Ferias", "Parentes - Amigos", "Estudos", "Religião", "Saúde", "Compras", "Outros"})
        Me.C_MotivoDaViagem.Location = New System.Drawing.Point(10, 529)
        Me.C_MotivoDaViagem.Name = "C_MotivoDaViagem"
        Me.C_MotivoDaViagem.Size = New System.Drawing.Size(188, 21)
        Me.C_MotivoDaViagem.TabIndex = 28
        '
        'C_MeioDeTransporte
        '
        Me.C_MeioDeTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_MeioDeTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_MeioDeTransporte.FormattingEnabled = True
        Me.C_MeioDeTransporte.Items.AddRange(New Object() {"Avião", "Automóvel", "Ônibus", "Moto", "Navio", "Trem", "Outros"})
        Me.C_MeioDeTransporte.Location = New System.Drawing.Point(239, 529)
        Me.C_MeioDeTransporte.Name = "C_MeioDeTransporte"
        Me.C_MeioDeTransporte.Size = New System.Drawing.Size(188, 21)
        Me.C_MeioDeTransporte.TabIndex = 29
        '
        'T_ProximoDestinoCidade
        '
        Me.T_ProximoDestinoCidade.BackColor = System.Drawing.Color.LightGray
        Me.T_ProximoDestinoCidade.Enabled = False
        Me.T_ProximoDestinoCidade.Location = New System.Drawing.Point(522, 478)
        Me.T_ProximoDestinoCidade.Name = "T_ProximoDestinoCidade"
        Me.T_ProximoDestinoCidade.Size = New System.Drawing.Size(162, 20)
        Me.T_ProximoDestinoCidade.TabIndex = 27
        '
        'T_UltimaProcedenciaCidade
        '
        Me.T_UltimaProcedenciaCidade.BackColor = System.Drawing.Color.LightGray
        Me.T_UltimaProcedenciaCidade.Enabled = False
        Me.T_UltimaProcedenciaCidade.Location = New System.Drawing.Point(521, 425)
        Me.T_UltimaProcedenciaCidade.Name = "T_UltimaProcedenciaCidade"
        Me.T_UltimaProcedenciaCidade.Size = New System.Drawing.Size(161, 20)
        Me.T_UltimaProcedenciaCidade.TabIndex = 24
        '
        'T_Profissao
        '
        Me.T_Profissao.Location = New System.Drawing.Point(10, 243)
        Me.T_Profissao.Name = "T_Profissao"
        Me.T_Profissao.Size = New System.Drawing.Size(254, 20)
        Me.T_Profissao.TabIndex = 10
        '
        'T_observação
        '
        Me.T_observação.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_observação.Location = New System.Drawing.Point(10, 578)
        Me.T_observação.Multiline = True
        Me.T_observação.Name = "T_observação"
        Me.T_observação.Size = New System.Drawing.Size(492, 82)
        Me.T_observação.TabIndex = 30
        '
        'T_ultimaProcedenciaUF
        '
        Me.T_ultimaProcedenciaUF.Enabled = False
        Me.T_ultimaProcedenciaUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_ultimaProcedenciaUF.Location = New System.Drawing.Point(273, 425)
        Me.T_ultimaProcedenciaUF.Name = "T_ultimaProcedenciaUF"
        Me.T_ultimaProcedenciaUF.Size = New System.Drawing.Size(199, 21)
        Me.T_ultimaProcedenciaUF.TabIndex = 23
        Me.T_ultimaProcedenciaUF.Visible = False
        '
        'T_próximoDestinoUF
        '
        Me.T_próximoDestinoUF.Enabled = False
        Me.T_próximoDestinoUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_próximoDestinoUF.Location = New System.Drawing.Point(273, 477)
        Me.T_próximoDestinoUF.Name = "T_próximoDestinoUF"
        Me.T_próximoDestinoUF.Size = New System.Drawing.Size(199, 21)
        Me.T_próximoDestinoUF.TabIndex = 26
        Me.T_próximoDestinoUF.Visible = False
        '
        'C_tipoDeDocumento
        '
        Me.C_tipoDeDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_tipoDeDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_tipoDeDocumento.FormattingEnabled = True
        Me.C_tipoDeDocumento.Items.AddRange(New Object() {"CPF", "PASSAPORTE"})
        Me.C_tipoDeDocumento.Location = New System.Drawing.Point(11, 314)
        Me.C_tipoDeDocumento.Name = "C_tipoDeDocumento"
        Me.C_tipoDeDocumento.Size = New System.Drawing.Size(145, 21)
        Me.C_tipoDeDocumento.TabIndex = 15
        '
        'T_ResidenciaUF
        '
        Me.T_ResidenciaUF.BackColor = System.Drawing.SystemColors.Window
        Me.T_ResidenciaUF.Enabled = False
        Me.T_ResidenciaUF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_ResidenciaUF.Location = New System.Drawing.Point(515, 367)
        Me.T_ResidenciaUF.Name = "T_ResidenciaUF"
        Me.T_ResidenciaUF.Size = New System.Drawing.Size(140, 21)
        Me.T_ResidenciaUF.TabIndex = 20
        Me.T_ResidenciaUF.Visible = False
        '
        'T_TelefoneDDI
        '
        Me.T_TelefoneDDI.Location = New System.Drawing.Point(45, 190)
        Me.T_TelefoneDDI.MaxLength = 4
        Me.T_TelefoneDDI.Name = "T_TelefoneDDI"
        Me.T_TelefoneDDI.Size = New System.Drawing.Size(36, 20)
        Me.T_TelefoneDDI.TabIndex = 4
        '
        'M_TelefoneN
        '
        Me.M_TelefoneN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_TelefoneN.Location = New System.Drawing.Point(200, 190)
        Me.M_TelefoneN.Name = "M_TelefoneN"
        Me.M_TelefoneN.Size = New System.Drawing.Size(106, 21)
        Me.M_TelefoneN.TabIndex = 6
        '
        'M_TelefoneDDD
        '
        Me.M_TelefoneDDD.Location = New System.Drawing.Point(122, 191)
        Me.M_TelefoneDDD.Name = "M_TelefoneDDD"
        Me.M_TelefoneDDD.Size = New System.Drawing.Size(52, 20)
        Me.M_TelefoneDDD.TabIndex = 5
        '
        'T_CelularDDI
        '
        Me.T_CelularDDI.Location = New System.Drawing.Point(368, 190)
        Me.T_CelularDDI.MaxLength = 4
        Me.T_CelularDDI.Name = "T_CelularDDI"
        Me.T_CelularDDI.Size = New System.Drawing.Size(37, 20)
        Me.T_CelularDDI.TabIndex = 7
        '
        'C_ProximoDestinoUF
        '
        Me.C_ProximoDestinoUF.BackColor = System.Drawing.Color.LightGray
        Me.C_ProximoDestinoUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_ProximoDestinoUF.Enabled = False
        Me.C_ProximoDestinoUF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_ProximoDestinoUF.FormattingEnabled = True
        Me.C_ProximoDestinoUF.Items.AddRange(New Object() {"Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espirito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro ", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina ", "São Paulo", "Sergipe", "Tocantins", "Outros"})
        Me.C_ProximoDestinoUF.Location = New System.Drawing.Point(273, 478)
        Me.C_ProximoDestinoUF.Name = "C_ProximoDestinoUF"
        Me.C_ProximoDestinoUF.Size = New System.Drawing.Size(200, 21)
        Me.C_ProximoDestinoUF.TabIndex = 26
        '
        'B_Cancelar
        '
        Me.B_Cancelar.BackColor = System.Drawing.Color.White
        Me.B_Cancelar.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Cancelar.Location = New System.Drawing.Point(752, 637)
        Me.B_Cancelar.Name = "B_Cancelar"
        Me.B_Cancelar.Size = New System.Drawing.Size(96, 23)
        Me.B_Cancelar.TabIndex = 38
        Me.B_Cancelar.Text = "Cancelar"
        Me.B_Cancelar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.B_Cancelar.UseVisualStyleBackColor = False
        '
        'B_Registrar
        '
        Me.B_Registrar.BackColor = System.Drawing.Color.White
        Me.B_Registrar.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Registrar.Location = New System.Drawing.Point(752, 594)
        Me.B_Registrar.Name = "B_Registrar"
        Me.B_Registrar.Size = New System.Drawing.Size(96, 23)
        Me.B_Registrar.TabIndex = 37
        Me.B_Registrar.Text = "Registrar"
        Me.B_Registrar.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.B_Registrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.B_Registrar.UseVisualStyleBackColor = False
        '
        'L_data
        '
        Me.L_data.AutoSize = True
        Me.L_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_data.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_data.Image = CType(resources.GetObject("L_data.Image"), System.Drawing.Image)
        Me.L_data.Location = New System.Drawing.Point(5, 7)
        Me.L_data.Name = "L_data"
        Me.L_data.Size = New System.Drawing.Size(69, 15)
        Me.L_data.TabIndex = 228
        Me.L_data.Text = "00/00/0000"
        '
        'L_hora
        '
        Me.L_hora.AutoSize = True
        Me.L_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_hora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_hora.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_hora.Image = CType(resources.GetObject("L_hora.Image"), System.Drawing.Image)
        Me.L_hora.Location = New System.Drawing.Point(813, 7)
        Me.L_hora.Name = "L_hora"
        Me.L_hora.Size = New System.Drawing.Size(55, 15)
        Me.L_hora.TabIndex = 227
        Me.L_hora.Text = "00:00:00"
        '
        'P_Cancelar
        '
        Me.P_Cancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.P_Cancelar.Enabled = False
        Me.P_Cancelar.Image = Global.Infinity_Hotel.My.Resources.Resources.Cancelar
        Me.P_Cancelar.Location = New System.Drawing.Point(761, 639)
        Me.P_Cancelar.Name = "P_Cancelar"
        Me.P_Cancelar.Size = New System.Drawing.Size(20, 18)
        Me.P_Cancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P_Cancelar.TabIndex = 33
        Me.P_Cancelar.TabStop = False
        '
        'P_registrar
        '
        Me.P_registrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.P_registrar.Enabled = False
        Me.P_registrar.Image = Global.Infinity_Hotel.My.Resources.Resources.Registrar
        Me.P_registrar.Location = New System.Drawing.Point(761, 596)
        Me.P_registrar.Name = "P_registrar"
        Me.P_registrar.Size = New System.Drawing.Size(20, 18)
        Me.P_registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P_registrar.TabIndex = 32
        Me.P_registrar.TabStop = False
        '
        'L_DataCheckIn
        '
        Me.L_DataCheckIn.AutoSize = True
        Me.L_DataCheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_DataCheckIn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DataCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_DataCheckIn.Image = CType(resources.GetObject("L_DataCheckIn.Image"), System.Drawing.Image)
        Me.L_DataCheckIn.Location = New System.Drawing.Point(524, 585)
        Me.L_DataCheckIn.Name = "L_DataCheckIn"
        Me.L_DataCheckIn.Size = New System.Drawing.Size(62, 15)
        Me.L_DataCheckIn.TabIndex = 179
        Me.L_DataCheckIn.Text = "00/00/000"
        '
        'L_CheckOutERRO
        '
        Me.L_CheckOutERRO.AutoSize = True
        Me.L_CheckOutERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_CheckOutERRO.ForeColor = System.Drawing.Color.Red
        Me.L_CheckOutERRO.Image = CType(resources.GetObject("L_CheckOutERRO.Image"), System.Drawing.Image)
        Me.L_CheckOutERRO.Location = New System.Drawing.Point(561, 659)
        Me.L_CheckOutERRO.Name = "L_CheckOutERRO"
        Me.L_CheckOutERRO.Size = New System.Drawing.Size(66, 13)
        Me.L_CheckOutERRO.TabIndex = 175
        Me.L_CheckOutERRO.Text = "Dia de saida"
        '
        'L_ObservaçãoERRO
        '
        Me.L_ObservaçãoERRO.AutoSize = True
        Me.L_ObservaçãoERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ObservaçãoERRO.ForeColor = System.Drawing.Color.Red
        Me.L_ObservaçãoERRO.Image = CType(resources.GetObject("L_ObservaçãoERRO.Image"), System.Drawing.Image)
        Me.L_ObservaçãoERRO.Location = New System.Drawing.Point(11, 662)
        Me.L_ObservaçãoERRO.Name = "L_ObservaçãoERRO"
        Me.L_ObservaçãoERRO.Size = New System.Drawing.Size(65, 13)
        Me.L_ObservaçãoERRO.TabIndex = 173
        Me.L_ObservaçãoERRO.Text = "Observação"
        '
        'L_MeioDeTransporteERRO
        '
        Me.L_MeioDeTransporteERRO.AutoSize = True
        Me.L_MeioDeTransporteERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_MeioDeTransporteERRO.ForeColor = System.Drawing.Color.Red
        Me.L_MeioDeTransporteERRO.Image = CType(resources.GetObject("L_MeioDeTransporteERRO.Image"), System.Drawing.Image)
        Me.L_MeioDeTransporteERRO.Location = New System.Drawing.Point(243, 550)
        Me.L_MeioDeTransporteERRO.Name = "L_MeioDeTransporteERRO"
        Me.L_MeioDeTransporteERRO.Size = New System.Drawing.Size(58, 13)
        Me.L_MeioDeTransporteERRO.TabIndex = 172
        Me.L_MeioDeTransporteERRO.Text = "Transporte"
        '
        'L_MotivoDaViagemERRO
        '
        Me.L_MotivoDaViagemERRO.AutoSize = True
        Me.L_MotivoDaViagemERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_MotivoDaViagemERRO.ForeColor = System.Drawing.Color.Red
        Me.L_MotivoDaViagemERRO.Image = CType(resources.GetObject("L_MotivoDaViagemERRO.Image"), System.Drawing.Image)
        Me.L_MotivoDaViagemERRO.Location = New System.Drawing.Point(12, 550)
        Me.L_MotivoDaViagemERRO.Name = "L_MotivoDaViagemERRO"
        Me.L_MotivoDaViagemERRO.Size = New System.Drawing.Size(91, 13)
        Me.L_MotivoDaViagemERRO.TabIndex = 171
        Me.L_MotivoDaViagemERRO.Text = "Motivo da viagem"
        '
        'L_PróximoDestinoCidadeERRO
        '
        Me.L_PróximoDestinoCidadeERRO.AutoSize = True
        Me.L_PróximoDestinoCidadeERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_PróximoDestinoCidadeERRO.ForeColor = System.Drawing.Color.Red
        Me.L_PróximoDestinoCidadeERRO.Image = CType(resources.GetObject("L_PróximoDestinoCidadeERRO.Image"), System.Drawing.Image)
        Me.L_PróximoDestinoCidadeERRO.Location = New System.Drawing.Point(478, 499)
        Me.L_PróximoDestinoCidadeERRO.Name = "L_PróximoDestinoCidadeERRO"
        Me.L_PróximoDestinoCidadeERRO.Size = New System.Drawing.Size(91, 13)
        Me.L_PróximoDestinoCidadeERRO.TabIndex = 170
        Me.L_PróximoDestinoCidadeERRO.Text = "Destino Cidade uf"
        '
        'L_PróximoDestinoPaisERRO
        '
        Me.L_PróximoDestinoPaisERRO.AutoSize = True
        Me.L_PróximoDestinoPaisERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_PróximoDestinoPaisERRO.ForeColor = System.Drawing.Color.Red
        Me.L_PróximoDestinoPaisERRO.Image = CType(resources.GetObject("L_PróximoDestinoPaisERRO.Image"), System.Drawing.Image)
        Me.L_PróximoDestinoPaisERRO.Location = New System.Drawing.Point(13, 499)
        Me.L_PróximoDestinoPaisERRO.Name = "L_PróximoDestinoPaisERRO"
        Me.L_PróximoDestinoPaisERRO.Size = New System.Drawing.Size(66, 13)
        Me.L_PróximoDestinoPaisERRO.TabIndex = 168
        Me.L_PróximoDestinoPaisERRO.Text = "Destino Pais"
        '
        'L_ultimaProcCidadeErro
        '
        Me.L_ultimaProcCidadeErro.AutoSize = True
        Me.L_ultimaProcCidadeErro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ultimaProcCidadeErro.ForeColor = System.Drawing.Color.Red
        Me.L_ultimaProcCidadeErro.Image = CType(resources.GetObject("L_ultimaProcCidadeErro.Image"), System.Drawing.Image)
        Me.L_ultimaProcCidadeErro.Location = New System.Drawing.Point(478, 446)
        Me.L_ultimaProcCidadeErro.Name = "L_ultimaProcCidadeErro"
        Me.L_ultimaProcCidadeErro.Size = New System.Drawing.Size(109, 13)
        Me.L_ultimaProcCidadeErro.TabIndex = 167
        Me.L_ultimaProcCidadeErro.Text = "Ultima Proc Cidade uf"
        '
        'L_ultimaProcPaisErro
        '
        Me.L_ultimaProcPaisErro.AutoSize = True
        Me.L_ultimaProcPaisErro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ultimaProcPaisErro.ForeColor = System.Drawing.Color.Red
        Me.L_ultimaProcPaisErro.Image = CType(resources.GetObject("L_ultimaProcPaisErro.Image"), System.Drawing.Image)
        Me.L_ultimaProcPaisErro.Location = New System.Drawing.Point(10, 446)
        Me.L_ultimaProcPaisErro.Name = "L_ultimaProcPaisErro"
        Me.L_ultimaProcPaisErro.Size = New System.Drawing.Size(84, 13)
        Me.L_ultimaProcPaisErro.TabIndex = 165
        Me.L_ultimaProcPaisErro.Text = "Ultima Proc Pais"
        '
        'L_ResidenciaCidadeERRO
        '
        Me.L_ResidenciaCidadeERRO.AutoSize = True
        Me.L_ResidenciaCidadeERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ResidenciaCidadeERRO.ForeColor = System.Drawing.Color.Red
        Me.L_ResidenciaCidadeERRO.Image = CType(resources.GetObject("L_ResidenciaCidadeERRO.Image"), System.Drawing.Image)
        Me.L_ResidenciaCidadeERRO.Location = New System.Drawing.Point(683, 387)
        Me.L_ResidenciaCidadeERRO.Name = "L_ResidenciaCidadeERRO"
        Me.L_ResidenciaCidadeERRO.Size = New System.Drawing.Size(91, 13)
        Me.L_ResidenciaCidadeERRO.TabIndex = 164
        Me.L_ResidenciaCidadeERRO.Text = "residencia Cidade"
        '
        'L_ResidenciapaisERRO
        '
        Me.L_ResidenciapaisERRO.AutoSize = True
        Me.L_ResidenciapaisERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ResidenciapaisERRO.ForeColor = System.Drawing.Color.Red
        Me.L_ResidenciapaisERRO.Image = CType(resources.GetObject("L_ResidenciapaisERRO.Image"), System.Drawing.Image)
        Me.L_ResidenciapaisERRO.Location = New System.Drawing.Point(287, 387)
        Me.L_ResidenciapaisERRO.Name = "L_ResidenciapaisERRO"
        Me.L_ResidenciapaisERRO.Size = New System.Drawing.Size(78, 13)
        Me.L_ResidenciapaisERRO.TabIndex = 162
        Me.L_ResidenciapaisERRO.Text = "residencia Pais"
        '
        'L_OrgãoExpdidorERRO
        '
        Me.L_OrgãoExpdidorERRO.AutoSize = True
        Me.L_OrgãoExpdidorERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_OrgãoExpdidorERRO.ForeColor = System.Drawing.Color.Red
        Me.L_OrgãoExpdidorERRO.Image = CType(resources.GetObject("L_OrgãoExpdidorERRO.Image"), System.Drawing.Image)
        Me.L_OrgãoExpdidorERRO.Location = New System.Drawing.Point(472, 336)
        Me.L_OrgãoExpdidorERRO.Name = "L_OrgãoExpdidorERRO"
        Me.L_OrgãoExpdidorERRO.Size = New System.Drawing.Size(85, 13)
        Me.L_OrgãoExpdidorERRO.TabIndex = 161
        Me.L_OrgãoExpdidorERRO.Text = "Orgão expedidor"
        '
        'L_NdDocumentoERRO
        '
        Me.L_NdDocumentoERRO.AutoSize = True
        Me.L_NdDocumentoERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_NdDocumentoERRO.ForeColor = System.Drawing.Color.Red
        Me.L_NdDocumentoERRO.Image = CType(resources.GetObject("L_NdDocumentoERRO.Image"), System.Drawing.Image)
        Me.L_NdDocumentoERRO.Location = New System.Drawing.Point(186, 336)
        Me.L_NdDocumentoERRO.Name = "L_NdDocumentoERRO"
        Me.L_NdDocumentoERRO.Size = New System.Drawing.Size(90, 13)
        Me.L_NdDocumentoERRO.TabIndex = 160
        Me.L_NdDocumentoERRO.Text = "Nº de documento"
        '
        'L_tipoDocumentoERRO
        '
        Me.L_tipoDocumentoERRO.AutoSize = True
        Me.L_tipoDocumentoERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_tipoDocumentoERRO.ForeColor = System.Drawing.Color.Red
        Me.L_tipoDocumentoERRO.Image = CType(resources.GetObject("L_tipoDocumentoERRO.Image"), System.Drawing.Image)
        Me.L_tipoDocumentoERRO.Location = New System.Drawing.Point(13, 336)
        Me.L_tipoDocumentoERRO.Name = "L_tipoDocumentoERRO"
        Me.L_tipoDocumentoERRO.Size = New System.Drawing.Size(99, 13)
        Me.L_tipoDocumentoERRO.TabIndex = 159
        Me.L_tipoDocumentoERRO.Text = "Tipo de documento"
        '
        'L_nacionalidadeERRO
        '
        Me.L_nacionalidadeERRO.AutoSize = True
        Me.L_nacionalidadeERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_nacionalidadeERRO.ForeColor = System.Drawing.Color.Red
        Me.L_nacionalidadeERRO.Image = CType(resources.GetObject("L_nacionalidadeERRO.Image"), System.Drawing.Image)
        Me.L_nacionalidadeERRO.Location = New System.Drawing.Point(296, 263)
        Me.L_nacionalidadeERRO.Name = "L_nacionalidadeERRO"
        Me.L_nacionalidadeERRO.Size = New System.Drawing.Size(73, 13)
        Me.L_nacionalidadeERRO.TabIndex = 158
        Me.L_nacionalidadeERRO.Text = "nacionalidade"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label49.Image = CType(resources.GetObject("Label49.Image"), System.Drawing.Image)
        Me.Label49.Location = New System.Drawing.Point(236, 513)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(140, 15)
        Me.Label49.TabIndex = 150
        Me.Label49.Text = "Meio de Transporte :"
        '
        'L_profissãoERRO
        '
        Me.L_profissãoERRO.AutoSize = True
        Me.L_profissãoERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_profissãoERRO.ForeColor = System.Drawing.Color.Red
        Me.L_profissãoERRO.Image = CType(resources.GetObject("L_profissãoERRO.Image"), System.Drawing.Image)
        Me.L_profissãoERRO.Location = New System.Drawing.Point(10, 263)
        Me.L_profissãoERRO.Name = "L_profissãoERRO"
        Me.L_profissãoERRO.Size = New System.Drawing.Size(50, 13)
        Me.L_profissãoERRO.TabIndex = 153
        Me.L_profissãoERRO.Text = "Profissão"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(10, 564)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 15)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Observaçães - Notes"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label46.Image = CType(resources.GetObject("Label46.Image"), System.Drawing.Image)
        Me.Label46.Location = New System.Drawing.Point(7, 513)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(129, 15)
        Me.Label46.TabIndex = 139
        Me.Label46.Text = "Motivo da Viagem :"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label47.Font = New System.Drawing.Font("Papyrus", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.White
        Me.Label47.Image = CType(resources.GetObject("Label47.Image"), System.Drawing.Image)
        Me.Label47.Location = New System.Drawing.Point(1, 25)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(336, 70)
        Me.Label47.TabIndex = 140
        Me.Label47.Text = "Bem Vindo  ao"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label42.Image = CType(resources.GetObject("Label42.Image"), System.Drawing.Image)
        Me.Label42.Location = New System.Drawing.Point(475, 480)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(46, 15)
        Me.Label42.TabIndex = 138
        Me.Label42.Text = "Cidade"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label44.Image = CType(resources.GetObject("Label44.Image"), System.Drawing.Image)
        Me.Label44.Location = New System.Drawing.Point(10, 479)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(31, 15)
        Me.Label44.TabIndex = 136
        Me.Label44.Text = "País"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label45.Image = CType(resources.GetObject("Label45.Image"), System.Drawing.Image)
        Me.Label45.Location = New System.Drawing.Point(8, 460)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(121, 15)
        Me.Label45.TabIndex = 135
        Me.Label45.Text = "Próximo Destino :"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label41.Image = CType(resources.GetObject("Label41.Image"), System.Drawing.Image)
        Me.Label41.Location = New System.Drawing.Point(474, 427)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(46, 15)
        Me.Label41.TabIndex = 131
        Me.Label41.Text = "Cidade"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label39.Image = CType(resources.GetObject("Label39.Image"), System.Drawing.Image)
        Me.Label39.Location = New System.Drawing.Point(9, 426)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(31, 15)
        Me.Label39.TabIndex = 127
        Me.Label39.Text = "País"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label38.Image = CType(resources.GetObject("Label38.Image"), System.Drawing.Image)
        Me.Label38.Location = New System.Drawing.Point(7, 407)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(140, 15)
        Me.Label38.TabIndex = 126
        Me.Label38.Text = "Última procedência :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label37.Image = CType(resources.GetObject("Label37.Image"), System.Drawing.Image)
        Me.Label37.Location = New System.Drawing.Point(676, 350)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(52, 15)
        Me.Label37.TabIndex = 125
        Me.Label37.Text = "Cidade :"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label35.Image = CType(resources.GetObject("Label35.Image"), System.Drawing.Image)
        Me.Label35.Location = New System.Drawing.Point(285, 350)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 15)
        Me.Label35.TabIndex = 121
        Me.Label35.Text = "Pais :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label34.Image = CType(resources.GetObject("Label34.Image"), System.Drawing.Image)
        Me.Label34.Location = New System.Drawing.Point(466, 297)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(106, 15)
        Me.Label34.TabIndex = 120
        Me.Label34.Text = "Orgão Expedidor :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Image = CType(resources.GetObject("Label28.Image"), System.Drawing.Image)
        Me.Label28.Location = New System.Drawing.Point(182, 297)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(138, 15)
        Me.Label28.TabIndex = 119
        Me.Label28.Text = "N° Tipo de Documento :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.Location = New System.Drawing.Point(11, 297)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 15)
        Me.Label18.TabIndex = 118
        Me.Label18.Text = "Tipo de Documento :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(9, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 15)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Documentação de Indentifição "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label27.Image = CType(resources.GetObject("Label27.Image"), System.Drawing.Image)
        Me.Label27.Location = New System.Drawing.Point(291, 227)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(93, 15)
        Me.Label27.TabIndex = 116
        Me.Label27.Text = "Nacionalidade :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.Location = New System.Drawing.Point(622, 226)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 15)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Gênero :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
        Me.Label15.Location = New System.Drawing.Point(7, 226)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 15)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "Profissão :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label30.Image = CType(resources.GetObject("Label30.Image"), System.Drawing.Image)
        Me.Label30.Location = New System.Drawing.Point(506, 190)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(21, 15)
        Me.Label30.TabIndex = 113
        Me.Label30.Text = "N°"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label31.Image = CType(resources.GetObject("Label31.Image"), System.Drawing.Image)
        Me.Label31.Location = New System.Drawing.Point(411, 190)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 15)
        Me.Label31.TabIndex = 111
        Me.Label31.Text = "DDD"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label32.Image = CType(resources.GetObject("Label32.Image"), System.Drawing.Image)
        Me.Label32.Location = New System.Drawing.Point(336, 190)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(28, 15)
        Me.Label32.TabIndex = 110
        Me.Label32.Text = "DDI"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label33.Image = CType(resources.GetObject("Label33.Image"), System.Drawing.Image)
        Me.Label33.Location = New System.Drawing.Point(336, 170)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(52, 15)
        Me.Label33.TabIndex = 109
        Me.Label33.Text = "Celular :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label29.Image = CType(resources.GetObject("Label29.Image"), System.Drawing.Image)
        Me.Label29.Location = New System.Drawing.Point(177, 190)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(21, 15)
        Me.Label29.TabIndex = 106
        Me.Label29.Text = "N°"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Image = CType(resources.GetObject("Label20.Image"), System.Drawing.Image)
        Me.Label20.Location = New System.Drawing.Point(767, 133)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 20)
        Me.Label20.TabIndex = 101
        Me.Label20.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(85, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "DDD"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(11, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "DDI"
        '
        'L_preferencia_Q_INEXISTENTE
        '
        Me.L_preferencia_Q_INEXISTENTE.AutoSize = True
        Me.L_preferencia_Q_INEXISTENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_preferencia_Q_INEXISTENTE.ForeColor = System.Drawing.Color.Red
        Me.L_preferencia_Q_INEXISTENTE.Image = CType(resources.GetObject("L_preferencia_Q_INEXISTENTE.Image"), System.Drawing.Image)
        Me.L_preferencia_Q_INEXISTENTE.Location = New System.Drawing.Point(725, 474)
        Me.L_preferencia_Q_INEXISTENTE.Name = "L_preferencia_Q_INEXISTENTE"
        Me.L_preferencia_Q_INEXISTENTE.Size = New System.Drawing.Size(39, 13)
        Me.L_preferencia_Q_INEXISTENTE.TabIndex = 75
        Me.L_preferencia_Q_INEXISTENTE.Text = "Label4"
        '
        'L_DataDeNascimentoERRO
        '
        Me.L_DataDeNascimentoERRO.AutoSize = True
        Me.L_DataDeNascimentoERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DataDeNascimentoERRO.ForeColor = System.Drawing.Color.Red
        Me.L_DataDeNascimentoERRO.Image = CType(resources.GetObject("L_DataDeNascimentoERRO.Image"), System.Drawing.Image)
        Me.L_DataDeNascimentoERRO.Location = New System.Drawing.Point(514, 263)
        Me.L_DataDeNascimentoERRO.Name = "L_DataDeNascimentoERRO"
        Me.L_DataDeNascimentoERRO.Size = New System.Drawing.Size(61, 13)
        Me.L_DataDeNascimentoERRO.TabIndex = 73
        Me.L_DataDeNascimentoERRO.Text = "nascimento"
        '
        'L_ResidenciaPermanenteERRO
        '
        Me.L_ResidenciaPermanenteERRO.AutoSize = True
        Me.L_ResidenciaPermanenteERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ResidenciaPermanenteERRO.ForeColor = System.Drawing.Color.Red
        Me.L_ResidenciaPermanenteERRO.Image = CType(resources.GetObject("L_ResidenciaPermanenteERRO.Image"), System.Drawing.Image)
        Me.L_ResidenciaPermanenteERRO.Location = New System.Drawing.Point(14, 387)
        Me.L_ResidenciaPermanenteERRO.Name = "L_ResidenciaPermanenteERRO"
        Me.L_ResidenciaPermanenteERRO.Size = New System.Drawing.Size(55, 13)
        Me.L_ResidenciaPermanenteERRO.TabIndex = 69
        Me.L_ResidenciaPermanenteERRO.Text = "residencia"
        '
        'L_celularERRO
        '
        Me.L_celularERRO.AutoSize = True
        Me.L_celularERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_celularERRO.ForeColor = System.Drawing.Color.Red
        Me.L_celularERRO.Image = CType(resources.GetObject("L_celularERRO.Image"), System.Drawing.Image)
        Me.L_celularERRO.Location = New System.Drawing.Point(340, 211)
        Me.L_celularERRO.Name = "L_celularERRO"
        Me.L_celularERRO.Size = New System.Drawing.Size(38, 13)
        Me.L_celularERRO.TabIndex = 67
        Me.L_celularERRO.Text = "celular"
        '
        'L_GeneroERRO
        '
        Me.L_GeneroERRO.AutoSize = True
        Me.L_GeneroERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_GeneroERRO.ForeColor = System.Drawing.Color.Red
        Me.L_GeneroERRO.Image = CType(resources.GetObject("L_GeneroERRO.Image"), System.Drawing.Image)
        Me.L_GeneroERRO.Location = New System.Drawing.Point(627, 263)
        Me.L_GeneroERRO.Name = "L_GeneroERRO"
        Me.L_GeneroERRO.Size = New System.Drawing.Size(42, 13)
        Me.L_GeneroERRO.TabIndex = 65
        Me.L_GeneroERRO.Text = "Gênero"
        '
        'L_emailLocalideERRO
        '
        Me.L_emailLocalideERRO.AutoSize = True
        Me.L_emailLocalideERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_emailLocalideERRO.ForeColor = System.Drawing.Color.Red
        Me.L_emailLocalideERRO.Image = CType(resources.GetObject("L_emailLocalideERRO.Image"), System.Drawing.Image)
        Me.L_emailLocalideERRO.Location = New System.Drawing.Point(783, 155)
        Me.L_emailLocalideERRO.Name = "L_emailLocalideERRO"
        Me.L_emailLocalideERRO.Size = New System.Drawing.Size(27, 13)
        Me.L_emailLocalideERRO.TabIndex = 64
        Me.L_emailLocalideERRO.Text = "com"
        '
        'L_emaildominioERRO
        '
        Me.L_emaildominioERRO.AutoSize = True
        Me.L_emaildominioERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_emaildominioERRO.ForeColor = System.Drawing.Color.Red
        Me.L_emaildominioERRO.Image = CType(resources.GetObject("L_emaildominioERRO.Image"), System.Drawing.Image)
        Me.L_emaildominioERRO.Location = New System.Drawing.Point(661, 155)
        Me.L_emaildominioERRO.Name = "L_emaildominioERRO"
        Me.L_emaildominioERRO.Size = New System.Drawing.Size(70, 13)
        Me.L_emaildominioERRO.TabIndex = 63
        Me.L_emaildominioERRO.Text = "complemento"
        '
        'L_EmaiERRO
        '
        Me.L_EmaiERRO.AutoSize = True
        Me.L_EmaiERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_EmaiERRO.ForeColor = System.Drawing.Color.Red
        Me.L_EmaiERRO.Image = CType(resources.GetObject("L_EmaiERRO.Image"), System.Drawing.Image)
        Me.L_EmaiERRO.Location = New System.Drawing.Point(408, 155)
        Me.L_EmaiERRO.Name = "L_EmaiERRO"
        Me.L_EmaiERRO.Size = New System.Drawing.Size(34, 13)
        Me.L_EmaiERRO.TabIndex = 62
        Me.L_EmaiERRO.Text = "e-mail"
        '
        'L_nomeERRO
        '
        Me.L_nomeERRO.AutoSize = True
        Me.L_nomeERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_nomeERRO.ForeColor = System.Drawing.Color.Red
        Me.L_nomeERRO.Image = CType(resources.GetObject("L_nomeERRO.Image"), System.Drawing.Image)
        Me.L_nomeERRO.Location = New System.Drawing.Point(15, 155)
        Me.L_nomeERRO.Name = "L_nomeERRO"
        Me.L_nomeERRO.Size = New System.Drawing.Size(33, 13)
        Me.L_nomeERRO.TabIndex = 61
        Me.L_nomeERRO.Text = "nome"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label26.Image = CType(resources.GetObject("Label26.Image"), System.Drawing.Image)
        Me.Label26.Location = New System.Drawing.Point(713, 439)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(150, 15)
        Me.Label26.TabIndex = 55
        Me.Label26.Text = "Preferencia de quarto:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.Location = New System.Drawing.Point(625, 565)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 15)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "Data do check out :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.Location = New System.Drawing.Point(507, 565)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 15)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Data do check in :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
        Me.Label17.Location = New System.Drawing.Point(11, 350)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(146, 15)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Residência Permanente :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
        Me.Label14.Location = New System.Drawing.Point(11, 170)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 15)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Telefone :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(511, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 15)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Data Nac :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.Location = New System.Drawing.Point(402, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Email :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(10, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 15)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Nome completo :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.Location = New System.Drawing.Point(757, 529)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Valor total:"
        '
        'L_total
        '
        Me.L_total.AutoSize = True
        Me.L_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_total.ForeColor = System.Drawing.Color.Red
        Me.L_total.Image = CType(resources.GetObject("L_total.Image"), System.Drawing.Image)
        Me.L_total.Location = New System.Drawing.Point(784, 546)
        Me.L_total.Name = "L_total"
        Me.L_total.Size = New System.Drawing.Size(31, 15)
        Me.L_total.TabIndex = 36
        Me.L_total.Text = "354"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(637, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "@"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label40.Image = CType(resources.GetObject("Label40.Image"), System.Drawing.Image)
        Me.Label40.Location = New System.Drawing.Point(250, 426)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(23, 15)
        Me.Label40.TabIndex = 129
        Me.Label40.Text = "UF"
        '
        'L_ultimaProcUfErro
        '
        Me.L_ultimaProcUfErro.AutoSize = True
        Me.L_ultimaProcUfErro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ultimaProcUfErro.ForeColor = System.Drawing.Color.Red
        Me.L_ultimaProcUfErro.Image = CType(resources.GetObject("L_ultimaProcUfErro.Image"), System.Drawing.Image)
        Me.L_ultimaProcUfErro.Location = New System.Drawing.Point(255, 446)
        Me.L_ultimaProcUfErro.Name = "L_ultimaProcUfErro"
        Me.L_ultimaProcUfErro.Size = New System.Drawing.Size(73, 13)
        Me.L_ultimaProcUfErro.TabIndex = 166
        Me.L_ultimaProcUfErro.Text = "Ultima Proc uf"
        '
        'L_PróximoDestinoUfERRO
        '
        Me.L_PróximoDestinoUfERRO.AutoSize = True
        Me.L_PróximoDestinoUfERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_PróximoDestinoUfERRO.ForeColor = System.Drawing.Color.Red
        Me.L_PróximoDestinoUfERRO.Image = CType(resources.GetObject("L_PróximoDestinoUfERRO.Image"), System.Drawing.Image)
        Me.L_PróximoDestinoUfERRO.Location = New System.Drawing.Point(258, 499)
        Me.L_PróximoDestinoUfERRO.Name = "L_PróximoDestinoUfERRO"
        Me.L_PróximoDestinoUfERRO.Size = New System.Drawing.Size(55, 13)
        Me.L_PróximoDestinoUfERRO.TabIndex = 169
        Me.L_PróximoDestinoUfERRO.Text = "Destino uf"
        '
        'L_ResidenciaUfERRO
        '
        Me.L_ResidenciaUfERRO.AutoSize = True
        Me.L_ResidenciaUfERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ResidenciaUfERRO.ForeColor = System.Drawing.Color.Red
        Me.L_ResidenciaUfERRO.Image = CType(resources.GetObject("L_ResidenciaUfERRO.Image"), System.Drawing.Image)
        Me.L_ResidenciaUfERRO.Location = New System.Drawing.Point(517, 387)
        Me.L_ResidenciaUfERRO.Name = "L_ResidenciaUfERRO"
        Me.L_ResidenciaUfERRO.Size = New System.Drawing.Size(72, 13)
        Me.L_ResidenciaUfERRO.TabIndex = 163
        Me.L_ResidenciaUfERRO.Text = "residencia UF"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label36.Image = CType(resources.GetObject("Label36.Image"), System.Drawing.Image)
        Me.Label36.Location = New System.Drawing.Point(516, 350)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(29, 15)
        Me.Label36.TabIndex = 123
        Me.Label36.Text = "UF :"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label43.Image = CType(resources.GetObject("Label43.Image"), System.Drawing.Image)
        Me.Label43.Location = New System.Drawing.Point(251, 479)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(23, 15)
        Me.Label43.TabIndex = 137
        Me.Label43.Text = "UF"
        '
        'L_tefefoneERRO
        '
        Me.L_tefefoneERRO.AutoSize = True
        Me.L_tefefoneERRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_tefefoneERRO.ForeColor = System.Drawing.Color.Red
        Me.L_tefefoneERRO.Image = CType(resources.GetObject("L_tefefoneERRO.Image"), System.Drawing.Image)
        Me.L_tefefoneERRO.Location = New System.Drawing.Point(14, 211)
        Me.L_tefefoneERRO.Name = "L_tefefoneERRO"
        Me.L_tefefoneERRO.Size = New System.Drawing.Size(49, 13)
        Me.L_tefefoneERRO.TabIndex = 66
        Me.L_tefefoneERRO.Text = "Telefone"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Infinity_Hotel.My.Resources.Resources.Plano_de_fundo
        Me.PictureBox1.Location = New System.Drawing.Point(-24, -22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(973, 741)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 182
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox2.Image = Global.Infinity_Hotel.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(304, -30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(253, 172)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 229
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Papyrus", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(520, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 70)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Cinco Estrelas"
        '
        'L_DataCheckOut
        '
        Me.L_DataCheckOut.AutoSize = True
        Me.L_DataCheckOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_DataCheckOut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_DataCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_DataCheckOut.Image = CType(resources.GetObject("L_DataCheckOut.Image"), System.Drawing.Image)
        Me.L_DataCheckOut.Location = New System.Drawing.Point(640, 585)
        Me.L_DataCheckOut.Name = "L_DataCheckOut"
        Me.L_DataCheckOut.Size = New System.Drawing.Size(62, 15)
        Me.L_DataCheckOut.TabIndex = 231
        Me.L_DataCheckOut.Text = "00/00/000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(547, 619)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 15)
        Me.Label6.TabIndex = 232
        Me.Label6.Text = "Nº de dias da hospedagem"
        '
        'N_Ndias
        '
        Me.N_Ndias.Location = New System.Drawing.Point(559, 636)
        Me.N_Ndias.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.N_Ndias.Name = "N_Ndias"
        Me.N_Ndias.Size = New System.Drawing.Size(120, 20)
        Me.N_Ndias.TabIndex = 233
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(757, 546)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 15)
        Me.Label7.TabIndex = 245
        Me.Label7.Text = "-R$"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 685)
        Me.Controls.Add(Me.C_Genero)
        Me.Controls.Add(Me.L_GeneroERRO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.N_Ndias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.L_DataCheckOut)
        Me.Controls.Add(Me.L_data)
        Me.Controls.Add(Me.L_hora)
        Me.Controls.Add(Me.C_ResidenciaPais)
        Me.Controls.Add(Me.P_Cancelar)
        Me.Controls.Add(Me.B_Cancelar)
        Me.Controls.Add(Me.P_registrar)
        Me.Controls.Add(Me.B_Registrar)
        Me.Controls.Add(Me.C_comEcombr)
        Me.Controls.Add(Me.L_DataCheckIn)
        Me.Controls.Add(Me.C_tipoDeDocumento)
        Me.Controls.Add(Me.C_emailDominio)
        Me.Controls.Add(Me.T_observação)
        Me.Controls.Add(Me.T_Profissao)
        Me.Controls.Add(Me.L_CheckOutERRO)
        Me.Controls.Add(Me.L_ObservaçãoERRO)
        Me.Controls.Add(Me.C_MeioDeTransporte)
        Me.Controls.Add(Me.L_MeioDeTransporteERRO)
        Me.Controls.Add(Me.C_MotivoDaViagem)
        Me.Controls.Add(Me.L_MotivoDaViagemERRO)
        Me.Controls.Add(Me.T_ProximoDestinoCidade)
        Me.Controls.Add(Me.C_ProximoDestinoPais)
        Me.Controls.Add(Me.L_PróximoDestinoCidadeERRO)
        Me.Controls.Add(Me.L_PróximoDestinoPaisERRO)
        Me.Controls.Add(Me.T_UltimaProcedenciaCidade)
        Me.Controls.Add(Me.L_ultimaProcCidadeErro)
        Me.Controls.Add(Me.C_UltimaProcedenciaPais)
        Me.Controls.Add(Me.L_ultimaProcPaisErro)
        Me.Controls.Add(Me.L_ResidenciaCidadeERRO)
        Me.Controls.Add(Me.L_ResidenciapaisERRO)
        Me.Controls.Add(Me.L_OrgãoExpdidorERRO)
        Me.Controls.Add(Me.L_NdDocumentoERRO)
        Me.Controls.Add(Me.L_tipoDocumentoERRO)
        Me.Controls.Add(Me.L_nacionalidadeERRO)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.L_profissãoERRO)
        Me.Controls.Add(Me.T_ResidenciaCidade)
        Me.Controls.Add(Me.M_TelefoneN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.M_OrgaoExpedidor)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.C_Nacionalidade)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.M_CelularN)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.M_CelularDDD)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.M_DataDeNascimento)
        Me.Controls.Add(Me.C_PreferenciaQuarto)
        Me.Controls.Add(Me.L_preferencia_Q_INEXISTENTE)
        Me.Controls.Add(Me.L_DataDeNascimentoERRO)
        Me.Controls.Add(Me.T_ResidenciaPermanente)
        Me.Controls.Add(Me.L_ResidenciaPermanenteERRO)
        Me.Controls.Add(Me.L_celularERRO)
        Me.Controls.Add(Me.L_emailLocalideERRO)
        Me.Controls.Add(Me.L_emaildominioERRO)
        Me.Controls.Add(Me.T_lerEMAIL)
        Me.Controls.Add(Me.L_EmaiERRO)
        Me.Controls.Add(Me.T_lerNOME)
        Me.Controls.Add(Me.L_nomeERRO)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.L_total)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.L_ultimaProcUfErro)
        Me.Controls.Add(Me.L_PróximoDestinoUfERRO)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.M_NdeDocumento)
        Me.Controls.Add(Me.T_TelefoneDDI)
        Me.Controls.Add(Me.M_TelefoneDDD)
        Me.Controls.Add(Me.T_CelularDDI)
        Me.Controls.Add(Me.L_tefefoneERRO)
        Me.Controls.Add(Me.C_ResidenciaUF)
        Me.Controls.Add(Me.C_UltimaProcedenciaUF)
        Me.Controls.Add(Me.C_ProximoDestinoUF)
        Me.Controls.Add(Me.T_ResidenciaUF)
        Me.Controls.Add(Me.T_próximoDestinoUF)
        Me.Controls.Add(Me.T_ultimaProcedenciaUF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.L_ResidenciaUfERRO)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Infinity Hotel"
        CType(Me.P_Cancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_registrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Ndias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T_lerNOME As System.Windows.Forms.TextBox
    Friend WithEvents T_lerEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C_emailDominio As System.Windows.Forms.ComboBox
    Friend WithEvents C_comEcombr As System.Windows.Forms.ComboBox
    Friend WithEvents P_registrar As System.Windows.Forms.PictureBox
    Friend WithEvents P_Cancelar As System.Windows.Forms.PictureBox
    Friend WithEvents L_total As System.Windows.Forms.Label
    Friend WithEvents C_PreferenciaQuarto As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents L_nomeERRO As System.Windows.Forms.Label
    Friend WithEvents L_EmaiERRO As System.Windows.Forms.Label
    Friend WithEvents L_emaildominioERRO As System.Windows.Forms.Label
    Friend WithEvents L_emailLocalideERRO As System.Windows.Forms.Label
    Friend WithEvents L_GeneroERRO As System.Windows.Forms.Label
    Friend WithEvents L_tefefoneERRO As System.Windows.Forms.Label
    Friend WithEvents L_celularERRO As System.Windows.Forms.Label
    Friend WithEvents L_ResidenciaPermanenteERRO As System.Windows.Forms.Label
    Friend WithEvents L_DataDeNascimentoERRO As System.Windows.Forms.Label
    Friend WithEvents L_preferencia_Q_INEXISTENTE As System.Windows.Forms.Label
    Friend WithEvents M_DataDeNascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents M_CelularN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents M_CelularDDD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents C_Nacionalidade As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents C_Genero As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents M_NdeDocumento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents M_OrgaoExpedidor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents T_ResidenciaPermanente As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents C_ResidenciaPais As System.Windows.Forms.ComboBox
    Friend WithEvents C_ResidenciaUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents C_UltimaProcedenciaPais As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents C_ProximoDestinoPais As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents T_ResidenciaCidade As System.Windows.Forms.TextBox
    Friend WithEvents L_profissãoERRO As System.Windows.Forms.Label
    Friend WithEvents C_MotivoDaViagem As System.Windows.Forms.ComboBox
    Friend WithEvents C_MeioDeTransporte As System.Windows.Forms.ComboBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents T_ProximoDestinoCidade As System.Windows.Forms.TextBox
    Friend WithEvents T_UltimaProcedenciaCidade As System.Windows.Forms.TextBox
    Friend WithEvents L_nacionalidadeERRO As System.Windows.Forms.Label
    Friend WithEvents L_tipoDocumentoERRO As System.Windows.Forms.Label
    Friend WithEvents L_NdDocumentoERRO As System.Windows.Forms.Label
    Friend WithEvents L_OrgãoExpdidorERRO As System.Windows.Forms.Label
    Friend WithEvents L_ResidenciapaisERRO As System.Windows.Forms.Label
    Friend WithEvents L_ResidenciaUfERRO As System.Windows.Forms.Label
    Friend WithEvents L_ResidenciaCidadeERRO As System.Windows.Forms.Label
    Friend WithEvents L_ultimaProcUfErro As System.Windows.Forms.Label
    Friend WithEvents L_ultimaProcPaisErro As System.Windows.Forms.Label
    Friend WithEvents L_ultimaProcCidadeErro As System.Windows.Forms.Label
    Friend WithEvents L_PróximoDestinoCidadeERRO As System.Windows.Forms.Label
    Friend WithEvents L_PróximoDestinoUfERRO As System.Windows.Forms.Label
    Friend WithEvents L_PróximoDestinoPaisERRO As System.Windows.Forms.Label
    Friend WithEvents L_MotivoDaViagemERRO As System.Windows.Forms.Label
    Friend WithEvents L_MeioDeTransporteERRO As System.Windows.Forms.Label
    Friend WithEvents L_ObservaçãoERRO As System.Windows.Forms.Label
    Friend WithEvents L_CheckOutERRO As System.Windows.Forms.Label
    Friend WithEvents T_Profissao As System.Windows.Forms.TextBox
    Friend WithEvents T_observação As System.Windows.Forms.TextBox
    Friend WithEvents C_UltimaProcedenciaUF As System.Windows.Forms.ComboBox
    Friend WithEvents T_ultimaProcedenciaUF As System.Windows.Forms.TextBox
    Friend WithEvents T_próximoDestinoUF As System.Windows.Forms.TextBox
    Friend WithEvents C_tipoDeDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents T_ResidenciaUF As System.Windows.Forms.TextBox
    Friend WithEvents L_DataCheckIn As System.Windows.Forms.Label
    Friend WithEvents T_TelefoneDDI As System.Windows.Forms.TextBox
    Friend WithEvents M_TelefoneN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents M_TelefoneDDD As System.Windows.Forms.MaskedTextBox
    Friend WithEvents T_CelularDDI As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents C_ProximoDestinoUF As System.Windows.Forms.ComboBox
    Friend WithEvents B_Registrar As System.Windows.Forms.Button
    Friend WithEvents B_Cancelar As System.Windows.Forms.Button
    Friend WithEvents L_data As System.Windows.Forms.Label
    Friend WithEvents L_hora As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents L_DataCheckOut As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents N_Ndias As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
