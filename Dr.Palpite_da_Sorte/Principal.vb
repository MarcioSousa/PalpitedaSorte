Public Class Principal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnMegaSena_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMegaSena.Click
        Sena.Show()
        Me.Hide()
    End Sub

    Private Sub btnLotomania_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLotomania.Click
        Lotomania.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuina.Click
        Quina.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.facebook.com/pages/Dr-Hardware/385320148204842?bookmark_t=page")
    End Sub
End Class