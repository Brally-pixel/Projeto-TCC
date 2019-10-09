Imports System.Data.SqlClient
Public Class Listar_Estoque
    Dim cone As New cls_Conexao
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Compra.CellContentClick

    End Sub
    Dim m As Integer = 0
    Private Sub Btn_Listar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Listar.Click
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        'Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.Open()

        If M = 0 Then

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "Listar_Produto"

                .CommandType = CommandType.StoredProcedure

            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            da.Dispose()       '  libera recursos ou melhora a performance  
            DT_Produto.DataSource = dt        ' dt1 name do datagrid
            m = 1

            If DT_Produto.Rows.Count > 0 Then
                Sele_Estoque()
                Gere_Compras()
            End If
        End If
    End Sub
    Public Sub Sele_Estoque()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        'Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.Open()


        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "Sele_Estoque"
            .Parameters.AddWithValue("@Cod_Prod", DT_Produto.CurrentRow.Cells(0).Value)
            .CommandType = CommandType.StoredProcedure

        End With

        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        DG_Estoque.DataSource = dt        ' dt1 name do datagrid


    End Sub

    Public Sub Gere_Compras()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        'Dim mr As SqlDataReader
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        cn.Open()


        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "Sele_Compra"
            .Parameters.AddWithValue("@Cod_Prod", DT_Produto.CurrentRow.Cells(0).Value)
            .CommandType = CommandType.StoredProcedure

        End With

        da.SelectCommand = cmd
        da.Fill(dt)
        da.Dispose()       '  libera recursos ou melhora a performance  
        DG_Compra.DataSource = dt        ' dt1 name do datagrid


    End Sub



    Dim Objest As New Cls_Estoque

    'Private Sub DT1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DT_Produto.SelectionChanged
    '    Objest.SelecionaProd_Estoque(DT_Produto.CurrentRow.Cells.Item(0).Value, DG_Estoque)
    '    If DG_Estoque.RowCount <> 0 Then
    '        Objest.SelecionaProd_Estoque(DG_Estoque.CurrentRow.Cells(0).Value, DG_Compra.CurrentRow.Cells.Item(0).Value)
    '    Else
    '        DT_Produto.Columns.Clear()
    '    End If
    'End Sub

    'Private Sub DG_Estoque_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Estoque.CellContentClick

    'End Sub

    'Private Sub DG_Estoque_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DG_Estoque.SelectionChanged
    '    If DG_Estoque.RowCount <> 0 Then
    '        ' Objest.Sele_Estoque(DG_Estoque.CurrentRow.Cells(0).Value, DT_Produto.CurrentRow.Cells.Item(0).Value, DGFornecedor)
    '    End If
    'End Sub

    Private Sub Btn_Limpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Limpar.Click
        Dim dt As DataTable
        dt = DT_Produto.DataSource And DG_Compra.DataSource And DG_Estoque.DataSource
        dt.Rows.Clear()

    End Sub




    Private Sub Estoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descricao.TextChanged
        Try
            With Objest
                .Descricao = Descricao.Text
            End With
            Objest.SelecionaProd(0, "A")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cone.Desconectar()
            cone.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Cod_Prod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cod_Prod.TextChanged
        Try
            With Objest
                .Cod_Prod = Cod_Prod.Text
            End With
            Objest.SelecionaProd(1, "A")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cone.Desconectar()
            cone.cmd.Parameters.Clear()
        End Try
    End Sub
    Private Sub DT_Produto_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DT_Produto.SelectionChanged
        If DT_Produto.Rows.Count > 0 Then
            Sele_Estoque()
            Gere_Compras()
        End If
    End Sub
    Dim objBlo_Des As New Cls_Blo_Des
    Private Sub Btn_Alterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Alterar.Click
        Controle_Estoque.D = 1

        Controle_Estoque.Show()
        Controle_Estoque.codigo_Produto.Text = CInt(DG_Estoque.CurrentRow.Cells(0).Value)

        'Cadastro_Cliente.BtnNovo.Enabled = False
        'Cadastro_Cliente.BtnLimpar.Enabled = False
        'Cadastro_Cliente.Cadastrar_Cli.Enabled = False
        'Cadastro_Cliente.Alterar_Cli.Enabled = True

        Me.Close()
    End Sub
End Class