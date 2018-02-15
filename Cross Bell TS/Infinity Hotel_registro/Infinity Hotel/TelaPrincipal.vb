Public Class TelaPrincipal

    Private Sub TelaPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub B_CheckIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_CheckIn.Click
        Registro.Show()
        Me.Hide()
    End Sub

    Private Sub B_Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Sair.Click
        senha.Show()
        Me.Hide()
    End Sub

    Private Sub B_CheckOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_CheckOut.Click
        CheckOut.Show()
        Me.Hide()
    End Sub

    Private Sub B_Quartos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Quartos.Click
        Quartos.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        L_hora.Text = TimeString
    End Sub
End Class