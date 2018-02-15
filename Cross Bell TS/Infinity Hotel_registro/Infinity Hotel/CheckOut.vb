Public Class CheckOut
    Dim x As Integer = 0
    Dim cad(30) As String
    Dim linha As String
    Dim streamREADER As IO.StreamReader
    Dim streamWRITE As IO.StreamWriter
    Private Sub CheckOut_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x = 0
        If M_Nome.Text <> Nothing And C_TipoDeDocumento.Text <> Nothing And (T_CPF_PASSAPORTE.Text <> Nothing And M_CPF_PASSAPORTE.Text <> Nothing) Then
            If IO.File.Exists("Infinity Hotel.REGISTRO") Then
                streamWRITE = New IO.StreamWriter("new.txt")
                streamREADER = New IO.StreamReader("Infinity Hotel.REGISTRO")
                While Not streamREADER.EndOfStream
                    linha = streamREADER.ReadLine()
                    cad = linha.Split(";")
                    'Label1.Text = linha
                    'MessageBox.Show("Nome: " + cad(22))
                    If cad(0) = M_Nome.Text And (cad(8) = T_CPF_PASSAPORTE.Text Or cad(8) = M_CPF_PASSAPORTE.Text) Then
                        If MessageBox.Show("Confirmar exclusão de registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            streamREADER.Close()
                            x = 1
                        End If
                    Else
                        streamWRITE.WriteLine(linha)
                    End If
                End While
                streamREADER.Close()
                streamWRITE.Close()
                If x <> 1 Then
                    IO.File.Delete("Infinity Hotel.REGISTRO")
                    IO.File.Move("new.txt", "Infinity Hotel.REGISTRO")
                    x = 0
                    TelaPrincipal.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("ERRO, hospede não registrado", "ERRO Critico", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                TelaPrincipal.Show()
                Me.Hide()
            Else
                MessageBox.Show("ERRO, ao abrir o arquivo", "ERRO Critico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("ERRO, Dados não preenchidos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If M_Nome.Text = Nothing Then
                L_NomeERRO.Visible = True
                L_NomeERRO.Text = "*Nome inexistente*"
            End If
            If C_TipoDeDocumento.Text = Nothing Then
                L_TipoDeDocumentoERRO.Visible = True
                L_TipoDeDocumentoERRO.Text = "*Tipo de documento inexistente*"
            End If
            If T_CPF_PASSAPORTE.Text = Nothing Or Not M_CPF_PASSAPORTE.MaskCompleted Then
                L_CPF_PASSAPORTEerro.Visible = True
                L_CPF_PASSAPORTEerro.Text = "*Número de documento inexistente*"
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        TelaPrincipal.Show()
    End Sub

    Private Sub M_Nome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles M_Nome.KeyPress
        L_NomeERRO.Visible = False
    End Sub

    Private Sub C_TipoDeDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_TipoDeDocumento.SelectedIndexChanged
        L_TipoDeDocumentoERRO.Visible = False
        M_CPF_PASSAPORTE.Enabled = True
        If C_TipoDeDocumento.Text = "CPF" Then
            M_CPF_PASSAPORTE.Clear()
            M_CPF_PASSAPORTE.Visible = True
            T_CPF_PASSAPORTE.Visible = False
        Else
            T_CPF_PASSAPORTE.Clear()
            T_CPF_PASSAPORTE.Visible = True
            M_CPF_PASSAPORTE.Visible = False
        End If
    End Sub

    Private Sub M_CPF_PASSAPORTE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles M_CPF_PASSAPORTE.KeyPress
        L_CPF_PASSAPORTEerro.Visible = False
    End Sub

    Private Sub T_CPF_PASSAPORTE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T_CPF_PASSAPORTE.TextChanged
        L_CPF_PASSAPORTEerro.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        L_hora.Text = TimeString
    End Sub
End Class