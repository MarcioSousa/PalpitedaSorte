Public Class Lotomania
    Dim numerol(19) As Integer

    Private Sub Lotomania_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub ordenacao()
        Dim arrumacao As Integer

        For t = 1 To 19
            If numerol(t - 1) > numerol(t) Then
                arrumacao = numerol(t - 1)
                numerol(t - 1) = numerol(t)
                numerol(t) = arrumacao
                t = 0
            End If

        Next
    End Sub

    Private Sub btnJogar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJogar.Click
        Dim entrou As Boolean = True

        For t = 0 To 19
            numerol(t) = CStr(Int(Rnd() * 100))
        Next

        While entrou = True
            entrou = False
            ordenacao()
            For t = 1 To 19
                If numerol(t - 1) = numerol(t) Then
                    numerol(t) = CStr(Int(Rnd() * 100))
                    entrou = True
                End If
            Next
        End While


        Label1.Text = numerol(0)
        Label2.Text = numerol(1)
        Label3.Text = numerol(2)
        Label4.Text = numerol(3)
        Label5.Text = numerol(4)
        Label6.Text = numerol(5)
        Label7.Text = numerol(6)
        Label8.Text = numerol(7)
        Label9.Text = numerol(8)
        Label10.Text = numerol(9)
        Label11.Text = numerol(10)
        Label12.Text = numerol(11)
        Label13.Text = numerol(12)
        Label14.Text = numerol(13)
        Label15.Text = numerol(14)
        Label16.Text = numerol(15)
        Label17.Text = numerol(16)
        Label18.Text = numerol(17)
        Label19.Text = numerol(18)
        Label20.Text = numerol(19)

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        MessageBox.Show("Desejamos boa sorte", "Boa Sorte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Principal.Show()
        Close()
    End Sub
End Class