Imports System.Data
Imports System.Data.SqlClient
Public Class Efetuar_Login
    Public cn As New cls_Conexao
    Dim objLog As New Cls_login
    Dim Cone As New cls_Conexao
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        label3.Text = TimeOfDay
        label4.Text = DateString
    End Sub
    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSair.Click
        Application.Exit()
    End Sub
    Public cmd As New SqlClient.SqlCommand
    Dim mr As SqlDataReader
    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click

        Try
            With objLog
                .mUsuario = txtUsuario.Text
                .mSenha = txtSenha.Text()

                .Verifica_Login()

                ''If mr!cad_login = objLog.mUsuario And mr!senha = objLog.mSenha And mr!Nivel = 1 Then
                ''    Menu_Principal_Gerente.Show()
                ''    Menu_Principal_Gerente.Nome_Funcio.Text = objLog.mUsuario
                ''ElseIf mr!Nivel = 2 Then
                ''    Menu_Principal.Show()
                ''End If

                If .Verifica_Login() = 0 Then

                    If .mNivel = "1" Then
                        Menu_Principal_Gerente.Show()
                    ElseIf .mNivel = "2" Then
                        Menu_Principal_Gerente.CadastroDoFuncionaroToolStripMenuItem.Enabled = True
                        Menu_Principal_Gerente.ContatoFornecedorToolStripMenuItem.Enabled = True
                        Menu_Principal_Gerente.DepartamentoToolStripMenuItem3.Enabled = True
                        ' Menu_Principal_Gerente.EstoqueFornecedorToolStripMenuItem.Enabled = True
                        Menu_Principal_Gerente.CadastroDoFuncionaroToolStripMenuItem.Enabled = True

                        Menu_Principal.Show()
                    End If
                    Menu_Principal_Gerente.Nome_Funcio.Text = objLog.mUsuario()
                    Me.Finalize()
                ElseIf .Verifica_Login = 1 Then
                    MsgBox("Usuário não registrado")
                    'ElseIf .VerificaLogin = 2 Then
                    '    MsgBox("Senha inválida")
                End If

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Efetuar_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
