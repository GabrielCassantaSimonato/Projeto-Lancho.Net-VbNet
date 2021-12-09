Public Class inicio

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            Label4.Text = "Iniciando o sistema"
        ElseIf ProgressBar1.Value <= 30 Then
            Label4.Text = "Carregando banco de dados"

        ElseIf ProgressBar1.Value <= 50 Then
            Label4.Text = "Carregando cardápio"

        ElseIf ProgressBar1.Value <= 70 Then
            Label4.Text = "Carregando gerenciamento"

        ElseIf ProgressBar1.Value <= 90 Then
            Label4.Text = "Bem vindo ao Lancho.NET!"
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class