Imports System.Data.SqlClient
Public Class Cls_Cadastro_Login
    Private mCod_Fun As Integer
    Private mLogin As String
    Private mSenha As String
    Private mNivel As String

    Dim Cone As New cls_Conexao
    Public Property Cod_Fun() As Integer
        Get
            Return mCod_Fun
        End Get
        Set(ByVal value As Integer)
            mCod_Fun = value
        End Set
    End Property
    Public Property Login() As String
        Get
            Return mLogin
        End Get
        Set(ByVal value As String)
            mLogin = value
        End Set
    End Property
    Public Property Senha() As String
        Get
            Return mSenha
        End Get
        Set(ByVal value As String)
            mSenha = value
        End Set
    End Property
    Public Property Nivel() As String
        Get
            Return mNivel
        End Get
        Set(ByVal value As String)
            mNivel = value
        End Set
    End Property

    Public Sub InsertLogin()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Cadastrar_Login"
                .Parameters.AddWithValue("@Cod_fun", mCod_Fun)
                .Parameters.AddWithValue("@cad_login", mLogin)
                .Parameters.AddWithValue("@senha", mSenha)
                .Parameters.AddWithValue("@Nivel", mNivel)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub


   
End Class
