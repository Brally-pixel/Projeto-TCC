Imports System.Data.SqlClient
Public Class ClsContas
    Private mCod_Conta As Integer
    Private mDescricao_Conta As String
    Private mValor_Conta As Integer
    Private mValor_Pago_Conta As Integer
    Private mData_Pag_Conta As Date
    Private mResponsavel_Conta As String
    Private mCod_Fun_Conta As Integer
    Private mData_Ven_Conta As Date

    Dim Cone As New cls_Conexao
    Public Property Cod_Conta() As Integer
        Get
            Return mCod_Conta
        End Get
        Set(ByVal value As Integer)
            mCod_Conta = value
        End Set
    End Property
    Public Property Descricao_Conta() As String
        Get
            Return mDescricao_Conta
        End Get
        Set(ByVal value As String)
            mDescricao_Conta = value
        End Set
    End Property
    Public Property Valor_Conta() As Integer
        Get
            Return mValor_Conta
        End Get
        Set(ByVal value As Integer)
            mValor_Conta = value
        End Set
    End Property
    Public Property Valor_Pago_Conta() As Integer
        Get
            Return mValor_Pago_Conta
        End Get
        Set(ByVal value As Integer)
            mValor_Pago_Conta = value
        End Set
    End Property
    Public Property Data_Pag_Conta() As Date
        Get
            Return mData_Pag_Conta
        End Get
        Set(ByVal value As Date)
            mData_Pag_Conta = value
        End Set
    End Property
    Public Property Data_Ven_Conta() As Date
        Get
            Return mData_Ven_Conta
        End Get
        Set(ByVal value As Date)
            mData_Ven_Conta = value
        End Set
    End Property
    Public Property Responsavel_Conta() As String
        Get
            Return mResponsavel_Conta
        End Get
        Set(ByVal value As String)
            mResponsavel_Conta = value
        End Set
    End Property
    Public Property Cod_Fun_Conta() As Integer
        Get
            Return mCod_Fun_Conta
        End Get
        Set(ByVal value As Integer)
            mCod_Fun_Conta = value
        End Set
    End Property
    Dim mStatus_Cont As String
    Public Property Status_Cont() As String
        Get
            Return mStatus_Cont
        End Get
        Set(ByVal value As String)
            mStatus_Cont = value
        End Set
    End Property

    Public Sub InsertContas()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Cadastrar_Conta"
                .Parameters.AddWithValue("@Descricao_conta", mDescricao_Conta)
                .Parameters.AddWithValue("@Responsavel", mResponsavel_Conta)
                .Parameters.AddWithValue("@Data_de_Pagamento", mData_Pag_Conta)
                .Parameters.AddWithValue("@Data_de_Vencimento", mData_Ven_Conta)
                .Parameters.AddWithValue("@Valor_da_Conta", mValor_Conta)
                .Parameters.AddWithValue("@Valor_Pago", mValor_Pago_Conta)
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

    Public Sub Mostrar_Fun()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "select Nome  from Cadastro_Funcionario "
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Cadastrar_Tipo_de_Conta.CB_Responsavel.Items.Add(mr("Nome").ToString)
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub
End Class
