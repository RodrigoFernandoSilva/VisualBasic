<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaPrincipal))
        Me.B_Sair = New System.Windows.Forms.Button()
        Me.B_Quartos = New System.Windows.Forms.Button()
        Me.B_CheckOut = New System.Windows.Forms.Button()
        Me.B_CheckIn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.L_data = New System.Windows.Forms.Label()
        Me.L_hora = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B_Sair
        '
        Me.B_Sair.BackColor = System.Drawing.Color.White
        Me.B_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_Sair.Location = New System.Drawing.Point(410, 322)
        Me.B_Sair.Name = "B_Sair"
        Me.B_Sair.Size = New System.Drawing.Size(48, 23)
        Me.B_Sair.TabIndex = 23
        Me.B_Sair.Text = "Sair"
        Me.B_Sair.UseVisualStyleBackColor = False
        '
        'B_Quartos
        '
        Me.B_Quartos.BackColor = System.Drawing.Color.White
        Me.B_Quartos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_Quartos.Location = New System.Drawing.Point(112, 300)
        Me.B_Quartos.Name = "B_Quartos"
        Me.B_Quartos.Size = New System.Drawing.Size(75, 23)
        Me.B_Quartos.TabIndex = 22
        Me.B_Quartos.Text = "Quartos"
        Me.B_Quartos.UseVisualStyleBackColor = False
        '
        'B_CheckOut
        '
        Me.B_CheckOut.BackColor = System.Drawing.Color.White
        Me.B_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_CheckOut.Location = New System.Drawing.Point(69, 254)
        Me.B_CheckOut.Name = "B_CheckOut"
        Me.B_CheckOut.Size = New System.Drawing.Size(75, 23)
        Me.B_CheckOut.TabIndex = 21
        Me.B_CheckOut.Text = "Check out"
        Me.B_CheckOut.UseVisualStyleBackColor = False
        '
        'B_CheckIn
        '
        Me.B_CheckIn.BackColor = System.Drawing.Color.White
        Me.B_CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.B_CheckIn.Location = New System.Drawing.Point(29, 204)
        Me.B_CheckIn.Name = "B_CheckIn"
        Me.B_CheckIn.Size = New System.Drawing.Size(75, 23)
        Me.B_CheckIn.TabIndex = 20
        Me.B_CheckIn.Text = "Check in"
        Me.B_CheckIn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox1.Image = Global.Infinity_Hotel.My.Resources.Resources.Logo_Infinity_Hotel
        Me.PictureBox1.Location = New System.Drawing.Point(-17, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(513, 370)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
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
        Me.L_hora.Location = New System.Drawing.Point(412, 3)
        Me.L_hora.Name = "L_hora"
        Me.L_hora.Size = New System.Drawing.Size(55, 15)
        Me.L_hora.TabIndex = 227
        Me.L_hora.Text = "00:00:00"
        '
        'TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(469, 357)
        Me.Controls.Add(Me.L_data)
        Me.Controls.Add(Me.L_hora)
        Me.Controls.Add(Me.B_Sair)
        Me.Controls.Add(Me.B_Quartos)
        Me.Controls.Add(Me.B_CheckOut)
        Me.Controls.Add(Me.B_CheckIn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Infinity Hotel"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Sair As System.Windows.Forms.Button
    Friend WithEvents B_Quartos As System.Windows.Forms.Button
    Friend WithEvents B_CheckOut As System.Windows.Forms.Button
    Friend WithEvents B_CheckIn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents L_data As System.Windows.Forms.Label
    Friend WithEvents L_hora As System.Windows.Forms.Label
End Class
