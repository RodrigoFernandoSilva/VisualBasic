Public Class Quartos
    Dim X As Integer = 0
    Dim QuartoEscolhido As String
    public Dim cad(30) As String
    Dim linha As String
    Dim streamREADER As IO.StreamReader
    Dim streamWRITE As IO.StreamWriter
    Private Sub B_Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Sair.Click
        TelaPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub Quartos_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    Private Sub B_VerTodosDados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_VerTodosDados.Click
        streamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
        While Not streamREADER.EndOfStream
            linha = streamREADER.ReadLine()
            cad = linha.Split(";")
            If cad(26) = N_quarto.Value Then
                DadosDoHospede.T_Nome.Text = cad(0).ToString
                DadosDoHospede.T_Email.Text = cad(1).ToString
                DadosDoHospede.M_TelefoneN.Text = cad(2).ToString
                DadosDoHospede.M_CelularN.Text = cad(3).ToString
                DadosDoHospede.T_Profissao.Text = cad(4).ToString
                DadosDoHospede.T_nacionalidade.Text = cad(5).ToString
                DadosDoHospede.M_DataDeNascimento.Text = cad(6).ToString
                DadosDoHospede.T_Genero.Text = cad(7).ToString
                DadosDoHospede.T_TipoDeDocumento.Text = cad(8).ToString
                DadosDoHospede.M_NdeDocumento.Text = cad(9).ToString
                DadosDoHospede.M_OrgaoExpedidor.Text = cad(10).ToString
                DadosDoHospede.T_ResidenciaPermanente.Text = cad(11).ToString
                DadosDoHospede.M_ResidenciaPais.Text = cad(12).ToString
                DadosDoHospede.M_ResidenciaUF.Text = cad(13).ToString
                DadosDoHospede.M_residenciaPermCIDADE.Text = cad(14).ToString

                DadosDoHospede.T_UltimaProcPAIS.Text = cad(15).ToString
                DadosDoHospede.T_UltimaProcUF.Text = cad(16).ToString

                DadosDoHospede.T_UltimaProcCIDADE.Text = cad(17).ToString
                DadosDoHospede.T_ProximoDestinoPAIS.Text = cad(18).ToString
                DadosDoHospede.T_ProximoDestinoUF.Text = cad(19).ToString
                DadosDoHospede.T_ProximoDestinoCIDADE.Text = cad(20).ToString

                DadosDoHospede.M_MotivoDaViagem.Text = cad(21).ToString
                DadosDoHospede.M_MeioDeTransporte.Text = cad(22).ToString
                DadosDoHospede.T_observação.Text = cad(23).ToString
                DadosDoHospede.L_Ndias.Text = cad(24).ToString
                DadosDoHospede.L_dataCheckIn.Text = cad(25).ToString
                DadosDoHospede.L_preferenciaDeQuarto.Text = cad(26).ToString
                DadosDoHospede.L_Diaria.Text = cad(27).ToString
                DadosDoHospede.L_DataCheckOut.Text = cad(28).ToString

                DadosDoHospede.L_ValorTotal.Text = L_ValorTotal.Text

                streamREADER.Close()
                X = 9
                DadosDoHospede.Show()
                Exit While
            End If
        End While
        If X = 9 Then
            X = 0
            Me.Hide()
        End If
        streamREADER.Close()
    End Sub

    Private Sub N_quarto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_quarto.ValueChanged
        T_Nome.Clear()
        T_Email.Clear()
        M_CelularN.Clear()
        T_TipoDeDocumento.Clear()
        M_NdeDocumento.Clear()
        L_Diaria.Text = "0"
        L_ValorTotal.Text = "0"
        L_restaurante.Text = "0"
        L_dataCheckIn.Text = "00/00/0000"
        L_CheckOut.Text = "00/00/0000"
        L_Ndias.Text = "0"
        T_observação.Clear()
        streamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
        While Not streamREADER.EndOfStream
            linha = streamREADER.ReadLine()
            cad = linha.Split(";")
            If cad(26) = N_quarto.Value Then
                T_Nome.Text = cad(0).ToString
                T_Email.Text = cad(1).ToString
                M_CelularN.Text = cad(3).ToString
                T_TipoDeDocumento.Text = cad(8).ToString
                M_NdeDocumento.Text = cad(9).ToString
                T_observação.Text = cad(23).ToString
                L_Ndias.Text = cad(24).ToString
                L_dataCheckIn.Text = cad(25).ToString
                L_Diaria.Text = cad(27).ToString
                L_CheckOut.Text = cad(28).ToString

                'Este processo irá transformar o valor do 'label' da diaria em um número inteiro, e somar com o valor do 'label' do restaurante, que tambem foi transformado de uma 'string' para um número inteiro.
                'o resultado da conta será salvo no 'label' quer quarda o valor total a ser pago.
                L_ValorTotal.Text = CType(L_Diaria.Text, Integer) + CType(L_restaurante.Text, Integer)

                L_EstatusDoQuarto.Text = "OCUPADO"
                L_EstatusDoQuarto.ForeColor = Color.Red
                Exit While
            Else
                L_EstatusDoQuarto.Text = "VASIO"
                L_EstatusDoQuarto.ForeColor = Color.LightGreen
            End If
        End While
        streamREADER.Close()
    End Sub

    Private Sub Quartos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        streamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
        While (Not streamREADER.EndOfStream)
            linha = streamREADER.ReadLine()
            cad = linha.Split(";")
            If cad(26) = "1" Then
                T_Nome.Text = cad(0).ToString
                T_Email.Text = cad(1).ToString
                M_CelularN.Text = cad(3).ToString
                T_TipoDeDocumento.Text = cad(8).ToString
                M_NdeDocumento.Text = cad(9).ToString
                T_observação.Text = cad(23).ToString
                L_Ndias.Text = cad(24).ToString
                L_dataCheckIn.Text = cad(25).ToString
                L_Diaria.Text = cad(27).ToString
                L_CheckOut.Text = cad(28).ToString
                L_ValorTotal.Text = CType(L_Diaria.Text, Integer) + CType(L_restaurante.Text, Integer)
                L_EstatusDoQuarto.Text = "OCUPADO"
                L_EstatusDoQuarto.ForeColor = Color.Red
            Else
                L_EstatusDoQuarto.Text = "VASIO"
                L_EstatusDoQuarto.ForeColor = Color.LightGreen
            End If
        End While
        streamREADER.Close()
    End Sub

    Private Sub Quartos_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        streamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
        While (Not streamREADER.EndOfStream)
            linha = streamREADER.ReadLine()
            cad = linha.Split(";")
            If cad(26) = "1" Then
                T_Nome.Text = cad(0).ToString
                T_Email.Text = cad(1).ToString
                M_CelularN.Text = cad(3).ToString
                T_TipoDeDocumento.Text = cad(8).ToString
                M_NdeDocumento.Text = cad(9).ToString
                T_observação.Text = cad(23).ToString
                L_Ndias.Text = cad(24).ToString
                L_dataCheckIn.Text = cad(25).ToString
                L_Diaria.Text = cad(27).ToString
                L_CheckOut.Text = cad(28).ToString
                L_ValorTotal.Text = CType(L_Diaria.Text, Integer) + CType(L_restaurante.Text, Integer)
                L_EstatusDoQuarto.Text = "OCUPADO"
                L_EstatusDoQuarto.ForeColor = Color.Red
                Exit While
            Else
                L_EstatusDoQuarto.Text = "VASIO"
                L_EstatusDoQuarto.ForeColor = Color.LightGreen
            End If
        End While
        streamREADER.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        L_hora.Text = TimeString
    End Sub
End Class