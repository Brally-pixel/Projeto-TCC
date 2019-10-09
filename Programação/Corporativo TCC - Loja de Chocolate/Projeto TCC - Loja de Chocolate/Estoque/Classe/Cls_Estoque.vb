Imports System.Data.SqlClient
Public Class Cls_Estoque


    Private mProduto As String
    Private mUnidade As String
    Private mQuantMax As String
    Private mQuantMin As String
    Private mDescricao As String
    Private mValorVenda As Decimal
    Private mQuantAtual As String
    Private mMarca As String
    Private mcod_Estoque As Integer

    Dim Cone As New cls_Conexao

    Public Property Produto() As String
        Get
            Return mProduto
        End Get
        Set(ByVal value As String)
            mProduto = value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return mMarca
        End Get
        Set(ByVal value As String)
            mMarca = value
        End Set
    End Property
    '------------------------------------------------------------
    Public Property Unidade() As String
        Get
            Return mUnidade
        End Get
        Set(ByVal value As String)
            mUnidade = value
        End Set
    End Property


    Public Property QuantMax() As String
        Get
            Return mQuantMax
        End Get
        Set(ByVal value As String)
            mQuantMax = value
        End Set
    End Property
    Public Property QuantMin() As String
        Get
            Return mQuantMin
        End Get
        Set(ByVal value As String)
            mQuantMin = value
        End Set
    End Property
    Public Property Descricao() As String
        Get
            Return mDescricao
        End Get
        Set(ByVal value As String)
            mDescricao = value
        End Set
    End Property
    Public Property QuantAtual() As String
        Get
            Return mQuantAtual
        End Get
        Set(ByVal value As String)
            mQuantAtual = value
        End Set
    End Property
    Public Property ValorVenda() As Decimal
        Get
            Return mValorVenda
        End Get
        Set(ByVal value As Decimal)
            mValorVenda = value
        End Set
    End Property

    Public Property cod_Estoque() As Integer
        Get
            Return mcod_Estoque
        End Get
        Set(ByVal value As Integer)
            mcod_Estoque = value
        End Set
    End Property

    Dim mCod_Prod As Integer
    Public Property Cod_Prod() As Integer
        Get
            Return mCod_Prod
        End Get
        Set(ByVal value As Integer)
            mCod_Prod = value
        End Set
    End Property
    Dim mEstoque As Integer
    Public Property Estoque() As Integer
        Get
            Return mEstoque
        End Get
        Set(ByVal value As Integer)
            mEstoque = value
        End Set
    End Property

    Dim mCod_Forn As Integer
    Public Property Cod_Forn() As Integer
        Get
            Return mCod_Forn
        End Get
        Set(ByVal value As Integer)
            mCod_Forn = value
        End Set
    End Property

    Public Sub InsertEstoque()
        Try
            Cone.Conectar()
            Cone.cmd.Parameters.Clear()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Insert_Estoque"
                .Parameters.AddWithValue("@Cod_Prod", mCod_Prod)
                .Parameters.AddWithValue("@Cod_Estoque", mcod_Estoque)
                .Parameters.AddWithValue("@Estoque_Max", mQuantMax)
                .Parameters.AddWithValue("@Estoque_Min", mQuantMin)
                .Parameters.AddWithValue("@Sabor", mDescricao)
                .Parameters.AddWithValue("@Unidade", mUnidade)
                .Parameters.AddWithValue("@Vl_Venda_Prod", mValorVenda)
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

    Public Sub InsertEstoque_For()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Cadas_Estoque_For"
                .Parameters.AddWithValue("@CodEstoque", mcod_Estoque)
                .Parameters.AddWithValue("@Cod_Fornecedor", mCod_Forn)
                .Parameters.AddWithValue("@Cod_Produto", mCod_Prod)
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

    Public Sub SelecionaEstoque_Fornec()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Seleci_Cod_Estoque"
                .Parameters.AddWithValue("@Cod_Produto", mCod_Prod)
                .CommandType = CommandType.StoredProcedure

            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                cod_Estoque = mr!CodigoEstoque + 1
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()

        End Try
    End Sub

    Public Function SelecionaEstoqueCodigo()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SelecionaEstoqueCod"
                .Parameters.AddWithValue("@Cod_Prod", mCod_Prod)
                .Parameters.AddWithValue("@Caract", mDescricao)
                .Parameters.AddWithValue("@Unidade", mUnidade)
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Return mr!Cod_Estoque
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
        Return Nothing
    End Function
    
    Public Sub SeleEstoque()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SeleEstoque_Cod"
                .Parameters.AddWithValue("@Cod_Prod", mCod_Prod)
                .Parameters.AddWithValue("@Cod_Estoque", mCod_Estoque)
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Item_compra.objEst.QuantMax = mr!Estoque_Max
                Item_compra.objEst.QuantAtual = mr!Estoque_Atual
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub


    
    
    Public Sub VendeEstoque()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "DiminuiEstoque"
                .Parameters.AddWithValue("@Cod_Estoque", mCod_Estoque)
                .Parameters.AddWithValue("@Cod_Prod", mCod_Prod)
                .Parameters.AddWithValue("@Estoque", mEstoque)
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

    Public Sub SelecionaProd_EstoqueVenda(ByVal CodProd As String, ByVal DG As DataGridView)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SeleProd_EstoqueVenda"
                .Parameters.AddWithValue("@Cod_Prod", CodProd)
                .Parameters.AddWithValue("@Estado", "A")
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            DG.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub ComboFornecedor()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Nome_Fantasia from Fornecedor"
                .CommandType = CommandType.Text
            End With
            Controle_Estoque.CB_Fornecedor.Items.Clear()
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Controle_Estoque.CB_Fornecedor.Items.Add(mr("Nome_Fantasia").ToString)
            End While

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub SelecionaProd()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Descricao_Prod from Cad_Produto"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Controle_Estoque.CB_Produto.Items.Add(mr("Descricao_Prod").ToString)
                Controle_Estoque.ComboBox1.Items.Add(mr("Descricao_Prod").ToString)
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub GetCod_Prod(ByVal Combobox As ComboBox)
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Cod_Produto from Cad_Produto where Descricao_Prod = '" & Combobox.SelectedItem & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                mCod_Prod = mr!Cod_Produto
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub


    Public Sub GetCod_Forn(ByVal Combobox As ComboBox)
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Cod_Empresa from Fornecedor where Nome_Fantasia = '" & Combobox.SelectedItem & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                mCod_Forn = mr!Cod_Empresa
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub Sele_CodEstoque_Data(ByVal DG As DataGridView)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Mostrar_Data"
                .Parameters.AddWithValue("@Cod_Prod", mCod_Prod)
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            DG.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub SelecionaProd_Estoque(ByVal CodProd As String, ByVal DG As DataGridView)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Listar_Produto"
                .Parameters.AddWithValue("@Cod_Prod", mCod_Prod)
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            DG.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub SelecionaProd(ByVal C As Integer, ByVal Estado As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            cone.Conectar()
            With cone.cmd
                .Connection = cone.cnn
                Select Case C
                    Case 0
                        .CommandText = "Listar_Produto_Descri"
                        .Parameters.AddWithValue("@Descricao_Prod", mDescricao)
                    Case 1
                        .CommandText = "Listar_Produto_Codigo"
                        .Parameters.AddWithValue("@Cod_Produto", mCod_Prod)
                End Select
                .CommandType = CommandType.StoredProcedure

            End With
            da.SelectCommand = cone.cmd
            da.Fill(dt)
            da.Dispose()
            Listar_Estoque.DT_Produto.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cone.cmd.Parameters.Clear()
            cone.Desconectar()
        End Try
    End Sub

    Public Sub SelecionaEstCampos()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        'GetCidade(Cadastro_Cliente.CB_Cidade)
        Try
            'Cone.Conectar()
            Using conn As New SqlConnection("Server=.;database=Loja_Chocolicia;uid=sa;pwd=123456")
                Dim command As SqlCommand = New SqlCommand

                With command
                    .Connection = conn
                    .CommandText = "Sele_EstoqueCampos"
                    .Parameters.AddWithValue("@Cod_Prod", Controle_Estoque.codigo_Produto.Text)
                    .CommandType = CommandType.StoredProcedure
                End With
                conn.Open()
                Dim mr As SqlDataReader = command.ExecuteReader()
                While mr.Read

                    With Controle_Estoque
                        .QuantMax.Text = mr!Estoque_Max

                        .QuantMin.Text = mr!Estoque_Min

                        .Descri.Text = mr!Sabor
                        .Valor_Venda.Text = mr!Vl_Venda_Prod

                        For Each o As Object In .CB_Produto.Items
                            If o.ToString() = mr!Cod_Prod Then
                                .CB_Produto.SelectedItem = o
                            End If
                        Next

                        For Each o As Object In .CB_Unidade.Items
                            If o.ToString() = mr!Unidade Then
                                .CB_Unidade.SelectedItem = o
                            End If
                        Next

                        

                        'Cadastro_Cliente.Cadastrar_Cli.Enabled = False
                        'Cadastro_Cliente.BtnNovo.Enabled = False
                        'Cadastro_Cliente.BtnLimpar.Enabled = False
                        'Cadastro_Cliente.Alterar_Cli.Enabled = True

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

    Public Sub UpdateEst()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Update_Estoque"
                .Parameters.AddWithValue("@Cod_Estoque", mcod_Estoque)
                .Parameters.AddWithValue("@Estoque_Max", mQuantMax)
                .Parameters.AddWithValue("@Estoque_Min", mQuantMin)
                .Parameters.AddWithValue("@Sabor", mDescricao)
                .Parameters.AddWithValue("@Unidade", mUnidade)
                .Parameters.AddWithValue("@Vl_Venda_Prod", mValorVenda)
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

    Public Function GetCidade(ByVal Combo As ComboBox)
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Cod_Produto from Estoque where Descicao_Prod='" & Combo.Text & "'"
                .CommandType = CommandType.Text
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Produto = mr!Cod_Produto
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
        Return Produto
    End Function
End Class


