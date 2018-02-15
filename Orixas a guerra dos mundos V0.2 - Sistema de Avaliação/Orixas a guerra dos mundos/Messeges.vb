Public Class Messeges

    Function CloseThisForm()
        Avaliacao.Enabled = True
        Return 0
    End Function

    Private Sub Messeges_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CloseThisForm()
    End Sub
    Private Sub B_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Ok.Click
        CloseThisForm
        Avaliacao.Show()
        Me.Close()
    End Sub
End Class