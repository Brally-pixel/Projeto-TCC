Imports System.Data
Imports System.Data.SqlClient
Public Class Cls_login

    Dim Cone As New cls_Conexao
    'txt_Login.text
    Private _Usu_login As String
    Public Property mUsuario() As String
        Get
            Return _Usu_login
        End Get
        Set(ByVal value As String)
            _Usu_login = value
        End Set
    End Property
    'txt_Senha.text
    Private _Usu_senha As String
    Public Property mSenha() As String
        Get
            Return _Usu_senha
        End Get
        Set(ByVal value As String)
            _Usu_senha = value
        End Set
    End Property
    Private _Nivel As String
    Public Property mNivel() As String
        Get
            Return _Nivel
        End Get
        Set(ByVal value As String)
            _Nivel = value
        End Set
    End Property
    Dim mCod_Funci As Integer
    Public Property Cod_Funci() As Integer
        Get
            Return mCod_Funci
        End Get
        Set(ByVal value As Integer)
            mCod_Funci = value
        End Set
    End Property

    Public Function Verifica_Login()
        'Try
        '    Cone.Conectar()
        '    With Cone.cmd
        '        .Connection = Cone.cnn
        '        .CommandText = "SP_Verifica_Login"
        '        .Parameters.AddWithValue("@cadlogin", mUsuario)
        '        .Parameters.AddWithValue("@senha", mSenha)
        '        .CommandType = CommandType.StoredProcedure
        '    End With
        '    Dim mr As SqlDataReader = Cone.cmd.ExecuteReader
        '    Me.Finalize()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    Cone.cmd.Parameters.Clear()
        '    Cone.Desconectar()
        'End Try


        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "VerificaLogin"
                .Parameters.AddWithValue("@cadlogin", mUsuario)
                .Parameters.AddWithValue("@senha", mSenha)
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            If mr.Read = True Then
                'While mr.Read
                '    If mr!Senha <> mSenha Then
                '        Return 2
                '    Else
                _Nivel = mr!Nivel
                Cod_Funci = mr!Cod_fun
                Return 0
                'End If
                'End While
            Else
                Return 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
        Return Nothing

    End Function

    Public Sub SelecionaLogCampos()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable

        Try
            'Cone.Conectar()
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand

                With command
                    .Connection = Cone.cnn
                    .CommandText = ""
                    .Parameters.AddWithValue("@Cod_Con", Cadastro_de_Senha.Cod_Funcionario.Text)
                    .CommandType = CommandType.StoredProcedure
                End With
                Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
                While mr.Read
                    With Cadastro_de_Senha

                        .Login.Text = mr!Nome
                        .Senha.Text = mr!Fax
                        .Confir_Senha.Text = mr!E_mail_Fornecedor

                        For Each o As Object In .CB_Nivel.Items
                            If o.ToString() = mr!UF_Estado Then
                                .CB_Nivel.SelectedItem = o
                            End If
                        Next


                    End With
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try

    End Sub
End Class
