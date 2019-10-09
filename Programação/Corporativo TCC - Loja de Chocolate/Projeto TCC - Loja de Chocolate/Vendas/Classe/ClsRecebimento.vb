Imports System.Data.SqlClient
Public Class ClsRecebimento
    Dim Cone As New cls_Conexao
    Private mCod_Receb As Integer
    Private mCod_Venda As Integer
    Private mCodForma_Pag As Integer
    Private mDataReceb As Date
    Private mValorReceb As Decimal
    Private mStatus_Pag As String
    Private mEstado As Char
    Private mMes As Integer
    Private mAno As Integer
    Private mVmenor As Decimal
    Private mVmaior As Decimal
    Public Property Cod_Receb() As Integer
        Get
            Return mCod_Receb
        End Get
        Set(ByVal value As Integer)
            mCod_Receb = value
        End Set
    End Property
    Public Property Cod_Venda() As Integer
        Get
            Return mCod_Venda
        End Get
        Set(ByVal value As Integer)
            mCod_Venda = value
        End Set
    End Property
    Public Property CodForma_Pag() As Integer
        Get
            Return mCodForma_Pag
        End Get
        Set(ByVal value As Integer)
            mCodForma_Pag = value
        End Set
    End Property
    Public Property DataReceb() As Date
        Get
            Return mDataReceb
        End Get
        Set(ByVal value As Date)
            mDataReceb = value
        End Set
    End Property
    Public Property ValorReceb() As Decimal
        Get
            Return mValorReceb
        End Get
        Set(ByVal value As Decimal)
            mValorReceb = value
        End Set
    End Property
    Public Property Status_Pag() As String
        Get
            Return mStatus_Pag
        End Get
        Set(ByVal value As String)
            mStatus_Pag = value
        End Set
    End Property
    Public Property Estado() As Char
        Get
            Return mEstado
        End Get
        Set(ByVal value As Char)
            mEstado = value
        End Set
    End Property
    Public Property Vmaior() As Decimal
        Get
            Return mVmaior
        End Get
        Set(ByVal value As Decimal)
            mVmaior = value
        End Set
    End Property
    Public Property Vmenor() As Decimal
        Get
            Return mVmenor
        End Get
        Set(ByVal value As Decimal)
            mVmenor = value
        End Set
    End Property
    Public Property Mes() As Integer
        Get
            Return mMes
        End Get
        Set(ByVal value As Integer)
            mMes = value
        End Set
    End Property
    Public Property Ano() As Integer
        Get
            Return mAno
        End Get
        Set(ByVal value As Integer)
            mAno = value
        End Set
    End Property
    Public Sub InsertRecebimento()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "IncluiRecebimento"
                .Parameters.AddWithValue("@Cod_Venda", mCod_Venda)
                .Parameters.AddWithValue("@Cod_Receb", mCod_Receb)
                .Parameters.AddWithValue("@CodForma_Pag", mCodForma_Pag)
                .Parameters.AddWithValue("@DataReceb", mDataReceb)
                .Parameters.AddWithValue("@ValorReceb", mValorReceb)
                .Parameters.AddWithValue("@Status_Pag", mStatus_Pag)
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
    Public Sub SelecionaReceb(ByVal C As Integer)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                Select Case C
                    Case 0
                        .CommandText = "SeleReceb"
                    Case 2
                        .CommandText = "SeleRecebCodVenda"
                        .Parameters.AddWithValue("@Cod_Venda", mCod_Venda)
                    Case 3
                        .CommandText = "SeleRecebFormaPag"
                        .Parameters.AddWithValue("@CodForma_Pag", mCodForma_Pag)
                    Case 4
                        .CommandText = "SeleRecebData"
                        .Parameters.AddWithValue("@Mes", mMes)
                        .Parameters.AddWithValue("@Ano", mAno)
                    Case 5
                        .CommandText = "SeleRecebStatus"
                        .Parameters.AddWithValue("@Status_Pag", mStatus_Pag)
                    Case 6
                        .CommandText = "SeleRecebValor"
                        .Parameters.AddWithValue("@Vmenor", mVmenor)
                        .Parameters.AddWithValue("@Vmaior", mVmaior)
                End Select
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            'Gere_Recebimento.DGReceb.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    Public Function SeleCodRecebimento()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SelecionaCodRecebimento"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@Cod_Venda", Cod_Venda)
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Return mr!CodigoRecebimento
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
        Return Nothing
    End Function
    Public Sub PagaRecebimento()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "PagaRecebimento"
                .Parameters.AddWithValue("@Cod_Receb", mCod_Receb)
                .Parameters.AddWithValue("@Cod_Venda", mCod_Venda)
                .Parameters.AddWithValue("@DataReceb", mDataReceb)
                .Parameters.AddWithValue("@ValorReceb", mValorReceb)
                .Parameters.AddWithValue("@Status_Pag", mStatus_Pag)
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
    Public Sub RecebimentoAtrasado()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "RecebimentoAtrasado"
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub ListaLembrete()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SeleRecebStatusLista"
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            'Menu_Principal_Gerente.DGRecebimento.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
End Class

