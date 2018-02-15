<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckOut))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C_TipoDeDocumento = New System.Windows.Forms.ComboBox()
        Me.M_Nome = New System.Windows.Forms.MaskedTextBox()
        Me.M_CPF_PASSAPORTE = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.T_CPF_PASSAPORTE = New System.Windows.Forms.TextBox()
        Me.L_TipoDeDocumentoERRO = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.L_NomeERRO = New System.Windows.Forms.Label()
        Me.L_CPF_PASSAPORTEerro = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.L_data = New System.Windows.Forms.Label()
        Me.L_hora = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Check Out"
        '
        'C_TipoDeDocumento
        '
        Me.C_TipoDeDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_TipoDeDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.C_TipoDeDocumento.FormattingEnabled = True
        Me.C_TipoDeDocumento.Items.AddRange(New Object() {"CPF", "PASSAPORTE"})
        Me.C_TipoDeDocumento.Location = New System.Drawing.Point(96, 181)
        Me.C_TipoDeDocumento.Name = "C_TipoDeDocumento"
        Me.C_TipoDeDocumento.Size = New System.Drawing.Size(248, 21)
        Me.C_TipoDeDocumento.TabIndex = 1
        '
        'M_Nome
        '
        Me.M_Nome.Location = New System.Drawing.Point(95, 125)
        Me.M_Nome.Name = "M_Nome"
        Me.M_Nome.Size = New System.Drawing.Size(250, 20)
        Me.M_Nome.TabIndex = 0
        '
        'M_CPF_PASSAPORTE
        '
        Me.M_CPF_PASSAPORTE.Enabled = False
        Me.M_CPF_PASSAPORTE.Location = New System.Drawing.Point(14, 245)
        Me.M_CPF_PASSAPORTE.Mask = "000.000.000-00"
        Me.M_CPF_PASSAPORTE.Name = "M_CPF_PASSAPORTE"
        Me.M_CPF_PASSAPORTE.Size = New System.Drawing.Size(331, 20)
        Me.M_CPF_PASSAPORTE.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(181, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 152
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(269, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 153
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'T_CPF_PASSAPORTE
        '
        Me.T_CPF_PASSAPORTE.Location = New System.Drawing.Point(14, 246)
        Me.T_CPF_PASSAPORTE.Name = "T_CPF_PASSAPORTE"
        Me.T_CPF_PASSAPORTE.Size = New System.Drawing.Size(331, 20)
        Me.T_CPF_PASSAPORTE.TabIndex = 158
        Me.T_CPF_PASSAPORTE.Visible = False
        '
        'L_TipoDeDocumentoERRO
        '
        Me.L_TipoDeDocumentoERRO.AutoSize = True
        Me.L_TipoDeDocumentoERRO.ForeColor = System.Drawing.Color.Red
        Me.L_TipoDeDocumentoERRO.Image = CType(resources.GetObject("L_TipoDeDocumentoERRO.Image"), System.Drawing.Image)
        Me.L_TipoDeDocumentoERRO.Location = New System.Drawing.Point(96, 203)
        Me.L_TipoDeDocumentoERRO.Name = "L_TipoDeDocumentoERRO"
        Me.L_TipoDeDocumentoERRO.Size = New System.Drawing.Size(117, 13)
        Me.L_TipoDeDocumentoERRO.TabIndex = 157
        Me.L_TipoDeDocumentoERRO.Text = "Erro tipo de documento"
        Me.L_TipoDeDocumentoERRO.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(11, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "CPF / PASSAPORTE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(93, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(93, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 15)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Tipo de documento:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Infinity_Hotel.My.Resources.Resources.Nova_Imagem_de_Bitmap
        Me.PictureBox1.Location = New System.Drawing.Point(11, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 143
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox2.Image = Global.Infinity_Hotel.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(56, -26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(244, 156)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 142
        Me.PictureBox2.TabStop = False
        '
        'L_NomeERRO
        '
        Me.L_NomeERRO.AutoSize = True
        Me.L_NomeERRO.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_NomeERRO.ForeColor = System.Drawing.Color.Red
        Me.L_NomeERRO.Image = CType(resources.GetObject("L_NomeERRO.Image"), System.Drawing.Image)
        Me.L_NomeERRO.Location = New System.Drawing.Point(96, 145)
        Me.L_NomeERRO.Name = "L_NomeERRO"
        Me.L_NomeERRO.Size = New System.Drawing.Size(57, 13)
        Me.L_NomeERRO.TabIndex = 154
        Me.L_NomeERRO.Text = "Erro Nome"
        Me.L_NomeERRO.Visible = False
        '
        'L_CPF_PASSAPORTEerro
        '
        Me.L_CPF_PASSAPORTEerro.AutoSize = True
        Me.L_CPF_PASSAPORTEerro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_CPF_PASSAPORTEerro.ForeColor = System.Drawing.Color.Red
        Me.L_CPF_PASSAPORTEerro.Image = CType(resources.GetObject("L_CPF_PASSAPORTEerro.Image"), System.Drawing.Image)
        Me.L_CPF_PASSAPORTEerro.Location = New System.Drawing.Point(13, 267)
        Me.L_CPF_PASSAPORTEerro.Name = "L_CPF_PASSAPORTEerro"
        Me.L_CPF_PASSAPORTEerro.Size = New System.Drawing.Size(105, 13)
        Me.L_CPF_PASSAPORTEerro.TabIndex = 156
        Me.L_CPF_PASSAPORTEerro.Text = "Erro CPF Passaporte"
        Me.L_CPF_PASSAPORTEerro.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox3.Image = Global.Infinity_Hotel.My.Resources.Resources.Plano_de_fundo
        Me.PictureBox3.Location = New System.Drawing.Point(-3, -20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(376, 365)
        Me.PictureBox3.TabIndex = 159
        Me.PictureBox3.TabStop = False
        '
        'L_data
        '
        Me.L_data.AutoSize = True
        Me.L_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_data.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_data.Image = CType(resources.GetObject("L_data.Image"), System.Drawing.Image)
        Me.L_data.Location = New System.Drawing.Point(4, 1)
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
        Me.L_hora.Location = New System.Drawing.Point(297, 1)
        Me.L_hora.Name = "L_hora"
        Me.L_hora.Size = New System.Drawing.Size(55, 15)
        Me.L_hora.TabIndex = 227
        Me.L_hora.Text = "00:00:00"
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 319)
        Me.Controls.Add(Me.L_data)
        Me.Controls.Add(Me.L_hora)
        Me.Controls.Add(Me.L_TipoDeDocumentoERRO)
        Me.Controls.Add(Me.C_TipoDeDocumento)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.M_Nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.L_NomeERRO)
        Me.Controls.Add(Me.L_CPF_PASSAPORTEerro)
        Me.Controls.Add(Me.T_CPF_PASSAPORTE)
        Me.Controls.Add(Me.M_CPF_PASSAPORTE)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CheckOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Infinity Hotel"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C_TipoDeDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents M_Nome As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents M_CPF_PASSAPORTE As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents L_NomeERRO As System.Windows.Forms.Label
    Friend WithEvents L_CPF_PASSAPORTEerro As System.Windows.Forms.Label
    Friend WithEvents L_TipoDeDocumentoERRO As System.Windows.Forms.Label
    Friend WithEvents T_CPF_PASSAPORTE As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents L_data As System.Windows.Forms.Label
    Friend WithEvents L_hora As System.Windows.Forms.Label
End Class
