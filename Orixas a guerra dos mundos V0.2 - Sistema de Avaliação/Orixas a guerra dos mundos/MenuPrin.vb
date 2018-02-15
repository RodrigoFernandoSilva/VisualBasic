Public Class MenuPrin

    Private Sub B_AvalidarJogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_AvalidarJogo.Click
        'Prepara a tela de avaliação zerando todos os campos, para caso o usuário use o programa duas veses
        'a tela de avaliação esteja com os capos e menssagens de textos livres e limpo.
        'Limmpa os capos de digitação:
        Avaliacao.TB_Nome.Clear()
        Avaliacao.TB_MesaObserva.Clear()
        Avaliacao.TB_DigitalObserva.Clear()
        Avaliacao.CB_DigitalCriatividade.Text = Nothing
        Avaliacao.CB_DigitalDesgn.Text = Nothing
        Avaliacao.CB_DigitalEntretenimento.Text = Nothing
        Avaliacao.CB_DigitalMecanicas.Text = Nothing
        Avaliacao.CB_MesaCriatividade.Text = Nothing
        Avaliacao.CB_MesaDesign.Text = Nothing
        Avaliacao.CB_MesaEntretenimento.Text = Nothing
        Avaliacao.CB_MesaMecanicas.Text = Nothing

        'Esconde os label de mensagens de erro, esse label tem um "*" como texto de erro.
        Avaliacao.L_ErroNome.Visible = False
        Avaliacao.L_ErroDigitalCriatividade.Visible = False
        Avaliacao.L_ErroDigitalDesign.Visible = False
        Avaliacao.L_ErroDigitalEntretenimento.Visible = False
        Avaliacao.L_ErroDigitalMecanicas.Visible = False
        Avaliacao.L_ErroDigitalObserva.Visible = False
        Avaliacao.L_ErroMesaCriatividade.Visible = False
        Avaliacao.L_ErroMesaDesign.Visible = False
        Avaliacao.L_ErroMesaEntretenimento.Visible = False
        Avaliacao.L_ErroMesaMecanicas.Visible = False
        Avaliacao.L_ErroMesaObserva.Visible = False

        Avaliacao.Show()
        Me.Hide()
    End Sub

    Private Sub Menu_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub MenuPrin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Avaliacao.Show()
        Avaliacao.Hide()
    End Sub
End Class
