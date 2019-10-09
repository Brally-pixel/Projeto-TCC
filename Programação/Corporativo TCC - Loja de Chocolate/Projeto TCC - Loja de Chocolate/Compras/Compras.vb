Imports System.Data.SqlClient
Public Class Compras
    Public cn As New cls_Conexao
    Dim objCompra As New Cls_Compra
    Dim Cone As New cls_Conexao
    Dim objLimpar As New Cls_Limpar
    Public D As Integer = 0
    Dim objCompras As New Cls_Compra
    Dim objItem_Compra As New ClsItem_Compra

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
    End Sub

    Public Sub Mos_Cod_Compra()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection(" server=.; uid=sa; pwd=123456; database=Loja_Chocolicia")
        Dim mr As SqlDataReader
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select COUNT(Cod_Compra)  as 'CodigoCompra' from Compra "
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            Cod_Compra.Text = mr!CodigoCompra + 1
        End While
        ' somente leitura - select

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            With objCompra
                .Cod_Forne = CInt(CB_Fornecedor.SelectedIndex + 1)
                .Vl_Compra = VL_Compra.Text
                .Data_Compra = DT_DataCompra.Value

                .InsertCompra()
                MsgBox("Compra Cadastrada!")
                Item_compra.Show()
                objItem_Compra.ComboProduto()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
        End Try
    End Sub

   

    Private Sub Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCompras.ComboForne()
        Mos_Cod_Compra()
    End Sub

End Class