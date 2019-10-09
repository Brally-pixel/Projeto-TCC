Imports System.Data.SqlClient

Public Class ClsVendas
    Dim Cone As New cls_Conexao

    Private mCod_Venda As Integer
    Private mCod_Cli As Integer
    Private mCod_Funci As Integer
    Private mData_Venda As Date
    Private mVl_Total_venda As Decimal
    Private mEstado As Char
    Private mCodBarra As String
    Private mValorAdicional As Decimal
    Private mVmaior As Decimal
    Private mVmenor As Decimal
    Private mMes As Integer
    Private mAno As Integer
    Public Property Cod_Venda() As Integer
        Get
            Return mCod_Venda
        End Get
        Set(ByVal value As Integer)
            mCod_Venda = value
        End Set
    End Property
    Public Property Cod_Cli() As Integer
        Get
            Return mCod_Cli
        End Get
        Set(ByVal value As Integer)
            mCod_Cli = value
        End Set
    End Property
    Public Property Cod_Funci() As Integer
        Get
            Return mCod_Funci
        End Get
        Set(ByVal value As Integer)
            mCod_Funci = value
        End Set
    End Property
    Public Property Data_Venda() As Date
        Get
            Return mData_Venda
        End Get
        Set(ByVal value As Date)
            mData_Venda = value
        End Set
    End Property
    Public Property Vl_Total_venda() As Decimal
        Get
            Return mVl_Total_venda
        End Get
        Set(ByVal value As Decimal)
            mVl_Total_venda = value
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
    Public Property CodBarra() As String
        Get
            Return mCodBarra
        End Get
        Set(ByVal value As String)
            mCodBarra = value
        End Set
    End Property
    Public Property ValorAdicional() As Decimal
        Get
            Return mValorAdicional
        End Get
        Set(ByVal value As Decimal)
            mValorAdicional = value
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
    'ABRE A VENDA

    Public Function GetCliente(ByVal Combo As ComboBox)
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Codigo_do_Cliente from Cadastro_Cliente where Nome = '" & Combo.SelectedItem & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Cod_Cli = mr!Codigo_do_Cliente
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
        Return Cod_Cli
    End Function

    Public Sub InsertVenda()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "IncluiVenda"
                .Parameters.AddWithValue("@Cod_Cli", mCod_Cli)
                .Parameters.AddWithValue("@Cod_Funci", mCod_Funci)
                .Parameters.AddWithValue("@Vl_Total_Venda", mVl_Total_venda)
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
    'ATUALIZA A VENDA QUANDO ELA TERMINA, ARRUMANDO O VALOR TOTAL O FUCIONÁRIO CONECTADO NO MOMENTOO CLIENTE (SEJA ELE O CLIENTE PADRÃO DE CÓDIGO 000, OU OUTRO CLIENTE)
    Public Sub AtualizaVenda()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "IncluiVenda"
                .Parameters.AddWithValue("@Cod_Cli", mCod_Cli)
                .Parameters.AddWithValue("@Cod_Funci", mCod_Funci)
                .Parameters.AddWithValue("@Vl_Total_Venda", mVl_Total_venda)
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
    'ATUALIZA O CLIENTE (SEJA ELE O CLIENTE PADRÃO DE CÓDIGO 000, OU OUTRO CLIENTE) D NOVO ._. <-Ta redundante, mas n vou arrumar agr e.e
    Public Sub UpdateClienteVenda()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "AtualizaCliVenda"
                .Parameters.AddWithValue("@Cod_Venda", mCod_Venda)
                .Parameters.AddWithValue("@Cod_Cli", mCod_Cli)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    'MOSTRA A VENDA NO DATAGRID DE SELEÇÃO DE VENDA, NDA A VER COM A VENDA EM SÍ, É SÓ UMA LISTAGEM
    Public Sub SelecionaVenda(ByVal C As Integer, ByVal Estado As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                Select Case C
                    Case 0
                        .CommandText = "SeleVenda"
                    Case 1
                        .CommandText = "SeleVendaCod"
                        .Parameters.AddWithValue("@Cod_Venda", mCod_Venda)
                    Case 2
                        .CommandText = "SeleVendaValor"
                        .Parameters.AddWithValue("@Vmenor", mVmenor)
                        .Parameters.AddWithValue("@Vmaior", mVmaior)
                    Case 3
                        .CommandText = "SeleVendaData"
                        .Parameters.AddWithValue("@Mes", Mes)
                        .Parameters.AddWithValue("@Ano", Ano)
                    Case 4
                        .CommandText = "SeleVendaCli"
                        .Parameters.AddWithValue("@Cod_Cli", mCod_Cli)
                    Case 5
                        .CommandText = "SeleVendaFunci"
                        .Parameters.AddWithValue("@Cod_Funci", mCod_Funci)
                End Select
                .Parameters.AddWithValue("@Estado", Estado)
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            'List_Venda.DGVenda.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    'AQUI EU MOSTRO EM UM DATAGRID OS PRODUTOS QUE TEM EM ESTOQUE E Q O CÓDIGO DE BARRA É IGUAL AO LIDO PELA LEITORA,NESSE DATAGRID EU ESCOLHO QUAL PRODUTO EU QRO COMPRAR
    Public Sub SelecionaEstoqueProduto()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SeleProdCodBarra"
                .Parameters.AddWithValue("@CodBarra", CodBarra)
                .Parameters.AddWithValue("@Estado", "A")
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Vendas.CodProduto = mr("Código Produto").ToString
                Vendas.NomeProd = mr("Descrição do Produto").ToString
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub ComboCliente(ByVal Combo As ComboBox, ByVal Estado As String)
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Nome from Cadastro_Cliente where Status_Cli = '" & Estado & "'"
                .CommandType = CommandType.Text
            End With
            Combo.Items.Clear()
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Combo.Items.Add(mr("Nome").ToString)
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

    'ARRUMA O VALOR DA VENDA A CADA VEZ Q UM ITEM É ADICIONADO
    Public Sub UpdateValorVenda()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "AtualizaValorVenda"
                .Parameters.AddWithValue("@Cod_Venda", mCod_Venda)
                .Parameters.AddWithValue("@VlAdicional", mValorAdicional)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    'MEU ATIVAR OU DESATIVAR A VENDA, SÓ É USADO NA LISTAGEM, D NOVO NÃO É IMPORTANTE PRA VENDA EM SÍ
    Public Sub DesativaAtivaVenda(ByVal Estado As String)
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "DesativaAtivaVenda"
                .Parameters.AddWithValue("@Cod_Venda", mCod_Venda)
                .Parameters.AddWithValue("@Estado", Estado)
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
