Public Class Form1
    Dim chave(6) As Integer
    Sub mostra_numeros()
        lblBola1.Text = chave(0)
        lblBola2.Text = chave(1)
        lblBola3.Text = chave(2)
        lblBola4.Text = chave(3)
        lblBola5.Text = chave(4)
        lblEstrela1.Text = chave(5)
        lblEstrela2.Text = chave(6)
    End Sub

    Private Sub btnOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
        Dim numero1, numero2 As Integer

        Array.Sort(chave, 0, 5)
        mostra_numeros()
        btnOrdenar.Visible = False

        numero1 = lblEstrela1.Text
        numero2 = lblEstrela2.Text

        If numero2 > numero1 Then
            lblEstrela1.Text = numero1
            lblEstrela2.Text = numero2
        Else
            lblEstrela1.Text = numero2
            lblEstrela2.Text = numero1
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub btnExtracao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtracao.Click
        Dim x, bola, num_bola, y, estrela, num_estrela As Byte
        Dim repetida As Boolean
        Randomize()
        num_bola = 0
        num_estrela = 5

        Do While num_bola <= 4
            bola = Int(Rnd() * 49 + 1)
            For x = 0 To num_bola
                If chave(x) = bola Then
                    repetida = True
                    Exit For
                Else
                    repetida = False
                End If
            Next
            If repetida = False Then
                chave(num_bola) = bola
                num_bola += 1
            End If
        Loop

        Do While num_estrela <= 6
            estrela = Int(Rnd() * 11 + 1)
            For y = 5 To num_estrela
                If chave(y) = estrela Then
                    repetida = True
                    Exit For
                Else
                    repetida = False
                End If
            Next
            If repetida = False Then
                chave(num_estrela) = estrela
                num_estrela += 1
            End If
        Loop
        btnOrdenar.Visible = True
        mostra_numeros()
    End Sub
End Class
