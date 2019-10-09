Imports System.Data.SqlClient
Public Class Cadastro_de_Senha
    Public cn As New cls_Conexao
    Dim objLogin As New Cls_Cadastro_Login
    Dim objCls_Login As New Cls_login
    Dim objLimpar As New Cls_Limpar
    Dim Cone As New cls_Conexao

    Dim m As Integer = 0
    Dim m2 As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            With objLogin
                If Cod_Funcionario.Text = "" Then
                    MsgBox("Campo não preenchido!")
                    Cod_Funcionario.Select()
                    m2 = 1

                ElseIf Login.Text = "" Then
                    MsgBox("Campo inválido")
                    Login.Select()
                    m2 = 1

                ElseIf Senha.Text = "" Then
                    MsgBox("Campo inválido")
                    Senha.Select()
                    m2 = 1
                ElseIf CB_Nivel.SelectedIndex = -1 Then
                    MsgBox("Campo inválido")
                    CB_Nivel.Select()
                    m2 = 1
                End If

                .Cod_Fun = Cod_Funcionario.Text
                .Login = Login.Text()
                .Senha = Senha.Text
                If Senha.Text <> Confir_Senha.Text Then
                    MsgBox("A senha não confere", MsgBoxStyle.Critical, "Erro")
                    Senha.Text = ""
                    Confir_Senha.Text = ""
                    Senha.Focus()
                    Exit Sub
                End If

                If CB_Nivel.SelectedItem = "Administrador" = True Then
                    .Nivel = 1
                ElseIf CB_Nivel.SelectedItem = "Funcionario" = True Then
                    .Nivel = 2
                End If
                .InsertLogin()


                MsgBox("Senha Cadastrada")
                objLimpar.LimpaCampos(Me)
                Cod_Funcionario.Focus()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        objLimpar.LimpaCampos(Me)
    End Sub

    Private Sub Cadastro_de_Senha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cod_Funcionario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cod_Funcionario.TextChanged
        objCls_Login.SelecionaLogCampos()
    End Sub
End Class