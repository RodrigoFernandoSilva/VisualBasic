Public Class SenhaAlteração
    Dim cad1(2) As String
    Dim cad2(2) As String
    Dim x As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        L_hora.Text = TimeString
    End Sub
    Private Sub M_senhaAlterar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles M_senhaAlterar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If M_senhaAlterar.Text = "1234" Then
                M_senhaAlterar.Clear()
                DadosDoHospede.Label45.Visible = True
                DadosDoHospede.L_novaDataDeCheckOut.Visible = True
                DadosDoHospede.L_novaDataDeCheckOut.Text = Quartos.cad(28).ToString
                DadosDoHospede.B_FazerAlteração.Enabled = False
                DadosDoHospede.T_Nome.Enabled = True
                DadosDoHospede.T_Email.Visible = False
                DadosDoHospede.M_TelefoneN.Visible = False
                DadosDoHospede.M_CelularN.Visible = False
                DadosDoHospede.T_Profissao.Enabled = True
                DadosDoHospede.T_nacionalidade.Visible = False
                DadosDoHospede.M_DataDeNascimento.Enabled = True
                DadosDoHospede.T_Genero.Visible = False
                DadosDoHospede.T_TipoDeDocumento.Visible = False
                DadosDoHospede.M_NdeDocumento.Enabled = True
                DadosDoHospede.M_OrgaoExpedidor.Enabled = True
                DadosDoHospede.T_ResidenciaPermanente.Enabled = True
                DadosDoHospede.M_ResidenciaPais.Visible = False
                DadosDoHospede.M_ResidenciaUF.Visible = False
                DadosDoHospede.M_residenciaPermCIDADE.Enabled = True
                DadosDoHospede.M_MotivoDaViagem.Visible = False
                DadosDoHospede.M_MeioDeTransporte.Visible = False
                DadosDoHospede.T_observação.Enabled = True
                DadosDoHospede.T_ProximoDestinoPAIS.Visible = False
                DadosDoHospede.T_ProximoDestinoCIDADE.Enabled = True
                DadosDoHospede.T_ProximoDestinoUF.Visible = False
                DadosDoHospede.B_SalvarAlteração.Enabled = True
                DadosDoHospede.T_UltimaProcCIDADE.Enabled = True

                DadosDoHospede.T_lerEMAIL.Visible = True
                DadosDoHospede.Label42.Visible = True
                DadosDoHospede.Label43.Visible = True
                DadosDoHospede.C_emailDominio.Visible = True
                DadosDoHospede.C_comEcombr.Visible = True
                DadosDoHospede.Label31.Visible = True
                DadosDoHospede.Label25.Visible = True
                DadosDoHospede.Label23.Visible = True
                DadosDoHospede.M_TelefoneDDD.Visible = True
                DadosDoHospede.T_TelefoneDDI.Visible = True
                DadosDoHospede.M_NewTelefone.Visible = True
                DadosDoHospede.Label41.Visible = True
                DadosDoHospede.Label37.Visible = True
                DadosDoHospede.Label32.Visible = True
                DadosDoHospede.M_CelularDDD.Visible = True
                DadosDoHospede.T_CelularDDI.Visible = True
                DadosDoHospede.M_NewCelular.Visible = True
                DadosDoHospede.C_Nacionalidade.Visible = True
                DadosDoHospede.C_Genero.Visible = True
                DadosDoHospede.C_ResidenciaPais.Visible = True
                DadosDoHospede.C_ResidenciaUF.Visible = True
                DadosDoHospede.C_ProximoDestinoPais.Visible = True
                DadosDoHospede.C_ProximoDestinoUF.Visible = True
                DadosDoHospede.C_UltimaProcedenciaPais.Visible = True
                DadosDoHospede.C_UltimaProcedenciaUF.Visible = True
                DadosDoHospede.C_PreferenciaQuarto.Visible = True
                DadosDoHospede.N_dias.Visible = True
                DadosDoHospede.C_MeioDeTransporte.Visible = True
                DadosDoHospede.C_MotivoDaViagem.Visible = True

                DadosDoHospede.C_MotivoDaViagem.Text = Quartos.cad(21)
                DadosDoHospede.C_MeioDeTransporte.Text = Quartos.cad(22)
                DadosDoHospede.C_ResidenciaPais.Text = Quartos.cad(12)
                DadosDoHospede.C_UltimaProcedenciaPais.Text = Quartos.cad(15)
                DadosDoHospede.C_ProximoDestinoPais.Text = Quartos.cad(18)
                DadosDoHospede.C_PreferenciaQuarto.Text = Quartos.cad(26)
                DadosDoHospede.C_Genero.Text = Quartos.cad(7)
                DadosDoHospede.C_Nacionalidade.Text = Quartos.cad(5)

                If Quartos.cad(16) <> "Brasil" Then
                    DadosDoHospede.T_UltimaProcUF.Text = Quartos.cad(16)
                    DadosDoHospede.C_UltimaProcedenciaUF.Visible = False
                    DadosDoHospede.T_UltimaProcUF.Visible = True
                    DadosDoHospede.T_UltimaProcUF.Enabled = True
                Else
                    DadosDoHospede.C_UltimaProcedenciaUF.Text = Quartos.cad(16)
                    DadosDoHospede.T_UltimaProcUF.Visible = False
                    DadosDoHospede.C_UltimaProcedenciaUF.Visible = True
                    DadosDoHospede.C_UltimaProcedenciaUF.Enabled = True
                End If

                If Quartos.cad(12) <> "Brasil" Then
                    DadosDoHospede.M_ResidenciaUF.Text = Quartos.cad(13)
                    DadosDoHospede.C_ResidenciaUF.Visible = False
                    DadosDoHospede.M_ResidenciaUF.Visible = True
                    DadosDoHospede.M_ResidenciaUF.Enabled = True
                Else
                    DadosDoHospede.C_ResidenciaUF.Text = Quartos.cad(13)
                    DadosDoHospede.M_ResidenciaUF.Visible = False
                    DadosDoHospede.C_ResidenciaUF.Visible = True
                    DadosDoHospede.C_ResidenciaUF.Enabled = True
                End If

                If Quartos.cad(18) <> "Brasil" Then
                    DadosDoHospede.T_ProximoDestinoUF.Text = Quartos.cad(19)
                    DadosDoHospede.C_ProximoDestinoUF.Visible = False
                    DadosDoHospede.T_ProximoDestinoUF.Visible = True
                    DadosDoHospede.T_ProximoDestinoUF.Enabled = True
                Else
                    DadosDoHospede.C_ProximoDestinoUF.Text = Quartos.cad(19)
                    DadosDoHospede.T_ProximoDestinoUF.Visible = False
                    DadosDoHospede.C_ProximoDestinoUF.Visible = True
                    DadosDoHospede.C_ProximoDestinoUF.Enabled = True
                End If

                cad1 = DadosDoHospede.T_Email.Text.Split("@")
                cad2 = cad1(1).Split(".")
                DadosDoHospede.T_lerEMAIL.Text = cad1(0)
                DadosDoHospede.C_emailDominio.Text = cad2(0)
                DadosDoHospede.C_comEcombr.Text = cad2(1)

                cad1 = DadosDoHospede.M_TelefoneN.Text.Split(")")
                cad2 = cad1(0).Split("(")
                DadosDoHospede.T_TelefoneDDI.Text = cad2(0)
                DadosDoHospede.M_TelefoneDDD.Text = cad2(1)
                DadosDoHospede.M_NewTelefone.Text = cad1(1)

                cad1 = DadosDoHospede.M_CelularN.Text.Split(")")
                cad2 = cad1(0).Split("(")
                DadosDoHospede.T_CelularDDI.Text = cad2(0)
                DadosDoHospede.M_CelularDDD.Text = cad2(1)
                DadosDoHospede.M_NewCelular.Text = cad1(1)
                M_senhaAlterar.Clear()

                DadosDoHospede.M_DataDeNascimento.Mask = "00/00/0000"

                DadosDoHospede.C_tipoDeDocumento.Visible = True
                DadosDoHospede.C_tipoDeDocumento.Text = Quartos.cad(8)

                If DadosDoHospede.C_tipoDeDocumento.Text = "CPF" Then
                    DadosDoHospede.M_NdeDocumento.Mask = "000.000.000-00"
                    DadosDoHospede.M_NdeDocumento.Text = Quartos.cad(9)
                Else
                    DadosDoHospede.M_NdeDocumento.Mask = ""
                    DadosDoHospede.M_NdeDocumento.Text = Quartos.cad(9)
                End If

                DadosDoHospede.L_ValorAcrecental_RS.Visible = True
                DadosDoHospede.L_ValorAcrecental.Visible = True

                DadosDoHospede.B_Voltar.Text = "Cancelar"

                ActiveControl = M_senhaAlterar
                DadosDoHospede.Enabled = True
                DadosDoHospede.Show()
                Me.Hide()
            Else
                M_senhaAlterar.Clear()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            ActiveControl = M_senhaAlterar
            M_senhaAlterar.Clear()
            DadosDoHospede.Enabled = True
            DadosDoHospede.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub B_Entrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Entrar.Click
        If M_senhaAlterar.Text = "1234" Then

            M_senhaAlterar.Clear()

            DadosDoHospede.B_FazerAlteração.Enabled = False
            DadosDoHospede.T_Nome.Enabled = True
            DadosDoHospede.T_Email.Visible = False
            DadosDoHospede.M_TelefoneN.Visible = False
            DadosDoHospede.M_CelularN.Visible = False
            DadosDoHospede.T_Profissao.Enabled = True
            DadosDoHospede.T_nacionalidade.Visible = False
            DadosDoHospede.M_DataDeNascimento.Enabled = True
            DadosDoHospede.T_Genero.Visible = False
            DadosDoHospede.T_TipoDeDocumento.Visible = False
            DadosDoHospede.M_NdeDocumento.Enabled = True
            DadosDoHospede.M_OrgaoExpedidor.Enabled = True
            DadosDoHospede.T_ResidenciaPermanente.Enabled = True
            DadosDoHospede.M_ResidenciaPais.Visible = False
            DadosDoHospede.M_ResidenciaUF.Visible = False
            DadosDoHospede.M_residenciaPermCIDADE.Enabled = True
            DadosDoHospede.M_MotivoDaViagem.Visible = False
            DadosDoHospede.M_MeioDeTransporte.Visible = False
            DadosDoHospede.T_observação.Enabled = True
            DadosDoHospede.T_ProximoDestinoPAIS.Visible = False
            DadosDoHospede.T_ProximoDestinoCIDADE.Enabled = True
            DadosDoHospede.T_ProximoDestinoUF.Visible = False
            DadosDoHospede.B_SalvarAlteração.Enabled = True
            DadosDoHospede.T_UltimaProcCIDADE.Enabled = True

            DadosDoHospede.T_lerEMAIL.Visible = True
            DadosDoHospede.Label42.Visible = True
            DadosDoHospede.Label43.Visible = True
            DadosDoHospede.C_emailDominio.Visible = True
            DadosDoHospede.C_comEcombr.Visible = True
            DadosDoHospede.Label31.Visible = True
            DadosDoHospede.Label25.Visible = True
            DadosDoHospede.Label23.Visible = True
            DadosDoHospede.M_TelefoneDDD.Visible = True
            DadosDoHospede.T_TelefoneDDI.Visible = True
            DadosDoHospede.M_NewTelefone.Visible = True
            DadosDoHospede.Label41.Visible = True
            DadosDoHospede.Label37.Visible = True
            DadosDoHospede.Label32.Visible = True
            DadosDoHospede.M_CelularDDD.Visible = True
            DadosDoHospede.T_CelularDDI.Visible = True
            DadosDoHospede.M_NewCelular.Visible = True
            DadosDoHospede.C_Nacionalidade.Visible = True
            DadosDoHospede.C_Genero.Visible = True
            DadosDoHospede.C_ResidenciaPais.Visible = True
            DadosDoHospede.C_ResidenciaUF.Visible = True
            DadosDoHospede.C_ProximoDestinoPais.Visible = True
            DadosDoHospede.C_ProximoDestinoUF.Visible = True
            DadosDoHospede.C_UltimaProcedenciaPais.Visible = True
            DadosDoHospede.C_UltimaProcedenciaUF.Visible = True
            DadosDoHospede.C_PreferenciaQuarto.Visible = True
            DadosDoHospede.N_dias.Visible = True
            DadosDoHospede.C_MeioDeTransporte.Visible = True
            DadosDoHospede.C_MotivoDaViagem.Visible = True

            DadosDoHospede.C_MotivoDaViagem.Text = Quartos.cad(21)
            DadosDoHospede.C_MeioDeTransporte.Text = Quartos.cad(22)
            DadosDoHospede.C_ResidenciaPais.Text = Quartos.cad(12)
            DadosDoHospede.C_UltimaProcedenciaPais.Text = Quartos.cad(15)
            DadosDoHospede.C_ProximoDestinoPais.Text = Quartos.cad(18)
            DadosDoHospede.C_PreferenciaQuarto.Text = Quartos.cad(26)
            DadosDoHospede.C_Genero.Text = Quartos.cad(7)
            DadosDoHospede.C_Nacionalidade.Text = Quartos.cad(5)

            If Quartos.cad(16) <> "Brasil" Then
                DadosDoHospede.T_UltimaProcUF.Text = Quartos.cad(16)
                DadosDoHospede.C_UltimaProcedenciaUF.Visible = False
                DadosDoHospede.T_UltimaProcUF.Visible = True
                DadosDoHospede.T_UltimaProcUF.Enabled = True
            Else
                DadosDoHospede.C_UltimaProcedenciaUF.Text = Quartos.cad(16)
                DadosDoHospede.T_UltimaProcUF.Visible = False
                DadosDoHospede.C_UltimaProcedenciaUF.Visible = True
                DadosDoHospede.C_UltimaProcedenciaUF.Enabled = True
            End If

            If Quartos.cad(12) <> "Brasil" Then
                DadosDoHospede.M_ResidenciaUF.Text = Quartos.cad(13)
                DadosDoHospede.C_ResidenciaUF.Visible = False
                DadosDoHospede.M_ResidenciaUF.Visible = True
                DadosDoHospede.M_ResidenciaUF.Enabled = True
            Else
                DadosDoHospede.C_ResidenciaUF.Text = Quartos.cad(13)
                DadosDoHospede.M_ResidenciaUF.Visible = False
                DadosDoHospede.C_ResidenciaUF.Visible = True
                DadosDoHospede.C_ResidenciaUF.Enabled = True
            End If

            If Quartos.cad(18) <> "Brasil" Then
                DadosDoHospede.T_ProximoDestinoUF.Text = Quartos.cad(19)
                DadosDoHospede.C_ProximoDestinoUF.Visible = False
                DadosDoHospede.T_ProximoDestinoUF.Visible = True
                DadosDoHospede.T_ProximoDestinoUF.Enabled = True
            Else
                DadosDoHospede.C_ProximoDestinoUF.Text = Quartos.cad(19)
                DadosDoHospede.T_ProximoDestinoUF.Visible = False
                DadosDoHospede.C_ProximoDestinoUF.Visible = True
                DadosDoHospede.C_ProximoDestinoUF.Enabled = True
            End If

            cad1 = DadosDoHospede.T_Email.Text.Split("@")
            cad2 = cad1(1).Split(".")
            DadosDoHospede.T_lerEMAIL.Text = cad1(0)
            DadosDoHospede.C_emailDominio.Text = cad2(0)
            DadosDoHospede.C_comEcombr.Text = cad2(1)

            cad1 = DadosDoHospede.M_TelefoneN.Text.Split(")")
            cad2 = cad1(0).Split("(")
            DadosDoHospede.T_TelefoneDDI.Text = cad2(0)
            DadosDoHospede.M_TelefoneDDD.Text = cad2(1)
            DadosDoHospede.M_NewTelefone.Text = cad1(1)

            cad1 = DadosDoHospede.M_CelularN.Text.Split(")")
            cad2 = cad1(0).Split("(")
            DadosDoHospede.T_CelularDDI.Text = cad2(0)
            DadosDoHospede.M_CelularDDD.Text = cad2(1)
            DadosDoHospede.M_NewCelular.Text = cad1(1)
            M_senhaAlterar.Clear()

            DadosDoHospede.M_DataDeNascimento.Mask = "00/00/0000"
            DadosDoHospede.C_tipoDeDocumento.Visible = True
            DadosDoHospede.C_tipoDeDocumento.Text = Quartos.cad(8)
            If DadosDoHospede.C_tipoDeDocumento.Text = "CPF" Then
                DadosDoHospede.M_NdeDocumento.Mask = "000.000.000-00"
            Else
                DadosDoHospede.M_NdeDocumento.Mask = ""
            End If

            DadosDoHospede.L_ValorAcrecental_RS.Visible = True
            DadosDoHospede.L_ValorAcrecental.Visible = True

            DadosDoHospede.B_Voltar.Text = "Cancelar"

            ActiveControl = M_senhaAlterar
            DadosDoHospede.Show()
            Me.Hide()
        Else
            M_senhaAlterar.Clear()
        End If

    End Sub

    Private Sub SenhaAlteração_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ActiveControl = M_senhaAlterar
        M_senhaAlterar.Clear()
        DadosDoHospede.Enabled = True
        DadosDoHospede.Show()
        Me.Hide()
    End Sub

    Private Sub SenhaAlteração_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        L_data.Text = Today
    End Sub

    Private Sub B_Cancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Cancelar.Click
        ActiveControl = M_senhaAlterar
        M_senhaAlterar.Clear()
        DadosDoHospede.Enabled = True
        DadosDoHospede.Show()
        Me.Hide()
    End Sub
End Class