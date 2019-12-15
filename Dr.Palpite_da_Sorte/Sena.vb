Public Class Sena
    Dim numeros(5) As Integer


    Private Sub Sena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub ordenacao()
        Dim espaco As Integer

        For t = 0 To 4
            If numeros(t) > numeros(t + 1) Then
                espaco = numeros(t)
                numeros(t) = numeros(t + 1)
                numeros(t + 1) = espaco
                t = -1
            End If
        Next
    End Sub

    Private Sub btnJogar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJogar.Click
        Dim mudou As Boolean = True

        numeros(0) = CStr(Int(Rnd() * 61))
        numeros(1) = CStr(Int(Rnd() * 61))
        numeros(2) = CStr(Int(Rnd() * 61))
        numeros(3) = CStr(Int(Rnd() * 61))
        numeros(4) = CStr(Int(Rnd() * 61))
        numeros(5) = CStr(Int(Rnd() * 61))

        While mudou
            mudou = False
            For t = 0 To 5
                If numeros(t) = 0 Then
                    numeros(t) = CStr(Int(Rnd() * 10))
                    t = t - 1
                    mudou = True
                End If
            Next
            ordenacao()
            For v = 1 To 5
                If numeros(v - 1) = numeros(v) Then
                    numeros(v) = CStr(Int(Rnd() * 10))
                    v = v - 1
                    mudou = True
                End If
            Next
        End While

        Label1.Text = numeros(0)
        Label2.Text = numeros(1)
        Label3.Text = numeros(2)
        Label4.Text = numeros(3)
        Label5.Text = numeros(4)
        Label6.Text = numeros(5)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Desejamos boa sorte", "Boa Sorte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Principal.Show()
        Close()
    End Sub
End Class