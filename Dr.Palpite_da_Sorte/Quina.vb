Public Class Quina
    Dim numeroq(4) As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Desejamos boa sorte", "Boa Sorte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Principal.Show()
        Close()
    End Sub

    Private Sub ordenacao()
        Dim ordem As Integer

        For t = 0 To 3
            If numeroq(t) > numeroq(t + 1) Then
                ordem = numeroq(t)
                numeroq(t) = numeroq(t + 1)
                numeroq(t + 1) = ordem
                t = -1
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim entrou As Boolean = True

        While entrou
            entrou = False
            For t = 0 To 4
                numeroq(t) = CStr(Int(Rnd() * 81))
                If numeroq(t) = 0 Then
                    t = t- 1
                    entrou = True
                End If

            Next
            ordenacao()
            For t = 1 To 4
                If numeroq(t - 1) = numeroq(t) Then
                    numeroq(t) = CStr(Int(Rnd() * 81))
                    entrou = True
                End If
            Next
        End While

        Label1.Text = numeroq(0)
        Label2.Text = numeroq(1)
        Label3.Text = numeroq(2)
        Label4.Text = numeroq(3)
        Label5.Text = numeroq(4)

    End Sub

    Private Sub Quina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class