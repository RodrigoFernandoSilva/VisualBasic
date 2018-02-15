Public Class DadosDoHospede
    Dim linha As String
    Dim x As Integer
    Dim x1 As Integer
    Dim cad(30) As String
    Dim cad1(3) As String
    Dim streamREADER As IO.StreamReader
    Dim streamWRITE As IO.StreamWriter
    Dim total As Integer = 0
    Dim dia As Integer = 0
    Dim mes As Integer = 0
    Dim ano As Integer = 0
    Private Sub B_Voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Voltar.Click
        N_dias.Value = 0
        Label45.Visible = False
        L_novaDataDeCheckOut.Visible = False
        L_ValorAcrecental.Visible = False
        L_ValorAcrecental_RS.Visible = False
        B_Voltar.Text = "Voltar"
        B_FazerAlteração.Enabled = True

        T_lerEMAIL.Visible = False
        Label43.Visible = False
        C_emailDominio.Visible = False
        Label42.Visible = False
        C_comEcombr.Visible = False
        Label31.Visible = False
        T_TelefoneDDI.Visible = False
        Label25.Visible = False
        M_TelefoneDDD.Visible = False
        Label23.Visible = False
        M_NewTelefone.Visible = False
        Label41.Visible = False
        T_CelularDDI.Visible = False
        Label37.Visible = False
        M_CelularDDD.Visible = False
        Label32.Visible = False
        M_NewCelular.Visible = False
        C_Nacionalidade.Visible = False
        M_DataDeNascimento.Mask = ""
        C_Genero.Visible = False
        C_tipoDeDocumento.Visible = False
        M_NdeDocumento.Mask = ""
        C_ResidenciaPais.Visible = False
        C_ResidenciaUF.Visible = False
        M_ResidenciaUF.Visible = True
        C_UltimaProcedenciaPais.Visible = False
        C_UltimaProcedenciaUF.Visible = False
        T_UltimaProcUF.Visible = True
        N_dias.Visible = False
        C_PreferenciaQuarto.Visible = False
        C_MotivoDaViagem.Visible = False
        C_MeioDeTransporte.Visible = False
        C_ProximoDestinoPais.Visible = False
        C_ProximoDestinoUF.Visible = False
        T_ProximoDestinoUF.Visible = False
        B_SalvarAlteração.Enabled = False


        T_Nome.Enabled = False
        T_Email.Enabled = False
        T_Email.Visible = True
        M_CelularN.Enabled = False
        M_CelularN.Visible = True
        M_TelefoneN.Enabled = False
        M_TelefoneN.Visible = True
        T_nacionalidade.Visible = True
        T_nacionalidade.Enabled = False
        T_Genero.Visible = True
        T_Genero.Enabled = False
        T_TipoDeDocumento.Enabled = False
        T_TipoDeDocumento.Visible = True
        M_ResidenciaPais.Enabled = False
        M_ResidenciaPais.Visible = True
        M_ResidenciaUF.Visible = True
        M_ResidenciaUF.Enabled = False
        M_MeioDeTransporte.Visible = True
        M_MeioDeTransporte.Enabled = False
        M_MotivoDaViagem.Visible = True
        M_MotivoDaViagem.Enabled = False
        T_ProximoDestinoPAIS.Visible = True
        T_ProximoDestinoPAIS.Enabled = False
        T_ProximoDestinoUF.Enabled = False
        T_ProximoDestinoUF.Visible = True
        M_DataDeNascimento.Enabled = False
        M_residenciaPermCIDADE.Enabled = False
        T_UltimaProcCIDADE.Enabled = False
        T_ProximoDestinoCIDADE.Enabled = False
        T_Profissao.Enabled = False
        M_NdeDocumento.Enabled = False
        M_OrgaoExpedidor.Enabled = False
        T_ResidenciaPermanente.Enabled = False
        T_UltimaProcUF.Enabled = False
        T_observação.Enabled = False
        Quartos.Show()
        Me.Hide()
    End Sub

    Private Sub DadosDoHospede_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        L_hora.Text = TimeString
    End Sub

    Private Sub B_FazerAlteração_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_FazerAlteração.Click
        C_PreferenciaQuarto.Items.Clear()
        For index = 1 To 50
            streamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
            While Not streamREADER.EndOfStream
                linha = streamREADER.ReadLine()
                cad = linha.Split(";")
                If index.ToString = L_preferenciaDeQuarto.Text Then
                    C_PreferenciaQuarto.Items.Add(index.ToString + " - Seu Quarto")
                    x = 9
                    Exit While
                ElseIf cad(26) = index.ToString Then
                    C_PreferenciaQuarto.Items.Add(index.ToString + " - Ocupado")
                    x = 9
                End If
            End While
            If x <> 9 Then
                C_PreferenciaQuarto.Items.Add(index)
            End If
            x = 0
            streamREADER.Close()
        Next
        C_PreferenciaQuarto.Text = (L_preferenciaDeQuarto.Text + " - Seu Quarto")
        Me.Enabled = False
        SenhaAlteração.Show()
    End Sub

  

    Private Sub C_ResidenciaPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_ResidenciaPais.SelectedIndexChanged
        If C_ResidenciaPais.Text <> "Brasil" Then
            M_ResidenciaUF.Clear()
            C_ResidenciaUF.Visible = False
            M_ResidenciaUF.Visible = True
            M_ResidenciaUF.Enabled = True
        Else
            M_ResidenciaUF.Clear()
            M_ResidenciaUF.Visible = False
            C_ResidenciaUF.Visible = True
            C_ResidenciaUF.Enabled = True
        End If
    End Sub

    Private Sub C_UltimaProcedenciaPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_UltimaProcedenciaPais.SelectedIndexChanged
        If C_UltimaProcedenciaPais.Text <> "Brasil" Then
            T_UltimaProcUF.Clear()
            C_UltimaProcedenciaUF.Visible = False
            T_UltimaProcUF.Visible = True
            T_UltimaProcUF.Enabled = True
        Else
            T_UltimaProcUF.Clear()
            T_UltimaProcUF.Visible = False
            C_UltimaProcedenciaUF.Visible = True
            C_UltimaProcedenciaUF.Enabled = True
        End If
    End Sub

    Private Sub B_SalvarAlteração_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_SalvarAlteração.Click
        If IO.File.Exists("Infinity Hotel.REGISTRO") Then
            streamWRITE = New IO.StreamWriter("new.txt")
            streamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
            While Not streamREADER.EndOfStream
                linha = streamREADER.ReadLine()
                cad = linha.Split(";")
                If cad(26) = L_preferenciaDeQuarto.Text Then
                    If C_PreferenciaQuarto.Text.Contains(" - Seu Quarto") Then
                        C_PreferenciaQuarto.Items.Add(L_preferenciaDeQuarto.Text)
                        C_PreferenciaQuarto.Text = L_preferenciaDeQuarto.Text
                    End If
                    If MessageBox.Show("Comfirmar alteração de rigistro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                        streamREADER.Close()
                        streamWRITE.Close()
                        IO.File.Delete("new.txt")
                        Exit Sub
                    End If
                    streamWRITE.Write(T_Nome.Text + ";" + T_lerEMAIL.Text + "@" + C_emailDominio.Text + "." + C_comEcombr.Text + ";" + T_TelefoneDDI.Text + "(" + M_TelefoneDDD.Text + ")" + M_NewTelefone.Text + ";" + T_CelularDDI.Text + "(" + M_CelularDDD.Text + ")" + M_NewCelular.Text + ";" + T_Profissao.Text + ";" + C_Nacionalidade.Text + ";" + M_DataDeNascimento.Text + ";" + C_Genero.Text + ";" + C_tipoDeDocumento.Text + ";" + M_NdeDocumento.Text + ";" + M_OrgaoExpedidor.Text + ";" + T_ResidenciaPermanente.Text + ";" + C_ResidenciaPais.Text + ";")
                    If C_ResidenciaPais.Text <> "Brasil" Then
                        streamWRITE.Write(M_ResidenciaUF.Text)
                    Else
                        streamWRITE.Write(C_ResidenciaUF.Text)
                    End If
                    streamWRITE.Write(";" + M_residenciaPermCIDADE.Text + ";" + C_UltimaProcedenciaPais.Text + ";")
                    If C_UltimaProcedenciaPais.Text <> "Brasil" Then
                        streamWRITE.Write(T_UltimaProcUF.Text)
                    Else
                        streamWRITE.Write(C_UltimaProcedenciaUF.Text)
                    End If
                    streamWRITE.Write(";" + T_UltimaProcCIDADE.Text + ";" + C_ProximoDestinoPais.Text + ";")
                    If C_ProximoDestinoPais.Text <> "Brasil" Then
                        streamWRITE.Write(T_ProximoDestinoUF.Text)
                    Else
                        streamWRITE.Write(C_ProximoDestinoUF.Text)
                    End If

                    x = CType(L_Ndias.Text, Integer)
                    x = x + N_dias.Value
                    streamWRITE.WriteLine(";" + T_ProximoDestinoCIDADE.Text + ";" + C_MotivoDaViagem.Text + ";" + C_MeioDeTransporte.Text + ";" + T_observação.Text + ";" + x.ToString + ";" + L_dataCheckIn.Text + ";" + C_PreferenciaQuarto.Text + ";" + L_ValorTotal.Text + ";" + L_novaDataDeCheckOut.Text, True)
                    MessageBox.Show("Cadastro alterado com sucesso.", "alteração!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    streamWRITE.WriteLine(linha)
                End If
            End While
            streamREADER.Close()
            streamWRITE.Close()
            IO.File.Delete("Infinity Hotel.REGISTRO")
            IO.File.Move("new.txt", "Infinity Hotel.REGISTRO")


            Quartos.T_Nome.Clear()
            Quartos.T_Email.Clear()
            Quartos.M_CelularN.Clear()
            Quartos.T_TipoDeDocumento.Clear()
            Quartos.M_NdeDocumento.Clear()
            Quartos.L_Diaria.Text = "0"
            Quartos.L_ValorTotal.Text = "0"
            Quartos.L_restaurante.Text = "0"
            Quartos.L_dataCheckIn.Text = "00/00/0000"
            Quartos.L_CheckOut.Text = "00/00/0000"
            Quartos.L_Ndias.Text = "0"
            Quartos.T_observação.Clear()
            streamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
            While Not streamREADER.EndOfStream
                linha = streamREADER.ReadLine()
                cad = linha.Split(";")
                If Quartos.N_quarto.Value = CType(C_PreferenciaQuarto.Text, Integer) Then
                    Quartos.T_Nome.Text = cad(0).ToString
                    Quartos.T_Email.Text = cad(1).ToString
                    Quartos.M_CelularN.Text = cad(3).ToString
                    Quartos.T_TipoDeDocumento.Text = cad(8).ToString
                    Quartos.M_NdeDocumento.Text = cad(9).ToString
                    Quartos.T_observação.Text = cad(23).ToString
                    Quartos.L_Ndias.Text = cad(24).ToString
                    Quartos.L_dataCheckIn.Text = cad(25).ToString
                    Quartos.L_Diaria.Text = cad(27).ToString
                    Quartos.L_CheckOut.Text = cad(28).ToString

                    'Este processo irá transformar o valor do 'label' da diaria em um número inteiro, e somar com o valor do 'label' do restaurante, que tambem foi transformado de uma 'string' para um número inteiro.
                    'o resultado da conta será salvo no 'label' quer quarda o valor total a ser pago.
                    Quartos.L_ValorTotal.Text = CType(Quartos.L_Diaria.Text, Integer) + CType(Quartos.L_restaurante.Text, Integer)

                    Quartos.L_EstatusDoQuarto.Text = "OCUPADO"
                    Quartos.L_EstatusDoQuarto.ForeColor = Color.Red
                    Exit While
                Else
                    Quartos.L_EstatusDoQuarto.Text = "VASIO"
                    Quartos.L_EstatusDoQuarto.ForeColor = Color.LightGreen
                End If
            End While
            streamREADER.Close()

            Quartos.Show()
            Me.Hide()
        End If

        N_dias.Value = 0
        Label45.Visible = False
        L_novaDataDeCheckOut.Visible = False
        L_ValorAcrecental.Visible = False
        L_ValorAcrecental_RS.Visible = False
        B_Voltar.Text = "Voltar"
        B_FazerAlteração.Enabled = True

        T_lerEMAIL.Visible = False
        Label43.Visible = False
        C_emailDominio.Visible = False
        Label42.Visible = False
        C_comEcombr.Visible = False
        Label31.Visible = False
        T_TelefoneDDI.Visible = False
        Label25.Visible = False
        M_TelefoneDDD.Visible = False
        Label23.Visible = False
        M_NewTelefone.Visible = False
        Label41.Visible = False
        T_CelularDDI.Visible = False
        Label37.Visible = False
        M_CelularDDD.Visible = False
        Label32.Visible = False
        M_NewCelular.Visible = False
        C_Nacionalidade.Visible = False
        M_DataDeNascimento.Mask = ""
        C_Genero.Visible = False
        C_tipoDeDocumento.Visible = False
        M_NdeDocumento.Mask = ""
        C_ResidenciaPais.Visible = False
        C_ResidenciaUF.Visible = False
        M_ResidenciaUF.Visible = True
        C_UltimaProcedenciaPais.Visible = False
        C_UltimaProcedenciaUF.Visible = False
        T_UltimaProcUF.Visible = True
        N_dias.Visible = False
        C_PreferenciaQuarto.Visible = False
        C_MotivoDaViagem.Visible = False
        C_MeioDeTransporte.Visible = False
        C_ProximoDestinoPais.Visible = False
        C_ProximoDestinoUF.Visible = False
        T_ProximoDestinoUF.Visible = False
        B_SalvarAlteração.Enabled = False


        T_Nome.Enabled = False
        T_Email.Enabled = False
        T_Email.Visible = True
        M_CelularN.Enabled = False
        M_CelularN.Visible = True
        M_TelefoneN.Enabled = False
        M_TelefoneN.Visible = True
        T_nacionalidade.Visible = True
        T_nacionalidade.Enabled = False
        T_Genero.Visible = True
        T_Genero.Enabled = False
        T_TipoDeDocumento.Enabled = False
        T_TipoDeDocumento.Visible = True
        M_ResidenciaPais.Enabled = False
        M_ResidenciaPais.Visible = True
        M_ResidenciaUF.Visible = True
        M_ResidenciaUF.Enabled = False
        M_MeioDeTransporte.Visible = True
        M_MeioDeTransporte.Enabled = False
        M_MotivoDaViagem.Visible = True
        M_MotivoDaViagem.Enabled = False
        T_ProximoDestinoPAIS.Visible = True
        T_ProximoDestinoPAIS.Enabled = False
        T_ProximoDestinoUF.Enabled = False
        T_ProximoDestinoUF.Visible = True
        M_DataDeNascimento.Enabled = False
        M_residenciaPermCIDADE.Enabled = False
        T_UltimaProcCIDADE.Enabled = False
        T_ProximoDestinoCIDADE.Enabled = False
        T_Profissao.Enabled = False
        M_NdeDocumento.Enabled = False
        M_OrgaoExpedidor.Enabled = False
        T_ResidenciaPermanente.Enabled = False
        T_UltimaProcUF.Enabled = False
        T_observação.Enabled = False
        Quartos.Show()
        Me.Hide()

    End Sub

    Private Sub C_tipoDeDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_tipoDeDocumento.SelectedIndexChanged
        If C_tipoDeDocumento.Text = "CPF" Then
            M_NdeDocumento.Mask = "000.000.000-00"
            M_NdeDocumento.Clear()
        Else
            M_NdeDocumento.Mask = ""
            M_NdeDocumento.Clear()
        End If
    End Sub

    Private Sub C_ProximoDestinoPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_ProximoDestinoPais.SelectedIndexChanged
        If C_ProximoDestinoPais.Text <> "Brasil" Then
            T_ProximoDestinoUF.Clear()
            C_UltimaProcedenciaUF.Visible = False
            T_ProximoDestinoUF.Visible = True
            T_ProximoDestinoUF.Enabled = True
        Else
            T_ProximoDestinoUF.Clear()
            T_ProximoDestinoUF.Visible = False
            C_ProximoDestinoUF.Visible = True
            C_ProximoDestinoUF.Enabled = True
        End If
    End Sub

    Private Sub C_PreferenciaQuarto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles C_PreferenciaQuarto.Click
        C_PreferenciaQuarto.Items.Clear()
        For index = 1 To 50
            streamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
            While Not streamREADER.EndOfStream
                linha = streamREADER.ReadLine()
                cad = linha.Split(";")
                If index.ToString = L_preferenciaDeQuarto.Text Then
                    C_PreferenciaQuarto.Items.Add(index.ToString + " - Seu Quarto")
                    x = 9
                    Exit While
                ElseIf cad(26) = index.ToString Then
                    C_PreferenciaQuarto.Items.Add(index.ToString + " - Ocupado")
                    x = 9
                End If
            End While
            If x <> 9 Then
                C_PreferenciaQuarto.Items.Add(index)
            End If
            x = 0
            streamREADER.Close()
        Next
    End Sub

    Private Sub C_PreferenciaQuarto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_PreferenciaQuarto.SelectedIndexChanged
        C_PreferenciaQuarto.BackColor = Color.White
        If C_PreferenciaQuarto.Text.Contains(" - Ocupado") Then
            C_PreferenciaQuarto.BackColor = Color.Red
        End If
    End Sub

    Private Sub N_dias_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_dias.ValueChanged
        N_dias.Maximum = 355 - CType(L_Ndias.Text, Integer)
        total = N_dias.Value * 354
        x = CType(L_Diaria.Text, Integer)
        L_ValorAcrecental.Text = total.ToString
        L_ValorTotal.Text = total + x

        dia = 0
        mes = 0
        ano = 0

        cad1 = L_DataCheckOut.Text.Split("/")
        dia = cad1(0)
        mes = cad1(1)
        ano = cad1(2)

        For index = 1 To N_dias.Value

            'MÊS 1
            If mes = 1 Then
                If dia < 31 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 2
            ElseIf mes = 2 Then
                If dia < 29 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 3
            ElseIf mes = 3 Then
                If dia < 31 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 4
            ElseIf mes = 4 Then
                If dia < 30 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 0
                End If

                'MÊS 5
            ElseIf mes = 5 Then
                If dia < 31 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 6
            ElseIf mes = 6 Then
                If dia < 30 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 7
            ElseIf mes = 7 Then
                If dia < 31 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 8
            ElseIf mes = 8 Then
                If dia < 31 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 9
            ElseIf mes = 9 Then
                If dia < 30 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 10
            ElseIf mes = 10 Then
                If dia < 31 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 11
            ElseIf mes = 11 Then
                If dia < 30 Then
                    dia = dia + 1
                Else
                    mes = mes + 1
                    dia = 1
                End If

                'MÊS 12
            ElseIf mes = 12 Then
                If dia < 31 Then
                    dia = dia + 1
                Else
                    ano = ano + 1
                    mes = 1
                    dia = 1
                End If
            End If
        Next

        L_novaDataDeCheckOut.Text = dia.ToString + "/" + mes.ToString + "/" + ano.ToString
    End Sub
End Class