Imports System.Data.SqlClient
Public Class Cls_Produto
    Dim Cone As New cls_Conexao
    Private mCarac_Prod As String
    Private mCod_Forn As Integer
    Private mNome_Marca As String
    Private mCod_Prod As Integer
    Private mCod_Marca As Integer

    Public Property Cod_Prod() As Integer
        Get
            Return mCod_Prod
        End Get
        Set(ByVal value As Integer)
            mCod_Prod = value
        End Set
    End Property

    Public Property Cod_Marca() As Integer
        Get
            Return mCod_Marca
        End Get
        Set(ByVal value As Integer)
            mCod_Marca = value
        End Set
    End Property

    Public Property Carac_Prod() As String
        Get
            Return mCarac_Prod
        End Get
        Set(ByVal value As String)
            mCarac_Prod = value
        End Set
    End Property
    Public Property Cod_Forn() As Integer
        Get
            Return mCod_Forn
        End Get
        Set(ByVal value As Integer)
            mCod_Forn = value
        End Set
    End Property

    Public Property Nome_Marca() As String
        Get
            Return mNome_Marca
        End Get
        Set(ByVal value As String)
            mNome_Marca = value
        End Set
    End Property
    Dim mCod_Barra As String
    Public Property Cod_Barra() As String
        Get
            Return mCod_Barra
        End Get
        Set(ByVal value As String)
            mCod_Barra = value
        End Set
    End Property


    Public Sub InsertProd()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "IncluiProduto"
                .Parameters.AddWithValue("@Descricao_Prod", mCarac_Prod)
                .Parameters.AddWithValue("@COd_Marca", mNome_Marca)
                .Parameters.AddWithValue("@Cod_Barra", mCod_Barra)

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
    Public Sub InsertMarca()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SP_Insert_Marca"
                .Parameters.AddWithValue("@Nome_Marca", mNome_Marca)
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

    Public Sub ComboMarca()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Nome_Marca from Marca"
                .CommandType = CommandType.Text
            End With
            Cadastrar_o_Produto.CB_Marca.Items.Clear()
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Cadastrar_o_Produto.CB_Marca.Items.Add(mr("Nome_Marca").ToString)
            End While

        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub Cod_Marca_()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Cod_Marca)  as 'Cod_Marca' from Marca "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Cadastrar_o_Produto.Codigo_marca.Text = mr!Cod_Marca + 1
        End While
        ' somente leitura - select
    End Sub

    Public Sub Cod_Produto()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Cod_Produto)  as 'Cod_Produto' from Cad_Produto "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Cadastrar_o_Produto.Codigo_Produto.Text = mr!Cod_Produto + 1
        End While
        ' somente leitura - select
    End Sub

    Public Sub SelecionaProd(ByVal C As Integer, ByVal Estado As String)
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                Select Case C
                    Case 0
                        .CommandText = "Listar_Produto_Nome"
                        .Parameters.AddWithValue("@Descricao_Prod", mCarac_Prod)
                    Case 1
                        .CommandText = "SeleProdCodBarra"
                        .Parameters.AddWithValue("@CodBarra", mCod_Barra)
                End Select
                .Parameters.AddWithValue("@Estado", Estado)
                .CommandType = CommandType.StoredProcedure
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            Cliente.dt1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub Desativa_Prod()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "DesativaProd"
                .Parameters.AddWithValue("@Cod_Produto", mCod_Prod)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Produto Desativado!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub Ativa_Prod()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "AtivaProd"
                .Parameters.AddWithValue("@Cod_Produto", mCod_Prod)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Produto Ativado!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Sub Desativa_Mar()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "DesativaMar"
                .Parameters.AddWithValue("@Cod_Marca", mCod_Marca)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Marca Desativado!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub
    Public Sub Ativa_Mar()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "AtivaMar"
                .Parameters.AddWithValue("@Cod_Marca", mCod_Marca)
                .CommandType = CommandType.StoredProcedure
                .ExecuteNonQuery()
            End With
            MsgBox("Marca Ativado!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
    End Sub

    Public Function SeleProdCod()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SelecionaProdCod"
                .Parameters.AddWithValue("@Descricao_Prod", mCarac_Prod)
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Return mr!Cod_Produto
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.cmd.Parameters.Clear()
            Cone.Desconectar()
        End Try
        Return Nothing
    End Function
End Class
