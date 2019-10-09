Imports System.Data.SqlClient
Public Class Cls_Compra
    Dim Cone As New cls_Conexao

    Private mCod_Compra As Integer
    Private mCod_Forne As Integer
    Private mVl_Compra As Double
    Private mData_Compra As Date
    Private mEstado As Char
    Private mQuantidade As Integer
    Private mValor_Unit As Integer
    Private mCod_Produto As Integer

    Public Property Cod_Compra() As Integer
        Get
            Return mCod_Compra
        End Get
        Set(ByVal value As Integer)
            mCod_Compra = value
        End Set
    End Property
    Public Property Cod_Forne() As Integer
        Get
            Return mCod_Forne
        End Get
        Set(ByVal value As Integer)
            mCod_Forne = value
        End Set
    End Property
    Public Property Vl_Compra() As Double
        Get
            Return mVl_Compra
        End Get
        Set(ByVal value As Double)
            mVl_Compra = value
        End Set
    End Property
    Public Property Data_Compra() As Date
        Get
            Return mData_Compra
        End Get
        Set(ByVal value As Date)
            mData_Compra = value
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
    Public Property Valor_Unit() As Integer
        Get
            Return mValor_Unit
        End Get
        Set(ByVal value As Integer)
            mValor_Unit = value
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

    Public Sub InsertCompra()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "IncluiCompra"
                .Parameters.AddWithValue("@Cod_Forne", mCod_Forne)
                .Parameters.AddWithValue("@Vl_Compra", mVl_Compra)
                .Parameters.AddWithValue("@Data_Compra", mData_Compra)
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

    Public Sub ComboForne()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Nome_Fantasia from Fornecedor"
                .CommandType = CommandType.Text
            End With
            Compras.CB_Fornecedor.Items.Clear()
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Compras.CB_Fornecedor.Items.Add(mr("Nome_Fantasia").ToString)
            End While

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub CalculaValordaCompra()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "CalculaValordaCompra"
                .Parameters.AddWithValue("@Cod_Compra", Compras.Cod_Compra.Text)
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                With Compras
                    .VL_Compra.Text = FormatCurrency(mr!ValorCompra)
                End With
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub CalculaValorCompra()
        Dim objForne As New ClsFornecedor
        With Compras
            ' If .DGListItem.RowCount > 0 Then
            CalculaValordaCompra()
            Cod_Compra = .Cod_Compra.Text
            Cod_Forne = objForne.GetForne(.CB_Fornecedor)
            Vl_Compra = .VL_Compra.Text
            Data_Compra = .DT_DataCompra.Value
            UpdateCompra()
            'Else
            '    .LblVlCompra.Text = 0
            'End If
            'Else
            '    .BtnAlteraEstoque.Enabled = True
        End With
    End Sub

    Public Sub UpdateCompra()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "AlteraCompra"
                .Parameters.AddWithValue("@Cod_Compra", mCod_Compra)
                .Parameters.AddWithValue("@Cod_Forne", mCod_Forne)
                .Parameters.AddWithValue("@Vl_Compra", mVl_Compra)
                .Parameters.AddWithValue("@Data_Compra", mData_Compra)
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

    'Public Sub Selectproduto()
    '    Try
    '        Cone.Conectar()
    '        With Cone.cmd
    '            .Connection = Cone.cnn
    '            .CommandText = "Select Descricao_Prod from Cad_Produto where COd_Marca='" & Compras.CB_Marca.SelectedIndex + 1 & "'"
    '            .CommandType = CommandType.Text
    '        End With
    '        Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
    '        While mr.Read
    '            Compras.CB_Cod_Prod.Items.Add(mr("Descricao_Prod").ToString)
    '        End While
    '    Catch ex As SqlException
    '        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        Cone.Desconectar()
    '    End Try
    'End Sub

End Class
