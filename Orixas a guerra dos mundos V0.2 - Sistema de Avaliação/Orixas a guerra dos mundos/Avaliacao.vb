Public Class Avaliacao

    Dim StreamWRITER As IO.StreamWriter
    Dim NomeJaExistente As Boolean
    Dim i As Integer = 0

    Function FexarForm()
        'Muda o cusor do programa para o primeiro form, para quando voltar nessa tela o cusor
        'esteja no primeiro capo e não no botão de voltar.
        TB_Nome.SelectAll()
        ActiveControl = TB_Nome
        MenuPrin.Show()
        Me.Hide()
        Return 0
    End Function

    Private Sub B_Voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Voltar.Click
        FexarForm()
    End Sub

    Private Sub Avaliacao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FexarForm()
    End Sub

    'Função para ver se tem algum capo em branco não preenchido, para não gravar algo inexistente.
    Function ItsCelanr()
        Dim CampoVasio As Boolean = False
        If TB_Nome.Text = Nothing Then
            L_ErroNome.Visible = True
            CampoVasio = True
        End If
        If TB_DigitalObserva.Text = Nothing Then
            L_ErroDigitalObserva.Visible = True
            CampoVasio = True
        End If
        If TB_MesaObserva.Text = Nothing Then
            L_ErroMesaObserva.Visible = True
            CampoVasio = True
        End If
        If CB_DigitalCriatividade.Text = Nothing Then
            L_ErroDigitalCriatividade.Visible = True
            CampoVasio = True
        End If
        If CB_DigitalDesgn.Text = Nothing Then
            L_ErroDigitalDesign.Visible = True
            CampoVasio = True
        End If
        If CB_DigitalEntretenimento.Text = Nothing Then
            L_ErroDigitalEntretenimento.Visible = True
            CampoVasio = True
        End If
        If CB_DigitalMecanicas.Text = Nothing Then
            L_ErroDigitalMecanicas.Visible = True
            CampoVasio = True
        End If
        If CB_MesaCriatividade.Text = Nothing Then
            L_ErroMesaCriatividade.Visible = True
            CampoVasio = True
        End If
        If CB_MesaDesign.Text = Nothing Then
            L_ErroMesaDesign.Visible = True
            CampoVasio = True
        End If
        If CB_MesaEntretenimento.Text = Nothing Then
            L_ErroMesaEntretenimento.Visible = True
            CampoVasio = True
        End If
        If CB_DigitalMecanicas.Text = Nothing Then
            L_ErroMesaMecanicas.Visible = True
            CampoVasio = True
        End If
        Return CampoVasio
    End Function

    'Função para desativar o form. São desativados os TextBox e ComboBox.
    Function DisableForm()
        B_Salvar.Enabled = False
        B_Voltar.Enabled = False
        TB_DigitalObserva.Enabled = False
        TB_MesaObserva.Enabled = False
        TB_Nome.Enabled = False
        CB_DigitalCriatividade.Enabled = False
        CB_DigitalDesgn.Enabled = False
        CB_DigitalEntretenimento.Enabled = False
        CB_DigitalMecanicas.Enabled = False
        CB_MesaCriatividade.Enabled = False
        CB_MesaDesign.Enabled = False
        CB_MesaEntretenimento.Enabled = False
        CB_MesaMecanicas.Enabled = False
        Return 0
    End Function

    'Gunção para encrever no  block de notas.
    Function Enviar()
        My.Computer.FileSystem.CreateDirectory(".\Fother")
        If IO.File.Exists("./Fother/" & TB_Nome.Text & ".txt") Then
            NomeJaExistente = True
            i = 0
            While True
                If IO.File.Exists("./Fother/" & TB_Nome.Text & i & ".txt") Then
                    i += 1
                Else
                    Exit While
                End If
            End While
        End If

        If NomeJaExistente = False Then
            ''MessageBox.Show("Nome inexistente")
            StreamWRITER = New IO.StreamWriter("./Fother/" & TB_Nome.Text & ".txt")
        Else
            ''MessageBox.Show("Nome ja existe")
            StreamWRITER = New IO.StreamWriter("./Fother/" & TB_Nome.Text & i & ".txt")
        End If

        StreamWRITER.WriteLine("Nome: " & TB_Nome.Text & vbNewLine)
        StreamWRITER.WriteLine("Jogo de mesa:")
        StreamWRITER.WriteLine("Design: " & CB_MesaDesign.Text)
        StreamWRITER.WriteLine("Criatividade: " & CB_MesaCriatividade.Text)
        StreamWRITER.WriteLine("Mecânica: " & CB_MesaMecanicas.Text)
        StreamWRITER.WriteLine("Entretenimento: " & CB_MesaEntretenimento.Text)
        StreamWRITER.WriteLine("Observações: " & TB_MesaObserva.Text)

        StreamWRITER.WriteLine(vbNewLine & "Jogo digital:")
        StreamWRITER.WriteLine("Design: " & CB_DigitalDesgn.Text)
        StreamWRITER.WriteLine("Criatividade: " & CB_MesaCriatividade.Text)
        StreamWRITER.WriteLine("Mecânica: " & CB_DigitalMecanicas.Text)
        StreamWRITER.WriteLine("Entretenimento: " & CB_DigitalEntretenimento.Text)
        StreamWRITER.WriteLine("Observações: " & TB_DigitalObserva.Text)

        StreamWRITER.Close()
        Return 0
    End Function
    Private Sub B_Salvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Salvar.Click
        'Ve se tem algum campo em branco, se tiver o label do erro corespondente a ele e mostrado.

        If ItsCelanr() = True Then
            Messeges.Show()
            Me.Enabled = False
            Exit Sub
        End If

        Enviar()

        'Depois de gravar volta para a tela principal.
        Me.Hide()
        MenuPrin.Show()
    End Sub

    'Os 'Sub' a seguir serve para limpar a mensagen de erro  quando o campo corespondente for clicado.
    Private Sub TB_Nome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_Nome.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And e.Handled = Char.IsControl(e.KeyChar) And e.Handled = Char.IsWhiteSpace(e.KeyChar)
        L_ErroNome.Visible = False
    End Sub
    Private Sub TB_MesaObserva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_MesaObserva.KeyPress
        L_ErroMesaObserva.Visible = False
    End Sub
    Private Sub TB_DigitalObserva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_DigitalObserva.KeyPress
        L_ErroDigitalObserva.Visible = False
    End Sub
    Private Sub CB_DigitalCriatividade_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_DigitalCriatividade.SelectedIndexChanged
        L_ErroDigitalCriatividade.Visible = False
    End Sub
    Private Sub CB_DigitalDesgn_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_DigitalDesgn.SelectedIndexChanged
        L_ErroDigitalDesign.Visible = False
    End Sub
    Private Sub CB_DigitalEntretenimento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_DigitalEntretenimento.SelectedIndexChanged
        L_ErroDigitalEntretenimento.Visible = False
    End Sub
    Private Sub CB_DigitalMecanicas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_DigitalMecanicas.SelectedIndexChanged
        L_ErroDigitalMecanicas.Visible = False
    End Sub
    Private Sub CB_MesaCriatividade_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_MesaCriatividade.SelectedIndexChanged
        L_ErroMesaCriatividade.Visible = False
    End Sub
    Private Sub CB_MesaDesign_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_MesaDesign.SelectedIndexChanged
        L_ErroMesaDesign.Visible = False
    End Sub
    Private Sub CB_MesaEntretenimento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_MesaEntretenimento.SelectedIndexChanged
        L_ErroMesaEntretenimento.Visible = False
    End Sub
    Private Sub CB_MesaMecanicas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CB_MesaMecanicas.SelectedIndexChanged
        L_ErroMesaMecanicas.Visible = False
    End Sub
End Class