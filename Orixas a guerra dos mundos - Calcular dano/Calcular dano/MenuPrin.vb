Public Class MenuPrin

    Public OrumVidas(10) As Integer
    Public AiyeVidas(10) As Integer

    Function ComboBoxPrinLife()
        For index = 0 To 9
            ComB_Orum.Items(index) = ComB_OrumNames.Items(index) + " | Vida: " + OrumVidas(index).ToString
            ComB_Aiye.Items(index) = ComB_AiyeNames.Items(index) + " | Vida: " + AiyeVidas(index).ToString
        Next
        Return 0
    End Function

    Private Sub CheB_BonusOrum_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheB_BonusOrum.CheckedChanged
        If CheB_BonusAiye.Checked = True Then
            CheB_BonusOrum.Checked = False
        End If
    End Sub

    Private Sub CheB_BonusAiye_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheB_BonusAiye.CheckedChanged
        If CheB_BonusOrum.Checked = True Then
            CheB_BonusAiye.Checked = False
        End If
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComB_Orum.SelectedIndex = 0
        ComB_Aiye.SelectedIndex = 0
        RadB_AtkOrum.Checked = True
        OrumVidas(0) = 100
        OrumVidas(1) = 80
        OrumVidas(2) = 90
        OrumVidas(3) = 60
        OrumVidas(4) = 70
        OrumVidas(5) = 55
        OrumVidas(6) = 50
        OrumVidas(7) = 40
        OrumVidas(8) = 30
        OrumVidas(9) = 20

        AiyeVidas(0) = 100
        AiyeVidas(1) = 80
        AiyeVidas(2) = 90
        AiyeVidas(3) = 60
        AiyeVidas(4) = 70
        AiyeVidas(5) = 55
        AiyeVidas(6) = 50
        AiyeVidas(7) = 40
        AiyeVidas(8) = 30
        AiyeVidas(9) = 20

        ComboBoxPrinLife()
    End Sub

    Private Sub ComB_Orum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComB_Orum.SelectedIndexChanged
        If ComB_Orum.SelectedIndex = 0 Then
            PicB_Orum.Image = My.Resources.Orum_0
            Exit Sub
        ElseIf ComB_Orum.SelectedIndex = 1 Then
            PicB_Orum.Image = My.Resources.Orum_1
            Exit Sub
        ElseIf ComB_Orum.SelectedIndex = 2 Then
            PicB_Orum.Image = My.Resources.Orum_2
            Exit Sub
        ElseIf ComB_Orum.SelectedIndex = 3 Then
            PicB_Orum.Image = My.Resources.Orum_3
            Exit Sub
        ElseIf ComB_Orum.SelectedIndex = 4 Then
            PicB_Orum.Image = My.Resources.Orum_4
            Exit Sub
        ElseIf ComB_Orum.SelectedIndex = 5 Then
            PicB_Orum.Image = My.Resources.Orum_5
            Exit Sub
        ElseIf ComB_Orum.SelectedIndex = 6 Then
            PicB_Orum.Image = My.Resources.Orum_6
            Exit Sub
        ElseIf ComB_Orum.SelectedIndex = 7 Then
            PicB_Orum.Image = My.Resources.Orum_7
            Exit Sub
        ElseIf ComB_Orum.SelectedIndex = 8 Then
            PicB_Orum.Image = My.Resources.Orum_8
            Exit Sub
        ElseIf ComB_Orum.SelectedIndex = 9 Then
            PicB_Orum.Image = My.Resources.Orum_9
            Exit Sub
        End If
    End Sub


    Private Sub ComB_Aiye_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComB_Aiye.SelectedIndexChanged
        If ComB_Aiye.SelectedIndex = 0 Then
            PicB_Aiye.Image = My.Resources.Aiye_0
            Exit Sub
        ElseIf ComB_Aiye.SelectedIndex = 1 Then
            PicB_Aiye.Image = My.Resources.Aiye_1
            Exit Sub
        ElseIf ComB_Aiye.SelectedIndex = 2 Then
            PicB_Aiye.Image = My.Resources.Aiye_2
            Exit Sub
        ElseIf ComB_Aiye.SelectedIndex = 3 Then
            PicB_Aiye.Image = My.Resources.Aiye_3
            Exit Sub
        ElseIf ComB_Aiye.SelectedIndex = 4 Then
            PicB_Aiye.Image = My.Resources.Aiye_4
            Exit Sub
        ElseIf ComB_Aiye.SelectedIndex = 5 Then
            PicB_Aiye.Image = My.Resources.Aiye_5
            Exit Sub
        ElseIf ComB_Aiye.SelectedIndex = 6 Then
            PicB_Aiye.Image = My.Resources.Aiye_6
            Exit Sub
        ElseIf ComB_Aiye.SelectedIndex = 7 Then
            PicB_Aiye.Image = My.Resources.Aiye_7
            Exit Sub
        ElseIf ComB_Aiye.SelectedIndex = 8 Then
            PicB_Aiye.Image = My.Resources.Aiye_8
            Exit Sub
        ElseIf ComB_Aiye.SelectedIndex = 9 Then
            PicB_Aiye.Image = My.Resources.Aiye_9
            Exit Sub
        End If
    End Sub

    Private Sub B_Batahlar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Batahlar.Click
        If Not OrumVidas(ComB_Orum.SelectedIndex) = 0 And Not AiyeVidas(ComB_Aiye.SelectedIndex) = 0 Then
            ComB_Orum.SelectAll()
            ActiveControl = ComB_Orum
            Batalhar.Show()
            Me.Hide()
        Else
            If OrumVidas(ComB_Orum.SelectedIndex) = 0 Then
                MessageBox.Show(ComB_OrumNames.Items(ComB_Orum.SelectedIndex) & " já esta morto!!!")
            Else
                MessageBox.Show(ComB_AiyeNames.Items(ComB_Aiye.SelectedIndex) & " já esta morto!!!")
            End If

            End If
    End Sub
End Class
