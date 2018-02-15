<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Avaliacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Avaliacao))
        Me.TB_Nome = New System.Windows.Forms.TextBox()
        Me.CB_MesaDesign = New System.Windows.Forms.ComboBox()
        Me.CB_MesaCriatividade = New System.Windows.Forms.ComboBox()
        Me.CB_MesaMecanicas = New System.Windows.Forms.ComboBox()
        Me.CB_MesaEntretenimento = New System.Windows.Forms.ComboBox()
        Me.TB_MesaObserva = New System.Windows.Forms.TextBox()
        Me.TB_DigitalObserva = New System.Windows.Forms.TextBox()
        Me.CB_DigitalEntretenimento = New System.Windows.Forms.ComboBox()
        Me.CB_DigitalMecanicas = New System.Windows.Forms.ComboBox()
        Me.CB_DigitalCriatividade = New System.Windows.Forms.ComboBox()
        Me.CB_DigitalDesgn = New System.Windows.Forms.ComboBox()
        Me.B_Voltar = New System.Windows.Forms.Button()
        Me.B_Salvar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.L_ErroNome = New System.Windows.Forms.Label()
        Me.L_ErroMesaObserva = New System.Windows.Forms.Label()
        Me.L_ErroMesaEntretenimento = New System.Windows.Forms.Label()
        Me.L_ErroMesaMecanicas = New System.Windows.Forms.Label()
        Me.L_ErroMesaCriatividade = New System.Windows.Forms.Label()
        Me.L_ErroMesaDesign = New System.Windows.Forms.Label()
        Me.L_ErroDigitalObserva = New System.Windows.Forms.Label()
        Me.L_ErroDigitalEntretenimento = New System.Windows.Forms.Label()
        Me.L_ErroDigitalMecanicas = New System.Windows.Forms.Label()
        Me.L_ErroDigitalCriatividade = New System.Windows.Forms.Label()
        Me.L_ErroDigitalDesign = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_Nome
        '
        Me.TB_Nome.BackColor = System.Drawing.Color.White
        Me.TB_Nome.Location = New System.Drawing.Point(16, 32)
        Me.TB_Nome.Name = "TB_Nome"
        Me.TB_Nome.Size = New System.Drawing.Size(293, 20)
        Me.TB_Nome.TabIndex = 1
        '
        'CB_MesaDesign
        '
        Me.CB_MesaDesign.BackColor = System.Drawing.Color.White
        Me.CB_MesaDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MesaDesign.FormattingEnabled = True
        Me.CB_MesaDesign.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CB_MesaDesign.Location = New System.Drawing.Point(16, 136)
        Me.CB_MesaDesign.Name = "CB_MesaDesign"
        Me.CB_MesaDesign.Size = New System.Drawing.Size(67, 21)
        Me.CB_MesaDesign.TabIndex = 7
        '
        'CB_MesaCriatividade
        '
        Me.CB_MesaCriatividade.BackColor = System.Drawing.Color.White
        Me.CB_MesaCriatividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MesaCriatividade.FormattingEnabled = True
        Me.CB_MesaCriatividade.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CB_MesaCriatividade.Location = New System.Drawing.Point(16, 197)
        Me.CB_MesaCriatividade.Name = "CB_MesaCriatividade"
        Me.CB_MesaCriatividade.Size = New System.Drawing.Size(67, 21)
        Me.CB_MesaCriatividade.TabIndex = 9
        '
        'CB_MesaMecanicas
        '
        Me.CB_MesaMecanicas.BackColor = System.Drawing.Color.White
        Me.CB_MesaMecanicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MesaMecanicas.FormattingEnabled = True
        Me.CB_MesaMecanicas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CB_MesaMecanicas.Location = New System.Drawing.Point(16, 258)
        Me.CB_MesaMecanicas.Name = "CB_MesaMecanicas"
        Me.CB_MesaMecanicas.Size = New System.Drawing.Size(67, 21)
        Me.CB_MesaMecanicas.TabIndex = 11
        '
        'CB_MesaEntretenimento
        '
        Me.CB_MesaEntretenimento.BackColor = System.Drawing.Color.White
        Me.CB_MesaEntretenimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MesaEntretenimento.FormattingEnabled = True
        Me.CB_MesaEntretenimento.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CB_MesaEntretenimento.Location = New System.Drawing.Point(16, 320)
        Me.CB_MesaEntretenimento.Name = "CB_MesaEntretenimento"
        Me.CB_MesaEntretenimento.Size = New System.Drawing.Size(67, 21)
        Me.CB_MesaEntretenimento.TabIndex = 13
        '
        'TB_MesaObserva
        '
        Me.TB_MesaObserva.BackColor = System.Drawing.Color.White
        Me.TB_MesaObserva.Location = New System.Drawing.Point(16, 385)
        Me.TB_MesaObserva.Multiline = True
        Me.TB_MesaObserva.Name = "TB_MesaObserva"
        Me.TB_MesaObserva.Size = New System.Drawing.Size(293, 66)
        Me.TB_MesaObserva.TabIndex = 15
        '
        'TB_DigitalObserva
        '
        Me.TB_DigitalObserva.BackColor = System.Drawing.Color.White
        Me.TB_DigitalObserva.Location = New System.Drawing.Point(505, 385)
        Me.TB_DigitalObserva.Multiline = True
        Me.TB_DigitalObserva.Name = "TB_DigitalObserva"
        Me.TB_DigitalObserva.Size = New System.Drawing.Size(293, 66)
        Me.TB_DigitalObserva.TabIndex = 26
        '
        'CB_DigitalEntretenimento
        '
        Me.CB_DigitalEntretenimento.BackColor = System.Drawing.Color.White
        Me.CB_DigitalEntretenimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_DigitalEntretenimento.FormattingEnabled = True
        Me.CB_DigitalEntretenimento.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CB_DigitalEntretenimento.Location = New System.Drawing.Point(731, 320)
        Me.CB_DigitalEntretenimento.Name = "CB_DigitalEntretenimento"
        Me.CB_DigitalEntretenimento.Size = New System.Drawing.Size(67, 21)
        Me.CB_DigitalEntretenimento.TabIndex = 24
        '
        'CB_DigitalMecanicas
        '
        Me.CB_DigitalMecanicas.BackColor = System.Drawing.Color.White
        Me.CB_DigitalMecanicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_DigitalMecanicas.FormattingEnabled = True
        Me.CB_DigitalMecanicas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CB_DigitalMecanicas.Location = New System.Drawing.Point(731, 258)
        Me.CB_DigitalMecanicas.Name = "CB_DigitalMecanicas"
        Me.CB_DigitalMecanicas.Size = New System.Drawing.Size(67, 21)
        Me.CB_DigitalMecanicas.TabIndex = 22
        '
        'CB_DigitalCriatividade
        '
        Me.CB_DigitalCriatividade.BackColor = System.Drawing.Color.White
        Me.CB_DigitalCriatividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_DigitalCriatividade.FormattingEnabled = True
        Me.CB_DigitalCriatividade.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CB_DigitalCriatividade.Location = New System.Drawing.Point(732, 197)
        Me.CB_DigitalCriatividade.Name = "CB_DigitalCriatividade"
        Me.CB_DigitalCriatividade.Size = New System.Drawing.Size(67, 21)
        Me.CB_DigitalCriatividade.TabIndex = 20
        '
        'CB_DigitalDesgn
        '
        Me.CB_DigitalDesgn.BackColor = System.Drawing.Color.White
        Me.CB_DigitalDesgn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_DigitalDesgn.FormattingEnabled = True
        Me.CB_DigitalDesgn.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CB_DigitalDesgn.Location = New System.Drawing.Point(732, 136)
        Me.CB_DigitalDesgn.Name = "CB_DigitalDesgn"
        Me.CB_DigitalDesgn.Size = New System.Drawing.Size(67, 21)
        Me.CB_DigitalDesgn.TabIndex = 18
        '
        'B_Voltar
        '
        Me.B_Voltar.BackColor = System.Drawing.Color.White
        Me.B_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_Voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Voltar.Location = New System.Drawing.Point(732, 32)
        Me.B_Voltar.Name = "B_Voltar"
        Me.B_Voltar.Size = New System.Drawing.Size(65, 23)
        Me.B_Voltar.TabIndex = 28
        Me.B_Voltar.Text = "Voltar"
        Me.B_Voltar.UseVisualStyleBackColor = False
        '
        'B_Salvar
        '
        Me.B_Salvar.BackColor = System.Drawing.Color.White
        Me.B_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Salvar.Location = New System.Drawing.Point(630, 32)
        Me.B_Salvar.Name = "B_Salvar"
        Me.B_Salvar.Size = New System.Drawing.Size(74, 23)
        Me.B_Salvar.TabIndex = 27
        Me.B_Salvar.Text = "Enviar"
        Me.B_Salvar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label3.Location = New System.Drawing.Point(698, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Observações:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label9.Location = New System.Drawing.Point(682, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Entretenimento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label10.Location = New System.Drawing.Point(715, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 20)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Mecânicas:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label11.Location = New System.Drawing.Point(709, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Criatividade:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label12.Location = New System.Drawing.Point(743, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Design:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label13.Location = New System.Drawing.Point(664, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 29)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Jogo digital:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label8.Location = New System.Drawing.Point(12, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Observações:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label7.Location = New System.Drawing.Point(12, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Entretenimento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label6.Location = New System.Drawing.Point(12, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Mecânicas:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label5.Location = New System.Drawing.Point(12, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Criatividade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label4.Location = New System.Drawing.Point(12, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Design:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label2.Location = New System.Drawing.Point(11, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 29)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jogo de mesa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome:"
        '
        'L_ErroNome
        '
        Me.L_ErroNome.AutoSize = True
        Me.L_ErroNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroNome.ForeColor = System.Drawing.Color.Red
        Me.L_ErroNome.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroNome.Location = New System.Drawing.Point(2, 35)
        Me.L_ErroNome.Name = "L_ErroNome"
        Me.L_ErroNome.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroNome.TabIndex = 29
        Me.L_ErroNome.Text = "*"
        '
        'L_ErroMesaObserva
        '
        Me.L_ErroMesaObserva.AutoSize = True
        Me.L_ErroMesaObserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroMesaObserva.ForeColor = System.Drawing.Color.Red
        Me.L_ErroMesaObserva.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroMesaObserva.Location = New System.Drawing.Point(2, 408)
        Me.L_ErroMesaObserva.Name = "L_ErroMesaObserva"
        Me.L_ErroMesaObserva.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroMesaObserva.TabIndex = 34
        Me.L_ErroMesaObserva.Text = "*"
        '
        'L_ErroMesaEntretenimento
        '
        Me.L_ErroMesaEntretenimento.AutoSize = True
        Me.L_ErroMesaEntretenimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroMesaEntretenimento.ForeColor = System.Drawing.Color.Red
        Me.L_ErroMesaEntretenimento.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroMesaEntretenimento.Location = New System.Drawing.Point(2, 324)
        Me.L_ErroMesaEntretenimento.Name = "L_ErroMesaEntretenimento"
        Me.L_ErroMesaEntretenimento.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroMesaEntretenimento.TabIndex = 33
        Me.L_ErroMesaEntretenimento.Text = "*"
        '
        'L_ErroMesaMecanicas
        '
        Me.L_ErroMesaMecanicas.AutoSize = True
        Me.L_ErroMesaMecanicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroMesaMecanicas.ForeColor = System.Drawing.Color.Red
        Me.L_ErroMesaMecanicas.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroMesaMecanicas.Location = New System.Drawing.Point(2, 261)
        Me.L_ErroMesaMecanicas.Name = "L_ErroMesaMecanicas"
        Me.L_ErroMesaMecanicas.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroMesaMecanicas.TabIndex = 32
        Me.L_ErroMesaMecanicas.Text = "*"
        '
        'L_ErroMesaCriatividade
        '
        Me.L_ErroMesaCriatividade.AutoSize = True
        Me.L_ErroMesaCriatividade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroMesaCriatividade.ForeColor = System.Drawing.Color.Red
        Me.L_ErroMesaCriatividade.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroMesaCriatividade.Location = New System.Drawing.Point(2, 201)
        Me.L_ErroMesaCriatividade.Name = "L_ErroMesaCriatividade"
        Me.L_ErroMesaCriatividade.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroMesaCriatividade.TabIndex = 31
        Me.L_ErroMesaCriatividade.Text = "*"
        '
        'L_ErroMesaDesign
        '
        Me.L_ErroMesaDesign.AutoSize = True
        Me.L_ErroMesaDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroMesaDesign.ForeColor = System.Drawing.Color.Red
        Me.L_ErroMesaDesign.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroMesaDesign.Location = New System.Drawing.Point(2, 140)
        Me.L_ErroMesaDesign.Name = "L_ErroMesaDesign"
        Me.L_ErroMesaDesign.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroMesaDesign.TabIndex = 30
        Me.L_ErroMesaDesign.Text = "*"
        '
        'L_ErroDigitalObserva
        '
        Me.L_ErroDigitalObserva.AutoSize = True
        Me.L_ErroDigitalObserva.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroDigitalObserva.ForeColor = System.Drawing.Color.Red
        Me.L_ErroDigitalObserva.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroDigitalObserva.Location = New System.Drawing.Point(800, 408)
        Me.L_ErroDigitalObserva.Name = "L_ErroDigitalObserva"
        Me.L_ErroDigitalObserva.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroDigitalObserva.TabIndex = 39
        Me.L_ErroDigitalObserva.Text = "*"
        '
        'L_ErroDigitalEntretenimento
        '
        Me.L_ErroDigitalEntretenimento.AutoSize = True
        Me.L_ErroDigitalEntretenimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroDigitalEntretenimento.ForeColor = System.Drawing.Color.Red
        Me.L_ErroDigitalEntretenimento.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroDigitalEntretenimento.Location = New System.Drawing.Point(800, 324)
        Me.L_ErroDigitalEntretenimento.Name = "L_ErroDigitalEntretenimento"
        Me.L_ErroDigitalEntretenimento.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroDigitalEntretenimento.TabIndex = 38
        Me.L_ErroDigitalEntretenimento.Text = "*"
        '
        'L_ErroDigitalMecanicas
        '
        Me.L_ErroDigitalMecanicas.AutoSize = True
        Me.L_ErroDigitalMecanicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroDigitalMecanicas.ForeColor = System.Drawing.Color.Red
        Me.L_ErroDigitalMecanicas.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroDigitalMecanicas.Location = New System.Drawing.Point(800, 261)
        Me.L_ErroDigitalMecanicas.Name = "L_ErroDigitalMecanicas"
        Me.L_ErroDigitalMecanicas.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroDigitalMecanicas.TabIndex = 37
        Me.L_ErroDigitalMecanicas.Text = "*"
        '
        'L_ErroDigitalCriatividade
        '
        Me.L_ErroDigitalCriatividade.AutoSize = True
        Me.L_ErroDigitalCriatividade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroDigitalCriatividade.ForeColor = System.Drawing.Color.Red
        Me.L_ErroDigitalCriatividade.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroDigitalCriatividade.Location = New System.Drawing.Point(800, 201)
        Me.L_ErroDigitalCriatividade.Name = "L_ErroDigitalCriatividade"
        Me.L_ErroDigitalCriatividade.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroDigitalCriatividade.TabIndex = 36
        Me.L_ErroDigitalCriatividade.Text = "*"
        '
        'L_ErroDigitalDesign
        '
        Me.L_ErroDigitalDesign.AutoSize = True
        Me.L_ErroDigitalDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_ErroDigitalDesign.ForeColor = System.Drawing.Color.Red
        Me.L_ErroDigitalDesign.Image = Global.WindowsApplication1.My.Resources.Resources.BackColor
        Me.L_ErroDigitalDesign.Location = New System.Drawing.Point(800, 140)
        Me.L_ErroDigitalDesign.Name = "L_ErroDigitalDesign"
        Me.L_ErroDigitalDesign.Size = New System.Drawing.Size(16, 20)
        Me.L_ErroDigitalDesign.TabIndex = 35
        Me.L_ErroDigitalDesign.Text = "*"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.AvaliacaoClear
        Me.PictureBox1.Location = New System.Drawing.Point(-14, -63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(855, 528)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Avaliacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 463)
        Me.Controls.Add(Me.B_Salvar)
        Me.Controls.Add(Me.B_Voltar)
        Me.Controls.Add(Me.TB_DigitalObserva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB_DigitalEntretenimento)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CB_DigitalMecanicas)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CB_DigitalCriatividade)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CB_DigitalDesgn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TB_MesaObserva)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CB_MesaEntretenimento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CB_MesaMecanicas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CB_MesaCriatividade)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CB_MesaDesign)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_ErroNome)
        Me.Controls.Add(Me.L_ErroMesaObserva)
        Me.Controls.Add(Me.L_ErroMesaEntretenimento)
        Me.Controls.Add(Me.L_ErroMesaMecanicas)
        Me.Controls.Add(Me.L_ErroMesaCriatividade)
        Me.Controls.Add(Me.L_ErroMesaDesign)
        Me.Controls.Add(Me.L_ErroDigitalObserva)
        Me.Controls.Add(Me.L_ErroDigitalEntretenimento)
        Me.Controls.Add(Me.L_ErroDigitalMecanicas)
        Me.Controls.Add(Me.L_ErroDigitalCriatividade)
        Me.Controls.Add(Me.L_ErroDigitalDesign)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Avaliacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avaliacao"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_Nome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CB_MesaDesign As System.Windows.Forms.ComboBox
    Friend WithEvents CB_MesaCriatividade As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CB_MesaMecanicas As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CB_MesaEntretenimento As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_MesaObserva As System.Windows.Forms.TextBox
    Friend WithEvents TB_DigitalObserva As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_DigitalEntretenimento As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CB_DigitalMecanicas As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CB_DigitalCriatividade As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CB_DigitalDesgn As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents B_Voltar As System.Windows.Forms.Button
    Friend WithEvents B_Salvar As System.Windows.Forms.Button
    Friend WithEvents L_ErroNome As System.Windows.Forms.Label
    Friend WithEvents L_ErroMesaDesign As System.Windows.Forms.Label
    Friend WithEvents L_ErroMesaCriatividade As System.Windows.Forms.Label
    Friend WithEvents L_ErroMesaMecanicas As System.Windows.Forms.Label
    Friend WithEvents L_ErroMesaEntretenimento As System.Windows.Forms.Label
    Friend WithEvents L_ErroMesaObserva As System.Windows.Forms.Label
    Friend WithEvents L_ErroDigitalObserva As System.Windows.Forms.Label
    Friend WithEvents L_ErroDigitalEntretenimento As System.Windows.Forms.Label
    Friend WithEvents L_ErroDigitalMecanicas As System.Windows.Forms.Label
    Friend WithEvents L_ErroDigitalCriatividade As System.Windows.Forms.Label
    Friend WithEvents L_ErroDigitalDesign As System.Windows.Forms.Label
End Class
