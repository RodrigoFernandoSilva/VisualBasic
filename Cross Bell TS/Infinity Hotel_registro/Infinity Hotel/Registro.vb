Public Class Registro
    Dim Total As Integer = 0
    Dim StreamREADER As IO.StreamReader
    Dim StreamWRITE As IO.StreamWriter
    Dim Read As String
    Dim i As Integer = 0
    Dim Nmpalavra As Integer = 0
    Dim validar As Integer = 0
    Dim x = 0, x1 = 0, x2 As Integer = 0
    Dim CPF_soma(14) As Integer
    Dim CPF_Multiplica(14) As Integer
    Dim dia As Integer = 0
    Dim mes As Integer = 0
    Dim ano As Integer = 0
    Dim checkIn As String
    Dim checkOut As String
    Dim d1, d2 As Date
    Dim cad(30) As String
    Dim linha As String
    Private Sub Registro_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If N_Ndias.Value <= 0 Then
            N_Ndias.Value = 1
        End If
        L_DataCheckOut.Text = senha.L_data.Text
        T_lerNOME.SelectAll()
        ActiveControl = T_lerNOME
        x = 0
        L_data.Text = Today
        L_DataCheckIn.Text = Today
        'L_ValorTotal.Text = CType(L_Diaria.Text, Integer) + CType(L_MultaPorAtraso.Text, Integer)

        'Estes processos irão deixar todos os 'Label' de menssagem de erro ocultos
        L_celularERRO.Visible = False
        L_PróximoDestinoCidadeERRO.Visible = False
        L_PróximoDestinoPaisERRO.Visible = False
        L_PróximoDestinoUfERRO.Visible = False
        L_CheckOutERRO.Visible = False
        L_EmaiERRO.Visible = False
        L_emaildominioERRO.Visible = False
        L_emailLocalideERRO.Visible = False
        L_ResidenciaPermanenteERRO.Visible = False
        L_DataDeNascimentoERRO.Visible = False
        L_MeioDeTransporteERRO.Visible = False
        L_MotivoDaViagemERRO.Visible = False
        L_nacionalidadeERRO.Visible = False
        L_NdDocumentoERRO.Visible = False
        L_nomeERRO.Visible = False
        L_ObservaçãoERRO.Visible = False
        L_OrgãoExpdidorERRO.Visible = False
        L_preferencia_Q_INEXISTENTE.Visible = False
        L_profissãoERRO.Visible = False
        L_ResidenciaCidadeERRO.Visible = False
        L_ResidenciaUfERRO.Visible = False
        L_GeneroERRO.Visible = False
        L_tefefoneERRO.Visible = False
        L_tipoDocumentoERRO.Visible = False
        L_ultimaProcCidadeErro.Visible = False
        L_ultimaProcPaisErro.Visible = False
        L_ultimaProcUfErro.Visible = False
        L_ResidenciapaisERRO.Visible = False
    End Sub

    'Nome completo
    'Este 'sub' irá empedir que digitem número e caracteres inválidos no nome
    Private Sub T_lerNOME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_lerNOME.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar) And e.Handled = Char.IsWhiteSpace(e.KeyChar)
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            L_nomeERRO.Visible = False
        End If
        If T_lerNOME.Text <> Nothing And Char.IsControl(e.KeyChar) Then
            L_nomeERRO.Visible = False
        End If
    End Sub

    'Email
    'Este 'sub' irá empedir que digitem espaço no Email
    Private Sub T_lerEMAIL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_lerEMAIL.KeyPress
        L_EmaiERRO.Visible = False
    End Sub

    'Email
    'Este 'sub' irá procurar os caraqueteres invalidos no nome do email, como : ! , # , $ , % , ¨ , & , *
    Private Sub T_lerEMAIL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles T_lerEMAIL.Leave
        'Este 'if' ira procurar os caraqueteres citados acima
        If T_lerEMAIL.Text.Contains("!") Or T_lerEMAIL.Text.Contains("#") Or T_lerEMAIL.Text.Contains("$") Or T_lerEMAIL.Text.Contains("¨") Or T_lerEMAIL.Text.Contains("&") Or T_lerEMAIL.Text.Contains("*") Or T_lerEMAIL.Text.Contains(" ") Then
            L_EmaiERRO.Visible = True
            L_EmaiERRO.Text = "*E-mail invalido*"
        ElseIf T_lerEMAIL.Text = Nothing Then
            L_EmaiERRO.Visible = True
            L_EmaiERRO.Text = "*E-mail inexistente*"
        End If
    End Sub

    'Email
    'Este 'sub' irá empedir que digitem '@' e '.com' no Email
    Private Sub T_lerEMAIL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_lerEMAIL.TextChanged
        L_EmaiERRO.Visible = False
        If T_lerEMAIL.Text.Contains("@") Then
            'T_lerEMAIL.SelectAll()
            T_lerEMAIL.Text = T_lerEMAIL.Text.Replace("@", "")
            ActiveControl = C_emailDominio
        ElseIf T_lerEMAIL.Text.Contains(".com") Then
            'T_lerEMAIL.SelectAll()
            T_lerEMAIL.Text = T_lerEMAIL.Text.Replace(".com", "")
            ActiveControl = C_comEcombr
        End If
    End Sub

    'Dominio de email
    'Este 'sub' irá impedir que o usuario digite espaço no dominio, e tambem irá limpar a mensagem de ERRO de dominio da tela, isso quando o usuário digitar uma tecla.
    Private Sub C_emailDominio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C_emailDominio.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar)
        If Char.IsWhiteSpace(e.KeyChar) And Char.IsWhiteSpace(e.KeyChar) Then
            L_emaildominioERRO.Visible = False
        End If
    End Sub

    'Dominio de email
    'Este 'sub' irá Tirar o lable no ERRO de dominio inexistente da tela, isso quando o usuário selecionar ou mudar um item do 'Combobox'.
    Private Sub C_emailDominio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_emailDominio.SelectedIndexChanged
        L_emaildominioERRO.Visible = False
    End Sub

    'Dominio de email
    'Este 'sub' irá empedir que digitem @ e .com no Dominio de Email.
    Private Sub C_emailDominio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles C_emailDominio.TextChanged
        L_emaildominioERRO.Visible = False
        'Este 'if' irá ver se o texto do dominio de Email tem algum '@'.
        If C_emailDominio.Text.Contains("@") Then
            'Caso ele tenha o '@' o programa ira subestituir o '@' pelo ''(nada).
            C_emailDominio.Text = C_emailDominio.Text.Replace("@", "")
            'Caso não tenha o '@' ira procurar o '.com' pelo texto do dominio de Email.
        ElseIf C_emailDominio.Text.Contains(".com") Then
            'Caso o programa ache o '.com' irá substituir ele por ''(espaço em branco)
            C_emailDominio.Text = C_emailDominio.Text.Replace(".com", "")
            ActiveControl = C_comEcombr
        End If
    End Sub

    'Localidade de email
    'Este 'sub' irá limpar a mensagem de ERRO da localidade de email inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura dela.
    Private Sub C_comEcombr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C_comEcombr.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar)
        If Not Char.IsWhiteSpace(e.KeyChar) Then
            L_emailLocalideERRO.Visible = False
        End If
    End Sub

    'DDI do telefone
    'Este sub irá impedir que o usuário digite nada que seja diferente de um numero no DDI do número de telefone, porém vai permitir que ele digite 'Backspace' para apagar.
    'Ele Tambem irá limpar a mensagem de ERRO do número de  telefone da tela
    Private Sub T_TelefoneDDI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_TelefoneDDI.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar)
        If Char.IsDigit(e.KeyChar) Then
            L_tefefoneERRO.Visible = False
        End If
    End Sub
    'DDD do telefone
    'Este sub irá impedir que o usuário digite nada que seja diferente de um numero no DDD do número de telefone, porém vai permitir que ele digite 'Backspace' para apagar.
    'Ele Tambem irá limpar a mensagem de ERRO do número de  telefone da tela
    Private Sub T_TelefoneDDD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not Char.IsDigit(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar)
        If Char.IsDigit(e.KeyChar) Then
            L_tefefoneERRO.Visible = False
        End If
    End Sub
    'Numero do telefone
    'Este sub irá impedir que o usuário digite nada que seja diferente de um numero no DDD do número de telefone, porém vai permitir que ele digite 'Backspace' para apagar.
    'Ele Tambem irá limpar a mensagem de ERRO do búmero de  telefone da tela
    Private Sub M_TelefoneN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles M_TelefoneN.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar)
        If Char.IsDigit(e.KeyChar) Then
            L_tefefoneERRO.Visible = False
        End If
    End Sub
    'DDD do telefone
    'Este sub irá impedir que o usuário digite nada que seja diferente de um numero no número de telefone, porém vai permitir que ele digite 'Backspace' para apagar.
    'Ele Tambem irá limpar a mensagem de ERRO do búmero de telefone da tela
    Private Sub M_TelefoneDDD_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles M_TelefoneDDD.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar)
        If Char.IsDigit(e.KeyChar) Then
            L_tefefoneERRO.Visible = False
        End If
    End Sub
    'DDI do celular
    'Este sub irá impedir que o usuário digite nada que seja diferente de um numero no DDI do número de celular, porém vai permitir que ele digite 'Backspace' para apagar.
    'Ele Tambem irá limpar a mensagem de ERRO do número de telefone da tela
    Private Sub T_CelularDDI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_CelularDDI.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar)
        If Char.IsDigit(e.KeyChar) Then
            L_celularERRO.Visible = False
        End If
    End Sub
    'Numero do celular
    'Este sub irá impedir que o usuário digite nada que seja diferente de um numero no DDD do número de celular, porém vai permitir que ele digite 'Backspace' para apagar.
    'Ele Tambem irá limpar a mensagem de ERRO do número de telefone da tela
    Private Sub M_CelularDDD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles M_CelularDDD.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar)
        If Char.IsDigit(e.KeyChar) Then
            L_celularERRO.Visible = False
        End If
    End Sub
    'DDD do celular
    'Este sub irá impedir que o usuário digite nada que seja diferente de um numero no número de celular, porém vai permitir que ele digite 'Backspace' para apagar.
    'Ele Tambem irá limpar a mensagem de ERRO do número de telefone da tela
    Private Sub M_CelularN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles M_CelularN.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar)
        If Char.IsDigit(e.KeyChar) Then
            L_celularERRO.Visible = False
        End If
    End Sub

    'Profissão
    'Este 'sub' irá limpar a mensagem de ERRO da profissão inexistente caso o usuário digite qualquer coisa dentro do quadro da profissão.
    Private Sub T_Profissao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_Profissao.KeyPress
        L_profissãoERRO.Visible = False
    End Sub

    'Data de nascimento
    'Este 'sub' irá limpar a mensagem de ERRO da data de nascimento inexistente caso o usuário digite qualquer coisa dentro da mascara de leitura dela.
    Private Sub M_DataDeNascimento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles M_DataDeNascimento.KeyPress
        L_DataDeNascimentoERRO.Visible = False
    End Sub

    'Gênero
    'Este 'sub' irá limpar a mensagem de ERRO do gênero inexistente caso o usuário selecione um dos gêneros
    Private Sub C_Genero_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_Genero.SelectedIndexChanged
        L_GeneroERRO.Visible = False
    End Sub

    'Tipo de documento
    'Este 'sub' irá limpar a mensagem de ERRO do tipo de documento inexistente caso o usuário selecione deixe este campo em branco.
    Private Sub C_tipoDeDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_tipoDeDocumento.SelectedIndexChanged
        L_tipoDocumentoERRO.Visible = False
        L_NdDocumentoERRO.Visible = False
        'Estes processos irão abalitar para digitação os campos de número de documento e orção expeditor
        M_NdeDocumento.Enabled = True
        M_OrgaoExpedidor.Enabled = True

        'Este processo ira mudar a cor de cinza claro para branco, para "avisar" que ele pode digitar nessa campo
        M_NdeDocumento.BackColor = Color.White
        M_OrgaoExpedidor.BackColor = Color.White

        'Caso o tipo de documento escolhido foi o passaporte, ira deixar sem a mascara no campo de digitação de número de documento 
        If C_tipoDeDocumento.Text = "PASSAPORTE" Then
            M_NdeDocumento.Text = Nothing
            M_NdeDocumento.Mask = ""
            'Porém caso comtrario, irá ativar a masca pra digitar o CPf
        Else
            M_NdeDocumento.Text = Nothing
            M_NdeDocumento.Mask = "000.000.000-00"
        End If
    End Sub

    'Tipo de documento
    'Este 'sub' irá limpar a mensagem de ERRO do Tipo de documeto inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura dele.
    Private Sub M_TipoDeDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        L_tipoDocumentoERRO.Visible = False
    End Sub

    'Numero do documento
    'Este 'sub' irá limpar a mensagem de ERRO do Nº Tipo de documento inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura do Nº tipo de documento.
    Private Sub M_NdeDocumento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles M_NdeDocumento.KeyPress
        L_NdDocumentoERRO.Visible = False
    End Sub

    'Orgão expedidor
    'Este 'sub' irá limpar a mensagem de ERRO do orgão expedidor inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura dele.
    Private Sub M_OrgaoExpedidor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles M_OrgaoExpedidor.KeyPress
        L_OrgãoExpdidorERRO.Visible = False
    End Sub

    'Residencia permanente
    'Este 'sub' irá limpar a mensagem de ERRO da Residencia permanente inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura da Residencia permanente.
    Private Sub T_ResidenciaPermanente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles T_ResidenciaPermanente.KeyPress
        L_ResidenciaPermanenteERRO.Visible = False
    End Sub

    'Nacionalidade
    'Este 'sub' irá limpar a mensagem de ERRO da nacionalidade inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura da Residencia Ppermanente.
    Private Sub C_Nacionalidade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_Nacionalidade.SelectedIndexChanged
        L_nacionalidadeERRO.Visible = False
    End Sub

    'Localidade de email
    'Este 'sub' irá limpar a mensagem de ERRO da localidade inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura da localidade de email.
    Private Sub C_comEcombr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_comEcombr.SelectedIndexChanged
        L_emailLocalideERRO.Visible = False
    End Sub

    'Residencia permanênte pais
    'Este 'sub' irá limpar a mensagem de ERRO da residencia permanênte pais inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura da Residencia Permanente pais.
    Private Sub C_ResidenciaPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_ResidenciaPais.SelectedIndexChanged
        L_ResidenciapaisERRO.Visible = False

        'Estes processos irão mudar a cor de cinza pra branco, para "avisar" o usuario que ele pode digitar algo aqui, e ira ativar pra digitação o campo de leitura da cidade
        T_ResidenciaCidade.BackColor = Color.White
        T_ResidenciaCidade.Enabled = True

        C_ResidenciaUF.BackColor = Color.White

        'Caso o usuario não celecione brasil, ira deixar visivel o campo para ele digitar o estado dele
        If C_ResidenciaPais.Text <> "Brasil" Then
            T_ResidenciaUF.Enabled = True
            T_ResidenciaUF.Visible = True

            C_ResidenciaUF.Enabled = False
            C_ResidenciaUF.Visible = False
            'Caso comtrario, irá pedir pra ele escolher um no 'combobox'
        Else
            C_ResidenciaUF.Enabled = True
            C_ResidenciaUF.Visible = True

            T_ResidenciaUF.Enabled = False
            T_ResidenciaUF.Visible = False
        End If
    End Sub

    'Residencia permanênte cidade
    'Este 'sub' irá limpar a mensagem de ERRO da residencia permanênte cidade inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura da Residencia Permanente cidade.
    Private Sub T_ResidenciaCidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_ResidenciaCidade.TextChanged
        L_ResidenciaCidadeERRO.Visible = False
    End Sub

    'Proximo Destino pais
    'Este 'sub' irá limpar a mensagem de ERRO da Proximo Destino pais inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura do Proximo Destino pais.
    'é a mesma coisa da residencia permanente, so muda o nome dos forms
    Private Sub C_ProximoDestinoPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_ProximoDestinoPais.SelectedIndexChanged
        L_PróximoDestinoPaisERRO.Visible = False

        T_ProximoDestinoCidade.Enabled = True
        T_ProximoDestinoCidade.BackColor = Color.White

        C_ProximoDestinoUF.BackColor = Color.White

        If C_ProximoDestinoPais.Text <> "Brasil" Then
            T_próximoDestinoUF.Visible = True
            T_próximoDestinoUF.Enabled = True

            C_ProximoDestinoUF.Visible = False
            C_ProximoDestinoUF.Enabled = False

            C_ProximoDestinoUF.Text = Nothing
        Else
            T_próximoDestinoUF.Visible = False
            T_próximoDestinoUF.Enabled = False

            C_ProximoDestinoUF.Visible = True
            C_ProximoDestinoUF.Enabled = True

            T_próximoDestinoUF.Text = Nothing
        End If
    End Sub

    'Ultima Procedencia pais
    'Este 'sub' irá limpar a mensagem de ERRO da Ultima Procedencia pais inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura da Ultima Procedencia pais.
    'é a mesma coisa da residencia permanente, so muda o nome dos forms
    Private Sub C_UltimaProcedenciaPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_UltimaProcedenciaPais.SelectedIndexChanged
        L_ultimaProcPaisErro.Visible = False

        T_UltimaProcedenciaCidade.Enabled = True
        T_UltimaProcedenciaCidade.BackColor = Color.White

        C_UltimaProcedenciaUF.BackColor = Color.White

        If C_UltimaProcedenciaPais.Text <> "Brasil" Then
            T_ultimaProcedenciaUF.Visible = True
            T_ultimaProcedenciaUF.Enabled = True

            C_UltimaProcedenciaUF.Visible = False
            C_UltimaProcedenciaUF.Enabled = False

            C_UltimaProcedenciaUF.Text = Nothing
        Else
            T_ultimaProcedenciaUF.Visible = False
            T_ultimaProcedenciaUF.Enabled = False

            C_UltimaProcedenciaUF.Visible = True
            C_UltimaProcedenciaUF.Enabled = True

            T_ultimaProcedenciaUF.Text = Nothing
        End If
    End Sub

    'Residencia UF pais
    'Este 'sub' irá limpar a mensagem de ERRO da Residencia UF pais inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura da Residencia UF pais.
    Private Sub C_ResidenciaUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_ResidenciaUF.SelectedIndexChanged
        L_ResidenciaUfERRO.Visible = False
    End Sub

    'Residencia UF pais
    'Este 'sub' irá limpar a mensagem de ERRO da Residencia UF pais inexistente caso o usuário digite qualquer coisa dentro da caixa de leitura da Residencia UF pais.
    Private Sub T_ResidenciaUF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_ResidenciaUF.TextChanged
        L_ResidenciaUfERRO.Visible = False
    End Sub

    Private Sub T_ultimaProcedenciaUF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_ultimaProcedenciaUF.TextChanged
        L_ultimaProcUfErro.Visible = False
    End Sub

    Private Sub T_próximoDestinoUF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_próximoDestinoUF.TextChanged
        L_PróximoDestinoUfERRO.Visible = False
    End Sub

    Private Sub C_UltimaProcedenciaUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_UltimaProcedenciaUF.SelectedIndexChanged
        L_ultimaProcUfErro.Visible = False
    End Sub

    Private Sub C_ProximoDestinoUF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_ProximoDestinoUF.SelectedIndexChanged
        L_PróximoDestinoUfERRO.Visible = False
    End Sub

    Private Sub T_UltimaProcedenciaCidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_UltimaProcedenciaCidade.TextChanged
        L_ultimaProcCidadeErro.Visible = False
    End Sub

    Private Sub T_ProximoDestinoCidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_ProximoDestinoCidade.TextChanged
        L_PróximoDestinoCidadeERRO.Visible = False
    End Sub

    Private Sub C_MotivoDaViagem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_MotivoDaViagem.SelectedIndexChanged
        L_MotivoDaViagemERRO.Visible = False
    End Sub

    Private Sub C_MeioDeTransporte_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_MeioDeTransporte.SelectedIndexChanged
        L_MeioDeTransporteERRO.Visible = False
    End Sub

    Private Sub T_observação_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_observação.TextChanged
        L_ObservaçãoERRO.Visible = False
    End Sub

    Private Sub M_NdeDocumento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles M_NdeDocumento.Leave
        If C_tipoDeDocumento.Text = "CPF" Then
            x = 0
            x1 = 0
            If Not M_NdeDocumento.MaskCompleted Then
                L_NdDocumentoERRO.Visible = True
                L_NdDocumentoERRO.Text = "*CPF incompleto ou inexistente*"
                Exit Sub
            End If
            CPF_Multiplica(0) = (AscW(M_NdeDocumento.Text(0)) - 48) * 10
            CPF_Multiplica(2) = (AscW(M_NdeDocumento.Text(1)) - 48) * 9
            CPF_Multiplica(3) = (AscW(M_NdeDocumento.Text(2)) - 48) * 8

            CPF_Multiplica(4) = (AscW(M_NdeDocumento.Text(4)) - 48) * 7
            CPF_Multiplica(5) = (AscW(M_NdeDocumento.Text(5)) - 48) * 6
            CPF_Multiplica(6) = (AscW(M_NdeDocumento.Text(6)) - 48) * 5

            CPF_Multiplica(7) = (AscW(M_NdeDocumento.Text(8)) - 48) * 4
            CPF_Multiplica(8) = (AscW(M_NdeDocumento.Text(9)) - 48) * 3
            CPF_Multiplica(9) = (AscW(M_NdeDocumento.Text(10)) - 48) * 2

            For index = 0 To 9
                x += CPF_Multiplica(index)
            Next
            x = x Mod 11
            x = 11 - x

            CPF_Multiplica(0) = (AscW(M_NdeDocumento.Text(0)) - 48) * 11
            CPF_Multiplica(2) = (AscW(M_NdeDocumento.Text(1)) - 48) * 10
            CPF_Multiplica(3) = (AscW(M_NdeDocumento.Text(2)) - 48) * 9

            CPF_Multiplica(4) = (AscW(M_NdeDocumento.Text(4)) - 48) * 8
            CPF_Multiplica(5) = (AscW(M_NdeDocumento.Text(5)) - 48) * 7
            CPF_Multiplica(6) = (AscW(M_NdeDocumento.Text(6)) - 48) * 6

            CPF_Multiplica(7) = (AscW(M_NdeDocumento.Text(8)) - 48) * 5
            CPF_Multiplica(8) = (AscW(M_NdeDocumento.Text(9)) - 48) * 4
            CPF_Multiplica(9) = (AscW(M_NdeDocumento.Text(10)) - 48) * 3

            CPF_Multiplica(10) = (AscW(M_NdeDocumento.Text(12)) - 48) * 2


            For index = 0 To 10
                x1 += CPF_Multiplica(index)
            Next

            x1 = x1 Mod 11
            x1 = 11 - x1

            If AscW(M_NdeDocumento.Text(12)) - 48 <> x Or AscW(M_NdeDocumento.Text(13)) - 48 <> x1 Then
                L_NdDocumentoERRO.Visible = True
                L_NdDocumentoERRO.Text = "*CPF invalido*"
            End If
        End If
    End Sub

    Private Sub T_lerNOME_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles T_lerNOME.Leave
        If T_lerNOME.Text <> Nothing Then
            Nmpalavra = T_lerNOME.Text.Length - 1
            If Nmpalavra = 0 Then
                L_nomeERRO.Visible = True
                L_nomeERRO.Text = "*Nome muito curto"
                Exit Sub
            End If
            If T_lerNOME.Text(0) = " " Or T_lerNOME.Text(Nmpalavra) = " " Then
                L_nomeERRO.Visible = True
                L_nomeERRO.Text = "*Nome invalido devido a uso incerto dos espaços"
                Exit Sub
            End If

            For i = 0 To Nmpalavra
                If T_lerNOME.Text(i) = " " Then
                    validar = 1
                    Exit For
                End If
            Next

            If validar <> 1 Or Nmpalavra = 0 Then
                L_nomeERRO.Visible = True
                L_nomeERRO.Text = "*Sobrenome inexistente*"
                Exit Sub
            End If

            For i = 0 To Nmpalavra
                If T_lerNOME.Text(i) = " " And i = Nmpalavra - 1 Then
                    If T_lerNOME.Text(i + 1) = " " Then
                        L_nomeERRO.Visible = True
                        L_nomeERRO.Text = "*Nome invalido devido a uso incerto dos espaços"
                        Exit Sub
                    End If
                End If
            Next
            For i = 0 To Nmpalavra
                If i + 1 = Nmpalavra Then
                    Exit For
                End If
                If T_lerNOME.Text(i) = " " And T_lerNOME.Text(i + 1) = " " Then
                    L_nomeERRO.Visible = True
                    L_nomeERRO.Text = "*Nome invalido devido a uso incerto dos espaços"
                    Exit Sub
                End If
            Next
            If T_lerNOME.Text(1) = " " Then
                L_nomeERRO.Visible = True
                L_nomeERRO.Text = "*Nome invalido devido a uso incerto dos espaços"
                Exit Sub
            End If
        Else
            L_nomeERRO.Visible = True
            L_nomeERRO.Text = "*Nome inexistente*"
            Exit Sub
        End If
    End Sub

    Private Sub M_DataDeNascimento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles M_DataDeNascimento.Leave
        If M_DataDeNascimento.MaskCompleted Then
            dia = 0
            mes = 0
            ano = 0
            validar = 0

            dia = (AscW(M_DataDeNascimento.Text(0)) - 48) * 10
            dia = (AscW(M_DataDeNascimento.Text(1)) - 48) + dia

            mes = (AscW(M_DataDeNascimento.Text(3)) - 48) * 10
            mes = (AscW(M_DataDeNascimento.Text(4)) - 48) + mes

            ano = (AscW(M_DataDeNascimento.Text(6)) - 48) * 1000
            x = ((AscW(M_DataDeNascimento.Text(7)) - 48) * 100)
            x1 = ((AscW(M_DataDeNascimento.Text(8)) - 48) * 10)
            ano = (AscW(M_DataDeNascimento.Text(9)) - 48) + x + x1 + ano

            If ano > 0 Then
                If mes = 1 Or mes = 3 Or mes = 5 Or mes = 7 Or mes = 8 Or mes = 10 Or mes = 12 Then
                    If dia < 1 Or dia > 31 Then
                        validar = 2
                    End If
                ElseIf mes = 4 Or mes = 6 Or mes = 9 Or mes = 11 Then
                    If dia < 1 Or dia > 30 Then
                        validar = 2
                    End If
                ElseIf mes = 2 Then
                    If (ano Mod 4 = 0 And ano Mod 100 <> 0) Or ano Mod 400 = 0 Then
                        If dia < 0 And dia > 30 Then
                            validar = 2
                        End If
                    Else
                        If dia < 0 And dia > 29 Then
                            validar = 2
                        End If
                    End If
                    validar = 2
                Else
                    validar = 2
                End If
            End If

            If validar = 2 Then
                L_DataDeNascimentoERRO.Visible = True
                L_DataDeNascimentoERRO.Text = "*Data de nascimento" + vbCrLf + " invalido*"
                Exit Sub
            End If
        Else
            L_DataDeNascimentoERRO.Visible = True
            L_DataDeNascimentoERRO.Text = "*Data de nascimento" + vbCrLf + " inexistente ou incompleta*"
        End If
    End Sub

    Private Sub C_PreferenciaQuarto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles C_PreferenciaQuarto.Click
        C_PreferenciaQuarto.Items.Clear()
        For index = 1 To 50
            StreamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
            While Not StreamREADER.EndOfStream
                linha = StreamREADER.ReadLine()
                cad = linha.Split(";")
                If cad(26) = index.ToString Then
                    C_PreferenciaQuarto.Items.Add(index.ToString + " - Ocupado")
                    x = 9
                End If
            End While
            If x <> 9 Then
                C_PreferenciaQuarto.Items.Add(index)
            End If
            x = 0
            StreamREADER.Close()
        Next

    End Sub

    Private Sub C_PreferenciaQuarto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_PreferenciaQuarto.SelectedIndexChanged
        L_preferencia_Q_INEXISTENTE.Visible = False
        If C_PreferenciaQuarto.Text.Contains(" - Ocupado") Then
            L_preferencia_Q_INEXISTENTE.Visible = True
            L_preferencia_Q_INEXISTENTE.Text = "*Quarto já Ocupado*"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Registrar.Click
        'Este 'if' irá ver se todos os dados do cadastro estão completos, Caso estejão ira escrever no bloco de notas, caso contrario irá ver qual dado não esta preenchido e avisar o usuário
        If T_CelularDDI.Text <> Nothing And T_lerEMAIL.Text <> Nothing And T_lerNOME.Text <> Nothing And T_observação.Text <> Nothing And T_Profissao.Text <> Nothing And T_ProximoDestinoCidade.Text <> Nothing And T_ResidenciaCidade.Text <> Nothing And T_ResidenciaPermanente.Text <> Nothing And T_TelefoneDDI.Text <> Nothing And T_UltimaProcedenciaCidade.Text <> Nothing And M_CelularDDD.MaskCompleted And M_CelularN.MaskCompleted And M_DataDeNascimento.MaskCompleted And M_NdeDocumento.MaskCompleted And M_OrgaoExpedidor.MaskCompleted And M_TelefoneDDD.MaskCompleted And M_TelefoneN.MaskCompleted And C_comEcombr.Text <> Nothing And C_emailDominio.Text <> Nothing And C_Genero.Text <> Nothing And C_MeioDeTransporte.Text <> Nothing And C_MotivoDaViagem.Text <> Nothing And C_Nacionalidade.Text <> Nothing And C_PreferenciaQuarto.Text <> Nothing And C_ProximoDestinoPais.Text <> Nothing And C_ResidenciaPais.Text <> Nothing And C_tipoDeDocumento.Text <> Nothing And C_UltimaProcedenciaPais.Text <> Nothing And L_nomeERRO.Visible = False And L_EmaiERRO.Visible = False And L_DataDeNascimentoERRO.Visible = False Then
            'Não se usa o : 3 , 7 , 11

            If T_ultimaProcedenciaUF.Text = Nothing And C_UltimaProcedenciaUF.Text = Nothing Then
                L_ultimaProcUfErro.Visible = True
                L_ultimaProcUfErro.Text = "*UF da ultima procedência inexistente*"
            End If
            If T_próximoDestinoUF.Text = Nothing And C_ProximoDestinoUF.Text = Nothing Then
                L_PróximoDestinoUfERRO.Visible = True
                L_PróximoDestinoUfERRO.Text = "*UF do próximo destino inexistente*"
            End If
            If T_ResidenciaUF.Text = Nothing And C_ResidenciaUF.Text = Nothing Then
                L_ResidenciaUfERRO.Visible = True
                L_ResidenciaUfERRO.Text = "*UF da residencia permanente inexistente*"
            End If
            If L_ultimaProcUfErro.Visible = True Or L_PróximoDestinoUfERRO.Visible = True Or L_ResidenciaUfERRO.Visible = True Then
                MessageBox.Show("ERRO, Dados não preenchidos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Confirmar gravação de registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            'Escreve no bloco de notas todo o registro do cliente.
            StreamWRITE = New IO.StreamWriter("Infinity Hotel.REGISTRO", True)
            StreamWRITE.Write(T_lerNOME.Text + ";" + T_lerEMAIL.Text + "@" + C_emailDominio.Text + "." + C_comEcombr.Text + ";" + T_TelefoneDDI.Text + "(" + M_TelefoneDDD.Text + ")" + M_TelefoneN.Text + ";" + T_CelularDDI.Text + "(" + M_CelularDDD.Text + ")" + M_CelularN.Text + ";" + T_Profissao.Text + ";" + C_Nacionalidade.Text + ";" + M_DataDeNascimento.Text + ";" + C_Genero.Text + ";" + C_tipoDeDocumento.Text + ";" + M_NdeDocumento.Text + ";" + M_OrgaoExpedidor.Text + ";" + T_ResidenciaPermanente.Text + ";" + C_ResidenciaPais.Text + ";")
            If C_ResidenciaPais.Text <> "Brasil" Then
                StreamWRITE.Write(T_ResidenciaUF.Text)
            Else
                StreamWRITE.Write(C_ResidenciaUF.Text)
            End If
            StreamWRITE.Write(";" + T_ResidenciaCidade.Text + ";" + C_UltimaProcedenciaPais.Text + ";")
            If C_UltimaProcedenciaPais.Text <> "Brasil" Then
                StreamWRITE.Write(T_ultimaProcedenciaUF.Text)
            Else
                StreamWRITE.Write(C_UltimaProcedenciaUF.Text)
            End If
            StreamWRITE.Write(";" + T_UltimaProcedenciaCidade.Text + ";" + C_ProximoDestinoPais.Text + ";")
            If C_ProximoDestinoPais.Text <> "Brasil" Then
                StreamWRITE.Write(T_próximoDestinoUF.Text)
            Else
                StreamWRITE.Write(C_ProximoDestinoUF.Text)
            End If
            StreamWRITE.WriteLine(";" + T_ProximoDestinoCidade.Text + ";" + C_MotivoDaViagem.Text + ";" + C_MeioDeTransporte.Text + ";" + T_observação.Text + ";" + N_Ndias.Text + ";" + L_DataCheckIn.Text + ";" + C_PreferenciaQuarto.Text + ";" + Total.ToString + ";" + L_DataCheckOut.Text, True)
            StreamWRITE.Close()


            'Escreve o dados do cliente em outro aquivo pra ficar salvo no sistema, pra caso o hospede venha a se escrever no hotel novamente agelise o processo de preenchimento da ficha
            'StreamWRITE = New IO.StreamWriter("AllHospedes.ficha", True)
            'StreamWRITE.Write(T_lerNOME.Text + ";" + T_lerEMAIL.Text + "@" + C_emailDominio.Text + "." + C_comEcombr.Text + ";" + T_TelefoneDDI.Text + "(" + M_TelefoneDDD.Text + ")" + M_TelefoneN.Text + ";" + T_CelularDDI.Text + "(" + M_CelularDDD.Text + ")" + M_CelularN.Text + ";" + T_Profissao.Text + ";" + C_Nacionalidade.Text + ";" + M_DataDeNascimento.Text + ";" + C_Genero.Text + ";" + M_NdeDocumento.Text + "/" + M_OrgaoExpedidor.Text + ";" + T_ResidenciaPermanente.Text + ";" + C_ResidenciaPais.Text)
            'StreamWRITE.Close()

            T_lerNOME.SelectAll()
            ActiveControl = T_lerNOME
            TelaPrincipal.Show()
            Me.Hide()


            'Tudo abaixo deste 'Else' irá ver qua dados estaõ incompleto e exibir uma mensagem embaixo dele.
        Else

            'Todos estes 'if' abaixo irá mostrar exibir embaixo do campo de do cadastro não digitado uma mensagem de erro que ele esta incompleto ou inexistente
            'Pra fazer isso, primeiro o programa irá deixar o 'label' do erro visivel e mudar o texto dele
            'Erro de nome não digitado
            If T_lerNOME.Text = Nothing And L_nomeERRO.Visible = False Then
                L_nomeERRO.Visible = True
                L_nomeERRO.Text = "*Nome inexistente*"
            End If
            'Erro de email não digitado
            If T_lerEMAIL.Text = Nothing And L_EmaiERRO.Visible = False Then
                L_EmaiERRO.Visible = True
                L_EmaiERRO.Text = "*E-mail inexistente*"
            End If
            'Erro de Domínio de E-mail não digitado
            If C_emailDominio.Text = Nothing And L_emaildominioERRO.Visible = False Then
                L_emaildominioERRO.Visible = True
                L_emaildominioERRO.Text = "*Domínio inexistente*"
            End If
            'Erro de Local de E-mail não digitado
            If C_comEcombr.Text = Nothing Then
                L_emailLocalideERRO.Visible = True
                L_emailLocalideERRO.Text = "*Localidade" + vbCrLf + "inexistente*"
            End If
            'Erro de DDI, DDD, Numero de telefone não digitado
            If T_TelefoneDDI.Text = Nothing Or M_TelefoneDDD.Text = Nothing Or M_TelefoneN.Text = Nothing Then
                L_tefefoneERRO.Visible = True
                L_tefefoneERRO.Text = "*Dados de telefone incompleto*"
            End If
            'Erro de DDI, DDD, Numero de celular não digitado
            If T_CelularDDI.Text = Nothing Or M_CelularDDD.Text = Nothing Or M_CelularN.Text = Nothing Then
                L_celularERRO.Visible = True
                L_celularERRO.Text = "*Dados de celular incompleto*"
            End If
            'Erro de Local de E-mail não digitado
            If T_Profissao.Text = Nothing Then
                L_profissãoERRO.Visible = True
                L_profissãoERRO.Text = "*Profissão inexistente*"
            End If
            'Erro de Nacionalidade não digitado
            If C_Nacionalidade.Text = Nothing Then
                L_nacionalidadeERRO.Visible = True
                L_nacionalidadeERRO.Text = "*Nacionalidade inexistente*"
            End If
            'Erro de data de nascimento não digitado ou incompleta
            If Not M_DataDeNascimento.MaskCompleted Then
                L_DataDeNascimentoERRO.Visible = True
                L_DataDeNascimentoERRO.Text = "*Data de Nascimento" + vbCrLf + "inexistente ou incompleta*"
            End If
            'Erro de Gênero não digitado
            If C_Genero.Text = Nothing Then
                L_GeneroERRO.Visible = True
                L_GeneroERRO.Text = "*Gênero inexistente*"
            End If
            'Erro de Tipo de documento não digitado
            If C_tipoDeDocumento.Text = Nothing Then
                L_tipoDocumentoERRO.Visible = True
                L_tipoDocumentoERRO.Text = "*Tipo de Documento inexistente*"
            End If
            'Erro de Nº Tipo de documento não digitado
            If (M_NdeDocumento.Text = Nothing Or Not M_NdeDocumento.MaskCompleted) And L_NdDocumentoERRO.Visible = False Then
                L_NdDocumentoERRO.Visible = True
                L_NdDocumentoERRO.Text = "*Nº tipo de Documento inexistente ou incompleto*"
            End If
            'Erro de Orgão Expedidor não digitado
            If M_OrgaoExpedidor.Text = Nothing Then
                L_OrgãoExpdidorERRO.Visible = True
                L_OrgãoExpdidorERRO.Text = "*Orgão Expedidor inexistente*"
            End If

            'Erro de Observação não digitado
            If T_observação.Text = Nothing Then
                L_ObservaçãoERRO.Visible = True
                L_ObservaçãoERRO.Text = "*Observação inexistente*"
            End If

            'Erro de Motivo da viagem não digitado
            If C_MotivoDaViagem.Text = Nothing Then
                L_MotivoDaViagemERRO.Visible = True
                L_MotivoDaViagemERRO.Text = "*Motivo da viagem inexistente*"
            End If

            'Erro de Meio de transporte não digitado
            If C_MeioDeTransporte.Text = Nothing Then
                L_MeioDeTransporteERRO.Visible = True
                L_MeioDeTransporteERRO.Text = "*Meio de transporte inexistente*"
            End If

            'Erro preferencia de quarto não digitado
            If C_PreferenciaQuarto.Text = Nothing Then
                L_preferencia_Q_INEXISTENTE.Visible = True
                L_preferencia_Q_INEXISTENTE.Text = "*Oreferencia de quarto " + vbCrLf + "inexistente*"
            End If

            'Erro do pais da ultima procedência não escolhido
            If C_UltimaProcedenciaPais.Text = Nothing Then
                L_ultimaProcPaisErro.Visible = True
                L_ultimaProcPaisErro.Text = "*pais da última procêdencia inexistente*"
            End If

            'Erro da UF da última procedência não escolhido
            If C_UltimaProcedenciaUF.Text = Nothing And T_ultimaProcedenciaUF.Text = Nothing Then
                L_ultimaProcUfErro.Visible = True
                L_ultimaProcUfErro.Text = "*UF da última procedência inexistente*"
            End If

            'Erro da cidade da última procedência da última procedência não escolhido
            If T_UltimaProcedenciaCidade.Text = Nothing Then
                L_ultimaProcCidadeErro.Visible = True
                L_ultimaProcCidadeErro.Text = "*Cidade da última procedência inexistente*"
            End If

            'Erro de Próxima destino Pais não digitado
            If C_ProximoDestinoPais.Text = Nothing Then
                L_PróximoDestinoPaisERRO.Visible = True
                L_PróximoDestinoPaisERRO.Text = "*Pais do Próxima destino inexistente*"
            End If

            'Erro de Próximo destino UF não digitado
            If C_ProximoDestinoUF.Text = Nothing And T_próximoDestinoUF.Text = Nothing Then
                L_PróximoDestinoUfERRO.Visible = True
                L_PróximoDestinoUfERRO.Text = "*UF do Próxima destino inexistente*"
            End If

            'Erro de Próximo destino Cidade não digitado
            If T_ProximoDestinoCidade.Text = Nothing Then
                L_PróximoDestinoCidadeERRO.Visible = True
                L_PróximoDestinoCidadeERRO.Text = "*Cidade do Próxima destino inexistente*"
            End If

            'Erro da residencia permanente não digitado
            If T_ResidenciaPermanente.Text = Nothing Then
                L_ResidenciaPermanenteERRO.Visible = True
                L_ResidenciaPermanenteERRO.Text = "*Residência permanente inexistente*"
            End If

            ''Erro da UF da residencia permanente não digitado
            If C_ResidenciaUF.Text = Nothing And T_ResidenciaUF.Text = Nothing Then
                L_ResidenciaUfERRO.Visible = True
                L_ResidenciaUfERRO.Text = "*UF da residência permanente inexistente*"
            End If

            'Erro da cidade da residência permanente não digitado
            If T_ResidenciaCidade.Text = Nothing Then
                L_ResidenciaCidadeERRO.Visible = True
                L_ResidenciaCidadeERRO.Text = "*Cidade da residência permanente inexistente*"
            End If
            'Esta linha de código irá exibir para usuário uma menssagem de erro com um 'X' na tela escrito o texto em vermelho
            MessageBox.Show("ERRO, Dados não preenchidos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Este 'sub' é para caso o usuário aperte o botão cancelar da tela de registro. se ele aperta irá limpar toda a tela, de forma que fique igual a quando foi entrada pela primeira vez.
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Cancelar.Click
        'Estes processos irão deixar todos os 'Label' de menssagem de erro ocultos
        L_CheckOutERRO.Visible = False
        L_celularERRO.Visible = False
        L_PróximoDestinoCidadeERRO.Visible = False
        L_PróximoDestinoPaisERRO.Visible = False
        L_PróximoDestinoUfERRO.Visible = False
        L_CheckOutERRO.Visible = False
        L_EmaiERRO.Visible = False
        L_emaildominioERRO.Visible = False
        L_emailLocalideERRO.Visible = False
        L_ResidenciaPermanenteERRO.Visible = False
        L_DataDeNascimentoERRO.Visible = False
        L_MeioDeTransporteERRO.Visible = False
        L_MotivoDaViagemERRO.Visible = False
        L_nacionalidadeERRO.Visible = False
        L_NdDocumentoERRO.Visible = False
        L_nomeERRO.Visible = False
        L_ObservaçãoERRO.Visible = False
        L_OrgãoExpdidorERRO.Visible = False
        L_preferencia_Q_INEXISTENTE.Visible = False
        L_profissãoERRO.Visible = False
        L_ResidenciaCidadeERRO.Visible = False
        L_ResidenciaUfERRO.Visible = False
        L_GeneroERRO.Visible = False
        L_tefefoneERRO.Visible = False
        L_tipoDocumentoERRO.Visible = False
        L_ultimaProcCidadeErro.Visible = False
        L_ultimaProcPaisErro.Visible = False
        L_ultimaProcUfErro.Visible = False
        L_ResidenciapaisERRO.Visible = False

        'Todos os processos abaixo irão limpar os textos dos campos que forão ou não preenchidos
        N_Ndias.Value = 1
        T_lerNOME.Clear()
        T_lerEMAIL.Clear()
        C_emailDominio.Text = Nothing
        C_comEcombr.Text = Nothing
        T_CelularDDI.Clear()
        M_CelularDDD.Clear()
        M_CelularN.Clear()
        T_TelefoneDDI.Clear()
        M_TelefoneDDD.Clear()
        M_TelefoneN.Clear()
        T_Profissao.Clear()
        C_Nacionalidade.Text = Nothing
        M_DataDeNascimento.Clear()
        C_Genero.Text = Nothing
        C_tipoDeDocumento.Text = Nothing
        M_NdeDocumento.Clear()
        M_OrgaoExpedidor.Clear()
        T_ResidenciaPermanente.Clear()
        C_ResidenciaPais.Text = Nothing
        C_ResidenciaUF.Text = Nothing
        T_ResidenciaCidade.Clear()
        C_UltimaProcedenciaPais.Text = Nothing
        C_UltimaProcedenciaUF.Text = Nothing
        T_ultimaProcedenciaUF.Clear()
        T_UltimaProcedenciaCidade.Clear()
        C_ProximoDestinoPais.Text = Nothing
        C_ProximoDestinoUF.Text = Nothing
        T_próximoDestinoUF.Clear()
        T_ProximoDestinoCidade.Clear()
        T_observação.Clear()
        C_PreferenciaQuarto.Text = Nothing

        'Todos os processo abaixo irão deixar os items que estavam desativos, desativos novamente, e os items que estavam cinza, cinza novamente
        M_NdeDocumento.Enabled = False
        M_NdeDocumento.BackColor = Color.LightGray

        'Este processo de deixar a masca do número de documento igual a nada, e necessario para deixar a tela igual quando foi entrada pela primeira vez na tela de registro
        M_NdeDocumento.Mask = ""
        M_OrgaoExpedidor.Enabled = False
        M_OrgaoExpedidor.BackColor = Color.LightGray

        'Este processos deixar não visivel o TextBox de leitura da residencia e deixar visivel o ComboBox de leitura da residencia, isso é necessario para deixar igual a quando foi entrado pela primeira vez na tela de registro
        T_ResidenciaUF.Visible = False
        C_ResidenciaUF.Visible = True

        T_ResidenciaCidade.Enabled = False
        T_ResidenciaCidade.BackColor = Color.LightGray

        'Este processos deixar não visivel o TextBox de leitura da ultima procedencia e deixar visivel o ComboBox de leitura da ultima procedencia, isso é necessario para deixar igual a quando foi entrado pela primeira vez na tela de registro
        C_UltimaProcedenciaUF.Visible = True
        T_ultimaProcedenciaUF.Visible = False

        C_UltimaProcedenciaUF.Enabled = False
        C_UltimaProcedenciaUF.BackColor = Color.LightGray
        C_ResidenciaUF.Enabled = False
        C_ResidenciaUF.BackColor = Color.LightGray
        C_ProximoDestinoUF.Enabled = False
        C_ProximoDestinoUF.BackColor = Color.LightGray
        T_ultimaProcedenciaUF.Enabled = False
        T_UltimaProcedenciaCidade.BackColor = Color.LightGray

        'Este processos deixar não visivel o TextBox de leitura do próximo destino procedencia e deixar visivel o ComboBox de leitura do próximo destino, isso é necessario para deixar igual a quando foi entrado pela primeira vez na tela de registro
        C_ProximoDestinoUF.Visible = True
        T_próximoDestinoUF.Visible = False

        C_ProximoDestinoUF.Enabled = False
        C_ProximoDestinoUF.BackColor = Color.LightGray
        T_ProximoDestinoCidade.Enabled = False
        T_ProximoDestinoCidade.BackColor = Color.LightGray

        'Então após limpar as mensagem de erro e os campos de cadastro, irá selecionar o 'TextBox' de leitura do nome, para quando o programa voltar na tela de registro novamente, ele comece a digitar pelo começo
        T_lerNOME.SelectAll()
        ActiveControl = T_lerNOME
        'Após isso, programa irá exibir a tela principal e esconder a tela de registro (Me.Hide)
        TelaPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub N_Ndias_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N_Ndias.ValueChanged
        If N_Ndias.Value <= 0 Then
            N_Ndias.Value = 1
        End If
        L_total.Text = N_Ndias.Value * 354

        cad = L_data.Text.Split("/")
        dia = cad(1)
        mes = cad(0)
        ano = cad(2)

        For index = 1 To N_Ndias.Value

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

        L_DataCheckOut.Text = dia.ToString + "/" + mes.ToString + "/" + ano.ToString
    End Sub
End Class