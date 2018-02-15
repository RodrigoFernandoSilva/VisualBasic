Public Class senha
    'Variaveis dia, mes e ano, irão ser usada pra salvar o valor da data do dia atual, para imverter ela na hora de exibir na tela, porque a data vem na forma americana de se ver.
    Dim dia As Integer = 0
    Dim mes As Integer = 0
    Dim ano As Integer = 0
    Dim cad(3) As String
    'Variaveis x e x1 irão ser usada para salvar temporariamente valores ou resultados de contas.
    Dim x As Integer = 0
    Dim x1 As Integer = 0

    'Este 'sub' é pra caso o usuário aperte o botão 'x' da tela de senha, feche o programa todo. Isso é necessario devido a algums formularios estarem apenas escondidos, e por eles estarem escondidos, so apertando o botão 'x' sem esse 'sub' não iria fechar eles.
    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    'Este 'sub' é pra caso o usuario aperte o botão Entrar,
    Private Sub B_Entrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Entrar.Click
        'Caso o usuário aperte ele, então irá ver se a senha digitada é igual a 1234
        If M_senhaENTRAR.Text = "1234" Then
            'Caso senha e senha serta, irá voltar a seleção para o campo da senha e limpar ela para caso o usuário volte depois para esse formulario, não apareça mais a senha.
            ActiveControl = M_senhaENTRAR
            M_senhaENTRAR.Text = Nothing
            'Este processos irá abrir a tela principal do programa e fechar a tela de senha de segurança.
            TelaPrincipal.Show()
            Me.Hide()
        Else
            'Caso o usuário digite a senha errada, irá limpar o campo de senha e selecionar ela pra digitação.
            M_senhaENTRAR.Text = Nothing
            ActiveControl = M_senhaENTRAR
        End If
    End Sub

    'Este 'sub' ´r para caso o usuário aperte 'enter' ou 'Escape' no campo de leitura de senha
    Private Sub M_senhaEMTRAR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles M_senhaENTRAR.KeyDown
        'Caso o usuário aperte 'enter', então irá fazer o mesmo critério e validação do botão "Entrar".
        If e.KeyCode = Keys.Enter Then
            If M_senhaENTRAR.Text = "1234" Then
                M_senhaENTRAR.Text = Nothing
                TelaPrincipal.Show()
                Me.Hide()
            Else
                'A unica diferemça é que não é necessario ativar pra digitação o campo de senha, caso ela esteja errada.
                M_senhaENTRAR.Text = Nothing
            End If
        End If
        'Este 'if' é pra caso o usuário aperte 'Escape' no campo de digitação da senha.
        If e.KeyCode = Keys.Escape Then
            'Se ele apertar 'Escape', então irá fechar todo o programa.
            End
        End If
    End Sub

    'Este 'sub' e para mandar a hora e a data para todos os outros forms
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Primeiro irá salvar a data e a hora nos 'label' desse formulario.
        L_data.Text = Today
        L_hora.Text = TimeString

        'Então irá separar a data em um variavel chamada 'cad' com o "/" usamdo o split
        cad = L_data.Text.Split("/")

        'Então após isso ira ebibir no 'label' da data, a data serta na forma brasileira, ja que se eu não invertece o 'cad(0)' pelo 'cad(1)' a data ficaria na forma americana. 
        L_data.Text = cad(1) + "/" + cad(0) + "/" + cad(2)

        'Após isso, irá destribuir a data e a hora  para todos os outros forms.
        DadosDoHospede.L_data.Text = L_data.Text()
        DadosDoHospede.L_hora.Text = L_hora.Text()
        Registro.L_hora.Text = L_hora.Text
        Registro.L_data.Text = L_data.Text
        Registro.L_DataCheckIn.Text = L_data.Text
        Quartos.L_data.Text = L_data.Text()
        Quartos.L_hora.Text = L_hora.Text()
        SenhaAlteração.L_hora.Text = L_hora.Text()
        SenhaAlteração.L_data.Text = L_data.Text()
        TelaPrincipal.L_data.Text = L_data.Text()
        TelaPrincipal.L_hora.Text = L_hora.Text()
        CheckOut.L_data.Text = L_data.Text()
        CheckOut.L_hora.Text = L_hora.Text()
    End Sub
End Class