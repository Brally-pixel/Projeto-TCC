Imports System.Data.SqlClient
Public Class ClsItem_Venda
    Dim Cone As New cls_Conexao
    Private mCod_Item_Venda As Integer
    Private mCod_Venda As Integer
    Private mCod_Prod As Integer
    Private mQtde_Item As Integer
    Private mVl_Unitario_Item As Decimal
    Private mCod_Estoque As Integer
    Private mEstado As Char
    Public Property Cod_Item_Venda() As Integer
        Get
            Return mCod_Item_Venda
        End Get
        Set(ByVal value As Integer)
            mCod_Item_Venda = value
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
    Public Property Cod_Prod() As Integer
        Get
            Return mCod_Prod
        End Get
        Set(ByVal value As Integer)
            mCod_Prod = value
        End Set
    End Property
    Public Property Qtde_Item() As Integer
        Get
            Return mQtde_Item
        End Get
        Set(ByVal value As Integer)
            mQtde_Item = value
        End Set
    End Property
    Public Property Vl_Unitario_Item() As Decimal
        Get
            Return mVl_Unitario_Item
        End Get
        Set(ByVal value As Decimal)
            mVl_Unitario_Item = value
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
    Public Property Cod_Estoque() As Integer
        Get
            Return mCod_Estoque
        End Get
        Set(ByVal value As Integer)
            mCod_Estoque = value
        End Set
    End Property
    Public Sub InsertItemVenda()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "IncluiItemVenda"
                .Parameters.AddWithValue("@Cod_Venda", mCod_Venda)
                .Parameters.AddWithValue("@Cod_Item_Venda", mCod_Item_Venda)
                .Parameters.AddWithValue("@Cod_Prod", mCod_Prod)
                .Parameters.AddWithValue("@Cod_Estoque", mCod_Estoque)
                .Parameters.AddWithValue("@Qtde_Item", mQtde_Item)
                .Parameters.AddWithValue("@Vl_Unitario_Item", mVl_Unitario_Item)
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
    Public Function Vl_Venda()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SelecionaVl_Venda"
                .Parameters.AddWithValue("@Cod_Prod", Cod_Prod)
                .Parameters.AddWithValue("@Cod_Estoque", Cod_Estoque)
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Return mr!Vl_Venda_Prod
                'objItemVenda.Vl_Unitario_Item = mr!Vl_Venda_Prod
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
        Return Nothing
    End Function
    Public Function SeleCodItem_Venda()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SelecionaCodItemVenda"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@Cod_Venda", Cod_Venda)
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Return mr!CodigoItemVenda
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
        Return Nothing
    End Function
    Public Sub SelecionaItem_Venda(ByVal C As Integer, ByVal Estado As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                Select Case C
                    Case 0
                        .CommandText = "SeleItem_Venda"
                        .Parameters.AddWithValue("Cod_Venda", mCod_Venda)
                End Select
                .Parameters.AddWithValue("@Estado", Estado)
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            'List_Venda.DGItem.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
End Class

