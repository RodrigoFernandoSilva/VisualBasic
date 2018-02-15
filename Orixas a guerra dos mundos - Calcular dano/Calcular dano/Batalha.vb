Public Class Batalhar

    Dim AiyeAtaque As Integer = 0
    Dim AiyeVida As Integer = 0
    Dim AiyeI As Integer = 0
    Dim OrumAtaque As Integer = 0
    Dim OrumVida As Integer = 0
    Dim OrumI As Integer = 0
    Dim dano As Integer = 0
    Dim Porcentagem As Decimal = 0.0
    Dim BonusVida As Integer = 10
    Dim BonusAtaque As Integer = 10

    Function AiyeAtacer()
        If Not MasB_AiyeDado.Text = Nothing And MasB_AiyeDado.Text >= 0 Then
            dano = AtaqueFunction(Int(MasB_AiyeDado.Text), AiyeAtaque)
            OrumVida -= dano
            If OrumVida <= 0 Then
                ProB_Vida_Orum.Value = 0
                MessageBox.Show(MenuPrin.ComB_AiyeNames.Items(AiyeI) + " é o vencedor!!!")
                MenuPrin.Show()
                MenuPrin.AiyeVidas(AiyeI) = AiyeVida
                MenuPrin.OrumVidas(OrumI) = 0
                MenuPrin.ComboBoxPrinLife()
                Me.Close()
                Return 0
            End If
            ProB_Vida_Orum.Value = OrumVida
            MasB_AiyeDado.Clear()
            DisableAiye()
        Else
            MasB_AiyeDado.Clear()
            MasB_AiyeDado.SelectAll()
            ActiveControl = MasB_AiyeDado
        End If
        AtualizarLabels()
        Return 0
    End Function

    Function OrumAtacar()
        If Not MasB_OrumDado.Text = Nothing And MasB_OrumDado.Text >= 0 Then
            dano = AtaqueFunction(Int(MasB_OrumDado.Text), OrumAtaque)
            AiyeVida -= dano
            If AiyeVida <= 0 Then
                ProB_Vida_Aiye.Value = 0
                MessageBox.Show(MenuPrin.ComB_OrumNames.Items(OrumI) + " é o vencedor!!!")
                MenuPrin.OrumVidas(OrumI) = OrumVida
                MenuPrin.AiyeVidas(AiyeI) = 0
                MenuPrin.Show()
                MenuPrin.ComboBoxPrinLife()
                Me.Close()
                Return 0
            End If
            ProB_Vida_Aiye.Value = AiyeVida
            MasB_OrumDado.Clear()
            DisableOrum()
        Else
            MasB_OrumDado.Clear()
            MasB_OrumDado.SelectAll()
            ActiveControl = MasB_OrumDado
        End If
        AtualizarLabels()
        Return 0
    End Function

    Function Aredondar(ByVal Valor As Decimal)
        Dim cad(2) As String
        cad = Split(Valor)
        Return Int(cad(0))
    End Function

    Function AtaqueFunction(ByVal dado As Integer, ByVal Ataque As Integer)
        Porcentagem = (Ataque * dado) / 100
        If Porcentagem.ToString.Contains(",") Then
            Porcentagem = Aredondar(Porcentagem)
        End If
        Return dado + Porcentagem
    End Function

    Function DisableOrum()
        MasB_AiyeDado.Visible = True
        MasB_AiyeDado.Enabled = True
        L_AiyeDado.Visible = True
        B_AiyeAtacar.Visible = True
        B_AiyeAtacar.Enabled = True

        MasB_AiyeDado.SelectAll()
        ActiveControl = MasB_AiyeDado

        MasB_OrumDado.Visible = False
        MasB_OrumDado.Enabled = False
        L_OrumDado.Visible = False
        B_OrumAtachar.Visible = False
        B_OrumAtachar.Enabled = False

        Return 0
    End Function

    Function DisableAiye()
        MasB_OrumDado.Visible = True
        MasB_OrumDado.Enabled = True
        L_OrumDado.Visible = True
        B_OrumAtachar.Visible = True
        B_OrumAtachar.Enabled = True

        MasB_OrumDado.SelectAll()
        ActiveControl = MasB_OrumDado

        MasB_AiyeDado.Visible = False
        MasB_AiyeDado.Enabled = False
        L_AiyeDado.Visible = False
        B_AiyeAtacar.Visible = False
        B_AiyeAtacar.Enabled = False
        Return 0
    End Function

    Function AtualizarLabels()
        If MenuPrin.CheB_BonusAiye.Checked = True Then
            L_VidaAiye.Text = "Vida: " & AiyeVida.ToString & "/" & Vida.Items(AiyeI) + 10 & "             Ataque: " & AiyeAtaque.ToString & "%"
        Else
            L_VidaAiye.Text = "Vida: " & AiyeVida.ToString & "/" & Vida.Items(AiyeI) & "             Ataque: " & AiyeAtaque.ToString & "%"
        End If

        If MenuPrin.CheB_BonusOrum.Checked = True Then
            L_VidaOrum.Text = "Vida: " & OrumVida.ToString & "/" & Vida.Items(OrumI) + 10 & "             Ataque: " & OrumAtaque.ToString & "%"
        Else
            L_VidaOrum.Text = "Vida: " & OrumVida.ToString & "/" & Vida.Items(OrumI) & "             Ataque: " & OrumAtaque.ToString & "%"
        End If

        Return 0
    End Function

    Private Sub Batalha_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MenuPrin.Show()
    End Sub

    Private Sub Batalha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AiyeAtaque = 0
        AiyeVida = 0
        AiyeI = MenuPrin.ComB_Aiye.SelectedIndex
        OrumAtaque = 0
        OrumVida = 0
        OrumI = MenuPrin.ComB_Orum.SelectedIndex

        PicB_Orum.Image = MenuPrin.PicB_Orum.Image
        PicB_Aiye.Image = MenuPrin.PicB_Aiye.Image

        L_VidaOrum.Text = Nothing
        L_VidaAiye.Text = Nothing
        OrumVida += MenuPrin.OrumVidas(OrumI)
        OrumAtaque += Ataque.Items(OrumI)

        AiyeVida += MenuPrin.AiyeVidas(AiyeI)
        AiyeAtaque += Ataque.Items(AiyeI)

        If MenuPrin.CheB_BonusOrum.Checked = True Then
            OrumVida += BonusVida
            OrumAtaque += BonusAtaque
            ProB_Vida_Orum.Maximum = Vida.Items(OrumI) + BonusVida
        Else
            ProB_Vida_Orum.Maximum = Vida.Items(OrumI)
        End If
        If MenuPrin.CheB_BonusAiye.Checked = True Then
            AiyeVida += BonusVida
            AiyeAtaque += BonusVida
            ProB_Vida_Aiye.Maximum = Vida.Items(AiyeI) + BonusVida
        Else
            ProB_Vida_Aiye.Maximum = Vida.Items(AiyeI)
        End If

        ProB_Vida_Orum.Value = OrumVida


        ProB_Vida_Aiye.Value = AiyeVida

        If MenuPrin.RadB_AtkOrum.Checked = True Then
            DisableAiye()
        Else
            DisableOrum()
        End If

        AtualizarLabels()
    End Sub

    Private Sub B_OrumAtachar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_OrumAtachar.Click
        OrumAtacar()
    End Sub

    Private Sub B_AiyeAtacar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_AiyeAtacar.Click
        AiyeAtacer()
    End Sub

    Private Sub MasB_OrumDado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MasB_OrumDado.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            OrumAtacar()
        End If
    End Sub

    Private Sub MasB_AiyeDado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MasB_AiyeDado.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            AiyeAtacer()
        End If
    End Sub
End Class