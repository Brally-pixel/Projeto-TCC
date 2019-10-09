Imports System.Data.SqlClient
Public Class Vendas
    Dim objVenda As New ClsVendas
    Dim objItemVenda As New ClsItem_Venda
    Dim objAut As New Cls_login
    'Dim objReceb As New ClsRecebimento
    'Dim objUTL As New ClsUTL
    Dim objEstoque As New Cls_Estoque
    Dim objCli As New ClsCliente
    Dim objFun As New ClsFuncionario
    Public Contr As Integer = 0
    Public Valor As Decimal = 0
    Public QuantidadeEstoque As Integer
    Public NomeProd As String
    Public Caract As String
    Public Unidade As String
    Public ValorRecebimento As Decimal
    Public CodProduto As Integer
    Dim Cone As New cls_Conexao

    Public Function CodVenda()
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "SelecionaCodVenda"
                .CommandType = CommandType.StoredProcedure
            End With
            Dim mr As SqlDataReader = Cone.cmd.ExecuteReader()
            While mr.Read
                Return mr!NumeroVenda
                objVenda.Cod_Venda = mr!NumeroVenda
            End While
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
        Return Nothing
    End Function
    
    Private Sub Cod_Barra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cod_Barra.KeyDown
        If e.KeyCode = 13 Then
            If Cod_Barra.Text <> "" Then
                objVenda.CodBarra = Cod_Barra.Text
                objVenda.SelecionaEstoqueProduto()
                objEstoque.SelecionaProd_EstoqueVenda(CodProduto, DGEstoque)
                DGEstoque.Focus()
            End If
        End If
    End Sub
    
    Private Sub Cod_Barra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cod_Barra.TextChanged

    End Sub
    Dim objFunci As New ClsFuncionario
    Private Sub ComboCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CB_Cliente.KeyDown
        If e.KeyCode = 13 And Contr = 0 Then
            Try
                Cod_Barra.Enabled = True
                Contr = 1
                With objVenda
                    .Cod_Cli = objVenda.GetCliente(CB_Cliente)
                    .Cod_Funci = objFunci.GetFuncionario(Menu_Principal_Gerente.Nome_Funcio.Text)
                    .Vl_Total_venda = 0
                    .InsertVenda()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cod_Barra.Focus()
            End Try
        End If
    End Sub

    Private Sub Vendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objVenda.ComboCliente(CB_Cliente, "A")
    End Sub

    Private Sub txtQtde_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQtde.KeyDown
        If e.KeyCode = 13 Then
            If txtQtde.Text <= DGEstoque.CurrentRow.Cells.Item(3).Value Then
                Try
                    With objItemVenda
                        .Cod_Venda = CodVenda()
                        .Cod_Item_Venda = .SeleCodItem_Venda + 1
                        .Cod_Prod = CodProduto
                        .Qtde_Item = txtQtde.Text
                        LblUnit.Text = FormatCurrency(DGEstoque.CurrentRow.Cells.Item(4).Value)
                        .Vl_Unitario_Item = LblUnit.Text
                        .Cod_Estoque = DGEstoque.CurrentRow.Cells.Item(0).Value
                        .Vl_Unitario_Item = DGEstoque.CurrentRow.Cells.Item(4).Value

                        .InsertItemVenda()

                        objVenda.ValorAdicional = .Qtde_Item * .Vl_Unitario_Item
                        objVenda.Cod_Venda = .Cod_Venda

                        objVenda.UpdateValorVenda()

                        objEstoque.cod_Estoque = .Cod_Estoque
                        objEstoque.Cod_Prod = .Cod_Prod
                        objEstoque.Estoque = .Qtde_Item
                        objEstoque.VendeEstoque()
                    End With
                    SubTotal.Text = FormatCurrency(objItemVenda.Vl_Unitario_Item * objItemVenda.Qtde_Item)
                    Valor += SubTotal.Text
                    Total.Text = FormatCurrency(Valor)

                    LstProd.Items.Add(CStr(NomeProd + "    " + DGEstoque.CurrentRow.Cells.Item(1).Value + "    " + DGEstoque.CurrentRow.Cells.Item(2).Value))
                    LstQtde.Items.Add(txtQtde.Text)
                    LstVlUnit.Items.Add(FormatCurrency(LblUnit.Text))
                    LstSTotal.Items.Add(FormatCurrency(SubTotal.Text))

                    Cod_Barra.Clear()
                    txtQtde.Text = 1
                    LblUnit.Text = FormatCurrency(0)
                    SubTotal.Text = FormatCurrency(0)

                    'SubTotal.Text = 0
                    Cod_Barra.Focus()
                    DGEstoque.DataSource = Nothing
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally

                End Try
            Else
                MsgBox("Não existem produtos suficientes no estoque.")
            End If
        End If
    End Sub

    Private Sub DGEstoque_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGEstoque.CellContentClick
        If DGEstoque.RowCount > 0 Then
            LblUnit.Text = FormatCurrency(DGEstoque.CurrentRow.Cells.Item(4).Value)
        Else
            LblUnit.Text = FormatCurrency(0)
        End If
    End Sub

    Private Sub txtQtde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtde.TextChanged
        If txtQtde.Text <> "" Then
            SubTotal.Text = FormatCurrency(CDbl(LblUnit.Text) * CInt(txtQtde.Text))
        Else
            SubTotal.Text = FormatCurrency(0)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Encerramento_Vendas.Show()
        Encerramento_Vendas.Valor_Total_Enc.Text = Total.Text
        Me.Close()
    End Sub
End Class











