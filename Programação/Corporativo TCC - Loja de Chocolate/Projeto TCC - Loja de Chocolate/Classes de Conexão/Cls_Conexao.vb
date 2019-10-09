Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class cls_Conexao
    'Public cnn As New SqlConnection("Data Source=localhost;Initial Catalog=TCC;Persist Security Info=True;User ID=sa;Password=123456")
    Public cnn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
    Public cmd As New SqlCommand

    Function Conectar() As Boolean
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        If cnn.State = ConnectionState.Open Then
            Conectar = True
        Else
            Conectar = False
        End If
        Return Conectar
    End Function
    Function Desconectar() As Boolean
        If cnn.State = ConnectionState.Open Then
            cnn.Close()
        End If
        If cnn.State = ConnectionState.Closed Then
            Desconectar = True
        Else
            Desconectar = False
        End If
        Return Desconectar
    End Function

    Function Restore() As Boolean
        If cnnrestore.State = ConnectionState.Closed Then
            cnnrestore.Open()
        End If
        If cnnrestore.State = ConnectionState.Open Then
            Restore = True
        Else
            Restore = False
        End If
        Return Restore
    End Function
    Function DesconectarRestore() As Boolean
        If cnnrestore.State = ConnectionState.Open Then
            cnnrestore.Close()
        End If
        If cnnrestore.State = ConnectionState.Closed Then
            DesconectarRestore = True
        Else
            DesconectarRestore = False
        End If
        Return DesconectarRestore
    End Function
    Public cnnrestore As New SqlConnection("Data Source=localhost;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=123456")
    'Public cmd As New SqlClient.SqlCommand
    'Public ler As SqlClient.SqlDataReader
    'Private _Usu_login As String
    'Public Property txtUsuario() As String
    '    Get
    '        Return _Usu_login
    '    End Get
    '    Set(ByVal value As String)
    '        _Usu_login = value
    '    End Set
    'End Property

    ''txt_Senha.text
    'Private _Usu_senha As String
    'Public Property txtSenha() As String
    '    Get
    '        Return _Usu_senha
    '    End Get
    '    Set(ByVal value As String)
    '        _Usu_senha = value
    '    End Set
    'End Property
    'Public Sub Verifica_Login()
    '    Try
    '        cn.Open()
    '        cmd.Connection = cn
    '        cmd.CommandText = "select * from Cad_Login where Cad_Login='" & txtUsuario & "' and senha='" & txtSenha & "'"
    '        ler = cmd.ExecuteReader
    '        If Not ler.Read Then
    '            MsgBox("Usuário ou senha invalidos!!! Tente novamente!!!", MsgBoxStyle.Information, "Erro")
    '            Login.txtUsuario.Text = ""
    '            Login.txtSenha.Text = ""
    '            Login.txtUsuario.Focus()
    '        Else
    '            Menu_Principal_Gerente.Show()
    '            Login.Close()
    '        End If
    '    Catch ex As SqlClient.SqlException
    '        Throw ex
    '    Finally
    '        cn.Close()
    '        cmd.Dispose()
    '    End Try
    'End Sub
End Class
