Imports System.Data.SqlClient
Public Class ClsItem_Compra
    Private mCod_Item_Compra As Integer
    Private mCod_Compra As Integer
    Private mCOd_Fornec As Integer
    Private mCod_Estoque As Integer
    Private mSabor As String
    Private mDescri As String

    Private mUnidade As String

    Private mNome_Forne As String
    Private mVl_Unitario As Decimal
    Private mCod_Produto As Integer
    Private mQuantidade As Integer

    Dim Cone As New cls_Conexao
    Public Property Vl_Unitario() As Decimal
        Get
            Return mVl_Unitario
        End Get
        Set(ByVal value As Decimal)
            mVl_Unitario = value
        End Set
    End Property

    Public Property Nome_Forne() As String
        Get
            Return mNome_Forne
        End Get
        Set(ByVal value As String)
            mNome_Forne = value
        End Set
    End Property


    Public Property Unidade() As String
        Get
            Return mUnidade
        End Get
        Set(ByVal value As String)
            mUnidade = value
        End Set
    End Property


    Public Property Descri() As String
        Get
            Return mDescri
        End Get
        Set(ByVal value As String)
            mDescri = value
        End Set
    End Property


    Public Property Sabor() As String
        Get
            Return mSabor
        End Get
        Set(ByVal value As String)
            mSabor = value
        End Set
    End Property

    Public Property COd_Fornec() As Integer
        Get
            Return mCOd_Fornec
        End Get
        Set(ByVal value As Integer)
            mCOd_Fornec = value
        End Set
    End Property

    Public Property Quantidade() As Integer
        Get
            Return mQuantidade
        End Get
        Set(ByVal value As Integer)
            mQuantidade = value
        End Set
    End Property


    Public Property Cod_Produto() As Integer
        Get
            Return mCod_Produto
        End Get
        Set(ByVal value As Integer)
            mCod_Produto = value
        End Set
    End Property


    Public Property Cod_Item_Compra() As Integer
        Get
            Return mCod_Item_Compra
        End Get
        Set(ByVal value As Integer)
            mCod_Item_Compra = value
        End Set
    End Property
    Public Property Cod_Compra() As Integer
        Get
            Return mCod_Compra
        End Get
        Set(ByVal value As Integer)
            mCod_Compra = value
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

    Public Sub InsertItem_Compra()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "IncluiItem_Compra"
                .Parameters.AddWithValue("@Cod_Item_Compra", mCod_Item_Compra)
                .Parameters.AddWithValue("@Cod_Compra", mCod_Compra)
                .Parameters.AddWithValue("@Cod_Estoque", mCod_Estoque)
                .Parameters.AddWithValue("@Cod_Prod", mCod_Produto)
                .Parameters.AddWithValue("@Qtd_Prod", mQuantidade)
                .Parameters.AddWithValue("@Vl_Unitario", mVl_Unitario)
                .Parameters.AddWithValue("@Unidade", mUnidade)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Cadastrado!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub Mos_Cod_Cont()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Cod_Compra)  as 'Cod_Compra' from Compra "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            'Cod_Compra.Text = mr!Cod_Compra + 1
        End While
        'somente leitura - select

    End Sub
    Public Sub CompraEstoque()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "AumentaEstoque"
                .Parameters.AddWithValue("@Cod_Compra", mCod_Compra)
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

    Public Sub SelecionaItem_Compra()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Seleci_Cod_Item_Compra"
                .Parameters.AddWithValue("@Cod_Compra", mCod_Item_Compra)
                .CommandType = CommandType.StoredProcedure

            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Cod_Item_Compra = mr!CodigoItemCompra + 1
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()

        End Try
    End Sub


    Public Sub ComboProduto()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "GetProdutoFornecedor"
                .Parameters.AddWithValue("@Nome_Fantasia_Forne", Compras.CB_Fornecedor.SelectedItem)
                .CommandType = CommandType.StoredProcedure
            End With
            Item_compra.CB_Cod_Prod.Items.Clear()
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                If Item_compra.CB_Cod_Prod.Items.Count = 0 Then
                    Item_compra.CB_Cod_Prod.Items.Add(mr("Descricao_Prod").ToString)
                Else
                    Dim i As Integer = 0
                    For Each item In Item_compra.CB_Cod_Prod.Items

                        If item = mr!Descricao_Prod Then
                            i += 1

                        End If
                    Next
                    If i = 0 Then
                        Item_compra.CB_Cod_Prod.Items.Add(mr("Descricao_Prod").ToString)
                    Else
                        i = 0
                    End If
                End If
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub ComboUnidade()
        Item_compra.CB_Unidade.Items.Clear()
        Item_compra.CB_Unidade.Text = ""
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "GetUnidade"
                .Parameters.AddWithValue("@Nome_Fantasia_Forne", Nome_Forne)
                .Parameters.AddWithValue("@Descricao_Prod", Descri)
                .Parameters.AddWithValue("@Sabor", Sabor)
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read

                If Item_compra.CB_Unidade.Items.Count = 0 Then
                    
                    If mr!Unidade = "Pacote" Then
                        Item_compra.CB_Unidade.Items.Add("Pacote")
                    End If
                    If mr!Unidade = "Unidade" Then
                        Item_compra.CB_Unidade.Items.Add("Unidade")
                    End If
                    If mr!Unidade = "Gramas" Then
                        Item_compra.CB_Unidade.Items.Add("Gramas")
                    End If
                Else
                    Dim i As Integer = 0
                    Dim X As String = ""
                    
                    If mr!Unidade = "Pacote" Then
                        X = "Pacote"
                    End If
                    If mr!Unidade = "Unidade" Then
                        X = "Unidade"
                    End If
                    If mr!Unidade = "Gramas" Then
                        X = "Gramas"
                    End If
                    For Each item In Item_compra.CB_Unidade.Items
                        If item = X Then
                            i += 1
                        End If
                    Next
                    If i = 0 Then
                        If mr!Unidade = "L" Then
                            Item_compra.CB_Unidade.Items.Add("Litro")
                        End If
                        If mr!Unidade = "P" Then
                            Item_compra.CB_Unidade.Items.Add("Pacote")
                        End If
                        If mr!Unidade = "U" Then
                            Item_compra.CB_Unidade.Items.Add("Unidade")
                        End If
                        If mr!Unidade = "G" Then
                            Item_compra.CB_Unidade.Items.Add("Gramas")
                        End If
                    Else
                        i = 0
                    End If
                End If

            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Function SeleCodItemCompra()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SelecionaCodItemCompra"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@Cod_Compra", Cod_Compra)
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Return mr!CodigoItemCompra
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
        Return Nothing
    End Function

    Public Sub ComboCaract()
        Item_compra.CB_Carac.Items.Clear()
        Item_compra.CB_Unidade.Items.Clear()
        Item_compra.CB_Carac.Text = ""
        Item_compra.CB_Unidade.Text = ""
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "GetCaract"
                .Parameters.AddWithValue("@Nome_Fantasia_Forne", Nome_Forne)
                .Parameters.AddWithValue("@Descricao_Prod", Descri )
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                If Item_compra.CB_Carac.Items.Count = 0 Then
                    Item_compra.CB_Carac.Items.Add(mr!Sabor)
                Else
                    Dim i As Integer = 0
                    For Each item In Item_compra.CB_Carac.Items
                        If item = mr!Sabor Then
                            i += 1
                        End If
                    Next
                    If i = 0 Then
                        Item_compra.CB_Carac.Items.Add(mr!Sabor)
                    Else
                        i = 0
                    End If
                End If
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

End Class
