<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SenhaAlteração
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SenhaAlteração))
        Me.M_senhaAlterar = New System.Windows.Forms.MaskedTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.B_Entrar = New System.Windows.Forms.Button()
        Me.L_data = New System.Windows.Forms.Label()
        Me.L_hora = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.B_Cancelar = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'M_senhaAlterar
        '
        Me.M_senhaAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_senhaAlterar.Location = New System.Drawing.Point(11, 158)
        Me.M_senhaAlterar.Name = "M_senhaAlterar"
        Me.M_senhaAlterar.Size = New System.Drawing.Size(179, 22)
        Me.M_senhaAlterar.TabIndex = 231
        Me.M_senhaAlterar.UseSystemPasswordChar = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'B_Entrar
        '
        Me.B_Entrar.BackColor = System.Drawing.Color.White
        Me.B_Entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.B_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_Entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Entrar.Location = New System.Drawing.Point(203, 158)
        Me.B_Entrar.Name = "B_Entrar"
        Me.B_Entrar.Size = New System.Drawing.Size(65, 23)
        Me.B_Entrar.TabIndex = 232
        Me.B_Entrar.Text = "Entrar"
        Me.B_Entrar.UseVisualStyleBackColor = False
        '
        'L_data
        '
        Me.L_data.AutoSize = True
        Me.L_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_data.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_data.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_data.Image = CType(resources.GetObject("L_data.Image"), System.Drawing.Image)
        Me.L_data.Location = New System.Drawing.Point(4, 3)
        Me.L_data.Name = "L_data"
        Me.L_data.Size = New System.Drawing.Size(69, 15)
        Me.L_data.TabIndex = 235
        Me.L_data.Text = "00/00/0000"
        '
        'L_hora
        '
        Me.L_hora.AutoSize = True
        Me.L_hora.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_hora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_hora.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.L_hora.Image = CType(resources.GetObject("L_hora.Image"), System.Drawing.Image)
        Me.L_hora.Location = New System.Drawing.Point(301, 3)
        Me.L_hora.Name = "L_hora"
        Me.L_hora.Size = New System.Drawing.Size(55, 15)
        Me.L_hora.TabIndex = 234
        Me.L_hora.Text = "00:00:00"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox2.Image = Global.Infinity_Hotel.My.Resources.Resources.Logo_Infinity_Hotel
        Me.PictureBox2.Location = New System.Drawing.Point(-11, -32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(377, 252)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 233
        Me.PictureBox2.TabStop = False
        '
        'B_Cancelar
        '
        Me.B_Cancelar.BackColor = System.Drawing.Color.White
        Me.B_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.B_Cancelar.Location = New System.Drawing.Point(280, 158)
        Me.B_Cancelar.Name = "B_Cancelar"
        Me.B_Cancelar.Size = New System.Drawing.Size(64, 23)
        Me.B_Cancelar.TabIndex = 236
        Me.B_Cancelar.Text = "Cancelar"
        Me.B_Cancelar.UseVisualStyleBackColor = False
        '
        'SenhaAlteração
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 203)
        Me.Controls.Add(Me.B_Cancelar)
        Me.Controls.Add(Me.L_data)
        Me.Controls.Add(Me.L_hora)
        Me.Controls.Add(Me.M_senhaAlterar)
        Me.Controls.Add(Me.B_Entrar)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SenhaAlteração"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Infinity Hotel"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L_data As System.Windows.Forms.Label
    Friend WithEvents L_hora As System.Windows.Forms.Label
    Friend WithEvents M_senhaAlterar As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents B_Entrar As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents B_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
End Class
