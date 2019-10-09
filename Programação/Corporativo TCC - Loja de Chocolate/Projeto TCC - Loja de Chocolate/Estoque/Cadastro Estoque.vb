Imports System.Data.SqlClient
Public Class Controle_Estoque
    Dim objEst As New Cls_Estoque
    Dim objLimpar As New Cls_Limpar
    Dim objBlo_Des As New Cls_Blo_Des
    Public cn As New cls_Conexao
    Dim Cone As New cls_Conexao
    Public cod_Prod As Integer
    Public D As Integer = 0

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCadastrar.Click
        Try
            With objEst

                If QuantMax.Text = "0" Or QuantMax.Text = "" Then
                    MsgBox("Campo inválido")
                    QuantMax.Select()
                ElseIf QuantMin.Text = "0" Or QuantMin.Text = "" Then
                    MsgBox("Campo inválido")
                    QuantMin.Select()


                ElseIf Descri.Text = "" Or Descri.Text = "" Then
                    MsgBox("Campo inválido")
                    Descri.Select()

                ElseIf CB_Produto.SelectedItem = "" Then
                    MsgBox("Campo inválido")
                    CB_Produto.Select()

                ElseIf CB_Unidade.SelectedItem = "" Then
                    MsgBox("Campo inválido")
                    CB_Unidade.Select()

                End If

                .Descricao = Descri.Text
                .QuantMax = QuantMax.Text
                .QuantMin = QuantMin.Text
                .Produto = CInt(CB_Produto.SelectedIndex + 1)
                .Unidade = CB_Unidade.SelectedItem
                .ValorVenda = CDbl(Valor_Venda.Text.ToString)

                objEst.Cod_Prod = objEst.Produto
                objEst.SelecionaEstoque_Fornec()

                If QuantMax.Text > QuantMin.Text Then
                    .InsertEstoque()
                Else
                    MsgBox("Quantidade Maxima deve ser maior que a Quantidade Minima")
                End If

                MsgBox("Estoque Cadastrado!")
                objLimpar.LimpaCampos(Me)

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub Controle_Estoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        objEst.SelecionaProd()
        objEst.ComboFornecedor()
        ' objEst.MostrarQuantAtual()
    End Sub

    Public Sub Selecionarproduto()
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Try
            Cone.Conectar()
            With Cone.cmd
                .Connection = Cone.cnn
                .CommandText = "Select Cod_Produto,Descricao_Prod from Cad_Produto"
                .CommandType = CommandType.Text
            End With
            da.SelectCommand = Cone.cmd
            da.Fill(dt)
            da.Dispose()
            DG.DataSource = dt
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cone.Desconectar()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cadastro_Forn.Click
        Try
            With objEst
                .cod_Estoque = Val(DG.CurrentRow.Cells(1).Value)
                .Cod_Prod = Val(DG.CurrentRow.Cells(0).Value)
                objEst.GetCod_Forn(CB_Fornecedor)
                'objEst.SelecionaEstoque_Fornec()


                .InsertEstoque_For()

                MsgBox("Produto Cadastrado no Fornecedor!")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub DG_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellContentClick

    End Sub

    Private Sub DG_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG.CellContentDoubleClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        objEst.GetCod_Prod(ComboBox1)
        objEst.Sele_CodEstoque_Data(DG)
    End Sub

    Private Sub CB_Fornecedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Fornecedor.SelectedIndexChanged

    End Sub

    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sair.Click
        Dim dt As DataTable
        dt = DG.DataSource
        dt.Rows.Clear()

        Dim objLimpar As New Cls_Limpar
        objLimpar.LimpaCampos(Me)
    End Sub

    Private Sub BtnAterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAterar.Click

        Try
            With objEst
                .Produto = objEst.GetCidade(CB_Produto)
                .Unidade = CB_Unidade.SelectedText
                .QuantMax = QuantMax.Text()

                .QuantMin = QuantMin.Text

                .Descricao = Descri.Text
                .ValorVenda = Valor_Venda.Text

                .UpdateEst()
                MsgBox("Registro Atualizado!")
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cn.Desconectar()
            cn.cmd.Parameters.Clear()
        End Try
    End Sub

    Private Sub codigo_Produto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles codigo_Produto.TextChanged
        objEst.SelecionaEstCampos()

    End Sub
End Class