Imports System.Data.SqlClient

Public Class Item_compra
    Dim objCompras As New Cls_Compra
    Public objEst As New Cls_Estoque
    Dim objItemCompra As New ClsItem_Compra
    Dim Controle As Integer = 0

    Private Sub CB_Cod_Prod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Cod_Prod.SelectedIndexChanged
        objItemCompra.Nome_Forne = Compras.CB_Fornecedor.SelectedItem
        objItemCompra.Descri = CB_Cod_Prod.SelectedItem
        objItemCompra.ComboCaract()
       
    End Sub

    Private Sub CB_Carac_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Carac.SelectedIndexChanged
        objItemCompra.Sabor = CB_Carac.SelectedItem
        objItemCompra.ComboUnidade()
    End Sub
    Dim objProduto As New Cls_Produto
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            With objItemCompra

                .Cod_Item_Compra = .SeleCodItemCompra + 1
                objProduto.Carac_Prod = CB_Cod_Prod.SelectedItem
                .Cod_Produto = objProduto.SeleProdCod
                .Vl_Unitario = Valor_Unitario.Text
                If CB_Unidade.SelectedItem = "Pacote" Then
                    .Unidade = "Pacote"
                End If
                If CB_Unidade.SelectedItem = "Unidade" Then
                    .Unidade = "Unidade"
                End If
                If CB_Unidade.SelectedItem = "Gramas" Then
                    .Unidade = "Gramas"
                End If
                objEst.Descricao = CB_Carac.SelectedItem
                objEst.Unidade = .Unidade
                objEst.Cod_Prod = .Cod_Produto
                .Cod_Estoque = objEst.SelecionaEstoqueCodigo()
                objEst.cod_Estoque = .Cod_Estoque
                .Quantidade = Quantidade.Text
                objEst.cod_Estoque = .Cod_Estoque
                objEst.SeleEstoque()

                objItemCompra.SelecionaItem_Compra()

                .Cod_Compra = Compras.Cod_Compra.Text
                If CInt(objEst.QuantMax) < CInt(Quantidade.Text + CInt(objEst.QuantAtual)) Then
                    MsgBox("Estoque acima da capacidade, digite um valor menor ou igual a: " + (objEst.QuantMax - objEst.QuantAtual).ToString + ".")
                    Quantidade.Text = (objEst.QuantMax - objEst.QuantAtual)
                Else
                    If Controle = 0 Then
                        .InsertItem_Compra()

                        objCompras.CalculaValorCompra()
                        If MsgBox("Deseja Finalizar a Compra?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.No Then
                            Dim objLimpar As New Cls_Limpar
                            objLimpar.LimpaCampos(Me)
                        Else
                            .Cod_Compra = Compras.Cod_Compra.Text
                            objItemCompra.CompraEstoque()
                            Me.Close()
                        End If


                        'Else
                        '    .Cod_Item_Compra = Compras.DGListItem.CurrentRow.Cells.Item(0).Value
                        '    .Cod_Compra = Gere_Compra.TxtCodCompra.Text
                        '    .UpdateItemCompra()
                        '    .SelecionaItemCompraDG()
                        '    BtnSalvItemCompra.Enabled = False
                        '    BtnNovoItemCompra.Enabled = True
                        '    BtnAltItemCompra.Enabled = True
                        '    objCompra.CalculaValorCompra()
                        '    If Gere_Compra.Created = True Then
                        '        objItemCompra.SelecionaItemCompraDG()
                        '        Me.Close()
                        '    End If
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Controle = 0
        End Try
    End Sub

    Private Sub Item_compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class