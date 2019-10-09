'Imports System.Data.SqlClient
'Public Class Senha__do_Gerente
'    Dim mValor As Boolean = False
'    Dim Cone As New cls_Conexao
'    Dim objLog As New Cls_Cadastro_Login
'    Dim objProd As New Cls_Produto
'    Public cn As New cls_Conexao
'    Public Z As Integer

'    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

'        Dim cmd As New SqlCommand
'        Try
'            With objLog

'                .Login = txtUsuario.Text
'                .Senha = txtSenha.Text()End With
'                If .ConfirmaGerente() = 0 Then
'                    Select Case Z
'                        Case 1
'                            With objProd
'                                .Nome_Marca = Cadastrar_o_Produto.Carac_Marca.Text
'                                .InsertMarca()

'                            End With
'                            objFun()
'                    End Select
'                End If


'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        Finally
'            cn.Desconectar()
'            cn.cmd.Parameters.Clear()
'        End Try
'    End Sub

'    Private Sub Senha__do_Gerente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

'    End Sub
'End Class