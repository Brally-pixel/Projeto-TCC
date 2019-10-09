Public Class Tela_Inicial
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 1 Then
            Label1.Text = "Carregando Sistema"
        End If
        If ProgressBar1.Value = 20 Then
            Label1.Text = "Carregando o banco de dados"
        End If
        If ProgressBar1.Value = 40 Then
            Label1.Text = "Carregando padrões do windows"
        End If
        If ProgressBar1.Value = 60 Then
            Label1.Text = "Carregando configurações de proprietario"
        End If
        If ProgressBar1.Value = 80 Then
            Label1.Text = "Carregando Layout do sistema"
        End If

        If ProgressBar1.Value = "100" Then

            Efetuar_Login.Show()
            Me.Finalize()
        End If

    End Sub

    Private Sub Tela_Inicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class